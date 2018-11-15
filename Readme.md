<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/FindTextUsingShortcut/Form1.cs) (VB: [Form1.vb](./VB/FindTextUsingShortcut/Form1.vb))
<!-- default file list end -->
# How to find text using a keyboard shortcut


This example shows how to execute the Find Next action by pressing the F3 shortcut after an end-user specified search options in the <strong>Find Text</strong> dialog. <br><br>To do this, handle the<strong> PdfViewer.KeyDown</strong> event. If the F3 key is pressed, call the overloaded <a href="https://documentation.devexpress.com/WindowsForms/DevExpress.XtraPdfViewer.PdfViewer.FindText.method(KsOC1Q)">PDFViewer.FindText </a> method and pass the text to search and search parameters obtained from the<strong> Find Text </strong>dialog to this method.  <br><br>The text search settings (e.g, search text, whole words, case sensitive) applied by an end-user in the <strong>Find Text</strong> dialog can be accessed using the<a href="https://documentation.devexpress.com/WindowsForms/DevExpress.XtraPdfViewer.PdfViewer.FindDialogOptions.property"> PdfViewer.FindDialogOptions</a> property.<br><br>

<br/>


