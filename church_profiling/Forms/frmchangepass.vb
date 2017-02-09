Public Class frmchangepass
    Public u_id As Integer
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim u As New Useraccount

        txtOldPass.Text = u.Password
        If txtNewPass.Text <> txtCpass.Text Then
            MsgBox("Password doesn't match", MsgBoxStyle.Exclamation, "Warning")
        ElseIf txtCpass.Text = "" Or txtNewPass.Text = "" Then
            MsgBox("Fill up the missing field", MsgBoxStyle.Information, "Information")
            txtNewPass.Clear()
            txtCpass.Clear()


        Else
            u.changePassword(u_id, txtNewPass.Text)
            MsgBox("Successfully Updated", MsgBoxStyle.Information, "Information")
            txtNewPass.Clear()
            txtCpass.Clear()
        End If


    End Sub

  
   

    Private Sub txtOldPass_TextChanged(sender As Object, e As EventArgs) Handles txtOldPass.TextChanged
        If txtOldPass.Text.Length > 0 Then
            Label2.Visible = False
        Else
            Label2.Visible = True
        End If
    End Sub

    Private Sub frmchangepass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Enabled = False
        txtOldPass.Select()
    End Sub

    Private Sub txtNewPass_TextChanged(sender As Object, e As EventArgs) Handles txtNewPass.TextChanged
        If txtNewPass.Text.Length > 0 Then
            Label1.Visible = False
        Else
            Label1.Visible = True
        End If
    End Sub

    Private Sub txtCpass_TextChanged(sender As Object, e As EventArgs) Handles txtCpass.TextChanged
        If txtCpass.Text.Length > 0 Then
            Label3.Visible = False
        Else
            Label3.Visible = True
        End If
    End Sub
End Class