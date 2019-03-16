Imports Entities

Public Class TelefonosValidation

    Public Entity As Telefonos

    Public Function ValidateId() As Boolean
        Return Not String.IsNullOrWhiteSpace(Entity.IdUsuario)
    End Function

    Public Function ValidateTelefono() As Boolean
        Return Not String.IsNullOrWhiteSpace(Entity.Telefono)
    End Function

    Public Function ValidateAll() As Boolean
        Return ValidateId() And ValidateTelefono()
    End Function

End Class
