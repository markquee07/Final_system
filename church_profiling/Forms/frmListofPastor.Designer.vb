<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListofPastor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListofPastor))
        Me.lblPastor = New System.Windows.Forms.Label()
        Me.btnAddChurch = New System.Windows.Forms.Button()
        Me.lblAttendanceType = New System.Windows.Forms.Label()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader25 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lsvPastor = New System.Windows.Forms.ListView()
        Me.ColumnHeader36 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader37 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader68 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPastor
        '
        Me.lblPastor.AutoSize = True
        Me.lblPastor.BackColor = System.Drawing.Color.White
        Me.lblPastor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblPastor.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPastor.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblPastor.Location = New System.Drawing.Point(643, 93)
        Me.lblPastor.Name = "lblPastor"
        Me.lblPastor.Size = New System.Drawing.Size(82, 17)
        Me.lblPastor.TabIndex = 84
        Me.lblPastor.Text = "Search Pastor"
        '
        'btnAddChurch
        '
        Me.btnAddChurch.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnAddChurch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddChurch.ForeColor = System.Drawing.Color.White
        Me.btnAddChurch.Location = New System.Drawing.Point(43, 81)
        Me.btnAddChurch.Name = "btnAddChurch"
        Me.btnAddChurch.Size = New System.Drawing.Size(148, 41)
        Me.btnAddChurch.TabIndex = 80
        Me.btnAddChurch.Text = "View Details"
        Me.btnAddChurch.UseVisualStyleBackColor = False
        '
        'lblAttendanceType
        '
        Me.lblAttendanceType.AutoSize = True
        Me.lblAttendanceType.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblAttendanceType.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAttendanceType.ForeColor = System.Drawing.Color.White
        Me.lblAttendanceType.Location = New System.Drawing.Point(37, 28)
        Me.lblAttendanceType.Name = "lblAttendanceType"
        Me.lblAttendanceType.Size = New System.Drawing.Size(173, 31)
        Me.lblAttendanceType.TabIndex = 77
        Me.lblAttendanceType.Text = "List of Pastor"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "YEAR GRADUATED"
        Me.ColumnHeader4.Width = 0
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "SCHOOL ADDRESS"
        Me.ColumnHeader3.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "NAME OF SCHOOL GRADUATED"
        Me.ColumnHeader2.Width = 0
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "CONTACT NO."
        Me.ColumnHeader1.Width = 88
        '
        'ColumnHeader25
        '
        Me.ColumnHeader25.Text = "PASTOR NAME"
        Me.ColumnHeader25.Width = 133
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "ID"
        Me.ColumnHeader19.Width = 0
        '
        'lsvPastor
        '
        Me.lsvPastor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lsvPastor.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader19, Me.ColumnHeader25, Me.ColumnHeader36, Me.ColumnHeader37, Me.ColumnHeader68, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lsvPastor.FullRowSelect = True
        Me.lsvPastor.Location = New System.Drawing.Point(59, 183)
        Me.lsvPastor.Name = "lsvPastor"
        Me.lsvPastor.Size = New System.Drawing.Size(738, 406)
        Me.lsvPastor.TabIndex = 81
        Me.lsvPastor.UseCompatibleStateImageBehavior = False
        Me.lsvPastor.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader36
        '
        Me.ColumnHeader36.Text = "ADDRESS"
        Me.ColumnHeader36.Width = 230
        '
        'ColumnHeader37
        '
        Me.ColumnHeader37.Text = "GENDER"
        Me.ColumnHeader37.Width = 108
        '
        'ColumnHeader68
        '
        Me.ColumnHeader68.Text = "BIRTH DATE"
        Me.ColumnHeader68.Width = 147
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "CHURCH NAME"
        Me.ColumnHeader5.Width = 0
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "ADDRESS"
        Me.ColumnHeader6.Width = 0
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "YEAR OF SERVICE"
        Me.ColumnHeader7.Width = 0
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(639, 94)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(147, 15)
        Me.txtSearch.TabIndex = 85
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(604, 89)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 25)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 79
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(43, 167)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(767, 448)
        Me.PictureBox1.TabIndex = 76
        Me.PictureBox1.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.PictureBox5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox5.Location = New System.Drawing.Point(0, 645)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(848, 12)
        Me.PictureBox5.TabIndex = 83
        Me.PictureBox5.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Location = New System.Drawing.Point(633, 89)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(175, 25)
        Me.PictureBox3.TabIndex = 78
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.PictureBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox4.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(848, 137)
        Me.PictureBox4.TabIndex = 82
        Me.PictureBox4.TabStop = False
        '
        'frmListofPastor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 657)
        Me.Controls.Add(Me.lblPastor)
        Me.Controls.Add(Me.btnAddChurch)
        Me.Controls.Add(Me.lblAttendanceType)
        Me.Controls.Add(Me.lsvPastor)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Name = "frmListofPastor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmListofPastor"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPastor As System.Windows.Forms.Label
    Friend WithEvents btnAddChurch As System.Windows.Forms.Button
    Friend WithEvents lblAttendanceType As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader25 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsvPastor As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader36 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader37 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader68 As System.Windows.Forms.ColumnHeader
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
End Class
