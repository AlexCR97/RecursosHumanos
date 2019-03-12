Imports Data
Imports Entities

Public Class DatosPersonalesModel
    Inherits Model

    Public Entity As DatosPersonales
    Private repository = New DatosPersonales()

    Public Sub New()

    End Sub

    Public Sub New(Entity As DatosPersonales)
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
