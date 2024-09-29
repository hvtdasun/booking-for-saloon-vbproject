<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_show_customer_service
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
        Me.txtsearchappoid = New System.Windows.Forms.TextBox()
        Me.btnsearchappo = New System.Windows.Forms.Button()
        Me.dgvserv = New System.Windows.Forms.DataGridView()
        Me.btnserv1 = New System.Windows.Forms.Button()
        CType(Me.dgvserv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtsearchappoid
        '
        Me.txtsearchappoid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearchappoid.Location = New System.Drawing.Point(676, 16)
        Me.txtsearchappoid.Multiline = True
        Me.txtsearchappoid.Name = "txtsearchappoid"
        Me.txtsearchappoid.Size = New System.Drawing.Size(130, 31)
        Me.txtsearchappoid.TabIndex = 0
        '
        'btnsearchappo
        '
        Me.btnsearchappo.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnsearchappo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearchappo.Location = New System.Drawing.Point(812, 14)
        Me.btnsearchappo.Name = "btnsearchappo"
        Me.btnsearchappo.Size = New System.Drawing.Size(89, 33)
        Me.btnsearchappo.TabIndex = 1
        Me.btnsearchappo.Text = "Search"
        Me.btnsearchappo.UseVisualStyleBackColor = False
        '
        'dgvserv
        '
        Me.dgvserv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvserv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvserv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvserv.Location = New System.Drawing.Point(145, 109)
        Me.dgvserv.Name = "dgvserv"
        Me.dgvserv.Size = New System.Drawing.Size(643, 220)
        Me.dgvserv.TabIndex = 2
        '
        'btnserv1
        '
        Me.btnserv1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnserv1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnserv1.Location = New System.Drawing.Point(26, 14)
        Me.btnserv1.Name = "btnserv1"
        Me.btnserv1.Size = New System.Drawing.Size(42, 33)
        Me.btnserv1.TabIndex = 3
        Me.btnserv1.Text = "<"
        Me.btnserv1.UseVisualStyleBackColor = False
        '
        'frm_show_customer_service
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.bookingtable.My.Resources.Resources.Premium_Photo___Makeup_products_and_striped_cosmetic_bag_on_dusty_dark_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(913, 500)
        Me.Controls.Add(Me.btnserv1)
        Me.Controls.Add(Me.dgvserv)
        Me.Controls.Add(Me.btnsearchappo)
        Me.Controls.Add(Me.txtsearchappoid)
        Me.Name = "frm_show_customer_service"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_show_customer_service"
        CType(Me.dgvserv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtsearchappoid As System.Windows.Forms.TextBox
    Friend WithEvents btnsearchappo As System.Windows.Forms.Button
    Friend WithEvents dgvserv As System.Windows.Forms.DataGridView
    Friend WithEvents btnserv1 As System.Windows.Forms.Button
End Class
