Imports Entities

Public Class AdscripcionTecNMValidation

    Public Entity As AdscripcionTecNM

    Public Function ValidateIdUsuario() As Boolean
        Return Not String.IsNullOrWhiteSpace(Entity.IdUsuario)
    End Function

    Public Function ValidatePlantel() As Boolean
        Return Not String.IsNullOrWhiteSpace(Entity.Plantel)
    End Function

    Public Function ValidateFechaAdscripcion() As Boolean
        Return True
    End Function

    Public Function ValidateVigente() As Boolean
        Return True
    End Function

    Public Function ValidateAll() As Boolean
        Return ValidateIdUsuario() And ValidatePlantel() And ValidateFechaAdscripcion() And ValidateVigente()
    End Function

End Class
