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
    public partial class FormProducts : DevExpress.XtraEditors.XtraForm
    {
        private ProjectSettings projectSettings;
        private ProjectData projectData;

        public FormProducts()
        {
            InitializeComponent();
        }

        public FormProducts(ProjectSettings Projectsettings) : this()
        {
            this.projectSettings = Projectsettings;
            this.projectData = Projectsettings.ProjectData;

            InitDisplayData();
        }

        private void InitDisplayData()
        {
            gcProducts.DataSource = projectData.ProductList;
            luProductCategory.DataSource = projectData.RecipesCategories;



        }

        private void bbAddProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WzrdAddProduct wzrdAddProduct = new(projectData);
            wzrdAddProduct.ShowDialog();
            gvProducts.RefreshData();
        }

        private void bbRemoveProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SellProduct focusedProduct = (SellProduct)gvProducts.GetRow(gvProducts.FocusedRowHandle);

            if (focusedProduct != null)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete:\r\n" + focusedProduct.Name + "?", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    projectData.ProductList.Remove(focusedProduct);
                    gvProducts.RefreshData();
                }
            }
            else
            {
                MessageBox.Show("Please select a product", "warning");
            }
        }

        private void gvProducts_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            SellProduct changedProduct = (SellProduct)gvProducts.GetRow(gvProducts.FocusedRowHandle);

          

            if (e.Column.Caption == "Sell Price (Inc)")
            {
                changedProduct.MarginInc = (changedProduct.SellPriceInc - changedProduct.ProductionCostExc) / changedProduct.SellPriceInc;
                changedProduct.MarginInc = Math.Round(changedProduct.MarginInc, 2);

                changedProduct.ProfitInc = changedProduct.SellPriceInc - changedProduct.ProductionCostExc;
                changedProduct.ProfitInc = Math.Round(changedProduct.ProfitInc, 2);
            }

            if (e.Column.Caption == "Margin (Inc)")
            {
                changedProduct.SellPriceInc = changedProduct.ProductionCostExc / (1 - changedProduct.MarginInc);
                changedProduct.SellPriceInc = Math.Round(changedProduct.SellPriceInc, 2);

                changedProduct.ProfitInc = changedProduct.SellPriceInc - changedProduct.ProductionCostExc;
                changedProduct.ProfitInc = Math.Round(changedProduct.ProfitInc, 2);
            }

            if (e.Column.Caption == "Profit (Inc)")
            {
                changedProduct.SellPriceInc = changedProduct.ProfitInc + changedProduct.ProductionCostExc;
                changedProduct.SellPriceInc = Math.Round(changedProduct.SellPriceInc, 2);

                changedProduct.MarginInc = (changedProduct.SellPriceInc - changedProduct.ProductionCostExc) / changedProduct.SellPriceInc;
                changedProduct.MarginInc = Math.Round(changedProduct.MarginInc, 2);
            }
           

            gvProducts.RefreshData();

        }

        private void disabledCellEvents2_ProcessingCell(object sender, DevExpress.Utils.Behaviors.Common.ProcessCellEventArgs e)
        {
            GridView view = e.Source as GridView;
            bool isRecipeProduct = (bool)(view.GetListSourceRowCellValue(e.RecordId, "IsRecipeProduct"));

            if (isRecipeProduct)
            {
                if (e.FieldName == "RecipeName" || e.FieldName == "PackagingName" || e.FieldName == "Category" || e.FieldName == "ProductionCostExc" || e.FieldName == "ProductionCostInc")
                {
                    e.Disabled = true;
                }
            }
        }

        public void Save()
        {
            projectData.ProductList = (List<SellProduct>)gcProducts.DataSource;
            projectSettings.SaveProject(projectSettings.ProjectSaveLocation);
        }

        public bool CheckData()
        {                  

            return true;
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

        private void bbDetailedOverview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}