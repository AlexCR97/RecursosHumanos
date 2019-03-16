<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TitulosAcademicosModule
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
        Me.CustomDataGridViewTitulosAcademicos = New Presentation.CustomDataGridView()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.AgregarButtonTitulosAcademicos = New Presentation.AgregarButton()
        Me.EditarButtonTitulosAcademicos = New Presentation.EditarButton()
        Me.EliminarButtonTitulosAcademicos = New Presentation.EliminarButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanelContent = New System.Windows.Forms.TableLayoutPanel()
        Me.Institucion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Grado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Titulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaObtencion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroCedula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.CustomDataGridViewTitulosAcademicos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanelContent.SuspendLayout()
        Me.SuspendLayout()
        '
        'CustomDataGridViewTitulosAcademicos
        '
        Me.CustomDataGridViewTitulosAcademicos.AllowUserToAddRows = False
        Me.CustomDataGridViewTitulosAcademicos.AllowUserToDeleteRows = False
        Me.CustomDataGridViewTitulosAcademicos.AllowUserToResizeColumns = False
        Me.CustomDataGridViewTitulosAcademicos.AllowUserToResizeRows = False
        Me.CustomDataGridViewTitulosAcademicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CustomDataGridViewTitulosAcademicos.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.CustomDataGridViewTitulosAcademicos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CustomDataGridViewTitulosAcademicos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.CustomDataGridViewTitulosAcademicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomDataGridViewTitulosAcademicos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Institucion, Me.Grado, Me.Titulo, Me.FechaObtencion, Me.NumeroCedula})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CustomDataGridViewTitulosAcademicos.DefaultCellStyle = DataGridViewCellStyle2
        Me.CustomDataGridViewTitulosAcademicos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomDataGridViewTitulosAcademicos.Location = New System.Drawing.Point(53, 53)
        Me.CustomDataGridViewTitulosAcademicos.MultiSelect = False
        Me.CustomDataGridViewTitulosAcademicos.Name = "CustomDataGridViewTitulosAcademicos"
        Me.CustomDataGridViewTitulosAcademicos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CustomDataGridViewTitulosAcademicos.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.CustomDataGridViewTitulosAcademicos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.CustomDataGridViewTitulosAcademicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CustomDataGridViewTitulosAcademicos.Size = New System.Drawing.Size(757, 568)
        Me.CustomDataGridViewTitulosAcademicos.TabIndex = 9
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.EliminarButtonTitulosAcademicos)
        Me.FlowLayoutPanel2.Controls.Add(Me.EditarButtonTitulosAcademicos)
        Me.FlowLayoutPanel2.Controls.Add(Me.AgregarButtonTitulosAcademicos)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(53, 627)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(757, 34)
        Me.FlowLayoutPanel2.TabIndex = 6
        '
        'AgregarButtonTitulosAcademicos
        '
        Me.AgregarButtonTitulosAcademicos.BackColor = System.Drawing.Color.SteelBlue
        Me.AgregarButtonTitulosAcademicos.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgregarButtonTitulosAcademicos.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.AgregarButtonTitulosAcademicos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AgregarButtonTitulosAcademicos.Location = New System.Drawing.Point(517, 3)
        Me.AgregarButtonTitulosAcademicos.Name = "AgregarButtonTitulosAcademicos"
        Me.AgregarButtonTitulosAcademicos.Size = New System.Drawing.Size(75, 30)
        Me.AgregarButtonTitulosAcademicos.TabIndex = 2
        Me.AgregarButtonTitulosAcademicos.Text = "Agregar"
        Me.AgregarButtonTitulosAcademicos.UseVisualStyleBackColor = False
        '
        'EditarButtonTitulosAcademicos
        '
        Me.EditarButtonTitulosAcademicos.BackColor = System.Drawing.Color.SeaGreen
        Me.EditarButtonTitulosAcademicos.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditarButtonTitulosAcademicos.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.EditarButtonTitulosAcademicos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EditarButtonTitulosAcademicos.Location = New System.Drawing.Point(598, 3)
        Me.EditarButtonTitulosAcademicos.Name = "EditarButtonTitulosAcademicos"
        Me.EditarButtonTitulosAcademicos.Size = New System.Drawing.Size(75, 30)
        Me.EditarButtonTitulosAcademicos.TabIndex = 1
        Me.EditarButtonTitulosAcademicos.Text = "Editar"
        Me.EditarButtonTitulosAcademicos.UseVisualStyleBackColor = False
        '
        'EliminarButtonTitulosAcademicos
        '
        Me.EliminarButtonTitulosAcademicos.BackColor = System.Drawing.Color.Firebrick
        Me.EliminarButtonTitulosAcademicos.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EliminarButtonTitulosAcademicos.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.EliminarButtonTitulosAcademicos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EliminarButtonTitulosAcademicos.Location = New System.Drawing.Point(679, 3)
        Me.EliminarButtonTitulosAcademicos.Name = "EliminarButtonTitulosAcademicos"
        Me.EliminarButtonTitulosAcademicos.Size = New System.Drawing.Size(75, 30)
        Me.EliminarButtonTitulosAcademicos.TabIndex = 0
        Me.EliminarButtonTitulosAcademicos.Text = "Eliminar"
        Me.EliminarButtonTitulosAcademicos.UseVisualStyleBackColor = False
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
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Corbel", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(53, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(757, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Titulos academicos"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
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
        Me.TableLayoutPanelContent.Controls.Add(Me.CustomDataGridViewTitulosAcademicos, 1, 2)
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
        'Institucion
        '
        Me.Institucion.HeaderText = "Institucion"
        Me.Institucion.Name = "Institucion"
        '
        'Grado
        '
        Me.Grado.HeaderText = "Grado"
        Me.Grado.Name = "Grado"
        '
        'Titulo
        '
        Me.Titulo.HeaderText = "Titulo"
        Me.Titulo.Name = "Titulo"
        '
        'FechaObtencion
        '
        Me.FechaObtencion.HeaderText = "Fecha de obtencion"
        Me.FechaObtencion.Name = "FechaObtencion"
        '
        'NumeroCedula
        '
        Me.NumeroCedula.HeaderText = "Numero de cedula"
        Me.NumeroCedula.Name = "NumeroCedula"
        '
        'TitulosAcademicosModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanelContent)
        Me.Name = "TitulosAcademicosModule"
        Me.Size = New System.Drawing.Size(863, 664)
        CType(Me.CustomDataGridViewTitulosAcademicos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanelContent.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CustomDataGridViewTitulosAcademicos As CustomDataGridView
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents EliminarButtonTitulosAcademicos As EliminarButton
    Friend WithEvents EditarButtonTitulosAcademicos As EditarButton
    Friend WithEvents AgregarButtonTitulosAcademicos As AgregarButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanelContent As TableLayoutPanel
    Friend WithEvents Institucion As DataGridViewTextBoxColumn
    Friend WithEvents Grado As DataGridViewTextBoxColumn
    Friend WithEvents Titulo As DataGridViewTextBoxColumn
    Friend WithEvents FechaObtencion As DataGridViewTextBoxColumn
    Friend WithEvents NumeroCedula As DataGridViewTextBoxColumn
End Class
