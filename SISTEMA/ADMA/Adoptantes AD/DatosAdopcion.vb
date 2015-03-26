Imports System.Data.SqlClient
Imports System.Configuration
Imports Adoptantes_AD.My.Resources


Public Class DatosAdopcion
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

    Public Sub ModificarDueño(ByVal IDMascota As Integer, ByVal dueño As String)

        Dim COMANDO As New SqlCommand
        Dim Adaptador As New SqlDataAdapter(COMANDO)
        Dim TABLA As New DataTable
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.StoredProcedure
        COMANDO.CommandText = "ModificarDueño"
        COMANDO.Parameters.Clear()

        COMANDO.Parameters.AddWithValue("@IDMascota", IDMascota)
        COMANDO.Parameters.AddWithValue("@Dueño", dueño)
        Adaptador.Fill(TABLA)

    End Sub
End Class
