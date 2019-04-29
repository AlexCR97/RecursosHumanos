Imports System.Threading
Imports Entities
Imports Logic
Imports MicroServices

Public Class LoginForm
    Inherits CustomForm

    Public usuario As Usuario = New Usuario()
    Private usuarioModel As UsuarioModel = New UsuarioModel()
    Private usuarioValidation As UsuarioValidation = New UsuarioValidation()

    Private datosPersonales As DatosPersonales = New DatosPersonales()
    Private datosPersonalesModel As DatosPersonalesModel = New DatosPersonalesModel()
    Private datosPersonalesValidation As DatosPersonalesValidation = New DatosPersonalesValidation()

    Public Sub New()
        InitializeComponent()
        Me.PanelSignIn.BackColor = My.Settings.MainColor

        ' Start backup thread
        StartBackupThread()
    End Sub

    Public Sub Login()
        usuario = usuarioModel.GetEntityWithId()

        usuarioModel = New UsuarioModel() With {
            .Entity = usuario,
            .State = UsuarioModel.STATE_CHECK_VERIFIED_EMAIL
        }

        Dim success = usuarioModel.ExecuteChanges()
        If Not success Then
            MessageBox.Show("No has verificado tu cuenta! Revisa la bandeja de entrada de tu correo electronico para obtener el id de activacion de tu cuenta")
            SendActivationId()
            Return
        End If

        Dim mainForm As MainForm = New MainForm()
        mainForm.InitializeWithUser(usuario)
        mainForm.UpdateResumenModule()
        mainForm.Show()

        Me.Close()
    End Sub

    Private Function ValidateCuenta() As Boolean
        Dim correo = Me.TextBoxSignUpCorreo.Text
        Dim confirmarCorreo = Me.TextBoxSignUpConfirmarCorreo.Text

        If correo <> confirmarCorreo Then
            MessageBox.Show("Vuelve a confirmar tu correo!")
            Return False
        End If

        Dim contrasena = Me.TextBoxSignUpContrasena.Text
        Dim confirmarContrasena = Me.TextBoxSignUpConfirmarContrasena.Text

        If contrasena <> confirmarContrasena Then
            MessageBox.Show("Vuelve a confirmar tu contrasena!")
            Return False
        End If

        usuario = New Usuario() With {
            .IdUsuario = correo,
            .Contrasena = contrasena
        }

        usuarioValidation.Entity = usuario

        Dim success = usuarioValidation.ValidateAll()
        If Not success Then
            MessageBox.Show("El correo o la contrasena es invalida. Intentelo de nuevo")
            Return False
        End If

        usuarioModel = New UsuarioModel() With {
            .Entity = usuario,
            .State = UsuarioModel.STATE_CHECK_EXISTANCE
        }

        success = usuarioModel.ExecuteChanges()
        If success Then
            MessageBox.Show("Ya existe un usuario con ese correo. Intentelo de nuevo")
            Return False
        End If

        Return True
    End Function

    Public Function ValidateDatosPersonales() As Boolean
        Dim idUsuario = Me.TextBoxSignUpCorreo.Text
        Dim nombre = Me.TextBoxSignUpNombre.Text
        Dim apellidoPaterno = Me.TextBoxSignUpApellidoP.Text
        Dim apellidoMaterno = Me.TextBoxSignUpApellidoM.Text
        Dim rfc = Me.TextBoxSignUpRFC.Text
        Dim curp = Me.TextBoxSignUpCURP.Text
        Dim pais = CType(Me.ComboBoxSignUpPaisNacimiento.SelectedItem, String)

        datosPersonales = New DatosPersonales With {
            .IdUsuario = idUsuario,
            .Nombre = nombre,
            .ApellidoPaterno = apellidoPaterno,
            .ApellidoMaterno = apellidoMaterno,
            .Rfc = rfc,
            .Curp = curp,
            .PaisNacimiento = pais
        }

        datosPersonalesValidation = New DatosPersonalesValidation() With {
            .Entity = datosPersonales
        }

        Dim success = datosPersonalesValidation.ValidateAll()
        If Not success Then
            MessageBox.Show("Has ingresado datos personales invalidos. Intentelo de nuevo.")
            Return False
        End If

        Return True
    End Function

    Private Sub ButtonAcceder_Click(sender As Object, e As EventArgs) Handles ButtonAcceder.Click
        Dim correo = Me.TextBoxSignInCorreo.Text
        Dim contrasena = Me.TextBoxSignInContrasena.Text

        usuario = New Usuario With {
            .IdUsuario = correo,
            .Contrasena = contrasena
        }

        usuarioValidation.Entity = usuario

        Dim success = usuarioValidation.ValidateAll()
        If Not success Then
            MessageBox.Show("Debes ingresar campos validos. Intentelo de nuevo")
            Return
        End If

        usuarioModel.Entity = usuario
        usuarioModel.State = UsuarioModel.STATE_CHECK_EXISTANCE

        success = usuarioModel.ExecuteChanges()
        If Not success Then
            MessageBox.Show("No existe un usuario con ese correo o contrasena. Intentelo de nuevo")
            Return
        End If

        Login()
    End Sub

    Private Sub ButtonRegistrarse_Click(sender As Object, e As EventArgs) Handles ButtonRegistrarse.Click
        If Not Me.CheckBoxTerminos.Checked Then
            MessageBox.Show("Debes aceptar los terminos y condiciones!")
            Return
        End If

        If Not ValidateCuenta() Then
            Return
        End If

        If Not ValidateDatosPersonales() Then
            Return
        End If

        Dim keyGenerator As New UniqueKeyGenerator()
        usuario.IdActivacion = keyGenerator.GenerateKey()
        usuario.CuentaVerificada = False

        usuarioModel = New UsuarioModel() With {
            .Entity = usuario,
            .State = UsuarioModel.STATE_INSERT
        }

        Dim success = usuarioModel.ExecuteChanges()
        If Not success Then
            MessageBox.Show("Ocurrio un error al realizar el registro del usuario. Intentelo de nuevo")
            Return
        End If

        datosPersonalesModel = New DatosPersonalesModel() With {
            .Entity = datosPersonales,
            .State = DatosPersonalesModel.STATE_INSERT
        }

        success = datosPersonalesModel.ExecuteChanges()
        If Not success Then
            MessageBox.Show("Ocurrio un error al realizar el registro de los datos peronales. Intentelo de nuevo")
            Return
        End If

        MessageBox.Show("Registrado!")
        SendActivationId()
    End Sub

    Private Sub SendActivationId()
        Dim sender As New EmailSender()

        Dim toMail = usuario.IdUsuario
        Dim subject = "RRHH System - Id de activacion de cuenta"
        Dim message = "Ingrese el siguiente id en el sistema para activar su cuenta: " + usuario.IdActivacion

        Dim success = sender.SendEmail(toMail, subject, message)
        If Not success Then
            MessageBox.Show("Ocurrio un error al enviar el id de activacion")
        End If

        Dim dialog As New ActivationDialog(Me)
        dialog.Show()
    End Sub

    Private Sub CheckBoxTerminos_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxTerminos.CheckedChanged
    End Sub

    Private Sub LinkLabelAdmin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelAdmin.LinkClicked
        Dim adminLoginForm As New AdminLoginForm()
        adminLoginForm.Show()

        Me.Close()
    End Sub

    ' BACKUP THREAD
    Private Sub StartBackupThread()
        Dim t As New Thread(AddressOf CheckForAutomaticBackups) With {
            .IsBackground = True
        }

        t.Start()
    End Sub

    Private Sub CheckForAutomaticBackups()
        While True
            Dim now As DateTime = DateTime.Now
            Dim backupDate As DateTime = My.Settings.BackupDate

            If now > backupDate Then
                Dim system As New SystemModel()
                Dim success = system.Backup(SystemModel.BACKUP_TYPE_AUTOMATIC)

                If Not success Then
                    MessageBox.Show("Ocurrio un error al realizar el respaldo automatico :(")
                Else
                    MessageBox.Show("Respaldo automatico realizado :D")
                End If

                My.Settings.BackupDate = now.AddHours(24)
                My.Settings.Save()
            End If
        End While
    End Sub

End Class
