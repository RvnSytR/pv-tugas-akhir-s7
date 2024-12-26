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
        Me.BestLoveLabel = New System.Windows.Forms.Label()
        Me.ZodBestLove = New System.Windows.Forms.Label()
        Me.BackLink = New System.Windows.Forms.Label()
        Me.Calculate = New System.Windows.Forms.Label()
        Me.ZodWorstLove = New System.Windows.Forms.Label()
        Me.WorstLoveLabel = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Label()
        Me.HistoryButton = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.Font = New System.Drawing.Font("Century Schoolbook", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Title.Location = New System.Drawing.Point(49, 232)
        Me.Title.Margin = New System.Windows.Forms.Padding(0)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(491, 43)
        Me.Title.TabIndex = 0
        Me.Title.Text = "What Zodiac Sign Am I ?"
        '
        'Subtitle2
        '
        Me.Subtitle2.AutoSize = True
        Me.Subtitle2.BackColor = System.Drawing.Color.Transparent
        Me.Subtitle2.Font = New System.Drawing.Font("Century Schoolbook", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subtitle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Subtitle2.Location = New System.Drawing.Point(111, 300)
        Me.Subtitle2.Margin = New System.Windows.Forms.Padding(0)
        Me.Subtitle2.Name = "Subtitle2"
        Me.Subtitle2.Size = New System.Drawing.Size(363, 25)
        Me.Subtitle2.TabIndex = 9
        Me.Subtitle2.Text = " Here is a how you can check it !"
        '
        'Subtitle1
        '
        Me.Subtitle1.AutoSize = True
        Me.Subtitle1.BackColor = System.Drawing.Color.Transparent
        Me.Subtitle1.Font = New System.Drawing.Font("Century Schoolbook", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subtitle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Subtitle1.Location = New System.Drawing.Point(79, 275)
        Me.Subtitle1.Margin = New System.Windows.Forms.Padding(0)
        Me.Subtitle1.Name = "Subtitle1"
        Me.Subtitle1.Size = New System.Drawing.Size(426, 25)
        Me.Subtitle1.TabIndex = 8
        Me.Subtitle1.Text = "Are you sure about your Zodiac sign ?"
        '
        'LoadingText
        '
        Me.LoadingText.BackColor = System.Drawing.Color.Transparent
        Me.LoadingText.Font = New System.Drawing.Font("Century Schoolbook", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadingText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LoadingText.Location = New System.Drawing.Point(169, 401)
        Me.LoadingText.Name = "LoadingText"
        Me.LoadingText.Size = New System.Drawing.Size(275, 50)
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
        Me.DateTimePicker.Location = New System.Drawing.Point(169, 390)
        Me.DateTimePicker.Margin = New System.Windows.Forms.Padding(0)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(275, 26)
        Me.DateTimePicker.TabIndex = 0
        '
        'ZodPanel
        '
        Me.ZodPanel.BackColor = System.Drawing.Color.Transparent
        Me.ZodPanel.BackgroundImage = Global.tugas_akhir_s7.My.Resources.Resources.sagittarius
        Me.ZodPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ZodPanel.Location = New System.Drawing.Point(206, 21)
        Me.ZodPanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ZodPanel.Name = "ZodPanel"
        Me.ZodPanel.Size = New System.Drawing.Size(184, 258)
        Me.ZodPanel.TabIndex = 12
        '
        'ZodLabel
        '
        Me.ZodLabel.BackColor = System.Drawing.Color.Transparent
        Me.ZodLabel.Font = New System.Drawing.Font("Century Schoolbook", 33.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZodLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ZodLabel.Location = New System.Drawing.Point(48, 281)
        Me.ZodLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.ZodLabel.Name = "ZodLabel"
        Me.ZodLabel.Size = New System.Drawing.Size(496, 60)
        Me.ZodLabel.TabIndex = 11
        Me.ZodLabel.Text = "Sagittarius"
        Me.ZodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ZodDesc
        '
        Me.ZodDesc.AutoSize = True
        Me.ZodDesc.BackColor = System.Drawing.Color.Transparent
        Me.ZodDesc.Font = New System.Drawing.Font("Century Schoolbook", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZodDesc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ZodDesc.Location = New System.Drawing.Point(19, 344)
        Me.ZodDesc.Margin = New System.Windows.Forms.Padding(0)
        Me.ZodDesc.Name = "ZodDesc"
        Me.ZodDesc.Size = New System.Drawing.Size(148, 30)
        Me.ZodDesc.TabIndex = 13
        Me.ZodDesc.Text = "- Deskripsi"
        Me.ZodDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DescLabel
        '
        Me.DescLabel.AutoSize = True
        Me.DescLabel.BackColor = System.Drawing.Color.Transparent
        Me.DescLabel.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DescLabel.Location = New System.Drawing.Point(19, 379)
        Me.DescLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.DescLabel.Name = "DescLabel"
        Me.DescLabel.Size = New System.Drawing.Size(0, 16)
        Me.DescLabel.TabIndex = 14
        '
        'CareerLabel
        '
        Me.CareerLabel.AutoSize = True
        Me.CareerLabel.BackColor = System.Drawing.Color.Transparent
        Me.CareerLabel.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CareerLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CareerLabel.Location = New System.Drawing.Point(19, 525)
        Me.CareerLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.CareerLabel.Name = "CareerLabel"
        Me.CareerLabel.Size = New System.Drawing.Size(0, 16)
        Me.CareerLabel.TabIndex = 16
        '
        'ZodCareer
        '
        Me.ZodCareer.AutoSize = True
        Me.ZodCareer.BackColor = System.Drawing.Color.Transparent
        Me.ZodCareer.Font = New System.Drawing.Font("Century Schoolbook", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZodCareer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ZodCareer.Location = New System.Drawing.Point(19, 490)
        Me.ZodCareer.Margin = New System.Windows.Forms.Padding(0)
        Me.ZodCareer.Name = "ZodCareer"
        Me.ZodCareer.Size = New System.Drawing.Size(96, 30)
        Me.ZodCareer.TabIndex = 15
        Me.ZodCareer.Text = "- Karir"
        Me.ZodCareer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BestLoveLabel
        '
        Me.BestLoveLabel.AutoSize = True
        Me.BestLoveLabel.BackColor = System.Drawing.Color.Transparent
        Me.BestLoveLabel.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BestLoveLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BestLoveLabel.Location = New System.Drawing.Point(19, 667)
        Me.BestLoveLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.BestLoveLabel.Name = "BestLoveLabel"
        Me.BestLoveLabel.Size = New System.Drawing.Size(0, 16)
        Me.BestLoveLabel.TabIndex = 18
        '
        'ZodBestLove
        '
        Me.ZodBestLove.AutoSize = True
        Me.ZodBestLove.BackColor = System.Drawing.Color.Transparent
        Me.ZodBestLove.Font = New System.Drawing.Font("Century Schoolbook", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZodBestLove.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ZodBestLove.Location = New System.Drawing.Point(19, 638)
        Me.ZodBestLove.Margin = New System.Windows.Forms.Padding(0)
        Me.ZodBestLove.Name = "ZodBestLove"
        Me.ZodBestLove.Size = New System.Drawing.Size(148, 23)
        Me.ZodBestLove.TabIndex = 17
        Me.ZodBestLove.Text = "- Best Partner"
        Me.ZodBestLove.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BackLink
        '
        Me.BackLink.BackColor = System.Drawing.Color.Transparent
        Me.BackLink.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BackLink.Font = New System.Drawing.Font("Century Schoolbook", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackLink.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackLink.Location = New System.Drawing.Point(43, 771)
        Me.BackLink.Margin = New System.Windows.Forms.Padding(0)
        Me.BackLink.Name = "BackLink"
        Me.BackLink.Size = New System.Drawing.Size(501, 27)
        Me.BackLink.TabIndex = 19
        Me.BackLink.Text = "Back to Calculator"
        Me.BackLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Calculate
        '
        Me.Calculate.BackColor = System.Drawing.Color.Transparent
        Me.Calculate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Calculate.Font = New System.Drawing.Font("Century Schoolbook", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Calculate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Calculate.Location = New System.Drawing.Point(169, 462)
        Me.Calculate.Name = "Calculate"
        Me.Calculate.Size = New System.Drawing.Size(273, 35)
        Me.Calculate.TabIndex = 20
        Me.Calculate.Text = "Calculate My Sign"
        Me.Calculate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ZodWorstLove
        '
        Me.ZodWorstLove.AutoSize = True
        Me.ZodWorstLove.BackColor = System.Drawing.Color.Transparent
        Me.ZodWorstLove.Font = New System.Drawing.Font("Century Schoolbook", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZodWorstLove.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ZodWorstLove.Location = New System.Drawing.Point(19, 703)
        Me.ZodWorstLove.Margin = New System.Windows.Forms.Padding(0)
        Me.ZodWorstLove.Name = "ZodWorstLove"
        Me.ZodWorstLove.Size = New System.Drawing.Size(163, 23)
        Me.ZodWorstLove.TabIndex = 21
        Me.ZodWorstLove.Text = "- Worst Partner"
        Me.ZodWorstLove.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'WorstLoveLabel
        '
        Me.WorstLoveLabel.AutoSize = True
        Me.WorstLoveLabel.BackColor = System.Drawing.Color.Transparent
        Me.WorstLoveLabel.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorstLoveLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.WorstLoveLabel.Location = New System.Drawing.Point(19, 733)
        Me.WorstLoveLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.WorstLoveLabel.Name = "WorstLoveLabel"
        Me.WorstLoveLabel.Size = New System.Drawing.Size(0, 16)
        Me.WorstLoveLabel.TabIndex = 22
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Transparent
        Me.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExitButton.Font = New System.Drawing.Font("Century Schoolbook", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ExitButton.Location = New System.Drawing.Point(43, 806)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(0)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(501, 27)
        Me.ExitButton.TabIndex = 23
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HistoryButton
        '
        Me.HistoryButton.BackColor = System.Drawing.Color.Transparent
        Me.HistoryButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HistoryButton.Font = New System.Drawing.Font("Century Schoolbook", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HistoryButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.HistoryButton.Location = New System.Drawing.Point(233, 570)
        Me.HistoryButton.Name = "HistoryButton"
        Me.HistoryButton.Size = New System.Drawing.Size(135, 35)
        Me.HistoryButton.TabIndex = 24
        Me.HistoryButton.Text = "History"
        Me.HistoryButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Font = New System.Drawing.Font("Century Schoolbook", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnExit.Location = New System.Drawing.Point(233, 615)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(135, 35)
        Me.btnExit.TabIndex = 25
        Me.btnExit.Text = "Exit"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackgroundImage = Global.tugas_akhir_s7.My.Resources.Resources.bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(584, 861)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.HistoryButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.BackLink)
        Me.Controls.Add(Me.WorstLoveLabel)
        Me.Controls.Add(Me.ZodWorstLove)
        Me.Controls.Add(Me.Calculate)
        Me.Controls.Add(Me.BestLoveLabel)
        Me.Controls.Add(Me.ZodBestLove)
        Me.Controls.Add(Me.CareerLabel)
        Me.Controls.Add(Me.ZodCareer)
        Me.Controls.Add(Me.DescLabel)
        Me.Controls.Add(Me.ZodDesc)
        Me.Controls.Add(Me.DateTimePicker)
        Me.Controls.Add(Me.LoadingText)
        Me.Controls.Add(Me.Subtitle2)
        Me.Controls.Add(Me.Subtitle1)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.ZodLabel)
        Me.Controls.Add(Me.ZodPanel)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Inter", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(600, 900)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(600, 900)
        Me.Name = "Form1"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "What Zodiac Sign Am I?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Title As Label
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
    Friend WithEvents BestLoveLabel As Label
    Friend WithEvents ZodBestLove As Label
    Friend WithEvents Calculate As Label
    Friend WithEvents ZodWorstLove As Label
    Friend WithEvents WorstLoveLabel As Label
    Friend WithEvents ExitButton As Label
    Private WithEvents BackLink As Label
    Friend WithEvents HistoryButton As Label
    Friend WithEvents btnExit As Label
End Class
