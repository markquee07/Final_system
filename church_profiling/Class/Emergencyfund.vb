Public Class Emergencyfund
    Public First_name As String
    Public Fullname As String
    Public Last_name As String
    Public member_id As Integer
    Public members_id As String
    Public amount_borrowed As Double
    Public due_date As String
    Public date_borrowed As String
    Public amount_tendered As Double
    Public status As String
    Public balance As String
    Public val As String

    Public Sub saveEmergencyFund()
        Dim sql As String = "INSERT INTO  tbl_emergency_funds " & _
               "VALUES(NULL," & Me.member_id & "," & Me.amount_borrowed & ",'" & Me.date_borrowed & "','" & Me.due_date & "','" & status & "');"
        GLOBAL_VARS.db.executeNonReader(sql)
        MsgBox("Transaction Saved", MsgBoxStyle.Information, "Emergency Funds")
        updateEmergencyBudget(1, 1000 - amount_borrowed)
    End Sub

    Public Sub updateEmergencyBudget(ByVal id As Integer, ammount As Integer)
        Dim sql As String = "update tbl_emergency_fund_budget set amount = " & ammount & " where id= " & id & ""
        GLOBAL_VARS.db.executeNonReader(sql)
    End Sub

    Public Sub displayMemberToBorrow(ByVal lsv As ListView)
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

    Public Sub serachMemberToBorrow(ByVal lsv As ListView, key As String)
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

    Public Function checkEmergencyBudget() As String

        Dim sql As String = "SELECT if(amount = 0,'Unavailable',amount) as availability FROM tbl_emergency_fund_budget"
        GLOBAL_VARS.db.execute(sql)

        While GLOBAL_VARS.db.reader.Read()
            If GLOBAL_VARS.db.reader.HasRows Then
                val = GLOBAL_VARS.db.reader("availability").ToString()
            End If
        End While
        GLOBAL_VARS.db.reader.Close()
        Return val
    End Function

    Public Sub displayCurrentBorrower()
        Dim sql As String = "SELECT m.member_id,concat(m.first_name,' ',m.middle_name,' ',m.last_name) as fullname,date_format(e.date_borrowed,'%M %d, %Y') as Date_borrowed,date_format(e.due_date,'%M %d, %Y') as due_date,e.status FROM tbl_member_information m inner join tbl_emergency_funds e where e.status = 'unpaid'"
        GLOBAL_VARS.db.execute(sql)

        While GLOBAL_VARS.db.reader.Read()
            If GLOBAL_VARS.db.reader.HasRows Then
                With Me
                    .members_id = GLOBAL_VARS.db.reader("member_id").ToString()
                    .Fullname = GLOBAL_VARS.db.reader("fullname").ToString()
                    .date_borrowed = GLOBAL_VARS.db.reader("date_borrowed").ToString()
                    .due_date = GLOBAL_VARS.db.reader("due_date").ToString()
                    .status = GLOBAL_VARS.db.reader("status").ToString()
                End With
            End If
        End While
        GLOBAL_VARS.db.reader.Close()
    End Sub
    Public Sub currentBalance()
        Dim sql As String = "SELECT 1000 - amount as balance FROM tbl_emergency_fund_budget"
        GLOBAL_VARS.db.execute(sql)

        While GLOBAL_VARS.db.reader.Read()
            If GLOBAL_VARS.db.reader.HasRows Then
                With Me
                    .balance = GLOBAL_VARS.db.reader("balance").ToString()
                End With
            End If
        End While
        GLOBAL_VARS.db.reader.Close()
    End Sub
End Class
