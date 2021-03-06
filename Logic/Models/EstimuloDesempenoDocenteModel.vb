﻿Imports Data
Imports Entities

Public Class EstimuloDesempenoDocenteModel
    Inherits Model(Of EstimuloDesempenoDocente)

    Public Entity As EstimuloDesempenoDocente
    Private repository = New EstimuloDesempenoDocenteRepository()

    Public Sub New()

    End Sub

    Public Sub New(Entity As EstimuloDesempenoDocente)
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

    Public Overrides Function GetEntities() As List(Of EstimuloDesempenoDocente)
        Return repository.SelectAll()
    End Function

    Public Overrides Function GetEntityWithId() As EstimuloDesempenoDocente
        Throw New NotImplementedException()
    End Function

    Public Overrides Function GetEntitiesWithId() As List(Of EstimuloDesempenoDocente)
        Throw New NotImplementedException()
    End Function
End Class
