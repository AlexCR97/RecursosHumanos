Imports Entities

Public Class AdscripcionExternaValidation

    Public Entity As AdscripcionExterna

    Public Function ValidateIdUsuario() As Boolean
        Return Not String.IsNullOrWhiteSpace(Entity.IdUsuario)

    End Function

    Public Function ValidateInstitucion() As Boolean
        Return Not String.IsNullOrWhiteSpace(Entity.Institucion)
    End Function

    Public Function ValidatePuesto() As Boolean
        Return Not String.IsNullOrWhiteSpace(Entity.Puesto)
    End Function

    Public Function ValidateFechaNombramiento() As Boolean
        Return True
    End Function

    Public Function ValidateVigente() As Boolean
        Return True
    End Function

    Public Function ValidateAll() As Boolean
        Return ValidateIdUsuario() And ValidateInstitucion() And ValidatePuesto() And ValidateFechaNombramiento() And ValidateVigente()
    End Function

End Class
