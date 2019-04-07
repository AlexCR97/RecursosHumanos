Imports Data
Imports Entities

Public Class UsuarioModel
    Inherits Model(Of Usuario)

    Public Const STATE_CHECK_EXISTANCE = 4
    Public Const STATE_CHECK_VERIFIED_EMAIL = 5
    Public Const STATE_CHECK_ACTIVATION_ID = 6
    Public Const STATE_ACTIVATE_ACCOUNT = 7

    Public Entity As Usuario
    Private repository As UsuarioRepository = New UsuarioRepository()

    Public Sub New()

    End Sub

    Public Sub New(Entity As Usuario)
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

            Case STATE_CHECK_EXISTANCE
                Return repository.CheckExistance(Entity)

            Case STATE_CHECK_VERIFIED_EMAIL
                Return repository.CheckVerifiedEmail(Entity)

            Case STATE_CHECK_ACTIVATION_ID
                Return repository.CheckActivationId(Entity)

            Case STATE_ACTIVATE_ACCOUNT
                Return repository.ActivateAccount(Entity)
        End Select

        Return False
    End Function

    Public Overrides Function GetEntities() As List(Of Usuario)
        Return repository.SelectAll()
    End Function

    Public Overrides Function GetEntityWithId() As Usuario
        Return repository.SelectWithId(Entity.IdUsuario)
    End Function

    Public Overrides Function GetEntitiesWithId() As List(Of Usuario)
        Throw New NotImplementedException()
    End Function
End Class
