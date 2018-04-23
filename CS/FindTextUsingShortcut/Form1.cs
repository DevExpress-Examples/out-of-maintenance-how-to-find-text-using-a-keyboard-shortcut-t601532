using DevExpress.Pdf;
using DevExpress.XtraPdfViewer;
using System;
using System.Windows.Forms;

namespace FindTextUsingShortcut {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            pdfViewer1.LoadDocument(@"..\..\Report.pdf");
        }

        private void pdfViewer1_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyData == Keys.F3) {
                PdfTextSearchParameters parameters = new PdfTextSearchParameters();
                PdfFindDialogOptions options = pdfViewer1.FindDialogOptions;
                parameters.CaseSensitive = options.CaseSensitive;
                parameters.WholeWords = options.WholeWords;
                pdfViewer1.FindText(options.Text, parameters);
            }
        }
    }
}
