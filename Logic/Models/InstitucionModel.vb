Imports Data
Imports Entities

Public Class InstitucionModel
    Inherits Model(Of Institucion)

    Public Entity As Institucion
    Private repository = New InstitucionRepository()

    Public Sub New()

    End Sub

    Public Sub New(Entity As Institucion)
        Me.Entity = Entity
    End Sub

    Public Overrides Function ExecuteChanges() As Boolean
        Select Case State
            Case STATE_INSERT
                Return repository.Insert(Entity)

            Case STATE_DELETE
                Return repository.Delete(Entity.IdInstitucion)

            Case STATE_UPDATE
                Return repository.Update(Entity)
        End Select

        Return False
    End Function

    Public Overrides Function GetEntities() As List(Of Institucion)
        Return repository.SelectAll()
    End Function

    Public Overrides Function GetEntityWithId() As Institucion
        Throw New NotImplementedException()
    End Function

    Public Overrides Function GetEntitiesWithId() As List(Of Institucion)
        Throw New NotImplementedException()
    End Function
End Class
