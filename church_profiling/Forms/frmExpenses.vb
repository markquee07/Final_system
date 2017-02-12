Public Class frmExpenses
    Public active_id As Integer
    Public add As Integer = 1
    Private Sub frmExpenses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x As New Expenses
        x.displayListOfExpenses(lsvlistofexpenses)
        If btnsave.Text = "UPDATE" Then
            Dim p As New Expenses
            p.loadSelectedExpense(active_id)
            cboexpensestype.Text = p.expenses_type
            txtamount.Text = p.amount
        End If
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs)
        'txtName.Text = Replace(txtName.Text, "'", "\'")
       
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Try
            If lsvlistofexpenses.SelectedItems(0).Text <> "" Then
                Dim selected_id As Integer = lsvlistofexpenses.SelectedItems(0).Text
                With Me
                    .active_id = selected_id
                    .btnsave.Text = "UPDATE"
                    Dim exp As New Expenses
                    exp.loadSelectedExpense(selected_id)
                    cboexpensestype.Text = exp.expenses_type
                    txtamount.Text = exp.amount

                End With
            End If

        Catch ex As Exception
            MsgBox("Please Select Field in Listview")
        End Try

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Try
            If lsvlistofexpenses.SelectedItems(0).Text <> "" Then
                Dim selected_id As Integer
                selected_id = lsvlistofexpenses.SelectedItems(0).Text
                Dim i As New Expenses
                Dim c As Byte = MsgBox("Are You Sure You Want To Delete This Value?", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
                If c = MsgBoxResult.Yes Then
                    i.deleteExpenses(selected_id)
                    i.displayListOfExpenses(lsvlistofexpenses)
                End If
            End If
        Catch ex As Exception
            MsgBox("Please Selecct Field in Listview")
        End Try
    End Sub

    Private Sub btnsave_Click_1(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim ex As New Expenses
        With ex
            .expenses_type = cboexpensestype.Text
            .amount = Val(txtamount.Text)
            If Trim(cboexpensestype.Text) = "" Then
                MsgBox("Empty field")
            ElseIf btnsave.Text = "UPDATE" Then
                Dim c As Byte = MsgBox("Are You Sure You Want To UPDATE This Value?", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
                If c = MsgBoxResult.Yes Then
                    .updateSelectedExpense(active_id)
                    .displayListOfExpenses(lsvlistofexpenses)
                End If
            Else
                .savechurchExpenses()
                .displayListOfExpenses(lsvlistofexpenses)
            End If
        End With
    End Sub

   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim type As String
        Dim amount As Double
        Dim new_info As Integer = 1
        If add = 1 Then
            Dim x As Integer = lsvAddedExpenses.Items.Count
            lsvAddedExpenses.Items.Add(cboexpensestype.Text)
            lsvAddedExpenses.Items(x).SubItems.Add(txtamount.Text)
            add = add + 1
        Else
            For Each lst As ListViewItem In lsvAddedExpenses.Items
                type = lst.Text
                amount = lst.SubItems(1).Text

                If cboexpensestype.Text = type Then
                    amount = Integer.Parse(txtamount.Text) + amount
                    lst.SubItems(1).Text = amount.ToString()
                    new_info = 0
                End If
            Next
            If new_info = 1 Then
                Dim x As Integer = lsvAddedExpenses.Items.Count
                lsvAddedExpenses.Items.Add(cboexpensestype.Text)
                lsvAddedExpenses.Items(x).SubItems.Add(txtamount.Text)
            End If
        End If
    End Sub
End Class