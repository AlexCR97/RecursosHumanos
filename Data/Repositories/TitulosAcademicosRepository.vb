Imports Data
Imports Entities

Public Class TitulosAcademicosRepository
    Inherits MasterRepository(Of TitulosAcademicos)
    Implements IGenericContract(Of TitulosAcademicos)

    Public Sub New()
        queryInsert = "insert into titulos_academicos values (@id_usuario, @institucion, @grado, @titulo, @fecha_obtencion, @numero_cedula)"
        queryDelete = "delete from titulos_academicos where id_usuario = @id_usuario"
        queryDeleteSpecific = "delete from titulos_academicos where 
            id_usuario = @id_usuario and
            institucion = @institucion and
            grado = @grado and
            titulo = @titulo and
            fecha_de_obtencion = @fecha_obtencion and
            numero_de_cedula = @numero_cedula"
        queryUpdate = "update titulos_academicos set 
            id_usuario =@id_usuario,
            institucion = @institucion,
            grado = @grado,
            titulo = @titulo,
            fecha_de_obtencion = @fecha_obtencion,
            numero_de_cedula = @numero_cedula 
            where id_usuario = @id_usuario"
        querySelect = "select * from titulos_academicos"
        querySelectAllId = "select * from titulos_academicos where id_usuario = @id_usuario"
    End Sub

    Public Function Insert(e As TitulosAcademicos) As Boolean Implements IGenericContract(Of TitulosAcademicos).Insert
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@institucion", e.Institucion)
        parameters.Add("@grado", e.Grado)
        parameters.Add("@titulo", e.Titulo)
        parameters.Add("@fecha_obtencion", e.FechaObtencion)
        parameters.Add("@numero_cedula", e.NumeroCedula)
        Return ExecuteQuery(queryInsert)
    End Function

    Public Function Delete(id As Object) As Boolean Implements IGenericContract(Of TitulosAcademicos).Delete
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", id)
        Return ExecuteQuery(queryDelete)
    End Function

    Public Function Update(e As TitulosAcademicos) As Boolean Implements IGenericContract(Of TitulosAcademicos).Update
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@institucion", e.Institucion)
        parameters.Add("@grado", e.Grado)
        parameters.Add("@titulo", e.Titulo)
        parameters.Add("@fecha_obtencion", e.FechaObtencion)
        parameters.Add("@numero_cedula", e.NumeroCedula)
        Return ExecuteQuery(queryUpdate)
    End Function

    Public Function SelectAll() As List(Of TitulosAcademicos) Implements IGenericContract(Of TitulosAcademicos).SelectAll
        parameters = New Dictionary(Of String, Object)

        Dim dataTable = ExecuteSelect(querySelect)
        Dim titulosAcademicos As New List(Of TitulosAcademicos)

        For Each row As DataRow In dataTable.Rows
            Dim idUsuario = row.Field(Of String)("id_usuario")
            Dim institucion = row.Field(Of String)("institucion")
            Dim grado = row.Field(Of String)("grado")
            Dim titulo = row.Field(Of String)("titulo")
            Dim fechaObtencion = row.Field(Of DateTime)("fecha_de_obtencion")
            Dim numeroCedula = row.Field(Of String)("numero_de_cedula")

            Dim i As New TitulosAcademicos With {
                .IdUsuario = idUsuario,
                .Institucion = institucion,
                .Grado = grado,
                .Titulo = titulo,
                .FechaObtencion = fechaObtencion,
                .NumeroCedula = numeroCedula
            }

            titulosAcademicos.Add(i)
        Next

        Return titulosAcademicos
    End Function

    Public Function SelectWithId(id As Object) As TitulosAcademicos Implements IGenericContract(Of TitulosAcademicos).SelectWithId
        Throw New NotImplementedException()
    End Function

    Public Function SelectAllWithId(id As Object) As List(Of TitulosAcademicos) Implements IGenericContract(Of TitulosAcademicos).SelectAllWithId
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", id)

        Dim dataTable = ExecuteSelect(querySelectAllId)
        Dim titulosAcademicos As New List(Of TitulosAcademicos)

        For Each row As DataRow In dataTable.Rows
            Dim idUsuario = row.Field(Of String)("id_usuario")
            Dim institucion = row.Field(Of String)("institucion")
            Dim grado = row.Field(Of String)("grado")
            Dim titulo = row.Field(Of String)("titulo")
            Dim fechaObtencion = row.Field(Of DateTime)("fecha_de_obtencion")
            Dim numeroCedula = row.Field(Of String)("numero_de_cedula")

            Dim i As New TitulosAcademicos With {
                .IdUsuario = idUsuario,
                .Institucion = institucion,
                .Grado = grado,
                .Titulo = titulo,
                .FechaObtencion = fechaObtencion,
                .NumeroCedula = numeroCedula
            }

            titulosAcademicos.Add(i)
        Next

        Return titulosAcademicos
    End Function

    Public Function DeleteSpecific(e As TitulosAcademicos) As Boolean Implements IGenericContract(Of TitulosAcademicos).DeleteSpecific
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@institucion", e.Institucion)
        parameters.Add("@grado", e.Grado)
        parameters.Add("@titulo", e.Titulo)
        parameters.Add("@fecha_obtencion", e.FechaObtencion)
        parameters.Add("@numero_cedula", e.NumeroCedula)
        Return ExecuteQuery(queryDeleteSpecific)
    End Function
End Class
