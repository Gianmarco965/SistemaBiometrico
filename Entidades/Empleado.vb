Imports Entidades

Public Class Empleado
    Inherits Estado
    Implements IArea

    Dim idempleado As Integer
    Dim nomepleado As String
    Dim apellidopaterno As String
    Dim apellidomaterno As String
    Dim fechanac As Date
    Dim celular As String
    Dim telefono As String
    Dim dni As String
    Dim huella As Byte()
    Dim idarea As Integer
    Dim nomarea As String

    Public Property Idempleado1 As Integer
        Get
            Return idempleado
        End Get
        Set(value As Integer)
            idempleado = value
        End Set
    End Property

    Public Property Nomepleado1 As String
        Get
            Return nomepleado
        End Get
        Set(value As String)
            nomepleado = value
        End Set
    End Property

    Public Property Apellidopaterno1 As String
        Get
            Return apellidopaterno
        End Get
        Set(value As String)
            apellidopaterno = value
        End Set
    End Property

    Public Property Apellidomaterno1 As String
        Get
            Return apellidomaterno
        End Get
        Set(value As String)
            apellidomaterno = value
        End Set
    End Property

    Public Property Fechanac1 As Date
        Get
            Return fechanac
        End Get
        Set(value As Date)
            fechanac = value
        End Set
    End Property

    Public Property Celular1 As String
        Get
            Return celular
        End Get
        Set(value As String)
            celular = value
        End Set
    End Property

    Public Property Telefono1 As String
        Get
            Return telefono
        End Get
        Set(value As String)
            telefono = value
        End Set
    End Property

    Public Property Dni1 As String
        Get
            Return dni
        End Get
        Set(value As String)
            dni = value
        End Set
    End Property

    Public Property Huella1 As Byte()
        Get
            Return huella
        End Get
        Set(value As Byte())
            huella = value
        End Set
    End Property

    Public Property Idarea1 As Integer Implements IArea.Idarea1
        Get
            Return idarea
        End Get
        Set(value As Integer)
            idarea = value
        End Set
    End Property

    Public Property Nomarea1 As String Implements IArea.Nomarea1
        Get
            Return nomarea
        End Get
        Set(value As String)
            nomarea = value
        End Set
    End Property
End Class
