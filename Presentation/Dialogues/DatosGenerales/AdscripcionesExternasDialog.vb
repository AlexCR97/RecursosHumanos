Imports Entities
Imports Logic

Public Class AdscripcionesExternasDialog
    Inherits CustomDialog

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(mainForm As MainForm, parentModule As DatosLaboralesModule, operation As Integer)
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
        Dim dataGridViewAdscripciones As DataGridView = CType(parentModule, DatosLaboralesModule).DataGridViewExternas

        Dim selectedRow As DataGridViewRow = dataGridViewAdscripciones.SelectedRows(0)
        If selectedRow Is Nothing Then
            MessageBox.Show("Ocurrio un error al intentar obtener la adscripcion a editar")
            ReturnControl()
        End If

        Me.TextBoxInstitucion.Text = selectedRow.Cells("Institucion").Value.ToString()
        Me.TextBoxPuesto.Text = selectedRow.Cells("Puesto").Value.ToString()
        Me.DateTimePickerFechaNombramiento.Value = DateTime.Parse(selectedRow.Cells("FechaNombramiento").Value.ToString())
        Me.CheckBoxVigente.Checked = CType(selectedRow.Cells("Vigente").Value, Boolean)
    End Sub

    Public Overrides Sub Add()
        Dim idUsuario = mainForm.usuario.IdUsuario
        Dim institucion = Me.TextBoxInstitucion.Text
        Dim puesto = Me.TextBoxPuesto.Text
        Dim fecha = Me.DateTimePickerFechaNombramiento.Value
        Dim vigente = Me.CheckBoxVigente.Checked

        Dim a As AdscripcionExterna = New AdscripcionExterna() With {
            .IdUsuario = idUsuario,
            .Institucion = institucion,
            .Puesto = puesto,
            .FechaNombramiento = fecha,
            .Vigente = vigente
        }

        Dim adscripcionValidation As AdscripcionExternaValidation = New AdscripcionExternaValidation() With {
            .Entity = a
        }

        Dim success = adscripcionValidation.ValidateAll()
        If Not success Then
            MessageBox.Show("Debes ingresar datos validos")
            Return
        End If

        Dim adscripcionModel As AdscripcionExternaModel = New AdscripcionExternaModel() With {
            .Entity = a,
            .State = AdscripcionExternaModel.STATE_INSERT
        }

        success = adscripcionModel.ExecuteChanges()
        If Not success Then
            MessageBox.Show("Hubo un error al agregar la adscripcion. Intentelo de nuevo")
            Return
        End If

        MessageBox.Show("Adscripcion agregada!")
        CType(parentModule, DatosLaboralesModule).FillExternasData()

        ReturnControl()
    End Sub

    Public Overrides Sub Edit()
        Dim idUsuario = mainForm.usuario.IdUsuario
        Dim institucion = Me.TextBoxInstitucion.Text
        Dim puesto = Me.TextBoxPuesto.Text
        Dim fecha = Me.DateTimePickerFechaNombramiento.Value
        Dim vigente = Me.CheckBoxVigente.Checked

        Dim a As AdscripcionExterna = New AdscripcionExterna() With {
            .IdUsuario = idUsuario,
            .Institucion = institucion,
            .Puesto = puesto,
            .FechaNombramiento = fecha,
            .Vigente = vigente
        }

        Dim adscripcionValidation As AdscripcionExternaValidation = New AdscripcionExternaValidation() With {
            .Entity = a
        }

        Dim success = adscripcionValidation.ValidateAll()
        If Not success Then
            MessageBox.Show("Debes ingresar datos validos")
            Return
        End If

        Dim dataGridViewAdscripciones As DataGridView = CType(parentModule, DatosLaboralesModule).DataGridViewExternas

        Dim selectedRow As DataGridViewRow = dataGridViewAdscripciones.SelectedRows(0)
        If selectedRow Is Nothing Then
            MessageBox.Show("Ocurrio un error al intentar obtener la adscripcion a editar")
            ReturnControl()
        End If

        a = New AdscripcionExterna() With {
            .IdUsuario = idUsuario,
            .Institucion = selectedRow.Cells("Institucion").Value.ToString(),
            .Puesto = selectedRow.Cells("Puesto").Value.ToString(),
            .FechaNombramiento = DateTime.Parse(selectedRow.Cells("FechaNombramiento").Value.ToString()),
            .Vigente = CType(selectedRow.Cells("Vigente").Value, Boolean)
        }

        Dim adscripcionesModel As AdscripcionExternaModel = New AdscripcionExternaModel() With {
            .Entity = a,
            .State = AdscripcionExternaModel.STATE_DELETE_SPECIFIC
        }

        success = adscripcionesModel.ExecuteChanges()
        If Not success Then
            MessageBox.Show("Ocurrio un error al hacer la edicion. La adscripcion ha sido eliminada")
            Return
        End If

        a = New AdscripcionExterna() With {
            .IdUsuario = idUsuario,
            .Institucion = institucion,
            .Puesto = puesto,
            .FechaNombramiento = fecha,
            .Vigente = vigente
        }

        adscripcionesModel = New AdscripcionExternaModel() With {
            .Entity = a,
            .State = AdscripcionExternaModel.STATE_INSERT
        }

        success = adscripcionesModel.ExecuteChanges()
        If Not success Then
            MessageBox.Show("Hubo un error al agregar la adscripcion. Intentelo de nuevo")
            Return
        End If

        MessageBox.Show("Adscripcion editada!")
        CType(parentModule, DatosLaboralesModule).FillExternasData()

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
