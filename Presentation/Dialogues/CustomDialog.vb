Public Class CustomDialog

    Public mainForm As MainForm
    Public parentModule As Control

    Protected operation As Integer

    Public Const OPERATION_ADD = 1
    Public Const OPERATION_EDIT = 2

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(mainForm As MainForm)
        InitializeComponent()

        Me.mainForm = mainForm
        mainForm.Enabled = False
    End Sub

    Public Sub ReturnControl()
        mainForm.Enabled = True
        Me.Close()
    End Sub

    Public Overridable Sub FillData()

    End Sub

    Public Overridable Sub Add()

    End Sub

    Public Overridable Sub Edit()

    End Sub

End Class
