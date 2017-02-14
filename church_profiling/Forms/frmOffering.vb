Public Class frmOffering
    Public active_id As Integer
    Dim var As Integer = 0
    Public add As Integer = 1
   

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim type As String
        Dim amount As Double
        Dim new_info As Integer = 1
        If add = 1 Then
            Dim x As Integer = lsvAddedOfferings.Items.Count
            lsvAddedOfferings.Items.Add(cboofferingtype.Text)
            lsvAddedOfferings.Items(x).SubItems.Add(txtamount.Text)
            add = add + 1
        Else
            For Each lst As ListViewItem In lsvAddedOfferings.Items
                type = lst.Text
                amount = lst.SubItems(1).Text

                If cboofferingtype.Text = type Then
                    amount = Integer.Parse(txtamount.Text) + amount
                    lst.SubItems(1).Text = amount.ToString()
                    new_info = 0
                End If
            Next
            If new_info = 1 Then
                Dim x As Integer = lsvAddedOfferings.Items.Count
                lsvAddedOfferings.Items.Add(cboofferingtype.Text)
                lsvAddedOfferings.Items(x).SubItems.Add(txtamount.Text)
            End If
        End If
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim o As New Offering
        With o
            .offering_type = cboofferingtype.Text
            .amount = Val(txtamount.Text)
            If Trim(cboofferingtype.Text) = "" Then
                MsgBox("Empty field")
            Else
                For Each lst As ListViewItem In lsvAddedOfferings.Items
                    o.offering_type = lst.Text
                    o.amount = lst.SubItems(1).Text
                    .savechurchOffering()
                Next
                MsgBox("Offerings Saved", MsgBoxStyle.Information)
                cboofferingtype.Text = ""
                txtamount.Clear()
                lsvAddedOfferings.Items.Clear()
                '.displayListOfExpenses(lsvlistofexpenses)
            End If
        End With
    End Sub
End Class