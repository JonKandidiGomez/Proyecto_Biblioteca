Public Class Ventana_NuevoLibro

    Public editando = False
    Property titulo As String
        Get
            Return tbTitulo.Text
        End Get
        Set
            tbTitulo.Text = Value
        End Set
    End Property

    Property autor As String
        Get
            Return tbAutor.Text
        End Get
        Set
            tbAutor.Text = Value
        End Set
    End Property

    Property año As String
        Get
            Return tbAño.Text
        End Get
        Set
            tbAño.Text = Value
        End Set
    End Property

    Property sinopsis As String
        Get
            Return tbSinopsis.Text
        End Get
        Set
            tbSinopsis.Text = Value
        End Set
    End Property

    Property id As Integer
        Get
            Return _id
        End Get
        Set
            _id = Value
        End Set
    End Property

    Dim gestor As New GestionBiblioteca

    Private _titulo As String
    Private _autor As String
    Private _año As String
    Private _sinopsis As String
    Private _id As Integer

    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
        Dim mensaje = validarDatos()
        If mensaje = "Datos validos" Then
            If editando Then
                Dim respuesta = gestor.lanzarMensaje("COMPROBAR", "Vas a editar un libro")
                If respuesta = 1 Then
                    gestor.editarLibro(Me.id, tbTitulo.Text, tbAutor.Text, tbAño.Text, tbSinopsis.Text)
                    MsgBox("Libro guardado")
                End If
            Else
                Dim respuesta = gestor.lanzarMensaje("COMPROBAR", "Vas a guardar un nuevo libro")
                If respuesta = 1 Then
                    gestor.nuevoLibro(tbTitulo.Text, tbAutor.Text, tbAño.Text, tbSinopsis.Text)
                    MsgBox("Libro guardado")
                End If
            End If
            limpiar()
        Else
            gestor.lanzarMensaje("ERROR", mensaje)
        End If
    End Sub

    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        limpiar()
    End Sub

    Private Function validarDatos()
        Dim validos = "Datos validos"
        If tbTitulo.Text = "" Then
            validos = "Falta el titulo del libro"
        ElseIf tbAutor.Text = "" Then
            validos = "Falta el autor del libro"
        ElseIf Not validarAño(tbAño.Text) Then
            validos = "El año tiene que ser un numero de 4 digitos entre 1492 y 2025 "
        ElseIf tbSinopsis.Text = "" Then
            validos = "Falta la sinopsis del libro"
        End If
        Return validos
    End Function
    Private Function validarAño(año As String)
        Return IsNumeric(año) And año.Length = 4 And CInt(año) < 2026 And CInt(año) > 1491
    End Function
    Private Sub limpiar()
        tbTitulo.Clear()
        tbAutor.Clear()
        tbAño.Clear()
        tbSinopsis.Clear()
    End Sub
End Class