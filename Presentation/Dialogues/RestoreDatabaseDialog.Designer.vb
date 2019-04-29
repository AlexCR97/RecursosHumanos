<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RestoreDatabaseDialog
    Inherits CustomDialog

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
        Me.TextBoxBackupFile = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.GuardarButtonBackup = New Presentation.GuardarButton()
        Me.CancelarButton1 = New Presentation.CancelarButton()
        Me.GuardarButtonSelectBackup = New Presentation.GuardarButton()
        Me.PanelContent.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelContent
        '
        Me.PanelContent.Controls.Add(Me.TableLayoutPanel1)
        Me.PanelContent.Size = New System.Drawing.Size(601, 157)
        '
        'LabelTitle
        '
        Me.LabelTitle.Size = New System.Drawing.Size(601, 68)
        Me.LabelTitle.Text = "Restauracion de base de datos"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 490.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxBackupFile, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GuardarButtonSelectBackup, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(601, 157)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'TextBoxBackupFile
        '
        Me.TextBoxBackupFile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxBackupFile.Enabled = False
        Me.TextBoxBackupFile.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBackupFile.Location = New System.Drawing.Point(58, 13)
        Me.TextBoxBackupFile.Name = "TextBoxBackupFile"
        Me.TextBoxBackupFile.Size = New System.Drawing.Size(484, 27)
        Me.TextBoxBackupFile.TabIndex = 12
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.GuardarButtonBackup)
        Me.FlowLayoutPanel1.Controls.Add(Me.CancelarButton1)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(58, 93)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(484, 61)
        Me.FlowLayoutPanel1.TabIndex = 20
        '
        'GuardarButtonBackup
        '
        Me.GuardarButtonBackup.BackColor = System.Drawing.Color.DarkViolet
        Me.GuardarButtonBackup.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuardarButtonBackup.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.GuardarButtonBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GuardarButtonBackup.Location = New System.Drawing.Point(382, 3)
        Me.GuardarButtonBackup.Name = "GuardarButtonBackup"
        Me.GuardarButtonBackup.Size = New System.Drawing.Size(99, 30)
        Me.GuardarButtonBackup.TabIndex = 1
        Me.GuardarButtonBackup.Text = "Restaurar"
        Me.GuardarButtonBackup.UseVisualStyleBackColor = False
        '
        'CancelarButton1
        '
        Me.CancelarButton1.BackColor = System.Drawing.Color.Chocolate
        Me.CancelarButton1.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelarButton1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.CancelarButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CancelarButton1.Location = New System.Drawing.Point(301, 3)
        Me.CancelarButton1.Name = "CancelarButton1"
        Me.CancelarButton1.Size = New System.Drawing.Size(75, 30)
        Me.CancelarButton1.TabIndex = 2
        Me.CancelarButton1.Text = "Cancelar"
        Me.CancelarButton1.UseVisualStyleBackColor = False
        '
        'GuardarButtonSelectBackup
        '
        Me.GuardarButtonSelectBackup.BackColor = System.Drawing.Color.SeaGreen
        Me.GuardarButtonSelectBackup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GuardarButtonSelectBackup.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuardarButtonSelectBackup.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.GuardarButtonSelectBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GuardarButtonSelectBackup.Location = New System.Drawing.Point(58, 48)
        Me.GuardarButtonSelectBackup.Name = "GuardarButtonSelectBackup"
        Me.GuardarButtonSelectBackup.Size = New System.Drawing.Size(484, 29)
        Me.GuardarButtonSelectBackup.TabIndex = 21
        Me.GuardarButtonSelectBackup.Text = "Seleccionar respaldo"
        Me.GuardarButtonSelectBackup.UseVisualStyleBackColor = False
        '
        'RestoreDatabaseDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 225)
        Me.Name = "RestoreDatabaseDialog"
        Me.Text = "Restauracion de base de datos"
        Me.PanelContent.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TextBoxBackupFile As TextBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents CancelarButton1 As CancelarButton
    Friend WithEvents GuardarButtonBackup As GuardarButton
    Friend WithEvents GuardarButtonSelectBackup As GuardarButton
End Class
