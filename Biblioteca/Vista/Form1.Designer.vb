<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.msBarraNav = New System.Windows.Forms.MenuStrip()
        Me.BibliotecaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrestamosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.msBarraNav.SuspendLayout()
        Me.SuspendLayout()
        '
        'msBarraNav
        '
        Me.msBarraNav.BackColor = System.Drawing.Color.PowderBlue
        Me.msBarraNav.Font = New System.Drawing.Font("Miriam Libre", 12.0!, System.Drawing.FontStyle.Bold)
        Me.msBarraNav.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.msBarraNav.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BibliotecaToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.PrestamosToolStripMenuItem})
        Me.msBarraNav.Location = New System.Drawing.Point(0, 0)
        Me.msBarraNav.Name = "msBarraNav"
        Me.msBarraNav.Padding = New System.Windows.Forms.Padding(3, 1, 0, 1)
        Me.msBarraNav.Size = New System.Drawing.Size(484, 27)
        Me.msBarraNav.TabIndex = 0
        Me.msBarraNav.Text = "MenuStrip1"
        '
        'BibliotecaToolStripMenuItem
        '
        Me.BibliotecaToolStripMenuItem.Name = "BibliotecaToolStripMenuItem"
        Me.BibliotecaToolStripMenuItem.Size = New System.Drawing.Size(102, 25)
        Me.BibliotecaToolStripMenuItem.Text = "Biblioteca"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(91, 25)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'PrestamosToolStripMenuItem
        '
        Me.PrestamosToolStripMenuItem.Name = "PrestamosToolStripMenuItem"
        Me.PrestamosToolStripMenuItem.Size = New System.Drawing.Size(105, 25)
        Me.PrestamosToolStripMenuItem.Text = "Prestamos"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.msBarraNav)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.msBarraNav
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(500, 500)
        Me.Name = "Form1"
        Me.Text = "Biblioteca"
        Me.msBarraNav.ResumeLayout(False)
        Me.msBarraNav.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents msBarraNav As MenuStrip
    Friend WithEvents BibliotecaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrestamosToolStripMenuItem As ToolStripMenuItem
End Class
