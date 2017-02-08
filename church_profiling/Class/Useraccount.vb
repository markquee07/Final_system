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
End Class
