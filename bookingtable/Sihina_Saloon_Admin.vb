Imports System.Data.OleDb
Public Class Sihina_Saloon_Admin
    Private Sub btnservice_Click(sender As Object, e As EventArgs) Handles btnservice.Click
        Me.Hide()
        Dim services As New services
        services.ShowDialog()

    End Sub

    Private Sub btnadminlogout_Click(sender As Object, e As EventArgs) Handles btnadminlogout.Click
        Me.Hide()
        Dim login As New Log_in
        login.ShowDialog()
    End Sub

    Private Sub btnreport_Click(sender As Object, e As EventArgs) Handles btnreport.Click
        Me.Hide()
        Dim reportview As New frmreport
        reportview.ShowDialog()
    End Sub
End Class