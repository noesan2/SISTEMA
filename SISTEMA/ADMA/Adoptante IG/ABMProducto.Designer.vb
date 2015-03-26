<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMProducto
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Productos = New System.Windows.Forms.GroupBox()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.lstProductos = New System.Windows.Forms.ListBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.ckbActivo = New System.Windows.Forms.CheckBox()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.Productos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Productos
        '
        Me.Productos.Controls.Add(Me.lstProductos)
        Me.Productos.Controls.Add(Me.txtFiltro)
        Me.Productos.Dock = System.Windows.Forms.DockStyle.Left
        Me.Productos.Location = New System.Drawing.Point(0, 0)
        Me.Productos.Name = "Productos"
        Me.Productos.Size = New System.Drawing.Size(200, 340)
        Me.Productos.TabIndex = 0
        Me.Productos.TabStop = False
        Me.Productos.Text = "GroupBox1"
        '
        'txtFiltro
        '
        Me.txtFiltro.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtFiltro.Location = New System.Drawing.Point(3, 16)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(194, 20)
        Me.txtFiltro.TabIndex = 0
        '
        'lstProductos
        '
        Me.lstProductos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lstProductos.FormattingEnabled = True
        Me.lstProductos.Location = New System.Drawing.Point(3, 47)
        Me.lstProductos.Name = "lstProductos"
        Me.lstProductos.Size = New System.Drawing.Size(194, 290)
        Me.lstProductos.TabIndex = 1
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(206, 147)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(151, 20)
        Me.txtNombre.TabIndex = 1
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(206, 173)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(151, 57)
        Me.txtDescripcion.TabIndex = 2
        '
        'ckbActivo
        '
        Me.ckbActivo.AutoSize = True
        Me.ckbActivo.Location = New System.Drawing.Point(206, 254)
        Me.ckbActivo.Name = "ckbActivo"
        Me.ckbActivo.Size = New System.Drawing.Size(56, 17)
        Me.ckbActivo.TabIndex = 3
        Me.ckbActivo.Text = "Activo"
        Me.ckbActivo.UseVisualStyleBackColor = True
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(283, 305)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(75, 23)
        Me.cmdGuardar.TabIndex = 4
        Me.cmdGuardar.Text = "Guardar"
        Me.cmdGuardar.UseVisualStyleBackColor = True
        '
        'ABMProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 340)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.ckbActivo)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Productos)
        Me.Name = "ABMProducto"
        Me.Text = "Abm Productos"
        Me.Productos.ResumeLayout(False)
        Me.Productos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Productos As System.Windows.Forms.GroupBox
    Friend WithEvents lstProductos As System.Windows.Forms.ListBox
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents ckbActivo As System.Windows.Forms.CheckBox
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
End Class
