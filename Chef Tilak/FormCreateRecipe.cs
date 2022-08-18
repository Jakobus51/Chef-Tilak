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
using DevExpress.XtraEditors;
using DevExpress.XtraReports;
using DevExpress.XtraBars;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraReports.UI;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraPrinting;
using System.IO;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid;
using DevExpress.Utils.DragDrop;

namespace Chef_Tilak
{
    public partial class FormCreateRecipe : DevExpress.XtraEditors.XtraForm
    {
        private ProjectSettings projectSettings;
        private ProjectData projectData;
        private Recipe recipe;
        private Recipe oldRecipe;
        private GridHitInfo downHitInfo = null;

        public FormCreateRecipe()
        {
            InitializeComponent();
        }



        public FormCreateRecipe(ProjectSettings projectSettings) : this()
        {

            this.projectSettings = projectSettings;
            this.projectData = projectSettings.ProjectData;

            recipe = new Recipe() { RecipeName = "New recipe", Code = Guid.NewGuid(), LastEdited = DateTime.Now.ToShortDateString(), RecipeUnit = "g" };

            teRecipeName.Text = recipe.RecipeName;
            teLastEdited.EditValue = recipe.LastEdited;
            rgRecipeUnit.EditValue = recipe.RecipeUnit;

            InitDisplayData();
        }

        public FormCreateRecipe(ProjectSettings projectSettings, Recipe Recipe) : this()
        {
            this.projectSettings = projectSettings;
            this.projectData = projectSettings.ProjectData;
            recipe = Recipe;

            InitDisplayData();


            teRecipeName.Text = recipe.RecipeName;
            teLastEdited.EditValue = recipe.LastEdited;
            luCategoryRecipe.EditValue = recipe.Category;
            rtbMethod.Text = recipe.Method;

            rgRecipeUnit.EditValue = recipe.RecipeUnit;
            ceAddToIngredients.EditValue = recipe.IsAlsoIngredient;

            rgNumberPackagings.EditValue = recipe.packagingList.Count();
            if (recipe.packagingList.Count() > 0)
            {
                //If the quantity is changed, the price exc and inc also get updated
                luPackaging1.EditValue = recipe.packagingList[0].Name;
                seQuantityPP1.EditValue = recipe.packagingList[0].RecipeQuantity;
                seNumberPackagings1.EditValue = recipe.packagingList[0].NumberOfPackagings;
                lcgPackaging1.Visibility = LayoutVisibility.Always;
            }
            if (recipe.packagingList.Count() > 1)
            {
                luPackaging2.EditValue = recipe.packagingList[1].Name;
                seQuantityPP2.EditValue = recipe.packagingList[1].RecipeQuantity;
                seNumberPackagings2.EditValue = recipe.packagingList[1].NumberOfPackagings;
                lcgPackaging2.Visibility = LayoutVisibility.Always;
            }
            if (recipe.packagingList.Count() > 2)
            {
                luPackaging3.EditValue = recipe.packagingList[2].Name;
                seQuantityPP3.EditValue = recipe.packagingList[2].RecipeQuantity;
                seNumberPackagings3.EditValue = recipe.packagingList[2].NumberOfPackagings;
                lcgPackaging3.Visibility = LayoutVisibility.Always;
            }

            seTotalQuantity.Value = recipe.TotalVolume;
            seQuantityRemaining.Value = calculateRemainingVolume();
        }

        private void InitDisplayData()
        {
            rgRecipeUnit.EditValue = "g";
            setVisibility("Ingredients");

            seTotalQuantity.Properties.EditMask = "##,###,##0 g";
            seQuantityRemaining.Properties.EditMask = "##,###,##0 g";
            seQuantityPP1.Properties.EditMask = "##,###,##0 g";
            seQuantityPP2.Properties.EditMask = "##,###,##0 g";
            seQuantityPP3.Properties.EditMask = "##,###,##0 g";

            sleSelectIngedient.Properties.DataSource = projectData.BuyIngredientList;
            sleSelectIngedient.Properties.DisplayMember = "Name";
            sleSelectIngedient.Properties.ValueMember = "Name";
            sleSelectIngedient.Properties.View.Columns.Clear();
            sleSelectIngedient.Properties.View.Columns.AddVisible("Name", "Name");
            sleSelectIngedient.Properties.View.Columns.AddVisible("Store", "Store");
            sleSelectIngedient.Properties.View.Columns.AddVisible("PricePerUnitExc", "Price per unit exc(€)");
            sleSelectIngedient.Properties.View.Columns.AddVisible("BuyUnit", "Unit");

            gcRecipeIngredients.DataSource = recipe.RecipeIngredientList;
            leRecipeUnit.DataSource = projectData.Units;

            luCategoryRecipe.Properties.DataSource = projectData.RecipesCategories;

            luPackaging1.Properties.DataSource = projectData.PackagingList;
            luPackaging1.Properties.DisplayMember = "Name";
            luPackaging1.Properties.ValueMember = "Name";
            luPackaging1.Properties.Columns.Clear();
            luPackaging1.Properties.Columns.Add(new LookUpColumnInfo("Name", 300, "Name"));
            luPackaging1.Properties.Columns.Add(new LookUpColumnInfo("Volume", 100, "Volume (mL)"));
            luPackaging1.Properties.Columns.Add(new LookUpColumnInfo("PriceExc", 100, "Price exc. (€)"));
            luPackaging1.Properties.Columns.Add(new LookUpColumnInfo("PriceInc", 100, "Price inc. (€)"));

            luPackaging2.Properties.DataSource = projectData.PackagingList;
            luPackaging2.Properties.DisplayMember = "Name";
            luPackaging2.Properties.ValueMember = "Name";
            luPackaging2.Properties.Columns.Clear();
            luPackaging2.Properties.Columns.Add(new LookUpColumnInfo("Name", 300, "Name"));
            luPackaging2.Properties.Columns.Add(new LookUpColumnInfo("Volume", 100, "Volume (mL)"));
            luPackaging2.Properties.Columns.Add(new LookUpColumnInfo("PriceExc", 100, "Price exc. (€)"));
            luPackaging2.Properties.Columns.Add(new LookUpColumnInfo("PriceInc", 100, "Price inc. (€)"));

            luPackaging3.Properties.DataSource = projectData.PackagingList;
            luPackaging3.Properties.DisplayMember = "Name";
            luPackaging3.Properties.ValueMember = "Name";
            luPackaging3.Properties.Columns.Clear();
            luPackaging3.Properties.Columns.Add(new LookUpColumnInfo("Name", 300, "Name"));
            luPackaging3.Properties.Columns.Add(new LookUpColumnInfo("Volume", 100, "Volume (mL)"));
            luPackaging3.Properties.Columns.Add(new LookUpColumnInfo("PriceExc", 100, "Price exc. (€)"));
            luPackaging3.Properties.Columns.Add(new LookUpColumnInfo("PriceInc", 100, "Price inc. (€)"));
            setVisibility("Ingredients");
        }
        private void rgRecipeUnit_EditValueChanged(object sender, EventArgs e)
        {
            if (rgRecipeUnit.EditValue.Equals("g"))
            {
                recipe.RecipeUnit = "g";
                seTotalQuantity.Properties.EditMask = "##,###,##0 g";
                seQuantityRemaining.Properties.EditMask = "##,###,##0 g";
                seQuantityPP1.Properties.EditMask = "##,###,##0 g";
                seQuantityPP2.Properties.EditMask = "##,###,##0 g";
                seQuantityPP3.Properties.EditMask = "##,###,##0 g";
            }
            if (rgRecipeUnit.EditValue.Equals("mL"))
            {
                recipe.RecipeUnit = "mL";
                seTotalQuantity.Properties.EditMask = "##,###,##0 mL";
                seQuantityRemaining.Properties.EditMask = "##,###,##0 mL";
                seQuantityPP1.Properties.EditMask = "##,###,##0 mL";
                seQuantityPP2.Properties.EditMask = "##,###,##0 mL";
                seQuantityPP3.Properties.EditMask = "##,###,##0 mL";

            }
        }


        private void bbSetIngredients_Click(object sender, EventArgs e)
        {
            setVisibility("Ingredients");
        }

        private void bbSetMethod_Click(object sender, EventArgs e)
        {
            setVisibility("Method");
        }

        private void bbSetPackagings_Click(object sender, EventArgs e)
        {
            setVisibility("Packagings");
        }

        private void sleSelectIngedient_EditValueChanged(object sender, EventArgs e)
        { 
            Ingredient ingredientAddedDataBase = projectData.BuyIngredientList.Find(x => x.Name.Equals(((SearchLookUpEdit)sender).EditValue));

            if (sleSelectIngedient.EditValue != null)
            {
                Ingredient ingredientAdded = new()
                {
                    Code = ingredientAddedDataBase.Code,
                    Name = ingredientAddedDataBase.Name,
                    BuyPriceInc = ingredientAddedDataBase.BuyPriceInc,
                    BuyPriceExc = ingredientAddedDataBase.BuyPriceExc,
                    BuyUnit = ingredientAddedDataBase.BuyUnit,
                    BuyQuantity = ingredientAddedDataBase.BuyQuantity,
                    Store = ingredientAddedDataBase.Store,
                    PricePerUnitInc = ingredientAddedDataBase.PricePerUnitInc,
                    PricePerUnitExc = ingredientAddedDataBase.PricePerUnitExc,
                    RecipeUnit = ingredientAddedDataBase.BuyUnit
                };
                recipe.RecipeIngredientList.Add(ingredientAdded);
                sleSelectIngedient.EditValue = null;
               
            }
            gvRecipeIngredients.RefreshData();

        }


        private void sbAddWhiteSpace_Click(object sender, EventArgs e)
        {

            //Add an empty ingredient, the guid is empty which we will use to seperate these ingredients with real ingredients
            Ingredient ingredientAdded = new()
            {

                Name = "",
                RecipeUnit = "",






            };

            recipe.RecipeIngredientList.Add(ingredientAdded);
            gvRecipeIngredients.RefreshData();

        }

        private void sbRemoveIngredient_Click(object sender, EventArgs e)
        {
            Ingredient focusedIngredient = (Ingredient)gvRecipeIngredients.GetRow(gvRecipeIngredients.FocusedRowHandle);
            recipe.RecipeIngredientList.Remove(focusedIngredient);
            gvRecipeIngredients.RefreshData();
        }


        private void gvRecipeIngredients_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            Ingredient changedIngredient = (Ingredient)gvRecipeIngredients.GetRow(gvRecipeIngredients.FocusedRowHandle);
            if (changedIngredient.Code != Guid.Empty)
            {
                changedIngredient.updatePriceRecipe();
                updateTotalQuantities();

                gvRecipeIngredients.RefreshData();
            }
            
        }

        private void disabledCellEvents1_ProcessingCell(object sender, DevExpress.Utils.Behaviors.Common.ProcessCellEventArgs e)
        {
        
            GridView view = e.Source as GridView;
            Guid guid = (Guid)(view.GetListSourceRowCellValue(e.RecordId, "Code"));

            if (guid == Guid.Empty)
            {
                if (e.FieldName == "RecipeQuantity" || e.FieldName == "RecipeUnit" || e.FieldName == "RecipeComment")
                {
                    e.Disabled = true;
                }
            }

            if (e.FieldName == "RecipePriceExc" || e.FieldName == "RecipePriceInc")
            {
                e.Disabled = true;
                
            }         


        }

        private void gvRecipeIngredients_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {         
            //Makes the display texts of the white space rows all non visible
            if (e.Column.FieldName == "RecipeQuantity" || e.Column.FieldName == "RecipePriceExc" || e.Column.FieldName == "RecipePriceInc")
            {
                Ingredient ingredient = gvRecipeIngredients.GetRow(e.ListSourceRowIndex) as Ingredient;
                if (ingredient.Code == Guid.Empty)
                {
                    e.DisplayText = "";
                }
            }
        }

        #region packagings


        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int)rgNumberPackagings.EditValue == 0)
            {
                lcgPackaging1.Visibility = LayoutVisibility.Never;
                lcgPackaging2.Visibility = LayoutVisibility.Never;
                lcgPackaging3.Visibility = LayoutVisibility.Never;

                luPackaging1.EditValue = null;
                luPackaging2.EditValue = null;
                luPackaging3.EditValue = null;


            }

            if ((int)rgNumberPackagings.EditValue == 1)
            {
                lcgPackaging1.Visibility = LayoutVisibility.Always;
                lcgPackaging2.Visibility = LayoutVisibility.Never;
                lcgPackaging3.Visibility = LayoutVisibility.Never;


                luPackaging2.EditValue = null;
                luPackaging3.EditValue = null;


            }
            if ((int)rgNumberPackagings.EditValue == 2)
            {
                lcgPackaging1.Visibility = LayoutVisibility.Always;
                lcgPackaging2.Visibility = LayoutVisibility.Always;
                lcgPackaging3.Visibility = LayoutVisibility.Never;

                luPackaging3.EditValue = null;
            }
            if ((int)rgNumberPackagings.EditValue == 3)
            {
                lcgPackaging1.Visibility = LayoutVisibility.Always;
                lcgPackaging2.Visibility = LayoutVisibility.Always;
                lcgPackaging3.Visibility = LayoutVisibility.Always;
            }

            calculatePricePP((int)rgNumberPackagings.EditValue);
        }

        private void updateTotalQuantities()
        {
            decimal totalquantity = 0M;
            foreach (Ingredient ingredient in recipe.RecipeIngredientList)
            {
                if (ingredient.Code != Guid.Empty)
                {
                    if (ingredient.RecipeUnit.Equals("Kg") || ingredient.RecipeUnit.Equals("L"))
                    {
                        totalquantity += ingredient.RecipeQuantity * 1000;
                    }
                    if (ingredient.RecipeUnit.Equals("g") || ingredient.RecipeUnit.Equals("mL"))
                    {
                        totalquantity += ingredient.RecipeQuantity;
                    }
                }
            }

            seTotalQuantity.Value = totalquantity;
        }

        private void luPackaging1_EditValueChanged(object sender, EventArgs e)
        {
            if (projectData.PackagingList.Find(x => x.Name.Equals(luPackaging1.EditValue)) != null)
            {
                seQuantityPP1.EditValue = projectData.PackagingList.Find(x => x.Name.Equals(luPackaging1.EditValue)).Volume;
            }
            else
            {
                seQuantityPP1.EditValue = 0;
                seNumberPackagings1.EditValue = 0;
            }
            calculatePricePP((int)rgNumberPackagings.EditValue);
        }

        private void luPackaging2_EditValueChanged(object sender, EventArgs e)
        {
            if (projectData.PackagingList.Find(x => x.Name.Equals(luPackaging2.EditValue)) != null)
            {
                seQuantityPP2.EditValue = projectData.PackagingList.Find(x => x.Name.Equals(luPackaging2.EditValue)).Volume;
            }
            else
            {
                seQuantityPP2.EditValue = 0;
                seNumberPackagings2.EditValue = 0;
            }
            calculatePricePP((int)rgNumberPackagings.EditValue);
        }

        private void luPackaging3_EditValueChanged(object sender, EventArgs e)
        {
            if (projectData.PackagingList.Find(x => x.Name.Equals(luPackaging3.EditValue)) != null)
            {
                seQuantityPP3.EditValue = projectData.PackagingList.Find(x => x.Name.Equals(luPackaging3.EditValue)).Volume;
            }
            else
            {
                seQuantityPP3.EditValue = 0;
                seNumberPackagings3.EditValue = 0;
            }
            calculatePricePP((int)rgNumberPackagings.EditValue);
        }

        private void updatePriceAndQuantity(object sender, EventArgs e)
        {
            seQuantityRemaining.Value = calculateRemainingVolume();
            calculatePricePP((int)rgNumberPackagings.EditValue);
        }


       

        public void calculatePricePP(int packagings)
        {
            recipe.calculateRecipeIngredientCostExc();
            recipe.calculateRecipeIngredientCostInc();

            if (packagings == 1 && seNumberPackagings1.Value != 0)
            {
                decimal pricePP1Exc = 0M;
                decimal pricePP1Inc = 0M;
                Packaging package1 = projectData.PackagingList.Find(x => x.Name.Equals(luPackaging1.EditValue));
                if (package1 != null)
                {
                    pricePP1Exc = package1.PriceExc + package1.AdditionalCostExc + (recipe.TotalIngredientCostExc / seNumberPackagings1.Value);
                    sePricePP1Exc.Value = pricePP1Exc;

                    pricePP1Inc = package1.PriceInc + package1.AdditionalCostInc + (recipe.TotalIngredientCostInc / seNumberPackagings1.Value);
                    sePricePP1Inc.Value = pricePP1Inc;
                }


            }

            if (packagings == 2 && seNumberPackagings1.Value != 0 && seNumberPackagings2.Value != 0)
            {
                decimal pricePP1Exc = 0M;
                decimal pricePP2Exc = 0M;
                decimal pricePP1Inc = 0M;
                decimal pricePP2Inc = 0M;

                Packaging package1 = projectData.PackagingList.Find(x => x.Name.Equals(luPackaging1.EditValue));
                Packaging package2 = projectData.PackagingList.Find(x => x.Name.Equals(luPackaging2.EditValue));

                if (package1 != null && package2 != null)
                {
                    pricePP1Exc = package1.PriceExc + package1.AdditionalCostExc + (recipe.TotalIngredientCostExc * ((seNumberPackagings1.Value * seQuantityPP1.Value) / ((seNumberPackagings1.Value * seQuantityPP1.Value) + (seNumberPackagings2.Value * seQuantityPP2.Value))) / seNumberPackagings1.Value);
                    pricePP2Exc = package2.PriceExc + package2.AdditionalCostExc + (recipe.TotalIngredientCostExc * ((seNumberPackagings2.Value * seQuantityPP2.Value) / ((seNumberPackagings1.Value * seQuantityPP1.Value) + (seNumberPackagings2.Value * seQuantityPP2.Value))) / seNumberPackagings2.Value);
                    sePricePP1Exc.Value = pricePP1Exc;
                    sePricePP2Exc.Value = pricePP2Exc;

                    pricePP1Inc = package1.PriceInc + package1.AdditionalCostInc + (recipe.TotalIngredientCostInc * ((seNumberPackagings1.Value * seQuantityPP1.Value) / ((seNumberPackagings1.Value * seQuantityPP1.Value) + (seNumberPackagings2.Value * seQuantityPP2.Value))) / seNumberPackagings1.Value);
                    pricePP2Inc = package2.PriceInc + package2.AdditionalCostInc + (recipe.TotalIngredientCostInc * ((seNumberPackagings2.Value * seQuantityPP2.Value) / ((seNumberPackagings1.Value * seQuantityPP1.Value) + (seNumberPackagings2.Value * seQuantityPP2.Value))) / seNumberPackagings2.Value);
                    sePricePP1Inc.Value = pricePP1Inc;
                    sePricePP2Inc.Value = pricePP2Inc;
                }

            }

            if (packagings == 3 && seNumberPackagings1.Value != 0 && seNumberPackagings2.Value != 0 && seNumberPackagings3.Value != 0)
            {
                decimal pricePP1Exc = 0M;
                decimal pricePP2Exc = 0M;
                decimal pricePP3Exc = 0M;

                decimal pricePP1Inc = 0M;
                decimal pricePP2Inc = 0M;
                decimal pricePP3Inc = 0M;

                Packaging package1 = projectData.PackagingList.Find(x => x.Name.Equals(luPackaging1.EditValue));
                Packaging package2 = projectData.PackagingList.Find(x => x.Name.Equals(luPackaging2.EditValue));
                Packaging package3 = projectData.PackagingList.Find(x => x.Name.Equals(luPackaging3.EditValue));

                if (package1 != null && package2 != null && package3 != null)
                {
                    pricePP1Exc = package1.PriceExc + package1.AdditionalCostExc + (recipe.TotalIngredientCostExc * ((seNumberPackagings1.Value * seQuantityPP1.Value) / ((seNumberPackagings1.Value * seQuantityPP1.Value) + (seNumberPackagings2.Value * seQuantityPP2.Value) + (seNumberPackagings3.Value * seQuantityPP3.Value))) / seNumberPackagings1.Value);
                    pricePP2Exc = package2.PriceExc + package2.AdditionalCostExc + (recipe.TotalIngredientCostExc * ((seNumberPackagings2.Value * seQuantityPP2.Value) / ((seNumberPackagings1.Value * seQuantityPP1.Value) + (seNumberPackagings2.Value * seQuantityPP2.Value) + (seNumberPackagings3.Value * seQuantityPP3.Value))) / seNumberPackagings2.Value);
                    pricePP3Exc = package3.PriceExc + package3.AdditionalCostExc + (recipe.TotalIngredientCostExc * ((seNumberPackagings3.Value * seQuantityPP3.Value) / ((seNumberPackagings1.Value * seQuantityPP1.Value) + (seNumberPackagings2.Value * seQuantityPP2.Value) + (seNumberPackagings3.Value * seQuantityPP3.Value))) / seNumberPackagings3.Value);

                    sePricePP1Exc.Value = pricePP1Exc;
                    sePricePP2Exc.Value = pricePP2Exc;
                    sePricePP3Exc.Value = pricePP3Exc;

                    pricePP1Inc = package1.PriceInc + package1.AdditionalCostInc + (recipe.TotalIngredientCostInc * ((seNumberPackagings1.Value * seQuantityPP1.Value) / ((seNumberPackagings1.Value * seQuantityPP1.Value) + (seNumberPackagings2.Value * seQuantityPP2.Value) + (seNumberPackagings3.Value * seQuantityPP3.Value))) / seNumberPackagings1.Value);
                    pricePP2Inc = package2.PriceInc + package2.AdditionalCostInc + (recipe.TotalIngredientCostInc * ((seNumberPackagings2.Value * seQuantityPP2.Value) / ((seNumberPackagings1.Value * seQuantityPP1.Value) + (seNumberPackagings2.Value * seQuantityPP2.Value) + (seNumberPackagings3.Value * seQuantityPP3.Value))) / seNumberPackagings2.Value);
                    pricePP3Inc = package3.PriceInc + package3.AdditionalCostInc + (recipe.TotalIngredientCostInc * ((seNumberPackagings3.Value * seQuantityPP3.Value) / ((seNumberPackagings1.Value * seQuantityPP1.Value) + (seNumberPackagings2.Value * seQuantityPP2.Value) + (seNumberPackagings3.Value * seQuantityPP3.Value))) / seNumberPackagings3.Value);

                    sePricePP1Inc.Value = pricePP1Inc;
                    sePricePP2Inc.Value = pricePP2Inc;
                    sePricePP3Inc.Value = pricePP3Inc;
                }
            }

        }

        public decimal calculateRemainingVolume()
        {
            decimal remainingVolume = 0M;
            remainingVolume = seTotalQuantity.Value - (seQuantityPP1.Value * seNumberPackagings1.Value) - (seQuantityPP2.Value * seNumberPackagings2.Value) - (seQuantityPP3.Value * seNumberPackagings3.Value);

            return remainingVolume;
        }

        #endregion

        private void bbSaveRecipe_Click(object sender, EventArgs e)
        {
            (bool validated, string errorMessage) = CheckData();
            if (validated)
            {
                Save(false);
            }
            else
            {
                XtraMessageBox.Show(errorMessage);
            }
            
        }


        public void Save(bool partialSave)
        {
            recipe.RecipeName = teRecipeName.Text;
            recipe.Category = (string)luCategoryRecipe.EditValue;
            recipe.Method = rtbMethod.Text;
            recipe.TotalVolume = seTotalQuantity.Value;
            recipe.LastEdited = DateTime.Now.ToShortDateString();
            

            savePackagings();
            recipe.calculateTotalCostExc();
            recipe.calculateTotalCostInc();

            if (partialSave)
            {
                projectData.CurrentRecipe = recipe;
                projectSettings.SaveProject(projectSettings.ProjectSaveLocation);
            }
            else
            {
                if (QuantityCheck())
                {
                    //remove old recipe if it exists
                    if (projectData.RecipeList.Find(x => x.Code.Equals(recipe.Code)) != null)
                    {
                        projectData.RecipeList.Remove(projectData.RecipeList.Find(x => x.Code.Equals(recipe.Code)));
                    }
                    projectData.RecipeList.Add(recipe);
                    saveProducts();

                    //Will add this later, gives too much of a headache right now

                    //if ((bool)ceAddToIngredients.EditValue)
                    //{
                    //    recipe.IsAlsoIngredient = true;
                    //    SaveToIngredients();
                    //}
                    //else
                    //{
                    //    recipe.IsAlsoIngredient = false;
                    //}

                    //Reset the current recipe to disable to button again
                    projectData.CurrentRecipe = null;

                    //Close the current Form and open the recipes form again                
                    FormMain parentForm = (FormMain)this.ParentForm;
                    this.Close();
                    projectSettings.formType = "ViewRecipes";
                    parentForm.LoadForm("ViewRecipes");

                    
                    projectSettings.SaveProject(projectSettings.ProjectSaveLocation);

                    //Also create the pdf of the recipe
                    Report report = new Report(projectData, recipe);
                    string saveLocation = Path.Combine(projectSettings.RecipesDirectory, recipe.RecipeName + " (" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + ").pdf");
                    report.ExportToPdf(saveLocation);
                    if (projectData.Settings.ShowPDFAfterCreation)
                    {
                        report.ShowPreview();
                    }


                }
            }
           
            
        }

        public bool QuantityCheck()
        {            

            if (seQuantityRemaining.Value > 500)
            {
                DialogResult dialogResult = MessageBox.Show("You still have " + seQuantityRemaining.Value + recipe.RecipeUnit+" remaining which is not yet in packagings, are you sure you want to save the recipe?", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return false;
                }
            }

            if (seQuantityRemaining.Value < -500)
            {
                DialogResult dialogResult = MessageBox.Show("You have put " + seQuantityRemaining.Value +  recipe.RecipeUnit+ " too much in the packagings, are you sure you want to save the recipe?", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return false;
                }
            }

            return true;
        }

        public void savePackagings()
        {
            recipe.packagingList.Clear();            
            if ((int)rgNumberPackagings.EditValue > 0 && seNumberPackagings1.Value != 0)
            {
                Packaging package1 = projectData.PackagingList.Find(x => x.Name.Equals(luPackaging1.EditValue));
                recipe.packagingList.Add(new Packaging()
                {
                    NumberOfPackagings = seNumberPackagings1.Value,
                    RecipeQuantity = seQuantityPP1.Value,
                    ProductionPriceInc = Math.Round(sePricePP1Inc.Value, 2),
                    ProductionPriceExc = Math.Round(sePricePP1Exc.Value, 2),

                    Code = package1.Code,
                    Name = package1.Name,
                    PriceInc = package1.PriceInc,
                    PriceExc = package1.PriceExc,
                    ColorRoundSticker = package1.ColorRoundSticker,
                    AdditionalCostInc = package1.AdditionalCostInc,
                    AdditionalCostExc = package1.AdditionalCostExc,
                    Volume = package1.Volume,
                });
            }

            if ((int)rgNumberPackagings.EditValue > 1 && seNumberPackagings2.Value != 0)
            {
                Packaging package2 = projectData.PackagingList.Find(x => x.Name.Equals(luPackaging2.EditValue));
                recipe.packagingList.Add(new Packaging()
                {
                    NumberOfPackagings = seNumberPackagings2.Value,
                    RecipeQuantity = seQuantityPP2.Value,
                    ProductionPriceInc = Math.Round(sePricePP2Inc.Value, 2),
                    ProductionPriceExc = Math.Round(sePricePP2Exc.Value, 2),

                    Code = package2.Code,
                    Name = package2.Name,
                    PriceInc = package2.PriceInc,
                    PriceExc = package2.PriceExc,
                    ColorRoundSticker = package2.ColorRoundSticker,
                    AdditionalCostInc = package2.AdditionalCostInc,
                    AdditionalCostExc = package2.AdditionalCostExc,
                    Volume = package2.Volume,
                });
            }

            if ((int)rgNumberPackagings.EditValue > 2 && seNumberPackagings3.Value != 0)
            {
                Packaging package3 = projectData.PackagingList.Find(x => x.Name.Equals(luPackaging3.EditValue));
                recipe.packagingList.Add(new Packaging()
                {
                    NumberOfPackagings = seNumberPackagings3.Value,
                    RecipeQuantity = seQuantityPP3.Value,
                    ProductionPriceInc = Math.Round(sePricePP3Inc.Value, 2),
                    ProductionPriceExc = Math.Round(sePricePP3Exc.Value, 2),



                    Code = package3.Code,
                    Name = package3.Name,
                    PriceInc = package3.PriceInc,
                    PriceExc = package3.PriceExc,
                    ColorRoundSticker = package3.ColorRoundSticker,
                    AdditionalCostInc = package3.AdditionalCostInc,
                    AdditionalCostExc = package3.AdditionalCostExc,
                    Volume = package3.Volume,
                });
            }
        }

        public void saveProducts()
        {

            foreach (Packaging packaging in recipe.packagingList)
            {
                SellProduct product = projectData.ProductList.Find(x => x.RecipeCode.Equals(recipe.Code) && x.PackagingCode.Equals(packaging.Code));
                //If the combination of this recipe and packaging already exist update it
                if (product != null)
                {
                    product.Name = recipe.RecipeName + "\r\n(" + packaging.Name + ")";
                    product.RecipeName = recipe.RecipeName;
                    product.PackagingName = packaging.Name;
                    product.IsRecipeProduct = true;
                    product.Category = recipe.Category;
                    product.Volume = packaging.RecipeQuantity;
                    product.ProductionCostExc = packaging.ProductionPriceExc;
                    product.ProductionCostInc = packaging.ProductionPriceInc;                  


                }
                //Otheriwse create a new one
                else
                {
                    product = new SellProduct()
                    {
                        ProductCode = new Guid(),
                        RecipeCode = recipe.Code,
                        PackagingCode = packaging.Code,
                        IsRecipeProduct = true,
                        Name = recipe.RecipeName + "\r\n(" + packaging.Name + ")",
                        RecipeName = recipe.RecipeName,
                        PackagingName = packaging.Name,
                        Category = recipe.Category,
                        Volume = packaging.RecipeQuantity,
                        ProductionCostExc = packaging.ProductionPriceExc,
                        ProductionCostInc = packaging.ProductionPriceInc,
                        DataPointProfit = "Profit",
                        DataPointMargin = "Margin"
                    };

                    projectData.ProductList.Add(product);
                }
            }

        }
        public void SaveToIngredients()
        {
            if (projectData.BuyIngredientList.Find(x => x.RecipeCode.Equals(recipe.Code)) != null)
            {
                Ingredient ingredient = projectData.BuyIngredientList.Find(x => x.RecipeCode.Equals(recipe.Code));
                projectData.BuyIngredientList.Remove(ingredient);

                ingredient.BuyPriceExc = recipe.TotalIngredientCostExc;
                ingredient.BuyPriceInc = recipe.TotalIngredientCostInc;
                ingredient.BuyQuantity = recipe.TotalVolume;
                ingredient.BuyUnit = recipe.RecipeUnit;
                ingredient.updateBuyPPU();
                projectData.BuyIngredientList.Add(ingredient);
            }
            else
            {
                Ingredient newIngredient = new()
                {
                    Code = new Guid(),
                    Name = recipe.RecipeName,
                    Store = "Home made",
                    BuyPriceExc = recipe.TotalIngredientCostExc,
                    BuyPriceInc = recipe.TotalIngredientCostInc,
                    BuyQuantity = recipe.TotalVolume,
                    BuyUnit = recipe.RecipeUnit,
                    Tax = 0.09M,
                    MadeFromOwnRecipe = true,
                    RecipeCode = recipe.Code,

                };
                newIngredient.updateBuyPPU();
                projectData.BuyIngredientList.Add(newIngredient);
            }

            
        }

        public (bool, string) CheckData()
        {
            bool validated = true;
            string msg = "The following errors have occured:" + Environment.NewLine;
            if (teRecipeName.Text == string.Empty)
            {
                msg += "- Please provide a recipe name." + Environment.NewLine;
                validated = false;
            }
            if (luPackaging1.EditValue == null && (int)rgNumberPackagings.EditValue > 0)
            {
                msg += "- Please select a packaging type for the first package." + Environment.NewLine;
                validated = false;
            }
            if (luPackaging2.EditValue == null && (int)rgNumberPackagings.EditValue > 1)
            {
                msg += "- Please select a packaging type for the second package." + Environment.NewLine;
                validated = false;
            }
            if (luPackaging3.EditValue == null && (int)rgNumberPackagings.EditValue > 2)
            {
                msg += "- Please select a packaging type for the third package." + Environment.NewLine;
                validated = false;
            }
            if (gvRecipeIngredients.DataRowCount == 0)
            {
                msg += "- Please select at least one ingredient." + Environment.NewLine;
                validated = false;
            }           

            return (validated, msg);
        }
        
        private void setVisibility(string page)
        {
            switch (page)
            {
                case "Ingredients":
                    {
                        lcgTabIngredients.Visibility = LayoutVisibility.Always;
                        lcgTabMethod.Visibility = LayoutVisibility.Never;
                        lcgTabPackagings.Visibility = LayoutVisibility.Never;
                        break;
                    }

                case "Method":
                    {
                        lcgTabIngredients.Visibility = LayoutVisibility.Never;
                        lcgTabMethod.Visibility = LayoutVisibility.Always;
                        lcgTabPackagings.Visibility = LayoutVisibility.Never;
                        break;
                    }

                case "Packagings":
                    {
                        lcgTabIngredients.Visibility = LayoutVisibility.Never;
                        lcgTabMethod.Visibility = LayoutVisibility.Never;
                        lcgTabPackagings.Visibility = LayoutVisibility.Always;
                        break;
                    }
            }
        }

        private void sbResetQuantity_Click(object sender, EventArgs e)
        {
            updateTotalQuantities();
        }

        //Stole this from the internet and then rewrote it so it works for a gridcontrol with datasource List<Ingredient>
        #region drag and drop
        private void dragDropEvents1_DragOver(object sender, DevExpress.Utils.DragDrop.DragOverEventArgs e)
        {
            DragOverGridEventArgs args = DragOverGridEventArgs.GetDragOverGridEventArgs(e);
            e.InsertType = args.InsertType;
            e.InsertIndicatorLocation = args.InsertIndicatorLocation;
            e.Action = args.Action;
            Cursor.Current = args.Cursor;
            args.Handled = true;
        }

        private void dragDropEvents1_DragDrop(object sender, DevExpress.Utils.DragDrop.DragDropEventArgs e)
        {
            GridView targetGrid = e.Target as GridView;
            GridView sourceGrid = e.Source as GridView;
            if (e.Action == DragDropActions.None || targetGrid != sourceGrid)
                return;
            List<Ingredient> sourceTable = sourceGrid.GridControl.DataSource as List<Ingredient>;

            Point hitPoint = targetGrid.GridControl.PointToClient(Cursor.Position);
            GridHitInfo hitInfo = targetGrid.CalcHitInfo(hitPoint);

            int[] sourceHandles = e.GetData<int[]>();

            int targetRowHandle = hitInfo.RowHandle;
            int targetRowIndex = targetGrid.GetDataSourceRowIndex(targetRowHandle);

            List<Ingredient> draggedRows = new List<Ingredient>();
            foreach (int sourceHandle in sourceHandles)
            {
                int oldRowIndex = sourceGrid.GetDataSourceRowIndex(sourceHandle);
                Ingredient oldRow = sourceTable[oldRowIndex];
                draggedRows.Add(oldRow);
            }

            int newRowIndex;

            switch (e.InsertType)
            {
                case DevExpress.Utils.DragDrop.InsertType.Before:
                    newRowIndex = targetRowIndex > sourceHandles[sourceHandles.Length - 1] ? targetRowIndex - 1 : targetRowIndex;
                    for (int i = draggedRows.Count - 1; i >= 0; i--)
                    {
                       
                        Ingredient oldRow = draggedRows[i];
                        Ingredient newRow = oldRow;
                        sourceTable.Remove(oldRow);
                        sourceTable.Insert( newRowIndex, newRow);

                    }
                    break;
                case DevExpress.Utils.DragDrop.InsertType.After:
                    newRowIndex = targetRowIndex < sourceHandles[0] ? targetRowIndex + 1 : targetRowIndex;
                    for (int i = 0; i < draggedRows.Count; i++)
                    {
                        Ingredient oldRow = draggedRows[i];
                        Ingredient newRow = oldRow;
                        sourceTable.Remove(oldRow);
                        sourceTable.Insert(newRowIndex, newRow);
                    }
                    break;
                default:
                    newRowIndex = -1;
                    break;
            }
            int insertedIndex = targetGrid.GetRowHandle(newRowIndex);
            targetGrid.FocusedRowHandle = insertedIndex;
            targetGrid.SelectRow(targetGrid.FocusedRowHandle);
            gvRecipeIngredients.RefreshData();
        }
        #endregion

       
    }

}
