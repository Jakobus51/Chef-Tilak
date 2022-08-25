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
using DevExpress.XtraCharts;

namespace Chef_Tilak
{
    public partial class FormCostBreakdown : DevExpress.XtraEditors.XtraForm
    {
        public SellProduct product;


        public FormCostBreakdown(SellProduct Product)
        {
            product = Product;
            InitializeComponent();
            this.Text = product.RecipeName + " (" + product.PackagingName + ")";
            meRecipeName.Text = product.RecipeName;           
            tePackagingName.Text = product.PackagingName;
            teCategory.Text = product.Category;
            teProductionCost.EditValue = product.ProductionCostExc;
            teSellPrice.EditValue = product.SellPriceInc ;
            teProfit.EditValue = product.ProfitInc;
            teMargin.EditValue = product.MarginInc;
            CreateCostGraph();
        }

        public void CreateCostGraph()
        {
            ccCostBreakdown.Titles.Add(new ChartTitle() { Text = "Production Costs (Total: €" + Math.Round(product.ProductionCostExc,2) +")" });
            Series series1 = new Series("Production Cost", ViewType.Pie);

            series1.DataSource = product.ProductionCostBreakdown;
            series1.ArgumentDataMember = "Name";
            series1.ValueDataMembers.AddRange(new string[] { "Cost" });

            ccCostBreakdown.Series.Add(series1);

            // Format the the series labels.
            series1.Label.TextPattern = "{A}\r\n{V:c} ({VP:p0})";
            series1.LegendTextPattern = "{A}";
            ((PieSeriesLabel)series1.Label).Position = PieSeriesLabelPosition.Outside;
            ((PieSeriesLabel)series1.Label).ResolveOverlappingMode = ResolveOverlappingMode.Default;
            
            ccCostBreakdown.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            series1.SeriesPointsSorting = SortingMode.Descending;
            series1.SeriesPointsSortingKey = SeriesPointKey.Value_1;




        }
    }
}