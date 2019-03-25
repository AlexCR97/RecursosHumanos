Imports Entities
Imports Logic

Public Class AsociacionesDialog
    Inherits CustomDialog

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(mainForm As MainForm, parentModule As AsociacionesModule, operation As Integer)
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
        Dim dataGridView As DataGridView = CType(parentModule, AsociacionesModule).DataGridViewAsociaciones

        Dim selectedRow As DataGridViewRow = dataGridView.SelectedRows(0)
        If selectedRow Is Nothing Then
            MessageBox.Show("Ocurrio un error al intentar obtener la asociacion a editar")
            ReturnControl()
        End If

        Me.TextBoxOrganismo.Text = selectedRow.Cells("Organismo").Value.ToString()
        Me.TextBoxNombramiento.Text = selectedRow.Cells("Nombramiento").Value.ToString()
        Me.DateTimePickerAñoAfiliacion.Value = DateTime.Parse(selectedRow.Cells("AnioAfiliacion").Value.ToString())
        Me.DateTimePickerInicioVigencia.Value = DateTime.Parse(selectedRow.Cells("InicioVigencia").Value.ToString())
        Me.DateTimePickerFinVigencia.Value = DateTime.Parse(selectedRow.Cells("FinVigencia").Value.ToString())
    End Sub

    Public Overrides Sub Add()
        Dim idUsuario = mainForm.usuario.IdUsuario
        Dim organismo = Me.TextBoxOrganismo.Text
        Dim nombramiento = Me.TextBoxNombramiento.Text
        Dim anio = Me.DateTimePickerAñoAfiliacion.Value
        Dim inicio = Me.DateTimePickerInicioVigencia.Value
        Dim fin = Me.DateTimePickerFinVigencia.Value

        Dim a As Asociaciones = New Asociaciones() With {
            .IdUsuario = idUsuario,
            .Organismo = organismo,
            .Nombramiento = nombramiento,
            .AnioAfiliacion = anio,
            .InicioVigencia = inicio,
            .FinVigencia = fin
        }

        Dim asociacionesValidation As AsociacionesValidation = New AsociacionesValidation() With {
            .Entity = a
        }

        Dim success = asociacionesValidation.ValidateAll()
        If Not success Then
            MessageBox.Show("Debes ingresar datos validos")
            Return
        End If

        Dim asociacionesModel As AsociacionesModel = New AsociacionesModel() With {
            .Entity = a,
            .State = AsociacionesModel.STATE_INSERT
        }

        success = asociacionesModel.ExecuteChanges()
        If Not success Then
            MessageBox.Show("Hubo un error al agregar el colegio. Intentelo de nuevo")
            Return
        End If

        MessageBox.Show("Asociacion agregado!")
        CType(parentModule, AsociacionesModule).FillData()

        ReturnControl()
    End Sub

    Public Overrides Sub Edit()
        Dim idUsuario = mainForm.usuario.IdUsuario
        Dim organismo = Me.TextBoxOrganismo.Text
        Dim nombramiento = Me.TextBoxNombramiento.Text
        Dim anio = Me.DateTimePickerAñoAfiliacion.Value
        Dim inicio = Me.DateTimePickerInicioVigencia.Value
        Dim fin = Me.DateTimePickerFinVigencia.Value

        Dim a As Asociaciones = New Asociaciones() With {
            .IdUsuario = idUsuario,
            .Organismo = organismo,
            .Nombramiento = nombramiento,
            .AnioAfiliacion = anio,
            .InicioVigencia = inicio,
            .FinVigencia = fin
        }

        Dim asociacionesValidation As AsociacionesValidation = New AsociacionesValidation() With {
            .Entity = a
        }

        Dim success = asociacionesValidation.ValidateAll()
        If Not success Then
            MessageBox.Show("Debes ingresar datos validos")
            Return
        End If

        Dim dataGridView As DataGridView = CType(parentModule, AsociacionesModule).DataGridViewAsociaciones

        Dim selectedRow As DataGridViewRow = dataGridView.SelectedRows(0)
        If selectedRow Is Nothing Then
            MessageBox.Show("Ocurrio un error al intentar obtener la asociacion a editar")
            ReturnControl()
        End If

        a = New Asociaciones() With {
            .IdUsuario = idUsuario,
            .Organismo = selectedRow.Cells("Organismo").Value.ToString(),
            .Nombramiento = selectedRow.Cells("Nombramiento").Value.ToString(),
            .AnioAfiliacion = DateTime.Parse(selectedRow.Cells("AnioAfiliacion").Value.ToString()),
            .InicioVigencia = DateTime.Parse(selectedRow.Cells("InicioVigencia").Value.ToString()),
            .FinVigencia = DateTime.Parse(selectedRow.Cells("FinVigencia").Value.ToString())
        }

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        Dim asociacionesModel As AsociacionesModel = New AsociacionesModel() With {
            .Entity = a,
            .State = AsociacionesModel.STATE_DELETE_SPECIFIC
        }

        success = asociacionesModel.ExecuteChanges()
        If Not success Then
            MessageBox.Show("Ocurrio un error al hacer la edicion. La asociacion ha sido eliminado")
            Return
        End If

        a = New Asociaciones() With {
            .IdUsuario = idUsuario,
            .Organismo = organismo,
            .Nombramiento = nombramiento,
            .AnioAfiliacion = anio,
            .InicioVigencia = inicio,
            .FinVigencia = fin
        }

        asociacionesModel = New AsociacionesModel() With {
            .Entity = a,
            .State = AsociacionesModel.STATE_INSERT
        }

        success = asociacionesModel.ExecuteChanges()
        If Not success Then
            MessageBox.Show("Hubo un error al agregar la asociacion. Intentelo de nuevo")
            Return
        End If

        MessageBox.Show("Asociacion editada!")
        CType(parentModule, AsociacionesModule).FillData()

        ReturnControl()
    End Sub

    Private Sub GuardarButton1_Click_1(sender As Object, e As EventArgs) Handles GuardarButton1.Click
        Select Case operation
            Case OPERATION_ADD
                Add()
            Case OPERATION_EDIT
                Edit()
        End Select
    End Sub

    Private Sub CancelarButton1_Click_1(sender As Object, e As EventArgs) Handles CancelarButton1.Click
        ReturnControl()
    End Sub
End Class