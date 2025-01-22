Public Class Prestamo
    Private _id As Integer
    Private _libro As Integer
    Private _usuario As Integer
    Private _fechaInicio As String
    Private _fechaFin As String

    Property id As Integer
        Get
            Return _id
        End Get
        Set
            _id = Value
        End Set
    End Property

    Property libro As Integer
        Get
            Return _libro
        End Get
        Set
            _libro = Value
        End Set
    End Property

    Property usuario As Integer
        Get
            Return _usuario
        End Get
        Set
            _usuario = Value
        End Set
    End Property

    Property fechaInicio As String
        Get
            Return _fechaInicio
        End Get
        Set
            _fechaInicio = Value
        End Set
    End Property

    Property fechaFin As String
        Get
            Return _fechaFin
        End Get
        Set
            _fechaFin = Value
        End Set
    End Property

    Public Sub New(id As Integer, libro As Integer, usuario As Integer, fechaInicio As String, fechaFin As String)
        Me.id = id
        Me.libro = libro
        Me.usuario = usuario
        Me.fechaInicio = fechaInicio
        Me.fechaFin = fechaFin
    End Sub
End Class
