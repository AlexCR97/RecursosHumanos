Imports Data
Imports Entities

Public Class TitulosAcademicosRepository
    Inherits MasterRepository(Of TitulosAcademicos)
    Implements IGenericContract(Of TitulosAcademicos)

    Public Sub New()
        queryInsert = "insert into titulos_academicos values (@id_usuario, @id_insitucion, @grado, @titulo, @fecha_obtencion, @numero_cedula)"
        queryDelete = "delete from titulos_academicos where id_usuario = @id_usuario"
        queryUpdate = "update titulos_academicos set 
            @id_usuario,
            @id_insitucion,
            @grado,
            @titulo,
            @fecha_obtencion,
            @numero_cedula 
            where id_usuario = @id_usuario"
        querySelect = "select * from titulos_academidos where id_usuario = @id_usuario"
    End Sub

    Public Function Insert(e As TitulosAcademicos) As Boolean Implements IGenericContract(Of TitulosAcademicos).Insert
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@id_institucion", e.IdInstitucion)
        parameters.Add("@grado", e.Grado)
        parameters.Add("@titulo", e.Titulo)
        parameters.Add("@fecha_obtencion", e.FechaObtencion)
        parameters.Add("@numer_cedula", e.NumeroCedula)
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
        parameters.Add("@id_institucion", e.IdInstitucion)
        parameters.Add("@grado", e.Grado)
        parameters.Add("@titulo", e.Titulo)
        parameters.Add("@fecha_obtencion", e.FechaObtencion)
        parameters.Add("@numer_cedula", e.NumeroCedula)
        Return ExecuteQuery(queryUpdate)
    End Function

    Public Function SelectAll() As List(Of TitulosAcademicos) Implements IGenericContract(Of TitulosAcademicos).SelectAll
        Dim dataTable = ExecuteSelect(querySelect)
        Dim titulosAcademicos As New List(Of TitulosAcademicos)

        For Each row As DataRow In dataTable.Rows
            Dim idUsuario = row.Field(Of String)("id_usuario")
            Dim idInstitucion = row.Field(Of Integer)("id_institucion")
            Dim grado = row.Field(Of String)("grado")
            Dim titulo = row.Field(Of String)("titulo")
            Dim fechaObtencion = row.Field(Of DateTime)("fecha_obtencion")
            Dim numeroCedula = row.Field(Of String)("numero_cedula")

            Dim i As New TitulosAcademicos With {
                .IdUsuario = idUsuario,
                .IdInstitucion = idInstitucion,
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
        Throw New NotImplementedException()
    End Function

    Public Function DeleteSpecific(e As TitulosAcademicos) As Boolean Implements IGenericContract(Of TitulosAcademicos).DeleteSpecific
        Throw New NotImplementedException()
    End Function
End Class
