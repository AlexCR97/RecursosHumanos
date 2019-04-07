Public Class SideBarModule

    Private mainForm As MainForm

    Private expandedWidth = 220
    Private shrinkedWidth = 70

    Private expanded = True

    Public Sub New()
        InitializeComponent()

        Dim color = My.Settings.MainColor
        Me.BackColor = ControlPaint.Dark(color)
    End Sub

    Public Sub SetMainForm(mainForm As MainForm)
        Me.mainForm = mainForm
    End Sub

    Public Sub ExpandOrShrink()
        expanded = Not expanded

        If expanded Then
            Me.Width = expandedWidth
        Else
            Me.Width = shrinkedWidth
        End If

    End Sub

    Private Sub PictureBoxExpandOrShrink_Click(sender As Object, e As EventArgs) Handles PictureBoxExpandOrShrink.Click
        ExpandOrShrink()
    End Sub

    Private Sub ButtonDatosGenerales_Click(sender As Object, e As EventArgs) Handles ButtonDatosGenerales.Click
        Dim m = New DatosGeneralesModule(mainForm)
        mainForm.LoadModule(m)
        mainForm.SetContentTitle(MainForm.TITLE_DATOS_GENERALES)
    End Sub

    Private Sub PictureBoxDatosGenerales_Click(sender As Object, e As EventArgs) Handles PictureBoxDatosGenerales.Click
        Dim m = New DatosGeneralesModule(mainForm)
        mainForm.LoadModule(m)
        mainForm.SetContentTitle(MainForm.TITLE_DATOS_GENERALES)
    End Sub

    Private Sub ButtonPerfilAcademico_Click(sender As Object, e As EventArgs) Handles ButtonPerfilAcademico.Click
        Dim m = New PerfilAcademicoModule(mainForm)
        mainForm.LoadModule(m)
        mainForm.SetContentTitle(MainForm.TITLE_PERFIL_ACADEMICO)
    End Sub

    Private Sub PictureBoxPerfilAcademico_Click(sender As Object, e As EventArgs) Handles PictureBoxPerfilAcademico.Click
        Dim m = New PerfilAcademicoModule(mainForm)
        mainForm.LoadModule(m)
        mainForm.SetContentTitle(MainForm.TITLE_PERFIL_ACADEMICO)
    End Sub

    Private Sub ButtonResumen_Click(sender As Object, e As EventArgs) Handles ButtonResumen.Click
        Dim m = New ResumenModule(mainForm)
        mainForm.LoadModule(m)
        mainForm.SetContentTitle(MainForm.TITLE_RESUMEN)
    End Sub

    Private Sub PictureBoxResumen_Click(sender As Object, e As EventArgs) Handles PictureBoxResumen.Click
        Dim m = New ResumenModule(mainForm)
        mainForm.LoadModule(m)
        mainForm.SetContentTitle(MainForm.TITLE_RESUMEN)
    End Sub

End Class
