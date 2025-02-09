<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ventana_Libros
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tlpPrincipal = New System.Windows.Forms.TableLayoutPanel()
        Me.bNuevoLibro = New System.Windows.Forms.Button()
        Me.flpLibros = New System.Windows.Forms.FlowLayoutPanel()
        Me.tlpPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpPrincipal
        '
        Me.tlpPrincipal.ColumnCount = 1
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPrincipal.Controls.Add(Me.bNuevoLibro, 0, 1)
        Me.tlpPrincipal.Controls.Add(Me.flpLibros, 0, 0)
        Me.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.tlpPrincipal.Name = "tlpPrincipal"
        Me.tlpPrincipal.RowCount = 2
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpPrincipal.Size = New System.Drawing.Size(296, 302)
        Me.tlpPrincipal.TabIndex = 0
        '
        'bNuevoLibro
        '
        Me.bNuevoLibro.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bNuevoLibro.AutoSize = True
        Me.bNuevoLibro.BackColor = System.Drawing.Color.PowderBlue
        Me.bNuevoLibro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bNuevoLibro.Font = New System.Drawing.Font("Miriam Libre", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bNuevoLibro.Location = New System.Drawing.Point(186, 257)
        Me.bNuevoLibro.Margin = New System.Windows.Forms.Padding(10)
        Me.bNuevoLibro.Name = "bNuevoLibro"
        Me.bNuevoLibro.Size = New System.Drawing.Size(100, 35)
        Me.bNuevoLibro.TabIndex = 0
        Me.bNuevoLibro.Text = "Nuevo libro"
        Me.bNuevoLibro.UseVisualStyleBackColor = False
        '
        'flpLibros
        '
        Me.flpLibros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flpLibros.AutoScroll = True
        Me.flpLibros.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpLibros.Location = New System.Drawing.Point(3, 3)
        Me.flpLibros.Name = "flpLibros"
        Me.flpLibros.Size = New System.Drawing.Size(290, 241)
        Me.flpLibros.TabIndex = 1
        Me.flpLibros.WrapContents = False
        '
        'Ventana_Libros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(296, 302)
        Me.Controls.Add(Me.tlpPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Ventana_Libros"
        Me.Text = "Ventana_Libros"
        Me.tlpPrincipal.ResumeLayout(False)
        Me.tlpPrincipal.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpPrincipal As TableLayoutPanel
    Friend WithEvents bNuevoLibro As Button
    Friend WithEvents flpLibros As FlowLayoutPanel
End Class
