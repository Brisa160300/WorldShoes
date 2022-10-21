Public Class DPerfil
    Dim ctx As WorldShoes_Roman_RiosEntities = New WorldShoes_Roman_RiosEntities
    Function Dguardar_perfil(operfil As Perfiles) As Boolean
        Try
            ctx.Perfiles.Add(operfil)
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Function getPerfilAll() As List(Of Perfiles)
        Dim listarPerfiles = (From p In ctx.Perfiles Select p).ToList
        Return listarPerfiles
    End Function


    Function modPerfil(idPerfil As Integer, descripcion As String) As Boolean
        Try
            Dim perfMod = (From p In ctx.Perfiles Where p.id_Perfil = idPerfil
                           Select p).First
            perfMod.Descripcion = descripcion
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            MsgBox("No se han podido implementar los cambios", vbCritical, "Error")
            Return False
        End Try

    End Function

    Function EliminarPerfil(idPerfil As Integer) As Boolean
        Try
            Dim perfDelete = (From p In ctx.Perfiles Where p.id_Perfil = idPerfil
                              Select p).First
            perfDelete.estado_perfil = 0
            ctx.SaveChanges()
            MsgBox("Se ha eliminado con exito", vbInformation, "Confirmar Eliminación")
            Return True
        Catch ex As Exception
            MsgBox("No se han podido implementar los cambios", vbCritical, "Error")
            Return False
        End Try

    End Function

    Function AltaPerfil(idPerfil As Integer) As Boolean
        Try
            Dim perfAlta = (From p In ctx.Perfiles Where p.id_Perfil = idPerfil
                            Select p).First
            perfAlta.estado_perfil = 1
            MsgBox("Se ha dado de alta con exito", vbInformation, "Confirmar Alta")
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            MsgBox("No se han podido implementar los cambios", vbCritical, "Error")
            Return False
        End Try

    End Function

    Function selecPerfil(desc As String) As Integer
        Try
            Dim perf = (From p In ctx.Perfiles Where p.Descripcion Like "%desc%" Select p.id_Perfil).First
            Return perf
        Catch ex As Exception
            Return False
        End Try
    End Function



End Class
