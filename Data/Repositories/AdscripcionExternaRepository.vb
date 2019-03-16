Imports Data
Imports Entities

Public Class AdscripcionExternaRepository
    Inherits MasterRepository(Of AdscripcionExterna)
    Implements IGenericContract(Of AdscripcionExterna)

    Public Sub New()
        queryInsert = "insert into adscripcion_externa values (@id_usuario, @id_institucion, @puesto, @fecha_nombramiento, @vigente)"
        queryDelete = "delete from adscripcion_externa where id_usuario = @id_usuario"
        queryUpdate = "update adscripcion_externa set 
            id_usuario = @id_usuario, 
            id_institucion = @id_institucion, 
            puesto = @puesto, 
            fecha_nombramiento = @fecha_nombramiento, 
            vigente = @vigente 
            where id_usuario = @id_usuario"
        querySelect = "select * from adscripcion_externa"
        querySelectId = "select * from adscripcion_externa where id_usuario = @id_usuario"
    End Sub

    Public Function Insert(e As AdscripcionExterna) As Boolean Implements IGenericContract(Of AdscripcionExterna).Insert
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@id_institucion", e.IdInstitucion)
        parameters.Add("@puesto", e.Puesto)
        parameters.Add("@fecha_nombramiento", e.FechaNombramiento)
        parameters.Add("@vigente", e.Vigente)
        Return ExecuteQuery(queryInsert)
    End Function

    Public Function Delete(id As Object) As Boolean Implements IGenericContract(Of AdscripcionExterna).Delete
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", id)
        Return ExecuteQuery(queryDelete)
    End Function

    Public Function Update(e As AdscripcionExterna) As Boolean Implements IGenericContract(Of AdscripcionExterna).Update
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@id_institucion", e.IdInstitucion)
        parameters.Add("@puesto", e.Puesto)
        parameters.Add("@fecha_nombramiento", e.FechaNombramiento)
        parameters.Add("@vigente", e.Vigente)
        Return ExecuteQuery(queryUpdate)
    End Function

    Public Function SelectAll() As List(Of AdscripcionExterna) Implements IGenericContract(Of AdscripcionExterna).SelectAll
        Dim dataTable = ExecuteSelect(querySelect)
        Dim adscripciones As New List(Of AdscripcionExterna)

        For Each row As DataRow In dataTable.Rows
            Dim idUsuario = row.Field(Of String)("id_usuario")
            Dim idInstitucion = row.Field(Of Integer)("id_institucion")
            Dim puesto = row.Field(Of String)("puesto")
            Dim fechaNombramiento = row.Field(Of DateTime)("fecha_nombramiento")
            Dim vigente = row.Field(Of Boolean)("vigente")

            Dim adscripcionExterna As New AdscripcionExterna With {
                .IdUsuario = idUsuario,
                .IdInstitucion = idInstitucion,
                .Puesto = puesto,
                .FechaNombramiento = fechaNombramiento,
                .Vigente = vigente
            }

            adscripciones.Add(adscripcionExterna)
        Next

        Return adscripciones
    End Function

    Public Function SelectWithId(id As Object) As AdscripcionExterna Implements IGenericContract(Of AdscripcionExterna).SelectWithId
        Throw New NotImplementedException()
    End Function

    Public Function SelectAllWithId(id As Object) As List(Of AdscripcionExterna) Implements IGenericContract(Of AdscripcionExterna).SelectAllWithId
        Throw New NotImplementedException()
    End Function

    Public Function DeleteSpecific(e As AdscripcionExterna) As Boolean Implements IGenericContract(Of AdscripcionExterna).DeleteSpecific
        Throw New NotImplementedException()
    End Function
End Class
