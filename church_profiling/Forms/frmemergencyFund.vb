Public Class frmemergencyFund

    Public ex As New Emergencyfund
    Public id As Integer


    Private Sub lblSearchMember_Click(sender As Object, e As EventArgs) Handles lblSearchMember.Click
        lblSearchMember.Focus()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        lblSearchMember.Focus()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Length > 0 Then
            lblSearchMember.Visible = False
        Else
            lblSearchMember.Visible = True
        End If
    End Sub

    Private Sub lsvListofmember_Click(sender As Object, e As EventArgs) Handles lsvListofmember.Click
        Dim selected_id = lsvListofmember.SelectedItems.Count
        If selected_id <= 0 Then
            MsgBox("Search and select the Member first", MsgBoxStyle.Information, "Information")
        Else
            Dim i As Integer = lsvListofmember.Items.Count
            txtMemberId.Text = lsvListofmember.SelectedItems(0).SubItems(1).Text
            txtMemberName.Text = lsvListofmember.SelectedItems(0).SubItems(2).Text
            id = lsvListofmember.SelectedItems(0).SubItems(0).Text
        End If
    End Sub

    Private Sub frmemergencyFund_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim budget As String = ex.checkEmergencyBudget()
        If ex.checkEmergencyBudget() = "Unavailable" Then
            lblStatus.Text = "UNAVAILABLE"
            lblStatus.ForeColor = Color.Red
            btnsave.Enabled = False
            dtpDateBorrowed.Enabled = False
            unhideControl()
           
        ElseIf Integer.Parse(budget) < 1000 Then
            lblStatus.Text = "UNAVAILABLE"
            lblStatus.ForeColor = Color.Red
            btnsave.Enabled = False
            dtpDateBorrowed.Enabled = False
            unhideControl()
        Else
            hideControl()
            lblStatus.ForeColor = Color.DeepSkyBlue
            lblStatus.Text = "AVAILABLE"
            btnsave.Enabled = True
            dtpDateBorrowed.Enabled = True
            dtpDueDate.Value = dtpDateBorrowed.Value.AddMonths(1)
            ex.displayMemberToBorrow(lsvListofmember)
        End If
    End Sub

    Private Sub dtpDateBorrowed_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateBorrowed.ValueChanged
        dtpDueDate.Value = dtpDateBorrowed.Value.AddMonths(1)
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        With ex

            .member_id = id
            .amount_borrowed = txtamountborrowed.Text
            .due_date = dtpDueDate.Value.ToString("yyyy-MM-dd")
            .date_borrowed = dtpDateBorrowed.Value.ToString("yyyy-MM-dd")
            .status = "UNPAID"
            .saveEmergencyFund()
        End With
      
    End Sub

    Public Sub unhideControl()
        lsvListofmember.Visible = False
        lblSearchMember.Visible = False
        txtSearch.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False

        lblMemberID.Visible = True
        lblMemberName.Visible = True
        lblDateBorrowed.Visible = True
        lblDueDate.Visible = True
        lblPaidStatus.Visible = True
        lblBalance.Visible = True
        l1.Visible = True
        l2.Visible = True
        l3.Visible = True
        l4.Visible = True
        l5.Visible = True
        l6.Visible = True
        l7.Visible = True

        With ex
            .displayCurrentBorrower()
            .currentBalance()
            lblMemberID.Text = .members_id
            lblMemberName.Text = .Fullname
            lblDateBorrowed.Text = .date_borrowed
            lblDueDate.Text = .due_date
            lblPaidStatus.Text = .status
            lblBalance.Text = .balance
        End With
    End Sub

    Public Sub hideControl()
        lsvListofmember.Visible = True
        lblSearchMember.Visible = True
        txtSearch.Visible = True
        PictureBox2.Visible = True
        PictureBox3.Visible = True

        lblMemberID.Visible = False
        lblMemberName.Visible = False
        lblDateBorrowed.Visible = False
        lblDueDate.Visible = False
        lblPaidStatus.Visible = False
        lblBalance.Visible = False
        l1.Visible = False
        l2.Visible = False
        l3.Visible = False
        l4.Visible = False
        l5.Visible = False
        l6.Visible = False
        l7.Visible = False

        With ex
            .displayCurrentBorrower()
            .currentBalance()
            lblMemberID.Text = .members_id
            lblMemberName.Text = .Fullname
            lblDateBorrowed.Text = .date_borrowed
            lblDueDate.Text = .due_date
            lblStatus.Text = .status
            lblBalance.Text = .balance
        End With
    End Sub
End Class