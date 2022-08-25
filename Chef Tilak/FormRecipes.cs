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
using DevExpress.XtraReports.UI;
using System.IO;
using System.Xml.Serialization;

namespace Chef_Tilak
{
    public partial class FormRecipes : DevExpress.XtraEditors.XtraForm
    {

        private ProjectData projectData;
        private ProjectSettings projectSettings;

        public FormRecipes()
        {
            InitializeComponent();
        }

        public FormRecipes(ProjectSettings Projectsettings) : this()
        {
            this.projectSettings = Projectsettings;
            this.projectData = Projectsettings.ProjectData;

            InitDisplayData();
        }

        private void InitDisplayData()
        {
            gcRecipes.DataSource = projectData.RecipeList;
            tePDFLocationTip.Text = "You can find the PDF's of all your recipes in " + projectSettings.RecipesDirectory;
        }

        private void bbEditRecipe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Recipe focusedRecipe = (Recipe)gvRecipes.GetRow(gvRecipes.FocusedRowHandle);
            if (focusedRecipe != null)
            {
                //Add a warning if you want to start a new recipe while another one is still open
                if (projectData.CurrentRecipe != null)
                {
                    DialogResult dialogResult = MessageBox.Show("There is already another recipe open: " + projectData.CurrentRecipe.RecipeName + ".\r\nEditing " + focusedRecipe.RecipeName +" will delete all the changes of " + projectData.CurrentRecipe.RecipeName + ", are you sure you want to edit "+ focusedRecipe.RecipeName + "?", "Warning", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        FormMain parentForm = (FormMain)this.ParentForm;
                        if (!projectSettings.formType.Equals("EditRecipe") && parentForm.ExitForm(projectSettings.formType))
                        {
                            projectSettings.formType = "EditRecipe";
                            parentForm.LoadForm("EditRecipe", focusedRecipe);
                        }
                    }

                }
                else
                {
                    FormMain parentForm = (FormMain)this.ParentForm;
                    if (!projectSettings.formType.Equals("EditRecipe") && parentForm.ExitForm(projectSettings.formType))
                    {
                        projectSettings.formType = "EditRecipe";
                        parentForm.LoadForm("EditRecipe", focusedRecipe);
                    }
                }               
            }            
            else
            {
                MessageBox.Show("Please select a recipe", "warning");
            }
        }

        private void bbCopyRecipe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Recipe focusedRecipe = (Recipe)gvRecipes.GetRow(gvRecipes.FocusedRowHandle);
            if (focusedRecipe != null)
            {
                //Add a warning if you want to start a new recipe while another one is still open
                if (projectData.CurrentRecipe != null)
                {
                    DialogResult dialogResult = MessageBox.Show("There is already another recipe open: " + projectData.CurrentRecipe.RecipeName + ".\r\nCopying " + focusedRecipe.RecipeName + " will delete all the changes of " + projectData.CurrentRecipe.RecipeName + ", are you sure you want to copy " + focusedRecipe.RecipeName + "?", "Warning", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        FormMain parentForm = (FormMain)this.ParentForm;
                        if (!projectSettings.formType.Equals("EditRecipe") && parentForm.ExitForm(projectSettings.formType))
                        {
                            projectSettings.formType = "EditRecipe";
                            Recipe copiedRecipe = CreateDeepCopy(focusedRecipe);
                            copiedRecipe.Code = Guid.NewGuid();
                            copiedRecipe.RecipeName = focusedRecipe.RecipeName + "- copy";
                            parentForm.LoadForm("EditRecipe", copiedRecipe);
                        }
                    }

                }
                else
                {
                    FormMain parentForm = (FormMain)this.ParentForm;
                    if (!projectSettings.formType.Equals("EditRecipe") && parentForm.ExitForm(projectSettings.formType))
                    {
                        projectSettings.formType = "EditRecipe";
                        Recipe copiedRecipe = CreateDeepCopy(focusedRecipe);
                        copiedRecipe.Code = Guid.NewGuid();
                        copiedRecipe.RecipeName = focusedRecipe.RecipeName + "- copy";

                        parentForm.LoadForm("EditRecipe", copiedRecipe);
                    }
                }
            }

            else
            {
                MessageBox.Show("Please select a recipe", "warning");
            }
        }

        public static Recipe CreateDeepCopy(Recipe obj)
        {
            using (var ms = new MemoryStream())
            {
                XmlSerializer serializer = new XmlSerializer(obj.GetType());
                serializer.Serialize(ms, obj);
                ms.Seek(0, SeekOrigin.Begin);
                return (Recipe)serializer.Deserialize(ms);
            }
        }

        private void bbRemoveRecipe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Recipe focusedRecipe = (Recipe)gvRecipes.GetRow(gvRecipes.FocusedRowHandle);

            if (focusedRecipe != null)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete: " + focusedRecipe.RecipeName + "?", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    projectData.RecipeList.Remove(focusedRecipe);
                    gvRecipes.RefreshData();
                }
            }
            else
            {
                MessageBox.Show("Please select a recipe", "warning");
            }
        }

        private void bbViewPDF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Recipe focusedRecipe = (Recipe)gvRecipes.GetRow(gvRecipes.FocusedRowHandle);

            if (focusedRecipe != null)
            {
                Report report = new Report(projectData, focusedRecipe);
                report.ShowPreview();
            }
            else
            {
                MessageBox.Show("Please select a recipe", "warning");
            }
        }

        public void Save()
        {
            projectData.RecipeList = (List<Recipe>)gcRecipes.DataSource;
        }

        public bool CheckData()
        {    
            return true;
        }


        private void FormRecipes_FormClosing(object sender, FormClosingEventArgs e)
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