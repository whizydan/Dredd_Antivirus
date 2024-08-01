<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrivacyControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(PrivacyControl))
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        connectImage = New Guna.UI2.WinForms.Guna2PictureBox()
        Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(components)
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Guna2GradientButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        outputText = New Guna.UI2.WinForms.Guna2HtmlLabel()
        CType(connectImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2Elipse1
        ' 
        Guna2Elipse1.BorderRadius = 20
        Guna2Elipse1.TargetControl = Me
        ' 
        ' connectImage
        ' 
        connectImage.BackColor = Color.Transparent
        connectImage.CustomizableEdges = CustomizableEdges5
        connectImage.FillColor = Color.Transparent
        connectImage.Image = CType(resources.GetObject("connectImage.Image"), Image)
        connectImage.ImageRotate = 0F
        connectImage.Location = New Point(148, 32)
        connectImage.Name = "connectImage"
        connectImage.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        connectImage.Size = New Size(300, 200)
        connectImage.SizeMode = PictureBoxSizeMode.Zoom
        connectImage.TabIndex = 0
        connectImage.TabStop = False
        ' 
        ' Guna2Elipse2
        ' 
        Guna2Elipse2.BorderRadius = 20
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.Animated = True
        Guna2Button1.AutoRoundedCorners = True
        Guna2Button1.BorderRadius = 21
        Guna2Button1.CustomizableEdges = CustomizableEdges3
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.FillColor = Color.Red
        Guna2Button1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2Button1.ForeColor = Color.White
        Guna2Button1.Location = New Point(200, 238)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Button1.Size = New Size(180, 45)
        Guna2Button1.TabIndex = 3
        Guna2Button1.Text = "Disconnect"
        Guna2Button1.Visible = False
        ' 
        ' Guna2GradientButton1
        ' 
        Guna2GradientButton1.AutoRoundedCorners = True
        Guna2GradientButton1.BorderRadius = 21
        Guna2GradientButton1.CustomizableEdges = CustomizableEdges1
        Guna2GradientButton1.DisabledState.BorderColor = Color.DarkGray
        Guna2GradientButton1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2GradientButton1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientButton1.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientButton1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2GradientButton1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2GradientButton1.ForeColor = Color.White
        Guna2GradientButton1.Location = New Point(200, 238)
        Guna2GradientButton1.Name = "Guna2GradientButton1"
        Guna2GradientButton1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2GradientButton1.Size = New Size(180, 45)
        Guna2GradientButton1.TabIndex = 4
        Guna2GradientButton1.Text = "Connect"
        ' 
        ' outputText
        ' 
        outputText.AutoSize = False
        outputText.BackColor = Color.Gainsboro
        outputText.Location = New Point(28, 298)
        outputText.Name = "outputText"
        outputText.Size = New Size(479, 129)
        outputText.TabIndex = 5
        outputText.Text = "C:\\"
        ' 
        ' PrivacyControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(outputText)
        Controls.Add(Guna2GradientButton1)
        Controls.Add(Guna2Button1)
        Controls.Add(connectImage)
        Name = "PrivacyControl"
        Size = New Size(800, 450)
        CType(connectImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents connectImage As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents outputText As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
