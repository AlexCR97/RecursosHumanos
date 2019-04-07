<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActivationDialog
    Inherits CustomDialog

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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxIdActivacion = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ActivarButton = New Presentation.AgregarButton()
        Me.CancelarButton1 = New Presentation.CancelarButton()
        Me.LinkLabelResend = New System.Windows.Forms.LinkLabel()
        Me.PanelContent.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelContent
        '
        Me.PanelContent.Controls.Add(Me.TableLayoutPanel1)
        Me.PanelContent.Size = New System.Drawing.Size(601, 212)
        '
        'LabelTitle
        '
        Me.LabelTitle.Size = New System.Drawing.Size(601, 68)
        Me.LabelTitle.Text = "Activar cuenta"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxIdActivacion, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LinkLabelResend, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(601, 212)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(555, 70)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Se ha enviado un id de activacion de cuenta a tu correo electronico. Ingresa el i" &
    "d para poder acceder al sistema"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBoxIdActivacion
        '
        Me.TextBoxIdActivacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxIdActivacion.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxIdActivacion.Location = New System.Drawing.Point(23, 73)
        Me.TextBoxIdActivacion.Name = "TextBoxIdActivacion"
        Me.TextBoxIdActivacion.Size = New System.Drawing.Size(555, 27)
        Me.TextBoxIdActivacion.TabIndex = 2
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.ActivarButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.CancelarButton1)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(23, 150)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(555, 34)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'ActivarButton
        '
        Me.ActivarButton.BackColor = System.Drawing.Color.SteelBlue
        Me.ActivarButton.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActivarButton.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.ActivarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ActivarButton.Location = New System.Drawing.Point(477, 3)
        Me.ActivarButton.Name = "ActivarButton"
        Me.ActivarButton.Size = New System.Drawing.Size(75, 30)
        Me.ActivarButton.TabIndex = 0
        Me.ActivarButton.Text = "Activar"
        Me.ActivarButton.UseVisualStyleBackColor = False
        '
        'CancelarButton1
        '
        Me.CancelarButton1.BackColor = System.Drawing.Color.Chocolate
        Me.CancelarButton1.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelarButton1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.CancelarButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CancelarButton1.Location = New System.Drawing.Point(396, 3)
        Me.CancelarButton1.Name = "CancelarButton1"
        Me.CancelarButton1.Size = New System.Drawing.Size(75, 30)
        Me.CancelarButton1.TabIndex = 1
        Me.CancelarButton1.Text = "Cancelar"
        Me.CancelarButton1.UseVisualStyleBackColor = False
        '
        'LinkLabelResend
        '
        Me.LinkLabelResend.AutoSize = True
        Me.LinkLabelResend.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LinkLabelResend.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelResend.Location = New System.Drawing.Point(23, 107)
        Me.LinkLabelResend.Name = "LinkLabelResend"
        Me.LinkLabelResend.Size = New System.Drawing.Size(555, 40)
        Me.LinkLabelResend.TabIndex = 3
        Me.LinkLabelResend.TabStop = True
        Me.LinkLabelResend.Text = "Haz clic aqui para reenviar el id de activacion"
        Me.LinkLabelResend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ActivationDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 280)
        Me.Name = "ActivationDialog"
        Me.Text = "Activar cuenta"
        Me.PanelContent.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents ActivarButton As AgregarButton
    Friend WithEvents TextBoxIdActivacion As TextBox
    Friend WithEvents CancelarButton1 As CancelarButton
    Friend WithEvents LinkLabelResend As LinkLabel
End Class
