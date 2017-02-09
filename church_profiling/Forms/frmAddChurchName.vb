Public Class frmAddChurchName
    Public ch As New Church
    Public c As Integer
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblcname.Click

    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If txtChurchName.Text = "" Or txtcadrress.Text = "" Or txtccontact.Text = "" Or txtcemailadd.Text = "" Then
            MsgBox("All fields must be filled up", MsgBoxStyle.Exclamation)
        Else

                With ch
                    .Church_name = txtChurchName.Text
                    .Church_address = txtcadrress.Text
                    .Contact_no = txtccontact.Text
                .Email_ad = txtcemailadd.Text
                If btnRegister.Text = "Update" Then
                    .updateChurchInfo(c)
                    Me.clearchurchinfo()
                    .loadchurchinfo(frmchurchlist.lsvChurch)
                    Me.Close()

                Else
                    .saveChurch()
                    .loadchurchinfo(frmchurchlist.lsvChurch)
                    clearchurchinfo()
                End If
                End With

        End If


    End Sub
    Public Sub clearchurchinfo()
        txtChurchName.Clear()
        txtcadrress.Clear()
        txtccontact.Clear()
        txtcemailadd.Clear()
        txtChurchName.Select()
    End Sub

    Private Sub txtChurchName_TextChanged(sender As Object, e As EventArgs) Handles txtChurchName.TextChanged
        If txtChurchName.Text.Length < 1 Then
            lblcname.Visible = True
        Else
            lblcname.Visible = False
        End If
    End Sub

    Private Sub txtcadrress_TextChanged(sender As Object, e As EventArgs) Handles txtcadrress.TextChanged
        If txtcadrress.Text.Length < 1 Then
            lblcadress.Visible = True
        Else
            lblcadress.Visible = False
        End If
    End Sub

    Private Sub txtccontact_TextChanged(sender As Object, e As EventArgs) Handles txtccontact.TextChanged
        If txtccontact.Text.Length < 1 Then
            lblccontact.Visible = True
        Else
            lblccontact.Visible = False
        End If
    End Sub

    Private Sub txtcemailadd_TextChanged(sender As Object, e As EventArgs) Handles txtcemailadd.TextChanged
        If txtcemailadd.Text.Length < 1 Then
            lblemail.Visible = True
        Else
            lblemail.Visible = False
        End If
    End Sub

    Private Sub frmAddChurchName_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If btnRegister.Text = "Update" Then
            ch.displayforEdit(c)
            txtChurchName.Text = ch.Church_name
            txtcadrress.Text = ch.Church_address
            txtccontact.Text = ch.Contact_no
            txtcemailadd.Text = ch.Email_ad

        End If
    End Sub

    Private Sub frmAddChurchName_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.clearchurchinfo()
    End Sub

    Private Sub frmAddChurchName_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub
End Class