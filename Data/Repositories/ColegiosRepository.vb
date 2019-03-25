Imports Data
Imports Entities

Public Class ColegiosRepository
    Inherits MasterRepository(Of Colegios)
    Implements IGenericContract(Of Colegios)

    Public Sub New()
        queryInsert = "insert into colegios values (@id_usuario, @nombramiento, @colegio, @afiliacion)"
        queryDelete = "delete from colegios where id_usuario = @id_usuario"
        queryDeleteSpecific = "delete from colegios where 
            id_usuario = @id_usuario and 
            nombramiento = @nombramiento and 
            colegio = @colegio and 
            afiliacion = @afiliacion"
        queryUpdate = "update colegios set 
            id_usuario = @id_usuario, 
            nombramiento = @nombramiento, 
            colegio = @colegio, 
            afiliacion = @afiliacion 
            where id_usuario = @id_usuario"
        querySelect = "select * from colegios"
        querySelectAllId = "select * from colegios where id_usuario = @id_usuario"
    End Sub

    Public Function Insert(e As Colegios) As Boolean Implements IGenericContract(Of Colegios).Insert
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@nombramiento", e.Nombramiento)
        parameters.Add("@colegio", e.Colegio)
        parameters.Add("@afiliacion", e.Afiliacion)
        Return ExecuteQuery(queryInsert)
    End Function

    Public Function Delete(id As Object) As Boolean Implements IGenericContract(Of Colegios).Delete
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", id)
        Return ExecuteQuery(queryDelete)
    End Function

    Public Function Update(e As Colegios) As Boolean Implements IGenericContract(Of Colegios).Update
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@nombramiento", e.Nombramiento)
        parameters.Add("@colegio", e.Colegio)
        parameters.Add("@afiliacion", e.Afiliacion)
        Return ExecuteQuery(queryUpdate)
    End Function

    Public Function SelectAll() As List(Of Colegios) Implements IGenericContract(Of Colegios).SelectAll
        parameters = New Dictionary(Of String, Object)

        Dim dataTable = ExecuteSelect(querySelect)
        Dim colegios As New List(Of Colegios)

        For Each row As DataRow In dataTable.Rows
            Dim idUsuario = row.Field(Of String)("id_usuario")
            Dim nombramiento = row.Field(Of String)("nombramiento")
            Dim colegio = row.Field(Of String)("colegio")
            Dim afiliacion = row.Field(Of String)("afiliacion")

            Dim c As New Colegios With {
                .IdUsuario = idUsuario,
                .Nombramiento = nombramiento,
                .Colegio = colegio,
                .Afiliacion = afiliacion
            }

            colegios.Add(c)
        Next

        Return colegios
    End Function

    Public Function SelectWithId(id As Object) As Colegios Implements IGenericContract(Of Colegios).SelectWithId
        Throw New NotImplementedException()
    End Function

    Public Function SelectAllWithId(id As Object) As List(Of Colegios) Implements IGenericContract(Of Colegios).SelectAllWithId
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", id)

        Dim dataTable = ExecuteSelect(querySelect)
        Dim colegios As New List(Of Colegios)

        For Each row As DataRow In dataTable.Rows
            Dim idUsuario = row.Field(Of String)("id_usuario")
            Dim nombramiento = row.Field(Of String)("nombramiento")
            Dim colegio = row.Field(Of String)("colegio")
            Dim afiliacion = row.Field(Of String)("afiliacion")

            Dim c As New Colegios With {
                .IdUsuario = idUsuario,
                .Nombramiento = nombramiento,
                .Colegio = colegio,
                .Afiliacion = afiliacion
            }

            colegios.Add(c)
        Next

        Return colegios
    End Function

    Public Function DeleteSpecific(e As Colegios) As Boolean Implements IGenericContract(Of Colegios).DeleteSpecific
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@nombramiento", e.Nombramiento)
        parameters.Add("@colegio", e.Colegio)
        parameters.Add("@afiliacion", e.Afiliacion)
        Return ExecuteQuery(queryDeleteSpecific)
    End Function
End Class
