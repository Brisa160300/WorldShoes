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
        Dim fac As datos_factura = New datos_factura
        fac.Id_factura = 1
        fac.Cliente = TBCliente.Text
        Dim pdf As Procesar_PDF = New Procesar_PDF
        pdf.crearPDF(fac, dgvVentas)
    End Sub

End Class