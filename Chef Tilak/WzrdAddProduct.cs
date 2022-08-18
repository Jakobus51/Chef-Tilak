using DevExpress.XtraEditors;
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

namespace Chef_Tilak
{
    public partial class WzrdAddProduct : DevExpress.XtraEditors.XtraForm
    {
        public List<Packaging> Packagings;
        public ProjectData ProjectData;

        public WzrdAddProduct(ProjectData projectData)
        {
            ProjectData = projectData;

            InitializeComponent();

            luCategory.Properties.DataSource = projectData.RecipesCategories;
            luCategory.EditValue = "Other";

        }

        private void wizardControl1_FinishClick_1(object sender, CancelEventArgs e)
        {
            if (CheckData())
            {
                SellProduct newProduct = new()
                {
                    ProductCode = new Guid(),
                    RecipeName = teName.Text,
                    PackagingName = tePackaging.Text,
                    Category = luCategory.Text,
                    ProductionCostExc = Math.Round(seBuyPriceExc.Value, 2),
                    SellPriceInc = Math.Round(seSellPriceInc.Value, 2),
                    MarginInc = Math.Round(seMarginInc.Value, 2),
                   
                    IsRecipeProduct = false,
                };
                ProjectData.ProductList.Add(newProduct);
            }
            else
            {
                e.Cancel = true;
            }
        }
               


        public bool CheckData()
        {
            foreach (SellProduct product in ProjectData.ProductList)
            {
                if (product.RecipeName.Equals(teName.Text) && product.PackagingName.Equals(tePackaging.Text))
                {
                    string message = "There is already an product with this name and packaging. Please change the name or packaging.";
                    string title = "Error";
                    MessageBox.Show(message, title);

                    return false;
                }
            }

            if (teName.Text.Equals("") || seBuyPriceExc.Value == 0 || seSellPriceInc.Value == 0)
            {
                string message = "Make sure the product has a name, buy price and sell price";
                string title = "Error";
                MessageBox.Show(message, title);

                return false;
            }


            return true;
        }

        private void seMargin_EditValueChanged(object sender, EventArgs e)
        {
            if (seMarginInc.Value != 1)
            {
                seSellPriceInc.Value = seBuyPriceExc.Value / (1 - seMarginInc.Value);
            }          

        }

        private void seBuyPriceExc_EditValueChanged(object sender, EventArgs e)
        {
            if (seSellPriceInc.Value != 0)
            {
                seMarginInc.Value = (seSellPriceInc.Value - seBuyPriceExc.Value) / seSellPriceInc.Value;
            }
        }

        private void seSellPriceInc_EditValueChanged(object sender, EventArgs e)
        {
            if (seSellPriceInc.Value != 0)
            {
                seMarginInc.Value = (seSellPriceInc.Value - seBuyPriceExc.Value) / seSellPriceInc.Value;
            }
        }

        private void wizardControl1_CustomizeCommandButtons(object sender, DevExpress.XtraWizard.CustomizeCommandButtonsEventArgs e)
        {
            e.PrevButton.Visible = false;
        }
    }
}
