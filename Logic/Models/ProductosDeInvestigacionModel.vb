Imports Data
Imports Entities

Public Class ProductosDeInvestigacionModel
    Inherits Model(Of ProductosDeInvestigacion)

    Public Entity As ProductosDeInvestigacion
    Private repository = New ProductosDeInvestigacionRepository()

    Public Sub New()

    End Sub

    Public Sub New(Entity As ProductosDeInvestigacion)
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

    Public Overrides Function GetEntities() As List(Of ProductosDeInvestigacion)
        Return repository.SelectAll()
    End Function

    Public Overrides Function GetEntityWithId() As ProductosDeInvestigacion
        Throw New NotImplementedException()
    End Function

    Public Overrides Function GetEntitiesWithId() As List(Of ProductosDeInvestigacion)
        Throw New NotImplementedException()
    End Function
End Class
