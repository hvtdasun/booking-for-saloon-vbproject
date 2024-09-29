Imports System.Data.OleDb
Public Class services
    Dim adser As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim n As Integer
    Dim chrdcommand As Char
    Dim cmser As New OleDbCommand
    Dim vwser As New DataView

    Private Sub services_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        cmser.Connection = con
        cmser.CommandText = "select* from tblservice"
        adser.SelectCommand = cmser
        adser.Fill(ds, "service")
        n = ds.Tables("service").Rows.Count - 1
        con.Close()
        Show_records()
        fillgrid()
    End Sub
    Sub Show_records()
        Dim drser As DataRow
        If n >= 0 Then
            drser = ds.Tables("service").Rows(n)
            With drser
                txtsname.Text = .Item("service_name")
                txtsid.Text = .Item("service_id")
                txtsprice.Text = .Item("price")
            End With
        End If
    End Sub

    Private Sub btnsadd_Click(sender As Object, e As EventArgs) Handles btnsadd.Click
        chrdcommand = "A"
        txtsid.Focus()
        clearcontrols()
        btnssave.Enabled = True
    End Sub

    Private Sub btnsedit_Click(sender As Object, e As EventArgs) Handles btnsedit.Click
        chrdcommand = "E"
        txtsid.Focus()
        btnssave.Enabled = True
    End Sub

    Private Sub btnssave_Click(sender As Object, e As EventArgs) Handles btnssave.Click
        Dim cmbuilder As New OleDbCommandBuilder
        cmbuilder.DataAdapter = adser
        If chrdcommand = "A" Then
            If txtsid.Text = "" Then
                MessageBox.Show("Please enter data before saving.....")
            Else
                Dim drser As DataRow
                drser = ds.Tables("service").NewRow
                With drser
                    .Item("service_id") = txtsid.Text
                    .Item("service_name") = txtsname.Text
                    .Item("price") = txtsprice.Text
                End With
                ds.Tables("service").Rows.Add(drser)
                adser.InsertCommand = cmbuilder.GetInsertCommand
                n = n + 1
            End If
        ElseIf chrdcommand = "E" Then
            Dim tbser As DataTable
            Dim dsprimarykey(0) As DataColumn
            tbser = ds.Tables("service")
            dsprimarykey(0) = tbser.Columns("service_id")
            tbser.PrimaryKey = dsprimarykey
            Dim drser As DataRow = tbser.Rows.Find(txtsid.Text)
            With drser
                .Item("service_name") = txtsname.Text
                .Item("price") = txtsprice.Text
            End With
            adser.UpdateCommand = cmbuilder.GetUpdateCommand
        ElseIf chrdcommand = "D" Then
            ds.Tables("service").Rows(n).Delete()
            adser.DeleteCommand = cmbuilder.GetDeleteCommand
            n = n + 1
        End If
        fillgrid()
        con.Open()
        Try
            adser.Update(ds, "service")
            MessageBox.Show("Data Save Successful....")
        Catch ex As Exception
            MessageBox.Show("You are trying to save data incorrectly")
        End Try
        con.Close()
        btnssave.Enabled = False
        btnsadd.Enabled = True
    End Sub
    Sub clearcontrols()
        txtsid.Clear()
        txtsname.Clear()
        txtsprice.Clear()
    End Sub


    Private Sub btnsdelete_Click(sender As Object, e As EventArgs) Handles btnsdelete.Click
        chrdcommand = "D"
        btnssave.Enabled = True
    End Sub

    Private Sub btnscancel_Click(sender As Object, e As EventArgs) Handles btnscancel.Click
        chrdcommand = "C"
        clearcontrols()
    End Sub

    Private Sub btnsclose_Click(sender As Object, e As EventArgs) Handles btnsclose.Click
        chrdcommand = "E"
        Me.Close()
    End Sub

    Private Sub btnssearch_Click(sender As Object, e As EventArgs) Handles btnssearch.Click
        Dim tbservice As DataTable
        Dim dcprimarykey(0) As DataColumn
        tbservice = ds.Tables("service")
        dcprimarykey(0) = tbservice.Columns("service_id")
        tbservice.PrimaryKey = dcprimarykey

        Dim strsid As String

        strsid = txtssearch.Text

        If Not strsid Is Nothing Then
            Dim drservice As DataRow = tbservice.Rows.Find(strsid)
            If Not drservice Is Nothing Then
                With drservice
                    txtsid.Text = .Item("service_id")
                    txtsname.Text = .Item("service_name")
                    txtsprice.Text = .Item("price")
                End With
            Else
                MessageBox.Show("Services not found...!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Sub fillgrid()
        Dim cmservicegrid As New OleDbCommand
        Dim adservicegrid As New OleDbDataAdapter

        con.Open()
        cmservicegrid.Connection = con
        cmservicegrid.CommandText = "SELECT * FROM tblservice"
        adservicegrid.SelectCommand = cmservicegrid
        Dim dtservice As New DataTable
        adservicegrid.Fill(dtservice)
        con.Close()

        vwser = dtservice.DefaultView
        dgvservices.DataSource = vwser
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim sihina_saloon_Admin As New Sihina_Saloon_Admin
        Sihina_Saloon_Admin.ShowDialog()
    End Sub
End Class