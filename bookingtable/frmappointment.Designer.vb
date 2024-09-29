<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmappointment
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btncsearch = New System.Windows.Forms.Button()
        Me.txtcsearch = New System.Windows.Forms.TextBox()
        Me.txtcfname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbtime = New System.Windows.Forms.TextBox()
        Me.txtbid = New System.Windows.Forms.TextBox()
        Me.btnbooking = New System.Windows.Forms.Button()
        Me.EventLog1 = New System.Diagnostics.EventLog()
        Me.dgvbooking = New System.Windows.Forms.DataGridView()
        Me.txtGetDate = New System.Windows.Forms.TextBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.dtpbooking = New System.Windows.Forms.DateTimePicker()
        Me.DirectorySearcher1 = New System.DirectoryServices.DirectorySearcher()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnappdelete = New System.Windows.Forms.Button()
        Me.btnAddGrid = New System.Windows.Forms.Button()
        Me.dgvSelectedServices = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboservices = New System.Windows.Forms.ComboBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.btnback2 = New System.Windows.Forms.Button()
        Me.TblAppointmentBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Appointment_tabelDataSet1 = New bookingtable.Appointment_tabelDataSet1()
        Me.Appointment_tabelDataSet = New bookingtable.Appointment_tabelDataSet()
        Me.TblAppointmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblAppointmentTableAdapter = New bookingtable.Appointment_tabelDataSetTableAdapters.tblAppointmentTableAdapter()
        Me.Tblappointment_servicesTableAdapter = New bookingtable.Appointment_tabelDataSetTableAdapters.tblappointment_servicesTableAdapter()
        Me.TblAppointmentBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblAppointmentBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblAppointmentTableAdapter1 = New bookingtable.Appointment_tabelDataSet1TableAdapters.tblAppointmentTableAdapter()
        Me.TblAppointmentBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Appointment_tabelDataSet3 = New bookingtable.Appointment_tabelDataSet3()
        Me.TblAppointmentBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Appointment_tabelDataSet2 = New bookingtable.Appointment_tabelDataSet2()
        Me.TblAppointmentTableAdapter2 = New bookingtable.Appointment_tabelDataSet2TableAdapters.tblAppointmentTableAdapter()
        Me.TblAppointmentTableAdapter3 = New bookingtable.Appointment_tabelDataSet3TableAdapters.tblAppointmentTableAdapter()
        Me.Tblappointment_servicesTableAdapter1 = New bookingtable.Appointment_tabelDataSet1TableAdapters.tblappointment_servicesTableAdapter()
        Me.TblAppointmenttblappointmentservicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblAppointmenttblappointmentservicesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvbooking, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvSelectedServices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblAppointmentBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Appointment_tabelDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Appointment_tabelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblAppointmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblAppointmentBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblAppointmentBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblAppointmentBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Appointment_tabelDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblAppointmentBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Appointment_tabelDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblAppointmenttblappointmentservicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblAppointmenttblappointmentservicesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(35, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Full name :"
        '
        'btncsearch
        '
        Me.btncsearch.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btncsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncsearch.Location = New System.Drawing.Point(291, 19)
        Me.btncsearch.Name = "btncsearch"
        Me.btncsearch.Size = New System.Drawing.Size(75, 28)
        Me.btncsearch.TabIndex = 2
        Me.btncsearch.Text = "Search"
        Me.btncsearch.UseVisualStyleBackColor = False
        '
        'txtcsearch
        '
        Me.txtcsearch.Location = New System.Drawing.Point(150, 19)
        Me.txtcsearch.Multiline = True
        Me.txtcsearch.Name = "txtcsearch"
        Me.txtcsearch.Size = New System.Drawing.Size(125, 28)
        Me.txtcsearch.TabIndex = 1
        '
        'txtcfname
        '
        Me.txtcfname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcfname.Location = New System.Drawing.Point(127, 64)
        Me.txtcfname.Multiline = True
        Me.txtcfname.Name = "txtcfname"
        Me.txtcfname.Size = New System.Drawing.Size(245, 26)
        Me.txtcfname.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gold
        Me.Label4.Location = New System.Drawing.Point(15, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 20)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Booking Time :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(17, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 20)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Booking date :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(29, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 20)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Booking Id :"
        '
        'txtbtime
        '
        Me.txtbtime.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbtime.Location = New System.Drawing.Point(127, 181)
        Me.txtbtime.Multiline = True
        Me.txtbtime.Name = "txtbtime"
        Me.txtbtime.Size = New System.Drawing.Size(100, 26)
        Me.txtbtime.TabIndex = 6
        '
        'txtbid
        '
        Me.txtbid.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbid.Location = New System.Drawing.Point(127, 102)
        Me.txtbid.Multiline = True
        Me.txtbid.Name = "txtbid"
        Me.txtbid.Size = New System.Drawing.Size(100, 26)
        Me.txtbid.TabIndex = 4
        '
        'btnbooking
        '
        Me.btnbooking.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnbooking.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbooking.Location = New System.Drawing.Point(157, 432)
        Me.btnbooking.Name = "btnbooking"
        Me.btnbooking.Size = New System.Drawing.Size(74, 37)
        Me.btnbooking.TabIndex = 9
        Me.btnbooking.Text = "Booking"
        Me.btnbooking.UseVisualStyleBackColor = False
        '
        'EventLog1
        '
        Me.EventLog1.SynchronizingObject = Me
        '
        'dgvbooking
        '
        Me.dgvbooking.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvbooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvbooking.Location = New System.Drawing.Point(12, 220)
        Me.dgvbooking.Name = "dgvbooking"
        Me.dgvbooking.Size = New System.Drawing.Size(344, 187)
        Me.dgvbooking.TabIndex = 34
        '
        'txtGetDate
        '
        Me.txtGetDate.Location = New System.Drawing.Point(251, 140)
        Me.txtGetDate.Name = "txtGetDate"
        Me.txtGetDate.Size = New System.Drawing.Size(122, 20)
        Me.txtGetDate.TabIndex = 36
        Me.txtGetDate.Visible = False
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(12, 46)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 37
        '
        'dtpbooking
        '
        Me.dtpbooking.Location = New System.Drawing.Point(127, 140)
        Me.dtpbooking.Name = "dtpbooking"
        Me.dtpbooking.Size = New System.Drawing.Size(200, 24)
        Me.dtpbooking.TabIndex = 5
        '
        'DirectorySearcher1
        '
        Me.DirectorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnclear)
        Me.GroupBox1.Controls.Add(Me.btnappdelete)
        Me.GroupBox1.Controls.Add(Me.btnAddGrid)
        Me.GroupBox1.Controls.Add(Me.dgvSelectedServices)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cboservices)
        Me.GroupBox1.Controls.Add(Me.txttotal)
        Me.GroupBox1.Controls.Add(Me.btncsearch)
        Me.GroupBox1.Controls.Add(Me.dtpbooking)
        Me.GroupBox1.Controls.Add(Me.txtcsearch)
        Me.GroupBox1.Controls.Add(Me.txtcfname)
        Me.GroupBox1.Controls.Add(Me.btnbooking)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtbid)
        Me.GroupBox1.Controls.Add(Me.txtbtime)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(379, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(519, 488)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Booking"
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Location = New System.Drawing.Point(418, 432)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(75, 37)
        Me.btnclear.TabIndex = 11
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'btnappdelete
        '
        Me.btnappdelete.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnappdelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnappdelete.Location = New System.Drawing.Point(261, 432)
        Me.btnappdelete.Name = "btnappdelete"
        Me.btnappdelete.Size = New System.Drawing.Size(129, 37)
        Me.btnappdelete.TabIndex = 10
        Me.btnappdelete.Text = "Booking Cancel"
        Me.btnappdelete.UseVisualStyleBackColor = False
        '
        'btnAddGrid
        '
        Me.btnAddGrid.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnAddGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddGrid.Location = New System.Drawing.Point(343, 215)
        Me.btnAddGrid.Name = "btnAddGrid"
        Me.btnAddGrid.Size = New System.Drawing.Size(150, 27)
        Me.btnAddGrid.TabIndex = 8
        Me.btnAddGrid.Text = "Add to appointment"
        Me.btnAddGrid.UseVisualStyleBackColor = False
        '
        'dgvSelectedServices
        '
        Me.dgvSelectedServices.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvSelectedServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSelectedServices.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dgvSelectedServices.Location = New System.Drawing.Point(48, 244)
        Me.dgvSelectedServices.Name = "dgvSelectedServices"
        Me.dgvSelectedServices.Size = New System.Drawing.Size(445, 157)
        Me.dgvSelectedServices.TabIndex = 50
        '
        'Column1
        '
        Me.Column1.HeaderText = "Appointment Id"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Service Id"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Service Name"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Price"
        Me.Column4.Name = "Column4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gold
        Me.Label5.Location = New System.Drawing.Point(6, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 20)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Select services :"
        '
        'cboservices
        '
        Me.cboservices.FormattingEnabled = True
        Me.cboservices.ItemHeight = 18
        Me.cboservices.Location = New System.Drawing.Point(127, 215)
        Me.cboservices.Name = "cboservices"
        Me.cboservices.Size = New System.Drawing.Size(200, 26)
        Me.cboservices.TabIndex = 45
        '
        'txttotal
        '
        Me.txttotal.ForeColor = System.Drawing.Color.Blue
        Me.txttotal.Location = New System.Drawing.Point(293, 402)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(200, 24)
        Me.txttotal.TabIndex = 41
        '
        'btnback2
        '
        Me.btnback2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnback2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback2.Location = New System.Drawing.Point(12, 6)
        Me.btnback2.Name = "btnback2"
        Me.btnback2.Size = New System.Drawing.Size(41, 28)
        Me.btnback2.TabIndex = 40
        Me.btnback2.Text = "<"
        Me.btnback2.UseVisualStyleBackColor = False
        '
        'TblAppointmentBindingSource3
        '
        Me.TblAppointmentBindingSource3.DataMember = "tblAppointment"
        Me.TblAppointmentBindingSource3.DataSource = Me.Appointment_tabelDataSet1
        '
        'Appointment_tabelDataSet1
        '
        Me.Appointment_tabelDataSet1.DataSetName = "Appointment_tabelDataSet1"
        Me.Appointment_tabelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Appointment_tabelDataSet
        '
        Me.Appointment_tabelDataSet.DataSetName = "Appointment_tabelDataSet"
        Me.Appointment_tabelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblAppointmentBindingSource
        '
        Me.TblAppointmentBindingSource.DataMember = "tblAppointment"
        Me.TblAppointmentBindingSource.DataSource = Me.Appointment_tabelDataSet
        '
        'TblAppointmentTableAdapter
        '
        Me.TblAppointmentTableAdapter.ClearBeforeFill = True
        '
        'Tblappointment_servicesTableAdapter
        '
        Me.Tblappointment_servicesTableAdapter.ClearBeforeFill = True
        '
        'TblAppointmentBindingSource1
        '
        Me.TblAppointmentBindingSource1.DataMember = "tblAppointment"
        Me.TblAppointmentBindingSource1.DataSource = Me.Appointment_tabelDataSet
        '
        'TblAppointmentBindingSource2
        '
        Me.TblAppointmentBindingSource2.DataMember = "tblAppointment"
        Me.TblAppointmentBindingSource2.DataSource = Me.Appointment_tabelDataSet
        '
        'TblAppointmentTableAdapter1
        '
        Me.TblAppointmentTableAdapter1.ClearBeforeFill = True
        '
        'TblAppointmentBindingSource5
        '
        Me.TblAppointmentBindingSource5.DataMember = "tblAppointment"
        Me.TblAppointmentBindingSource5.DataSource = Me.Appointment_tabelDataSet3
        '
        'Appointment_tabelDataSet3
        '
        Me.Appointment_tabelDataSet3.DataSetName = "Appointment_tabelDataSet3"
        Me.Appointment_tabelDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblAppointmentBindingSource4
        '
        Me.TblAppointmentBindingSource4.DataMember = "tblAppointment"
        Me.TblAppointmentBindingSource4.DataSource = Me.Appointment_tabelDataSet2
        '
        'Appointment_tabelDataSet2
        '
        Me.Appointment_tabelDataSet2.DataSetName = "Appointment_tabelDataSet2"
        Me.Appointment_tabelDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblAppointmentTableAdapter2
        '
        Me.TblAppointmentTableAdapter2.ClearBeforeFill = True
        '
        'TblAppointmentTableAdapter3
        '
        Me.TblAppointmentTableAdapter3.ClearBeforeFill = True
        '
        'Tblappointment_servicesTableAdapter1
        '
        Me.Tblappointment_servicesTableAdapter1.ClearBeforeFill = True
        '
        'TblAppointmenttblappointmentservicesBindingSource
        '
        Me.TblAppointmenttblappointmentservicesBindingSource.DataMember = "tblAppointmenttblappointment_services"
        Me.TblAppointmenttblappointmentservicesBindingSource.DataSource = Me.TblAppointmentBindingSource
        '
        'TblAppointmenttblappointmentservicesBindingSource1
        '
        Me.TblAppointmenttblappointmentservicesBindingSource1.DataMember = "tblAppointmenttblappointment_services"
        Me.TblAppointmenttblappointmentservicesBindingSource1.DataSource = Me.TblAppointmentBindingSource2
        '
        'frmappointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.bookingtable.My.Resources.Resources.Premium_Photo___Makeup_products_and_striped_cosmetic_bag_on_dusty_dark_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(913, 500)
        Me.Controls.Add(Me.btnback2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvbooking)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.txtGetDate)
        Me.Name = "frmappointment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmappointment"
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvbooking, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvSelectedServices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblAppointmentBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Appointment_tabelDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Appointment_tabelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblAppointmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblAppointmentBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblAppointmentBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblAppointmentBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Appointment_tabelDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblAppointmentBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Appointment_tabelDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblAppointmenttblappointmentservicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblAppointmenttblappointmentservicesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btncsearch As System.Windows.Forms.Button
    Friend WithEvents txtcsearch As System.Windows.Forms.TextBox
    Friend WithEvents txtcfname As System.Windows.Forms.TextBox
    Friend WithEvents txtbtime As System.Windows.Forms.TextBox
    Friend WithEvents txtbid As System.Windows.Forms.TextBox
    Friend WithEvents btnbooking As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Appointment_tabelDataSet As bookingtable.Appointment_tabelDataSet
    Friend WithEvents TblAppointmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblAppointmentTableAdapter As bookingtable.Appointment_tabelDataSetTableAdapters.tblAppointmentTableAdapter
    Friend WithEvents TblAppointmenttblappointmentservicesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tblappointment_servicesTableAdapter As bookingtable.Appointment_tabelDataSetTableAdapters.tblappointment_servicesTableAdapter
    Friend WithEvents TblAppointmentBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TblAppointmentBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents TblAppointmenttblappointmentservicesBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Appointment_tabelDataSet1 As bookingtable.Appointment_tabelDataSet1
    Friend WithEvents TblAppointmentBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents TblAppointmentTableAdapter1 As bookingtable.Appointment_tabelDataSet1TableAdapters.tblAppointmentTableAdapter
    Friend WithEvents EventLog1 As System.Diagnostics.EventLog
    Friend WithEvents dgvbooking As DataGridView
    Friend WithEvents Appointment_tabelDataSet2 As Appointment_tabelDataSet2
    Friend WithEvents TblAppointmentBindingSource4 As BindingSource
    Friend WithEvents TblAppointmentTableAdapter2 As Appointment_tabelDataSet2TableAdapters.tblAppointmentTableAdapter
    Friend WithEvents Appointment_tabelDataSet3 As bookingtable.Appointment_tabelDataSet3
    Friend WithEvents TblAppointmentBindingSource5 As System.Windows.Forms.BindingSource
    Friend WithEvents TblAppointmentTableAdapter3 As bookingtable.Appointment_tabelDataSet3TableAdapters.tblAppointmentTableAdapter
    Friend WithEvents txtGetDate As System.Windows.Forms.TextBox
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents dtpbooking As System.Windows.Forms.DateTimePicker
    Friend WithEvents DirectorySearcher1 As System.DirectoryServices.DirectorySearcher
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnback2 As System.Windows.Forms.Button
    Friend WithEvents Tblappointment_servicesTableAdapter1 As bookingtable.Appointment_tabelDataSet1TableAdapters.tblappointment_servicesTableAdapter
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboservices As System.Windows.Forms.ComboBox
    Friend WithEvents dgvSelectedServices As System.Windows.Forms.DataGridView
    Friend WithEvents btnAddGrid As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnappdelete As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
End Class
