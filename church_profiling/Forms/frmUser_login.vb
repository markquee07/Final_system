Public Class frmUser_login

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        triggerLogin()
    End Sub

    
    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        If txtUsername.Text.Length < 1 Then
            Label1.Show()
        Else
            Label1.Hide()
        End If
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        If txtPassword.Text.Length < 1 Then
            Label2.Show()
        Else
            Label2.Hide()
        End If
    End Sub

    Private Sub triggerLogin()
        Dim ua As New Useraccount
        With ua
            .Username = txtUsername.Text
            .Password = txtPassword.Text

            If txtUsername.Text = Nothing Then
                MsgBox("All field must be filled up", MsgBoxStyle.Exclamation, Title:="")
            ElseIf txtPassword.Text = Nothing Then
                MsgBox("All field must be filled up", MsgBoxStyle.Exclamation, Title:="")
            Else
                If .validateLogin() Then
                    frmMainFinal.ShowDialog()
                Else
                    MsgBox("Invalid Username/Password", MsgBoxStyle.Critical, Title:="")
                End If

                txtPassword.Clear()
                txtUsername.Clear()
                txtUsername.Focus()
            End If
        End With
    End Sub
   

    Private Sub cboUserType_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Convert.ToInt32(e.KeyChar).ToString() = "13" Then
            Me.triggerLogin()
        End If
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If Convert.ToInt32(e.KeyChar).ToString() = "13" Then
            Me.triggerLogin()
        End If
    End Sub
End Class