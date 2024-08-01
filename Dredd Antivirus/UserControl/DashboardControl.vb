Imports System.IO
Imports Cloudmersive.APIClient.NETCore.VirusScan.Api
Imports Cloudmersive.APIClient.NETCore.VirusScan.Client
Imports Cloudmersive.APIClient.NETCore.VirusScan.Model
Imports System.Security.Cryptography
Imports System.Data.SqlClient

Public Class DashboardControl
    Private count As Int32
    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String

        fd.Title = "Select File to scan"
        fd.InitialDirectory = "C:\"
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName

            Dim config As New Configuration

            Dim inputFile As New IO.FileStream(strFileName, IO.FileMode.Open)
            Dim result As VirusScanResult
            config.AddApiKey("Apikey", "73fa1980-a3b7-4ac6-8373-225c810e56e3")
            Dim scan As New ScanApi(config)
            Dim scanningDialog As New Scanning
            While IsNothing(result)
                scanningDialog.ShowDialog()
                result = scan.ScanFile(inputFile)
            End While
            scanningDialog.Close()
            MessageBox.Show(result.ToString)

        End If
    End Sub

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click
        'scan one folder
        Dim FolderBrowserDialog1 As New FolderBrowserDialog
        FolderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer
        FolderBrowserDialog1.ShowNewFolderButton = False
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then

            gafad(FolderBrowserDialog1.SelectedPath)
        End If
    End Sub

    Private Sub GetDirectories(ByVal StartPath As String)
        For Each Dir As String In IO.Directory.GetDirectories(StartPath)
            'RichTextBox1.AppendText(Dir + vbCrLf)
            GetDirectories(Dir)
        Next
    End Sub

    Private Sub gafad(ByVal mfd As String) 'Get all files all directories
        For Each foundFile As String In My.Computer.FileSystem.GetFiles(mfd)
            Scanner(foundFile)
        Next

        For Each fd As String In IO.Directory.GetDirectories(mfd)
            If InStr(fd, "$") = False Then 'Not list for system folder
                'RichTextBox1.AppendText(fd + vbCrLf)
                For Each foundFile As String In My.Computer.FileSystem.GetFiles(fd)
                    Scanner(foundFile)
                Next
                GetDirectories(fd)
            End If
        Next
    End Sub

    Private Sub Scanner(ByVal path As String)
        'compare hashes to those in database
        Dim myConn As SqlConnection
        Dim myCmd As SqlCommand
        Dim myReader As SqlDataReader

        'Create a Connection object.
        myConn = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Dredd Antivirus\Dredd Antivirus\Dredd Antivirus\Data.mdf"";Integrated Security=True;Connect Timeout=30")

        'Create a Command object.
        myCmd = myConn.CreateCommand
        Dim hashValue = md5(path)
        myCmd.CommandText = $"SELECT * from Viruses where Hash = '{hashValue}'"

        'Open the connection.
        myConn.Open()
        Guna2HtmlLabel6.Text = $"Scanning : {path}"

        myReader = myCmd.ExecuteReader()
        Dim scanObj As New Scanning
        If myReader.Read() Then
            count = count + 1
            scanObj.ShowDialog()
            Guna2HtmlLabel6.Text = $"Virus Hash identified: File => {path}"
            scanObj.Close()
            'save the virus to thr database
            myCmd = myConn.CreateCommand()
            myCmd.CommandText = $"insert into Malware(File,Hash,Date) values('{path}','{hashValue}','{DateTime.Now.ToString("d M yyyy")}')"
            myCmd.ExecuteNonQuery()
            Guna2HtmlLabel6.Text = $"Found {count} viruses => see them in protection tab"
        Else
            Guna2HtmlLabel6.Refresh()
            Guna2HtmlLabel6.Text = $"{path}\n No virus found"
        End If



    End Sub

    Private Sub Guna2PictureBox3_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox3.Click
        'pass folders 1 by 1 to the gafad function
        gafad("c:\")
    End Sub

    Function md5(ByVal file_name As String)
        Dim hash = System.Security.Cryptography.MD5.Create()
        Dim hashValue() As Byte
        Dim fileStream As FileStream = File.OpenRead(file_name)
        fileStream.Position = 0
        hashValue = hash.ComputeHash(fileStream)
        Dim hash_hex = PrintByteArray(hashValue)
        fileStream.Close()
        Return hash_hex
    End Function

    Public Function PrintByteArray(ByVal array() As Byte)
        Dim hex_value As String = ""
        Dim i As Integer
        For i = 0 To array.Length - 1
            hex_value += array(i).ToString("X2")
        Next i
        Return hex_value.ToLower
    End Function
End Class
