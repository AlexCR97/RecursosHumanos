Public Interface IUsuarioContract(Of Entity)
    Inherits IGenericContract(Of Entity)

    Function ActivateAccount(e As Entity) As Boolean
    Function CheckActivationId(e As Entity) As Boolean
    Function CheckExistance(e As Entity) As Boolean
    Function CheckVerifiedEmail(e As Entity) As Boolean

End Interface
