Public Class Usuario
    Private _id As Integer
    Private _nombre As String
    Private _apellido1 As String
    Private _apellido2 As String
    Private _telefono As Integer

    Property id As Integer
        Get
            Return _id
        End Get
        Set
            _id = Value
        End Set
    End Property

    Property nombre As String
        Get
            Return _nombre
        End Get
        Set
            _nombre = Value
        End Set
    End Property

    Property apellido1 As String
        Get
            Return _apellido1
        End Get
        Set
            _apellido1 = Value
        End Set
    End Property

    Property apellido2 As String
        Get
            Return _apellido2
        End Get
        Set
            _apellido2 = Value
        End Set
    End Property

    Property telefono As Integer
        Get
            Return _telefono
        End Get
        Set
            _telefono = Value
        End Set
    End Property

    Public Sub New(id As Integer, nombre As String, apellido1 As String, apellido2 As String, telefono As Integer)
        Me.id = id
        Me.nombre = nombre
        Me.apellido1 = apellido1
        Me.apellido2 = apellido2
        Me.telefono = telefono
    End Sub
End Class
