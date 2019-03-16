Imports Data
Imports Entities

Public Class TelefonosRepository
    Inherits MasterRepository(Of Telefonos)
    Implements IGenericContract(Of Telefonos)

    Public Sub New()
        queryInsert = "insert into telefonos values (@id_usuario, @telefono)"
        queryDelete = "delete from telefonos where id_usuario = @id_usuario"
        queryDeleteSpecific = "delete from telefonos where id_usuario = @id_usuario and telefono = @telefono"
        queryUpdate = "update telefonos set id_usuario = @id_usuario, telefono = @telefono where id_usuario = @id_usuario"
        querySelect = "select * from telefonos"
        querySelectAllId = "select * from telefonos where id_usuario = @id_usuario"
    End Sub

    Public Function Insert(e As Telefonos) As Boolean Implements IGenericContract(Of Telefonos).Insert
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@telefono", e.Telefono)
        Return ExecuteQuery(queryInsert)
    End Function

    Public Function Delete(id As Object) As Boolean Implements IGenericContract(Of Telefonos).Delete
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", id)
        Return ExecuteQuery(queryDelete)
    End Function

    Public Function DeleteSpecific(e As Telefonos) As Boolean Implements IGenericContract(Of Telefonos).DeleteSpecific
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@telefono", e.Telefono)
        Return ExecuteQuery(queryDeleteSpecific)
    End Function

    Public Function Update(e As Telefonos) As Boolean Implements IGenericContract(Of Telefonos).Update
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@telefono", e.Telefono)
        Return ExecuteQuery(queryUpdate)
    End Function

    Public Function SelectAll() As List(Of Telefonos) Implements IGenericContract(Of Telefonos).SelectAll
        parameters = New Dictionary(Of String, Object)

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

    Public Function SelectWithId(id As Object) As Telefonos Implements IGenericContract(Of Telefonos).SelectWithId
        Throw New NotImplementedException()
    End Function

    Public Function SelectAllWithId(id As Object) As List(Of Telefonos) Implements IGenericContract(Of Telefonos).SelectAllWithId
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", id)

        Dim dataTable = ExecuteSelect(querySelectAllId)
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
