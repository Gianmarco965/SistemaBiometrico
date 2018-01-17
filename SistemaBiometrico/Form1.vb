Public Class Form1
    Private Sub BTNCancelar_Click(sender As Object, e As EventArgs) Handles BTNCancelar.Click
        End

    End Sub

    Private Sub BTNAceptar_Click(sender As Object, e As EventArgs) Handles BTNAceptar.Click


        Try

            Dim oentidad As New Entidades.Usuario()
            oentidad.Usu1 = TxtUsuario.Text
            oentidad.Pass1 = TxtContra.Text

            Dim fnsusuario As New Funciones.FnsUsuario()


            If (fnsusuario.Validar(oentidad)) = True Then
                MessageBox.Show("Bienvenido al Sistema ", "Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Dim bs As New BindingSource()
                Me.Hide()

                Dim frmprincipal As New FrmAsistencia()
                frmprincipal.ShowDialog()
                frmprincipal.Activate()



            Else
                MessageBox.Show("Usuario y Contraseña Incorrectos", "Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text)
        End Try






    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

    End Sub
End Class
