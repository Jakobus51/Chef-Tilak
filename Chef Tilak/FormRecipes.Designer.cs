namespace Chef_Tilak
{
    partial class FormRecipes

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRecipes));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.tePDFLocationTip = new DevExpress.XtraEditors.TextEdit();
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
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.bbEditRecipe = new DevExpress.XtraBars.BarButtonItem();
            this.bbRemoveRecipe = new DevExpress.XtraBars.BarButtonItem();
            this.bbViewPDF = new DevExpress.XtraBars.BarButtonItem();
            this.bscRecipeLocation = new DevExpress.XtraBars.BarStaticItem();
            this.Recipes = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgIngredients = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gcRecipes = new DevExpress.XtraGrid.GridControl();
            this.gvRecipes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcRecipeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcRecipeCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTotalVolume = new DevExpress.XtraGrid.Columns.GridColumn();
            this.seTotalVolume = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gcTotalIngredientCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.seTotalIngredientCost = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gcTotalCostwPackagings = new DevExpress.XtraGrid.Columns.GridColumn();
            this.seTotalCostwPackagings = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.bbCopyRecipe = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tePDFLocationTip.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRecipes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRecipes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seTotalVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seTotalIngredientCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seTotalCostwPackagings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.tePDFLocationTip);
            this.layoutControl1.Controls.Add(this.gcRecipes);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 132);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1009, 390);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // tePDFLocationTip
            // 
            this.tePDFLocationTip.Enabled = false;
            this.tePDFLocationTip.Location = new System.Drawing.Point(37, 366);
            this.tePDFLocationTip.MenuManager = this.ribbonControl2;
            this.tePDFLocationTip.Name = "tePDFLocationTip";
            this.tePDFLocationTip.Size = new System.Drawing.Size(970, 22);
            this.tePDFLocationTip.StyleController = this.layoutControl1;
            this.tePDFLocationTip.TabIndex = 2;
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
            this.barButtonItem3,
            this.barButtonItem4,
            this.bbEditRecipe,
            this.bbRemoveRecipe,
            this.bbViewPDF,
            this.bscRecipeLocation,
            this.bbCopyRecipe});
            this.ribbonControl2.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl2.MaxItemId = 24;
            this.ribbonControl2.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbonControl2.Name = "ribbonControl2";
            this.ribbonControl2.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.Recipes});
            this.ribbonControl2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2019;
            this.ribbonControl2.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl2.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl2.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl2.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl2.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl2.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Show;
            this.ribbonControl2.ShowQatLocationSelector = false;
            this.ribbonControl2.ShowToolbarCustomizeItem = false;
            this.ribbonControl2.Size = new System.Drawing.Size(1009, 132);
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
            // bbEditRecipe
            // 
            this.bbEditRecipe.Caption = "Edit Recipe";
            this.bbEditRecipe.Id = 19;
            this.bbEditRecipe.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbEditRecipe.ImageOptions.SvgImage")));
            this.bbEditRecipe.LargeWidth = 70;
            this.bbEditRecipe.Name = "bbEditRecipe";
            this.bbEditRecipe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbEditRecipe_ItemClick);
            // 
            // bbRemoveRecipe
            // 
            this.bbRemoveRecipe.Caption = "Remove Recipe";
            this.bbRemoveRecipe.Id = 20;
            this.bbRemoveRecipe.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbRemoveRecipe.ImageOptions.SvgImage")));
            this.bbRemoveRecipe.LargeWidth = 70;
            this.bbRemoveRecipe.Name = "bbRemoveRecipe";
            this.bbRemoveRecipe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbRemoveRecipe_ItemClick);
            // 
            // bbViewPDF
            // 
            this.bbViewPDF.Caption = "View PDF ";
            this.bbViewPDF.Id = 21;
            this.bbViewPDF.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbViewPDF.ImageOptions.SvgImage")));
            this.bbViewPDF.LargeWidth = 70;
            this.bbViewPDF.Name = "bbViewPDF";
            this.bbViewPDF.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbViewPDF_ItemClick);
            // 
            // bscRecipeLocation
            // 
            this.bscRecipeLocation.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.bscRecipeLocation.Caption = "Test ie test";
            this.bscRecipeLocation.Id = 22;
            this.bscRecipeLocation.Name = "bscRecipeLocation";
            // 
            // Recipes
            // 
            this.Recipes.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5,
            this.rpgIngredients,
            this.ribbonPageGroup1});
            this.Recipes.Name = "Recipes";
            this.Recipes.Text = "Recipes";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment.Far;
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // rpgIngredients
            // 
            this.rpgIngredients.ItemLinks.Add(this.bbEditRecipe);
            this.rpgIngredients.ItemLinks.Add(this.bbCopyRecipe);
            this.rpgIngredients.ItemLinks.Add(this.bbRemoveRecipe);
            this.rpgIngredients.Name = "rpgIngredients";
            this.rpgIngredients.Text = "ribbonPageGroup1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbViewPDF);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // gcRecipes
            // 
            this.gcRecipes.Location = new System.Drawing.Point(2, 2);
            this.gcRecipes.MainView = this.gvRecipes;
            this.gcRecipes.Name = "gcRecipes";
            this.gcRecipes.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.seTotalVolume,
            this.seTotalIngredientCost,
            this.seTotalCostwPackagings,
            this.repositoryItemSpinEdit1,
            this.repositoryItemSpinEdit2});
            this.gcRecipes.Size = new System.Drawing.Size(1005, 360);
            this.gcRecipes.TabIndex = 0;
            this.gcRecipes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRecipes});
            // 
            // gvRecipes
            // 
            this.gvRecipes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcRecipeName,
            this.gcRecipeCategory,
            this.gcTotalVolume,
            this.gridColumn3,
            this.gridColumn1,
            this.gcTotalIngredientCost,
            this.gridColumn2,
            this.gcTotalCostwPackagings});
            this.gvRecipes.GridControl = this.gcRecipes;
            this.gvRecipes.Name = "gvRecipes";
            this.gvRecipes.OptionsBehavior.Editable = false;
            this.gvRecipes.OptionsFind.AlwaysVisible = true;
            this.gvRecipes.OptionsFind.FindDelay = 250;
            this.gvRecipes.OptionsView.ShowGroupPanel = false;
            this.gvRecipes.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gcRecipeName, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gcRecipeName
            // 
            this.gcRecipeName.Caption = "Recipe Name";
            this.gcRecipeName.FieldName = "RecipeName";
            this.gcRecipeName.MinWidth = 400;
            this.gcRecipeName.Name = "gcRecipeName";
            this.gcRecipeName.Visible = true;
            this.gcRecipeName.VisibleIndex = 0;
            this.gcRecipeName.Width = 458;
            // 
            // gcRecipeCategory
            // 
            this.gcRecipeCategory.Caption = "Category";
            this.gcRecipeCategory.FieldName = "Category";
            this.gcRecipeCategory.MinWidth = 120;
            this.gcRecipeCategory.Name = "gcRecipeCategory";
            this.gcRecipeCategory.Visible = true;
            this.gcRecipeCategory.VisibleIndex = 1;
            this.gcRecipeCategory.Width = 120;
            // 
            // gcTotalVolume
            // 
            this.gcTotalVolume.Caption = "Total Produced";
            this.gcTotalVolume.ColumnEdit = this.seTotalVolume;
            this.gcTotalVolume.FieldName = "TotalVolume";
            this.gcTotalVolume.MinWidth = 80;
            this.gcTotalVolume.Name = "gcTotalVolume";
            this.gcTotalVolume.Visible = true;
            this.gcTotalVolume.VisibleIndex = 2;
            this.gcTotalVolume.Width = 85;
            // 
            // seTotalVolume
            // 
            this.seTotalVolume.AutoHeight = false;
            this.seTotalVolume.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seTotalVolume.MaskSettings.Set("mask", "###,##0");
            this.seTotalVolume.MaskSettings.Set("autoHideDecimalSeparator", true);
            this.seTotalVolume.MaskSettings.Set("hideInsignificantZeros", true);
            this.seTotalVolume.Name = "seTotalVolume";
            this.seTotalVolume.UseMaskAsDisplayFormat = true;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Unit";
            this.gridColumn3.FieldName = "RecipeUnit";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 35;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Ingredient Cost Exc";
            this.gridColumn1.ColumnEdit = this.repositoryItemSpinEdit1;
            this.gridColumn1.FieldName = "TotalIngredientCostExc";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            this.gridColumn1.Width = 121;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.MaskSettings.Set("mask", "c");
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            this.repositoryItemSpinEdit1.UseMaskAsDisplayFormat = true;
            // 
            // gcTotalIngredientCost
            // 
            this.gcTotalIngredientCost.Caption = "Ingredient Cost Inc";
            this.gcTotalIngredientCost.ColumnEdit = this.seTotalIngredientCost;
            this.gcTotalIngredientCost.FieldName = "TotalIngredientCostInc";
            this.gcTotalIngredientCost.MinWidth = 75;
            this.gcTotalIngredientCost.Name = "gcTotalIngredientCost";
            this.gcTotalIngredientCost.Width = 121;
            // 
            // seTotalIngredientCost
            // 
            this.seTotalIngredientCost.AutoHeight = false;
            this.seTotalIngredientCost.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seTotalIngredientCost.MaskSettings.Set("mask", "c");
            this.seTotalIngredientCost.Name = "seTotalIngredientCost";
            this.seTotalIngredientCost.UseMaskAsDisplayFormat = true;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Cost with packagings Exc";
            this.gridColumn2.ColumnEdit = this.repositoryItemSpinEdit2;
            this.gridColumn2.FieldName = "TotalCostwPackagingsExc";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 5;
            this.gridColumn2.Width = 156;
            // 
            // repositoryItemSpinEdit2
            // 
            this.repositoryItemSpinEdit2.AutoHeight = false;
            this.repositoryItemSpinEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit2.MaskSettings.Set("mask", "c");
            this.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2";
            this.repositoryItemSpinEdit2.UseMaskAsDisplayFormat = true;
            // 
            // gcTotalCostwPackagings
            // 
            this.gcTotalCostwPackagings.Caption = "Cost with packagings Inc";
            this.gcTotalCostwPackagings.ColumnEdit = this.seTotalCostwPackagings;
            this.gcTotalCostwPackagings.FieldName = "TotalCostwPackagingsInc";
            this.gcTotalCostwPackagings.MinWidth = 30;
            this.gcTotalCostwPackagings.Name = "gcTotalCostwPackagings";
            this.gcTotalCostwPackagings.Width = 159;
            // 
            // seTotalCostwPackagings
            // 
            this.seTotalCostwPackagings.AutoHeight = false;
            this.seTotalCostwPackagings.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seTotalCostwPackagings.MaskSettings.Set("mask", "c");
            this.seTotalCostwPackagings.Name = "seTotalCostwPackagings";
            this.seTotalCostwPackagings.UseMaskAsDisplayFormat = true;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1009, 390);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcRecipes;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1009, 364);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.tePDFLocationTip;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 364);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1009, 26);
            this.layoutControlItem2.Text = "Tip:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(23, 16);
            // 
            // bbCopyRecipe
            // 
            this.bbCopyRecipe.Caption = "Copy Recipe";
            this.bbCopyRecipe.Id = 23;
            this.bbCopyRecipe.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.bbCopyRecipe.Name = "bbCopyRecipe";
            this.bbCopyRecipe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbCopyRecipe_ItemClick);
            // 
            // FormRecipes
            // 
            this.ActiveGlowColor = System.Drawing.Color.White;
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.BackColor2 = System.Drawing.Color.White;
            this.Appearance.BorderColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseBorderColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 522);
            this.ControlBox = false;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonControl2);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRecipes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRecipes_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tePDFLocationTip.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRecipes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRecipes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seTotalVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seTotalIngredientCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seTotalCostwPackagings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
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
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Ribbon.RibbonPage Recipes;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgIngredients;
        private DevExpress.XtraGrid.GridControl gcRecipes;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRecipes;
        private DevExpress.XtraGrid.Columns.GridColumn gcRecipeName;
        private DevExpress.XtraGrid.Columns.GridColumn gcRecipeCategory;
        private DevExpress.XtraGrid.Columns.GridColumn gcTotalVolume;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit seTotalVolume;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gcTotalIngredientCost;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit seTotalIngredientCost;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn gcTotalCostwPackagings;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit seTotalCostwPackagings;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarButtonItem bbEditRecipe;
        private DevExpress.XtraBars.BarButtonItem bbRemoveRecipe;
        private DevExpress.XtraBars.BarButtonItem bbViewPDF;
        private DevExpress.XtraEditors.TextEdit tePDFLocationTip;
        private DevExpress.XtraBars.BarStaticItem bscRecipeLocation;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbCopyRecipe;
    }
}