Imports Data
Imports Entities

Public Class ColegiosRepository
    Inherits MasterRepository
    Implements GenericContract(Of Colegios)

    Public Sub New()
        queryInsert = "insert into colegios values (@id_usuario, @nombramiento, @colegio, @afiliacion)"
        queryDelete = "delete from colegios where id_usuario = @id_usuario"
        queryUpdate = "update colegios set 
            id_usuario = @id_usuario, 
            nombramiento = @nombramiento, 
            colegio = @colegio, 
            afiliacion = @afiliacion 
            where id_usuario = @id_usuario"
        querySelect = "select * from colegios"
    End Sub

    Public Function Insert(e As Colegios) As Boolean Implements GenericContract(Of Colegios).Insert
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@nombramiento", e.Nombramiento)
        parameters.Add("@colegio", e.Colegio)
        parameters.Add("@afiliacion", e.Afiliacion)
        Return ExecuteQuery(queryInsert)
    End Function

    Public Function Delete(id As Object) As Boolean Implements GenericContract(Of Colegios).Delete
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", id)
        Return ExecuteQuery(queryDelete)
    End Function

    Public Function Update(e As Colegios) As Boolean Implements GenericContract(Of Colegios).Update
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@nombramiento", e.Nombramiento)
        parameters.Add("@colegio", e.Colegio)
        parameters.Add("@afiliacion", e.Afiliacion)
        Return ExecuteQuery(queryUpdate)
    End Function

    Public Function SelectAll() As List(Of Colegios) Implements GenericContract(Of Colegios).SelectAll
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
End Class
