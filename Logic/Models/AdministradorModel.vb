Imports Data
Imports Entities

Public Class AdministradorModel
    Inherits Model(Of Administrador)

    Public Const STATE_CHECK_EXISTANCE = 4

    Public Entity As Administrador
    Private repository = New AdministradorRepository()

    Public Sub New()

    End Sub

    Public Sub New(Entity As Administrador)
        Me.Entity = Entity
    End Sub

    Public Overrides Function ExecuteChanges() As Boolean
        Select Case State
            Case STATE_CHECK_EXISTANCE
                Return repository.CheckExistance(Entity)
        End Select

        Return False
    End Function

    Public Overrides Function GetEntities() As List(Of Administrador)
        Throw New NotImplementedException()
    End Function

    Public Overrides Function GetEntityWithId() As Administrador
        Return repository.SelectWithId(Entity.IdAdmin)
    End Function

    Public Overrides Function GetEntitiesWithId() As List(Of Administrador)
        Throw New NotImplementedException()
    End Function
End Class
