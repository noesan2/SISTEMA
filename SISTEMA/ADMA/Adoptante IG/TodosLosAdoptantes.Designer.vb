﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TodosLosAdoptantes
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
        Me.dgvAdoptantes = New System.Windows.Forms.DataGridView()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        CType(Me.dgvAdoptantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAdoptantes
        '
        Me.dgvAdoptantes.AllowUserToAddRows = False
        Me.dgvAdoptantes.AllowUserToDeleteRows = False
        Me.dgvAdoptantes.AllowUserToResizeRows = False
        Me.dgvAdoptantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAdoptantes.Location = New System.Drawing.Point(12, 12)
        Me.dgvAdoptantes.Name = "dgvAdoptantes"
        Me.dgvAdoptantes.ReadOnly = True
        Me.dgvAdoptantes.RowHeadersVisible = False
        Me.dgvAdoptantes.Size = New System.Drawing.Size(996, 446)
        Me.dgvAdoptantes.TabIndex = 0
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(12, 464)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancelar.TabIndex = 1
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(770, 469)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Total de Adoptantes:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(882, 464)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 20)
        Me.lblTotal.TabIndex = 3
        '
        'TodosLosAdoptantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 498)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.dgvAdoptantes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "TodosLosAdoptantes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Adoptantes"
        CType(Me.dgvAdoptantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvAdoptantes As System.Windows.Forms.DataGridView
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
End Class
