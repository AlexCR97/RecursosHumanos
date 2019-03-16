Imports Data
Imports Entities

Public Class CorreosRepository
    Inherits MasterRepository(Of Correos)
    Implements IGenericContract(Of Correos)

    Public Sub New()
        queryInsert = "insert into correos values (@id_usuario, @correo)"
        queryDelete = "delete from correos where id_usuario = @id_usuario"
        queryDeleteSpecific = "delete from correos where id_usuario = @id_usuario and correo = @correo"
        queryUpdate = "update correos set id_usuario = @id_usuario, correo = @correo where id_usuario = @id_usuario"
        querySelect = "select * from correos"
        querySelectAllId = "select * from correos where id_usuario = @id_usuario"
    End Sub

    Public Function Insert(e As Correos) As Boolean Implements IGenericContract(Of Correos).Insert
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@correo", e.Correo)
        Return ExecuteQuery(queryInsert)
    End Function

    Public Function Delete(id As Object) As Boolean Implements IGenericContract(Of Correos).Delete
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", id)
        Return ExecuteQuery(queryDelete)
    End Function

    Public Function Update(e As Correos) As Boolean Implements IGenericContract(Of Correos).Update
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@correo", e.Correo)
        Return ExecuteQuery(queryUpdate)
    End Function

    Public Function SelectAll() As List(Of Correos) Implements IGenericContract(Of Correos).SelectAll
        parameters = New Dictionary(Of String, Object)

        Dim dataTable = ExecuteSelect(querySelect)
        Dim correos As New List(Of Correos)

        For Each row As DataRow In dataTable.Rows
            Dim idUsuario = row.Field(Of String)("id_usuario")
            Dim correo = row.Field(Of String)("correo")

            Dim c As New Correos With {
                .IdUsuario = idUsuario,
                .Correo = correo
            }

            correos.Add(c)
        Next

        Return correos
    End Function

    Public Function SelectWithId(id As Object) As Correos Implements IGenericContract(Of Correos).SelectWithId
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", id)

        Dim dataTable = ExecuteSelect(querySelectId)
        Dim correo As Correos

        For Each row As DataRow In dataTable.Rows
            Dim idUsuario = row.Field(Of String)("id_usuario")
            Dim c = row.Field(Of String)("correo")

            correo = New Correos With {
                .IdUsuario = idUsuario,
                .Correo = c
            }
        Next

        Return correo
    End Function

    Public Function SelectAllWithId(id As Object) As List(Of Correos) Implements IGenericContract(Of Correos).SelectAllWithId
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", id)

        Dim dataTable = ExecuteSelect(querySelectAllId)
        Dim correos As New List(Of Correos)

        For Each row As DataRow In dataTable.Rows
            Dim idUsuario = row.Field(Of String)("id_usuario")
            Dim correo = row.Field(Of String)("correo")

            Dim c As New Correos With {
                .IdUsuario = idUsuario,
                .Correo = correo
            }

            correos.Add(c)
        Next

        Return correos
    End Function

    Public Function DeleteSpecific(e As Correos) As Boolean Implements IGenericContract(Of Correos).DeleteSpecific
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@correo", e.Correo)
        Return ExecuteQuery(queryDeleteSpecific)
    End Function
End Class
