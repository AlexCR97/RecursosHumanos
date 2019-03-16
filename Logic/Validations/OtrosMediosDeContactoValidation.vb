Imports Entities

Public Class OtrosMediosDeContactoValidation

    Public Entity As OtrosMediosDeContacto

    Public Function ValidateId() As Boolean
        Return Not String.IsNullOrWhiteSpace(Entity.IdUsuario)
    End Function

    Public Function ValidateMedio() As Boolean
        Return Not String.IsNullOrWhiteSpace(Entity.Medio)
    End Function

    Public Function ValidateDescripcion() As Boolean
        Return Not String.IsNullOrWhiteSpace(Entity.Descripcion)
    End Function

    Public Function ValidateAll() As Boolean
        Return ValidateId() And ValidateMedio() And ValidateDescripcion()
    End Function

End Class
