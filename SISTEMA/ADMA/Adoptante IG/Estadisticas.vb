Public Class Estadisticas
    Private Sub ValidarEnabledFecha()
        If cmbEstadisticas.SelectedIndex <> 3 Then
            dtpDesde.Enabled = True
            dtpHasta.Enabled = True
        Else
            dtpDesde.Enabled = False
            dtpHasta.Enabled = False

        End If

    End Sub



    Private Sub Estadisticas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbEstadisticas.SelectedIndex = 0

    End Sub

    Private Sub cmdConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultar.Click
        Dim objRN As New Adoptantes_RN.ReglasEstadisticas

        Select Case cmbEstadisticas.SelectedIndex
            Case 0
                objRN.EstAdopcionesPorBarrio(dgvEstadisticas, dtpDesde.Value, dtpHasta.Value)

            Case 1
                objRN.EstCantidadEspecieSexo(dgvEstadisticas, dtpDesde.Value, dtpHasta.Value)

            Case 2
                objRN.EstEsterilizaciones(dgvEstadisticas, dtpDesde.Value, dtpHasta.Value)

            Case 3
                objRN.EstMascotasConSinDueño(dgvEstadisticas)

        End Select
    End Sub

    Private Sub cmbEstadisticas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEstadisticas.SelectedIndexChanged
        dgvEstadisticas.DataSource = ""
        ValidarEnabledFecha()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class