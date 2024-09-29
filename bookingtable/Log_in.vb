Public Class Log_in

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If txtuser.Text = "Admin" Then
            If txtpassword.Text = "5405" Then

                Me.Hide()
                Dim Sihina_Saloon_Admin As New Sihina_Saloon_Admin
                Sihina_Saloon_Admin.ShowDialog()
            Else
                MessageBox.Show("Wrong Password Please Try Again", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        ElseIf txtuser.Text = "User" Then
            If txtpassword.Text = "1234" Then

                Me.Hide()
                Dim sihina_saloon_employee As New Sihina_Saloon_Employee
                sihina_saloon_employee.ShowDialog()
            Else
                MessageBox.Show("Wrong Password Please Try Again", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Wrong User name Please Enter Correct User name", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub Log_in_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class