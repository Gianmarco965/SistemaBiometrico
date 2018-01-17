Imports System.Data.SqlClient

Public Class FnsAsistencia

    Public Sub agregar_asistencia(ByRef pEntidad As Entidades.Asistencia)
        Using cnn = New SqlConnection(conex.Lecc1)
            cnn.Open()
            Dim cmd As New SqlCommand()


            cmd.CommandText = "SP_AGREGAR_ASISTENCIA"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idempleado", pEntidad.Idempleado1)
            cmd.ExecuteNonQuery()

            cmd.Dispose()
            cnn.Close()
            cnn.Dispose()


        End Using

    End Sub

    Public Function listarasistenciaxfecha(fechaini As String, fechafinal As String) As DataTable

        Using cnn = New SqlConnection(conex.Lecc1)

            Dim cmd As New SqlCommand()
            Dim dr As SqlDataReader

            cmd.CommandText = "SP_VER_ASISTENCIA"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@fechaini", fechaini)

            cmd.Parameters.AddWithValue("@fechafin", fechafinal)
            cnn.Open()
            dr = cmd.ExecuteReader()
            Dim ds As New DataSet
            Dim dt As New DataTable("Tabla1")

            ds.Tables.Add(dt)

            ds.Load(dr, LoadOption.PreserveChanges, ds.Tables(0))


            Return ds.Tables(0)
        End Using

    End Function


End Class
