Imports Data

Public Class SystemModel

    Public Const BACKUP_TYPE_MANUAL = 0
    Public Const BACKUP_TYPE_AUTOMATIC = 1

    Private defaultBackupPath = "C:\MariaDbBackups"
    Private repository As New SystemRepository()

    Public Function Backup(fileName As String) As Boolean
        Return repository.Backup(fileName)
    End Function

    Public Function Backup(backupType As Integer) As Boolean
        Dim fileName = ""
        Dim nowFormat = "d-MM-yyyy_HH-mm-ss"
        Dim nowString = DateTime.Now.ToString(nowFormat)

        Select Case backupType
            Case BACKUP_TYPE_MANUAL
                fileName = defaultBackupPath + "\respaldo_manual_" & nowString & ".sql"

            Case BACKUP_TYPE_AUTOMATIC
                fileName = defaultBackupPath + "\respaldo_automatico_" & nowString & ".sql"
        End Select

        Return repository.Backup(fileName)
    End Function

    Public Function Backup(folderPath As String, backupType As Integer) As Boolean
        Dim fileName = ""
        Dim nowFormat = "d-MM-yyyy_HH-mm-ss"
        Dim nowString = DateTime.Now.ToString(nowFormat)

        Select Case backupType
            Case BACKUP_TYPE_MANUAL
                fileName = folderPath + "\respaldo_manual_" & nowString & ".sql"

            Case BACKUP_TYPE_AUTOMATIC
                fileName = folderPath + "\respaldo_automatico_" & nowString & ".sql"
        End Select

        Return repository.Backup(fileName)
    End Function

    Public Function Restore(fileName As String) As Boolean
        Return repository.Restore(fileName)
    End Function

End Class
