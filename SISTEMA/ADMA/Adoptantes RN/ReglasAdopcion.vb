Imports System.Windows.Forms

Public Class ReglasAdopcion


    Public Function BuscarAdoptante(ByVal DNI As String, ByVal Nombre As TextBox, ByVal Apellido As TextBox) As Boolean
        Try
            Dim TABLA As DataTable
            Dim objAD As New Adoptantes_AD.DatosAdopcion
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

    Public Function BuscarMascota(ByVal IDMascota As Integer, ByVal txtNombreMascota As TextBox, ByVal txtSexo As TextBox, ByVal txtColor As TextBox, ByVal txtEspecie As TextBox, ByVal txtTamaño As TextBox)

        Try
            Dim TABLA As DataTable
            Dim objAD As New Adoptantes_AD.DatosAdopcion
            TABLA = objAD.ObtenerMascota(IDMascota)

            txtNombreMascota.Text = ""
            txtSexo.Text = ""
            txtColor.Text = ""
            txtEspecie.Text = ""
            txtTamaño.Text = ""

            For Each RCLI As DataRow In TABLA.Rows
                txtNombreMascota.Text = RCLI("nombre")
                txtEspecie.Text = RCLI("Especie")
                txtSexo.Text = RCLI("Sexo")
                txtTamaño.Text = RCLI("Tamanio")
                txtColor.Text = RCLI("color")

            Next
            If txtNombreMascota.Text <> "" Then
                Return True
            Else
                Return False

            End If

        Catch


            Return False
        End Try

    End Function


    Public Function BuscarDueño(ByVal IDMascota As Integer, ByVal dueño As String)

        Try
            Dim TABLA As DataTable
            Dim objAD As New Adoptantes_AD.DatosAdopcion
            TABLA = objAD.ObtenerMascota(IDMascota)

            dueño = ""

            For Each RCLI As DataRow In TABLA.Rows
                dueño = RCLI("Dueño")

            Next
            If dueño = "Si" Then
                Return True
            Else
                Return False

            End If

        Catch


            Return False
        End Try

    End Function


    Public Sub CrearAdopcion(ByVal IDMascota As Integer, ByVal DNI As Integer, ByVal FechaAdopcion As Date, ByVal Comentarios As String)
        Dim objAD As New Adoptantes_AD.DatosAdopcion
        objAD.CrearAdopcion(IDMascota, DNI, FechaAdopcion, Comentarios)

    End Sub

    Public Sub BorrarAdopcion(ByVal IDMascota As Integer)
        Dim objAD As New Adoptantes_AD.DatosAdopcion
        objAD.BorrarAdopcion(IDMascota)

    End Sub

    Public Sub ModificarDueño(ByVal IDMascota As Integer, ByVal dueño As String)
        Dim objAD As New Adoptantes_AD.DatosAdopcion
        objAD.ModificarDueño(IDMascota, dueño)

    End Sub
    Public Sub TodosLosAdoptantes()

    End Sub
End Class
