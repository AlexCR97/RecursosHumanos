Imports Entities
Imports Logic

Public Class ResumenAsociacionesModule

    Public mainForm As MainForm

    Public Sub ClearData()
        Me.FlowLayoutPanelAsociaciones.Controls.Clear()
    End Sub

    Public Sub FillData()
        Dim idUsuario = mainForm.usuario.IdUsuario

        Dim model As AsociacionesModel = New AsociacionesModel() With {
            .Entity = New Asociaciones() With {
                .IdUsuario = idUsuario
            }
        }

        Dim entities As List(Of Asociaciones) = model.GetEntitiesWithId()

        For Each e As Asociaciones In entities
            Dim label As Label = New Label() With {
                .AutoSize = True,
                .Text = String.Format("{0}, {1}, {2} - {3}", e.Nombramiento, e.Organismo, e.InicioVigencia.ToShortDateString(), e.FinVigencia.ToShortDateString()),
                .Font = New Font("Corbel", 12)
            }
            Me.FlowLayoutPanelAsociaciones.Controls.Add(label)
        Next
    End Sub

End Class
