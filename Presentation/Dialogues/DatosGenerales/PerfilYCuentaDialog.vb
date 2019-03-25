Imports Entities
Imports Logic

Public Class PerfilYCuentaDialog
    Inherits CustomDialog

    Public Sub New(mainForm As MainForm, parentModule As PerfilYCuentaModule)
        MyBase.New(mainForm)

        InitializeComponent()

        Me.mainForm = mainForm
        Me.parentModule = parentModule

        Me.ComboBoxPaisNacimiento.Items.Add("Mexico")
        Me.ComboBoxPaisNacimiento.SelectedItem = "Mexico"

        Me.ComboBoxSexo.Items.Add("Hombre")
        Me.ComboBoxSexo.Items.Add("Mujer")
        Me.ComboBoxSexo.SelectedItem = "Hombre"

        FillData()
    End Sub

    Public Overrides Sub FillData()
        Dim datosPersonales As DatosPersonales = mainForm.datosPersonales

        Me.TextBoxNombre.Text = datosPersonales.Nombre
        Me.TextBoxApellidoP.Text = datosPersonales.ApellidoPaterno
        Me.TextBoxApellidoM.Text = datosPersonales.ApellidoMaterno
        Me.ComboBoxSexo.SelectedItem = datosPersonales.Sexo
        Me.ComboBoxPaisNacimiento.SelectedItem = datosPersonales.PaisNacimiento
        Me.DateTimePickerFechaNacimiento.Value = If(datosPersonales.FechaNacimiento > DateTime.Parse("1/1/1753"), datosPersonales.FechaNacimiento, DateTime.Parse("1/1/1753"))
        Me.TextBoxCurp.Text = datosPersonales.Curp
        Me.TextBoxRfc.Text = datosPersonales.Rfc
        Me.TextBoxCvu.Text = datosPersonales.Cvu
        Me.TextBoxBiografia.Text = datosPersonales.Biografia
    End Sub

    Private Sub CancelarButton1_Click(sender As Object, e As EventArgs) Handles CancelarButton1.Click
        ReturnControl()
    End Sub

    Private Sub GuardarButton1_Click(sender As Object, e As EventArgs) Handles GuardarButton1.Click
        Dim datosPersonales As DatosPersonales = mainForm.datosPersonales

        datosPersonales.Nombre = Me.TextBoxNombre.Text
        datosPersonales.ApellidoPaterno = Me.TextBoxApellidoP.Text
        datosPersonales.ApellidoMaterno = Me.TextBoxApellidoM.Text
        datosPersonales.Sexo = Me.ComboBoxSexo.SelectedItem
        datosPersonales.PaisNacimiento = Me.ComboBoxPaisNacimiento.SelectedItem
        datosPersonales.FechaNacimiento = Me.DateTimePickerFechaNacimiento.Value
        datosPersonales.Curp = Me.TextBoxCurp.Text
        datosPersonales.Rfc = Me.TextBoxRfc.Text
        datosPersonales.Cvu = Me.TextBoxCvu.Text
        datosPersonales.Biografia = Me.TextBoxBiografia.Text

        Dim datosPersonalesValidation As DatosPersonalesValidation = New DatosPersonalesValidation()
        datosPersonalesValidation.Entity = datosPersonales

        Dim success = datosPersonalesValidation.ValidateAll()
        If Not success Then
            MessageBox.Show("Has ingresado datos invalidos. Intentelo de nuevo.")
            Return
        End If

        Dim datosPersonalesModel As DatosPersonalesModel = mainForm.datosPersonalesModel
        datosPersonalesModel.Entity = datosPersonales
        datosPersonalesModel.State = DatosPersonalesModel.STATE_UPDATE

        success = datosPersonalesModel.ExecuteChanges()
        If Not success Then
            MessageBox.Show("Hubo un error al realizar los cambios. Intentelo de nuevo")
            Return
        End If

        MessageBox.Show("Cambios guardados!")
        CType(parentModule, PerfilYCuentaModule).FillData()

        ReturnControl()
    End Sub
End Class
