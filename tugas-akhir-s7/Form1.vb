Public Class Form1
    Private Const ANIMATE_SPEED As Double = 0.01
    Private Const ANIMATE_BREAKPOINT As Double = 75

    Private ZodiacPanelImage As Bitmap
    Private ZodiacLabel As String
    Private ZodiacDescLabel As String = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Nam, commodi! Distinctio voluptatibus esse laboriosam ipsa quaerat repellat officiis cum assumenda ea consequuntur! Aut cupiditate necessitatibus in illo alias, aliquid blanditiis!"
    Private ZodiacCareerLabel As String = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Nam, commodi! Distinctio voluptatibus esse laboriosam ipsa quaerat repellat officiis cum assumenda ea consequuntur! Aut cupiditate necessitatibus in illo alias, aliquid blanditiis!"
    Private ZodiacLoveLabel As String = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Nam, commodi! Distinctio voluptatibus esse laboriosam ipsa quaerat repellat officiis cum assumenda ea consequuntur! Aut cupiditate necessitatibus in illo alias, aliquid blanditiis!"

    Private Async Function Delay(seconds As Double) As Task
        Await Task.Delay(seconds * 1000)
    End Function

    Private Async Function AnimateLabel(label As Label, targetText As String, Optional speed As Double = ANIMATE_SPEED) As Task
        Dim isBreak As Boolean = False

        For i As Integer = 0 To targetText.Length - 1
            label.Text += targetText(i)

            If i <> 0 AndAlso i Mod ANIMATE_BREAKPOINT = 0 Then isBreak = True
            If isBreak AndAlso String.IsNullOrWhiteSpace(targetText(i)) Then
                label.Text += vbCrLf
                isBreak = False
            End If
            If targetText IsNot " " Then Await Delay(speed)
        Next

        '?? label.Text += vbCrLf 
    End Function

    Private Sub ResetForm()
        'Setter : Enable Menu
        Title.Visible = True
        Subtitle1.Visible = True
        Subtitle2.Visible = True
        DateTimePicker.Visible = True
        Calculate.Visible = True

        LoadingText.Visible = False
        LoadingText.Text = ""

        ZodPanel.Visible = False
        ZodLabel.Visible = False
        ZodLabel.Text = ""

        ZodDesc.Visible = False
        ZodDesc.Text = ""
        DescLabel.Visible = False
        DescLabel.Text = ""

        ZodCareer.Visible = False
        ZodCareer.Text = ""
        CareerLabel.Visible = False
        CareerLabel.Text = ""

        ZodLove.Visible = False
        ZodLove.Text = ""
        LoveLabel.Visible = False
        LoveLabel.Text = ""

        BackLink.Visible = False
        BackLink.Text = ""
    End Sub

    Private Sub FormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetForm()
    End Sub

    Private Async Sub Calculate_Click(sender As Object, e As EventArgs) Handles Calculate.Click
        Dim birthDate As Date = DateTimePicker.Value
        GetZodiacSign(birthDate)

        'Setter : Disable Menu
        Title.Visible = False
        Subtitle1.Visible = False
        Subtitle2.Visible = False
        DateTimePicker.Visible = False
        Calculate.Visible = False

        'Setter : Loading State
        LoadingText.Visible = True
        Await AnimateLabel(LoadingText, "Loading...", 0.25)
        Await Delay(1.75)
        LoadingText.Visible = False

        'Setter : Prediction Page
        ZodPanel.Visible = True
        ZodPanel.BackgroundImage = ZodiacPanelImage

        ZodLabel.Visible = True
        AnimateLabel(ZodLabel, ZodiacLabel, 0.15)

        ZodDesc.Visible = True
        DescLabel.Visible = True
        AnimateLabel(ZodDesc, "- Deskripsi")
        AnimateLabel(DescLabel, ZodiacDescLabel)

        ZodCareer.Visible = True
        CareerLabel.Visible = True
        AnimateLabel(ZodCareer, "- Karir")
        AnimateLabel(CareerLabel, ZodiacCareerLabel)

        ZodLove.Visible = True
        LoveLabel.Visible = True
        AnimateLabel(ZodLove, "- Asmara")
        AnimateLabel(LoveLabel, ZodiacLoveLabel)

        Await Delay(3)
        BackLink.Visible = True
        AnimateLabel(BackLink, "└>  Back To Calculator", 0.075)
    End Sub

    Private Sub GetZodiacSign(birthDate As Date)
        Dim day As Integer = birthDate.Day
        Dim month As Integer = birthDate.Month

        ' TODO : Label per Zodiac (Desc & Career & Love)
        Select Case month
            Case 1
                If day <= 19 Then
                    ZodiacPanelImage = My.Resources.capricron
                    ZodiacLabel = "Capricorn"
                    'ZodiacCareerLabel = "Career Label"
                    'ZodiacLoveLabel = "Love Label"
                Else
                    ZodiacPanelImage = My.Resources.aquarius
                    ZodiacLabel = "Aquarius"
                End If
            Case 2
                If day <= 18 Then
                    ZodiacPanelImage = My.Resources.aquarius
                    ZodiacLabel = "Aquarius"
                Else
                    ZodiacPanelImage = My.Resources.pisces
                    ZodiacLabel = "Pisces"
                End If
            Case 3
                If day <= 20 Then
                    ZodiacPanelImage = My.Resources.aquarius
                    ZodiacLabel = "Pisces"
                Else
                    ZodiacPanelImage = My.Resources.aries
                    ZodiacLabel = "Aries"
                End If
            Case 4
                If day <= 19 Then
                    ZodiacPanelImage = My.Resources.aries
                    ZodiacLabel = "Aries"
                Else
                    ZodiacPanelImage = My.Resources.taurus
                    ZodiacLabel = "Taurus"
                End If
            Case 5
                If day <= 20 Then
                    ZodiacPanelImage = My.Resources.taurus
                    ZodiacLabel = "Taurus"
                Else
                    ZodiacPanelImage = My.Resources.gemini
                    ZodiacLabel = "Gemini"
                End If
            Case 6
                If day <= 20 Then
                    ZodiacPanelImage = My.Resources.gemini
                    ZodiacLabel = "Gemini"
                Else
                    ZodiacPanelImage = My.Resources.cancer
                    ZodiacLabel = "Cancer"
                End If
            Case 7
                If day <= 22 Then
                    ZodiacPanelImage = My.Resources.cancer
                    ZodiacLabel = "Cancer"
                Else
                    ZodiacPanelImage = My.Resources.leo
                    ZodiacLabel = "Leo"
                End If
            Case 8
                If day <= 22 Then
                    ZodiacPanelImage = My.Resources.leo
                    ZodiacLabel = "Leo"
                Else
                    ZodiacPanelImage = My.Resources.virgo
                    ZodiacLabel = "Virgo"
                End If
            Case 9
                If day <= 22 Then
                    ZodiacPanelImage = My.Resources.virgo
                    ZodiacLabel = "Virgo"
                Else
                    ZodiacPanelImage = My.Resources.libra
                    ZodiacLabel = "Libra"
                End If
            Case 10
                If day <= 22 Then
                    ZodiacPanelImage = My.Resources.libra
                    ZodiacLabel = "Libra"
                Else
                    ZodiacPanelImage = My.Resources.scorpio
                    ZodiacLabel = "Scorpio"
                End If
            Case 11
                If day <= 21 Then
                    ZodiacPanelImage = My.Resources.scorpio
                    ZodiacLabel = "Scorpio"
                Else
                    ZodiacPanelImage = My.Resources.sagittarius
                    ZodiacLabel = "Sagittarius"
                End If
            Case 12
                If day <= 21 Then
                    ZodiacPanelImage = My.Resources.sagittarius
                    ZodiacLabel = "Sagittarius"
                Else
                    ZodiacPanelImage = My.Resources.capricron
                    ZodiacLabel = "Capricorn"
                End If
            Case Else
                ZodiacLabel = "Unknown"
        End Select
    End Sub

    Private Sub BackLink_Click(sender As Object, e As EventArgs) Handles BackLink.Click
        ResetForm()
    End Sub
End Class
