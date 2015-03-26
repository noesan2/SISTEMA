Public Class MascotaPerdida

    Private Sub Inicializar()
        txtApellido.Text = ""
        txtNombre.Text = ""
        txtSexo.Text = ""
        txtDNI.Text = ""
        txtDomicilio.Text = ""
        txtTelefono.Text = ""
        txtBarrio.Text = ""
        cmdBuscarIDMascota.Enabled = False
        txtIDMascota.Text = ""
        txtIDMascota.Focus()


    End Sub
    Private Sub ValidarBuscarMascota()
        If txtIDMascota.Text.Trim <> "" Then
            cmdBuscarIDMascota.Enabled = True
        Else
            cmdBuscarIDMascota.Enabled = False

        End If
    End Sub
    Private Sub ValidarBuscarDueño()
        If txtDNIBuscar.Text.Trim <> "" Then
            cmdBuscarDNI.Enabled = True
        Else
            cmdBuscarDNI.Enabled = False

        End If
    End Sub

    Private Sub cmdBuscarIDMascota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscarIDMascota.Click
        Dim objRN As New Adoptantes_RN.ReglasBuscar
        Dim bandera As Boolean = False
        bandera = objRN.BuscarMascota(txtIDMascota.Text.Trim, txtNombre, txtApellido, txtDNI, txtDomicilio, txtSexo, txtTelefono, txtBarrio)

        If bandera = True Then

        Else
            MessageBox.Show("La mascota no está cargada en el sistema o no tiene dueño asignado", "ERROR")

        End If


    End Sub


    Private Sub MascotaPerdida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Inicializar()

    End Sub

    Private Sub cmdLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLimpiar.Click
        Inicializar()

    End Sub

    Private Sub txtIDMascota_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIDMascota.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdBuscarIDMascota.PerformClick()
        End If
    End Sub

    Private Sub txtIDMascota_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIDMascota.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtIDMascota_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIDMascota.TextChanged
        ValidarBuscarMascota()

    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Inicializar()

        Me.Close()

    End Sub

   
    Private Sub cmdBuscarDNI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscarDNI.Click
        Dim objRN As New Adoptantes_RN.ReglasBuscar
        Dim bandera As Boolean = False
        bandera = objRN.BuscarDueño(dgvMascotas, txtDNIBuscar.Text.Trim)

        If bandera = True Then

        Else
            MessageBox.Show("El adoptante no está cargado en el sistema", "ERROR")

        End If
    End Sub

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Click
        Me.dgvMascotas.DataSource = Nothing


    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        Me.dgvMascotas.DataSource = Nothing
        txtDNIBuscar.Text = ""

        Inicializar()
        If TabControl1.SelectedIndex = 0 Then
            txtIDMascota.Focus()
        Else
            txtDNIBuscar.Focus()

        End If
    End Sub

    Private Sub txtDNIBuscar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDNIBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdBuscarDNI.PerformClick()
        End If
    End Sub

    Private Sub txtDNIBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDNIBuscar.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub


    Private Sub txtDNIBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDNIBuscar.TextChanged
        ValidarBuscarDueño()
        Me.dgvMascotas.DataSource = Nothing
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        dgvMascotas.DataSource = ""

        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.dgvMascotas.DataSource = Nothing
        txtDNIBuscar.Text = ""
    End Sub

   
    Private Sub TabControl1_TabIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.TabIndexChanged
        Me.dgvMascotas.DataSource = Nothing
        txtDNIBuscar.Text = ""
        ValidarBuscarDueño()
        Inicializar()
        If TabControl1.SelectedIndex = 0 Then
            txtIDMascota.Focus()
        Else
            txtDNIBuscar.Focus()

        End If
    End Sub
End Class