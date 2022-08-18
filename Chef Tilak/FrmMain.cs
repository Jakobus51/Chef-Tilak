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

namespace Chef_Tilak
{
    public partial class FormMain : DevExpress.XtraEditors.XtraForm
    {
        public ProjectSettings ProjectSettings;

      
        public FormMain(ProjectSettings settings)
        {
            this.ProjectSettings = settings;
            InitializeComponent();

            //Gives notification if loaded succesfully
            if (!settings.newProject)
            {

                //Tries to load the project
                (bool succes, string msg) = settings.LoadProject(settings.ProjectSaveLocation);
                if (succes)
                {

                }
                else
                {
                    MessageBox.Show("Could not load the project: " + msg +"\r\nPlease contact Jakob if this keep happening.", "No Succes :(");
                }
            }
            else
            {
                settings.ProjectData.SetNewProject();
            }

            ProjectSettings.formType = "";
         
            //Sets whether or not there the continue recipe button is enabled
            bbContinueRecipe.Enabled = ProjectSettings.ProjectData.CurrentRecipe == null ? false : true;

        }

        private void bbIngridients_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //If the dockpanel equal Ingredients the ingredient form is already open, so you don't have to open it again
            if (!ProjectSettings.formType.Equals("Ingridients") && ExitForm(ProjectSettings.formType))
            {
                ProjectSettings.formType = "Ingridients";
                LoadForm("Ingridients");
            }

        }

        private void bbPackagings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!ProjectSettings.formType.Equals("Packagings") && ExitForm(ProjectSettings.formType))
            {
                ProjectSettings.formType = "Packagings";
                LoadForm("Packagings");
            }
        }

        private void bbViewRecipes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!ProjectSettings.formType.Equals("ViewRecipes") && ExitForm(ProjectSettings.formType))
            {
                ProjectSettings.formType = "ViewRecipes";
                LoadForm("ViewRecipes");
            }
        }

        private void bbNewRecipe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Add a warning if you want to start a new recipe while another one is still open
            if (ProjectSettings.ProjectData.CurrentRecipe != null)
            {
                DialogResult dialogResult = MessageBox.Show("There is already another recipe open: " + ProjectSettings.ProjectData.CurrentRecipe.RecipeName + ".\r\nStarting a new recipe will delete this recipe, are you sure you want to start a new recipe?", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (!ProjectSettings.formType.Equals("NewRecipe") && ExitForm(ProjectSettings.formType))
                    {
                        ProjectSettings.formType = "NewRecipe";
                        LoadForm("NewRecipe");
                    }
                }

            }
            else
            {
                if (!ProjectSettings.formType.Equals("NewRecipe") && ExitForm(ProjectSettings.formType))
                {
                    ProjectSettings.formType = "NewRecipe";
                    LoadForm("NewRecipe");
                }
            }
          
           
        }

        private void bbContinueRecipe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!ProjectSettings.formType.Equals("ContinueRecipe") && ExitForm(ProjectSettings.formType))
            {
                ProjectSettings.formType = "ContinueRecipe";
                LoadForm("ContinueRecipe", ProjectSettings.ProjectData.CurrentRecipe);
            }
        }

        private void bbProducts_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!ProjectSettings.formType.Equals("Products") && ExitForm(ProjectSettings.formType))
            {
                ProjectSettings.formType = "Products";
                LoadForm("Products");
            }
        }

        private void bbGraphs1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!ProjectSettings.formType.Equals("Graphs") && ExitForm(ProjectSettings.formType))
            {
                ProjectSettings.formType = "Graphs";
                LoadForm("Graphs");
            }
        }

        private void bbSettings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!ProjectSettings.formType.Equals("Settings") && ExitForm(ProjectSettings.formType))
            {
                ProjectSettings.formType = "Settings";
                LoadForm("Settings");
            }
        }

        /// <summary>
        /// Load new form by loading it into the dockpanel
        /// </summary>
        /// <param name="formName"></param>
        public void LoadForm(string formtype)
        {   
            switch (formtype)
            {
                case "Ingridients":
                    {
                        dockPanel1.Text = "Ingredients";
                        FormIngredients form = new FormIngredients(ProjectSettings);
                        form.MdiParent = this;
                        form.TopLevel = false;
                        form.Visible = true;
                        dockPanel1.ControlContainer.Controls.Add(form);
                        form.Dock = DockStyle.Fill;
                        form.FormBorderStyle = FormBorderStyle.None;
                        
                    }
                    break;


                case "Packagings":
                    {
                        dockPanel1.Text = "Packagings";
                        FormPackagings form = new FormPackagings(ProjectSettings);
                        form.MdiParent = this;
                        form.TopLevel = false;
                        form.Visible = true;
                        dockPanel1.ControlContainer.Controls.Add(form);
                        form.Dock = DockStyle.Fill;
                        form.FormBorderStyle = FormBorderStyle.None;
                    }
                    break;

                case "ViewRecipes":
                    {
                        dockPanel1.Text = "Recipes";
                        FormRecipes form = new FormRecipes(ProjectSettings);
                        form.MdiParent = this;
                        form.TopLevel = false;
                        form.Visible = true;
                        dockPanel1.ControlContainer.Controls.Add(form);
                        form.Dock = DockStyle.Fill;
                        form.FormBorderStyle = FormBorderStyle.None;

                        //If there is no current recipe, the button is disabled
                        bbContinueRecipe.Enabled = ProjectSettings.ProjectData.CurrentRecipe == null? false: true;

                    }
                    break;

                case "NewRecipe":
                    {
                        dockPanel1.Text = "New Recipe";
                        FormCreateRecipe form = new FormCreateRecipe(ProjectSettings);
                        form.MdiParent = this;
                        form.TopLevel = false;
                        form.Visible = true;
                        dockPanel1.ControlContainer.Controls.Add(form);
                        form.Dock = DockStyle.Fill;
                        form.FormBorderStyle = FormBorderStyle.None;
                    }
                    break;                   


                case "Products":
                    {
                        dockPanel1.Text = "Products";
                        FormProducts form = new FormProducts(ProjectSettings);
                        form.MdiParent = this;
                        form.TopLevel = false;
                        form.Visible = true;
                        dockPanel1.ControlContainer.Controls.Add(form);
                        form.Dock = DockStyle.Fill;
                        form.FormBorderStyle = FormBorderStyle.None;
                    }
            
                    break;

                case "Graphs":
                    {
                        dockPanel1.Text = "Graphs";
                        FormGraphs form = new FormGraphs(ProjectSettings);
                        form.MdiParent = this;
                        form.TopLevel = false;
                        form.Visible = true;
                        dockPanel1.ControlContainer.Controls.Add(form);
                        form.Dock = DockStyle.Fill;
                        form.FormBorderStyle = FormBorderStyle.None;
                    }
                    break;

                case "Settings":
                    {
                        dockPanel1.Text = "Settings";
                        FormSettings form = new FormSettings(ProjectSettings);
                        form.MdiParent = this;
                        form.TopLevel = false;
                        form.Visible = true;
                        dockPanel1.ControlContainer.Controls.Add(form);
                        form.Dock = DockStyle.Fill;
                        form.FormBorderStyle = FormBorderStyle.None;
                    }
                    break;
            }
        }

        public void LoadForm(string formtype, Recipe recipe)
        {
            switch (formtype)
            {
                case "ContinueRecipe":
                case "EditRecipe":
                    {
                        dockPanel1.Text = "Edit Recipe";
                        FormCreateRecipe form = new FormCreateRecipe(ProjectSettings, recipe);
                        form.MdiParent = this;
                        form.TopLevel = false;
                        form.Visible = true;
                        dockPanel1.ControlContainer.Controls.Add(form);
                        form.Dock = DockStyle.Fill;
                        form.FormBorderStyle = FormBorderStyle.None;
                    }
                    break;
            }
        }
        

        /// <summary>
        /// Closes the current active form in the dockpanel by removing it
        /// If it passes the checkdata then close the form otherwise return false
        /// </summary>        
        public bool ExitForm(string formType)
        {

            switch (formType)
            {
                case "Ingridients":
                    {
                        if (((FormIngredients)dockPanel1.ControlContainer.Controls[0]).CheckData())
                        {
                            ((FormIngredients)dockPanel1.ControlContainer.Controls[0]).Close();
                            dockPanel1.ControlContainer.Controls.Clear();
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }


                case "Packagings":
                    {
                        if (((FormPackagings)dockPanel1.ControlContainer.Controls[0]).CheckData())
                        {
                            ((FormPackagings)dockPanel1.ControlContainer.Controls[0]).Close();
                            dockPanel1.ControlContainer.Controls.Clear();
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                case "ViewRecipes":
                    {
                        if (((FormRecipes)dockPanel1.ControlContainer.Controls[0]).CheckData())
                        {
                            ((FormRecipes)dockPanel1.ControlContainer.Controls[0]).Close();
                            dockPanel1.ControlContainer.Controls.Clear();
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }


                case "EditRecipe":
                case "ContinueRecipe":
                case "NewRecipe":
                    {
                        //This one is abit different since you don't have to check the data and the form closing event is not configured
                        ((FormCreateRecipe)dockPanel1.ControlContainer.Controls[0]).Save(true);
                        ((FormCreateRecipe)dockPanel1.ControlContainer.Controls[0]).Close();
                        dockPanel1.ControlContainer.Controls.Clear();
                        bbContinueRecipe.Enabled = true;
                        return true;
                    }

                case "Products":
                    {
                        if (((FormProducts)dockPanel1.ControlContainer.Controls[0]).CheckData())
                        {
                            ((FormProducts)dockPanel1.ControlContainer.Controls[0]).Close();
                            dockPanel1.ControlContainer.Controls.Clear();
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }

                case "Graphs":
                    {
                        if (((FormGraphs)dockPanel1.ControlContainer.Controls[0]).CheckData())
                        {
                            ((FormGraphs)dockPanel1.ControlContainer.Controls[0]).Close();
                            dockPanel1.ControlContainer.Controls.Clear();
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }

                case "Settings":
                    {
                        if (((FormSettings)dockPanel1.ControlContainer.Controls[0]).CheckData())
                        {
                            ((FormSettings)dockPanel1.ControlContainer.Controls[0]).Close();
                            dockPanel1.ControlContainer.Controls.Clear();
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }

                default:
                    {
                        return true;
                    }
            }

        }
        private void Args_Showing(object sender, XtraMessageShowingArgs e)
        {
            foreach (var control in e.Form.Controls)
            {
                SimpleButton button = control as SimpleButton;
                if (button != null)
                {                   
                    switch (button.DialogResult.ToString())
                    {
                        case ("OK"):
                            button.Text = "Yes, Discard";
                            break;
                        case ("Cancel"):
                            button.Text = "Cancel";
                            break;
                    }
                }
            }
        }

        private void bbSaveAndExit1_ItemClick(object sender, ItemClickEventArgs e)
        {
            ExitForm(ProjectSettings.formType);
            this.Close();

        }

       
        private void FormMain_SizeChanged(object sender, EventArgs e)
        {
            dockPanel1.Height = this.Height - 167;
        }
    }
}