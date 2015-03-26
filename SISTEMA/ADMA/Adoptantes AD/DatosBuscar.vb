Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class DatosBuscar
    Dim CADENA As String = "data source=.\sqlexpress;initial catalog=ADMA;integrated security=true"
    Dim CONECTOR As New SqlConnection(CADENA)

    Public Function BuscarMascota(ByVal IDMascota As Integer) As DataTable
        Dim COMANDO As New SqlCommand
        Dim ADAPTADOR As New SqlDataAdapter(COMANDO)
        Dim TABLA As New DataTable
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.StoredProcedure
        COMANDO.CommandText = "BuscarMascota"
        COMANDO.Parameters.Clear()

        COMANDO.Parameters.AddWithValue("@IDMascota", IDMascota)
        ADAPTADOR.Fill(TABLA)
        Return TABLA


    End Function

    Public Function ObtenerDueño(ByVal DNI As Integer) As DataTable
        Dim COMANDO As New SqlCommand
        Dim ADAPTADOR As New SqlDataAdapter(COMANDO)
        Dim TABLA As New DataTable
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.StoredProcedure
        COMANDO.CommandText = "BuscarDueño"
        COMANDO.Parameters.Clear()
        COMANDO.Parameters.AddWithValue("@dni", DNI)



        ADAPTADOR.Fill(TABLA)
        Return TABLA


    End Function

    Public Function ObtenerTodosLosAdoptantes() As DataTable
        Dim COMANDO As New SqlCommand
        Dim ADAPTADOR As New SqlDataAdapter(COMANDO)
        Dim TABLA As New DataTable
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.StoredProcedure
        COMANDO.CommandText = "ObtenerTodosLosAdoptantes"
      



        ADAPTADOR.Fill(TABLA)
        Return TABLA


    End Function
    Public Function ObtenerTodasLasMascotas() As DataTable
        Dim COMANDO As New SqlCommand
        Dim ADAPTADOR As New SqlDataAdapter(COMANDO)
        Dim TABLA As New DataTable
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.StoredProcedure
        COMANDO.CommandText = "ObtenerTodasLasMascotas"




        ADAPTADOR.Fill(TABLA)
        Return TABLA


    End Function
    Public Function ObtenerTodasLasAdopciones() As DataTable
        Dim COMANDO As New SqlCommand
        Dim ADAPTADOR As New SqlDataAdapter(COMANDO)
        Dim TABLA As New DataTable
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.StoredProcedure
        COMANDO.CommandText = "ObtenerTodasLasAdopciones"




        ADAPTADOR.Fill(TABLA)
        Return TABLA


    End Function
End Class
