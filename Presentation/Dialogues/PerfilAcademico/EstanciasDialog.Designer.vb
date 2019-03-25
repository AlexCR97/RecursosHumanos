<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EstanciasDialog
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxInstitucion = New System.Windows.Forms.TextBox()
        Me.TextBoxNombreProyecto = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.CancelarButton1 = New Presentation.CancelarButton()
        Me.GuardarButton1 = New Presentation.GuardarButton()
        Me.DateTimePickerFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerFechaTermino = New System.Windows.Forms.DateTimePicker()
        Me.PanelContent.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelContent
        '
        Me.PanelContent.Controls.Add(Me.TableLayoutPanel1)
        Me.PanelContent.Size = New System.Drawing.Size(554, 226)
        '
        'LabelTitle
        '
        Me.LabelTitle.Size = New System.Drawing.Size(554, 68)
        Me.LabelTitle.Text = "Estancias"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 325.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxInstitucion, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxNombreProyecto, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 2, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.DateTimePickerFechaInicio, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.DateTimePickerFechaTermino, 2, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(554, 226)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Institucion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 35)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre del proyecto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 35)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fecha de inicio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(35, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(159, 35)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fecha de termino"
        '
        'TextBoxInstitucion
        '
        Me.TextBoxInstitucion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxInstitucion.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxInstitucion.Location = New System.Drawing.Point(200, 13)
        Me.TextBoxInstitucion.Name = "TextBoxInstitucion"
        Me.TextBoxInstitucion.Size = New System.Drawing.Size(319, 27)
        Me.TextBoxInstitucion.TabIndex = 10
        '
        'TextBoxNombreProyecto
        '
        Me.TextBoxNombreProyecto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxNombreProyecto.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNombreProyecto.Location = New System.Drawing.Point(200, 48)
        Me.TextBoxNombreProyecto.Name = "TextBoxNombreProyecto"
        Me.TextBoxNombreProyecto.Size = New System.Drawing.Size(319, 27)
        Me.TextBoxNombreProyecto.TabIndex = 12
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.CancelarButton1)
        Me.FlowLayoutPanel1.Controls.Add(Me.GuardarButton1)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(200, 163)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(319, 60)
        Me.FlowLayoutPanel1.TabIndex = 20
        '
        'CancelarButton1
        '
        Me.CancelarButton1.BackColor = System.Drawing.Color.Chocolate
        Me.CancelarButton1.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelarButton1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.CancelarButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CancelarButton1.Location = New System.Drawing.Point(241, 3)
        Me.CancelarButton1.Name = "CancelarButton1"
        Me.CancelarButton1.Size = New System.Drawing.Size(75, 30)
        Me.CancelarButton1.TabIndex = 2
        Me.CancelarButton1.Text = "Cancelar"
        Me.CancelarButton1.UseVisualStyleBackColor = False
        '
        'GuardarButton1
        '
        Me.GuardarButton1.BackColor = System.Drawing.Color.DarkViolet
        Me.GuardarButton1.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuardarButton1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.GuardarButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GuardarButton1.Location = New System.Drawing.Point(160, 3)
        Me.GuardarButton1.Name = "GuardarButton1"
        Me.GuardarButton1.Size = New System.Drawing.Size(75, 30)
        Me.GuardarButton1.TabIndex = 1
        Me.GuardarButton1.Text = "Guardar"
        Me.GuardarButton1.UseVisualStyleBackColor = False
        '
        'DateTimePickerFechaInicio
        '
        Me.DateTimePickerFechaInicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateTimePickerFechaInicio.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerFechaInicio.Location = New System.Drawing.Point(200, 83)
        Me.DateTimePickerFechaInicio.Name = "DateTimePickerFechaInicio"
        Me.DateTimePickerFechaInicio.Size = New System.Drawing.Size(319, 27)
        Me.DateTimePickerFechaInicio.TabIndex = 21
        '
        'DateTimePickerFechaTermino
        '
        Me.DateTimePickerFechaTermino.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateTimePickerFechaTermino.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerFechaTermino.Location = New System.Drawing.Point(200, 118)
        Me.DateTimePickerFechaTermino.Name = "DateTimePickerFechaTermino"
        Me.DateTimePickerFechaTermino.Size = New System.Drawing.Size(319, 27)
        Me.DateTimePickerFechaTermino.TabIndex = 22
        '
        'EstanciasDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 294)
        Me.Name = "EstanciasDialog"
        Me.Text = ""
        Me.PanelContent.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxInstitucion As TextBox
    Friend WithEvents TextBoxNombreProyecto As TextBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents CancelarButton1 As CancelarButton
    Friend WithEvents GuardarButton1 As GuardarButton
    Friend WithEvents DateTimePickerFechaInicio As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePickerFechaTermino As DateTimePicker
End Class
