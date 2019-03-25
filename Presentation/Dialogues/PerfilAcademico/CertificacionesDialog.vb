Imports Entities
Imports Logic

Public Class CertificacionesDialog
    Inherits CustomDialog

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(mainForm As MainForm, parentModule As DistincionesModule, operation As Integer)
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
        Dim dataGridView As DataGridView = CType(parentModule, DistincionesModule).DataGridViewCertificaciones

        Dim selectedRow As DataGridViewRow = dataGridView.SelectedRows(0)
        If selectedRow Is Nothing Then
            MessageBox.Show("Ocurrio un error al intentar obtener la certificacion a editar")
            ReturnControl()
        End If

        Me.TextBoxInstitucion.Text = selectedRow.Cells("Institucion").Value.ToString()
        Me.TextBoxDescripcion.Text = selectedRow.Cells("Descripcion").Value.ToString()
        Me.DateTimePickerFechaCertificacion.Value = DateTime.Parse(selectedRow.Cells("FechaCertificacion").Value.ToString())
        Me.DateTimePickerFechaLimite.Value = DateTime.Parse(selectedRow.Cells("FechaLimite").Value.ToString())
    End Sub

    Public Overrides Sub Add()
        Dim idUsuario = mainForm.usuario.IdUsuario
        Dim institucion = Me.TextBoxInstitucion.Text
        Dim descripcion = Me.TextBoxDescripcion.Text
        Dim fechaCertificacion = Me.DateTimePickerFechaCertificacion.Value
        Dim fechaLimite = Me.DateTimePickerFechaLimite.Value

        Dim c As Certificaciones = New Certificaciones() With {
            .IdUsuario = idUsuario,
            .Institucion = institucion,
            .Descripcion = descripcion,
            .FechaCertificacion = fechaCertificacion,
            .FechaLimite = fechaLimite
        }

        Dim certificacionesValidation As CertificacionesValidation = New CertificacionesValidation() With {
            .Entity = c
        }

        Dim success = certificacionesValidation.ValidateAll()
        If Not success Then
            MessageBox.Show("Debes ingresar datos validos")
            Return
        End If

        Dim certificacionesModel As CertificacionesModel = New CertificacionesModel() With {
            .Entity = c,
            .State = CertificacionesModel.STATE_INSERT
        }

        success = certificacionesModel.ExecuteChanges()
        If Not success Then
            MessageBox.Show("Hubo un error al agregar la certificacion. Intentelo de nuevo")
            Return
        End If

        MessageBox.Show("Certificacion agregada!")
        CType(parentModule, DistincionesModule).FillCertificacionesData()

        ReturnControl()
    End Sub

    Public Overrides Sub Edit()
        Dim idUsuario = mainForm.usuario.IdUsuario
        Dim institucion = Me.TextBoxInstitucion.Text
        Dim descripcion = Me.TextBoxDescripcion.Text
        Dim fechaCertificacion = Me.DateTimePickerFechaCertificacion.Value
        Dim fechaLimite = Me.DateTimePickerFechaLimite.Value

        Dim c As Certificaciones = New Certificaciones() With {
            .IdUsuario = idUsuario,
            .Institucion = institucion,
            .Descripcion = descripcion,
            .FechaCertificacion = fechaCertificacion,
            .FechaLimite = fechaLimite
        }

        Dim certificacionesValidation As CertificacionesValidation = New CertificacionesValidation() With {
            .Entity = c
        }

        Dim success = certificacionesValidation.ValidateAll()
        If Not success Then
            MessageBox.Show("Debes ingresar datos validos")
            Return
        End If

        Dim dataGridView As DataGridView = CType(parentModule, DistincionesModule).DataGridViewCertificaciones

        Dim selectedRow As DataGridViewRow = dataGridView.SelectedRows(0)
        If selectedRow Is Nothing Then
            MessageBox.Show("Ocurrio un error al intentar obtener la certificacion a editar")
            ReturnControl()
        End If

        c = New Certificaciones() With {
            .IdUsuario = idUsuario,
            .Institucion = selectedRow.Cells("Institucion").Value.ToString(),
            .Descripcion = selectedRow.Cells("Descripcion").Value.ToString(),
            .FechaCertificacion = DateTime.Parse(selectedRow.Cells("FechaCertificacion").Value.ToString()),
            .FechaLimite = DateTime.Parse(selectedRow.Cells("FechaLimite").Value.ToString())
        }

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        Dim certificacionesModel As CertificacionesModel = New CertificacionesModel() With {
            .Entity = c,
            .State = CertificacionesModel.STATE_DELETE_SPECIFIC
        }

        success = certificacionesModel.ExecuteChanges()
        If Not success Then
            MessageBox.Show("Ocurrio un error al hacer la edicion. La certificacion ha sido eliminado")
            Return
        End If

        c = New Certificaciones() With {
            .IdUsuario = idUsuario,
            .Institucion = institucion,
            .Descripcion = descripcion,
            .FechaCertificacion = fechaCertificacion,
            .FechaLimite = fechaLimite
        }

        certificacionesModel = New CertificacionesModel() With {
            .Entity = c,
            .State = CertificacionesModel.STATE_INSERT
        }

        success = certificacionesModel.ExecuteChanges()
        If Not success Then
            MessageBox.Show("Hubo un error al editar la certificacion. Intentelo de nuevo")
            Return
        End If

        MessageBox.Show("Certificacion editada!")
        CType(parentModule, DistincionesModule).FillCertificacionesData()

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