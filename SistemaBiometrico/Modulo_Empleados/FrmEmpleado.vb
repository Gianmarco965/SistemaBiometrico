Public Class FrmEmpleado
    Private Sub FrmEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        leer("")


    End Sub

    Private Sub leer(dato As String)
        Try
            Dim fnsempleado As New Funciones.FnsEmpleado()

            'GCProductos.DataSource = fnsproducto.listar_productos()

            DGVEmpleado.DataSource = fnsempleado.listar_empleados()
            DGVEmpleado.DefaultCellStyle.WrapMode = DataGridViewTriState.True
            DGVEmpleado.AutoResizeRows()


        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text)

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim frmagregar As New FrmAgregarEmpleado
        AddHandler frmagregar.FormClosed, AddressOf FormCloseds
        frmagregar.ShowDialog()

    End Sub

    Private Sub FormCloseds(sender As Object, e As FormClosedEventArgs)

        leer("")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim codempleado As Integer = 0

        codempleado = DGVEmpleado.Rows(DGVEmpleado.CurrentRow.Index).Cells(0).Value.ToString()
        Modulo_Empleado.idempleado = codempleado

        Dim frmmempleado As New FrmModificarEmpleado()
        AddHandler frmmempleado.FormClosed, AddressOf FormCloseds
        frmmempleado.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim codempleado As Integer = 0

        codempleado = DGVEmpleado.Rows(DGVEmpleado.CurrentRow.Index).Cells(0).Value.ToString()
        Modulo_Empleado.idempleado = codempleado

        Dim frmmempleado As New FrmVerAsistencia()
        AddHandler frmmempleado.FormClosed, AddressOf FormCloseds
        frmmempleado.ShowDialog()

    End Sub
End Class