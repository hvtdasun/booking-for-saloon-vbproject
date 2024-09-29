Imports System.Data.OleDb
Public Class frm_show_customer_service
    Dim cmshow As New OleDbCommand
    Dim ds As New DataSet
    Dim adshow As New OleDbDataAdapter
    Dim vwshow As New DataView
    Dim n As Integer

    Private Sub frm_show_customer_service_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'con.Open()
        'cmshow.Connection = con
        'cmshow.CommandText = "SELECT * FROM tblappointment_services WHERE appointment_id LIKE ' " & txtsearchappoid.Text & "'"
        'adshow.SelectCommand = cmshow
        'adshow.Fill(ds, "shserv")
        'n = ds.Tables("shserv").Rows.Count - 1
        'con.Close()
        ''Show_recordsserv()

    End Sub

    Private Sub btnsearchappo_Click(sender As Object, e As EventArgs) Handles btnsearchappo.Click
        ds.Reset()
        dgvserv.DataSource = Nothing
        dgvserv.Rows.Clear()

        cmshow.Connection = con
        con.Open()
        cmshow.CommandText = "SELECT * FROM tblappointment_services WHERE appointment_id LIKE '" & txtsearchappoid.Text & "'"
        adshow.SelectCommand = cmshow
        adshow.Fill(ds, "dsCustomer")
        con.Close()

        If Not ds.Tables("dsCustomer").Rows.Count - 1 < 0 Then
            Dim tbCustomer As DataTable = ds.Tables("dsCustomer")

            vwshow = tbCustomer.DefaultView
            dgvserv.DataSource = vwshow
        Else
            MsgBox("No data")
        End If
    End Sub

    Private Sub btnserv1_Click(sender As Object, e As EventArgs) Handles btnserv1.Click
        Me.Hide()
        Dim sihina_saloon_user As New Sihina_Saloon_Employee
        sihina_saloon_user.ShowDialog()
    End Sub
End Class