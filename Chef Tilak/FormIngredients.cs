using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chef_Tilak.DataClassses;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports;
using DevExpress.XtraSplashScreen;

namespace Chef_Tilak
{
    public partial class FormIngredients : DevExpress.XtraEditors.XtraForm
    {
        private ProjectSettings projectSettings;
        private ProjectData projectData;
        public List<Ingredient> Ingredients = new();

        public FormIngredients()
        {
            InitializeComponent();
        }

        public FormIngredients(ProjectSettings Projectsettings) : this()
        {
            this.projectSettings = Projectsettings;
            this.projectData = Projectsettings.ProjectData;

            InitDisplayData();
        }

        private void InitDisplayData()
        {

            foreach (Ingredient ingredient in projectData.BuyIngredientList)
            {
                Ingredients.Add(ingredient);
            }
            gcIngredients.DataSource = Ingredients;
            luUnitIngredient.DataSource = projectData.Units;

            luIngredientSupplier.DataSource = projectData.IngredientSupplier;

            gcPPUExc.Visible = projectData.Settings.ShowPricePPIngredientExc;
            gcPPUInc.Visible = projectData.Settings.ShowPricePPIngredientInc;
        }

        private void bbAddIngredient_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WzrdAddIngredient wzrdAddIngredient = new(projectData, Ingredients);
            wzrdAddIngredient.ShowDialog();
            gvIngredients.RefreshData();
        }

        private void bbRemoveIngredient_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Ingredient focusedIngredient = (Ingredient)gvIngredients.GetRow(gvIngredients.FocusedRowHandle);          

            if (focusedIngredient != null)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete:\r\n" + focusedIngredient.Name + "? \r\n\r\nIt will also be deleted from your recipes.", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Ingredients.Remove(focusedIngredient);
                    gvIngredients.RefreshData();
                }
            }
            else
            {
                MessageBox.Show("Please select an ingredient", "warning");
            }
        }

        private void gvIngredients_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            Ingredient changedIngredient = (Ingredient)gvIngredients.GetRow(gvIngredients.FocusedRowHandle);

            if (e.Column.Caption == "Price Exc" || e.Column.Caption == "Tax")
            {
                changedIngredient.BuyPriceInc = (1 + changedIngredient.Tax) * changedIngredient.BuyPriceExc;
                changedIngredient.BuyPriceInc = Math.Round(changedIngredient.BuyPriceInc, 2);
            }

            if (e.Column.Caption == "Price Inc")
            {
                changedIngredient.BuyPriceExc = (1 / (1 + changedIngredient.Tax)) * changedIngredient.BuyPriceInc;
                changedIngredient.BuyPriceExc = Math.Round(changedIngredient.BuyPriceExc, 2);
            }

            if (e.Column.Caption == "PP Unit Exc" || e.Column.Caption == "Tax")
            {
                changedIngredient.PricePerUnitInc = (1 + changedIngredient.Tax) * changedIngredient.PricePerUnitExc;
                changedIngredient.PricePerUnitInc = Math.Round(changedIngredient.PricePerUnitInc, 2);
            }

            if (e.Column.Caption == "PP Unit Inc")
            {
                changedIngredient.PricePerUnitExc = (1 / (1 + changedIngredient.Tax)) * changedIngredient.PricePerUnitInc;
                changedIngredient.PricePerUnitExc = Math.Round(changedIngredient.PricePerUnitExc, 2);
            }              

            changedIngredient.updateBuyPPU();
            gvIngredients.RefreshData();
        }

        private void disabledCellEvents1_ProcessingCell(object sender, DevExpress.Utils.Behaviors.Common.ProcessCellEventArgs e)
        {
            if (e.FieldName == "PricePerUnitExc" || e.FieldName == "PricePerUnitInc")
            {
                e.Disabled = true;
            }
        }


        public void Save()
        {
            projectData.BuyIngredientList = Ingredients;
            //Firstly all recipes get updated with the correct new production prices
            //Then this is also set in the sell products where the margins will be adjusted
            UpdateRecipes();
            UpdateProducts();
            projectSettings.SaveProject(projectSettings.ProjectSaveLocation);
        }

        public bool CheckData()
        {                  

            return true;
        }
        


        public void UpdateRecipes()
        {
            foreach (Recipe recipe in projectData.RecipeList.FindAll(x=>x.IsAlsoIngredient == true))
            {
                List<Ingredient> updatedIngredientList = new();

                foreach (Ingredient oldIngredient in recipe.RecipeIngredientList)
                {
                    //First replace the old ingredient with the new, if an ingredient has been removed it will also be removed from the recipe
                    if (projectData.BuyIngredientList.Find(x => x.Code.Equals(oldIngredient.Code)) != null)
                    {
                        Ingredient newIngredient = projectData.BuyIngredientList.Find(x => x.Code.Equals(oldIngredient.Code));
                        Ingredient updatedIngredient = new()
                        {
                            Code = oldIngredient.Code,
                            RecipeComment = oldIngredient.RecipeComment,
                            RecipeQuantity = oldIngredient.RecipeQuantity,
                            RecipeUnit = oldIngredient.RecipeUnit,

                            Name = newIngredient.Name,
                            Store = newIngredient.Store,
                            Tax = newIngredient.Tax,
                            BuyPriceInc = newIngredient.BuyPriceInc,
                            BuyPriceExc = newIngredient.BuyPriceExc,
                            BuyQuantity = newIngredient.BuyQuantity,
                            BuyUnit = newIngredient.BuyUnit,
                            PricePerUnitExc = newIngredient.PricePerUnitExc,
                            PricePerUnitInc = newIngredient.PricePerUnitInc,
                        };
                        updatedIngredient.updatePriceRecipe();
                        updatedIngredientList.Add(updatedIngredient);
                    }

                }
                recipe.RecipeIngredientList = updatedIngredientList;

                recipe.updatePricePerPackage(recipe.packagingList.Count());
                recipe.calculateTotalCostExc();
                recipe.calculateTotalCostInc();

            }

            foreach (Recipe recipe in projectData.RecipeList.FindAll(x => x.IsAlsoIngredient == false))
            {
                List<Ingredient> updatedIngredientList = new();

                foreach (Ingredient oldIngredient in recipe.RecipeIngredientList)
                {
                    //First replace the old ingredient with the new, if an ingredient has been removed it will also be removed from the recipe
                    if (projectData.BuyIngredientList.Find(x => x.Code.Equals(oldIngredient.Code)) != null)
                    {
                        Ingredient newIngredient = projectData.BuyIngredientList.Find(x => x.Code.Equals(oldIngredient.Code));
                        Ingredient updatedIngredient = new()
                        {
                            Code = oldIngredient.Code,
                            RecipeComment = oldIngredient.RecipeComment,
                            RecipeQuantity = oldIngredient.RecipeQuantity,
                            RecipeUnit = oldIngredient.RecipeUnit,

                            Name = newIngredient.Name,
                            Store = newIngredient.Store,
                            Tax = newIngredient.Tax,
                            BuyPriceInc = newIngredient.BuyPriceInc,
                            BuyPriceExc = newIngredient.BuyPriceExc,
                            BuyQuantity = newIngredient.BuyQuantity,
                            BuyUnit = newIngredient.BuyUnit,
                            PricePerUnitExc = newIngredient.PricePerUnitExc,
                            PricePerUnitInc = newIngredient.PricePerUnitInc,
                        };
                        updatedIngredient.updatePriceRecipe();
                        updatedIngredientList.Add(updatedIngredient);
                    }

                }
                recipe.RecipeIngredientList = updatedIngredientList;

                recipe.updatePricePerPackage(recipe.packagingList.Count());
                recipe.calculateTotalCostExc();
                recipe.calculateTotalCostInc();

            }
        }

        public void UpdateProducts()
        {
            foreach (Recipe recipe in projectData.RecipeList)
            {
                foreach (Packaging packaging in recipe.packagingList)
                {
                    SellProduct product = projectData.ProductList.Find(x => x.RecipeCode.Equals(recipe.Code) && x.PackagingCode.Equals(packaging.Code));
                    //If the combination of this recipe and packaging already exist update it
                    if (product != null)
                    {
                        product.Name = recipe.RecipeName + " (" + packaging.Name + ")";

                        product.ProductionCostExc = packaging.ProductionPriceExc;
                        product.ProductionCostInc = packaging.ProductionPriceInc;

                        if (product.SellPriceInc != 0)
                        {
                            product.MarginInc = (product.SellPriceInc - product.ProductionCostExc) / product.SellPriceInc;
                            product.ProfitInc = product.SellPriceInc - product.ProductionCostExc;
                        }



                    }
                }
            }
        }

        private void FormIngredients_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CheckData())
            {
                Save();

            }
            else
            {
                e.Cancel = true;
            }
        }

        private void bbUploadPDF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WzrdUploadPDF wzrdUploadPDF = new(projectData);
            wzrdUploadPDF.ShowDialog();
            gvIngredients.RefreshData();
        }
    }
}