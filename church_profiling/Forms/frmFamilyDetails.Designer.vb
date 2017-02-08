<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFamilyDetails
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
        Me.lsvListOffamilydetails = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lsvListOffamilydetails
        '
        Me.lsvListOffamilydetails.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lsvListOffamilydetails.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lsvListOffamilydetails.FullRowSelect = True
        Me.lsvListOffamilydetails.Location = New System.Drawing.Point(89, 67)
        Me.lsvListOffamilydetails.Name = "lsvListOffamilydetails"
        Me.lsvListOffamilydetails.Size = New System.Drawing.Size(751, 396)
        Me.lsvListOffamilydetails.TabIndex = 45
        Me.lsvListOffamilydetails.UseCompatibleStateImageBehavior = False
        Me.lsvListOffamilydetails.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 0
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "CHILD ID"
        Me.ColumnHeader1.Width = 66
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "FIRST NAME"
        Me.ColumnHeader2.Width = 180
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "LAST NAME"
        Me.ColumnHeader3.Width = 167
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "MIDDLE NAME"
        Me.ColumnHeader4.Width = 152
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "DATE OF BIRTH"
        Me.ColumnHeader5.Width = 101
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "GENDER"
        Me.ColumnHeader6.Width = 71
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "CHURCH MEMBER"
        Me.ColumnHeader7.Width = 114
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(61, 55)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(794, 421)
        Me.PictureBox1.TabIndex = 46
        Me.PictureBox1.TabStop = False
        '
        'frmFamilyDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 522)
        Me.Controls.Add(Me.lsvListOffamilydetails)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmFamilyDetails"
        Me.Text = "frmFamilyDetails"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lsvListOffamilydetails As System.Windows.Forms.ListView
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
