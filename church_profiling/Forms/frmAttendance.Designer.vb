<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAttendance
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAttendance))
        Me.lblSearchMember = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSet = New System.Windows.Forms.Button()
        Me.btnActiveNow = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lsvAttendance = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTimeIn = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblMins = New System.Windows.Forms.Label()
        Me.lblSec = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboHour = New System.Windows.Forms.ComboBox()
        Me.cboMins = New System.Windows.Forms.ComboBox()
        Me.cboAmPm = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblTotalPresent = New System.Windows.Forms.Label()
        Me.lblTotalAbsent = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtDay = New System.Windows.Forms.TextBox()
        Me.cboOpenMins = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtCurrentTime = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboOpenType = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lsvPresentMember = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cboMeetingtype = New System.Windows.Forms.ComboBox()
        Me.timeRemaining = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSearchMember
        '
        Me.lblSearchMember.AutoSize = True
        Me.lblSearchMember.BackColor = System.Drawing.Color.White
        Me.lblSearchMember.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblSearchMember.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchMember.ForeColor = System.Drawing.Color.Gray
        Me.lblSearchMember.Location = New System.Drawing.Point(719, 95)
        Me.lblSearchMember.Name = "lblSearchMember"
        Me.lblSearchMember.Size = New System.Drawing.Size(91, 17)
        Me.lblSearchMember.TabIndex = 33
        Me.lblSearchMember.Text = "Search Member"
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(715, 96)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(147, 15)
        Me.txtSearch.TabIndex = 10
        '
        'btnSet
        '
        Me.btnSet.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnSet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSet.ForeColor = System.Drawing.Color.Transparent
        Me.btnSet.Location = New System.Drawing.Point(25, 375)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(201, 32)
        Me.btnSet.TabIndex = 7
        Me.btnSet.Text = "SET"
        Me.btnSet.UseVisualStyleBackColor = False
        '
        'btnActiveNow
        '
        Me.btnActiveNow.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnActiveNow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActiveNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActiveNow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActiveNow.ForeColor = System.Drawing.Color.Transparent
        Me.btnActiveNow.Location = New System.Drawing.Point(25, 482)
        Me.btnActiveNow.Name = "btnActiveNow"
        Me.btnActiveNow.Size = New System.Drawing.Size(196, 75)
        Me.btnActiveNow.TabIndex = 8
        Me.btnActiveNow.Text = "ACTIVE NOW"
        Me.btnActiveNow.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Transparent
        Me.btnSave.Location = New System.Drawing.Point(733, 566)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(140, 47)
        Me.btnSave.TabIndex = 39
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lsvAttendance
        '
        Me.lsvAttendance.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lsvAttendance.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lsvAttendance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvAttendance.FullRowSelect = True
        Me.lsvAttendance.Location = New System.Drawing.Point(279, 150)
        Me.lsvAttendance.Name = "lsvAttendance"
        Me.lsvAttendance.Size = New System.Drawing.Size(589, 396)
        Me.lsvAttendance.TabIndex = 45
        Me.lsvAttendance.UseCompatibleStateImageBehavior = False
        Me.lsvAttendance.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "MEMBER ID"
        Me.ColumnHeader2.Width = 186
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "MEMBER NAME"
        Me.ColumnHeader3.Width = 264
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "GENDER"
        Me.ColumnHeader4.Width = 122
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(274, 25)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(0, 25)
        Me.lblTitle.TabIndex = 48
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.Transparent
        Me.btnLogin.Location = New System.Drawing.Point(279, 86)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(110, 26)
        Me.btnLogin.TabIndex = 49
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(443, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Time in:"
        '
        'lblTimeIn
        '
        Me.lblTimeIn.AutoSize = True
        Me.lblTimeIn.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblTimeIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeIn.ForeColor = System.Drawing.Color.White
        Me.lblTimeIn.Location = New System.Drawing.Point(498, 93)
        Me.lblTimeIn.Name = "lblTimeIn"
        Me.lblTimeIn.Size = New System.Drawing.Size(0, 16)
        Me.lblTimeIn.TabIndex = 51
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(720, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 16)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Attendance will close in:"
        '
        'lblMins
        '
        Me.lblMins.AutoSize = True
        Me.lblMins.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblMins.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMins.ForeColor = System.Drawing.Color.White
        Me.lblMins.Location = New System.Drawing.Point(788, 47)
        Me.lblMins.Name = "lblMins"
        Me.lblMins.Size = New System.Drawing.Size(36, 25)
        Me.lblMins.TabIndex = 53
        Me.lblMins.Text = "00"
        '
        'lblSec
        '
        Me.lblSec.AutoSize = True
        Me.lblSec.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblSec.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSec.ForeColor = System.Drawing.Color.White
        Me.lblSec.Location = New System.Drawing.Point(828, 47)
        Me.lblSec.Name = "lblSec"
        Me.lblSec.Size = New System.Drawing.Size(36, 25)
        Me.lblSec.TabIndex = 55
        Me.lblSec.Text = "00"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.White
        Me.lblStatus.Location = New System.Drawing.Point(324, 61)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(77, 16)
        Me.lblStatus.TabIndex = 57
        Me.lblStatus.Text = "INACTIVE"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(278, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 16)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "Status:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(816, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 25)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = ":"
        '
        'txtDescription
        '
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(33, 223)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(179, 14)
        Me.txtDescription.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(47, 150)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(160, 24)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "Attendance Setup"
        '
        'cboHour
        '
        Me.cboHour.BackColor = System.Drawing.Color.White
        Me.cboHour.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboHour.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboHour.ForeColor = System.Drawing.Color.Black
        Me.cboHour.FormattingEnabled = True
        Me.cboHour.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cboHour.Location = New System.Drawing.Point(25, 281)
        Me.cboHour.Name = "cboHour"
        Me.cboHour.Size = New System.Drawing.Size(65, 24)
        Me.cboHour.TabIndex = 3
        '
        'cboMins
        '
        Me.cboMins.BackColor = System.Drawing.Color.White
        Me.cboMins.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboMins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMins.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboMins.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMins.FormattingEnabled = True
        Me.cboMins.Items.AddRange(New Object() {"00", "05", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55"})
        Me.cboMins.Location = New System.Drawing.Point(93, 281)
        Me.cboMins.Name = "cboMins"
        Me.cboMins.Size = New System.Drawing.Size(65, 24)
        Me.cboMins.TabIndex = 4
        '
        'cboAmPm
        '
        Me.cboAmPm.BackColor = System.Drawing.Color.White
        Me.cboAmPm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboAmPm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAmPm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboAmPm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAmPm.FormattingEnabled = True
        Me.cboAmPm.Items.AddRange(New Object() {"AM", "PM"})
        Me.cboAmPm.Location = New System.Drawing.Point(161, 281)
        Me.cboAmPm.Name = "cboAmPm"
        Me.cboAmPm.Size = New System.Drawing.Size(65, 24)
        Me.cboAmPm.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(44, 456)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(158, 18)
        Me.Label11.TabIndex = 68
        Me.Label11.Text = "To Activate Attendance"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DimGray
        Me.Label12.Location = New System.Drawing.Point(307, 582)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(123, 16)
        Me.Label12.TabIndex = 69
        Me.Label12.Text = "PRESENT TOTAL:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DimGray
        Me.Label13.Location = New System.Drawing.Point(515, 582)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(113, 16)
        Me.Label13.TabIndex = 70
        Me.Label13.Text = "ABSENT TOTAL:"
        '
        'lblTotalPresent
        '
        Me.lblTotalPresent.AutoSize = True
        Me.lblTotalPresent.BackColor = System.Drawing.Color.White
        Me.lblTotalPresent.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPresent.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.lblTotalPresent.Location = New System.Drawing.Point(428, 577)
        Me.lblTotalPresent.Name = "lblTotalPresent"
        Me.lblTotalPresent.Size = New System.Drawing.Size(21, 24)
        Me.lblTotalPresent.TabIndex = 71
        Me.lblTotalPresent.Text = "0"
        '
        'lblTotalAbsent
        '
        Me.lblTotalAbsent.AutoSize = True
        Me.lblTotalAbsent.BackColor = System.Drawing.Color.White
        Me.lblTotalAbsent.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAbsent.ForeColor = System.Drawing.Color.Red
        Me.lblTotalAbsent.Location = New System.Drawing.Point(626, 577)
        Me.lblTotalAbsent.Name = "lblTotalAbsent"
        Me.lblTotalAbsent.Size = New System.Drawing.Size(21, 24)
        Me.lblTotalAbsent.TabIndex = 72
        Me.lblTotalAbsent.Text = "0"
        '
        'txtDate
        '
        Me.txtDate.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDate.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.ForeColor = System.Drawing.Color.White
        Me.txtDate.Location = New System.Drawing.Point(40, 64)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(167, 19)
        Me.txtDate.TabIndex = 76
        Me.txtDate.Text = "January 12, 2017"
        Me.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDay
        '
        Me.txtDay.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.txtDay.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDay.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDay.ForeColor = System.Drawing.Color.White
        Me.txtDay.Location = New System.Drawing.Point(39, 88)
        Me.txtDay.Name = "txtDay"
        Me.txtDay.Size = New System.Drawing.Size(167, 19)
        Me.txtDay.TabIndex = 77
        Me.txtDay.Text = "Monday"
        Me.txtDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboOpenMins
        '
        Me.cboOpenMins.BackColor = System.Drawing.Color.White
        Me.cboOpenMins.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboOpenMins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOpenMins.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboOpenMins.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOpenMins.FormattingEnabled = True
        Me.cboOpenMins.Items.AddRange(New Object() {"05", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55", "60"})
        Me.cboOpenMins.Location = New System.Drawing.Point(25, 345)
        Me.cboOpenMins.Name = "cboOpenMins"
        Me.cboOpenMins.Size = New System.Drawing.Size(101, 24)
        Me.cboOpenMins.TabIndex = 6
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(43, 319)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(167, 20)
        Me.Label18.TabIndex = 81
        Me.Label18.Text = "Attendance Open For:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(93, 255)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(67, 20)
        Me.Label19.TabIndex = 82
        Me.Label19.Text = "TIme In:"
        '
        'txtCurrentTime
        '
        Me.txtCurrentTime.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.txtCurrentTime.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCurrentTime.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtCurrentTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentTime.ForeColor = System.Drawing.Color.White
        Me.txtCurrentTime.Location = New System.Drawing.Point(40, 23)
        Me.txtCurrentTime.Name = "txtCurrentTime"
        Me.txtCurrentTime.Size = New System.Drawing.Size(167, 40)
        Me.txtCurrentTime.TabIndex = 83
        Me.txtCurrentTime.Text = "10:30 PM"
        Me.txtCurrentTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(790, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 15)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Mins"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(831, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 15)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "Sec"
        '
        'cboOpenType
        '
        Me.cboOpenType.AutoSize = True
        Me.cboOpenType.BackColor = System.Drawing.Color.White
        Me.cboOpenType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOpenType.ForeColor = System.Drawing.Color.Black
        Me.cboOpenType.Location = New System.Drawing.Point(142, 349)
        Me.cboOpenType.Name = "cboOpenType"
        Me.cboOpenType.Size = New System.Drawing.Size(62, 15)
        Me.cboOpenType.TabIndex = 86
        Me.cboOpenType.Text = "MINUTES"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(31, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 15)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "Attendance Category"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(33, 223)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 15)
        Me.Label7.TabIndex = 89
        Me.Label7.Text = "Activity Description / Title"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gray
        Me.Label8.Location = New System.Drawing.Point(31, 284)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 15)
        Me.Label8.TabIndex = 90
        Me.Label8.Text = "Hour"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Gray
        Me.Label14.Location = New System.Drawing.Point(100, 285)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 15)
        Me.Label14.TabIndex = 91
        Me.Label14.Text = "Mins"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Gray
        Me.Label15.Location = New System.Drawing.Point(166, 284)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 15)
        Me.Label15.TabIndex = 92
        Me.Label15.Text = "Period"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Gray
        Me.Label16.Location = New System.Drawing.Point(56, 349)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(34, 15)
        Me.Label16.TabIndex = 93
        Me.Label16.Text = "Mins"
        '
        'lsvPresentMember
        '
        Me.lsvPresentMember.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lsvPresentMember.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12})
        Me.lsvPresentMember.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvPresentMember.FullRowSelect = True
        Me.lsvPresentMember.Location = New System.Drawing.Point(279, 150)
        Me.lsvPresentMember.Name = "lsvPresentMember"
        Me.lsvPresentMember.Size = New System.Drawing.Size(589, 396)
        Me.lsvPresentMember.TabIndex = 94
        Me.lsvPresentMember.UseCompatibleStateImageBehavior = False
        Me.lsvPresentMember.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "ID"
        Me.ColumnHeader5.Width = 0
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "MEMBER ID"
        Me.ColumnHeader6.Width = 163
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "MEMBER NAME"
        Me.ColumnHeader7.Width = 181
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "DATE"
        Me.ColumnHeader8.Width = 125
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "STATUS"
        Me.ColumnHeader9.Width = 104
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Description"
        Me.ColumnHeader10.Width = 0
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Meeting_time"
        Me.ColumnHeader11.Width = 0
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "category"
        Me.ColumnHeader12.Width = 0
        '
        'cboMeetingtype
        '
        Me.cboMeetingtype.BackColor = System.Drawing.Color.White
        Me.cboMeetingtype.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboMeetingtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMeetingtype.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboMeetingtype.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMeetingtype.FormattingEnabled = True
        Me.cboMeetingtype.Items.AddRange(New Object() {"BURIAL MEETING", "CHURCH MEETING"})
        Me.cboMeetingtype.Location = New System.Drawing.Point(29, 186)
        Me.cboMeetingtype.Name = "cboMeetingtype"
        Me.cboMeetingtype.Size = New System.Drawing.Size(192, 23)
        Me.cboMeetingtype.TabIndex = 95
        '
        'timeRemaining
        '
        Me.timeRemaining.Interval = 1000
        '
        'PictureBox10
        '
        Me.PictureBox10.BackgroundImage = Global.church_profiling.My.Resources.Resources.c
        Me.PictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox10.Location = New System.Drawing.Point(483, 576)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(28, 23)
        Me.PictureBox10.TabIndex = 98
        Me.PictureBox10.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackgroundImage = Global.church_profiling.My.Resources.Resources.c2
        Me.PictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox9.Location = New System.Drawing.Point(273, 577)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(28, 23)
        Me.PictureBox9.TabIndex = 97
        Me.PictureBox9.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(677, 91)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 25)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 34
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Location = New System.Drawing.Point(268, 120)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(606, 437)
        Me.PictureBox3.TabIndex = 44
        Me.PictureBox3.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.White
        Me.PictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox6.Location = New System.Drawing.Point(25, 216)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(201, 29)
        Me.PictureBox6.TabIndex = 62
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Location = New System.Drawing.Point(128, 345)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(98, 24)
        Me.PictureBox7.TabIndex = 87
        Me.PictureBox7.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(699, 91)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(169, 25)
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.PictureBox5.Location = New System.Drawing.Point(268, 0)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(606, 126)
        Me.PictureBox5.TabIndex = 47
        Me.PictureBox5.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.White
        Me.PictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox8.Location = New System.Drawing.Point(25, 183)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(201, 29)
        Me.PictureBox8.TabIndex = 96
        Me.PictureBox8.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.PictureBox4.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox4.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(249, 639)
        Me.PictureBox4.TabIndex = 46
        Me.PictureBox4.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(268, 123)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 22)
        Me.Button1.TabIndex = 99
        Me.Button1.Text = "Present"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Transparent
        Me.Button2.Location = New System.Drawing.Point(369, 123)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 22)
        Me.Button2.TabIndex = 100
        Me.Button2.Text = "All Members"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.Red
        Me.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.Transparent
        Me.btnRemove.Location = New System.Drawing.Point(793, 123)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 22)
        Me.btnRemove.TabIndex = 101
        Me.btnRemove.Text = "Remove (X)"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'frmAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(892, 639)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboMeetingtype)
        Me.Controls.Add(Me.lsvPresentMember)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboOpenType)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCurrentTime)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.cboOpenMins)
        Me.Controls.Add(Me.txtDay)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.lblTotalAbsent)
        Me.Controls.Add(Me.lblTotalPresent)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cboAmPm)
        Me.Controls.Add(Me.cboMins)
        Me.Controls.Add(Me.cboHour)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.lblMins)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblTimeIn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lsvAttendance)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnActiveNow)
        Me.Controls.Add(Me.btnSet)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lblSearchMember)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.lblSec)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox4)
        Me.Name = "frmAttendance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAttendance"
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSearchMember As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnSet As System.Windows.Forms.Button
    Friend WithEvents btnActiveNow As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents lsvAttendance As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTimeIn As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblMins As System.Windows.Forms.Label
    Friend WithEvents lblSec As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents cboHour As System.Windows.Forms.ComboBox
    Friend WithEvents cboMins As System.Windows.Forms.ComboBox
    Friend WithEvents cboAmPm As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblTotalPresent As System.Windows.Forms.Label
    Friend WithEvents lblTotalAbsent As System.Windows.Forms.Label
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents txtDay As System.Windows.Forms.TextBox
    Friend WithEvents cboOpenMins As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtCurrentTime As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboOpenType As System.Windows.Forms.Label
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lsvPresentMember As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cboMeetingtype As System.Windows.Forms.ComboBox
    Friend WithEvents timeRemaining As System.Windows.Forms.Timer
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
End Class
