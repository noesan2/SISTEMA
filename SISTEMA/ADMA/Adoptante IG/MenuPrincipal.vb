Public Class MenuPrincipal

    Private Sub CrearAdoptanteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrearAdoptanteToolStripMenuItem.Click

        AltaAdoptante.ShowDialog()

    End Sub

    Private Sub GestionarMascotaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionarMascotaToolStripMenuItem.Click
        AltaMascota.ShowDialog()

    End Sub

    Private Sub CrearNuevaAdopcionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrearNuevaAdopcionToolStripMenuItem.Click
        CrearAdopcion.ShowDialog()

    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        'Me.Close()
        ABMProducto.ShowDialog()
    End Sub

    Private Sub MascotaPerdidaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MascotaPerdidaToolStripMenuItem.Click
        MascotaPerdida.ShowDialog()
    End Sub

    Private Sub VerTodosLosAdoptantesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerTodosLosAdoptantesToolStripMenuItem.Click
        TodosLosAdoptantes.ShowDialog()

    End Sub

    Private Sub VerTodasLasMascotasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerTodasLasMascotasToolStripMenuItem.Click
        TodasLasMascotas.ShowDialog()

    End Sub

    Private Sub VerTodasLasAdopcionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerTodasLasAdopcionesToolStripMenuItem.Click
        TodasLasAdopciones.ShowDialog()

    End Sub

    Private Sub ConsultarEstadisticasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarEstadisticasToolStripMenuItem.Click
        Estadisticas.ShowDialog()

    End Sub
End Class