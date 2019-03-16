Imports Entities

Public Class UsuarioValidation

    Public Entity As Usuario

    Public Function ValidateId() As Boolean
        Return Not String.IsNullOrWhiteSpace(Entity.IdUsuario)
    End Function

    Public Function ValidateContrasena() As Boolean
        Return Not String.IsNullOrWhiteSpace(Entity.Contrasena)
    End Function

    Public Function ValidateImagen() As Boolean
        Return True
    End Function

    Public Function ValidateAll() As Boolean
        Return ValidateId() And ValidateContrasena() And ValidateImagen()
    End Function

End Class
