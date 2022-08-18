using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using Chef_Tilak.DataClassses;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Drawing;

namespace Chef_Tilak
{
    public partial class Report : DevExpress.XtraReports.UI.XtraReport
    {

        private ProjectData projectData;
        private Recipe recipe;

        
        public Report(ProjectData projectData, Recipe recipeToBeMade)
        {
            this.recipe = recipeToBeMade;
            this.projectData = projectData;
            InitializeComponent();

            objectDataSource2.DataSource = recipe;
            xrPackagingUnit.Text = recipe.RecipeUnit;
            xlVolumeProduced.Text = recipe.TotalVolume.ToString("N0") + " " + recipe.RecipeUnit;
           

            if (recipe.packagingList.Count == 0)
            {
                drPackagings1.Visible = false;
                drPackagings2.Visible = false;
            }
            
            if (recipe.Method.Equals(""))
            {
                drMethod.Visible = false;
            }

            if (!String.IsNullOrEmpty(projectData.Settings.CustomerLogoPath))
            {             
                pcCustomerLogo.ImageUrl = projectData.Settings.CustomerLogoPath;
            }
            if (!String.IsNullOrEmpty(projectData.Settings.CustomerName))
            {
                xlCustomerName.Text = "Recipe by " + projectData.Settings.CustomerName;
            }
            if (!String.IsNullOrEmpty(projectData.Settings.CustomerColorHTML))
            {
                xlRecipeName.BackColor = ColorTranslator.FromHtml(projectData.Settings.CustomerColorHTML);
                xrLabel35.BackColor = ColorTranslator.FromHtml(projectData.Settings.CustomerColorHTML);
            }
        }
    }
}
