Public MustInherit Class Model

    Public Const STATE_INSERT = 1
    Public Const STATE_DELETE = 2
    Public Const STATE_UPDATE = 3

    Public State As Integer

    Public MustOverride Function ExecuteChanges() As Boolean
    Public MustOverride Function GetEntities() As List(Of Object)

End Class
