<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatosLaboralesModule
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanelContent = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.EliminarButtonTECNM = New Presentation.EliminarButton()
        Me.EditarButtonTECNM = New Presentation.EditarButton()
        Me.AgregarButtonTECNM = New Presentation.AgregarButton()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.EliminarButtonExternas = New Presentation.EliminarButton()
        Me.EditarButtonExternas = New Presentation.EditarButton()
        Me.AgregarButtonExternas = New Presentation.AgregarButton()
        Me.CustomDataGridViewTECNM = New Presentation.CustomDataGridView()
        Me.CustomDataGridViewExternas = New Presentation.CustomDataGridView()
        Me.Plantel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDeAdscripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vigente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Institucion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Puesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDeNombramiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vigente2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanelContent.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        CType(Me.CustomDataGridViewTECNM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomDataGridViewExternas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanelContent
        '
        Me.TableLayoutPanelContent.ColumnCount = 3
        Me.TableLayoutPanelContent.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanelContent.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelContent.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanelContent.Controls.Add(Me.Label1, 1, 0)
        Me.TableLayoutPanelContent.Controls.Add(Me.Label2, 1, 5)
        Me.TableLayoutPanelContent.Controls.Add(Me.Panel1, 1, 1)
        Me.TableLayoutPanelContent.Controls.Add(Me.FlowLayoutPanel1, 1, 6)
        Me.TableLayoutPanelContent.Controls.Add(Me.FlowLayoutPanel2, 1, 3)
        Me.TableLayoutPanelContent.Controls.Add(Me.FlowLayoutPanel3, 1, 8)
        Me.TableLayoutPanelContent.Controls.Add(Me.CustomDataGridViewTECNM, 1, 2)
        Me.TableLayoutPanelContent.Controls.Add(Me.CustomDataGridViewExternas, 1, 7)
        Me.TableLayoutPanelContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelContent.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelContent.Name = "TableLayoutPanelContent"
        Me.TableLayoutPanelContent.RowCount = 9
        Me.TableLayoutPanelContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanelContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanelContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanelContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanelContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanelContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanelContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
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
        Me.Label1.Text = "Adscripciones al TECNM"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Corbel", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(53, 337)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(757, 40)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Adscripciones externas"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
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
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(53, 380)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(757, 4)
        Me.FlowLayoutPanel1.TabIndex = 4
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.EliminarButtonTECNM)
        Me.FlowLayoutPanel2.Controls.Add(Me.EditarButtonTECNM)
        Me.FlowLayoutPanel2.Controls.Add(Me.AgregarButtonTECNM)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(53, 290)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(757, 34)
        Me.FlowLayoutPanel2.TabIndex = 6
        '
        'EliminarButtonTECNM
        '
        Me.EliminarButtonTECNM.BackColor = System.Drawing.Color.Firebrick
        Me.EliminarButtonTECNM.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EliminarButtonTECNM.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.EliminarButtonTECNM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EliminarButtonTECNM.Location = New System.Drawing.Point(679, 3)
        Me.EliminarButtonTECNM.Name = "EliminarButtonTECNM"
        Me.EliminarButtonTECNM.Size = New System.Drawing.Size(75, 30)
        Me.EliminarButtonTECNM.TabIndex = 0
        Me.EliminarButtonTECNM.Text = "Eliminar"
        Me.EliminarButtonTECNM.UseVisualStyleBackColor = False
        '
        'EditarButtonTECNM
        '
        Me.EditarButtonTECNM.BackColor = System.Drawing.Color.SeaGreen
        Me.EditarButtonTECNM.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditarButtonTECNM.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.EditarButtonTECNM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EditarButtonTECNM.Location = New System.Drawing.Point(598, 3)
        Me.EditarButtonTECNM.Name = "EditarButtonTECNM"
        Me.EditarButtonTECNM.Size = New System.Drawing.Size(75, 30)
        Me.EditarButtonTECNM.TabIndex = 1
        Me.EditarButtonTECNM.Text = "Editar"
        Me.EditarButtonTECNM.UseVisualStyleBackColor = False
        '
        'AgregarButtonTECNM
        '
        Me.AgregarButtonTECNM.BackColor = System.Drawing.Color.SteelBlue
        Me.AgregarButtonTECNM.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgregarButtonTECNM.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.AgregarButtonTECNM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AgregarButtonTECNM.Location = New System.Drawing.Point(517, 3)
        Me.AgregarButtonTECNM.Name = "AgregarButtonTECNM"
        Me.AgregarButtonTECNM.Size = New System.Drawing.Size(75, 30)
        Me.AgregarButtonTECNM.TabIndex = 2
        Me.AgregarButtonTECNM.Text = "Agregar"
        Me.AgregarButtonTECNM.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.EliminarButtonExternas)
        Me.FlowLayoutPanel3.Controls.Add(Me.EditarButtonExternas)
        Me.FlowLayoutPanel3.Controls.Add(Me.AgregarButtonExternas)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(53, 627)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(757, 34)
        Me.FlowLayoutPanel3.TabIndex = 7
        '
        'EliminarButtonExternas
        '
        Me.EliminarButtonExternas.BackColor = System.Drawing.Color.Firebrick
        Me.EliminarButtonExternas.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EliminarButtonExternas.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.EliminarButtonExternas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EliminarButtonExternas.Location = New System.Drawing.Point(679, 3)
        Me.EliminarButtonExternas.Name = "EliminarButtonExternas"
        Me.EliminarButtonExternas.Size = New System.Drawing.Size(75, 30)
        Me.EliminarButtonExternas.TabIndex = 0
        Me.EliminarButtonExternas.Text = "Eliminar"
        Me.EliminarButtonExternas.UseVisualStyleBackColor = False
        '
        'EditarButtonExternas
        '
        Me.EditarButtonExternas.BackColor = System.Drawing.Color.SeaGreen
        Me.EditarButtonExternas.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditarButtonExternas.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.EditarButtonExternas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EditarButtonExternas.Location = New System.Drawing.Point(598, 3)
        Me.EditarButtonExternas.Name = "EditarButtonExternas"
        Me.EditarButtonExternas.Size = New System.Drawing.Size(75, 30)
        Me.EditarButtonExternas.TabIndex = 1
        Me.EditarButtonExternas.Text = "Editar"
        Me.EditarButtonExternas.UseVisualStyleBackColor = False
        '
        'AgregarButtonExternas
        '
        Me.AgregarButtonExternas.BackColor = System.Drawing.Color.SteelBlue
        Me.AgregarButtonExternas.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgregarButtonExternas.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.AgregarButtonExternas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AgregarButtonExternas.Location = New System.Drawing.Point(517, 3)
        Me.AgregarButtonExternas.Name = "AgregarButtonExternas"
        Me.AgregarButtonExternas.Size = New System.Drawing.Size(75, 30)
        Me.AgregarButtonExternas.TabIndex = 2
        Me.AgregarButtonExternas.Text = "Agregar"
        Me.AgregarButtonExternas.UseVisualStyleBackColor = False
        '
        'CustomDataGridViewTECNM
        '
        Me.CustomDataGridViewTECNM.AllowUserToAddRows = False
        Me.CustomDataGridViewTECNM.AllowUserToDeleteRows = False
        Me.CustomDataGridViewTECNM.AllowUserToResizeColumns = False
        Me.CustomDataGridViewTECNM.AllowUserToResizeRows = False
        Me.CustomDataGridViewTECNM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CustomDataGridViewTECNM.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.CustomDataGridViewTECNM.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CustomDataGridViewTECNM.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.CustomDataGridViewTECNM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomDataGridViewTECNM.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Plantel, Me.FechaDeAdscripcion, Me.Vigente})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CustomDataGridViewTECNM.DefaultCellStyle = DataGridViewCellStyle2
        Me.CustomDataGridViewTECNM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomDataGridViewTECNM.Location = New System.Drawing.Point(53, 53)
        Me.CustomDataGridViewTECNM.MultiSelect = False
        Me.CustomDataGridViewTECNM.Name = "CustomDataGridViewTECNM"
        Me.CustomDataGridViewTECNM.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CustomDataGridViewTECNM.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.CustomDataGridViewTECNM.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.CustomDataGridViewTECNM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CustomDataGridViewTECNM.Size = New System.Drawing.Size(757, 231)
        Me.CustomDataGridViewTECNM.TabIndex = 9
        '
        'CustomDataGridViewExternas
        '
        Me.CustomDataGridViewExternas.AllowUserToAddRows = False
        Me.CustomDataGridViewExternas.AllowUserToDeleteRows = False
        Me.CustomDataGridViewExternas.AllowUserToResizeColumns = False
        Me.CustomDataGridViewExternas.AllowUserToResizeRows = False
        Me.CustomDataGridViewExternas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CustomDataGridViewExternas.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.CustomDataGridViewExternas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CustomDataGridViewExternas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.CustomDataGridViewExternas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomDataGridViewExternas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Institucion, Me.Puesto, Me.FechaDeNombramiento, Me.Vigente2})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CustomDataGridViewExternas.DefaultCellStyle = DataGridViewCellStyle5
        Me.CustomDataGridViewExternas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomDataGridViewExternas.Location = New System.Drawing.Point(53, 390)
        Me.CustomDataGridViewExternas.MultiSelect = False
        Me.CustomDataGridViewExternas.Name = "CustomDataGridViewExternas"
        Me.CustomDataGridViewExternas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CustomDataGridViewExternas.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.CustomDataGridViewExternas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.CustomDataGridViewExternas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CustomDataGridViewExternas.Size = New System.Drawing.Size(757, 231)
        Me.CustomDataGridViewExternas.TabIndex = 10
        '
        'Plantel
        '
        Me.Plantel.HeaderText = "Plantel"
        Me.Plantel.Name = "Plantel"
        '
        'FechaDeAdscripcion
        '
        Me.FechaDeAdscripcion.HeaderText = "Fecha de adscripcion"
        Me.FechaDeAdscripcion.Name = "FechaDeAdscripcion"
        '
        'Vigente
        '
        Me.Vigente.HeaderText = "Vigente"
        Me.Vigente.Name = "Vigente"
        '
        'Institucion
        '
        Me.Institucion.HeaderText = "Institucion"
        Me.Institucion.Name = "Institucion"
        '
        'Puesto
        '
        Me.Puesto.HeaderText = "Puesto"
        Me.Puesto.Name = "Puesto"
        '
        'FechaDeNombramiento
        '
        Me.FechaDeNombramiento.HeaderText = "Fecha de nombramiento"
        Me.FechaDeNombramiento.Name = "FechaDeNombramiento"
        '
        'Vigente2
        '
        Me.Vigente2.HeaderText = "Vigente"
        Me.Vigente2.Name = "Vigente2"
        '
        'DatosLaboralesModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanelContent)
        Me.Name = "DatosLaboralesModule"
        Me.Size = New System.Drawing.Size(863, 664)
        Me.TableLayoutPanelContent.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel3.ResumeLayout(False)
        CType(Me.CustomDataGridViewTECNM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomDataGridViewExternas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanelContent As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents EliminarButtonTECNM As EliminarButton
    Friend WithEvents EditarButtonTECNM As EditarButton
    Friend WithEvents AgregarButtonTECNM As AgregarButton
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents EliminarButtonExternas As EliminarButton
    Friend WithEvents EditarButtonExternas As EditarButton
    Friend WithEvents AgregarButtonExternas As AgregarButton
    Friend WithEvents CustomDataGridViewTECNM As CustomDataGridView
    Friend WithEvents CustomDataGridViewExternas As CustomDataGridView
    Friend WithEvents Plantel As DataGridViewTextBoxColumn
    Friend WithEvents FechaDeAdscripcion As DataGridViewTextBoxColumn
    Friend WithEvents Vigente As DataGridViewTextBoxColumn
    Friend WithEvents Institucion As DataGridViewTextBoxColumn
    Friend WithEvents Puesto As DataGridViewTextBoxColumn
    Friend WithEvents FechaDeNombramiento As DataGridViewTextBoxColumn
    Friend WithEvents Vigente2 As DataGridViewTextBoxColumn
End Class
