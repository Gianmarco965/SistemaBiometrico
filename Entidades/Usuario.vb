Public Class Usuario

    Dim idusuario As Integer
    Dim usu As String
    Dim pass As String

    Public Property Idusuario1 As Integer
        Get
            Return idusuario
        End Get
        Set(value As Integer)
            idusuario = value
        End Set
    End Property

    Public Property Usu1 As String
        Get
            Return usu
        End Get
        Set(value As String)
            usu = value
        End Set
    End Property

    Public Property Pass1 As String
        Get
            Return pass
        End Get
        Set(value As String)
            pass = value
        End Set
    End Property
End Class
