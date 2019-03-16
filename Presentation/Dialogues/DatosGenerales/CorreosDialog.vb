Imports Entities
Imports Logic

Public Class CorreosDialog
    Inherits CustomDialog

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(mainForm As MainForm, parentModule As DatosDeContactoModule)
        MyBase.New(mainForm)
        InitializeComponent()

        Me.parentModule = parentModule
    End Sub

    Public Overrides Sub Add()
        Dim idUsuario = mainForm.usuario.IdUsuario

        Dim correo = Me.TextBoxCorreo.Text

        Dim c As Correos = New Correos() With {
            .IdUsuario = idUsuario,
            .Correo = correo
        }

        Dim correosValidation As CorreosValidation = New CorreosValidation() With {
            .Entity = c
        }

        Dim success = correosValidation.ValidateAll()
        If Not success Then
            MessageBox.Show("Debes ingresar un correo valido")
            Return
        End If

        Dim correosModel As CorreosModel = New CorreosModel() With {
            .Entity = c,
            .State = CorreosModel.STATE_INSERT
        }

        success = correosModel.ExecuteChanges()
        If Not success Then
            MessageBox.Show("Hubo un error al agregar el correo. Intentelo de nuevo")
            Return
        End If

        MessageBox.Show("Correo agregado!")
        CType(parentModule, DatosDeContactoModule).FillCorreosData()

        ReturnControl()
    End Sub

    Private Sub GuardarButton1_Click(sender As Object, e As EventArgs) Handles GuardarButton1.Click
        Add()
    End Sub

    Private Sub CancelarButton1_Click(sender As Object, e As EventArgs) Handles CancelarButton1.Click
        ReturnControl()
    End Sub
End Class
