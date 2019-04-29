Imports Logic

Public Class RestoreDatabaseDialog
    Inherits CustomDialog

    Private adminForm As AdminMainForm

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(adminForm As AdminMainForm)
        InitializeComponent()

        Me.adminForm = adminForm
        adminForm.Enabled = False
    End Sub

    Public Overrides Sub ReturnControl()
        adminForm.Enabled = True
        Me.Close()
    End Sub

    Private Sub GuardarButtonSelectBackup_Click(sender As Object, e As EventArgs) Handles GuardarButtonSelectBackup.Click
        Dim openFile As New OpenFileDialog() With {
            .Title = "Selecciona el archivo de restauracion",
            .Filter = "Backup (*.sql)|*.sql"
        }

        Dim result = openFile.ShowDialog()
        If result <> DialogResult.OK Then
            Return
        End If

        Dim fileName = openFile.FileName
        Me.TextBoxBackupFile.Text = fileName
    End Sub

    Private Sub CancelarButton1_Click(sender As Object, e As EventArgs) Handles CancelarButton1.Click
        ReturnControl()
    End Sub

    Private Sub GuardarButtonBackup_Click(sender As Object, e As EventArgs) Handles GuardarButtonBackup.Click
        Dim fileName = Me.TextBoxBackupFile.Text
        If String.IsNullOrWhiteSpace(fileName) Then
            Return
        End If

        Dim system As New SystemModel()
        Dim success = system.Restore(fileName)
        If Not success Then
            MessageBox.Show("La base de datos no pudo ser restaurada :(")
            Return
        End If

        MessageBox.Show("Restauracion exitosa! :D")
        ReturnControl()
    End Sub
End Class
