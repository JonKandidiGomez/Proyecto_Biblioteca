<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventana_InfoLibro
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ventana_InfoLibro))
        Me.tlpPrincipal = New System.Windows.Forms.TableLayoutPanel()
        Me.lTitulo = New System.Windows.Forms.Label()
        Me.lAutor = New System.Windows.Forms.Label()
        Me.lAño = New System.Windows.Forms.Label()
        Me.tbSinopsis = New System.Windows.Forms.RichTextBox()
        Me.tlpPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpPrincipal
        '
        Me.tlpPrincipal.ColumnCount = 2
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpPrincipal.Controls.Add(Me.lTitulo, 0, 0)
        Me.tlpPrincipal.Controls.Add(Me.lAutor, 0, 1)
        Me.tlpPrincipal.Controls.Add(Me.lAño, 1, 1)
        Me.tlpPrincipal.Controls.Add(Me.tbSinopsis, 0, 2)
        Me.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.tlpPrincipal.Name = "tlpPrincipal"
        Me.tlpPrincipal.RowCount = 3
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPrincipal.Size = New System.Drawing.Size(355, 345)
        Me.tlpPrincipal.TabIndex = 0
        '
        'lTitulo
        '
        Me.lTitulo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lTitulo.AutoSize = True
        Me.tlpPrincipal.SetColumnSpan(Me.lTitulo, 2)
        Me.lTitulo.Font = New System.Drawing.Font("Gabriola", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTitulo.Location = New System.Drawing.Point(40, 0)
        Me.lTitulo.Margin = New System.Windows.Forms.Padding(40, 0, 3, 0)
        Me.lTitulo.Name = "lTitulo"
        Me.lTitulo.Size = New System.Drawing.Size(250, 88)
        Me.lTitulo.TabIndex = 0
        Me.lTitulo.Text = "Titulo del libro"
        '
        'lAutor
        '
        Me.lAutor.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lAutor.AutoSize = True
        Me.lAutor.Font = New System.Drawing.Font("Gabriola", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lAutor.Location = New System.Drawing.Point(40, 88)
        Me.lAutor.Margin = New System.Windows.Forms.Padding(40, 0, 3, 0)
        Me.lAutor.Name = "lAutor"
        Me.lAutor.Size = New System.Drawing.Size(100, 59)
        Me.lAutor.TabIndex = 1
        Me.lAutor.Text = "Escritor"
        '
        'lAño
        '
        Me.lAño.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lAño.AutoSize = True
        Me.lAño.Font = New System.Drawing.Font("Gabriola", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lAño.Location = New System.Drawing.Point(146, 88)
        Me.lAño.Name = "lAño"
        Me.lAño.Size = New System.Drawing.Size(173, 59)
        Me.lAño.TabIndex = 2
        Me.lAño.Text = "Año de edición"
        '
        'tbSinopsis
        '
        Me.tbSinopsis.BackColor = System.Drawing.Color.Azure
        Me.tbSinopsis.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tlpPrincipal.SetColumnSpan(Me.tbSinopsis, 2)
        Me.tbSinopsis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbSinopsis.Enabled = False
        Me.tbSinopsis.Font = New System.Drawing.Font("Gabriola", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSinopsis.Location = New System.Drawing.Point(20, 167)
        Me.tbSinopsis.Margin = New System.Windows.Forms.Padding(20)
        Me.tbSinopsis.Name = "tbSinopsis"
        Me.tbSinopsis.ReadOnly = True
        Me.tbSinopsis.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.tbSinopsis.Size = New System.Drawing.Size(315, 158)
        Me.tbSinopsis.TabIndex = 3
        Me.tbSinopsis.Text = resources.GetString("tbSinopsis.Text")
        '
        'Ventana_InfoLibro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(355, 345)
        Me.Controls.Add(Me.tlpPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Ventana_InfoLibro"
        Me.Text = "Ventana_InfoLibro"
        Me.tlpPrincipal.ResumeLayout(False)
        Me.tlpPrincipal.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpPrincipal As TableLayoutPanel
    Friend WithEvents lTitulo As Label
    Friend WithEvents lAutor As Label
    Friend WithEvents lAño As Label
    Friend WithEvents tbSinopsis As RichTextBox
End Class
