<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sihina_Saloon_Employee
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
        Me.btnaddcus = New System.Windows.Forms.Button()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.btnfrm = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnview = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnaddcus
        '
        Me.btnaddcus.BackColor = System.Drawing.Color.Black
        Me.btnaddcus.BackgroundImage = Global.bookingtable.My.Resources.Resources.new_customer_icon_19
        Me.btnaddcus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnaddcus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddcus.ForeColor = System.Drawing.Color.Transparent
        Me.btnaddcus.Location = New System.Drawing.Point(135, 74)
        Me.btnaddcus.Name = "btnaddcus"
        Me.btnaddcus.Size = New System.Drawing.Size(119, 76)
        Me.btnaddcus.TabIndex = 1
        Me.btnaddcus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnaddcus.UseVisualStyleBackColor = False
        '
        'btnlogout
        '
        Me.btnlogout.BackColor = System.Drawing.Color.Red
        Me.btnlogout.Location = New System.Drawing.Point(277, 469)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(88, 32)
        Me.btnlogout.TabIndex = 3
        Me.btnlogout.Text = "Log out"
        Me.btnlogout.UseVisualStyleBackColor = False
        '
        'btnfrm
        '
        Me.btnfrm.BackColor = System.Drawing.Color.Black
        Me.btnfrm.BackgroundImage = Global.bookingtable.My.Resources.Resources.pngwing_com
        Me.btnfrm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnfrm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfrm.ForeColor = System.Drawing.Color.Transparent
        Me.btnfrm.Location = New System.Drawing.Point(135, 230)
        Me.btnfrm.Name = "btnfrm"
        Me.btnfrm.Size = New System.Drawing.Size(119, 76)
        Me.btnfrm.TabIndex = 2
        Me.btnfrm.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnfrm.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Nature Beauty Personal Use", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label3.Location = New System.Drawing.Point(0, 322)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(355, 91)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Sihina Saloon"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label4.Location = New System.Drawing.Point(56, 396)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(299, 39)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Sihina Sathsara Bandara"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(131, 190)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Appointment"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(131, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Add Customer"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btnview)
        Me.GroupBox1.Controls.Add(Me.btnlogout)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnfrm)
        Me.GroupBox1.Controls.Add(Me.btnaddcus)
        Me.GroupBox1.Location = New System.Drawing.Point(536, -13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(384, 520)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(65, 335)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(251, 48)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Show Customer Selected " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "             Services"
        '
        'btnview
        '
        Me.btnview.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnview.BackgroundImage = Global.bookingtable.My.Resources.Resources.pngwing1
        Me.btnview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnview.Location = New System.Drawing.Point(135, 396)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(119, 76)
        Me.btnview.TabIndex = 10
        Me.btnview.UseVisualStyleBackColor = False
        '
        'Sihina_Saloon_Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.bookingtable.My.Resources.Resources.wp2035457_salon_wallpapers
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(913, 500)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Sihina_Saloon_Employee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sihina_Saloon_Employee"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnaddcus As System.Windows.Forms.Button
    Friend WithEvents btnlogout As System.Windows.Forms.Button
    Friend WithEvents btnfrm As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnview As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
