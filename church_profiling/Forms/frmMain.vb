Public Class frmMain

    'Menus effects

    Private Sub ptbFile_MouseEnter(sender As Object, e As EventArgs) Handles ptbFile.MouseEnter
        ptbFile.BackgroundImage = church_profiling.My.Resources.file_2
        'slidePanel_down()
        'slideView_up()
        'slideReport_up()
        'slideMaintenance_up()
        slideAttendanceReport_up()
        slideAttendance_up()
        slideView_up()
        slideReport_up()
        slideMaintenance_up()
        slideBurialOrg_up()
        slideFinancialTrans_up()
        slidePanel_down()
    End Sub

    Private Sub ptbFile_MouseLeave(sender As Object, e As EventArgs) Handles ptbFile.MouseLeave
        'ptbFile.BackgroundImage = church_profiling.My.Resources.File
    End Sub

    Private Sub ptbView_MouseEnter(sender As Object, e As EventArgs) Handles ptbView.MouseEnter
        ptbView.BackgroundImage = church_profiling.My.Resources.view_2
        'slidePanel_up()
        'slideView_down()
        'slideReport_up()
        'slideMaintenance_up()
        slideAttendanceReport_up()
        slideAttendance_up()
        slidePanel_up()
        slideReport_up()
        slideMaintenance_up()
        slideBurialOrg_up()
        slideFinancialTrans_up()
        slideView_down()
    End Sub

    Private Sub ptbView_MouseLeave(sender As Object, e As EventArgs) Handles ptbView.MouseLeave
        'ptbView.BackgroundImage = church_profiling.My.Resources.view
    End Sub

    Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles ptbReport.MouseEnter
        ptbReport.BackgroundImage = church_profiling.My.Resources.report_2
        'slidePanel_up()
        'slideView_up()
        'slideMaintenance_up()
        slideAttendanceReport_up()
        slideAttendance_up()
        slidePanel_up()
        slideView_up()
        slideMaintenance_up()
        slideBurialOrg_up()
        slideFinancialTrans_up()
        slideReport_down()
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles ptbReport.MouseLeave
        'ptbReport.BackgroundImage = church_profiling.My.Resources.report
    End Sub

    Private Sub PictureBox3_MouseEnter(sender As Object, e As EventArgs) Handles ptbMaintenance.MouseEnter
        ptbMaintenance.BackgroundImage = church_profiling.My.Resources.maintenance_2
        'slidePanel_up()
        'slideReport_up()
        'slideView_up()
        'slideBurialOrg_up()
        slideAttendanceReport_up()
        slideAttendance_up()
        slidePanel_up()
        slideView_up()
        slideReport_up()
        slideBurialOrg_up()
        slideFinancialTrans_up()
        slideMaintenance_down()
    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles ptbMaintenance.MouseLeave
        'ptbMaintenance.BackgroundImage = church_profiling.My.Resources.maintenance
    End Sub

    Private Sub PictureBox4_MouseEnter(sender As Object, e As EventArgs) Handles ptbBurial.MouseEnter
        ptbBurial.BackgroundImage = church_profiling.My.Resources.burial_2
        'slidePanel_up()
        'slideReport_up()
        'slideView_up()
        'slideMaintenance_up()
        slideAttendanceReport_up()
        slideAttendance_up()
        slidePanel_up()
        slideView_up()
        slideMaintenance_up()
        slideReport_up()
        slideFinancialTrans_up()
        slideBurialOrg_down()
    End Sub

    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles ptbBurial.MouseLeave
        'ptbBurial.BackgroundImage = church_profiling.My.Resources.burial
    End Sub





    'file sub menus effects

    Private Sub PictureBox2_MouseEnter_1(sender As Object, e As EventArgs) Handles ptbMemberOrg.MouseEnter
        ptbMemberOrg.BackgroundImage = church_profiling.My.Resources.membership_org
        slideAttendance_up()
    End Sub

    Private Sub PictureBox2_MouseLeave_1(sender As Object, e As EventArgs) Handles ptbMemberOrg.MouseLeave
        ptbMemberOrg.BackgroundImage = church_profiling.My.Resources.membership_org_2
    End Sub

    Private Sub PictureBox3_MouseEnter_1(sender As Object, e As EventArgs) Handles ptbAttendance.MouseEnter
        ptbAttendance.BackgroundImage = church_profiling.My.Resources.attendance
        Me.slideFinancialTrans_up()
        Me.slideAttendance_down()
    End Sub

    Private Sub PictureBox3_MouseLeave_1(sender As Object, e As EventArgs) Handles ptbAttendance.MouseLeave
        'ptbAttendance.BackgroundImage = church_profiling.My.Resources.attendance_2
    End Sub

    Private Sub PictureBox4_MouseEnter_1(sender As Object, e As EventArgs) Handles ptbManageFinancial.MouseEnter
        ptbManageFinancial.BackgroundImage = church_profiling.My.Resources.manage_financial
        slideAttendance_up()
        slideFinancialTrans_down()
    End Sub

    Private Sub PictureBox4_MouseLeave_1(sender As Object, e As EventArgs) Handles ptbManageFinancial.MouseLeave
        'ptbManageFinancial.BackgroundImage = church_profiling.My.Resources.manage_financial_2
    End Sub



    'sliding effects

    Public Sub slidePanel_down()
        ptbFile.BackgroundImage = church_profiling.My.Resources.file_2
        While (panelFileSub.Height < 182)
            panelFileSub.Height += 1
        End While
    End Sub

    Public Sub slidePanel_up()
        ptbFile.BackgroundImage = church_profiling.My.Resources.File
        While (panelFileSub.Height > 0)
            panelFileSub.Height -= 1
        End While
    End Sub



    Private Sub panelFileSub_MouseLeave(sender As Object, e As EventArgs) Handles panelFileSub.MouseLeave
        slidePanel_up()
    End Sub


    'general closing of animation

    Private Sub frmMain_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
        slideAttendanceReport_up()
        slideAttendance_up()
        slideFinancialTrans_up()
        slidePanel_up()
        slideView_up()
        slideReport_up()
        slideMaintenance_up()
        slideBurialOrg_up()
        slideFinancialTrans_up()
    End Sub


    'View menu Effects

    Private Sub ptbList_of_household_MouseEnter(sender As Object, e As EventArgs) Handles ptbList_of_household.MouseEnter
        ptbList_of_household.BackgroundImage = church_profiling.My.Resources.list_of_family
    End Sub

    Private Sub ptbList_of_household_MouseLeave(sender As Object, e As EventArgs) Handles ptbList_of_household.MouseLeave
        ptbList_of_household.BackgroundImage = church_profiling.My.Resources.list_of_family2
    End Sub

    Private Sub ptbList_of_officials_MouseEnter(sender As Object, e As EventArgs) Handles ptbList_of_officials.MouseEnter
        ptbList_of_officials.BackgroundImage = church_profiling.My.Resources.list_of_officials
    End Sub

    Private Sub ptbList_of_officials_MouseLeave(sender As Object, e As EventArgs) Handles ptbList_of_officials.MouseLeave
        ptbList_of_officials.BackgroundImage = church_profiling.My.Resources.list_of_officials2
    End Sub

    Public Sub slideView_down()
        ptbView.BackgroundImage = church_profiling.My.Resources.view_2
        While (panelViewSub.Height < 138)
            panelViewSub.Height += 1
        End While
    End Sub

    Public Sub slideView_up()
        ptbView.BackgroundImage = church_profiling.My.Resources.view
        While (panelViewSub.Height > 0)
            panelViewSub.Height -= 1
        End While
    End Sub


    'Report Effects

    Private Sub ptbHouseholdReport_MouseEnter(sender As Object, e As EventArgs) Handles ptbHouseholdReport.MouseEnter
        ptbHouseholdReport.BackgroundImage = church_profiling.My.Resources.Household_report
    End Sub

    Private Sub ptbTreasurerReport_MouseEnter(sender As Object, e As EventArgs) Handles ptbTreasurerReport.MouseEnter
        ptbTreasurerReport.BackgroundImage = church_profiling.My.Resources.treasurers_report
    End Sub

    Private Sub ptbCertificate_MouseEnter(sender As Object, e As EventArgs) Handles ptbCertificate.MouseEnter
        ptbCertificate.BackgroundImage = church_profiling.My.Resources.certificate_and_clearances
        slideAttendanceReport_up()
    End Sub

    
    Private Sub ptbHouseholdReport_MouseLeave(sender As Object, e As EventArgs) Handles ptbHouseholdReport.MouseLeave
        ptbHouseholdReport.BackgroundImage = church_profiling.My.Resources.Household_report_2
    End Sub

    Private Sub ptbTreasurerReport_MouseLeave(sender As Object, e As EventArgs) Handles ptbTreasurerReport.MouseLeave
        ptbTreasurerReport.BackgroundImage = church_profiling.My.Resources.treasurers_report_2
    End Sub

    Private Sub ptbCertificate_MouseLeave(sender As Object, e As EventArgs) Handles ptbCertificate.MouseLeave
        ptbCertificate.BackgroundImage = church_profiling.My.Resources.certificate_and_clearances_2
    End Sub

    
    Public Sub slideReport_down()
        ptbReport.BackgroundImage = church_profiling.My.Resources.report_2
        While (panelReportSub.Height < 230)
            panelReportSub.Height += 1
        End While
    End Sub

    Public Sub slideReport_up()
        ptbReport.BackgroundImage = church_profiling.My.Resources.report
        While (panelReportSub.Height > 0)
            panelReportSub.Height -= 1
        End While
    End Sub


   
    Private Sub ptbAttendance_report_MouseEnter(sender As Object, e As EventArgs) Handles ptbAttendance_report.MouseEnter
        ptbAttendance_report.BackgroundImage = church_profiling.My.Resources.attendance_report_deepsky
        Me.slideAttendanceReport_down()
    End Sub

    Private Sub ptbAttendance_report_MouseLeave(sender As Object, e As EventArgs) Handles ptbAttendance_report.MouseLeave
        'ptbAttendance_report.BackgroundImage = church_profiling.My.Resources.attendance_report_Dodge
    End Sub




    'Maintenance Effects

    Private Sub ptbUseraccount_MouseEnter(sender As Object, e As EventArgs) Handles ptbUseraccount.MouseEnter
        ptbUseraccount.BackgroundImage = church_profiling.My.Resources.useraccount
    End Sub

    Private Sub ptbUseraccount_MouseLeave(sender As Object, e As EventArgs) Handles ptbUseraccount.MouseLeave
        ptbUseraccount.BackgroundImage = church_profiling.My.Resources.useraccount_2
    End Sub

    Private Sub PictureBox8_MouseEnter(sender As Object, e As EventArgs) Handles ptbChurchName.MouseEnter
        ptbChurchName.BackgroundImage = church_profiling.My.Resources.church_name
    End Sub

    Private Sub PictureBox8_MouseLeave(sender As Object, e As EventArgs) Handles ptbChurchName.MouseLeave
        ptbChurchName.BackgroundImage = church_profiling.My.Resources.church_name_2
    End Sub

    Private Sub PictureBox7_MouseEnter(sender As Object, e As EventArgs) Handles ptbChurchOfficial.MouseEnter
        ptbChurchOfficial.BackgroundImage = church_profiling.My.Resources.church_official
    End Sub

    Private Sub PictureBox7_MouseLeave(sender As Object, e As EventArgs) Handles ptbChurchOfficial.MouseLeave
        ptbChurchOfficial.BackgroundImage = church_profiling.My.Resources.church_official_2
    End Sub

    Private Sub PictureBox6_MouseEnter(sender As Object, e As EventArgs) Handles ptbManageBurialOfficial.MouseEnter
        ptbManageBurialOfficial.BackgroundImage = church_profiling.My.Resources.manage_bruial_official
    End Sub

    Private Sub PictureBox6_MouseLeave(sender As Object, e As EventArgs) Handles ptbManageBurialOfficial.MouseLeave
        ptbManageBurialOfficial.BackgroundImage = church_profiling.My.Resources.manage_bruial_official_2
    End Sub


    Public Sub slideMaintenance_down()
        ptbMaintenance.BackgroundImage = church_profiling.My.Resources.maintenance_2
        While (panleMaintenanceSub.Height < 183)
            panleMaintenanceSub.Height += 1
        End While
    End Sub

    Public Sub slideMaintenance_up()
        ptbMaintenance.BackgroundImage = church_profiling.My.Resources.maintenance
        While (panleMaintenanceSub.Height > 0)
            panleMaintenanceSub.Height -= 1
        End While
    End Sub




    'Burial Org Effects

    Private Sub ptbAttendanceMembers_MouseEnter(sender As Object, e As EventArgs) Handles ptbAttendanceMembers.MouseEnter
        ptbAttendanceMembers.BackgroundImage = church_profiling.My.Resources.attendance_of_members
    End Sub

    Private Sub ptbAttendanceMembers_MouseLeave(sender As Object, e As EventArgs) Handles ptbAttendanceMembers.MouseLeave
        ptbAttendanceMembers.BackgroundImage = church_profiling.My.Resources.attendance_of_members_2
    End Sub

    Private Sub ptbFinancialTrans_MouseEnter(sender As Object, e As EventArgs) Handles ptbFinancialTrans.MouseEnter
        ptbFinancialTrans.BackgroundImage = church_profiling.My.Resources.financial_transaction
    End Sub

    Private Sub ptbFinancialTrans_MouseLeave(sender As Object, e As EventArgs) Handles ptbFinancialTrans.MouseLeave
        ptbFinancialTrans.BackgroundImage = church_profiling.My.Resources.financial_transaction_2
    End Sub

    'ptbBurial.BackgroundImage = church_profiling.My.Resources.burial

    Public Sub slideBurialOrg_down()
        ptbBurial.BackgroundImage = church_profiling.My.Resources.burial_2
        While (panelBurialOrg.Height < 139)
            panelBurialOrg.Height += 1
        End While
    End Sub

    Public Sub slideBurialOrg_up()
        ptbBurial.BackgroundImage = church_profiling.My.Resources.burial
        While (panelBurialOrg.Height > 0)
            panelBurialOrg.Height -= 1
        End While
    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs)
        slideBurialOrg_up()
    End Sub


    'Effects For Sub-menus

    Private Sub ptbIncome_MouseEnter(sender As Object, e As EventArgs) Handles ptbIncome.MouseEnter
        ptbIncome.BackgroundImage = church_profiling.My.Resources.income_3
    End Sub

    Private Sub ptbIncome_MouseLeave(sender As Object, e As EventArgs) Handles ptbIncome.MouseLeave
        ptbIncome.BackgroundImage = church_profiling.My.Resources.income
    End Sub

    Private Sub ptbFines_MouseEnter(sender As Object, e As EventArgs) Handles ptbFines.MouseEnter
        ptbFines.BackgroundImage = church_profiling.My.Resources.fines_2
    End Sub

    Private Sub ptbFines_MouseLeave(sender As Object, e As EventArgs) Handles ptbFines.MouseLeave
        ptbFines.BackgroundImage = church_profiling.My.Resources.fines
    End Sub

    Private Sub ptbExpenses_MouseEnter(sender As Object, e As EventArgs) Handles ptbExpenses.MouseEnter
        ptbExpenses.BackgroundImage = church_profiling.My.Resources.expenses_2
    End Sub

    Private Sub ptbExpenses_MouseLeave(sender As Object, e As EventArgs) Handles ptbExpenses.MouseLeave
        ptbExpenses.BackgroundImage = church_profiling.My.Resources.expenses
    End Sub

    Private Sub ptbExpenditures_MouseEnter(sender As Object, e As EventArgs) Handles ptbExpenditures.MouseEnter
        ptbExpenditures.BackgroundImage = church_profiling.My.Resources.expenditures_2
    End Sub

    Private Sub ptbExpenditures_MouseLeave(sender As Object, e As EventArgs) Handles ptbExpenditures.MouseLeave
        ptbExpenditures.BackgroundImage = church_profiling.My.Resources.expenditures
    End Sub

    Public Sub slideFinancialTrans_down()
        ptbManageFinancial.BackgroundImage = church_profiling.My.Resources.manage_financial
        While (panelFinancialTrans.Height < 183)
            panelFinancialTrans.Height += 1
        End While
    End Sub

    Public Sub slideFinancialTrans_up()
        ptbManageFinancial.BackgroundImage = church_profiling.My.Resources.manage_financial_2
        While (panelFinancialTrans.Height > 0)
            panelFinancialTrans.Height -= 1
        End While
    End Sub


    'attendance Sub menus Effects

    Private Sub ptbBurialMeeting_MouseEnter(sender As Object, e As EventArgs) Handles ptbBurialMeeting.MouseEnter
        ptbBurialMeeting.BackgroundImage = church_profiling.My.Resources.burial_meeting_2
    End Sub

    Private Sub ptbBurialMeeting_MouseLeave(sender As Object, e As EventArgs) Handles ptbBurialMeeting.MouseLeave
        ptbBurialMeeting.BackgroundImage = church_profiling.My.Resources.burial_meeting
    End Sub

    Private Sub ptbChurchMeeting_MouseEnter(sender As Object, e As EventArgs) Handles ptbChurchMeeting.MouseEnter
        ptbChurchMeeting.BackgroundImage = church_profiling.My.Resources.church_meeting_2
    End Sub

    Private Sub ptbChurchMeeting_MouseLeave(sender As Object, e As EventArgs) Handles ptbChurchMeeting.MouseLeave
        ptbChurchMeeting.BackgroundImage = church_profiling.My.Resources.church_meeting
    End Sub

    Public Sub slideAttendance_down()
        ptbAttendance.BackgroundImage = church_profiling.My.Resources.attendance
        While (panelAttendanceSub.Height < 91)
            panelAttendanceSub.Height += 1
        End While
    End Sub

    Public Sub slideAttendance_up()
        ptbAttendance.BackgroundImage = church_profiling.My.Resources.attendance_2
        While (panelAttendanceSub.Height > 0)
            panelAttendanceSub.Height -= 1
        End While
    End Sub



    'attendance Report effects


    Private Sub ptbMeetingReport_MouseEnter(sender As Object, e As EventArgs) Handles ptbMeetingReport.MouseEnter
        ptbMeetingReport.BackgroundImage = church_profiling.My.Resources.meetings_report_2
    End Sub

    Private Sub ptbMeetingReport_MouseLeave(sender As Object, e As EventArgs) Handles ptbMeetingReport.MouseLeave
        ptbMeetingReport.BackgroundImage = church_profiling.My.Resources.meetings_report
    End Sub

    Private Sub ptbMembersAssignment_MouseEnter(sender As Object, e As EventArgs) Handles ptbMembersAssignment.MouseEnter
        ptbMembersAssignment.BackgroundImage = church_profiling.My.Resources.members_assignment_2
    End Sub

    Private Sub ptbMembersAssignment_MouseLeave(sender As Object, e As EventArgs) Handles ptbMembersAssignment.MouseLeave
        ptbMembersAssignment.BackgroundImage = church_profiling.My.Resources.members_assignment
    End Sub

    Public Sub slideAttendanceReport_down()
        ptbAttendance_report.BackgroundImage = church_profiling.My.Resources.attendance_report_deepsky
        While (panelAttendanceReportSub.Height < 91)
            panelAttendanceReportSub.Height += 1
        End While
    End Sub

    Public Sub slideAttendanceReport_up()
        ptbAttendance_report.BackgroundImage = church_profiling.My.Resources.attendance_report_Dodge
        While (panelAttendanceReportSub.Height > 0)
            panelAttendanceReportSub.Height -= 1
        End While
    End Sub




    'End of Animation and Effects


    'Menus Functionality



    'File Sub-Menus

    Private Sub ptbMemberOrg_Click(sender As Object, e As EventArgs) Handles ptbMemberOrg.Click
        slidePanel_up()
        frmMember_registration.ShowDialog()
    End Sub


    Private Sub ptbManageFinancial_Click(sender As Object, e As EventArgs) Handles ptbManageFinancial.Click

    End Sub

    Private Sub ptbBurialMeeting_Click(sender As Object, e As EventArgs) Handles ptbBurialMeeting.Click
        
            Me.slideAttendance_up()
            Me.slidePanel_up()
        frmAttendance.ShowDialog()
    End Sub

    Private Sub ptbChurchMeeting_Click(sender As Object, e As EventArgs) Handles ptbChurchMeeting.Click
       
            Me.slideAttendance_up()
            Me.slidePanel_up()
        frmAttendance.ShowDialog()
    End Sub

    Private Sub ptbUseraccount_Click(sender As Object, e As EventArgs) Handles ptbUseraccount.Click
        slideMaintenance_up()
        frmRegisterUser.ShowDialog()
    End Sub

    Private Sub ptbList_of_household_Click(sender As Object, e As EventArgs) Handles ptbList_of_household.Click
        slideView_up()
        frmListOfHousehold.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmChurchOfficials.ShowDialog()
    End Sub
End Class