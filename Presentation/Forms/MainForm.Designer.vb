<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits CustomForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuBarModule1 = New Presentation.MenuBarModule()
        Me.SideBarModule1 = New Presentation.SideBarModule()
        Me.PanelSubContent = New System.Windows.Forms.Panel()
        Me.MainMenuModule1 = New Presentation.MainMenuModule()
        Me.PanelSubContentTitle = New System.Windows.Forms.Panel()
        Me.LabelSubContentTitle = New System.Windows.Forms.Label()
        Me.PanelHeader.SuspendLayout()
        Me.PanelContent.SuspendLayout()
        CType(Me.PictureBoxHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSubContent.SuspendLayout()
        Me.PanelSubContentTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelHeader
        '
        Me.PanelHeader.Size = New System.Drawing.Size(1063, 100)
        '
        'PanelContent
        '
        Me.PanelContent.Controls.Add(Me.PanelSubContent)
        Me.PanelContent.Controls.Add(Me.SideBarModule1)
        Me.PanelContent.Controls.Add(Me.MenuBarModule1)
        Me.PanelContent.Size = New System.Drawing.Size(1063, 552)
        '
        'PictureBoxHeader
        '
        Me.PictureBoxHeader.Size = New System.Drawing.Size(1063, 100)
        '
        'MenuBarModule1
        '
        Me.MenuBarModule1.BackColor = System.Drawing.Color.MidnightBlue
        Me.MenuBarModule1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuBarModule1.Location = New System.Drawing.Point(0, 0)
        Me.MenuBarModule1.Name = "MenuBarModule1"
        Me.MenuBarModule1.Size = New System.Drawing.Size(1063, 56)
        Me.MenuBarModule1.TabIndex = 0
        '
        'SideBarModule1
        '
        Me.SideBarModule1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.SideBarModule1.Dock = System.Windows.Forms.DockStyle.Left
        Me.SideBarModule1.Location = New System.Drawing.Point(0, 56)
        Me.SideBarModule1.Name = "SideBarModule1"
        Me.SideBarModule1.Size = New System.Drawing.Size(220, 496)
        Me.SideBarModule1.TabIndex = 1
        '
        'PanelSubContent
        '
        Me.PanelSubContent.Controls.Add(Me.MainMenuModule1)
        Me.PanelSubContent.Controls.Add(Me.PanelSubContentTitle)
        Me.PanelSubContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelSubContent.Location = New System.Drawing.Point(220, 56)
        Me.PanelSubContent.Name = "PanelSubContent"
        Me.PanelSubContent.Size = New System.Drawing.Size(843, 496)
        Me.PanelSubContent.TabIndex = 2
        '
        'MainMenuModule1
        '
        Me.MainMenuModule1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainMenuModule1.Location = New System.Drawing.Point(0, 50)
        Me.MainMenuModule1.Name = "MainMenuModule1"
        Me.MainMenuModule1.Size = New System.Drawing.Size(843, 446)
        Me.MainMenuModule1.TabIndex = 1
        '
        'PanelSubContentTitle
        '
        Me.PanelSubContentTitle.Controls.Add(Me.LabelSubContentTitle)
        Me.PanelSubContentTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubContentTitle.Location = New System.Drawing.Point(0, 0)
        Me.PanelSubContentTitle.Name = "PanelSubContentTitle"
        Me.PanelSubContentTitle.Size = New System.Drawing.Size(843, 50)
        Me.PanelSubContentTitle.TabIndex = 0
        '
        'LabelSubContentTitle
        '
        Me.LabelSubContentTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelSubContentTitle.Font = New System.Drawing.Font("Corbel", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSubContentTitle.Location = New System.Drawing.Point(0, 0)
        Me.LabelSubContentTitle.Name = "LabelSubContentTitle"
        Me.LabelSubContentTitle.Size = New System.Drawing.Size(843, 50)
        Me.LabelSubContentTitle.TabIndex = 0
        Me.LabelSubContentTitle.Text = "Menu principal"
        Me.LabelSubContentTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1063, 652)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "MainForm"
        Me.Text = "Form1"
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelContent.ResumeLayout(False)
        CType(Me.PictureBoxHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSubContent.ResumeLayout(False)
        Me.PanelSubContentTitle.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuBarModule1 As MenuBarModule
    Friend WithEvents SideBarModule1 As SideBarModule
    Friend WithEvents PanelSubContent As Panel
    Friend WithEvents PanelSubContentTitle As Panel
    Friend WithEvents LabelSubContentTitle As Label
    Friend WithEvents MainMenuModule1 As MainMenuModule
End Class
