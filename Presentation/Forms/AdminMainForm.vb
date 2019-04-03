Imports Entities
Imports Logic

Public Class AdminMainForm
    Inherits CustomForm

    Private admin As Administrador

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub InitializeWithAdmin(admin As Administrador)
        Me.admin = admin
    End Sub

    Private Sub ButtonChangeLogo_Click(sender As Object, e As EventArgs) Handles ButtonChangeLogo.Click

    End Sub

    Private Sub ButtonChangeColor_Click(sender As Object, e As EventArgs) Handles ButtonChangeColor.Click
        Dim dialog As New ColorDialog()
        Dim result As DialogResult = dialog.ShowDialog()

        If Not result = DialogResult.OK Then
            Return
        End If

        Dim aplicacion As New AplicacionModel() With {
            .Entity = New Aplicacion() With {
                .ColorR = dialog.Color.R,
                .ColorG = dialog.Color.G,
                .ColorB = dialog.Color.B,
                .ColorA = dialog.Color.A
            },
            .State = AplicacionModel.STATE_UPDATE
        }

        Dim success = aplicacion.ExecuteChanges()
        If Not success Then
            MessageBox.Show("Ocurrio un error al actualizar el color")
            Return
        End If

        MessageBox.Show("Color acutalizado!")
    End Sub

    Private Sub PictureBoxSignOut_Click(sender As Object, e As EventArgs) Handles PictureBoxSignOut.Click
        Dim result = MessageBox.Show("Estas seguro de que quieres cerrar sesion?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Not result = DialogResult.Yes Then
            Return
        End If

        Application.Restart()
    End Sub
End Class
