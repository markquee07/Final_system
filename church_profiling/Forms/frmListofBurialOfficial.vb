Public Class frmListofBurialOfficial

    Public c As New cart
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Length > 0 Then
            lblSearchMember.Visible = False
        Else
            lblSearchMember.Visible = True
        End If
    End Sub

    Private Sub frmListofBurialOfficial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        c.displayBurialOfficial(lsvBurialOfficial)
    End Sub
End Class