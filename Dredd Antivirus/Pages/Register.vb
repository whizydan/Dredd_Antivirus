Imports System.Data.SqlClient
Imports Guna.UI2.WinForms

Public Class Register
    Private Sub signup_Click(sender As Object, e As EventArgs) Handles signup.Click

        Dim emailVal As String
        Dim passwordVal As String
        Dim confirmVal As String
        Dim userVal As String

        emailVal = email.Text
        passwordVal = password.Text
        confirmVal = confirmPassword.Text
        userVal = username.Text

        If confirmVal = passwordVal Then
            If String.IsNullOrEmpty(passwordVal) Then
                MessageBox.Show("Empty password")
            ElseIf String.IsNullOrEmpty(emailVal) Then
                MessageBox.Show("Empty email")
            ElseIf String.IsNullOrEmpty(userVal) Then
                MessageBox.Show("Username empty")
            Else
                'query db here
                Dim myConn As SqlConnection
                Dim myCmd As SqlCommand
                Dim myReader As SqlDataReader
                Dim results As Int32

                'Create a Connection object.
                myConn = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Dredd Antivirus\Dredd Antivirus\Dredd Antivirus\Data.mdf"";Integrated Security=True;Connect Timeout=30")

                'Create a Command object.
                myCmd = myConn.CreateCommand
                myCmd.CommandText = $"insert into users(UserName,Email,Password) values('{userVal}','{emailVal}','{passwordVal}')"

                'Open the connection.
                myConn.Open()

                results = myCmd.ExecuteNonQuery()

                If results > 0 Then
                    Dim mainWindow As New MainWindow
                    mainWindow.Show()
                    Me.Close()
                Else

                    MessageDialog.Show("Error :could not add user")
                End If


            End If

        Else
            MessageBox.Show("Passwords do not match")
        End If





    End Sub

    Private Sub agreement_CheckedChanged(sender As Object, e As EventArgs) Handles agreement.CheckedChanged
        If agreement.Checked = True Then
            signup.Enabled = True
        Else
            signup.Enabled = False
        End If
    End Sub
End Class