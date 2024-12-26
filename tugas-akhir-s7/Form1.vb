Imports System.Data.SqlClient

Public Class Form1
    Dim connection As New SqlConnection("Server=RVNS\SQLEXPRESS;Database=db_latihan;Integrated Security=True;")

    Private Const ANIMATE_SPEED As Double = 0.01
    Private Const ANIMATE_BREAKPOINT As Double = 72
    Private BACKGROUND As Bitmap = My.Resources.bg

    Private ZodiacPanelImage As Bitmap
    Private ZodiacBackground As Bitmap
    Private ZodiacLabel As String
    Private ZodiacDescLabel As String = ""
    Private ZodiacCareerLabel As String = ""
    Private ZodiacBestPartLabel As String = ""
    Private ZodiacWorstPartLabel As String = ""

    Private Function InsertHistory()
        Try
            connection.Open()
            Dim query As String = "INSERT INTO history (tgl_lahir, zodiac) VALUES (@tgl_lahir, @zodiac);"
            Dim cmd As New SqlCommand(query, connection)

            cmd.Parameters.AddWithValue("@tgl_lahir", DateTimePicker.Value)
            cmd.Parameters.AddWithValue("@zodiac", ZodiacLabel)

            cmd.ExecuteNonQuery()
            connection.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            If connection.State = ConnectionState.Open Then connection.Close()
            Return False
        End Try
    End Function

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
    End Function

    Private Sub ResetForm()
        Me.BackgroundImage = BACKGROUND

        Title.Visible = True
        Subtitle1.Visible = True
        Subtitle2.Visible = True
        DateTimePicker.Visible = True
        Calculate.Visible = True
        HistoryButton.Visible = True
        btnExit.Visible = True

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

        ZodBestLove.Visible = False
        ZodBestLove.Text = ""
        BestLoveLabel.Visible = False
        BestLoveLabel.Text = ""

        ZodWorstLove.Visible = False
        ZodWorstLove.Text = ""
        WorstLoveLabel.Visible = False
        WorstLoveLabel.Text = ""

        BackLink.Visible = False
        BackLink.Text = ""
        ExitButton.Visible = False
        ExitButton.Text = ""
    End Sub

    Private Sub FormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetForm()
    End Sub

    Private Async Sub Calculate_Click(sender As Object, e As EventArgs) Handles Calculate.Click
        Dim birthDate As Date = DateTimePicker.Value
        GetZodiacSign(birthDate)
        InsertHistory()

        Title.Visible = False
        Subtitle1.Visible = False
        Subtitle2.Visible = False
        DateTimePicker.Visible = False
        Calculate.Visible = False
        HistoryButton.Visible = False
        btnExit.Visible = False

        LoadingText.Visible = True
        Await AnimateLabel(LoadingText, "Loading...", 0.25)
        Await Delay(1.25)
        LoadingText.Visible = False

        ZodPanel.Visible = True
        Me.BackgroundImage = ZodiacBackground
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

        ZodBestLove.Visible = True
        BestLoveLabel.Visible = True
        AnimateLabel(ZodBestLove, "- Best Partner", 0.1)
        AnimateLabel(BestLoveLabel, ZodiacBestPartLabel, 0.075)

        ZodWorstLove.Visible = True
        WorstLoveLabel.Visible = True
        AnimateLabel(ZodWorstLove, "- Worst Partner", 0.1)
        AnimateLabel(WorstLoveLabel, ZodiacWorstPartLabel, 0.075)

        Await Delay(3)

        BackLink.Visible = True
        AnimateLabel(BackLink, "Back To Calculator", 0.075)

        ExitButton.Visible = True
        AnimateLabel(ExitButton, "Exit", 0.1)
    End Sub

    Private Sub GetZodiacSign(birthDate As Date)
        Dim day As Integer = birthDate.Day
        Dim month As Integer = birthDate.Month

        Select Case month
            Case 1
                If day <= 19 Then
                    ZodiacBackground = My.Resources.bg_capricron
                    ZodiacPanelImage = My.Resources.capricron
                    ZodiacLabel = "Capricorn"
                    ZodiacBestPartLabel = "Taurus, Virgo, Pisces"
                    ZodiacWorstPartLabel = "Gemini, Leo"
                    SetZodiacLabel("capricorn")
                Else
                    ZodiacBackground = My.Resources.bg_aquarius
                    ZodiacPanelImage = My.Resources.aquarius
                    ZodiacLabel = "Aquarius"
                    ZodiacBestPartLabel = "Aries, Gemini, Sagittarius"
                    ZodiacWorstPartLabel = "Taurus, Cancer"
                    SetZodiacLabel("aquarius")
                End If
            Case 2
                If day <= 18 Then
                    ZodiacBackground = My.Resources.bg_aquarius
                    ZodiacPanelImage = My.Resources.aquarius
                    ZodiacLabel = "Aquarius"
                    ZodiacBestPartLabel = "Aries, Gemini, Sagittarius"
                    ZodiacWorstPartLabel = "Taurus, Cancer"
                    SetZodiacLabel("aquarius")
                Else
                    ZodiacBackground = My.Resources.bg_pisces
                    ZodiacPanelImage = My.Resources.pisces
                    ZodiacLabel = "Pisces"
                    ZodiacBestPartLabel = "Cancer, Scorpio, Capricorn"
                    ZodiacWorstPartLabel = "Gemini, Aquarius"
                    SetZodiacLabel("pisces")
                End If
            Case 3
                If day <= 20 Then
                    ZodiacBackground = My.Resources.bg_pisces
                    ZodiacPanelImage = My.Resources.aquarius
                    ZodiacLabel = "Pisces"
                    ZodiacBestPartLabel = "Cancer, Scorpio, Capricorn"
                    ZodiacWorstPartLabel = "Gemini, Aquarius"
                    SetZodiacLabel("pisces")
                Else
                    ZodiacBackground = My.Resources.bg_aries
                    ZodiacPanelImage = My.Resources.aries
                    ZodiacLabel = "Aries"
                    ZodiacBestPartLabel = "Leo, Sagitarius, Aquarius"
                    ZodiacWorstPartLabel = "Capricorn, Scorpio"
                    SetZodiacLabel("aries")
                End If
            Case 4
                If day <= 19 Then
                    ZodiacBackground = My.Resources.bg_aries
                    ZodiacPanelImage = My.Resources.aries
                    ZodiacLabel = "Aries"
                    ZodiacBestPartLabel = "Leo, Sagitarius, Aquarius"
                    ZodiacWorstPartLabel = "Capricorn, Scorpio"
                    SetZodiacLabel("aries")
                Else
                    ZodiacBackground = My.Resources.bg_taurus
                    ZodiacPanelImage = My.Resources.taurus
                    ZodiacLabel = "Taurus"
                    ZodiacBestPartLabel = "Virgo, Cancer, Scorpio"
                    ZodiacWorstPartLabel = "Aries, Aquarius"
                    SetZodiacLabel("taurus")
                End If
            Case 5
                If day <= 20 Then
                    ZodiacBackground = My.Resources.bg_taurus
                    ZodiacPanelImage = My.Resources.taurus
                    ZodiacLabel = "Taurus"
                    ZodiacBestPartLabel = "Virgo, Cancer, Scorpio"
                    ZodiacWorstPartLabel = "Aries, Aquarius"
                    SetZodiacLabel("taurus")
                Else
                    ZodiacBackground = My.Resources.bg_gemini
                    ZodiacPanelImage = My.Resources.gemini
                    ZodiacLabel = "Gemini"
                    ZodiacBestPartLabel = "Libra, Aries, Leo"
                    ZodiacWorstPartLabel = "Cancer, Scorpio"
                    SetZodiacLabel("gemini")
                End If
            Case 6
                If day <= 20 Then
                    ZodiacBackground = My.Resources.bg_gemini
                    ZodiacPanelImage = My.Resources.gemini
                    ZodiacLabel = "Gemini"
                    ZodiacBestPartLabel = "Libra, Aries, Leo"
                    ZodiacWorstPartLabel = "Cancer, Scorpio"
                    SetZodiacLabel("gemini")
                Else
                    ZodiacBackground = My.Resources.bg_cancer
                    ZodiacPanelImage = My.Resources.cancer
                    ZodiacLabel = "Cancer"
                    ZodiacBestPartLabel = "Pisces, Virgo, Taurus"
                    ZodiacWorstPartLabel = "Aries, Leo"
                    SetZodiacLabel("cancer")
                End If
            Case 7
                If day <= 22 Then
                    ZodiacBackground = My.Resources.bg_cancer
                    ZodiacPanelImage = My.Resources.cancer
                    ZodiacLabel = "Cancer"
                    ZodiacBestPartLabel = "Pisces, Virgo, Taurus"
                    ZodiacWorstPartLabel = "Aries, Leo"
                    SetZodiacLabel("cancer")
                Else
                    ZodiacBackground = My.Resources.bg_leo
                    ZodiacPanelImage = My.Resources.leo
                    ZodiacLabel = "Leo"
                    ZodiacBestPartLabel = "Aries, Libra, Sagitarius"
                    ZodiacWorstPartLabel = "Pisces, Scorpio"
                    SetZodiacLabel("leo")
                End If
            Case 8
                If day <= 22 Then
                    ZodiacBackground = My.Resources.bg_leo
                    ZodiacPanelImage = My.Resources.leo
                    ZodiacLabel = "Leo"
                    ZodiacBestPartLabel = "Aries, Libra, Sagitarius"
                    ZodiacWorstPartLabel = "Pisces, Scorpio"
                    SetZodiacLabel("leo")
                Else
                    ZodiacBackground = My.Resources.bg_virgo
                    ZodiacPanelImage = My.Resources.virgo
                    ZodiacLabel = "Virgo"
                    ZodiacBestPartLabel = "Scorpio, Taurus, Capricorn"
                    ZodiacWorstPartLabel = "Libra, Leo"
                    SetZodiacLabel("virgo")
                End If
            Case 9
                If day <= 22 Then
                    ZodiacBackground = My.Resources.bg_virgo
                    ZodiacPanelImage = My.Resources.virgo
                    ZodiacLabel = "Virgo"
                    ZodiacBestPartLabel = "Scorpio, Taurus, Capricorn"
                    ZodiacWorstPartLabel = "Libra, Leo"
                    SetZodiacLabel("virgo")
                Else
                    ZodiacBackground = My.Resources.bg_libra
                    ZodiacPanelImage = My.Resources.libra
                    ZodiacLabel = "Libra"
                    ZodiacBestPartLabel = "Aquarius, Gemini, Leo"
                    ZodiacWorstPartLabel = "Scorpio, Capricorn"
                    SetZodiacLabel("libra")
                End If
            Case 10
                If day <= 22 Then
                    ZodiacBackground = My.Resources.bg_libra
                    ZodiacPanelImage = My.Resources.libra
                    ZodiacLabel = "Libra"
                    ZodiacBestPartLabel = "Aquarius, Gemini, Leo"
                    ZodiacWorstPartLabel = "Scorpio, Capricorn"
                    SetZodiacLabel("libra")
                Else
                    ZodiacBackground = My.Resources.bg_scorpio
                    ZodiacPanelImage = My.Resources.scorpio
                    ZodiacLabel = "Scorpio"
                    ZodiacBestPartLabel = "Capricorn, Pisces, Virgo"
                    ZodiacWorstPartLabel = "Sagittarius, Gemini"
                    SetZodiacLabel("scorpio")
                End If
            Case 11
                If day <= 21 Then
                    ZodiacBackground = My.Resources.bg_scorpio
                    ZodiacPanelImage = My.Resources.scorpio
                    ZodiacLabel = "Scorpio"
                    ZodiacBestPartLabel = "Capricorn, Pisces, Virgo"
                    ZodiacWorstPartLabel = "Sagittarius, Gemini"
                    SetZodiacLabel("scorpio")
                Else
                    ZodiacBackground = My.Resources.bg_sagittarius
                    ZodiacPanelImage = My.Resources.sagittarius
                    ZodiacLabel = "Sagittarius"
                    ZodiacBestPartLabel = "Aquarius, Aries, Leo"
                    ZodiacWorstPartLabel = "Taurus, Virgo"
                    SetZodiacLabel("sagittarius")
                End If
            Case 12
                If day <= 21 Then
                    ZodiacBackground = My.Resources.bg_sagittarius
                    ZodiacPanelImage = My.Resources.sagittarius
                    ZodiacLabel = "Sagittarius"
                    ZodiacBestPartLabel = "Aquarius, Aries, Leo"
                    ZodiacWorstPartLabel = "Taurus, Virgo"
                    SetZodiacLabel("sagittarius")
                Else
                    ZodiacBackground = My.Resources.bg_capricron
                    ZodiacPanelImage = My.Resources.capricron
                    ZodiacLabel = "Capricorn"
                    ZodiacBestPartLabel = "Taurus, Virgo, Pisces"
                    ZodiacWorstPartLabel = "Gemini, Leo"
                    SetZodiacLabel("capricorn")
                End If
            Case Else
                ZodiacLabel = "Unknown"
        End Select
    End Sub

    Private Sub SetZodiacLabel(zod As String)
        Select Case zod
            Case "aquarius"
                ZodiacDescLabel = "Aquarius dikenal sebagai pribadi yang terkadang tampak acuh tak acuh, tetapi sebenarnya mereka suka bersosialisasi dalam kelompok besar. Mereka memiliki selera humor yang khas serta pengetahuan luas tentang berbagai hal menarik. Meski mudah terprovokasi, mereka akan berusaha keras untuk membuktikan jika suatu teori salah menurut pandangan mereka. Mereka pada dasarnya lebih tertarik pada ilmu pengetahuan dibandingkan melihatkan emosi."
                ZodiacCareerLabel = "Aquarius cocok bekerja di bidang yang memberi mereka kebebasan dalam berekspresi. Mereka menyukai pekerjaan yang mendorong mereka untuk mempelajari hal-hal baru, seperti aktor, desainer, analis data, pemrogram, dan ilmuwan."

            Case "pisces"
                ZodiacDescLabel = "Pisces terkenal sebagai sosok yang mudah berempati dengan hati yang peka. Mereka memiliki karakter sensitif dan perhatian yang tulus terhadap orang lain. Pisces cenderung berimajinasi, memikirkan mimpi, romansa, dan keindahan. Mereka bisa beradaptasi dengan mudah sesuai dengan orang di sekitar mereka, karena secara alami pisces tidak ingin dibenci."
                ZodiacCareerLabel = "Dengan intuisi emosional dan kebijaksanaan mereka, Pisces cocok dalam pekerjaan yang membutuhkan kesabaran, seperti terapis, konselor, perawat, pengasuh, dan musisi."

            Case "aries"
                ZodiacDescLabel = "Orang berzodiak Aries terkenal ambisius dan kompetitif. Mereka memiliki keinginan besar untuk sukses dan selalu berusaha menjadi yang terbaik. Aries tidak suka kalah dan akan berjuang keras untuk mencapai apa yang mereka inginkan. Mereka suka bergaul dan akan menjadi pendorong dalam suasana apapun."
                ZodiacCareerLabel = "Aries cocok dalam pekerjaan yang membutuhkan kepemimpinan yang kuat, seperti politisi, pengacara, pengusaha, produser, dan atlet."

            Case "taurus"
                ZodiacDescLabel = "Taurus menyukai rutinitas dan ketenangan. Mereka berusaha menjaga suasana damai dengan menghindari konfrontasi. Taurus bisa menjadi keras kepala, tetapi mereka juga pendengar yang baik dan dapat diandalkan. Mereka berhati-hati dan berpikir dengan matang sebelum bertindak, sehingga taurus tidak sering gagal dalam pekerjaan."
                ZodiacCareerLabel = "Dengan sifat yang gigih dan jujur, Taurus cocok dalam bidang seperti perbankan, teknik, manajemen proyek, koki, dan arsitektur."

            Case "gemini"
                ZodiacDescLabel = "Gemini dikenal cerdas dan cepat memahami berbagai hal. Mereka memiliki rasa ingin tahu yang tinggi dan mudah beradaptasi dalam lingkungan baru. Gemini dapat menyesuaikan diri dengan situasi yang ada dan mudah memenangkan hati orang lain, membuat mereka menjadi sosok yang dikenal banyak orang."
                ZodiacCareerLabel = "Gemini cocok dalam pekerjaan yang dinamis dan kreatif seperti guru, jurnalis, manajer media sosial, periklanan, dan penyiar."

            Case "cancer"
                ZodiacDescLabel = "Cancer dikenal sebagai pribadi yang penuh perhatian dan penyayang. Mereka akan selalu merawat orang di sekitar mereka, meskipun sulit untuk berbagi mengenai perasaan mereka sendiri. Cancer berusaha menyembunyikan kesedihannya agar tidak membebani orang lain."
                ZodiacCareerLabel = "Cancer cocok dalam pekerjaan yang membutuhkan tanggung jawab dan estetika, seperti desainer interior, penulis, editor buku, konselor, dan manajer konten."

            Case "leo"
                ZodiacDescLabel = "Leo terlahir sebagai pemimpin yang suka menonjol dan memimpin. Dengan kepercayaan diri tinggi, Leo memiliki kepribadian yang bersemangat dan sering mengambil keputusan berdasarkan insting. Mereka menyukai perhatian dan pujian, yang mendorong ambisi mereka."
                ZodiacCareerLabel = "Leo cocok dalam peran kepemimpinan, terutama yang memberi mereka apresiasi, seperti pemasar, perencana acara, motivator, aktor, dan pengusaha."

            Case "virgo"
                ZodiacDescLabel = "Virgo dikenal sebagai sosok perfeksionis dengan perhatian terhadap detail. Mereka suka berada di lingkungan yang teratur dan rela membantu orang lain. Virgo jarang menonjolkan diri dan cukup rendah hati, tetapi mereka tetap ingin diakui atas kontribusinya."
                ZodiacCareerLabel = "Virgo dikenal sebagai sosok perfeksionis dengan perhatian terhadap detail. Mereka suka berada di lingkungan yang teratur dan rela membantu orang lain. Virgo jarang menonjolkan diri dan cukup rendah hati, tetapi mereka tetap ingin diakui atas kontribusinya."

            Case "libra"
                ZodiacDescLabel = "Libra bisa menyesuaikan diri dengan orang yang mereka hadapi dan sering bertindak sebagai penengah dalam konflik. Mereka memiliki keterampilan sosial yang baik, membuat mereka mudah berteman dengan siapa saja."
                ZodiacCareerLabel = "Libra cocok dalam pekerjaan yang melibatkan energi positif dan kemampuan membuat keputusan seperti diplomat, negosiator, manajer SDM, advokat hak asasi manusia, dan hakim."

            Case "scorpio"
                ZodiacDescLabel = "Dengan intuisi tajam, Scorpio bisa membedakan kebenaran dan kepalsuan dengan mudah. Mereka lebih suka mencari fakta dari orang lain daripada menceritakan kisah mereka sendiri. Scorpio cenderung introspektif dan berhati-hati, kadang membuat mereka tampak lebih pendiam."
                ZodiacCareerLabel = "Scorpio cocok dalam pekerjaan yang membutuhkan kecerdasan dan rasa ingin tahu seperti detektif, apoteker, psikolog, astronom, dan analis pemasaran."

            Case "sagittarius"
                ZodiacDescLabel = "Memiliki kepribadian yang mudah jenuh, sagittarius sangat menyukai tantangan. Mereka akan mengambil kesempatan dan menantang diri untuk melakukan hal-hal baru yang belum pernah mereka lakukan sebelumnya. Mereka senang menjelajahi hal-hal yang tidak diketahui untuk memahami bagaimana dunia bekerja. Sagittarius juga memiliki selera humor yang tinggi, dan menyukai suasana yang ceria dan hidup."
                ZodiacCareerLabel = "Sagitarius adalah orang yang suka bersenang-senang, ramah, ceria, dan dermawan. Mereka bekerja dengan baik dalam peran yang kreatif dan dinamis yang membutuhkan tugas yang berbeda dari hari ke hari, dan juga pekerjaan dengan peran yang membutuhkan berbicara di depan umum."

            Case "capricorn"
                ZodiacDescLabel = "Capricorn terkenal sebagai seorang work-holic. Meskipun bukan pribadi yang dapat memiliki banyak keahlian, seorang Capricorn dapat berkonsentrasi penuh pada bidang yang mereka kuasai. Dengan rasa tanggung jawab yang tinggi, mereka akan berusaha sebisa mungkin mencapai hasil yang sempurna dalam bidang keahlian mereka."
                ZodiacCareerLabel = "Capricorn sangat cocok untuk pekerjaan yang membutuhkan seseorang yang praktis dan memiliki kemampuan untuk mendeskripsikan tugas dengan baik. Meskipun begitu mereka juga terkenal dengan sifat mereka yang tegas dan keras kepala. Oleh karena itu, karir yang cocok untuk mereka adalah sekretaris, ahli matematika, manajer, akuntan dan bankir."

        End Select
    End Sub

    Private Sub BackLink_Click(sender As Object, e As EventArgs) Handles BackLink.Click
        ResetForm()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Application.Exit()
    End Sub

    Private Sub HistoryButton_Click(sender As Object, e As EventArgs) Handles HistoryButton.Click
        Dim form2 As New Form2()
        form2.Show()
        Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
