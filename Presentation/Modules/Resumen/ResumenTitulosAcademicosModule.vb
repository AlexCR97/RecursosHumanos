Imports Entities
Imports Logic

Public Class ResumenTitulosAcademicosModule

    Public mainForm As MainForm

    Public Sub ClearData()
        Me.FlowLayoutPanelTitulos.Controls.Clear()
    End Sub

    Public Sub FillData()
        Dim idUsuario = mainForm.usuario.IdUsuario

        Dim titulosModel As TitulosAcademicosModel = New TitulosAcademicosModel() With {
            .Entity = New TitulosAcademicos() With {
                .IdUsuario = idUsuario
            }
        }

        Dim titulos As List(Of TitulosAcademicos) = titulosModel.GetEntitiesWithId()

        For Each t As TitulosAcademicos In titulos
            Dim label As Label = New Label() With {
                .AutoSize = True,
                .Text = String.Format("{0}, {1}, {2}", t.Titulo, t.Institucion, t.FechaObtencion.ToShortDateString()),
                .Font = New Font("Corbel", 12)
            }
            Me.FlowLayoutPanelTitulos.Controls.Add(label)
        Next
    End Sub

End Class
