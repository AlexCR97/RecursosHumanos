Imports Data
Imports Entities

Public Class CertificacionesModel
    Inherits Model(Of Certificaciones)

    Public Entity As Certificaciones
    Private repository = New CertificacionesRepository()

    Public Sub New()

    End Sub

    Public Sub New(Entity As Certificaciones)
        Me.Entity = Entity
    End Sub

    Public Overrides Function ExecuteChanges() As Boolean
        Select Case State
            Case STATE_INSERT
                Return repository.Insert(Entity)

            Case STATE_DELETE
                Return repository.Delete(Entity.IdUsuario)

            Case STATE_UPDATE
                Return repository.Update(Entity)
        End Select

        Return False
    End Function

    Public Overrides Function GetEntities() As List(Of Certificaciones)
        Return repository.SelectAll()
    End Function

    Public Overrides Function GetEntityWithId() As Certificaciones
        Throw New NotImplementedException()
    End Function

    Public Overrides Function GetEntitiesWithId() As List(Of Certificaciones)
        Throw New NotImplementedException()
    End Function
End Class
