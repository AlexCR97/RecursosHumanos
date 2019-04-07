Imports Entities
Imports Logic

Public Class AdminLoginForm
    Inherits CustomForm

    Public Sub New()
        InitializeComponent()
        Me.PanelAccessSystem.BackColor = My.Settings.MainColor
    End Sub

    Private Function ValidateCuenta(correo As String, contrasena As String) As Boolean

        Dim admin = New Administrador() With {
            .IdAdmin = correo,
            .Contrasena = contrasena
        }

        Dim adminValidation As New AdministradorValidation() With {
            .Entity = admin
        }

        Dim success = adminValidation.ValidateAll()
        If Not success Then
            MessageBox.Show("El correo o la contrasena es invalida. Intentelo de nuevo")
            Return False
        End If

        Dim adminModel As New AdministradorModel() With {
            .Entity = admin,
            .State = AdministradorModel.STATE_CHECK_EXISTANCE
        }

        success = adminModel.ExecuteChanges()
        If Not success Then
            Return False
        End If

        Return True
    End Function

    Private Sub ButtonSignIn_Click(sender As Object, e As EventArgs) Handles ButtonSignIn.Click
        Dim correo = Me.TextBoxEmail.Text
        Dim contrasena = Me.TextBoxPassword.Text

        If Not ValidateCuenta(correo, contrasena) Then
            MessageBox.Show("El correo o la contrasena es incorrecta. Intentelo de nuevo")
            Return
        End If

        Dim adminForm As New AdminMainForm()
        adminForm.Show()
        Me.Close()
    End Sub

    Private Sub LinkLabelUser_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelUser.LinkClicked
        Application.Restart()
    End Sub
End Class