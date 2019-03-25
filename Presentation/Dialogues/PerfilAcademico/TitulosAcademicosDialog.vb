Imports Entities
Imports Logic

Public Class TitulosAcademicosDialog
    Inherits CustomDialog

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(mainForm As MainForm, parentModule As TitulosAcademicosModule, operation As Integer)
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
        Dim dataGridViewTitulos As DataGridView = CType(parentModule, TitulosAcademicosModule).DataGridViewTitulosAcademicos

        Dim selectedRow As DataGridViewRow = dataGridViewTitulos.SelectedRows(0)
        If selectedRow Is Nothing Then
            MessageBox.Show("Ocurrio un error al intentar obtener el titulo a editar")
            ReturnControl()
        End If

        Me.TextBoxInstitucion.Text = selectedRow.Cells("Institucion").Value.ToString()
        Me.TextBoxGrado.Text = selectedRow.Cells("Grado").Value.ToString()
        Me.TextBoxTitulo.Text = selectedRow.Cells("Titulo").Value.ToString()
        Me.DateTimePickerFechaObtencion.Value = DateTime.Parse(selectedRow.Cells("FechaObtencion").Value.ToString())
        Me.TextBoxNumeroCedula.Text = selectedRow.Cells("NumeroCedula").Value.ToString()
    End Sub

    Public Overrides Sub Add()
        Dim idUsuario = mainForm.usuario.IdUsuario
        Dim institucion = Me.TextBoxInstitucion.Text
        Dim grado = Me.TextBoxGrado.Text
        Dim titulo = Me.TextBoxTitulo.Text
        Dim fecha = Me.DateTimePickerFechaObtencion.Value
        Dim numero = Me.TextBoxNumeroCedula.Text

        Dim t As TitulosAcademicos = New TitulosAcademicos() With {
            .IdUsuario = idUsuario,
            .Institucion = institucion,
            .Grado = grado,
            .Titulo = titulo,
            .FechaObtencion = fecha,
            .NumeroCedula = numero
        }

        Dim titulosAcademicosValidation As TitulosAcademicosValidation = New TitulosAcademicosValidation() With {
            .Entity = t
        }

        Dim success = titulosAcademicosValidation.ValidateAll()
        If Not success Then
            MessageBox.Show("Debes ingresar datos validos")
            Return
        End If

        Dim titulosAcademicosModel As TitulosAcademicosModel = New TitulosAcademicosModel() With {
            .Entity = t,
            .State = TitulosAcademicosModel.STATE_INSERT
        }

        success = titulosAcademicosModel.ExecuteChanges()
        If Not success Then
            MessageBox.Show("Hubo un error al agregar el titulo acedemico. Intentelo de nuevo")
            Return
        End If

        MessageBox.Show("Titulo agregado!")
        CType(parentModule, TitulosAcademicosModule).FillData()

        ReturnControl()
    End Sub

    Public Overrides Sub Edit()
        Dim idUsuario = mainForm.usuario.IdUsuario
        Dim institucion = Me.TextBoxInstitucion.Text
        Dim grado = Me.TextBoxGrado.Text
        Dim titulo = Me.TextBoxTitulo.Text
        Dim fecha = Me.DateTimePickerFechaObtencion.Value
        Dim numero = Me.TextBoxNumeroCedula.Text

        Dim t As TitulosAcademicos = New TitulosAcademicos() With {
            .IdUsuario = idUsuario,
            .Institucion = institucion,
            .Grado = grado,
            .Titulo = titulo,
            .FechaObtencion = fecha,
            .NumeroCedula = numero
        }

        Dim titulosAcademicosValidation As TitulosAcademicosValidation = New TitulosAcademicosValidation() With {
            .Entity = t
        }

        Dim success = titulosAcademicosValidation.ValidateAll()
        If Not success Then
            MessageBox.Show("Debes ingresar datos validos")
            Return
        End If

        Dim dataGridViewTitulos As DataGridView = CType(parentModule, TitulosAcademicosModule).DataGridViewTitulosAcademicos

        Dim selectedRow As DataGridViewRow = dataGridViewTitulos.SelectedRows(0)
        If selectedRow Is Nothing Then
            MessageBox.Show("Ocurrio un error al intentar obtener el titulo a editar")
            ReturnControl()
        End If

        t = New TitulosAcademicos() With {
            .IdUsuario = idUsuario,
            .Institucion = selectedRow.Cells("Institucion").Value.ToString(),
            .Grado = selectedRow.Cells("Grado").Value.ToString(),
            .Titulo = selectedRow.Cells("Titulo").Value.ToString(),
            .FechaObtencion = DateTime.Parse(selectedRow.Cells("FechaObtencion").Value.ToString()),
            .NumeroCedula = selectedRow.Cells("NumeroCedula").Value.ToString()
        }

        Dim titulosAcademicosModel As TitulosAcademicosModel = New TitulosAcademicosModel() With {
            .Entity = t,
            .State = TitulosAcademicosModel.STATE_DELETE_SPECIFIC
        }

        success = titulosAcademicosModel.ExecuteChanges()
        If Not success Then
            MessageBox.Show("Ocurrio un error al hacer la edicion. El titulo ha sido eliminado")
            Return
        End If

        t = New TitulosAcademicos() With {
            .IdUsuario = idUsuario,
            .Institucion = institucion,
            .Grado = grado,
            .Titulo = titulo,
            .FechaObtencion = fecha,
            .NumeroCedula = numero
        }

        titulosAcademicosModel = New TitulosAcademicosModel() With {
            .Entity = t,
            .State = TitulosAcademicosModel.STATE_INSERT
        }

        success = titulosAcademicosModel.ExecuteChanges()
        If Not success Then
            MessageBox.Show("Hubo un error al agregar el titulo academico. Intentelo de nuevo")
            Return
        End If

        MessageBox.Show("Titulo editado!")
        CType(parentModule, TitulosAcademicosModule).FillData()

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
