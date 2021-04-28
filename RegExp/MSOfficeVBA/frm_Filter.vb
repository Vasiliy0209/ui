Private Sub btn_clear_Click()
Me.tb_output.Text = ""
End Sub

Private Sub btn_invoke_Click()
Dim reg As RegExp
Set reg = New RegExp
For Each rxp In Split(Me.tb_regexps.Value, vbCrLf) 'vbCr
    Me.tb_output.Text = Me.tb_output.Value + vbCr + "---------[" + rxp + "]---------" + vbCr 'Me.tb_output.Value + rxp
    For Each Line In Split(Me.tb_input.Value, vbCrLf)
        reg.Pattern = rxp
        If (reg.Test(Line)) Then
            Me.tb_output.Value = vbCr + Me.tb_output.Value + Line + vbCr
        End If
    Next
Next
End Sub

Private Sub UserForm_Click()

End Sub