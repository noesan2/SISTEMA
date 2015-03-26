Public Class Producto
    Private _productoId As Integer
    Public Property ProductoId() As Integer
        Get
            Return _productoId
        End Get
        Set(ByVal value As Integer)
            _productoId = value
        End Set
    End Property

    Private _nombre As String
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Private _descripcion As String
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

End Class
