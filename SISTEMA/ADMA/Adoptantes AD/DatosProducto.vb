Imports Adoptantes_AD
Imports Adoptante_MD
Imports System.Data.SqlClient
Imports Adoptantes_AD.My.Resources
Imports Microsoft.Practices

Public Class DatosProducto
    Inherits DatosBase

    ''' <summary>
    ''' Crea un producto nuevo.
    ''' </summary>
    ''' <param name="productoToSave">Producto a crear.</param>
    ''' <remarks></remarks>
    Public Sub CrearProducto(ByVal productoToSave As Producto)
        cmd.CommandText = StoredProcedures.CrearProducto

        cmd.Parameters.AddWithValue("@Nombre", productoToSave.Nombre)
        cmd.Parameters.AddWithValue("@Descipcion", productoToSave.Descripcion)

        adpt.Fill(tabla)
    End Sub

    ''' <summary>
    ''' Borra un producto por Id.
    ''' </summary>
    ''' <param name="productoToDelete">Producto a borrar.</param>
    ''' <remarks></remarks>
    Public Sub BorrarProducto(ByVal productoToDelete As Producto)
        cmd.CommandText = StoredProcedures.BorrarProducto

        cmd.Parameters.AddWithValue("@ProductoId", productoToDelete.ProductoId)

        adpt.Fill(tabla)
    End Sub

    ''' <summary>
    ''' Retorna los productos filtrado por nombre
    ''' </summary>
    ''' <param name="nombre">nombre de producto buscado.</param>
    ''' <returns>List de Productos.</returns>
    ''' <remarks></remarks>
    Public Function ObtenerProductos(ByVal nombre As String) As List(Of Producto)
        cmd.CommandText = StoredProcedures.ObtenerProducto
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@Nombre", nombre)
        tabla.Clear()
        adpt.Fill(tabla)

        Dim result = New List(Of Producto)
        Dim prod = New Producto()
        For Each row As DataRow In tabla.Rows
            MapProperties(row, prod)
            result.Add(prod)
        Next

        Return result
    End Function

    ''' <summary>
    ''' Retorna si es posible borrar un Producto en base a si tiene
    ''' o no Consumos o compras relacionadas.
    ''' </summary>
    ''' <param name="productoToCheck">Producto a chekear.</param>
    ''' <returns>Boolean</returns>
    ''' <remarks></remarks>
    Public Function SePuedeBorrar(ByVal productoToCheck As Producto) As Boolean
        cmd.CommandText = StoredProcedures.SePuedeBorrarProducto

        cmd.Parameters.AddWithValue("@ProductoId", productoToCheck.ProductoId)
        adpt.Fill(tabla)
        Return False

    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="row"></param>
    ''' <param name="producto"></param>
    ''' <remarks></remarks>
    Private Sub MapProperties(ByVal row As DataRow, ByRef producto As Producto)
        producto.Descripcion = If(Not String.IsNullOrEmpty(row.Item("Descripcion")), row.Item("Descripcion").ToString(), String.Empty)
        producto.Nombre = If(Not String.IsNullOrEmpty(row.Item("Nombre")), row.Item("Nombre").ToString(), String.Empty)
        producto.ProductoId = Integer.Parse(row.Item("ProductoId"))
    End Sub
End Class
