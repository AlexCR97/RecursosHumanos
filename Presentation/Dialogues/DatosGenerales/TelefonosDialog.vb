Imports Entities
Imports Logic

Public Class TelefonosDialog
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

        Dim telefono = Me.TextBoxTelefono.Text

        Dim t As Telefonos = New Telefonos() With {
            .IdUsuario = idUsuario,
            .Telefono = telefono
        }

        Dim telefonosValidation As TelefonosValidation = New TelefonosValidation() With {
            .Entity = t
        }

        Dim success = telefonosValidation.ValidateAll()
        If Not success Then
            MessageBox.Show("Debes ingresar un telefono valido")
            Return
        End If

        Dim telefonosModel As TelefonosModel = New TelefonosModel With {
            .Entity = t,
            .State = TelefonosModel.STATE_INSERT
        }

        success = telefonosModel.ExecuteChanges()
        If Not success Then
            MessageBox.Show("Hubo un error al agregar el telefono. Intentelo de nuevo")
            Return
        End If

        MessageBox.Show("Telefono agregado!")
        CType(parentModule, DatosDeContactoModule).FillTelefonosData()

        ReturnControl()
    End Sub

    Private Sub GuardarButton1_Click(sender As Object, e As EventArgs) Handles GuardarButton1.Click
        Add()
    End Sub

    Private Sub CancelarButton1_Click(sender As Object, e As EventArgs) Handles CancelarButton1.Click
        ReturnControl()
    End Sub

End Class
