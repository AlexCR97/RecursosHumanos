Public MustInherit Class Model(Of Entity)

    Public Const STATE_INSERT = 1
    Public Const STATE_DELETE = 2
    Public Const STATE_UPDATE = 3
    Public Const STATE_DELETE_SPECIFIC = 4

    Public State As Integer

    Public MustOverride Function ExecuteChanges() As Boolean
    Public MustOverride Function GetEntities() As List(Of Entity)
    Public MustOverride Function GetEntityWithId() As Entity
    Public MustOverride Function GetEntitiesWithId() As List(Of Entity)

End Class
