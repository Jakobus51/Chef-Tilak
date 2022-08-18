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
using DevExpress.XtraReports;
using DevExpress.XtraSplashScreen;

namespace Chef_Tilak
{
    public partial class FormPackagings : DevExpress.XtraEditors.XtraForm
    {
        private ProjectSettings projectSettings;
        private ProjectData projectData;
        public List<Packaging> Packagings = new();

        public FormPackagings()
        {
            InitializeComponent();
        }

        public FormPackagings(ProjectSettings Projectsettings) : this()
        {
            this.projectSettings = Projectsettings;
            this.projectData = Projectsettings.ProjectData;

            InitDisplayData();
        }

        private void InitDisplayData()
        {
            this.FormBorderStyle = FormBorderStyle.None;
           
            foreach (Packaging packaging in projectData.PackagingList)
            {
                Packagings.Add(packaging);
            }           
            gcPackaging.DataSource = Packagings;
            luColorRoundSticker.DataSource = projectData.StickerColors;

            sePackagingVolume.EditMask = "##,###,##0 mL";
        }

        private void bbAddPackaging_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WzrdAddPackaging wzrdAddPackaging = new(projectData, Packagings);
            wzrdAddPackaging.ShowDialog();
            gvPackaging.RefreshData();
        }

        private void bbRemovePackaging_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Packaging focusedPackaging = (Packaging)gvPackaging.GetRow(gvPackaging.FocusedRowHandle);

            if (focusedPackaging != null)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete:\r\n" + focusedPackaging.Name + "? \r\n\r\nIt will also be deleted from your recipes.", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Packagings.Remove(focusedPackaging);
                    gvPackaging.RefreshData();
                }
            }   
            else
            {
                MessageBox.Show("Please select a packaging", "warning");
            }
        }


        private void gvPackaging_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            Packaging changedPackaging = (Packaging)gvPackaging.GetRow(gvPackaging.FocusedRowHandle);

            if (e.Column.Caption == "Price Exc" || e.Column.Caption == "Tax")
            {
                changedPackaging.PriceInc = (1 + changedPackaging.Tax) * changedPackaging.PriceExc;
                changedPackaging.PriceInc = Math.Round(changedPackaging.PriceInc, 2);
            }

            if (e.Column.Caption == "Price Inc")
            {
                changedPackaging.PriceExc = (1 / (1 + changedPackaging.Tax)) * changedPackaging.PriceInc;
                changedPackaging.PriceExc = Math.Round(changedPackaging.PriceExc, 2);
            }

            if (e.Column.Caption == "Additional Cost Exc" || e.Column.Caption == "Tax")
            {
                changedPackaging.AdditionalCostInc = (1 + changedPackaging.Tax) * changedPackaging.AdditionalCostExc;
                changedPackaging.AdditionalCostInc = Math.Round(changedPackaging.AdditionalCostInc, 2);
            }

            if (e.Column.Caption == "Additional Cost Inc")
            {
                changedPackaging.AdditionalCostExc = (1 / (1 + changedPackaging.Tax)) * changedPackaging.AdditionalCostInc;
                changedPackaging.AdditionalCostExc = Math.Round(changedPackaging.AdditionalCostExc, 2);
            }

            gvPackaging.RefreshData();
        }

        public void Save()
        {          
           
            projectData.PackagingList = Packagings;
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
            foreach (Recipe recipe in projectData.RecipeList)
            {
                List<Packaging> updatedPackagingList = new();   

                //Now do the same with the packagings
                foreach (Packaging oldPackaging in recipe.packagingList)
                {
                    //First replace the old Packaging with the new, if an Packaging has been removed it will also be removed from the recipe
                    if (projectData.PackagingList.Find(x => x.Code.Equals(oldPackaging.Code)) != null)
                    {
                        Packaging newPackaging = projectData.PackagingList.Find(x => x.Code.Equals(oldPackaging.Code));
                        Packaging updatedPackaging = new()
                        {
                            Code = oldPackaging.Code,
                            NumberOfPackagings = oldPackaging.NumberOfPackagings,
                            RecipeQuantity = oldPackaging.RecipeQuantity,

                            Name = newPackaging.Name,
                            Tax = newPackaging.Tax,
                            Volume = newPackaging.Volume,
                            PriceInc = newPackaging.PriceInc,
                            PriceExc = newPackaging.PriceExc,
                            ColorRoundSticker = newPackaging.ColorRoundSticker,
                            AdditionalCostInc = newPackaging.AdditionalCostInc,
                            AdditionalCostExc = newPackaging.AdditionalCostExc,
                        };
                        updatedPackagingList.Add(updatedPackaging);
                    }
                }
                recipe.packagingList = updatedPackagingList;
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
                        product.PackagingName = packaging.Name;
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
        private void FormPackagings_FormClosing(object sender, FormClosingEventArgs e)
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

        
    }
}