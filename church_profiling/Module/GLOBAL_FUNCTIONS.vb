Module GLOBAL_FUNCTIONS
    Public Function isGroupFilledUp(container As Panel) As Boolean
        Dim has_data As Boolean = False
        For Each ctl As Control In container.Controls
            If TypeOf ctl Is Panel Or TypeOf ctl Is GroupBox Then
                GLOBAL_FUNCTIONS.isGroupFilledUp(ctl)
            Else
                If TypeOf ctl Is TextBox Then
                    Dim txt As New TextBox
                    txt = ctl
                    If Trim(txt.Text) <> "" Then
                        has_data = True
                    End If

                End If
                If TypeOf ctl Is CheckBox Then
                    Dim chk As New CheckBox
                    chk = ctl
                    If chk.Checked Then
                        has_data = True
                    End If
                End If
            End If
        Next
        Return has_data
    End Function
End Module
