﻿Public Class AñadirProducto

    Private objDProducto = New DProducto
    Private objNProducto = New NProducto
    Private objNtalleProd = New NTalle_Producto
    'botón "añadir" del formulario añadir producto.
    Private Sub BAñadirProducto_Click(sender As Object, e As EventArgs) Handles BAñadirProducto.Click
        Dim Ask As MsgBoxResult

        If EspacioEnBlanco() = False Then
            Dim codigo As Integer = CInt(TBCodProducto.Text)
            Dim nombre As String = TBNombreProducto.Text
            Dim categoria As Integer = CBCategoria.SelectedValue
            Dim stock As Integer = CInt(TBStock.Text)
            Dim precio As Integer = TBPrecio.Text
            Dim talle As Integer = CBTalle.SelectedValue
            Dim marca As Integer = CBMarca.SelectedValue
            Ask = MsgBox("Seguro que desea añadir este producto?", vbQuestion + vbYesNo, "Confirmar Inserción")
            If Ask = vbYes Then
                If objNProducto.agregar_Producto(codigo, nombre, categoria, stock, precio, marca) Then
                    If objNtalleProd.agregar_talle_producto(codigo, talle) Then
                        objNProducto.cargarGrid(dgvListaProductos)
                    End If
                    MsgBox("El producto" + TBNombreProducto.Text + "se insertó correctamente", vbInformation, "Guardar")
                Else
                    MsgBox("No se pudo realizar el registro", vbCritical, "Error")
                End If

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
        'ver los campos combobox como validar

        If String.IsNullOrWhiteSpace(nombre) Or
           String.IsNullOrWhiteSpace(categoria) Or
           String.IsNullOrWhiteSpace(stock) Or
           String.IsNullOrWhiteSpace(precio) Then
            Ask = MsgBox("Debe Completar todos los campos", vbCritical, "Error")
            Return Ask
        Else
            Return False
        End If
    End Function

    Private Sub TBPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBStock.KeyPress, TBPrecio.KeyPress, TBCodProducto.KeyPress

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
        objNProducto.cargarGrid(dgvListaProductos)
    End Sub
End Class