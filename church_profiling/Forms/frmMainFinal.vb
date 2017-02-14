Imports System.IO
Public Class frmMainFinal

    ''Hovering Parts 

    Private Sub ptbFile_MouseEnter(sender As Object, e As EventArgs) Handles ptbFile.MouseEnter
        ptbFile.BackgroundImage = church_profiling.My.Resources.File_dodge
        slideReportSub_up()
        slideMaintenanceSub_up()
        slideViewSub_up()
        slideFileSub_down()
    End Sub

    Private Sub ptb_MouseEnter(sender As Object, e As EventArgs) Handles ptbRegister.MouseEnter

        slideRegisterSub_down()
    End Sub

    Private Sub PictureBox4_MouseEnter(sender As Object, e As EventArgs) Handles ptbAttendance.MouseEnter
        ptbAttendance.BackgroundImage = church_profiling.My.Resources.attendance_deepsky
        slideChurchFinancialTrans_up()
        slideChurchFinancialTrans_up()
        slideRegisterSub_up()
    End Sub

    Private Sub PictureBox5_MouseEnter(sender As Object, e As EventArgs) Handles ptbChurchFinancialtrans.MouseEnter

        slideBurialTrans_up()
        slideRegisterSub_up()
        slideChurchFinancialTrans_down()
    End Sub

    Private Sub PictureBox6_MouseEnter(sender As Object, e As EventArgs) Handles ptbBurialFinancialTrans.MouseEnter

        slideChurchFinancialTrans_up()
        slideBurialTrans_down()
    End Sub

    Private Sub ptbMember_MouseEnter(sender As Object, e As EventArgs) Handles ptbMember.MouseEnter
        ptbMember.BackgroundImage = church_profiling.My.Resources.member_dodge
    End Sub

    Private Sub ptbPastor_MouseEnter(sender As Object, e As EventArgs) Handles ptbPastor.MouseEnter
        ptbPastor.BackgroundImage = church_profiling.My.Resources.Pastor_dodge
    End Sub

    Private Sub ptbChurchOfficial_MouseEnter(sender As Object, e As EventArgs)
        'ptbChurchOfficial.BackgroundImage = church_profiling.My.Resources.church_official_dodge
    End Sub

    Private Sub ptbBurialOfficial_MouseEnter(sender As Object, e As EventArgs)
        'ptbBurialOfficial.BackgroundImage = church_profiling.My.Resources.Burial_official_dodge
    End Sub

    Private Sub ptbIncome_MouseEnter(sender As Object, e As EventArgs) Handles ptbIncome.MouseEnter
        ptbIncome.BackgroundImage = church_profiling.My.Resources.income_dodge
    End Sub

    Private Sub ptbExpenses_MouseEnter(sender As Object, e As EventArgs) Handles ptbExpenses.MouseEnter
        ptbExpenses.BackgroundImage = church_profiling.My.Resources.expenses_dodge
    End Sub

    Private Sub ptbEmergencyFunds_MouseEnter(sender As Object, e As EventArgs) Handles ptbEmergencyFunds.MouseEnter
        ptbEmergencyFunds.BackgroundImage = church_profiling.My.Resources.emergency_funds_dodge
    End Sub

    Private Sub ptbMothyFee_MouseEnter(sender As Object, e As EventArgs) Handles ptbMothyFee.MouseEnter
        ptbMothyFee.BackgroundImage = church_profiling.My.Resources.monthly_fee_dodge
    End Sub

    Private Sub ptbExpenditures_MouseEnter(sender As Object, e As EventArgs) Handles ptbExpenditures.MouseEnter
        ptbExpenditures.BackgroundImage = church_profiling.My.Resources.expenditures_dodge
    End Sub





    ''Sliding Parts

    'File sub
    Public Sub slideFileSub_down()
        While (panelFileUnder.Height < 181)
            panelFileUnder.Height += 1
        End While
    End Sub
    Public Sub slideFileSub_up()
        ptbFile.BackgroundImage = church_profiling.My.Resources.File_deepsky
        While (panelFileUnder.Height > 0)
            panelFileUnder.Height -= 1
        End While
    End Sub

    'Register sub
    Public Sub slideRegisterSub_down()
        ptbRegister.BackgroundImage = church_profiling.My.Resources.register_deepsky
        While (panelRegisterUnder.Height < 91)
            panelRegisterUnder.Height += 1
        End While
    End Sub
    Public Sub slideRegisterSub_up()
        ptbRegister.BackgroundImage = church_profiling.My.Resources.register_dodge
        While (panelRegisterUnder.Height > 0)
            panelRegisterUnder.Height -= 1
        End While
    End Sub

    'slideBurialTrans_down

    Public Sub slideBurialTrans_down()
        ptbBurialFinancialTrans.BackgroundImage = church_profiling.My.Resources.burial_financial_trans_deepsky
        While (panelBurialFinancialTrans_under.Height < 87)
            panelBurialFinancialTrans_under.Height += 1
        End While
    End Sub
    Public Sub slideBurialTrans_up()
        ptbBurialFinancialTrans.BackgroundImage = church_profiling.My.Resources.burial_financial_trans_dodge
        While (panelBurialFinancialTrans_under.Height > 0)
            panelBurialFinancialTrans_under.Height -= 1
        End While
    End Sub

    Public Sub slideChurchFinancialTrans_down()
        ptbChurchFinancialtrans.BackgroundImage = church_profiling.My.Resources.church_financial_trans_deepsky
        While (panelChurchFinancialTrans_under.Height < 136)
            panelChurchFinancialTrans_under.Height += 1
        End While
    End Sub
    Public Sub slideChurchFinancialTrans_up()
        ptbChurchFinancialtrans.BackgroundImage = church_profiling.My.Resources.church_financial_trans_dodge
        While (panelChurchFinancialTrans_under.Height > 0)
            panelChurchFinancialTrans_under.Height -= 1
        End While
    End Sub

    Public Sub slideViewSub_down()
        While (panelViewUnder.Height < 316)
            panelViewUnder.Height += 1
        End While
    End Sub
    Public Sub slideViewSub_up()
        ptbView.BackgroundImage = church_profiling.My.Resources.view_sky
        While (panelViewUnder.Height > 0)
            panelViewUnder.Height -= 1
        End While
    End Sub

    Public Sub slideReportSub_down()
        While (panelReport.Height < 313)
            panelReport.Height += 1
        End While
    End Sub
    Public Sub slideReportSub_up()
        ptbReport.BackgroundImage = church_profiling.My.Resources.report_deepsky
        While (panelReport.Height > 0)
            panelReport.Height -= 1
        End While
    End Sub

    Public Sub slideReportChurchFinancialTrans_down()
        ptbReportChurchFinancialTrans.BackgroundImage = church_profiling.My.Resources.church_financial_trans_deepsky
        While (panelReportChurchFinancial.Height < 135)
            panelReportChurchFinancial.Height += 1
        End While
    End Sub
    Public Sub slideReportChurchFinancialTrans_up()
        ptbReportChurchFinancialTrans.BackgroundImage = church_profiling.My.Resources.church_financial_trans_dodge
        While (panelReportChurchFinancial.Height > 0)
            panelReportChurchFinancial.Height -= 1
        End While
    End Sub

    Public Sub slideReportBurialFinancialTrans_down()
        ptbReportBurialFinancialTrans.BackgroundImage = church_profiling.My.Resources.burial_financial_trans_deepsky
        While (panelReportBurialFinancialTrans.Height < 90)
            panelReportBurialFinancialTrans.Height += 1
        End While
    End Sub
    Public Sub slideReportBurialFinancialTrans_up()
        ptbReportBurialFinancialTrans.BackgroundImage = church_profiling.My.Resources.burial_financial_trans_dodge
        While (panelReportBurialFinancialTrans.Height > 0)
            panelReportBurialFinancialTrans.Height -= 1
        End While
    End Sub

    Public Sub slideMaintenanceSub_down()
        ptbMaintenance.BackgroundImage = church_profiling.My.Resources.maintenance_dodge
        While (panelMaintenanceSub.Height < 271)
            panelMaintenanceSub.Height += 1
        End While
    End Sub
    Public Sub slideMaintenanceSub_up()
        ptbMaintenance.BackgroundImage = church_profiling.My.Resources.maintenance_deepsky
        While (panelMaintenanceSub.Height > 0)
            panelMaintenanceSub.Height -= 1
        End While
    End Sub


    Private Sub frmMainFinal_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
        slideMaintenanceSub_up()
        slideReportBurialFinancialTrans_up()
        slideReportChurchFinancialTrans_up()
        slideReportSub_up()
        slideViewSub_up()
        slideChurchFinancialTrans_up()
        slideBurialTrans_up()
        slideRegisterSub_up()
        slideFileSub_up()
    End Sub


    ''LEAVE PARTS

    Private Sub ptbRegister_MouseLeave(sender As Object, e As EventArgs) Handles ptbRegister.MouseLeave
        'ptbRegister.BackgroundImage = church_profiling.My.Resources.register_dodge
    End Sub

    Private Sub ptbAttendance_MouseLeave(sender As Object, e As EventArgs) Handles ptbAttendance.MouseLeave
        ptbAttendance.BackgroundImage = church_profiling.My.Resources.attendance_dodge
    End Sub

    Private Sub ptbChurchFinancialtrans_MouseLeave(sender As Object, e As EventArgs) Handles ptbChurchFinancialtrans.MouseLeave
        'ptbChurchFinancialtrans.BackgroundImage = church_profiling.My.Resources.church_financial_trans_dodge
    End Sub

    Private Sub ptbBurialFinancialTrans_MouseLeave(sender As Object, e As EventArgs) Handles ptbBurialFinancialTrans.MouseLeave

    End Sub

    Private Sub ptbMember_MouseLeave(sender As Object, e As EventArgs) Handles ptbMember.MouseLeave
        ptbMember.BackgroundImage = church_profiling.My.Resources.member_deepsky
    End Sub

    Private Sub ptbPastor_MouseLeave(sender As Object, e As EventArgs) Handles ptbPastor.MouseLeave
        ptbPastor.BackgroundImage = church_profiling.My.Resources.pastor_deepsky
    End Sub

    Private Sub ptbChurchOfficial_MouseLeave(sender As Object, e As EventArgs)
        ' ptbChurchOfficial.BackgroundImage = church_profiling.My.Resources.church_official_deepsky
    End Sub

    Private Sub ptbBurialOfficial_MouseLeave(sender As Object, e As EventArgs)
        ' ptbBurialOfficial.BackgroundImage = church_profiling.My.Resources.burial_official_deepsky
    End Sub

    Private Sub ptbIncome_MouseLeave(sender As Object, e As EventArgs) Handles ptbIncome.MouseLeave
        ptbIncome.BackgroundImage = church_profiling.My.Resources.income_deepsky
    End Sub

    Private Sub ptbExpenses_MouseLeave(sender As Object, e As EventArgs) Handles ptbExpenses.MouseLeave
        ptbExpenses.BackgroundImage = church_profiling.My.Resources.expenses_deepsky
    End Sub

    Private Sub ptbEmergencyFunds_MouseLeave(sender As Object, e As EventArgs) Handles ptbEmergencyFunds.MouseLeave
        ptbEmergencyFunds.BackgroundImage = church_profiling.My.Resources.emergency_funds_deepsky
    End Sub

    Private Sub ptbMothyFee_MouseLeave(sender As Object, e As EventArgs) Handles ptbMothyFee.MouseLeave
        ptbMothyFee.BackgroundImage = church_profiling.My.Resources.monthly_fee_deepsky
    End Sub

    Private Sub ptbExpenditures_MouseLeave(sender As Object, e As EventArgs) Handles ptbExpenditures.MouseLeave
        ptbExpenditures.BackgroundImage = church_profiling.My.Resources.expenditures_deepsky
    End Sub

    Private Sub ptbView_MouseEnter(sender As Object, e As EventArgs) Handles ptbView.MouseEnter
        ptbView.BackgroundImage = church_profiling.My.Resources.view_dodge
        slideMaintenanceSub_up()
        slideReportBurialFinancialTrans_up()
        slideReportChurchFinancialTrans_up()
        slideReportSub_up()
        slideChurchFinancialTrans_up()
        slideBurialTrans_up()
        slideRegisterSub_up()
        slideFileSub_up()
        slideViewSub_down()
    End Sub

    Private Sub ptbReport_MouseEnter(sender As Object, e As EventArgs) Handles ptbReport.MouseEnter
        ptbReport.BackgroundImage = church_profiling.My.Resources.report_dodge
        ptbView.BackgroundImage = church_profiling.My.Resources.view_dodge
        slideMaintenanceSub_up()
        slideReportBurialFinancialTrans_up()
        slideReportChurchFinancialTrans_up()
        slideChurchFinancialTrans_up()
        slideBurialTrans_up()
        slideRegisterSub_up()
        slideFileSub_up()
        slideViewSub_up()
        slideReportSub_down()
    End Sub

    Private Sub ptbMaintenance_MouseEnter(sender As Object, e As EventArgs) Handles ptbMaintenance.MouseEnter
        slideReportSub_up()
        slideReportBurialFinancialTrans_up()
        slideReportChurchFinancialTrans_up()
        slideChurchFinancialTrans_up()
        slideBurialTrans_up()
        slideRegisterSub_up()
        slideFileSub_up()
        slideViewSub_up()
        slideMaintenanceSub_down()
    End Sub

    Private Sub ptbViewMembers_MouseEnter(sender As Object, e As EventArgs) Handles ptbViewMembers.MouseEnter
        ptbViewMembers.BackgroundImage = church_profiling.My.Resources.members_deepsky
    End Sub

    Private Sub ptbViewOfficials_MouseEnter(sender As Object, e As EventArgs) Handles ptbViewOfficials.MouseEnter
        ptbViewOfficials.BackgroundImage = church_profiling.My.Resources.church_officials_deepsky
    End Sub

    Private Sub ptbViewBurialOfficials_MouseEnter(sender As Object, e As EventArgs) Handles ptbViewBurialOfficials.MouseEnter
        ptbViewBurialOfficials.BackgroundImage = church_profiling.My.Resources.burial_officials_deepsky
    End Sub

    Private Sub ptbViewAttendance_MouseEnter(sender As Object, e As EventArgs) Handles ptbViewAttendance.MouseEnter
        ptbViewAttendance.BackgroundImage = church_profiling.My.Resources.attendance_deepsky
    End Sub

    Private Sub ptbViewChurchFinancialTrans_MouseEnter(sender As Object, e As EventArgs) Handles ptbViewChurchFinancialTrans.MouseEnter
        ptbViewChurchFinancialTrans.BackgroundImage = church_profiling.My.Resources.church_financial_trans_deepsky
    End Sub

    Private Sub ptbViewBurialFinancialTrans_MouseEnter(sender As Object, e As EventArgs) Handles ptbViewBurialFinancialTrans.MouseEnter
        ptbViewBurialFinancialTrans.BackgroundImage = church_profiling.My.Resources.burial_financial_trans_deepsky
    End Sub



    'Mouse Leave
    Private Sub ptbViewMembers_MouseLeave(sender As Object, e As EventArgs) Handles ptbViewMembers.MouseLeave
        ptbViewMembers.BackgroundImage = church_profiling.My.Resources.members_dodge
    End Sub

    Private Sub ptbViewOfficials_MouseLeave(sender As Object, e As EventArgs) Handles ptbViewOfficials.MouseLeave
        ptbViewOfficials.BackgroundImage = church_profiling.My.Resources.church_officials_dodge
    End Sub

    Private Sub ptbViewBurialOfficials_MouseLeave(sender As Object, e As EventArgs) Handles ptbViewBurialOfficials.MouseLeave
        ptbViewBurialOfficials.BackgroundImage = church_profiling.My.Resources.burial_officials_dodge
    End Sub

    Private Sub ptbViewAttendance_MouseLeave(sender As Object, e As EventArgs) Handles ptbViewAttendance.MouseLeave
        ptbViewAttendance.BackgroundImage = church_profiling.My.Resources.attendance_dodge
    End Sub

    Private Sub ptbViewChurchFinancialTrans_MouseLeave(sender As Object, e As EventArgs) Handles ptbViewChurchFinancialTrans.MouseLeave
        ptbViewChurchFinancialTrans.BackgroundImage = church_profiling.My.Resources.church_financial_trans_dodge
    End Sub

    Private Sub ptbViewBurialFinancialTrans_MouseLeave(sender As Object, e As EventArgs) Handles ptbViewBurialFinancialTrans.MouseLeave
        ptbViewBurialFinancialTrans.BackgroundImage = church_profiling.My.Resources.burial_financial_trans_dodge
    End Sub


    'Report Effects
    Private Sub ptbReportMembers_MouseEnter(sender As Object, e As EventArgs) Handles ptbReportMembers.MouseEnter
        ptbReportMembers.BackgroundImage = church_profiling.My.Resources.members_deepsky
    End Sub

    Private Sub ptbReportMembers_MouseLeave(sender As Object, e As EventArgs) Handles ptbReportMembers.MouseLeave
        ptbReportMembers.BackgroundImage = church_profiling.My.Resources.members_dodge
    End Sub

    Private Sub ptbChurchOfficials_MouseEnter(sender As Object, e As EventArgs) Handles ptbReportChurchOfficials.MouseEnter
        ptbReportChurchOfficials.BackgroundImage = church_profiling.My.Resources.church_officials_deepsky
    End Sub

    Private Sub ptbChurchOfficials_MouseLeave(sender As Object, e As EventArgs) Handles ptbReportChurchOfficials.MouseLeave
        ptbReportChurchOfficials.BackgroundImage = church_profiling.My.Resources.church_officials_dodge
    End Sub

    Private Sub ptbBurialOfficials_MouseEnter(sender As Object, e As EventArgs) Handles ptbReportBurialOfficials.MouseEnter
        ptbReportBurialOfficials.BackgroundImage = church_profiling.My.Resources.burial_officials_deepsky
        slideReportBurialFinancialTrans_up()
        slideReportChurchFinancialTrans_up()
    End Sub

    Private Sub ptbBurialOfficials_MouseLeave(sender As Object, e As EventArgs) Handles ptbReportBurialOfficials.MouseLeave
        ptbReportBurialOfficials.BackgroundImage = church_profiling.My.Resources.burial_officials_dodge
    End Sub


    Private Sub ptbReportAttendance_MouseEnter(sender As Object, e As EventArgs) Handles ptbReportAttendance.MouseEnter
        ptbReportAttendance.BackgroundImage = church_profiling.My.Resources.attendance_deepsky
        slideReportBurialFinancialTrans_up()
        slideReportChurchFinancialTrans_up()
    End Sub

    Private Sub ptbReportAttendance_MouseLeave(sender As Object, e As EventArgs) Handles ptbReportAttendance.MouseLeave
        ptbReportAttendance.BackgroundImage = church_profiling.My.Resources.attendance_dodge
    End Sub

    Private Sub ptbReportChurchFinancialTrans_MouseEnter(sender As Object, e As EventArgs) Handles ptbReportChurchFinancialTrans.MouseEnter
        slideReportBurialFinancialTrans_up()
        slideReportChurchFinancialTrans_down()
    End Sub

    Private Sub ptbReportChurchFinancialTrans_MouseLeave(sender As Object, e As EventArgs) Handles ptbReportChurchFinancialTrans.MouseLeave

    End Sub

    Private Sub ptbReportBurialFinancialTrans_MouseEnter(sender As Object, e As EventArgs) Handles ptbReportBurialFinancialTrans.MouseEnter

        slideReportChurchFinancialTrans_up()
        slideReportBurialFinancialTrans_down()
    End Sub

    Private Sub ptbReportBurialFinancialTrans_MouseLeave(sender As Object, e As EventArgs) Handles ptbReportBurialFinancialTrans.MouseLeave

    End Sub

    Private Sub ptbReportCerficate_MouseEnter(sender As Object, e As EventArgs) Handles ptbReportCerficate.MouseEnter
        ptbReportCerficate.BackgroundImage = church_profiling.My.Resources.certificate_deepsky
        slideReportBurialFinancialTrans_up()
        slideReportChurchFinancialTrans_up()
    End Sub

    Private Sub ptbReportCerficate_MouseLeave(sender As Object, e As EventArgs) Handles ptbReportCerficate.MouseLeave
        ptbReportCerficate.BackgroundImage = church_profiling.My.Resources.certificate_dodge
    End Sub

    Private Sub ptbReportIncome_MouseEnter(sender As Object, e As EventArgs) Handles ptbReportIncome.MouseEnter
        ptbReportIncome.BackgroundImage = church_profiling.My.Resources.income_dodge
    End Sub

    Private Sub ptbReportIncome_MouseLeave(sender As Object, e As EventArgs) Handles ptbReportIncome.MouseLeave
        ptbReportIncome.BackgroundImage = church_profiling.My.Resources.income_deepsky
    End Sub

    Private Sub ptbReportExpenses_MouseEnter(sender As Object, e As EventArgs) Handles ptbReportExpenses.MouseEnter
        ptbReportExpenses.BackgroundImage = church_profiling.My.Resources.expenses_dodge
    End Sub

    Private Sub ptbReportExpenses_MouseLeave(sender As Object, e As EventArgs) Handles ptbReportExpenses.MouseLeave
        ptbReportExpenses.BackgroundImage = church_profiling.My.Resources.expenses_deepsky
    End Sub

    Private Sub ptbReportEmergencyFunds_MouseEnter(sender As Object, e As EventArgs) Handles ptbReportEmergencyFunds.MouseEnter
        ptbReportEmergencyFunds.BackgroundImage = church_profiling.My.Resources.emergency_funds_dodge
    End Sub

    Private Sub ptbReportEmergencyFunds_MouseLeave(sender As Object, e As EventArgs) Handles ptbReportEmergencyFunds.MouseLeave
        ptbReportEmergencyFunds.BackgroundImage = church_profiling.My.Resources.emergency_funds_deepsky
    End Sub

    Private Sub ptbReportMonthlyFee_MouseEnter(sender As Object, e As EventArgs) Handles ptbReportMonthlyFee.MouseEnter
        ptbReportMonthlyFee.BackgroundImage = church_profiling.My.Resources.monthly_fee_dodge
    End Sub

    Private Sub ptbReportMonthlyFee_MouseLeave(sender As Object, e As EventArgs) Handles ptbReportMonthlyFee.MouseLeave
        ptbReportMonthlyFee.BackgroundImage = church_profiling.My.Resources.monthly_fee_deepsky
    End Sub

    Private Sub ptbReportExpenditure_MouseEnter(sender As Object, e As EventArgs) Handles ptbReportExpenditure.MouseEnter
        ptbReportExpenditure.BackgroundImage = church_profiling.My.Resources.expenditures_dodge
    End Sub

    Private Sub ptbReportExpenditure_MouseLeave(sender As Object, e As EventArgs) Handles ptbReportExpenditure.MouseLeave
        ptbReportExpenditure.BackgroundImage = church_profiling.My.Resources.expenditures_deepsky
    End Sub

    Private Sub ptbUserAccount_MouseEnter(sender As Object, e As EventArgs) Handles ptbUserAccount.MouseEnter
        ptbUserAccount.BackgroundImage = church_profiling.My.Resources.user_account_deepsky
    End Sub

    Private Sub ptbUserAccount_MouseLeave(sender As Object, e As EventArgs) Handles ptbUserAccount.MouseLeave
        ptbUserAccount.BackgroundImage = church_profiling.My.Resources.user_account_dodge
    End Sub

    Private Sub ptbM_member_MouseEnter(sender As Object, e As EventArgs) Handles ptbM_member.MouseEnter
        ptbM_member.BackgroundImage = church_profiling.My.Resources.member_deepsky
    End Sub

    Private Sub ptbM_member_MouseLeave(sender As Object, e As EventArgs) Handles ptbM_member.MouseLeave
        ptbM_member.BackgroundImage = church_profiling.My.Resources.member_dodge
    End Sub

    Private Sub ptbM_church_officials_MouseEnter(sender As Object, e As EventArgs) Handles ptbM_church_officials.MouseEnter
        ptbM_church_officials.BackgroundImage = church_profiling.My.Resources.church_officials_deepsky
    End Sub

    Private Sub ptbM_church_officials_MouseLeave(sender As Object, e As EventArgs) Handles ptbM_church_officials.MouseLeave
        ptbM_church_officials.BackgroundImage = church_profiling.My.Resources.church_officials_dodge
    End Sub

    Private Sub ptbM_burial_officials_MouseEnter(sender As Object, e As EventArgs) Handles ptbM_burial_officials.MouseEnter
        ptbM_burial_officials.BackgroundImage = church_profiling.My.Resources.burial_officials_deepsky
    End Sub

    Private Sub ptbM_burial_officials_MouseLeave(sender As Object, e As EventArgs) Handles ptbM_burial_officials.MouseLeave
        ptbM_burial_officials.BackgroundImage = church_profiling.My.Resources.burial_officials_dodge
    End Sub

    Private Sub ptbM_church_name_MouseEnter(sender As Object, e As EventArgs) Handles ptbM_church_name.MouseEnter
        ptbM_church_name.BackgroundImage = church_profiling.My.Resources.church_name_deepsky
    End Sub

    Private Sub ptbM_church_name_MouseLeave(sender As Object, e As EventArgs) Handles ptbM_church_name.MouseLeave
        ptbM_church_name.BackgroundImage = church_profiling.My.Resources.church_name_dodge
    End Sub

    Private Sub ptbF_fines_MouseEnter(sender As Object, e As EventArgs) Handles ptbF_fines.MouseEnter
        ptbF_fines.BackgroundImage = church_profiling.My.Resources.fines_deepsky
    End Sub

    Private Sub ptbF_fines_MouseLeave(sender As Object, e As EventArgs) Handles ptbF_fines.MouseLeave
        ptbF_fines.BackgroundImage = church_profiling.My.Resources.fines_dodge
    End Sub

    Private Sub panelMenuBar_MouseEnter(sender As Object, e As EventArgs) Handles panelMenuBar.MouseEnter
        slideMaintenanceSub_up()
        slideReportBurialFinancialTrans_up()
        slideReportChurchFinancialTrans_up()
        slideReportSub_up()
        slideViewSub_up()
        slideChurchFinancialTrans_up()
        slideBurialTrans_up()
        slideRegisterSub_up()
        slideFileSub_up()
    End Sub

    Private Sub frmMainFinal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        'Dim path As String = Directory.GetCurrentDirectory()
        'MsgBox(path)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = Format(Now(), "long time")
        lblDate.Text = Date.Now.ToString("MMMM dd, yyyy")
        lblDay.Text = Date.Now.ToString("dddd")
    End Sub


    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.BackgroundImage = church_profiling.My.Resources.logout_sky
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.BackgroundImage = church_profiling.My.Resources.logout_white
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim dialog As DialogResult = MsgBox("You are about to logout?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Logout")

        If dialog = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub


    Private Sub ptbMember_Click(sender As Object, e As EventArgs) Handles ptbMember.Click
        slideRegisterSub_up()
        slideFileSub_up()
        frmMember_registration.ShowDialog()
    End Sub

    Private Sub ptbPastor_Click(sender As Object, e As EventArgs) Handles ptbPastor.Click
        slideRegisterSub_up()
        slideFileSub_up()
        frmRegisterPastor.ShowDialog()

    End Sub

    Private Sub ptbChurchOfficial_Click(sender As Object, e As EventArgs)
        slideRegisterSub_up()
        slideFileSub_up()
        frmChurchOfficials.ShowDialog()
    End Sub

    Private Sub ptbBurialOfficial_Click(sender As Object, e As EventArgs)
        slideRegisterSub_up()
        slideFileSub_up()
        frmBurialOfficers.ShowDialog()
    End Sub

    Private Sub ptbAttendance_Click(sender As Object, e As EventArgs) Handles ptbAttendance.Click
        slideFileSub_up()
        frmAttendance.ShowDialog()
    End Sub

    Private Sub ptbViewMembers_Click(sender As Object, e As EventArgs) Handles ptbViewMembers.Click
        slideViewSub_up()
        frmListOfHousehold.ShowDialog()
    End Sub

    Private Sub ptbViewOfficials_Click(sender As Object, e As EventArgs) Handles ptbViewOfficials.Click
        slideViewSub_up()
        With frmListofBurialOfficial
            .lblTypeOfOfficial.Text = "List of Church Officials"
            .lsvBurialOfficial.Visible = False
            .lsvListOfMember.Visible = True
            .ShowDialog()
        End With

    End Sub

    Private Sub ptbViewBurialOfficials_Click(sender As Object, e As EventArgs) Handles ptbViewBurialOfficials.Click
        slideViewSub_up()
        With frmListofBurialOfficial
            .lblTypeOfOfficial.Text = "List of Burial Officials"
            .lsvListOfMember.Visible = False
            .lsvBurialOfficial.Visible = True
            .ShowDialog()
        End With

    End Sub

    Private Sub ptbViewAttendance_Click(sender As Object, e As EventArgs) Handles ptbViewAttendance.Click
        slideViewSub_up()
        frmListOfAttendance.ShowDialog()

    End Sub

    Private Sub ptbViewChurchFinancialTrans_Click(sender As Object, e As EventArgs) Handles ptbViewChurchFinancialTrans.Click
        slideViewSub_up()
        frmListofDebts.ShowDialog()
    End Sub

    Private Sub ptbViewBurialFinancialTrans_Click(sender As Object, e As EventArgs) Handles ptbViewBurialFinancialTrans.Click

    End Sub

    Private Sub ptbUserAccount_Click(sender As Object, e As EventArgs) Handles ptbUserAccount.Click
        slideMaintenanceSub_up()
        frmUserAccountProfile.ShowDialog()
    End Sub

    Private Sub ptbM_member_Click(sender As Object, e As EventArgs) Handles ptbM_member.Click
        slideMaintenanceSub_up()
        With frmListOfHousehold
            .Button1.Text = "Edit"
            .ShowDialog()
        End With


    End Sub

    Private Sub ptbM_church_name_Click(sender As Object, e As EventArgs) Handles ptbM_church_name.Click
        slideMaintenanceSub_up()
        frmchurchlist.ShowDialog()
    End Sub

    Private Sub ptbChurchFinancialtrans_Click(sender As Object, e As EventArgs) Handles ptbChurchFinancialtrans.Click

    End Sub

    Private Sub ptbM_church_officials_Click(sender As Object, e As EventArgs) Handles ptbM_church_officials.Click
        slideMaintenanceSub_up()
        frmChurchOfficials.ShowDialog()
    End Sub

    Private Sub ptbM_burial_officials_Click(sender As Object, e As EventArgs) Handles ptbM_burial_officials.Click
        slideMaintenanceSub_up()
        frmBurialOfficers.ShowDialog()
    End Sub

    Private Sub ptbExpenses_Click(sender As Object, e As EventArgs) Handles ptbExpenses.Click
        slideChurchFinancialTrans_up()
        slideFileSub_up()
        frmExpenses.ShowDialog()
    End Sub

    Private Sub ptbEmergencyFunds_Click(sender As Object, e As EventArgs) Handles ptbEmergencyFunds.Click
        slideChurchFinancialTrans_up()
        slideFileSub_up()
        frmemergencyFund.ShowDialog()
    End Sub

    Private Sub ptbIncome_Click(sender As Object, e As EventArgs) Handles ptbIncome.Click

    End Sub




   
    Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox2.MouseEnter
        PictureBox2.BackgroundImage = church_profiling.My.Resources.pastor_deepsky
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.BackgroundImage = church_profiling.My.Resources.Pastor_dodge
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        slideViewSub_up()
        frmListofPastor.ShowDialog()
    End Sub
End Class