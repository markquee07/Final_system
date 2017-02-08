Public Class frmFamilyDetails
    Public c As New cart()
    Private Sub frmFamilyDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        c.displayFamilyDetails(lsvListOffamilydetails, frmListOfHousehold.p_id2)
    End Sub
End Class