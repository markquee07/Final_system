Public Class Expenses
    Public ID As Integer
    Public expenses_type As String
    Public amount As Double



    Public Sub savechurchExpenses()
        Dim sql As String = "INSERT INTO  tbl_church_expenses " & _
               "VALUES(NULL,'" & Me.expenses_type & "'," & Me.amount & ",NOW());"
        GLOBAL_VARS.db.executeNonReader(sql)
        MsgBox("New Expenses Saved")
    End Sub
    Public Sub displayListOfExpenses(ByVal lsv As ListView)
        lsv.Items.Clear()
        Dim sql As String = "SELECT * FROM  tbl_church_expenses;"
        GLOBAL_VARS.db.execute(sql)
        If GLOBAL_VARS.db.reader.HasRows Then
            While GLOBAL_VARS.db.reader.Read()
                Dim i As Integer = lsv.Items.Count
                With lsv
                    .Items.Add(GLOBAL_VARS.db.reader("ID").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("Expenses_type").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("Amount").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("date").ToString())
                End With
            End While
        End If
        GLOBAL_VARS.db.reader.Close()
    End Sub
    Public Sub updateSelectedExpense(ByVal id As Integer)
        Dim sql As String = "UPDATE tbl_church_expenses SET " & _
                           "Expenses_type='" & Me.expenses_type & "'," & _
                           "Amount=" & Me.amount & " " & _
                           "WHERE ID=" & id
        GLOBAL_VARS.db.executeNonReader(sql)
        MsgBox("Expenses Record Updated")
    End Sub

    Public Sub loadSelectedExpense(ByVal id As Integer)
        Dim sql As String = "SELECT * FROM tbl_church_expenses WHERE ID=" & id
        GLOBAL_VARS.db.execute(sql)
        If GLOBAL_VARS.db.reader.HasRows Then
            GLOBAL_VARS.db.reader.Read()
            With Me
                .expenses_type = GLOBAL_VARS.db.reader("Expenses_type").ToString()
                .amount = GLOBAL_VARS.db.reader("Amount").ToString()
            End With
        End If
        GLOBAL_VARS.db.reader.Close()
    End Sub

    Public Sub deleteExpenses(ByVal id As Integer)
        Dim sql As String
        sql = "DELETE FROM tbl_church_expenses WHERE ID=" & id
        GLOBAL_VARS.db.executeNonReader(sql)
        MsgBox("Expenses record Deleted")
    End Sub

End Class
