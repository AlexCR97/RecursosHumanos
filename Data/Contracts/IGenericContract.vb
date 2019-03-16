Public Interface IGenericContract(Of Entity)

    Function Insert(e As Entity) As Boolean
    Function Delete(id As Object) As Boolean
    Function DeleteSpecific(e As Entity) As Boolean
    Function Update(e As Entity) As Boolean
    Function SelectAll() As List(Of Entity)
    Function SelectWithId(id As Object) As Entity
    Function SelectAllWithId(id As Object) As List(Of Entity)

End Interface
