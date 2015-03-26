Imports System.Windows.Forms
Public Class ReglasMascota
    Public Sub CrearMascota(ByVal Nombre As String, ByVal IDMascota As Integer, ByVal Especie As String, ByVal Sexo As String, ByVal edad As Integer, ByVal tamaño As String, ByVal color As String, ByVal caracteristicas As String, ByVal FechaEsterilizacion As Date, ByVal dueño As String, ByVal Comentarios As String)
        Dim objAD As New Adoptantes_AD.DatosMascota
        objAD.CrearMascota(Nombre, IDMascota, Especie, Sexo, edad, tamaño, color, caracteristicas, FechaEsterilizacion, dueño, Comentarios)

    End Sub

    Public Sub ModificarMascota(ByVal Nombre As String, ByVal IDMascota As Integer, ByVal Especie As String, ByVal Sexo As String, ByVal edad As Integer, ByVal tamaño As String, ByVal color As String, ByVal caracteristicas As String, ByVal FechaEsterilizacion As Date, ByVal dueño As String, ByVal Comentarios As String)
        Dim objAD As New Adoptantes_AD.DatosMascota
        objAD.ModificarMascota(Nombre, IDMascota, Especie, Sexo, edad, tamaño, color, caracteristicas, FechaEsterilizacion, dueño, Comentarios)

    End Sub
    Public Function BuscarAdoptante(ByVal DNI As String, ByVal Nombre As TextBox, ByVal Apellido As TextBox) As Boolean
        Try
            Dim TABLA As DataTable
            Dim objAD As New Adoptantes_AD.DatosMascota
            TABLA = objAD.ObtenerAdoptante(DNI)
            Apellido.Text = ""
            Nombre.Text = ""
            For Each RCLI As DataRow In TABLA.Rows
                Apellido.Text = RCLI("Apellido")
                Nombre.Text = RCLI("nombre")
            Next
            If Apellido.Text <> "" Then
                Return True
            Else
                Return False

            End If

        Catch
            Return False
        End Try

    End Function
    Public Function BuscarMascota(ByVal IDMascota As Integer _
                                  , ByVal txtEdad As TextBox _
                                  , ByVal txtNombre As TextBox _
                                  , ByVal cmbSexo As ComboBox _
                                  , ByVal cmbCaracteristicas As ComboBox _
                                  , ByVal cmbcolor As ComboBox _
                                  , ByVal cmbEspecie As ComboBox _
                                  , ByVal cmbTamaño As ComboBox _
                                  , ByVal FechaEsterilizacion As DateTimePicker _
                                  , ByVal Comentarios As TextBox _
                                  , ByVal Dueño As ComboBox)

        Try
            Dim TABLA As DataTable
            Dim objAD As New Adoptantes_AD.DatosMascota
            TABLA = objAD.ObtenerMascota(IDMascota)
            txtEdad.Text = ""
            txtNombre.Text = ""
            cmbSexo.SelectedIndex = -1
            cmbCaracteristicas.SelectedIndex = -1
            cmbcolor.SelectedIndex = -1
            cmbEspecie.SelectedIndex = -1
            cmbTamaño.SelectedIndex = -1
            Comentarios.Text = ""

            For Each RCLI As DataRow In TABLA.Rows
                txtNombre.Text = RCLI("nombre")
                cmbEspecie.Text = RCLI("Especie")
                txtEdad.Text = RCLI("Edad")
                cmbSexo.Text = RCLI("Sexo")
                cmbTamaño.Text = RCLI("Tamanio")
                cmbcolor.Text = RCLI("color")
                cmbCaracteristicas.Text = RCLI("caracteristicas")
                FechaEsterilizacion.Value = RCLI("Fechaesterilizacion")
                Comentarios.Text = RCLI("Comentarios")
                Dueño.SelectedItem = RCLI("Dueño")
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

    Public Sub CrearAdopcion(ByVal IDMascota As Integer, ByVal DNI As Integer, ByVal FechaAdopcion As Date, ByVal Comentarios As String)
        Dim objAD As New Adoptantes_AD.DatosMascota
        objAD.CrearAdopcion(IDMascota, DNI, FechaAdopcion, Comentarios)

    End Sub

    Public Sub ObtenerAdopcion(ByVal IDMascota As Integer, ByVal txtDNI As TextBox, ByVal txtComentariosAdopcion As TextBox)
        Try
            Dim TABLA As DataTable
            Dim objAD As New Adoptantes_AD.DatosMascota
            TABLA = objAD.ObtenerAdopcion(IDMascota)

            For Each RCLI As DataRow In TABLA.Rows
                txtDNI.Text = RCLI("DNI")
                txtComentariosAdopcion.Text = RCLI("Comentarios")
            Next
        Catch

        End Try

    End Sub

    Public Function BorrarMascota(ByVal IDMascota As Integer) As Boolean
        Try
            Dim objAD As New Adoptantes_AD.DatosMascota
            objAD.BorrarAdopcion(IDMascota)
            objAD.BorrarMascota(IDMascota)
            Return True
        Catch
            Return False
        End Try

    End Function
End Class
