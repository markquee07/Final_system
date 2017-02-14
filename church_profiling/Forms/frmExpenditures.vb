Public Class frmExpenditures
    Public ex As New Expenditure
    Public active_id As Integer
    Private Sub frmExpenditures_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ex.displayMemberExpenditure(lsvListofmember)
    End Sub

    Private Sub lsvListofmember_Click(sender As Object, e As EventArgs) Handles lsvListofmember.Click
        Dim x As Integer = lsvListofmember.SelectedItems.Count
        If x <= 0 Then
            MsgBox("Select Member First", MsgBoxStyle.Information, "Expenditures")
        Else
            active_id = lsvListofmember.SelectedItems(0).SubItems(0).Text
            txtMemberId.Text = lsvListofmember.SelectedItems(0).SubItems(1).Text
            txtMemberName.Text = lsvListofmember.SelectedItems(0).SubItems(2).Text
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Length > 0 Then
            lblSearchMember.Visible = False
            ex.serachMember(lsvListofmember, txtSearch.Text)
        Else
            ex.displayMemberExpenditure(lsvListofmember)
            lblSearchMember.Visible = True
        End If
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        With ex
            .Expenditures_type = cboexpendiyretype.Text
            .member_id = active_id
            .saveExpenditure()
        End With
        txtMemberId.Clear()
        txtMemberName.Clear()
        cboexpendiyretype.Text = ""
    End Sub
End Class