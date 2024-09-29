<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class services
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
        Me.btnsclose = New System.Windows.Forms.Button()
        Me.btnscancel = New System.Windows.Forms.Button()
        Me.btnsdelete = New System.Windows.Forms.Button()
        Me.btnssave = New System.Windows.Forms.Button()
        Me.btnsedit = New System.Windows.Forms.Button()
        Me.btnsadd = New System.Windows.Forms.Button()
        Me.btnssearch = New System.Windows.Forms.Button()
        Me.txtssearch = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtsid = New System.Windows.Forms.TextBox()
        Me.txtsprice = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtsname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvservices = New System.Windows.Forms.DataGridView()
        Me.TblserviceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Appointment_tabelDataSet = New bookingtable.Appointment_tabelDataSet()
        Me.TblserviceTableAdapter = New bookingtable.Appointment_tabelDataSetTableAdapters.tblserviceTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvservices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblserviceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Appointment_tabelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnsclose
        '
        Me.btnsclose.Location = New System.Drawing.Point(798, 444)
        Me.btnsclose.Name = "btnsclose"
        Me.btnsclose.Size = New System.Drawing.Size(75, 32)
        Me.btnsclose.TabIndex = 9
        Me.btnsclose.Text = "Close"
        Me.btnsclose.UseVisualStyleBackColor = True
        '
        'btnscancel
        '
        Me.btnscancel.Location = New System.Drawing.Point(696, 444)
        Me.btnscancel.Name = "btnscancel"
        Me.btnscancel.Size = New System.Drawing.Size(75, 32)
        Me.btnscancel.TabIndex = 8
        Me.btnscancel.Text = "Cancel"
        Me.btnscancel.UseVisualStyleBackColor = True
        '
        'btnsdelete
        '
        Me.btnsdelete.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnsdelete.Location = New System.Drawing.Point(798, 396)
        Me.btnsdelete.Name = "btnsdelete"
        Me.btnsdelete.Size = New System.Drawing.Size(75, 32)
        Me.btnsdelete.TabIndex = 7
        Me.btnsdelete.Text = "Delete"
        Me.btnsdelete.UseVisualStyleBackColor = False
        '
        'btnssave
        '
        Me.btnssave.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnssave.Location = New System.Drawing.Point(696, 396)
        Me.btnssave.Name = "btnssave"
        Me.btnssave.Size = New System.Drawing.Size(75, 32)
        Me.btnssave.TabIndex = 6
        Me.btnssave.Text = "Save"
        Me.btnssave.UseVisualStyleBackColor = False
        '
        'btnsedit
        '
        Me.btnsedit.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnsedit.Location = New System.Drawing.Point(595, 396)
        Me.btnsedit.Name = "btnsedit"
        Me.btnsedit.Size = New System.Drawing.Size(75, 32)
        Me.btnsedit.TabIndex = 5
        Me.btnsedit.Text = "Edit"
        Me.btnsedit.UseVisualStyleBackColor = False
        '
        'btnsadd
        '
        Me.btnsadd.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnsadd.Location = New System.Drawing.Point(505, 396)
        Me.btnsadd.Name = "btnsadd"
        Me.btnsadd.Size = New System.Drawing.Size(75, 32)
        Me.btnsadd.TabIndex = 4
        Me.btnsadd.Text = "Add"
        Me.btnsadd.UseVisualStyleBackColor = False
        '
        'btnssearch
        '
        Me.btnssearch.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnssearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnssearch.Location = New System.Drawing.Point(640, 12)
        Me.btnssearch.Name = "btnssearch"
        Me.btnssearch.Size = New System.Drawing.Size(86, 33)
        Me.btnssearch.TabIndex = 11
        Me.btnssearch.Text = "Search"
        Me.btnssearch.UseVisualStyleBackColor = False
        '
        'txtssearch
        '
        Me.txtssearch.Location = New System.Drawing.Point(515, 12)
        Me.txtssearch.Multiline = True
        Me.txtssearch.Name = "txtssearch"
        Me.txtssearch.Size = New System.Drawing.Size(100, 33)
        Me.txtssearch.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtsid)
        Me.GroupBox1.Controls.Add(Me.txtsprice)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtsname)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(469, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(419, 307)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gold
        Me.Label8.Location = New System.Drawing.Point(87, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(274, 46)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Services Detail"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(38, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Services id :"
        '
        'txtsid
        '
        Me.txtsid.Location = New System.Drawing.Point(157, 115)
        Me.txtsid.Multiline = True
        Me.txtsid.Name = "txtsid"
        Me.txtsid.Size = New System.Drawing.Size(100, 26)
        Me.txtsid.TabIndex = 1
        '
        'txtsprice
        '
        Me.txtsprice.Location = New System.Drawing.Point(157, 180)
        Me.txtsprice.Multiline = True
        Me.txtsprice.Name = "txtsprice"
        Me.txtsprice.Size = New System.Drawing.Size(163, 26)
        Me.txtsprice.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gold
        Me.Label6.Location = New System.Drawing.Point(13, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Services price :"
        '
        'txtsname
        '
        Me.txtsname.Location = New System.Drawing.Point(157, 148)
        Me.txtsname.Multiline = True
        Me.txtsname.Name = "txtsname"
        Me.txtsname.Size = New System.Drawing.Size(245, 26)
        Me.txtsname.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(10, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Services name :"
        '
        'dgvservices
        '
        Me.dgvservices.BackgroundColor = System.Drawing.Color.White
        Me.dgvservices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvservices.Location = New System.Drawing.Point(53, 61)
        Me.dgvservices.Name = "dgvservices"
        Me.dgvservices.Size = New System.Drawing.Size(329, 355)
        Me.dgvservices.TabIndex = 18
        '
        'TblserviceBindingSource
        '
        Me.TblserviceBindingSource.DataMember = "tblservice"
        Me.TblserviceBindingSource.DataSource = Me.Appointment_tabelDataSet
        '
        'Appointment_tabelDataSet
        '
        Me.Appointment_tabelDataSet.DataSetName = "Appointment_tabelDataSet"
        Me.Appointment_tabelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblserviceTableAdapter
        '
        Me.TblserviceTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(24, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 37)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "<"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'services
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.BackgroundImage = Global.bookingtable.My.Resources.Resources.Premium_Photo___Makeup_products_and_striped_cosmetic_bag_on_dusty_dark_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(913, 506)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgvservices)
        Me.Controls.Add(Me.btnsclose)
        Me.Controls.Add(Me.btnscancel)
        Me.Controls.Add(Me.btnsdelete)
        Me.Controls.Add(Me.btnssave)
        Me.Controls.Add(Me.btnsedit)
        Me.Controls.Add(Me.btnsadd)
        Me.Controls.Add(Me.btnssearch)
        Me.Controls.Add(Me.txtssearch)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "services"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "services"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvservices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblserviceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Appointment_tabelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnsclose As System.Windows.Forms.Button
    Friend WithEvents btnscancel As System.Windows.Forms.Button
    Friend WithEvents btnsdelete As System.Windows.Forms.Button
    Friend WithEvents btnssave As System.Windows.Forms.Button
    Friend WithEvents btnsedit As System.Windows.Forms.Button
    Friend WithEvents btnsadd As System.Windows.Forms.Button
    Friend WithEvents btnssearch As System.Windows.Forms.Button
    Friend WithEvents txtssearch As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtsid As System.Windows.Forms.TextBox
    Friend WithEvents txtsprice As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtsname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvservices As System.Windows.Forms.DataGridView
    Friend WithEvents Appointment_tabelDataSet As bookingtable.Appointment_tabelDataSet
    Friend WithEvents TblserviceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblserviceTableAdapter As bookingtable.Appointment_tabelDataSetTableAdapters.tblserviceTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
