Public Class Expenditure
    Public ID As Integer
    Public Expenditures_type As String
    Public amount As Double
    Public Member_name As String
    Public member_id As Integer



    Public Sub saveExpenditure()
        Dim sql As String = "INSERT INTO  tbl_expenditures " & _
               "VALUES(NULL,'" & Me.Expenditures_type & "'," & member_id & ",NOW());"
        GLOBAL_VARS.db.executeNonReader(sql)
        MsgBox("New Expenditure Saved")
    End Sub

    Public Sub displayMemberExpenditure(ByVal lsv As ListView)
        lsv.Items.Clear()
        Dim sql As String = "SELECT id,member_id,concat(first_name,' ',middle_name,' ',last_name) as fullname FROM tbl_member_information"
        GLOBAL_VARS.db.execute(sql)
        If GLOBAL_VARS.db.reader.HasRows Then
            While GLOBAL_VARS.db.reader.Read()
                Dim i As Integer = lsv.Items.Count
                With lsv
                    .Items.Add(GLOBAL_VARS.db.reader("id").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("member_id").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("Fullname").ToString())
                End With
            End While
        End If
        GLOBAL_VARS.db.reader.Close()
    End Sub

    Public Sub serachMember(ByVal lsv As ListView, key As String)
        lsv.Items.Clear()
        Dim sql As String = "SELECT id,member_id,concat(first_name,' ',middle_name,' ',last_name) as fullname FROM tbl_member_information where first_name Like '%" & key & "%' or last_name Like '%" & key & "%' Or member_id Like '%" & key & "%'"
        GLOBAL_VARS.db.execute(sql)
        If GLOBAL_VARS.db.reader.HasRows Then
            While GLOBAL_VARS.db.reader.Read()
                Dim i As Integer = lsv.Items.Count
                With lsv
                    .Items.Add(GLOBAL_VARS.db.reader("id").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("member_id").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("Fullname").ToString())
                End With
            End While
        End If
        GLOBAL_VARS.db.reader.Close()
    End Sub


    Public Sub displayListOfExpenditure(ByVal lsv As ListView)
        lsv.Items.Clear()
        Dim sql As String = "SELECT * FROM  tbl_expenditures;"
        GLOBAL_VARS.db.execute(sql)
        If GLOBAL_VARS.db.reader.HasRows Then
            While GLOBAL_VARS.db.reader.Read()
                Dim i As Integer = lsv.Items.Count
                With lsv
                    .Items.Add(GLOBAL_VARS.db.reader("ID").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("Expenditures_type").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("Date").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("Member_name").ToString())
                End With
            End While
        End If
        GLOBAL_VARS.db.reader.Close()
    End Sub
    Public Sub updateSelectedExpenditure(ByVal id As Integer)
        Dim sql As String = "UPDATE tbl_expenditures SET " & _
                           "Expenditures_type='" & Me.Expenditures_type & "' WHERE ID=" & id
        GLOBAL_VARS.db.executeNonReader(sql)
        MsgBox("Expenditure Record Updated")
    End Sub

    Public Sub loadSelectedExpenditure(ByVal id As Integer)
        Dim sql As String = "SELECT * FROM tbl_expenditures WHERE ID=" & id
        GLOBAL_VARS.db.execute(sql)
        If GLOBAL_VARS.db.reader.HasRows Then
            GLOBAL_VARS.db.reader.Read()
            With Me
                .Expenditures_type = GLOBAL_VARS.db.reader("Expenditures_type").ToString()
            End With
        End If
        GLOBAL_VARS.db.reader.Close()
    End Sub

    Public Sub deleteExpenditure(ByVal id As Integer)
        Dim sql As String
        sql = "DELETE FROM tbl_expenditures WHERE ID=" & id
        GLOBAL_VARS.db.executeNonReader(sql)
        MsgBox("Expenditure record Deleted")
    End Sub

    

End Class
