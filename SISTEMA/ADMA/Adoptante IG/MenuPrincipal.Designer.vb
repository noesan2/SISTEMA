<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdoptantesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearAdoptanteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerTodosLosAdoptantesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MascotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarMascotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerTodasLasMascotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdopcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearNuevaAdopcionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerTodasLasAdopcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BusquedaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MascotaPerdidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadisticasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarEstadisticasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.BusquedaToolStripMenuItem, Me.EstadisticasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(492, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdoptantesToolStripMenuItem, Me.MascotasToolStripMenuItem, Me.AdopcionesToolStripMenuItem})
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'AdoptantesToolStripMenuItem
        '
        Me.AdoptantesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearAdoptanteToolStripMenuItem, Me.VerTodosLosAdoptantesToolStripMenuItem})
        Me.AdoptantesToolStripMenuItem.Name = "AdoptantesToolStripMenuItem"
        Me.AdoptantesToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.AdoptantesToolStripMenuItem.Text = "Adoptantes"
        '
        'CrearAdoptanteToolStripMenuItem
        '
        Me.CrearAdoptanteToolStripMenuItem.Name = "CrearAdoptanteToolStripMenuItem"
        Me.CrearAdoptanteToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.CrearAdoptanteToolStripMenuItem.Text = "Gestionar Adoptante"
        '
        'VerTodosLosAdoptantesToolStripMenuItem
        '
        Me.VerTodosLosAdoptantesToolStripMenuItem.Name = "VerTodosLosAdoptantesToolStripMenuItem"
        Me.VerTodosLosAdoptantesToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.VerTodosLosAdoptantesToolStripMenuItem.Text = "Ver Todos los Adoptantes"
        '
        'MascotasToolStripMenuItem
        '
        Me.MascotasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionarMascotaToolStripMenuItem, Me.VerTodasLasMascotasToolStripMenuItem})
        Me.MascotasToolStripMenuItem.Name = "MascotasToolStripMenuItem"
        Me.MascotasToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.MascotasToolStripMenuItem.Text = "Mascotas"
        '
        'GestionarMascotaToolStripMenuItem
        '
        Me.GestionarMascotaToolStripMenuItem.Name = "GestionarMascotaToolStripMenuItem"
        Me.GestionarMascotaToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.GestionarMascotaToolStripMenuItem.Text = "Gestionar Mascota"
        '
        'VerTodasLasMascotasToolStripMenuItem
        '
        Me.VerTodasLasMascotasToolStripMenuItem.Name = "VerTodasLasMascotasToolStripMenuItem"
        Me.VerTodasLasMascotasToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.VerTodasLasMascotasToolStripMenuItem.Text = "Ver Todas las Mascotas"
        '
        'AdopcionesToolStripMenuItem
        '
        Me.AdopcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearNuevaAdopcionToolStripMenuItem, Me.VerTodasLasAdopcionesToolStripMenuItem})
        Me.AdopcionesToolStripMenuItem.Name = "AdopcionesToolStripMenuItem"
        Me.AdopcionesToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.AdopcionesToolStripMenuItem.Text = "Adopciones"
        '
        'CrearNuevaAdopcionToolStripMenuItem
        '
        Me.CrearNuevaAdopcionToolStripMenuItem.Name = "CrearNuevaAdopcionToolStripMenuItem"
        Me.CrearNuevaAdopcionToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.CrearNuevaAdopcionToolStripMenuItem.Text = "Crear Nueva Adopcion"
        '
        'VerTodasLasAdopcionesToolStripMenuItem
        '
        Me.VerTodasLasAdopcionesToolStripMenuItem.Name = "VerTodasLasAdopcionesToolStripMenuItem"
        Me.VerTodasLasAdopcionesToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.VerTodasLasAdopcionesToolStripMenuItem.Text = "Ver Todas las Adopciones"
        '
        'BusquedaToolStripMenuItem
        '
        Me.BusquedaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MascotaPerdidaToolStripMenuItem})
        Me.BusquedaToolStripMenuItem.Name = "BusquedaToolStripMenuItem"
        Me.BusquedaToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.BusquedaToolStripMenuItem.Text = "Busqueda"
        '
        'MascotaPerdidaToolStripMenuItem
        '
        Me.MascotaPerdidaToolStripMenuItem.Name = "MascotaPerdidaToolStripMenuItem"
        Me.MascotaPerdidaToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.MascotaPerdidaToolStripMenuItem.Text = "Mascota Perdida"
        '
        'EstadisticasToolStripMenuItem
        '
        Me.EstadisticasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarEstadisticasToolStripMenuItem})
        Me.EstadisticasToolStripMenuItem.Name = "EstadisticasToolStripMenuItem"
        Me.EstadisticasToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.EstadisticasToolStripMenuItem.Text = "Estadisticas"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ConsultarEstadisticasToolStripMenuItem
        '
        Me.ConsultarEstadisticasToolStripMenuItem.Name = "ConsultarEstadisticasToolStripMenuItem"
        Me.ConsultarEstadisticasToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.ConsultarEstadisticasToolStripMenuItem.Text = "Consultar Estadisticas"
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 347)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuPrincipal"
        Me.Text = "MenuPrincipal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents InicioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdoptantesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CrearAdoptanteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MascotasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionarMascotaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdopcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CrearNuevaAdopcionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BusquedaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MascotaPerdidaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerTodosLosAdoptantesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerTodasLasMascotasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerTodasLasAdopcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstadisticasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarEstadisticasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
