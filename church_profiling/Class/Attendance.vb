Public Class Attendance

    Public member_id As Integer
    Public activity_type As String
    Public date_ As String
    Public meeting_time As String
    Public status As String
    Public description As String

    Public Sub saveAttendanceInfo()
        Dim sql As String = "insert into tbl_attendance values (" & Me.member_id & ",'" & Me.activity_type & "','" & Me.date_ & "','" & Me.meeting_time & "','" & Me.status & "','" & Me.description & "');"
        GLOBAL_VARS.db.executeNonReader(sql)
        MsgBox("Attendance Information Successfully Saved", MsgBoxStyle.Information)
        GLOBAL_VARS.db.reader.Close()
    End Sub

    Public Sub displayAllMembersForAttendance(ByVal lsv As ListView)
        lsv.Items.Clear()
        Dim sql As String = "SELECT id,Member_id,concat(first_name,' ',middle_name,' ',last_name) as full_name,gender FROM tbl_member_information;"
        GLOBAL_VARS.db.execute(sql)
        If GLOBAL_VARS.db.reader.HasRows Then
            While GLOBAL_VARS.db.reader.Read()
                Dim i As Integer = lsv.Items.Count
                With lsv
                    .Items.Add(GLOBAL_VARS.db.reader("ID").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("member_id").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("full_name").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("gender").ToString())
                End With
            End While
        End If
        GLOBAL_VARS.db.reader.Close()
    End Sub


    Public Sub searchMember(ByVal lsv As ListView, ByVal search_keyword As String)
        lsv.Items.Clear()
        Dim sql As String = "SELECT id,Member_id,concat(first_name,' ',middle_name,' ',last_name) as full_name,gender FROM tbl_member_information where member_id like '%" & search_keyword & "%';"
        GLOBAL_VARS.db.execute(sql)
        If GLOBAL_VARS.db.reader.HasRows Then
            While GLOBAL_VARS.db.reader.Read()
                Dim i As Integer = lsv.Items.Count
                With lsv
                    .Items.Add(GLOBAL_VARS.db.reader("ID").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("member_id").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("full_name").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("gender").ToString())
                End With
            End While
        End If
        GLOBAL_VARS.db.reader.Close()
    End Sub
End Class
