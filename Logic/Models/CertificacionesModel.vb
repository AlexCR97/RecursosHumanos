﻿Imports Data
Imports Entities

Public Class CertificacionesModel
    Inherits Model

    Public Entity As Certificaciones
    Private repository = New CertificacionesRepository()

    Public Sub New()

    End Sub

    Public Sub New(Entity As Certificaciones)
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
