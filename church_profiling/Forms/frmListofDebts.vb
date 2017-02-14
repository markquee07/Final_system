Public Class frmListofDebts

    Public ex As New Expenses
    Public ef As New Emergencyfund

    Private Sub frmListofDebts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ex.displayListOfExpenses(lsvExpenses)
    End Sub

    Private Sub btnAddChurch_Click(sender As Object, e As EventArgs) Handles btnAddChurch.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ef.checkEmergencyBudget()
        lsvExpenses.Visible = False
        lsvEmergencyFund.Visible = True
        btnPayBalance.Visible = True

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub lsvEmergencyFund_Click(sender As Object, e As EventArgs) Handles lsvEmergencyFund.Click

    End Sub


    Private Sub btnPayBalance_Click(sender As Object, e As EventArgs) Handles btnPayBalance.Click
        Dim x As Integer = lsvEmergencyFund.SelectedItems.Count
        If x <= 0 Then
            MsgBox("Please Select a transaction first", MsgBoxStyle.Information)
        Else
            Dim id As Integer = lsvEmergencyFund.SelectedItems(0).SubItems(0).Text
            Dim b As New frmPayBalance
            With b
                .id = id
                .ShowDialog()
            End With
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lsvEmergencyFund.Visible = False
        btnPayBalance.Visible = False
        lsvExpenses.Visible = True
    End Sub

    
    Private Sub lsvEmergencyFund_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvEmergencyFund.SelectedIndexChanged
        Dim x As Integer = lsvEmergencyFund.SelectedItems.Count

        If x <= 0 Then
            btnPayBalance.Visible = False
        Else
            Dim y As String = lsvEmergencyFund.SelectedItems(0).SubItems(8).Text
            If y = "PAID" Then
                btnPayBalance.Visible = False
            Else
                btnPayBalance.Visible = True
            End If
        End If
    End Sub
End Class