Imports Entities
Imports Logic

Public Class OtrosMediosDialog
    Inherits CustomDialog

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(mainForm As MainForm, parentModule As DatosDeContactoModule, operation As Integer)
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
        Dim dataGridViewOtrosMedios As DataGridView = CType(parentModule, DatosDeContactoModule).DataGridViewOtrosMedios

        Dim selectedRow As DataGridViewRow = dataGridViewOtrosMedios.SelectedRows(0)
        If selectedRow Is Nothing Then
            MessageBox.Show("Ocurrio un error al intentar obtener el medio a editar")
            ReturnControl()
        End If

        Me.TextBoxMedio.Text = selectedRow.Cells("Medio").Value.ToString()
        Me.TextBoxDescripcion.Text = selectedRow.Cells("Descripcion").Value.ToString()
    End Sub

    Public Overrides Sub Add()
        Dim idUsuario = mainForm.usuario.IdUsuario
        Dim medio = Me.TextBoxMedio.Text
        Dim descripcion = Me.TextBoxDescripcion.Text

        Dim o As OtrosMediosDeContacto = New OtrosMediosDeContacto() With {
            .IdUsuario = idUsuario,
            .Medio = medio,
            .Descripcion = descripcion
        }

        Dim otrosMediosValidation As OtrosMediosDeContactoValidation = New OtrosMediosDeContactoValidation() With {
            .Entity = o
        }

        Dim success = otrosMediosValidation.ValidateAll()
        If Not success Then
            MessageBox.Show("Debes ingresar datos validos")
            Return
        End If

        Dim otrosMediosModel As OtrosMediosDeContactoModel = New OtrosMediosDeContactoModel() With {
            .Entity = o,
            .State = OtrosMediosDeContactoModel.STATE_INSERT
        }

        success = otrosMediosModel.ExecuteChanges()
        If Not success Then
            MessageBox.Show("Hubo un error al agregar el medio de contacto. Intentelo de nuevo")
            Return
        End If

        MessageBox.Show("Medio agregado!")
        CType(parentModule, DatosDeContactoModule).FillOtrosData()

        ReturnControl()
    End Sub

    Public Overrides Sub Edit()
        Dim idUsuario = mainForm.usuario.IdUsuario
        Dim medio = Me.TextBoxMedio.Text
        Dim descripcion = Me.TextBoxDescripcion.Text

        Dim o As OtrosMediosDeContacto = New OtrosMediosDeContacto() With {
            .IdUsuario = idUsuario,
            .Medio = medio,
            .Descripcion = descripcion
        }

        Dim otrosMediosValidation As OtrosMediosDeContactoValidation = New OtrosMediosDeContactoValidation() With {
            .Entity = o
        }

        Dim success = otrosMediosValidation.ValidateAll()
        If Not success Then
            MessageBox.Show("Debes ingresar datos validos")
            Return
        End If

        Dim dataGridViewOtrosMedios As DataGridView = CType(parentModule, DatosDeContactoModule).DataGridViewOtrosMedios

        Dim selectedRow As DataGridViewRow = dataGridViewOtrosMedios.SelectedRows(0)
        If selectedRow Is Nothing Then
            MessageBox.Show("Ocurrio un error al intentar obtener el medio a editar")
            Return
        End If

        o = New OtrosMediosDeContacto() With {
            .IdUsuario = selectedRow.Cells("IdUsuario").Value.ToString(),
            .Medio = selectedRow.Cells("Medio").Value.ToString(),
            .Descripcion = selectedRow.Cells("Descripcion").Value.ToString()
        }

        Dim otrosMediosModel As OtrosMediosDeContactoModel = New OtrosMediosDeContactoModel() With {
            .Entity = o,
            .State = OtrosMediosDeContactoModel.STATE_DELETE_SPECIFIC
        }

        success = otrosMediosModel.ExecuteChanges()
        If Not success Then
            MessageBox.Show("Ocurrio un error al hacer la edicion. El medio ha sido eliminado")
            Return
        End If

        o = New OtrosMediosDeContacto() With {
            .IdUsuario = idUsuario,
            .Medio = medio,
            .Descripcion = descripcion
        }

        otrosMediosModel = New OtrosMediosDeContactoModel() With {
            .Entity = o,
            .State = OtrosMediosDeContactoModel.STATE_INSERT
        }

        success = otrosMediosModel.ExecuteChanges()
        If Not success Then
            MessageBox.Show("Hubo un error al agregar el medio de contacto. Intentelo de nuevo")
            Return
        End If

        MessageBox.Show("Medio editado!")
        CType(parentModule, DatosDeContactoModule).FillOtrosData()

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