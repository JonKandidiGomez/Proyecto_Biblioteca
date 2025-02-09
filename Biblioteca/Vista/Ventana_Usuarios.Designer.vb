<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventana_Usuarios
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
        Me.bNuevoUsuario = New System.Windows.Forms.Button()
        Me.bEditarUsuario = New System.Windows.Forms.Button()
        Me.bBorrarUsuario = New System.Windows.Forms.Button()
        Me.tlpDatos = New System.Windows.Forms.TableLayoutPanel()
        Me.lUsuarios = New System.Windows.Forms.Label()
        Me.lNombre = New System.Windows.Forms.Label()
        Me.lPrimerApellido = New System.Windows.Forms.Label()
        Me.lSegundoApellido = New System.Windows.Forms.Label()
        Me.lTelefono = New System.Windows.Forms.Label()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.tbPrimerApellido = New System.Windows.Forms.TextBox()
        Me.tbSegundoApellido = New System.Windows.Forms.TextBox()
        Me.tbTelefono = New System.Windows.Forms.TextBox()
        Me.lbUsuarios = New System.Windows.Forms.ListBox()
        Me.tlpPrincipal.SuspendLayout()
        Me.tlpDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpPrincipal
        '
        Me.tlpPrincipal.ColumnCount = 4
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpPrincipal.Controls.Add(Me.bNuevoUsuario, 1, 1)
        Me.tlpPrincipal.Controls.Add(Me.bEditarUsuario, 2, 1)
        Me.tlpPrincipal.Controls.Add(Me.bBorrarUsuario, 3, 1)
        Me.tlpPrincipal.Controls.Add(Me.tlpDatos, 0, 0)
        Me.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.tlpPrincipal.Margin = New System.Windows.Forms.Padding(10)
        Me.tlpPrincipal.Name = "tlpPrincipal"
        Me.tlpPrincipal.Padding = New System.Windows.Forms.Padding(10)
        Me.tlpPrincipal.RowCount = 2
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpPrincipal.Size = New System.Drawing.Size(477, 457)
        Me.tlpPrincipal.TabIndex = 0
        '
        'bNuevoUsuario
        '
        Me.bNuevoUsuario.AutoSize = True
        Me.bNuevoUsuario.BackColor = System.Drawing.Color.PowderBlue
        Me.bNuevoUsuario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bNuevoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bNuevoUsuario.Font = New System.Drawing.Font("Miriam Libre", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bNuevoUsuario.Location = New System.Drawing.Point(90, 408)
        Me.bNuevoUsuario.Name = "bNuevoUsuario"
        Me.bNuevoUsuario.Size = New System.Drawing.Size(120, 36)
        Me.bNuevoUsuario.TabIndex = 0
        Me.bNuevoUsuario.Text = "Nuevo Usuario"
        Me.bNuevoUsuario.UseVisualStyleBackColor = False
        '
        'bEditarUsuario
        '
        Me.bEditarUsuario.AutoSize = True
        Me.bEditarUsuario.BackColor = System.Drawing.Color.PowderBlue
        Me.bEditarUsuario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bEditarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bEditarUsuario.Font = New System.Drawing.Font("Miriam Libre", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bEditarUsuario.Location = New System.Drawing.Point(216, 408)
        Me.bEditarUsuario.Name = "bEditarUsuario"
        Me.bEditarUsuario.Size = New System.Drawing.Size(121, 36)
        Me.bEditarUsuario.TabIndex = 1
        Me.bEditarUsuario.Text = "Editar usuario"
        Me.bEditarUsuario.UseVisualStyleBackColor = False
        '
        'bBorrarUsuario
        '
        Me.bBorrarUsuario.AutoSize = True
        Me.bBorrarUsuario.BackColor = System.Drawing.Color.PowderBlue
        Me.bBorrarUsuario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bBorrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bBorrarUsuario.Font = New System.Drawing.Font("Miriam Libre", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bBorrarUsuario.Location = New System.Drawing.Point(343, 408)
        Me.bBorrarUsuario.Name = "bBorrarUsuario"
        Me.bBorrarUsuario.Size = New System.Drawing.Size(121, 36)
        Me.bBorrarUsuario.TabIndex = 2
        Me.bBorrarUsuario.Text = "Borrar usuario"
        Me.bBorrarUsuario.UseVisualStyleBackColor = False
        '
        'tlpDatos
        '
        Me.tlpDatos.ColumnCount = 3
        Me.tlpPrincipal.SetColumnSpan(Me.tlpDatos, 4)
        Me.tlpDatos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99999!))
        Me.tlpDatos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpDatos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001!))
        Me.tlpDatos.Controls.Add(Me.lUsuarios, 0, 1)
        Me.tlpDatos.Controls.Add(Me.lNombre, 1, 2)
        Me.tlpDatos.Controls.Add(Me.lPrimerApellido, 1, 3)
        Me.tlpDatos.Controls.Add(Me.lSegundoApellido, 1, 4)
        Me.tlpDatos.Controls.Add(Me.lTelefono, 1, 5)
        Me.tlpDatos.Controls.Add(Me.tbNombre, 2, 2)
        Me.tlpDatos.Controls.Add(Me.tbPrimerApellido, 2, 3)
        Me.tlpDatos.Controls.Add(Me.tbSegundoApellido, 2, 4)
        Me.tlpDatos.Controls.Add(Me.tbTelefono, 2, 5)
        Me.tlpDatos.Controls.Add(Me.lbUsuarios, 0, 2)
        Me.tlpDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpDatos.Location = New System.Drawing.Point(13, 13)
        Me.tlpDatos.Name = "tlpDatos"
        Me.tlpDatos.RowCount = 7
        Me.tlpDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpDatos.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpDatos.Size = New System.Drawing.Size(451, 389)
        Me.tlpDatos.TabIndex = 3
        '
        'lUsuarios
        '
        Me.lUsuarios.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lUsuarios.AutoSize = True
        Me.lUsuarios.Font = New System.Drawing.Font("Miriam Libre", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lUsuarios.Location = New System.Drawing.Point(3, 36)
        Me.lUsuarios.Name = "lUsuarios"
        Me.lUsuarios.Size = New System.Drawing.Size(79, 21)
        Me.lUsuarios.TabIndex = 0
        Me.lUsuarios.Text = "Usuarios"
        '
        'lNombre
        '
        Me.lNombre.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lNombre.AutoSize = True
        Me.lNombre.Font = New System.Drawing.Font("Miriam Libre", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lNombre.Location = New System.Drawing.Point(226, 84)
        Me.lNombre.Name = "lNombre"
        Me.lNombre.Size = New System.Drawing.Size(63, 18)
        Me.lNombre.TabIndex = 2
        Me.lNombre.Text = "Nombre"
        '
        'lPrimerApellido
        '
        Me.lPrimerApellido.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lPrimerApellido.AutoSize = True
        Me.lPrimerApellido.Font = New System.Drawing.Font("Miriam Libre", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lPrimerApellido.Location = New System.Drawing.Point(170, 157)
        Me.lPrimerApellido.Name = "lPrimerApellido"
        Me.lPrimerApellido.Size = New System.Drawing.Size(119, 18)
        Me.lPrimerApellido.TabIndex = 3
        Me.lPrimerApellido.Text = "Primer apellido"
        '
        'lSegundoApellido
        '
        Me.lSegundoApellido.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lSegundoApellido.AutoSize = True
        Me.lSegundoApellido.Font = New System.Drawing.Font("Miriam Libre", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lSegundoApellido.Location = New System.Drawing.Point(160, 230)
        Me.lSegundoApellido.Name = "lSegundoApellido"
        Me.lSegundoApellido.Size = New System.Drawing.Size(129, 18)
        Me.lSegundoApellido.TabIndex = 4
        Me.lSegundoApellido.Text = "Segundo apellido"
        '
        'lTelefono
        '
        Me.lTelefono.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lTelefono.AutoSize = True
        Me.lTelefono.Font = New System.Drawing.Font("Miriam Libre", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTelefono.Location = New System.Drawing.Point(222, 303)
        Me.lTelefono.Name = "lTelefono"
        Me.lTelefono.Size = New System.Drawing.Size(67, 18)
        Me.lTelefono.TabIndex = 5
        Me.lTelefono.Text = "Teléfono"
        '
        'tbNombre
        '
        Me.tbNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbNombre.Font = New System.Drawing.Font("Miriam Libre", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombre.Location = New System.Drawing.Point(295, 81)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(153, 25)
        Me.tbNombre.TabIndex = 6
        '
        'tbPrimerApellido
        '
        Me.tbPrimerApellido.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbPrimerApellido.Font = New System.Drawing.Font("Miriam Libre", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.tbPrimerApellido.Location = New System.Drawing.Point(295, 154)
        Me.tbPrimerApellido.Name = "tbPrimerApellido"
        Me.tbPrimerApellido.Size = New System.Drawing.Size(153, 25)
        Me.tbPrimerApellido.TabIndex = 7
        '
        'tbSegundoApellido
        '
        Me.tbSegundoApellido.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbSegundoApellido.Font = New System.Drawing.Font("Miriam Libre", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSegundoApellido.Location = New System.Drawing.Point(295, 227)
        Me.tbSegundoApellido.Name = "tbSegundoApellido"
        Me.tbSegundoApellido.Size = New System.Drawing.Size(153, 25)
        Me.tbSegundoApellido.TabIndex = 8
        '
        'tbTelefono
        '
        Me.tbTelefono.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbTelefono.Font = New System.Drawing.Font("Miriam Libre", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTelefono.Location = New System.Drawing.Point(295, 300)
        Me.tbTelefono.Name = "tbTelefono"
        Me.tbTelefono.Size = New System.Drawing.Size(153, 25)
        Me.tbTelefono.TabIndex = 9
        '
        'lbUsuarios
        '
        Me.lbUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbUsuarios.Font = New System.Drawing.Font("Miriam Libre", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUsuarios.FormattingEnabled = True
        Me.lbUsuarios.ItemHeight = 17
        Me.lbUsuarios.Location = New System.Drawing.Point(3, 60)
        Me.lbUsuarios.Name = "lbUsuarios"
        Me.tlpDatos.SetRowSpan(Me.lbUsuarios, 4)
        Me.lbUsuarios.Size = New System.Drawing.Size(151, 286)
        Me.lbUsuarios.TabIndex = 10
        '
        'Ventana_Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(477, 457)
        Me.Controls.Add(Me.tlpPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Ventana_Usuarios"
        Me.Text = "Ventana_Usuarios"
        Me.tlpPrincipal.ResumeLayout(False)
        Me.tlpPrincipal.PerformLayout()
        Me.tlpDatos.ResumeLayout(False)
        Me.tlpDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpPrincipal As TableLayoutPanel
    Friend WithEvents bNuevoUsuario As Button
    Friend WithEvents bEditarUsuario As Button
    Friend WithEvents bBorrarUsuario As Button
    Friend WithEvents tlpDatos As TableLayoutPanel
    Friend WithEvents lUsuarios As Label
    Friend WithEvents lNombre As Label
    Friend WithEvents lPrimerApellido As Label
    Friend WithEvents lSegundoApellido As Label
    Friend WithEvents lTelefono As Label
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents tbPrimerApellido As TextBox
    Friend WithEvents tbSegundoApellido As TextBox
    Friend WithEvents tbTelefono As TextBox
    Friend WithEvents lbUsuarios As ListBox
End Class
