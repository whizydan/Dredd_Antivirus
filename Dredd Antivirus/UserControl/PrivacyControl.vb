Imports Guna.UI2.WinForms
Imports VpnHood.Common

Public Class PrivacyControl

    Dim oProcess As New Process()
    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click

        Dim vpnExecutable As String
        vpnExecutable = "\Debug\net6.0\ConnectVpn.exe"
        Dim executingPath As String = IO.Path.GetDirectoryName(Reflection.Assembly.GetExecutingAssembly().Location)
        vpnExecutable = executingPath + vpnExecutable



        Dim oStartInfo As New ProcessStartInfo(vpnExecutable, "arguments")
        oStartInfo.UseShellExecute = False
        oStartInfo.RedirectStandardOutput = True
        oProcess.StartInfo = oStartInfo
        oProcess.Start()

        Dim sOutput As String
        Using oStreamReader As System.IO.StreamReader = oProcess.StandardOutput
            sOutput = oStreamReader.ReadToEnd()
        End Using
        outputText.Text = sOutput
    End Sub

    Private Sub PrivacyControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'check if file exists to know if vpn is working'
        If IO.File.Exists("C:\Temp\csc.txt") Then
            connectImage.Image = Image.FromFile(IO.Path.GetDirectoryName(Reflection.Assembly.GetExecutingAssembly().Location) + "\Assets\img\connected.gif")
            Guna2Button1.Visible = True
            Guna2GradientButton1.Visible = False
        Else
            connectImage.Image = Image.FromFile(IO.Path.GetDirectoryName(Reflection.Assembly.GetExecutingAssembly().Location) + "\Assets\img\animation_llbe9a90_small.gif")
            Guna2Button1.Visible = False
            Guna2GradientButton1.Visible = True
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        oProcess.Close()
        connectImage.Image = Image.FromFile(IO.Path.GetDirectoryName(Reflection.Assembly.GetExecutingAssembly().Location) + "\Assets\img\animation_llbe9a90_small.gif")
        Guna2Button1.Visible = False
        Guna2GradientButton1.Visible = True
    End Sub
End Class
