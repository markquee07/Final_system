Public Class frmPastorViewDetails
    Public p As New Pastor
    Public p_id As Integer

    Private Sub frmPastorViewDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        p.displayPastorDetails(p_id)
        txtFname.Text = p.first_name
        txtLname.Text = p.last_name
        txtMname.Text = p.middle_name
        txtAddress.Text = p.address
        txtContanctNo.Text = p.concat_number
        txtgender.Text = p.gender
        txtbdate.Text = p.date_of_birth
        txtage.Text = p.age
        txtNameOfSchoolGrad.Text = p.name_of_school_grad
        txtSchoolGradAdress.Text = p.address_of_school_graduaterd
        txtyearGrad.Text = p.year_graduated
        txtyearsofService.Text = p.years_of_service
        txtExperienceSchoolAddress.Text = p.church_address
        txtExperienceSchool.Text = p.chutch_name


    End Sub
End Class