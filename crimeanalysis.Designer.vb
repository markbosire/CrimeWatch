<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class crimeanalysis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(crimeanalysis))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.searchButton = New Guna.UI2.WinForms.Guna2GradientCircleButton()
        Me.searchBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.crimesPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.doclbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.crimenamelbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.criminalAvatar = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.criminalIDlbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.criminalSecondName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.criminalFirstName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.crimeRating = New Guna.UI2.WinForms.Guna2RatingStar()
        Me.Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2Panel1.SuspendLayout()
        Me.crimesPanel.SuspendLayout()
        CType(Me.criminalAvatar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.Guna2DataGridView1)
        Me.Guna2Panel1.Controls.Add(Me.crimesPanel)
        Me.Guna2Panel1.Controls.Add(Me.searchButton)
        Me.Guna2Panel1.Controls.Add(Me.searchBox)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1158, 688)
        Me.Guna2Panel1.TabIndex = 0
        '
        'searchButton
        '
        Me.searchButton.BackColor = System.Drawing.Color.Transparent
        Me.searchButton.CustomImages.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
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
        Me.searchButton.Location = New System.Drawing.Point(842, 60)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.searchButton.Size = New System.Drawing.Size(37, 36)
        Me.searchButton.TabIndex = 45
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
        Me.searchBox.Location = New System.Drawing.Point(209, 60)
        Me.searchBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.searchBox.Name = "searchBox"
        Me.searchBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.searchBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.searchBox.PlaceholderText = "Search by Crime ID"
        Me.searchBox.SelectedText = ""
        Me.searchBox.Size = New System.Drawing.Size(615, 36)
        Me.searchBox.TabIndex = 44
        '
        'crimesPanel
        '
        Me.crimesPanel.BackColor = System.Drawing.Color.Transparent
        Me.crimesPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.crimesPanel.BorderRadius = 16
        Me.crimesPanel.BorderThickness = 3
        Me.crimesPanel.Controls.Add(Me.doclbl)
        Me.crimesPanel.Controls.Add(Me.crimenamelbl)
        Me.crimesPanel.Controls.Add(Me.criminalAvatar)
        Me.crimesPanel.Controls.Add(Me.criminalIDlbl)
        Me.crimesPanel.Controls.Add(Me.criminalSecondName)
        Me.crimesPanel.Controls.Add(Me.criminalFirstName)
        Me.crimesPanel.Controls.Add(Me.crimeRating)
        Me.crimesPanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.crimesPanel.Location = New System.Drawing.Point(351, 244)
        Me.crimesPanel.Name = "crimesPanel"
        Me.crimesPanel.Size = New System.Drawing.Size(365, 294)
        Me.crimesPanel.TabIndex = 46
        '
        'doclbl
        '
        Me.doclbl.BackColor = System.Drawing.Color.Transparent
        Me.doclbl.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.doclbl.ForeColor = System.Drawing.Color.White
        Me.doclbl.Location = New System.Drawing.Point(11, 153)
        Me.doclbl.Name = "doclbl"
        Me.doclbl.Size = New System.Drawing.Size(89, 25)
        Me.doclbl.TabIndex = 9
        Me.doclbl.Text = "9/11/2001"
        '
        'crimenamelbl
        '
        Me.crimenamelbl.BackColor = System.Drawing.Color.Transparent
        Me.crimenamelbl.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crimenamelbl.ForeColor = System.Drawing.Color.White
        Me.crimenamelbl.Location = New System.Drawing.Point(9, 122)
        Me.crimenamelbl.Name = "crimenamelbl"
        Me.crimenamelbl.Size = New System.Drawing.Size(98, 25)
        Me.crimenamelbl.TabIndex = 8
        Me.crimenamelbl.Text = "Crime name"
        '
        'criminalAvatar
        '
        Me.criminalAvatar.BackColor = System.Drawing.Color.Transparent
        Me.criminalAvatar.FillColor = System.Drawing.Color.Transparent
        Me.criminalAvatar.Image = CType(resources.GetObject("criminalAvatar.Image"), System.Drawing.Image)
        Me.criminalAvatar.ImageRotate = 0!
        Me.criminalAvatar.Location = New System.Drawing.Point(9, 3)
        Me.criminalAvatar.Name = "criminalAvatar"
        Me.criminalAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.criminalAvatar.Size = New System.Drawing.Size(80, 80)
        Me.criminalAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.criminalAvatar.TabIndex = 7
        Me.criminalAvatar.TabStop = False
        Me.criminalAvatar.UseTransparentBackground = True
        '
        'criminalIDlbl
        '
        Me.criminalIDlbl.BackColor = System.Drawing.Color.Transparent
        Me.criminalIDlbl.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.criminalIDlbl.ForeColor = System.Drawing.Color.White
        Me.criminalIDlbl.Location = New System.Drawing.Point(10, 89)
        Me.criminalIDlbl.Name = "criminalIDlbl"
        Me.criminalIDlbl.Size = New System.Drawing.Size(90, 25)
        Me.criminalIDlbl.TabIndex = 6
        Me.criminalIDlbl.Text = "Criminal ID"
        '
        'criminalSecondName
        '
        Me.criminalSecondName.BackColor = System.Drawing.Color.Transparent
        Me.criminalSecondName.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.criminalSecondName.ForeColor = System.Drawing.Color.White
        Me.criminalSecondName.Location = New System.Drawing.Point(96, 45)
        Me.criminalSecondName.Name = "criminalSecondName"
        Me.criminalSecondName.Size = New System.Drawing.Size(86, 25)
        Me.criminalSecondName.TabIndex = 5
        Me.criminalSecondName.Text = "Last Name"
        '
        'criminalFirstName
        '
        Me.criminalFirstName.BackColor = System.Drawing.Color.Transparent
        Me.criminalFirstName.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.criminalFirstName.ForeColor = System.Drawing.Color.White
        Me.criminalFirstName.Location = New System.Drawing.Point(95, 14)
        Me.criminalFirstName.Name = "criminalFirstName"
        Me.criminalFirstName.Size = New System.Drawing.Size(87, 25)
        Me.criminalFirstName.TabIndex = 4
        Me.criminalFirstName.Text = "First name"
        '
        'crimeRating
        '
        Me.crimeRating.BackColor = System.Drawing.Color.Transparent
        Me.crimeRating.Location = New System.Drawing.Point(11, 201)
        Me.crimeRating.Name = "crimeRating"
        Me.crimeRating.RatingColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.crimeRating.Size = New System.Drawing.Size(113, 27)
        Me.crimeRating.TabIndex = 2
        '
        'Guna2DataGridView1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Guna2DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Guna2DataGridView1.EnableHeadersVisualStyles = False
        Me.Guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.Location = New System.Drawing.Point(38, 190)
        Me.Guna2DataGridView1.Name = "Guna2DataGridView1"
        Me.Guna2DataGridView1.RowHeadersVisible = False
        Me.Guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Guna2DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.Guna2DataGridView1.TabIndex = 47
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4
        Me.Guna2DataGridView1.ThemeStyle.ReadOnly = False
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'crimeanalysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1158, 688)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "crimeanalysis"
        Me.Text = "crimeanalysis"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.crimesPanel.ResumeLayout(False)
        Me.crimesPanel.PerformLayout()
        CType(Me.criminalAvatar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents searchButton As Guna.UI2.WinForms.Guna2GradientCircleButton
    Friend WithEvents searchBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents crimesPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents doclbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents crimenamelbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents criminalAvatar As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents criminalIDlbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents criminalSecondName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents criminalFirstName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents crimeRating As Guna.UI2.WinForms.Guna2RatingStar
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
End Class
