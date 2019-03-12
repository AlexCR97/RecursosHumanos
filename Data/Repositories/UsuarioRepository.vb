Imports Data
Imports Entities

Public Class UsuarioRepository
    Inherits MasterRepository
    Implements GenericContract(Of Usuario)

    Public Sub New()
        queryInsert = "insert into usuarios values (@id_usuario, @contrasena, @imagen)"
        queryDelete = "delete from usuarios where id_usuario = @id_usuario"
        queryUpdate = "update usuarios set 
            id_usuario = @id_usuario, 
            contrasena = @contrasena, 
            imagen = @imagen 
            where id_usuario = @id_usuario"
        querySelect = "select * from usuarios"
    End Sub

    Public Function Insert(e As Usuario) As Boolean Implements GenericContract(Of Usuario).Insert
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@contrasena", e.Contrasena)
        parameters.Add("@imagen", e.Imagen)
        Return ExecuteQuery(queryInsert)
    End Function

    Public Function Delete(id As Object) As Boolean Implements GenericContract(Of Usuario).Delete
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", id)
        Return ExecuteQuery(queryDelete)
    End Function

    Public Function Update(e As Usuario) As Boolean Implements GenericContract(Of Usuario).Update
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@contrasena", e.Contrasena)
        parameters.Add("@imagen", e.Imagen)
        Return ExecuteQuery(queryUpdate)
    End Function

    Public Function SelectAll() As List(Of Usuario) Implements GenericContract(Of Usuario).SelectAll
        Dim dataTable = ExecuteSelect(querySelect)
        Dim usuarios As New List(Of Usuario)

        For Each row As DataRow In dataTable.Rows
            Dim idUsuario = row.Field(Of String)("id_usuario")
            Dim contrasena = row.Field(Of String)("contrasena")
            Dim imagen = row.Field(Of String)("imagen")

            Dim usuario As New Usuario With {
                .IdUsuario = idUsuario,
                .Contrasena = contrasena,
                .Imagen = imagen
            }

            usuarios.Add(usuario)
        Next

        Return usuarios
    End Function

End Class
