<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResumenPerfilYCuentaModule
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelNombreCompleto = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelRfc = New System.Windows.Forms.Label()
        Me.LabelCurp = New System.Windows.Forms.Label()
        Me.LabelGenero = New System.Windows.Forms.Label()
        Me.LabelPaisNacimiento = New System.Windows.Forms.Label()
        Me.LabelFechaNacimiento = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.LabelNombreCompleto, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 165.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(410, 213)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'LabelNombreCompleto
        '
        Me.LabelNombreCompleto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelNombreCompleto.Font = New System.Drawing.Font("Corbel", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombreCompleto.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LabelNombreCompleto.Location = New System.Drawing.Point(3, 0)
        Me.LabelNombreCompleto.Name = "LabelNombreCompleto"
        Me.LabelNombreCompleto.Size = New System.Drawing.Size(404, 45)
        Me.LabelNombreCompleto.TabIndex = 1
        Me.LabelNombreCompleto.Text = "Apellido Paterno - Apellido Materno, Nombre"
        Me.LabelNombreCompleto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.LabelRfc, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelCurp, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelGenero, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelPaisNacimiento, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelFechaNacimiento, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 0, 4)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 48)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(404, 159)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'LabelRfc
        '
        Me.LabelRfc.AutoSize = True
        Me.LabelRfc.BackColor = System.Drawing.Color.Transparent
        Me.LabelRfc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelRfc.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRfc.ForeColor = System.Drawing.Color.SteelBlue
        Me.LabelRfc.Location = New System.Drawing.Point(205, 124)
        Me.LabelRfc.Name = "LabelRfc"
        Me.LabelRfc.Size = New System.Drawing.Size(196, 35)
        Me.LabelRfc.TabIndex = 9
        Me.LabelRfc.Text = "Rfc"
        Me.LabelRfc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelCurp
        '
        Me.LabelCurp.AutoSize = True
        Me.LabelCurp.BackColor = System.Drawing.Color.Transparent
        Me.LabelCurp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelCurp.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCurp.ForeColor = System.Drawing.Color.SteelBlue
        Me.LabelCurp.Location = New System.Drawing.Point(205, 93)
        Me.LabelCurp.Name = "LabelCurp"
        Me.LabelCurp.Size = New System.Drawing.Size(196, 31)
        Me.LabelCurp.TabIndex = 8
        Me.LabelCurp.Text = "Curp"
        Me.LabelCurp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelGenero
        '
        Me.LabelGenero.AutoSize = True
        Me.LabelGenero.BackColor = System.Drawing.Color.Transparent
        Me.LabelGenero.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelGenero.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGenero.ForeColor = System.Drawing.Color.SteelBlue
        Me.LabelGenero.Location = New System.Drawing.Point(205, 62)
        Me.LabelGenero.Name = "LabelGenero"
        Me.LabelGenero.Size = New System.Drawing.Size(196, 31)
        Me.LabelGenero.TabIndex = 7
        Me.LabelGenero.Text = "Genero"
        Me.LabelGenero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelPaisNacimiento
        '
        Me.LabelPaisNacimiento.AutoSize = True
        Me.LabelPaisNacimiento.BackColor = System.Drawing.Color.Transparent
        Me.LabelPaisNacimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelPaisNacimiento.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPaisNacimiento.ForeColor = System.Drawing.Color.SteelBlue
        Me.LabelPaisNacimiento.Location = New System.Drawing.Point(205, 31)
        Me.LabelPaisNacimiento.Name = "LabelPaisNacimiento"
        Me.LabelPaisNacimiento.Size = New System.Drawing.Size(196, 31)
        Me.LabelPaisNacimiento.TabIndex = 6
        Me.LabelPaisNacimiento.Text = "PaisNacimiento"
        Me.LabelPaisNacimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelFechaNacimiento
        '
        Me.LabelFechaNacimiento.AutoSize = True
        Me.LabelFechaNacimiento.BackColor = System.Drawing.Color.Transparent
        Me.LabelFechaNacimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelFechaNacimiento.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFechaNacimiento.ForeColor = System.Drawing.Color.SteelBlue
        Me.LabelFechaNacimiento.Location = New System.Drawing.Point(205, 0)
        Me.LabelFechaNacimiento.Name = "LabelFechaNacimiento"
        Me.LabelFechaNacimiento.Size = New System.Drawing.Size(196, 31)
        Me.LabelFechaNacimiento.TabIndex = 5
        Me.LabelFechaNacimiento.Text = "FechaNacimiento"
        Me.LabelFechaNacimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(196, 31)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Fecha de nacimiento"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(196, 31)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Pais de nacimiento"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(196, 31)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Genero"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(196, 31)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "CURP"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(196, 35)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "RFC"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ResumenPerfilYCuentaModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "ResumenPerfilYCuentaModule"
        Me.Size = New System.Drawing.Size(410, 213)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LabelNombreCompleto As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents LabelRfc As Label
    Friend WithEvents LabelCurp As Label
    Friend WithEvents LabelGenero As Label
    Friend WithEvents LabelPaisNacimiento As Label
    Friend WithEvents LabelFechaNacimiento As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
