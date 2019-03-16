Imports Data
Imports Entities

Public Class UsuarioRepository
    Inherits MasterRepository(Of Usuario)
    Implements IUsuarioContract(Of Usuario)

    Protected queryCheckExistance As String

    Public Sub New()
        queryInsert = "insert into usuarios values (@id_usuario, @contrasena, @imagen)"
        queryDelete = "delete from usuarios where id_usuario = @id_usuario"
        queryUpdate = "update usuarios set 
            id_usuario = @id_usuario, 
            contrasena = @contrasena, 
            imagen = @imagen 
            where id_usuario = @id_usuario"
        querySelect = "select * from usuarios"
        querySelectId = "select * from usuarios where id_usuario = @id_usuario"

        queryCheckExistance = "select * from usuarios where id_usuario = @id_usuario and contrasena = @contrasena"
    End Sub

    Public Function Insert(e As Usuario) As Boolean Implements IUsuarioContract(Of Usuario).Insert
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@contrasena", e.Contrasena)
        parameters.Add("@imagen", e.Imagen)
        Return ExecuteQuery(queryInsert)
    End Function

    Public Function Delete(id As Object) As Boolean Implements IUsuarioContract(Of Usuario).Delete
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", id)
        Return ExecuteQuery(queryDelete)
    End Function

    Public Function Update(e As Usuario) As Boolean Implements IUsuarioContract(Of Usuario).Update
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@contrasena", e.Contrasena)
        parameters.Add("@imagen", e.Imagen)
        Return ExecuteQuery(queryUpdate)
    End Function

    Public Function CheckExistance(e As Usuario) As Boolean Implements IUsuarioContract(Of Usuario).CheckExistance
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@contrasena", e.Contrasena)

        Dim dataTable = ExecuteSelect(queryCheckExistance)

        Return dataTable.Rows.Count <> 0
    End Function

    Public Function SelectAll() As List(Of Usuario) Implements IUsuarioContract(Of Usuario).SelectAll
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

    Public Function SelectWithId(id As Object) As Usuario Implements IGenericContract(Of Usuario).SelectWithId
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", id)

        Dim dataTable = ExecuteSelect(querySelectId)
        Dim usuario As Usuario

        For Each row As DataRow In dataTable.Rows
            Dim idUsuario = row.Field(Of String)("id_usuario")
            Dim contrasena = row.Field(Of String)("contrasena")
            Dim imagen = row.Field(Of String)("imagen")

            usuario = New Usuario With {
                .IdUsuario = idUsuario,
                .Contrasena = contrasena,
                .Imagen = imagen
            }
        Next

        Return usuario
    End Function

    Public Function SelectAllWithId(id As Object) As List(Of Usuario) Implements IGenericContract(Of Usuario).SelectAllWithId
        Throw New NotImplementedException()
    End Function

    Public Function DeleteSpecific(e As Usuario) As Boolean Implements IGenericContract(Of Usuario).DeleteSpecific
        Throw New NotImplementedException()
    End Function
End Class
