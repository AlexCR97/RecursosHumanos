Imports Entities
Imports Logic

Public Class DatosDeContactoModule

    Private mainForm As MainForm

    Public Sub New(mainForm As MainForm)
        InitializeComponent()

        Me.mainForm = mainForm

        FillData()
    End Sub

    Public Sub FillData()
        FillTelefonosData()
        FillCorreosData()
        FillOtrosData()
    End Sub

    Public Sub FillTelefonosData()
        Dim idUsuario = mainForm.usuario.IdUsuario
        Dim telefonosModel As TelefonosModel = New TelefonosModel With {
            .Entity = New Telefonos With {
                .IdUsuario = idUsuario
            }
        }
        Dim telefonos As List(Of Telefonos) = telefonosModel.GetEntitiesWithId()

        Me.DataGridViewTelefonos.DataSource = telefonos
    End Sub

    Public Sub FillCorreosData()
        Dim idUsuario = mainForm.usuario.IdUsuario
        Dim correosModel As CorreosModel = New CorreosModel With {
            .Entity = New Correos With {
                .IdUsuario = idUsuario
            }
        }
        Dim correos As List(Of Correos) = correosModel.GetEntitiesWithId()

        Me.DataGridViewCorreos.DataSource = correos
    End Sub

    Public Sub FillOtrosData()
        Dim idUsuario = mainForm.usuario.IdUsuario
        Dim otrosMediosModel As OtrosMediosDeContactoModel = New OtrosMediosDeContactoModel With {
             .Entity = New OtrosMediosDeContacto With {
                .IdUsuario = idUsuario
             }
        }
        Dim otrosMedios As List(Of OtrosMediosDeContacto) = otrosMediosModel.GetEntitiesWithId()

        Me.DataGridViewOtrosMedios.DataSource = otrosMedios
    End Sub

    Private Sub AgregarButtonTelefonos_Click(sender As Object, e As EventArgs) Handles AgregarButtonTelefonos.Click
        Dim telefonosDialog As TelefonosDialog = New TelefonosDialog(mainForm, Me)
        telefonosDialog.Show(Me)
    End Sub

    Private Sub EliminarButtonTelefonos_Click(sender As Object, e As EventArgs) Handles EliminarButtonTelefonos.Click
        Dim result As DialogResult = MessageBox.Show(
            "Estas seguro de que quieres eliminar el telefono seleccionado?", "",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Exclamation
        )

        If Not result = DialogResult.Yes Then
            Return
        End If

        Dim selectedRow As DataGridViewRow = Me.DataGridViewTelefonos.SelectedRows(0)
        If selectedRow Is Nothing Then
            Return
        End If

        Dim t As Telefonos = New Telefonos With {
            .IdUsuario = selectedRow.Cells("IdUsuario").Value.ToString(),
            .Telefono = selectedRow.Cells("Telefono").Value.ToString()
        }

        Dim telefonosModel As TelefonosModel = New TelefonosModel() With {
            .Entity = t,
            .State = TelefonosModel.STATE_DELETE_SPECIFIC
        }

        Dim success = telefonosModel.ExecuteChanges()
        If Not success Then
            MessageBox.Show("No se pudo eliminar el telefono. Intentelo de nuevo")
            Return
        End If

        MessageBox.Show("Telefono eliminado!")
        FillTelefonosData()
    End Sub

    Private Sub AgregarButtonCorreos_Click(sender As Object, e As EventArgs) Handles AgregarButtonCorreos.Click
        Dim correosDialog As CorreosDialog = New CorreosDialog(mainForm, Me)
        correosDialog.Show(Me)
    End Sub

    Private Sub EliminarButtonCorreos_Click(sender As Object, e As EventArgs) Handles EliminarButtonCorreos.Click
        Dim result As DialogResult = MessageBox.Show(
            "Estas seguro de que quieres eliminar el correo seleccionado?", "",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Exclamation
        )

        If Not result = DialogResult.Yes Then
            Return
        End If

        Dim selectedRow As DataGridViewRow = Me.DataGridViewCorreos.SelectedRows(0)
        If selectedRow Is Nothing Then
            Return
        End If

        Dim c As Correos = New Correos With {
            .IdUsuario = selectedRow.Cells("IdUsuario").Value.ToString(),
            .Correo = selectedRow.Cells("Correo").Value.ToString()
        }

        Dim correosModel As CorreosModel = New CorreosModel() With {
            .Entity = c,
            .State = CorreosModel.STATE_DELETE_SPECIFIC
        }

        Dim success = correosModel.ExecuteChanges()
        If Not success Then
            MessageBox.Show("No se pudo eliminar el correo. Intentelo de nuevo")
            Return
        End If

        MessageBox.Show("Correo eliminado!")
        FillCorreosData()
    End Sub

    Private Sub AgregarButtonOtros_Click(sender As Object, e As EventArgs) Handles AgregarButtonOtros.Click
        Dim otrosDialog As OtrosMediosDialog = New OtrosMediosDialog(mainForm, Me, OtrosMediosDialog.OPERATION_ADD)
        otrosDialog.Show(Me)
    End Sub

    Private Sub EditarButtonOtros_Click(sender As Object, e As EventArgs) Handles EditarButtonOtros.Click
        Dim otrosDialog As OtrosMediosDialog = New OtrosMediosDialog(mainForm, Me, OtrosMediosDialog.OPERATION_EDIT)
        otrosDialog.Show(Me)
    End Sub

    Private Sub EliminarButtonOtros_Click(sender As Object, e As EventArgs) Handles EliminarButtonOtros.Click
        Dim result As DialogResult = MessageBox.Show(
            "Estas seguro de que quieres eliminar el medio seleccionado?", "",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Exclamation
        )

        If Not result = DialogResult.Yes Then
            Return
        End If

        Dim selectedRow As DataGridViewRow = Me.DataGridViewOtrosMedios.SelectedRows(0)
        If selectedRow Is Nothing Then
            Return
        End If

        Dim o As OtrosMediosDeContacto = New OtrosMediosDeContacto With {
            .IdUsuario = selectedRow.Cells("IdUsuario").Value.ToString(),
            .Medio = selectedRow.Cells("Medio").Value.ToString(),
            .Descripcion = selectedRow.Cells("Descripcion").Value.ToString()
        }

        Dim otrosMediosModel As OtrosMediosDeContactoModel = New OtrosMediosDeContactoModel() With {
            .Entity = o,
            .State = OtrosMediosDeContactoModel.STATE_DELETE_SPECIFIC
        }

        Dim success = otrosMediosModel.ExecuteChanges()
        If Not success Then
            MessageBox.Show("No se pudo eliminar el medio. Intentelo de nuevo")
            Return
        End If

        MessageBox.Show("Medio eliminado!")
        FillOtrosData()
    End Sub
End Class
