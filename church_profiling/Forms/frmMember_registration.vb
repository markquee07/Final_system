Imports AForge.Video
Imports AForge.Video.DirectShow

Public Class frmMember_registration

   
    Dim resized As Image


    Public c As New cart
    Public cart_id As cart

    Private Sub frmMember_registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ID.Text = generatedID(8)
        dtpMarriedDate.Enabled = False
        txtWorkAddress.Enabled = False
        txtSpecify.Enabled = False
        dtpDateBaptize.Enabled = False

        txtSchoolGrad.Enabled = False
        txtSpecify.Enabled = False
        txtCourseGrad.Enabled = False
        cbLicenseYES.Enabled = False
        cbLicenseNo.Enabled = False

        txtNatureofwork.Enabled = False
        txtNameofcomp.Enabled = False
        txtSalary.Enabled = False
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

    Private Sub cbBaptizedYes_Click(sender As Object, e As EventArgs) Handles cbBaptizedYes.Click
        dtpDateBaptize.Enabled = True
        c.Baptized_status = "Yes"
        cbBaptizedNo.Checked = False
    End Sub

    Private Sub cbBaptizedNo_Click(sender As Object, e As EventArgs) Handles cbBaptizedNo.Click
        c.Baptized_status = "No"
        dtpDateBaptize.Enabled = False
        cbBaptizedYes.Checked = False
    End Sub

    Private Sub cbNone_Click(sender As Object, e As EventArgs) Handles cbNone.Click
        c.HEA = "None"
        cbCollege.Checked = False
        cbElementary.Checked = False
        cbHighSchool.Checked = False
        cbMasters.Checked = False
        cbPhD.Checked = False

        txtSchoolGrad.Enabled = False
        txtSpecify.Enabled = False
        txtCourseGrad.Enabled = False
        cbLicenseYES.Enabled = False
        cbLicenseYES.Enabled = False
    End Sub

    Private Sub cbMasters_Click(sender As Object, e As EventArgs) Handles cbMasters.Click
        c.HEA = "Master's"
        cbCollege.Checked = False
        cbElementary.Checked = False
        cbHighSchool.Checked = False
        cbNone.Checked = False
        cbPhD.Checked = False
    End Sub

    Private Sub cbElementary_Click(sender As Object, e As EventArgs) Handles cbElementary.Click
        c.HEA = "Elementary"
        cbCollege.Checked = False
        cbNone.Checked = False
        cbHighSchool.Checked = False
        cbMasters.Checked = False
        cbPhD.Checked = False

        txtSchoolGrad.Enabled = True
        txtSpecify.Enabled = False
        txtCourseGrad.Enabled = False
        cbLicenseYES.Enabled = False
        cbLicenseNo.Enabled = False
    End Sub

    Private Sub cbHighSchool_Click(sender As Object, e As EventArgs) Handles cbHighSchool.Click
        c.HEA = "High School"
        cbCollege.Checked = False
        cbElementary.Checked = False
        cbNone.Checked = False
        cbMasters.Checked = False
        cbPhD.Checked = False

        txtSchoolGrad.Enabled = True
        txtSpecify.Enabled = False
        txtCourseGrad.Enabled = False
        cbLicenseYES.Enabled = False
        cbLicenseNo.Enabled = False
    End Sub

    Private Sub cbCollege_Click(sender As Object, e As EventArgs) Handles cbCollege.Click
        c.HEA = "College"
        cbNone.Checked = False
        cbElementary.Checked = False
        cbHighSchool.Checked = False
        cbMasters.Checked = False
        cbPhD.Checked = False

        txtSchoolGrad.Enabled = True
        txtSpecify.Enabled = False
        txtCourseGrad.Enabled = True
        cbLicenseYES.Enabled = False
        cbLicenseNo.Enabled = False
    End Sub

    Private Sub cbPhD_Click(sender As Object, e As EventArgs) Handles cbPhD.Click
        c.HEA = "PhD"
        cbCollege.Checked = False
        cbElementary.Checked = False
        cbHighSchool.Checked = False
        cbMasters.Checked = False
        cbNone.Checked = False

        txtSchoolGrad.Enabled = True
        txtSpecify.Enabled = False
        txtCourseGrad.Enabled = True
        cbLicenseYES.Enabled = True
        cbLicenseNo.Enabled = True
    End Sub

    Private Sub cbLicenseYES_Click(sender As Object, e As EventArgs) Handles cbLicenseYES.Click
        txtSpecify.Enabled = True
        c.Licensure_passer = "Yes"
        cbLicenseNo.Checked = False
    End Sub

    Private Sub cbLicenseNo_Click(sender As Object, e As EventArgs) Handles cbLicenseNo.Click
        txtSpecify.Clear()
        txtSpecify.Enabled = False
        c.Licensure_passer = "No"
        cbLicenseYES.Checked = False
    End Sub

    Private Sub cbWorkYEs_Click(sender As Object, e As EventArgs) Handles cbWorkYEs.Click
        c.Work_status = "Yes"
        txtWorkAddress.Enabled = True
        cbWorkNo.Checked = False

        txtNatureofwork.Enabled = True
        txtNameofcomp.Enabled = True
        txtSalary.Enabled = True
    End Sub

    Private Sub cbWorkNo_Click(sender As Object, e As EventArgs) Handles cbWorkNo.Click
        txtWorkAddress.Clear()
        txtWorkAddress.Enabled = False
        c.Work_status = "No"
        cbWorkYEs.Checked = False

        txtNatureofwork.Enabled = False
        txtNameofcomp.Enabled = False
        txtSalary.Enabled = False
    End Sub

    Private Sub cbSingle_Click(sender As Object, e As EventArgs) Handles cbSingle.Click
        c.Civil_status = "Single"
        cbWidow.Checked = False
        cbDivorce.Checked = False
        cbMarried.Checked = False
    End Sub

    Private Sub cbMarried_Click(sender As Object, e As EventArgs) Handles cbMarried.Click
        dtpMarriedDate.Enabled = True
        c.Civil_status = "Married"
        cbWidow.Checked = False
        cbDivorce.Checked = False
        cbSingle.Checked = False
    End Sub

    Private Sub cbWidow_Click(sender As Object, e As EventArgs) Handles cbWidow.Click
        c.Civil_status = "Widow"
        cbSingle.Checked = False
        cbDivorce.Checked = False
        cbMarried.Checked = False
    End Sub

    Private Sub cbDivorce_Click(sender As Object, e As EventArgs) Handles cbDivorce.Click
        c.Civil_status = "Divorce"
        cbWidow.Checked = False
        cbSingle.Checked = False
        cbMarried.Checked = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        With c

            .Member_id = ID.Text
            .First_name = txtFname.Text
            .Last_name = txtLname.Text
            .Middle_name = txtMname.Text
            .Gender = cboGender.Text
            .Date_of_birth = dtpDateofbirth.Text
            .Blood_type = cboBloodType.Text
            .Contact_no = txtContactNo.Text
            .Email_ad = txtEmail.Text
            .Province = txtprovince.Text
            .City = txtCity.Text
            .Barangay = txtBarangay.Text
            .Church_name = txtChurchName.Text
            .Pastor_name = txtPastorName.Text
            .Baptized_date = dtpDateBaptize.Text
            .Course_graduated = txtCourseGrad.Text
            .Name_of_school_graduated = txtSchoolGrad.Text
            .License_specification = txtSpecify.Text
            .Work_address = txtWorkAddress.Text
            .Nature_of_work = txtNatureofwork.Text
            .Name_of_company = txtNameofcomp.Text
            .Salary = txtSalary.Text
            .Self_employed = txtSelfEmplyed.Text
            .Business_address = txtBusinessAddress.Text
            .Estimated_annual_income = txtEstimatedIncome.Text
            .Name_of_business = txtNameOfBusiness.Text

            Me.checkRequiredField()
        End With
    End Sub

    Public Sub uncheckedHEA()
        If cbNone.Checked = False Or cbElementary.Checked = False Or cbHighSchool.Checked = False Or cbCollege.Checked = False Or cbMasters.Checked = False Or cbPhD.Checked = False Then
            txtSchoolGrad.Enabled = False
            txtSpecify.Enabled = False
            txtCourseGrad.Enabled = False
            cbLicenseYES.Enabled = False
            cbLicenseNo.Enabled = False
        End If
    End Sub

    Private Sub cbPhD_CheckStateChanged(sender As Object, e As EventArgs) Handles cbPhD.CheckStateChanged, cbNone.CheckStateChanged, cbMasters.CheckStateChanged, cbHighSchool.CheckStateChanged, cbElementary.CheckStateChanged, cbCollege.CheckStateChanged
        uncheckedHEA()
    End Sub

    Public Sub checkRequiredField()
        If txtFname.Text = Nothing Or txtLname.Text = Nothing Or cboGender.Text = "" Or cboBloodType.Text = "" Or txtBarangay.Text = Nothing Or txtChurchName.Text = Nothing Or txtPastorName.Text = Nothing Then
            MsgBox("All Required Fields must be Fill-in", MsgBoxStyle.Exclamation)
        ElseIf cbBaptizedYes.Checked = False And cbBaptizedNo.Checked = False Then
            MsgBox("All Required Fields must be Fill-in", MsgBoxStyle.Exclamation)
        ElseIf cbNone.Checked = False And cbElementary.Checked = False And cbHighSchool.Checked = False And cbCollege.Checked = False And cbMasters.Checked = False And cbPhD.Checked = False Then
            MsgBox("All Required Fields must be Fill-in", MsgBoxStyle.Exclamation)
        ElseIf cbWorkNo.Checked = False And cbWorkYEs.Checked = False Then
            MsgBox("All Required Fields must be Fill-in", MsgBoxStyle.Exclamation)
        ElseIf cbSingle.Checked = False And cbMarried.Checked = False And cbDivorce.Checked = False And cbWidow.Checked = False Then
            MsgBox("All Required Fields must be Fill-in", MsgBoxStyle.Exclamation)
        Else
            Me.defualtValue()
            c.savePersonalInformation()
            Dim d As DialogResult = MsgBox("Do you have children?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Question")
            If d = MsgBoxResult.Yes Then
                With frmSiblingsRegistration
                    .mem_last_id = c.member_last_id
                    .ShowDialog()
                End With
            Else
                MsgBox("Information Successfully Saved", MsgBoxStyle.Information)
                Me.clearMemberInformation()

            End If
        End If
    End Sub
    Public Sub clearMemberInformation()
        txtFname.Clear()
        txtLname.Clear()
        txtMname.Clear()
        cboGender.Text = ""
        cboBloodType.Text = ""
        txtContactNo.Clear()
        txtEmail.Clear()
        txtprovince.Clear()
        txtCity.Clear()
        txtBarangay.Clear()
        txtChurchName.Clear()
        txtPastorName.Clear()
        cbBaptizedNo.Checked = False
        cbBaptizedYes.Checked = False
        cbNone.Checked = False
        cbElementary.Checked = False
        cbCollege.Checked = False
        cbMasters.Checked = False
        cbHighSchool.Checked = False
        cbPhD.Checked = False
        txtCourseGrad.Clear()
        txtSchoolGrad.Clear()
        cbLicenseNo.Checked = False
        cbLicenseYES.Checked = False
        txtSpecify.Clear()
        cbWorkYEs.Checked = False
        cbWorkNo.Checked = False
        txtNatureofwork.Clear()
        txtNameofcomp.Clear()
        txtSalary.Clear()
        txtSelfEmplyed.Clear()
        txtBusinessAddress.Clear()
        txtEstimatedIncome.Clear()
        txtNameOfBusiness.Clear()



    End Sub

    Public Sub defualtValue()
        If txtContactNo.Text = Nothing Then
            c.Contact_no = "None"
        End If
        If txtEmail.Text = Nothing Then
            c.Email_ad = "None"
        End If
        If txtCourseGrad.Text = Nothing Then
            c.Course_graduated = "None"
        End If
        If txtSchoolGrad.Text = Nothing Then
            c.Name_of_school_graduated = "None"
        End If
        If cbLicenseNo.Checked = False And cbLicenseYES.Checked = False Then
            c.Licensure_passer = "No"
        End If
        If txtSpecify.Text = Nothing Then
            c.License_specification = "None"
        End If
        If txtWorkAddress.Text = Nothing Then
            c.Work_address = "None"
        End If
        If txtNatureofwork.Text = Nothing Then
            c.Nature_of_work = "None"
        End If
        If txtNameOfBusiness.Text = Nothing Then
            c.Name_of_business = "None"
        End If
        If txtNameofcomp.Text = Nothing Then
            c.Name_of_company = "None"
        End If
        If txtBusinessAddress.Text = Nothing Then
            c.Business_address = "None"
        End If
        If cbBaptizedNo.Checked = True Then
            c.Baptized_date = "0000-00-00"
        End If
        If cbMarried.Checked = False Then
            c.Marriage_date = "0000-00-00"
        End If

        If txtSelfEmplyed.Text = Nothing Then
            c.Self_employed = "None"
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        'OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog1.Filter = "Img Files (*.jpg)|*.png"
        If (OpenFileDialog1.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog1.FileName
            rectangle.BackgroundImage = Image.FromFile(FileName)

            Dim NewSize As New Size(128, 112)
            resized = New Bitmap(rectangle.BackgroundImage, NewSize)
            rectangle.BackgroundImage = resized
            rectangle.BackgroundImageLayout = ImageLayout.Stretch
        End If
    End Sub

    Private Sub frmMember_registration_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub txtNameOfBusiness_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNameOfBusiness.KeyPress
        If Convert.ToInt32(e.KeyChar).ToString() = "13" Then
            With c

                .Member_id = ID.Text
                .First_name = txtFname.Text
                .Last_name = txtLname.Text
                .Middle_name = txtMname.Text
                .Gender = cboGender.Text
                .Date_of_birth = dtpDateofbirth.Text
                .Blood_type = cboBloodType.Text
                .Contact_no = txtContactNo.Text
                .Email_ad = txtEmail.Text
                .Province = txtprovince.Text
                .City = txtCity.Text
                .Barangay = txtBarangay.Text
                .Church_name = txtChurchName.Text
                .Pastor_name = txtPastorName.Text
                .Baptized_date = dtpDateBaptize.Text
                .Course_graduated = txtCourseGrad.Text
                .Name_of_school_graduated = txtSchoolGrad.Text
                .License_specification = txtSpecify.Text
                .Work_address = txtWorkAddress.Text
                .Nature_of_work = txtNatureofwork.Text
                .Name_of_company = txtNameofcomp.Text
                .Salary = txtSalary.Text
                .Self_employed = txtSelfEmplyed.Text
                .Business_address = txtBusinessAddress.Text
                .Estimated_annual_income = txtEstimatedIncome.Text
                .Name_of_business = txtNameOfBusiness.Text
                Me.checkRequiredField()
            End With
        End If
    End Sub
End Class
