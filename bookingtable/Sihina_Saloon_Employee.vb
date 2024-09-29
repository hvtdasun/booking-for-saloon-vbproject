Imports System.Data.OleDb
Public Class Sihina_Saloon_Employee

    Private Sub btnaddcus_Click(sender As Object, e As EventArgs) Handles btnaddcus.Click
        Me.Hide()
        Dim addcutomer As New Addcustomer
        addcutomer.ShowDialog()
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Me.Hide()
        Dim login As New Log_in
        login.ShowDialog()
    End Sub

    'Private Sub btnappointment_Click(sender As Object, e As EventArgs)
    '    Appointment.Show()
    '    Me.Hide()
    'End Sub

    Private Sub btnfrm_Click(sender As Object, e As EventArgs) Handles btnfrm.Click
        Me.Hide()
        Dim addappoint As New frmappointment
        addappoint.ShowDialog()
    End Sub

    Private Sub btnview_Click(sender As Object, e As EventArgs) Handles btnview.Click
        frm_show_customer_service.Show()
    End Sub
End Class