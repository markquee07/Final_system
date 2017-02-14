Public Class frmChurchOfficials

    Public c As New cart
    Public loc As Integer
    Public button_no As Integer
    Public officials As New Collection
    Public o_position As String
    Dim active_official As New Selected_Official


    Private Sub btnHostPastor_Click(sender As Object, e As EventArgs) Handles btnHostPastor.Click
        txtSearch.Enabled = True
        slide_left()
        button_no = 1
        o_position = "HOST PASTOR"
    End Sub

    Public Sub slide_left()
        lsvMemberInformaion.Visible = False
        lsvPastorList.Visible = False

        PictureBox3.Visible = False
        PictureBox4.Visible = False
        lblSearchMember.Visible = False
        Label9.Visible = False
        txtSearch.Visible = False
        btnSave.Visible = False

        loc = Me.Location.X
        While (Me.Width < 1220)
            Me.Width += 1
          
        End While
        c.displayPasotr(lsvPastorList)
        lsvPastorList.Visible = True
        PictureBox3.Visible = True
        PictureBox4.Visible = True
        lblSearchMember.Visible = True
        Label9.Visible = True
        txtSearch.Visible = True
        btnSave.Visible = True

    End Sub

    Public Sub slide_right()
        While (Me.Width > 870)
            Me.Width -= 1
        End While
    End Sub

    Private Sub frmChurchOfficials_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub frmChurchOfficials_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSearch.Enabled = False
        Label10.Visible = True
        txtHostPastor.Enabled = False
        txtElder.Enabled = False
        txtDeacon1.Enabled = False
        txtDeacon2.Enabled = False
        txtDeacon3.Enabled = False
        txtSecretary.Enabled = False
        txtTreasurer.Enabled = False
    End Sub

    Private Sub lblSearchMember_Click(sender As Object, e As EventArgs) Handles lblSearchMember.Click
        txtSearch.Focus()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Length > 0 Then
            lblSearchMember.Visible = False
            If button_no = 1 Then
                c.searchPastor(txtSearch.Text, lsvPastorList)
            ElseIf button_no > 1 Then
                c.searhMemberInChurch(txtSearch.Text, lsvMemberInformaion)
            End If
        Else
            lblSearchMember.Visible = True
            If button_no = 1 Then
                c.displayPasotr(lsvPastorList)
            ElseIf button_no > 1 Then
                c.displayMemberForChurchOfficial(lsvMemberInformaion)
            End If
        End If
    End Sub

    Private Sub lsvMemberInformaion_Click(sender As Object, e As EventArgs) Handles lsvMemberInformaion.Click


        If button_no = 2 Then
            txtElder.Text = lsvMemberInformaion.SelectedItems(0).SubItems(2).Text
        ElseIf button_no = 3 Then
            txtDeacon1.Text = lsvMemberInformaion.SelectedItems(0).SubItems(2).Text
        ElseIf button_no = 4 Then
            txtDeacon2.Text = lsvMemberInformaion.SelectedItems(0).SubItems(2).Text
        ElseIf button_no = 5 Then
            txtDeacon3.Text = lsvMemberInformaion.SelectedItems(0).SubItems(2).Text
        ElseIf button_no = 6 Then
            txtTreasurer.Text = lsvMemberInformaion.SelectedItems(0).SubItems(2).Text
        ElseIf button_no = 7 Then
            txtSecretary.Text = lsvMemberInformaion.SelectedItems(0).SubItems(2).Text
        End If


        Dim active_id As Integer = lsvMemberInformaion.SelectedItems(0).Text
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
    Private Sub btnElder_Click(sender As Object, e As EventArgs) Handles btnElder.Click
        c.displayMemberForChurchOfficial(lsvMemberInformaion)
        lsvPastorList.Visible = False
        lsvMemberInformaion.Visible = True
        button_no = 2
        o_position = "ELDER"
    End Sub

    Private Sub btnDeacon1_Click(sender As Object, e As EventArgs) Handles btnDeacon1.Click
        c.displayMemberForChurchOfficial(lsvMemberInformaion)
        lsvPastorList.Visible = False
        lsvMemberInformaion.Visible = True
        button_no = 3
        o_position = "DEACON 1"
    End Sub

    Private Sub btnDeacon2_Click(sender As Object, e As EventArgs) Handles btnDeacon2.Click
        c.displayMemberForChurchOfficial(lsvMemberInformaion)
        lsvPastorList.Visible = False
        lsvMemberInformaion.Visible = True
        button_no = 4
        o_position = "DEACON 2"
    End Sub

    Private Sub btnDeacon3_Click(sender As Object, e As EventArgs) Handles btnDeacon3.Click
        c.displayMemberForChurchOfficial(lsvMemberInformaion)
        lsvPastorList.Visible = False
        lsvMemberInformaion.Visible = True
        button_no = 5
        o_position = "DEACON 3"

    End Sub

    Private Sub btnTreasurer_Click(sender As Object, e As EventArgs) Handles btnTreasurer.Click
        c.displayMemberForChurchOfficial(lsvMemberInformaion)
        lsvPastorList.Visible = False
        lsvMemberInformaion.Visible = True
        button_no = 6
        o_position = "TREASURER"

    End Sub

    Private Sub btnSecretary_Click(sender As Object, e As EventArgs) Handles btnSecretary.Click
        c.displayMemberForChurchOfficial(lsvMemberInformaion)
        lsvPastorList.Visible = False
        lsvMemberInformaion.Visible = True
        button_no = 7
        o_position = "SECRETARY"

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtHostPastor.Text = Nothing Or txtElder.Text = Nothing Or txtDeacon1.Text = Nothing Or txtDeacon2.Text = Nothing Or txtDeacon3.Text = Nothing Or txtTreasurer.Text = Nothing Or txtSecretary.Text = Nothing Then
            MsgBox("Please make sure to Complete all the Position", MsgBoxStyle.Exclamation, "Warning")

        ElseIf Trim(txtYear.Text) = Nothing Then
            MsgBox("Please Specify The Year", MsgBoxStyle.Information)
        Else
            For Each mem As Selected_Official In Me.officials
                If mem.position = "HOST PASTOR" Then
                    c.Pastor_name = txtHostPastor.Text
                End If
                c.saveChurchOfficial(mem.member.id, mem.position, txtYear.Text)
            Next
            MsgBox("New set of Church Officials successfully saved", MsgBoxStyle.Information, "Information")
        End If
        
    End Sub

    Private Sub lsvMemberInformaion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvMemberInformaion.SelectedIndexChanged

    End Sub

    Private Sub lsvPastorList_Click(sender As Object, e As EventArgs) Handles lsvPastorList.Click
        If button_no = 1 Then
            txtHostPastor.Text = lsvPastorList.SelectedItems(0).SubItems(1).Text
        End If

        Dim active_id As Integer = lsvPastorList.SelectedItems(0).Text
        Me.active_official = New Selected_Official
        Me.active_official.member.loadPastor(active_id)
        Me.active_official.position = Me.o_position
        Me.setOfficial()
    End Sub

    Private Sub txtYear_TextChanged(sender As Object, e As EventArgs) Handles txtYear.TextChanged
        If txtYear.Text.Length > 0 Then
            Label10.Visible = False
        Else
            Label10.Visible = True
        End If
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Label10.Visible = False
        txtYear.Select()
    End Sub

    Private Sub txtYear_Click(sender As Object, e As EventArgs) Handles txtYear.Click
        Label10.Visible = False
        txtYear.Select()
    End Sub
End Class