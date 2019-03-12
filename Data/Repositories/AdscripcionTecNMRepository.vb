Imports Data
Imports Entities

Public Class AdscripcionTecNMRepository
    Inherits MasterRepository
    Implements GenericContract(Of AdscripcionTecNM)

    Public Sub New()
        queryInsert = "insert into adscripcion_tecnm values (@id_usuario, @plantel, @fecha_adscripcion, @vigente)"
        queryDelete = "delete from adscripcion_tecnm where id_usuario = @id_usuario"
        queryUpdate = "update adscripcion_tecnm set 
            id_usuario = @id_usuario, 
            plantel = @plantel, 
            fecha_adscripcion = @fecha_adscripcion, 
            vigente = @vigente 
            where id_usuario = @id_usuario"
        querySelect = "select * from adscripcion_tecnm"
    End Sub

    Public Function Insert(e As AdscripcionTecNM) As Boolean Implements GenericContract(Of AdscripcionTecNM).Insert
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@plantel", e.Plantel)
        parameters.Add("@fecha_adscripcion", e.FechaAdscripcion)
        parameters.Add("@vigente", e.Vigente)
        Return ExecuteQuery(queryInsert)
    End Function

    Public Function Delete(id As Object) As Boolean Implements GenericContract(Of AdscripcionTecNM).Delete
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", id)
        Return ExecuteQuery(queryDelete)
    End Function

    Public Function Update(e As AdscripcionTecNM) As Boolean Implements GenericContract(Of AdscripcionTecNM).Update
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@plantel", e.Plantel)
        parameters.Add("@fecha_adscripcion", e.FechaAdscripcion)
        parameters.Add("@vigente", e.Vigente)
        Return ExecuteQuery(queryUpdate)
    End Function

    Public Function SelectAll() As List(Of AdscripcionTecNM) Implements GenericContract(Of AdscripcionTecNM).SelectAll
        Dim dataTable = ExecuteSelect(querySelect)
        Dim adscripciones As New List(Of AdscripcionTecNM)

        For Each row As DataRow In dataTable.Rows
            Dim idUsuario = row.Field(Of String)("id_usuario")
            Dim plantel = row.Field(Of String)("plantel")
            Dim fechaAdscripcion = row.Field(Of DateTime)("fecha_adscripcion")
            Dim vigente = row.Field(Of Boolean)("vigente")

            Dim adscripcion As New AdscripcionTecNM With {
                .IdUsuario = idUsuario,
                .Plantel = plantel,
                .FechaAdscripcion = fechaAdscripcion,
                .Vigente = vigente
            }

            adscripciones.Add(adscripcion)
        Next

        Return adscripciones
    End Function
End Class
