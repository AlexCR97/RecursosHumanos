Imports Data
Imports Entities

Public Class AplicacionRepository
    Inherits MasterRepository(Of Aplicacion)
    Implements IGenericContract(Of Aplicacion)

    Public Sub New()
        querySelectId = "select * from aplicacion"
        queryUpdate = "update aplicacion set 
            imagen = @imagen, 
            color_r = @color_r, 
            color_g = @color_g, 
            color_b = @color_b, 
            color_a = @color_a"
    End Sub

    Public Function Insert(e As Aplicacion) As Boolean Implements IGenericContract(Of Aplicacion).Insert
        Throw New NotImplementedException()
    End Function

    Public Function Delete(id As Object) As Boolean Implements IGenericContract(Of Aplicacion).Delete
        Throw New NotImplementedException()
    End Function

    Public Function DeleteSpecific(e As Aplicacion) As Boolean Implements IGenericContract(Of Aplicacion).DeleteSpecific
        Throw New NotImplementedException()
    End Function

    Public Function Update(e As Aplicacion) As Boolean Implements IGenericContract(Of Aplicacion).Update
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@imagen", e.Imagen)
        parameters.Add("@color_r", e.ColorR)
        parameters.Add("@color_g", e.ColorG)
        parameters.Add("@color_b", e.ColorB)
        parameters.Add("@color_a", e.ColorA)
        Return ExecuteQuery(queryUpdate)
    End Function

    Public Function SelectAll() As List(Of Aplicacion) Implements IGenericContract(Of Aplicacion).SelectAll
        Throw New NotImplementedException()
    End Function

    Public Function SelectWithId(id As Object) As Aplicacion Implements IGenericContract(Of Aplicacion).SelectWithId
        parameters = New Dictionary(Of String, Object)

        Dim dataTable = ExecuteSelect(querySelectId)
        Dim aplicacion As Aplicacion = Nothing

        For Each row As DataRow In dataTable.Rows
            Dim imagen = row.Field(Of String)("imagen")
            Dim color_r = row.Field(Of Integer)("color_r")
            Dim color_g = row.Field(Of Integer)("color_g")
            Dim color_b = row.Field(Of Integer)("color_b")
            Dim color_a = row.Field(Of Integer)("color_a")

            aplicacion = New Aplicacion With {
                .Imagen = imagen,
                .ColorR = color_r,
                .ColorG = color_g,
                .ColorB = color_b,
                .ColorA = color_a
            }
        Next

        Return aplicacion
    End Function

    Public Function SelectAllWithId(id As Object) As List(Of Aplicacion) Implements IGenericContract(Of Aplicacion).SelectAllWithId
        Throw New NotImplementedException()
    End Function
End Class
