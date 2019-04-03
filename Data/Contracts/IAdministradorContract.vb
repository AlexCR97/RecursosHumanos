Public Interface IAdministradorContract(Of Entity)
    Inherits IGenericContract(Of Entity)

    Function CheckExistance(e As Entity) As Boolean

End Interface
