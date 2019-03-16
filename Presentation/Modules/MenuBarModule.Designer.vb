<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuBarModule
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
        Me.TableLayoutPanelMenuBarItems = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBoxUser = New System.Windows.Forms.PictureBox()
        Me.PictureBoxLogout = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.TableLayoutPanelMenuBarItems.SuspendLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxLogout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanelMenuBarItems
        '
        Me.TableLayoutPanelMenuBarItems.ColumnCount = 5
        Me.TableLayoutPanelMenuBarItems.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelMenuBarItems.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanelMenuBarItems.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanelMenuBarItems.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanelMenuBarItems.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanelMenuBarItems.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelMenuBarItems.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelMenuBarItems.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelMenuBarItems.Controls.Add(Me.PictureBoxUser, 2, 0)
        Me.TableLayoutPanelMenuBarItems.Controls.Add(Me.PictureBoxLogout, 3, 0)
        Me.TableLayoutPanelMenuBarItems.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanelMenuBarItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelMenuBarItems.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelMenuBarItems.Name = "TableLayoutPanelMenuBarItems"
        Me.TableLayoutPanelMenuBarItems.RowCount = 1
        Me.TableLayoutPanelMenuBarItems.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelMenuBarItems.Size = New System.Drawing.Size(1007, 56)
        Me.TableLayoutPanelMenuBarItems.TabIndex = 0
        '
        'PictureBoxUser
        '
        Me.PictureBoxUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBoxUser.Image = Global.Presentation.My.Resources.Resources.iconUser
        Me.PictureBoxUser.Location = New System.Drawing.Point(880, 3)
        Me.PictureBoxUser.Name = "PictureBoxUser"
        Me.PictureBoxUser.Size = New System.Drawing.Size(54, 50)
        Me.PictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxUser.TabIndex = 1
        Me.PictureBoxUser.TabStop = False
        '
        'PictureBoxLogout
        '
        Me.PictureBoxLogout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBoxLogout.Image = Global.Presentation.My.Resources.Resources.iconLogout
        Me.PictureBoxLogout.Location = New System.Drawing.Point(940, 3)
        Me.PictureBoxLogout.Name = "PictureBoxLogout"
        Me.PictureBoxLogout.Size = New System.Drawing.Size(54, 50)
        Me.PictureBoxLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxLogout.TabIndex = 2
        Me.PictureBoxLogout.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LabelNombre)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(680, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(194, 50)
        Me.Panel2.TabIndex = 4
        '
        'LabelNombre
        '
        Me.LabelNombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelNombre.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombre.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.LabelNombre.Location = New System.Drawing.Point(0, 0)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(194, 50)
        Me.LabelNombre.TabIndex = 0
        Me.LabelNombre.Text = "Nombre de usuario"
        Me.LabelNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MenuBarModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.Controls.Add(Me.TableLayoutPanelMenuBarItems)
        Me.Name = "MenuBarModule"
        Me.Size = New System.Drawing.Size(1007, 56)
        Me.TableLayoutPanelMenuBarItems.ResumeLayout(False)
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxLogout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanelMenuBarItems As TableLayoutPanel
    Friend WithEvents PictureBoxUser As PictureBox
    Friend WithEvents PictureBoxLogout As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LabelNombre As Label
End Class
