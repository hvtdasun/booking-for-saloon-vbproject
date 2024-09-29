Imports System.Data.OleDb
Public Class Addcustomer
    Dim adcus As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim n As Integer
    Dim chrdcommand As Char

    Private Sub Addcustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        Dim cmcus As New OleDbCommand
        cmcus.Connection = con
        cmcus.CommandText = "select* from tblcustomer"
        adcus.SelectCommand = cmcus
        adcus.Fill(ds, "customer")
        n = ds.Tables("customer").Rows.Count - 1
        con.Close()
        Show_records()
    End Sub
    Sub Show_records()
        Dim drcus As DataRow
        If n >= 0 Then
            drcus = ds.Tables("customer").Rows(n)
            With drcus
                txtcfname.Text = .Item("cusname")
                txtcid.Text = .Item("cus_id")
                txtcaddress.Text = .Item("cus_address")
                txtctp.Text = .Item("cus_tp")
            End With
        End If
    End Sub

    Private Sub btncadd_Click(sender As Object, e As EventArgs) Handles btncadd.Click
        chrdcommand = "A"
        txtcfname.Focus()
        clearcontrols()
        btncsave.Enabled = True
        btncadd.Enabled = True
        btncedit.Enabled = False
        btncdelete.Enabled = False
    End Sub

    Private Sub btncedit_Click(sender As Object, e As EventArgs) Handles btncedit.Click
        chrdcommand = "E"
        txtcfname.Focus()
        btncsave.Enabled = True
    End Sub

    Private Sub btncsave_Click(sender As Object, e As EventArgs) Handles btncsave.Click
        Dim srttp As String
        srttp = txtctp.Text
        Dim srtid As Boolean

        If txtcid.Text.Length = 12 Then
            If IsNumeric(txtcid.Text) Then
                srtid = True
            End If
        ElseIf txtcid.Text.Length = 10 Then
            Dim strid As String = txtcid.Text
            If IsNumeric(strid.Substring(0, 9)) Then
                If strid.Substring(9, 1) = "V" Then
                    srtid = True
                End If
            End If
        End If
        If Not srttp.Length = 10 Or IsNumeric(srttp) = False Then
            MessageBox.Show("Invalid phone number")
            btncadd.Enabled = True
        Else
            Dim cmbuilder As New OleDbCommandBuilder
            cmbuilder.DataAdapter = adcus
            If chrdcommand = "A" Then
                If txtcid.Text = "" Then
                    MessageBox.Show("Please enter data before Saving....")
                Else
                    Dim drcus As DataRow
                    drcus = ds.Tables("customer").NewRow
                    With drcus
                        .Item("cusname") = txtcfname.Text
                        .Item("cus_id") = txtcid.Text
                        .Item("cus_address") = txtcaddress.Text
                        .Item("cus_tp") = txtctp.Text
                    End With
                    ds.Tables("customer").Rows.Add(drcus)
                    adcus.InsertCommand = cmbuilder.GetInsertCommand
                    n = n + 1
                End If
            ElseIf chrdcommand = "E" Then
                Dim tbcus As DataTable
                Dim dsprimarykey(0) As DataColumn
                tbcus = ds.Tables("customer")
                dsprimarykey(0) = tbcus.Columns("cus_id")
                tbcus.PrimaryKey = dsprimarykey
                Dim drcus As DataRow = tbcus.Rows.Find(txtcid.Text)
                With drcus
                    .Item("cusname") = txtcfname.Text
                    .Item("cus_id") = txtcid.Text
                    .Item("cus_address") = txtcaddress.Text
                    .Item("cus_tp") = txtctp.Text
                End With
                adcus.UpdateCommand = cmbuilder.GetUpdateCommand
                MsgBox("Edit succesful")
            ElseIf chrdcommand = "D" Then
                ds.Tables("customer").Rows(n).Delete()
                adcus.DeleteCommand = cmbuilder.GetDeleteCommand
                n = n + 1
            End If
            con.Open()
            Try
                adcus.Update(ds, "customer")
                btncsave.Enabled = False
            Catch ex As Exception
                MessageBox.Show("you are trying to save data incorrectly")
            End Try
            con.Close()

        End If


    End Sub
    Sub clearcontrols()
        txtcfname.Clear()
        txtcid.Clear()
        txtcaddress.Clear()
        txtctp.Clear()
    End Sub

    Private Sub btncdelete_Click(sender As Object, e As EventArgs) Handles btncdelete.Click
        chrdcommand = "D"
        btncsave.Enabled = True
    End Sub

    Private Sub btnccancel_Click(sender As Object, e As EventArgs) Handles btnccancel.Click
        chrdcommand = "C"
        clearcontrols()
    End Sub

    Private Sub btncclose_Click(sender As Object, e As EventArgs) Handles btncclose.Click
        chrdcommand = "E"
        Me.Close()
    End Sub

    Private Sub btncsearch_Click(sender As Object, e As EventArgs) Handles btncsearch.Click
        Dim tbcutomer As DataTable
        Dim dcprimarykey(0) As DataColumn
        tbcutomer = ds.Tables("customer")
        dcprimarykey(0) = tbcutomer.Columns("cus_id")
        tbcutomer.PrimaryKey = dcprimarykey

        Dim strcno As String
        strcno = txtcsearch.Text

        If Not strcno Is Nothing Then
            Dim drcustomer As DataRow = tbcutomer.Rows.Find(strcno)
            If Not drcustomer Is Nothing Then
                With drcustomer
                    txtcfname.Text = .Item("cusname")
                    txtcid.Text = .Item("cus_id")
                    txtcaddress.Text = .Item("cus_address")
                    txtctp.Text = .Item("cus_tp")
                End With
            Else
                MessageBox.Show("Customer not found....", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnbackc_Click(sender As Object, e As EventArgs) Handles btnbackc.Click
        Me.Hide()
        Dim sihina_saloon_user As New Sihina_Saloon_Employee
        sihina_saloon_user.ShowDialog()
    End Sub

    Private Sub btnfirstcus_Click(sender As Object, e As EventArgs) Handles btnfirstcus.Click
        n = 0
        Show_records()
    End Sub

    Private Sub btnprevcus_Click(sender As Object, e As EventArgs) Handles btnprevcus.Click
        If n > 0 Then
            n = n - 1
            Show_records()
        End If
    End Sub

    Private Sub btnnextcus_Click(sender As Object, e As EventArgs) Handles btnnextcus.Click
        If n < ds.Tables("Customer").Rows.Count - 1 Then
            n = n + 1
            Show_records()
        End If
    End Sub

    Private Sub btnlastcus_Click(sender As Object, e As EventArgs) Handles btnlastcus.Click
        n = ds.Tables("Customer").Rows.Count - 1
        Show_records()
    End Sub
End Class