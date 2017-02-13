Public Class frmPayBalance

    Public ex As New Emergencyfund
    Public id As Integer
    Private Sub frmPayBalance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With ex
            .displayCurrentBorrowerByID(id)
            .currentBalance()
            lblMemberID.Text = .members_id
            lblMemberName.Text = .Fullname
            lblDateBorrowed.Text = .date_borrowed
            lblDueDate.Text = .due_date
            lblPaidStatus.Text = .status
            lblBalance.Text = .balance
        End With
    End Sub

    Private Sub frmPayBalance_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        
    End Sub
End Class