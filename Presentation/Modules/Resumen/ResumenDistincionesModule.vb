Imports Entities
Imports Logic

Public Class ResumenDistincionesModule

    Public mainForm As MainForm

    Public Sub FillData()
        FillDataCertificaciones()
        FillDataPremios()
        FillDataColegios()
    End Sub

    Public Sub ClearData()
        Me.FlowLayoutPanelCertificaciones.Controls.Clear()
        Me.FlowLayoutPanelColegios.Controls.Clear()
        Me.FlowLayoutPanelPremios.Controls.Clear()
    End Sub

    Public Sub FillDataCertificaciones()
        Dim idUsuario = mainForm.usuario.IdUsuario

        Dim model As CertificacionesModel = New CertificacionesModel() With {
            .Entity = New Certificaciones() With {
                .IdUsuario = idUsuario
            }
        }

        Dim entities As List(Of Certificaciones) = model.GetEntitiesWithId()

        For Each e As Certificaciones In entities
            Dim label As Label = New Label() With {
                .AutoSize = True,
                .Text = String.Format("{0}, {1}, {2} - {3}", e.Descripcion, e.Institucion, e.FechaCertificacion.ToShortDateString(), e.FechaLimite.ToShortDateString()),
                .Font = New Font("Corbel", 12)
            }
            Me.FlowLayoutPanelCertificaciones.Controls.Add(label)
        Next
    End Sub

    Public Sub FillDataPremios()
        Dim idUsuario = mainForm.usuario.IdUsuario

        Dim model As PremiosModel = New PremiosModel() With {
            .Entity = New Premios() With {
                .IdUsuario = idUsuario
            }
        }

        Dim entities As List(Of Premios) = model.GetEntitiesWithId()

        For Each e As Premios In entities
            Dim label As Label = New Label() With {
                .AutoSize = True,
                .Text = String.Format("{0}, {1}, {2}", e.Descripcion, e.Institucion, e.FechaCertificacion.ToShortDateString()),
                .Font = New Font("Corbel", 12)
            }
            Me.FlowLayoutPanelPremios.Controls.Add(label)
        Next
    End Sub

    Public Sub FillDataColegios()
        Dim idUsuario = mainForm.usuario.IdUsuario

        Dim model As ColegiosModel = New ColegiosModel() With {
            .Entity = New Colegios() With {
                .IdUsuario = idUsuario
            }
        }

        Dim entities As List(Of Colegios) = model.GetEntitiesWithId()

        For Each e As Colegios In entities
            Dim label As Label = New Label() With {
                .AutoSize = True,
                .Text = String.Format("{0}, {1}, {2}", e.Nombramiento, e.Colegio, e.Afiliacion),
                .Font = New Font("Corbel", 12)
            }
            Me.FlowLayoutPanelColegios.Controls.Add(label)
        Next
    End Sub

End Class
