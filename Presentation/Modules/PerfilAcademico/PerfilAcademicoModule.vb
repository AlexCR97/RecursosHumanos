Public Class PerfilAcademicoModule

    Private mainForm As MainForm

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(mainForm As MainForm)
        InitializeComponent()

        Me.mainForm = mainForm
    End Sub

    Private Sub ButtonTitulosAcademicos_Click(sender As Object, e As EventArgs) Handles ButtonTitulosAcademicos.Click
        Dim m = New TitulosAcademicosModule()
        mainForm.LoadModule(m)
        mainForm.SetContentTitle(MainForm.TITLE_PERFIL_ACADEMICO_TITULOS_ACADEMICOS)
    End Sub

    Private Sub ButtonProductividadAcademica_Click(sender As Object, e As EventArgs) Handles ButtonProductividadAcademica.Click
        Dim m = New ProductividadAcademicaModule()
        mainForm.LoadModule(m)
        mainForm.SetContentTitle(MainForm.TITLE_PERFIL_ACADEMICO_PRODUCTIVDAD_ACADEMICA)
    End Sub

    Private Sub ButtonDistinciones_Click(sender As Object, e As EventArgs) Handles ButtonDistinciones.Click
        Dim m = New DistincionesModule()
        mainForm.LoadModule(m)
        mainForm.SetContentTitle(MainForm.TITLE_PERFIL_ACADEMICO_DISTINCIONES)
    End Sub

    Private Sub ButtonAsociaciones_Click(sender As Object, e As EventArgs) Handles ButtonAsociaciones.Click
        Dim m = New AsociacionesModule()
        mainForm.LoadModule(m)
        mainForm.SetContentTitle(MainForm.TITLE_PERFIL_ACADEMICO_ASOCIACIONES)
    End Sub

End Class
