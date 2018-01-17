<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificarEmpleado
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtEstado = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtPrompt = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BTNCancelar = New System.Windows.Forms.Button()
        Me.BTNAceptar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CMBEstado = New System.Windows.Forms.ComboBox()
        Me.CMBArea = New System.Windows.Forms.ComboBox()
        Me.TxtDni = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.TxtCelular = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DTPFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtApeMaterno = New System.Windows.Forms.TextBox()
        Me.TxtApePaterno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.PEHuella = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LCCodigo = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PEHuella, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxtEstado)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.TxtPrompt)
        Me.GroupBox3.Controls.Add(Me.PEHuella)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(460, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(307, 427)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "HUELLA"
        '
        'TxtEstado
        '
        Me.TxtEstado.Location = New System.Drawing.Point(35, 332)
        Me.TxtEstado.Multiline = True
        Me.TxtEstado.Name = "TxtEstado"
        Me.TxtEstado.Size = New System.Drawing.Size(241, 72)
        Me.TxtEstado.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(32, 315)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "ESTADO"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(29, 272)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "PROMPT"
        '
        'TxtPrompt
        '
        Me.TxtPrompt.Location = New System.Drawing.Point(32, 288)
        Me.TxtPrompt.Name = "TxtPrompt"
        Me.TxtPrompt.Size = New System.Drawing.Size(244, 20)
        Me.TxtPrompt.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BTNCancelar)
        Me.GroupBox2.Controls.Add(Me.BTNAceptar)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(11, 320)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(442, 119)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CONTROLES"
        '
        'BTNCancelar
        '
        Me.BTNCancelar.Location = New System.Drawing.Point(232, 48)
        Me.BTNCancelar.Name = "BTNCancelar"
        Me.BTNCancelar.Size = New System.Drawing.Size(179, 35)
        Me.BTNCancelar.TabIndex = 1
        Me.BTNCancelar.Text = "CANCELAR"
        Me.BTNCancelar.UseVisualStyleBackColor = True
        '
        'BTNAceptar
        '
        Me.BTNAceptar.Location = New System.Drawing.Point(34, 35)
        Me.BTNAceptar.Name = "BTNAceptar"
        Me.BTNAceptar.Size = New System.Drawing.Size(158, 61)
        Me.BTNAceptar.TabIndex = 0
        Me.BTNAceptar.Text = "ACEPTAR"
        Me.BTNAceptar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LCCodigo)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.CMBEstado)
        Me.GroupBox1.Controls.Add(Me.CMBArea)
        Me.GroupBox1.Controls.Add(Me.TxtDni)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtTelefono)
        Me.GroupBox1.Controls.Add(Me.TxtCelular)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.DTPFecha)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtApeMaterno)
        Me.GroupBox1.Controls.Add(Me.TxtApePaterno)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtNombre)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(442, 301)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS DEL EMPLEADO"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(100, 266)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "ESTADO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(117, 238)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "AREA"
        '
        'CMBEstado
        '
        Me.CMBEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBEstado.FormattingEnabled = True
        Me.CMBEstado.Location = New System.Drawing.Point(169, 263)
        Me.CMBEstado.Name = "CMBEstado"
        Me.CMBEstado.Size = New System.Drawing.Size(158, 21)
        Me.CMBEstado.TabIndex = 15
        '
        'CMBArea
        '
        Me.CMBArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBArea.FormattingEnabled = True
        Me.CMBArea.Location = New System.Drawing.Point(169, 235)
        Me.CMBArea.Name = "CMBArea"
        Me.CMBArea.Size = New System.Drawing.Size(158, 21)
        Me.CMBArea.TabIndex = 14
        '
        'TxtDni
        '
        Me.TxtDni.Location = New System.Drawing.Point(169, 208)
        Me.TxtDni.Name = "TxtDni"
        Me.TxtDni.Size = New System.Drawing.Size(100, 20)
        Me.TxtDni.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(128, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "DNI"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(85, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "TELEFONO"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(169, 181)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(100, 20)
        Me.TxtTelefono.TabIndex = 10
        '
        'TxtCelular
        '
        Me.TxtCelular.Location = New System.Drawing.Point(169, 154)
        Me.TxtCelular.Name = "TxtCelular"
        Me.TxtCelular.Size = New System.Drawing.Size(100, 20)
        Me.TxtCelular.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(94, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "CELULAR"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "FECHA DE NACIMIENTO"
        '
        'DTPFecha
        '
        Me.DTPFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFecha.Location = New System.Drawing.Point(169, 127)
        Me.DTPFecha.Name = "DTPFecha"
        Me.DTPFecha.Size = New System.Drawing.Size(100, 20)
        Me.DTPFecha.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "APELLIDO MATERNO"
        '
        'TxtApeMaterno
        '
        Me.TxtApeMaterno.Location = New System.Drawing.Point(169, 100)
        Me.TxtApeMaterno.Name = "TxtApeMaterno"
        Me.TxtApeMaterno.Size = New System.Drawing.Size(100, 20)
        Me.TxtApeMaterno.TabIndex = 4
        '
        'TxtApePaterno
        '
        Me.TxtApePaterno.Location = New System.Drawing.Point(169, 74)
        Me.TxtApePaterno.Name = "TxtApePaterno"
        Me.TxtApePaterno.Size = New System.Drawing.Size(158, 20)
        Me.TxtApePaterno.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "APELLIDO PATERNO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(89, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NOMBRES"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(169, 48)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(242, 20)
        Me.TxtNombre.TabIndex = 0
        '
        'PEHuella
        '
        Me.PEHuella.Image = Global.SistemaBiometrico.My.Resources.Resources.fingerprint
        Me.PEHuella.Location = New System.Drawing.Point(32, 20)
        Me.PEHuella.Name = "PEHuella"
        Me.PEHuella.Size = New System.Drawing.Size(244, 245)
        Me.PEHuella.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PEHuella.TabIndex = 0
        Me.PEHuella.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(102, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 13)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "CODIGO"
        '
        'LCCodigo
        '
        Me.LCCodigo.AutoSize = True
        Me.LCCodigo.Location = New System.Drawing.Point(169, 24)
        Me.LCCodigo.Name = "LCCodigo"
        Me.LCCodigo.Size = New System.Drawing.Size(14, 13)
        Me.LCCodigo.TabIndex = 19
        Me.LCCodigo.Text = "0"
        '
        'FrmModificarEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 450)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmModificarEmpleado"
        Me.Text = "MODIFICAR EMPLEADO"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PEHuella, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtEstado As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtPrompt As TextBox
    Friend WithEvents PEHuella As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BTNCancelar As Button
    Friend WithEvents BTNAceptar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CMBEstado As ComboBox
    Friend WithEvents CMBArea As ComboBox
    Friend WithEvents TxtDni As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents TxtCelular As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DTPFecha As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtApeMaterno As TextBox
    Friend WithEvents TxtApePaterno As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents LCCodigo As Label
End Class
