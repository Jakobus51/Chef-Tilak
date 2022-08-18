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
using DevExpress.XtraBars;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraBars;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Chef_Tilak
{
    public partial class FormGraphs : DevExpress.XtraEditors.XtraForm
    {
        private ProjectSettings projectSettings;
        private ProjectData projectData;

        public FormGraphs()
        {
            InitializeComponent();
        }

        public FormGraphs(ProjectSettings Projectsettings) : this()
        {
            this.projectSettings = Projectsettings;
            this.projectData = Projectsettings.ProjectData;

            InitDisplayData();
        }

        private void InitDisplayData()
        {
            SetPanel(pcMainGraphs, true);


            SeriesTemplate CategoryDrillTemplate = new SeriesTemplate();
            
            ccMainGraphs.DataSource = projectData.ProductList;
            ccMainGraphs.SeriesTemplate.SeriesDataMember = "DataPointMargin";
            ccMainGraphs.SeriesTemplate.ArgumentDataMember = "Category";
            ccMainGraphs.SeriesTemplate.QualitativeSummaryOptions.SummaryFunction = "AVERAGE([MarginInc])";
            ccMainGraphs.SeriesTemplate.View = new SideBySideBarSeriesView();

            ccMainGraphs.SeriesTemplate.SeriesPointDrillTemplate = CategoryDrillTemplate;
           
            ccMainGraphs.SeriesTemplate.Label.TextPattern = "{V:p2}";
            ccMainGraphs.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            ((SideBySideBarSeriesLabel)ccMainGraphs.SeriesTemplate.Label).Position = BarSeriesLabelPosition.Top;
            ccMainGraphs.SeriesTemplate.CrosshairLabelPattern = "{A}: \r\n{V:p2}";

            CategoryDrillTemplate.SeriesDataMember = "Category";
            CategoryDrillTemplate.ArgumentDataMember = "Name";
            CategoryDrillTemplate.ValueDataMembers.AddRange("MarginInc");
            CategoryDrillTemplate.View = new SideBySideBarSeriesView();
            CategoryDrillTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            CategoryDrillTemplate.Label.TextPattern = "{V:p2}";
            CategoryDrillTemplate.CrosshairLabelPattern = "{A}: \r\n{V:p2}";
            ((SideBySideBarSeriesLabel)CategoryDrillTemplate.Label).Position = BarSeriesLabelPosition.Top;

            //SeriesTemplate ProductDrillTemplate = new SeriesTemplate();
            //CategoryDrillTemplate.SeriesDrillTemplate = ProductDrillTemplate;

            XYDiagram diagram = (XYDiagram)ccMainGraphs.Diagram;
            diagram.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;     
            diagram.AxisY.Title.Text = "Margin";
            diagram.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            diagram.AxisX.Title.Text = "Product (Category)";
            diagram.AxisY.Label.TextPattern = "{VP:p0}";

            diagram.AxisY.Strips.Add(new Strip("Strip 1", -5,0));
            diagram.AxisY.Strips[0].Visible = true;
            diagram.AxisY.Strips[0].MinLimit.Enabled = false;
            diagram.AxisY.Strips[0].ShowInLegend = false;
            diagram.AxisY.Strips[0].Color = Color.FromArgb(220, 200, 200);
            diagram.AxisY.Strips[0].FillStyle.FillMode = FillMode.Empty;

            diagram.EnableAxisXScrolling = true;
            diagram.ScrollingOptions.UseKeyboard = true;
            diagram.ScrollingOptions.UseMouse = true;
            diagram.ScrollingOptions.UseScrollBars = true;

            diagram.EnableAxisXZooming = true;
            diagram.ZoomingOptions.UseKeyboard = true;
            diagram.ZoomingOptions.UseKeyboardWithMouse = true;
            diagram.ZoomingOptions.UseMouseWheel = true;
            diagram.AxisX.WholeRange.SideMarginsValue = 1;



        }

    

      

        public void Save()
        {
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

        private void SetPanel(PanelControl panel, bool visible)
        {
            panel.Visible = visible;
            panel.Dock = DockStyle.Fill;
            panel.BorderStyle = BorderStyles.NoBorder;
        }
    }
}