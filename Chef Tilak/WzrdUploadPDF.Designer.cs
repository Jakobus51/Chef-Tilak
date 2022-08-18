namespace Chef_Tilak
{
    partial class WzrdUploadPDF
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
            this.wizardControl1 = new DevExpress.XtraWizard.WizardControl();
            this.wizardPage1 = new DevExpress.XtraWizard.WizardPage();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.sbUploadPDF = new DevExpress.XtraEditors.SimpleButton();
            this.tePDFFilePath = new DevExpress.XtraEditors.TextEdit();
            this.cbeSuppliers = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ofdUploadPDF = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            this.wizardControl1.SuspendLayout();
            this.wizardPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tePDFFilePath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeSuppliers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
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
            this.wizardPage1.Text = "Upload a PDf of a supplier";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.sbUploadPDF);
            this.layoutControl1.Controls.Add(this.tePDFFilePath);
            this.layoutControl1.Controls.Add(this.cbeSuppliers);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(569, 184);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // sbUploadPDF
            // 
            this.sbUploadPDF.Location = new System.Drawing.Point(12, 38);
            this.sbUploadPDF.Name = "sbUploadPDF";
            this.sbUploadPDF.Size = new System.Drawing.Size(102, 27);
            this.sbUploadPDF.StyleController = this.layoutControl1;
            this.sbUploadPDF.TabIndex = 6;
            this.sbUploadPDF.Text = "Select PDF";
            this.sbUploadPDF.Click += new System.EventHandler(this.sbUploadPDF_Click);
            // 
            // tePDFFilePath
            // 
            this.tePDFFilePath.Enabled = false;
            this.tePDFFilePath.Location = new System.Drawing.Point(118, 38);
            this.tePDFFilePath.Name = "tePDFFilePath";
            this.tePDFFilePath.Size = new System.Drawing.Size(439, 22);
            this.tePDFFilePath.StyleController = this.layoutControl1;
            this.tePDFFilePath.TabIndex = 5;
            // 
            // cbeSuppliers
            // 
            this.cbeSuppliers.EditValue = "BHVC";
            this.cbeSuppliers.Location = new System.Drawing.Point(115, 12);
            this.cbeSuppliers.Name = "cbeSuppliers";
            this.cbeSuppliers.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cbeSuppliers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeSuppliers.Properties.Items.AddRange(new object[] {
            "BHVC",
            "Hanos",
            "Flexivers",
            "Makro"});
            this.cbeSuppliers.Size = new System.Drawing.Size(442, 22);
            this.cbeSuppliers.StyleController = this.layoutControl1;
            this.cbeSuppliers.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(569, 184);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cbeSuppliers;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(549, 26);
            this.layoutControlItem1.Text = "Select Supplier:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(91, 16);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 57);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(549, 107);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.tePDFFilePath;
            this.layoutControlItem2.Location = new System.Drawing.Point(106, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(443, 31);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.sbUploadPDF;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(106, 31);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 137);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(725, 25);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(51, 16);
            // 
            // ofdUploadPDF
            // 
            this.ofdUploadPDF.FileName = "Select a PDF";
            this.ofdUploadPDF.Filter = "PDF FIles|*.PDF;*.pdf;";
            this.ofdUploadPDF.Title = "Upload PDF";
            // 
            // WzrdUploadPDF
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
            this.Name = "WzrdUploadPDF";
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.wizardControl1.ResumeLayout(false);
            this.wizardPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tePDFFilePath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeSuppliers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWizard.WizardControl wizardControl1;
        private DevExpress.XtraWizard.WizardPage wizardPage1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraEditors.SimpleButton sbUploadPDF;
        private DevExpress.XtraEditors.TextEdit tePDFFilePath;
        private DevExpress.XtraEditors.ComboBoxEdit cbeSuppliers;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.XtraOpenFileDialog ofdUploadPDF;
    }
}