namespace Chef_Tilak
{
    partial class FormIngredients
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.Utils.AppearanceObject appearanceObject1 = new DevExpress.Utils.AppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIngredients));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gcIngredients = new DevExpress.XtraGrid.GridControl();
            this.gvIngredients = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.luIngredientSupplier = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gcQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.seQuantityIngredient = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gcUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.luUnitIngredient = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gcTax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gcPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sePriceIngredient = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gcPPUExc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sePricePerUnitExc = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gcPPUInc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sePricePerUnitIngridient = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.disabledCellEvents1 = new DevExpress.Utils.Behaviors.Common.DisabledCellEvents(this.components);
            this.ribbonControl2 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbIngridients = new DevExpress.XtraBars.BarButtonItem();
            this.bbPackagings = new DevExpress.XtraBars.BarButtonItem();
            this.bbViewRecipes = new DevExpress.XtraBars.BarButtonItem();
            this.bbNewRecipe = new DevExpress.XtraBars.BarButtonItem();
            this.bbContinueRecipe = new DevExpress.XtraBars.BarButtonItem();
            this.bbSettings = new DevExpress.XtraBars.BarButtonItem();
            this.bbProducts = new DevExpress.XtraBars.BarButtonItem();
            this.bbGraphs = new DevExpress.XtraBars.BarButtonItem();
            this.bbGraphs1 = new DevExpress.XtraBars.BarButtonItem();
            this.bbAddIngredient = new DevExpress.XtraBars.BarButtonItem();
            this.bbRemoveIngredient = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.bbUploadPDF = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgIngredients = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcIngredients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvIngredients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luIngredientSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seQuantityIngredient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luUnitIngredient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sePriceIngredient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sePricePerUnitExc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sePricePerUnitIngridient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcIngredients);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 132);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1055, 365);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcIngredients
            // 
            this.gcIngredients.Location = new System.Drawing.Point(2, 2);
            this.gcIngredients.MainView = this.gvIngredients;
            this.gcIngredients.Margin = new System.Windows.Forms.Padding(0);
            this.gcIngredients.Name = "gcIngredients";
            this.gcIngredients.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.seQuantityIngredient,
            this.luUnitIngredient,
            this.sePriceIngredient,
            this.sePricePerUnitIngridient,
            this.repositoryItemLookUpEdit1,
            this.luIngredientSupplier,
            this.repositoryItemSpinEdit1,
            this.sePricePerUnitExc,
            this.repositoryItemSpinEdit2});
            this.gcIngredients.Size = new System.Drawing.Size(1051, 361);
            this.gcIngredients.TabIndex = 3;
            this.gcIngredients.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvIngredients});
            // 
            // gvIngredients
            // 
            this.behaviorManager1.SetBehaviors(this.gvIngredients, new DevExpress.Utils.Behaviors.Behavior[] {
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.Utils.Behaviors.Common.DisabledCellBehavior.Create(typeof(DevExpress.XtraGrid.Extensions.GridViewDisabledCellSource), "", appearanceObject1, this.disabledCellEvents1)))});
            this.gvIngredients.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcName,
            this.gcCategory,
            this.gcQuantity,
            this.gcUnit,
            this.gcTax,
            this.gridColumn3,
            this.gcPrice,
            this.gcPPUExc,
            this.gcPPUInc});
            this.gvIngredients.GridControl = this.gcIngredients;
            this.gvIngredients.Name = "gvIngredients";
            this.gvIngredients.OptionsFind.AlwaysVisible = true;
            this.gvIngredients.OptionsFind.FindDelay = 250;
            this.gvIngredients.OptionsView.ShowGroupPanel = false;
            this.gvIngredients.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gcName, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvIngredients.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvIngredients_CellValueChanged);
            // 
            // gcName
            // 
            this.gcName.Caption = "Name";
            this.gcName.FieldName = "Name";
            this.gcName.MinWidth = 400;
            this.gcName.Name = "gcName";
            this.gcName.Visible = true;
            this.gcName.VisibleIndex = 0;
            this.gcName.Width = 425;
            // 
            // gcCategory
            // 
            this.gcCategory.Caption = "Store";
            this.gcCategory.ColumnEdit = this.luIngredientSupplier;
            this.gcCategory.FieldName = "Store";
            this.gcCategory.MinWidth = 25;
            this.gcCategory.Name = "gcCategory";
            this.gcCategory.Visible = true;
            this.gcCategory.VisibleIndex = 1;
            this.gcCategory.Width = 100;
            // 
            // luIngredientSupplier
            // 
            this.luIngredientSupplier.AutoHeight = false;
            this.luIngredientSupplier.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luIngredientSupplier.Name = "luIngredientSupplier";
            // 
            // gcQuantity
            // 
            this.gcQuantity.Caption = "Quantity";
            this.gcQuantity.ColumnEdit = this.seQuantityIngredient;
            this.gcQuantity.FieldName = "BuyQuantity";
            this.gcQuantity.MinWidth = 25;
            this.gcQuantity.Name = "gcQuantity";
            this.gcQuantity.Visible = true;
            this.gcQuantity.VisibleIndex = 2;
            this.gcQuantity.Width = 106;
            // 
            // seQuantityIngredient
            // 
            this.seQuantityIngredient.AutoHeight = false;
            this.seQuantityIngredient.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seQuantityIngredient.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.seQuantityIngredient.Name = "seQuantityIngredient";
            // 
            // gcUnit
            // 
            this.gcUnit.Caption = "Unit";
            this.gcUnit.ColumnEdit = this.luUnitIngredient;
            this.gcUnit.FieldName = "BuyUnit";
            this.gcUnit.MinWidth = 25;
            this.gcUnit.Name = "gcUnit";
            this.gcUnit.Visible = true;
            this.gcUnit.VisibleIndex = 3;
            this.gcUnit.Width = 63;
            // 
            // luUnitIngredient
            // 
            this.luUnitIngredient.AutoHeight = false;
            this.luUnitIngredient.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luUnitIngredient.Name = "luUnitIngredient";
            // 
            // gcTax
            // 
            this.gcTax.Caption = "Tax";
            this.gcTax.ColumnEdit = this.repositoryItemSpinEdit1;
            this.gcTax.FieldName = "Tax";
            this.gcTax.MinWidth = 25;
            this.gcTax.Name = "gcTax";
            this.gcTax.Visible = true;
            this.gcTax.VisibleIndex = 4;
            this.gcTax.Width = 60;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.repositoryItemSpinEdit1.MaskSettings.Set("mask", "p");
            this.repositoryItemSpinEdit1.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            this.repositoryItemSpinEdit1.UseMaskAsDisplayFormat = true;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Price Exc";
            this.gridColumn3.ColumnEdit = this.repositoryItemSpinEdit2;
            this.gridColumn3.FieldName = "BuyPriceExc";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 5;
            this.gridColumn3.Width = 80;
            // 
            // repositoryItemSpinEdit2
            // 
            this.repositoryItemSpinEdit2.AutoHeight = false;
            this.repositoryItemSpinEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit2.MaskSettings.Set("mask", "c");
            this.repositoryItemSpinEdit2.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2";
            this.repositoryItemSpinEdit2.UseMaskAsDisplayFormat = true;
            // 
            // gcPrice
            // 
            this.gcPrice.Caption = "Price Inc";
            this.gcPrice.ColumnEdit = this.sePriceIngredient;
            this.gcPrice.FieldName = "BuyPriceInc";
            this.gcPrice.MinWidth = 25;
            this.gcPrice.Name = "gcPrice";
            this.gcPrice.Visible = true;
            this.gcPrice.VisibleIndex = 6;
            this.gcPrice.Width = 78;
            // 
            // sePriceIngredient
            // 
            this.sePriceIngredient.AutoHeight = false;
            this.sePriceIngredient.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sePriceIngredient.MaskSettings.Set("mask", "c");
            this.sePriceIngredient.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.sePriceIngredient.Name = "sePriceIngredient";
            this.sePriceIngredient.UseMaskAsDisplayFormat = true;
            // 
            // gcPPUExc
            // 
            this.gcPPUExc.Caption = "PP Unit Exc";
            this.gcPPUExc.ColumnEdit = this.sePricePerUnitExc;
            this.gcPPUExc.FieldName = "PricePerUnitExc";
            this.gcPPUExc.MinWidth = 25;
            this.gcPPUExc.Name = "gcPPUExc";
            this.gcPPUExc.Visible = true;
            this.gcPPUExc.VisibleIndex = 7;
            this.gcPPUExc.Width = 80;
            // 
            // sePricePerUnitExc
            // 
            this.sePricePerUnitExc.AutoHeight = false;
            this.sePricePerUnitExc.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sePricePerUnitExc.MaskSettings.Set("mask", "c");
            this.sePricePerUnitExc.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.sePricePerUnitExc.Name = "sePricePerUnitExc";
            this.sePricePerUnitExc.UseMaskAsDisplayFormat = true;
            // 
            // gcPPUInc
            // 
            this.gcPPUInc.Caption = "PP unit Inc";
            this.gcPPUInc.ColumnEdit = this.sePricePerUnitIngridient;
            this.gcPPUInc.FieldName = "PricePerUnitInc";
            this.gcPPUInc.MinWidth = 25;
            this.gcPPUInc.Name = "gcPPUInc";
            this.gcPPUInc.Visible = true;
            this.gcPPUInc.VisibleIndex = 8;
            this.gcPPUInc.Width = 80;
            // 
            // sePricePerUnitIngridient
            // 
            this.sePricePerUnitIngridient.AutoHeight = false;
            this.sePricePerUnitIngridient.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sePricePerUnitIngridient.MaskSettings.Set("mask", "c");
            this.sePricePerUnitIngridient.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.sePricePerUnitIngridient.Name = "sePricePerUnitIngridient";
            this.sePricePerUnitIngridient.ReadOnly = true;
            this.sePricePerUnitIngridient.UseMaskAsDisplayFormat = true;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(1055, 365);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcIngredients;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1055, 365);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // disabledCellEvents1
            // 
            this.disabledCellEvents1.ProcessingCell += new System.EventHandler<DevExpress.Utils.Behaviors.Common.ProcessCellEventArgs>(this.disabledCellEvents1_ProcessingCell);
            // 
            // ribbonControl2
            // 
            this.ribbonControl2.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl2.ExpandCollapseItem.Id = 0;
            this.ribbonControl2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl2.ExpandCollapseItem,
            this.ribbonControl2.SearchEditItem,
            this.bbIngridients,
            this.bbPackagings,
            this.bbViewRecipes,
            this.bbNewRecipe,
            this.bbContinueRecipe,
            this.bbSettings,
            this.bbProducts,
            this.bbGraphs,
            this.bbGraphs1,
            this.bbAddIngredient,
            this.bbRemoveIngredient,
            this.barButtonItem3,
            this.barButtonItem4,
            this.bbUploadPDF});
            this.ribbonControl2.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl2.MaxItemId = 19;
            this.ribbonControl2.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbonControl2.Name = "ribbonControl2";
            this.ribbonControl2.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2});
            this.ribbonControl2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2019;
            this.ribbonControl2.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl2.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl2.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl2.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl2.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl2.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Show;
            this.ribbonControl2.ShowQatLocationSelector = false;
            this.ribbonControl2.ShowToolbarCustomizeItem = false;
            this.ribbonControl2.Size = new System.Drawing.Size(1055, 132);
            this.ribbonControl2.Toolbar.ShowCustomizeItem = false;
            this.ribbonControl2.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbIngridients
            // 
            this.bbIngridients.Caption = "Ingridients";
            this.bbIngridients.Id = 1;
            this.bbIngridients.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbIngridients.ImageOptions.SvgImage")));
            this.bbIngridients.Name = "bbIngridients";
            // 
            // bbPackagings
            // 
            this.bbPackagings.Caption = "Packagings";
            this.bbPackagings.Id = 2;
            this.bbPackagings.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbPackagings.ImageOptions.SvgImage")));
            this.bbPackagings.Name = "bbPackagings";
            // 
            // bbViewRecipes
            // 
            this.bbViewRecipes.Caption = "View Recipes";
            this.bbViewRecipes.Id = 3;
            this.bbViewRecipes.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbViewRecipes.ImageOptions.SvgImage")));
            this.bbViewRecipes.Name = "bbViewRecipes";
            // 
            // bbNewRecipe
            // 
            this.bbNewRecipe.Caption = "New Recipe";
            this.bbNewRecipe.Id = 4;
            this.bbNewRecipe.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbNewRecipe.ImageOptions.SvgImage")));
            this.bbNewRecipe.Name = "bbNewRecipe";
            // 
            // bbContinueRecipe
            // 
            this.bbContinueRecipe.Caption = "Continue Recipe";
            this.bbContinueRecipe.Id = 5;
            this.bbContinueRecipe.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbContinueRecipe.ImageOptions.SvgImage")));
            this.bbContinueRecipe.Name = "bbContinueRecipe";
            // 
            // bbSettings
            // 
            this.bbSettings.Caption = "Settings";
            this.bbSettings.Id = 6;
            this.bbSettings.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbSettings.ImageOptions.SvgImage")));
            this.bbSettings.Name = "bbSettings";
            // 
            // bbProducts
            // 
            this.bbProducts.Caption = "Products";
            this.bbProducts.Id = 7;
            this.bbProducts.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbProducts.ImageOptions.SvgImage")));
            this.bbProducts.Name = "bbProducts";
            // 
            // bbGraphs
            // 
            this.bbGraphs.Caption = "Graphs";
            this.bbGraphs.Id = 8;
            this.bbGraphs.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbGraphs.ImageOptions.SvgImage")));
            this.bbGraphs.Name = "bbGraphs";
            // 
            // bbGraphs1
            // 
            this.bbGraphs1.Caption = "Graphs";
            this.bbGraphs1.Id = 12;
            this.bbGraphs1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbGraphs1.ImageOptions.SvgImage")));
            this.bbGraphs1.Name = "bbGraphs1";
            // 
            // bbAddIngredient
            // 
            this.bbAddIngredient.Caption = "Add Ingredient";
            this.bbAddIngredient.Id = 14;
            this.bbAddIngredient.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbAddIngredient.ImageOptions.SvgImage")));
            this.bbAddIngredient.LargeWidth = 70;
            this.bbAddIngredient.Name = "bbAddIngredient";
            this.bbAddIngredient.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbAddIngredient_ItemClick);
            // 
            // bbRemoveIngredient
            // 
            this.bbRemoveIngredient.Caption = "Remove Ingredient";
            this.bbRemoveIngredient.Id = 15;
            this.bbRemoveIngredient.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbRemoveIngredient.ImageOptions.SvgImage")));
            this.bbRemoveIngredient.LargeWidth = 70;
            this.bbRemoveIngredient.Name = "bbRemoveIngredient";
            this.bbRemoveIngredient.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbRemoveIngredient_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Add Packaging";
            this.barButtonItem3.Id = 16;
            this.barButtonItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem3.ImageOptions.SvgImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Remove Packaging";
            this.barButtonItem4.Id = 17;
            this.barButtonItem4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem4.ImageOptions.SvgImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // bbUploadPDF
            // 
            this.bbUploadPDF.Caption = "Upload PDF";
            this.bbUploadPDF.Id = 18;
            this.bbUploadPDF.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbUploadPDF.ImageOptions.SvgImage")));
            this.bbUploadPDF.Name = "bbUploadPDF";
            this.bbUploadPDF.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbUploadPDF_ItemClick);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5,
            this.rpgIngredients,
            this.ribbonPageGroup1});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Pantry";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment.Far;
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // rpgIngredients
            // 
            this.rpgIngredients.ItemLinks.Add(this.bbAddIngredient);
            this.rpgIngredients.ItemLinks.Add(this.bbRemoveIngredient);
            this.rpgIngredients.Name = "rpgIngredients";
            this.rpgIngredients.Text = "ribbonPageGroup1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbUploadPDF);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            this.ribbonPageGroup1.Visible = false;
            // 
            // FormIngredients
            // 
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 497);
            this.ControlBox = false;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonControl2);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormIngredients";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormIngredients_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcIngredients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvIngredients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luIngredientSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seQuantityIngredient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luUnitIngredient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sePriceIngredient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sePricePerUnitExc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sePricePerUnitIngridient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gcIngredients;
        private DevExpress.XtraGrid.Views.Grid.GridView gvIngredients;
        private DevExpress.XtraGrid.Columns.GridColumn gcName;
        private DevExpress.XtraGrid.Columns.GridColumn gcCategory;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit luIngredientSupplier;
        private DevExpress.XtraGrid.Columns.GridColumn gcQuantity;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit seQuantityIngredient;
        private DevExpress.XtraGrid.Columns.GridColumn gcUnit;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit luUnitIngredient;
        private DevExpress.XtraGrid.Columns.GridColumn gcTax;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn gcPrice;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit sePriceIngredient;
        private DevExpress.XtraGrid.Columns.GridColumn gcPPUExc;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit sePricePerUnitExc;
        private DevExpress.XtraGrid.Columns.GridColumn gcPPUInc;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit sePricePerUnitIngridient;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.Utils.Behaviors.Common.DisabledCellEvents disabledCellEvents1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl2;
        private DevExpress.XtraBars.BarButtonItem bbIngridients;
        private DevExpress.XtraBars.BarButtonItem bbPackagings;
        private DevExpress.XtraBars.BarButtonItem bbViewRecipes;
        private DevExpress.XtraBars.BarButtonItem bbNewRecipe;
        private DevExpress.XtraBars.BarButtonItem bbContinueRecipe;
        private DevExpress.XtraBars.BarButtonItem bbSettings;
        private DevExpress.XtraBars.BarButtonItem bbProducts;
        private DevExpress.XtraBars.BarButtonItem bbGraphs;
        private DevExpress.XtraBars.BarButtonItem bbGraphs1;
        private DevExpress.XtraBars.BarButtonItem bbAddIngredient;
        private DevExpress.XtraBars.BarButtonItem bbRemoveIngredient;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgIngredients;
        private DevExpress.XtraBars.BarButtonItem bbUploadPDF;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    }
}