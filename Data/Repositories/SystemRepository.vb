Imports MySql.Data.MySqlClient

Public Class SystemRepository

    Private database As New Database()

    Public Function Backup(fileName As String) As Boolean
        Try
            Dim command As New MySqlCommand With {
                .Connection = database.GetConnection()
            }

            Dim databaseBackup As New MySqlBackup(command)
            databaseBackup.ExportToFile(fileName)

            Return True

        Catch ex As Exception
            Console.WriteLine(ex)
            Return False
        End Try
    End Function

    Public Function Restore(fileName As String) As Boolean
        Try
            Dim command As New MySqlCommand With {
                .Connection = database.GetConnection()
            }

            Dim databaseRestore As New MySqlBackup(command)
            databaseRestore.ImportFromFile(fileName)

            Return True

        Catch ex As Exception
            Console.WriteLine(ex)
            Return False
        End Try
    End Function

End Class
