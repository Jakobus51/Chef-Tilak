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
    public partial class WzrdAddPackaging : DevExpress.XtraEditors.XtraForm
    {
        public List<Packaging> Packagings;
        public ProjectData ProjectData;

        public WzrdAddPackaging(ProjectData projectData, List<Packaging> packagings)
        {
            ProjectData = projectData;
            Packagings = packagings; 

            InitializeComponent();

            luColorSticker.Properties.DataSource = projectData.StickerColors;
            luColorSticker.EditValue = "Other";
            seVolume.Properties.EditMask = "##,###,##0 mL";

        }

        private void wizardControl1_FinishClick_1(object sender, CancelEventArgs e)
        {
            if (CheckData())
            {
                Packaging newPackaging = new()
                {
                    Name = teName.Text,
                    Volume = seVolume.Value,
                    Tax = seTax.Value,
                    ColorRoundSticker = (string)luColorSticker.EditValue,
                    PriceExc = Math.Round(sePriceExc.Value, 2),
                    PriceInc = Math.Round(sePriceInc.Value, 2),
                    AdditionalCostExc = Math.Round(seExtraCostExc.Value, 2),
                    AdditionalCostInc = Math.Round(seExtraCostInc.Value, 2),
                };
                Packagings.Add(newPackaging);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void sePriceExc_EditValueChanged(object sender, EventArgs e)
        {
            
            if (sePriceInc.Value != Math.Round(((1 + seTax.Value) * sePriceExc.Value), 2))
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

        private void seExtraCostExc_EditValueChanged(object sender, EventArgs e)
        {
            if (seExtraCostInc.Value != Math.Round((1 + seTax.Value) * seExtraCostExc.Value, 2))
            {
                seExtraCostInc.Value = Math.Round((1 + seTax.Value) * seExtraCostExc.Value, 2);
            }
        }

        private void seExtraCostInc_EditValueChanged(object sender, EventArgs e)
        {
            if (seExtraCostExc.Value != Math.Round(1 / (1 + seTax.Value) * seExtraCostInc.Value, 2))
            {
                seExtraCostExc.Value = Math.Round(1 / (1 + seTax.Value) * seExtraCostInc.Value, 2);
            }

        }

        private void seTax_EditValueChanged(object sender, EventArgs e)
        {
            if (sePriceInc.Value != Math.Round(((1 + seTax.Value) * sePriceExc.Value), 2))
            {
                sePriceInc.Value = Math.Round((1 + seTax.Value) * sePriceExc.Value, 2);
            }

            if (seExtraCostInc.Value != Math.Round((1 + seTax.Value) * seExtraCostExc.Value, 2))
            {
                seExtraCostInc.Value = Math.Round((1 + seTax.Value) * seExtraCostExc.Value, 2);
            }
        }


        public bool CheckData()
        {
            foreach (Packaging packaging in Packagings)
            {
                if (packaging.Name.Equals(teName.Text))
                {
                    string message = "There is already an ingredient with this name. Please change the name of " + teName.Text;
                    string title = "Error";
                    MessageBox.Show(message, title);

                    return false;
                }
            }

            //if (teName.Text.Equals("") || seVolume.Value == 0 || sePriceExc.Value == 0)
            //{
            //    string message = "Make sure the packaging has a name, volume and price";
            //    string title = "Error";
            //    MessageBox.Show(message, title);

            //    return false;
            //}

            if (teName.Text.Equals(""))
            {
                string message = "Make sure the packaging has a name.";
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
