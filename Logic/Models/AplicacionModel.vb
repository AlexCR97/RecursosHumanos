Imports Data
Imports Entities

Public Class AplicacionModel
    Inherits Model(Of Aplicacion)

    Public Entity As Aplicacion
    Private repository = New AplicacionRepository()

    Public Sub New()

    End Sub

    Public Sub New(Entity As Aplicacion)
        Me.Entity = Entity
    End Sub

    Public Overrides Function ExecuteChanges() As Boolean
        Select Case State
            Case STATE_UPDATE
                Return repository.Update(Entity)
        End Select

        Return False
    End Function

    Public Overrides Function GetEntities() As List(Of Aplicacion)
        Throw New NotImplementedException()
    End Function

    Public Overrides Function GetEntityWithId() As Aplicacion
        Return repository.SelectWithId(-1)
    End Function

    Public Overrides Function GetEntitiesWithId() As List(Of Aplicacion)
        Throw New NotImplementedException()
    End Function
End Class
