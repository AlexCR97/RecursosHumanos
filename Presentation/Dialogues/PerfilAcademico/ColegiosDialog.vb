Imports Entities
Imports Logic

Public Class ColegiosDialog
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
        Dim dataGridView As DataGridView = CType(parentModule, DistincionesModule).DataGridViewColegios

        Dim selectedRow As DataGridViewRow = dataGridView.SelectedRows(0)
        If selectedRow Is Nothing Then
            MessageBox.Show("Ocurrio un error al intentar obtener el colegio a editar")
            ReturnControl()
        End If

        Me.TextBoxNombramiento.Text = selectedRow.Cells("Nombramiento").Value.ToString()
        Me.TextBoxColegio.Text = selectedRow.Cells("Colegio").Value.ToString()
        Me.TextBoxAfiliacion.Text = selectedRow.Cells("Afiliacion").Value.ToString()
    End Sub

    Public Overrides Sub Add()
        Dim idUsuario = mainForm.usuario.IdUsuario
        Dim nombramiento = Me.TextBoxNombramiento.Text
        Dim colegio = Me.TextBoxColegio.Text
        Dim afiliacion = Me.TextBoxAfiliacion.Text

        Dim c As Colegios = New Colegios() With {
            .IdUsuario = idUsuario,
            .Nombramiento = nombramiento,
            .Colegio = colegio,
            .Afiliacion = afiliacion
        }

        Dim colegiosValidation As ColegiosValidation = New ColegiosValidation() With {
            .Entity = c
        }

        Dim success = colegiosValidation.ValidateAll()
        If Not success Then
            MessageBox.Show("Debes ingresar datos validos")
            Return
        End If

        Dim colegiosModel As ColegiosModel = New ColegiosModel() With {
            .Entity = c,
            .State = ColegiosModel.STATE_INSERT
        }

        success = colegiosModel.ExecuteChanges()
        If Not success Then
            MessageBox.Show("Hubo un error al agregar el colegio. Intentelo de nuevo")
            Return
        End If

        MessageBox.Show("Colegio agregado!")
        CType(parentModule, DistincionesModule).FillColegiosData()

        ReturnControl()
    End Sub

    Public Overrides Sub Edit()
        Dim idUsuario = mainForm.usuario.IdUsuario
        Dim nombramiento = Me.TextBoxNombramiento.Text
        Dim colegio = Me.TextBoxColegio.Text
        Dim afiliacion = Me.TextBoxAfiliacion.Text

        Dim c As Colegios = New Colegios() With {
            .IdUsuario = idUsuario,
            .Nombramiento = nombramiento,
            .Colegio = colegio,
            .Afiliacion = afiliacion
        }

        Dim colegiosValidation As ColegiosValidation = New ColegiosValidation() With {
            .Entity = c
        }

        Dim success = colegiosValidation.ValidateAll()
        If Not success Then
            MessageBox.Show("Debes ingresar datos validos")
            Return
        End If

        Dim dataGridView As DataGridView = CType(parentModule, DistincionesModule).DataGridViewColegios

        Dim selectedRow As DataGridViewRow = dataGridView.SelectedRows(0)
        If selectedRow Is Nothing Then
            MessageBox.Show("Ocurrio un error al intentar obtener el colegio a editar")
            ReturnControl()
        End If

        c = New Colegios() With {
            .IdUsuario = idUsuario,
            .Nombramiento = selectedRow.Cells("Nombramiento").Value.ToString(),
            .Colegio = selectedRow.Cells("Colegio").Value.ToString(),
            .Afiliacion = selectedRow.Cells("Afiliacion").Value.ToString()
        }

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        Dim colegiosModel As ColegiosModel = New ColegiosModel() With {
            .Entity = c,
            .State = ColegiosModel.STATE_DELETE_SPECIFIC
        }

        success = colegiosModel.ExecuteChanges()
        If Not success Then
            MessageBox.Show("Ocurrio un error al hacer la edicion. El colegio ha sido eliminado")
            Return
        End If

        c = New Colegios() With {
            .IdUsuario = idUsuario,
            .Nombramiento = nombramiento,
            .Colegio = colegio,
            .Afiliacion = afiliacion
        }

        colegiosModel = New ColegiosModel() With {
            .Entity = c,
            .State = ColegiosModel.STATE_INSERT
        }

        success = colegiosModel.ExecuteChanges()
        If Not success Then
            MessageBox.Show("Hubo un error al agregar el colegio. Intentelo de nuevo")
            Return
        End If

        MessageBox.Show("Colegio editado!")
        CType(parentModule, DistincionesModule).FillColegiosData()

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