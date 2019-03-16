<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomForm
    Inherits System.Windows.Forms.Form

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
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.PictureBoxHeader = New System.Windows.Forms.PictureBox()
        Me.PanelContent = New System.Windows.Forms.Panel()
        Me.PanelHeader.SuspendLayout()
        CType(Me.PictureBoxHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelHeader
        '
        Me.PanelHeader.Controls.Add(Me.PictureBoxHeader)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(1139, 100)
        Me.PanelHeader.TabIndex = 0
        '
        'PictureBoxHeader
        '
        Me.PictureBoxHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBoxHeader.Image = Global.Presentation.My.Resources.Resources.imageSep
        Me.PictureBoxHeader.Location = New System.Drawing.Point(0, 0)
        Me.PictureBoxHeader.Name = "PictureBoxHeader"
        Me.PictureBoxHeader.Size = New System.Drawing.Size(1139, 100)
        Me.PictureBoxHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxHeader.TabIndex = 0
        Me.PictureBoxHeader.TabStop = False
        '
        'PanelContent
        '
        Me.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContent.Location = New System.Drawing.Point(0, 100)
        Me.PanelContent.Name = "PanelContent"
        Me.PanelContent.Size = New System.Drawing.Size(1139, 559)
        Me.PanelContent.TabIndex = 1
        '
        'CustomForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(1139, 659)
        Me.Controls.Add(Me.PanelContent)
        Me.Controls.Add(Me.PanelHeader)
        Me.DoubleBuffered = True
        Me.Name = "CustomForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CustomForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelHeader.ResumeLayout(False)
        CType(Me.PictureBoxHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Protected Friend WithEvents PanelHeader As Panel
    Protected Friend WithEvents PanelContent As Panel
    Protected Friend WithEvents PictureBoxHeader As PictureBox
End Class
