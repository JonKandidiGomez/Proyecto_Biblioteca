Imports System.Windows.Forms.VisualStyles
Imports ControlUsuario
Public Class Ventana_Libros
    Dim gestor As New GestionBiblioteca
    Dim cargado = False
    Private Sub Ventana_Libros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarLibros()
    End Sub

    Private Sub cargarLibros()
        flpLibros.Controls.Clear()
        Dim libros = gestor.buscarLibros()
        For Each libro In libros
            Dim controlUsuario As New UserControl1 With {
                .id = libro.id,
                .titulo = libro.titulo,
                .autor = libro.escritor,
                .Parent = flpLibros,
                .Width = flpLibros.Width - 8
            }

            AddHandler controlUsuario.ClickEditar, AddressOf EditarLibro
            AddHandler controlUsuario.ClickBorrar, AddressOf BorrarLibro
            AddHandler controlUsuario.ClickVer, AddressOf VerLibro
        Next
    End Sub

    Private Sub EditarLibro(sender As Object, e As EventArgs)
        Dim vNuevoLibro As New Ventana_NuevoLibro
        Dim control As UserControl1 = CType(sender, UserControl1)
        Dim libro As Libro = gestor.buscarLibro(control.titulo)
        vNuevoLibro.id = libro.id
        vNuevoLibro.titulo = libro.titulo
        vNuevoLibro.autor = libro.escritor
        vNuevoLibro.año = libro.añoEdicion
        vNuevoLibro.sinopsis = libro.sinopsis
        vNuevoLibro.editando = True
        vNuevoLibro.MdiParent = Me.MdiParent
        vNuevoLibro.Dock = DockStyle.Fill
        vNuevoLibro.Show()
    End Sub

    Private Sub BorrarLibro(sender As Object, e As EventArgs)
        Dim control As UserControl1 = CType(sender, UserControl1)
        Dim libro As Libro = gestor.buscarLibro(control.titulo)
        If gestor.lanzarMensaje("COMPROBAR", "Vas a borrar un libro") = 1 Then
            gestor.borrarLibro(libro.id)
            MsgBox("Libro borrado")
            cargarLibros()
        End If
    End Sub

    Private Sub VerLibro(sender As Object, e As EventArgs)
        Dim vLibro As New Ventana_InfoLibro
        Dim control As UserControl1 = CType(sender, UserControl1)
        Dim libro As Libro = gestor.buscarLibro(control.titulo)
        vLibro.lTitulo.Text = libro.titulo
        vLibro.lAutor.Text = libro.escritor
        vLibro.lAño.Text = libro.añoEdicion
        vLibro.tbSinopsis.Text = libro.sinopsis
        vLibro.MdiParent = Me.MdiParent
        vLibro.Dock = DockStyle.Fill
        vLibro.Show()
    End Sub

    Private Sub bNuevoLibro_Click(sender As Object, e As EventArgs) Handles bNuevoLibro.Click
        Dim vNuevoLibro As New Ventana_NuevoLibro
        vNuevoLibro.MdiParent = Me.MdiParent
        vNuevoLibro.Dock = DockStyle.Fill
        vNuevoLibro.Show()
    End Sub

    Private Sub Ventana_Libros_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        cargado = True
    End Sub

    Private Sub Ventana_Libros_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If cargado Then
            For Each control In flpLibros.Controls
                control.Width = flpLibros.Width - 8
            Next
        End If
    End Sub
End Class