Imports System.Text

Public Class UniqueKeyGenerator

    Private Const upperCaseLetters As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
    Private Const lowerCaseLetters As String = "abcdefghijklmnopqrstuvwxyz"
    Private Const numbers As String = "0123456789"

    Public Function GenerateKey() As String
        Dim key As New StringBuilder()
        Dim random As New Random()

        While key.Length <> 16
            Dim operation = random.Next(3)
            Dim i As Integer
            Select Case operation
                Case 0
                    i = random.Next(upperCaseLetters.Length)
                    key.Append(upperCaseLetters(i))
                Case 1
                    i = random.Next(lowerCaseLetters.Length)
                    key.Append(lowerCaseLetters(i))
                Case 2
                    i = random.Next(numbers.Length)
                    key.Append(numbers(i))
            End Select
        End While

        Return key.ToString()
    End Function

End Class
