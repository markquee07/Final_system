Public Class frmUserAccountProfile
    Public u As New Useraccount
    Public u_id As Integer
    Private Sub frmUserAccountProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        u.loaduserc(lsvUsers)
    End Sub

    Private Sub btnAddNEw_Click(sender As Object, e As EventArgs) Handles btnAddNEw.Click
        Dim ru As New frmRegisterUser
        ru.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim selected_id As Integer = lsvUsers.SelectedItems.Count
        If selected_id <= 0 Then
            MsgBox("Select User first", MsgBoxStyle.Information)
        Else
            With frmRegisterUser
                .user_id = u_id
                .btnRegister.text = "Update"
                .ShowDialog()
            End With
        End If
    End Sub

    Private Sub lsvUsers_Click(sender As Object, e As EventArgs) Handles lsvUsers.Click
        u_id = lsvUsers.SelectedItems(0).SubItems(0).Text
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim selected_id As Integer = lsvUsers.SelectedItems.Count
        If selected_id <= 0 Then
            MsgBox("Please select user first", MsgBoxStyle.Information, "Information")
        Else
            Dim d As DialogResult = MsgBox("Are you about to delete this data?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Question")
            If d = MsgBoxResult.Yes Then
                u.deleteUSer(u_id)
                u.loaduserc(lsvUsers)
            Else

            End If
           
        End If

    End Sub

    Private Sub btnChangePass_Click(sender As Object, e As EventArgs) Handles btnChangePass.Click
        Dim selected_id As Integer = lsvUsers.SelectedItems.Count
        If selected_id <= 0 Then
            MsgBox("Select User First", MsgBoxStyle.Information, "Information")
        Else

            With frmchangepass
                .u_id = Me.u_id
                .txtUsername.Text = lsvUsers.SelectedItems(0).SubItems(3).Text
                .ShowDialog()
            End With

        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Length > 0 Then
            lblSearchMember.Visible = False
            u.searchUser(txtSearch.Text, lsvUsers)

        Else
            u.loaduserc(lsvUsers)
            lblSearchMember.Visible = True
        End If
    End Sub
End Class