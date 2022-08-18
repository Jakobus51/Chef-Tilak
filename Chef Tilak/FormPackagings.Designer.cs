namespace Chef_Tilak
{
    partial class FormPackagings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPackagings));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gcPackaging = new DevExpress.XtraGrid.GridControl();
            this.gvPackaging = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcPackagingName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPackagingVolume = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sePackagingVolume = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gcColorRoundSticker = new DevExpress.XtraGrid.Columns.GridColumn();
            this.luColorRoundSticker = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gcPackagingPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sePackagingPrice = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gcPackagingAdditionalCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.seAdditionalCost = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
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
            this.bbAddPackaging = new DevExpress.XtraBars.BarButtonItem();
            this.bbRemovePackaging = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgIngredients = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPackaging)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPackaging)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sePackagingVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luColorRoundSticker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sePackagingPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seAdditionalCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcPackaging);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 132);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1009, 390);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcPackaging
            // 
            this.gcPackaging.Location = new System.Drawing.Point(2, 2);
            this.gcPackaging.MainView = this.gvPackaging;
            this.gcPackaging.Name = "gcPackaging";
            this.gcPackaging.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.sePackagingVolume,
            this.sePackagingPrice,
            this.luColorRoundSticker,
            this.seAdditionalCost,
            this.repositoryItemSpinEdit3,
            this.repositoryItemSpinEdit4,
            this.repositoryItemSpinEdit5});
            this.gcPackaging.Size = new System.Drawing.Size(1005, 386);
            this.gcPackaging.TabIndex = 3;
            this.gcPackaging.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPackaging});
            // 
            // gvPackaging
            // 
            this.gvPackaging.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcPackagingName,
            this.gcPackagingVolume,
            this.gcColorRoundSticker,
            this.gridColumn1,
            this.gridColumn4,
            this.gcPackagingPrice,
            this.gridColumn5,
            this.gcPackagingAdditionalCost});
            this.gvPackaging.GridControl = this.gcPackaging;
            this.gvPackaging.Name = "gvPackaging";
            this.gvPackaging.OptionsFind.AlwaysVisible = true;
            this.gvPackaging.OptionsFind.FindDelay = 250;
            this.gvPackaging.OptionsView.ShowGroupPanel = false;
            this.gvPackaging.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gcPackagingName, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvPackaging.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvPackaging_CellValueChanged);
            // 
            // gcPackagingName
            // 
            this.gcPackagingName.Caption = "Name";
            this.gcPackagingName.FieldName = "Name";
            this.gcPackagingName.MinWidth = 25;
            this.gcPackagingName.Name = "gcPackagingName";
            this.gcPackagingName.Visible = true;
            this.gcPackagingName.VisibleIndex = 0;
            this.gcPackagingName.Width = 473;
            // 
            // gcPackagingVolume
            // 
            this.gcPackagingVolume.Caption = "Volume";
            this.gcPackagingVolume.ColumnEdit = this.sePackagingVolume;
            this.gcPackagingVolume.FieldName = "Volume";
            this.gcPackagingVolume.MinWidth = 25;
            this.gcPackagingVolume.Name = "gcPackagingVolume";
            this.gcPackagingVolume.Visible = true;
            this.gcPackagingVolume.VisibleIndex = 1;
            this.gcPackagingVolume.Width = 74;
            // 
            // sePackagingVolume
            // 
            this.sePackagingVolume.AutoHeight = false;
            this.sePackagingVolume.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sePackagingVolume.MaskSettings.Set("mask", "0 Units");
            this.sePackagingVolume.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.sePackagingVolume.Name = "sePackagingVolume";
            this.sePackagingVolume.UseMaskAsDisplayFormat = true;
            // 
            // gcColorRoundSticker
            // 
            this.gcColorRoundSticker.Caption = "Color Sticker";
            this.gcColorRoundSticker.ColumnEdit = this.luColorRoundSticker;
            this.gcColorRoundSticker.FieldName = "ColorRoundSticker";
            this.gcColorRoundSticker.MinWidth = 25;
            this.gcColorRoundSticker.Name = "gcColorRoundSticker";
            this.gcColorRoundSticker.Visible = true;
            this.gcColorRoundSticker.VisibleIndex = 2;
            this.gcColorRoundSticker.Width = 111;
            // 
            // luColorRoundSticker
            // 
            this.luColorRoundSticker.AutoHeight = false;
            this.luColorRoundSticker.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luColorRoundSticker.Name = "luColorRoundSticker";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tax";
            this.gridColumn1.ColumnEdit = this.repositoryItemSpinEdit3;
            this.gridColumn1.FieldName = "Tax";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 71;
            // 
            // repositoryItemSpinEdit3
            // 
            this.repositoryItemSpinEdit3.AutoHeight = false;
            this.repositoryItemSpinEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.repositoryItemSpinEdit3.MaskSettings.Set("mask", "p");
            this.repositoryItemSpinEdit3.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.repositoryItemSpinEdit3.Name = "repositoryItemSpinEdit3";
            this.repositoryItemSpinEdit3.UseMaskAsDisplayFormat = true;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Price Exc";
            this.gridColumn4.ColumnEdit = this.repositoryItemSpinEdit4;
            this.gridColumn4.FieldName = "PriceExc";
            this.gridColumn4.MinWidth = 25;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            // 
            // repositoryItemSpinEdit4
            // 
            this.repositoryItemSpinEdit4.AutoHeight = false;
            this.repositoryItemSpinEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit4.MaskSettings.Set("mask", "c");
            this.repositoryItemSpinEdit4.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.repositoryItemSpinEdit4.Name = "repositoryItemSpinEdit4";
            this.repositoryItemSpinEdit4.UseMaskAsDisplayFormat = true;
            // 
            // gcPackagingPrice
            // 
            this.gcPackagingPrice.Caption = "Price Inc";
            this.gcPackagingPrice.ColumnEdit = this.sePackagingPrice;
            this.gcPackagingPrice.FieldName = "PriceInc";
            this.gcPackagingPrice.MinWidth = 25;
            this.gcPackagingPrice.Name = "gcPackagingPrice";
            this.gcPackagingPrice.Visible = true;
            this.gcPackagingPrice.VisibleIndex = 5;
            this.gcPackagingPrice.Width = 73;
            // 
            // sePackagingPrice
            // 
            this.sePackagingPrice.AutoHeight = false;
            this.sePackagingPrice.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sePackagingPrice.MaskSettings.Set("mask", "c");
            this.sePackagingPrice.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.sePackagingPrice.Name = "sePackagingPrice";
            this.sePackagingPrice.UseMaskAsDisplayFormat = true;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Additional Exc";
            this.gridColumn5.ColumnEdit = this.repositoryItemSpinEdit5;
            this.gridColumn5.FieldName = "AdditionalCostExc";
            this.gridColumn5.MinWidth = 25;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 6;
            this.gridColumn5.Width = 120;
            // 
            // repositoryItemSpinEdit5
            // 
            this.repositoryItemSpinEdit5.AutoHeight = false;
            this.repositoryItemSpinEdit5.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit5.MaskSettings.Set("mask", "c");
            this.repositoryItemSpinEdit5.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.repositoryItemSpinEdit5.Name = "repositoryItemSpinEdit5";
            this.repositoryItemSpinEdit5.UseMaskAsDisplayFormat = true;
            // 
            // gcPackagingAdditionalCost
            // 
            this.gcPackagingAdditionalCost.Caption = "Additional Inc";
            this.gcPackagingAdditionalCost.ColumnEdit = this.seAdditionalCost;
            this.gcPackagingAdditionalCost.FieldName = "AdditionalCostInc";
            this.gcPackagingAdditionalCost.MinWidth = 25;
            this.gcPackagingAdditionalCost.Name = "gcPackagingAdditionalCost";
            this.gcPackagingAdditionalCost.Visible = true;
            this.gcPackagingAdditionalCost.VisibleIndex = 7;
            this.gcPackagingAdditionalCost.Width = 120;
            // 
            // seAdditionalCost
            // 
            this.seAdditionalCost.AutoHeight = false;
            this.seAdditionalCost.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seAdditionalCost.MaskSettings.Set("mask", "c");
            this.seAdditionalCost.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.seAdditionalCost.Name = "seAdditionalCost";
            this.seAdditionalCost.UseMaskAsDisplayFormat = true;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1009, 390);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcPackaging;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1009, 390);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
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
            this.bbAddPackaging,
            this.bbRemovePackaging,
            this.barButtonItem3,
            this.barButtonItem4});
            this.ribbonControl2.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl2.MaxItemId = 18;
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
            // bbAddPackaging
            // 
            this.bbAddPackaging.Caption = "Add Packaging";
            this.bbAddPackaging.Id = 14;
            this.bbAddPackaging.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbAddPackaging.ImageOptions.SvgImage")));
            this.bbAddPackaging.LargeWidth = 70;
            this.bbAddPackaging.Name = "bbAddPackaging";
            this.bbAddPackaging.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbAddPackaging_ItemClick);
            // 
            // bbRemovePackaging
            // 
            this.bbRemovePackaging.Caption = "Remove Packaging";
            this.bbRemovePackaging.Id = 15;
            this.bbRemovePackaging.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbRemovePackaging.ImageOptions.SvgImage")));
            this.bbRemovePackaging.LargeWidth = 70;
            this.bbRemovePackaging.Name = "bbRemovePackaging";
            this.bbRemovePackaging.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbRemovePackaging_ItemClick);
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
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5,
            this.rpgIngredients});
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
            this.rpgIngredients.ItemLinks.Add(this.bbAddPackaging);
            this.rpgIngredients.ItemLinks.Add(this.bbRemovePackaging);
            this.rpgIngredients.Name = "rpgIngredients";
            this.rpgIngredients.Text = "ribbonPageGroup1";
            // 
            // FormPackagings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 522);
            this.ControlBox = false;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPackagings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPackagings_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPackaging)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPackaging)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sePackagingVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luColorRoundSticker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sePackagingPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seAdditionalCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gcPackaging;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPackaging;
        private DevExpress.XtraGrid.Columns.GridColumn gcPackagingName;
        private DevExpress.XtraGrid.Columns.GridColumn gcPackagingVolume;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit sePackagingVolume;
        private DevExpress.XtraGrid.Columns.GridColumn gcColorRoundSticker;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit luColorRoundSticker;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit4;
        private DevExpress.XtraGrid.Columns.GridColumn gcPackagingPrice;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit sePackagingPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit5;
        private DevExpress.XtraGrid.Columns.GridColumn gcPackagingAdditionalCost;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit seAdditionalCost;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
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
        private DevExpress.XtraBars.BarButtonItem bbAddPackaging;
        private DevExpress.XtraBars.BarButtonItem bbRemovePackaging;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgIngredients;
    }
}