Imports Entities

Public Class ProductosDeInvestigacionValidation

    Public Entity As ProductosDeInvestigacion

    Public Function ValidateIdUsuario() As Boolean
        Return Not String.IsNullOrWhiteSpace(Entity.IdUsuario)
    End Function

    Public Function ValidateTitulo() As Boolean
        Return Not String.IsNullOrWhiteSpace(Entity.Titulo)
    End Function

    Public Function ValidateProposito() As Boolean
        Return Not String.IsNullOrWhiteSpace(Entity.Proposito)
    End Function

    Public Function ValidateFechaPublicacion() As Boolean
        Return True
    End Function

    Public Function ValidateTipoProducto() As Boolean
        Return Not String.IsNullOrWhiteSpace(Entity.TipoProducto)
    End Function

    Public Function ValidateAll() As Boolean
        Return ValidateIdUsuario() And ValidateTitulo() And ValidateProposito() And ValidateFechaPublicacion() And ValidateTipoProducto()
    End Function

End Class
