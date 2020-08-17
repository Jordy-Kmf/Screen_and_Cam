<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnSShot = New System.Windows.Forms.Button()
        Me.btnWCam = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.btnLocation = New System.Windows.Forms.Button()
        Me.btnMin = New System.Windows.Forms.Button()
        Me.delay = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.picDisplay = New System.Windows.Forms.PictureBox()
        Me.picTaken = New System.Windows.Forms.PictureBox()
        Me.btnSnap = New System.Windows.Forms.Button()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTaken, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSShot
        '
        Me.btnSShot.Image = CType(resources.GetObject("btnSShot.Image"), System.Drawing.Image)
        Me.btnSShot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSShot.Location = New System.Drawing.Point(4, 81)
        Me.btnSShot.Name = "btnSShot"
        Me.btnSShot.Size = New System.Drawing.Size(75, 23)
        Me.btnSShot.TabIndex = 1
        Me.btnSShot.Text = "   Screen"
        Me.btnSShot.UseVisualStyleBackColor = True
        '
        'btnWCam
        '
        Me.btnWCam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnWCam.Location = New System.Drawing.Point(87, 81)
        Me.btnWCam.Name = "btnWCam"
        Me.btnWCam.Size = New System.Drawing.Size(75, 23)
        Me.btnWCam.TabIndex = 2
        Me.btnWCam.Text = "   Webcam "
        Me.btnWCam.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(227, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(20, 20)
        Me.btnExit.TabIndex = 0
        Me.btnExit.TabStop = False
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mistral", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Plum
        Me.Label1.Location = New System.Drawing.Point(18, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 57)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Take A Pic-k"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.ForeColor = System.Drawing.Color.LightGray
        Me.lblVersion.Location = New System.Drawing.Point(85, 63)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(78, 13)
        Me.lblVersion.TabIndex = 0
        Me.lblVersion.Text = "Version 1.0.0.0"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLocation
        '
        Me.btnLocation.Image = CType(resources.GetObject("btnLocation.Image"), System.Drawing.Image)
        Me.btnLocation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLocation.Location = New System.Drawing.Point(169, 81)
        Me.btnLocation.Name = "btnLocation"
        Me.btnLocation.Size = New System.Drawing.Size(75, 23)
        Me.btnLocation.TabIndex = 3
        Me.btnLocation.Text = "  Saved"
        Me.btnLocation.UseVisualStyleBackColor = True
        '
        'btnMin
        '
        Me.btnMin.BackColor = System.Drawing.Color.Transparent
        Me.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMin.Image = CType(resources.GetObject("btnMin.Image"), System.Drawing.Image)
        Me.btnMin.Location = New System.Drawing.Point(205, 0)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(20, 20)
        Me.btnMin.TabIndex = 0
        Me.btnMin.TabStop = False
        Me.btnMin.UseVisualStyleBackColor = False
        '
        'delay
        '
        Me.delay.Enabled = True
        Me.delay.Interval = 4000
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.picDisplay)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Plum
        Me.GroupBox1.Location = New System.Drawing.Point(4, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 153)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Display"
        '
        'picDisplay
        '
        Me.picDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picDisplay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picDisplay.Location = New System.Drawing.Point(3, 16)
        Me.picDisplay.Name = "picDisplay"
        Me.picDisplay.Size = New System.Drawing.Size(234, 134)
        Me.picDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDisplay.TabIndex = 0
        Me.picDisplay.TabStop = False
        '
        'picTaken
        '
        Me.picTaken.Location = New System.Drawing.Point(4, 269)
        Me.picTaken.Name = "picTaken"
        Me.picTaken.Size = New System.Drawing.Size(28, 28)
        Me.picTaken.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picTaken.TabIndex = 1
        Me.picTaken.TabStop = False
        '
        'btnSnap
        '
        Me.btnSnap.Image = CType(resources.GetObject("btnSnap.Image"), System.Drawing.Image)
        Me.btnSnap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSnap.Location = New System.Drawing.Point(169, 271)
        Me.btnSnap.Name = "btnSnap"
        Me.btnSnap.Size = New System.Drawing.Size(75, 23)
        Me.btnSnap.TabIndex = 2
        Me.btnSnap.Text = "   Snap "
        Me.btnSnap.UseVisualStyleBackColor = True
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.AsciiOnly = True
        Me.MaskedTextBox1.BeepOnError = True
        Me.MaskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MaskedTextBox1.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(93, 269)
        Me.MaskedTextBox1.Mask = "00:00"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(51, 26)
        Me.MaskedTextBox1.TabIndex = 5
        Me.MaskedTextBox1.Text = "0030"
        Me.MaskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MaskedTextBox1.ValidatingType = GetType(Date)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(59, 276)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Timer: "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(248, 108)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.picTaken)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnMin)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLocation)
        Me.Controls.Add(Me.btnSnap)
        Me.Controls.Add(Me.btnWCam)
        Me.Controls.Add(Me.btnSShot)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Opacity = 0.9R
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Take A Pic-k"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.picDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTaken, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSShot As Button
    Friend WithEvents btnWCam As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblVersion As Label
    Friend WithEvents btnLocation As Button
    Friend WithEvents btnMin As Button
    Friend WithEvents delay As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents picDisplay As PictureBox
    Friend WithEvents picTaken As PictureBox
    Friend WithEvents btnSnap As Button
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents Label2 As Label
End Class
