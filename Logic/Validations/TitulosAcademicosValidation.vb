Imports Entities

Public Class TitulosAcademicosValidation

    Public Entity As TitulosAcademicos

    Public Property IdUsuario As String
    Public Property Institucion As String
    Public Property Grado As String
    Public Property Titulo As String
    Public Property FechaObtencion As DateTime
    Public Property NumeroCedula As String

    Public Function ValidateIdUsuario() As Boolean
        Return Not String.IsNullOrWhiteSpace(Entity.IdUsuario)
    End Function

    Public Function ValidateInstitucion() As Boolean
        Return Not String.IsNullOrWhiteSpace(Entity.Institucion)
    End Function

    Public Function ValidateGrado() As Boolean
        Return Not String.IsNullOrWhiteSpace(Entity.Grado)
    End Function

    Public Function ValidateTitulo() As Boolean
        Return Not String.IsNullOrWhiteSpace(Entity.Titulo)
    End Function

    Public Function ValidateFechaObtencion() As Boolean
        Return True
    End Function

    Public Function ValidateNumeroCedula() As Boolean
        Return Not String.IsNullOrWhiteSpace(Entity.NumeroCedula)
    End Function

    Public Function ValidateAll() As Boolean
        Return ValidateIdUsuario() And ValidateInstitucion() And ValidateGrado() And ValidateTitulo() And ValidateFechaObtencion() And ValidateNumeroCedula()
    End Function

End Class
