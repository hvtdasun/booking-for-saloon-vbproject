Imports System.Data.OleDb
Module Module1
    Public con As New OleDbConnection
    Sub main()
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\New folder\project7\PROJECT\bookingtable\Appointment tabel.mdb"
        Dim frmlogin As New Log_in
        frmlogin.ShowDialog()
    End Sub
End Module
