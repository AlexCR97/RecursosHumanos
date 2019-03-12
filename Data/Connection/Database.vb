Imports MySql.Data.MySqlClient

Public Class Database

    Private host = "localhost"
    Private dbName = "recursos_humanos"
    Private user = "root"
    Private pass = "Carp1997"

    Public Function GetConnection() As MySqlConnection
        Try
            Dim url = "server=" & host & ";port=3406;database=" & dbName & ";user=" & user & ";password=" & pass

            Dim connection As New MySqlConnection()
            connection.ConnectionString = url
            connection.Open()

            If connection.State <> ConnectionState.Open Then
                Return Nothing
            End If

            Return connection

        Catch ex As Exception
            Return Nothing
        End Try
    End Function

End Class
