Public Class Estado

    Dim idestado As Integer
    Dim nomestado As String

    Public Property Idestado1 As Integer
        Get
            Return idestado
        End Get
        Set(value As Integer)
            idestado = value
        End Set
    End Property

    Public Property Nomestado1 As String
        Get
            Return nomestado
        End Get
        Set(value As String)
            nomestado = value
        End Set
    End Property
End Class
