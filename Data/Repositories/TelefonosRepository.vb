Imports Data
Imports Entities

Public Class TelefonosRepository
    Inherits MasterRepository
    Implements GenericContract(Of Telefonos)

    Public Sub New()
        queryInsert = "insert into telefonos values (@id_usuario, @telefono)"
        queryDelete = "delete from telefonos where id_usuario = @id_usuario"
        queryUpdate = "update telefonos set id_usuario = @id_usuario, telefono = @telefono where id_usuario = @id_usuario"
        querySelect = "select * from telefonos"
    End Sub

    Public Function Insert(e As Telefonos) As Boolean Implements GenericContract(Of Telefonos).Insert
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@telefono", e.Telefono)
        Return ExecuteQuery(queryInsert)
    End Function

    Public Function Delete(id As Object) As Boolean Implements GenericContract(Of Telefonos).Delete
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", id)
        Return ExecuteQuery(queryDelete)
    End Function

    Public Function Update(e As Telefonos) As Boolean Implements GenericContract(Of Telefonos).Update
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@telefono", e.Telefono)
        Return ExecuteQuery(queryUpdate)
    End Function

    Public Function SelectAll() As List(Of Telefonos) Implements GenericContract(Of Telefonos).SelectAll
        Dim dataTable = ExecuteSelect(querySelect)
        Dim telefonos As New List(Of Telefonos)

        For Each row As DataRow In dataTable.Rows
            Dim idUsuario = row.Field(Of String)("id_usuario")
            Dim telefono = row.Field(Of String)("telefono")

            Dim i As New Telefonos With {
                .IdUsuario = idUsuario,
                .Telefono = telefono
            }

            telefonos.Add(i)
        Next

        Return telefonos
    End Function
End Class
