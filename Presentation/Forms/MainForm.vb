Imports Logic
Imports Entities

Public Class MainForm
    Inherits CustomForm

    Public Const TITLE_MENU_PRINCIPAL = "Menu principal"

    Public Const TITLE_DATOS_GENERALES = "Datos generales"
    Public Const TITLE_DATOS_GENERALES_PERFIL_Y_CUENTA = "Perfil y cuenta"
    Public Const TITLE_DATOS_GENERALES_DATOS_DE_CONTACTO = "Datos de contacto"
    Public Const TITLE_DATOS_GENERALES_DATOS_LABORALES = "Datos laborales"
    Public Const TITLE_PERFIL_ACADEMICO = "Perfil academico"
    Public Const TITLE_PERFIL_ACADEMICO_TITULOS_ACADEMICOS = "Titulos academicos"
    Public Const TITLE_PERFIL_ACADEMICO_PRODUCTIVDAD_ACADEMICA = "Productividad academica"
    Public Const TITLE_PERFIL_ACADEMICO_DISTINCIONES = "Distinciones"
    Public Const TITLE_PERFIL_ACADEMICO_ASOCIACIONES = "Asociaciones"
    Public Const TITLE_RESUMEN = "Resumen"

    Private modules As Dictionary(Of String, Control) = New Dictionary(Of String, Control)

    Public usuario As Usuario = New Usuario()
    Public usuarioModel As UsuarioModel = New UsuarioModel()

    Public datosPersonales As DatosPersonales = New DatosPersonales()
    Public datosPersonalesModel As DatosPersonalesModel = New DatosPersonalesModel()

    Public Sub New()
        InitializeComponent()

        Dim resumen = New ResumenModule(Me)
        Me.LoadModule(resumen)

        Me.MainMenuModule1.SetMainForm(Me)
        Me.SideBarModule1.SetMainForm(Me)
        Me.MenuBarModule1.SetMainForm(Me)
    End Sub

    Public Sub InitializeWithUser(usuario As Usuario)
        Me.usuario = usuario

        datosPersonales.IdUsuario = usuario.IdUsuario
        datosPersonalesModel.Entity = datosPersonales

        datosPersonales = datosPersonalesModel.GetEntityWithId()

        Me.MenuBarModule1.LabelNombre.Text = datosPersonales.Nombre
    End Sub

    Public Sub LoadModule(c As Control)
        Dim moduleName = c.Name

        If Not modules.ContainsKey(moduleName) Then
            modules(moduleName) = c
            Me.PanelSubContent.Controls.Add(modules(moduleName))
            modules(moduleName).Dock = DockStyle.Fill
        End If

        modules(moduleName).BringToFront()
    End Sub

    Public Sub SetContentTitle(Title As String)
        Me.LabelSubContentTitle.Text = Title
    End Sub

    Public Sub UpdateResumenModule()
        Dim resumen As ResumenModule = CType(modules("ResumenModule"), ResumenModule)
        resumen.ClearData()
        resumen.FillData()
    End Sub

End Class
