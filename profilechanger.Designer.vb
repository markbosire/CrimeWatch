<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class profilechanger
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(profilechanger))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnImageUpload = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.updateBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.tb2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.label2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tb1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.label1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pbimage = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.pbimage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.Controls.Add(Me.btnImageUpload)
        Me.Guna2Panel1.Controls.Add(Me.pbimage)
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Guna2Panel1.Controls.Add(Me.updateBtn)
        Me.Guna2Panel1.Controls.Add(Me.tb2)
        Me.Guna2Panel1.Controls.Add(Me.label2)
        Me.Guna2Panel1.Controls.Add(Me.tb1)
        Me.Guna2Panel1.Controls.Add(Me.label1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(540, 275)
        Me.Guna2Panel1.TabIndex = 0
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
        Me.btnImageUpload.Location = New System.Drawing.Point(69, 110)
        Me.btnImageUpload.Name = "btnImageUpload"
        Me.btnImageUpload.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnImageUpload.Size = New System.Drawing.Size(40, 40)
        Me.btnImageUpload.TabIndex = 53
        Me.btnImageUpload.UseTransparentBackground = True
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(498, 12)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(30, 29)
        Me.Guna2ControlBox1.TabIndex = 51
        '
        'updateBtn
        '
        Me.updateBtn.BackColor = System.Drawing.Color.Transparent
        Me.updateBtn.BorderRadius = 7
        Me.updateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.updateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.updateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.updateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.updateBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.updateBtn.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.updateBtn.ForeColor = System.Drawing.Color.White
        Me.updateBtn.Location = New System.Drawing.Point(204, 201)
        Me.updateBtn.Name = "updateBtn"
        Me.updateBtn.Size = New System.Drawing.Size(106, 32)
        Me.updateBtn.TabIndex = 6
        Me.updateBtn.Text = "Update"
        Me.updateBtn.UseTransparentBackground = True
        '
        'tb2
        '
        Me.tb2.BorderRadius = 8
        Me.tb2.BorderThickness = 0
        Me.tb2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb2.DefaultText = ""
        Me.tb2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb2.FillColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.tb2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb2.ForeColor = System.Drawing.Color.White
        Me.tb2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb2.Location = New System.Drawing.Point(189, 142)
        Me.tb2.Name = "tb2"
        Me.tb2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb2.PlaceholderText = ""
        Me.tb2.SelectedText = ""
        Me.tb2.Size = New System.Drawing.Size(296, 36)
        Me.tb2.TabIndex = 3
        '
        'label2
        '
        Me.label2.BorderRadius = 8
        Me.label2.BorderThickness = 0
        Me.label2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.label2.DefaultText = ""
        Me.label2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.label2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.label2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.label2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.label2.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.label2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.White
        Me.label2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.label2.Location = New System.Drawing.Point(12, 142)
        Me.label2.Name = "label2"
        Me.label2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.label2.PlaceholderText = ""
        Me.label2.SelectedText = ""
        Me.label2.Size = New System.Drawing.Size(153, 36)
        Me.label2.TabIndex = 2
        Me.label2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tb1
        '
        Me.tb1.BorderRadius = 8
        Me.tb1.BorderThickness = 0
        Me.tb1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb1.DefaultText = ""
        Me.tb1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb1.FillColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.tb1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb1.ForeColor = System.Drawing.Color.White
        Me.tb1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb1.Location = New System.Drawing.Point(189, 91)
        Me.tb1.Name = "tb1"
        Me.tb1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb1.PlaceholderText = ""
        Me.tb1.SelectedText = ""
        Me.tb1.Size = New System.Drawing.Size(296, 36)
        Me.tb1.TabIndex = 0
        '
        'label1
        '
        Me.label1.BorderRadius = 8
        Me.label1.BorderThickness = 0
        Me.label1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.label1.DefaultText = ""
        Me.label1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.label1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.label1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.label1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.label1.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.label1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.label1.Location = New System.Drawing.Point(12, 91)
        Me.label1.Name = "label1"
        Me.label1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.label1.PlaceholderText = ""
        Me.label1.SelectedText = ""
        Me.label1.Size = New System.Drawing.Size(153, 36)
        Me.label1.TabIndex = 0
        Me.label1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pbimage
        '
        Me.pbimage.BackColor = System.Drawing.Color.Transparent
        Me.pbimage.FillColor = System.Drawing.Color.Transparent
        Me.pbimage.ImageRotate = 0!
        Me.pbimage.Location = New System.Drawing.Point(134, 96)
        Me.pbimage.Name = "pbimage"
        Me.pbimage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.pbimage.Size = New System.Drawing.Size(64, 54)
        Me.pbimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbimage.TabIndex = 52
        Me.pbimage.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'profilechanger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 275)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "profilechanger"
        Me.Text = "profilechanger"
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.pbimage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents label1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tb1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tb2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents label2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents updateBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents btnImageUpload As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents pbimage As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
