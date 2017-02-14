Public Class frmListofPastor
    Public p As New Pastor
    Public pa_id As Integer
    Private Sub frmListofPastor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        p.displayPastor(lsvPastor)
        txtSearch.Select()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Length > 0 Then
            lblPastor.Visible = False
            p.searchPastor(lsvPastor, txtSearch.Text)
        Else
            p.displayPastor(lsvPastor)
            lblPastor.Visible = True
        End If

    End Sub

    Private Sub btnAddChurch_Click(sender As Object, e As EventArgs) Handles btnAddChurch.Click
        Dim i As Integer = lsvPastor.SelectedItems.Count
        If i <= 0 Then
            MsgBox("Please select data first", MsgBoxStyle.Information, "Pastor")
        Else
            frmPastorViewDetails.p_id = pa_id
            frmPastorViewDetails.ShowDialog()
        End If
       
    End Sub

    Private Sub lsvPastor_Click(sender As Object, e As EventArgs) Handles lsvPastor.Click
        pa_id = lsvPastor.SelectedItems(0).Text
    End Sub
End Class