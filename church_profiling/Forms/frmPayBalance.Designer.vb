<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayBalance
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
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.lblPaidStatus = New System.Windows.Forms.Label()
        Me.lblDueDate = New System.Windows.Forms.Label()
        Me.lblDateBorrowed = New System.Windows.Forms.Label()
        Me.lblMemberName = New System.Windows.Forms.Label()
        Me.lblMemberID = New System.Windows.Forms.Label()
        Me.l7 = New System.Windows.Forms.Label()
        Me.l6 = New System.Windows.Forms.Label()
        Me.l5 = New System.Windows.Forms.Label()
        Me.l4 = New System.Windows.Forms.Label()
        Me.l3 = New System.Windows.Forms.Label()
        Me.l2 = New System.Windows.Forms.Label()
        Me.l1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalance.Location = New System.Drawing.Point(182, 319)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(77, 16)
        Me.lblBalance.TabIndex = 72
        Me.lblBalance.Text = "Member ID:"
        '
        'lblPaidStatus
        '
        Me.lblPaidStatus.AutoSize = True
        Me.lblPaidStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaidStatus.Location = New System.Drawing.Point(182, 287)
        Me.lblPaidStatus.Name = "lblPaidStatus"
        Me.lblPaidStatus.Size = New System.Drawing.Size(77, 16)
        Me.lblPaidStatus.TabIndex = 71
        Me.lblPaidStatus.Text = "Member ID:"
        '
        'lblDueDate
        '
        Me.lblDueDate.AutoSize = True
        Me.lblDueDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDueDate.Location = New System.Drawing.Point(182, 250)
        Me.lblDueDate.Name = "lblDueDate"
        Me.lblDueDate.Size = New System.Drawing.Size(77, 16)
        Me.lblDueDate.TabIndex = 70
        Me.lblDueDate.Text = "Member ID:"
        '
        'lblDateBorrowed
        '
        Me.lblDateBorrowed.AutoSize = True
        Me.lblDateBorrowed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateBorrowed.Location = New System.Drawing.Point(182, 218)
        Me.lblDateBorrowed.Name = "lblDateBorrowed"
        Me.lblDateBorrowed.Size = New System.Drawing.Size(77, 16)
        Me.lblDateBorrowed.TabIndex = 69
        Me.lblDateBorrowed.Text = "Member ID:"
        '
        'lblMemberName
        '
        Me.lblMemberName.AutoSize = True
        Me.lblMemberName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemberName.Location = New System.Drawing.Point(182, 183)
        Me.lblMemberName.Name = "lblMemberName"
        Me.lblMemberName.Size = New System.Drawing.Size(77, 16)
        Me.lblMemberName.TabIndex = 68
        Me.lblMemberName.Text = "Member ID:"
        '
        'lblMemberID
        '
        Me.lblMemberID.AutoSize = True
        Me.lblMemberID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemberID.Location = New System.Drawing.Point(182, 149)
        Me.lblMemberID.Name = "lblMemberID"
        Me.lblMemberID.Size = New System.Drawing.Size(77, 16)
        Me.lblMemberID.TabIndex = 67
        Me.lblMemberID.Text = "Member ID:"
        '
        'l7
        '
        Me.l7.AutoSize = True
        Me.l7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l7.Location = New System.Drawing.Point(55, 319)
        Me.l7.Name = "l7"
        Me.l7.Size = New System.Drawing.Size(61, 16)
        Me.l7.TabIndex = 66
        Me.l7.Text = "Balance:"
        '
        'l6
        '
        Me.l6.AutoSize = True
        Me.l6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l6.Location = New System.Drawing.Point(55, 287)
        Me.l6.Name = "l6"
        Me.l6.Size = New System.Drawing.Size(48, 16)
        Me.l6.TabIndex = 65
        Me.l6.Text = "Status:"
        '
        'l5
        '
        Me.l5.AutoSize = True
        Me.l5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l5.Location = New System.Drawing.Point(55, 254)
        Me.l5.Name = "l5"
        Me.l5.Size = New System.Drawing.Size(68, 16)
        Me.l5.TabIndex = 64
        Me.l5.Text = "Due Date:"
        '
        'l4
        '
        Me.l4.AutoSize = True
        Me.l4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l4.Location = New System.Drawing.Point(55, 218)
        Me.l4.Name = "l4"
        Me.l4.Size = New System.Drawing.Size(101, 16)
        Me.l4.TabIndex = 63
        Me.l4.Text = "Date Borrowed:"
        '
        'l3
        '
        Me.l3.AutoSize = True
        Me.l3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l3.Location = New System.Drawing.Point(55, 183)
        Me.l3.Name = "l3"
        Me.l3.Size = New System.Drawing.Size(101, 16)
        Me.l3.TabIndex = 62
        Me.l3.Text = "Member Name:"
        '
        'l2
        '
        Me.l2.AutoSize = True
        Me.l2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l2.Location = New System.Drawing.Point(55, 149)
        Me.l2.Name = "l2"
        Me.l2.Size = New System.Drawing.Size(77, 16)
        Me.l2.TabIndex = 61
        Me.l2.Text = "Member ID:"
        '
        'l1
        '
        Me.l1.AutoSize = True
        Me.l1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l1.Location = New System.Drawing.Point(54, 103)
        Me.l1.Name = "l1"
        Me.l1.Size = New System.Drawing.Size(158, 20)
        Me.l1.TabIndex = 60
        Me.l1.Text = "Borrower Information"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(406, 74)
        Me.PictureBox1.TabIndex = 73
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(53, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 29)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "Borrower Information"
        '
        'frmPayBalance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(406, 495)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblBalance)
        Me.Controls.Add(Me.lblPaidStatus)
        Me.Controls.Add(Me.lblDueDate)
        Me.Controls.Add(Me.lblDateBorrowed)
        Me.Controls.Add(Me.lblMemberName)
        Me.Controls.Add(Me.lblMemberID)
        Me.Controls.Add(Me.l7)
        Me.Controls.Add(Me.l6)
        Me.Controls.Add(Me.l5)
        Me.Controls.Add(Me.l4)
        Me.Controls.Add(Me.l3)
        Me.Controls.Add(Me.l2)
        Me.Controls.Add(Me.l1)
        Me.Name = "frmPayBalance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPayBalance"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBalance As System.Windows.Forms.Label
    Friend WithEvents lblPaidStatus As System.Windows.Forms.Label
    Friend WithEvents lblDueDate As System.Windows.Forms.Label
    Friend WithEvents lblDateBorrowed As System.Windows.Forms.Label
    Friend WithEvents lblMemberName As System.Windows.Forms.Label
    Friend WithEvents lblMemberID As System.Windows.Forms.Label
    Friend WithEvents l7 As System.Windows.Forms.Label
    Friend WithEvents l6 As System.Windows.Forms.Label
    Friend WithEvents l5 As System.Windows.Forms.Label
    Friend WithEvents l4 As System.Windows.Forms.Label
    Friend WithEvents l3 As System.Windows.Forms.Label
    Friend WithEvents l2 As System.Windows.Forms.Label
    Friend WithEvents l1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
