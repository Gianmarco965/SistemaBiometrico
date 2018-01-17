<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAsistencia
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BTNEmpleados = New System.Windows.Forms.Button()
        Me.BTNAsistencia = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BTNEmpleados
        '
        Me.BTNEmpleados.BackColor = System.Drawing.Color.DarkOrange
        Me.BTNEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNEmpleados.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BTNEmpleados.Location = New System.Drawing.Point(13, 13)
        Me.BTNEmpleados.Name = "BTNEmpleados"
        Me.BTNEmpleados.Size = New System.Drawing.Size(161, 147)
        Me.BTNEmpleados.TabIndex = 0
        Me.BTNEmpleados.Text = "EMPLEADOS"
        Me.BTNEmpleados.UseVisualStyleBackColor = False
        '
        'BTNAsistencia
        '
        Me.BTNAsistencia.Location = New System.Drawing.Point(181, 13)
        Me.BTNAsistencia.Name = "BTNAsistencia"
        Me.BTNAsistencia.Size = New System.Drawing.Size(163, 147)
        Me.BTNAsistencia.TabIndex = 1
        Me.BTNAsistencia.Text = "VER ASISTENCIAS"
        Me.BTNAsistencia.UseVisualStyleBackColor = True
        '
        'FrmAsistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 176)
        Me.Controls.Add(Me.BTNAsistencia)
        Me.Controls.Add(Me.BTNEmpleados)
        Me.MaximizeBox = False
        Me.Name = "FrmAsistencia"
        Me.Text = "SISTEMA ASISTENCIA"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTNEmpleados As Button
    Friend WithEvents BTNAsistencia As Button
End Class
