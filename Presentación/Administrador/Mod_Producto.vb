Public Class Mod_Producto
    Public fila As Integer
    Private objNProductos As NProducto = New NProducto
    Public categdesc As String
    Public marcadesc As String
    Private Sub BCancelarModifCliente_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Public Function EspacioEnBlanco()
        Dim Ask As Boolean = False
        Dim nombre As String = TBNombre.Text.Trim
        Dim categoria As String = CBCategoria.Text.Trim
        Dim precio As String = TBPrecio.Text.Trim
        Dim marca As String = CBMarca.Text.Trim
        If nombre = "" Then
            ErrorProviderNombre.SetError(TBNombre, "Ingrese el nombre del producto")
            Ask = True
        ElseIf nombre.Length < 3 Then
            ErrorProviderNombre.SetError(TBNombre, "El nombre ingresado debe tener minimo 5 caracteres")
            Ask = True
        End If
        If categoria = "" Then
            ErrorProviderCategoria.SetError(CBCategoria, "Seleccione una categoria")
            Ask = True
        End If
        If precio = "" Then
            ErrorProviderPrecio.SetError(TBPrecio, "Ingrese un precio")
        ElseIf CDec(precio) <= 500 Then
            ErrorProviderPrecio.SetError(TBPrecio, "El precio minimo es de $500")
            Ask = True
        End If
        If marca = "" Then
            ErrorProviderMarca.SetError(CBMarca, "Seleccione una marca")
            Ask = True
        End If
        Return Ask
    End Function

    Private Sub TBCodigoProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBPrecio.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan caracteres númericos", vbCritical, "Error")
        End If
    End Sub
    Private Sub TBNombreProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBNombre.KeyPress

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

    Private Sub ModificarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objNProductos.cargarComboxCateg2(CBCategoria, categdesc)
        objNProductos.cargarComboxMarca2(CBMarca, marcadesc)
    End Sub
End Class