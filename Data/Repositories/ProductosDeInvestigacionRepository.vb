Imports Data
Imports Entities

Public Class ProductosDeInvestigacionRepository
    Inherits MasterRepository(Of ProductosDeInvestigacion)
    Implements IGenericContract(Of ProductosDeInvestigacion)

    Public Sub New()
        queryInsert = "insert into productos_de_investigacion values (@id_usuario, @titulo, @proposito, @fecha_publicacion, @tipo_producto)"
        queryDelete = "delete from productos_de_investigacion where id_usuario = @id_usuario"
        queryUpdate = "update productos_de_investigacion set 
            id_usuario = @id_usuario,
            titulo = @titulo,
            proposito = @proposito,
            fecha_publicacion = @fecha_publicacion,
            tipo_producto = @tipo_producto
            where id_usuario = @id_usuario"
        querySelect = "select * from productos_de_investigacion"
    End Sub

    Public Function Insert(e As ProductosDeInvestigacion) As Boolean Implements IGenericContract(Of ProductosDeInvestigacion).Insert
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@titulo", e.Titulo)
        parameters.Add("@proposito", e.Proposito)
        parameters.Add("@fecha_publicacion", e.FechaPublicacion)
        parameters.Add("@tipo_producto", e.TipoProducto)
        Return ExecuteQuery(queryInsert)
    End Function

    Public Function Delete(id As Object) As Boolean Implements IGenericContract(Of ProductosDeInvestigacion).Delete
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", id)
        Return ExecuteQuery(queryDelete)
    End Function

    Public Function Update(e As ProductosDeInvestigacion) As Boolean Implements IGenericContract(Of ProductosDeInvestigacion).Update
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@titulo", e.Titulo)
        parameters.Add("@proposito", e.Proposito)
        parameters.Add("@fecha_publicacion", e.FechaPublicacion)
        parameters.Add("@tipo_producto", e.TipoProducto)
        Return ExecuteQuery(queryUpdate)
    End Function

    Public Function SelectAll() As List(Of ProductosDeInvestigacion) Implements IGenericContract(Of ProductosDeInvestigacion).SelectAll
        Dim dataTable = ExecuteSelect(querySelect)
        Dim productosDeInvestigacion As New List(Of ProductosDeInvestigacion)

        For Each row As DataRow In dataTable.Rows
            Dim idUsuario = row.Field(Of String)("id_usuario")
            Dim titulo = row.Field(Of String)("titulo")
            Dim proposito = row.Field(Of String)("proposito")
            Dim fechaPublicacion = row.Field(Of DateTime)("fecha_publicacion")
            Dim tipoProducto = row.Field(Of String)("tipo_producto")

            Dim i As New ProductosDeInvestigacion With {
                .IdUsuario = idUsuario,
                .Titulo = titulo,
                .Proposito = proposito,
                .FechaPublicacion = fechaPublicacion,
                .TipoProducto = tipoProducto
            }

            productosDeInvestigacion.Add(i)
        Next

        Return productosDeInvestigacion
    End Function

    Public Function SelectWithId(id As Object) As ProductosDeInvestigacion Implements IGenericContract(Of ProductosDeInvestigacion).SelectWithId
        Throw New NotImplementedException()
    End Function

    Public Function SelectAllWithId(id As Object) As List(Of ProductosDeInvestigacion) Implements IGenericContract(Of ProductosDeInvestigacion).SelectAllWithId
        Throw New NotImplementedException()
    End Function

    Public Function DeleteSpecific(e As ProductosDeInvestigacion) As Boolean Implements IGenericContract(Of ProductosDeInvestigacion).DeleteSpecific
        Throw New NotImplementedException()
    End Function
End Class
