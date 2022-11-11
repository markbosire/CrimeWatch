<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class temp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(temp))
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.mainForm = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnNewCriminal = New Guna.UI2.WinForms.Guna2Button()
        Me.btnExistingCriminal = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2GradientPanel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2GradientPanel1.Controls.Add(Me.mainForm)
        Me.Guna2GradientPanel1.Controls.Add(Me.btnNewCriminal)
        Me.Guna2GradientPanel1.Controls.Add(Me.btnExistingCriminal)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label1)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(1158, 688)
        Me.Guna2GradientPanel1.TabIndex = 0
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(51, 3)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(109, 60)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 29
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'mainForm
        '
        Me.mainForm.BackColor = System.Drawing.Color.Transparent
        Me.mainForm.FillColor = System.Drawing.Color.Transparent
        Me.mainForm.Location = New System.Drawing.Point(86, 117)
        Me.mainForm.Name = "mainForm"
        Me.mainForm.Size = New System.Drawing.Size(970, 541)
        Me.mainForm.TabIndex = 28
        '
        'btnNewCriminal
        '
        Me.btnNewCriminal.BackColor = System.Drawing.Color.Transparent
        Me.btnNewCriminal.BorderRadius = 12
        Me.btnNewCriminal.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnNewCriminal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnNewCriminal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnNewCriminal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnNewCriminal.FillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.btnNewCriminal.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewCriminal.ForeColor = System.Drawing.Color.White
        Me.btnNewCriminal.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnNewCriminal.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnNewCriminal.Location = New System.Drawing.Point(86, 66)
        Me.btnNewCriminal.Name = "btnNewCriminal"
        Me.btnNewCriminal.Size = New System.Drawing.Size(180, 45)
        Me.btnNewCriminal.TabIndex = 27
        Me.btnNewCriminal.Text = "New criminal"
        '
        'btnExistingCriminal
        '
        Me.btnExistingCriminal.BackColor = System.Drawing.Color.Transparent
        Me.btnExistingCriminal.BorderRadius = 12
        Me.btnExistingCriminal.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnExistingCriminal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnExistingCriminal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnExistingCriminal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnExistingCriminal.FillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.btnExistingCriminal.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnExistingCriminal.ForeColor = System.Drawing.Color.White
        Me.btnExistingCriminal.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnExistingCriminal.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnExistingCriminal.Location = New System.Drawing.Point(283, 66)
        Me.btnExistingCriminal.Name = "btnExistingCriminal"
        Me.btnExistingCriminal.Size = New System.Drawing.Size(283, 45)
        Me.btnExistingCriminal.TabIndex = 26
        Me.btnExistingCriminal.Text = "Existing criminal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(137, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 25)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Enter crime commited"
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'temp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1158, 688)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "temp"
        Me.Text = "temp"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents btnNewCriminal As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnExistingCriminal As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents mainForm As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
End Class
