Imports Entities
Imports Logic

Public Class ProductosDeInvestigacionDialog
    Inherits CustomDialog

    Public Sub New(mainForm As MainForm, parentModule As ProductividadAcademicaModule, operation As Integer)
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
        Dim dataGridView As DataGridView = CType(parentModule, ProductividadAcademicaModule).DataGridViewProductos

        Dim selectedRow As DataGridViewRow = dataGridView.SelectedRows(0)
        If selectedRow Is Nothing Then
            MessageBox.Show("Ocurrio un error al intentar obtener la estancia a editar")
            ReturnControl()
        End If

        Me.TextBoxTitulo.Text = selectedRow.Cells("Titulo").Value.ToString()
        Me.TextBoxProposito.Text = selectedRow.Cells("Proposito").Value.ToString()
        Me.DateTimePickerFechaPublicacion.Value = DateTime.Parse(selectedRow.Cells("FechaPublicacion").Value.ToString())
        Me.TextBoxTipoProducto.Text = selectedRow.Cells("TipoProducto").Value.ToString()
    End Sub

    Public Overrides Sub Add()
        Dim idUsuario = mainForm.usuario.IdUsuario
        Dim titulo = Me.TextBoxTitulo.Text
        Dim proposito = Me.TextBoxProposito.Text
        Dim fecha = Me.DateTimePickerFechaPublicacion.Value
        Dim tipoProducto = Me.TextBoxTipoProducto.Text

        Dim p As ProductosDeInvestigacion = New ProductosDeInvestigacion() With {
            .IdUsuario = idUsuario,
            .Titulo = titulo,
            .Proposito = proposito,
            .FechaPublicacion = fecha,
            .TipoProducto = tipoProducto
        }

        Dim productosValidation As ProductosDeInvestigacionValidation = New ProductosDeInvestigacionValidation() With {
            .Entity = p
        }

        Dim success = productosValidation.ValidateAll()
        If Not success Then
            MessageBox.Show("Debes ingresar datos validos")
            Return
        End If

        Dim productosModel As ProductosDeInvestigacionModel = New ProductosDeInvestigacionModel() With {
            .Entity = p,
            .State = ProductosDeInvestigacionModel.STATE_INSERT
        }

        success = productosModel.ExecuteChanges()
        If Not success Then
            MessageBox.Show("Hubo un error al agregar el producto. Intentelo de nuevo")
            Return
        End If

        MessageBox.Show("Producto agregado!")
        CType(parentModule, ProductividadAcademicaModule).FillProductosData()

        ReturnControl()
    End Sub

    Public Overrides Sub Edit()
        Dim idUsuario = mainForm.usuario.IdUsuario
        Dim titulo = Me.TextBoxTitulo.Text
        Dim proposito = Me.TextBoxProposito.Text
        Dim fecha = Me.DateTimePickerFechaPublicacion.Value
        Dim tipoProducto = Me.TextBoxTipoProducto.Text

        Dim p As ProductosDeInvestigacion = New ProductosDeInvestigacion() With {
            .IdUsuario = idUsuario,
            .Titulo = titulo,
            .Proposito = proposito,
            .FechaPublicacion = fecha,
            .TipoProducto = tipoProducto
        }

        Dim productosValidation As ProductosDeInvestigacionValidation = New ProductosDeInvestigacionValidation() With {
            .Entity = p
        }

        Dim success = productosValidation.ValidateAll()
        If Not success Then
            MessageBox.Show("Debes ingresar datos validos")
            Return
        End If

        Dim dataGridView As DataGridView = CType(parentModule, ProductividadAcademicaModule).DataGridViewProductos

        Dim selectedRow As DataGridViewRow = dataGridView.SelectedRows(0)
        If selectedRow Is Nothing Then
            MessageBox.Show("Ocurrio un error al intentar obtener el producto a editar")
            ReturnControl()
        End If

        p = New ProductosDeInvestigacion() With {
            .IdUsuario = idUsuario,
            .Titulo = selectedRow.Cells("Titulo").Value.ToString(),
            .Proposito = selectedRow.Cells("Proposito").Value.ToString(),
            .FechaPublicacion = DateTime.Parse(selectedRow.Cells("FechaPublicacion").Value.ToString()),
            .TipoProducto = selectedRow.Cells("TipoProducto").Value.ToString()
        }

        Dim productosModel As ProductosDeInvestigacionModel = New ProductosDeInvestigacionModel() With {
            .Entity = p,
            .State = ProductosDeInvestigacionModel.STATE_DELETE_SPECIFIC
        }

        success = productosModel.ExecuteChanges()
        If Not success Then
            MessageBox.Show("Ocurrio un error al hacer la edicion. El producto ha sido eliminado")
            Return
        End If

        p = New ProductosDeInvestigacion() With {
            .IdUsuario = idUsuario,
            .Titulo = titulo,
            .Proposito = proposito,
            .FechaPublicacion = fecha,
            .TipoProducto = tipoProducto
        }

        productosModel = New ProductosDeInvestigacionModel() With {
            .Entity = p,
            .State = ProductosDeInvestigacionModel.STATE_INSERT
        }

        success = productosModel.ExecuteChanges()
        If Not success Then
            MessageBox.Show("Hubo un error al agregar el producto. Intentelo de nuevo")
            Return
        End If

        MessageBox.Show("Producto editado!")
        CType(parentModule, ProductividadAcademicaModule).FillProductosData()

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
