<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InternetOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YouTubeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ROBLOXToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoogleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VidLiiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PF94ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MediaPlayerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Process1 = New System.Diagnostics.Process()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(63, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(665, 20)
        Me.TextBox1.TabIndex = 1
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 123)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(1177, 627)
        Me.WebBrowser1.TabIndex = 2
        Me.WebBrowser1.Url = New System.Uri("http://google.com", System.UriKind.Absolute)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InternetOptionsToolStripMenuItem, Me.AaToolStripMenuItem, Me.AboutToolStripMenuItem, Me.MediaPlayerToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1177, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InternetOptionsToolStripMenuItem
        '
        Me.InternetOptionsToolStripMenuItem.Image = Global.IEChaziz.My.Resources.Resources.icon_options
        Me.InternetOptionsToolStripMenuItem.Name = "InternetOptionsToolStripMenuItem"
        Me.InternetOptionsToolStripMenuItem.Size = New System.Drawing.Size(122, 20)
        Me.InternetOptionsToolStripMenuItem.Text = "Internet Options"
        '
        'AaToolStripMenuItem
        '
        Me.AaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.YouTubeToolStripMenuItem, Me.ROBLOXToolStripMenuItem, Me.GoogleToolStripMenuItem, Me.VidLiiToolStripMenuItem})
        Me.AaToolStripMenuItem.Image = Global.IEChaziz.My.Resources.Resources._1f310
        Me.AaToolStripMenuItem.Name = "AaToolStripMenuItem"
        Me.AaToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.AaToolStripMenuItem.Text = "Websites"
        '
        'YouTubeToolStripMenuItem
        '
        Me.YouTubeToolStripMenuItem.Image = Global.IEChaziz.My.Resources.Resources.favicon_vfl1123
        Me.YouTubeToolStripMenuItem.Name = "YouTubeToolStripMenuItem"
        Me.YouTubeToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.YouTubeToolStripMenuItem.Text = "YouTube"
        '
        'ROBLOXToolStripMenuItem
        '
        Me.ROBLOXToolStripMenuItem.Image = Global.IEChaziz.My.Resources.Resources.favicon
        Me.ROBLOXToolStripMenuItem.Name = "ROBLOXToolStripMenuItem"
        Me.ROBLOXToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.ROBLOXToolStripMenuItem.Text = "ROBLOX"
        '
        'GoogleToolStripMenuItem
        '
        Me.GoogleToolStripMenuItem.Image = Global.IEChaziz.My.Resources.Resources.favicon__1_
        Me.GoogleToolStripMenuItem.Name = "GoogleToolStripMenuItem"
        Me.GoogleToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.GoogleToolStripMenuItem.Text = "Google"
        '
        'VidLiiToolStripMenuItem
        '
        Me.VidLiiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PF94ToolStripMenuItem})
        Me.VidLiiToolStripMenuItem.Name = "VidLiiToolStripMenuItem"
        Me.VidLiiToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.VidLiiToolStripMenuItem.Text = "VidLii"
        '
        'PF94ToolStripMenuItem
        '
        Me.PF94ToolStripMenuItem.Name = "PF94ToolStripMenuItem"
        Me.PF94ToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.PF94ToolStripMenuItem.Text = "PF94"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = Global.IEChaziz.My.Resources.Resources.Information1
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'MediaPlayerToolStripMenuItem
        '
        Me.MediaPlayerToolStripMenuItem.Image = Global.IEChaziz.My.Resources.Resources.mediaPlay
        Me.MediaPlayerToolStripMenuItem.Name = "MediaPlayerToolStripMenuItem"
        Me.MediaPlayerToolStripMenuItem.Size = New System.Drawing.Size(103, 20)
        Me.MediaPlayerToolStripMenuItem.Text = "mediaChaziz"
        '
        'Process1
        '
        Me.Process1.StartInfo.Domain = ""
        Me.Process1.StartInfo.LoadUserProfile = False
        Me.Process1.StartInfo.Password = Nothing
        Me.Process1.StartInfo.StandardErrorEncoding = Nothing
        Me.Process1.StartInfo.StandardOutputEncoding = Nothing
        Me.Process1.StartInfo.UserName = ""
        Me.Process1.SynchronizingObject = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(3, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "URL/Link"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(190, 94)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(794, 23)
        Me.Panel1.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = Global.IEChaziz.My.Resources.Resources._290
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(734, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 24)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Enter"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button8.BackColor = System.Drawing.Color.Gainsboro
        Me.Button8.BackgroundImage = Global.IEChaziz.My.Resources.Resources.Search2
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.Location = New System.Drawing.Point(1085, 27)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(92, 92)
        Me.Button8.TabIndex = 12
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Gainsboro
        Me.Button7.BackgroundImage = Global.IEChaziz.My.Resources.Resources.close
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Maroon
        Me.Button7.Location = New System.Drawing.Point(265, 28)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(69, 62)
        Me.Button7.TabIndex = 10
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.BackColor = System.Drawing.Color.Gainsboro
        Me.Button6.BackgroundImage = Global.IEChaziz.My.Resources.Resources.Print_icon
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button6.Location = New System.Drawing.Point(916, 28)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(68, 66)
        Me.Button6.TabIndex = 9
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackColor = System.Drawing.Color.Gainsboro
        Me.Button5.BackgroundImage = Global.IEChaziz.My.Resources.Resources.home
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button5.Location = New System.Drawing.Point(990, 27)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(89, 90)
        Me.Button5.TabIndex = 6
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Gainsboro
        Me.Button4.BackgroundImage = Global.IEChaziz.My.Resources.Resources.Button_Refresh_icon
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.Location = New System.Drawing.Point(190, 27)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(69, 63)
        Me.Button4.TabIndex = 5
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Gainsboro
        Me.Button3.BackgroundImage = Global.IEChaziz.My.Resources.Resources.back_button
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.Location = New System.Drawing.Point(0, 27)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(95, 90)
        Me.Button3.TabIndex = 4
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Gainsboro
        Me.Button2.BackgroundImage = Global.IEChaziz.My.Resources.Resources.forward_button
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Location = New System.Drawing.Point(99, 27)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 90)
        Me.Button2.TabIndex = 3
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1177, 749)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "netChaziz - Beta 1.0"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        WebBrowser1.GoHome()
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Diagnostics.Process.Start("inetcpl.cpl")
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InternetOptionsToolStripMenuItem As ToolStripMenuItem

    Private Sub InternetOptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InternetOptionsToolStripMenuItem.Click
        Diagnostics.Process.Start("inetcpl.cpl")
    End Sub

    Private Sub AboutWindowsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Diagnostics.Process.Start("winver.exe")
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AboutCodenameNetChazizToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem

    Private Sub AboutToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Friend WithEvents Button6 As Button

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        WebBrowser1.ShowPrintDialog()
    End Sub

    Private Sub ProgressBar1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs)

    End Sub

    Friend WithEvents Process1 As Process

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Friend WithEvents AaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button7 As Button

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        WebBrowser1.Stop()
    End Sub

    Private Sub AaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AaToolStripMenuItem.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Friend WithEvents Button8 As Button

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        WebBrowser1.GoSearch()
    End Sub

    Friend WithEvents Label1 As Label

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Friend WithEvents YouTubeToolStripMenuItem As ToolStripMenuItem

    Private Sub YouTubeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YouTubeToolStripMenuItem.Click
        WebBrowser1.Navigate("youtube.com")
    End Sub

    Friend WithEvents ROBLOXToolStripMenuItem As ToolStripMenuItem

    Private Sub ROBLOXToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ROBLOXToolStripMenuItem.Click
        WebBrowser1.Navigate("roblox.com")
    End Sub

    Friend WithEvents GoogleToolStripMenuItem As ToolStripMenuItem

    Private Sub GoogleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoogleToolStripMenuItem.Click
        WebBrowser1.Navigate("google.com")
    End Sub

    Friend WithEvents Panel1 As Panel

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents VidLiiToolStripMenuItem As ToolStripMenuItem

    Private Sub VidLiiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VidLiiToolStripMenuItem.Click
        WebBrowser1.Navigate("vidlii.com")
    End Sub

    Friend WithEvents PF94ToolStripMenuItem As ToolStripMenuItem

    Private Sub GamerappaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PF94ToolStripMenuItem.Click
        WebBrowser1.Navigate("vidlii.com/PF94")
    End Sub

    Private Sub Process1_Exited(sender As Object, e As EventArgs) Handles Process1.Exited

    End Sub

    Friend WithEvents MediaPlayerToolStripMenuItem As ToolStripMenuItem

    Private Sub MediaPlayerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MediaPlayerToolStripMenuItem.Click
        Media.Show()
    End Sub
End Class
