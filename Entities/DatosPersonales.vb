Public Class DatosPersonales

    Public IdUsuario As String
    Public Nombre As String
    Public ApellidoPaterno As String
    Public ApellidoMaterno As String
    Public Sexo As String
    Public PaisNacimiento As String
    Public FechaNacimiento As DateTime
    Public Curp As String
    Public Rfc As String
    Public Cvu As String
    Public Biografia As String

    Public Overrides Function ToString() As String
        Return "DatosPersonales {IdUsuario:" & IdUsuario & ", Nombre:" & Nombre & ", ApellidoPaterno:" & ApellidoPaterno &
            ", ApellidoMaterno:" & ApellidoMaterno & ", Sexo:" & Sexo & ", PaisNacimiento:" & PaisNacimiento &
            ", FechaNacimiento:" & FechaNacimiento & ", Curp:" & Curp & ", Rfc:" & Rfc & ", Cvu:" & Cvu & ", Biografia:" & Biografia & "}\n"
    End Function

End Class
