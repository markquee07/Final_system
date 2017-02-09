Public Class frmRegisterUser

    Public user As New Useraccount
    Public user_id As Integer

    Private Sub txtFname_TextChanged(sender As Object, e As EventArgs) Handles txtFname.TextChanged
        If txtFname.Text.Length < 1 Then
            Label1.Visible = True
        Else
            Label1.Visible = False
        End If
    End Sub

    Private Sub txtLname_TextChanged(sender As Object, e As EventArgs) Handles txtLname.TextChanged
        If txtLname.Text.Length < 1 Then
            Label2.Visible = True
        Else
            Label2.Visible = False
        End If
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        If txtUsername.Text.Length < 1 Then
            Label3.Visible = True
        Else
            Label3.Visible = False
        End If
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        If txtPassword.Text.Length < 1 Then
            Label4.Visible = True
        Else
            Label4.Visible = False
        End If
    End Sub

    Private Sub cboUsertype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUsertype.SelectedIndexChanged
        Label5.Visible = False
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        txtFname.Focus()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        txtLname.Focus()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        txtUsername.Focus()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        txtPassword.Focus()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        cboUsertype.Focus()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If txtUsername.Text = "" Or txtFname.Text = "" Or txtLname.Text = "" Or txtPassword.Text = "" Or txtContactNum.Text = "" Then
            MsgBox("Fill up th missing field", MsgBoxStyle.Exclamation)
        Else
            With user
                .First_Name = txtFname.Text
                .Last_Name = txtLname.Text
                .Password = txtPassword.Text
                .User_type = cboUsertype.Text
                .Contact_no = txtContactNum.Text
                .Username = txtUsername.Text
                If btnRegister.Text = "Update" Then

                    user.updateUser(user_id)
                    clearInformation()
                    user.loaduserc(frmUserAccountProfile.lsvUsers)
                    Me.Close()

                Else
                If .isuserExist(txtUsername.Text) Then
                    MsgBox("Username already exist", MsgBoxStyle.Exclamation, "Warning")
                    txtUsername.Clear()
                ElseIf txtPassword.Text <> txtcPass.Text Then
                    MsgBox(" Password And Confirmation password doesn't match", MsgBoxStyle.Exclamation, "Warning")
                    txtPassword.Clear()
                    txtcPass.Clear()
                Else
                    .saveNewAccount()
                    user.loaduserc(frmUserAccountProfile.lsvUsers)
                    clearInformation()
                End If
                End If

            End With
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        txtContactNum.Focus()
    End Sub

    Private Sub txtContactNum_TextChanged(sender As Object, e As EventArgs) Handles txtContactNum.TextChanged
        If txtContactNum.Text.Length > 0 Then
            Label7.Visible = False
        Else
            Label7.Visible = True
        End If
    End Sub

    Public Sub clearInformation()
        txtFname.Clear()
        txtLname.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        cboUsertype.Text = ""
        txtContactNum.Clear()
        Label5.Visible = True
        txtcPass.Clear()
        txtFname.Focus()
    End Sub
 
    Private Sub txtContactNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContactNum.KeyPress
        If Convert.ToInt32(e.KeyChar).ToString() = "13" Then
            If txtUsername.Text = "" Or txtFname.Text = "" Or txtLname.Text = "" Or txtPassword.Text = "" Or txtContactNum.Text = "" Then
                MsgBox("Fill up th missing field", MsgBoxStyle.Exclamation)
            Else
                With user
                    .First_Name = txtFname.Text
                    .Last_Name = txtLname.Text
                    .Password = txtPassword.Text
                    .User_type = cboUsertype.Text
                    .Contact_no = txtContactNum.Text
                    .Username = txtContactNum.Text
                    .saveNewAccount()
                    clearInformation()
                End With
            End If
        End If

    End Sub

    Private Sub frmRegisterUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If btnRegister.Text = "Update" Then
            user.displayUserSelected(user_id)
            txtFname.Text = user.First_Name
            txtLname.Text = user.Last_Name
            txtUsername.Text = user.Username
            txtcPass.Text = user.Password
            txtPassword.Text = user.Password
            txtContactNum.Text = user.Contact_no
            cboUsertype.Text = user.User_type
            txtPassword.Visible = False
            Label4.Visible = False
            Label5.Visible = False
            txtcPass.Visible = False
            Label4.Visible = False
            PictureBox4.Visible = False
            PictureBox9.Visible = False
            lblcpass.Visible = False
            PictureBox5.Location = New Point(51, 234)
            cboUsertype.Location = New Point(67, 247)
            Label5.Location = New Point(72, 245)
            PictureBox8.Location = New Point(50, 285)
            txtContactNum.Location = New Point(66, 298)
            Label7.Location = New Point(71, 296)
            btnRegister.Location = New Point(51, 334)
            Me.Size = New Size(400, 460)
            Label6.Text="UPDATE USER"
        End If

    End Sub

    Private Sub lblcpass_Click(sender As Object, e As EventArgs) Handles lblcpass.Click
        txtcPass.Focus()
    End Sub

    Private Sub txtcPass_TextChanged(sender As Object, e As EventArgs) Handles txtcPass.TextChanged
        If txtcPass.Text.Length > 0 Then
            lblcpass.Visible = False
        Else
            lblcpass.Visible = True
        End If

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub frmRegisterUser_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub frmRegisterUser_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.clearInformation()
    End Sub
End Class