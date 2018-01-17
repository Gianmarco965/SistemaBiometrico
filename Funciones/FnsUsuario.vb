Imports System.Data.SqlClient

Public Class FnsUsuario
    Public cnn As New SqlConnection

    'Inicia evento validar
    Public Function Validar(ByRef pEntidad As Entidades.Usuario) As Boolean
        Dim mensaje As String = ""
        Dim verificador As Boolean
        Using cnn = New SqlConnection(conex.Lecc1)
            cnn.Open()
            Dim cmd As New SqlCommand()
            cmd.CommandText = "SP_LOGIN"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@usu", pEntidad.Usu1)
            cmd.Parameters.AddWithValue("@pass", pEntidad.Pass1)
            cmd.Parameters.Add("@msg", SqlDbType.VarChar, 50)
            cmd.Parameters("@msg").Direction = ParameterDirection.Output

            Dim lector As SqlDataReader
            lector = cmd.ExecuteReader()
            mensaje = cmd.Parameters("@msg").Value
            If (mensaje.Equals("ok")) Then
                verificador = True
            ElseIf (mensaje.Equals("fallo")) Then
                verificador = False
            Else
                verificador = False
            End If
        End Using
        Return verificador

    End Function


End Class
