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

Partial Public Class Productos
    Public Property cod_producto As Integer
    Public Property nombre As String
    Public Property id_categoria As Integer
    Public Property stock As Integer
    Public Property precio As Decimal
    Public Property imagen As String

    Public Overridable Property Categoria As Categoria
    Public Overridable Property talle_producto As ICollection(Of talle_producto) = New HashSet(Of talle_producto)

End Class