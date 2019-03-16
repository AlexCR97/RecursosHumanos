<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductividadAcademicaModule
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
        Me.EliminarButtonEstancias = New Presentation.EliminarButton()
        Me.EditarButtonEstancias = New Presentation.EditarButton()
        Me.AgregarButtonEstancias = New Presentation.AgregarButton()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.EliminarButtonProductosInvestigacion = New Presentation.EliminarButton()
        Me.EditarButtonProductosInvestigacion = New Presentation.EditarButton()
        Me.AgregarButtonProductosInvestigacion = New Presentation.AgregarButton()
        Me.CustomDataGridViewEstancias = New Presentation.CustomDataGridView()
        Me.CustomDataGridViewProductosInvestigacion = New Presentation.CustomDataGridView()
        Me.Institucion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreProyecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaTermino = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Titulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proposito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaPublicacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanelContent.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        CType(Me.CustomDataGridViewEstancias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomDataGridViewProductosInvestigacion, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanelContent.Controls.Add(Me.CustomDataGridViewEstancias, 1, 2)
        Me.TableLayoutPanelContent.Controls.Add(Me.CustomDataGridViewProductosInvestigacion, 1, 7)
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
        Me.Label1.Text = "Estancias"
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
        Me.Label2.Text = "Productos de investigacion"
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
        Me.FlowLayoutPanel2.Controls.Add(Me.EliminarButtonEstancias)
        Me.FlowLayoutPanel2.Controls.Add(Me.EditarButtonEstancias)
        Me.FlowLayoutPanel2.Controls.Add(Me.AgregarButtonEstancias)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(53, 290)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(757, 34)
        Me.FlowLayoutPanel2.TabIndex = 6
        '
        'EliminarButtonEstancias
        '
        Me.EliminarButtonEstancias.BackColor = System.Drawing.Color.Firebrick
        Me.EliminarButtonEstancias.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EliminarButtonEstancias.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.EliminarButtonEstancias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EliminarButtonEstancias.Location = New System.Drawing.Point(679, 3)
        Me.EliminarButtonEstancias.Name = "EliminarButtonEstancias"
        Me.EliminarButtonEstancias.Size = New System.Drawing.Size(75, 30)
        Me.EliminarButtonEstancias.TabIndex = 0
        Me.EliminarButtonEstancias.Text = "Eliminar"
        Me.EliminarButtonEstancias.UseVisualStyleBackColor = False
        '
        'EditarButtonEstancias
        '
        Me.EditarButtonEstancias.BackColor = System.Drawing.Color.SeaGreen
        Me.EditarButtonEstancias.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditarButtonEstancias.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.EditarButtonEstancias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EditarButtonEstancias.Location = New System.Drawing.Point(598, 3)
        Me.EditarButtonEstancias.Name = "EditarButtonEstancias"
        Me.EditarButtonEstancias.Size = New System.Drawing.Size(75, 30)
        Me.EditarButtonEstancias.TabIndex = 1
        Me.EditarButtonEstancias.Text = "Editar"
        Me.EditarButtonEstancias.UseVisualStyleBackColor = False
        '
        'AgregarButtonEstancias
        '
        Me.AgregarButtonEstancias.BackColor = System.Drawing.Color.SteelBlue
        Me.AgregarButtonEstancias.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgregarButtonEstancias.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.AgregarButtonEstancias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AgregarButtonEstancias.Location = New System.Drawing.Point(517, 3)
        Me.AgregarButtonEstancias.Name = "AgregarButtonEstancias"
        Me.AgregarButtonEstancias.Size = New System.Drawing.Size(75, 30)
        Me.AgregarButtonEstancias.TabIndex = 2
        Me.AgregarButtonEstancias.Text = "Agregar"
        Me.AgregarButtonEstancias.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.EliminarButtonProductosInvestigacion)
        Me.FlowLayoutPanel3.Controls.Add(Me.EditarButtonProductosInvestigacion)
        Me.FlowLayoutPanel3.Controls.Add(Me.AgregarButtonProductosInvestigacion)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(53, 627)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(757, 34)
        Me.FlowLayoutPanel3.TabIndex = 7
        '
        'EliminarButtonProductosInvestigacion
        '
        Me.EliminarButtonProductosInvestigacion.BackColor = System.Drawing.Color.Firebrick
        Me.EliminarButtonProductosInvestigacion.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EliminarButtonProductosInvestigacion.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.EliminarButtonProductosInvestigacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EliminarButtonProductosInvestigacion.Location = New System.Drawing.Point(679, 3)
        Me.EliminarButtonProductosInvestigacion.Name = "EliminarButtonProductosInvestigacion"
        Me.EliminarButtonProductosInvestigacion.Size = New System.Drawing.Size(75, 30)
        Me.EliminarButtonProductosInvestigacion.TabIndex = 0
        Me.EliminarButtonProductosInvestigacion.Text = "Eliminar"
        Me.EliminarButtonProductosInvestigacion.UseVisualStyleBackColor = False
        '
        'EditarButtonProductosInvestigacion
        '
        Me.EditarButtonProductosInvestigacion.BackColor = System.Drawing.Color.SeaGreen
        Me.EditarButtonProductosInvestigacion.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditarButtonProductosInvestigacion.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.EditarButtonProductosInvestigacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EditarButtonProductosInvestigacion.Location = New System.Drawing.Point(598, 3)
        Me.EditarButtonProductosInvestigacion.Name = "EditarButtonProductosInvestigacion"
        Me.EditarButtonProductosInvestigacion.Size = New System.Drawing.Size(75, 30)
        Me.EditarButtonProductosInvestigacion.TabIndex = 1
        Me.EditarButtonProductosInvestigacion.Text = "Editar"
        Me.EditarButtonProductosInvestigacion.UseVisualStyleBackColor = False
        '
        'AgregarButtonProductosInvestigacion
        '
        Me.AgregarButtonProductosInvestigacion.BackColor = System.Drawing.Color.SteelBlue
        Me.AgregarButtonProductosInvestigacion.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgregarButtonProductosInvestigacion.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.AgregarButtonProductosInvestigacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AgregarButtonProductosInvestigacion.Location = New System.Drawing.Point(517, 3)
        Me.AgregarButtonProductosInvestigacion.Name = "AgregarButtonProductosInvestigacion"
        Me.AgregarButtonProductosInvestigacion.Size = New System.Drawing.Size(75, 30)
        Me.AgregarButtonProductosInvestigacion.TabIndex = 2
        Me.AgregarButtonProductosInvestigacion.Text = "Agregar"
        Me.AgregarButtonProductosInvestigacion.UseVisualStyleBackColor = False
        '
        'CustomDataGridViewEstancias
        '
        Me.CustomDataGridViewEstancias.AllowUserToAddRows = False
        Me.CustomDataGridViewEstancias.AllowUserToDeleteRows = False
        Me.CustomDataGridViewEstancias.AllowUserToResizeColumns = False
        Me.CustomDataGridViewEstancias.AllowUserToResizeRows = False
        Me.CustomDataGridViewEstancias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CustomDataGridViewEstancias.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.CustomDataGridViewEstancias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CustomDataGridViewEstancias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.CustomDataGridViewEstancias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomDataGridViewEstancias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Institucion, Me.NombreProyecto, Me.FechaInicio, Me.FechaTermino})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CustomDataGridViewEstancias.DefaultCellStyle = DataGridViewCellStyle2
        Me.CustomDataGridViewEstancias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomDataGridViewEstancias.Location = New System.Drawing.Point(53, 53)
        Me.CustomDataGridViewEstancias.MultiSelect = False
        Me.CustomDataGridViewEstancias.Name = "CustomDataGridViewEstancias"
        Me.CustomDataGridViewEstancias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CustomDataGridViewEstancias.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.CustomDataGridViewEstancias.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.CustomDataGridViewEstancias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CustomDataGridViewEstancias.Size = New System.Drawing.Size(757, 231)
        Me.CustomDataGridViewEstancias.TabIndex = 9
        '
        'CustomDataGridViewProductosInvestigacion
        '
        Me.CustomDataGridViewProductosInvestigacion.AllowUserToAddRows = False
        Me.CustomDataGridViewProductosInvestigacion.AllowUserToDeleteRows = False
        Me.CustomDataGridViewProductosInvestigacion.AllowUserToResizeColumns = False
        Me.CustomDataGridViewProductosInvestigacion.AllowUserToResizeRows = False
        Me.CustomDataGridViewProductosInvestigacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CustomDataGridViewProductosInvestigacion.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.CustomDataGridViewProductosInvestigacion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CustomDataGridViewProductosInvestigacion.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.CustomDataGridViewProductosInvestigacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomDataGridViewProductosInvestigacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Titulo, Me.Proposito, Me.FechaPublicacion, Me.TipoProducto})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CustomDataGridViewProductosInvestigacion.DefaultCellStyle = DataGridViewCellStyle5
        Me.CustomDataGridViewProductosInvestigacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomDataGridViewProductosInvestigacion.Location = New System.Drawing.Point(53, 390)
        Me.CustomDataGridViewProductosInvestigacion.MultiSelect = False
        Me.CustomDataGridViewProductosInvestigacion.Name = "CustomDataGridViewProductosInvestigacion"
        Me.CustomDataGridViewProductosInvestigacion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CustomDataGridViewProductosInvestigacion.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.CustomDataGridViewProductosInvestigacion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.CustomDataGridViewProductosInvestigacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CustomDataGridViewProductosInvestigacion.Size = New System.Drawing.Size(757, 231)
        Me.CustomDataGridViewProductosInvestigacion.TabIndex = 10
        '
        'Institucion
        '
        Me.Institucion.HeaderText = "Institucion"
        Me.Institucion.Name = "Institucion"
        '
        'NombreProyecto
        '
        Me.NombreProyecto.HeaderText = "Nombre del proyecto"
        Me.NombreProyecto.Name = "NombreProyecto"
        '
        'FechaInicio
        '
        Me.FechaInicio.HeaderText = "Fecha de inicio"
        Me.FechaInicio.Name = "FechaInicio"
        '
        'FechaTermino
        '
        Me.FechaTermino.HeaderText = "Fecha de termino"
        Me.FechaTermino.Name = "FechaTermino"
        '
        'Titulo
        '
        Me.Titulo.HeaderText = "Titulo"
        Me.Titulo.Name = "Titulo"
        '
        'Proposito
        '
        Me.Proposito.HeaderText = "Proposito"
        Me.Proposito.Name = "Proposito"
        '
        'FechaPublicacion
        '
        Me.FechaPublicacion.HeaderText = "Fecha de publicacion"
        Me.FechaPublicacion.Name = "FechaPublicacion"
        '
        'TipoProducto
        '
        Me.TipoProducto.HeaderText = "Tipo de producto"
        Me.TipoProducto.Name = "TipoProducto"
        '
        'ProductividadAcademicaModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanelContent)
        Me.Name = "ProductividadAcademicaModule"
        Me.Size = New System.Drawing.Size(863, 664)
        Me.TableLayoutPanelContent.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel3.ResumeLayout(False)
        CType(Me.CustomDataGridViewEstancias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomDataGridViewProductosInvestigacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanelContent As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents EliminarButtonEstancias As EliminarButton
    Friend WithEvents EditarButtonEstancias As EditarButton
    Friend WithEvents AgregarButtonEstancias As AgregarButton
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents EliminarButtonProductosInvestigacion As EliminarButton
    Friend WithEvents EditarButtonProductosInvestigacion As EditarButton
    Friend WithEvents AgregarButtonProductosInvestigacion As AgregarButton
    Friend WithEvents CustomDataGridViewEstancias As CustomDataGridView
    Friend WithEvents CustomDataGridViewProductosInvestigacion As CustomDataGridView
    Friend WithEvents Institucion As DataGridViewTextBoxColumn
    Friend WithEvents NombreProyecto As DataGridViewTextBoxColumn
    Friend WithEvents FechaInicio As DataGridViewTextBoxColumn
    Friend WithEvents FechaTermino As DataGridViewTextBoxColumn
    Friend WithEvents Titulo As DataGridViewTextBoxColumn
    Friend WithEvents Proposito As DataGridViewTextBoxColumn
    Friend WithEvents FechaPublicacion As DataGridViewTextBoxColumn
    Friend WithEvents TipoProducto As DataGridViewTextBoxColumn
End Class
