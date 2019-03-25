Imports Entities
Imports Logic

Public Class ProductividadAcademicaModule

    Private mainForm As MainForm

    Public Sub New(mainForm As MainForm)
        InitializeComponent()

        Me.mainForm = mainForm

        FillData()
    End Sub

    Public Sub FillData()
        FillEstanciasData()
        FillProductosData()
    End Sub

    Public Sub FillEstanciasData()
        Dim idUsuario = mainForm.usuario.IdUsuario
        Dim estanciasModel As EstanciasModel = New EstanciasModel With {
            .Entity = New Estancias With {
                .IdUsuario = idUsuario
            }
        }

        Dim estancias As List(Of Estancias) = estanciasModel.GetEntitiesWithId()

        Me.DataGridViewEstancias.DataSource = estancias
        mainForm.UpdateResumenModule()
    End Sub

    Public Sub FillProductosData()
        Dim idUsuario = mainForm.usuario.IdUsuario
        Dim productosModel As ProductosDeInvestigacionModel = New ProductosDeInvestigacionModel With {
            .Entity = New ProductosDeInvestigacion With {
                .IdUsuario = idUsuario
            }
        }

        Dim productos As List(Of ProductosDeInvestigacion) = productosModel.GetEntitiesWithId()

        Me.DataGridViewProductos.DataSource = productos
        mainForm.UpdateResumenModule()
    End Sub

    Private Sub AgregarButtonEstancias_Click(sender As Object, e As EventArgs) Handles AgregarButtonEstancias.Click
        Dim dialog As EstanciasDialog = New EstanciasDialog(mainForm, Me, EstanciasDialog.OPERATION_ADD)
        dialog.Show(Me)
    End Sub

    Private Sub EditarButtonEstancias_Click(sender As Object, e As EventArgs) Handles EditarButtonEstancias.Click
        Dim dialog As EstanciasDialog = New EstanciasDialog(mainForm, Me, EstanciasDialog.OPERATION_EDIT)
        dialog.Show(Me)
    End Sub

    Private Sub EliminarButtonEstancias_Click(sender As Object, e As EventArgs) Handles EliminarButtonEstancias.Click
        Dim result As DialogResult = MessageBox.Show(
            "Estas seguro de que quieres eliminar la estancia seleccionada?", "",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Exclamation
        )

        If Not result = DialogResult.Yes Then
            Return
        End If

        Dim selectedRow As DataGridViewRow = Me.DataGridViewEstancias.SelectedRows(0)
        If selectedRow Is Nothing Then
            Return
        End If

        Dim es As Estancias = New Estancias() With {
            .IdUsuario = selectedRow.Cells("IdUsuario").Value.ToString(),
            .Institucion = selectedRow.Cells("Institucion").Value.ToString(),
            .NombreProyecto = selectedRow.Cells("NombreProyecto").Value.ToString(),
            .FechaInicio = DateTime.Parse(selectedRow.Cells("FechaInicio").Value.ToString()),
            .FechaTermino = DateTime.Parse(selectedRow.Cells("FechaTermino").Value.ToString())
        }

        Dim estanciasModel As EstanciasModel = New EstanciasModel() With {
            .Entity = es,
            .State = EstanciasModel.STATE_DELETE_SPECIFIC
        }

        Dim success = estanciasModel.ExecuteChanges()
        If Not success Then
            MessageBox.Show("No se pudo eliminar la estancia. Intentelo de nuevo")
            Return
        End If

        MessageBox.Show("Estancia eliminada!")
        FillEstanciasData()
    End Sub

    Private Sub AgregarButtonProductosInvestigacion_Click(sender As Object, e As EventArgs) Handles AgregarButtonProductosInvestigacion.Click
        Dim dialog As ProductosDeInvestigacionDialog = New ProductosDeInvestigacionDialog(mainForm, Me, ProductosDeInvestigacionDialog.OPERATION_ADD)
        dialog.Show(Me)
    End Sub

    Private Sub EditarButtonProductosInvestigacion_Click(sender As Object, e As EventArgs) Handles EditarButtonProductosInvestigacion.Click
        Dim dialog As ProductosDeInvestigacionDialog = New ProductosDeInvestigacionDialog(mainForm, Me, ProductosDeInvestigacionDialog.OPERATION_EDIT)
        dialog.Show(Me)
    End Sub

    Private Sub EliminarButtonProductosInvestigacion_Click(sender As Object, e As EventArgs) Handles EliminarButtonProductosInvestigacion.Click
        Dim result As DialogResult = MessageBox.Show(
            "Estas seguro de que quieres eliminar el producto seleccionado?", "",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Exclamation
        )

        If Not result = DialogResult.Yes Then
            Return
        End If

        Dim selectedRow As DataGridViewRow = Me.DataGridViewProductos.SelectedRows(0)
        If selectedRow Is Nothing Then
            Return
        End If

        Dim p As ProductosDeInvestigacion = New ProductosDeInvestigacion() With {
            .IdUsuario = selectedRow.Cells("IdUsuario").Value.ToString(),
            .Titulo = selectedRow.Cells("Titulo").Value.ToString(),
            .Proposito = selectedRow.Cells("Proposito").Value.ToString(),
            .FechaPublicacion = DateTime.Parse(selectedRow.Cells("FechaPublicacion").Value.ToString()),
            .TipoProducto = selectedRow.Cells("TipoProducto").Value.ToString()
        }

        Dim productoModel As ProductosDeInvestigacionModel = New ProductosDeInvestigacionModel() With {
            .Entity = p,
            .State = ProductosDeInvestigacionModel.STATE_DELETE_SPECIFIC
        }

        Dim success = productoModel.ExecuteChanges()
        If Not success Then
            MessageBox.Show("No se pudo eliminar el producto. Intentelo de nuevo")
            Return
        End If

        MessageBox.Show("Producto eliminado!")
        FillProductosData()
    End Sub
End Class
