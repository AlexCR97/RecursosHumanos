Public Class MenuBarModule

    Private mainForm As MainForm

    Public Sub SetMainForm(mainForm As MainForm)
        Me.mainForm = mainForm

        Me.BackColor = My.Settings.MainColor
    End Sub

    Private Sub PictureBoxUser_Click(sender As Object, e As EventArgs) Handles PictureBoxUser.Click
        Dim c As PerfilYCuentaModule = New PerfilYCuentaModule(mainForm)
        mainForm.LoadModule(c)
    End Sub

    Private Sub PictureBoxLogout_Click(sender As Object, e As EventArgs) Handles PictureBoxLogout.Click
        Dim result = MessageBox.Show(
            "Estas seguro de que quieres cerrar sesion?", "",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question
        )

        If Not result = DialogResult.Yes Then
            Return
        End If

        Application.Restart()
    End Sub

End Class
