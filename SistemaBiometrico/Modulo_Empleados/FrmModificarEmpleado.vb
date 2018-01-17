Imports Funciones

Imports DPFP.Capture
Imports DPFP.Verification
Imports DPFP.Gui.Enrollment
Imports System.Data.SqlClient
Imports DPFP
Imports System.Text
Imports System.Text.RegularExpressions

Public Class FrmModificarEmpleado
    Implements DPFP.Capture.EventHandler

    Private captura As DPFP.Capture.Capture
    Private enroller As DPFP.Processing.Enrollment
    Private Delegate Sub _delegadoMuestra(ByVal texto As String)
    Private template As DPFP.Template
    Private Delegate Sub _delegadoImagen(ByVal imagen As Bitmap)
    Private Delegate Sub _delegadoControles()

    Dim varcodempleado As String

    Dim bs As New BindingSource()

    Private Sub mostrarVeces(ByVal mensajetexto As String)
        If TxtPrompt.InvokeRequired Then
            Dim deleg As New _delegadoMuestra(AddressOf mostrarVeces)
            Me.Invoke(deleg, New Object() {mensajetexto})
        Else
            TxtPrompt.Text = (mensajetexto)
        End If

    End Sub
    Private Sub escribirConsola(ByVal mensajetexto As String)
        If TxtEstado.InvokeRequired Then
            Dim deleg As New _delegadoMuestra(AddressOf escribirConsola)
            Me.Invoke(deleg, New Object() {mensajetexto})
        Else
            TxtEstado.Text += (mensajetexto + vbCrLf)
        End If
    End Sub

    Private Sub modificarControles()
        If (BTNAceptar.InvokeRequired) Then
            Dim deleg As New _delegadoControles(AddressOf modificarControles)
            Me.Invoke(deleg, New Object() {})
        Else
            BTNAceptar.Enabled = True
        End If
    End Sub

    Private Sub colocarImagen(ByVal bmp As Bitmap)
        If (PEHuella.InvokeRequired) Then
            Dim deleg As New _delegadoImagen(AddressOf colocarImagen)
            Me.Invoke(deleg, New Object() {bmp})
        End If
        Dim Converter = New ImageConverter()
        Dim bytes As Byte() = Converter.ConvertTo(bmp, GetType(Byte()))
        Dim MS = New IO.MemoryStream(bytes)
        MS.Position = 0
        If (Not PEHuella.Image Is Nothing) Then PEHuella.Image.Dispose()
        PEHuella.Image = Image.FromStream(MS)
    End Sub

    Protected Overridable Sub Init()

        Try
            captura = New DPFP.Capture.Capture()
            If Not captura Is Nothing Then
                captura.EventHandler = Me
                enroller = New DPFP.Processing.Enrollment()
                Dim mensaje As New StringBuilder()
                mensaje.AppendFormat("Necesitas pasar el dedo {0} veces", enroller.FeaturesNeeded)
                TxtPrompt.Text = mensaje.ToString()
            Else
                MessageBox.Show("No se pudo iniciar la captura")
            End If
        Catch ex As Exception
            MessageBox.Show("No se pudo inicializar la captura")
        End Try

    End Sub

    Protected Sub iniciarCaptura()
        If Not captura Is Nothing Then
            Try
                captura.StartCapture()
            Catch ex As Exception
                MessageBox.Show("No se pudo iniciar la captura")
            End Try
        End If

    End Sub

    Protected Sub pararCaptura()
        If Not captura Is Nothing Then
            Try
                captura.StopCapture()

            Catch ex As Exception
                MessageBox.Show("No se pudo detener la captura")
            End Try

        End If

    End Sub





    Private Sub FrmModificarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        BTNAceptar.Enabled = False
        Init()
        cargar_combo(CMBArea, "idarea", "nomarea", "SP_LISTAR_AREA")
        cargar_combo(CMBEstado, "idestado", "nomestado", "SP_LISTAR_ESTADO")
        iniciarCaptura()
        Dim fnsempleado As New FnsEmpleado()

        varcodempleado = Modulo_Empleado.idempleado
        Dim lista As New List(Of Entidades.Empleado)
        Dim pentidad As New Entidades.Empleado()
        bs.DataSource = fnsempleado.listaempleadoxid(varcodempleado)

        LCCodigo.Text = varcodempleado
        TxtNombre.DataBindings.Add(New Binding("text", bs, "Nomepleado1"))
        TxtApePaterno.DataBindings.Add(New Binding("text", bs, "Apellidopaterno1"))
        TxtApeMaterno.DataBindings.Add(New Binding("text", bs, "Apellidomaterno1"))
        DTPFecha.DataBindings.Add(New Binding("Value", bs, "Fechanac1"))
        TxtCelular.DataBindings.Add(New Binding("text", bs, "Celular1"))
        TxtTelefono.DataBindings.Add(New Binding("text", bs, "Telefono1"))
        TxtDni.DataBindings.Add(New Binding("text", bs, "Dni1"))
        CMBArea.DataBindings.Add(New Binding("text", bs, "Idarea1"))
        CMBEstado.DataBindings.Add(New Binding("text", bs, "Idestado1"))



    End Sub

    Private Sub cargar_combo(cmb As ComboBox, codigo As String, mostrar As String, procedimiento As String)
        cmb.DataSource = llenar_combo(procedimiento, "")
        cmb.ValueMember = codigo
        cmb.DisplayMember = mostrar
    End Sub

    Public Sub OnComplete(Capture As Object, ReaderSerialNumber As String, Sample As Sample) Implements DPFP.Capture.EventHandler.OnComplete
        ponerImagen(convertirSampleMapaBits(Sample))
        Procesar(Sample)

    End Sub

    Public Sub OnFingerGone(Capture As Object, ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnFingerGone
        escribirConsola("El dedo dejo de tocar el lector")
    End Sub

    Public Sub OnFingerTouch(Capture As Object, ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnFingerTouch
        escribirConsola("Se ha tocado el lector")
    End Sub

    Public Sub OnReaderConnect(Capture As Object, ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnReaderConnect
        escribirConsola("El lector esta Listo")
    End Sub

    Public Sub OnReaderDisconnect(Capture As Object, ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnReaderDisconnect
        escribirConsola("El lector esta desconectado")
    End Sub

    Public Sub OnSampleQuality(Capture As Object, ReaderSerialNumber As String, CaptureFeedback As CaptureFeedback) Implements DPFP.Capture.EventHandler.OnSampleQuality
        If (CaptureFeedback.LowContrast) Then
            escribirConsola("La captura es de baja calidad")
        ElseIf (CaptureFeedback.Good) Then
            escribirConsola("La captura es de buena calidad")
        End If


    End Sub

    Private Sub FrmModificarEmpleado_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        pararCaptura()
    End Sub

    Protected Function convertirSampleMapaBits(ByVal sample As DPFP.Sample) As Bitmap
        Dim convertidor As New DPFP.Capture.SampleConversion()
        Dim mapaBits As Bitmap = Nothing
        convertidor.ConvertToPicture(sample, mapaBits)
        Return mapaBits
    End Function

    Private Sub ponerImagen(ByVal bmp)

        colocarImagen(bmp)

    End Sub
    Protected Function extraerCaracteristicas(ByVal sample As DPFP.Sample, ByVal purpose As DPFP.Processing.DataPurpose) As DPFP.FeatureSet
        Dim extractor As New DPFP.Processing.FeatureExtraction()
        Dim alimentacion As DPFP.Capture.CaptureFeedback = DPFP.Capture.CaptureFeedback.None
        Dim caracteristicas As New DPFP.FeatureSet()
        extractor.CreateFeatureSet(sample, purpose, alimentacion, caracteristicas)
        If (alimentacion = DPFP.Capture.CaptureFeedback.Good) Then
            Return caracteristicas
        Else
            Return Nothing
        End If

    End Function

    Protected Sub procesar(ByVal sample As DPFP.Sample)

        Dim caracteristicas As DPFP.FeatureSet = extraerCaracteristicas(sample, DPFP.Processing.DataPurpose.Enrollment)
        If (Not caracteristicas Is Nothing) Then
            Try
                enroller.AddFeatures(caracteristicas)
            Catch ex As Exception
                MessageBox.Show("Error en añadir caracteristicas")
            Finally
                Dim mensaje As New StringBuilder()
                mensaje.AppendFormat("Necesitas pasar el dedo {0} veces", enroller.FeaturesNeeded)
                mostrarVeces(mensaje.ToString())
                Select Case enroller.TemplateStatus
                    Case DPFP.Processing.Enrollment.Status.Ready
                        mostrarVeces("La Muestra esta Lista")
                        escribirConsola("Muestra de Huella Lista." + vbCrLf + "Proceda con la inserción de datos")
                        template = enroller.Template
                        pararCaptura()
                        modificarControles()

                    Case DPFP.Processing.Enrollment.Status.Failed
                        enroller.Clear()
                        pararCaptura()
                        iniciarCaptura()
                End Select
            End Try
        End If

    End Sub

    Sub New()
        InitializeComponent()
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub BTNAceptar_Click(sender As Object, e As EventArgs) Handles BTNAceptar.Click
        Dim oentidad As New Entidades.Empleado
        oentidad.Idempleado1 = LCCodigo.Text
        oentidad.Nomepleado1 = TxtNombre.Text
        oentidad.Apellidopaterno1 = TxtApePaterno.Text
        oentidad.Apellidomaterno1 = TxtApeMaterno.Text
        oentidad.Fechanac1 = DTPFecha.Value
        oentidad.Celular1 = TxtCelular.Text
        oentidad.Telefono1 = TxtTelefono.Text
        oentidad.Dni1 = TxtDni.Text

        oentidad.Idarea1 = CMBArea.SelectedValue
        oentidad.Idestado1 = CMBEstado.SelectedValue

        Using fm As New IO.MemoryStream(template.Bytes)
            oentidad.Huella1 = fm.ToArray

        End Using

        Dim FnsEmpleado As New FnsEmpleado()
        FnsEmpleado.actualizar_empleado(oentidad)

        MessageBox.Show("Se agrego con exito el nuevo empleado", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)


        Me.Close()

    End Sub
End Class