Public Class AñadirProducto

    Private objDProducto = New DProducto
    Private objNProducto = New NProducto
    Private objNtalleProd = New NTalle_Producto


    Public Function EspacioEnBlanco()
        Dim Ask As Boolean = False
        Dim codigo As String = TBCodProducto.Text
        Dim nombre As String = TBNombreProducto.Text.Trim
        Dim categoria As String = CBCategoria.Text.Trim
        Dim stock As String = TBStock.Text.Trim
        Dim precio As String = TBPrecio.Text.Trim
        Dim talle As String = CBTalle.Text.Trim
        Dim marca As String = CBMarca.Text.Trim
        If Not Char.IsNumber(Strings.Right(precio, 1)) Then
            ErrorProviderPrecio2.SetError(TBPrecio, "Debe ingresar un numero valido")
            Ask = True
        Else
            ErrorProviderPrecio.Clear()
        End If
        If codigo = "" Then
            ErrorProviderCodigo.SetError(TBCodProducto, "Ingrese el codigo del producto")
            Ask = True
        ElseIf CInt(codigo) = 0 Then
            ErrorProviderCodigo.SetError(TBCodProducto, "El codigo ingresado no puede ser 0")
            Ask = True
        End If
        If nombre = "" Then
            ErrorProviderNombre.SetError(TBNombreProducto, "Ingrese el nombre del producto")
            Ask = True
        ElseIf nombre.Length < 3 Then
            ErrorProviderNombre.SetError(TBNombreProducto, "El nombre ingresado debe tener minimo 5 caracteres")
            Ask = True
        End If
        If categoria = "" Then
            ErrorProviderCategoria.SetError(CBCategoria, "Seleccione una categoria")
            Ask = True
        End If
        If stock = "" Then
            ErrorProviderStock.SetError(TBStock, "Ingrese un stock")
            Ask = True

        ElseIf CInt(stock) <= 100 Then
            ErrorProviderStock.SetError(TBStock, "El stock minimo es de 100 unidades")
            Ask = True
        ElseIf CInt(stock) > 1000 Then
            ErrorProviderStock.SetError(TBStock, "El stock maximo es de 1000 unidades")
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
        If talle = "" Then
            ErrorProviderTalle.SetError(CBTalle, "Seleccione un talle")
            Ask = True
        End If
        Return Ask
    End Function
    'botón "añadir" del formulario añadir producto.
    Private Sub BAñadirProducto_Click(sender As Object, e As EventArgs) Handles BAñadirProducto.Click
        Dim Ask As MsgBoxResult
        ErrorProviderCodigo.Clear()
        ErrorProviderNombre.Clear()
        ErrorProviderCategoria.Clear()
        ErrorProviderPrecio.Clear()
        ErrorProviderStock.Clear()
        ErrorProviderTalle.Clear()
        ErrorProviderMarca.Clear()
        If EspacioEnBlanco() = False Then
            Dim codigo As Integer = CInt(TBCodProducto.Text)
            Dim nombre As String = TBNombreProducto.Text
            Dim categoria As Integer = CBCategoria.SelectedValue
            Dim stock As Integer = CInt(TBStock.Text)
            Dim precio As Decimal = CDec(TBPrecio.Text)
            Dim talle As Integer = CBTalle.SelectedValue
            Dim marca As Integer = CBMarca.SelectedValue
            Ask = MsgBox("Seguro que desea añadir este producto?", vbQuestion + vbYesNo, "Confirmar Inserción")
            If Ask = vbYes Then
                If objNProducto.agregar_Producto(codigo, nombre, categoria, precio, marca) Then
                    If objNtalleProd.agregar_talle_producto(codigo, talle, stock) Then
                        objNProducto.cargarGrid(dgvListaProductos)
                    End If
                    MsgBox("El producto" + TBNombreProducto.Text + "se insertó correctamente", vbInformation, "Guardar")
                Else
                    MsgBox("El producto ya se encuentra registrado", vbCritical, "Error")
                End If

            End If
        End If
    End Sub

    Private Sub BVolver_Click(sender As Object, e As EventArgs) Handles BVolver.Click, BVolver.Click
        Me.Close()
    End Sub

    Private Sub TBnumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBStock.KeyPress, TBCodProducto.KeyPress
        ErrorProviderPrecio.Clear()
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.OemPeriod) Then
            e.Handled = True
            MsgBox("Solo se aceptan caracteres numericos")
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
        objDProducto.getProductosAll(dgvListaProductos)
    End Sub

    Private Sub TBPrecio_TextChanged(sender As Object, e As EventArgs) Handles TBPrecio.TextChanged
        If Not Char.IsNumber(Strings.Right(TBPrecio.Text, 1)) Then
            ErrorProviderPrecio2.SetError(TBPrecio, "Debe ingresar un numero valido")
        Else
            ErrorProviderPrecio2.Clear()
        End If
    End Sub
End Class