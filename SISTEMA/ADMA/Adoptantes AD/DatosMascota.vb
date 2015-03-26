Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class DatosMascota
    Dim CADENA As String = "data source=.\sqlexpress;initial catalog=ADMA;integrated security=true"
    Dim CONECTOR As New SqlConnection(CADENA)
    Public Function ObtenerAdoptante(ByVal DNI As Integer) As DataTable
        Dim COMANDO As New SqlCommand
        Dim ADAPTADOR As New SqlDataAdapter(COMANDO)
        Dim TABLA As New DataTable
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.StoredProcedure
        COMANDO.CommandText = "ObtenerAdoptante"
        COMANDO.Parameters.Clear()

        COMANDO.Parameters.AddWithValue("@dni", DNI)

        ADAPTADOR.Fill(TABLA)
        Return TABLA


    End Function

    Public Sub CrearMascota(ByVal Nombre As String, ByVal IDMascota As Integer, ByVal Especie As String, ByVal Sexo As String, ByVal edad As Integer, ByVal tamaño As String, ByVal color As String, ByVal caracteristicas As String, ByVal FechaEsterilizacion As Date, ByVal dueño As String, ByVal Comentarios As String)

        Dim COMANDO As New SqlCommand
        Dim Adaptador As New SqlDataAdapter(COMANDO)
        Dim TABLA As New DataTable
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.StoredProcedure
        COMANDO.CommandText = "CrearMascota"
        COMANDO.Parameters.Clear()

        COMANDO.Parameters.AddWithValue("@IDMascota", IDMascota)
        COMANDO.Parameters.AddWithValue("@Nombre", Nombre)
        COMANDO.Parameters.AddWithValue("@especie", Especie)
        COMANDO.Parameters.AddWithValue("@sexo", Sexo)
        COMANDO.Parameters.AddWithValue("@edad", edad)
        COMANDO.Parameters.AddWithValue("@tamanio", tamaño)
        COMANDO.Parameters.AddWithValue("@color", color)
        COMANDO.Parameters.AddWithValue("@caracteristicas", caracteristicas)
        COMANDO.Parameters.AddWithValue("@FechaEsterilizacion", FechaEsterilizacion)
        COMANDO.Parameters.AddWithValue("@Dueño", dueño)
        COMANDO.Parameters.AddWithValue("@Comentarios", Comentarios)
        Adaptador.Fill(TABLA)

    End Sub


    Public Function ObtenerMascota(ByVal IDMascota As Integer) As DataTable
        Dim COMANDO As New SqlCommand
        Dim ADAPTADOR As New SqlDataAdapter(COMANDO)
        Dim TABLA As New DataTable
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.StoredProcedure
        COMANDO.CommandText = "ObtenerMascota"
        COMANDO.Parameters.Clear()

        COMANDO.Parameters.AddWithValue("@IDMascota", IDMascota)
        ADAPTADOR.Fill(TABLA)
        Return TABLA


    End Function



    Public Sub ModificarMascota(ByVal Nombre As String, ByVal IDMascota As Integer, ByVal Especie As String, ByVal Sexo As String, ByVal edad As Integer, ByVal tamaño As String, ByVal color As String, ByVal caracteristicas As String, ByVal FechaEsterilizacion As Date, ByVal dueño As String, ByVal Comentarios As String)

        Dim COMANDO As New SqlCommand
        Dim Adaptador As New SqlDataAdapter(COMANDO)
        Dim TABLA As New DataTable
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.StoredProcedure
        COMANDO.CommandText = "ModificarMascota"
        COMANDO.Parameters.Clear()

        COMANDO.Parameters.AddWithValue("@IDMascota", IDMascota)
        COMANDO.Parameters.AddWithValue("@Nombre", Nombre)
        COMANDO.Parameters.AddWithValue("@especie", Especie)
        COMANDO.Parameters.AddWithValue("@sexo", Sexo)
        COMANDO.Parameters.AddWithValue("@edad", edad)
        COMANDO.Parameters.AddWithValue("@tamanio", tamaño)
        COMANDO.Parameters.AddWithValue("@color", color)
        COMANDO.Parameters.AddWithValue("@caracteristicas", caracteristicas)
        COMANDO.Parameters.AddWithValue("@FechaEsterilizacion", FechaEsterilizacion)
        COMANDO.Parameters.AddWithValue("@Dueño", dueño)
        COMANDO.Parameters.AddWithValue("@Comentarios", Comentarios)
        Adaptador.Fill(TABLA)

    End Sub

    Public Sub CrearAdopcion(ByVal IDMascota As Integer, ByVal DNI As Integer, ByVal FechaAdopcion As Date, ByVal Comentarios As String)
        Dim COMANDO As New SqlCommand
        Dim ADAPTADOR As New SqlDataAdapter(COMANDO)
        Dim TABLA As New DataTable
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.StoredProcedure
        COMANDO.CommandText = "CrearAdopcion"
        COMANDO.Parameters.Clear()

        COMANDO.Parameters.AddWithValue("@IDMascota", IDMascota)
        COMANDO.Parameters.AddWithValue("@DNI", DNI)
        COMANDO.Parameters.AddWithValue("@FechaAdopcion", FechaAdopcion)
        COMANDO.Parameters.AddWithValue("@Comentarios", Comentarios)

        ADAPTADOR.Fill(TABLA)

    End Sub
    Public Function ObtenerAdopcion(ByVal IDMascota As Integer) As DataTable
        Dim COMANDO As New SqlCommand
        Dim ADAPTADOR As New SqlDataAdapter(COMANDO)
        Dim TABLA As New DataTable
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.StoredProcedure
        COMANDO.CommandText = "ObtenerAdopcion"
        COMANDO.Parameters.Clear()

        COMANDO.Parameters.AddWithValue("@IDMascota", IDMascota)
        ADAPTADOR.Fill(TABLA)
        Return TABLA


    End Function

    Public Sub BorrarAdopcion(ByVal IDMascota As Integer)
        Dim COMANDO As New SqlCommand
        Dim ADAPTADOR As New SqlDataAdapter(COMANDO)
        Dim TABLA As New DataTable
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.StoredProcedure
        COMANDO.CommandText = "EliminarAdopcion"
        COMANDO.Parameters.Clear()

        COMANDO.Parameters.AddWithValue("@IDMascota", IDMascota)

        ADAPTADOR.Fill(TABLA)
    End Sub

    Public Sub BorrarMascota(ByVal IDMascota As Integer)
        Dim COMANDO As New SqlCommand
        Dim ADAPTADOR As New SqlDataAdapter(COMANDO)
        Dim TABLA As New DataTable
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.StoredProcedure
        COMANDO.CommandText = "EliminarMascota"
        COMANDO.Parameters.Clear()

        COMANDO.Parameters.AddWithValue("@IDMascota", IDMascota)

        ADAPTADOR.Fill(TABLA)
    End Sub
End Class
