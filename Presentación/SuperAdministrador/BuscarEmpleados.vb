Public Class BuscarEmpleados
    Private objNEmpleados = New NEmpleado
    Private Sub BVolver_Click(sender As Object, e As EventArgs) Handles BVolver.Click
        Me.Close()
    End Sub

    Private Sub BuscarEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objNEmpleados.cargarGrid(dgvEmpleados)
    End Sub

End Class