Imports System.Data.OleDb
Public Class frmappointment
    Dim adcus As New OleDbDataAdapter
    Dim adService As New OleDbDataAdapter
    Dim cmcus As New OleDbCommand
    Dim cmBokking As New OleDbCommand
    Dim cmadserv As New OleDbCommand
    Dim adadserv As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim n As Integer
    Dim x As Integer
    Dim r As Integer
    Dim chrdcommand As Char
    Dim vwbook As DataView
    Dim strdate As String
    Dim vwbookingdate As DataView
    Dim tprice As Double
    Dim searchServiceID As String
    Dim intservid As Integer
    Dim cmbook As New OleDbCommand
    Dim m As Integer
    Dim servicePrice As Double
    Dim cmbuilder As New OleDbCommandBuilder
    Dim dataadapter As New OleDbDataAdapter
    Dim cmshowserv As New OleDbCommand
    Dim adshowserv As New OleDbDataAdapter


    Private Sub Addcustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()

        cmcus.Connection = con
        cmcus.CommandText = "select* from tblcustomer"
        adcus.SelectCommand = cmcus
        adcus.Fill(ds, "customer")
        n = ds.Tables("customer").Rows.Count - 1
        con.Close()
        'Show_records()

        con.Open()
        cmbook.Connection = con
        cmbook.CommandText = "select* from tblAppointment"
        adcus.SelectCommand = cmbook
        adcus.Fill(ds, "Appointment")
        n = ds.Tables("Appointment").Rows.Count - 1
        x = ds.Tables("Appointment").Rows.Count + 1
        con.Close()
        txtGetDate.Text = Today
        strdate = Today
        txtbid.Text = x
        fillgriddate()

        con.Open()
        cmadserv.Connection = con
        cmadserv.CommandText = "SELECT * FROM tblservice"
        adadserv.SelectCommand = cmadserv
        Dim showserv As New DataTable
        adadserv.Fill(showserv)
        con.Close()

        With cboservices
            .DataSource = showserv
            .DisplayMember = "service_name"
            .SelectedIndex = -1
        End With
    End Sub

    Sub Show_records()
        Dim drcus As DataRow
        If n >= 0 Then
            drcus = ds.Tables("customer").Rows(n)
            With drcus
                txtcfname.Text = .Item("cusname")
                'txtcid.Text = .Item("cus_id")
                'txtcaddress.Text = .Item("cus_address")
                'txtctp.Text = .Item("cus_tp")
            End With
        End If
    End Sub

    Sub clearcontrols()
        txtcfname.Clear()
        'txtcid.Clear()
        'txtcaddress.Clear()
        'txtctp.Clear()
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
                    'txtcid.Text = .Item("cus_id")
                    'txtcaddress.Text = .Item("cus_address")
                    'txtctp.Text = .Item("cus_tp")
                End With
            Else
                MessageBox.Show("Customer not found....", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub dgvappointment_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim x As Integer
        x = e.RowIndex
        Show_records()
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        txtGetDate.Text = MonthCalendar1.SelectionRange.Start.ToString("MM/dd/yyyy")
        strdate = txtGetDate.Text
        fillgriddate()
    End Sub
    Sub fillgriddate()
        Dim cmbookingGrid As New OleDbCommand
        Dim adbookingGrid As New OleDbDataAdapter
        con.Open()
        cmbookingGrid.Connection = con
        cmbookingGrid.CommandText = "SELECT * FROM tblAppointment WHERE appointment_date LIKE '" & strdate & "' ORDER BY cus_id DESC"
        adbookingGrid.SelectCommand = cmbookingGrid
        Dim dtbooking As New DataTable
        adbookingGrid.Fill(dtbooking)
        con.Close()

        vwbookingdate = dtbooking.DefaultView
        dgvbooking.DataSource = vwbookingdate
        'If dgvbooking.CurrentCell Is Nothing Then
        '    MsgBox("No Booking")
        'End If
    End Sub
    'back button
    Private Sub btnback2_Click(sender As Object, e As EventArgs) Handles btnback2.Click
        Me.Hide()
        Dim sihina_saloon_user As New Sihina_Saloon_Employee
        sihina_saloon_user.ShowDialog()
    End Sub
    'price calculation
    'Sub calculateprice()
    '    For i = 0 To cboservices.Items.Count - 1
    '        Dim tbprice As DataTable
    '        Dim dcprimarykey(0) As DataColumn
    '        tbprice = ds.Tables("service")
    '        dcprimarykey(0) = tbprice.Columns("service_name")
    '        tbprice.PrimaryKey = dcprimarykey
    '        Dim drprice As DataRow = tbprice.Rows.Find(cboservices.Items(i))
    '        Dim ssprice As String
    '        With drprice
    '            ssprice = .Item("price")
    '        End With
    '        tprice = tprice + ssprice
    '    Next
    '    txttotal.Text = "You Need To Pay : RS." & tprice
    'End Sub
    Sub findservicecode() '--------------------------------------------------------service code---------------------------------------------------
        Dim adservice As New OleDbDataAdapter
        Dim ds As New DataSet
        Dim n As Integer
        con.Open()
        Dim cmserv As New OleDbCommand
        cmserv.Connection = con
        cmserv.CommandText = "SELECT * FROM tblservice"
        adservice.SelectCommand = cmserv
        adservice.Fill(ds, "servicesad")
        n = ds.Tables("servicesad").Rows.Count - 1
        con.Close()
        Dim tbserviceid As DataTable
        Dim dcprimarykey(0) As DataColumn
        tbserviceid = ds.Tables("servicesad")
        dcprimarykey(0) = tbserviceid.Columns("service_name")
        tbserviceid.PrimaryKey = dcprimarykey
        Dim strservicename As String
        strservicename = cboservices.Text
        Dim drserviceid As DataRow = tbserviceid.Rows.Find(strservicename)
        If Not drserviceid Is Nothing Then
            With drserviceid
                searchServiceID = .Item("service_id")
                servicePrice = .Item("price")

            End With
        End If
    End Sub

    Private Sub cboservices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboservices.SelectedIndexChanged
        findservicecode()
    End Sub


    '-----------------------booking save button------------------------------------
    Private Sub btnbooking_Click(sender As Object, e As EventArgs) Handles btnbooking.Click
        con.Open()
        cmBokking.Connection = con
        cmBokking.CommandText = "SELECT * FROM tblAppointment"
        adService.SelectCommand = cmBokking
        adService.Fill(ds, "Bokking")
        con.Close()
        Dim cmbuilder As New OleDbCommandBuilder
        cmbuilder.DataAdapter = adService
        If txtbtime.Text = "" Then
            MessageBox.Show("Please Enter Booking Time..")
        Else
            Dim drapp As DataRow
            drapp = ds.Tables("Bokking").NewRow
            With drapp
                .Item("cus_id") = txtcsearch.Text
                .Item("cusname") = txtcfname.Text
                .Item("appointment_id") = txtbid.Text
                .Item("appointment_date") = dtpbooking.Value.ToString("MM/dd/yyyy")
                .Item("appointment_time") = txtbtime.Text
                .Item("TotalP") = "Rs." & txttotal.Text
            End With
            ds.Tables("Bokking").Rows.Add(drapp)
            adService.InsertCommand = cmbuilder.GetInsertCommand
            n = n + 1
        End If
        Try
            adService.Update(ds, "Bokking")
            MessageBox.Show("Booking successful....!")
        Catch ex As Exception
            MessageBox.Show("Booking Data Incorrectly")
        End Try
        findservicecode() '---------------------------------------------Save service code into database----------------------------------------------
        cmadserv.Connection = con
        cmadserv.CommandText = "SELECT * FROM tblappointment_services"
        adadserv.SelectCommand = cmadserv
        adadserv.Fill(ds, "Save")
        If dgvSelectedServices.Rows.Count - 1 > 0 Then
            For i = 0 To dgvSelectedServices.Rows.Count - 2
                Dim drAdServiceSave As DataRow
                drAdServiceSave = ds.Tables("Save").NewRow
                Dim appointmentID As String = dgvSelectedServices.Rows(i).Cells(0).Value
                Dim serviceID As String = dgvSelectedServices.Rows(i).Cells(1).Value
                Dim serviceName As String = dgvSelectedServices.Rows(i).Cells(2).Value

                With drAdServiceSave
                    .Item("appointment_id") = appointmentID
                    .Item("service_id") = serviceID
                    .Item("service_name") = serviceName

                End With
                ds.Tables("Save").Rows.Add(drAdServiceSave)
                Dim cmSave As New OleDbCommandBuilder
                cmSave.DataAdapter = adadserv
                adadserv.InsertCommand = cmSave.GetInsertCommand
                Try
                    adadserv.Update(ds, "Save")
                    'MsgBox("Saved")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Next
        End If
        clearData()
        txtbid.Text = x + 1
        txtbid.Enabled = True
    End Sub

    Sub show_recordsad()
        Dim tbBoking As New DataTable
        Dim dcPrimaryKey(0) As DataColumn
        tbBoking = ds.Tables("Appointment")
        dcPrimaryKey(0) = tbBoking.Columns("cus_id")
        tbBoking.PrimaryKey = dcPrimaryKey
        If Not strdate Is Nothing Then
            Dim drBoking As DataRow = tbBoking.Rows.Find(strdate)
            If Not drBoking Is Nothing Then
                With drBoking
                    txtcsearch.Text = .Item("cus_id")
                    txtbid.Text = .Item("appointment_id")
                    dtpbooking.Text = .Item("appointment_date")
                    txtbtime.Text = .Item("appointment_time")
                End With
            Else
                MessageBox.Show("Booking Available")
            End If
        End If
    End Sub
    'Sub showrecordserv(ByVal servicenumber)
    '    Dim sernumber As String = servicenumber.ToString
    '    con.Open()
    '    cmshowserv.Connection = con
    '    cmshowserv.CommandText = "SELECT tblappointment_services.appointment_id AS [appointmentID],tblappointment_services.service_id AS [serviceID],tblappointment_services.service_name AS [serviceName] FROM tblappointment_services INNER JOIN tblAppointment ON tblappointment_services.service_id = tblAppointment.appointment_id WHERE tblappointment_services.appointment_id='" & sernumber & "'"
    '    adshowserv.SelectCommand = cmshowserv
    '    adshowserv.Fill(ds, "servicelist")
    '    con.Close()
    '    Dim tbserviceshow As DataTable
    '    tbserviceshow = ds.Tables("servicelist")
    '    vwbook = tbserviceshow.DefaultView
    '    dgvSelectedServices.DataSource = vwbook
    'End Sub
    Private Sub btnAddGrid_Click(sender As Object, e As EventArgs) Handles btnAddGrid.Click
        Dim appointmentID As String = txtbid.Text
        Dim serviceID As String = searchServiceID
        Dim serviceName As String = cboservices.GetItemText(cboservices.Text)
        dgvSelectedServices.Rows.Add(appointmentID, serviceID, serviceName, servicePrice)
        For i = 0 To dgvSelectedServices.Rows.Count - 1
            tprice += dgvSelectedServices.Rows(i).Cells(3).Value
        Next
        txttotal.Text = Val(tprice)
        tprice = 0.0
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        clearData()
    End Sub

    Sub clearData()
        txtcsearch.Clear()
        txtcfname.Clear()
        txtbtime.Clear()
        txttotal.Clear()
        dgvSelectedServices.Rows.Clear()
        cboservices.Text = ""
    End Sub
    Private Sub dgvbooking_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvbooking.CellContentClick
        Try
            Dim value As Object = dgvbooking.Rows(e.RowIndex).Cells(0).Value
            intservid = CType(value, Integer)
        Catch ex As Exception
            MessageBox.Show("Do you want to edit")
        End Try
        cmbook.Connection = con
        con.Open()
        cmbook.CommandText = "SELECT * FROM tblAppointment WHERE appointment_id = " & intservid & ""
        adcus.SelectCommand = cmbook
        adcus.Fill(ds, "dsAppo")
        m = ds.Tables("dsAppo").Rows.Count - 1
        con.Close()
        Dim drservid As DataRow

        If m >= 0 Then
            drservid = ds.Tables("dsAppo").Rows(m)
            With drservid
                txtcsearch.Text = .Item("cus_id")
                txtcfname.Text = .Item("cusname")
                txtbid.Text = .Item("appointment_id")
                txtbtime.Text = .Item("appointment_time")
                txttotal.Text = .Item("TotalP")
            End With
        End If
        'Dim t As Integer
        'Dim servicenumber As Integer
        't = e.RowIndex
        'Dim selectedrow As DataGridViewRow
        'selectedrow = dgvSelectedServices.Rows(t)
        'servicenumber = selectedrow.Cells(0).Value
        'showrecordserv(servicenumber)
    End Sub

    Private Sub btnappdelete_Click(sender As Object, e As EventArgs) Handles btnappdelete.Click
        If txtbid.Text = "" Then
            MessageBox.Show("Select Appointment id before delete data", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If vbYes = MessageBox.Show("Do You want Cancel this Appointment", "System Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) Then
                Dim tbappo As DataTable
                Dim primarykey(0) As DataColumn
                tbappo = ds.Tables("Appointment")
                primarykey(0) = tbappo.Columns("appointment_id")
                tbappo.PrimaryKey = primarykey
                Dim drappo As DataRow
                Dim s As Integer
                drappo = tbappo.Rows.Find(txtbid.Text)
                s = tbappo.Rows.IndexOf(drappo)
                ds.Tables("Appointment").Rows.Item(s).Delete()
                cmbuilder.DataAdapter = adcus
                adcus.DeleteCommand = cmbuilder.GetDeleteCommand
                con.Open()
                Try
                    adcus.Update(ds, "Appointment")
                    MessageBox.Show("This appointment is canceled", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try
                con.Close()
            End If
            fillgriddate()

        End If
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs)
        txtbid.Enabled = False
    End Sub
End Class