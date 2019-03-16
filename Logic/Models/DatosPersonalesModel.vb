Imports Data
Imports Entities

Public Class DatosPersonalesModel
    Inherits Model(Of DatosPersonales)

    Public Entity As DatosPersonales
    Private repository = New DatosPersonalesRepository()

    Public Sub New()

    End Sub

    Public Sub New(Entity As DatosPersonales)
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

    Public Overrides Function GetEntities() As List(Of DatosPersonales)
        Return repository.SelectAll()
    End Function

    Public Overrides Function GetEntityWithId() As DatosPersonales
        Return repository.SelectWithId(Entity.IdUsuario)
    End Function

    Public Overrides Function GetEntitiesWithId() As List(Of DatosPersonales)
        Throw New NotImplementedException()
    End Function
End Class
