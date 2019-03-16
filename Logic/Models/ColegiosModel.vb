Imports Data
Imports Entities

Public Class ColegiosModel
    Inherits Model(Of Colegios)

    Public Entity As Colegios
    Private repository = New ColegiosRepository()

    Public Sub New()

    End Sub

    Public Sub New(Entity As Colegios)
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

    Public Overrides Function GetEntities() As List(Of Colegios)
        Return repository.SelectAll()
    End Function

    Public Overrides Function GetEntityWithId() As Colegios
        Throw New NotImplementedException()
    End Function

    Public Overrides Function GetEntitiesWithId() As List(Of Colegios)
        Throw New NotImplementedException()
    End Function
End Class
