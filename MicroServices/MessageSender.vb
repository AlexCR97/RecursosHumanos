Imports System.Net

Public Class MessageSender

    Private fromMail As String
    Private fromPassword As String
    Private host As String

    Public Sub New()
        Me.fromMail = "castillo.ramirez.16225@itsmante.edu.mx"
        Me.fromPassword = "sam.loves.ham"
        Me.host = "smtp.gmail.com"
    End Sub

    Public Sub New(fromMail As String, fromPassword As String, host As String)
        Me.fromMail = fromMail
        Me.fromPassword = fromPassword
        Me.host = host
    End Sub

    Public Function SendMessage() As Boolean
        Try
            Dim request As HttpWebRequest
            Dim response As HttpWebResponse

            Dim url As String
            Dim host As String

            Return True
        Catch ex As Exception
            Console.WriteLine(ex)
            Return False
        End Try
    End Function

End Class
