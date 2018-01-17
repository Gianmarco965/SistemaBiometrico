Imports DPFP
Imports DPFP.Capture
Imports Entidades
Imports Funciones

Public Class FrmVerAsistencia
    Implements DPFP.Capture.EventHandler

    Private captura As DPFP.Capture.Capture
    Private template As DPFP.Template
    Private Delegate Sub _delegadoControles()
    Private Delegate Sub _delegadoImagen(ByVal imagen As Bitmap)
    Private Delegate Sub _delegadoColor()
    Private verificador As DPFP.Verification.Verification



    Private Sub cambiarColor()
        If (LCEstado.InvokeRequired) Then
            Dim deleg As New _delegadoColor(AddressOf cambiarColor)
            Me.Invoke(deleg, New Object() {})
        Else
            LCEstado.BackColor = Color.ForestGreen
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
            captura = New Capture()
            If Not captura Is Nothing Then
                captura.EventHandler = Me
                verificador = New Verification.Verification()
                template = New Template()

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



    Public Sub OnComplete(Capture As Object, ReaderSerialNumber As String, Sample As Sample) Implements EventHandler.OnComplete
        ponerImagen(convertirSampleMapaBits(Sample))
        Dim caracteristicas As DPFP.FeatureSet = extraerCaracteristicas(Sample, DPFP.Processing.DataPurpose.Verification)
        If Not caracteristicas Is Nothing Then

            Dim result As New DPFP.Verification.Verification.Result()
            Dim lista_huella As List(Of Byte())
            Dim fnsEmpleado As New FnsEmpleado()
            Dim verificado As Boolean = False
            lista_huella = fnsEmpleado.lista_huellas()

            For i = 0 To lista_huella.Count - 1
                Dim memoria As New IO.MemoryStream(CType(lista_huella(i), Byte()))

                template.DeSerialize(memoria.ToArray())

                verificador.Verify(caracteristicas, template, result)
                If (result.Verified) Then
                    verificado = True

                    Exit For
                End If
            Next
            If (verificado) Then

                pararCaptura()
                cambiarColor()
                MessageBox.Show("Huella Verificada")

                Dim objasistencia As New Asistencia
                objasistencia.Idempleado1 = Modulo_Empleado.idempleado
                Dim fnsasistencia As New FnsAsistencia

                fnsasistencia.agregar_asistencia(objasistencia)
                lista_huella.Clear()
                Me.Close()


            Else
                MessageBox.Show("No se encontro ningun registro")
                verificado = False
                lista_huella.Clear()

            End If

        End If

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

    Sub New()
        InitializeComponent()
        Control.CheckForIllegalCrossThreadCalls = False

    End Sub

    Public Sub OnFingerGone(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerGone

    End Sub

    Public Sub OnFingerTouch(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerTouch
        MessageBox.Show("Ha tocado el lector")
    End Sub

    Public Sub OnReaderConnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderConnect
        MessageBox.Show("El Lector esta Listo")
    End Sub

    Public Sub OnReaderDisconnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderDisconnect
        MessageBox.Show("Lector Desconectado")
    End Sub

    Public Sub OnSampleQuality(Capture As Object, ReaderSerialNumber As String, CaptureFeedback As CaptureFeedback) Implements EventHandler.OnSampleQuality

    End Sub

    Private Sub FrmVerAsistencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Init()
        StartPosition = FormStartPosition.CenterScreen
        MaximizeBox = False

        iniciarCaptura()
        LCEstado.BackColor = Color.Red
    End Sub

    Private Sub FrmVerAsistencia_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        pararCaptura()

    End Sub

    Private Sub FrmVerAsistencia_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        pararCaptura()
        Modulo_Empleado.idempleado = 0
    End Sub
End Class