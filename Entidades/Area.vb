Public Class Area
    Dim idarea As Integer
    Dim nomarea As String

    Public Property Idarea1 As Integer
        Get
            Return idarea
        End Get
        Set(value As Integer)
            idarea = value
        End Set
    End Property

    Public Property Nomarea1 As String
        Get
            Return nomarea
        End Get
        Set(value As String)
            nomarea = value
        End Set
    End Property
End Class
