Imports Entities

Public Class CorreosValidation

    Public Entity As Correos

    Public Function ValidateId() As Boolean
        Return Not String.IsNullOrWhiteSpace(Entity.IdUsuario)
    End Function

    Public Function ValidateCorreo() As Boolean
        Return Not String.IsNullOrWhiteSpace(Entity.Correo)
    End Function

    Public Function ValidateAll() As Boolean
        Return ValidateId() And ValidateCorreo()
    End Function

End Class
