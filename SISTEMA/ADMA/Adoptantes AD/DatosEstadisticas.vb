Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class DatosEstadisticas
    Dim CADENA As String = "data source=.\sqlexpress;initial catalog=ADMA;integrated security=true"
    Dim CONECTOR As New SqlConnection(CADENA)

    Public Function EstAdopcionesPorBarrio(ByVal Desde As Date, ByVal Hasta As Date) As DataTable
        Dim COMANDO As New SqlCommand
        Dim ADAPTADOR As New SqlDataAdapter(COMANDO)
        Dim TABLA As New DataTable
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.StoredProcedure
        COMANDO.CommandText = "EstAdopcionesPorBarrio"
        COMANDO.Parameters.Clear()
        COMANDO.Parameters.AddWithValue("@FechaDesde", Desde)
        COMANDO.Parameters.AddWithValue("@FechaHasta", Hasta)



        ADAPTADOR.Fill(TABLA)
        Return TABLA


    End Function
    Public Function EstCantidadEspecieSexo(ByVal Desde As Date, ByVal Hasta As Date) As DataTable
        Dim COMANDO As New SqlCommand
        Dim ADAPTADOR As New SqlDataAdapter(COMANDO)
        Dim TABLA As New DataTable
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.StoredProcedure
        COMANDO.CommandText = "EstCantidadEspecieSexo"
        COMANDO.Parameters.Clear()
        COMANDO.Parameters.AddWithValue("@FechaDesde", Desde)
        COMANDO.Parameters.AddWithValue("@FechaHasta", Hasta)



        ADAPTADOR.Fill(TABLA)
        Return TABLA


    End Function

    Public Function EstEsterilizaciones(ByVal Desde As Date, ByVal Hasta As Date) As DataTable
        Dim COMANDO As New SqlCommand
        Dim ADAPTADOR As New SqlDataAdapter(COMANDO)
        Dim TABLA As New DataTable
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.StoredProcedure
        COMANDO.CommandText = "EstEsterilizaciones"
        COMANDO.Parameters.Clear()
        COMANDO.Parameters.AddWithValue("@FechaDesde", Desde)
        COMANDO.Parameters.AddWithValue("@FechaHasta", Hasta)



        ADAPTADOR.Fill(TABLA)
        Return TABLA


    End Function
    Public Function EstMascotasConSinDueño() As DataTable
        Dim COMANDO As New SqlCommand
        Dim ADAPTADOR As New SqlDataAdapter(COMANDO)
        Dim TABLA As New DataTable
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.StoredProcedure
        COMANDO.CommandText = "EstMascotasConSinDueño"

        ADAPTADOR.Fill(TABLA)
        Return TABLA


    End Function
End Class
