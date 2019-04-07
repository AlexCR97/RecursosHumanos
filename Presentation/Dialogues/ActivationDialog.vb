Imports Entities
Imports Logic
Imports MicroServices

Public Class ActivationDialog
    Inherits CustomDialog

    Private loginForm As LoginForm

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(loginForm As LoginForm)
        InitializeComponent()

        Me.loginForm = loginForm
        loginForm.Enabled = False
    End Sub

    Public Overrides Sub ReturnControl()
        loginForm.Enabled = True
        Me.Close()
    End Sub

    Private Sub ActivarButton_Click(sender As Object, e As EventArgs) Handles ActivarButton.Click
        Dim idActivacion = Me.TextBoxIdActivacion.Text
        If String.IsNullOrWhiteSpace(idActivacion) Then
            Return
        End If

        Dim usuario As Usuario = loginForm.usuario
        usuario.IdActivacion = idActivacion

        Dim model As New UsuarioModel() With {
            .Entity = usuario,
            .State = UsuarioModel.STATE_CHECK_ACTIVATION_ID
        }

        Dim success = model.ExecuteChanges()
        If Not success Then
            MessageBox.Show("No se pudo activar tu cuenta. Revisa que hayas escrito bien el id de verificacion o haz clic en el enlace para reenviarlo")
            Return
        End If

        model = New UsuarioModel() With {
            .Entity = usuario,
            .State = UsuarioModel.STATE_ACTIVATE_ACCOUNT
        }

        success = model.ExecuteChanges()
        If Not success Then
            MessageBox.Show("Ocurrio un error al activar tu cuenta. Intentelo de nuevo")
            Return
        End If

        MessageBox.Show("Cuenta activada!")
        loginForm.Login()
    End Sub

    Private Sub CancelarButton1_Click(sender As Object, e As EventArgs) Handles CancelarButton1.Click
        ReturnControl()
    End Sub

    Private Sub LinkLabelResend_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelResend.LinkClicked

    End Sub
End Class
