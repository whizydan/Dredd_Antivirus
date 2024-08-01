Public Class MainWindow
    Private Sub Dashboard_Click(sender As Object, e As EventArgs) Handles Dashboard.Click
        DashboardControl1.BringToFront()
        DashboardControl1.Visible = True

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        ProtectionControl1.BringToFront()
        ProtectionControl1.Visible = True
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        PrivacyControl1.BringToFront()
        PrivacyControl1.Visible = True
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Me.Close()
    End Sub
End Class