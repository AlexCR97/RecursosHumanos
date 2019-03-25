Imports Entities

Public Class ColegiosValidation

    Public Entity As Colegios

    Public Function ValidateIdUsuario() As Boolean
        Return Not String.IsNullOrWhiteSpace(Entity.IdUsuario)
    End Function

    Public Function ValidateNombramiento() As Boolean
        Return Not String.IsNullOrWhiteSpace(Entity.Nombramiento)
    End Function

    Public Function ValidateColegio() As Boolean
        Return Not String.IsNullOrWhiteSpace(Entity.Colegio)
    End Function

    Public Function ValidateAfiliacion() As Boolean
        Return Not String.IsNullOrWhiteSpace(Entity.Afiliacion)
    End Function

    Public Function ValidateAll() As Boolean
        Return ValidateIdUsuario() And ValidateNombramiento() And ValidateColegio() And ValidateAfiliacion()
    End Function

End Class
