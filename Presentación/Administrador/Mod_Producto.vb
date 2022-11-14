Public Class Mod_Producto
    Public fila As Integer
    Private objNProductos As NProducto = New NProducto
    Private objDProductos As DProducto = New DProducto
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
        If Not Char.IsNumber(Strings.Right(precio, 1)) Then
            ErrorProviderPrecio2.SetError(TBPrecio, "Debe ingresar un numero valido")
            Ask = True
        Else
            ErrorProviderPrecio.Clear()
        End If
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
            Ask = True
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

    Private Sub TBPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBPrecio.KeyPress
        ErrorProviderPrecio.Clear()
        Dim tecla As Short = Asc(e.KeyChar)
        Dim dis As Integer = CInt(TBPrecio.TextLength)

        If TBPrecio.TextLength = 0 Then
            If Char.IsNumber(e.KeyChar) Or e.KeyChar = Chr(Keys.Delete) Or e.KeyChar = Chr(Keys.Back) Or e.KeyChar = Chr(Keys.OemPeriod) Then
            Else
                e.Handled = True
            End If
        ElseIf e.KeyChar = "." And TBPrecio.Text.Contains(".") Then
            e.Handled = True
        ElseIf TBPrecio.Text.Contains(".") Then
            If TBPrecio.Text.Substring(TBPrecio.Text.IndexOf(".")).Length >= 3 Then
                e.Handled = True
                If e.KeyChar = Chr(Keys.Delete) Or e.KeyChar = Chr(Keys.Back) Then
                    e.Handled = False
                End If
            ElseIf tecla >= 48 And tecla <= 57 Or tecla = 8 Or e.KeyChar = Chr(Keys.Delete) Or e.KeyChar = Chr(Keys.Back) Then
            End If
        ElseIf Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.OemPeriod) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BModificarProducto_Click(sender As Object, e As EventArgs) Handles BModificarProducto.Click
        If EspacioEnBlanco() = False Then
            Dim nombre As String = TBNombre.Text.Trim
            Dim categoria As Integer = CBCategoria.SelectedValue
            Dim precio As Decimal = CDec(TBPrecio.Text.Trim)
            Dim marca As String = CBMarca.SelectedValue
            Dim ask = MsgBox("Seguro que desea modificar este producto", vbQuestion + vbYesNo, "Confirmar Modificación")
            If ask = vbYes Then
                If objDProductos.modProducto(fila, nombre, categoria, precio, marca) Then
                    MsgBox("El producto se ha modificado con exito", vbInformation, "Modificacion exitosa")
                    Me.Close()
                Else
                    MsgBox("No se ha podido modificar el producto")
                End If

            End If
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