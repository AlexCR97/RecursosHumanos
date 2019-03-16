Public Class DatosGeneralesModule

    Private mainForm As MainForm

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(mainForm As MainForm)
        InitializeComponent()

        Me.mainForm = mainForm
    End Sub

    Private Sub ButtonPerfilYCuenta_Click(sender As Object, e As EventArgs) Handles ButtonPerfilYCuenta.Click
        Dim m = New PerfilYCuentaModule(mainForm)
        mainForm.LoadModule(m)
        mainForm.SetContentTitle(MainForm.TITLE_DATOS_GENERALES_PERFIL_Y_CUENTA)
    End Sub

    Private Sub ButtonDatosDeContacto_Click(sender As Object, e As EventArgs) Handles ButtonDatosDeContacto.Click
        Dim m = New DatosDeContactoModule(mainForm)
        mainForm.LoadModule(m)
        mainForm.SetContentTitle(MainForm.TITLE_DATOS_GENERALES_DATOS_DE_CONTACTO)
    End Sub

    Private Sub ButtonDatosLaborales_Click(sender As Object, e As EventArgs) Handles ButtonDatosLaborales.Click
        Dim m = New DatosLaboralesModule(mainForm)
        mainForm.LoadModule(m)
        mainForm.SetContentTitle(MainForm.TITLE_DATOS_GENERALES_DATOS_LABORALES)
    End Sub
End Class
