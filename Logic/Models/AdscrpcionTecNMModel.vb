Imports Data
Imports Entities

Public Class AdscrpcionTecNMModel
    Inherits Model

    Public Entity As AdscripcionTecNM
    Private repository = New AdscripcionTecNMRepository()

    Public Sub New()

    End Sub

    Public Sub New(Entity As AdscripcionTecNM)
        Me.Entity = Entity
    End Sub

    Public Overrides Function ExecuteChanges() As Boolean
        Select Case State
            Case Model.STATE_INSERT
                Return repository.Insert(Entity)

            Case Model.STATE_DELETE
                Return repository.Delete(Entity.IdUsuario)

            Case Model.STATE_UPDATE
                Return repository.Update(Entity)
        End Select

        Return False
    End Function

    Public Overrides Function GetEntities() As List(Of Object)
        Return repository.SelectAll()
    End Function
End Class
