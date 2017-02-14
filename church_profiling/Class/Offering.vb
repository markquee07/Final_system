Public Class Offering

    Public ID As Integer
    Public offering_type As String
    Public amount As Double
    Public church_pastor_share As Double
    Public district_modearator_share As Double
    Public main_church_share As Double

    Public Sub savechurchOffering()
        Dim sql As String = "INSERT INTO  tbl_offerings " & _
               "VALUES(NULL,'" & Me.offering_type & "'," & Me.amount & ",NOW());"
        GLOBAL_VARS.db.executeNonReader(sql)
    End Sub
    Public Sub displayListOfOfferings(ByVal lsv As ListView)
        lsv.Items.Clear()
        Dim sql As String = "SELECT * FROM  tbl_offerings;"
        GLOBAL_VARS.db.execute(sql)
        If GLOBAL_VARS.db.reader.HasRows Then
            While GLOBAL_VARS.db.reader.Read()
                Dim i As Integer = lsv.Items.Count
                With lsv
                    .Items.Add(GLOBAL_VARS.db.reader("ID").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("offering_type").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("amount").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("date").ToString())
                End With
            End While
        End If
        GLOBAL_VARS.db.reader.Close()
    End Sub
    Public Sub updateSelectedOffering(ByVal id As Integer)
        Dim sql As String = "UPDATE tbl_offerings SET " & _
                           "offering_type='" & Me.offering_type & "'," & _
                           "amount=" & Me.amount & " " & _
                           "WHERE ID=" & id
        GLOBAL_VARS.db.executeNonReader(sql)
        MsgBox("Offering Record Updated")
    End Sub

    Public Sub loadSelectedOfferingtype(ByVal id As Integer)
        Dim sql As String = "SELECT * FROM tbl_offerings WHERE ID=" & id
        GLOBAL_VARS.db.execute(sql)
        If GLOBAL_VARS.db.reader.HasRows Then
            GLOBAL_VARS.db.reader.Read()
            With Me
                .offering_type = GLOBAL_VARS.db.reader("offering_type").ToString()
                .amount = GLOBAL_VARS.db.reader("Amount").ToString()
            End With
        End If
        GLOBAL_VARS.db.reader.Close()
    End Sub

    Public Sub deleteOffering(ByVal id As Integer)
        Dim sql As String
        sql = "DELETE FROM tbl_offerings WHERE ID=" & id
        GLOBAL_VARS.db.executeNonReader(sql)
        MsgBox("Offering record Deleted")
    End Sub


    Public Sub displayOfferingListByDateRange(ByVal lsv As ListView, ByVal start_date As String, ByVal end_date As String)
        lsv.Items.Clear()
        Dim sql As String = "SELECT * FROM tbl_offerings " & _
                            "WHERE DATE_FORMAT(date,'%Y-%m-%d') " & _
                            "between '" & start_date & "' AND '" & end_date & "';"
        GLOBAL_VARS.db.execute(sql)

        If GLOBAL_VARS.db.reader.HasRows Then
            While GLOBAL_VARS.db.reader.Read()
                Dim i As Integer = lsv.Items.Count
                With lsv
                    .Items.Add(GLOBAL_VARS.db.reader("ID").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("offering_type").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("amount").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("date").ToString())
                    
                End With
            End While
        End If
        GLOBAL_VARS.db.reader.Close()
    End Sub
End Class
