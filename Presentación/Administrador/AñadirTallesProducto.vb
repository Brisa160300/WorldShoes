Public Class AñadirTallesProducto
    Private objNProducto = New NProducto
    Private objNTalle = New NTalle
    Private objDTalle = New DTalle
    Private Sub AñadirTallesProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objNProducto.cargarGrid(dgvListarProductos)
        objNProducto.cargarComboxTalle(CBTalleProducto)
        objNProducto.cargarGrid(dgvDetalleProductos)
    End Sub

    Public Function EspacioEnBlanco() As Boolean
        Dim Ask As MsgBoxResult
        'Dim talleProducto As String = Int(CBTalleProducto.SelectedValue)
        Dim producto As String = TBCodProducto.Text
        Dim cantidad As String = TBCantidadProducto.Text
        If String.IsNullOrWhiteSpace(producto) Or String.IsNullOrWhiteSpace(cantidad) Then
            Ask = MsgBox("Debe Completar todos los campos", vbCritical, "Error")
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub BRegistrarTalle_Click(sender As Object, e As EventArgs) Handles BRegistrarTalle.Click
        Dim ask As MsgBoxResult
        If EspacioEnBlanco() = False Then
            Dim cod_producto As Integer = TBCodProducto.Text
            Dim talleProducto As Integer = Int(CBTalleProducto.SelectedValue)
            Dim cantidad As Integer = TBCantidadProducto.Text
            ask = MsgBox("Esta seguro que desea añadir el talle y stock", vbYesNo + vbQuestion, "Confirmar operacion")
            If ask = vbYes Then
                If objNProducto.agregar_talle_producto(cod_producto, talleProducto, cantidad) Then
                    objNProducto.cargarGrid(dgvListarProductos)
                    MsgBox("Registrado con exito", vbInformation)
                Else
                    MsgBox("No se pudo realizar el registro", vbCritical, "Error")
                End If
            End If
        End If
    End Sub
    Private Sub dgvListarProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListarProductos.CellClick
        TBCodProducto.Text = dgvListarProductos.CurrentRow.Cells(0).Value.ToString
    End Sub
    Private Sub BVolver_Click(sender As Object, e As EventArgs) Handles BVolver.Click
        Me.Close()
    End Sub
End Class