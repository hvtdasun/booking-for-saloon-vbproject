Public Class frmreport

    Private Sub frmreport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Appointment_tabelDataSet4.tblAppointment' table. You can move, or remove it, as needed.
        Me.tblAppointmentTableAdapter.Fill(Me.Appointment_tabelDataSet4.tblAppointment)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class