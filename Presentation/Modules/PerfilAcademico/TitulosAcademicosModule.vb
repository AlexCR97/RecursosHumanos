Imports Entities
Imports Logic

Public Class TitulosAcademicosModule

    Private mainForm As MainForm

    Public Sub New(mainForm As MainForm)
        InitializeComponent()

        Me.mainForm = mainForm

        FillData()
    End Sub

    Public Sub FillData()
        Dim idUsuario = mainForm.usuario.IdUsuario
        Dim titulosAcademicosModel As TitulosAcademicosModel = New TitulosAcademicosModel With {
            .Entity = New TitulosAcademicos With {
                .IdUsuario = idUsuario
            }
        }

        Dim titulosAcademicos As List(Of TitulosAcademicos) = titulosAcademicosModel.GetEntitiesWithId()

        Me.DataGridViewTitulosAcademicos.DataSource = titulosAcademicos
        mainForm.UpdateResumenModule()
    End Sub

    Private Sub AgregarButtonTitulosAcademicos_Click(sender As Object, e As EventArgs) Handles AgregarButtonTitulosAcademicos.Click
        Dim dialog As TitulosAcademicosDialog = New TitulosAcademicosDialog(mainForm, Me, TitulosAcademicosDialog.OPERATION_ADD)
        dialog.Show(Me)
    End Sub

    Private Sub EditarButtonTitulosAcademicos_Click(sender As Object, e As EventArgs) Handles EditarButtonTitulosAcademicos.Click
        Dim dialog As TitulosAcademicosDialog = New TitulosAcademicosDialog(mainForm, Me, TitulosAcademicosDialog.OPERATION_EDIT)
        dialog.Show(Me)
    End Sub

    Private Sub EliminarButtonTitulosAcademicos_Click(sender As Object, e As EventArgs) Handles EliminarButtonTitulosAcademicos.Click
        Dim result As DialogResult = MessageBox.Show(
            "Estas seguro de que quieres eliminar el titulo seleccionado?", "",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Exclamation
        )

        If Not result = DialogResult.Yes Then
            Return
        End If

        Dim selectedRow As DataGridViewRow = Me.DataGridViewTitulosAcademicos.SelectedRows(0)
        If selectedRow Is Nothing Then
            Return
        End If

        Dim t As TitulosAcademicos = New TitulosAcademicos With {
            .IdUsuario = selectedRow.Cells("IdUsuario").Value.ToString(),
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

        Dim success = titulosAcademicosModel.ExecuteChanges()
        If Not success Then
            MessageBox.Show("No se pudo eliminar el titulo. Intentelo de nuevo")
            Return
        End If

        MessageBox.Show("Titulo eliminado!")
        FillData()
    End Sub
End Class
