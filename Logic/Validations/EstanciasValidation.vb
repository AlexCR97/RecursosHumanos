Imports Entities

Public Class EstanciasValidation

    Public Entity As Estancias

    Public Function ValidateIdUsuario() As Boolean
        Return Not String.IsNullOrWhiteSpace(Entity.IdUsuario)
    End Function

    Public Function ValidateInstitucion() As Boolean
        Return Not String.IsNullOrWhiteSpace(Entity.Institucion)
    End Function

    Public Function ValidateNombreProyecto() As Boolean
        Return Not String.IsNullOrWhiteSpace(Entity.NombreProyecto)
    End Function

    Public Function ValidateFechaInicio() As Boolean
        Return True
    End Function

    Public Function ValidateFechaTermino() As Boolean
        Return True
    End Function

    Public Function ValidateAll() As Boolean
        Return ValidateIdUsuario() And ValidateInstitucion() And ValidateNombreProyecto() And ValidateFechaInicio() And ValidateFechaTermino()
    End Function
End Class
