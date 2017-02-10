Public Class frmListOfAttendance

    Public att As New Attendance
    Private Sub frmListOfAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        att.displayAllAttendance(lsvListOfAttendance)
    End Sub
End Class