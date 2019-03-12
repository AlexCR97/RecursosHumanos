Imports Data
Imports Entities

Public Class DatosPersonalesRepository
    Inherits MasterRepository
    Implements GenericContract(Of DatosPersonales)

    Public Sub New()
        queryInsert = "insert into datos_personales values (
            @id_usuario,
            @nombre,
            @apellido_paterno, 
            @apellido_materno, 
            @sexo, 
            @pais_nacimiento, 
            @fecha_nacimiento, 
            @curp, 
            @rfc, 
            @cvu, 
            @biografia)"
        queryDelete = "delete from datos_personales where id_usuario = @id_usuario"
        queryUpdate = "update datos_personales set 
            id_usuario = @id_usuario,
            nombre = @nombre,
            apellido_paterno = @apellido_paterno, 
            apellido_materno = @apellido_materno, 
            sexo = @sexo, 
            pais_nacimiento = @pais_nacimiento, 
            fecha_nacimiento = @fecha_nacimiento, 
            curp = @curp, 
            rfc = @rfc, 
            cvu = @cvu, 
            biografia = @biografia
            where id_usuario = @id_usuario"
        querySelect = "select * from datos_personales"
    End Sub

    Public Function Insert(e As DatosPersonales) As Boolean Implements GenericContract(Of DatosPersonales).Insert
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@nombre", e.Nombre)
        parameters.Add("@apellido_paterno", e.ApellidoPaterno)
        parameters.Add("@apellido_materno", e.ApellidoMaterno)
        parameters.Add("@sexo", e.Sexo)
        parameters.Add("@pais_nacimiento", e.PaisNacimiento)
        parameters.Add("@fecha_nacimiento", e.FechaNacimiento)
        parameters.Add("@curp", e.Curp)
        parameters.Add("@Rfc", e.Rfc)
        parameters.Add("@Cvu", e.Cvu)
        parameters.Add("@biografia", e.Biografia)
        Return ExecuteQuery(queryInsert)
    End Function

    Public Function Delete(id As Object) As Boolean Implements GenericContract(Of DatosPersonales).Delete
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", id)
        Return ExecuteQuery(queryDelete)
    End Function

    Public Function Update(e As DatosPersonales) As Boolean Implements GenericContract(Of DatosPersonales).Update
        parameters = New Dictionary(Of String, Object)
        parameters.Add("@id_usuario", e.IdUsuario)
        parameters.Add("@nombre", e.Nombre)
        parameters.Add("@apellido_paterno", e.ApellidoPaterno)
        parameters.Add("@apellido_materno", e.ApellidoMaterno)
        parameters.Add("@sexo", e.Sexo)
        parameters.Add("@pais_nacimiento", e.PaisNacimiento)
        parameters.Add("@fecha_nacimiento", e.FechaNacimiento)
        parameters.Add("@curp", e.Curp)
        parameters.Add("@Rfc", e.Rfc)
        parameters.Add("@Cvu", e.Cvu)
        parameters.Add("@biografia", e.Biografia)
        Return ExecuteQuery(queryUpdate)
    End Function

    Public Function SelectAll() As List(Of DatosPersonales) Implements GenericContract(Of DatosPersonales).SelectAll
        Dim dataTable = ExecuteSelect(querySelect)
        Dim datosPersonales As New List(Of DatosPersonales)

        For Each row As DataRow In dataTable.Rows
            Dim idUsuario = row.Field(Of String)("id_usuario")
            Dim nombre = row.Field(Of String)("nombre")
            Dim apellidoPaterno = row.Field(Of String)("apellido_paterno")
            Dim apellidoMaterno = row.Field(Of String)("apellido_materno")
            Dim sexo = row.Field(Of Char)("sexo")
            Dim paisNacimiento = row.Field(Of String)("pais_nacimiento")
            Dim fechaNacimiento = row.Field(Of DateTime)("fecha_nacimiento")
            Dim curp = row.Field(Of String)("curp")
            Dim rfc = row.Field(Of String)("rfc")
            Dim cvu = row.Field(Of String)("cvu")
            Dim biografia = row.Field(Of String)("biografia")

            Dim i As New DatosPersonales With {
                .IdUsuario = idUsuario,
                .Nombre = nombre,
                .ApellidoPaterno = apellidoPaterno,
                .ApellidoMaterno = apellidoMaterno,
                .Sexo = sexo,
                .PaisNacimiento = paisNacimiento,
                .FechaNacimiento = fechaNacimiento,
                .Curp = curp,
                .Rfc = rfc,
                .Cvu = cvu,
                .Biografia = biografia
            }

            datosPersonales.Add(i)
        Next

        Return datosPersonales
    End Function

End Class
