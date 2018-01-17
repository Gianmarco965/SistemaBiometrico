Public Class FrmAsistencia
    Private Sub BTNEmpleados_Click(sender As Object, e As EventArgs) Handles BTNEmpleados.Click

        FrmEmpleado.ShowDialog()

    End Sub

    Private Sub BTNAsistencia_Click(sender As Object, e As EventArgs)

        FrmVerAsistencia.ShowDialog()

    End Sub

    Private Sub FrmAsistencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToScreen()

    End Sub

    Private Sub BTNAsistencia_Click_1(sender As Object, e As EventArgs) Handles BTNAsistencia.Click
        FrmFiltroAsistencia.ShowDialog()

    End Sub
End Class