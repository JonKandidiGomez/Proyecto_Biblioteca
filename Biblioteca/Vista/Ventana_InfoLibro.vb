Public Class Ventana_InfoLibro

    Dim minTitulo = 36
    Dim minOtros = 24
    Dim minSinopsis = 18
    Dim anchoMin = 480
    Dim cargado = False
    Private Sub Ventana_InfoLibro_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        cargado = True
    End Sub

    Private Sub Ventana_InfoLibro_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If cargado Then
            Dim tamañoFuenteTitulo = (minTitulo * Me.Size.Width) / anchoMin
            Dim tamañoFuenteOtros = (minOtros * Me.Size.Width) / anchoMin
            Dim tamañoFuenteSinopsis = (minSinopsis * Me.Size.Width) / anchoMin
            Dim fuenteTitulo As New Font("Gabriola", IIf(tamañoFuenteTitulo < minTitulo, minTitulo, IIf(tamañoFuenteTitulo > minTitulo * 2, minTitulo * 2, tamañoFuenteTitulo)))
            lTitulo.Font = fuenteTitulo
            Dim fuenteOtros As New Font("Gabriola", IIf(tamañoFuenteOtros < minOtros, minOtros, IIf(tamañoFuenteOtros > minOtros * 2, minOtros * 2, tamañoFuenteOtros)))
            lAutor.Font = fuenteOtros
            lAño.Font = fuenteOtros
            Dim fuenteSinopsis As New Font("Gabriola", IIf(tamañoFuenteSinopsis < minSinopsis, minSinopsis, IIf(tamañoFuenteSinopsis > minSinopsis * 2, minSinopsis * 2, tamañoFuenteSinopsis)))
            tbSinopsis.Font = fuenteSinopsis
        End If
    End Sub
End Class