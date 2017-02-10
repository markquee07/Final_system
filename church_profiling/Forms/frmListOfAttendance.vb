Public Class frmListOfAttendance

    Public att As New Attendance
    Private Sub frmListOfAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        att.displayAllAttendance(lsvListOfAttendance)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class