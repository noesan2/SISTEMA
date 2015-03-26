Public Class AltaAdoptante
    Private Sub Inicializar()
        txtApellido.Text = ""
        txtNombre.Text = ""
        txtDNI.Text = ""
        txtDNIBusqueda.Text = ""
        txtDomicilio.Text = ""
        txtTelefono.Text = ""
        txtComentarios.Text = ""
        cmbBarrio.SelectedIndex = -1
        cmbSexo.SelectedIndex = -1
        dtpFechaNac.Value = Now
        cmdGrabar.Text = "Grabar"
        cmdGrabar.Enabled = False
        cmdEliminar.Enabled = False
        txtDNI.Enabled = False
        txtDNIBusqueda.Focus()

    End Sub

    Private Sub ValidarGrabar()
        If txtApellido.Text.Trim <> "" And txtNombre.Text.Trim <> "" And txtDomicilio.Text.Trim <> "" And txtTelefono.Text.Trim <> "" And cmbBarrio.SelectedIndex <> -1 And cmbSexo.SelectedIndex <> -1 Then
            cmdGrabar.Enabled = True
        Else
            cmdGrabar.Enabled = False
        End If
    End Sub
 

    Private Sub cmdGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGrabar.Click
        If cmdGrabar.Text = "Grabar" Then
            Try
                Dim objRN As New Adoptantes_RN.ReglasAdoptantes
                objRN.CrearAdoptante(txtNombre.Text, txtApellido.Text, txtDNI.Text, dtpFechaNac.Value.Date, cmbSexo.SelectedItem, cmbBarrio.SelectedValue, txtDomicilio.Text, txtTelefono.Text, txtComentarios.Text)
                Inicializar()
                MessageBox.Show("Los datos han sido grabados correctamente", "Confirmacion")

            Catch ex As Exception
                MessageBox.Show("No se ha grabado el adoptante, por favor revise los datos", "ERROR")
            End Try
        Else
            Try
                Dim objRN As New Adoptantes_RN.ReglasAdoptantes
                objRN.ModificarAdoptante(txtNombre.Text, txtApellido.Text, txtDNI.Text, dtpFechaNac.Value, cmbSexo.SelectedItem, cmbBarrio.SelectedValue, txtDomicilio.Text, txtTelefono.Text, txtComentarios.Text)
                MessageBox.Show("Los datos han sido modificados correctamente", "Información")
            Catch ex As Exception
                MessageBox.Show("No se ha grabado el adoptante, por favor revise los datos", "ERROR")
            End Try
        End If
    End Sub


    Private Sub AltaAdoptante_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim objRN As New Adoptantes_RN.ReglasAdoptantes
        objRN.ObtenerBarrios(cmbBarrio)
        Inicializar()

    End Sub


    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        If txtDNI.Text.Trim <> txtDNIBusqueda.Text.Trim Then
            Dim objRN As New Adoptantes_RN.ReglasAdoptantes
            Dim bandera As Boolean = False
            bandera = objRN.BuscarAdoptante(txtDNIBusqueda.Text, txtNombre, txtApellido, dtpFechaNac, cmbSexo, cmbBarrio, txtDomicilio, txtTelefono, txtComentarios)
            If bandera = True Then
                txtDNI.Text = txtDNIBusqueda.Text.Trim
                cmdGrabar.Text = "Modificar"
                cmdEliminar.Enabled = True
                txtDNI.Enabled = False
            Else
                txtDNI.Text = ""
                cmdEliminar.Enabled = False
                txtDNI.Enabled = False
                If MessageBox.Show("El Adoptante no existe. Desea crearlo?", "Atención", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    txtDNI.Text = txtDNIBusqueda.Text.Trim
                    txtDNI.Enabled = False
                    cmdGrabar.Text = "Grabar"
                    txtNombre.Focus()

                Else
                    txtDNI.Enabled = False
                End If

            End If

        End If

    End Sub

    Private Sub cmdLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLimpiar.Click
        Inicializar()


    End Sub

    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        If MessageBox.Show("¿Esta seguro que desea eliminar este adoptante?", "Confirmar eliminacion", MessageBoxButtons.YesNo) = vbYes Then
            Dim objRN As New Adoptantes_RN.ReglasAdoptantes
            objRN.BorrarAdoptante(txtDNI.Text)
            Inicializar()
            MessageBox.Show("Los datos han sido borrados", "Confirmacion")

        Else
            MessageBox.Show("Los datos no han sido borrados")


        End If

    End Sub

    Private Sub txtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged
        ValidarGrabar()

    End Sub

    Private Sub txtApellido_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtApellido.TextChanged
        ValidarGrabar()

    End Sub

    Private Sub txtDNI_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDNI.TextChanged
        ValidarGrabar()

    End Sub

    Private Sub cmbSexo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSexo.SelectedIndexChanged
        ValidarGrabar()

    End Sub

    Private Sub txtDomicilio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDomicilio.TextChanged
        ValidarGrabar()
    End Sub

    Private Sub cmbBarrio_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmbBarrio.MouseClick
        Dim objRN As New Adoptantes_RN.ReglasAdoptantes
        objRN.ObtenerBarrios(cmbBarrio)
    End Sub

    Private Sub cmbBarrio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBarrio.SelectedIndexChanged
        ValidarGrabar()
      
    End Sub

    Private Sub txtTelefono_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTelefono.TextChanged
        ValidarGrabar()
    End Sub
    Private Sub txtDNI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDNI.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtDNIBusqueda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDNI.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtDNIBusqueda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDNIBusqueda.KeyDown
        If e.KeyCode = Keys.Enter And txtDNIBusqueda.Text.Trim <> "" Then
            cmdBuscar.PerformClick()

        End If
    End Sub

    Private Sub txtDNIBusqueda_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDNIBusqueda.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

  
    Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Me.Close()

    End Sub

    
   
    Private Sub cmdNuevoBarrio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevoBarrio.Click
        NuevoBarrio.ShowDialog()

    End Sub

    Private Sub AltaAdoptante_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Enter
        Dim objRN As New Adoptantes_RN.ReglasAdoptantes
        objRN.ObtenerBarrios(cmbBarrio)
        txtDNIBusqueda.Focus()

    End Sub
End Class
