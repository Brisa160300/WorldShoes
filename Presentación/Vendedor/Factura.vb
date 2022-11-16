Imports System.Drawing.Printing
Public Class Factura
    Public nroFactura As Integer
    Public nrovendedor As Integer
    Public printline = 0
    Public contador = 0
    Public posicionencabezado = AñadirVentas.Top

    Private Sub Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BImprimri_Click(sender As Object, e As EventArgs) Handles BImprimir.Click
        printline = 0
        contador = 0

        PrintDialog1.Document = PrintDocument1
        BImprimir.Visible = False


        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.WindowState = FormWindowState.Maximized
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim titulo As New Font("Britannic", 22)
        Dim subtitulo As New Font("Arial", 16)
        Dim negrita As New Font("Arial", 9, FontStyle.Bold)
        Dim detalles As New Font("Arial", 22)
        e.Graphics.DrawString(AñadirVentas.LTituloVentas.Text, titulo, Brushes.Black, AñadirVentas.LTituloVentas.Left, AñadirVentas.Top)
        e.Graphics.DrawString(AñadirVentas.LNombreCli.Text, subtitulo, Brushes.Black, AñadirVentas.LNombreCli.Left, AñadirVentas.Top)

    End Sub
End Class