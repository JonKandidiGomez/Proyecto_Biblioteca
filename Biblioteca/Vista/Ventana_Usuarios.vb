Public Class Ventana_Usuarios
    Dim gestor As New GestionBiblioteca
    Private Sub cargarDatos()
        lbUsuarios.Items.Clear()
        Dim usuarios = gestor.buscarUsuarios()
        For Each usuario In usuarios
            lbUsuarios.Items.Add(String.Format("{0} {1} {2}", usuario.nombre, usuario.apellido1, usuario.apellido2))
        Next
    End Sub
    Private Sub Ventana_Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
    End Sub

    Private Sub lbUsuarios_SelectedValueChanged(sender As Object, e As EventArgs) Handles lbUsuarios.SelectedValueChanged
        Dim us = gestor.buscarUsuario(lbUsuarios.SelectedItem)
        If us.Equals("usuario no encontrado") Then
            limpiar()
        Else
            tbNombre.Text = us.nombre
            tbPrimerApellido.Text = us.apellido1
            tbSegundoApellido.Text = us.apellido2
            tbTelefono.Text = us.telefono
        End If
    End Sub

    Private Sub bNuevoUsuario_Click(sender As Object, e As EventArgs) Handles bNuevoUsuario.Click
        Dim mensaje = validarDatos()
        If gestor.buscarUsuario(String.Format("{0} {1} {2}", tbNombre.Text, tbPrimerApellido.Text, tbSegundoApellido.Text)).Equals("usuario no encontrado") Then
            If mensaje = "Datos validos" Then
                If gestor.lanzarMensaje("COMPROBAR", "Vas a crear un nuevo usuario") = 1 Then
                    gestor.nuevoUsuario(tbNombre.Text, tbPrimerApellido.Text, tbSegundoApellido.Text, CInt(tbTelefono.Text))
                    MsgBox("Usuario creado", Title:="Usuarios")
                    cargarDatos()
                Else
                    limpiar()
                End If
            Else
                gestor.lanzarMensaje("ERROR", mensaje)
            End If
        Else
            gestor.lanzarMensaje("ERROR", "Ya existe un usuario con ese nombre")
        End If
    End Sub

    Private Sub bEditarUsuario_Click(sender As Object, e As EventArgs) Handles bEditarUsuario.Click
        Dim usuario = gestor.buscarUsuario(lbUsuarios.SelectedItem)
        If usuario.Equals("usuario no encontrado") Then
            gestor.lanzarMensaje("ERROR", "Ningun usuario seleccionado")
        Else
            Dim mensaje = validarDatos()
            If mensaje = "Datos validos" Then
                If gestor.lanzarMensaje("COMPROBAR", "Vas a actualizar un usuario") = 1 Then

                    gestor.editarUsuario(usuario.id, tbNombre.Text, tbPrimerApellido.Text, tbSegundoApellido.Text, CInt(tbTelefono.Text))
                    MsgBox("Datos actualizados", Title:="Usuarios")
                    cargarDatos()
                Else
                    limpiar()
                End If
            Else
                gestor.lanzarMensaje("ERROR", mensaje)
            End If
        End If
    End Sub

    Private Sub bBorrarUsuario_Click(sender As Object, e As EventArgs) Handles bBorrarUsuario.Click
        Dim usuario = gestor.buscarUsuario(lbUsuarios.SelectedItem)
        If usuario.Equals("usuario no encontrado") Then
            gestor.lanzarMensaje("ERROR", "Ningun usuario seleccionado")
        Else
            If gestor.lanzarMensaje("COMPROBAR", "Vas a eliminar un usuario") = 1 Then
                gestor.borrarUsuario(usuario.id)
                MsgBox("Usuario borrado", Title:="Usuarios")
                cargarDatos()
            End If
        End If
    End Sub

    Private Function validarTel(telefono As String)
        Return IsNumeric(telefono) And telefono.Length = 9
    End Function

    Private Function validarDatos()
        Dim validos = "Datos validos"
        If tbNombre.Text = "" Then
            validos = "Falta el nombre"
        ElseIf tbPrimerApellido.Text = "" Then
            validos = "Falta el primer apellido"
        ElseIf tbSegundoApellido.Text = "" Then
            validos = "Falta el segundo apellido"
        ElseIf Not validarTel(tbTelefono.Text) Then
            validos = "El telefono debe ser un numero de 9 digitos"
        End If
        Return validos
    End Function

    Private Sub limpiar()
        lbUsuarios.ClearSelected()
        tbNombre.Clear()
        tbPrimerApellido.Clear()
        tbSegundoApellido.Clear()
        tbTelefono.Clear()
    End Sub

    Dim cargado = False
    Dim anchoMin = 480

    Private Sub Ventana_Usuarios_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        cargado = True
    End Sub


    Private Sub Ventana_Usuarios_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If cargado Then
            Dim tamañoFuente = (10 * Me.Size.Width) / anchoMin
            Dim fuente As New Font("Miriam Libre", IIf(tamañoFuente < 10, 10, IIf(tamañoFuente > 20, 20, tamañoFuente)), FontStyle.Bold)
            For Each control In tlpDatos.Controls
                control.Font = fuente
            Next
            For Each control In tlpPrincipal.Controls
                control.Font = fuente
            Next
            tamañoFuente = (12 * Me.Size.Width) / anchoMin
            lbUsuarios.Font = New Font("Miriam Libre", IIf(tamañoFuente < 12, 12, IIf(tamañoFuente > 24, 24, tamañoFuente)), FontStyle.Bold)
        End If
    End Sub
End Class