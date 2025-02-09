<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventana_Prestamos
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
        Me.lUsuarios = New System.Windows.Forms.Label()
        Me.lLibros = New System.Windows.Forms.Label()
        Me.tlpBotones = New System.Windows.Forms.TableLayoutPanel()
        Me.bGuardar = New System.Windows.Forms.Button()
        Me.bNuevoPrestamo = New System.Windows.Forms.Button()
        Me.bDevolucion = New System.Windows.Forms.Button()
        Me.bVolver = New System.Windows.Forms.Button()
        Me.lbUsuarios = New System.Windows.Forms.ListBox()
        Me.lbLibros = New System.Windows.Forms.ListBox()
        Me.lFecha = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.tlpPrincipal.SuspendLayout()
        Me.tlpBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpPrincipal
        '
        Me.tlpPrincipal.ColumnCount = 6
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpPrincipal.Controls.Add(Me.lUsuarios, 1, 1)
        Me.tlpPrincipal.Controls.Add(Me.lLibros, 3, 1)
        Me.tlpPrincipal.Controls.Add(Me.tlpBotones, 1, 4)
        Me.tlpPrincipal.Controls.Add(Me.lbUsuarios, 1, 2)
        Me.tlpPrincipal.Controls.Add(Me.lbLibros, 3, 2)
        Me.tlpPrincipal.Controls.Add(Me.dtpFecha, 4, 3)
        Me.tlpPrincipal.Controls.Add(Me.lFecha, 1, 3)
        Me.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.tlpPrincipal.Name = "tlpPrincipal"
        Me.tlpPrincipal.RowCount = 6
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpPrincipal.Size = New System.Drawing.Size(397, 435)
        Me.tlpPrincipal.TabIndex = 0
        '
        'lUsuarios
        '
        Me.lUsuarios.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lUsuarios.AutoSize = True
        Me.lUsuarios.Font = New System.Drawing.Font("Miriam Libre", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lUsuarios.Location = New System.Drawing.Point(33, 20)
        Me.lUsuarios.Name = "lUsuarios"
        Me.lUsuarios.Size = New System.Drawing.Size(79, 21)
        Me.lUsuarios.TabIndex = 0
        Me.lUsuarios.Text = "Usuarios"
        '
        'lLibros
        '
        Me.lLibros.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lLibros.AutoSize = True
        Me.tlpPrincipal.SetColumnSpan(Me.lLibros, 2)
        Me.lLibros.Font = New System.Drawing.Font("Miriam Libre", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lLibros.Location = New System.Drawing.Point(199, 20)
        Me.lLibros.Name = "lLibros"
        Me.lLibros.Size = New System.Drawing.Size(93, 21)
        Me.lLibros.TabIndex = 1
        Me.lLibros.Text = "Prestamos"
        '
        'tlpBotones
        '
        Me.tlpBotones.ColumnCount = 4
        Me.tlpPrincipal.SetColumnSpan(Me.tlpBotones, 4)
        Me.tlpBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpBotones.Controls.Add(Me.bGuardar, 3, 0)
        Me.tlpBotones.Controls.Add(Me.bNuevoPrestamo, 2, 0)
        Me.tlpBotones.Controls.Add(Me.bDevolucion, 1, 0)
        Me.tlpBotones.Controls.Add(Me.bVolver, 0, 0)
        Me.tlpBotones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpBotones.Location = New System.Drawing.Point(30, 344)
        Me.tlpBotones.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpBotones.MinimumSize = New System.Drawing.Size(0, 30)
        Me.tlpBotones.Name = "tlpBotones"
        Me.tlpBotones.RowCount = 1
        Me.tlpBotones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpBotones.Size = New System.Drawing.Size(302, 43)
        Me.tlpBotones.TabIndex = 4
        '
        'bGuardar
        '
        Me.bGuardar.BackColor = System.Drawing.Color.PowderBlue
        Me.bGuardar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bGuardar.Font = New System.Drawing.Font("Miriam Libre", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bGuardar.Location = New System.Drawing.Point(228, 3)
        Me.bGuardar.MinimumSize = New System.Drawing.Size(94, 44)
        Me.bGuardar.Name = "bGuardar"
        Me.bGuardar.Size = New System.Drawing.Size(94, 44)
        Me.bGuardar.TabIndex = 0
        Me.bGuardar.Text = "Guardar"
        Me.bGuardar.UseVisualStyleBackColor = False
        Me.bGuardar.Visible = False
        '
        'bNuevoPrestamo
        '
        Me.bNuevoPrestamo.AutoSize = True
        Me.bNuevoPrestamo.BackColor = System.Drawing.Color.PowderBlue
        Me.bNuevoPrestamo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bNuevoPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bNuevoPrestamo.Font = New System.Drawing.Font("Miriam Libre", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bNuevoPrestamo.Location = New System.Drawing.Point(153, 3)
        Me.bNuevoPrestamo.MinimumSize = New System.Drawing.Size(94, 44)
        Me.bNuevoPrestamo.Name = "bNuevoPrestamo"
        Me.bNuevoPrestamo.Size = New System.Drawing.Size(94, 44)
        Me.bNuevoPrestamo.TabIndex = 1
        Me.bNuevoPrestamo.Text = "Nuevo prestamo"
        Me.bNuevoPrestamo.UseVisualStyleBackColor = False
        '
        'bDevolucion
        '
        Me.bDevolucion.BackColor = System.Drawing.Color.PowderBlue
        Me.bDevolucion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bDevolucion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bDevolucion.Font = New System.Drawing.Font("Miriam Libre", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bDevolucion.Location = New System.Drawing.Point(78, 3)
        Me.bDevolucion.MinimumSize = New System.Drawing.Size(94, 44)
        Me.bDevolucion.Name = "bDevolucion"
        Me.bDevolucion.Size = New System.Drawing.Size(94, 44)
        Me.bDevolucion.TabIndex = 2
        Me.bDevolucion.Text = "Devolución"
        Me.bDevolucion.UseVisualStyleBackColor = False
        '
        'bVolver
        '
        Me.bVolver.BackColor = System.Drawing.Color.PowderBlue
        Me.bVolver.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bVolver.Font = New System.Drawing.Font("Miriam Libre", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bVolver.Location = New System.Drawing.Point(3, 3)
        Me.bVolver.MinimumSize = New System.Drawing.Size(94, 44)
        Me.bVolver.Name = "bVolver"
        Me.bVolver.Size = New System.Drawing.Size(94, 44)
        Me.bVolver.TabIndex = 3
        Me.bVolver.Text = "Volver"
        Me.bVolver.UseVisualStyleBackColor = False
        Me.bVolver.Visible = False
        '
        'lbUsuarios
        '
        Me.lbUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbUsuarios.Font = New System.Drawing.Font("Miriam Libre", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUsuarios.FormattingEnabled = True
        Me.lbUsuarios.ItemHeight = 17
        Me.lbUsuarios.Location = New System.Drawing.Point(33, 44)
        Me.lbUsuarios.Name = "lbUsuarios"
        Me.lbUsuarios.Size = New System.Drawing.Size(130, 241)
        Me.lbUsuarios.TabIndex = 5
        '
        'lbLibros
        '
        Me.tlpPrincipal.SetColumnSpan(Me.lbLibros, 2)
        Me.lbLibros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbLibros.Font = New System.Drawing.Font("Miriam Libre", 9.749998!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLibros.FormattingEnabled = True
        Me.lbLibros.ItemHeight = 17
        Me.lbLibros.Location = New System.Drawing.Point(199, 44)
        Me.lbLibros.Name = "lbLibros"
        Me.lbLibros.Size = New System.Drawing.Size(130, 241)
        Me.lbLibros.TabIndex = 6
        '
        'lFecha
        '
        Me.lFecha.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lFecha.AutoSize = True
        Me.tlpPrincipal.SetColumnSpan(Me.lFecha, 3)
        Me.lFecha.Font = New System.Drawing.Font("Miriam Libre", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lFecha.Location = New System.Drawing.Point(176, 298)
        Me.lFecha.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.lFecha.Name = "lFecha"
        Me.lFecha.Size = New System.Drawing.Size(85, 36)
        Me.lFecha.TabIndex = 8
        Me.lFecha.Text = "Fecha de devolución"
        Me.lFecha.Visible = False
        '
        'dtpFecha
        '
        Me.dtpFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFecha.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpFecha.Font = New System.Drawing.Font("Miriam Libre", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(267, 303)
        Me.dtpFecha.MaxDate = New Date(2025, 12, 31, 0, 0, 0, 0)
        Me.dtpFecha.MinDate = New Date(2025, 2, 8, 19, 42, 14, 0)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(62, 25)
        Me.dtpFecha.TabIndex = 10
        Me.dtpFecha.Value = New Date(2025, 2, 22, 0, 0, 0, 0)
        Me.dtpFecha.Visible = False
        '
        'Ventana_Prestamos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(397, 435)
        Me.Controls.Add(Me.tlpPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Ventana_Prestamos"
        Me.Text = "Ventana_Prestamos"
        Me.tlpPrincipal.ResumeLayout(False)
        Me.tlpPrincipal.PerformLayout()
        Me.tlpBotones.ResumeLayout(False)
        Me.tlpBotones.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpPrincipal As TableLayoutPanel
    Friend WithEvents lUsuarios As Label
    Friend WithEvents lLibros As Label
    Friend WithEvents tlpBotones As TableLayoutPanel
    Friend WithEvents bGuardar As Button
    Friend WithEvents bNuevoPrestamo As Button
    Friend WithEvents bDevolucion As Button
    Friend WithEvents lbUsuarios As ListBox
    Friend WithEvents lbLibros As ListBox
    Friend WithEvents lFecha As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents bVolver As Button
End Class
