Imports System.Data.SqlClient

Public Class DatosBase
    Private CADENA As String = "data source=.\sqlexpress;initial catalog=ADMA;integrated security=true"
    Protected CONECTOR As New SqlConnection(CADENA)
    Protected cmd As New SqlCommand
    Protected adpt As SqlDataAdapter
    Protected tabla As DataTable

    Sub New()
        adpt = New SqlDataAdapter(cmd)
        tabla = New DataTable
        cmd.Connection = Me.CONECTOR
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Clear()
    End Sub
End Class
