<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AsociacionesModule
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanelContent = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.EliminarButtonAsociaciones = New Presentation.EliminarButton()
        Me.EditarButtonAsociaciones = New Presentation.EditarButton()
        Me.AgregarButtonAsociaciones = New Presentation.AgregarButton()
        Me.CustomDataGridViewAsociaciones = New Presentation.CustomDataGridView()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanelContent.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        CType(Me.CustomDataGridViewAsociaciones, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanelContent.Controls.Add(Me.CustomDataGridViewAsociaciones, 1, 2)
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
        'CustomDataGridViewAsociaciones
        '
        Me.CustomDataGridViewAsociaciones.AllowUserToAddRows = False
        Me.CustomDataGridViewAsociaciones.AllowUserToDeleteRows = False
        Me.CustomDataGridViewAsociaciones.AllowUserToResizeColumns = False
        Me.CustomDataGridViewAsociaciones.AllowUserToResizeRows = False
        Me.CustomDataGridViewAsociaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CustomDataGridViewAsociaciones.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.CustomDataGridViewAsociaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CustomDataGridViewAsociaciones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.CustomDataGridViewAsociaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomDataGridViewAsociaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Telefono})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CustomDataGridViewAsociaciones.DefaultCellStyle = DataGridViewCellStyle2
        Me.CustomDataGridViewAsociaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomDataGridViewAsociaciones.Location = New System.Drawing.Point(53, 53)
        Me.CustomDataGridViewAsociaciones.MultiSelect = False
        Me.CustomDataGridViewAsociaciones.Name = "CustomDataGridViewAsociaciones"
        Me.CustomDataGridViewAsociaciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CustomDataGridViewAsociaciones.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.CustomDataGridViewAsociaciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.CustomDataGridViewAsociaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CustomDataGridViewAsociaciones.Size = New System.Drawing.Size(757, 568)
        Me.CustomDataGridViewAsociaciones.TabIndex = 9
        '
        'Telefono
        '
        Me.Telefono.HeaderText = "Telefono"
        Me.Telefono.Name = "Telefono"
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
        CType(Me.CustomDataGridViewAsociaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanelContent As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents EliminarButtonAsociaciones As EliminarButton
    Friend WithEvents EditarButtonAsociaciones As EditarButton
    Friend WithEvents AgregarButtonAsociaciones As AgregarButton
    Friend WithEvents CustomDataGridViewAsociaciones As CustomDataGridView
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
End Class
