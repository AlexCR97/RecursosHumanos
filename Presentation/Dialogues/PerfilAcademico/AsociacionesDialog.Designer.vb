<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AsociacionesDialog
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxOrganismo = New System.Windows.Forms.TextBox()
        Me.DateTimePickerInicioVigencia = New System.Windows.Forms.DateTimePicker()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.CancelarButton1 = New Presentation.CancelarButton()
        Me.GuardarButton1 = New Presentation.GuardarButton()
        Me.TextBoxNombramiento = New System.Windows.Forms.TextBox()
        Me.DateTimePickerAñoAfiliacion = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerFinVigencia = New System.Windows.Forms.DateTimePicker()
        Me.PanelContent.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelContent
        '
        Me.PanelContent.Controls.Add(Me.TableLayoutPanel1)
        Me.PanelContent.Size = New System.Drawing.Size(554, 263)
        '
        'LabelTitle
        '
        Me.LabelTitle.Size = New System.Drawing.Size(554, 68)
        Me.LabelTitle.Text = "Asociacion"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 325.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxOrganismo, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DateTimePickerInicioVigencia, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 2, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxNombramiento, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.DateTimePickerAñoAfiliacion, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.DateTimePickerFinVigencia, 2, 5)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(554, 263)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 35)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Organismo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 35)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nombramiento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(35, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(159, 35)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Año de afiliacion"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(35, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(159, 35)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Inicio de vigencia"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(35, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(159, 35)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Fin de vigencia"
        '
        'TextBoxOrganismo
        '
        Me.TextBoxOrganismo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxOrganismo.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxOrganismo.Location = New System.Drawing.Point(200, 13)
        Me.TextBoxOrganismo.Name = "TextBoxOrganismo"
        Me.TextBoxOrganismo.Size = New System.Drawing.Size(319, 27)
        Me.TextBoxOrganismo.TabIndex = 12
        '
        'DateTimePickerInicioVigencia
        '
        Me.DateTimePickerInicioVigencia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateTimePickerInicioVigencia.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerInicioVigencia.Location = New System.Drawing.Point(200, 118)
        Me.DateTimePickerInicioVigencia.Name = "DateTimePickerInicioVigencia"
        Me.DateTimePickerInicioVigencia.Size = New System.Drawing.Size(319, 27)
        Me.DateTimePickerInicioVigencia.TabIndex = 15
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.CancelarButton1)
        Me.FlowLayoutPanel1.Controls.Add(Me.GuardarButton1)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(200, 198)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(319, 62)
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
        'TextBoxNombramiento
        '
        Me.TextBoxNombramiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxNombramiento.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNombramiento.Location = New System.Drawing.Point(200, 48)
        Me.TextBoxNombramiento.Name = "TextBoxNombramiento"
        Me.TextBoxNombramiento.Size = New System.Drawing.Size(319, 27)
        Me.TextBoxNombramiento.TabIndex = 21
        '
        'DateTimePickerAñoAfiliacion
        '
        Me.DateTimePickerAñoAfiliacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateTimePickerAñoAfiliacion.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerAñoAfiliacion.Location = New System.Drawing.Point(200, 83)
        Me.DateTimePickerAñoAfiliacion.Name = "DateTimePickerAñoAfiliacion"
        Me.DateTimePickerAñoAfiliacion.Size = New System.Drawing.Size(319, 27)
        Me.DateTimePickerAñoAfiliacion.TabIndex = 22
        '
        'DateTimePickerFinVigencia
        '
        Me.DateTimePickerFinVigencia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateTimePickerFinVigencia.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerFinVigencia.Location = New System.Drawing.Point(200, 153)
        Me.DateTimePickerFinVigencia.Name = "DateTimePickerFinVigencia"
        Me.DateTimePickerFinVigencia.Size = New System.Drawing.Size(319, 27)
        Me.DateTimePickerFinVigencia.TabIndex = 23
        '
        'AsociacionesDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 331)
        Me.Name = "AsociacionesDialog"
        Me.Text = ""
        Me.PanelContent.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxOrganismo As TextBox
    Friend WithEvents DateTimePickerInicioVigencia As DateTimePicker
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents CancelarButton1 As CancelarButton
    Friend WithEvents GuardarButton1 As GuardarButton
    Friend WithEvents TextBoxNombramiento As TextBox
    Friend WithEvents DateTimePickerAñoAfiliacion As DateTimePicker
    Friend WithEvents DateTimePickerFinVigencia As DateTimePicker
End Class
