﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Partial Public Class WorldShoes_Roman_RiosEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=WorldShoes_Roman_RiosEntities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property Categoria() As DbSet(Of Categoria)
    Public Overridable Property clientes() As DbSet(Of clientes)
    Public Overridable Property detalles_factura() As DbSet(Of detalles_factura)
    Public Overridable Property empleados() As DbSet(Of empleados)
    Public Overridable Property factura() As DbSet(Of factura)
    Public Overridable Property Marcas() As DbSet(Of Marcas)
    Public Overridable Property Perfiles() As DbSet(Of Perfiles)
    Public Overridable Property Productos() As DbSet(Of Productos)
    Public Overridable Property talle() As DbSet(Of talle)
    Public Overridable Property talle_producto() As DbSet(Of talle_producto)
    Public Overridable Property Usuarios() As DbSet(Of Usuarios)

End Class
