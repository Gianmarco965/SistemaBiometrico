Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Module conex
    Public ReadOnly Property Lecc1 As String
        Get
            Return "Data Source=.;Initial Catalog=dbassistance;Integrated Security=True"
        End Get
    End Property

    Function llenar_combo(ByVal cadena As String, ByVal parametro As String) As BindingSource
        Dim ds As New DataSet
        Dim bs As New BindingSource
        Dim da As New SqlDataAdapter(cadena, Lecc1)

        If parametro <> "" Then
            da.SelectCommand.Parameters.AddWithValue("@p", parametro)
        End If
        da.Fill(ds, "datos")
        bs.DataSource = ds.Tables(0)
        Return bs
    End Function

    Public Function llenar_combo_producto(ByVal condicion As String, ByVal cadena As String) As BindingSource
        Dim cnn As New SqlConnection(Lecc1)
        Dim cmd As New SqlCommand(cadena, cnn)
        Dim dr As SqlDataReader
        Dim bs As New BindingSource

        Try
            If condicion <> "" Then
                cmd.CommandText = cadena
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@p", condicion)
            End If
            cnn.Open()
            dr = cmd.ExecuteReader
            bs.DataSource = dr

            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return bs
    End Function



    Function buscar(ByVal cadena As String, ByVal Parametro As String)
        Dim da As New SqlDataAdapter(cadena, Lecc1)
        Dim ds As New DataSet
        Dim val As String

        If Parametro <> "" Then
            da.SelectCommand.Parameters.AddWithValue("@p", Parametro)
        End If
        da.Fill(ds, "datos")
        val = ds.Tables(0).Rows(0).Item(0).ToString
        Return val
    End Function
    Public Function obtener_valor(ByVal cadena As String, ByVal parametro As String)
        Dim valor As String
        Dim cnn As New SqlConnection(Lecc1)
        Dim cmdc As New SqlCommand(cadena, cnn)
        If parametro <> "" Then
            cmdc.Parameters.AddWithValue("@p", parametro)
        End If
        cnn.Open()
        If IsDBNull(cmdc.ExecuteScalar) Then
            valor = ""
        Else
            valor = cmdc.ExecuteScalar
        End If

        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Return valor
    End Function
    Public Sub Procesar(ByVal cadena As String)
        Dim cnn As New SqlConnection(Lecc1)
        Dim cmd As New SqlCommand(cadena, cnn)

        Try
            cnn.Open()
            cmd.ExecuteNonQuery()
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Module
