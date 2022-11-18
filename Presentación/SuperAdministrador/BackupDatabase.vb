Imports System.Data.SqlClient
Public Class BackupDatabase
    Private Sub BResguardar_Click(sender As Object, e As EventArgs) Handles BResguardar.Click
        Dim AnswerYes As String

        AnswerYes = MsgBox("Seguro desea realizar el backup?", vbCritical + vbYesNo, "BACKUP")

        If AnswerYes = vbYes Then
            Dim sfd As New SaveFileDialog() With {
            .Filter = "Backup File | *.bak",
            .FileName = ""
            }

            If sfd.ShowDialog = DialogResult.OK Then
                Dim conexion = New SqlConnection("server=ABI\SQLEXPRESS;database=WorldShoes_Roman_Rios;integrated security = true")
                Using conexion
                    conexion.Open()
                    Cursor = Cursors.WaitCursor
                    Dim sql As String = $"backup database WorldShoes_Roman_Rios to disk = '{sfd.FileName}'"
                    Dim cmd As SqlCommand = New SqlCommand(sql, conexion)
                    cmd.ExecuteNonQuery()
                    conexion.Close()
                    MsgBox("Se ha realizado el backup correctamente", vbInformation, "Copia Guardada")
                    Cursor = Cursors.Default
                End Using
            End If
        ElseIf AnswerYes = vbNo Then
            Me.Close()
        Else
            MsgBox("No se ha podido realizar el backup de la base de datos", vbCritical + vbYesNo, "BACKUP")
        End If

    End Sub
    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        Me.Close()
    End Sub

    Private Sub BRestaurar_Click(sender As Object, e As EventArgs) Handles BRestaurar.Click
        Dim ofd As New OpenFileDialog With {
            .Filter = "Backup File | *.bak",
            .FileName = ""
        }
        If ofd.ShowDialog = DialogResult.OK Then
            Dim conexion = New SqlConnection("server=ABI\SQLEXPRESS;database=WorldShoes_Roman_Rios;integrated security = true")
            Using conexion
                conexion.Open()
                Cursor = Cursors.WaitCursor
                Dim sql As String = $"ALTER DATABASE WorldShoes_Roman_Rios SET OFFLINE WITH ROLLBACK IMMEDIATE; RESTORE DATABASE WorldShoes_Roman_Rios FROM disk = '{ofd.FileName}'"
                Dim cmd As New SqlCommand(sql, conexion)
                cmd.ExecuteNonQuery()
                conexion.Close()
                MsgBox("Restauración completada")
                Cursor = Cursors.Default
            End Using
        End If
    End Sub
End Class