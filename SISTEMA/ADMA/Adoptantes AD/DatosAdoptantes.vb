Imports System.Data.SqlClient

Imports System.Windows.Forms
Public Class DatosAdoptantes
    Dim CADENA As String = "data source=.\sqlexpress;initial catalog=ADMA;integrated security=true"
    Dim CONECTOR As New SqlConnection(CADENA)

    Public Sub CrearAdoptante(ByVal Nombre As String, ByVal Apellido As String, ByVal DNI As Integer, ByVal FechaNac As Date, ByVal Sexo As String, ByVal IDBarrio As Integer, ByVal Domicilio As String, ByVal Telefono As String, ByVal Comentarios As String)
        Dim COMANDO As New SqlCommand
        Dim Adaptador As New SqlDataAdapter(COMANDO)
        Dim TABLA As New DataTable
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.StoredProcedure
        COMANDO.CommandText = "CrearAdoptante"
        COMANDO.Parameters.Clear()

        COMANDO.Parameters.AddWithValue("@dni", DNI)
        COMANDO.Parameters.AddWithValue("@nombre", Nombre)
        COMANDO.Parameters.AddWithValue("@apellido", Apellido)
        COMANDO.Parameters.AddWithValue("@FechaNac", FechaNac)
        COMANDO.Parameters.AddWithValue("@Sexo", Sexo)
        COMANDO.Parameters.AddWithValue("@IDBarrio", IDBarrio)
        COMANDO.Parameters.AddWithValue("@Domicilio", Domicilio)
        COMANDO.Parameters.AddWithValue("@Telefono", Telefono)
        COMANDO.Parameters.AddWithValue("@Comentarios", Comentarios)
        Adaptador.Fill(TABLA)

    End Sub
    Public Sub ModificarAdoptante(ByVal Nombre As String, ByVal Apellido As String, ByVal DNI As Integer, ByVal FechaNac As Date, ByVal Sexo As String, ByVal IDBarrio As Integer, ByVal Domicilio As String, ByVal Telefono As String, ByVal Comentarios As String)
        Dim COMANDO As New SqlCommand
        Dim Adaptador As New SqlDataAdapter(COMANDO)
        Dim TABLA As New DataTable
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.StoredProcedure
        COMANDO.CommandText = "ModificarAdoptante"
        COMANDO.Parameters.Clear()

        COMANDO.Parameters.AddWithValue("@dni", DNI)
        COMANDO.Parameters.AddWithValue("@nombre", Nombre)
        COMANDO.Parameters.AddWithValue("@apellido", Apellido)
        COMANDO.Parameters.AddWithValue("@FechaNac", FechaNac)
        COMANDO.Parameters.AddWithValue("@Sexo", Sexo)
        COMANDO.Parameters.AddWithValue("@IDBarrio", IDBarrio)
        COMANDO.Parameters.AddWithValue("@Domicilio", Domicilio)
        COMANDO.Parameters.AddWithValue("@Telefono", Telefono)
        COMANDO.Parameters.AddWithValue("@Comentarios", Comentarios)
        Adaptador.Fill(TABLA)

    End Sub


    Public Function ObtenerBarrios() As DataTable

        Dim COMANDO As New SqlCommand
        Dim ADAPTADOR As New SqlDataAdapter(COMANDO)
        Dim TABLA As New DataTable
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.StoredProcedure
        COMANDO.CommandText = "ObtenerBarrios"

        ADAPTADOR.Fill(TABLA)

        Return TABLA

    End Function


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

    Public Function BorrarAdoptante(ByVal DNI As Integer) As DataTable
        Dim COMANDO As New SqlCommand
        Dim ADAPTADOR As New SqlDataAdapter(COMANDO)
        Dim TABLA As New DataTable
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.StoredProcedure
        COMANDO.CommandText = "BorrarAdoptante"
        COMANDO.Parameters.Clear()

        COMANDO.Parameters.AddWithValue("@dni", DNI)

        ADAPTADOR.Fill(TABLA)
        Return TABLA



    End Function
    Public Function BorrarAdopcionDNI(ByVal DNI As Integer) As DataTable
        Dim COMANDO As New SqlCommand
        Dim ADAPTADOR As New SqlDataAdapter(COMANDO)
        Dim TABLA As New DataTable
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.StoredProcedure
        COMANDO.CommandText = "EliminarAdopcionDNI"
        COMANDO.Parameters.Clear()

        COMANDO.Parameters.AddWithValue("@dni", DNI)

        ADAPTADOR.Fill(TABLA)
        Return TABLA



    End Function

    Public Function ModificarDueñoAlEliminarAdoptante(ByVal DNI As Integer) As DataTable
        Dim COMANDO As New SqlCommand
        Dim ADAPTADOR As New SqlDataAdapter(COMANDO)
        Dim TABLA As New DataTable
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.StoredProcedure
        COMANDO.CommandText = "ModificarDueñoAlEliminarAdoptante"
        COMANDO.Parameters.Clear()

        COMANDO.Parameters.AddWithValue("@dni", DNI)

        ADAPTADOR.Fill(TABLA)
        Return TABLA



    End Function


    Public Sub NuevoBarrio(ByVal NombreBarrio As String)
        Dim COMANDO As New SqlCommand
        Dim Adaptador As New SqlDataAdapter(COMANDO)
        Dim TABLA As New DataTable
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.StoredProcedure
        COMANDO.CommandText = "NuevoBarrio"
        COMANDO.Parameters.Clear()

        COMANDO.Parameters.AddWithValue("@NombreBarrio", NombreBarrio)

        Adaptador.Fill(TABLA)

    End Sub


    Public Function BuscarBarrio(ByVal NombreBarrio As String) As DataTable
        Dim COMANDO As New SqlCommand
        Dim ADAPTADOR As New SqlDataAdapter(COMANDO)
        Dim TABLA As New DataTable
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.StoredProcedure
        COMANDO.CommandText = "BuscarBarrio"
        COMANDO.Parameters.Clear()

        COMANDO.Parameters.AddWithValue("@NombreBarrio", NombreBarrio)
        ADAPTADOR.Fill(TABLA)
        Return TABLA


    End Function
End Class
