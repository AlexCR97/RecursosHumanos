Imports MySql.Data.MySqlClient
Imports System.Data.Sql

Public Class MasterRepository

    Private database As New Database()
    Protected parameters As Dictionary(Of String, Object)

    Protected queryInsert As String
    Protected queryDelete As String
    Protected queryUpdate As String
    Protected querySelect As String

    Protected Function ExecuteQuery(query As String) As Boolean
        Using connection = database.GetConnection()
            Using command As New MySqlCommand()
                command.Connection = connection
                command.CommandText = query
                command.CommandType = CommandType.Text

                For Each pair As KeyValuePair(Of String, Object) In parameters
                    Dim key = pair.Key
                    Dim value = pair.Value
                    command.Parameters.AddWithValue(key, value)
                Next

                Try
                    Dim affectedRowsCount = command.ExecuteNonQuery()
                    If affectedRowsCount <= 0 Then
                        Return False
                    End If

                    Return True

                Catch ex As Exception
                    Console.WriteLine("Exception in Data Layer: " + ex.Message)
                    Return False
                End Try
            End Using
        End Using
    End Function

    Protected Function ExecuteSelect(query As String) As DataTable
        Using connection = database.GetConnection()
            Using command As New MySqlCommand()
                command.Connection = connection
                command.CommandText = query
                command.CommandType = CommandType.Text

                Try
                    Dim dataTable As New DataTable()
                    Dim dataAdapter As New MySqlDataAdapter(command)
                    dataAdapter.Fill(dataTable)

                    Return dataTable

                Catch ex As Exception
                    Return Nothing
                End Try
            End Using
        End Using
    End Function

End Class
