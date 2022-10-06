Public Class ModificarProducto
    Private Sub BCancelarModifCliente_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Public Function EspacioEnBlanco()
        Dim Ask As MsgBoxResult
        Dim nombre As String = TBNombreProducto.Text
        Dim categoria As String = CBCategoriaProducto.Text
        Dim marca As String = CBMarcaProducto.Text
        Dim talle As String = CBTalleProducto.Text


        Dim precio As String = TBPrecioProducto.Text
        Dim stock As String = TBStockProducto.Text


        If String.IsNullOrWhiteSpace(nombre) Or
           String.IsNullOrWhiteSpace(categoria) Or
           String.IsNullOrWhiteSpace(marca) Or
           String.IsNullOrWhiteSpace(talle) Or
           String.IsNullOrWhiteSpace(precio) Or
           String.IsNullOrWhiteSpace(stock) Then
            Ask = MsgBox("Debe Completar todos los campos", vbCritical, "Error")
            Return Ask
        Else
            Return False
        End If
    End Function

    Private Sub TBCodigoProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBStockProducto.KeyPress, TBPrecioProducto.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan caracteres númericos", vbCritical, "Error")
        End If
    End Sub
    Private Sub TBNombreProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBNombreProducto.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan letras", vbCritical, "Error")
        End If
    End Sub

    Private Sub BModificarProducto_Click(sender As Object, e As EventArgs)
        If EspacioEnBlanco() = False Then
            MsgBox("Seguro que desea modificar este producto", vbQuestion + vbYesNo, "Confirmar Modificación")
        End If
    End Sub

    Private Sub BCancelarModifCliente_Click_1(sender As Object, e As EventArgs) Handles BCancelarModifCliente.Click
        Me.Close()
    End Sub
End Class