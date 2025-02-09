Imports System.Data.SQLite
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography.X509Certificates
Imports Microsoft.VisualBasic.ApplicationServices

Public Class GestionBiblioteca
    Public Function buscarLibros()
        Dim libros As New List(Of Libro)

        Dim sql As String = "SELECT * FROM LIBROS"
        Dim cmd As New SQLiteCommand
        cmd.CommandText = sql
        Dim lector = SQLLite.GetDataReader(My.Settings.conexion, cmd)

        While lector.Read()
            Dim id = lector.GetInt16(0)
            Dim titulo = lector.GetString(1)
            Dim escritor = lector.GetString(2)
            Dim añoEdicion = lector.GetInt16(3)
            Dim sinopsis = lector.GetString(4)
            Dim disponible = lector.GetBoolean(5)

            libros.Add(New Libro(id, titulo, escritor, añoEdicion, sinopsis, disponible))
        End While

        Return libros
    End Function

    Public Function buscarLibro(libro As String)
        Dim libros = buscarLibros()

        For Each l In libros
            If l.titulo.Equals(libro) Then
                Return l
            End If
        Next

        Return "libro no encontrado"
    End Function

    Public Function buscarLibroPorId(id As Integer)
        Dim sql As String = String.Format("SELECT TITULO FROM LIBROS WHERE ID = {0}", id)
        Dim cmd As New SQLiteCommand
        cmd.CommandText = sql
        Dim lector = SQLLite.GetDataReader(My.Settings.conexion, cmd)
        Dim titulo As String = "libro no encontrado"

        While lector.Read()
            titulo = lector.GetString(0)
        End While

        Return titulo
    End Function

    Public Function buscarLibrosDisponibles()
        Dim libros As New List(Of Libro)

        Dim sql As String = "SELECT * FROM LIBROS WHERE DISPONIBLE = 1"
        Dim cmd As New SQLiteCommand
        cmd.CommandText = sql
        Dim lector = SQLLite.GetDataReader(My.Settings.conexion, cmd)

        While lector.Read()
            Dim id = lector.GetInt16(0)
            Dim titulo = lector.GetString(1)
            Dim escritor = lector.GetString(2)
            Dim añoEdicion = lector.GetInt16(3)
            Dim sinopsis = lector.GetString(4)
            Dim disponible = lector.GetBoolean(5)

            libros.Add(New Libro(id, titulo, escritor, añoEdicion, sinopsis, disponible))
        End While

        Return libros
    End Function

    Public Sub nuevoLibro(titulo As String, autor As String, año As String, sinopsis As String)
        Dim id = buscarUltimoId("LIBROS")
        Dim Cmd As New SQLiteCommand
        Dim sql As String = "INSERT INTO LIBROS (ID, TITULO, ESCRITOR, ANO_EDICION, SINOPSIS, DISPONIBLE) VALUES (@Id, @Titulo, @Autor, @Año, @Sinopsis, @Disponible)"
        Cmd.CommandText = sql
        Cmd.Parameters.Add("@Id", DbType.Int16).Value = id
        Cmd.Parameters.Add("@Titulo", DbType.String).Value = titulo
        Cmd.Parameters.Add("@Autor", DbType.String).Value = autor
        Cmd.Parameters.Add("@Año", DbType.Int16).Value = año
        Cmd.Parameters.Add("@Sinopsis", DbType.String).Value = sinopsis
        Cmd.Parameters.Add("@Disponible", DbType.String).Value = 1
        SQLLite.Ejecuta(My.Settings.conexion, Cmd)
    End Sub

    Public Sub editarLibro(id As Integer, titulo As String, autor As String, año As Integer, sinopsis As String)
        Dim Cmd As New SQLiteCommand
        Dim sql As String = "UPDATE LIBROS SET TITULO=@Titulo, ESCRITOR=@Escritor, ANO_EDICION=@Año, SINOPSIS=@Sinopsis WHERE ID=@Id"
        Cmd.CommandText = sql
        Cmd.Parameters.Add("@Id", DbType.Int16).Value = id
        Cmd.Parameters.Add("@Titulo", DbType.String).Value = titulo
        Cmd.Parameters.Add("@Escritor", DbType.String).Value = autor
        Cmd.Parameters.Add("@Año", DbType.Int16).Value = año
        Cmd.Parameters.Add("@Sinopsis", DbType.String).Value = sinopsis
        SQLLite.Ejecuta(My.Settings.conexion, Cmd)
    End Sub

    Public Sub borrarLibro(id As Integer)
        Dim Cmd As New SQLiteCommand
        Dim sql As String = "DELETE FROM LIBROS WHERE ID=@Id"
        Cmd.CommandText = sql
        Cmd.Parameters.Add("@Id", DbType.Int16).Value = id
        SQLLite.Ejecuta(My.Settings.conexion, Cmd)

        borrarPrestamosPorLibro(id)
    End Sub

    Public Function buscarUsuarios()
        Dim usuarios As New List(Of Usuario)

        Dim sql As String = "SELECT * FROM USUARIOS"
        Dim cmd As New SQLiteCommand
        cmd.CommandText = sql
        Dim lector = SQLLite.GetDataReader(My.Settings.conexion, cmd)

        While lector.Read()
            Dim id = lector.GetInt16(0)
            Dim nombre = lector.GetString(1)
            Dim apellido1 = lector.GetString(2)
            Dim apellido2 = lector.GetString(3)
            Dim telefono = lector.GetInt64(4)

            usuarios.Add(New Usuario(id, nombre, apellido1, apellido2, telefono))
        End While

        Return usuarios
    End Function

    Public Function buscarUsuario(user As String)
        Dim usuarios = buscarUsuarios()

        For Each us In usuarios
            Dim nombre = String.Format("{0} {1} {2}", us.nombre, us.apellido1, us.apellido2)

            If nombre.Equals(user) Then
                Dim usuario As Usuario
                usuario = us
                Return usuario
            End If
        Next
        Return "usuario no encontrado"
    End Function

    Public Sub nuevoUsuario(nombre As String, apellido1 As String, apellido2 As String, telefono As Integer)
        Dim id = buscarUltimoId("USUARIOS")
        Dim Cmd As New SQLiteCommand
        Dim sql As String = "INSERT INTO USUARIOS (ID, NOMBRE, APELLIDO_1, APELLIDO_2, TELEFONO) VALUES (@Id, @Nombre, @Apellido1, @Apellido2, @Telefono)"
        Cmd.CommandText = sql
        Cmd.Parameters.Add("@Id", DbType.Int16).Value = id
        Cmd.Parameters.Add("@Nombre", DbType.String).Value = nombre
        Cmd.Parameters.Add("@Apellido1", DbType.String).Value = apellido1
        Cmd.Parameters.Add("@Apellido2", DbType.String).Value = apellido2
        Cmd.Parameters.Add("@Telefono", DbType.Int64).Value = telefono
        SQLLite.Ejecuta(My.Settings.conexion, Cmd)
    End Sub

    Public Sub editarUsuario(id As Integer, nombre As String, apellido1 As String, apellido2 As String, telefono As Int64)
        Dim Cmd As New SQLiteCommand
        Dim sql As String = "UPDATE LIBROS SET TITULO=@Titulo, APELLIDO_1=@Apellido1, APELLIDO_2=@Apellido2, TELEFONO=@Telefono WHERE ID=@Id"
        Cmd.CommandText = sql
        Cmd.Parameters.Add("@Id", DbType.Int16).Value = id
        Cmd.Parameters.Add("@Nombre", DbType.String).Value = nombre
        Cmd.Parameters.Add("@Apellido1", DbType.String).Value = apellido1
        Cmd.Parameters.Add("@Apellido2", DbType.String).Value = apellido2
        Cmd.Parameters.Add("@Telefono", DbType.Int64).Value = telefono
        SQLLite.Ejecuta(My.Settings.conexion, Cmd)
    End Sub

    Public Sub borrarUsuario(id As Integer)
        Dim Cmd As New SQLiteCommand
        Dim sql As String = "DELETE FROM USUARIOS WHERE ID=@Id"
        Cmd.CommandText = sql
        Cmd.Parameters.Add("@Id", DbType.Int16).Value = id
        SQLLite.Ejecuta(My.Settings.conexion, Cmd)

        borrarPrestamosPorUsuario(id)
    End Sub

    Public Function buscarPrestamos(idUsuario As Integer)
        Dim prestamos As New List(Of Prestamo)

        Dim sql As String = String.Format("SELECT * FROM PRESTAMOS WHERE ID_USUARIO = {0}", idUsuario)
        Dim cmd As New SQLiteCommand
        cmd.CommandText = sql
        Dim lector = SQLLite.GetDataReader(My.Settings.conexion, cmd)

        While lector.Read()
            Dim id = lector.GetInt16(0)
            Dim id_libro = lector.GetInt16(1)
            Dim id_usuario = lector.GetInt16(2)
            Dim fecha_inicio = lector.GetString(3)
            Dim fecha_fin = lector.GetString(4)

            prestamos.Add(New Prestamo(id, id_libro, id_usuario, fecha_inicio, fecha_fin))
        End While

        Return prestamos
    End Function

    Public Sub nuevoPrestamo(idUsuario As Integer, idLibro As Integer, fechaInicio As String, fechaFin As String)
        Dim id = buscarUltimoId("PRESTAMOS")
        Dim Cmd As New SQLiteCommand
        Dim sql As String = "INSERT INTO PRESTAMOS (ID, ID_LIBRO, ID_USUARIO, FECHA_INICIO, FECHA_FIN) VALUES (@Id, @Id_Libro, @Id_Usuario, @Fecha_Inicio, @Fecha_Fin)"
        Cmd.CommandText = sql
        Cmd.Parameters.Add("@Id", DbType.Int16).Value = id
        Cmd.Parameters.Add("@Id_Libro", DbType.Int16).Value = idLibro
        Cmd.Parameters.Add("@Id_Usuario", DbType.Int16).Value = idUsuario
        Cmd.Parameters.Add("@Fecha_Inicio", DbType.String).Value = fechaInicio
        Cmd.Parameters.Add("@Fecha_Fin", DbType.String).Value = fechaFin
        SQLLite.Ejecuta(My.Settings.conexion, Cmd)
        actualizarDisponible(idLibro, 0)
    End Sub

    Public Sub borrarPrestamo(idLibro As Integer, idUsuario As Integer)
        Dim Cmd As New SQLiteCommand
        Dim sql As String = "DELETE FROM PRESTAMOS WHERE ID_LIBRO=@IdLibro AND ID_USUARIO=@IdUsuario"
        Cmd.CommandText = sql
        Cmd.Parameters.Add("@IdLibro", DbType.Int16).Value = idLibro
        Cmd.Parameters.Add("@IdUsuario", DbType.Int16).Value = idUsuario
        SQLLite.Ejecuta(My.Settings.conexion, Cmd)
        actualizarDisponible(idLibro, 1)
    End Sub

    Public Sub borrarPrestamosPorLibro(idLibro As Integer)
        Dim Cmd As New SQLiteCommand
        Dim sql As String = "DELETE FROM PRESTAMOS WHERE ID_LIBRO=@IdLibro"
        Cmd.CommandText = sql
        Cmd.Parameters.Add("@IdLibro", DbType.Int16).Value = idLibro
        SQLLite.Ejecuta(My.Settings.conexion, Cmd)
    End Sub

    Public Sub borrarPrestamosPorUsuario(idUsuario As Integer)
        Dim prestamos As New List(Of Prestamo)
        prestamos = buscarPrestamos(idUsuario)

        Dim Cmd As New SQLiteCommand
        Dim sql As String = "DELETE FROM PRESTAMOS WHERE ID_USUARIO=@IdUsuario"
        Cmd.CommandText = sql
        Cmd.Parameters.Add("@IdUsuario", DbType.Int16).Value = idUsuario
        SQLLite.Ejecuta(My.Settings.conexion, Cmd)

        For Each p In prestamos
            actualizarDisponible(p.libro, 1)
        Next

    End Sub

    Private Sub actualizarDisponible(idLibro As Integer, disponible As Integer)
        Dim Cmd As New SQLiteCommand
        Dim sql As String = "UPDATE LIBROS SET DISPONIBLE=@Disponible WHERE ID=@Id"
        Cmd.CommandText = sql
        Cmd.Parameters.Add("@Id", DbType.Int16).Value = idLibro
        Cmd.Parameters.Add("@Disponible", DbType.Int16).Value = disponible
        SQLLite.Ejecuta(My.Settings.conexion, Cmd)
    End Sub

    Private Function buscarUltimoId(tabla As String)
        Dim sql As String = String.Format("SELECT MAX(ID) FROM {0}", tabla)
        Dim cmd As New SQLiteCommand
        cmd.CommandText = sql
        Dim lector = SQLLite.GetDataReader(My.Settings.conexion, cmd)
        Dim id As Integer = 0

        While lector.Read()
            If Not lector.IsDBNull(0) Then ' Verificamos si el valor no es NULL
                id = lector.GetInt16(0)
            End If
        End While

        Return id + 1
    End Function

    Public Function lanzarMensaje(tipo As String, mensaje As String)
        Dim respuesta = 0
        Select Case tipo
            Case "ERROR"
                MsgBox(mensaje, Title:="Error")
            Case "COMPROBAR"
                respuesta = MsgBox(mensaje, 1, Title:="¿Estas seguro?")
        End Select
        Return respuesta
    End Function
End Class
