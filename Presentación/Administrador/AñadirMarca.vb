Public Class AñadirMarca

    Dim objNMarca = New NTalle
    Private Sub TBNombreMarca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBNombreMarca.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan letras", vbCritical, "Error")
        End If
    End Sub

    Public Function EspacioEnBlanco() As Boolean
        Dim ask As Boolean = False
        Dim nomMarc As String = TBNombreMarca.Text.Trim
        If nomMarc = "" Then
            ErrorProviderNomMarca.SetError(TBNombreMarca, "Ingrese una marca")
            ask = True
        ElseIf nomMarc.Length < 3 Then
            ErrorProviderNomMarca.SetError(TBNombreMarca, "La marca ingresada debe tener un minimo de 3 caracteres")
        End If
        Return ask
    End Function

    Private Sub BRegistrarMarca_Click(sender As Object, e As EventArgs) Handles BRegistrarMarca.Click
        ErrorProviderNomMarca.Clear()
        If EspacioEnBlanco() Then
            MsgBox("Debe Completar todos los campos", vbCritical, "Error")
        Else
            MsgBox("¿Desea añadir esta nueva marca?", vbQuestion + vbYesNo, "Confirmar Inserción")
            If vbYes Then
                If (objNMarca.agregar_Marca(TBNombreMarca.Text)) Then
                    MsgBox("La marca: " + TBNombreMarca.Text + " se registró correctamente", vbOKOnly + MsgBoxStyle.Information, "Registro exitoso")
                    objNMarca.cargarGrid(dgvRegistroMarca)
                    MsgBox("se ha añadido correctamente la nueva categoría")
                Else
                    MsgBox("La marca: " + TBNombreMarca.Text + " ya existe", vbOKOnly + MsgBoxStyle.Critical, "Error de registro")
                    TBNombreMarca.Focus()
                End If
            End If
        End If
        TBNombreMarca.Clear()
    End Sub

    Private Sub Añadir_Marca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objNMarca.cargarGrid(dgvRegistroMarca)
    End Sub

    Private Sub BVolve_Click(sender As Object, e As EventArgs) Handles BVolve.Click
        Me.Close()
    End Sub
End Class