Public Class Asistencia
    Dim idasistencia As Integer
    Dim idempleado As Integer
    Dim marca As Date

    Public Property Idasistencia1 As Integer
        Get
            Return idasistencia
        End Get
        Set(value As Integer)
            idasistencia = value
        End Set
    End Property

    Public Property Idempleado1 As Integer
        Get
            Return idempleado
        End Get
        Set(value As Integer)
            idempleado = value
        End Set
    End Property

    Public Property Marca1 As Date
        Get
            Return marca
        End Get
        Set(value As Date)
            marca = value
        End Set
    End Property
End Class
