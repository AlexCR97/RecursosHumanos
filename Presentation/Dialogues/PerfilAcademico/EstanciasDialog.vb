Imports Entities
Imports Logic

Public Class EstanciasDialog
    Inherits CustomDialog

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(mainForm As MainForm, parentModule As ProductividadAcademicaModule, operation As Integer)
        MyBase.New(mainForm)
        InitializeComponent()

        Me.parentModule = parentModule
        Me.operation = operation

        If Not operation = OPERATION_EDIT Then
            Return
        End If

        FillData()
    End Sub

    Public Overrides Sub FillData()
        Dim dataGridView As DataGridView = CType(parentModule, ProductividadAcademicaModule).DataGridViewEstancias

        Dim selectedRow As DataGridViewRow = dataGridView.SelectedRows(0)
        If selectedRow Is Nothing Then
            MessageBox.Show("Ocurrio un error al intentar obtener la estancia a editar")
            ReturnControl()
        End If

        Me.TextBoxInstitucion.Text = selectedRow.Cells("Institucion").Value.ToString()
        Me.TextBoxNombreProyecto.Text = selectedRow.Cells("NombreProyecto").Value.ToString()
        Me.DateTimePickerFechaInicio.Value = DateTime.Parse(selectedRow.Cells("FechaInicio").Value.ToString())
        Me.DateTimePickerFechaTermino.Value = DateTime.Parse(selectedRow.Cells("FechaTermino").Value.ToString())
    End Sub

    Public Overrides Sub Add()
        Dim idUsuario = mainForm.usuario.IdUsuario
        Dim institucion = Me.TextBoxInstitucion.Text
        Dim nombre = Me.TextBoxNombreProyecto.Text
        Dim fechaInicio = Me.DateTimePickerFechaInicio.Value
        Dim fechaTermino = Me.DateTimePickerFechaTermino.Value

        Dim e As Estancias = New Estancias() With {
            .IdUsuario = idUsuario,
            .Institucion = institucion,
            .NombreProyecto = nombre,
            .FechaInicio = fechaInicio,
            .FechaTermino = fechaTermino
        }

        Dim estanciasValidation As EstanciasValidation = New EstanciasValidation() With {
            .Entity = e
        }

        Dim success = estanciasValidation.ValidateAll()
        If Not success Then
            MessageBox.Show("Debes ingresar datos validos")
            Return
        End If

        Dim estanciasModel As EstanciasModel = New EstanciasModel() With {
            .Entity = e,
            .State = EstanciasModel.STATE_INSERT
        }

        success = estanciasModel.ExecuteChanges()
        If Not success Then
            MessageBox.Show("Hubo un error al agregar la estancia. Intentelo de nuevo")
            Return
        End If

        MessageBox.Show("Titulo agregado!")
        CType(parentModule, ProductividadAcademicaModule).FillEstanciasData()

        ReturnControl()
    End Sub

    Public Overrides Sub Edit()
        Dim idUsuario = mainForm.usuario.IdUsuario
        Dim institucion = Me.TextBoxInstitucion.Text
        Dim nombre = Me.TextBoxNombreProyecto.Text
        Dim fechaInicio = Me.DateTimePickerFechaInicio.Value
        Dim fechaTermino = Me.DateTimePickerFechaTermino.Value

        Dim e As Estancias = New Estancias() With {
            .IdUsuario = idUsuario,
            .Institucion = institucion,
            .NombreProyecto = nombre,
            .FechaInicio = fechaInicio,
            .FechaTermino = fechaTermino
        }

        Dim estanciasValidation As EstanciasValidation = New EstanciasValidation() With {
            .Entity = e
        }

        Dim success = estanciasValidation.ValidateAll()
        If Not success Then
            MessageBox.Show("Debes ingresar datos validos")
            Return
        End If

        Dim dataGridView As DataGridView = CType(parentModule, ProductividadAcademicaModule).DataGridViewEstancias

        Dim selectedRow As DataGridViewRow = dataGridView.SelectedRows(0)
        If selectedRow Is Nothing Then
            MessageBox.Show("Ocurrio un error al intentar obtener la estancia a editar")
            ReturnControl()
        End If

        e = New Estancias() With {
            .IdUsuario = idUsuario,
            .Institucion = selectedRow.Cells("Institucion").Value.ToString(),
            .NombreProyecto = selectedRow.Cells("NombreProyecto").Value.ToString(),
            .FechaInicio = DateTime.Parse(selectedRow.Cells("FechaInicio").Value.ToString()),
            .FechaTermino = DateTime.Parse(selectedRow.Cells("FechaTermino").Value.ToString())
        }

        ''''''''''''''''''''''''''''''''''''''''''''''''

        Dim estanciasModel As EstanciasModel = New EstanciasModel() With {
            .Entity = e,
            .State = EstanciasModel.STATE_DELETE_SPECIFIC
        }

        success = estanciasModel.ExecuteChanges()
        If Not success Then
            MessageBox.Show("Ocurrio un error al hacer la edicion. La estancia ha sido eliminado")
            Return
        End If

        e = New Estancias() With {
            .IdUsuario = idUsuario,
            .Institucion = institucion,
            .NombreProyecto = nombre,
            .FechaInicio = fechaInicio,
            .FechaTermino = fechaTermino
        }

        estanciasModel = New EstanciasModel() With {
            .Entity = e,
            .State = EstanciasModel.STATE_INSERT
        }

        success = estanciasModel.ExecuteChanges()
        If Not success Then
            MessageBox.Show("Hubo un error al agregar el titulo academico. Intentelo de nuevo")
            Return
        End If

        MessageBox.Show("Titulo editado!")
        CType(parentModule, ProductividadAcademicaModule).FillEstanciasData()

        ReturnControl()
    End Sub

    Private Sub GuardarButton1_Click(sender As Object, e As EventArgs) Handles GuardarButton1.Click
        Select Case operation
            Case OPERATION_ADD
                Add()
            Case OPERATION_EDIT
                Edit()
        End Select
    End Sub

    Private Sub CancelarButton1_Click(sender As Object, e As EventArgs) Handles CancelarButton1.Click
        ReturnControl()
    End Sub
End Class