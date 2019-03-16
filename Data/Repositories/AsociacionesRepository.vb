Imports Data
Imports Entities

Public Class AsociacionesRepository
    Inherits MasterRepository(Of Asociaciones)
    Implements IGenericContract(Of Asociaciones)

    Public Sub New()
        queryInsert = "insert into asociaciones values (@id_usuario, @organismo, @nombramiento, @anio_afiliacion, @inicio_vigencia, @fin_vigencia)"
        queryDelete = "delete from asociaciones where id_usuario = @id_usuario"
        queryUpdate = "update asociaciones set 
            id_usuario = @id_usuario, 
            organismo = @organismo, 
            nombramiento = @nombramiento, 
            anio_afiliacion = @anio_afiliacion, 
            inicio_vigencia = @inicio_vigencia, 
            fin_vigencia = @fin_vigencia 
            where id_usuario = @id_usuario"
        querySelect = "select * from asociaciones"
    End Sub

    Public Function Insert(e As Asociaciones) As Boolean Implements IGenericContract(Of Asociaciones).Insert
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@organismo", e.Organismo)
        parameters.Add("@nombramiento", e.Nombramiento)
        parameters.Add("@anio_afiliacion", e.AnioAfiliacion)
        parameters.Add("@inicio_vigencia", e.InicioVigencia)
        parameters.Add("@fin_vigencia", e.FinVigencia)
        Return ExecuteQuery(queryInsert)
    End Function

    Public Function Delete(id As Object) As Boolean Implements IGenericContract(Of Asociaciones).Delete
        parameters.Add("@id_usuario", id)
        Return ExecuteQuery(queryDelete)
    End Function

    Public Function Update(e As Asociaciones) As Boolean Implements IGenericContract(Of Asociaciones).Update
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@organismo", e.Organismo)
        parameters.Add("@nombramiento", e.Nombramiento)
        parameters.Add("@anio_afiliacion", e.AnioAfiliacion)
        parameters.Add("@inicio_vigencia", e.InicioVigencia)
        parameters.Add("@fin_vigencia", e.FinVigencia)
        Return ExecuteQuery(queryUpdate)
    End Function

    Public Function SelectAll() As List(Of Asociaciones) Implements IGenericContract(Of Asociaciones).SelectAll
        Dim dataTable = ExecuteSelect(querySelect)
        Dim asociaciones As New List(Of Asociaciones)

        For Each row As DataRow In dataTable.Rows
            Dim idUsuario = row.Field(Of String)("id_usuario")
            Dim organismo = row.Field(Of String)("organismo")
            Dim nombramiento = row.Field(Of String)("nombramiento")
            Dim anioAfiliacion = row.Field(Of DateTime)("anio_afiliacion")
            Dim inicioVigencia = row.Field(Of DateTime)("inicio_vigencia")
            Dim finVigencia = row.Field(Of DateTime)("fin_vigencia")

            Dim asociacion As New Asociaciones With {
                .IdUsuario = idUsuario,
                .Organismo = organismo,
                .Nombramiento = nombramiento,
                .AnioAfiliacion = anioAfiliacion,
                .InicioVigencia = inicioVigencia,
                .FinVigencia = finVigencia
            }

            asociaciones.Add(asociacion)
        Next

        Return asociaciones
    End Function

    Public Function SelectWithId(id As Object) As Asociaciones Implements IGenericContract(Of Asociaciones).SelectWithId
        Throw New NotImplementedException()
    End Function

    Public Function SelectAllWithId(id As Object) As List(Of Asociaciones) Implements IGenericContract(Of Asociaciones).SelectAllWithId
        Throw New NotImplementedException()
    End Function

    Public Function DeleteSpecific(e As Asociaciones) As Boolean Implements IGenericContract(Of Asociaciones).DeleteSpecific
        Throw New NotImplementedException()
    End Function
End Class
