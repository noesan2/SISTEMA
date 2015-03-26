Imports System.Windows.Forms
Public Class ReglasAdoptantes

    Public Sub CrearAdoptante(ByVal Nombre As String, ByVal Apellido As String, ByVal DNI As Integer, ByVal FechaNac As Date, ByVal Sexo As String, ByVal IDBarrio As Integer, ByVal Domicilio As String, ByVal Telefono As String, ByVal Comentarios As String)
        Dim objAD As New Adoptantes_AD.DatosAdoptantes
        objAD.CrearAdoptante(Nombre, Apellido, DNI, FechaNac, Sexo, IDBarrio, Domicilio, Telefono, Comentarios)

    End Sub
    Public Sub ModificarAdoptante(ByVal Nombre As String, ByVal Apellido As String, ByVal DNI As Integer, ByVal FechaNac As Date, ByVal Sexo As String, ByVal IDBarrio As Integer, ByVal Domicilio As String, ByVal Telefono As String, ByVal Comentarios As String)
        Dim objAD As New Adoptantes_AD.DatosAdoptantes
        objAD.ModificarAdoptante(Nombre, Apellido, DNI, FechaNac, Sexo, IDBarrio, Domicilio, Telefono, Comentarios)

    End Sub

    Public Sub ObtenerBarrios(ByVal COMBO As ComboBox)

        Dim TABLA As DataTable
        Dim objAD As New Adoptantes_AD.DatosAdoptantes
        TABLA = objAD.ObtenerBarrios
        COMBO.DisplayMember = "nombrebarrio"
        COMBO.ValueMember = "idbarrio"
        COMBO.DataSource = TABLA

    End Sub
    Public Function BuscarAdoptante(ByVal DNI As String, ByVal Nombre As TextBox, ByVal Apellido As TextBox, ByVal Fecha As DateTimePicker, ByVal Sexo As ComboBox, ByVal IDBarrio As ComboBox, ByVal Domicilio As TextBox, ByVal Telefono As TextBox, ByVal txtComentarios As TextBox) As Boolean

        Try
            Dim TABLA As DataTable
            Dim objAD As New Adoptantes_AD.DatosAdoptantes
            TABLA = objAD.ObtenerAdoptante(DNI)
            Apellido.Text = ""
            Nombre.Text = ""
            Fecha.Text = ""
            Sexo.SelectedIndex = -1
            Domicilio.Text = ""
            Telefono.Text = ""
            IDBarrio.SelectedIndex = -1
            txtComentarios.Text = ""



            For Each RCLI As DataRow In TABLA.Rows
                Apellido.Text = RCLI("Apellido")
                Nombre.Text = RCLI("nombre")
                Fecha.Text = RCLI("FechaNac")
                Sexo.Text = RCLI("Sexo")
                Domicilio.Text = RCLI("Domicilio")
                Telefono.Text = RCLI("Telefono")
                IDBarrio.SelectedValue = RCLI("IDBarrio")
                txtComentarios.Text = RCLI("Comentarios")

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

    Public Function BorrarAdoptante(ByVal DNI As Integer) As Boolean

        Try
            Dim ObjAD As New Adoptantes_AD.DatosAdoptantes
            ObjAD.ModificarDueñoAlEliminarAdoptante(DNI)
            ObjAD.BorrarAdopcionDNI(DNI)
            ObjAD.BorrarAdoptante(DNI)


            Return True
        Catch ex As Exception
            Return False

        End Try

    End Function

    Public Sub NuevoBarrio(ByVal NombreBarrio As String)
        Try
            Dim objAD As New Adoptantes_AD.DatosAdoptantes
            objAD.NuevoBarrio(NombreBarrio)
        Catch ex As Exception
            MessageBox.Show("No se ha podido crear el barrio", "Error")

        End Try
        

    End Sub

    Public Function BuscarBarrio(ByVal NombreBarrio As String) As Boolean
        Try
            Dim TABLA As DataTable
            Dim objAD As New Adoptantes_AD.DatosAdoptantes
            Dim NombreValidar As String = ""
            TABLA = objAD.BuscarBarrio(NombreBarrio)
            For Each RCLI As DataRow In TABLA.Rows
                NombreValidar = RCLI("NombreBarrio")

            Next

            If NombreValidar = "" Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
