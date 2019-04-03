<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
    Inherits CustomForm

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
        Me.TableLayoutPanelSignIn = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanelSignInput = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBoxSignInCorreo = New System.Windows.Forms.TextBox()
        Me.TextBoxSignInContrasena = New System.Windows.Forms.TextBox()
        Me.ButtonAcceder = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PanelSignInTitle = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelSignIn = New System.Windows.Forms.Panel()
        Me.TableLayoutPanelSignUp = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanelSignUpGroupBoxes = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBoxCVU = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanelCuentaCVU = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxSignUpConfirmarContrasena = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxSignUpContrasena = New System.Windows.Forms.TextBox()
        Me.TextBoxSignUpCorreo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxSignUpConfirmarCorreo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBoxPersonales = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanelDatosPersonales = New System.Windows.Forms.TableLayoutPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBoxSignUpCURP = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBoxSignUpNombre = New System.Windows.Forms.TextBox()
        Me.TextBoxSignUpApellidoM = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBoxSignUpPaisNacimiento = New System.Windows.Forms.ComboBox()
        Me.TextBoxSignUpRFC = New System.Windows.Forms.TextBox()
        Me.TextBoxSignUpApellidoP = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PanelSignUpTitle = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelTerminos = New System.Windows.Forms.Panel()
        Me.CheckBoxTerminos = New System.Windows.Forms.CheckBox()
        Me.PanelButton = New System.Windows.Forms.Panel()
        Me.ButtonRegistrarse = New System.Windows.Forms.Button()
        Me.LinkLabelAdmin = New System.Windows.Forms.LinkLabel()
        Me.PanelHeader.SuspendLayout()
        Me.PanelContent.SuspendLayout()
        CType(Me.PictureBoxHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanelSignIn.SuspendLayout()
        Me.TableLayoutPanelSignInput.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSignInTitle.SuspendLayout()
        Me.PanelSignIn.SuspendLayout()
        Me.TableLayoutPanelSignUp.SuspendLayout()
        Me.TableLayoutPanelSignUpGroupBoxes.SuspendLayout()
        Me.GroupBoxCVU.SuspendLayout()
        Me.TableLayoutPanelCuentaCVU.SuspendLayout()
        Me.GroupBoxPersonales.SuspendLayout()
        Me.TableLayoutPanelDatosPersonales.SuspendLayout()
        Me.PanelSignUpTitle.SuspendLayout()
        Me.PanelTerminos.SuspendLayout()
        Me.PanelButton.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelHeader
        '
        Me.PanelHeader.Size = New System.Drawing.Size(1073, 100)
        '
        'PanelContent
        '
        Me.PanelContent.Controls.Add(Me.TableLayoutPanelSignUp)
        Me.PanelContent.Controls.Add(Me.PanelSignIn)
        Me.PanelContent.Size = New System.Drawing.Size(1073, 662)
        '
        'PictureBoxHeader
        '
        Me.PictureBoxHeader.Size = New System.Drawing.Size(1073, 100)
        '
        'TableLayoutPanelSignIn
        '
        Me.TableLayoutPanelSignIn.ColumnCount = 5
        Me.TableLayoutPanelSignIn.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanelSignIn.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelSignIn.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanelSignIn.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500.0!))
        Me.TableLayoutPanelSignIn.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanelSignIn.Controls.Add(Me.TableLayoutPanelSignInput, 3, 1)
        Me.TableLayoutPanelSignIn.Controls.Add(Me.PanelSignInTitle, 1, 1)
        Me.TableLayoutPanelSignIn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelSignIn.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelSignIn.Name = "TableLayoutPanelSignIn"
        Me.TableLayoutPanelSignIn.RowCount = 3
        Me.TableLayoutPanelSignIn.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanelSignIn.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelSignIn.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanelSignIn.Size = New System.Drawing.Size(1073, 145)
        Me.TableLayoutPanelSignIn.TabIndex = 0
        '
        'TableLayoutPanelSignInput
        '
        Me.TableLayoutPanelSignInput.ColumnCount = 2
        Me.TableLayoutPanelSignInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanelSignInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelSignInput.Controls.Add(Me.TextBoxSignInCorreo, 1, 0)
        Me.TableLayoutPanelSignInput.Controls.Add(Me.TextBoxSignInContrasena, 1, 1)
        Me.TableLayoutPanelSignInput.Controls.Add(Me.ButtonAcceder, 1, 2)
        Me.TableLayoutPanelSignInput.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanelSignInput.Controls.Add(Me.PictureBox2, 0, 1)
        Me.TableLayoutPanelSignInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelSignInput.Location = New System.Drawing.Point(566, 13)
        Me.TableLayoutPanelSignInput.Name = "TableLayoutPanelSignInput"
        Me.TableLayoutPanelSignInput.RowCount = 3
        Me.TableLayoutPanelSignInput.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanelSignInput.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanelSignInput.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanelSignInput.Size = New System.Drawing.Size(494, 119)
        Me.TableLayoutPanelSignInput.TabIndex = 0
        '
        'TextBoxSignInCorreo
        '
        Me.TextBoxSignInCorreo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxSignInCorreo.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSignInCorreo.Location = New System.Drawing.Point(53, 3)
        Me.TextBoxSignInCorreo.Name = "TextBoxSignInCorreo"
        Me.TextBoxSignInCorreo.Size = New System.Drawing.Size(438, 27)
        Me.TextBoxSignInCorreo.TabIndex = 0
        '
        'TextBoxSignInContrasena
        '
        Me.TextBoxSignInContrasena.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxSignInContrasena.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSignInContrasena.Location = New System.Drawing.Point(53, 42)
        Me.TextBoxSignInContrasena.Name = "TextBoxSignInContrasena"
        Me.TextBoxSignInContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxSignInContrasena.Size = New System.Drawing.Size(438, 27)
        Me.TextBoxSignInContrasena.TabIndex = 1
        '
        'ButtonAcceder
        '
        Me.ButtonAcceder.BackColor = System.Drawing.Color.SteelBlue
        Me.ButtonAcceder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonAcceder.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAcceder.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonAcceder.Location = New System.Drawing.Point(53, 81)
        Me.ButtonAcceder.Name = "ButtonAcceder"
        Me.ButtonAcceder.Size = New System.Drawing.Size(438, 35)
        Me.ButtonAcceder.TabIndex = 2
        Me.ButtonAcceder.Text = "Acceder"
        Me.ButtonAcceder.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.Presentation.My.Resources.Resources.iconCorreo
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(44, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = Global.Presentation.My.Resources.Resources.iconContrasena
        Me.PictureBox2.Location = New System.Drawing.Point(3, 42)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(44, 33)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PanelSignInTitle
        '
        Me.PanelSignInTitle.Controls.Add(Me.Label1)
        Me.PanelSignInTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelSignInTitle.Location = New System.Drawing.Point(13, 13)
        Me.PanelSignInTitle.Name = "PanelSignInTitle"
        Me.PanelSignInTitle.Size = New System.Drawing.Size(537, 119)
        Me.PanelSignInTitle.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Corbel", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(3, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(381, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Accede a tu cuenta CVU"
        '
        'PanelSignIn
        '
        Me.PanelSignIn.BackColor = System.Drawing.Color.MidnightBlue
        Me.PanelSignIn.Controls.Add(Me.TableLayoutPanelSignIn)
        Me.PanelSignIn.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSignIn.Location = New System.Drawing.Point(0, 0)
        Me.PanelSignIn.Name = "PanelSignIn"
        Me.PanelSignIn.Size = New System.Drawing.Size(1073, 145)
        Me.PanelSignIn.TabIndex = 1
        '
        'TableLayoutPanelSignUp
        '
        Me.TableLayoutPanelSignUp.ColumnCount = 3
        Me.TableLayoutPanelSignUp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanelSignUp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelSignUp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanelSignUp.Controls.Add(Me.TableLayoutPanelSignUpGroupBoxes, 1, 3)
        Me.TableLayoutPanelSignUp.Controls.Add(Me.PanelSignUpTitle, 1, 1)
        Me.TableLayoutPanelSignUp.Controls.Add(Me.PanelTerminos, 1, 5)
        Me.TableLayoutPanelSignUp.Controls.Add(Me.PanelButton, 1, 7)
        Me.TableLayoutPanelSignUp.Controls.Add(Me.LinkLabelAdmin, 1, 9)
        Me.TableLayoutPanelSignUp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelSignUp.Location = New System.Drawing.Point(0, 145)
        Me.TableLayoutPanelSignUp.Name = "TableLayoutPanelSignUp"
        Me.TableLayoutPanelSignUp.RowCount = 11
        Me.TableLayoutPanelSignUp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanelSignUp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanelSignUp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanelSignUp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelSignUp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanelSignUp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanelSignUp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanelSignUp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanelSignUp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanelSignUp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelSignUp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanelSignUp.Size = New System.Drawing.Size(1073, 517)
        Me.TableLayoutPanelSignUp.TabIndex = 2
        '
        'TableLayoutPanelSignUpGroupBoxes
        '
        Me.TableLayoutPanelSignUpGroupBoxes.ColumnCount = 2
        Me.TableLayoutPanelSignUpGroupBoxes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelSignUpGroupBoxes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelSignUpGroupBoxes.Controls.Add(Me.GroupBoxCVU, 0, 0)
        Me.TableLayoutPanelSignUpGroupBoxes.Controls.Add(Me.GroupBoxPersonales, 1, 0)
        Me.TableLayoutPanelSignUpGroupBoxes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelSignUpGroupBoxes.Location = New System.Drawing.Point(13, 83)
        Me.TableLayoutPanelSignUpGroupBoxes.Name = "TableLayoutPanelSignUpGroupBoxes"
        Me.TableLayoutPanelSignUpGroupBoxes.RowCount = 1
        Me.TableLayoutPanelSignUpGroupBoxes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelSignUpGroupBoxes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 188.0!))
        Me.TableLayoutPanelSignUpGroupBoxes.Size = New System.Drawing.Size(1047, 291)
        Me.TableLayoutPanelSignUpGroupBoxes.TabIndex = 0
        '
        'GroupBoxCVU
        '
        Me.GroupBoxCVU.Controls.Add(Me.TableLayoutPanelCuentaCVU)
        Me.GroupBoxCVU.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxCVU.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxCVU.Location = New System.Drawing.Point(3, 3)
        Me.GroupBoxCVU.Name = "GroupBoxCVU"
        Me.GroupBoxCVU.Size = New System.Drawing.Size(517, 285)
        Me.GroupBoxCVU.TabIndex = 0
        Me.GroupBoxCVU.TabStop = False
        Me.GroupBoxCVU.Text = "Cuenta de CVU"
        '
        'TableLayoutPanelCuentaCVU
        '
        Me.TableLayoutPanelCuentaCVU.ColumnCount = 5
        Me.TableLayoutPanelCuentaCVU.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TableLayoutPanelCuentaCVU.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelCuentaCVU.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TableLayoutPanelCuentaCVU.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelCuentaCVU.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.TableLayoutPanelCuentaCVU.Controls.Add(Me.Label3, 1, 0)
        Me.TableLayoutPanelCuentaCVU.Controls.Add(Me.TextBoxSignUpConfirmarContrasena, 3, 3)
        Me.TableLayoutPanelCuentaCVU.Controls.Add(Me.Label4, 3, 0)
        Me.TableLayoutPanelCuentaCVU.Controls.Add(Me.TextBoxSignUpContrasena, 1, 3)
        Me.TableLayoutPanelCuentaCVU.Controls.Add(Me.TextBoxSignUpCorreo, 1, 1)
        Me.TableLayoutPanelCuentaCVU.Controls.Add(Me.Label6, 3, 2)
        Me.TableLayoutPanelCuentaCVU.Controls.Add(Me.TextBoxSignUpConfirmarCorreo, 3, 1)
        Me.TableLayoutPanelCuentaCVU.Controls.Add(Me.Label5, 1, 2)
        Me.TableLayoutPanelCuentaCVU.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelCuentaCVU.Location = New System.Drawing.Point(3, 23)
        Me.TableLayoutPanelCuentaCVU.Name = "TableLayoutPanelCuentaCVU"
        Me.TableLayoutPanelCuentaCVU.RowCount = 4
        Me.TableLayoutPanelCuentaCVU.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelCuentaCVU.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelCuentaCVU.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelCuentaCVU.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelCuentaCVU.Size = New System.Drawing.Size(511, 259)
        Me.TableLayoutPanelCuentaCVU.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(8, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(241, 30)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Correo electrónico"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxSignUpConfirmarContrasena
        '
        Me.TextBoxSignUpConfirmarContrasena.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxSignUpConfirmarContrasena.Location = New System.Drawing.Point(260, 93)
        Me.TextBoxSignUpConfirmarContrasena.Name = "TextBoxSignUpConfirmarContrasena"
        Me.TextBoxSignUpConfirmarContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxSignUpConfirmarContrasena.Size = New System.Drawing.Size(241, 27)
        Me.TextBoxSignUpConfirmarContrasena.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(260, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(241, 30)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Confirmar correo electrónico"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxSignUpContrasena
        '
        Me.TextBoxSignUpContrasena.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxSignUpContrasena.Location = New System.Drawing.Point(8, 93)
        Me.TextBoxSignUpContrasena.Name = "TextBoxSignUpContrasena"
        Me.TextBoxSignUpContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxSignUpContrasena.Size = New System.Drawing.Size(241, 27)
        Me.TextBoxSignUpContrasena.TabIndex = 5
        '
        'TextBoxSignUpCorreo
        '
        Me.TextBoxSignUpCorreo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxSignUpCorreo.Location = New System.Drawing.Point(8, 33)
        Me.TextBoxSignUpCorreo.Name = "TextBoxSignUpCorreo"
        Me.TextBoxSignUpCorreo.Size = New System.Drawing.Size(241, 27)
        Me.TextBoxSignUpCorreo.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Location = New System.Drawing.Point(260, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(241, 30)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Confirmar contraseña"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxSignUpConfirmarCorreo
        '
        Me.TextBoxSignUpConfirmarCorreo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxSignUpConfirmarCorreo.Location = New System.Drawing.Point(260, 33)
        Me.TextBoxSignUpConfirmarCorreo.Name = "TextBoxSignUpConfirmarCorreo"
        Me.TextBoxSignUpConfirmarCorreo.Size = New System.Drawing.Size(241, 27)
        Me.TextBoxSignUpConfirmarCorreo.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(8, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(241, 30)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Contraseña"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBoxPersonales
        '
        Me.GroupBoxPersonales.Controls.Add(Me.TableLayoutPanelDatosPersonales)
        Me.GroupBoxPersonales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxPersonales.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxPersonales.Location = New System.Drawing.Point(526, 3)
        Me.GroupBoxPersonales.Name = "GroupBoxPersonales"
        Me.GroupBoxPersonales.Size = New System.Drawing.Size(518, 285)
        Me.GroupBoxPersonales.TabIndex = 1
        Me.GroupBoxPersonales.TabStop = False
        Me.GroupBoxPersonales.Text = "Datos personales"
        '
        'TableLayoutPanelDatosPersonales
        '
        Me.TableLayoutPanelDatosPersonales.ColumnCount = 5
        Me.TableLayoutPanelDatosPersonales.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TableLayoutPanelDatosPersonales.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelDatosPersonales.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TableLayoutPanelDatosPersonales.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelDatosPersonales.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TableLayoutPanelDatosPersonales.Controls.Add(Me.Label9, 1, 0)
        Me.TableLayoutPanelDatosPersonales.Controls.Add(Me.TextBoxSignUpCURP, 3, 5)
        Me.TableLayoutPanelDatosPersonales.Controls.Add(Me.Label12, 1, 6)
        Me.TableLayoutPanelDatosPersonales.Controls.Add(Me.Label10, 3, 4)
        Me.TableLayoutPanelDatosPersonales.Controls.Add(Me.TextBoxSignUpNombre, 1, 1)
        Me.TableLayoutPanelDatosPersonales.Controls.Add(Me.TextBoxSignUpApellidoM, 3, 3)
        Me.TableLayoutPanelDatosPersonales.Controls.Add(Me.Label8, 1, 2)
        Me.TableLayoutPanelDatosPersonales.Controls.Add(Me.Label7, 3, 2)
        Me.TableLayoutPanelDatosPersonales.Controls.Add(Me.ComboBoxSignUpPaisNacimiento, 1, 7)
        Me.TableLayoutPanelDatosPersonales.Controls.Add(Me.TextBoxSignUpRFC, 1, 5)
        Me.TableLayoutPanelDatosPersonales.Controls.Add(Me.TextBoxSignUpApellidoP, 1, 3)
        Me.TableLayoutPanelDatosPersonales.Controls.Add(Me.Label11, 1, 4)
        Me.TableLayoutPanelDatosPersonales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelDatosPersonales.Location = New System.Drawing.Point(3, 23)
        Me.TableLayoutPanelDatosPersonales.Name = "TableLayoutPanelDatosPersonales"
        Me.TableLayoutPanelDatosPersonales.RowCount = 8
        Me.TableLayoutPanelDatosPersonales.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelDatosPersonales.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelDatosPersonales.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelDatosPersonales.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelDatosPersonales.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelDatosPersonales.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelDatosPersonales.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelDatosPersonales.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelDatosPersonales.Size = New System.Drawing.Size(512, 259)
        Me.TableLayoutPanelDatosPersonales.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Location = New System.Drawing.Point(8, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(242, 30)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Nombre"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxSignUpCURP
        '
        Me.TextBoxSignUpCURP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxSignUpCURP.Location = New System.Drawing.Point(261, 153)
        Me.TextBoxSignUpCURP.Name = "TextBoxSignUpCURP"
        Me.TextBoxSignUpCURP.Size = New System.Drawing.Size(242, 27)
        Me.TextBoxSignUpCURP.TabIndex = 16
        '
        'Label12
        '
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label12.Location = New System.Drawing.Point(8, 180)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(242, 30)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "País de nacimiento"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Location = New System.Drawing.Point(261, 120)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(242, 30)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "CURP"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxSignUpNombre
        '
        Me.TextBoxSignUpNombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxSignUpNombre.Location = New System.Drawing.Point(8, 33)
        Me.TextBoxSignUpNombre.Name = "TextBoxSignUpNombre"
        Me.TextBoxSignUpNombre.Size = New System.Drawing.Size(242, 27)
        Me.TextBoxSignUpNombre.TabIndex = 10
        '
        'TextBoxSignUpApellidoM
        '
        Me.TextBoxSignUpApellidoM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxSignUpApellidoM.Location = New System.Drawing.Point(261, 93)
        Me.TextBoxSignUpApellidoM.Name = "TextBoxSignUpApellidoM"
        Me.TextBoxSignUpApellidoM.Size = New System.Drawing.Size(242, 27)
        Me.TextBoxSignUpApellidoM.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Location = New System.Drawing.Point(8, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(242, 30)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Apellido paterno"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Location = New System.Drawing.Point(261, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(242, 30)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Apellido materno"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBoxSignUpPaisNacimiento
        '
        Me.ComboBoxSignUpPaisNacimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBoxSignUpPaisNacimiento.FormattingEnabled = True
        Me.ComboBoxSignUpPaisNacimiento.Items.AddRange(New Object() {"México"})
        Me.ComboBoxSignUpPaisNacimiento.Location = New System.Drawing.Point(8, 213)
        Me.ComboBoxSignUpPaisNacimiento.Name = "ComboBoxSignUpPaisNacimiento"
        Me.ComboBoxSignUpPaisNacimiento.Size = New System.Drawing.Size(242, 27)
        Me.ComboBoxSignUpPaisNacimiento.TabIndex = 7
        '
        'TextBoxSignUpRFC
        '
        Me.TextBoxSignUpRFC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxSignUpRFC.Location = New System.Drawing.Point(8, 153)
        Me.TextBoxSignUpRFC.Name = "TextBoxSignUpRFC"
        Me.TextBoxSignUpRFC.Size = New System.Drawing.Size(242, 27)
        Me.TextBoxSignUpRFC.TabIndex = 15
        '
        'TextBoxSignUpApellidoP
        '
        Me.TextBoxSignUpApellidoP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxSignUpApellidoP.Location = New System.Drawing.Point(8, 93)
        Me.TextBoxSignUpApellidoP.Name = "TextBoxSignUpApellidoP"
        Me.TextBoxSignUpApellidoP.Size = New System.Drawing.Size(242, 27)
        Me.TextBoxSignUpApellidoP.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Location = New System.Drawing.Point(8, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(242, 30)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "RFC"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanelSignUpTitle
        '
        Me.PanelSignUpTitle.Controls.Add(Me.Label2)
        Me.PanelSignUpTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelSignUpTitle.Location = New System.Drawing.Point(13, 13)
        Me.PanelSignUpTitle.Name = "PanelSignUpTitle"
        Me.PanelSignUpTitle.Size = New System.Drawing.Size(1047, 54)
        Me.PanelSignUpTitle.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Corbel", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 36)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Regístrate"
        '
        'PanelTerminos
        '
        Me.PanelTerminos.Controls.Add(Me.CheckBoxTerminos)
        Me.PanelTerminos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelTerminos.Location = New System.Drawing.Point(13, 390)
        Me.PanelTerminos.Name = "PanelTerminos"
        Me.PanelTerminos.Size = New System.Drawing.Size(1047, 29)
        Me.PanelTerminos.TabIndex = 2
        '
        'CheckBoxTerminos
        '
        Me.CheckBoxTerminos.AutoSize = True
        Me.CheckBoxTerminos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckBoxTerminos.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxTerminos.Location = New System.Drawing.Point(0, 0)
        Me.CheckBoxTerminos.Name = "CheckBoxTerminos"
        Me.CheckBoxTerminos.Size = New System.Drawing.Size(1047, 29)
        Me.CheckBoxTerminos.TabIndex = 2
        Me.CheckBoxTerminos.Text = "Acepto que la información proporcionada es real y correcta, así como los términos" &
    " indicados en la política de privacidad para el uso de mis datos e información p" &
    "ersonal"
        Me.CheckBoxTerminos.UseVisualStyleBackColor = True
        '
        'PanelButton
        '
        Me.PanelButton.Controls.Add(Me.ButtonRegistrarse)
        Me.PanelButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelButton.Location = New System.Drawing.Point(13, 435)
        Me.PanelButton.Name = "PanelButton"
        Me.PanelButton.Size = New System.Drawing.Size(1047, 29)
        Me.PanelButton.TabIndex = 3
        '
        'ButtonRegistrarse
        '
        Me.ButtonRegistrarse.BackColor = System.Drawing.Color.SteelBlue
        Me.ButtonRegistrarse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonRegistrarse.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRegistrarse.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonRegistrarse.Location = New System.Drawing.Point(0, 0)
        Me.ButtonRegistrarse.Name = "ButtonRegistrarse"
        Me.ButtonRegistrarse.Size = New System.Drawing.Size(1047, 29)
        Me.ButtonRegistrarse.TabIndex = 0
        Me.ButtonRegistrarse.Text = "Registrarse"
        Me.ButtonRegistrarse.UseVisualStyleBackColor = False
        '
        'LinkLabelAdmin
        '
        Me.LinkLabelAdmin.AutoSize = True
        Me.LinkLabelAdmin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LinkLabelAdmin.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelAdmin.Location = New System.Drawing.Point(13, 477)
        Me.LinkLabelAdmin.Name = "LinkLabelAdmin"
        Me.LinkLabelAdmin.Size = New System.Drawing.Size(1047, 30)
        Me.LinkLabelAdmin.TabIndex = 4
        Me.LinkLabelAdmin.TabStop = True
        Me.LinkLabelAdmin.Text = "Accede como administrador"
        Me.LinkLabelAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1073, 762)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "LoginForm"
        Me.Text = "LoginForm"
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelContent.ResumeLayout(False)
        CType(Me.PictureBoxHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanelSignIn.ResumeLayout(False)
        Me.TableLayoutPanelSignInput.ResumeLayout(False)
        Me.TableLayoutPanelSignInput.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSignInTitle.ResumeLayout(False)
        Me.PanelSignInTitle.PerformLayout()
        Me.PanelSignIn.ResumeLayout(False)
        Me.TableLayoutPanelSignUp.ResumeLayout(False)
        Me.TableLayoutPanelSignUp.PerformLayout()
        Me.TableLayoutPanelSignUpGroupBoxes.ResumeLayout(False)
        Me.GroupBoxCVU.ResumeLayout(False)
        Me.TableLayoutPanelCuentaCVU.ResumeLayout(False)
        Me.TableLayoutPanelCuentaCVU.PerformLayout()
        Me.GroupBoxPersonales.ResumeLayout(False)
        Me.TableLayoutPanelDatosPersonales.ResumeLayout(False)
        Me.TableLayoutPanelDatosPersonales.PerformLayout()
        Me.PanelSignUpTitle.ResumeLayout(False)
        Me.PanelSignUpTitle.PerformLayout()
        Me.PanelTerminos.ResumeLayout(False)
        Me.PanelTerminos.PerformLayout()
        Me.PanelButton.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelSignIn As Panel
    Friend WithEvents TableLayoutPanelSignIn As TableLayoutPanel
    Friend WithEvents TableLayoutPanelSignInput As TableLayoutPanel
    Friend WithEvents PanelSignInTitle As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxSignInCorreo As TextBox
    Friend WithEvents TextBoxSignInContrasena As TextBox
    Friend WithEvents ButtonAcceder As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TableLayoutPanelSignUp As TableLayoutPanel
    Friend WithEvents TableLayoutPanelSignUpGroupBoxes As TableLayoutPanel
    Friend WithEvents GroupBoxCVU As GroupBox
    Friend WithEvents GroupBoxPersonales As GroupBox
    Friend WithEvents PanelSignUpTitle As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelTerminos As Panel
    Friend WithEvents CheckBoxTerminos As CheckBox
    Friend WithEvents PanelButton As Panel
    Friend WithEvents ButtonRegistrarse As Button
    Friend WithEvents TextBoxSignUpConfirmarContrasena As TextBox
    Friend WithEvents TextBoxSignUpContrasena As TextBox
    Friend WithEvents TextBoxSignUpConfirmarCorreo As TextBox
    Friend WithEvents TextBoxSignUpCorreo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBoxSignUpCURP As TextBox
    Friend WithEvents TextBoxSignUpRFC As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBoxSignUpApellidoM As TextBox
    Friend WithEvents ComboBoxSignUpPaisNacimiento As ComboBox
    Friend WithEvents TextBoxSignUpApellidoP As TextBox
    Friend WithEvents TextBoxSignUpNombre As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TableLayoutPanelCuentaCVU As TableLayoutPanel
    Friend WithEvents TableLayoutPanelDatosPersonales As TableLayoutPanel
    Friend WithEvents LinkLabelAdmin As LinkLabel
End Class
