Imports Data
Imports Entities

Public Class AdscripcionTecNMRepository
    Inherits MasterRepository(Of AdscripcionTecNM)
    Implements IGenericContract(Of AdscripcionTecNM)

    Public Sub New()
        queryInsert = "insert into adscripcion_tecnm values (@id_usuario, @plantel, @fecha_adscripcion, @vigente)"
        queryDelete = "delete from adscripcion_tecnm where id_usuario = @id_usuario"
        queryDeleteSpecific = "delete from adscripcion_tecnm where 
            id_usuario = @id_usuario and 
            plantel = @plantel and 
            fecha_de_adscripcion = @fecha_adscripcion and 
            vigente = @vigente"
        queryUpdate = "update adscripcion_tecnm set 
            id_usuario = @id_usuario, 
            plantel = @plantel, 
            fecha_de_adscripcion = @fecha_adscripcion, 
            vigente = @vigente 
            where id_usuario = @id_usuario"
        querySelect = "select * from adscripcion_tecnm"
        querySelectAllId = "select * from adscripcion_tecnm where id_usuario = @id_usuario"
    End Sub

    Public Function Insert(e As AdscripcionTecNM) As Boolean Implements IGenericContract(Of AdscripcionTecNM).Insert
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@plantel", e.Plantel)
        parameters.Add("@fecha_adscripcion", e.FechaAdscripcion)
        parameters.Add("@vigente", e.Vigente)
        Return ExecuteQuery(queryInsert)
    End Function

    Public Function Delete(id As Object) As Boolean Implements IGenericContract(Of AdscripcionTecNM).Delete
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", id)
        Return ExecuteQuery(queryDelete)
    End Function

    Public Function Update(e As AdscripcionTecNM) As Boolean Implements IGenericContract(Of AdscripcionTecNM).Update
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@plantel", e.Plantel)
        parameters.Add("@fecha_adscripcion", e.FechaAdscripcion)
        parameters.Add("@vigente", e.Vigente)
        Return ExecuteQuery(queryUpdate)
    End Function

    Public Function SelectAll() As List(Of AdscripcionTecNM) Implements IGenericContract(Of AdscripcionTecNM).SelectAll
        parameters = New Dictionary(Of String, Object)

        Dim dataTable = ExecuteSelect(querySelect)
        Dim adscripciones As New List(Of AdscripcionTecNM)

        For Each row As DataRow In dataTable.Rows
            Dim idUsuario = row.Field(Of String)("id_usuario")
            Dim plantel = row.Field(Of String)("plantel")
            Dim fechaAdscripcion = row.Field(Of DateTime)("fecha_de_adscripcion")
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

    Public Function SelectWithId(id As Object) As AdscripcionTecNM Implements IGenericContract(Of AdscripcionTecNM).SelectWithId
        Throw New NotImplementedException()
    End Function

    Public Function SelectAllWithId(id As Object) As List(Of AdscripcionTecNM) Implements IGenericContract(Of AdscripcionTecNM).SelectAllWithId
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", id)

        Dim dataTable = ExecuteSelect(querySelectAllId)
        Dim adscripciones As New List(Of AdscripcionTecNM)

        For Each row As DataRow In dataTable.Rows
            Dim idUsuario = row.Field(Of String)("id_usuario")
            Dim plantel = row.Field(Of String)("plantel")
            Dim fechaAdscripcion = row.Field(Of DateTime)("fecha_de_adscripcion")
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

    Public Function DeleteSpecific(e As AdscripcionTecNM) As Boolean Implements IGenericContract(Of AdscripcionTecNM).DeleteSpecific
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@plantel", e.Plantel)
        parameters.Add("@fecha_adscripcion", e.FechaAdscripcion)
        parameters.Add("@vigente", e.Vigente)
        Return ExecuteQuery(queryDeleteSpecific)
    End Function
End Class
