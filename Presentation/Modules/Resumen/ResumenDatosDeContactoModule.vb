Imports Entities
Imports Logic

Public Class ResumenDatosDeContactoModule

    Public mainForm As MainForm

    Public Sub FillData()
        FillDataTelefonos()
        FillDataCorreos()
        FillDataOtros()
    End Sub

    Public Sub ClearData()
        Me.FlowLayoutPanelCorreos.Controls.Clear()
        Me.FlowLayoutPanelOtrosMedios.Controls.Clear()
        Me.FlowLayoutPanelTelefonos.Controls.Clear()
    End Sub

    Public Sub FillDataTelefonos()
        Dim idUsuario = mainForm.usuario.IdUsuario

        Dim telefonosModel As TelefonosModel = New TelefonosModel() With {
            .Entity = New Telefonos() With {
                .IdUsuario = idUsuario
            }
        }

        Dim telefonos As List(Of Telefonos) = telefonosModel.GetEntitiesWithId()

        For Each t As Telefonos In telefonos
            Dim label As Label = New Label() With {
                .AutoSize = True,
                .Text = t.Telefono,
                .Font = New Font("Corbel", 12)
            }
            Me.FlowLayoutPanelTelefonos.Controls.Add(label)
        Next
    End Sub

    Public Sub FillDataCorreos()
        Dim idUsuario = mainForm.usuario.IdUsuario

        Dim correosModel As CorreosModel = New CorreosModel() With {
            .Entity = New Correos() With {
                .IdUsuario = idUsuario
            }
        }

        Dim correos As List(Of Correos) = correosModel.GetEntitiesWithId()

        For Each c As Correos In correos
            Dim label As Label = New Label() With {
                .AutoSize = True,
                .Text = c.Correo,
                .Font = New Font("Corbel", 12)
            }
            Me.FlowLayoutPanelCorreos.Controls.Add(label)
        Next
    End Sub

    Public Sub FillDataOtros()
        Dim idUsuario = mainForm.usuario.IdUsuario

        Dim otrosModel As OtrosMediosDeContactoModel = New OtrosMediosDeContactoModel() With {
            .Entity = New OtrosMediosDeContacto() With {
                .IdUsuario = idUsuario
            }
        }

        Dim otros As List(Of OtrosMediosDeContacto) = otrosModel.GetEntitiesWithId()

        For Each o As OtrosMediosDeContacto In otros
            Dim label As Label = New Label() With {
                .AutoSize = True,
                .Text = String.Format("{0}: {1}", o.Medio, o.Descripcion),
                .Font = New Font("Corbel", 12)
            }
            Me.FlowLayoutPanelOtrosMedios.Controls.Add(label)
        Next
    End Sub

End Class
