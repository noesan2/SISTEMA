Public Class TodasLasMascotas

    Private Sub TodasLasMascotas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim objRN As New Adoptantes_RN.ReglasBuscar
        Dim bandera As Boolean = False
        dgvMascotas.DataSource = ""

        bandera = objRN.ObtenerTodasLasMascotas(dgvMascotas)

        If bandera = True Then
            lblTotal.Text = dgvMascotas.RowCount


        Else
            MessageBox.Show("No se han podido cargar los datos", "ERROR")

        End If
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        dgvMascotas.DataSource = ""

        Me.Close()

    End Sub
End Class