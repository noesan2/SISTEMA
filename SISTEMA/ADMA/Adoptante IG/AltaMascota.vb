
Public Class AltaMascota

    Private Sub inicializar()
        txtApellido.Text = ""
        txtDNI.Text = ""
        txtEdad.Text = ""
        txtIDMascota.Text = ""
        txtIDMascotaBuscar.Text = ""
        txtNombre.Text = ""
        txtNombreAdoptante.Text = ""
        txtComentarios.Text = ""
        cmbSexo.SelectedIndex = -1
        cmbCaracteristicas.SelectedIndex = -1
        cmbColor.SelectedIndex = -1
        cmbEspecie.SelectedIndex = -1
        cmbTamaño.SelectedIndex = -1
        dtpEsterilizado.Value = Now
        dtpAdoptado.Value = Now
        cmdGrabar.Enabled = False
        txtIDMascotaBuscar.Focus()
        cmbDueño.SelectedIndex = 1
        txtDNI.Enabled = False
        txtNombreAdoptante.Enabled = False
        txtApellido.Enabled = False
        cmdBuscar.Enabled = False
        cmdEliminar.Enabled = False
        txtIDMascota.Enabled = False
        dtpAdoptado.Enabled = False
        txtComentariosAdopcion.Text = ""

    End Sub
    Private Sub ValidarGrabar()
        If txtNombre.Text.Trim <> "" And txtEdad.Text.Trim <> "" And txtIDMascota.Text.Trim <> "" And cmbCaracteristicas.SelectedIndex <> -1 And cmbColor.SelectedIndex <> -1 And cmbEspecie.SelectedIndex <> -1 And cmbSexo.SelectedIndex <> -1 And cmbTamaño.SelectedIndex <> -1 Then

            cmdGrabar.Enabled = True
        Else
            cmdGrabar.Enabled = False

        End If

        If cmbDueño.SelectedItem = "Si" Then
            If txtApellido.Text.Trim <> "" And txtNombreAdoptante.Text.Trim <> "" Then
                cmdGrabar.Enabled = True
            Else
                cmdGrabar.Enabled = False
            End If
        End If
    End Sub
    Private Sub ValidarDueño()
        If cmbDueño.SelectedItem = "Si" Then
            txtDNI.Enabled = True
            cmdBuscar.Enabled = True
            dtpAdoptado.Enabled = True
            txtComentariosAdopcion.Enabled = True
        Else
            txtDNI.Enabled = False
            txtDNI.Text = ""
            txtNombreAdoptante.Text = ""
            txtApellido.Text = ""
            txtComentariosAdopcion.Text = ""
            cmdBuscar.Enabled = False
            dtpAdoptado.Enabled = False
            txtComentariosAdopcion.Enabled = False
        End If
    End Sub

    Private Sub cmdGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGrabar.Click
        If cmbDueño.SelectedItem = "Si" Then
            If MessageBox.Show("Está seguro de " & cmdGrabar.Text & " la mascota y asignarle " & txtNombreAdoptante.Text & " " & txtApellido.Text & " como adoptante?", "Atención", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                If cmdGrabar.Text = "Grabar" Then
                    Try
                        Dim objRN2 As New Adoptantes_RN.ReglasAdopcion
                        objRN2.ModificarDueño(txtIDMascota.Text.Trim, "Si")
                        objRN2.BorrarAdopcion(txtIDMascota.Text.Trim)

                        Dim objRN As New Adoptantes_RN.ReglasMascota
                        objRN.CrearMascota(txtNombre.Text, txtIDMascota.Text, cmbEspecie.SelectedItem, cmbSexo.SelectedItem, txtEdad.Text.Trim, cmbTamaño.SelectedItem, cmbColor.SelectedItem, cmbCaracteristicas.SelectedItem, dtpEsterilizado.Value, cmbDueño.SelectedItem, txtComentarios.Text)
                        objRN.CrearAdopcion(txtIDMascota.Text, txtDNI.Text, dtpAdoptado.Value, txtComentariosAdopcion.Text)

                        MessageBox.Show("La mascota ha sido cargada correctamente y se le ha asignado " & txtNombreAdoptante.Text & " " & txtApellido.Text & " como adoptante", "Información")
                        inicializar()

                    Catch ex As Exception
                        MessageBox.Show("No se ha grabado la mascota, por favor revise los datos", "ERROR")
                    End Try
                Else
                    Try
                        Dim objRN2 As New Adoptantes_RN.ReglasAdopcion
                        objRN2.ModificarDueño(txtIDMascota.Text.Trim, "Si")
                        objRN2.BorrarAdopcion(txtIDMascota.Text.Trim)

                        Dim objRN As New Adoptantes_RN.ReglasMascota
                        objRN.ModificarMascota(txtNombre.Text, txtIDMascota.Text, cmbEspecie.SelectedItem, cmbSexo.SelectedItem, txtEdad.Text.Trim, cmbTamaño.SelectedItem, cmbColor.SelectedItem, cmbCaracteristicas.SelectedItem, dtpEsterilizado.Value, cmbDueño.SelectedItem, txtComentarios.Text)
                        objRN.CrearAdopcion(txtIDMascota.Text, txtDNI.Text, dtpAdoptado.Value, txtComentariosAdopcion.Text)


                        MessageBox.Show("La mascota ha sido modificada correctamente", "Información")
                        inicializar()
                    Catch ex As Exception
                        MessageBox.Show("No se ha grabado el adoptante, por favor revise los datos", "ERROR")
                    End Try
                End If

            End If





        Else
            cmbDueño.SelectedItem = "No"
            ValidarDueño()
            If MessageBox.Show("Está seguro de cargar una mascota sin adoptante?", "Atención", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                If cmdGrabar.Text = "Grabar" Then
                    Try

                        Dim objRN As New Adoptantes_RN.ReglasMascota
                        objRN.CrearMascota(txtNombre.Text, txtIDMascota.Text, cmbEspecie.SelectedItem, cmbSexo.SelectedItem, txtEdad.Text.Trim, cmbTamaño.SelectedItem, cmbColor.SelectedItem, cmbCaracteristicas.SelectedItem, dtpEsterilizado.Value, cmbDueño.SelectedItem, txtComentarios.Text)
                        MessageBox.Show("La mascota ha sido cargada correctamente y no se le ha asignado ningún adoptante", "Información")
                        inicializar()

                    Catch ex As Exception
                        MessageBox.Show("No se ha grabado la mascota, por favor revise los datos", "ERROR")
                    End Try
                Else
                    Try
                        Dim objRN2 As New Adoptantes_RN.ReglasAdopcion
                        objRN2.ModificarDueño(txtIDMascota.Text.Trim, "No")
                        objRN2.BorrarAdopcion(txtIDMascota.Text.Trim)

                        Dim objRN As New Adoptantes_RN.ReglasMascota

                        objRN.ModificarMascota(txtNombre.Text, txtIDMascota.Text, cmbEspecie.SelectedItem, cmbSexo.SelectedItem, txtEdad.Text.Trim, cmbTamaño.SelectedItem, cmbColor.SelectedItem, cmbCaracteristicas.SelectedItem, dtpEsterilizado.Value, cmbDueño.SelectedItem, txtComentarios.Text)
                        MessageBox.Show("La mascota ha sido modificada correctamente", "Información")
                        inicializar()
                    Catch ex As Exception
                        MessageBox.Show("No se ha grabado el adoptante, por favor revise los datos", "ERROR")
                    End Try
                End If
            End If
        End If



    End Sub


    Private Sub AltaMascota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        inicializar()

    End Sub

    Private Sub cmdLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLimpiar.Click
        inicializar()

    End Sub

    Private Sub txtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged
        ValidarGrabar()
    End Sub

    Private Sub txtIDMascota_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIDMascota.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtIDMascota_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIDMascota.TextChanged
        ValidarGrabar()
    End Sub

    Private Sub txtEdad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEdad.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtEdad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEdad.TextChanged
        ValidarGrabar()
    End Sub

    Private Sub cmbEspecie_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEspecie.SelectedIndexChanged
        ValidarGrabar()
    End Sub

    Private Sub cmbSexo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSexo.SelectedIndexChanged
        ValidarGrabar()
    End Sub

    Private Sub cmbColor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbColor.SelectedIndexChanged
        ValidarGrabar()
    End Sub

    Private Sub cmbTamaño_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTamaño.SelectedIndexChanged
        ValidarGrabar()
    End Sub

    Private Sub cmbCaracteristicas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCaracteristicas.SelectedIndexChanged
        ValidarGrabar()
    End Sub

    Private Sub dtpEsterilizado_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpEsterilizado.ValueChanged
        ValidarGrabar()
    End Sub



    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDueño.SelectedIndexChanged
        ValidarDueño()
        ValidarGrabar()

    End Sub

    Private Sub cmdBuscarMascota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscarMascota.Click
        If txtIDMascota.Text.Trim <> txtIDMascotaBuscar.Text.Trim Then
            Dim objRN As New Adoptantes_RN.ReglasMascota
            Dim bandera As Boolean = False
            bandera = objRN.BuscarMascota(txtIDMascotaBuscar.Text.Trim, txtEdad, txtNombre, cmbSexo, cmbCaracteristicas, cmbColor, cmbEspecie, cmbTamaño, dtpEsterilizado, txtComentarios, cmbDueño)

            If bandera = True Then
                txtIDMascota.Text = txtIDMascotaBuscar.Text.Trim
                cmdGrabar.Text = "Modificar"
                cmdEliminar.Enabled = True
                txtIDMascota.Enabled = False
                If cmbDueño.SelectedItem = "Si" Then
                    objRN.ObtenerAdopcion(txtIDMascota.Text, txtDNI, txtComentariosAdopcion)
                    objRN.BuscarAdoptante(txtDNI.Text.Trim, txtNombreAdoptante, txtApellido)
                End If
            Else

                cmdEliminar.Enabled = False
                txtIDMascota.Text = ""
                If MessageBox.Show("La Mascota no existe. Desea crearla?", "Atención", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    txtIDMascota.Text = txtIDMascotaBuscar.Text.Trim
                    txtIDMascota.Enabled = False
                    cmdGrabar.Text = "Grabar"
                    txtNombre.Focus()

                Else
                    txtIDMascota.Enabled = False
                    txtIDMascota.Text = ""

                End If

            End If

        End If
    End Sub

    Private Sub txtIDMascotaBuscar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIDMascotaBuscar.KeyDown
        If e.KeyCode = Keys.Enter And txtIDMascotaBuscar.Text.Trim <> "" Then
            cmdBuscarMascota.PerformClick()

        End If
    End Sub

    Private Sub txtIDMascotaBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIDMascotaBuscar.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub



    Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Me.Close()

    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        Dim objRN As New Adoptantes_RN.ReglasMascota
        Dim bandera As Boolean = False
        bandera = objRN.BuscarAdoptante(txtDNI.Text, txtNombreAdoptante, txtApellido)
        If bandera = True Then
            ValidarGrabar()
        Else

            MessageBox.Show("El adoptante no existe, por favor primero cree el adoptante", "Error")

        End If
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

        txtApellido.Text = ""
        txtNombreAdoptante.Text = ""
        ValidarGrabar()
    End Sub

    Private Sub txtComentariosAdopcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtComentariosAdopcion.TextChanged
        ValidarGrabar()
    End Sub


    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        If MessageBox.Show("Está seguro que desea eliminar la mascota?", "Atención", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then



            Dim objRN As New Adoptantes_RN.ReglasMascota
            Dim bandera As Boolean = False
            bandera = objRN.BorrarMascota(txtIDMascota.Text)
            If bandera = True Then
                ValidarGrabar()
                inicializar()
                MessageBox.Show("La mascota ha sido eliminada correctamente", "Información")

            Else

                MessageBox.Show("No se ha podido eliminar la mascota correctamente", "Error")


            End If
        End If

    End Sub
End Class
