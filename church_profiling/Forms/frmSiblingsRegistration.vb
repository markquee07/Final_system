Public Class frmSiblingsRegistration

    'Member last id
    Public mem_last_id As Integer
    'cart instantation
    Public carts As New cart
    'collection for siblings
    Public sibling_list As New Collection

    'Count variables
    Public male_count As Integer
    Public female_count As Integer

    'Adding to listview variables
    Public row As Integer
    Public siblings_id As String
    Public fname As String
    Public lname As String
    Public Mname As String
    Public birth_date As String
    Public gender As String
    Public church_member As String

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        addToLisView()
        Me.countMaleAndFemale()
    End Sub

    Public Sub addToLisView()

        If cboxYes.Checked = True Then
            church_member = "Yes"
        Else
            church_member = "No"
        End If

        row = lsvSiblingsInformation.Items.Count
        lsvSiblingsInformation.Items.Add(lblId.Text)
        lsvSiblingsInformation.Items(row).SubItems.Add(txtFname.Text)
        lsvSiblingsInformation.Items(row).SubItems.Add(txtLname.Text)
        lsvSiblingsInformation.Items(row).SubItems.Add(txtMiddlename.Text)
        lsvSiblingsInformation.Items(row).SubItems.Add(dtpBirthDate.Text)
        lsvSiblingsInformation.Items(row).SubItems.Add(cboGender.Text)
        lsvSiblingsInformation.Items(row).SubItems.Add(church_member)

        txtFname.Clear()
        txtLname.Clear()
        txtMiddlename.Clear()
        cboGender.Text = ""
        cboxYes.Checked = False
        cboxNo.Checked = False
        txtFname.Focus()

    End Sub

    Public Function generatedID(ByVal len As Integer)
        Dim pool As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim rnd As New Random
        Dim result As String = ""

        Dim cc = 0
        While cc <= len
            result &= pool(rnd.Next(0, pool.Length))
            cc += 1
        End While

        Return result
    End Function

    Public Sub countMaleAndFemale()
        If cboGender.Text = "MALE" Then
            male_count = male_count + 1
            If male_count > 9 Then
                lblMaleCount.Location = New Point(118, 18)
            End If
            lblMaleCount.Text = male_count.ToString()
        Else
            female_count = female_count + 1
            If male_count > 9 Then
                lblFemaleCount.Location = New Point(321, 18)
            End If
            lblFemaleCount.Text = female_count.ToString()
        End If
    End Sub


    Private Sub lblFname_Click(sender As Object, e As EventArgs) Handles lblFname.Click
        txtFname.Focus()
    End Sub

    Private Sub txtFname_TextChanged(sender As Object, e As EventArgs) Handles txtFname.TextChanged
        If txtFname.Text.Length > 0 Then
            lblFname.Visible = False
        Else
            lblFname.Visible = True
        End If
    End Sub

    Private Sub lblLname_Click(sender As Object, e As EventArgs) Handles lblLname.Click
        txtLname.Focus()
    End Sub

    Private Sub txtLname_TextChanged(sender As Object, e As EventArgs) Handles txtLname.TextChanged
        If txtLname.Text.Length > 0 Then
            lblLname.Visible = False
        Else
            lblLname.Visible = True
        End If
    End Sub

    Private Sub lblMname_Click(sender As Object, e As EventArgs) Handles lblMname.Click
        txtMiddlename.Focus()
    End Sub

    Private Sub txtMiddlename_TextChanged(sender As Object, e As EventArgs) Handles txtMiddlename.TextChanged
        If txtMiddlename.Text.Length > 0 Then
            lblMname.Visible = False
        Else
            lblMname.Visible = True
        End If
    End Sub

    Private Sub cboGender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGender.SelectedIndexChanged
        lblGender.Visible = False
    End Sub

    Private Sub dtpBirthDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpBirthDate.ValueChanged
        lblBirthDate.Visible = False
    End Sub

    Private Sub cboxYes_CheckedChanged(sender As Object, e As EventArgs) Handles cboxYes.CheckedChanged
        cboxNo.Checked = False
    End Sub

    Private Sub cboxNo_CheckedChanged(sender As Object, e As EventArgs) Handles cboxNo.CheckedChanged
        cboxYes.Checked = False
    End Sub

    Private Sub cboxYes_Click(sender As Object, e As EventArgs) Handles cboxYes.Click
        cboxNo.Checked = False
    End Sub

    Private Sub cboxNo_Click(sender As Object, e As EventArgs) Handles cboxNo.Click
        cboxYes.Checked = False
    End Sub

    Private Sub frmSiblingsRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox(lblId.Text)
    End Sub

    Public Sub clearAllInformation()
        lsvSiblingsInformation.Items.Clear()
        lblMaleCount.Text = "0"
        lblFemaleCount.Text = "0"

        txtFname.Clear()
        txtLname.Clear()
        txtMiddlename.Clear()
        cboGender.Text = ""
        cboxYes.Checked = False
        cboxNo.Checked = False

        txtFname.Focus()
    End Sub

    Private Sub frmSiblingsRegistration_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        clearAllInformation()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        With frmMember_registration
            carts.s_count = 1
            .defualtValue()
            .c.savePersonalInformation()
        End With
        Me.saveSiblingsInfo()
        MsgBox("Successfully saved", MsgBoxStyle.Information)
        frmMember_registration.clearMemberInformation()
        clearAllInformation()
        Me.Dispose()
        Me.Close()
        carts.displayFamilyDetails(frmFamilyDetails.lsvListOffamilydetails, mem_last_id)
    End Sub

    Public Sub saveSiblingsInfo()
        For Each lsv As ListViewItem In lsvSiblingsInformation.Items
            Dim x As Integer = lsvSiblingsInformation.Items.Count
            carts.s_siblings_id = lsv.Text
            carts.s_First_name = lsv.SubItems(1).Text
            carts.s_Last_name = lsv.SubItems(2).Text
            carts.s_Middle_name = lsv.SubItems(3).Text
            carts.s_Date_of_birth = lsv.SubItems(4).Text
            carts.s_Gender = lsv.SubItems(5).Text
            carts.s_Church_member = lsv.SubItems(6).Text

            carts.saveSiblingsInformation(Me.mem_last_id)
        Next
    End Sub
End Class