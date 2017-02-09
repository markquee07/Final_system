Public Class frmchurchlist
    Public ch As New Church
    Public ch_id As Integer

    Private Sub frmchurchlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ch.loadchurchinfo(lsvChurch)
    End Sub

    Private Sub lblAttendanceType_Click(sender As Object, e As EventArgs) Handles lblAttendanceType.Click

    End Sub

    Private Sub btnAddChurch_Click(sender As Object, e As EventArgs) Handles btnAddChurch.Click

        With frmAddChurchName
            .btnRegister.Text = "Save"
            .ShowDialog()
        End With

    End Sub

    Private Sub btnDeleteChurch_Click(sender As Object, e As EventArgs) Handles btnDeleteChurch.Click
        Dim selected_id = lsvChurch.SelectedItems.Count
        If selected_id <= 0 Then
            MsgBox("Select data first", MsgBoxStyle.Information, "Information")
        Else
            Dim d As DialogResult = MsgBox("Are you about to delete this data?", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
            If d = MsgBoxResult.Yes Then
                ch.deleteChurchInfo(ch_id)
                ch.loadchurchinfo(lsvChurch)
            End If


        End If
    End Sub

    Private Sub lsvChurch_Click(sender As Object, e As EventArgs) Handles lsvChurch.Click
        ch_id = lsvChurch.SelectedItems(0).SubItems(0).Text
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim cc_id As Integer = lsvChurch.SelectedItems.Count
        If cc_id <= 0 Then
            MsgBox("Select data first", MsgBoxStyle.Information, "Information")
        Else
            With frmAddChurchName
                .c = ch_id
                .btnRegister.Text = "Update"
                .ShowDialog()
            End With
        End If

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Length < 1 Then
            lblSearchMember.Visible = True
        Else
            lblSearchMember.Visible = False
        End If
        ch.searchchurch(txtSearch.Text, lsvChurch)
    End Sub
End Class