<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SignUP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignUP))
        Me.signForm = New Guna.UI2.WinForms.Guna2Panel()
        Me.signUpbtn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnImageUpload = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.passwordTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.confirmpasswordTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.emailtextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.POLIDTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FirstNameTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LastNameTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DOBpicker = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.pbimage = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.signForm.SuspendLayout()
        CType(Me.pbimage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'signForm
        '
        Me.signForm.Controls.Add(Me.pbimage)
        Me.signForm.Controls.Add(Me.signUpbtn)
        Me.signForm.Controls.Add(Me.btnImageUpload)
        Me.signForm.Controls.Add(Me.passwordTextBox)
        Me.signForm.Controls.Add(Me.confirmpasswordTextBox)
        Me.signForm.Controls.Add(Me.emailtextBox)
        Me.signForm.Controls.Add(Me.POLIDTextBox)
        Me.signForm.Controls.Add(Me.Label5)
        Me.signForm.Controls.Add(Me.FirstNameTextBox)
        Me.signForm.Controls.Add(Me.LastNameTextBox)
        Me.signForm.Controls.Add(Me.DOBpicker)
        Me.signForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.signForm.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.signForm.Location = New System.Drawing.Point(0, 0)
        Me.signForm.Name = "signForm"
        Me.signForm.Size = New System.Drawing.Size(479, 356)
        Me.signForm.TabIndex = 9
        '
        'signUpbtn
        '
        Me.signUpbtn.BackColor = System.Drawing.Color.Transparent
        Me.signUpbtn.BorderRadius = 16
        Me.signUpbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.signUpbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.signUpbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.signUpbtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.signUpbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.signUpbtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.signUpbtn.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.signUpbtn.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold)
        Me.signUpbtn.ForeColor = System.Drawing.Color.White
        Me.signUpbtn.Location = New System.Drawing.Point(14, 277)
        Me.signUpbtn.Name = "signUpbtn"
        Me.signUpbtn.Size = New System.Drawing.Size(185, 45)
        Me.signUpbtn.TabIndex = 51
        Me.signUpbtn.Text = "SIGN IN"
        Me.signUpbtn.UseTransparentBackground = True
        '
        'btnImageUpload
        '
        Me.btnImageUpload.BackColor = System.Drawing.Color.Transparent
        Me.btnImageUpload.CustomImages.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.btnImageUpload.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnImageUpload.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnImageUpload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnImageUpload.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnImageUpload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnImageUpload.FillColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btnImageUpload.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnImageUpload.ForeColor = System.Drawing.Color.White
        Me.btnImageUpload.Location = New System.Drawing.Point(14, 231)
        Me.btnImageUpload.Name = "btnImageUpload"
        Me.btnImageUpload.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnImageUpload.Size = New System.Drawing.Size(41, 40)
        Me.btnImageUpload.TabIndex = 46
        Me.btnImageUpload.UseTransparentBackground = True
        '
        'passwordTextBox
        '
        Me.passwordTextBox.BackColor = System.Drawing.Color.Transparent
        Me.passwordTextBox.BorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.passwordTextBox.BorderRadius = 8
        Me.passwordTextBox.BorderThickness = 0
        Me.passwordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.passwordTextBox.DefaultText = ""
        Me.passwordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.passwordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.passwordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.passwordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.passwordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.passwordTextBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.passwordTextBox.ForeColor = System.Drawing.Color.Black
        Me.passwordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.passwordTextBox.Location = New System.Drawing.Point(14, 188)
        Me.passwordTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.passwordTextBox.Name = "passwordTextBox"
        Me.passwordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(46)
        Me.passwordTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.passwordTextBox.PlaceholderText = "Password"
        Me.passwordTextBox.SelectedText = ""
        Me.passwordTextBox.Size = New System.Drawing.Size(185, 36)
        Me.passwordTextBox.TabIndex = 44
        '
        'confirmpasswordTextBox
        '
        Me.confirmpasswordTextBox.BackColor = System.Drawing.Color.Transparent
        Me.confirmpasswordTextBox.BorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.confirmpasswordTextBox.BorderRadius = 8
        Me.confirmpasswordTextBox.BorderThickness = 0
        Me.confirmpasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.confirmpasswordTextBox.DefaultText = ""
        Me.confirmpasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.confirmpasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.confirmpasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.confirmpasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.confirmpasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.confirmpasswordTextBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmpasswordTextBox.ForeColor = System.Drawing.Color.Black
        Me.confirmpasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.confirmpasswordTextBox.Location = New System.Drawing.Point(206, 188)
        Me.confirmpasswordTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.confirmpasswordTextBox.Name = "confirmpasswordTextBox"
        Me.confirmpasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(46)
        Me.confirmpasswordTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.confirmpasswordTextBox.PlaceholderText = "Confirm Password"
        Me.confirmpasswordTextBox.SelectedText = ""
        Me.confirmpasswordTextBox.Size = New System.Drawing.Size(185, 36)
        Me.confirmpasswordTextBox.TabIndex = 45
        '
        'emailtextBox
        '
        Me.emailtextBox.BackColor = System.Drawing.Color.Transparent
        Me.emailtextBox.BorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.emailtextBox.BorderRadius = 8
        Me.emailtextBox.BorderThickness = 0
        Me.emailtextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.emailtextBox.DefaultText = ""
        Me.emailtextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.emailtextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.emailtextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.emailtextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.emailtextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.emailtextBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.emailtextBox.ForeColor = System.Drawing.Color.Black
        Me.emailtextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.emailtextBox.Location = New System.Drawing.Point(14, 97)
        Me.emailtextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.emailtextBox.Name = "emailtextBox"
        Me.emailtextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.emailtextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.emailtextBox.PlaceholderText = "Email"
        Me.emailtextBox.SelectedText = ""
        Me.emailtextBox.Size = New System.Drawing.Size(452, 38)
        Me.emailtextBox.TabIndex = 43
        '
        'POLIDTextBox
        '
        Me.POLIDTextBox.BackColor = System.Drawing.Color.Transparent
        Me.POLIDTextBox.BorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.POLIDTextBox.BorderRadius = 8
        Me.POLIDTextBox.BorderThickness = 0
        Me.POLIDTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.POLIDTextBox.DefaultText = ""
        Me.POLIDTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.POLIDTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.POLIDTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.POLIDTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.POLIDTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.POLIDTextBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.POLIDTextBox.ForeColor = System.Drawing.Color.Black
        Me.POLIDTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.POLIDTextBox.Location = New System.Drawing.Point(14, 9)
        Me.POLIDTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.POLIDTextBox.Name = "POLIDTextBox"
        Me.POLIDTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.POLIDTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.POLIDTextBox.PlaceholderText = "Police ID"
        Me.POLIDTextBox.SelectedText = ""
        Me.POLIDTextBox.Size = New System.Drawing.Size(199, 36)
        Me.POLIDTextBox.TabIndex = 40
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(61, 241)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 19)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Police Image Upload"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.BackColor = System.Drawing.Color.Transparent
        Me.FirstNameTextBox.BorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.FirstNameTextBox.BorderRadius = 8
        Me.FirstNameTextBox.BorderThickness = 0
        Me.FirstNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FirstNameTextBox.DefaultText = ""
        Me.FirstNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.FirstNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.FirstNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FirstNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FirstNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FirstNameTextBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameTextBox.ForeColor = System.Drawing.Color.Black
        Me.FirstNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(12, 53)
        Me.FirstNameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FirstNameTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.FirstNameTextBox.PlaceholderText = "First Name"
        Me.FirstNameTextBox.SelectedText = ""
        Me.FirstNameTextBox.Size = New System.Drawing.Size(201, 36)
        Me.FirstNameTextBox.TabIndex = 41
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.BackColor = System.Drawing.Color.Transparent
        Me.LastNameTextBox.BorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.LastNameTextBox.BorderRadius = 8
        Me.LastNameTextBox.BorderThickness = 0
        Me.LastNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.LastNameTextBox.DefaultText = ""
        Me.LastNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.LastNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.LastNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.LastNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.LastNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LastNameTextBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastNameTextBox.ForeColor = System.Drawing.Color.Black
        Me.LastNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LastNameTextBox.Location = New System.Drawing.Point(220, 51)
        Me.LastNameTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LastNameTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.LastNameTextBox.PlaceholderText = "Last Name "
        Me.LastNameTextBox.SelectedText = ""
        Me.LastNameTextBox.Size = New System.Drawing.Size(246, 38)
        Me.LastNameTextBox.TabIndex = 42
        '
        'DOBpicker
        '
        Me.DOBpicker.BackColor = System.Drawing.Color.Transparent
        Me.DOBpicker.BorderRadius = 8
        Me.DOBpicker.Checked = True
        Me.DOBpicker.FillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.DOBpicker.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOBpicker.ForeColor = System.Drawing.Color.White
        Me.DOBpicker.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DOBpicker.Location = New System.Drawing.Point(14, 145)
        Me.DOBpicker.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DOBpicker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DOBpicker.Name = "DOBpicker"
        Me.DOBpicker.Size = New System.Drawing.Size(376, 36)
        Me.DOBpicker.TabIndex = 43
        Me.DOBpicker.UseTransparentBackground = True
        Me.DOBpicker.Value = New Date(2022, 3, 23, 0, 0, 0, 0)
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'pbimage
        '
        Me.pbimage.BackColor = System.Drawing.Color.Transparent
        Me.pbimage.FillColor = System.Drawing.Color.Transparent
        Me.pbimage.ImageRotate = 0!
        Me.pbimage.Location = New System.Drawing.Point(220, 231)
        Me.pbimage.Name = "pbimage"
        Me.pbimage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.pbimage.Size = New System.Drawing.Size(64, 54)
        Me.pbimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbimage.TabIndex = 53
        Me.pbimage.TabStop = False
        '
        'SignUP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 356)
        Me.Controls.Add(Me.signForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SignUP"
        Me.Text = "SignUP"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.signForm.ResumeLayout(False)
        Me.signForm.PerformLayout()
        CType(Me.pbimage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents signForm As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pbimage As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents signUpbtn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnImageUpload As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents passwordTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents confirmpasswordTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents emailtextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents POLIDTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents FirstNameTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LastNameTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DOBpicker As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
