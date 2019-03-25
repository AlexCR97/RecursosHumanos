<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AsociacionesModule
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanelContent = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.EliminarButtonAsociaciones = New Presentation.EliminarButton()
        Me.EditarButtonAsociaciones = New Presentation.EditarButton()
        Me.AgregarButtonAsociaciones = New Presentation.AgregarButton()
        Me.DataGridViewAsociaciones = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanelContent.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        CType(Me.DataGridViewAsociaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanelContent
        '
        Me.TableLayoutPanelContent.ColumnCount = 3
        Me.TableLayoutPanelContent.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanelContent.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelContent.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanelContent.Controls.Add(Me.Label1, 1, 0)
        Me.TableLayoutPanelContent.Controls.Add(Me.Panel1, 1, 1)
        Me.TableLayoutPanelContent.Controls.Add(Me.FlowLayoutPanel2, 1, 3)
        Me.TableLayoutPanelContent.Controls.Add(Me.DataGridViewAsociaciones, 1, 2)
        Me.TableLayoutPanelContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelContent.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelContent.Name = "TableLayoutPanelContent"
        Me.TableLayoutPanelContent.RowCount = 4
        Me.TableLayoutPanelContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanelContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanelContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanelContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelContent.Size = New System.Drawing.Size(863, 664)
        Me.TableLayoutPanelContent.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Corbel", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(53, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(757, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Asociaciones"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(53, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(757, 4)
        Me.Panel1.TabIndex = 3
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.EliminarButtonAsociaciones)
        Me.FlowLayoutPanel2.Controls.Add(Me.EditarButtonAsociaciones)
        Me.FlowLayoutPanel2.Controls.Add(Me.AgregarButtonAsociaciones)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(53, 627)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(757, 34)
        Me.FlowLayoutPanel2.TabIndex = 6
        '
        'EliminarButtonAsociaciones
        '
        Me.EliminarButtonAsociaciones.BackColor = System.Drawing.Color.Firebrick
        Me.EliminarButtonAsociaciones.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EliminarButtonAsociaciones.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.EliminarButtonAsociaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EliminarButtonAsociaciones.Location = New System.Drawing.Point(679, 3)
        Me.EliminarButtonAsociaciones.Name = "EliminarButtonAsociaciones"
        Me.EliminarButtonAsociaciones.Size = New System.Drawing.Size(75, 30)
        Me.EliminarButtonAsociaciones.TabIndex = 0
        Me.EliminarButtonAsociaciones.Text = "Eliminar"
        Me.EliminarButtonAsociaciones.UseVisualStyleBackColor = False
        '
        'EditarButtonAsociaciones
        '
        Me.EditarButtonAsociaciones.BackColor = System.Drawing.Color.SeaGreen
        Me.EditarButtonAsociaciones.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditarButtonAsociaciones.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.EditarButtonAsociaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EditarButtonAsociaciones.Location = New System.Drawing.Point(598, 3)
        Me.EditarButtonAsociaciones.Name = "EditarButtonAsociaciones"
        Me.EditarButtonAsociaciones.Size = New System.Drawing.Size(75, 30)
        Me.EditarButtonAsociaciones.TabIndex = 1
        Me.EditarButtonAsociaciones.Text = "Editar"
        Me.EditarButtonAsociaciones.UseVisualStyleBackColor = False
        '
        'AgregarButtonAsociaciones
        '
        Me.AgregarButtonAsociaciones.BackColor = System.Drawing.Color.SteelBlue
        Me.AgregarButtonAsociaciones.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgregarButtonAsociaciones.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.AgregarButtonAsociaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AgregarButtonAsociaciones.Location = New System.Drawing.Point(517, 3)
        Me.AgregarButtonAsociaciones.Name = "AgregarButtonAsociaciones"
        Me.AgregarButtonAsociaciones.Size = New System.Drawing.Size(75, 30)
        Me.AgregarButtonAsociaciones.TabIndex = 2
        Me.AgregarButtonAsociaciones.Text = "Agregar"
        Me.AgregarButtonAsociaciones.UseVisualStyleBackColor = False
        '
        'DataGridViewAsociaciones
        '
        Me.DataGridViewAsociaciones.AllowUserToAddRows = False
        Me.DataGridViewAsociaciones.AllowUserToDeleteRows = False
        Me.DataGridViewAsociaciones.AllowUserToOrderColumns = True
        Me.DataGridViewAsociaciones.AllowUserToResizeColumns = False
        Me.DataGridViewAsociaciones.AllowUserToResizeRows = False
        Me.DataGridViewAsociaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewAsociaciones.BackgroundColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewAsociaciones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewAsociaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewAsociaciones.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewAsociaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewAsociaciones.Location = New System.Drawing.Point(53, 53)
        Me.DataGridViewAsociaciones.MultiSelect = False
        Me.DataGridViewAsociaciones.Name = "DataGridViewAsociaciones"
        Me.DataGridViewAsociaciones.ReadOnly = True
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewAsociaciones.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewAsociaciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewAsociaciones.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewAsociaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewAsociaciones.Size = New System.Drawing.Size(757, 568)
        Me.DataGridViewAsociaciones.TabIndex = 15
        '
        'AsociacionesModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanelContent)
        Me.Name = "AsociacionesModule"
        Me.Size = New System.Drawing.Size(863, 664)
        Me.TableLayoutPanelContent.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        CType(Me.DataGridViewAsociaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanelContent As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents EliminarButtonAsociaciones As EliminarButton
    Friend WithEvents EditarButtonAsociaciones As EditarButton
    Friend WithEvents AgregarButtonAsociaciones As AgregarButton
    Friend WithEvents DataGridViewAsociaciones As DataGridView
End Class
