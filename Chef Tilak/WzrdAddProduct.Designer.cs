namespace Chef_Tilak
{
    partial class WzrdAddProduct
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
            this.wizardControl1 = new DevExpress.XtraWizard.WizardControl();
            this.wizardPage1 = new DevExpress.XtraWizard.WizardPage();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.luCategory = new DevExpress.XtraEditors.LookUpEdit();
            this.teName = new DevExpress.XtraEditors.TextEdit();
            this.seMarginInc = new DevExpress.XtraEditors.SpinEdit();
            this.seBuyPriceExc = new DevExpress.XtraEditors.SpinEdit();
            this.seSellPriceInc = new DevExpress.XtraEditors.SpinEdit();
            this.tePackaging = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            this.wizardControl1.SuspendLayout();
            this.wizardPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seMarginInc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seBuyPriceExc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seSellPriceInc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePackaging.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            this.SuspendLayout();
            // 
            // wizardControl1
            // 
            this.wizardControl1.AllowPagePadding = false;
            this.wizardControl1.Controls.Add(this.wizardPage1);
            this.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl1.ImageOptions.ImageWidth = 216;
            this.wizardControl1.Margin = new System.Windows.Forms.Padding(4);
            this.wizardControl1.MinimumSize = new System.Drawing.Size(117, 80);
            this.wizardControl1.Name = "wizardControl1";
            this.wizardControl1.NextText = "";
            this.wizardControl1.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.wizardPage1});
            this.wizardControl1.PreviousText = "";
            this.wizardControl1.ShowBackButton = false;
            this.wizardControl1.Size = new System.Drawing.Size(569, 322);
            this.wizardControl1.Text = "";
            this.wizardControl1.FinishClick += new System.ComponentModel.CancelEventHandler(this.wizardControl1_FinishClick_1);
            this.wizardControl1.CustomizeCommandButtons += new DevExpress.XtraWizard.WizardCustomizeCommandButtonsEventHandler(this.wizardControl1_CustomizeCommandButtons);
            // 
            // wizardPage1
            // 
            this.wizardPage1.AllowBack = false;
            this.wizardPage1.AllowNext = false;
            this.wizardPage1.Controls.Add(this.layoutControl1);
            this.wizardPage1.DescriptionText = "";
            this.wizardPage1.Margin = new System.Windows.Forms.Padding(4);
            this.wizardPage1.Name = "wizardPage1";
            this.wizardPage1.Size = new System.Drawing.Size(569, 184);
            this.wizardPage1.Text = "New Product";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.luCategory);
            this.layoutControl1.Controls.Add(this.teName);
            this.layoutControl1.Controls.Add(this.seMarginInc);
            this.layoutControl1.Controls.Add(this.seBuyPriceExc);
            this.layoutControl1.Controls.Add(this.seSellPriceInc);
            this.layoutControl1.Controls.Add(this.tePackaging);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(569, 184);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // luCategory
            // 
            this.luCategory.Location = new System.Drawing.Point(109, 64);
            this.luCategory.Name = "luCategory";
            this.luCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luCategory.Size = new System.Drawing.Size(240, 22);
            this.luCategory.StyleController = this.layoutControl1;
            this.luCategory.TabIndex = 3;
            // 
            // teName
            // 
            this.teName.Location = new System.Drawing.Point(109, 12);
            this.teName.Name = "teName";
            this.teName.Size = new System.Drawing.Size(448, 22);
            this.teName.StyleController = this.layoutControl1;
            this.teName.TabIndex = 0;
            // 
            // seMarginInc
            // 
            this.seMarginInc.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seMarginInc.Location = new System.Drawing.Point(109, 118);
            this.seMarginInc.Name = "seMarginInc";
            this.seMarginInc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seMarginInc.Properties.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.seMarginInc.Properties.MaskSettings.Set("mask", "p");
            this.seMarginInc.Properties.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seMarginInc.Properties.UseMaskAsDisplayFormat = true;
            this.seMarginInc.Size = new System.Drawing.Size(240, 24);
            this.seMarginInc.StyleController = this.layoutControl1;
            this.seMarginInc.TabIndex = 5;
            this.seMarginInc.EditValueChanged += new System.EventHandler(this.seMargin_EditValueChanged);
            // 
            // seBuyPriceExc
            // 
            this.seBuyPriceExc.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seBuyPriceExc.Location = new System.Drawing.Point(109, 90);
            this.seBuyPriceExc.Name = "seBuyPriceExc";
            this.seBuyPriceExc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seBuyPriceExc.Properties.MaskSettings.Set("mask", "c");
            this.seBuyPriceExc.Properties.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.seBuyPriceExc.Properties.UseMaskAsDisplayFormat = true;
            this.seBuyPriceExc.Size = new System.Drawing.Size(240, 24);
            this.seBuyPriceExc.StyleController = this.layoutControl1;
            this.seBuyPriceExc.TabIndex = 4;
            this.seBuyPriceExc.EditValueChanged += new System.EventHandler(this.seBuyPriceExc_EditValueChanged);
            // 
            // seSellPriceInc
            // 
            this.seSellPriceInc.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seSellPriceInc.Location = new System.Drawing.Point(109, 146);
            this.seSellPriceInc.Name = "seSellPriceInc";
            this.seSellPriceInc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seSellPriceInc.Properties.MaskSettings.Set("mask", "c");
            this.seSellPriceInc.Properties.MaxValue = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.seSellPriceInc.Properties.UseMaskAsDisplayFormat = true;
            this.seSellPriceInc.Size = new System.Drawing.Size(240, 24);
            this.seSellPriceInc.StyleController = this.layoutControl1;
            this.seSellPriceInc.TabIndex = 6;
            this.seSellPriceInc.EditValueChanged += new System.EventHandler(this.seSellPriceInc_EditValueChanged);
            // 
            // tePackaging
            // 
            this.tePackaging.Location = new System.Drawing.Point(109, 38);
            this.tePackaging.Name = "tePackaging";
            this.tePackaging.Size = new System.Drawing.Size(448, 22);
            this.tePackaging.StyleController = this.layoutControl1;
            this.tePackaging.TabIndex = 2;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem7,
            this.layoutControlItem4,
            this.layoutControlItem6,
            this.layoutControlItem5,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(569, 184);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.teName;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(549, 26);
            this.layoutControlItem1.Text = "Name";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(85, 16);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(341, 52);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(208, 112);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.seBuyPriceExc;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 78);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(341, 28);
            this.layoutControlItem7.Text = "Buy Price (Exc)";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(85, 16);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.seSellPriceInc;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 134);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(341, 30);
            this.layoutControlItem4.Text = "Sell Price (Inc)";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(85, 16);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.luCategory;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 52);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(341, 26);
            this.layoutControlItem6.Text = "Category";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(85, 16);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.seMarginInc;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 106);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(341, 28);
            this.layoutControlItem5.Text = "Margin (Inc)";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(85, 16);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.tePackaging;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(549, 26);
            this.layoutControlItem2.Text = "Packaging";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(85, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.luCategory;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem3.Name = "layoutControlItem6";
            this.layoutControlItem3.Size = new System.Drawing.Size(719, 26);
            this.layoutControlItem3.Text = "Store:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(108, 16);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 137);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(725, 25);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(51, 16);
            // 
            // WzrdAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 322);
            this.ControlBox = false;
            this.Controls.Add(this.wizardControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WzrdAddProduct";
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.wizardControl1.ResumeLayout(false);
            this.wizardPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.luCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seMarginInc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seBuyPriceExc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seSellPriceInc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePackaging.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWizard.WizardControl wizardControl1;
        private DevExpress.XtraWizard.WizardPage wizardPage1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit teName;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.LookUpEdit luCategory;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.SpinEdit seBuyPriceExc;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SpinEdit seMarginInc;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraEditors.SpinEdit seSellPriceInc;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.TextEdit tePackaging;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}