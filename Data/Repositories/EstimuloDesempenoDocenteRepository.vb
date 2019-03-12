Imports Data
Imports Entities

Public Class EstimuloDesempenoDocenteRepository
    Inherits MasterRepository
    Implements GenericContract(Of EstimuloDesempenoDocente)

    Public Sub New()
        queryInsert = "insert into estimulo_desempeno_docente values (@id_usuario, @anio, @nivel)"
        queryDelete = "delete from estimulo_desempeno_docente where id_usuario = @id_usuario"
        queryUpdate = "update estimulo_desempeno_docente set 
            id_usuario = @id_usuario, 
            anio = @anio, 
            nivel = @nivel
            where id_usuario = @id_usuario"
        querySelect = "select * from estimulo_desempeno_docente"
    End Sub

    Public Function Insert(e As EstimuloDesempenoDocente) As Boolean Implements GenericContract(Of EstimuloDesempenoDocente).Insert
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@anio", e.Anio)
        parameters.Add("@nivel", e.Nivel)
        Return ExecuteQuery(queryInsert)
    End Function

    Public Function Delete(id As Object) As Boolean Implements GenericContract(Of EstimuloDesempenoDocente).Delete
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", id)
        Return ExecuteQuery(queryDelete)
    End Function

    Public Function Update(e As EstimuloDesempenoDocente) As Boolean Implements GenericContract(Of EstimuloDesempenoDocente).Update
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@anio", e.Anio)
        parameters.Add("@nivel", e.Nivel)
        Return ExecuteQuery(queryUpdate)
    End Function

    Public Function SelectAll() As List(Of EstimuloDesempenoDocente) Implements GenericContract(Of EstimuloDesempenoDocente).SelectAll
        Dim dataTable = ExecuteSelect(querySelect)
        Dim estimuloDesempenoDocente As New List(Of EstimuloDesempenoDocente)

        For Each row As DataRow In dataTable.Rows
            Dim idUsuario = row.Field(Of String)("id_usuario")
            Dim anio = row.Field(Of DateTime)("anio")
            Dim nivel = row.Field(Of Integer)("nivel")

            Dim i As New EstimuloDesempenoDocente With {
                .IdUsuario = idUsuario,
                .Anio = anio,
                .Nivel = nivel
            }

            estimuloDesempenoDocente.Add(i)
        Next

        Return estimuloDesempenoDocente
    End Function
End Class
