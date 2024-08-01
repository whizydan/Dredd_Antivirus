Imports System.Data.SqlClient

Public Class Login
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim email As String
        email = Guna2TextBox1.Text
        Dim pass As String
        pass = Guna2TextBox2.Text

        If String.IsNullOrEmpty(email) Then
            MessageBox.Show("Empty email")
        ElseIf String.IsNullOrEmpty(pass) Then
            MessageBox.Show("Password is empty")
        Else
            'query db here

            Dim myConn As SqlConnection
            Dim myCmd As SqlCommand
            Dim myReader As SqlDataReader

            'Create a Connection object.
            myConn = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Dredd Antivirus\Dredd Antivirus\Dredd Antivirus\Data.mdf"";Integrated Security=True;Connect Timeout=30")

            'Create a Command object.
            myCmd = myConn.CreateCommand
            myCmd.CommandText = $"SELECT * from users where Password = '{pass}' and Email = '{email}'"

            'Open the connection.
            myConn.Open()


            myReader = myCmd.ExecuteReader()

            Do While myReader.Read()
                If myReader.HasRows Then
                    Dim mainWindow As New MainWindow
                    mainWindow.Show()
                    Me.Close()
                    'Close the reader and the database connection.

                Else
                    MessageBox.Show("Invalid Credentials")
                End If
            Loop
        End If




    End Sub

    Private Sub Guna2HtmlLabel4_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel4.Click
        Dim signup As New Register
        signup.Show()
        Me.Close()

    End Sub
End Class
