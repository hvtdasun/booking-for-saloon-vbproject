<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmreport
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.tblAppointmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Appointment_tabelDataSet4 = New bookingtable.Appointment_tabelDataSet4()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tblAppointmentTableAdapter = New bookingtable.Appointment_tabelDataSet4TableAdapters.tblAppointmentTableAdapter()
        CType(Me.tblAppointmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Appointment_tabelDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tblAppointmentBindingSource
        '
        Me.tblAppointmentBindingSource.DataMember = "tblAppointment"
        Me.tblAppointmentBindingSource.DataSource = Me.Appointment_tabelDataSet4
        '
        'Appointment_tabelDataSet4
        '
        Me.Appointment_tabelDataSet4.DataSetName = "Appointment_tabelDataSet4"
        Me.Appointment_tabelDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tblAppointmentBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "bookingtable.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(723, 589)
        Me.ReportViewer1.TabIndex = 0
        '
        'tblAppointmentTableAdapter
        '
        Me.tblAppointmentTableAdapter.ClearBeforeFill = True
        '
        'frmreport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 589)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmreport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmreport"
        CType(Me.tblAppointmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Appointment_tabelDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tblAppointmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Appointment_tabelDataSet4 As bookingtable.Appointment_tabelDataSet4
    Friend WithEvents tblAppointmentTableAdapter As bookingtable.Appointment_tabelDataSet4TableAdapters.tblAppointmentTableAdapter
End Class
