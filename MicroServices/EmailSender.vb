Imports System.Net
Imports System.Net.Mail

Public Class EmailSender

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

    Public Function SendEmail(toMail As String, subject As String, message As String) As Boolean
        Try
            Dim server As New SmtpClient() With {
                .UseDefaultCredentials = False,
                .Credentials = New NetworkCredential(fromMail, fromPassword),
                .Port = 587,
                .EnableSsl = True,
                .Host = host
            }

            Dim mail As New MailMessage(fromMail, toMail) With {
                .IsBodyHtml = True,
                .Subject = subject,
                .Body = message
            }

            server.Send(mail)

            Return True
        Catch ex As Exception
            Console.WriteLine(ex)
            Return False
        End Try
    End Function

End Class
