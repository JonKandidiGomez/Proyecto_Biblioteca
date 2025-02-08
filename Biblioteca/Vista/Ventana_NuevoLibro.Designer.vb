<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventana_NuevoLibro
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
        Me.tlpPrincipal = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpDatos = New System.Windows.Forms.TableLayoutPanel()
        Me.tbTitulo = New System.Windows.Forms.TextBox()
        Me.lTitulo = New System.Windows.Forms.Label()
        Me.lSinopsis = New System.Windows.Forms.Label()
        Me.lAutor = New System.Windows.Forms.Label()
        Me.tbAutor = New System.Windows.Forms.TextBox()
        Me.lAño = New System.Windows.Forms.Label()
        Me.tbAño = New System.Windows.Forms.TextBox()
        Me.tbSinopsis = New System.Windows.Forms.RichTextBox()
        Me.bGuardar = New System.Windows.Forms.Button()
        Me.bLimpiar = New System.Windows.Forms.Button()
        Me.tlpPrincipal.SuspendLayout()
        Me.tlpDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpPrincipal
        '
        Me.tlpPrincipal.ColumnCount = 3
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpPrincipal.Controls.Add(Me.tlpDatos, 0, 0)
        Me.tlpPrincipal.Controls.Add(Me.bGuardar, 2, 1)
        Me.tlpPrincipal.Controls.Add(Me.bLimpiar, 1, 1)
        Me.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.tlpPrincipal.Name = "tlpPrincipal"
        Me.tlpPrincipal.Padding = New System.Windows.Forms.Padding(10)
        Me.tlpPrincipal.RowCount = 2
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpPrincipal.Size = New System.Drawing.Size(349, 261)
        Me.tlpPrincipal.TabIndex = 1
        '
        'tlpDatos
        '
        Me.tlpDatos.ColumnCount = 4
        Me.tlpPrincipal.SetColumnSpan(Me.tlpDatos, 3)
        Me.tlpDatos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpDatos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tlpDatos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpDatos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tlpDatos.Controls.Add(Me.tbTitulo, 1, 0)
        Me.tlpDatos.Controls.Add(Me.lTitulo, 0, 0)
        Me.tlpDatos.Controls.Add(Me.lSinopsis, 0, 2)
        Me.tlpDatos.Controls.Add(Me.lAutor, 0, 1)
        Me.tlpDatos.Controls.Add(Me.tbAutor, 1, 1)
        Me.tlpDatos.Controls.Add(Me.lAño, 2, 1)
        Me.tlpDatos.Controls.Add(Me.tbAño, 3, 1)
        Me.tlpDatos.Controls.Add(Me.tbSinopsis, 0, 3)
        Me.tlpDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpDatos.Font = New System.Drawing.Font("Miriam Libre", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlpDatos.Location = New System.Drawing.Point(13, 13)
        Me.tlpDatos.Name = "tlpDatos"
        Me.tlpDatos.Padding = New System.Windows.Forms.Padding(20, 0, 20, 5)
        Me.tlpDatos.RowCount = 4
        Me.tlpDatos.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpDatos.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpDatos.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpDatos.Size = New System.Drawing.Size(323, 203)
        Me.tlpDatos.TabIndex = 3
        '
        'tbTitulo
        '
        Me.tbTitulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpDatos.SetColumnSpan(Me.tbTitulo, 3)
        Me.tbTitulo.Font = New System.Drawing.Font("Miriam Libre", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTitulo.Location = New System.Drawing.Point(92, 3)
        Me.tbTitulo.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.tbTitulo.Name = "tbTitulo"
        Me.tbTitulo.Size = New System.Drawing.Size(208, 23)
        Me.tbTitulo.TabIndex = 1
        '
        'lTitulo
        '
        Me.lTitulo.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lTitulo.AutoSize = True
        Me.lTitulo.Font = New System.Drawing.Font("Miriam Libre", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTitulo.Location = New System.Drawing.Point(37, 6)
        Me.lTitulo.Name = "lTitulo"
        Me.lTitulo.Size = New System.Drawing.Size(42, 16)
        Me.lTitulo.TabIndex = 0
        Me.lTitulo.Text = "Titulo"
        '
        'lSinopsis
        '
        Me.lSinopsis.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lSinopsis.AutoSize = True
        Me.lSinopsis.Font = New System.Drawing.Font("Miriam Libre", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lSinopsis.Location = New System.Drawing.Point(23, 68)
        Me.lSinopsis.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.lSinopsis.Name = "lSinopsis"
        Me.lSinopsis.Size = New System.Drawing.Size(56, 16)
        Me.lSinopsis.TabIndex = 3
        Me.lSinopsis.Text = "Sinopsis"
        '
        'lAutor
        '
        Me.lAutor.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lAutor.AutoSize = True
        Me.lAutor.Font = New System.Drawing.Font("Miriam Libre", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lAutor.Location = New System.Drawing.Point(40, 35)
        Me.lAutor.Name = "lAutor"
        Me.lAutor.Size = New System.Drawing.Size(39, 16)
        Me.lAutor.TabIndex = 0
        Me.lAutor.Text = "Autor"
        '
        'tbAutor
        '
        Me.tbAutor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbAutor.Font = New System.Drawing.Font("Miriam Libre", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAutor.Location = New System.Drawing.Point(92, 32)
        Me.tbAutor.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.tbAutor.Name = "tbAutor"
        Me.tbAutor.Size = New System.Drawing.Size(75, 23)
        Me.tbAutor.TabIndex = 2
        '
        'lAño
        '
        Me.lAño.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lAño.AutoSize = True
        Me.lAño.Font = New System.Drawing.Font("Miriam Libre", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lAño.Location = New System.Drawing.Point(183, 35)
        Me.lAño.Margin = New System.Windows.Forms.Padding(10, 0, 3, 0)
        Me.lAño.Name = "lAño"
        Me.lAño.Size = New System.Drawing.Size(28, 16)
        Me.lAño.TabIndex = 1
        Me.lAño.Text = "Año"
        '
        'tbAño
        '
        Me.tbAño.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tbAño.Font = New System.Drawing.Font("Miriam Libre", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAño.Location = New System.Drawing.Point(224, 32)
        Me.tbAño.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.tbAño.MaxLength = 4
        Me.tbAño.Name = "tbAño"
        Me.tbAño.Size = New System.Drawing.Size(37, 23)
        Me.tbAño.TabIndex = 3
        '
        'tbSinopsis
        '
        Me.tlpDatos.SetColumnSpan(Me.tbSinopsis, 4)
        Me.tbSinopsis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbSinopsis.Font = New System.Drawing.Font("Miriam Libre", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSinopsis.Location = New System.Drawing.Point(23, 90)
        Me.tbSinopsis.Name = "tbSinopsis"
        Me.tbSinopsis.Size = New System.Drawing.Size(277, 105)
        Me.tbSinopsis.TabIndex = 4
        Me.tbSinopsis.Text = ""
        '
        'bGuardar
        '
        Me.bGuardar.AutoSize = True
        Me.bGuardar.BackColor = System.Drawing.Color.PowderBlue
        Me.bGuardar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bGuardar.Font = New System.Drawing.Font("Miriam Libre", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bGuardar.Location = New System.Drawing.Point(261, 222)
        Me.bGuardar.Name = "bGuardar"
        Me.bGuardar.Size = New System.Drawing.Size(75, 26)
        Me.bGuardar.TabIndex = 1
        Me.bGuardar.Text = "Guardar"
        Me.bGuardar.UseVisualStyleBackColor = False
        '
        'bLimpiar
        '
        Me.bLimpiar.AutoSize = True
        Me.bLimpiar.BackColor = System.Drawing.Color.PowderBlue
        Me.bLimpiar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bLimpiar.Font = New System.Drawing.Font("Miriam Libre", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bLimpiar.Location = New System.Drawing.Point(180, 222)
        Me.bLimpiar.Name = "bLimpiar"
        Me.bLimpiar.Size = New System.Drawing.Size(75, 26)
        Me.bLimpiar.TabIndex = 2
        Me.bLimpiar.Text = "Limpiar"
        Me.bLimpiar.UseVisualStyleBackColor = False
        '
        'Ventana_NuevoLibro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(349, 261)
        Me.Controls.Add(Me.tlpPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Ventana_NuevoLibro"
        Me.Text = "Ventana_NuevoLibro"
        Me.tlpPrincipal.ResumeLayout(False)
        Me.tlpPrincipal.PerformLayout()
        Me.tlpDatos.ResumeLayout(False)
        Me.tlpDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpPrincipal As TableLayoutPanel
    Friend WithEvents bGuardar As Button
    Friend WithEvents bLimpiar As Button
    Friend WithEvents tlpDatos As TableLayoutPanel
    Friend WithEvents tbTitulo As TextBox
    Friend WithEvents lTitulo As Label
    Friend WithEvents lSinopsis As Label
    Friend WithEvents lAutor As Label
    Friend WithEvents tbAutor As TextBox
    Friend WithEvents lAño As Label
    Friend WithEvents tbAño As TextBox
    Friend WithEvents tbSinopsis As RichTextBox
End Class
