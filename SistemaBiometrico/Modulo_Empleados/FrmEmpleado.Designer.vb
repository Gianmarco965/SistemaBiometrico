<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmpleado
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
        Me.DGVEmpleado = New System.Windows.Forms.DataGridView()
        Me.CONTROLES = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DGVEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CONTROLES.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVEmpleado
        '
        Me.DGVEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVEmpleado.Location = New System.Drawing.Point(12, 12)
        Me.DGVEmpleado.Name = "DGVEmpleado"
        Me.DGVEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVEmpleado.Size = New System.Drawing.Size(803, 250)
        Me.DGVEmpleado.TabIndex = 0
        '
        'CONTROLES
        '
        Me.CONTROLES.Controls.Add(Me.Button3)
        Me.CONTROLES.Controls.Add(Me.Button2)
        Me.CONTROLES.Controls.Add(Me.Button1)
        Me.CONTROLES.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CONTROLES.Location = New System.Drawing.Point(13, 269)
        Me.CONTROLES.Name = "CONTROLES"
        Me.CONTROLES.Size = New System.Drawing.Size(802, 108)
        Me.CONTROLES.TabIndex = 1
        Me.CONTROLES.TabStop = False
        Me.CONTROLES.Text = "CONTROLES"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(511, 31)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(191, 52)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "MARCAR ASISTENCIA"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(317, 31)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(187, 52)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "MODIFICAR EMPLEADO"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(130, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(180, 52)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "AGREGAR EMPLEADO"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 389)
        Me.Controls.Add(Me.CONTROLES)
        Me.Controls.Add(Me.DGVEmpleado)
        Me.MaximizeBox = False
        Me.Name = "FrmEmpleado"
        Me.Text = "EMPLEADOS"
        CType(Me.DGVEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CONTROLES.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVEmpleado As DataGridView
    Friend WithEvents CONTROLES As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
