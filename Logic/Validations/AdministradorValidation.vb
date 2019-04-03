Imports Entities

Public Class AdministradorValidation

    Public Entity As Administrador

    Public Function ValidateId() As Boolean
        Return Not String.IsNullOrWhiteSpace(Entity.IdAdmin)
    End Function

    Public Function ValidateContrasena() As Boolean
        Return Not String.IsNullOrWhiteSpace(Entity.Contrasena)
    End Function

    Public Function ValidateAll() As Boolean
        Return ValidateId() And ValidateContrasena()
    End Function

End Class
