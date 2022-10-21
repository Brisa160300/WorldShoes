Public Class AñadirProducto

    Private objDProducto = New DProducto
    Private objNProducto = New NProducto
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

    Private Sub BVolver_Click(sender As Object, e As EventArgs) Handles BVolver.Click, BVolver.Click
        Me.Close()
    End Sub

    Public Function EspacioEnBlanco()
        Dim Ask As MsgBoxResult
        Dim nombre As String = TBNombreProducto.Text
        Dim categoria As String = CBCategoria.Text
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

    Private Sub TBPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBStock.KeyPress, TBPrecio.KeyPress

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

    Private Sub AñadirProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objNProducto.cargarComboxCateg(CBCategoria)
        objNProducto.cargarComboxMarca(CBMarca)
        objNProducto.cargarComboxTalle(CBTalle)
    End Sub
End Class