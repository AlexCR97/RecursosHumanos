Imports Data
Imports Entities

Public Class OtrosMediosDeContactoRepository
    Inherits MasterRepository(Of OtrosMediosDeContacto)
    Implements IGenericContract(Of OtrosMediosDeContacto)

    Public Sub New()
        queryInsert = "insert into otros_medios_de_contacto values (@id_usuario, @medio, @descripcion)"
        queryDelete = "delete from otros_medios_de_contacto where id_usuario = @id_usuario"
        queryDeleteSpecific = "delete from otros_medios_de_contacto where id_usuario = @id_usuario and medio = @medio and descripcion = @descripcion"
        queryUpdate = "update otros_medios_de_contacto set id_usuario = @id_usuario, medio = @medio, descripcion = @descripcion where id_usuario = @id_usuario"
        querySelect = "select * from otros_medios_de_contacto"
        querySelectAllId = "select * from otros_medios_de_contacto where id_usuario = @id_usuario"
    End Sub

    Public Function Insert(e As OtrosMediosDeContacto) As Boolean Implements IGenericContract(Of OtrosMediosDeContacto).Insert
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@medio", e.Medio)
        parameters.Add("@descripcion", e.Descripcion)
        Return ExecuteQuery(queryInsert)
    End Function

    Public Function Delete(id As Object) As Boolean Implements IGenericContract(Of OtrosMediosDeContacto).Delete
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", id)
        Return ExecuteQuery(queryDelete)
    End Function

    Public Function Update(e As OtrosMediosDeContacto) As Boolean Implements IGenericContract(Of OtrosMediosDeContacto).Update
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@medio", e.Medio)
        parameters.Add("@descripcion", e.Descripcion)
        Return ExecuteQuery(queryUpdate)
    End Function

    Public Function SelectAll() As List(Of OtrosMediosDeContacto) Implements IGenericContract(Of OtrosMediosDeContacto).SelectAll
        parameters = New Dictionary(Of String, Object)

        Dim dataTable = ExecuteSelect(querySelect)
        Dim otrosMediosDeContacto As New List(Of OtrosMediosDeContacto)

        For Each row As DataRow In dataTable.Rows
            Dim idUsuario = row.Field(Of String)("id_usuario")
            Dim medio = row.Field(Of String)("medio")
            Dim descripcion = row.Field(Of String)("descripcion")

            Dim i As New OtrosMediosDeContacto With {
                .IdUsuario = idUsuario,
                .Medio = medio,
                .Descripcion = descripcion
            }

            otrosMediosDeContacto.Add(i)
        Next

        Return otrosMediosDeContacto
    End Function

    Public Function SelectWithId(id As Object) As OtrosMediosDeContacto Implements IGenericContract(Of OtrosMediosDeContacto).SelectWithId
        Throw New NotImplementedException()
    End Function

    Public Function SelectAllWithId(id As Object) As List(Of OtrosMediosDeContacto) Implements IGenericContract(Of OtrosMediosDeContacto).SelectAllWithId
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", id)

        Dim dataTable = ExecuteSelect(querySelectAllId)
        Dim otrosMediosDeContacto As New List(Of OtrosMediosDeContacto)

        For Each row As DataRow In dataTable.Rows
            Dim idUsuario = row.Field(Of String)("id_usuario")
            Dim medio = row.Field(Of String)("medio")
            Dim descripcion = row.Field(Of String)("descripcion")

            Dim i As New OtrosMediosDeContacto With {
                .IdUsuario = idUsuario,
                .Medio = medio,
                .Descripcion = descripcion
            }

            otrosMediosDeContacto.Add(i)
        Next

        Return otrosMediosDeContacto
    End Function

    Public Function DeleteSpecific(e As OtrosMediosDeContacto) As Boolean Implements IGenericContract(Of OtrosMediosDeContacto).DeleteSpecific
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@medio", e.Medio)
        parameters.Add("@descripcion", e.Descripcion)
        Return ExecuteQuery(queryDeleteSpecific)
    End Function
End Class
