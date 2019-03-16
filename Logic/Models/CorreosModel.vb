Imports Data
Imports Entities

Public Class CorreosModel
    Inherits Model(Of Correos)

    Public Entity As Correos
    Private repository As CorreosRepository = New CorreosRepository()

    Public Sub New()

    End Sub

    Public Sub New(Entity As Correos)
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

    Public Overrides Function GetEntities() As List(Of Correos)
        Return repository.SelectAll()
    End Function

    Public Overrides Function GetEntityWithId() As Correos
        Throw New NotImplementedException()
    End Function

    Public Overrides Function GetEntitiesWithId() As List(Of Correos)
        Return repository.SelectAllWithId(Entity.IdUsuario)
    End Function
End Class
