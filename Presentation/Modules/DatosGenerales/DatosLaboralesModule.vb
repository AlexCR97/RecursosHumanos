Imports Entities
Imports Logic

Public Class DatosLaboralesModule

    Private mainForm As MainForm

    Public Sub New(mainForm As MainForm)
        InitializeComponent()

        Me.mainForm = mainForm

        FillData()
    End Sub

    Public Sub FillData()
        FillTecnmData()
        FillExternasData()
    End Sub

    Public Sub FillTecnmData()
        Dim idUsuario = mainForm.usuario.IdUsuario
        Dim tecnmModel As AdscripcionTecNMModel = New AdscripcionTecNMModel() With {
            .Entity = New AdscripcionTecNM With {
                .IdUsuario = idUsuario
            }
        }
        Dim adscripciones As List(Of AdscripcionTecNM) = tecnmModel.GetEntitiesWithId()

        Me.DataGridViewTECNM.DataSource = adscripciones
        mainForm.UpdateResumenModule()
    End Sub

    Public Sub FillExternasData()
        Dim idUsuario = mainForm.usuario.IdUsuario
        Dim externasModel As AdscripcionExternaModel = New AdscripcionExternaModel() With {
            .Entity = New AdscripcionExterna With {
                .IdUsuario = idUsuario
            }
        }
        Dim adscripciones As List(Of AdscripcionExterna) = externasModel.GetEntitiesWithId()

        Me.DataGridViewExternas.DataSource = adscripciones
        mainForm.UpdateResumenModule()
    End Sub

    Private Sub AgregarButtonTECNM_Click(sender As Object, e As EventArgs) Handles AgregarButtonTECNM.Click
        Dim dialog As AdscripcionesTecNMDialog = New AdscripcionesTecNMDialog(mainForm, Me, AdscripcionesTecNMDialog.OPERATION_ADD)
        dialog.Show(Me)
    End Sub

    Private Sub EditarButtonTECNM_Click(sender As Object, e As EventArgs) Handles EditarButtonTECNM.Click
        Dim dialog As AdscripcionesTecNMDialog = New AdscripcionesTecNMDialog(mainForm, Me, AdscripcionesTecNMDialog.OPERATION_EDIT)
        dialog.Show(Me)
    End Sub

    Private Sub EliminarButtonTECNM_Click(sender As Object, e As EventArgs) Handles EliminarButtonTECNM.Click
        Dim result As DialogResult = MessageBox.Show(
            "Estas seguro de que quieres eliminar la adscripcion seleccionada?", "",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Exclamation
        )

        If Not result = DialogResult.Yes Then
            Return
        End If

        Dim selectedRow As DataGridViewRow = Me.DataGridViewTECNM.SelectedRows(0)
        If selectedRow Is Nothing Then
            Return
        End If

        Dim a As AdscripcionTecNM = New AdscripcionTecNM() With {
            .IdUsuario = selectedRow.Cells("IdUsuario").Value.ToString(),
            .Plantel = selectedRow.Cells("Plantel").Value.ToString(),
            .FechaAdscripcion = DateTime.Parse(selectedRow.Cells("FechaAdscripcion").Value.ToString()),
            .Vigente = CType(selectedRow.Cells("Vigente").Value, Boolean)
        }

        Dim adscripcionModel As AdscripcionTecNMModel = New AdscripcionTecNMModel() With {
            .Entity = a,
            .State = AdscripcionTecNMModel.STATE_DELETE_SPECIFIC
        }

        Dim success = adscripcionModel.ExecuteChanges()
        If Not success Then
            MessageBox.Show("No se pudo eliminar la adscripcion. Intentelo de nuevo")
            Return
        End If

        MessageBox.Show("Adscripcion eliminada!")
        FillTecnmData()
    End Sub

    Private Sub AgregarButtonExternas_Click(sender As Object, e As EventArgs) Handles AgregarButtonExternas.Click
        Dim dialog As AdscripcionesExternasDialog = New AdscripcionesExternasDialog(mainForm, Me, AdscripcionesExternasDialog.OPERATION_ADD)
        dialog.Show(Me)
    End Sub

    Private Sub EditarButtonExternas_Click(sender As Object, e As EventArgs) Handles EditarButtonExternas.Click
        Dim dialog As AdscripcionesExternasDialog = New AdscripcionesExternasDialog(mainForm, Me, AdscripcionesExternasDialog.OPERATION_EDIT)
        dialog.Show(Me)
    End Sub

    Private Sub EliminarButtonExternas_Click(sender As Object, e As EventArgs) Handles EliminarButtonExternas.Click
        Dim result As DialogResult = MessageBox.Show(
            "Estas seguro de que quieres eliminar la adscripcion seleccionada?", "",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Exclamation
        )

        If Not result = DialogResult.Yes Then
            Return
        End If

        Dim selectedRow As DataGridViewRow = Me.DataGridViewExternas.SelectedRows(0)
        If selectedRow Is Nothing Then
            Return
        End If

        Dim a = New AdscripcionExterna() With {
            .IdUsuario = selectedRow.Cells("IdUsuario").Value.ToString(),
            .Institucion = selectedRow.Cells("Institucion").Value.ToString(),
            .Puesto = selectedRow.Cells("Puesto").Value.ToString(),
            .FechaNombramiento = DateTime.Parse(selectedRow.Cells("FechaNombramiento").Value.ToString()),
            .Vigente = CType(selectedRow.Cells("Vigente").Value, Boolean)
        }

        Dim adscripcionModel As AdscripcionExternaModel = New AdscripcionExternaModel() With {
            .Entity = a,
            .State = AdscripcionExternaModel.STATE_DELETE_SPECIFIC
        }

        Dim success = adscripcionModel.ExecuteChanges()
        If Not success Then
            MessageBox.Show("No se pudo eliminar la adscripcion. Intentelo de nuevo")
            Return
        End If

        MessageBox.Show("Adscripcion eliminada!")
        FillExternasData()
    End Sub
End Class
