﻿Imports Data
Imports Entities

Public Class CertificacionesRepository
    Inherits MasterRepository(Of Certificaciones)
    Implements IGenericContract(Of Certificaciones)

    Public Sub New()
        queryInsert = "insert into certificaciones values (@id_usuario, @id_institucion, @descripcion, @fecha_certificacion, @fecha_limite)"
        queryDelete = "delete from certificaciones where id_usuario = @id_usuario"
        queryDeleteSpecific = "delete from certificaciones where 
            id_usuario = @id_usuario and 
            institucion = @id_institucion and 
            descripcion = @descripcion and 
            fecha_de_certificacion = @fecha_certificacion and 
            fecha_limite = @fecha_limite"
        queryUpdate = "update certificaciones set 
            id_usuario = @id_usuario, 
            institucion = @id_institucion, 
            descripcion = @descripcion, 
            fecha_de_certificacion = @fecha_certificacion, 
            fecha_limite = @fecha_limite 
            where id_usuario = @id_usuario"
        querySelect = "select * from certificaciones"
        querySelectAllId = "select * from certificaciones where id_usuario = @id_usuario"
    End Sub

    Public Function Insert(e As Certificaciones) As Boolean Implements IGenericContract(Of Certificaciones).Insert
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@id_institucion", e.Institucion)
        parameters.Add("@descripcion", e.Descripcion)
        parameters.Add("@fecha_certificacion", e.FechaCertificacion)
        parameters.Add("@fecha_limite", e.FechaLimite)
        Return ExecuteQuery(queryInsert)
    End Function

    Public Function Delete(id As Object) As Boolean Implements IGenericContract(Of Certificaciones).Delete
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", id)
        Return ExecuteQuery(queryDelete)
    End Function

    Public Function Update(e As Certificaciones) As Boolean Implements IGenericContract(Of Certificaciones).Update
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@id_institucion", e.Institucion)
        parameters.Add("@descripcion", e.Descripcion)
        parameters.Add("@fecha_certificacion", e.FechaCertificacion)
        parameters.Add("@fecha_limite", e.FechaLimite)
        Return ExecuteQuery(queryUpdate)
    End Function

    Public Function SelectAll() As List(Of Certificaciones) Implements IGenericContract(Of Certificaciones).SelectAll
        parameters = New Dictionary(Of String, Object)

        Dim dataTable = ExecuteSelect(querySelect)
        Dim certificaciones As New List(Of Certificaciones)

        For Each row As DataRow In dataTable.Rows
            Dim idUsuario = row.Field(Of String)("id_usuario")
            Dim institucion = row.Field(Of String)("institucion")
            Dim descripcion = row.Field(Of String)("descripcion")
            Dim fechaCertificacion = row.Field(Of DateTime)("fecha_de_certificacion")
            Dim fechaLimite = row.Field(Of DateTime)("fecha_limite")

            Dim certificacion As New Certificaciones With {
                .IdUsuario = idUsuario,
                .Institucion = institucion,
                .Descripcion = descripcion,
                .FechaCertificacion = fechaCertificacion,
                .FechaLimite = fechaLimite
            }

            certificaciones.Add(certificacion)
        Next

        Return certificaciones
    End Function

    Public Function SelectWithId(id As Object) As Certificaciones Implements IGenericContract(Of Certificaciones).SelectWithId
        Throw New NotImplementedException()
    End Function

    Public Function SelectAllWithId(id As Object) As List(Of Certificaciones) Implements IGenericContract(Of Certificaciones).SelectAllWithId
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", id)

        Dim dataTable = ExecuteSelect(querySelectAllId)
        Dim certificaciones As New List(Of Certificaciones)

        For Each row As DataRow In dataTable.Rows
            Dim idUsuario = row.Field(Of String)("id_usuario")
            Dim institucion = row.Field(Of String)("institucion")
            Dim descripcion = row.Field(Of String)("descripcion")
            Dim fechaCertificacion = row.Field(Of DateTime)("fecha_de_certificacion")
            Dim fechaLimite = row.Field(Of DateTime)("fecha_limite")

            Dim certificacion As New Certificaciones With {
                .IdUsuario = idUsuario,
                .Institucion = institucion,
                .Descripcion = descripcion,
                .FechaCertificacion = fechaCertificacion,
                .FechaLimite = fechaLimite
            }

            certificaciones.Add(certificacion)
        Next

        Return certificaciones
    End Function

    Public Function DeleteSpecific(e As Certificaciones) As Boolean Implements IGenericContract(Of Certificaciones).DeleteSpecific
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@id_institucion", e.Institucion)
        parameters.Add("@descripcion", e.Descripcion)
        parameters.Add("@fecha_certificacion", e.FechaCertificacion)
        parameters.Add("@fecha_limite", e.FechaLimite)
        Return ExecuteQuery(queryDeleteSpecific)
    End Function
End Class
