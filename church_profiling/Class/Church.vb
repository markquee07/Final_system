Public Class Church
    Public id As Integer
    Public Church_name As String
    Public Church_address As String
    Public Contact_no As String
    Public Email_ad As String

    Public Sub saveChurch()
        Dim sql As String = "insert into tbl_church_information values (null,'" & Me.Church_name & "','" & Me.Church_address & "','" & Me.Contact_no & "', '" & Me.Email_ad & "')"
        GLOBAL_VARS.db.executeNonReader(sql)
        MsgBox("successfully saved", MsgBoxStyle.Information)
        GLOBAL_VARS.db.reader.Close()
    End Sub

    Public Sub loadchurchinfo(ByVal lsv As ListView)
        Dim sql As String = "SELECT * FROM tbl_church_information "
        GLOBAL_VARS.db.execute(sql)
        lsv.Items.Clear()
        If GLOBAL_VARS.db.reader.HasRows Then
            While GLOBAL_VARS.db.reader.Read()
                Dim i As Integer = lsv.Items.Count
                With lsv
                    .Items.Add(GLOBAL_VARS.db.reader("ID").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("church_name").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("church_address").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("contact_no").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("email_ad").ToString())
                End With
            End While
        End If
        GLOBAL_VARS.db.reader.Close()
    End Sub
    Public Sub displayforEdit(ByVal u_id As Integer)

        Dim sql As String = "SELECT * FROM tbl_church_information where id= " & u_id & ";"
        GLOBAL_VARS.db.execute(sql)
        If GLOBAL_VARS.db.reader.HasRows Then
            GLOBAL_VARS.db.reader.Read()
            With Me
                .id = GLOBAL_VARS.db.reader("ID").ToString()
                .Church_name = GLOBAL_VARS.db.reader("church_name").ToString()
                .Church_address = GLOBAL_VARS.db.reader("church_address").ToString()
                .Contact_no = GLOBAL_VARS.db.reader("contact_no").ToString()
                .Email_ad = GLOBAL_VARS.db.reader("email_ad").ToString()


            End With
        End If
        GLOBAL_VARS.db.reader.Close()
    End Sub
    Public Sub deleteChurchInfo(ByVal id As Integer)
        Dim sql As String = "DELETE FROM tbl_church_information WHERE ID=" & id
        GLOBAL_VARS.db.executeNonReader(sql)
        MsgBox("Successfully Deleted", MsgBoxStyle.Information, "Information")
    End Sub
    Public Sub updateChurchInfo(ByVal id As Integer)
        Dim sql As String = "UPDATE tbl_church_information SET " & _
                           "Church_name='" & Me.Church_name & "'," & _
                           "church_address='" & Me.Church_address & "', " & _
                           "contact_no='" & Me.Contact_no & "' , " & _
                           "email_ad='" & Me.Email_ad & "'  " & _
                           "WHERE ID=" & id
        GLOBAL_VARS.db.executeNonReader(sql)
        MsgBox("Succesfuly Updated", MsgBoxStyle.Information, "information")
    End Sub

    Public Sub searchchurch(search_key As String, lsv As ListView)

        Dim sql As String = "SELECT * FROM tbl_church_information where church_name LIKE '%" & search_key & "%' or church_address LIKE '%" & search_key & "%' or email_ad LIKE '%" & search_key & "%';"
        GLOBAL_VARS.db.execute(sql)
        lsv.Items.Clear()
        If GLOBAL_VARS.db.reader.HasRows Then
            While GLOBAL_VARS.db.reader.Read()
                Dim i As Integer = lsv.Items.Count
                With lsv
                    .Items.Add(GLOBAL_VARS.db.reader("ID").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("Church_name").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("church_address").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("contact_no").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("email_ad").ToString())
                End With
            End While
        End If
        GLOBAL_VARS.db.reader.Close()
    End Sub

End Class
