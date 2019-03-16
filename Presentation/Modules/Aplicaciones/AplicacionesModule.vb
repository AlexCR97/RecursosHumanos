Public Class AplicacionesModule

    Private mainForm As MainForm

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(mainForm As MainForm)
        InitializeComponent()

        Me.mainForm = mainForm
    End Sub

    Private Sub ButtonAplicacionesVinculadas_Click(sender As Object, e As EventArgs) Handles ButtonAplicacionesVinculadas.Click
        Dim m = New AplicacionesVinculadasModule()
        mainForm.LoadModule(m)
        mainForm.SetContentTitle(MainForm.TITLE_APLICACIONES_VINCULADAS)
    End Sub

    Private Sub ButtonMensajesDeAplicacion_Click(sender As Object, e As EventArgs) Handles ButtonMensajesDeAplicacion.Click
        mainForm.SetContentTitle(MainForm.TITLE_APLICACIONES_MENSAJES)
    End Sub
End Class
