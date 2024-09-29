<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sihina_Saloon_Admin
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
        Me.btnreport = New System.Windows.Forms.Button()
        Me.btnservice = New System.Windows.Forms.Button()
        Me.btnadminlogout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnreport
        '
        Me.btnreport.BackColor = System.Drawing.Color.Wheat
        Me.btnreport.BackgroundImage = Global.bookingtable.My.Resources.Resources.pngegg__2_
        Me.btnreport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnreport.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreport.Location = New System.Drawing.Point(152, 286)
        Me.btnreport.Name = "btnreport"
        Me.btnreport.Size = New System.Drawing.Size(132, 78)
        Me.btnreport.TabIndex = 2
        Me.btnreport.UseVisualStyleBackColor = False
        '
        'btnservice
        '
        Me.btnservice.BackColor = System.Drawing.Color.Wheat
        Me.btnservice.BackgroundImage = Global.bookingtable.My.Resources.Resources.r8ank7bugsd76um9kb2pe611r7
        Me.btnservice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnservice.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnservice.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnservice.Location = New System.Drawing.Point(152, 124)
        Me.btnservice.Name = "btnservice"
        Me.btnservice.Size = New System.Drawing.Size(132, 76)
        Me.btnservice.TabIndex = 1
        Me.btnservice.UseVisualStyleBackColor = False
        '
        'btnadminlogout
        '
        Me.btnadminlogout.BackColor = System.Drawing.Color.Red
        Me.btnadminlogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadminlogout.Location = New System.Drawing.Point(315, 477)
        Me.btnadminlogout.Name = "btnadminlogout"
        Me.btnadminlogout.Size = New System.Drawing.Size(75, 23)
        Me.btnadminlogout.TabIndex = 3
        Me.btnadminlogout.Text = "Logout"
        Me.btnadminlogout.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(160, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Add Service"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(176, 248)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Report"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Controls.Add(Me.btnservice)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnadminlogout)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnreport)
        Me.GroupBox1.Location = New System.Drawing.Point(511, -12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(406, 516)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label4.Location = New System.Drawing.Point(57, 432)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(299, 39)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Sihina Sathsara Bandara"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Nature Beauty Personal Use", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label3.Location = New System.Drawing.Point(1, 358)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(355, 91)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Sihina Saloon"
        '
        'Sihina_Saloon_Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImage = Global.bookingtable.My.Resources.Resources.wp2035457_salon_wallpapers
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(913, 500)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Sihina_Saloon_Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sihina Saloon Admin"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnreport As System.Windows.Forms.Button
    Friend WithEvents btnservice As System.Windows.Forms.Button
    Friend WithEvents btnadminlogout As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
