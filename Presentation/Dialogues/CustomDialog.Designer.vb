<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomDialog
    Inherits System.Windows.Forms.Form

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
        Me.PanelFooter = New System.Windows.Forms.Panel()
        Me.PanelContent = New System.Windows.Forms.Panel()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.PanelHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelFooter
        '
        Me.PanelFooter.BackColor = System.Drawing.Color.MidnightBlue
        Me.PanelFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelFooter.Location = New System.Drawing.Point(0, 286)
        Me.PanelFooter.Name = "PanelFooter"
        Me.PanelFooter.Size = New System.Drawing.Size(454, 25)
        Me.PanelFooter.TabIndex = 3
        '
        'PanelContent
        '
        Me.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContent.Location = New System.Drawing.Point(0, 68)
        Me.PanelContent.Name = "PanelContent"
        Me.PanelContent.Size = New System.Drawing.Size(454, 243)
        Me.PanelContent.TabIndex = 2
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.MidnightBlue
        Me.PanelHeader.Controls.Add(Me.LabelTitle)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(454, 68)
        Me.PanelHeader.TabIndex = 0
        '
        'LabelTitle
        '
        Me.LabelTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelTitle.Font = New System.Drawing.Font("Corbel", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitle.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.LabelTitle.Location = New System.Drawing.Point(0, 0)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.LabelTitle.Size = New System.Drawing.Size(454, 68)
        Me.LabelTitle.TabIndex = 0
        Me.LabelTitle.Text = "Message"
        Me.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CustomDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(454, 311)
        Me.Controls.Add(Me.PanelFooter)
        Me.Controls.Add(Me.PanelContent)
        Me.Controls.Add(Me.PanelHeader)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CustomDialog"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CustomDialog"
        Me.PanelHeader.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelFooter As Panel
    Protected Friend WithEvents PanelContent As Panel
    Friend WithEvents PanelHeader As Panel
    Protected Friend WithEvents LabelTitle As Label
End Class
