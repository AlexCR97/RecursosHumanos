Imports Entities
Imports Logic

Public Class DistincionesModule

    Private mainForm As MainForm

    Public Sub New(mainForm As MainForm)
        InitializeComponent()

        Me.mainForm = mainForm

        FillData()
    End Sub

    Public Sub FillData()
        FillCertificacionesData()
        FillPremiosData()
        FillColegiosData()
    End Sub

    Public Sub FillCertificacionesData()
        Dim idUsuario = mainForm.usuario.IdUsuario
        Dim certificacionesModel As CertificacionesModel = New CertificacionesModel With {
            .Entity = New Certificaciones With {
                .IdUsuario = idUsuario
            }
        }

        Dim certificaciones As List(Of Certificaciones) = certificacionesModel.GetEntitiesWithId()

        Me.DataGridViewCertificaciones.DataSource = certificaciones
        mainForm.UpdateResumenModule()
    End Sub

    Public Sub FillPremiosData()
        Dim idUsuario = mainForm.usuario.IdUsuario
        Dim premiosModel As PremiosModel = New PremiosModel With {
            .Entity = New Premios With {
                .IdUsuario = idUsuario
            }
        }

        Dim premios As List(Of Premios) = premiosModel.GetEntitiesWithId()

        Me.DataGridViewPremios.DataSource = premios
        mainForm.UpdateResumenModule()
    End Sub

    Public Sub FillColegiosData()
        Dim idUsuario = mainForm.usuario.IdUsuario
        Dim colegiosModel As ColegiosModel = New ColegiosModel With {
            .Entity = New Colegios With {
                .IdUsuario = idUsuario
            }
        }

        Dim colegios As List(Of Colegios) = colegiosModel.GetEntitiesWithId()

        Me.DataGridViewColegios.DataSource = colegios
        mainForm.UpdateResumenModule()
    End Sub

    Private Sub AgregarButtonCertificaciones_Click(sender As Object, e As EventArgs) Handles AgregarButtonCertificaciones.Click
        Dim dialog As CertificacionesDialog = New CertificacionesDialog(mainForm, Me, CertificacionesDialog.OPERATION_ADD)
        dialog.Show(Me)
    End Sub

    Private Sub EditarButtonCertificaciones_Click(sender As Object, e As EventArgs) Handles EditarButtonCertificaciones.Click
        Dim dialog As CertificacionesDialog = New CertificacionesDialog(mainForm, Me, CertificacionesDialog.OPERATION_EDIT)
        dialog.Show(Me)
    End Sub

    Private Sub EliminarButtonCertificaciones_Click(sender As Object, e As EventArgs) Handles EliminarButtonCertificaciones.Click
        Dim result As DialogResult = MessageBox.Show(
            "Estas seguro de que quieres eliminar la certificacion seleccionada?", "",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Exclamation
        )

        If Not result = DialogResult.Yes Then
            Return
        End If

        Dim selectedRow As DataGridViewRow = Me.DataGridViewCertificaciones.SelectedRows(0)
        If selectedRow Is Nothing Then
            Return
        End If

        Dim c As Certificaciones = New Certificaciones() With {
            .IdUsuario = selectedRow.Cells("IdUsuario").Value.ToString(),
            .Institucion = selectedRow.Cells("Institucion").Value.ToString(),
            .Descripcion = selectedRow.Cells("Descripcion").Value.ToString(),
            .FechaCertificacion = DateTime.Parse(selectedRow.Cells("FechaCertificacion").Value.ToString()),
            .FechaLimite = DateTime.Parse(selectedRow.Cells("FechaLimite").Value.ToString())
        }

        Dim certificacionesModel As CertificacionesModel = New CertificacionesModel() With {
            .Entity = c,
            .State = CertificacionesModel.STATE_DELETE_SPECIFIC
        }

        Dim success = certificacionesModel.ExecuteChanges()
        If Not success Then
            MessageBox.Show("No se pudo eliminar la certificacion. Intentelo de nuevo")
            Return
        End If

        MessageBox.Show("Certificacion eliminada!")
        FillCertificacionesData()
    End Sub

    Private Sub AgregarButtonPremios_Click(sender As Object, e As EventArgs) Handles AgregarButtonPremios.Click
        Dim dialog As PremiosDialog = New PremiosDialog(mainForm, Me, PremiosDialog.OPERATION_ADD)
        dialog.Show(Me)
    End Sub

    Private Sub EditarButtonPremios_Click(sender As Object, e As EventArgs) Handles EditarButtonPremios.Click
        Dim dialog As PremiosDialog = New PremiosDialog(mainForm, Me, PremiosDialog.OPERATION_EDIT)
        dialog.Show(Me)
    End Sub

    Private Sub EliminarButtonPremios_Click(sender As Object, e As EventArgs) Handles EliminarButtonPremios.Click
        Dim result As DialogResult = MessageBox.Show(
            "Estas seguro de que quieres eliminar el premio seleccionado?", "",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Exclamation
        )

        If Not result = DialogResult.Yes Then
            Return
        End If

        Dim selectedRow As DataGridViewRow = Me.DataGridViewPremios.SelectedRows(0)
        If selectedRow Is Nothing Then
            Return
        End If

        Dim p As Premios = New Premios() With {
            .IdUsuario = selectedRow.Cells("IdUsuario").Value.ToString(),
            .Institucion = selectedRow.Cells("Institucion").Value.ToString(),
            .Descripcion = selectedRow.Cells("Descripcion").Value.ToString(),
            .FechaCertificacion = DateTime.Parse(selectedRow.Cells("FechaCertificacion").Value.ToString())
        }

        Dim premiosModel As PremiosModel = New PremiosModel() With {
            .Entity = p,
            .State = PremiosModel.STATE_DELETE_SPECIFIC
        }

        Dim success = premiosModel.ExecuteChanges()
        If Not success Then
            MessageBox.Show("No se pudo eliminar el premio. Intentelo de nuevo")
            Return
        End If

        MessageBox.Show("Premio eliminado!")
        FillPremiosData()
    End Sub

    Private Sub AgregarButtonColegios_Click(sender As Object, e As EventArgs) Handles AgregarButtonColegios.Click
        Dim dialog As ColegiosDialog = New ColegiosDialog(mainForm, Me, ColegiosDialog.OPERATION_ADD)
        dialog.Show(Me)
    End Sub

    Private Sub EditarButtonColegios_Click(sender As Object, e As EventArgs) Handles EditarButtonColegios.Click
        Dim dialog As ColegiosDialog = New ColegiosDialog(mainForm, Me, ColegiosDialog.OPERATION_EDIT)
        dialog.Show(Me)
    End Sub

    Private Sub EliminarButtonColegios_Click(sender As Object, e As EventArgs) Handles EliminarButtonColegios.Click
        Dim result As DialogResult = MessageBox.Show(
            "Estas seguro de que quieres eliminar el colegio seleccionado?", "",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Exclamation
        )

        If Not result = DialogResult.Yes Then
            Return
        End If

        Dim selectedRow As DataGridViewRow = Me.DataGridViewColegios.SelectedRows(0)
        If selectedRow Is Nothing Then
            Return
        End If

        Dim c As Colegios = New Colegios() With {
            .IdUsuario = selectedRow.Cells("IdUsuario").Value.ToString(),
            .Nombramiento = selectedRow.Cells("Nombramiento").Value.ToString(),
            .Colegio = selectedRow.Cells("Colegio").Value.ToString(),
            .Afiliacion = selectedRow.Cells("Afiliacion").Value.ToString()
        }

        Dim colegiosModel As ColegiosModel = New ColegiosModel() With {
            .Entity = c,
            .State = ColegiosModel.STATE_DELETE_SPECIFIC
        }

        Dim success = colegiosModel.ExecuteChanges()
        If Not success Then
            MessageBox.Show("No se pudo eliminar el colegio. Intentelo de nuevo")
            Return
        End If

        MessageBox.Show("Colegio eliminado!")
        FillColegiosData()
    End Sub
End Class
