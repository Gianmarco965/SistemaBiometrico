Imports System.Data.SqlClient
Imports Entidades
Imports Funciones

Public Class FnsEmpleado
    Public cnn As New SqlConnection

    Public Function listar_empleados() As DataTable
        Using cnn = New SqlConnection(conex.Lecc1)
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter("SP_LISTA_EMPLEADO", cnn)
            da.Fill(ds, "Empleado")
            Return ds.Tables("Empleado")

        End Using

    End Function


    Public Sub agregar_empleado(ByRef pEntidad As Entidades.Empleado)
        Using cnn = New SqlConnection(conex.Lecc1)
            cnn.Open()
            Dim cmd As New SqlCommand()


            cmd.CommandText = "SP_AGREGAR_EMPLEADO"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@nombre", pEntidad.Nomepleado1)
            cmd.Parameters.AddWithValue("@paterno", pEntidad.Apellidopaterno1)

            cmd.Parameters.AddWithValue("@materno", pEntidad.Apellidomaterno1)
            cmd.Parameters.AddWithValue("@fechanac", pEntidad.Fechanac1)
            cmd.Parameters.AddWithValue("@celular", pEntidad.Celular1)
            cmd.Parameters.AddWithValue("@telefono", pEntidad.Telefono1)
            cmd.Parameters.AddWithValue("@dni", pEntidad.Dni1)
            cmd.Parameters.AddWithValue("@huella", pEntidad.Huella1)
            cmd.Parameters.AddWithValue("@idarea", pEntidad.Idarea1)
            cmd.Parameters.AddWithValue("@idestado", pEntidad.Idestado1)
            cmd.ExecuteNonQuery()

            cmd.Dispose()
            cnn.Close()
            cnn.Dispose()


        End Using

    End Sub


    Public Function listaempleadoxid(pid As String) As List(Of Empleado)
        Dim lista As New List(Of Empleado)
        Using cnn = New SqlConnection(conex.Lecc1)

            Dim cmd As New SqlCommand()
            Dim dr As SqlDataReader

            cmd.CommandText = "SP_LISTAR_EMPLEADOXID"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idempleado", pid)
            cnn.Open()
            dr = cmd.ExecuteReader()
            While (dr.Read)
                Dim oEntidad = New Empleado()
                oEntidad.Idempleado1 = dr("idempleado")
                oEntidad.Nomepleado1 = dr("nomempleado").ToString()
                oEntidad.Apellidopaterno1 = dr("apellidopaterno").ToString()
                oEntidad.Apellidomaterno1 = dr("apellidomaterno").ToString()
                oEntidad.Fechanac1 = dr("fechanac").ToString()
                oEntidad.Celular1 = dr("celular").ToString()
                oEntidad.Telefono1 = dr("telefono").ToString()
                oEntidad.Dni1 = dr("dni").ToString()
                oEntidad.Idarea1 = dr("idarea").ToString()
                oEntidad.Idestado1 = dr("idestado").ToString()

                lista.Add(oEntidad)

            End While
            Return lista

        End Using

    End Function

    Public Sub actualizar_empleado(ByRef pEntidad As Entidades.Empleado)
        Using cnn = New SqlConnection(conex.Lecc1)
            cnn.Open()
            Dim cmd As New SqlCommand()


            cmd.CommandText = "SP_ACTUALIZAR_EMPLEADO"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idempleado", pEntidad.Idempleado1)
            cmd.Parameters.AddWithValue("@nomempleado", pEntidad.Nomepleado1)
            cmd.Parameters.AddWithValue("@paterno", pEntidad.Apellidopaterno1)

            cmd.Parameters.AddWithValue("@materno", pEntidad.Apellidomaterno1)
            cmd.Parameters.AddWithValue("@fechanac", pEntidad.Fechanac1)
            cmd.Parameters.AddWithValue("@celular", pEntidad.Celular1)
            cmd.Parameters.AddWithValue("@telefono", pEntidad.Telefono1)
            cmd.Parameters.AddWithValue("@dni", pEntidad.Dni1)
            cmd.Parameters.AddWithValue("@huella", pEntidad.Huella1)
            cmd.Parameters.AddWithValue("@idarea", pEntidad.Idarea1)
            cmd.Parameters.AddWithValue("@idestado", pEntidad.Idestado1)
            cmd.ExecuteNonQuery()

            cmd.Dispose()
            cnn.Close()
            cnn.Dispose()


        End Using

    End Sub



    Public Function lista_huellas() As List(Of Byte())
        Dim lista As New List(Of Byte())
        Dim elbyte As Byte() = Nothing
        Using cnn = New SqlConnection(conex.Lecc1)

            Dim cmd As New SqlCommand()
            Dim dr As SqlDataReader

            cmd.CommandText = "SP_LISTA_HUELLA"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cnn.Open()
            dr = cmd.ExecuteReader()
            While (dr.Read)
                Dim oEntidad = New Empleado()
                oEntidad.Huella1 = dr("huella")
                elbyte = oEntidad.Huella1
                lista.Add(elbyte)

            End While
            cmd.Dispose()
            cnn.Dispose()
            cnn.Close()

            Return lista

        End Using
    End Function

End Class
