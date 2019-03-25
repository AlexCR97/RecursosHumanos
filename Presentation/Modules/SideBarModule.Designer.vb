<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SideBarModule
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
        Me.ButtonDatosGenerales = New System.Windows.Forms.Button()
        Me.ButtonPerfilAcademico = New System.Windows.Forms.Button()
        Me.ButtonResumen = New System.Windows.Forms.Button()
        Me.TableLayoutPanelButtons = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBoxExpandOrShrink = New System.Windows.Forms.PictureBox()
        Me.PictureBoxDatosGenerales = New System.Windows.Forms.PictureBox()
        Me.PictureBoxPerfilAcademico = New System.Windows.Forms.PictureBox()
        Me.PictureBoxResumen = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanelButtons.SuspendLayout()
        CType(Me.PictureBoxExpandOrShrink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxDatosGenerales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxPerfilAcademico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxResumen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonDatosGenerales
        '
        Me.ButtonDatosGenerales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonDatosGenerales.FlatAppearance.BorderSize = 0
        Me.ButtonDatosGenerales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue
        Me.ButtonDatosGenerales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDatosGenerales.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDatosGenerales.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonDatosGenerales.Location = New System.Drawing.Point(73, 63)
        Me.ButtonDatosGenerales.Name = "ButtonDatosGenerales"
        Me.ButtonDatosGenerales.Size = New System.Drawing.Size(134, 54)
        Me.ButtonDatosGenerales.TabIndex = 0
        Me.ButtonDatosGenerales.Text = "Datos generales"
        Me.ButtonDatosGenerales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonDatosGenerales.UseVisualStyleBackColor = True
        '
        'ButtonPerfilAcademico
        '
        Me.ButtonPerfilAcademico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonPerfilAcademico.FlatAppearance.BorderSize = 0
        Me.ButtonPerfilAcademico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue
        Me.ButtonPerfilAcademico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPerfilAcademico.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPerfilAcademico.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonPerfilAcademico.Location = New System.Drawing.Point(73, 123)
        Me.ButtonPerfilAcademico.Name = "ButtonPerfilAcademico"
        Me.ButtonPerfilAcademico.Size = New System.Drawing.Size(134, 54)
        Me.ButtonPerfilAcademico.TabIndex = 1
        Me.ButtonPerfilAcademico.Text = "Perfil academico"
        Me.ButtonPerfilAcademico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonPerfilAcademico.UseVisualStyleBackColor = True
        '
        'ButtonResumen
        '
        Me.ButtonResumen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonResumen.FlatAppearance.BorderSize = 0
        Me.ButtonResumen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue
        Me.ButtonResumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonResumen.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonResumen.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonResumen.Location = New System.Drawing.Point(73, 183)
        Me.ButtonResumen.Name = "ButtonResumen"
        Me.ButtonResumen.Size = New System.Drawing.Size(134, 54)
        Me.ButtonResumen.TabIndex = 3
        Me.ButtonResumen.Text = "Resumen"
        Me.ButtonResumen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonResumen.UseVisualStyleBackColor = True
        '
        'TableLayoutPanelButtons
        '
        Me.TableLayoutPanelButtons.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TableLayoutPanelButtons.ColumnCount = 5
        Me.TableLayoutPanelButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanelButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanelButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanelButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanelButtons.Controls.Add(Me.PictureBoxExpandOrShrink, 1, 0)
        Me.TableLayoutPanelButtons.Controls.Add(Me.PictureBoxDatosGenerales, 1, 1)
        Me.TableLayoutPanelButtons.Controls.Add(Me.PictureBoxPerfilAcademico, 1, 2)
        Me.TableLayoutPanelButtons.Controls.Add(Me.ButtonResumen, 3, 3)
        Me.TableLayoutPanelButtons.Controls.Add(Me.ButtonPerfilAcademico, 3, 2)
        Me.TableLayoutPanelButtons.Controls.Add(Me.ButtonDatosGenerales, 3, 1)
        Me.TableLayoutPanelButtons.Controls.Add(Me.PictureBoxResumen, 1, 3)
        Me.TableLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelButtons.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelButtons.Name = "TableLayoutPanelButtons"
        Me.TableLayoutPanelButtons.RowCount = 5
        Me.TableLayoutPanelButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanelButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanelButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanelButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanelButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelButtons.Size = New System.Drawing.Size(220, 644)
        Me.TableLayoutPanelButtons.TabIndex = 4
        '
        'PictureBoxExpandOrShrink
        '
        Me.PictureBoxExpandOrShrink.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBoxExpandOrShrink.Image = Global.Presentation.My.Resources.Resources.iconMenu
        Me.PictureBoxExpandOrShrink.Location = New System.Drawing.Point(13, 3)
        Me.PictureBoxExpandOrShrink.Name = "PictureBoxExpandOrShrink"
        Me.PictureBoxExpandOrShrink.Size = New System.Drawing.Size(44, 54)
        Me.PictureBoxExpandOrShrink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxExpandOrShrink.TabIndex = 4
        Me.PictureBoxExpandOrShrink.TabStop = False
        '
        'PictureBoxDatosGenerales
        '
        Me.PictureBoxDatosGenerales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBoxDatosGenerales.Image = Global.Presentation.My.Resources.Resources.iconUser
        Me.PictureBoxDatosGenerales.Location = New System.Drawing.Point(13, 63)
        Me.PictureBoxDatosGenerales.Name = "PictureBoxDatosGenerales"
        Me.PictureBoxDatosGenerales.Size = New System.Drawing.Size(44, 54)
        Me.PictureBoxDatosGenerales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxDatosGenerales.TabIndex = 5
        Me.PictureBoxDatosGenerales.TabStop = False
        '
        'PictureBoxPerfilAcademico
        '
        Me.PictureBoxPerfilAcademico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBoxPerfilAcademico.Image = Global.Presentation.My.Resources.Resources.iconEdit
        Me.PictureBoxPerfilAcademico.Location = New System.Drawing.Point(13, 123)
        Me.PictureBoxPerfilAcademico.Name = "PictureBoxPerfilAcademico"
        Me.PictureBoxPerfilAcademico.Size = New System.Drawing.Size(44, 54)
        Me.PictureBoxPerfilAcademico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxPerfilAcademico.TabIndex = 6
        Me.PictureBoxPerfilAcademico.TabStop = False
        '
        'PictureBoxResumen
        '
        Me.PictureBoxResumen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBoxResumen.Image = Global.Presentation.My.Resources.Resources.iconResume
        Me.PictureBoxResumen.Location = New System.Drawing.Point(13, 183)
        Me.PictureBoxResumen.Name = "PictureBoxResumen"
        Me.PictureBoxResumen.Size = New System.Drawing.Size(44, 54)
        Me.PictureBoxResumen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxResumen.TabIndex = 8
        Me.PictureBoxResumen.TabStop = False
        '
        'SideBarModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Controls.Add(Me.TableLayoutPanelButtons)
        Me.Name = "SideBarModule"
        Me.Size = New System.Drawing.Size(220, 644)
        Me.TableLayoutPanelButtons.ResumeLayout(False)
        CType(Me.PictureBoxExpandOrShrink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxDatosGenerales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxPerfilAcademico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxResumen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonDatosGenerales As Button
    Friend WithEvents ButtonPerfilAcademico As Button
    Friend WithEvents ButtonResumen As Button
    Friend WithEvents TableLayoutPanelButtons As TableLayoutPanel
    Friend WithEvents PictureBoxExpandOrShrink As PictureBox
    Friend WithEvents PictureBoxDatosGenerales As PictureBox
    Friend WithEvents PictureBoxPerfilAcademico As PictureBox
    Friend WithEvents PictureBoxResumen As PictureBox
End Class
