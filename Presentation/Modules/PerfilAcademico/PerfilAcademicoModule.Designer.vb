<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PerfilAcademicoModule
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
        Me.TableLayoutPanelContent = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanelSubContent = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonTitulosAcademicos = New System.Windows.Forms.Button()
        Me.ButtonProductividadAcademica = New System.Windows.Forms.Button()
        Me.ButtonDistinciones = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.ButtonAsociaciones = New System.Windows.Forms.Button()
        Me.TableLayoutPanelContent.SuspendLayout()
        Me.TableLayoutPanelSubContent.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanelContent
        '
        Me.TableLayoutPanelContent.ColumnCount = 3
        Me.TableLayoutPanelContent.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelContent.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 550.0!))
        Me.TableLayoutPanelContent.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelContent.Controls.Add(Me.TableLayoutPanelSubContent, 1, 0)
        Me.TableLayoutPanelContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelContent.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelContent.Name = "TableLayoutPanelContent"
        Me.TableLayoutPanelContent.RowCount = 1
        Me.TableLayoutPanelContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 511.0!))
        Me.TableLayoutPanelContent.Size = New System.Drawing.Size(861, 511)
        Me.TableLayoutPanelContent.TabIndex = 1
        '
        'TableLayoutPanelSubContent
        '
        Me.TableLayoutPanelSubContent.ColumnCount = 2
        Me.TableLayoutPanelSubContent.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanelSubContent.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelSubContent.Controls.Add(Me.ButtonTitulosAcademicos, 1, 0)
        Me.TableLayoutPanelSubContent.Controls.Add(Me.ButtonProductividadAcademica, 1, 1)
        Me.TableLayoutPanelSubContent.Controls.Add(Me.ButtonDistinciones, 1, 2)
        Me.TableLayoutPanelSubContent.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanelSubContent.Controls.Add(Me.PictureBox2, 0, 1)
        Me.TableLayoutPanelSubContent.Controls.Add(Me.PictureBox3, 0, 2)
        Me.TableLayoutPanelSubContent.Controls.Add(Me.PictureBox4, 0, 3)
        Me.TableLayoutPanelSubContent.Controls.Add(Me.ButtonAsociaciones, 1, 3)
        Me.TableLayoutPanelSubContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelSubContent.Location = New System.Drawing.Point(158, 3)
        Me.TableLayoutPanelSubContent.Name = "TableLayoutPanelSubContent"
        Me.TableLayoutPanelSubContent.RowCount = 5
        Me.TableLayoutPanelSubContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanelSubContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanelSubContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanelSubContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanelSubContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelSubContent.Size = New System.Drawing.Size(544, 505)
        Me.TableLayoutPanelSubContent.TabIndex = 0
        '
        'ButtonTitulosAcademicos
        '
        Me.ButtonTitulosAcademicos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonTitulosAcademicos.Font = New System.Drawing.Font("Corbel", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTitulosAcademicos.Location = New System.Drawing.Point(123, 3)
        Me.ButtonTitulosAcademicos.Name = "ButtonTitulosAcademicos"
        Me.ButtonTitulosAcademicos.Size = New System.Drawing.Size(418, 114)
        Me.ButtonTitulosAcademicos.TabIndex = 0
        Me.ButtonTitulosAcademicos.Text = "Titulos academicos"
        Me.ButtonTitulosAcademicos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonTitulosAcademicos.UseVisualStyleBackColor = True
        '
        'ButtonProductividadAcademica
        '
        Me.ButtonProductividadAcademica.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonProductividadAcademica.Font = New System.Drawing.Font("Corbel", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonProductividadAcademica.Location = New System.Drawing.Point(123, 123)
        Me.ButtonProductividadAcademica.Name = "ButtonProductividadAcademica"
        Me.ButtonProductividadAcademica.Size = New System.Drawing.Size(418, 114)
        Me.ButtonProductividadAcademica.TabIndex = 1
        Me.ButtonProductividadAcademica.Text = "Productividad academica"
        Me.ButtonProductividadAcademica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonProductividadAcademica.UseVisualStyleBackColor = True
        '
        'ButtonDistinciones
        '
        Me.ButtonDistinciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonDistinciones.Font = New System.Drawing.Font("Corbel", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDistinciones.Location = New System.Drawing.Point(123, 243)
        Me.ButtonDistinciones.Name = "ButtonDistinciones"
        Me.ButtonDistinciones.Size = New System.Drawing.Size(418, 114)
        Me.ButtonDistinciones.TabIndex = 2
        Me.ButtonDistinciones.Text = "Distinciones"
        Me.ButtonDistinciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonDistinciones.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.Presentation.My.Resources.Resources.iconCorreo
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(114, 114)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = Global.Presentation.My.Resources.Resources.iconUser
        Me.PictureBox2.Location = New System.Drawing.Point(3, 123)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(114, 114)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox3.Image = Global.Presentation.My.Resources.Resources.iconUser
        Me.PictureBox3.Location = New System.Drawing.Point(3, 243)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(114, 114)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox4.Image = Global.Presentation.My.Resources.Resources.iconUser
        Me.PictureBox4.Location = New System.Drawing.Point(3, 363)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(114, 114)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        '
        'ButtonAsociaciones
        '
        Me.ButtonAsociaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonAsociaciones.Font = New System.Drawing.Font("Corbel", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAsociaciones.Location = New System.Drawing.Point(123, 363)
        Me.ButtonAsociaciones.Name = "ButtonAsociaciones"
        Me.ButtonAsociaciones.Size = New System.Drawing.Size(418, 114)
        Me.ButtonAsociaciones.TabIndex = 7
        Me.ButtonAsociaciones.Text = "Asociaciones"
        Me.ButtonAsociaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonAsociaciones.UseVisualStyleBackColor = True
        '
        'PerfilAcademicoModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.TableLayoutPanelContent)
        Me.Name = "PerfilAcademicoModule"
        Me.Size = New System.Drawing.Size(861, 511)
        Me.TableLayoutPanelContent.ResumeLayout(False)
        Me.TableLayoutPanelSubContent.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanelContent As TableLayoutPanel
    Friend WithEvents TableLayoutPanelSubContent As TableLayoutPanel
    Friend WithEvents ButtonTitulosAcademicos As Button
    Friend WithEvents ButtonProductividadAcademica As Button
    Friend WithEvents ButtonDistinciones As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents ButtonAsociaciones As Button
End Class
