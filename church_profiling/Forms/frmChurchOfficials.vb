Public Class frmChurchOfficials

    Public c As New cart
    Public loc As Integer
    Public button_no As Integer
    Public officials As New Collection
    Public o_position As String
    Dim active_official As New Selected_Official


    Private Sub btnHostPastor_Click(sender As Object, e As EventArgs) Handles btnHostPastor.Click

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

    End Sub

    Private Sub lblSearchMember_Click(sender As Object, e As EventArgs) Handles lblSearchMember.Click
        txtSearch.Focus()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Length > 0 Then
            lblSearchMember.Visible = False
        Else
            lblSearchMember.Visible = True
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
        Dim co_id As Long
        For Each mem As Selected_Official In Me.officials

            MsgBox(mem.member.id)
            If mem.position = "HOST PASTOR" Then
                c.Pastor_name = txtHostPastor.Text

            Else

            End If
        Next

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
End Class