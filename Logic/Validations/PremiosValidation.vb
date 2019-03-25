﻿Imports Entities

Public Class PremiosValidation

    Public Entity As Premios

    Public Function ValidateIdUsuario() As Boolean
        Return Not String.IsNullOrWhiteSpace(Entity.IdUsuario)
    End Function

    Public Function ValidateInstitucion() As Boolean
        Return Not String.IsNullOrWhiteSpace(Entity.Institucion)
    End Function

    Public Function ValidateDescripcion() As Boolean
        Return Not String.IsNullOrWhiteSpace(Entity.Descripcion)
    End Function

    Public Function ValidateFechaCertificacion() As Boolean
        Return True
    End Function

    Public Function ValidateAll() As Boolean
        Return ValidateIdUsuario() And ValidateInstitucion() And ValidateDescripcion() And ValidateFechaCertificacion()
    End Function

End Class
