'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class empleados
    Public Property Id_empleado As Integer
    Public Property nombre As String
    Public Property apellido As String
    Public Property dni As Integer
    Public Property telefono As Long
    Public Property direccion As String
    Public Property email As String
    Public Property estado_empleado As Integer

    Public Overridable Property Usuarios As ICollection(Of Usuarios) = New HashSet(Of Usuarios)

End Class