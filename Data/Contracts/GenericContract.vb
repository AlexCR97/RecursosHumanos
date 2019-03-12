Public Interface GenericContract(Of Entity)

    Function Insert(e As Entity) As Boolean
    Function Delete(id As Object) As Boolean
    Function Update(e As Entity) As Boolean

    Function SelectAll() As List(Of Entity)

End Interface
