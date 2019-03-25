<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResumenDatosDeContactoModule
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanelTelefonos = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanelCorreos = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanelOtrosMedios = New System.Windows.Forms.FlowLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanelTelefonos, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanelCorreos, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanelOtrosMedios, 0, 7)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(681, 452)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Corbel", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(675, 35)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Datos de contacto"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(675, 4)
        Me.Panel1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label2.Location = New System.Drawing.Point(3, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(675, 30)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Telefonos"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label3.Location = New System.Drawing.Point(3, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(675, 30)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Correos electronicos"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label4.Location = New System.Drawing.Point(3, 309)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(675, 30)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Otros medios"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FlowLayoutPanelTelefonos
        '
        Me.FlowLayoutPanelTelefonos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanelTelefonos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanelTelefonos.Location = New System.Drawing.Point(3, 78)
        Me.FlowLayoutPanelTelefonos.Name = "FlowLayoutPanelTelefonos"
        Me.FlowLayoutPanelTelefonos.Size = New System.Drawing.Size(675, 96)
        Me.FlowLayoutPanelTelefonos.TabIndex = 7
        '
        'FlowLayoutPanelCorreos
        '
        Me.FlowLayoutPanelCorreos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanelCorreos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanelCorreos.Location = New System.Drawing.Point(3, 210)
        Me.FlowLayoutPanelCorreos.Name = "FlowLayoutPanelCorreos"
        Me.FlowLayoutPanelCorreos.Size = New System.Drawing.Size(675, 96)
        Me.FlowLayoutPanelCorreos.TabIndex = 8
        '
        'FlowLayoutPanelOtrosMedios
        '
        Me.FlowLayoutPanelOtrosMedios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanelOtrosMedios.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanelOtrosMedios.Location = New System.Drawing.Point(3, 342)
        Me.FlowLayoutPanelOtrosMedios.Name = "FlowLayoutPanelOtrosMedios"
        Me.FlowLayoutPanelOtrosMedios.Size = New System.Drawing.Size(675, 107)
        Me.FlowLayoutPanelOtrosMedios.TabIndex = 9
        '
        'ResumenDatosDeContactoModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "ResumenDatosDeContactoModule"
        Me.Size = New System.Drawing.Size(681, 452)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents FlowLayoutPanelTelefonos As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanelCorreos As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanelOtrosMedios As FlowLayoutPanel
End Class
