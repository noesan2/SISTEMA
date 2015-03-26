Public Class NuevoBarrio

    Private Sub Inicializar()
        txtNombreBarrio.Text = ""
        cmdGuardar.Enabled = False
        txtNombreBarrio.Focus()

    End Sub
    Private Sub ValidarGrabar()
        If txtNombreBarrio.Text.Trim <> "" Then
            cmdGuardar.Enabled = True
        Else
            cmdGuardar.Enabled = False

        End If
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        If MessageBox.Show("Está seguro de crear un nuevo barrio? Tenga en cuenta que este dato no puede eliminarse o modificarse", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
            Dim objRN As New Adoptantes_RN.ReglasAdoptantes

            Dim bandera As Boolean = False
            bandera = objRN.BuscarBarrio(txtNombreBarrio.Text.Trim)

            If bandera = True Then
                objRN.NuevoBarrio(txtNombreBarrio.Text.Trim)
                Inicializar()
                MessageBox.Show("El barrio ha sido creado correctamente", "Información")

                Me.Close()

            Else
                MessageBox.Show("El barrio ya existe y no puede ser creado nuevamente")
            End If



        End If
    End Sub

    Private Sub txtNombreBarrio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombreBarrio.TextChanged
        ValidarGrabar()
    End Sub

    Private Sub NuevoBarrio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Inicializar()

    End Sub
End Class