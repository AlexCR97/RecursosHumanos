Imports Entities

Public Class ResumenPerfilYCuentaModule

    Public mainForm As MainForm

    Public Sub FillData()
        Dim datosPersonales As DatosPersonales = mainForm.datosPersonales
        Me.LabelCurp.Text = datosPersonales.Curp
        Me.LabelFechaNacimiento.Text = datosPersonales.FechaNacimiento.ToShortDateString()
        Me.LabelGenero.Text = datosPersonales.Sexo
        Me.LabelPaisNacimiento.Text = datosPersonales.PaisNacimiento
        Me.LabelRfc.Text = datosPersonales.Rfc

        Me.LabelNombreCompleto.Text = datosPersonales.ApellidoPaterno & "-" & datosPersonales.ApellidoMaterno & ", " & datosPersonales.Nombre
    End Sub

End Class
