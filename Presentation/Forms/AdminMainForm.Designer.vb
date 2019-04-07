<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminMainForm
    Inherits CustomForm

    'Form overrides dispose to clean up the component list.
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
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonChangeLogo = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonChangeColor = New System.Windows.Forms.Button()
        Me.PanelTitle = New System.Windows.Forms.Panel()
        Me.LabelAdministrador = New System.Windows.Forms.Label()
        Me.PictureBoxSignOut = New System.Windows.Forms.PictureBox()
        Me.PanelHeader.SuspendLayout()
        Me.PanelContent.SuspendLayout()
        CType(Me.PictureBoxHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.PanelTitle.SuspendLayout()
        CType(Me.PictureBoxSignOut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelHeader
        '
        Me.PanelHeader.Size = New System.Drawing.Size(1018, 100)
        '
        'PanelContent
        '
        Me.PanelContent.Controls.Add(Me.TableLayoutPanel1)
        Me.PanelContent.Size = New System.Drawing.Size(1018, 611)
        '
        'PictureBoxHeader
        '
        Me.PictureBoxHeader.Size = New System.Drawing.Size(1018, 100)
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.PanelTitle, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBoxSignOut, 0, 5)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1018, 611)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.ButtonChangeLogo, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 178)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1012, 144)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'ButtonChangeLogo
        '
        Me.ButtonChangeLogo.BackColor = System.Drawing.Color.SteelBlue
        Me.ButtonChangeLogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonChangeLogo.Font = New System.Drawing.Font("Corbel", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonChangeLogo.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonChangeLogo.Location = New System.Drawing.Point(384, 35)
        Me.ButtonChangeLogo.Margin = New System.Windows.Forms.Padding(3, 35, 3, 35)
        Me.ButtonChangeLogo.Name = "ButtonChangeLogo"
        Me.ButtonChangeLogo.Size = New System.Drawing.Size(244, 74)
        Me.ButtonChangeLogo.TabIndex = 1
        Me.ButtonChangeLogo.Text = "Cambiar logo"
        Me.ButtonChangeLogo.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.ButtonChangeColor, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 328)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1012, 144)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'ButtonChangeColor
        '
        Me.ButtonChangeColor.BackColor = System.Drawing.Color.SteelBlue
        Me.ButtonChangeColor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonChangeColor.Font = New System.Drawing.Font("Corbel", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonChangeColor.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonChangeColor.Location = New System.Drawing.Point(384, 35)
        Me.ButtonChangeColor.Margin = New System.Windows.Forms.Padding(3, 35, 3, 35)
        Me.ButtonChangeColor.Name = "ButtonChangeColor"
        Me.ButtonChangeColor.Size = New System.Drawing.Size(244, 74)
        Me.ButtonChangeColor.TabIndex = 1
        Me.ButtonChangeColor.Text = "Cambiar color"
        Me.ButtonChangeColor.UseVisualStyleBackColor = False
        '
        'PanelTitle
        '
        Me.PanelTitle.BackColor = System.Drawing.Color.MidnightBlue
        Me.PanelTitle.Controls.Add(Me.LabelAdministrador)
        Me.PanelTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelTitle.Location = New System.Drawing.Point(3, 3)
        Me.PanelTitle.Name = "PanelTitle"
        Me.PanelTitle.Size = New System.Drawing.Size(1012, 94)
        Me.PanelTitle.TabIndex = 2
        '
        'LabelAdministrador
        '
        Me.LabelAdministrador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelAdministrador.Font = New System.Drawing.Font("Corbel", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAdministrador.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.LabelAdministrador.Location = New System.Drawing.Point(0, 0)
        Me.LabelAdministrador.Name = "LabelAdministrador"
        Me.LabelAdministrador.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.LabelAdministrador.Size = New System.Drawing.Size(1012, 94)
        Me.LabelAdministrador.TabIndex = 0
        Me.LabelAdministrador.Text = "Bienvenido, Administrador"
        Me.LabelAdministrador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBoxSignOut
        '
        Me.PictureBoxSignOut.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBoxSignOut.Image = Global.Presentation.My.Resources.Resources.iconAsosiationBlack
        Me.PictureBoxSignOut.Location = New System.Drawing.Point(3, 498)
        Me.PictureBoxSignOut.Name = "PictureBoxSignOut"
        Me.PictureBoxSignOut.Size = New System.Drawing.Size(1012, 34)
        Me.PictureBoxSignOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxSignOut.TabIndex = 3
        Me.PictureBoxSignOut.TabStop = False
        '
        'AdminMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 711)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "AdminMainForm"
        Me.Text = "AdminForm"
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelContent.ResumeLayout(False)
        CType(Me.PictureBoxHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.PanelTitle.ResumeLayout(False)
        CType(Me.PictureBoxSignOut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents PanelTitle As Panel
    Friend WithEvents LabelAdministrador As Label
    Friend WithEvents PictureBoxSignOut As PictureBox
    Friend WithEvents ButtonChangeLogo As Button
    Friend WithEvents ButtonChangeColor As Button
End Class
