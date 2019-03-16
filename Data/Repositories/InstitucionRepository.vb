Imports Data
Imports Entities

Public Class InstitucionRepository
    Inherits MasterRepository(Of Institucion)
    Implements IGenericContract(Of Institucion)

    Public Sub New()
        queryInsert = "insert into instituciones values (@id_institucion, @nombre)"
        queryDelete = "delete from instituciones where id_institucion = @id_institucion"
        queryUpdate = "update instituciones set id_institucion = @id_institucion, nombre = @nombre where id_institucion = @id_institucion"
        querySelect = "select * from instituciones"
    End Sub

    Public Function Insert(e As Institucion) As Boolean Implements IGenericContract(Of Institucion).Insert
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_institucion", e.IdInstitucion)
        parameters.Add("@nombre", e.Nombre)
        Return ExecuteQuery(queryInsert)
    End Function

    Public Function Delete(id As Object) As Boolean Implements IGenericContract(Of Institucion).Delete
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_institucion", id)
        Return ExecuteQuery(queryDelete)
    End Function

    Public Function Update(e As Institucion) As Boolean Implements IGenericContract(Of Institucion).Update
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_institucion", e.IdInstitucion)
        parameters.Add("@nombre", e.Nombre)
        Return ExecuteQuery(queryUpdate)
    End Function

    Public Function SelectAll() As List(Of Institucion) Implements IGenericContract(Of Institucion).SelectAll
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

    Public Function SelectWithId(id As Object) As Institucion Implements IGenericContract(Of Institucion).SelectWithId
        Throw New NotImplementedException()
    End Function

    Public Function SelectAllWithId(id As Object) As List(Of Institucion) Implements IGenericContract(Of Institucion).SelectAllWithId
        Throw New NotImplementedException()
    End Function

    Public Function DeleteSpecific(e As Institucion) As Boolean Implements IGenericContract(Of Institucion).DeleteSpecific
        Throw New NotImplementedException()
    End Function
End Class
