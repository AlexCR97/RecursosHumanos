Imports Entities
Imports Logic

Public Class LoginForm
    Inherits CustomForm

    Private usuario As Usuario = New Usuario()
    Private usuarioModel As UsuarioModel = New UsuarioModel()
    Private usuarioValidation As UsuarioValidation = New UsuarioValidation()

    Private datosPersonales As DatosPersonales = New DatosPersonales()
    Private datosPersonalesModel As DatosPersonalesModel = New DatosPersonalesModel()
    Private datosPersonalesValidation As DatosPersonalesValidation = New DatosPersonalesValidation()

    Private Sub Login()
        MessageBox.Show("Exito!")

        usuario = usuarioModel.GetEntityWithId()

        Dim mainForm As MainForm = New MainForm()
        mainForm.InitializeWithUser(usuario)
        mainForm.Show()

        Me.Close()
    End Sub

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

        Dim correo = Me.TextBoxSignUpCorreo.Text
        Dim confirmarCorreo = Me.TextBoxSignUpConfirmarCorreo.Text

        If correo <> confirmarCorreo Then
            MessageBox.Show("Vuelve a confirmar tu correo!")
            Return
        End If

        Dim contrasena = Me.TextBoxSignUpContrasena.Text
        Dim confirmarContrasena = Me.TextBoxSignUpConfirmarContrasena.Text

        If contrasena <> confirmarContrasena Then
            MessageBox.Show("Vuelve a confirmar tu contrasena!")
            Return
        End If

        Dim nombre = Me.TextBoxSignUpNombre.Text
        Dim apellidoPaterno = Me.TextBoxSignUpApellidoP.Text
        Dim apellidoMaterno = Me.TextBoxSignUpApellidoM.Text
        Dim rfc = Me.TextBoxSignUpRFC.Text
        Dim curp = Me.TextBoxSignUpCURP.Text
        Dim pais = CType(Me.ComboBoxSignUpPaisNacimiento.SelectedItem, String)

        usuario = New Usuario With {
            .IdUsuario = correo,
            .Contrasena = contrasena
        }

        usuarioValidation.Entity = usuario

        Dim success = usuarioValidation.ValidateAll()
        If Not success Then
            MessageBox.Show("El correo o la contrasena es invalida. Intentelo de nuevo")
            Return
        End If

        usuarioModel.Entity = usuario
        usuarioModel.State = usuarioModel.STATE_CHECK_EXISTANCE

        success = usuarioModel.ExecuteChanges()

        If success Then
            MessageBox.Show("Ya existe un usuario con ese correo. Intentelo de nuevo")
            Return
        End If

        usuarioModel.State = UsuarioModel.STATE_INSERT
        success = usuarioModel.ExecuteChanges()

        If Not success Then
            MessageBox.Show("Ocurrio un error al realizar el registro del usuario. Intentelo de nuevo")
            Return
        End If

        datosPersonales = New DatosPersonales With {
            .IdUsuario = correo,
            .Nombre = nombre,
            .ApellidoPaterno = apellidoPaterno,
            .ApellidoMaterno = apellidoMaterno,
            .Rfc = rfc,
            .Curp = curp,
            .PaisNacimiento = pais
        }

        datosPersonalesValidation.Entity = datosPersonales
        success = datosPersonalesValidation.ValidateAll()

        If Not success Then
            MessageBox.Show("Has ingresado datos personales invalidos. Intentelo de nuevo.")
            Return
        End If

        datosPersonalesModel.Entity = datosPersonales
        datosPersonalesModel.State = DatosPersonalesModel.STATE_INSERT

        success = datosPersonalesModel.ExecuteChanges()

        If Not success Then
            MessageBox.Show("Ocurrio un error al realizar el registro de los datos peronales. Intentelo de nuevo")
            Return
        End If

        MessageBox.Show("Registrado!")
        Login()
    End Sub

End Class