Public Class añadirProducto

    'botón "añadir" del formulario añadir producto.
    Private Sub BAñadirProducto_Click(sender As Object, e As EventArgs) Handles BAñadirProducto.Click
        Dim Ask As MsgBoxResult

        If EspacioEnBlanco() = False Then
            Ask = MsgBox("Seguro que desea añadir este producto?", vbQuestion + vbYesNo, "Confirmar Inserción")
            If Ask = vbYes Then
                MsgBox("El producto" + TBNombreProducto.Text + "se insertó correctamente", vbInformation, "Guardar")
            End If
        End If
    End Sub

    Private Sub BCancelProducto_Click(sender As Object, e As EventArgs) Handles BCancelProducto.Click
        Dim Ask As MsgBoxResult

        If EspacioEnBlanco() = False Then
            Ask = MsgBox("Seguro que desea cancelar el registro del producto?", vbQuestion + vbYesNo, "Confirmar Inserción")
            If Ask = vbYes Then
                MsgBox("Se ha cancelado la operación de registro.", vbInformation, "Cancelar")
            End If
        Else
            Me.Close()
        End If
    End Sub

    Public Function EspacioEnBlanco()
        Dim Ask As MsgBoxResult
        Dim nombre As String = TBNombreProducto.Text
        Dim categoria As String = TBCateoriaProducto.Text
        Dim stock As String = TBStock.Text
        Dim precio As String = TBPrecio.Text
        'Dim imagen As String = TBImagen.Text

        If String.IsNullOrWhiteSpace(nombre) Or
           String.IsNullOrWhiteSpace(categoria) Or
           String.IsNullOrWhiteSpace(stock) Or
           String.IsNullOrWhiteSpace(precio) Then
            'String.IsNullOrWhiteSpace(imagen) Then
            Ask = MsgBox("Debe Completar todos los campos", vbCritical, "Error")
            Return Ask
        Else
            Return False
        End If
    End Function

End Class