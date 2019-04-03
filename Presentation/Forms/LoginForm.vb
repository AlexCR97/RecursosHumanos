Imports Entities
Imports Logic
Imports MicroServices

Public Class LoginForm
    Inherits CustomForm

    Private usuario As Usuario = New Usuario()
    Private usuarioModel As UsuarioModel = New UsuarioModel()
    Private usuarioValidation As UsuarioValidation = New UsuarioValidation()

    Private datosPersonales As DatosPersonales = New DatosPersonales()
    Private datosPersonalesModel As DatosPersonalesModel = New DatosPersonalesModel()
    Private datosPersonalesValidation As DatosPersonalesValidation = New DatosPersonalesValidation()

    Private Sub Login()
        usuario = usuarioModel.GetEntityWithId()

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
        Login()
    End Sub

    Private Sub CheckBoxTerminos_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxTerminos.CheckedChanged
        Dim m As New EmailSender()

        Dim toMail = "rrangel@itsmante.edu.mx"
        Dim subject = "Mensaje de prueba"
        Dim message = "Este es un mensaje de prueba enviado por la aplicacion 'CVU Tecnm' v1.0 stable"

        Dim success = m.SendEmail(toMail, subject, message)
        If Not success Then
            MessageBox.Show("Fallo")
            Return
        End If

        MessageBox.Show("Exito")
    End Sub

    Private Sub LinkLabelAdmin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelAdmin.LinkClicked
        Dim adminLoginForm As New AdminLoginForm()
        adminLoginForm.Show()

        Me.Close()
    End Sub

End Class
