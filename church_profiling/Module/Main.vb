Module Main
    Public Sub main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        With GLOBAL_VARS.db
            .server = "localhost"
            .user = "root"
            .password = ""
            .db = "church_profiling_monitoring"
            .port = "3306"

            If .connect() Then
                MsgBox("Database Connected")
                frmUser_login.ShowDialog()
            End If

        End With
    End Sub
End Module
