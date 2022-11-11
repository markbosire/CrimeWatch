<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim Animation1 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.usernamelbl = New System.Windows.Forms.Label()
        Me.btnCriminalInput = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnNewCrime = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientButton2 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnCriminalRecords = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.btnShow = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.btnHide = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        Me.mainForm = New Guna.UI2.WinForms.Guna2Panel()
        Me.unamelbl = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.unamepic = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.mainForm.SuspendLayout()
        Me.unamelbl.SuspendLayout()
        CType(Me.unamepic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Black
        Me.Guna2Panel1.Controls.Add(Me.Guna2GroupBox1)
        Me.Guna2Panel1.Controls.Add(Me.btnCriminalInput)
        Me.Guna2Panel1.Controls.Add(Me.btnNewCrime)
        Me.Guna2Panel1.Controls.Add(Me.Guna2GradientButton2)
        Me.Guna2Panel1.Controls.Add(Me.btnCriminalRecords)
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Transition1.SetDecoration(Me.Guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(67, 688)
        Me.Guna2Panel1.TabIndex = 0
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.Controls.Add(Me.usernamelbl)
        Me.Guna2GroupBox1.Controls.Add(Me.unamepic)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2GroupBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(12, 613)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(211, 50)
        Me.Guna2GroupBox1.TabIndex = 0
        Me.Guna2GroupBox1.Text = "Guna2GroupBox1"
        '
        'usernamelbl
        '
        Me.usernamelbl.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.usernamelbl, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.usernamelbl.Location = New System.Drawing.Point(83, 17)
        Me.usernamelbl.Name = "usernamelbl"
        Me.usernamelbl.Size = New System.Drawing.Size(59, 15)
        Me.usernamelbl.TabIndex = 0
        Me.usernamelbl.Text = "username"
        '
        'btnCriminalInput
        '
        Me.btnCriminalInput.BackColor = System.Drawing.Color.Black
        Me.btnCriminalInput.CustomImages.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.btnCriminalInput.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnCriminalInput.CustomImages.ImageSize = New System.Drawing.Size(40, 40)
        Me.Guna2Transition1.SetDecoration(Me.btnCriminalInput, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnCriminalInput.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCriminalInput.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCriminalInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCriminalInput.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCriminalInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCriminalInput.FillColor = System.Drawing.Color.Black
        Me.btnCriminalInput.FillColor2 = System.Drawing.Color.Black
        Me.btnCriminalInput.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCriminalInput.ForeColor = System.Drawing.Color.White
        Me.btnCriminalInput.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.btnCriminalInput.HoverState.FillColor2 = System.Drawing.Color.Black
        Me.btnCriminalInput.HoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCriminalInput.Location = New System.Drawing.Point(0, 365)
        Me.btnCriminalInput.Name = "btnCriminalInput"
        Me.btnCriminalInput.Size = New System.Drawing.Size(211, 50)
        Me.btnCriminalInput.TabIndex = 6
        Me.btnCriminalInput.Text = "Criminal Input"
        Me.btnCriminalInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnCriminalInput.TextOffset = New System.Drawing.Point(55, 0)
        '
        'btnNewCrime
        '
        Me.btnNewCrime.BackColor = System.Drawing.Color.Black
        Me.btnNewCrime.CustomImages.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.btnNewCrime.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnNewCrime.CustomImages.ImageSize = New System.Drawing.Size(40, 40)
        Me.Guna2Transition1.SetDecoration(Me.btnNewCrime, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnNewCrime.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnNewCrime.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnNewCrime.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnNewCrime.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnNewCrime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnNewCrime.FillColor = System.Drawing.Color.Black
        Me.btnNewCrime.FillColor2 = System.Drawing.Color.Black
        Me.btnNewCrime.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnNewCrime.ForeColor = System.Drawing.Color.White
        Me.btnNewCrime.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.btnNewCrime.HoverState.FillColor2 = System.Drawing.Color.Black
        Me.btnNewCrime.HoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewCrime.Location = New System.Drawing.Point(0, 309)
        Me.btnNewCrime.Name = "btnNewCrime"
        Me.btnNewCrime.Size = New System.Drawing.Size(211, 50)
        Me.btnNewCrime.TabIndex = 5
        Me.btnNewCrime.Text = "New Crime"
        Me.btnNewCrime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnNewCrime.TextOffset = New System.Drawing.Point(55, 0)
        '
        'Guna2GradientButton2
        '
        Me.Guna2GradientButton2.BackColor = System.Drawing.Color.Black
        Me.Guna2GradientButton2.CustomImages.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        Me.Guna2GradientButton2.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2GradientButton2.CustomImages.ImageSize = New System.Drawing.Size(40, 40)
        Me.Guna2Transition1.SetDecoration(Me.Guna2GradientButton2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2GradientButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2GradientButton2.FillColor = System.Drawing.Color.Black
        Me.Guna2GradientButton2.FillColor2 = System.Drawing.Color.Black
        Me.Guna2GradientButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GradientButton2.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton2.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.Guna2GradientButton2.HoverState.FillColor2 = System.Drawing.Color.Black
        Me.Guna2GradientButton2.HoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GradientButton2.Location = New System.Drawing.Point(0, 253)
        Me.Guna2GradientButton2.Name = "Guna2GradientButton2"
        Me.Guna2GradientButton2.Size = New System.Drawing.Size(211, 50)
        Me.Guna2GradientButton2.TabIndex = 4
        Me.Guna2GradientButton2.Text = "Crime Analysis"
        Me.Guna2GradientButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2GradientButton2.TextOffset = New System.Drawing.Point(55, 0)
        '
        'btnCriminalRecords
        '
        Me.btnCriminalRecords.BackColor = System.Drawing.Color.Black
        Me.btnCriminalRecords.CustomImages.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
        Me.btnCriminalRecords.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnCriminalRecords.CustomImages.ImageSize = New System.Drawing.Size(40, 40)
        Me.Guna2Transition1.SetDecoration(Me.btnCriminalRecords, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnCriminalRecords.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCriminalRecords.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCriminalRecords.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCriminalRecords.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCriminalRecords.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCriminalRecords.FillColor = System.Drawing.Color.Black
        Me.btnCriminalRecords.FillColor2 = System.Drawing.Color.Black
        Me.btnCriminalRecords.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCriminalRecords.ForeColor = System.Drawing.Color.White
        Me.btnCriminalRecords.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.btnCriminalRecords.HoverState.FillColor2 = System.Drawing.Color.Black
        Me.btnCriminalRecords.HoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCriminalRecords.Location = New System.Drawing.Point(0, 197)
        Me.btnCriminalRecords.Name = "btnCriminalRecords"
        Me.btnCriminalRecords.Size = New System.Drawing.Size(211, 50)
        Me.btnCriminalRecords.TabIndex = 3
        Me.btnCriminalRecords.Text = "Criminal Records"
        Me.btnCriminalRecords.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnCriminalRecords.TextOffset = New System.Drawing.Point(55, 0)
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'btnShow
        '
        Me.btnShow.Animated = True
        Me.btnShow.BackColor = System.Drawing.Color.Transparent
        Me.btnShow.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnShow.CustomImages.Image = Global.CrimeWatch.My.Resources.Resources.ddd
        Me.Guna2Transition1.SetDecoration(Me.btnShow, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnShow.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnShow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnShow.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnShow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnShow.FillColor = System.Drawing.Color.Black
        Me.btnShow.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnShow.ForeColor = System.Drawing.Color.White
        Me.btnShow.Location = New System.Drawing.Point(206, 580)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnShow.Size = New System.Drawing.Size(40, 40)
        Me.btnShow.TabIndex = 2
        Me.btnShow.UseTransparentBackground = True
        Me.btnShow.Visible = False
        '
        'btnHide
        '
        Me.btnHide.Animated = True
        Me.btnHide.BackColor = System.Drawing.Color.Transparent
        Me.btnHide.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnHide.CustomImages.Image = Global.CrimeWatch.My.Resources.Resources.yyy
        Me.btnHide.CustomImages.ImageSize = New System.Drawing.Size(15, 15)
        Me.Guna2Transition1.SetDecoration(Me.btnHide, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnHide.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnHide.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnHide.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnHide.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnHide.FillColor = System.Drawing.Color.Black
        Me.btnHide.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnHide.ForeColor = System.Drawing.Color.White
        Me.btnHide.Location = New System.Drawing.Point(51, 580)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnHide.Size = New System.Drawing.Size(40, 40)
        Me.btnHide.TabIndex = 5
        Me.btnHide.UseTransparentBackground = True
        '
        'Guna2Transition1
        '
        Me.Guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide
        Me.Guna2Transition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.Guna2Transition1.DefaultAnimation = Animation1
        '
        'mainForm
        '
        Me.mainForm.BackColor = System.Drawing.Color.Black
        Me.mainForm.Controls.Add(Me.unamelbl)
        Me.Guna2Transition1.SetDecoration(Me.mainForm, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.mainForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainForm.FillColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.mainForm.Location = New System.Drawing.Point(0, 0)
        Me.mainForm.Name = "mainForm"
        Me.mainForm.Size = New System.Drawing.Size(1158, 688)
        Me.mainForm.TabIndex = 6
        '
        'unamelbl
        '
        Me.unamelbl.Controls.Add(Me.Guna2ControlBox1)
        Me.Guna2Transition1.SetDecoration(Me.unamelbl, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.unamelbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.unamelbl.FillColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.unamelbl.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.unamelbl.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.unamelbl.Location = New System.Drawing.Point(0, 0)
        Me.unamelbl.Name = "unamelbl"
        Me.unamelbl.Size = New System.Drawing.Size(1158, 688)
        Me.unamelbl.TabIndex = 0
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(1116, 12)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(30, 29)
        Me.Guna2ControlBox1.TabIndex = 50
        '
        'unamepic
        '
        Me.Guna2Transition1.SetDecoration(Me.unamepic, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.unamepic.ErrorImage = CType(resources.GetObject("unamepic.ErrorImage"), System.Drawing.Image)
        Me.unamepic.Image = Global.CrimeWatch.My.Resources.Resources.ssmvtnogc7ue0jufjd03h6mj89
        Me.unamepic.ImageRotate = 0!
        Me.unamepic.Location = New System.Drawing.Point(3, 3)
        Me.unamepic.Name = "unamepic"
        Me.unamepic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.unamepic.Size = New System.Drawing.Size(40, 40)
        Me.unamepic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.unamepic.TabIndex = 0
        Me.unamepic.TabStop = False
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(3, 83)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(202, 59)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 2
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1158, 688)
        Me.Controls.Add(Me.btnHide)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.mainForm)
        Me.Guna2Transition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.mainForm.ResumeLayout(False)
        Me.unamelbl.ResumeLayout(False)
        CType(Me.unamepic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents btnCriminalRecords As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnCriminalInput As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnNewCrime As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientButton2 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnShow As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents btnHide As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents mainForm As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents unamelbl As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents usernamelbl As Label
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents unamepic As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
End Class
