Imports Entities
Imports Logic

Public Class AsociacionesModule

    Private mainForm As MainForm

    Public Sub New(mainForm As MainForm)
        InitializeComponent()

        Me.mainForm = mainForm

        FillData()
    End Sub

    Public Sub FillData()
        Dim idUsuario = mainForm.usuario.IdUsuario
        Dim asociacionesModel As AsociacionesModel = New AsociacionesModel With {
            .Entity = New Asociaciones With {
                .IdUsuario = idUsuario
            }
        }

        Dim asociaciones As List(Of Asociaciones) = asociacionesModel.GetEntitiesWithId()

        Me.DataGridViewAsociaciones.DataSource = asociaciones
        mainForm.UpdateResumenModule()
    End Sub

    Private Sub AgregarButtonAsociaciones_Click(sender As Object, e As EventArgs) Handles AgregarButtonAsociaciones.Click
        Dim dialog As AsociacionesDialog = New AsociacionesDialog(mainForm, Me, AsociacionesDialog.OPERATION_ADD)
        dialog.Show(Me)
    End Sub

    Private Sub EditarButtonAsociaciones_Click(sender As Object, e As EventArgs) Handles EditarButtonAsociaciones.Click
        Dim dialog As AsociacionesDialog = New AsociacionesDialog(mainForm, Me, AsociacionesDialog.OPERATION_EDIT)
        dialog.Show(Me)
    End Sub

    Private Sub EliminarButtonAsociaciones_Click(sender As Object, e As EventArgs) Handles EliminarButtonAsociaciones.Click
        Dim result As DialogResult = MessageBox.Show(
            "Estas seguro de que quieres eliminar la asociacion seleccionada?", "",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Exclamation
        )

        If Not result = DialogResult.Yes Then
            Return
        End If

        Dim selectedRow As DataGridViewRow = Me.DataGridViewAsociaciones.SelectedRows(0)
        If selectedRow Is Nothing Then
            Return
        End If

        Dim a As Asociaciones = New Asociaciones() With {
            .IdUsuario = selectedRow.Cells("IdUsuario").Value.ToString(),
            .Organismo = selectedRow.Cells("Organismo").Value.ToString(),
            .Nombramiento = selectedRow.Cells("Nombramiento").Value.ToString(),
            .AnioAfiliacion = DateTime.Parse(selectedRow.Cells("AnioAfiliacion").Value.ToString()),
            .InicioVigencia = DateTime.Parse(selectedRow.Cells("InicioVigencia").Value.ToString()),
            .FinVigencia = DateTime.Parse(selectedRow.Cells("FinVigencia").Value.ToString())
        }

        Dim asociacionesModel As AsociacionesModel = New AsociacionesModel() With {
            .Entity = a,
            .State = AsociacionesModel.STATE_DELETE_SPECIFIC
        }

        Dim success = asociacionesModel.ExecuteChanges()
        If Not success Then
            MessageBox.Show("No se pudo eliminar la asociacion. Intentelo de nuevo")
            Return
        End If

        MessageBox.Show("Certificacion eliminada!")
        FillData()
    End Sub
End Class
