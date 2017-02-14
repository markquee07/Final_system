<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListofDebts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListofDebts))
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ColumnHeader68 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader37 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader36 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lsvEmergencyFund = New System.Windows.Forms.ListView()
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader25 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAddChurch = New System.Windows.Forms.Button()
        Me.lblAttendanceType = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnPayBalance = New System.Windows.Forms.Button()
        Me.lsvExpenses = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.PictureBox5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox5.Location = New System.Drawing.Point(0, 682)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(942, 12)
        Me.PictureBox5.TabIndex = 70
        Me.PictureBox5.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(700, 120)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 25)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 64
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Location = New System.Drawing.Point(729, 120)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(175, 25)
        Me.PictureBox3.TabIndex = 61
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(31, 198)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(876, 448)
        Me.PictureBox1.TabIndex = 59
        Me.PictureBox1.TabStop = False
        '
        'ColumnHeader68
        '
        Me.ColumnHeader68.Text = "AMOUNT BORROWED"
        Me.ColumnHeader68.Width = 132
        '
        'ColumnHeader37
        '
        Me.ColumnHeader37.Text = "CONTACT NUMBER"
        Me.ColumnHeader37.Width = 114
        '
        'ColumnHeader36
        '
        Me.ColumnHeader36.Text = "MEMBER NAME"
        Me.ColumnHeader36.Width = 148
        '
        'lsvEmergencyFund
        '
        Me.lsvEmergencyFund.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lsvEmergencyFund.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader19, Me.ColumnHeader25, Me.ColumnHeader36, Me.ColumnHeader37, Me.ColumnHeader68, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lsvEmergencyFund.FullRowSelect = True
        Me.lsvEmergencyFund.Location = New System.Drawing.Point(47, 214)
        Me.lsvEmergencyFund.Name = "lsvEmergencyFund"
        Me.lsvEmergencyFund.Size = New System.Drawing.Size(847, 406)
        Me.lsvEmergencyFund.TabIndex = 68
        Me.lsvEmergencyFund.UseCompatibleStateImageBehavior = False
        Me.lsvEmergencyFund.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "ID"
        Me.ColumnHeader19.Width = 0
        '
        'ColumnHeader25
        '
        Me.ColumnHeader25.Text = "MEMBER ID"
        Me.ColumnHeader25.Width = 88
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "BALANCE"
        Me.ColumnHeader1.Width = 81
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "DATE BORROWED"
        Me.ColumnHeader2.Width = 123
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "DUE DATE"
        Me.ColumnHeader3.Width = 77
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "STATUS"
        Me.ColumnHeader4.Width = 82
        '
        'btnAddChurch
        '
        Me.btnAddChurch.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnAddChurch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddChurch.ForeColor = System.Drawing.Color.White
        Me.btnAddChurch.Location = New System.Drawing.Point(30, 112)
        Me.btnAddChurch.Name = "btnAddChurch"
        Me.btnAddChurch.Size = New System.Drawing.Size(148, 41)
        Me.btnAddChurch.TabIndex = 67
        Me.btnAddChurch.Text = "Income"
        Me.btnAddChurch.UseVisualStyleBackColor = False
        '
        'lblAttendanceType
        '
        Me.lblAttendanceType.AutoSize = True
        Me.lblAttendanceType.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblAttendanceType.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAttendanceType.ForeColor = System.Drawing.Color.White
        Me.lblAttendanceType.Location = New System.Drawing.Point(25, 37)
        Me.lblAttendanceType.Name = "lblAttendanceType"
        Me.lblAttendanceType.Size = New System.Drawing.Size(448, 31)
        Me.lblAttendanceType.TabIndex = 60
        Me.lblAttendanceType.Text = "List of Church Financial Transaction"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.PictureBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox4.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(942, 155)
        Me.PictureBox4.TabIndex = 69
        Me.PictureBox4.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Location = New System.Drawing.Point(733, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 17)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Search Member"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(178, 112)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 41)
        Me.Button1.TabIndex = 72
        Me.Button1.Text = "Expenses"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(317, 112)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(143, 41)
        Me.Button2.TabIndex = 73
        Me.Button2.Text = "Emergency Funds"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnPayBalance
        '
        Me.btnPayBalance.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnPayBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPayBalance.ForeColor = System.Drawing.Color.White
        Me.btnPayBalance.Location = New System.Drawing.Point(700, 161)
        Me.btnPayBalance.Name = "btnPayBalance"
        Me.btnPayBalance.Size = New System.Drawing.Size(207, 31)
        Me.btnPayBalance.TabIndex = 74
        Me.btnPayBalance.Text = "Pay Balance"
        Me.btnPayBalance.UseVisualStyleBackColor = False
        '
        'lsvExpenses
        '
        Me.lsvExpenses.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lsvExpenses.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.lsvExpenses.FullRowSelect = True
        Me.lsvExpenses.Location = New System.Drawing.Point(47, 214)
        Me.lsvExpenses.Name = "lsvExpenses"
        Me.lsvExpenses.Size = New System.Drawing.Size(847, 406)
        Me.lsvExpenses.TabIndex = 75
        Me.lsvExpenses.UseCompatibleStateImageBehavior = False
        Me.lsvExpenses.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "ID"
        Me.ColumnHeader5.Width = 0
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "EXPENSES TYPE"
        Me.ColumnHeader6.Width = 251
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "AMOUNT"
        Me.ColumnHeader7.Width = 274
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "TRANSACTION DATE"
        Me.ColumnHeader8.Width = 314
        '
        'frmListofDebts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 694)
        Me.Controls.Add(Me.lsvExpenses)
        Me.Controls.Add(Me.btnPayBalance)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.lsvEmergencyFund)
        Me.Controls.Add(Me.btnAddChurch)
        Me.Controls.Add(Me.lblAttendanceType)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmListofDebts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmListofDebts"
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ColumnHeader68 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader37 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader36 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsvEmergencyFund As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader25 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnAddChurch As System.Windows.Forms.Button
    Friend WithEvents lblAttendanceType As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnPayBalance As System.Windows.Forms.Button
    Friend WithEvents lsvExpenses As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
End Class
