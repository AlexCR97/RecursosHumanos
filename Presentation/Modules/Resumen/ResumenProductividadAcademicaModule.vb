Imports Entities
Imports Logic

Public Class ResumenProductividadAcademicaModule

    Public mainForm As MainForm

    Public Sub FillData()
        FillDataEstancias()
        FillDataProductos()
    End Sub

    Public Sub ClearData()
        Me.FlowLayoutPanelEstancias.Controls.Clear()
        Me.FlowLayoutPanelProductos.Controls.Clear()
    End Sub

    Public Sub FillDataEstancias()
        Dim idUsuario = mainForm.usuario.IdUsuario

        Dim model As EstanciasModel = New EstanciasModel() With {
            .Entity = New Estancias() With {
                .IdUsuario = idUsuario
            }
        }

        Dim entities As List(Of Estancias) = model.GetEntitiesWithId()

        For Each e As Estancias In entities
            Dim label As Label = New Label() With {
                .AutoSize = True,
                .Text = String.Format("{0}, {1}, {2} - {3}", e.NombreProyecto, e.Institucion, e.FechaInicio.ToShortDateString(), e.FechaTermino.ToShortDateString()),
                .Font = New Font("Corbel", 12)
            }
            Me.FlowLayoutPanelEstancias.Controls.Add(label)
        Next
    End Sub

    Public Sub FillDataProductos()
        Dim idUsuario = mainForm.usuario.IdUsuario

        Dim model As ProductosDeInvestigacionModel = New ProductosDeInvestigacionModel() With {
            .Entity = New ProductosDeInvestigacion() With {
                .IdUsuario = idUsuario
            }
        }

        Dim entities As List(Of ProductosDeInvestigacion) = model.GetEntitiesWithId()

        For Each e As ProductosDeInvestigacion In entities
            Dim label As Label = New Label() With {
                .AutoSize = True,
                .Text = String.Format("{0}, {1}, {2}", e.Titulo, e.TipoProducto, e.FechaPublicacion.ToShortDateString()),
                .Font = New Font("Corbel", 12)
            }
            Me.FlowLayoutPanelProductos.Controls.Add(label)
        Next
    End Sub

End Class
