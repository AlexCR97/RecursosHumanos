Imports Data
Imports Entities

Public Class PremiosRepository
    Inherits MasterRepository
    Implements GenericContract(Of Premios)

    Public Sub New()
        queryInsert = "insert into premios values (@id_usuario, @id_institucion, @descripcion, @fecha_certificacion)"
        queryDelete = "delete from premios where id_usuario = @id_usuario"
        queryUpdate = "update premios set 
            id_usuario = @id_usuario,
            id_institucion = @id_institucion,
            descripcion = @descripcion,
            fecha_certificacion = @fecha_certificacion 
            where id_usuario = @id_usuario"
        querySelect = "select * from premios"
    End Sub

    Public Function Insert(e As Premios) As Boolean Implements GenericContract(Of Premios).Insert
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@id_institucion", e.IdInstitucion)
        parameters.Add("@descripcion", e.Descripcion)
        parameters.Add("@fecha_certificacion", e.FechaCertificacion)
        Return ExecuteQuery(queryInsert)
    End Function

    Public Function Delete(id As Object) As Boolean Implements GenericContract(Of Premios).Delete
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", id)
        Return ExecuteQuery(queryDelete)
    End Function

    Public Function Update(e As Premios) As Boolean Implements GenericContract(Of Premios).Update
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@id_institucion", e.IdInstitucion)
        parameters.Add("@descripcion", e.Descripcion)
        parameters.Add("@fecha_certificacion", e.FechaCertificacion)
        Return ExecuteQuery(queryUpdate)
    End Function

    Public Function SelectAll() As List(Of Premios) Implements GenericContract(Of Premios).SelectAll
        Dim dataTable = ExecuteSelect(querySelect)
        Dim premios As New List(Of Premios)

        For Each row As DataRow In dataTable.Rows
            Dim idUsuario = row.Field(Of String)("id_usuario")
            Dim idInstitucion = row.Field(Of Integer)("id_institucion")
            Dim descripcion = row.Field(Of String)("descripcion")
            Dim fechaCertificacion = row.Field(Of DateTime)("fecha_certificacion")

            Dim premio As New Premios With {
                .IdUsuario = idUsuario,
                .IdInstitucion = idInstitucion,
                .Descripcion = descripcion,
                .FechaCertificacion = fechaCertificacion
            }

            premios.Add(premio)
        Next

        Return premios
    End Function
End Class
