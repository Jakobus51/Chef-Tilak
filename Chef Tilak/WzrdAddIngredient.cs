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
    public partial class WzrdAddIngredient : DevExpress.XtraEditors.XtraForm
    {
        public List<Ingredient> Ingredients;
        public ProjectData ProjectData;
        public Ingredient ingredientToAdd;

        public WzrdAddIngredient(ProjectData projectData, List<Ingredient> ingredients)
        {
            ProjectData = projectData;
            Ingredients = ingredients; 

            InitializeComponent();

            luUnit.Properties.DataSource = projectData.Units;
            luStore.Properties.DataSource = projectData.IngredientSupplier;
            luUnit.EditValue = "Kg";
            luStore.EditValue = "Other";
            ingredientToAdd = new();

        }

        private void wizardControl1_FinishClick(object sender, CancelEventArgs e)
        {
            if (CheckData())
            {
                Ingredient newIngredient = new()
                {
                    Name = teName.Text,
                    Store = (string)luStore.EditValue,
                    Tax = seTax.Value,
                    BuyQuantity = seQuantity.Value,
                    BuyUnit = (string)luUnit.EditValue,
                    BuyPriceExc = Math.Round(sePriceExc.Value, 2),
                    BuyPriceInc = Math.Round(sePriceInc.Value, 2),
                    PricePerUnitExc = Math.Round(sePriceExc.Value / seQuantity.Value, 5),
                    PricePerUnitInc = Math.Round(sePriceInc.Value / seQuantity.Value, 5),
                };

                Ingredients.Add(newIngredient);
            }
            else
            {
                e.Cancel = true;
            }        
        }

        private void sePriceExc_EditValueChanged(object sender, EventArgs e)        
        {
            if (sePriceInc.Value != Math.Round(((1 + seTax.Value) * sePriceExc.Value),2))
            {
                sePriceInc.Value = Math.Round((1 + seTax.Value) * sePriceExc.Value, 2);
            }           
            
        }

        private void sePriceInc_EditValueChanged(object sender, EventArgs e)
        {
            if (sePriceExc.Value != Math.Round(1 / (1 + seTax.Value) * sePriceInc.Value, 2))
            {
                sePriceExc.Value = Math.Round(1 / (1 + seTax.Value) * sePriceInc.Value, 2);
            }
        }

        private void seTax_EditValueChanged(object sender, EventArgs e)
        {
            if (sePriceInc.Value != Math.Round(((1 + seTax.Value) * sePriceExc.Value), 2))
            {
                sePriceInc.Value = Math.Round((1 + seTax.Value) * sePriceExc.Value, 2);
            }
        }


        public bool CheckData()
        {
            foreach (Ingredient ingredient in Ingredients)
            {
                if (ingredient.Name.Equals(teName.Text))
                {
                    string message = "There is already an ingredient with this name. Please change the name of " + teName.Text;
                    string title = "Error";
                    MessageBox.Show(message, title);

                    return false;
                }
            }

            //if (teName.Text.Equals("") || seQuantity.Value == 0 || sePriceExc.Value == 0)
            //{
            //    string message = "Make sure the ingredient has a name, quantity and price";
            //    string title = "Error";
            //    MessageBox.Show(message, title);

            //    return false;
            //}

            if (teName.Text.Equals("") || seQuantity.Value == 0)
            {
                string message = "Make sure the ingredient has a name and a quantity.";
                string title = "Error";
                MessageBox.Show(message, title);

                return false;
            }


            return true;
        }

        private void wizardControl1_CustomizeCommandButtons(object sender, DevExpress.XtraWizard.CustomizeCommandButtonsEventArgs e)
        {
            e.PrevButton.Visible = false;
        }

       
    }
}
