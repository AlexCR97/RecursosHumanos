Imports Data
Imports Entities

Public Class AdscrpcionTecNMModel
    Inherits Model(Of AdscripcionTecNM)

    Public Entity As AdscripcionTecNM
    Private repository = New AdscripcionTecNMRepository()

    Public Sub New()

    End Sub

    Public Sub New(Entity As AdscripcionTecNM)
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

    Public Overrides Function GetEntities() As List(Of AdscripcionTecNM)
        Return repository.SelectAll()
    End Function

    Public Overrides Function GetEntityWithId() As AdscripcionTecNM
        Throw New NotImplementedException()
    End Function

    Public Overrides Function GetEntitiesWithId() As List(Of AdscripcionTecNM)
        Throw New NotImplementedException()
    End Function
End Class
