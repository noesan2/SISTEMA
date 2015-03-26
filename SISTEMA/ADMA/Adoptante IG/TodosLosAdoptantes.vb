Public Class TodosLosAdoptantes

    Private Sub TodosLosAdoptantes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim objRN As New Adoptantes_RN.ReglasBuscar
        Dim bandera As Boolean = False
        dgvAdoptantes.DataSource = ""

        bandera = objRN.ObtenerTodosLosAdoptantes(dgvAdoptantes)

        If bandera = True Then
            lblTotal.Text = dgvAdoptantes.RowCount()


        Else
            MessageBox.Show("No se han podido cargar los datos", "ERROR")

        End If
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        dgvAdoptantes.DataSource = ""

        Me.Close()

    End Sub
End Class