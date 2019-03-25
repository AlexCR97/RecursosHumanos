Public Class ResumenModule

    Public mainForm As MainForm

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(mainForm As MainForm)
        InitializeComponent()

        Me.mainForm = mainForm
        Me.ResumenPerfilYCuentaModule1.mainForm = mainForm
        Me.ResumenDatosDeContactoModule1.mainForm = mainForm
        Me.ResumenDatosLaboralesModule1.mainForm = mainForm
        Me.ResumenTitulosAcademicosModule1.mainForm = mainForm
        Me.ResumenProductividadAcademicaModule1.mainForm = mainForm
        Me.ResumenDistincionesModule1.mainForm = mainForm
        Me.ResumenAsociacionesModule1.mainForm = mainForm

        FillData()
    End Sub

    Public Sub ClearData()
        Me.ResumenDatosDeContactoModule1.ClearData()
        Me.ResumenDatosLaboralesModule1.ClearData()
        Me.ResumenTitulosAcademicosModule1.ClearData()
        Me.ResumenProductividadAcademicaModule1.ClearData()
        Me.ResumenDistincionesModule1.ClearData()
        Me.ResumenAsociacionesModule1.ClearData()
    End Sub

    Public Sub FillData()
        Me.ResumenPerfilYCuentaModule1.FillData()
        Me.ResumenDatosDeContactoModule1.FillData()
        Me.ResumenDatosLaboralesModule1.FillData()
        Me.ResumenTitulosAcademicosModule1.FillData()
        Me.ResumenProductividadAcademicaModule1.FillData()
        Me.ResumenDistincionesModule1.FillData()
        Me.ResumenAsociacionesModule1.FillData()
    End Sub

End Class
