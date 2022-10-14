Public Class AñadirVentas
    Public Function EspacioEnBlanco()
        Dim Ask As MsgBoxResult
        Dim nroFactura As String = TBNroFactura.Text
        Dim dni As String = TBDniCliVenta.Text
        Dim nombre As String = TBNombreCliVenta.Text

        Dim producto As String = TBProductoVenta.Text
        Dim precio As String = TBPrecio.Text
        Dim stock As String = TBStock.Text
        Dim cantidad As String = TBCantidad.Text


        If String.IsNullOrWhiteSpace(nroFactura) Or
           String.IsNullOrWhiteSpace(dni) Or
           String.IsNullOrWhiteSpace(nombre) Or
           String.IsNullOrWhiteSpace(producto) Or
           String.IsNullOrWhiteSpace(precio) Or
           String.IsNullOrWhiteSpace(stock) Or
           String.IsNullOrWhiteSpace(cantidad) Then
            Ask = MsgBox("Debe Completar todos los campos", vbCritical, "Error")
            Return Ask
        Else
            Return False
        End If
    End Function

    Private Sub Cantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBCantidad.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan caracteres númericos", vbCritical, "Error")
        End If
    End Sub

    Private Sub AñadirVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BVolver_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub BBuscarProducto_Click(sender As Object, e As EventArgs) Handles BBuscarProducto.Click
        Dim frm As BuscarP = New BuscarP
        frm.ShowInTaskbar = False
        frm.ShowDialog()
        TBProductoVenta.Clear()

    End Sub

    Private Sub BuscarProducto_Click(sender As Object, e As EventArgs) Handles BuscarProducto.Click
        Dim frm As BuscarCli = New BuscarCli
        frm.ShowInTaskbar = False
        frm.ShowDialog()
        TBDniCliVenta.Clear()
    End Sub
End Class