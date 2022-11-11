<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class criminalrecords
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(criminalrecords))
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.btnFront = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.crimeBack = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.crimenext = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.showCrimes = New Guna.UI2.WinForms.Guna2Button()
        Me.crimesPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.criminalAge = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.criminalSecondName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.criminalFirstName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.criminalRating = New Guna.UI2.WinForms.Guna2RatingStar()
        Me.criminalShow = New Guna.UI2.WinForms.Guna2Button()
        Me.btnBack = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.searchButton = New Guna.UI2.WinForms.Guna2GradientCircleButton()
        Me.searchBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.criminalAvatar = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.crimesPanel.SuspendLayout()
        CType(Me.criminalAvatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Guna2GradientPanel1.Controls.Add(Me.btnFront)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2Panel1)
        Me.Guna2GradientPanel1.Controls.Add(Me.btnBack)
        Me.Guna2GradientPanel1.Controls.Add(Me.searchButton)
        Me.Guna2GradientPanel1.Controls.Add(Me.searchBox)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.Guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(1158, 688)
        Me.Guna2GradientPanel1.TabIndex = 0
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(1106, 12)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(30, 29)
        Me.Guna2ControlBox1.TabIndex = 49
        '
        'btnFront
        '
        Me.btnFront.Animated = True
        Me.btnFront.BackColor = System.Drawing.Color.Transparent
        Me.btnFront.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnFront.CustomImages.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.btnFront.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnFront.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnFront.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnFront.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnFront.FillColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnFront.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnFront.ForeColor = System.Drawing.Color.White
        Me.btnFront.Location = New System.Drawing.Point(891, 577)
        Me.btnFront.Name = "btnFront"
        Me.btnFront.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnFront.Size = New System.Drawing.Size(40, 40)
        Me.btnFront.TabIndex = 48
        Me.btnFront.UseTransparentBackground = True
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.Gray
        Me.Guna2Panel1.BorderRadius = 16
        Me.Guna2Panel1.BorderThickness = 3
        Me.Guna2Panel1.Controls.Add(Me.crimeBack)
        Me.Guna2Panel1.Controls.Add(Me.crimenext)
        Me.Guna2Panel1.Controls.Add(Me.showCrimes)
        Me.Guna2Panel1.Controls.Add(Me.crimesPanel)
        Me.Guna2Panel1.Controls.Add(Me.criminalShow)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(270, 71)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(615, 546)
        Me.Guna2Panel1.TabIndex = 1
        Me.Guna2Panel1.UseTransparentBackground = True
        '
        'crimeBack
        '
        Me.crimeBack.Animated = True
        Me.crimeBack.BackColor = System.Drawing.Color.Transparent
        Me.crimeBack.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.crimeBack.CustomImages.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.crimeBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.crimeBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.crimeBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.crimeBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.crimeBack.FillColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.crimeBack.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.crimeBack.ForeColor = System.Drawing.Color.White
        Me.crimeBack.Location = New System.Drawing.Point(72, 394)
        Me.crimeBack.Name = "crimeBack"
        Me.crimeBack.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.crimeBack.Size = New System.Drawing.Size(40, 40)
        Me.crimeBack.TabIndex = 49
        Me.crimeBack.UseTransparentBackground = True
        Me.crimeBack.Visible = False
        '
        'crimenext
        '
        Me.crimenext.Animated = True
        Me.crimenext.BackColor = System.Drawing.Color.Transparent
        Me.crimenext.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.crimenext.CustomImages.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        Me.crimenext.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.crimenext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.crimenext.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.crimenext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.crimenext.FillColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.crimenext.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.crimenext.ForeColor = System.Drawing.Color.White
        Me.crimenext.Location = New System.Drawing.Point(493, 394)
        Me.crimenext.Name = "crimenext"
        Me.crimenext.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.crimenext.Size = New System.Drawing.Size(40, 40)
        Me.crimenext.TabIndex = 49
        Me.crimenext.UseTransparentBackground = True
        Me.crimenext.Visible = False
        '
        'showCrimes
        '
        Me.showCrimes.BorderRadius = 16
        Me.showCrimes.CustomImages.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
        Me.showCrimes.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.showCrimes.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.showCrimes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.showCrimes.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.showCrimes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.showCrimes.FillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.showCrimes.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.showCrimes.ForeColor = System.Drawing.Color.White
        Me.showCrimes.HoverState.FillColor = System.Drawing.Color.Black
        Me.showCrimes.Location = New System.Drawing.Point(298, 486)
        Me.showCrimes.Name = "showCrimes"
        Me.showCrimes.Size = New System.Drawing.Size(50, 45)
        Me.showCrimes.TabIndex = 9
        '
        'crimesPanel
        '
        Me.crimesPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.crimesPanel.BorderRadius = 16
        Me.crimesPanel.BorderThickness = 3
        Me.crimesPanel.Controls.Add(Me.criminalAvatar)
        Me.crimesPanel.Controls.Add(Me.criminalAge)
        Me.crimesPanel.Controls.Add(Me.criminalSecondName)
        Me.crimesPanel.Controls.Add(Me.criminalFirstName)
        Me.crimesPanel.Controls.Add(Me.criminalRating)
        Me.crimesPanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.crimesPanel.Location = New System.Drawing.Point(135, 84)
        Me.crimesPanel.Name = "crimesPanel"
        Me.crimesPanel.Size = New System.Drawing.Size(352, 381)
        Me.crimesPanel.TabIndex = 0
        '
        'criminalAge
        '
        Me.criminalAge.BackColor = System.Drawing.Color.Transparent
        Me.criminalAge.Font = New System.Drawing.Font("Verdana", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.criminalAge.ForeColor = System.Drawing.Color.White
        Me.criminalAge.Location = New System.Drawing.Point(15, 243)
        Me.criminalAge.Name = "criminalAge"
        Me.criminalAge.Size = New System.Drawing.Size(71, 61)
        Me.criminalAge.TabIndex = 6
        Me.criminalAge.Text = "18"
        '
        'criminalSecondName
        '
        Me.criminalSecondName.BackColor = System.Drawing.Color.Transparent
        Me.criminalSecondName.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.criminalSecondName.ForeColor = System.Drawing.Color.White
        Me.criminalSecondName.Location = New System.Drawing.Point(15, 197)
        Me.criminalSecondName.Name = "criminalSecondName"
        Me.criminalSecondName.Size = New System.Drawing.Size(78, 40)
        Me.criminalSecondName.TabIndex = 5
        Me.criminalSecondName.Text = "Last"
        '
        'criminalFirstName
        '
        Me.criminalFirstName.BackColor = System.Drawing.Color.Transparent
        Me.criminalFirstName.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.criminalFirstName.ForeColor = System.Drawing.Color.White
        Me.criminalFirstName.Location = New System.Drawing.Point(15, 151)
        Me.criminalFirstName.Name = "criminalFirstName"
        Me.criminalFirstName.Size = New System.Drawing.Size(85, 40)
        Me.criminalFirstName.TabIndex = 4
        Me.criminalFirstName.Text = "First"
        '
        'criminalRating
        '
        Me.criminalRating.BackColor = System.Drawing.Color.Transparent
        Me.criminalRating.Location = New System.Drawing.Point(15, 310)
        Me.criminalRating.Name = "criminalRating"
        Me.criminalRating.RatingColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.criminalRating.Size = New System.Drawing.Size(120, 28)
        Me.criminalRating.TabIndex = 2
        '
        'criminalShow
        '
        Me.criminalShow.BorderRadius = 16
        Me.criminalShow.CustomImages.Image = CType(resources.GetObject("resource.Image4"), System.Drawing.Image)
        Me.criminalShow.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.criminalShow.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.criminalShow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.criminalShow.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.criminalShow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.criminalShow.FillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.criminalShow.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.criminalShow.ForeColor = System.Drawing.Color.White
        Me.criminalShow.HoverState.FillColor = System.Drawing.Color.Black
        Me.criminalShow.Location = New System.Drawing.Point(298, 486)
        Me.criminalShow.Name = "criminalShow"
        Me.criminalShow.Size = New System.Drawing.Size(50, 45)
        Me.criminalShow.TabIndex = 50
        Me.criminalShow.Visible = False
        '
        'btnBack
        '
        Me.btnBack.Animated = True
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnBack.CustomImages.Image = CType(resources.GetObject("resource.Image5"), System.Drawing.Image)
        Me.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBack.FillColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(224, 577)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnBack.Size = New System.Drawing.Size(40, 40)
        Me.btnBack.TabIndex = 47
        Me.btnBack.UseTransparentBackground = True
        '
        'searchButton
        '
        Me.searchButton.BackColor = System.Drawing.Color.Transparent
        Me.searchButton.CustomImages.Image = CType(resources.GetObject("resource.Image6"), System.Drawing.Image)
        Me.searchButton.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.searchButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.searchButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.searchButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.searchButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.searchButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.searchButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.searchButton.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.searchButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.searchButton.ForeColor = System.Drawing.Color.White
        Me.searchButton.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.searchButton.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.searchButton.Location = New System.Drawing.Point(903, 13)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.searchButton.Size = New System.Drawing.Size(37, 36)
        Me.searchButton.TabIndex = 43
        Me.searchButton.UseTransparentBackground = True
        '
        'searchBox
        '
        Me.searchBox.BackColor = System.Drawing.Color.Transparent
        Me.searchBox.BorderColor = System.Drawing.Color.Gray
        Me.searchBox.BorderRadius = 8
        Me.searchBox.BorderThickness = 2
        Me.searchBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.searchBox.DefaultText = ""
        Me.searchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.searchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.searchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.searchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.searchBox.FillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.searchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.searchBox.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.searchBox.ForeColor = System.Drawing.Color.White
        Me.searchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.searchBox.Location = New System.Drawing.Point(270, 13)
        Me.searchBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.searchBox.Name = "searchBox"
        Me.searchBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.searchBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.searchBox.PlaceholderText = "Search by Criminal ID"
        Me.searchBox.SelectedText = ""
        Me.searchBox.Size = New System.Drawing.Size(615, 36)
        Me.searchBox.TabIndex = 42
        '
        'criminalAvatar
        '
        Me.criminalAvatar.FillColor = System.Drawing.Color.Transparent
        Me.criminalAvatar.ImageRotate = 0!
        Me.criminalAvatar.Location = New System.Drawing.Point(115, 20)
        Me.criminalAvatar.Name = "criminalAvatar"
        Me.criminalAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.criminalAvatar.Size = New System.Drawing.Size(128, 128)
        Me.criminalAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.criminalAvatar.TabIndex = 7
        Me.criminalAvatar.TabStop = False
        Me.criminalAvatar.UseTransparentBackground = True
        '
        'criminalrecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1158, 688)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "criminalrecords"
        Me.Text = "criminalrecords"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.crimesPanel.ResumeLayout(False)
        Me.crimesPanel.PerformLayout()
        CType(Me.criminalAvatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents crimesPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents searchButton As Guna.UI2.WinForms.Guna2GradientCircleButton
    Friend WithEvents searchBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents criminalRating As Guna.UI2.WinForms.Guna2RatingStar
    Friend WithEvents criminalAge As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents criminalSecondName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents criminalFirstName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents criminalAvatar As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents btnFront As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents crimeBack As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents crimenext As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents criminalShow As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents showCrimes As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
End Class
