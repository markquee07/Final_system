Public Class Useraccount

    Public id As Integer
    Public First_Name As String
    Public Last_Name As String
    Public Username As String
    Public Password As String
    Public User_type As String
    Public Contact_no As String
    Public Date_registered As String

    Public Sub saveNewAccount()
        Dim sql As String = "insert into tbl_useraccount values (null,'" & Me.First_Name & "','" & Me.Last_Name & "','" & Me.Username & "', md5('" & Me.Password & "'),'" & Me.User_type & "'," & Me.Contact_no & ",now());"
        GLOBAL_VARS.db.executeNonReader(sql)
        MsgBox("New Account Saved", MsgBoxStyle.Information)
        GLOBAL_VARS.db.reader.Close()
    End Sub

    Public Function validateLogin() As Boolean
        Dim ret_val As Boolean = False
        Dim sql As String = "SELECT * FROM tbl_useraccount where Username = '" & Me.Username & "' and (Password = md5('" & Me.Password & "') or Password = '" & Me.Password & "');"
        GLOBAL_VARS.db.execute(sql)

        If GLOBAL_VARS.db.reader.HasRows Then
            ret_val = True
        End If
        GLOBAL_VARS.db.reader.Close()
        Return ret_val
    End Function
    Public Function isuserExist(ByVal user_name As String) As Boolean
        Dim result As Boolean = False
        Dim sql As String = "SELECT * FROM tbl_useraccount " & _
                            "WHERE username='" & user_name & "';"
        GLOBAL_VARS.db.execute(sql)
        If GLOBAL_VARS.db.reader.HasRows Then
            result = True
        End If
        GLOBAL_VARS.db.reader.Close()
        Return result
    End Function

    Public Sub loaduserc(ByVal lsv As ListView)
        Dim sql As String = "SELECT id,first_name,last_name,username,contact_no,user_type,date_format(date_registered,'%M %d, %Y') as date_registered FROM tbl_useraccount "
        GLOBAL_VARS.db.execute(sql)
        lsv.Items.Clear()
        If GLOBAL_VARS.db.reader.HasRows Then
            While GLOBAL_VARS.db.reader.Read()
                Dim i As Integer = lsv.Items.Count
                With lsv
                    .Items.Add(GLOBAL_VARS.db.reader("ID").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("first_name").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("last_name").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("username").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("contact_no").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("user_type").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("date_registered").ToString())
                End With
            End While
        End If
        GLOBAL_VARS.db.reader.Close()
    End Sub
    Public Sub displayUserSelected(ByVal u_id As Integer)

        Dim sql As String = "SELECT id,first_name,last_name,username,user_type,contact_no,password FROM tbl_useraccount where id= " & u_id & ";"
        GLOBAL_VARS.db.execute(sql)
        If GLOBAL_VARS.db.reader.HasRows Then
            GLOBAL_VARS.db.reader.Read()
            With Me
                .id = GLOBAL_VARS.db.reader("ID").ToString()
                .First_Name = GLOBAL_VARS.db.reader("First_Name").ToString()
                .Last_Name = GLOBAL_VARS.db.reader("Last_name").ToString()
                .Username = GLOBAL_VARS.db.reader("Username").ToString()
                .User_type = GLOBAL_VARS.db.reader("User_type").ToString()
                .Contact_no = GLOBAL_VARS.db.reader("Contact_no").ToString()
                .Password = GLOBAL_VARS.db.reader("password").ToString()


            End With
        End If
        GLOBAL_VARS.db.reader.Close()
    End Sub


    Public Sub searchUser(search_key As String, lsv As ListView)

        Dim sql As String = "SELECT id,first_name,last_name,username,user_type,contact_no,date_format(date_registered,'%M %d, %Y') as date_registered FROM tbl_useraccount where first_name LIKE '%" & search_key & "%' or last_name LIKE '%" & search_key & "%' or username LIKE '%" & search_key & "%';"
        GLOBAL_VARS.db.execute(sql)
        lsv.Items.Clear()
        If GLOBAL_VARS.db.reader.HasRows Then
            While GLOBAL_VARS.db.reader.Read()
                Dim i As Integer = lsv.Items.Count
                With lsv
                    .Items.Add(GLOBAL_VARS.db.reader("ID").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("first_name").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("last_name").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("username").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("user_type").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("contact_no").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("date_registered").ToString())
                End With
            End While
        End If
        GLOBAL_VARS.db.reader.Close()
    End Sub

    Public Function validateExistingAccount() As Boolean
        Dim ret_val As Boolean = False
        Dim sql As String = ""
        sql = "SELECT * FROM tbl_useraccount " & _
             "WHERE USERNAME='" & Me.Username & "' AND " & _
              "PASSWORD=md5('" & Me.Password & "');"
        GLOBAL_VARS.db.execute(sql)

        If GLOBAL_VARS.db.reader.HasRows Then
            ret_val = True
        End If
        GLOBAL_VARS.db.reader.Close()
        Return ret_val
    End Function
    Function changePassword(id As Integer, New_Password As String) As String
        Dim sql As String = "update tbl_useraccount set password = md5('" & New_Password & "') where id = " & id & ";"
        GLOBAL_VARS.db.execute(sql)
        GLOBAL_VARS.db.reader.Close()
        Return New_Password
    End Function

    Public Sub updateUser(ByVal id As Integer)
        Dim sql As String = "UPDATE tbl_useraccount SET " & _
                           "FIRST_NAME='" & Me.First_Name & "'," & _
                           "LAST_NAME='" & Me.Last_Name & "', " & _
                           "USERNAME='" & Me.Username & "' , " & _
                           "user_type='" & Me.User_type & "' , " & _
                           "contact_no='" & Me.Contact_no & "'  " & _
                           "WHERE ID=" & id
        GLOBAL_VARS.db.executeNonReader(sql)
        MsgBox("Succesfuly Updated", MsgBoxStyle.Information, "information")
    End Sub
    Public Sub deleteUSer(ByVal id As Integer)
        Dim sql As String = "DELETE FROM tbl_useraccount WHERE ID=" & id
        GLOBAL_VARS.db.executeNonReader(sql)
        MsgBox("Successfully Deleted", MsgBoxStyle.Information, "Information")
    End Sub
End Class
