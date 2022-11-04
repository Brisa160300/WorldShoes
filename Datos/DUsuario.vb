Public Class DUsuario
    Dim ctx As WorldShoes_Roman_RiosEntities = New WorldShoes_Roman_RiosEntities

    Function Dguardar_usuario(ousuario As Usuarios) As Boolean
        Try
            ctx.Usuarios.Add(ousuario)
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function getUsuariosAll() As List(Of EUsuario)
        Dim lista = (From u In ctx.Usuarios Select u).ToList
        Dim listaUsuarios = New List(Of EUsuario)
        For Each valor In lista
            Dim item As EUsuario = New EUsuario
            item.Nombre = valor.empleados.nombre
            item.Apellido = valor.empleados.apellido
            item.NombreUsuario = valor.Nombre
            item.Pass = valor.Contraseña
            If valor.estado_usuario = 1 Then
                item.Estado = "Activo"
            Else
                item.Estado = "Inactivo"
            End If
            item.Descripcion_perfil = valor.Perfiles.Descripcion
            item.Id_usuario = valor.id_Usuario
            listaUsuarios.Add(item)
        Next
        Return listaUsuarios

    End Function

    Function ModUsuario(iduser As Integer, nombre As String, contraseña As String, id_perfil As Integer) As Boolean
        Try
            Dim userMod = (From u In ctx.Usuarios Where u.id_Usuario = iduser
                           Select u).First
            userMod.Nombre = nombre
            userMod.Contraseña = contraseña
            userMod.id_Perfil = id_perfil
            userMod.estado_usuario = 1
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            MsgBox("No se han podido implementar los cambios", vbCritical, "Error")
            Return False
        End Try
    End Function
    '----otra opcion modUsuario----'
    Public Function ModUsuario2(iduser As Integer, p_nombre As String, p_contraseña As String, p_perfilId As Integer)
        Try
            Using modificacionUsu As New WorldShoes_Roman_RiosEntities
                Dim modificarUsuario = (From q In modificacionUsu.Usuarios Where q.id_Usuario = iduser Select q).First
                modificarUsuario.Nombre = p_nombre
                modificarUsuario.Contraseña = p_contraseña
                modificarUsuario.id_Perfil = p_perfilId
                modificarUsuario.estado_usuario = 1
                modificacionUsu.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Function EliminarUsuario(idUser As Integer) As Boolean
        Try
            Dim userDelete = (From u In ctx.Usuarios Where u.id_Usuario = idUser
                              Select u).First
            userDelete.estado_usuario = 0
            ctx.SaveChanges()
            MsgBox("Se ha eliminado con exito", vbInformation, "Confirmar Eliminación")
            Return True
        Catch ex As Exception
            MsgBox("No se han podido implementar los cambios", vbCritical, "Error")
            Return False
        End Try

    End Function

    Function AltaUsuario(idUser As Integer) As Boolean
        Try
            Dim userAlta = (From u In ctx.Usuarios Where u.id_Usuario = idUser
                            Select u).First
            userAlta.estado_usuario = 1
            MsgBox("Se ha dado de alta con exito", vbInformation, "Confirmar Alta")
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            MsgBox("No se han podido implementar los cambios", vbCritical, "Error")
            Return False
        End Try

    End Function

    'cambios---03/11/22 11:04
    Public Function buscarUsuarios(p_NombreEmpleado As String, ByVal grid As DataGridView)
        Try
            Using Mostrar As New WorldShoes_Roman_RiosEntities
                Dim objMostrar = (From q In Mostrar.Usuarios Where q.Nombre.ToString.Contains(p_NombreEmpleado)
                                  Select Nombre = q.empleados.nombre, Apellido = q.empleados.apellido,
                                      Usuario = q.Nombre, Contraseña = q.Contraseña, Perfil = q.id_Perfil, Estado = q.estado_usuario).ToList

                grid.DataSource = objMostrar
                'grid.Columns.Item(6).Visible = False
                'grid.Columns.Item(8).Visible = False
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

End Class
