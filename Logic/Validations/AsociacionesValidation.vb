Imports Entities

Public Class AsociacionesValidation

    Public Entity As Asociaciones

    Public Function ValidateIdUsuario() As Boolean
        Return Not String.IsNullOrWhiteSpace(Entity.IdUsuario)
    End Function

    Public Function ValidateOrganismo() As Boolean
        Return Not String.IsNullOrWhiteSpace(Entity.Organismo)
    End Function

    Public Function ValidateNombramiento() As Boolean
        Return Not String.IsNullOrWhiteSpace(Entity.Nombramiento)
    End Function

    Public Function ValidateAnioAfiliacion() As Boolean
        Return True
    End Function

    Public Function ValidateInicioVigencia() As Boolean
        Return True
    End Function

    Public Function ValidateFinVigencia() As Boolean
        Return True
    End Function

    Public Function ValidateAll() As Boolean
        Return ValidateIdUsuario() And ValidateOrganismo() And ValidateNombramiento() And ValidateAnioAfiliacion() And ValidateFinVigencia() And ValidateInicioVigencia()
    End Function

End Class
