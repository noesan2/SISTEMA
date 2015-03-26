<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaMascota
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdLimpiar = New System.Windows.Forms.Button()
        Me.cmdCerrar = New System.Windows.Forms.Button()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtComentarios = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmbDueño = New System.Windows.Forms.ComboBox()
        Me.cmbTamaño = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbCaracteristicas = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpEsterilizado = New System.Windows.Forms.DateTimePicker()
        Me.cmbColor = New System.Windows.Forms.ComboBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.cmbEspecie = New System.Windows.Forms.ComboBox()
        Me.cmbSexo = New System.Windows.Forms.ComboBox()
        Me.txtIDMascota = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdBuscarMascota = New System.Windows.Forms.Button()
        Me.txtIDMascotaBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtComentariosAdopcion = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.txtNombreAdoptante = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtpAdoptado = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Location = New System.Drawing.Point(183, 647)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(75, 23)
        Me.cmdEliminar.TabIndex = 4
        Me.cmdEliminar.Text = "Eliminar"
        Me.cmdEliminar.UseVisualStyleBackColor = True
        '
        'cmdLimpiar
        '
        Me.cmdLimpiar.Location = New System.Drawing.Point(102, 647)
        Me.cmdLimpiar.Name = "cmdLimpiar"
        Me.cmdLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.cmdLimpiar.TabIndex = 5
        Me.cmdLimpiar.Text = "Limpiar"
        Me.cmdLimpiar.UseVisualStyleBackColor = True
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Location = New System.Drawing.Point(21, 647)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(75, 23)
        Me.cmdCerrar.TabIndex = 6
        Me.cmdCerrar.Text = "Cerrar"
        Me.cmdCerrar.UseVisualStyleBackColor = True
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Location = New System.Drawing.Point(281, 647)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(75, 23)
        Me.cmdGrabar.TabIndex = 3
        Me.cmdGrabar.Text = "Grabar"
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtComentarios)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.cmbDueño)
        Me.GroupBox1.Controls.Add(Me.cmbTamaño)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cmbCaracteristicas)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.dtpEsterilizado)
        Me.GroupBox1.Controls.Add(Me.cmbColor)
        Me.GroupBox1.Controls.Add(Me.txtEdad)
        Me.GroupBox1.Controls.Add(Me.cmbEspecie)
        Me.GroupBox1.Controls.Add(Me.cmbSexo)
        Me.GroupBox1.Controls.Add(Me.txtIDMascota)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(335, 404)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Mascota"
        '
        'txtComentarios
        '
        Me.txtComentarios.Location = New System.Drawing.Point(108, 312)
        Me.txtComentarios.MaxLength = 149
        Me.txtComentarios.Multiline = True
        Me.txtComentarios.Name = "txtComentarios"
        Me.txtComentarios.Size = New System.Drawing.Size(171, 46)
        Me.txtComentarios.TabIndex = 10
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(7, 312)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 13)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "Comentarios:"
        '
        'cmbDueño
        '
        Me.cmbDueño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDueño.FormattingEnabled = True
        Me.cmbDueño.Items.AddRange(New Object() {"Si", "No"})
        Me.cmbDueño.Location = New System.Drawing.Point(107, 364)
        Me.cmbDueño.Name = "cmbDueño"
        Me.cmbDueño.Size = New System.Drawing.Size(38, 21)
        Me.cmbDueño.TabIndex = 11
        '
        'cmbTamaño
        '
        Me.cmbTamaño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTamaño.FormattingEnabled = True
        Me.cmbTamaño.Items.AddRange(New Object() {"Chico", "Mediano", "Grande"})
        Me.cmbTamaño.Location = New System.Drawing.Point(106, 216)
        Me.cmbTamaño.Name = "cmbTamaño"
        Me.cmbTamaño.Size = New System.Drawing.Size(121, 21)
        Me.cmbTamaño.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 219)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Tamaño:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 371)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Tiene Dueño?"
        '
        'cmbCaracteristicas
        '
        Me.cmbCaracteristicas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCaracteristicas.FormattingEnabled = True
        Me.cmbCaracteristicas.Items.AddRange(New Object() {"Lindo", "Feo", "Peludo"})
        Me.cmbCaracteristicas.Location = New System.Drawing.Point(106, 248)
        Me.cmbCaracteristicas.Name = "cmbCaracteristicas"
        Me.cmbCaracteristicas.Size = New System.Drawing.Size(121, 21)
        Me.cmbCaracteristicas.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 251)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Caracteristicas:"
        '
        'dtpEsterilizado
        '
        Me.dtpEsterilizado.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEsterilizado.Location = New System.Drawing.Point(106, 280)
        Me.dtpEsterilizado.Name = "dtpEsterilizado"
        Me.dtpEsterilizado.Size = New System.Drawing.Size(104, 20)
        Me.dtpEsterilizado.TabIndex = 9
        '
        'cmbColor
        '
        Me.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbColor.FormattingEnabled = True
        Me.cmbColor.Items.AddRange(New Object() {"Blanco", "Negro", "Manchado", "Te con leche", "Gris", "Verde"})
        Me.cmbColor.Location = New System.Drawing.Point(106, 184)
        Me.cmbColor.Name = "cmbColor"
        Me.cmbColor.Size = New System.Drawing.Size(121, 21)
        Me.cmbColor.TabIndex = 6
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(106, 89)
        Me.txtEdad.MaxLength = 3
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(50, 20)
        Me.txtEdad.TabIndex = 3
        '
        'cmbEspecie
        '
        Me.cmbEspecie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEspecie.FormattingEnabled = True
        Me.cmbEspecie.Items.AddRange(New Object() {"Canino", "Felino"})
        Me.cmbEspecie.Location = New System.Drawing.Point(107, 120)
        Me.cmbEspecie.Name = "cmbEspecie"
        Me.cmbEspecie.Size = New System.Drawing.Size(128, 21)
        Me.cmbEspecie.TabIndex = 4
        '
        'cmbSexo
        '
        Me.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSexo.FormattingEnabled = True
        Me.cmbSexo.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.cmbSexo.Location = New System.Drawing.Point(107, 152)
        Me.cmbSexo.Name = "cmbSexo"
        Me.cmbSexo.Size = New System.Drawing.Size(128, 21)
        Me.cmbSexo.TabIndex = 5
        '
        'txtIDMascota
        '
        Me.txtIDMascota.Enabled = False
        Me.txtIDMascota.Location = New System.Drawing.Point(106, 58)
        Me.txtIDMascota.MaxLength = 9
        Me.txtIDMascota.Name = "txtIDMascota"
        Me.txtIDMascota.Size = New System.Drawing.Size(128, 20)
        Me.txtIDMascota.TabIndex = 2
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(106, 27)
        Me.txtNombre.MaxLength = 49
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(128, 20)
        Me.txtNombre.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 286)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Esterilizado el:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Color:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Sexo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Edad:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "IDMascota:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Especie:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdBuscarMascota)
        Me.GroupBox2.Controls.Add(Me.txtIDMascotaBuscar)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(335, 48)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Castracion"
        '
        'cmdBuscarMascota
        '
        Me.cmdBuscarMascota.Location = New System.Drawing.Point(240, 11)
        Me.cmdBuscarMascota.Name = "cmdBuscarMascota"
        Me.cmdBuscarMascota.Size = New System.Drawing.Size(75, 23)
        Me.cmdBuscarMascota.TabIndex = 1
        Me.cmdBuscarMascota.Text = "Buscar"
        Me.cmdBuscarMascota.UseVisualStyleBackColor = True
        '
        'txtIDMascotaBuscar
        '
        Me.txtIDMascotaBuscar.Location = New System.Drawing.Point(106, 13)
        Me.txtIDMascotaBuscar.Name = "txtIDMascotaBuscar"
        Me.txtIDMascotaBuscar.Size = New System.Drawing.Size(128, 20)
        Me.txtIDMascotaBuscar.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Mascota:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtComentariosAdopcion)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.cmdBuscar)
        Me.GroupBox3.Controls.Add(Me.txtApellido)
        Me.GroupBox3.Controls.Add(Me.txtDNI)
        Me.GroupBox3.Controls.Add(Me.txtNombreAdoptante)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.dtpAdoptado)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Location = New System.Drawing.Point(21, 476)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(335, 165)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos de Dueño"
        '
        'txtComentariosAdopcion
        '
        Me.txtComentariosAdopcion.Location = New System.Drawing.Point(106, 131)
        Me.txtComentariosAdopcion.Name = "txtComentariosAdopcion"
        Me.txtComentariosAdopcion.Size = New System.Drawing.Size(173, 20)
        Me.txtComentariosAdopcion.TabIndex = 25
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(11, 134)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 13)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "Comentarios:"
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Location = New System.Drawing.Point(222, 20)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(75, 23)
        Me.cmdBuscar.TabIndex = 1
        Me.cmdBuscar.Text = "Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(106, 71)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(100, 20)
        Me.txtApellido.TabIndex = 3
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(106, 22)
        Me.txtDNI.MaxLength = 9
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(100, 20)
        Me.txtDNI.TabIndex = 0
        '
        'txtNombreAdoptante
        '
        Me.txtNombreAdoptante.Location = New System.Drawing.Point(106, 46)
        Me.txtNombreAdoptante.Name = "txtNombreAdoptante"
        Me.txtNombreAdoptante.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreAdoptante.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(7, 103)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 13)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "Fecha Adopcion:"
        '
        'dtpAdoptado
        '
        Me.dtpAdoptado.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAdoptado.Location = New System.Drawing.Point(106, 97)
        Me.dtpAdoptado.Name = "dtpAdoptado"
        Me.dtpAdoptado.Size = New System.Drawing.Size(100, 20)
        Me.dtpAdoptado.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 74)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 13)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Apellido"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 49)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 13)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Nombre:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(29, 13)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "DNI:"
        '
        'AltaMascota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 679)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Controls.Add(Me.cmdLimpiar)
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "AltaMascota"
        Me.Text = "Gestionar Mascota"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents cmdLimpiar As System.Windows.Forms.Button
    Friend WithEvents cmdCerrar As System.Windows.Forms.Button
    Friend WithEvents cmdGrabar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbSexo As System.Windows.Forms.ComboBox
    Friend WithEvents txtIDMascota As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbTamaño As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbCaracteristicas As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpEsterilizado As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbColor As System.Windows.Forms.ComboBox
    Friend WithEvents txtEdad As System.Windows.Forms.TextBox
    Friend WithEvents cmbEspecie As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdBuscarMascota As System.Windows.Forms.Button
    Friend WithEvents txtIDMascotaBuscar As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreAdoptante As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dtpAdoptado As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents cmbDueño As System.Windows.Forms.ComboBox
    Friend WithEvents txtComentarios As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtComentariosAdopcion As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label

End Class
