Imports Data
Imports Entities

Public Class AdscripcionExternaRepository
    Inherits MasterRepository(Of AdscripcionExterna)
    Implements IGenericContract(Of AdscripcionExterna)

    Public Sub New()
        queryInsert = "insert into adscripcion_externa values (@id_usuario, @institucion, @puesto, @fecha_nombramiento, @vigente)"
        queryDelete = "delete from adscripcion_externa where id_usuario = @id_usuario"
        queryDeleteSpecific = "delete from adscripcion_externa where 
            id_usuario = @id_usuario and 
            institucion = @institucion and 
            puesto = @puesto and 
            fecha_de_nombramiento = @fecha_nombramiento and 
            vigente = @vigente"
        queryUpdate = "update adscripcion_externa set 
            id_usuario = @id_usuario, 
            institucion = @institucion, 
            puesto = @puesto, 
            fecha_de_nombramiento = @fecha_nombramiento, 
            vigente = @vigente 
            where id_usuario = @id_usuario"
        querySelect = "select * from adscripcion_externa"
        querySelectId = "select * from adscripcion_externa where id_usuario = @id_usuario"
        querySelectAllId = "select * from adscripcion_externa where id_usuario = @id_usuario"
    End Sub

    Public Function Insert(e As AdscripcionExterna) As Boolean Implements IGenericContract(Of AdscripcionExterna).Insert
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@institucion", e.Institucion)
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
        parameters.Add("@institucion", e.Institucion)
        parameters.Add("@puesto", e.Puesto)
        parameters.Add("@fecha_nombramiento", e.FechaNombramiento)
        parameters.Add("@vigente", e.Vigente)
        Return ExecuteQuery(queryUpdate)
    End Function

    Public Function SelectAll() As List(Of AdscripcionExterna) Implements IGenericContract(Of AdscripcionExterna).SelectAll
        parameters = New Dictionary(Of String, Object)

        Dim dataTable = ExecuteSelect(querySelect)
        Dim adscripciones As New List(Of AdscripcionExterna)

        For Each row As DataRow In dataTable.Rows
            Dim idUsuario = row.Field(Of String)("id_usuario")
            Dim institucion = row.Field(Of String)("institucion")
            Dim puesto = row.Field(Of String)("puesto")
            Dim fechaNombramiento = row.Field(Of DateTime)("fecha_de_nombramiento")
            Dim vigente = row.Field(Of Boolean)("vigente")

            Dim adscripcionExterna As New AdscripcionExterna With {
                .IdUsuario = idUsuario,
                .Institucion = institucion,
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
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", id)

        Dim dataTable = ExecuteSelect(querySelectAllId)
        Dim adscripciones As New List(Of AdscripcionExterna)

        For Each row As DataRow In dataTable.Rows
            Dim idUsuario = row.Field(Of String)("id_usuario")
            Dim institucion = row.Field(Of String)("institucion")
            Dim puesto = row.Field(Of String)("puesto")
            Dim fechaNombramiento = row.Field(Of DateTime)("fecha_de_nombramiento")
            Dim vigente = row.Field(Of Boolean)("vigente")

            Dim adscripcionExterna As New AdscripcionExterna With {
                .IdUsuario = idUsuario,
                .Institucion = institucion,
                .Puesto = puesto,
                .FechaNombramiento = fechaNombramiento,
                .Vigente = vigente
            }

            adscripciones.Add(adscripcionExterna)
        Next

        Return adscripciones
    End Function

    Public Function DeleteSpecific(e As AdscripcionExterna) As Boolean Implements IGenericContract(Of AdscripcionExterna).DeleteSpecific
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@institucion", e.Institucion)
        parameters.Add("@puesto", e.Puesto)
        parameters.Add("@fecha_nombramiento", e.FechaNombramiento)
        parameters.Add("@vigente", e.Vigente)
        Return ExecuteQuery(queryDeleteSpecific)
    End Function
End Class
