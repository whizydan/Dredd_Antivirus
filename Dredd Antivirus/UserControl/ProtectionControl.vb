Imports System.Data.SqlClient

Public Class ProtectionControl
    Private Sub Guna2HtmlLabel4_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel4.Click
        Dim URL As String = "https://virusshare.com/hashes"
        Dim NewProcess As ProcessStartInfo = New ProcessStartInfo(URL)
        NewProcess.UseShellExecute = True
        Process.Start(NewProcess)



    End Sub

    Private Sub ProtectionControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sCommand As SqlCommand
        Dim sAdapter As SqlDataAdapter
        Dim sBuilder As SqlCommandBuilder
        Dim sDs As DataSet
        Dim sTable As DataTable
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Dredd Antivirus\Dredd Antivirus\Dredd Antivirus\Data.mdf"";Integrated Security=True;Connect Timeout=30"
        Dim sql As String = "SELECT * FROM Malware"
        Dim connection As New SqlConnection(connectionString)
        connection.Open()
        sCommand = New SqlCommand(sql, connection)
        sAdapter = New SqlDataAdapter(sCommand)
        sBuilder = New SqlCommandBuilder(sAdapter)
        sDs = New DataSet()
        sAdapter.Fill(sDs, "Malware")
        sTable = sDs.Tables("Malware")
        connection.Close()
        Guna2DataGridView1.DataSource = sDs.Tables("Malware")
        Guna2DataGridView1.ReadOnly = True
        Guna2DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub
End Class
