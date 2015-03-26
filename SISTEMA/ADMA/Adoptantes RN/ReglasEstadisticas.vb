Imports System.Windows.Forms
Public Class ReglasEstadisticas

    Public Function EstAdopcionesPorBarrio(ByVal GRILLA As DataGridView, ByVal Desde As Date, ByVal Hasta As Date) As Boolean
        Try
            Dim objAD As New Adoptantes_AD.DatosEstadisticas
            Dim TABLA As New DataTable
            TABLA = objAD.EstAdopcionesPorBarrio(Desde, Hasta)
            GRILLA.DataSource = TABLA
            Return True
        Catch

            Return False
        End Try
    End Function
    Public Function EstCantidadEspecieSexo(ByVal GRILLA As DataGridView, ByVal Desde As Date, ByVal Hasta As Date) As Boolean
        Try
            Dim objAD As New Adoptantes_AD.DatosEstadisticas
            Dim TABLA As New DataTable
            TABLA = objAD.EstCantidadEspecieSexo(Desde, Hasta)
            GRILLA.DataSource = TABLA
            Return True
        Catch

            Return False
        End Try
    End Function

    Public Function EstEsterilizaciones(ByVal GRILLA As DataGridView, ByVal Desde As Date, ByVal Hasta As Date) As Boolean
        Try
            Dim objAD As New Adoptantes_AD.DatosEstadisticas
            Dim TABLA As New DataTable
            TABLA = objAD.EstEsterilizaciones(Desde, Hasta)
            GRILLA.DataSource = TABLA
            Return True
        Catch

            Return False
        End Try
    End Function
    Public Function EstMascotasConSinDueño(ByVal GRILLA As DataGridView) As Boolean
        Try
            Dim objAD As New Adoptantes_AD.DatosEstadisticas
            Dim TABLA As New DataTable
            TABLA = objAD.EstMascotasConSinDueño()
            GRILLA.DataSource = TABLA
            Return True
        Catch

            Return False
        End Try
    End Function
End Class
