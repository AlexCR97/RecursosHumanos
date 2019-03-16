Imports Data
Imports Entities

Public Class TelefonosModel
    Inherits Model(Of Telefonos)

    Public Entity As Telefonos
    Private repository As TelefonosRepository = New TelefonosRepository()

    Public Sub New()

    End Sub

    Public Sub New(Entity As Telefonos)
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

            Case STATE_DELETE_SPECIFIC
                Return repository.DeleteSpecific(Entity)
        End Select

        Return False
    End Function

    Public Overrides Function GetEntities() As List(Of Telefonos)
        Return repository.SelectAll()
    End Function

    Public Overrides Function GetEntityWithId() As Telefonos
        Throw New NotImplementedException()
    End Function

    Public Overrides Function GetEntitiesWithId() As List(Of Telefonos)
        Return repository.SelectAllWithId(Entity.IdUsuario)
    End Function
End Class
