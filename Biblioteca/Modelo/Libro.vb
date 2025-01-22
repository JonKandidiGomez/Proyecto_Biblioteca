Public Class Libro
    Private _titulo As String
    Private _escritor As String
    Private _añoEdicion As Integer
    Private _sinopsis As String
    Private _disponible As Boolean
    Private __id As Integer

    Property id As Integer
        Get
            Return _id
        End Get
        Set
            _id = Value
        End Set
    End Property

    Property titulo As String
        Get
            Return _titulo
        End Get
        Set
            _titulo = Value
        End Set
    End Property

    Property escritor As String
        Get
            Return _escritor
        End Get
        Set
            _escritor = Value
        End Set
    End Property

    Property añoEdicion As Integer
        Get
            Return _añoEdicion
        End Get
        Set
            _añoEdicion = Value
        End Set
    End Property

    Property sinopsis As String
        Get
            Return _sinopsis
        End Get
        Set
            _sinopsis = Value
        End Set
    End Property

    Property disponible As Boolean
        Get
            Return _disponible
        End Get
        Set
            _disponible = Value
        End Set
    End Property

    Property _id As Integer
        Get
            Return __id
        End Get
        Set
            __id = Value
        End Set
    End Property

    Public Sub New(id As Integer, titulo As String, escritor As String, añoEdicion As Integer, sinopsis As String, disponible As Integer)
        Me.id = id
        Me.titulo = titulo
        Me.escritor = escritor
        Me.añoEdicion = añoEdicion
        Me.sinopsis = sinopsis
        If disponible = 0 Then
            Me.disponible = False
        ElseIf disponible = 1 Then
            Me.disponible = True
        End If
    End Sub

End Class
