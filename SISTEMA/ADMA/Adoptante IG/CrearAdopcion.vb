Public Class CrearAdopcion
    Public BorrarDueño As Boolean = False

    Private Sub InicializarTodo()
        txtApellido.Text = ""
        txtColor.Text = ""
        txtComentarios.Text = ""
        txtDNI.Text = ""
        txtEspecie.Text = ""
        txtIDMascota.Text = ""
        txtNombre.Text = ""
        txtNombreMascota.Text = ""
        txtSexo.Text = ""
        txtTamaño.Text = ""
        cmdCargar.Enabled = False
        BorrarDueño = False
        txtDNI.Focus()
        dtpFechaAdopcion.Value = Now


    End Sub
    Private Sub ValidarGrabar()
        If txtNombre.Text.Trim <> "" And txtNombreMascota.Text.Trim <> "" Then
            cmdCargar.Enabled = True
        Else
            cmdCargar.Enabled = False

        End If
    End Sub
    Private Sub InicializarMascota()
        txtColor.Text = ""
        txtComentarios.Text = ""
        txtEspecie.Text = ""
        txtNombreMascota.Text = ""
        txtSexo.Text = ""
        txtTamaño.Text = ""
        BorrarDueño = False

    End Sub
    Private Sub InicializarAdoptante()
        txtApellido.Text = ""
        txtNombre.Text = ""
    End Sub
    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        Dim objRN As New Adoptantes_RN.ReglasAdopcion
        Dim bandera As Boolean = False
        bandera = objRN.BuscarAdoptante(txtDNI.Text, txtNombre, txtApellido)
        If bandera = True Then

        Else

            MessageBox.Show("El adoptante no existe, por favor primero cree el adoptante", "Error")

        End If
    End Sub


    Private Sub cmdBuscarMascota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscarMascota.Click

        Dim objRN As New Adoptantes_RN.ReglasAdopcion
        Dim bandera As Boolean = False
        Dim tienedueño As Boolean = False
        Dim dueño As String = ""

        bandera = objRN.BuscarMascota(txtIDMascota.Text.Trim, txtNombreMascota, txtSexo, txtColor, txtEspecie, txtTamaño)

        If bandera = True Then
            tienedueño = objRN.BuscarDueño(txtIDMascota.Text.Trim, dueño)
            If tienedueño = True Then
                If MessageBox.Show("La Mascota ya tiene dueño, desea modificarle el dueño?", "Atención", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    BorrarDueño = True

                Else
                    InicializarMascota()
                    txtIDMascota.Text = ""

                End If
            End If
        Else


            MessageBox.Show("La Mascota no existe. Por favor primero ingresar la mascota", "Atención")
            txtIDMascota.Text = ""
        End If



    End Sub


    Private Sub cmdLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLimpiar.Click
        InicializarTodo()
    End Sub

    Private Sub CrearAdopcion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InicializarTodo()
    End Sub

    Private Sub txtIDMascota_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIDMascota.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdBuscarMascota.PerformClick()
        End If

      
    End Sub

    Private Sub txtIDMascota_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIDMascota.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtIDMascota_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIDMascota.TextChanged
        InicializarMascota()
        ValidarGrabar()
    End Sub

    Private Sub txtDNI_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDNI.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdBuscar.PerformClick()
        End If

    End Sub

    Private Sub txtDNI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDNI.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtDNI_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDNI.TextChanged
        InicializarAdoptante()
        ValidarGrabar()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCargar.Click
        If MessageBox.Show("Está seguro que desea crear la adopción?", "Atención", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            If BorrarDueño = True Then
                Try
                    Dim objRN2 As New Adoptantes_RN.ReglasAdopcion
                    objRN2.BorrarAdopcion(txtIDMascota.Text.Trim)
                    objRN2.ModificarDueño(txtIDMascota.Text.Trim, "No")

                Catch ex As Exception
                    MessageBox.Show("No se ha podido borrar adopción pre-existente", "ERROR")

                End Try
            End If
            Try

                Dim objRN As New Adoptantes_RN.ReglasAdopcion
                objRN.CrearAdopcion(txtIDMascota.Text.Trim, txtDNI.Text.Trim, dtpFechaAdopcion.Value, txtComentarios.Text.Trim)
                objRN.ModificarDueño(txtIDMascota.Text.Trim, "Si")

                InicializarTodo()
                MessageBox.Show("Los datos han sido grabados correctamente", "Confirmacion")

            Catch ex As Exception
                MessageBox.Show("Los datos no han sido grabados, por favor verifiquelos", "ERROR")
            End Try



        End If
    End Sub

    Private Sub txtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged
        ValidarGrabar()
    End Sub

    Private Sub txtNombreMascota_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombreMascota.TextChanged
        ValidarGrabar()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()

    End Sub
End Class
