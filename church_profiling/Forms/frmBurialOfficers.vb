Public Class frmBurialOfficers

    Public c As New cart

    Public button_no As Integer
    Public officials As New Collection
    Public o_position As String
    Dim active_official As New Selected_Official

    Private Sub frmBurialOfficers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnHostPastor_Click(sender As Object, e As EventArgs) Handles btnHostPastor.Click
        button_no = 1
        o_position = "PRESIDENT"
        c.displayMemberForChurchOfficial(lsvMemberList)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        button_no = 2
        o_position = "VICE-PRESIDENT"
        c.displayMemberForChurchOfficial(lsvMemberList)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        button_no = 3
        o_position = "TREASURER"
        c.displayMemberForChurchOfficial(lsvMemberList)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        button_no = 4
        o_position = "SECRETARY"
        c.displayMemberForChurchOfficial(lsvMemberList)
    End Sub

    Private Sub lsvMemberList_Click(sender As Object, e As EventArgs) Handles lsvMemberList.Click
        If button_no = 1 Then
            txtpresident.Text = lsvMemberList.SelectedItems(0).SubItems(2).Text
        ElseIf button_no = 2 Then
            txtVice_president.Text = lsvMemberList.SelectedItems(0).SubItems(2).Text
        ElseIf button_no = 3 Then
            txtTreasurer.Text = lsvMemberList.SelectedItems(0).SubItems(2).Text
        ElseIf button_no = 4 Then
            txtSecretary.Text = lsvMemberList.SelectedItems(0).SubItems(2).Text
        End If

        Dim active_id As Integer = lsvMemberList.SelectedItems(0).Text
        Me.active_official = New Selected_Official
        Me.active_official.member.loadMember(active_id)
        Me.active_official.position = Me.o_position
        Me.setOfficial()
    End Sub

    Private Sub setOfficial()
        'check if exist
        Dim index As Integer = 1
        For Each official As Selected_Official In Me.officials
            If official.position = Me.active_official.position Then
                Me.officials.Remove(index)
                Exit For
            End If
            index = index + 1
        Next

        'save
        Me.officials.Add(active_official)
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        If txtpresident.Text = Nothing Or txtVice_president.Text = Nothing Or txtTreasurer.Text = Nothing Or txtSecretary.Text = Nothing Then
            MsgBox("Please make sure to set all the official before saving", MsgBoxStyle.Exclamation, "Warning")
        Else
            For Each mem As Selected_Official In Me.officials
                c.saveBurialOfficial(mem.member.id, mem.position, txtYear.Text)
            Next
        End If
        MsgBox("Burial Officials Successfully Save", MsgBoxStyle.Information)
        txtpresident.Clear()
        txtVice_president.Clear()
        txtTreasurer.Clear()
        txtSecretary.Clear()
        lsvMemberList.Items.Clear()
    End Sub
End Class