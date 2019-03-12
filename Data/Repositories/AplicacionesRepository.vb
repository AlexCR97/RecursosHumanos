Imports Data
Imports Entities

Public Class AplicacionesRepository
    Inherits MasterRepository
    Implements GenericContract(Of Aplicaciones)

    Public Sub New()
        queryInsert = "insert into aplicaciones values (@id_usuario, @titulo, @direccion_web, @descripcion)"
        queryDelete = "delete from aplicaciones where id_usuario = @id_usuario"
        queryUpdate = "update aplicaciones set 
            id_usuario = @id_usuario, 
            titulo = @titulo, 
            direccion_web = @direccion_web, 
            descripcion = @descripcion 
            where id_usuario = @id_usuario"
        querySelect = "select * from aplicaciones"
    End Sub

    Public Function Insert(e As Aplicaciones) As Boolean Implements GenericContract(Of Aplicaciones).Insert
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@titulo", e.Titulo)
        parameters.Add("@direccion_web", e.DireccionWeb)
        parameters.Add("@descripcion", e.Descripcion)
        Return ExecuteQuery(queryInsert)
    End Function

    Private Function Delete(id As Object) As Boolean Implements GenericContract(Of Aplicaciones).Delete
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", id)
        Return ExecuteQuery(queryDelete)
    End Function

    Public Function Update(e As Aplicaciones) As Boolean Implements GenericContract(Of Aplicaciones).Update
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@titulo", e.Titulo)
        parameters.Add("@direccion_web", e.DireccionWeb)
        parameters.Add("@descripcion", e.Descripcion)
        Return ExecuteQuery(queryUpdate)
    End Function

    Private Function SelectAll() As List(Of Aplicaciones) Implements GenericContract(Of Aplicaciones).SelectAll
        Dim dataTable = ExecuteSelect(querySelect)
        Dim aplicaciones As New List(Of Aplicaciones)

        For Each row As DataRow In dataTable.Rows
            Dim idUsuario = row.Field(Of String)("id_usuario")
            Dim titulo = row.Field(Of String)("titulo")
            Dim direccionWeb = row.Field(Of String)("direccion_web")
            Dim descripcion = row.Field(Of String)("descripcion")

            Dim aplicacion As New Aplicaciones With {
                .IdUsuario = idUsuario,
                .Titulo = titulo,
                .DireccionWeb = direccionWeb,
                .Descripcion = descripcion
            }

            aplicaciones.Add(aplicacion)
        Next

        Return aplicaciones
    End Function
End Class
