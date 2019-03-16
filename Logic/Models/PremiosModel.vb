Imports Data
Imports Entities

Public Class PremiosModel
    Inherits Model(Of Premios)

    Public Entity As Premios
    Private repository = New PremiosRepository()

    Public Sub New()

    End Sub

    Public Sub New(Entity As Premios)
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

    Public Overrides Function GetEntities() As List(Of Premios)
        Return repository.SelectAll()
    End Function

    Public Overrides Function GetEntityWithId() As Premios
        Throw New NotImplementedException()
    End Function

    Public Overrides Function GetEntitiesWithId() As List(Of Premios)
        Throw New NotImplementedException()
    End Function
End Class
