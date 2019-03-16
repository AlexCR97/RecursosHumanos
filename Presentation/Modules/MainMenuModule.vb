Public Class MainMenuModule

    Private mainForm As MainForm

    Public Sub SetMainForm(mainForm As MainForm)
        Me.mainForm = mainForm
    End Sub

    Private Sub ButtonDatosGenerales_Click(sender As Object, e As EventArgs) Handles ButtonDatosGenerales.Click
        Dim m = New DatosGeneralesModule(mainForm)
        mainForm.LoadModule(m)
    End Sub

    Private Sub ButtonPerfilAcademico_Click(sender As Object, e As EventArgs) Handles ButtonPerfilAcademico.Click
        Dim m = New PerfilAcademicoModule(mainForm)
        mainForm.LoadModule(m)
    End Sub

    Private Sub ButtonAplicaciones_Click(sender As Object, e As EventArgs) Handles ButtonAplicaciones.Click
        Dim m = New AplicacionesModule(mainForm)
        mainForm.LoadModule(m)
    End Sub

    Private Sub ButtonResumen_Click(sender As Object, e As EventArgs) Handles ButtonResumen.Click

    End Sub

End Class
