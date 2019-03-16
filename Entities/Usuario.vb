Public Class Usuario

    Public IdUsuario As String
    Public Contrasena As String
    Public Imagen As String

    Public Overrides Function ToString() As String
        Return "Usuario {" +
            "IdUsuario: " + IdUsuario + ", " +
            "Contrasena: " + Contrasena + ", " +
            "Imagen: " + Imagen + " }"
    End Function

End Class
