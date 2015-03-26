Imports Adoptantes_RN


Public Class ABMProducto
    Private reglaProducto As ReglasProducto
    Private mensajeError As String

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        reglaProducto = New ReglasProducto()
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        If txtFiltro.Text.Length > 2 Then
            ''Filtrar la lista
            Dim result = reglaProducto.Buscar(txtFiltro.Text, mensajeError)
            If String.IsNullOrEmpty(mensajeError) Then
                ''Cargar la lista.
                Me.lstProductos.DataSource = Nothing
                Me.lstProductos.Items.Clear()
                Me.lstProductos.DataSource = result
            Else
                ''Mostrar el error.
                MsgBox(mensajeError, MsgBoxStyle.OkOnly, "Búsqueda")
            End If
        End If
    End Sub
End Class