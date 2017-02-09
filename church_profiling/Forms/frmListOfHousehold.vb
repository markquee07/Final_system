Public Class frmListOfHousehold

    Public c As New cart
    Public p_id As Integer
    Public p_id2 As Integer

    Private Sub frmListOfHousehold_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        c.displayMemberInformation(lsvListOfMember)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim selected_p_id = lsvListOfMember.SelectedItems.Count
        If selected_p_id <= 0 Then
            MsgBox("Please select member", MsgBoxStyle.Information, "Information")
        Else
            If Button1.Text = "Edit" Then
                frmMember_registration.m_id = p_id
                frmMember_registration.btnSave.Text = "Update"
                frmMember_registration.ShowDialog()
            Else
                p_id2 = p_id
                frmViewMemberDetails.ShowDialog()
            End If
           
        End If
    End Sub

    Private Sub lsvListOfMember_Click(sender As Object, e As EventArgs) Handles lsvListOfMember.Click
        p_id = lsvListOfMember.SelectedItems(0).SubItems(0).Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim selected_p_id = lsvListOfMember.SelectedItems.Count
        If selected_p_id <= 0 Then
            MsgBox("Please select member", MsgBoxStyle.Information, "Information")
        Else
            p_id2 = p_id
            frmFamilyDetails.ShowDialog()
        End If
        selected_p_id = 0
    End Sub
End Class