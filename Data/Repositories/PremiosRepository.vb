Imports Data
Imports Entities

Public Class PremiosRepository
    Inherits MasterRepository(Of Premios)
    Implements IGenericContract(Of Premios)

    Public Sub New()
        queryInsert = "insert into premios values (@id_usuario, @id_institucion, @descripcion, @fecha_certificacion)"
        queryDelete = "delete from premios where id_usuario = @id_usuario"
        queryDeleteSpecific = "delete from premios where 
            id_usuario = @id_usuario and 
            institucion = @id_institucion and 
            descripcion = @descripcion and 
            fecha_de_certificacion = @fecha_certificacion"
        queryUpdate = "update premios set 
            id_usuario = @id_usuario,
            institucion = @id_institucion,
            descripcion = @descripcion,
            fecha_de_certificacion = @fecha_certificacion 
            where id_usuario = @id_usuario"
        querySelect = "select * from premios"
        querySelectAllId = "select * from premios where id_usuario = @id_usuario"
    End Sub

    Public Function Insert(e As Premios) As Boolean Implements IGenericContract(Of Premios).Insert
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@id_institucion", e.Institucion)
        parameters.Add("@descripcion", e.Descripcion)
        parameters.Add("@fecha_certificacion", e.FechaCertificacion)
        Return ExecuteQuery(queryInsert)
    End Function

    Public Function Delete(id As Object) As Boolean Implements IGenericContract(Of Premios).Delete
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", id)
        Return ExecuteQuery(queryDelete)
    End Function

    Public Function Update(e As Premios) As Boolean Implements IGenericContract(Of Premios).Update
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@id_institucion", e.Institucion)
        parameters.Add("@descripcion", e.Descripcion)
        parameters.Add("@fecha_certificacion", e.FechaCertificacion)
        Return ExecuteQuery(queryUpdate)
    End Function

    Public Function SelectAll() As List(Of Premios) Implements IGenericContract(Of Premios).SelectAll
        parameters = New Dictionary(Of String, Object)

        Dim dataTable = ExecuteSelect(querySelect)
        Dim premios As New List(Of Premios)

        For Each row As DataRow In dataTable.Rows
            Dim idUsuario = row.Field(Of String)("id_usuario")
            Dim institucion = row.Field(Of String)("institucion")
            Dim descripcion = row.Field(Of String)("descripcion")
            Dim fechaCertificacion = row.Field(Of DateTime)("fecha_de_certificacion")

            Dim premio As New Premios With {
                .IdUsuario = idUsuario,
                .Institucion = institucion,
                .Descripcion = descripcion,
                .FechaCertificacion = fechaCertificacion
            }

            premios.Add(premio)
        Next

        Return premios
    End Function

    Public Function SelectWithId(id As Object) As Premios Implements IGenericContract(Of Premios).SelectWithId
        Throw New NotImplementedException()
    End Function

    Public Function SelectAllWithId(id As Object) As List(Of Premios) Implements IGenericContract(Of Premios).SelectAllWithId
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", id)

        Dim dataTable = ExecuteSelect(querySelectAllId)
        Dim premios As New List(Of Premios)

        For Each row As DataRow In dataTable.Rows
            Dim idUsuario = row.Field(Of String)("id_usuario")
            Dim institucion = row.Field(Of String)("institucion")
            Dim descripcion = row.Field(Of String)("descripcion")
            Dim fechaCertificacion = row.Field(Of DateTime)("fecha_de_certificacion")

            Dim premio As New Premios With {
                .IdUsuario = idUsuario,
                .Institucion = institucion,
                .Descripcion = descripcion,
                .FechaCertificacion = fechaCertificacion
            }

            premios.Add(premio)
        Next

        Return premios
    End Function

    Public Function DeleteSpecific(e As Premios) As Boolean Implements IGenericContract(Of Premios).DeleteSpecific
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@id_institucion", e.Institucion)
        parameters.Add("@descripcion", e.Descripcion)
        parameters.Add("@fecha_certificacion", e.FechaCertificacion)
        Return ExecuteQuery(queryDeleteSpecific)
    End Function
End Class
