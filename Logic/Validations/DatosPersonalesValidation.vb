Imports Entities

Public Class DatosPersonalesValidation

    Public Entity As DatosPersonales

    Public Function ValidateId() As Boolean
        Return Not String.IsNullOrWhiteSpace(Entity.IdUsuario)
    End Function

    Public Function ValidateNombre() As Boolean
        Return Not String.IsNullOrWhiteSpace(Entity.Nombre)
    End Function

    Public Function ValidateApellidoPaterno() As Boolean
        Return Not String.IsNullOrWhiteSpace(Entity.ApellidoPaterno)
    End Function

    Public Function ValidateApellidoMaterno() As Boolean
        Return Not String.IsNullOrWhiteSpace(Entity.ApellidoMaterno)
    End Function

    Public Function ValidateSexo() As Boolean
        Return True
    End Function

    Public Function ValidatePaisNacimiento() As Boolean
        Return Not String.IsNullOrWhiteSpace(Entity.PaisNacimiento)
    End Function

    Public Function ValidateFechaNacimiento() As Boolean
        Return True
    End Function

    Public Function ValidateCurp() As Boolean
        Return Not String.IsNullOrWhiteSpace(Entity.Curp) And Entity.Curp.Length <= 18
    End Function

    Public Function ValidateRfc() As Boolean
        Return Not String.IsNullOrWhiteSpace(Entity.Rfc) And Entity.Rfc.Length <= 13
    End Function

    Public Function ValidateCvu() As Boolean
        Return Not String.IsNullOrWhiteSpace(Entity.Cvu) And Entity.Cvu.Length <= 20
    End Function

    Public Function ValidateBiografia() As Boolean
        Return True
    End Function

    Public Function ValidateAll() As Boolean
        Return ValidateId() And ValidateNombre() And ValidateApellidoPaterno() And ValidateApellidoMaterno() And ValidateSexo() And ValidatePaisNacimiento() And ValidateFechaNacimiento() And ValidateCurp() And ValidateRfc() And ValidateCvu() And ValidateBiografia()
    End Function

End Class
