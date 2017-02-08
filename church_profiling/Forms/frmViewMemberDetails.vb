Public Class frmViewMemberDetails
    Public c As New cart()
    Private Sub frmViewMemberDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        c.displayMemberDetails(frmListOfHousehold.p_id2)
        With c
            lblID.Text = .Member_id
            lblFname.Text = .First_name
            lblLname.Text = .Last_name
            lblMname.Text = .Middle_name
            lblGender.Text = .Gender
            lblDateofbirth.Text = .Date_of_birth
            lblBloodType.Text = .Blood_type
            lblContactno.Text = .Contact_no
            lblemail_add.Text = .Email_ad
            lblCivilStatus.Text = .Civil_status
            lblProvince.Text = .Province
            lblCity.Text = .City
            lblBarangay.Text = .Barangay
            lblChurchName.Text = .Church_name
            lblPastorname.Text = .Pastor_name
            lblBaptized_date.Text = .Baptized_date
            lblHea.Text = .HEA
            lblCourseGrad.Text = .Course_graduated
            lblNameofschoolgrad.Text = .Name_of_school_graduated
            lblLicenseExam.Text = .Licensure_passer
            lblNatureofwork.Text = .Nature_of_work
            lblname_of_company.Text = .Name_of_company
            lblSalary.Text = .Salary
            lblSelf_employed.Text = .Self_employed
            lbladdress_of_business.Text = .Business_address
            lblannualincome.Text = .Estimated_annual_income
            lblname_of_business.Text = .Name_of_business

        End With
    End Sub
End Class