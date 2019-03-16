Imports Entities

Public Class PerfilYCuentaModule

    Private mainForm As MainForm

    Public Sub New(mainForm As MainForm)
        InitializeComponent()

        Me.mainForm = mainForm

        FillData()
    End Sub

    Public Sub FillData()
        Dim datosPersonales As DatosPersonales = mainForm.datosPersonales

        Me.LabelNombre.Text = datosPersonales.Nombre
        Me.LabelApellidoPaterno.Text = datosPersonales.ApellidoPaterno
        Me.LabelApellidoMaterno.Text = datosPersonales.ApellidoMaterno
        Me.LabelSexo.Text = datosPersonales.Sexo
        Me.LabelPaisNacimiento.Text = datosPersonales.PaisNacimiento
        Me.LabelFechaNacimiento.Text = datosPersonales.FechaNacimiento
        Me.LabelCurp.Text = datosPersonales.Curp
        Me.LabelRfc.Text = datosPersonales.Rfc
        Me.LabelCvu.Text = datosPersonales.Cvu
        Me.LabelBiografia.Text = datosPersonales.Biografia
    End Sub

    Private Sub PictureBoxEditar_Click(sender As Object, e As EventArgs) Handles PictureBoxEditar.Click
        Dim editarDialog As PerfilYCuentaDialog = New PerfilYCuentaDialog(mainForm, Me)
        editarDialog.Show(Me)
    End Sub

End Class
