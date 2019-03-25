Imports Entities
Imports Logic

Public Class ResumenDatosLaboralesModule

    Public mainForm As MainForm

    Public Sub FillData()
        FillDataTecNM()
        FillDataExternas()
    End Sub

    Public Sub ClearData()
        Me.FlowLayoutPanelExternas.Controls.Clear()
        Me.FlowLayoutPanelTecNM.Controls.Clear()
    End Sub

    Public Sub FillDataTecNM()
        Dim idUsuario = mainForm.usuario.IdUsuario

        Dim tecnmModel As AdscripcionTecNMModel = New AdscripcionTecNMModel() With {
            .Entity = New AdscripcionTecNM() With {
                .IdUsuario = idUsuario
            }
        }

        Dim tecnm As List(Of AdscripcionTecNM) = tecnmModel.GetEntitiesWithId()

        For Each a As AdscripcionTecNM In tecnm
            Dim label As Label = New Label() With {
                .AutoSize = True,
                .Text = String.Format("{0}, {1}", a.Plantel, a.FechaAdscripcion.ToShortDateString),
                .Font = New Font("Corbel", 12)
            }
            Me.FlowLayoutPanelTecNM.Controls.Add(label)
        Next
    End Sub

    Public Sub FillDataExternas()
        Dim idUsuario = mainForm.usuario.IdUsuario

        Dim externasModel As AdscripcionExternaModel = New AdscripcionExternaModel() With {
            .Entity = New AdscripcionExterna() With {
                .IdUsuario = idUsuario
            }
        }

        Dim externas As List(Of AdscripcionExterna) = externasModel.GetEntitiesWithId()

        For Each a As AdscripcionExterna In externas
            Dim label As Label = New Label() With {
                .AutoSize = True,
                .Text = String.Format("{0}, {1}, {2}", a.Institucion, a.Puesto, a.FechaNombramiento),
                .Font = New Font("Corbel", 12)
            }
            Me.FlowLayoutPanelExternas.Controls.Add(label)
        Next
    End Sub

End Class
