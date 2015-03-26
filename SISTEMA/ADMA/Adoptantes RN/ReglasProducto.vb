Imports Adoptante_MD
Imports Adoptantes_AD

Public Class ReglasProducto
    Private datosProducto As DatosProducto

    Sub New()
        datosProducto = New DatosProducto
    End Sub

    Public Sub Borrar(ByVal productoToDelete As Producto)
        If datosProducto.SePuedeBorrar(productoToDelete) Then
            ''DELETE
            datosProducto.BorrarProducto(productoToDelete)
        Else
            ''send a message

        End If
    End Sub

    Public Function Buscar(ByVal nombreProducto As String, ByRef mensajeError As String) As IEnumerable(Of Producto)
        Dim prod = datosProducto.ObtenerProductos(nombreProducto)
        If prod.Count > 0 Then
            ''mostrar resultado
            Return prod
        Else
            ''Show message
            mensajeError = "Producto no entontrado."
        End If
    End Function

    ''' <summary>
    ''' Crea un nuevo producto.
    ''' </summary>
    ''' <param name="newProducto">Producto a ser creado</param>
    ''' <remarks></remarks>
    Public Sub CrearProducto(ByRef newProducto As Producto)
        datosProducto.CrearProducto(newProducto)
    End Sub

End Class
