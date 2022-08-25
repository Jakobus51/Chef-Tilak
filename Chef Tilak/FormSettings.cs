using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chef_Tilak.DataClassses;
using DevExpress.XtraEditors;
using DevExpress.XtraReports;
using DevExpress.XtraSplashScreen;

namespace Chef_Tilak
{
    public partial class FormSettings : DevExpress.XtraEditors.XtraForm
    {
        private ProjectSettings projectSettings;
        private ProjectData projectData;

        public FormSettings()
        {
            InitializeComponent();
        }

        public FormSettings(ProjectSettings Projectsettings) : this()
        {
            this.projectSettings = Projectsettings;
            this.projectData = Projectsettings.ProjectData;

            InitDisplayData();
        }

        private void InitDisplayData()
        {
            luCategories.Properties.DataSource = projectData.RecipesCategories;
            luStores.Properties.DataSource = projectData.IngredientSupplier;

            luCategories.Properties.DropDownRows = projectData.RecipesCategories.Count() < 10 ? projectData.RecipesCategories.Count() : 10;
            luStores.Properties.DropDownRows = projectData.IngredientSupplier.Count() < 10 ? projectData.IngredientSupplier.Count() : 10;

            tsPPUIngredientExc.IsOn =  projectData.Settings.ShowPricePPIngredientExc;
            tsPPUIngredientInc.IsOn = projectData.Settings.ShowPricePPIngredientInc;
            tsShowPDF.IsOn = projectData.Settings.ShowPDFAfterCreation;

            teCustomerName.Text = projectData.Settings.CustomerName;

            try
            {
                peCustomerLogo.Image = Image.FromFile(projectData.Settings.CustomerLogoPath);
                teCustomerLogoPath.Text = projectData.Settings.CustomerLogoPath;
            }
            catch (ArgumentException)
            {
                if (!String.IsNullOrEmpty(projectData.Settings.CustomerLogoPath))
                {
                    XtraMessageBox.Show("Your logo could not be found, it may have been moved or deleted.");
                }
            }
            catch (IOException)
            {
                if (!String.IsNullOrEmpty(projectData.Settings.CustomerLogoPath))
                {
                    XtraMessageBox.Show("Your logo could not be found, it may have been moved or deleted.");
                }
            }
            cpeRecipeHeaderColour.Color = ColorTranslator.FromHtml(projectData.Settings.CustomerColorHTML);


        }


        public void Save()
        {
            projectData.Settings.ShowPricePPIngredientExc = tsPPUIngredientExc.IsOn;
            projectData.Settings.ShowPricePPIngredientInc = tsPPUIngredientInc.IsOn;
            projectData.Settings.ShowPDFAfterCreation = tsShowPDF.IsOn;

            projectData.Settings.CustomerName = teCustomerName.Text;
            projectData.Settings.CustomerLogoPath = teCustomerLogoPath.Text;
            projectData.Settings.CustomerColorHTML = ColorTranslator.ToHtml(cpeRecipeHeaderColour.Color);
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

      

        private void sbAddStore_Click(object sender, EventArgs e)
        {
            if (teAddStore.Text != "")
            {
                if (!projectData.IngredientSupplier.Contains(teAddStore.Text))
                {
                    projectData.IngredientSupplier.Add(teAddStore.Text);
                    projectData.IngredientSupplier.Sort();
                    teAddStore.Text = "";
                    luStores.Properties.DropDownRows = projectData.IngredientSupplier.Count() < 10 ? projectData.IngredientSupplier.Count() : 10;

                    luStores.Refresh();

                }
                else
                {
                    string message = "There is already a store with this name.";
                    string title = "Error";
                    MessageBox.Show(message, title);
                }
            }
            
        }

        private void sbAddCategory_Click(object sender, EventArgs e)
        {          
            if (teAddCategory.Text != "")
            {
                if (!projectData.RecipesCategories.Contains(teAddStore.Text))
                {
                    projectData.RecipesCategories.Add(teAddCategory.Text);
                    projectData.RecipesCategories.Sort();
                    teAddCategory.Text = "";
                    luCategories.Properties.DropDownRows = projectData.RecipesCategories.Count() < 10 ? projectData.RecipesCategories.Count() : 10;

                    luCategories.Refresh();
                }
                else
                {
                    string message = "There is already a category with this name.";
                    string title = "Error";
                    MessageBox.Show(message, title);
                }
            }
            
        }

        private void sbRemoveCategory_Click(object sender, EventArgs e)
        {
            if (luCategories.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete: " + luCategories.Text + " ? \r\n\r\nIt will also be deleted from your recipes and products.", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    projectData.RecipesCategories.Remove(luCategories.Text);
                    luCategories.Refresh();

                }
            }
          

        }

        private void sbRemoveStore_Click(object sender, EventArgs e)
        {
            if (luStores.Text == "Home made")
            {
                XtraMessageBox.Show("You cannot delete Home made from your store list");
                return;
            }
            if (luStores.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete: " + luStores.Text + " ? \r\n\r\nIt will also be deleted from your recipes and products.", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    projectData.IngredientSupplier.Remove(luStores.Text);
                    luStores.Refresh();
                }
            }
        }

        

        private void sbImportCustomerLogo_Click(object sender, EventArgs e)
        {
            if (odfCustomerLogo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    teCustomerLogoPath.Text = odfCustomerLogo.FileName;
                    Image image = Image.FromFile(odfCustomerLogo.FileName);
                    peCustomerLogo.Image = image;

                }
                catch (TaskCanceledException ex)
                {
                    MessageBox.Show($"Task error.\n\nError message: {ex.Message}\n\n" + $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void sbDeleteCustomerLogo_Click(object sender, EventArgs e)
        {
            peCustomerLogo.Image = null;
            teCustomerLogoPath.Text = null;

        }

        

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Ingredient ingredient in projectData.BuyIngredientList)
            {
                ingredient.UpdateStore();
            }

            foreach (Recipe recipe in projectData.RecipeList)
            {
                recipe.RecipeUnit = "g";
            }
        }

        private void tsDeveloperMode_EditValueChanged(object sender, EventArgs e)
        {
            if (tsDeveloperMode.IsOn)
            {
                ribbonPageGroup2.Visible = true;
            }
            else
            {
                ribbonPageGroup2.Visible = false;
            }
        }

        private void bbReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Recipe recipe in projectData.RecipeList)
            {
                recipe.PackagingList = recipe.packagingList;
            }
        }
    }
}