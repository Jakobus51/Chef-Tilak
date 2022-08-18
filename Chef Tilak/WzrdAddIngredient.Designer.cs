namespace Chef_Tilak
{
    partial class WzrdAddIngredient
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
            this.luUnit = new DevExpress.XtraEditors.LookUpEdit();
            this.luStore = new DevExpress.XtraEditors.LookUpEdit();
            this.teName = new DevExpress.XtraEditors.TextEdit();
            this.seTax = new DevExpress.XtraEditors.SpinEdit();
            this.seQuantity = new DevExpress.XtraEditors.SpinEdit();
            this.sePriceExc = new DevExpress.XtraEditors.SpinEdit();
            this.sePriceInc = new DevExpress.XtraEditors.SpinEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            this.wizardControl1.SuspendLayout();
            this.wizardPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luStore.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seTax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sePriceExc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sePriceInc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
            this.SuspendLayout();
            // 
            // wizardControl1
            // 
            this.wizardControl1.AllowPagePadding = false;
            this.wizardControl1.Controls.Add(this.wizardPage1);
            this.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl1.ImageOptions.ImageWidth = 216;
            this.wizardControl1.Margin = new System.Windows.Forms.Padding(4);
            this.wizardControl1.MinimumSize = new System.Drawing.Size(117, 110);
            this.wizardControl1.Name = "wizardControl1";
            this.wizardControl1.NextText = "";
            this.wizardControl1.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.wizardPage1});
            this.wizardControl1.PreviousText = "";
            this.wizardControl1.ShowBackButton = false;
            this.wizardControl1.Size = new System.Drawing.Size(569, 296);
            this.wizardControl1.Text = "";
            this.wizardControl1.FinishClick += new System.ComponentModel.CancelEventHandler(this.wizardControl1_FinishClick);
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
            this.wizardPage1.Size = new System.Drawing.Size(569, 158);
            this.wizardPage1.Text = "New Ingredient";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.luUnit);
            this.layoutControl1.Controls.Add(this.luStore);
            this.layoutControl1.Controls.Add(this.teName);
            this.layoutControl1.Controls.Add(this.seTax);
            this.layoutControl1.Controls.Add(this.seQuantity);
            this.layoutControl1.Controls.Add(this.sePriceExc);
            this.layoutControl1.Controls.Add(this.sePriceInc);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(569, 158);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // luUnit
            // 
            this.luUnit.Location = new System.Drawing.Point(225, 92);
            this.luUnit.Name = "luUnit";
            this.luUnit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luUnit.Size = new System.Drawing.Size(88, 22);
            this.luUnit.StyleController = this.layoutControl1;
            this.luUnit.TabIndex = 5;
            // 
            // luStore
            // 
            this.luStore.Location = new System.Drawing.Point(75, 38);
            this.luStore.Name = "luStore";
            this.luStore.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luStore.Size = new System.Drawing.Size(238, 22);
            this.luStore.StyleController = this.layoutControl1;
            this.luStore.TabIndex = 2;
            // 
            // teName
            // 
            this.teName.Location = new System.Drawing.Point(75, 12);
            this.teName.Name = "teName";
            this.teName.Size = new System.Drawing.Size(482, 22);
            this.teName.StyleController = this.layoutControl1;
            this.teName.TabIndex = 0;
            // 
            // seTax
            // 
            this.seTax.EditValue = new decimal(new int[] {
            9,
            0,
            0,
            131072});
            this.seTax.Location = new System.Drawing.Point(75, 64);
            this.seTax.Name = "seTax";
            this.seTax.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seTax.Properties.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.seTax.Properties.MaskSettings.Set("mask", "p");
            this.seTax.Properties.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seTax.Properties.UseMaskAsDisplayFormat = true;
            this.seTax.Size = new System.Drawing.Size(238, 24);
            this.seTax.StyleController = this.layoutControl1;
            this.seTax.TabIndex = 3;
            this.seTax.EditValueChanged += new System.EventHandler(this.seTax_EditValueChanged);
            // 
            // seQuantity
            // 
            this.seQuantity.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seQuantity.Location = new System.Drawing.Point(75, 92);
            this.seQuantity.Name = "seQuantity";
            this.seQuantity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seQuantity.Properties.MaskSettings.Set("mask", "");
            this.seQuantity.Properties.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.seQuantity.Size = new System.Drawing.Size(83, 24);
            this.seQuantity.StyleController = this.layoutControl1;
            this.seQuantity.TabIndex = 4;
            // 
            // sePriceExc
            // 
            this.sePriceExc.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sePriceExc.Location = new System.Drawing.Point(75, 120);
            this.sePriceExc.Name = "sePriceExc";
            this.sePriceExc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sePriceExc.Properties.MaskSettings.Set("mask", "c");
            this.sePriceExc.Properties.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.sePriceExc.Properties.UseMaskAsDisplayFormat = true;
            this.sePriceExc.Size = new System.Drawing.Size(83, 24);
            this.sePriceExc.StyleController = this.layoutControl1;
            this.sePriceExc.TabIndex = 7;
            this.sePriceExc.EditValueChanged += new System.EventHandler(this.sePriceExc_EditValueChanged);
            // 
            // sePriceInc
            // 
            this.sePriceInc.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sePriceInc.Location = new System.Drawing.Point(225, 118);
            this.sePriceInc.Name = "sePriceInc";
            this.sePriceInc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sePriceInc.Properties.MaskSettings.Set("mask", "c");
            this.sePriceInc.Properties.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.sePriceInc.Properties.UseMaskAsDisplayFormat = true;
            this.sePriceInc.Size = new System.Drawing.Size(88, 24);
            this.sePriceInc.StyleController = this.layoutControl1;
            this.sePriceInc.TabIndex = 6;
            this.sePriceInc.EditValueChanged += new System.EventHandler(this.sePriceInc_EditValueChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem4,
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.layoutControlItem7,
            this.layoutControlItem8});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(569, 158);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.teName;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(549, 26);
            this.layoutControlItem1.Text = "Name";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(51, 16);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.seTax;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 52);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(305, 28);
            this.layoutControlItem5.Text = "Tax";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(51, 16);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.luStore;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(305, 26);
            this.layoutControlItem6.Text = "Store";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(51, 16);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.luUnit;
            this.layoutControlItem4.Location = new System.Drawing.Point(150, 80);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(155, 26);
            this.layoutControlItem4.Text = "Unit";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(51, 16);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.seQuantity;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 80);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(150, 28);
            this.layoutControlItem2.Text = "Quantity";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(51, 16);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(305, 26);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(244, 112);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.sePriceExc;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 108);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(150, 30);
            this.layoutControlItem7.Text = "Price Exc";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(51, 16);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.sePriceInc;
            this.layoutControlItem8.Location = new System.Drawing.Point(150, 106);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(155, 32);
            this.layoutControlItem8.Text = "Price Inc";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(51, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.luStore;
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
            // layoutControlItem14
            // 
            this.layoutControlItem14.Location = new System.Drawing.Point(0, 164);
            this.layoutControlItem14.Name = "layoutControlItem14";
            this.layoutControlItem14.Size = new System.Drawing.Size(651, 51);
            this.layoutControlItem14.TextSize = new System.Drawing.Size(115, 16);
            // 
            // WzrdAddIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 296);
            this.ControlBox = false;
            this.Controls.Add(this.wizardControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WzrdAddIngredient";
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.wizardControl1.ResumeLayout(false);
            this.wizardPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.luUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luStore.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seTax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sePriceExc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sePriceInc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWizard.WizardControl wizardControl1;
        private DevExpress.XtraWizard.WizardPage wizardPage1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit teName;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.LookUpEdit luStore;
        private DevExpress.XtraEditors.SpinEdit sePriceExc;
        private DevExpress.XtraEditors.SpinEdit sePriceInc;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SpinEdit seTax;
        private DevExpress.XtraEditors.SpinEdit seQuantity;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraEditors.LookUpEdit luUnit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem14;
    }
}