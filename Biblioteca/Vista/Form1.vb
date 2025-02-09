Imports System.Data.Entity.Core.Common

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarBiblioteca()
    End Sub

    Private Sub cargarBiblioteca()
        Dim vLibros As New Ventana_Libros With {
            .MdiParent = Me,
            .Dock = DockStyle.Fill
        }
        vLibros.Show()
    End Sub

    Private Sub cargarUsuarios()
        Dim vUsuarios As New Ventana_Usuarios With {
            .MdiParent = Me,
            .Dock = DockStyle.Fill
        }
        vUsuarios.Show()
    End Sub

    Private Sub cargarPrestamos()
        Dim vPrestamos As New Ventana_Prestamos With {
            .MdiParent = Me,
            .Dock = DockStyle.Fill
        }
        vPrestamos.Show()
    End Sub

    Private Sub BibliotecaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BibliotecaToolStripMenuItem.Click
        If Me.ActiveMdiChild.Name IsNot Ventana_Libros.Name Then
            Me.ActiveMdiChild.Close()
            cargarBiblioteca()
        End If

    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        If Me.ActiveMdiChild.Name IsNot Ventana_Usuarios.Name Then
            Me.ActiveMdiChild.Close()
            cargarUsuarios()
        End If

    End Sub

    Private Sub PrestamosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrestamosToolStripMenuItem.Click
        If Me.ActiveMdiChild.Name IsNot Ventana_Prestamos.Name Then
            Me.ActiveMdiChild.Close()
            cargarPrestamos()
        End If

    End Sub

    Dim cargado = False
    Const fuenteMin = 12
    Const fuenteMax = 24
    Const anchoMin = 500

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        cargado = True
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If cargado Then
            Dim tamañoFuente = (fuenteMin * Me.Size.Width) / anchoMin
            Dim fuente As New Font("Miriam Libre", IIf(tamañoFuente < fuenteMin, fuenteMin, IIf(tamañoFuente > fuenteMax, fuenteMax, tamañoFuente)), FontStyle.Bold)
            msBarraNav.Font = fuente
        End If
    End Sub
End Class
