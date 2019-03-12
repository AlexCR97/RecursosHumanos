Imports Data
Imports Entities

Public Class OtrosMediosDeContactoRepository
    Inherits MasterRepository
    Implements GenericContract(Of OtrosMediosDeContacto)

    Public Sub New()
        queryInsert = "insert into otros_medios_de_contacto values (@id_usuario, @medio, @descripcion)"
        queryDelete = "delete from otros_medios_de_contacto where id_usuario = @id_usuario"
        queryUpdate = "update otros_medios_de_contacto set id_usuario = @id_usuario, medio = @medio, descripcion = @descripcion where id_usuario = @id_usuario"
        querySelect = "select * from otros_medios_de_contacto"
    End Sub

    Public Function Insert(e As OtrosMediosDeContacto) As Boolean Implements GenericContract(Of OtrosMediosDeContacto).Insert
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@medio", e.Medio)
        parameters.Add("@descripcion", e.Descripcion)
        Return ExecuteQuery(queryInsert)
    End Function

    Public Function Delete(id As Object) As Boolean Implements GenericContract(Of OtrosMediosDeContacto).Delete
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", id)
        Return ExecuteQuery(queryDelete)
    End Function

    Public Function Update(e As OtrosMediosDeContacto) As Boolean Implements GenericContract(Of OtrosMediosDeContacto).Update
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@medio", e.Medio)
        parameters.Add("@descripcion", e.Descripcion)
        Return ExecuteQuery(queryUpdate)
    End Function

    Public Function SelectAll() As List(Of OtrosMediosDeContacto) Implements GenericContract(Of OtrosMediosDeContacto).SelectAll
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
End Class
