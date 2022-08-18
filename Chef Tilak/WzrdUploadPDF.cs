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
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using iText.Kernel.Pdf.Canvas.Parser;

namespace Chef_Tilak
{
    public partial class WzrdUploadPDF : DevExpress.XtraEditors.XtraForm
    {
        public List<Packaging> Packagings;
        public ProjectData ProjectData;

        public WzrdUploadPDF(ProjectData projectData)
        {
            ProjectData = projectData;

            InitializeComponent();


        }

        

        private void wizardControl1_CustomizeCommandButtons(object sender, DevExpress.XtraWizard.CustomizeCommandButtonsEventArgs e)
        {
            e.PrevButton.Visible = false;
        }


        private void sbUploadPDF_Click(object sender, EventArgs e)
        {
            if (ofdUploadPDF.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    tePDFFilePath.Text = ofdUploadPDF.FileName;

                }
                catch (TaskCanceledException ex)
                {
                    MessageBox.Show($"Task error.\n\nError message: {ex.Message}\n\n" + $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        public string ExtractTextFromPDF()
        {
            string pageContent = "";
            PdfReader pdfReader = new PdfReader(tePDFFilePath.Text);
            PdfDocument pdfDoc = new PdfDocument(pdfReader);
            for (int page = 1; page <= pdfDoc.GetNumberOfPages(); page++)
            {
                ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                pageContent = PdfTextExtractor.GetTextFromPage(pdfDoc.GetPage(page), strategy);
            }
            pdfDoc.Close();
            pdfReader.Close();

            return pageContent;
        }

        public List<Ingredient> ExtractIngredientsFromText(string pageContent)
        {
            List<Ingredient> IngredientsToAdd = new();
            switch (cbeSuppliers.Text)
            {
                case "BHVC":

                    int startIndex = pageContent.IndexOf("Leveradres:");
                    int endIndex = pageContent.IndexOf("Totaal BTW Totaal");

                    string subPageContect = pageContent.Substring(startIndex, endIndex - startIndex);
                    string[] seperators = { "\r\n", "\r", "\n" };
                    string[] ingredientText = subPageContect.Split(seperators, StringSplitOptions.RemoveEmptyEntries);
                    string[] ingredientTextClean = ingredientText.Skip(1).ToArray();
                    ingredientTextClean = ingredientTextClean.SkipLast(1).ToArray();
                    return IngredientsToAdd;


                case "Flexivers":
                    return IngredientsToAdd;


                case "Hanos":
                    return IngredientsToAdd;


                case "Makro":
                    return IngredientsToAdd;


                default:
                    return IngredientsToAdd;
            }
        }
        private void wizardControl1_FinishClick_1(object sender, CancelEventArgs e)
        {
            if (CheckData())
            {
                string pageContent = ExtractTextFromPDF();
                List<Ingredient> IngredientsToAdd = ExtractIngredientsFromText(pageContent);


            }
            else
            {
                e.Cancel = true;
            }
        }



        public bool CheckData()
        {
            if (string.IsNullOrEmpty(tePDFFilePath.Text))
            {
                string message = "Please upload a pdf first.";
                string title = "Error";
                MessageBox.Show(message, title);

                return false;
            }

            return true;
        }


    }
}
