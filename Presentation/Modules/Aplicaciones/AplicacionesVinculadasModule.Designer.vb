<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AplicacionesVinculadasModule
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
        Me.EliminarButtonAplicacionesVinculadas = New Presentation.EliminarButton()
        Me.EditarButtonAplicacionesVinculadas = New Presentation.EditarButton()
        Me.AgregarButtonAplicacionesVinculadas = New Presentation.AgregarButton()
        Me.CustomDataGridViewAplicacionesVinculadas = New Presentation.CustomDataGridView()
        Me.Titulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionWeb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanelContent.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        CType(Me.CustomDataGridViewAplicacionesVinculadas, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanelContent.Controls.Add(Me.CustomDataGridViewAplicacionesVinculadas, 1, 2)
        Me.TableLayoutPanelContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelContent.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelContent.Name = "TableLayoutPanelContent"
        Me.TableLayoutPanelContent.RowCount = 4
        Me.TableLayoutPanelContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanelContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanelContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
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
        Me.Label1.Text = "Aplicaciones vinculadas"
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
        Me.FlowLayoutPanel2.Controls.Add(Me.EliminarButtonAplicacionesVinculadas)
        Me.FlowLayoutPanel2.Controls.Add(Me.EditarButtonAplicacionesVinculadas)
        Me.FlowLayoutPanel2.Controls.Add(Me.AgregarButtonAplicacionesVinculadas)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(53, 627)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(757, 34)
        Me.FlowLayoutPanel2.TabIndex = 6
        '
        'EliminarButtonAplicacionesVinculadas
        '
        Me.EliminarButtonAplicacionesVinculadas.BackColor = System.Drawing.Color.Firebrick
        Me.EliminarButtonAplicacionesVinculadas.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EliminarButtonAplicacionesVinculadas.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.EliminarButtonAplicacionesVinculadas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EliminarButtonAplicacionesVinculadas.Location = New System.Drawing.Point(679, 3)
        Me.EliminarButtonAplicacionesVinculadas.Name = "EliminarButtonAplicacionesVinculadas"
        Me.EliminarButtonAplicacionesVinculadas.Size = New System.Drawing.Size(75, 30)
        Me.EliminarButtonAplicacionesVinculadas.TabIndex = 0
        Me.EliminarButtonAplicacionesVinculadas.Text = "Eliminar"
        Me.EliminarButtonAplicacionesVinculadas.UseVisualStyleBackColor = False
        '
        'EditarButtonAplicacionesVinculadas
        '
        Me.EditarButtonAplicacionesVinculadas.BackColor = System.Drawing.Color.SeaGreen
        Me.EditarButtonAplicacionesVinculadas.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditarButtonAplicacionesVinculadas.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.EditarButtonAplicacionesVinculadas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EditarButtonAplicacionesVinculadas.Location = New System.Drawing.Point(598, 3)
        Me.EditarButtonAplicacionesVinculadas.Name = "EditarButtonAplicacionesVinculadas"
        Me.EditarButtonAplicacionesVinculadas.Size = New System.Drawing.Size(75, 30)
        Me.EditarButtonAplicacionesVinculadas.TabIndex = 1
        Me.EditarButtonAplicacionesVinculadas.Text = "Editar"
        Me.EditarButtonAplicacionesVinculadas.UseVisualStyleBackColor = False
        '
        'AgregarButtonAplicacionesVinculadas
        '
        Me.AgregarButtonAplicacionesVinculadas.BackColor = System.Drawing.Color.SteelBlue
        Me.AgregarButtonAplicacionesVinculadas.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgregarButtonAplicacionesVinculadas.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.AgregarButtonAplicacionesVinculadas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AgregarButtonAplicacionesVinculadas.Location = New System.Drawing.Point(517, 3)
        Me.AgregarButtonAplicacionesVinculadas.Name = "AgregarButtonAplicacionesVinculadas"
        Me.AgregarButtonAplicacionesVinculadas.Size = New System.Drawing.Size(75, 30)
        Me.AgregarButtonAplicacionesVinculadas.TabIndex = 2
        Me.AgregarButtonAplicacionesVinculadas.Text = "Agregar"
        Me.AgregarButtonAplicacionesVinculadas.UseVisualStyleBackColor = False
        '
        'CustomDataGridViewAplicacionesVinculadas
        '
        Me.CustomDataGridViewAplicacionesVinculadas.AllowUserToAddRows = False
        Me.CustomDataGridViewAplicacionesVinculadas.AllowUserToDeleteRows = False
        Me.CustomDataGridViewAplicacionesVinculadas.AllowUserToResizeColumns = False
        Me.CustomDataGridViewAplicacionesVinculadas.AllowUserToResizeRows = False
        Me.CustomDataGridViewAplicacionesVinculadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CustomDataGridViewAplicacionesVinculadas.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.CustomDataGridViewAplicacionesVinculadas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CustomDataGridViewAplicacionesVinculadas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.CustomDataGridViewAplicacionesVinculadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomDataGridViewAplicacionesVinculadas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Titulo, Me.DireccionWeb, Me.Descripcion})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CustomDataGridViewAplicacionesVinculadas.DefaultCellStyle = DataGridViewCellStyle2
        Me.CustomDataGridViewAplicacionesVinculadas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomDataGridViewAplicacionesVinculadas.Location = New System.Drawing.Point(53, 53)
        Me.CustomDataGridViewAplicacionesVinculadas.MultiSelect = False
        Me.CustomDataGridViewAplicacionesVinculadas.Name = "CustomDataGridViewAplicacionesVinculadas"
        Me.CustomDataGridViewAplicacionesVinculadas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CustomDataGridViewAplicacionesVinculadas.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.CustomDataGridViewAplicacionesVinculadas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.CustomDataGridViewAplicacionesVinculadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CustomDataGridViewAplicacionesVinculadas.Size = New System.Drawing.Size(757, 568)
        Me.CustomDataGridViewAplicacionesVinculadas.TabIndex = 9
        '
        'Titulo
        '
        Me.Titulo.HeaderText = "Titulo"
        Me.Titulo.Name = "Titulo"
        '
        'DireccionWeb
        '
        Me.DireccionWeb.HeaderText = "Direccion web"
        Me.DireccionWeb.Name = "DireccionWeb"
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        '
        'AplicacionesVinculadasModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanelContent)
        Me.Name = "AplicacionesVinculadasModule"
        Me.Size = New System.Drawing.Size(863, 664)
        Me.TableLayoutPanelContent.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        CType(Me.CustomDataGridViewAplicacionesVinculadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanelContent As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents EliminarButtonAplicacionesVinculadas As EliminarButton
    Friend WithEvents EditarButtonAplicacionesVinculadas As EditarButton
    Friend WithEvents AgregarButtonAplicacionesVinculadas As AgregarButton
    Friend WithEvents CustomDataGridViewAplicacionesVinculadas As CustomDataGridView
    Friend WithEvents Titulo As DataGridViewTextBoxColumn
    Friend WithEvents DireccionWeb As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
End Class
