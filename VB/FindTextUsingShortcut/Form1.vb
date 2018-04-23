Imports DevExpress.Pdf
Imports DevExpress.XtraPdfViewer
Imports System
Imports System.Windows.Forms

Namespace FindTextUsingShortcut
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            pdfViewer1.LoadDocument("..\..\Report.pdf")
        End Sub

        Private Sub pdfViewer1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles pdfViewer1.KeyDown
            If e.KeyData = Keys.F3 Then
                Dim parameters As New PdfTextSearchParameters()
                Dim options As PdfFindDialogOptions = pdfViewer1.FindDialogOptions
                parameters.CaseSensitive = options.CaseSensitive
                parameters.WholeWords = options.WholeWords
                pdfViewer1.FindText(options.Text, parameters)
            End If
        End Sub
    End Class
End Namespace
