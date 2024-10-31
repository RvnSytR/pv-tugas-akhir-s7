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
        Me.Title = New System.Windows.Forms.Label()
        Me.Calculate = New System.Windows.Forms.Button()
        Me.Subtitle2 = New System.Windows.Forms.Label()
        Me.Subtitle1 = New System.Windows.Forms.Label()
        Me.LoadingText = New System.Windows.Forms.Label()
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ZodPanel = New System.Windows.Forms.Panel()
        Me.ZodLabel = New System.Windows.Forms.Label()
        Me.ZodDesc = New System.Windows.Forms.Label()
        Me.DescLabel = New System.Windows.Forms.Label()
        Me.CareerLabel = New System.Windows.Forms.Label()
        Me.ZodCareer = New System.Windows.Forms.Label()
        Me.LoveLabel = New System.Windows.Forms.Label()
        Me.ZodLove = New System.Windows.Forms.Label()
        Me.BackLink = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.Color.White
        Me.Title.Location = New System.Drawing.Point(40, 214)
        Me.Title.Margin = New System.Windows.Forms.Padding(0)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(505, 55)
        Me.Title.TabIndex = 0
        Me.Title.Text = "What Zodiac Sign Am I ?"
        '
        'Calculate
        '
        Me.Calculate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Calculate.Location = New System.Drawing.Point(210, 450)
        Me.Calculate.Margin = New System.Windows.Forms.Padding(0)
        Me.Calculate.Name = "Calculate"
        Me.Calculate.Size = New System.Drawing.Size(185, 35)
        Me.Calculate.TabIndex = 6
        Me.Calculate.Text = "Calculate My Sign"
        Me.Calculate.UseVisualStyleBackColor = True
        '
        'Subtitle2
        '
        Me.Subtitle2.AutoSize = True
        Me.Subtitle2.BackColor = System.Drawing.Color.Transparent
        Me.Subtitle2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subtitle2.ForeColor = System.Drawing.Color.White
        Me.Subtitle2.Location = New System.Drawing.Point(130, 305)
        Me.Subtitle2.Margin = New System.Windows.Forms.Padding(0)
        Me.Subtitle2.Name = "Subtitle2"
        Me.Subtitle2.Size = New System.Drawing.Size(328, 27)
        Me.Subtitle2.TabIndex = 9
        Me.Subtitle2.Text = " Here is a how you can check it !"
        '
        'Subtitle1
        '
        Me.Subtitle1.AutoSize = True
        Me.Subtitle1.BackColor = System.Drawing.Color.Transparent
        Me.Subtitle1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subtitle1.ForeColor = System.Drawing.Color.White
        Me.Subtitle1.Location = New System.Drawing.Point(110, 275)
        Me.Subtitle1.Margin = New System.Windows.Forms.Padding(0)
        Me.Subtitle1.Name = "Subtitle1"
        Me.Subtitle1.Size = New System.Drawing.Size(378, 27)
        Me.Subtitle1.TabIndex = 8
        Me.Subtitle1.Text = "Are you sure about your Zodiac sign ?"
        '
        'LoadingText
        '
        Me.LoadingText.BackColor = System.Drawing.Color.Transparent
        Me.LoadingText.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadingText.ForeColor = System.Drawing.Color.White
        Me.LoadingText.Location = New System.Drawing.Point(175, 401)
        Me.LoadingText.Name = "LoadingText"
        Me.LoadingText.Size = New System.Drawing.Size(250, 50)
        Me.LoadingText.TabIndex = 0
        Me.LoadingText.Text = "Loading..."
        Me.LoadingText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LoadingText.Visible = False
        '
        'DateTimePicker
        '
        Me.DateTimePicker.Cursor = System.Windows.Forms.Cursors.Default
        Me.DateTimePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DateTimePicker.Font = New System.Drawing.Font("Inter Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker.Location = New System.Drawing.Point(165, 375)
        Me.DateTimePicker.Margin = New System.Windows.Forms.Padding(0)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(275, 26)
        Me.DateTimePicker.TabIndex = 0
        '
        'ZodPanel
        '
        Me.ZodPanel.BackColor = System.Drawing.Color.Transparent
        Me.ZodPanel.Location = New System.Drawing.Point(254, 51)
        Me.ZodPanel.Name = "ZodPanel"
        Me.ZodPanel.Size = New System.Drawing.Size(96, 96)
        Me.ZodPanel.TabIndex = 12
        '
        'ZodLabel
        '
        Me.ZodLabel.BackColor = System.Drawing.Color.Transparent
        Me.ZodLabel.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZodLabel.ForeColor = System.Drawing.Color.White
        Me.ZodLabel.Location = New System.Drawing.Point(50, 150)
        Me.ZodLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.ZodLabel.Name = "ZodLabel"
        Me.ZodLabel.Size = New System.Drawing.Size(495, 55)
        Me.ZodLabel.TabIndex = 11
        Me.ZodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ZodDesc
        '
        Me.ZodDesc.AutoSize = True
        Me.ZodDesc.BackColor = System.Drawing.Color.Transparent
        Me.ZodDesc.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZodDesc.ForeColor = System.Drawing.Color.White
        Me.ZodDesc.Location = New System.Drawing.Point(45, 225)
        Me.ZodDesc.Margin = New System.Windows.Forms.Padding(0)
        Me.ZodDesc.Name = "ZodDesc"
        Me.ZodDesc.Size = New System.Drawing.Size(116, 27)
        Me.ZodDesc.TabIndex = 13
        Me.ZodDesc.Text = "- Deskripsi"
        Me.ZodDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DescLabel
        '
        Me.DescLabel.AutoSize = True
        Me.DescLabel.BackColor = System.Drawing.Color.Transparent
        Me.DescLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescLabel.ForeColor = System.Drawing.Color.LightGray
        Me.DescLabel.Location = New System.Drawing.Point(45, 260)
        Me.DescLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.DescLabel.Name = "DescLabel"
        Me.DescLabel.Size = New System.Drawing.Size(0, 19)
        Me.DescLabel.TabIndex = 14
        '
        'CareerLabel
        '
        Me.CareerLabel.AutoSize = True
        Me.CareerLabel.BackColor = System.Drawing.Color.Transparent
        Me.CareerLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CareerLabel.ForeColor = System.Drawing.Color.LightGray
        Me.CareerLabel.Location = New System.Drawing.Point(44, 410)
        Me.CareerLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.CareerLabel.Name = "CareerLabel"
        Me.CareerLabel.Size = New System.Drawing.Size(0, 19)
        Me.CareerLabel.TabIndex = 16
        '
        'ZodCareer
        '
        Me.ZodCareer.AutoSize = True
        Me.ZodCareer.BackColor = System.Drawing.Color.Transparent
        Me.ZodCareer.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZodCareer.ForeColor = System.Drawing.Color.White
        Me.ZodCareer.Location = New System.Drawing.Point(44, 375)
        Me.ZodCareer.Margin = New System.Windows.Forms.Padding(0)
        Me.ZodCareer.Name = "ZodCareer"
        Me.ZodCareer.Size = New System.Drawing.Size(76, 27)
        Me.ZodCareer.TabIndex = 15
        Me.ZodCareer.Text = "- Karir"
        Me.ZodCareer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LoveLabel
        '
        Me.LoveLabel.AutoSize = True
        Me.LoveLabel.BackColor = System.Drawing.Color.Transparent
        Me.LoveLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoveLabel.ForeColor = System.Drawing.Color.LightGray
        Me.LoveLabel.Location = New System.Drawing.Point(45, 560)
        Me.LoveLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.LoveLabel.Name = "LoveLabel"
        Me.LoveLabel.Size = New System.Drawing.Size(0, 19)
        Me.LoveLabel.TabIndex = 18
        '
        'ZodLove
        '
        Me.ZodLove.AutoSize = True
        Me.ZodLove.BackColor = System.Drawing.Color.Transparent
        Me.ZodLove.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZodLove.ForeColor = System.Drawing.Color.White
        Me.ZodLove.Location = New System.Drawing.Point(45, 525)
        Me.ZodLove.Margin = New System.Windows.Forms.Padding(0)
        Me.ZodLove.Name = "ZodLove"
        Me.ZodLove.Size = New System.Drawing.Size(99, 27)
        Me.ZodLove.TabIndex = 17
        Me.ZodLove.Text = "- Asmara"
        Me.ZodLove.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BackLink
        '
        Me.BackLink.BackColor = System.Drawing.Color.Transparent
        Me.BackLink.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BackLink.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackLink.ForeColor = System.Drawing.Color.White
        Me.BackLink.Location = New System.Drawing.Point(44, 700)
        Me.BackLink.Margin = New System.Windows.Forms.Padding(0)
        Me.BackLink.Name = "BackLink"
        Me.BackLink.Size = New System.Drawing.Size(501, 27)
        Me.BackLink.TabIndex = 19
        Me.BackLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackgroundImage = Global.tugas_akhir_s7.My.Resources.Resources.blurry_gradient_haikei
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(584, 861)
        Me.Controls.Add(Me.BackLink)
        Me.Controls.Add(Me.LoveLabel)
        Me.Controls.Add(Me.ZodLove)
        Me.Controls.Add(Me.CareerLabel)
        Me.Controls.Add(Me.ZodCareer)
        Me.Controls.Add(Me.DescLabel)
        Me.Controls.Add(Me.ZodDesc)
        Me.Controls.Add(Me.ZodPanel)
        Me.Controls.Add(Me.ZodLabel)
        Me.Controls.Add(Me.DateTimePicker)
        Me.Controls.Add(Me.LoadingText)
        Me.Controls.Add(Me.Subtitle2)
        Me.Controls.Add(Me.Subtitle1)
        Me.Controls.Add(Me.Calculate)
        Me.Controls.Add(Me.Title)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Inter", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(600, 900)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(600, 900)
        Me.Name = "Form1"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Zodiaaccc"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Title As Label
    Friend WithEvents Calculate As Button
    Friend WithEvents Subtitle2 As Label
    Friend WithEvents Subtitle1 As Label
    Friend WithEvents LoadingText As Label
    Friend WithEvents DateTimePicker As DateTimePicker
    Friend WithEvents ZodPanel As Panel
    Friend WithEvents ZodLabel As Label
    Friend WithEvents ZodDesc As Label
    Friend WithEvents DescLabel As Label
    Friend WithEvents CareerLabel As Label
    Friend WithEvents ZodCareer As Label
    Friend WithEvents LoveLabel As Label
    Friend WithEvents ZodLove As Label
    Friend WithEvents BackLink As Label
End Class
