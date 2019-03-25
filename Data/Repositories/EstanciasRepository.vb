Imports Data
Imports Entities

Public Class EstanciasRepository
    Inherits MasterRepository(Of Estancias)
    Implements IGenericContract(Of Estancias)

    Public Sub New()
        queryInsert = "insert into estancias values (@id_usuario, @id_institucion, @nombre_proyecto, @fecha_inicio, @fecha_termino)"
        queryDelete = "delete from estancias where id_usuario = @id_usuario"
        queryDeleteSpecific = "delete from estancias where 
            id_usuario = @id_usuario and 
            institucion = @id_institucion and 
            nombre_del_proyecto = @nombre_proyecto and 
            fecha_de_inicio = @fecha_inicio and 
            fecha_de_termino = @fecha_termino"
        queryUpdate = "update estancias set 
            id_usuario = @id_usuario, 
            institucion = @id_institucion, 
            nombre_proyecto = @nombre_proyecto, 
            fecha_de_inicio = @fecha_inicio, 
            fecha_de_termino = @fecha_termino"
        querySelect = "select * from estancias"
        querySelectAllId = "select * from estancias where id_usuario = @id_usuario"
    End Sub

    Public Function Insert(e As Estancias) As Boolean Implements IGenericContract(Of Estancias).Insert
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@id_institucion", e.Institucion)
        parameters.Add("@nombre_proyecto", e.NombreProyecto)
        parameters.Add("@fecha_inicio", e.FechaInicio)
        parameters.Add("@fecha_termino", e.FechaTermino)
        Return ExecuteQuery(queryInsert)
    End Function

    Public Function Delete(id As Object) As Boolean Implements IGenericContract(Of Estancias).Delete
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", id)
        Return ExecuteQuery(queryDelete)
    End Function

    Public Function Update(e As Estancias) As Boolean Implements IGenericContract(Of Estancias).Update
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@id_institucion", e.Institucion)
        parameters.Add("@nombre_proyecto", e.NombreProyecto)
        parameters.Add("@fecha_inicio", e.FechaInicio)
        parameters.Add("@fecha_termino", e.FechaTermino)
        Return ExecuteQuery(queryUpdate)
    End Function

    Public Function SelectAll() As List(Of Estancias) Implements IGenericContract(Of Estancias).SelectAll
        parameters = New Dictionary(Of String, Object)

        Dim dataTable = ExecuteSelect(querySelect)
        Dim estancias As New List(Of Estancias)

        For Each row As DataRow In dataTable.Rows
            Dim idUsuario = row.Field(Of String)("id_usuario")
            Dim institucion = row.Field(Of String)("institucion")
            Dim nombreProyecto = row.Field(Of String)("nombre_del_proyecto")
            Dim fechaInicio = row.Field(Of DateTime)("fecha_de_inicio")
            Dim fechaTermino = row.Field(Of DateTime)("fecha_de_termino")

            Dim estancia As New Estancias With {
                .IdUsuario = idUsuario,
                .Institucion = institucion,
                .NombreProyecto = nombreProyecto,
                .FechaInicio = fechaInicio,
                .FechaTermino = fechaTermino
            }

            estancias.Add(estancia)
        Next

        Return estancias
    End Function

    Public Function SelectWithId(id As Object) As Estancias Implements IGenericContract(Of Estancias).SelectWithId
        Throw New NotImplementedException()
    End Function

    Public Function SelectAllWithId(id As Object) As List(Of Estancias) Implements IGenericContract(Of Estancias).SelectAllWithId
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", id)

        Dim dataTable = ExecuteSelect(querySelectAllId)
        Dim estancias As New List(Of Estancias)

        For Each row As DataRow In dataTable.Rows
            Dim idUsuario = row.Field(Of String)("id_usuario")
            Dim institucion = row.Field(Of String)("institucion")
            Dim nombreProyecto = row.Field(Of String)("nombre_del_proyecto")
            Dim fechaInicio = row.Field(Of DateTime)("fecha_de_inicio")
            Dim fechaTermino = row.Field(Of DateTime)("fecha_de_termino")

            Dim estancia As New Estancias With {
                .IdUsuario = idUsuario,
                .Institucion = institucion,
                .NombreProyecto = nombreProyecto,
                .FechaInicio = fechaInicio,
                .FechaTermino = fechaTermino
            }

            estancias.Add(estancia)
        Next

        Return estancias
    End Function

    Public Function DeleteSpecific(e As Estancias) As Boolean Implements IGenericContract(Of Estancias).DeleteSpecific
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@id_institucion", e.Institucion)
        parameters.Add("@nombre_proyecto", e.NombreProyecto)
        parameters.Add("@fecha_inicio", e.FechaInicio)
        parameters.Add("@fecha_termino", e.FechaTermino)
        Return ExecuteQuery(queryDeleteSpecific)
    End Function
End Class
