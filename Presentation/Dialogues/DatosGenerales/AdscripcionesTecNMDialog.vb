Imports Entities
Imports Logic

Public Class AdscripcionesTecNMDialog
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
        Dim dataGridViewAdscripciones As DataGridView = CType(parentModule, DatosLaboralesModule).DataGridViewTECNM

        Dim selectedRow As DataGridViewRow = dataGridViewAdscripciones.SelectedRows(0)
        If selectedRow Is Nothing Then
            MessageBox.Show("Ocurrio un error al intentar obtener la adscripcion a editar")
            ReturnControl()
        End If

        Me.TextBoxPlantel.Text = selectedRow.Cells("Plantel").Value.ToString()
        Me.DateTimePickerFecha.Value = DateTime.Parse(selectedRow.Cells("FechaAdscripcion").Value.ToString())
        Me.CheckBoxVigente.Checked = CType(selectedRow.Cells("Vigente").Value, Boolean)
    End Sub

    Public Overrides Sub Add()
        Dim idUsuario = mainForm.usuario.IdUsuario
        Dim plantel = Me.TextBoxPlantel.Text
        Dim fecha = Me.DateTimePickerFecha.Value
        Dim vigente = Me.CheckBoxVigente.Checked

        Dim a As AdscripcionTecNM = New AdscripcionTecNM() With {
            .IdUsuario = idUsuario,
            .Plantel = plantel,
            .FechaAdscripcion = fecha,
            .Vigente = vigente
        }

        Dim adscripcionValidation As AdscripcionTecNMValidation = New AdscripcionTecNMValidation() With {
            .Entity = a
        }

        Dim success = adscripcionValidation.ValidateAll()
        If Not success Then
            MessageBox.Show("Debes ingresar datos validos")
            Return
        End If

        Dim adscripcionModel As AdscripcionTecNMModel = New AdscripcionTecNMModel() With {
            .Entity = a,
            .State = AdscripcionTecNMModel.STATE_INSERT
        }

        success = adscripcionModel.ExecuteChanges()
        If Not success Then
            MessageBox.Show("Hubo un error al agregar la adscripcion. Intentelo de nuevo")
            Return
        End If

        MessageBox.Show("Adscripcion agregada!")
        CType(parentModule, DatosLaboralesModule).FillTecnmData()

        ReturnControl()
    End Sub

    Public Overrides Sub Edit()
        Dim idUsuario = mainForm.usuario.IdUsuario
        Dim plantel = Me.TextBoxPlantel.Text
        Dim fecha = Me.DateTimePickerFecha.Value
        Dim vigente = Me.CheckBoxVigente.Checked

        Dim a As AdscripcionTecNM = New AdscripcionTecNM() With {
            .IdUsuario = idUsuario,
            .Plantel = plantel,
            .FechaAdscripcion = fecha,
            .Vigente = vigente
        }

        Dim adscripcionValidation As AdscripcionTecNMValidation = New AdscripcionTecNMValidation() With {
            .Entity = a
        }

        Dim success = adscripcionValidation.ValidateAll()
        If Not success Then
            MessageBox.Show("Debes ingresar datos validos")
            Return
        End If

        Dim dataGridViewAdscripciones As DataGridView = CType(parentModule, DatosLaboralesModule).DataGridViewTECNM

        Dim selectedRow As DataGridViewRow = dataGridViewAdscripciones.SelectedRows(0)
        If selectedRow Is Nothing Then
            MessageBox.Show("Ocurrio un error al intentar obtener la adscripcion a editar")
            ReturnControl()
        End If

        a = New AdscripcionTecNM() With {
            .IdUsuario = idUsuario,
            .Plantel = selectedRow.Cells("Plantel").Value.ToString(),
            .FechaAdscripcion = DateTime.Parse(selectedRow.Cells("FechaAdscripcion").Value.ToString()),
            .Vigente = CType(selectedRow.Cells("Vigente").Value, Boolean)
        }

        Dim adscripcionesModel As AdscripcionTecNMModel = New AdscripcionTecNMModel() With {
            .Entity = a,
            .State = AdscripcionTecNMModel.STATE_DELETE_SPECIFIC
        }

        success = adscripcionesModel.ExecuteChanges()
        If Not success Then
            MessageBox.Show("Ocurrio un error al hacer la edicion. La adscripcion ha sido eliminada")
            Return
        End If

        a = New AdscripcionTecNM() With {
            .IdUsuario = idUsuario,
            .Plantel = plantel,
            .FechaAdscripcion = fecha,
            .Vigente = vigente
        }

        adscripcionesModel = New AdscripcionTecNMModel() With {
            .Entity = a,
            .State = AdscripcionTecNMModel.STATE_INSERT
        }

        success = adscripcionesModel.ExecuteChanges()
        If Not success Then
            MessageBox.Show("Hubo un error al agregar la adscripcion. Intentelo de nuevo")
            Return
        End If

        MessageBox.Show("Adscripcion editada!")
        CType(parentModule, DatosLaboralesModule).FillTecnmData()

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
