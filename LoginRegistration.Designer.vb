<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginRegistration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginRegistration))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.btnsubmit = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.signForm = New Guna.UI2.WinForms.Guna2Panel()
        Me.signupBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.signupBtnActive = New Guna.UI2.WinForms.Guna2Button()
        Me.signinBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.signinBtnActive = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.BackgroundImage = Global.CrimeWatch.My.Resources.Resources.FotoJet
        Me.Guna2GradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Guna2GradientPanel1.Controls.Add(Me.btnsubmit)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2Panel1)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.Transparent
        Me.Guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(1158, 688)
        Me.Guna2GradientPanel1.TabIndex = 1
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(1106, 21)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(30, 29)
        Me.Guna2ControlBox1.TabIndex = 50
        '
        'btnsubmit
        '
        Me.btnsubmit.BackColor = System.Drawing.Color.Transparent
        Me.btnsubmit.BorderRadius = 8
        Me.btnsubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnsubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnsubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnsubmit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnsubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnsubmit.FillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.btnsubmit.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnsubmit.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnsubmit.ForeColor = System.Drawing.Color.White
        Me.btnsubmit.Location = New System.Drawing.Point(97, 732)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(10, 45)
        Me.btnsubmit.TabIndex = 45
        Me.btnsubmit.Text = "Submit"
        Me.btnsubmit.UseTransparentBackground = True
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.Gray
        Me.Guna2Panel1.BorderRadius = 16
        Me.Guna2Panel1.BorderThickness = 3
        Me.Guna2Panel1.Controls.Add(Me.signForm)
        Me.Guna2Panel1.Controls.Add(Me.signupBtn)
        Me.Guna2Panel1.Controls.Add(Me.signupBtnActive)
        Me.Guna2Panel1.Controls.Add(Me.signinBtn)
        Me.Guna2Panel1.Controls.Add(Me.signinBtnActive)
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(346, 73)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(518, 535)
        Me.Guna2Panel1.TabIndex = 1
        Me.Guna2Panel1.UseTransparentBackground = True
        '
        'signForm
        '
        Me.signForm.Location = New System.Drawing.Point(16, 163)
        Me.signForm.Name = "signForm"
        Me.signForm.Size = New System.Drawing.Size(479, 356)
        Me.signForm.TabIndex = 8
        '
        'signupBtn
        '
        Me.signupBtn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.signupBtn.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.signupBtn.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.signupBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.signupBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.signupBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.signupBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.signupBtn.FillColor = System.Drawing.Color.Transparent
        Me.signupBtn.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signupBtn.ForeColor = System.Drawing.Color.White
        Me.signupBtn.Location = New System.Drawing.Point(266, 112)
        Me.signupBtn.Name = "signupBtn"
        Me.signupBtn.Size = New System.Drawing.Size(87, 45)
        Me.signupBtn.TabIndex = 7
        Me.signupBtn.Text = "SIGN UP"
        Me.signupBtn.UseTransparentBackground = True
        '
        'signupBtnActive
        '
        Me.signupBtnActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.signupBtnActive.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.signupBtnActive.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.signupBtnActive.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.signupBtnActive.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.signupBtnActive.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.signupBtnActive.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.signupBtnActive.FillColor = System.Drawing.Color.Transparent
        Me.signupBtnActive.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signupBtnActive.ForeColor = System.Drawing.Color.White
        Me.signupBtnActive.Location = New System.Drawing.Point(266, 112)
        Me.signupBtnActive.Name = "signupBtnActive"
        Me.signupBtnActive.Size = New System.Drawing.Size(87, 45)
        Me.signupBtnActive.TabIndex = 6
        Me.signupBtnActive.Text = "SIGN UP"
        Me.signupBtnActive.UseTransparentBackground = True
        '
        'signinBtn
        '
        Me.signinBtn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.signinBtn.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.signinBtn.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.signinBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.signinBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.signinBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.signinBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.signinBtn.FillColor = System.Drawing.Color.Transparent
        Me.signinBtn.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signinBtn.ForeColor = System.Drawing.Color.White
        Me.signinBtn.Location = New System.Drawing.Point(158, 112)
        Me.signinBtn.Name = "signinBtn"
        Me.signinBtn.Size = New System.Drawing.Size(87, 45)
        Me.signinBtn.TabIndex = 5
        Me.signinBtn.Text = "SIGN IN"
        Me.signinBtn.UseTransparentBackground = True
        '
        'signinBtnActive
        '
        Me.signinBtnActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.signinBtnActive.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.signinBtnActive.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.signinBtnActive.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.signinBtnActive.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.signinBtnActive.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.signinBtnActive.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.signinBtnActive.FillColor = System.Drawing.Color.Transparent
        Me.signinBtnActive.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signinBtnActive.ForeColor = System.Drawing.Color.White
        Me.signinBtnActive.Location = New System.Drawing.Point(158, 112)
        Me.signinBtnActive.Name = "signinBtnActive"
        Me.signinBtnActive.Size = New System.Drawing.Size(87, 45)
        Me.signinBtnActive.TabIndex = 4
        Me.signinBtnActive.Text = "SIGN IN"
        Me.signinBtnActive.UseTransparentBackground = True
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(158, 47)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(202, 59)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 3
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'LoginRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1158, 688)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginRegistration"
        Me.Text = "LoginRegistration"
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents signinBtnActive As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents signupBtnActive As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents signinBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents signupBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents signForm As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnsubmit As Guna.UI2.WinForms.Guna2GradientButton
End Class
