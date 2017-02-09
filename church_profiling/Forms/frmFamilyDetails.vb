Public Class frmFamilyDetails
    Public c As New cart()
    Public prt As Integer
    Private Sub frmFamilyDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        c.displayFamilyDetails(lsvListOffamilydetails, frmListOfHousehold.p_id2)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmSiblingsRegistration.ShowDialog()
    End Sub
End Class