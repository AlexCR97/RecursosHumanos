<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AplicacionesModule
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
        Me.ButtonAplicacionesVinculadas = New System.Windows.Forms.Button()
        Me.ButtonMensajesDeAplicacion = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanelContent.SuspendLayout()
        Me.TableLayoutPanelSubContent.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanelSubContent.Controls.Add(Me.ButtonAplicacionesVinculadas, 1, 0)
        Me.TableLayoutPanelSubContent.Controls.Add(Me.ButtonMensajesDeAplicacion, 1, 1)
        Me.TableLayoutPanelSubContent.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanelSubContent.Controls.Add(Me.PictureBox2, 0, 1)
        Me.TableLayoutPanelSubContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelSubContent.Location = New System.Drawing.Point(158, 3)
        Me.TableLayoutPanelSubContent.Name = "TableLayoutPanelSubContent"
        Me.TableLayoutPanelSubContent.RowCount = 3
        Me.TableLayoutPanelSubContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanelSubContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanelSubContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelSubContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelSubContent.Size = New System.Drawing.Size(544, 505)
        Me.TableLayoutPanelSubContent.TabIndex = 0
        '
        'ButtonAplicacionesVinculadas
        '
        Me.ButtonAplicacionesVinculadas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonAplicacionesVinculadas.Font = New System.Drawing.Font("Corbel", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAplicacionesVinculadas.Location = New System.Drawing.Point(123, 3)
        Me.ButtonAplicacionesVinculadas.Name = "ButtonAplicacionesVinculadas"
        Me.ButtonAplicacionesVinculadas.Size = New System.Drawing.Size(418, 114)
        Me.ButtonAplicacionesVinculadas.TabIndex = 0
        Me.ButtonAplicacionesVinculadas.Text = "Aplicaciones vinculadas"
        Me.ButtonAplicacionesVinculadas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonAplicacionesVinculadas.UseVisualStyleBackColor = True
        '
        'ButtonMensajesDeAplicacion
        '
        Me.ButtonMensajesDeAplicacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonMensajesDeAplicacion.Font = New System.Drawing.Font("Corbel", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMensajesDeAplicacion.Location = New System.Drawing.Point(123, 123)
        Me.ButtonMensajesDeAplicacion.Name = "ButtonMensajesDeAplicacion"
        Me.ButtonMensajesDeAplicacion.Size = New System.Drawing.Size(418, 114)
        Me.ButtonMensajesDeAplicacion.TabIndex = 1
        Me.ButtonMensajesDeAplicacion.Text = "Mensajes de aplicacion"
        Me.ButtonMensajesDeAplicacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonMensajesDeAplicacion.UseVisualStyleBackColor = True
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
        'AplicacionesModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.TableLayoutPanelContent)
        Me.Name = "AplicacionesModule"
        Me.Size = New System.Drawing.Size(861, 511)
        Me.TableLayoutPanelContent.ResumeLayout(False)
        Me.TableLayoutPanelSubContent.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanelContent As TableLayoutPanel
    Friend WithEvents TableLayoutPanelSubContent As TableLayoutPanel
    Friend WithEvents ButtonAplicacionesVinculadas As Button
    Friend WithEvents ButtonMensajesDeAplicacion As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
