Imports Entities

Public Class UsuarioValidation

    Public Entity As Usuario

    Public Function ValidateId() As Boolean
        Return Not String.IsNullOrWhiteSpace(Entity.IdUsuario)
    End Function

    Public Function ValidateContrasena() As Boolean
        Return Not String.IsNullOrWhiteSpace(Entity.Contrasena)
    End Function

    Public Function ValidateIdActivacion() As Boolean
        Return True
    End Function

    Public Function ValidateCuentaVerificada() As Boolean
        Return True
    End Function

    Public Function ValidateAll() As Boolean
        Return ValidateId() And ValidateContrasena() And ValidateIdActivacion() And ValidateCuentaVerificada()
    End Function

End Class
