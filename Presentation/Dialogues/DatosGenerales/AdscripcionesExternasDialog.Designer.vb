<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdscripcionesExternasDialog
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxInstitucion = New System.Windows.Forms.TextBox()
        Me.TextBoxPuesto = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.CancelarButton1 = New Presentation.CancelarButton()
        Me.GuardarButton1 = New Presentation.GuardarButton()
        Me.DateTimePickerFechaNombramiento = New System.Windows.Forms.DateTimePicker()
        Me.CheckBoxVigente = New System.Windows.Forms.CheckBox()
        Me.PanelContent.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelContent
        '
        Me.PanelContent.Controls.Add(Me.TableLayoutPanel1)
        Me.PanelContent.Size = New System.Drawing.Size(554, 225)
        '
        'LabelTitle
        '
        Me.LabelTitle.Size = New System.Drawing.Size(554, 68)
        Me.LabelTitle.Text = "Adscripcion externa"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 325.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxInstitucion, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxPuesto, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 2, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.DateTimePickerFechaNombramiento, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.CheckBoxVigente, 2, 4)
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
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(554, 225)
        Me.TableLayoutPanel1.TabIndex = 1
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 35)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Puesto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 35)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha nombramiento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 35)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Vigente"
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
        'TextBoxPuesto
        '
        Me.TextBoxPuesto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxPuesto.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPuesto.Location = New System.Drawing.Point(200, 48)
        Me.TextBoxPuesto.Name = "TextBoxPuesto"
        Me.TextBoxPuesto.Size = New System.Drawing.Size(319, 27)
        Me.TextBoxPuesto.TabIndex = 11
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.CancelarButton1)
        Me.FlowLayoutPanel1.Controls.Add(Me.GuardarButton1)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(200, 163)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(319, 59)
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
        'DateTimePickerFechaNombramiento
        '
        Me.DateTimePickerFechaNombramiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateTimePickerFechaNombramiento.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerFechaNombramiento.Location = New System.Drawing.Point(200, 83)
        Me.DateTimePickerFechaNombramiento.Name = "DateTimePickerFechaNombramiento"
        Me.DateTimePickerFechaNombramiento.Size = New System.Drawing.Size(319, 27)
        Me.DateTimePickerFechaNombramiento.TabIndex = 15
        '
        'CheckBoxVigente
        '
        Me.CheckBoxVigente.AutoSize = True
        Me.CheckBoxVigente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckBoxVigente.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxVigente.Location = New System.Drawing.Point(200, 118)
        Me.CheckBoxVigente.Name = "CheckBoxVigente"
        Me.CheckBoxVigente.Size = New System.Drawing.Size(319, 29)
        Me.CheckBoxVigente.TabIndex = 23
        Me.CheckBoxVigente.Text = "Seleccione si la adscripcion sigue vigente"
        Me.CheckBoxVigente.UseVisualStyleBackColor = True
        '
        'AdscripcionesExternasDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 293)
        Me.Name = "AdscripcionesExternasDialog"
        Me.Text = ""
        Me.PanelContent.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxInstitucion As TextBox
    Friend WithEvents TextBoxPuesto As TextBox
    Friend WithEvents DateTimePickerFechaNombramiento As DateTimePicker
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents CancelarButton1 As CancelarButton
    Friend WithEvents GuardarButton1 As GuardarButton
    Friend WithEvents CheckBoxVigente As CheckBox
End Class
