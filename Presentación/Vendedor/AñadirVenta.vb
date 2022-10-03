Public Class AñadirVenta
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

    Private Sub TBNroFactura_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBNroFactura.KeyPress, TBStock.KeyPress, TBPrecio.KeyPress, TBDniCliVenta.KeyPress, TBCantidad.KeyPress, TBCantidad.KeyPress, TBStock.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan caracteres númericos", vbCritical, "Error")
        End If
    End Sub

    Private Sub TBNombreCliVenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBNombreCliVenta.KeyPress, TBProductoVenta.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan letras", vbCritical, "Error")

        End If
    End Sub

End Class