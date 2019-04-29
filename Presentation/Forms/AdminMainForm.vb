Imports Entities
Imports Logic
Imports MicroServices

Public Class AdminMainForm
    Inherits CustomForm

    Private admin As Administrador

    Public Sub New()
        InitializeComponent()

        Me.PanelTitle.BackColor = My.Settings.MainColor
    End Sub

    Public Sub InitializeWithAdmin(admin As Administrador)
        Me.admin = admin
    End Sub

    Private Sub ButtonChangeLogo_Click(sender As Object, e As EventArgs) Handles ButtonChangeLogo.Click

    End Sub

    Private Sub ButtonChangeColor_Click(sender As Object, e As EventArgs) Handles ButtonChangeColor.Click
        Dim dialog As New ColorDialog()
        Dim result As DialogResult = dialog.ShowDialog()

        If Not result = DialogResult.OK Then
            Return
        End If

        My.Settings.MainColor = dialog.Color
        My.Settings.Save()
        Me.PanelTitle.BackColor = My.Settings.MainColor
    End Sub

    Private Sub PictureBoxSignOut_Click(sender As Object, e As EventArgs) Handles PictureBoxSignOut.Click
        Dim result = MessageBox.Show("Estas seguro de que quieres cerrar sesion?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Not result = DialogResult.Yes Then
            Return
        End If

        Application.Restart()
    End Sub

    Private Sub ButtonBackup_Click(sender As Object, e As EventArgs) Handles ButtonBackup.Click
        Dim folderBrowser As New FolderBrowserDialog()

        Dim result = folderBrowser.ShowDialog()
        If result <> DialogResult.OK Then
            Return
        End If

        Dim folderPath = folderBrowser.SelectedPath

        Dim system As New SystemModel()
        Dim success = system.Backup(folderPath, SystemModel.BACKUP_TYPE_MANUAL)
        If Not success Then
            MessageBox.Show("El respaldo no pudo ser creado :(")
            Return
        End If

        MessageBox.Show("Respaldo creado :D")
    End Sub

    Private Sub ButtonRestore_Click(sender As Object, e As EventArgs) Handles ButtonRestore.Click
        Dim dialog As New RestoreDatabaseDialog(Me)
        dialog.Show()
    End Sub

End Class
