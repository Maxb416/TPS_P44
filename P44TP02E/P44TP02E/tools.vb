Public Module tools
    Public Enum Action
        Read = 0
        Create = 1
        Update = 2
        Delete = 3
    End Enum

    Public Sub emptyForm(Controls As Control.ControlCollection)
        For Each ctrl As Control In Controls
            If TypeOf ctrl Is TextBox Or TypeOf ctrl Is MaskedTextBox Then
                ctrl.ResetText()
            ElseIf TypeOf ctrl Is RadioButton Then
                CType(ctrl, RadioButton).Checked = False
            ElseIf TypeOf ctrl Is ComboBox Then
                CType(ctrl, ComboBox).SelectedIndex = 0
            End If
        Next
    End Sub

    Public Sub lockControls(ParamArray ctrls() As Control)
        For Each ctrl In ctrls
            ctrl.Enabled = False
        Next
    End Sub

    Public Sub unlockControls(ParamArray ctrls() As Control)
        For Each ctrl In ctrls
            ctrl.Enabled = True
        Next
    End Sub

End Module