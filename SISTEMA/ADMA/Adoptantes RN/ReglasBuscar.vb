Imports System.Windows.Forms
Public Class ReglasBuscar
    Public Function BuscarMascota(ByVal IDMascota As Integer, ByVal txtNombre As TextBox, ByVal txtApellido As TextBox, ByVal txtDNI As TextBox, ByVal txtDomicilio As TextBox, ByVal txtSexo As TextBox, ByVal txtTelefono As TextBox, ByVal txtBarrio As TextBox)

        Try
            Dim TABLA As DataTable
            Dim objAD As New Adoptantes_AD.DatosBuscar
            TABLA = objAD.BuscarMascota(IDMascota)
            txtApellido.Text = ""
            txtNombre.Text = ""
            txtSexo.Text = ""
            txtDNI.Text = ""
            txtDomicilio.Text = ""
            txtTelefono.Text = ""
            txtBarrio.Text = ""




            For Each RCLI As DataRow In TABLA.Rows
                txtApellido.Text = RCLI("Apellido")
                txtNombre.Text = RCLI("Nombre")
                txtSexo.Text = RCLI("Sexo")
                txtDNI.Text = RCLI("DNI")
                txtDomicilio.Text = RCLI("Domicilio")
                txtTelefono.Text = RCLI("Telefono")
                txtBarrio.Text = RCLI("Barrio")


            Next
            If txtNombre.Text <> "" Then
                Return True
            Else
                Return False

            End If

        Catch


            Return False
        End Try

    End Function

    Public Function BuscarDueño(ByVal GRILLA As DataGridView, ByVal DNI As Integer) As Boolean
        Try
            Dim objAD As New Adoptantes_AD.DatosBuscar
            Dim TABLA As New DataTable
            TABLA = objAD.ObtenerDueño(DNI)
            GRILLA.DataSource = TABLA
            Return True
        Catch

            Return False
        End Try
    End Function

    Public Function ObtenerTodosLosAdoptantes(ByVal GRILLA As DataGridView) As Boolean
        Try
            Dim objAD As New Adoptantes_AD.DatosBuscar
            Dim TABLA As New DataTable
            TABLA = objAD.ObtenerTodosLosAdoptantes()
            GRILLA.DataSource = TABLA
            Return True



        Catch ex As Exception
            Return False

        End Try

    End Function
    Public Function ObtenerTodasLasMascotas(ByVal GRILLA As DataGridView) As Boolean
        Try
            Dim objAD As New Adoptantes_AD.DatosBuscar
            Dim TABLA As New DataTable
            TABLA = objAD.ObtenerTodasLasMascotas()
            GRILLA.DataSource = TABLA
            Return True



        Catch ex As Exception
            Return False

        End Try

    End Function
    Public Function ObtenerTodasLasAdopciones(ByVal GRILLA As DataGridView) As Boolean
        Try
            Dim objAD As New Adoptantes_AD.DatosBuscar
            Dim TABLA As New DataTable
            TABLA = objAD.ObtenerTodasLasAdopciones()
            GRILLA.DataSource = TABLA
            Return True



        Catch ex As Exception
            Return False

        End Try

    End Function
End Class
