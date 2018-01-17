<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVerAsistencia
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
        Me.LCEstado = New System.Windows.Forms.Label()
        Me.PEHuella = New System.Windows.Forms.PictureBox()
        CType(Me.PEHuella, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LCEstado
        '
        Me.LCEstado.BackColor = System.Drawing.Color.Red
        Me.LCEstado.Location = New System.Drawing.Point(12, 238)
        Me.LCEstado.Name = "LCEstado"
        Me.LCEstado.Size = New System.Drawing.Size(47, 44)
        Me.LCEstado.TabIndex = 2
        '
        'PEHuella
        '
        Me.PEHuella.Image = Global.SistemaBiometrico.My.Resources.Resources.fingerprint
        Me.PEHuella.Location = New System.Drawing.Point(65, 12)
        Me.PEHuella.Name = "PEHuella"
        Me.PEHuella.Size = New System.Drawing.Size(222, 270)
        Me.PEHuella.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PEHuella.TabIndex = 0
        Me.PEHuella.TabStop = False
        '
        'FrmVerAsistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 296)
        Me.Controls.Add(Me.LCEstado)
        Me.Controls.Add(Me.PEHuella)
        Me.Name = "FrmVerAsistencia"
        Me.Text = "FrmVerAsistencia"
        CType(Me.PEHuella, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PEHuella As PictureBox
    Friend WithEvents LCEstado As Label
End Class
