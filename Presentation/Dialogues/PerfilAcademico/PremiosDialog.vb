Imports Entities
Imports Logic

Public Class PremiosDialog
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
        Dim dataGridView As DataGridView = CType(parentModule, DistincionesModule).DataGridViewPremios

        Dim selectedRow As DataGridViewRow = dataGridView.SelectedRows(0)
        If selectedRow Is Nothing Then
            MessageBox.Show("Ocurrio un error al intentar obtener el premio a editar")
            ReturnControl()
        End If

        Me.TextBoxInstitucion.Text = selectedRow.Cells("Institucion").Value.ToString()
        Me.TextBoxDescripcion.Text = selectedRow.Cells("Descripcion").Value.ToString()
        Me.DateTimePickerFechaCertificacion.Value = DateTime.Parse(selectedRow.Cells("FechaCertificacion").Value.ToString())
    End Sub

    Public Overrides Sub Add()
        Dim idUsuario = mainForm.usuario.IdUsuario
        Dim institucion = Me.TextBoxInstitucion.Text
        Dim descripcion = Me.TextBoxDescripcion.Text
        Dim fecha = Me.DateTimePickerFechaCertificacion.Value

        Dim p As Premios = New Premios() With {
            .IdUsuario = idUsuario,
            .Institucion = institucion,
            .Descripcion = descripcion,
            .FechaCertificacion = fecha
        }

        Dim premiosValidation As PremiosValidation = New PremiosValidation() With {
            .Entity = p
        }

        Dim success = premiosValidation.ValidateAll()
        If Not success Then
            MessageBox.Show("Debes ingresar datos validos")
            Return
        End If

        Dim premiosModel As PremiosModel = New PremiosModel() With {
            .Entity = p,
            .State = PremiosModel.STATE_INSERT
        }

        success = premiosModel.ExecuteChanges()
        If Not success Then
            MessageBox.Show("Hubo un error al agregar el premio. Intentelo de nuevo")
            Return
        End If

        MessageBox.Show("Titulo agregado!")
        CType(parentModule, DistincionesModule).FillPremiosData()

        ReturnControl()
    End Sub

    Public Overrides Sub Edit()
        Dim idUsuario = mainForm.usuario.IdUsuario
        Dim institucion = Me.TextBoxInstitucion.Text
        Dim descripcion = Me.TextBoxDescripcion.Text
        Dim fecha = Me.DateTimePickerFechaCertificacion.Value

        Dim p As Premios = New Premios() With {
            .IdUsuario = idUsuario,
            .Institucion = institucion,
            .Descripcion = descripcion,
            .FechaCertificacion = fecha
        }

        Dim premiosValidation As PremiosValidation = New PremiosValidation() With {
            .Entity = p
        }

        Dim success = premiosValidation.ValidateAll()
        If Not success Then
            MessageBox.Show("Debes ingresar datos validos")
            Return
        End If

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        Dim dataGridView As DataGridView = CType(parentModule, DistincionesModule).DataGridViewPremios

        Dim selectedRow As DataGridViewRow = dataGridView.SelectedRows(0)
        If selectedRow Is Nothing Then
            MessageBox.Show("Ocurrio un error al intentar obtener el premio a editar")
            ReturnControl()
        End If

        p = New Premios() With {
            .IdUsuario = idUsuario,
            .Institucion = selectedRow.Cells("Institucion").Value.ToString(),
            .Descripcion = selectedRow.Cells("Descripcion").Value.ToString(),
            .FechaCertificacion = DateTime.Parse(selectedRow.Cells("FechaCertificacion").Value.ToString())
        }

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        Dim premiosModel As PremiosModel = New PremiosModel() With {
            .Entity = p,
            .State = PremiosModel.STATE_DELETE_SPECIFIC
        }

        success = premiosModel.ExecuteChanges()
        If Not success Then
            MessageBox.Show("Ocurrio un error al hacer la edicion. El premio ha sido eliminado")
            Return
        End If

        p = New Premios() With {
            .IdUsuario = idUsuario,
            .Institucion = institucion,
            .Descripcion = descripcion,
            .FechaCertificacion = fecha
        }

        premiosModel = New PremiosModel() With {
            .Entity = p,
            .State = PremiosModel.STATE_INSERT
        }

        success = premiosModel.ExecuteChanges()
        If Not success Then
            MessageBox.Show("Hubo un error al agregar el premio. Intentelo de nuevo")
            Return
        End If

        MessageBox.Show("Premio editado!")
        CType(parentModule, DistincionesModule).FillPremiosData()

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