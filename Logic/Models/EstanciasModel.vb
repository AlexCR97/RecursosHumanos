Imports Data
Imports Entities

Public Class EstanciasModel
    Inherits Model(Of Estancias)

    Public Entity As Estancias
    Private repository = New EstanciasRepository

    Public Sub New()

    End Sub

    Public Sub New(Entity As Estancias)
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

    Public Overrides Function GetEntities() As List(Of Estancias)
        Return repository.SelectAll()
    End Function

    Public Overrides Function GetEntityWithId() As Estancias
        Throw New NotImplementedException()
    End Function

    Public Overrides Function GetEntitiesWithId() As List(Of Estancias)
        Throw New NotImplementedException()
    End Function
End Class
