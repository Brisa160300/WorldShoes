Imports System
Imports System.Collections.Generic
Imports System.Threading.Tasks
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO
Imports System.Windows.form

Public Class Procesar_PDF
    Dim docPdf As Document = New Document
    Dim img As iTextSharp.text.Image
    Dim dc As PdfContentByte
    Dim ruta As String
    Dim x, y As Integer
    Dim pdfw As iTextSharp.text.pdf.PdfWriter

    Public rutadirectorio As String = Application.StartupPath + "\\facturasPdf"
    Public nombreArchivo As String
    Public Sub crearDirectorio()
        If Not (Directory.Exists(rutadirectorio)) Then
            Directory.CreateDirectory(rutadirectorio)
        End If
    End Sub

    Public Sub crearPDF(fac As datos_factura, grid As DataGridView)

        crearDirectorio()
        ruta = rutadirectorio + "\\" + "Comprobante" + ".pdf"
        pdfw = PdfWriter.GetInstance(docPdf, New FileStream(ruta, FileMode.Create))
        docPdf.Open()
        dc = pdfw.DirectContent
        dc.SetColorFill(BaseColor.WHITE)
        Dim fotoPDF = iTextSharp.text.Image.GetInstance("background2.jpg")
        fotoPDF.BackgroundColor = BaseColor.BLACK
        fotoPDF.ScaleAbsolute(50, 50)
        docPdf.Add(fotoPDF)
        docPdf.Close()


    End Sub


End Class



