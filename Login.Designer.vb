<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.signForm = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2CheckBox1 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.passwordTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnsubmit = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.polIDTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.signForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'signForm
        '
        Me.signForm.Controls.Add(Me.Guna2CheckBox1)
        Me.signForm.Controls.Add(Me.Guna2HtmlLabel1)
        Me.signForm.Controls.Add(Me.passwordTextBox)
        Me.signForm.Controls.Add(Me.btnsubmit)
        Me.signForm.Controls.Add(Me.polIDTextBox)
        Me.signForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.signForm.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.signForm.Location = New System.Drawing.Point(0, 0)
        Me.signForm.Name = "signForm"
        Me.signForm.Size = New System.Drawing.Size(479, 356)
        Me.signForm.TabIndex = 9
        '
        'Guna2CheckBox1
        '
        Me.Guna2CheckBox1.AutoSize = True
        Me.Guna2CheckBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.Guna2CheckBox1.CheckedState.BorderRadius = 0
        Me.Guna2CheckBox1.CheckedState.BorderThickness = 0
        Me.Guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.Guna2CheckBox1.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.Guna2CheckBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2CheckBox1.Location = New System.Drawing.Point(86, 180)
        Me.Guna2CheckBox1.Name = "Guna2CheckBox1"
        Me.Guna2CheckBox1.Size = New System.Drawing.Size(111, 22)
        Me.Guna2CheckBox1.TabIndex = 41
        Me.Guna2CheckBox1.Text = "stay signed in"
        Me.Guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2CheckBox1.UncheckedState.BorderRadius = 0
        Me.Guna2CheckBox1.UncheckedState.BorderThickness = 0
        Me.Guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.White
        Me.Guna2CheckBox1.UseVisualStyleBackColor = False
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(178, 294)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(112, 20)
        Me.Guna2HtmlLabel1.TabIndex = 40
        Me.Guna2HtmlLabel1.Text = "Forgot Password?"
        '
        'passwordTextBox
        '
        Me.passwordTextBox.BackColor = System.Drawing.Color.Transparent
        Me.passwordTextBox.BorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.passwordTextBox.BorderRadius = 20
        Me.passwordTextBox.BorderThickness = 0
        Me.passwordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.passwordTextBox.DefaultText = ""
        Me.passwordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.passwordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.passwordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.passwordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.passwordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.passwordTextBox.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordTextBox.ForeColor = System.Drawing.Color.Black
        Me.passwordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.passwordTextBox.Location = New System.Drawing.Point(68, 111)
        Me.passwordTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.passwordTextBox.Name = "passwordTextBox"
        Me.passwordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(46)
        Me.passwordTextBox.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.passwordTextBox.PlaceholderText = "Password"
        Me.passwordTextBox.SelectedText = ""
        Me.passwordTextBox.Size = New System.Drawing.Size(334, 51)
        Me.passwordTextBox.TabIndex = 39
        '
        'btnsubmit
        '
        Me.btnsubmit.BackColor = System.Drawing.Color.Transparent
        Me.btnsubmit.BorderRadius = 16
        Me.btnsubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnsubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnsubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnsubmit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnsubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnsubmit.FillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.btnsubmit.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnsubmit.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsubmit.ForeColor = System.Drawing.Color.White
        Me.btnsubmit.Location = New System.Drawing.Point(68, 221)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(334, 45)
        Me.btnsubmit.TabIndex = 38
        Me.btnsubmit.Text = "SIGN IN"
        Me.btnsubmit.UseTransparentBackground = True
        '
        'polIDTextBox
        '
        Me.polIDTextBox.BackColor = System.Drawing.Color.Transparent
        Me.polIDTextBox.BorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.polIDTextBox.BorderRadius = 20
        Me.polIDTextBox.BorderThickness = 0
        Me.polIDTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.polIDTextBox.DefaultText = ""
        Me.polIDTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.polIDTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.polIDTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.polIDTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.polIDTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.polIDTextBox.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.polIDTextBox.ForeColor = System.Drawing.Color.Black
        Me.polIDTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.polIDTextBox.Location = New System.Drawing.Point(68, 38)
        Me.polIDTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.polIDTextBox.Name = "polIDTextBox"
        Me.polIDTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.polIDTextBox.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.polIDTextBox.PlaceholderText = "PoliceID"
        Me.polIDTextBox.SelectedText = ""
        Me.polIDTextBox.Size = New System.Drawing.Size(334, 51)
        Me.polIDTextBox.TabIndex = 36
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 356)
        Me.Controls.Add(Me.signForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.Text = "Login"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.signForm.ResumeLayout(False)
        Me.signForm.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents signForm As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2CheckBox1 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents passwordTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnsubmit As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents polIDTextBox As Guna.UI2.WinForms.Guna2TextBox
End Class
