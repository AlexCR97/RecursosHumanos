<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DistincionesModule
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanelContent = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.EliminarButtonCertificaciones = New Presentation.EliminarButton()
        Me.EditarButtonCertificaciones = New Presentation.EditarButton()
        Me.AgregarButtonCertificaciones = New Presentation.AgregarButton()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.EliminarButtonPremios = New Presentation.EliminarButton()
        Me.EditarButtonPremios = New Presentation.EditarButton()
        Me.AgregarButtonPremios = New Presentation.AgregarButton()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.EliminarButtonColegios = New Presentation.EliminarButton()
        Me.EditarButtonColegios = New Presentation.EditarButton()
        Me.AgregarButtonColegios = New Presentation.AgregarButton()
        Me.CustomDataGridViewCertificaciones = New Presentation.CustomDataGridView()
        Me.CustomDataGridViewPremios = New Presentation.CustomDataGridView()
        Me.CustomDataGridViewColegios = New Presentation.CustomDataGridView()
        Me.Institucion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionCertificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCertificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaLimite = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InstitucionPremios = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionPremios = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCertificacionPremios = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombramiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colegio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Afiliacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanelContent.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.FlowLayoutPanel4.SuspendLayout()
        CType(Me.CustomDataGridViewCertificaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomDataGridViewPremios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomDataGridViewColegios, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanelContent.Controls.Add(Me.Label3, 1, 10)
        Me.TableLayoutPanelContent.Controls.Add(Me.Panel1, 1, 1)
        Me.TableLayoutPanelContent.Controls.Add(Me.FlowLayoutPanel1, 1, 6)
        Me.TableLayoutPanelContent.Controls.Add(Me.Panel2, 1, 11)
        Me.TableLayoutPanelContent.Controls.Add(Me.FlowLayoutPanel2, 1, 3)
        Me.TableLayoutPanelContent.Controls.Add(Me.FlowLayoutPanel3, 1, 8)
        Me.TableLayoutPanelContent.Controls.Add(Me.FlowLayoutPanel4, 1, 13)
        Me.TableLayoutPanelContent.Controls.Add(Me.CustomDataGridViewCertificaciones, 1, 2)
        Me.TableLayoutPanelContent.Controls.Add(Me.CustomDataGridViewPremios, 1, 7)
        Me.TableLayoutPanelContent.Controls.Add(Me.CustomDataGridViewColegios, 1, 12)
        Me.TableLayoutPanelContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelContent.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelContent.Name = "TableLayoutPanelContent"
        Me.TableLayoutPanelContent.RowCount = 14
        Me.TableLayoutPanelContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanelContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanelContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanelContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanelContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanelContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanelContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanelContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanelContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanelContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanelContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanelContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanelContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
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
        Me.Label1.Text = "Certificaciones"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Corbel", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(53, 224)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(757, 40)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Premios"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Corbel", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(53, 448)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(757, 40)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Colegios"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft
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
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(53, 267)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(757, 4)
        Me.FlowLayoutPanel1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(53, 491)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(757, 4)
        Me.Panel2.TabIndex = 5
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.EliminarButtonCertificaciones)
        Me.FlowLayoutPanel2.Controls.Add(Me.EditarButtonCertificaciones)
        Me.FlowLayoutPanel2.Controls.Add(Me.AgregarButtonCertificaciones)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(53, 177)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(757, 34)
        Me.FlowLayoutPanel2.TabIndex = 6
        '
        'EliminarButtonCertificaciones
        '
        Me.EliminarButtonCertificaciones.BackColor = System.Drawing.Color.Firebrick
        Me.EliminarButtonCertificaciones.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EliminarButtonCertificaciones.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.EliminarButtonCertificaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EliminarButtonCertificaciones.Location = New System.Drawing.Point(679, 3)
        Me.EliminarButtonCertificaciones.Name = "EliminarButtonCertificaciones"
        Me.EliminarButtonCertificaciones.Size = New System.Drawing.Size(75, 30)
        Me.EliminarButtonCertificaciones.TabIndex = 0
        Me.EliminarButtonCertificaciones.Text = "Eliminar"
        Me.EliminarButtonCertificaciones.UseVisualStyleBackColor = False
        '
        'EditarButtonCertificaciones
        '
        Me.EditarButtonCertificaciones.BackColor = System.Drawing.Color.SeaGreen
        Me.EditarButtonCertificaciones.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditarButtonCertificaciones.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.EditarButtonCertificaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EditarButtonCertificaciones.Location = New System.Drawing.Point(598, 3)
        Me.EditarButtonCertificaciones.Name = "EditarButtonCertificaciones"
        Me.EditarButtonCertificaciones.Size = New System.Drawing.Size(75, 30)
        Me.EditarButtonCertificaciones.TabIndex = 1
        Me.EditarButtonCertificaciones.Text = "Editar"
        Me.EditarButtonCertificaciones.UseVisualStyleBackColor = False
        '
        'AgregarButtonCertificaciones
        '
        Me.AgregarButtonCertificaciones.BackColor = System.Drawing.Color.SteelBlue
        Me.AgregarButtonCertificaciones.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgregarButtonCertificaciones.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.AgregarButtonCertificaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AgregarButtonCertificaciones.Location = New System.Drawing.Point(517, 3)
        Me.AgregarButtonCertificaciones.Name = "AgregarButtonCertificaciones"
        Me.AgregarButtonCertificaciones.Size = New System.Drawing.Size(75, 30)
        Me.AgregarButtonCertificaciones.TabIndex = 2
        Me.AgregarButtonCertificaciones.Text = "Agregar"
        Me.AgregarButtonCertificaciones.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.EliminarButtonPremios)
        Me.FlowLayoutPanel3.Controls.Add(Me.EditarButtonPremios)
        Me.FlowLayoutPanel3.Controls.Add(Me.AgregarButtonPremios)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(53, 401)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(757, 34)
        Me.FlowLayoutPanel3.TabIndex = 7
        '
        'EliminarButtonPremios
        '
        Me.EliminarButtonPremios.BackColor = System.Drawing.Color.Firebrick
        Me.EliminarButtonPremios.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EliminarButtonPremios.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.EliminarButtonPremios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EliminarButtonPremios.Location = New System.Drawing.Point(679, 3)
        Me.EliminarButtonPremios.Name = "EliminarButtonPremios"
        Me.EliminarButtonPremios.Size = New System.Drawing.Size(75, 30)
        Me.EliminarButtonPremios.TabIndex = 0
        Me.EliminarButtonPremios.Text = "Eliminar"
        Me.EliminarButtonPremios.UseVisualStyleBackColor = False
        '
        'EditarButtonPremios
        '
        Me.EditarButtonPremios.BackColor = System.Drawing.Color.SeaGreen
        Me.EditarButtonPremios.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditarButtonPremios.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.EditarButtonPremios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EditarButtonPremios.Location = New System.Drawing.Point(598, 3)
        Me.EditarButtonPremios.Name = "EditarButtonPremios"
        Me.EditarButtonPremios.Size = New System.Drawing.Size(75, 30)
        Me.EditarButtonPremios.TabIndex = 1
        Me.EditarButtonPremios.Text = "Editar"
        Me.EditarButtonPremios.UseVisualStyleBackColor = False
        '
        'AgregarButtonPremios
        '
        Me.AgregarButtonPremios.BackColor = System.Drawing.Color.SteelBlue
        Me.AgregarButtonPremios.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgregarButtonPremios.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.AgregarButtonPremios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AgregarButtonPremios.Location = New System.Drawing.Point(517, 3)
        Me.AgregarButtonPremios.Name = "AgregarButtonPremios"
        Me.AgregarButtonPremios.Size = New System.Drawing.Size(75, 30)
        Me.AgregarButtonPremios.TabIndex = 2
        Me.AgregarButtonPremios.Text = "Agregar"
        Me.AgregarButtonPremios.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.Controls.Add(Me.EliminarButtonColegios)
        Me.FlowLayoutPanel4.Controls.Add(Me.EditarButtonColegios)
        Me.FlowLayoutPanel4.Controls.Add(Me.AgregarButtonColegios)
        Me.FlowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(53, 625)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(757, 36)
        Me.FlowLayoutPanel4.TabIndex = 8
        '
        'EliminarButtonColegios
        '
        Me.EliminarButtonColegios.BackColor = System.Drawing.Color.Firebrick
        Me.EliminarButtonColegios.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EliminarButtonColegios.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.EliminarButtonColegios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EliminarButtonColegios.Location = New System.Drawing.Point(679, 3)
        Me.EliminarButtonColegios.Name = "EliminarButtonColegios"
        Me.EliminarButtonColegios.Size = New System.Drawing.Size(75, 30)
        Me.EliminarButtonColegios.TabIndex = 0
        Me.EliminarButtonColegios.Text = "Eliminar"
        Me.EliminarButtonColegios.UseVisualStyleBackColor = False
        '
        'EditarButtonColegios
        '
        Me.EditarButtonColegios.BackColor = System.Drawing.Color.SeaGreen
        Me.EditarButtonColegios.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditarButtonColegios.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.EditarButtonColegios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EditarButtonColegios.Location = New System.Drawing.Point(598, 3)
        Me.EditarButtonColegios.Name = "EditarButtonColegios"
        Me.EditarButtonColegios.Size = New System.Drawing.Size(75, 30)
        Me.EditarButtonColegios.TabIndex = 1
        Me.EditarButtonColegios.Text = "Editar"
        Me.EditarButtonColegios.UseVisualStyleBackColor = False
        '
        'AgregarButtonColegios
        '
        Me.AgregarButtonColegios.BackColor = System.Drawing.Color.SteelBlue
        Me.AgregarButtonColegios.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgregarButtonColegios.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.AgregarButtonColegios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AgregarButtonColegios.Location = New System.Drawing.Point(517, 3)
        Me.AgregarButtonColegios.Name = "AgregarButtonColegios"
        Me.AgregarButtonColegios.Size = New System.Drawing.Size(75, 30)
        Me.AgregarButtonColegios.TabIndex = 2
        Me.AgregarButtonColegios.Text = "Agregar"
        Me.AgregarButtonColegios.UseVisualStyleBackColor = False
        '
        'CustomDataGridViewCertificaciones
        '
        Me.CustomDataGridViewCertificaciones.AllowUserToAddRows = False
        Me.CustomDataGridViewCertificaciones.AllowUserToDeleteRows = False
        Me.CustomDataGridViewCertificaciones.AllowUserToResizeColumns = False
        Me.CustomDataGridViewCertificaciones.AllowUserToResizeRows = False
        Me.CustomDataGridViewCertificaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CustomDataGridViewCertificaciones.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.CustomDataGridViewCertificaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CustomDataGridViewCertificaciones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.CustomDataGridViewCertificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomDataGridViewCertificaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Institucion, Me.DescripcionCertificacion, Me.FechaCertificacion, Me.FechaLimite})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CustomDataGridViewCertificaciones.DefaultCellStyle = DataGridViewCellStyle2
        Me.CustomDataGridViewCertificaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomDataGridViewCertificaciones.Location = New System.Drawing.Point(53, 53)
        Me.CustomDataGridViewCertificaciones.MultiSelect = False
        Me.CustomDataGridViewCertificaciones.Name = "CustomDataGridViewCertificaciones"
        Me.CustomDataGridViewCertificaciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CustomDataGridViewCertificaciones.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.CustomDataGridViewCertificaciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.CustomDataGridViewCertificaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CustomDataGridViewCertificaciones.Size = New System.Drawing.Size(757, 118)
        Me.CustomDataGridViewCertificaciones.TabIndex = 9
        '
        'CustomDataGridViewPremios
        '
        Me.CustomDataGridViewPremios.AllowUserToAddRows = False
        Me.CustomDataGridViewPremios.AllowUserToDeleteRows = False
        Me.CustomDataGridViewPremios.AllowUserToResizeColumns = False
        Me.CustomDataGridViewPremios.AllowUserToResizeRows = False
        Me.CustomDataGridViewPremios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CustomDataGridViewPremios.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.CustomDataGridViewPremios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CustomDataGridViewPremios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.CustomDataGridViewPremios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomDataGridViewPremios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.InstitucionPremios, Me.DescripcionPremios, Me.FechaCertificacionPremios})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CustomDataGridViewPremios.DefaultCellStyle = DataGridViewCellStyle5
        Me.CustomDataGridViewPremios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomDataGridViewPremios.Location = New System.Drawing.Point(53, 277)
        Me.CustomDataGridViewPremios.MultiSelect = False
        Me.CustomDataGridViewPremios.Name = "CustomDataGridViewPremios"
        Me.CustomDataGridViewPremios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CustomDataGridViewPremios.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.CustomDataGridViewPremios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.CustomDataGridViewPremios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CustomDataGridViewPremios.Size = New System.Drawing.Size(757, 118)
        Me.CustomDataGridViewPremios.TabIndex = 10
        '
        'CustomDataGridViewColegios
        '
        Me.CustomDataGridViewColegios.AllowUserToAddRows = False
        Me.CustomDataGridViewColegios.AllowUserToDeleteRows = False
        Me.CustomDataGridViewColegios.AllowUserToResizeColumns = False
        Me.CustomDataGridViewColegios.AllowUserToResizeRows = False
        Me.CustomDataGridViewColegios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CustomDataGridViewColegios.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.CustomDataGridViewColegios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CustomDataGridViewColegios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.CustomDataGridViewColegios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.CustomDataGridViewColegios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombramiento, Me.Colegio, Me.Afiliacion})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CustomDataGridViewColegios.DefaultCellStyle = DataGridViewCellStyle8
        Me.CustomDataGridViewColegios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomDataGridViewColegios.Location = New System.Drawing.Point(53, 501)
        Me.CustomDataGridViewColegios.MultiSelect = False
        Me.CustomDataGridViewColegios.Name = "CustomDataGridViewColegios"
        Me.CustomDataGridViewColegios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CustomDataGridViewColegios.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.CustomDataGridViewColegios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.CustomDataGridViewColegios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CustomDataGridViewColegios.Size = New System.Drawing.Size(757, 118)
        Me.CustomDataGridViewColegios.TabIndex = 0
        '
        'Institucion
        '
        Me.Institucion.HeaderText = "Institucion"
        Me.Institucion.Name = "Institucion"
        '
        'DescripcionCertificacion
        '
        Me.DescripcionCertificacion.HeaderText = "Descripcion"
        Me.DescripcionCertificacion.Name = "DescripcionCertificacion"
        '
        'FechaCertificacion
        '
        Me.FechaCertificacion.HeaderText = "Fecha de certificacion"
        Me.FechaCertificacion.Name = "FechaCertificacion"
        '
        'FechaLimite
        '
        Me.FechaLimite.HeaderText = "Fecha limite"
        Me.FechaLimite.Name = "FechaLimite"
        '
        'InstitucionPremios
        '
        Me.InstitucionPremios.HeaderText = "Institucion"
        Me.InstitucionPremios.Name = "InstitucionPremios"
        '
        'DescripcionPremios
        '
        Me.DescripcionPremios.HeaderText = "Descripcion"
        Me.DescripcionPremios.Name = "DescripcionPremios"
        '
        'FechaCertificacionPremios
        '
        Me.FechaCertificacionPremios.HeaderText = "Fecha de certificacion"
        Me.FechaCertificacionPremios.Name = "FechaCertificacionPremios"
        '
        'Nombramiento
        '
        Me.Nombramiento.HeaderText = "Nombramiento"
        Me.Nombramiento.Name = "Nombramiento"
        '
        'Colegio
        '
        Me.Colegio.HeaderText = "Colegio"
        Me.Colegio.Name = "Colegio"
        '
        'Afiliacion
        '
        Me.Afiliacion.HeaderText = "Afiliacion"
        Me.Afiliacion.Name = "Afiliacion"
        '
        'DistincionesModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanelContent)
        Me.Name = "DistincionesModule"
        Me.Size = New System.Drawing.Size(863, 664)
        Me.TableLayoutPanelContent.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel4.ResumeLayout(False)
        CType(Me.CustomDataGridViewCertificaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomDataGridViewPremios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomDataGridViewColegios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanelContent As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents EliminarButtonCertificaciones As EliminarButton
    Friend WithEvents EditarButtonCertificaciones As EditarButton
    Friend WithEvents AgregarButtonCertificaciones As AgregarButton
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents EliminarButtonPremios As EliminarButton
    Friend WithEvents EditarButtonPremios As EditarButton
    Friend WithEvents AgregarButtonPremios As AgregarButton
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents EliminarButtonColegios As EliminarButton
    Friend WithEvents EditarButtonColegios As EditarButton
    Friend WithEvents AgregarButtonColegios As AgregarButton
    Friend WithEvents CustomDataGridViewCertificaciones As CustomDataGridView
    Friend WithEvents CustomDataGridViewPremios As CustomDataGridView
    Friend WithEvents CustomDataGridViewColegios As CustomDataGridView
    Friend WithEvents Institucion As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionCertificacion As DataGridViewTextBoxColumn
    Friend WithEvents FechaCertificacion As DataGridViewTextBoxColumn
    Friend WithEvents FechaLimite As DataGridViewTextBoxColumn
    Friend WithEvents InstitucionPremios As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionPremios As DataGridViewTextBoxColumn
    Friend WithEvents FechaCertificacionPremios As DataGridViewTextBoxColumn
    Friend WithEvents Nombramiento As DataGridViewTextBoxColumn
    Friend WithEvents Colegio As DataGridViewTextBoxColumn
    Friend WithEvents Afiliacion As DataGridViewTextBoxColumn
End Class
