Public Class Ventana_Prestamos
    Dim gestor As New GestionBiblioteca
    Private fechaMin As DateTime = System.DateTime.Today
    Private fechaMax As DateTime = DateAdd("d", 15, fechaMin)

    Private Sub Ventana_Prestamos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim usuarios = gestor.buscarUsuarios()
        For Each usuario In usuarios
            lbUsuarios.Items.Add(String.Format("{0} {1} {2}", usuario.nombre, usuario.apellido1, usuario.apellido2))
        Next
        dtpFecha.MinDate = fechaMin
        dtpFecha.MaxDate = fechaMax
        dtpFecha.Value = fechaMax
    End Sub

    Private Sub lbUsuarios_SelectedValueChanged(sender As Object, e As EventArgs) Handles lbUsuarios.SelectedValueChanged
        If bGuardar.Visible Then
            cargarDisponibles()
        Else
            cargarPrestamos()
        End If
    End Sub

    Private Sub bNuevoPrestamo_Click(sender As Object, e As EventArgs) Handles bNuevoPrestamo.Click
        lLibros.Text = "Libros disponibles"
        bDevolucion.Visible = False
        bNuevoPrestamo.Visible = False
        bGuardar.Visible = True
        bVolver.Visible = True
        lFecha.Visible = True
        dtpFecha.Visible = True
        cargarDisponibles()
    End Sub

    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
        If lbUsuarios.SelectedItem Is Nothing Then
            gestor.lanzarMensaje("ERROR", "Selecciona un usuario")
        ElseIf lbLibros.SelectedItem Is Nothing Then
            gestor.lanzarMensaje("ERROR", "Selecciona un libro")
        Else
            Dim usuario = gestor.buscarUsuario(lbUsuarios.SelectedItem)
            Dim libro = gestor.buscarLibro(lbLibros.SelectedItem)
            gestor.nuevoPrestamo(usuario.id, libro.id, fechaMin.ToString(), dtpFecha.Value.ToString())
            MsgBox("Nuevo prestamo guardado")
            volver()
        End If
    End Sub

    Private Sub bVolver_Click(sender As Object, e As EventArgs) Handles bVolver.Click
        volver()
    End Sub

    Private Sub bDevolucion_Click(sender As Object, e As EventArgs) Handles bDevolucion.Click
        If lbUsuarios.SelectedItem Is Nothing Or lbLibros.SelectedItem Is Nothing Then
            gestor.lanzarMensaje("ERROR", "Asegurate de seleccionar un usuario y el libro prestado")
        Else
            If gestor.lanzarMensaje("COMPROBAR", "Vas a registrar una devolución") = 1 Then
                Dim usuario = gestor.buscarUsuario(lbUsuarios.SelectedItem)
                Dim libro = gestor.buscarLibro(lbLibros.SelectedItem)
                gestor.borrarPrestamo(libro.id, usuario.id)
                MsgBox("Prestamo finalizado")
                cargarPrestamos()
            End If
        End If
    End Sub

    Private Sub volver()
        lLibros.Text = "Prestamos"
        bDevolucion.Visible = True
        bNuevoPrestamo.Visible = True
        bGuardar.Visible = False
        bVolver.Visible = False
        lFecha.Visible = False
        dtpFecha.Visible = False
        lbLibros.Items.Clear()
        lbUsuarios.ClearSelected()
    End Sub

    Private Sub cargarDisponibles()
        lbLibros.Items.Clear()
        Dim disponibles As New List(Of Libro)
        disponibles = gestor.buscarLibrosDisponibles()
        For Each l In disponibles
            lbLibros.Items.Add(l.titulo)
        Next
    End Sub

    Private Sub cargarPrestamos()
        If lbUsuarios.SelectedItem IsNot Nothing Then
            lbLibros.Items.Clear()
            Dim prestamos As New List(Of Prestamo)
            Dim us = gestor.buscarUsuario(lbUsuarios.SelectedItem)
            prestamos = gestor.buscarPrestamos(us.id)
            For Each p In prestamos
                lbLibros.Items.Add(gestor.buscarLibroPorId(p.libro))
            Next
        End If
    End Sub

    Dim cargado = False
    Const anchoMin = 480

    Private Sub Ventana_Prestamos_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        cargado = True
    End Sub

    Private Sub Ventana_Prestamos_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If cargado Then
            Dim tamañoFuente = (10 * Me.Size.Width) / anchoMin
            Dim fuente As New Font("Miriam Libre", IIf(tamañoFuente < 10, 10, IIf(tamañoFuente > 20, 20, tamañoFuente)), FontStyle.Bold)
            For Each control In tlpPrincipal.Controls
                control.Font = fuente
            Next
            For Each control In tlpBotones.Controls
                control.Font = fuente
            Next
        End If
    End Sub
End Class