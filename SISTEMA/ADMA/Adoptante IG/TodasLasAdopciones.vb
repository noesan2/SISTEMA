Public Class TodasLasAdopciones

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        dgvAdoptantes.DataSource = ""

        Me.Close()

    End Sub

    Private Sub TodasLasAdopciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim objRN As New Adoptantes_RN.ReglasBuscar
        dgvAdoptantes.DataSource = ""

        Dim bandera As Boolean = False
        bandera = objRN.ObtenerTodasLasAdopciones(dgvAdoptantes)

        If bandera = True Then
            lblTotal.Text = dgvAdoptantes.RowCount
        Else
            MessageBox.Show("No se han podido cargar los datos", "ERROR")

        End If
    End Sub
End Class