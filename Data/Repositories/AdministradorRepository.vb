Imports Data
Imports Entities

Public Class AdministradorRepository
    Inherits MasterRepository(Of Administrador)
    Implements IUsuarioContract(Of Administrador)

    Protected queryCheckExistance As String

    Public Sub New()
        querySelectId = "select * from administradores where id_admin = @id_admin"

        queryCheckExistance = "select * from administradores where id_admin = @id_admin and contrasena = @contrasena"
    End Sub

    Public Function CheckExistance(e As Administrador) As Boolean Implements IUsuarioContract(Of Administrador).CheckExistance
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_admin", e.IdAdmin)
        parameters.Add("@contrasena", e.Contrasena)

        Dim dataTable = ExecuteSelect(queryCheckExistance)

        Return dataTable.Rows.Count <> 0
    End Function

    Public Function Insert(e As Administrador) As Boolean Implements IGenericContract(Of Administrador).Insert
        Throw New NotImplementedException()
    End Function

    Public Function Delete(id As Object) As Boolean Implements IGenericContract(Of Administrador).Delete
        Throw New NotImplementedException()
    End Function

    Public Function DeleteSpecific(e As Administrador) As Boolean Implements IGenericContract(Of Administrador).DeleteSpecific
        Throw New NotImplementedException()
    End Function

    Public Function Update(e As Administrador) As Boolean Implements IGenericContract(Of Administrador).Update
        Throw New NotImplementedException()
    End Function

    Public Function SelectAll() As List(Of Administrador) Implements IGenericContract(Of Administrador).SelectAll
        Throw New NotImplementedException()
    End Function

    Public Function SelectWithId(id As Object) As Administrador Implements IGenericContract(Of Administrador).SelectWithId
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_admin", id)

        Dim dataTable = ExecuteSelect(querySelectId)
        Dim admin As Administrador = Nothing

        For Each row As DataRow In dataTable.Rows
            Dim idAdmin = row.Field(Of String)("id_admin")
            Dim contrasena = row.Field(Of String)("contrasena")

            admin = New Administrador With {
                .IdAdmin = idAdmin,
                .Contrasena = contrasena
            }
        Next

        Return admin
    End Function

    Public Function SelectAllWithId(id As Object) As List(Of Administrador) Implements IGenericContract(Of Administrador).SelectAllWithId
        Throw New NotImplementedException()
    End Function

    Public Function CheckVerifiedEmail(e As Administrador) As Boolean Implements IUsuarioContract(Of Administrador).CheckVerifiedEmail
        Throw New NotImplementedException()
    End Function

    Public Function ActivateAccount(e As Administrador) As Boolean Implements IUsuarioContract(Of Administrador).ActivateAccount
        Throw New NotImplementedException()
    End Function

    Public Function CheckActivationId(e As Administrador) As Boolean Implements IUsuarioContract(Of Administrador).CheckActivationId
        Throw New NotImplementedException()
    End Function
End Class
