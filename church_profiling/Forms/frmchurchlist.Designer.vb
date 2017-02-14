<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmchurchlist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmchurchlist))
        Me.btnDeleteChurch = New System.Windows.Forms.Button()
        Me.lblSearchMember = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblAttendanceType = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAddChurch = New System.Windows.Forms.Button()
        Me.lsvChurch = New System.Windows.Forms.ListView()
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader25 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader36 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader37 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader68 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDeleteChurch
        '
        Me.btnDeleteChurch.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnDeleteChurch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteChurch.ForeColor = System.Drawing.Color.White
        Me.btnDeleteChurch.Location = New System.Drawing.Point(238, 103)
        Me.btnDeleteChurch.Name = "btnDeleteChurch"
        Me.btnDeleteChurch.Size = New System.Drawing.Size(101, 36)
        Me.btnDeleteChurch.TabIndex = 51
        Me.btnDeleteChurch.Text = "Delete"
        Me.btnDeleteChurch.UseVisualStyleBackColor = False
        '
        'lblSearchMember
        '
        Me.lblSearchMember.AutoSize = True
        Me.lblSearchMember.BackColor = System.Drawing.Color.White
        Me.lblSearchMember.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblSearchMember.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchMember.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblSearchMember.Location = New System.Drawing.Point(657, 112)
        Me.lblSearchMember.Name = "lblSearchMember"
        Me.lblSearchMember.Size = New System.Drawing.Size(121, 17)
        Me.lblSearchMember.TabIndex = 49
        Me.lblSearchMember.Text = "Search Church Name"
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(655, 113)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(154, 15)
        Me.txtSearch.TabIndex = 48
        '
        'lblAttendanceType
        '
        Me.lblAttendanceType.AutoSize = True
        Me.lblAttendanceType.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblAttendanceType.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAttendanceType.ForeColor = System.Drawing.Color.White
        Me.lblAttendanceType.Location = New System.Drawing.Point(18, 39)
        Me.lblAttendanceType.Name = "lblAttendanceType"
        Me.lblAttendanceType.Size = New System.Drawing.Size(321, 31)
        Me.lblAttendanceType.TabIndex = 46
        Me.lblAttendanceType.Text = "List of Registered Church"
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(131, 103)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(101, 34)
        Me.btnEdit.TabIndex = 52
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnAddChurch
        '
        Me.btnAddChurch.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnAddChurch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddChurch.ForeColor = System.Drawing.Color.White
        Me.btnAddChurch.Location = New System.Drawing.Point(24, 103)
        Me.btnAddChurch.Name = "btnAddChurch"
        Me.btnAddChurch.Size = New System.Drawing.Size(101, 34)
        Me.btnAddChurch.TabIndex = 53
        Me.btnAddChurch.Text = "Add New"
        Me.btnAddChurch.UseVisualStyleBackColor = False
        '
        'lsvChurch
        '
        Me.lsvChurch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lsvChurch.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader19, Me.ColumnHeader25, Me.ColumnHeader36, Me.ColumnHeader37, Me.ColumnHeader68})
        Me.lsvChurch.FullRowSelect = True
        Me.lsvChurch.Location = New System.Drawing.Point(41, 192)
        Me.lsvChurch.Name = "lsvChurch"
        Me.lsvChurch.Size = New System.Drawing.Size(771, 436)
        Me.lsvChurch.TabIndex = 54
        Me.lsvChurch.UseCompatibleStateImageBehavior = False
        Me.lsvChurch.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "ID"
        Me.ColumnHeader19.Width = 0
        '
        'ColumnHeader25
        '
        Me.ColumnHeader25.Text = "CHURCH NAME"
        Me.ColumnHeader25.Width = 188
        '
        'ColumnHeader36
        '
        Me.ColumnHeader36.Text = "ADDRESS"
        Me.ColumnHeader36.Width = 208
        '
        'ColumnHeader37
        '
        Me.ColumnHeader37.Text = "CONTACT NUMBER"
        Me.ColumnHeader37.Width = 150
        '
        'ColumnHeader68
        '
        Me.ColumnHeader68.Text = "EMAIL ADD"
        Me.ColumnHeader68.Width = 217
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(617, 108)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 25)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 50
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Location = New System.Drawing.Point(647, 108)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(175, 25)
        Me.PictureBox3.TabIndex = 47
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(23, 178)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(801, 469)
        Me.PictureBox1.TabIndex = 45
        Me.PictureBox1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.PictureBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox4.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(848, 155)
        Me.PictureBox4.TabIndex = 57
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.PictureBox5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox5.Location = New System.Drawing.Point(0, 675)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(848, 12)
        Me.PictureBox5.TabIndex = 58
        Me.PictureBox5.TabStop = False
        '
        'frmchurchlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 687)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.lsvChurch)
        Me.Controls.Add(Me.btnAddChurch)
        Me.Controls.Add(Me.btnDeleteChurch)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lblSearchMember)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.lblAttendanceType)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.PictureBox4)
        Me.Name = "frmchurchlist"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmchurchlist"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDeleteChurch As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblSearchMember As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents lblAttendanceType As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnAddChurch As System.Windows.Forms.Button
    Friend WithEvents lsvChurch As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader25 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader36 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader37 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader68 As System.Windows.Forms.ColumnHeader
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
End Class
