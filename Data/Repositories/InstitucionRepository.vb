Imports Data
Imports Entities

Public Class InstitucionRepository
    Inherits MasterRepository
    Implements GenericContract(Of Institucion)

    Public Sub New()
        queryInsert = "insert into instituciones values (@id_institucion, @nombre)"
        queryDelete = "delete from instituciones where id_institucion = @id_institucion"
        queryUpdate = "update instituciones set id_institucion = @id_institucion, nombre = @nombre where id_institucion = @id_institucion"
        querySelect = "select * from instituciones"
    End Sub

    Public Function Insert(e As Institucion) As Boolean Implements GenericContract(Of Institucion).Insert
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_institucion", e.IdInstitucion)
        parameters.Add("@nombre", e.Nombre)
        Return ExecuteQuery(queryInsert)
    End Function

    Public Function Delete(id As Object) As Boolean Implements GenericContract(Of Institucion).Delete
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_institucion", id)
        Return ExecuteQuery(queryDelete)
    End Function

    Public Function Update(e As Institucion) As Boolean Implements GenericContract(Of Institucion).Update
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_institucion", e.IdInstitucion)
        parameters.Add("@nombre", e.Nombre)
        Return ExecuteQuery(queryUpdate)
    End Function

    Public Function SelectAll() As List(Of Institucion) Implements GenericContract(Of Institucion).SelectAll
        Dim dataTable = ExecuteSelect(querySelect)
        Dim instituciones As New List(Of Institucion)

        For Each row As DataRow In dataTable.Rows
            Dim idInstitucion = row.Field(Of String)("id_institucion")
            Dim nombre = row.Field(Of String)("nombre")

            Dim institucion As New Institucion With {
                .IdInstitucion = idInstitucion,
                .Nombre = nombre
            }

            instituciones.Add(institucion)
        Next

        Return instituciones
    End Function

End Class
