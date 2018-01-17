Public Class FrmFiltroAsistencia
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub BTNVer_Click(sender As Object, e As EventArgs) Handles BTNVer.Click
        Dim fnsasistencia As New Funciones.FnsAsistencia
        DGVAsistencia.DataSource = fnsasistencia.listarasistenciaxfecha(DTPInicial.Value, DTPFinal.Value)
        DGVAsistencia.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DGVAsistencia.AutoResizeRows()
    End Sub

    Private Sub FrmFiltroAsistencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVAsistencia.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DGVAsistencia.AutoResizeRows()
    End Sub
End Class