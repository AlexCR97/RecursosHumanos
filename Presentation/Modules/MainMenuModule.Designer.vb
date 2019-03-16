<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenuModule
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonDatosGenerales = New System.Windows.Forms.Button()
        Me.ButtonPerfilAcademico = New System.Windows.Forms.Button()
        Me.ButtonAplicaciones = New System.Windows.Forms.Button()
        Me.ButtonResumen = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonDatosGenerales, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonPerfilAcademico, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonAplicaciones, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonResumen, 3, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(907, 619)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'ButtonDatosGenerales
        '
        Me.ButtonDatosGenerales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonDatosGenerales.Font = New System.Drawing.Font("Corbel", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDatosGenerales.Location = New System.Drawing.Point(96, 102)
        Me.ButtonDatosGenerales.Name = "ButtonDatosGenerales"
        Me.ButtonDatosGenerales.Size = New System.Drawing.Size(344, 194)
        Me.ButtonDatosGenerales.TabIndex = 0
        Me.ButtonDatosGenerales.Text = "Datos generales"
        Me.ButtonDatosGenerales.UseVisualStyleBackColor = True
        '
        'ButtonPerfilAcademico
        '
        Me.ButtonPerfilAcademico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonPerfilAcademico.Font = New System.Drawing.Font("Corbel", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPerfilAcademico.Location = New System.Drawing.Point(466, 102)
        Me.ButtonPerfilAcademico.Name = "ButtonPerfilAcademico"
        Me.ButtonPerfilAcademico.Size = New System.Drawing.Size(344, 194)
        Me.ButtonPerfilAcademico.TabIndex = 1
        Me.ButtonPerfilAcademico.Text = "Perfil academico"
        Me.ButtonPerfilAcademico.UseVisualStyleBackColor = True
        '
        'ButtonAplicaciones
        '
        Me.ButtonAplicaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonAplicaciones.Font = New System.Drawing.Font("Corbel", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAplicaciones.Location = New System.Drawing.Point(96, 322)
        Me.ButtonAplicaciones.Name = "ButtonAplicaciones"
        Me.ButtonAplicaciones.Size = New System.Drawing.Size(344, 194)
        Me.ButtonAplicaciones.TabIndex = 2
        Me.ButtonAplicaciones.Text = "Aplicaciones"
        Me.ButtonAplicaciones.UseVisualStyleBackColor = True
        '
        'ButtonResumen
        '
        Me.ButtonResumen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonResumen.Font = New System.Drawing.Font("Corbel", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonResumen.Location = New System.Drawing.Point(466, 322)
        Me.ButtonResumen.Name = "ButtonResumen"
        Me.ButtonResumen.Size = New System.Drawing.Size(344, 194)
        Me.ButtonResumen.TabIndex = 3
        Me.ButtonResumen.Text = "Resumen"
        Me.ButtonResumen.UseVisualStyleBackColor = True
        '
        'MainMenuModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "MainMenuModule"
        Me.Size = New System.Drawing.Size(907, 619)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ButtonDatosGenerales As Button
    Friend WithEvents ButtonPerfilAcademico As Button
    Friend WithEvents ButtonAplicaciones As Button
    Friend WithEvents ButtonResumen As Button
End Class
