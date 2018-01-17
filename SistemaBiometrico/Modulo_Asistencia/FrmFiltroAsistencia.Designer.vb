<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFiltroAsistencia
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
        Me.DGVAsistencia = New System.Windows.Forms.DataGridView()
        Me.DTPInicial = New System.Windows.Forms.DateTimePicker()
        Me.DTPFinal = New System.Windows.Forms.DateTimePicker()
        Me.BTNVer = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DGVAsistencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVAsistencia
        '
        Me.DGVAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVAsistencia.Location = New System.Drawing.Point(1, 126)
        Me.DGVAsistencia.Name = "DGVAsistencia"
        Me.DGVAsistencia.Size = New System.Drawing.Size(670, 257)
        Me.DGVAsistencia.TabIndex = 0
        '
        'DTPInicial
        '
        Me.DTPInicial.Location = New System.Drawing.Point(77, 27)
        Me.DTPInicial.Name = "DTPInicial"
        Me.DTPInicial.Size = New System.Drawing.Size(200, 20)
        Me.DTPInicial.TabIndex = 1
        '
        'DTPFinal
        '
        Me.DTPFinal.Location = New System.Drawing.Point(410, 27)
        Me.DTPFinal.Name = "DTPFinal"
        Me.DTPFinal.Size = New System.Drawing.Size(200, 20)
        Me.DTPFinal.TabIndex = 2
        '
        'BTNVer
        '
        Me.BTNVer.Location = New System.Drawing.Point(262, 68)
        Me.BTNVer.Name = "BTNVer"
        Me.BTNVer.Size = New System.Drawing.Size(150, 32)
        Me.BTNVer.TabIndex = 3
        Me.BTNVer.Text = "VER"
        Me.BTNVer.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "DESDE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(332, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "HASTA"
        '
        'FrmFiltroAsistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 382)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTNVer)
        Me.Controls.Add(Me.DTPFinal)
        Me.Controls.Add(Me.DTPInicial)
        Me.Controls.Add(Me.DGVAsistencia)
        Me.MaximizeBox = False
        Me.Name = "FrmFiltroAsistencia"
        Me.Text = "ASISTENCIAS"
        CType(Me.DGVAsistencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVAsistencia As DataGridView
    Friend WithEvents DTPInicial As DateTimePicker
    Friend WithEvents DTPFinal As DateTimePicker
    Friend WithEvents BTNVer As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
