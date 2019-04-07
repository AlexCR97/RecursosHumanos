Public Class MainMenuModule

    Private mainForm As MainForm

    Public Sub New()
        InitializeComponent()

        Me.ButtonDatosGenerales.BackColor = My.Settings.MainColor
        Me.ButtonPerfilAcademico.BackColor = My.Settings.MainColor
        Me.ButtonResumen.BackColor = My.Settings.MainColor
    End Sub

    Public Sub SetMainForm(mainForm As MainForm)
        Me.mainForm = mainForm
    End Sub

    Private Sub ButtonDatosGenerales_Click(sender As Object, e As EventArgs) Handles ButtonDatosGenerales.Click
        Dim m = New DatosGeneralesModule(mainForm)
        mainForm.LoadModule(m)
        mainForm.SetContentTitle(MainForm.TITLE_DATOS_GENERALES)
    End Sub

    Private Sub ButtonPerfilAcademico_Click(sender As Object, e As EventArgs) Handles ButtonPerfilAcademico.Click
        Dim m = New PerfilAcademicoModule(mainForm)
        mainForm.LoadModule(m)
        mainForm.SetContentTitle(MainForm.TITLE_PERFIL_ACADEMICO)
    End Sub

    Private Sub ButtonResumen_Click(sender As Object, e As EventArgs) Handles ButtonResumen.Click
        Dim m = New ResumenModule(mainForm)
        mainForm.LoadModule(m)
        mainForm.SetContentTitle(MainForm.TITLE_RESUMEN)
    End Sub

End Class
