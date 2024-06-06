Imports System.Runtime.InteropServices
Imports System.IO

Public Class ibrahimcelik

    'Reedited & updated for 64 bit by software developer IBRAHIM CELIK
    'YouTube: @devibrahimcelik | : https://www.youtube.com/@devibrahimcelik
    'Github: https://github.com/SoftwareDEVibrahimcelik
    'Donation : https://www.patreon.com/devibrahimcelik
    'Instagram: @softwaredevic
    'Steam: https://store.steampowered.com/app/2967830/
    'Donate Bitcoin Address: 3H2iUqWmQ2RGTYDjJwceVeEFT8XMTafjrk


    Private Declare Function SetCursorPos Lib "user32" Alias "SetCursorPos" (ByVal x As Long, ByVal y As Long) As Long
    Private Declare Sub mouse_event Lib "user32" (ByVal dwFlags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cButtons As Integer, ByVal dwExtraInfo As Integer)
    Const MOUSEEVENTF_LEFTDOWN = &H2
    Const MOUSEEVENTF_LEFTUP = &H4
    Const MOUSEEVENTF_RIGHTDOWN = &H6
    Const MOUSEEVENTF_RIGHTUP = &H8

    <DllImport("user32.dll")>
    Public Shared Function GetAsyncKeyState(ByVal vKey As System.Windows.Forms.Keys) As Short
    End Function


    Private Sub birincipage_Click(sender As Object, e As EventArgs) Handles birincipage.Click
        ibrahimcelik8696.SelectedIndex = 0
    End Sub

    Private Sub ikincipage_Click(sender As Object, e As EventArgs) Handles ikincipage.Click
        ibrahimcelik8696.SelectedIndex = 1
    End Sub

    Private Sub ucuncupage_Click(sender As Object, e As EventArgs) Handles ucuncupage.Click
        ibrahimcelik8696.SelectedIndex = 2
    End Sub

    Private Sub dorduncupage_Click(sender As Object, e As EventArgs) Handles dorduncupage.Click
        ibrahimcelik8696.SelectedIndex = 3
    End Sub


    Private Sub ibrahimcelik_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        On Error Resume Next
        Dim dosya As String = "softwaredevic.txt"
        Dim yolu As String = System.IO.Path.Combine(My.Application.Info.DirectoryPath, dosya)

        If System.IO.File.Exists(yolu) Then
            Dim lines() As String = System.IO.File.ReadAllLines(yolu)
            starttusu.Text = lines(0)
            stoptusu.Text = lines(1)
        Else


        End If
        '



        Dim dosya2 As String = "Function1.txt"
        Dim yolu2 As String = System.IO.Path.Combine(My.Application.Info.DirectoryPath, dosya2)

        If System.IO.File.Exists(yolu2) Then
            Dim lines() As String = System.IO.File.ReadAllLines(yolu2)
            clickturu.Text = lines(0)
            spamayari.Text = lines(1)
            TextBox1.Text = lines(2)
            xkordinat.Text = lines(3)
            ykordinat.Text = lines(4)
        Else

            MsgBox("Functions Doesnt found")
        End If

        Dim dosya3 As String = "Function2.txt"
        Dim yolu3 As String = System.IO.Path.Combine(My.Application.Info.DirectoryPath, dosya3)

        If System.IO.File.Exists(yolu2) Then
            Dim lines() As String = System.IO.File.ReadAllLines(yolu2)
            clickturu.Text = lines(0)
            spamayari.Text = lines(1)
            TextBox1.Text = lines(2)
            xkordinat.Text = lines(3)
            ykordinat.Text = lines(4)
        Else

            MsgBox("Functions doesnt found")
        End If

        '

        '

        Bildirim.BalloonTipTitle = "IBRAHIM CELIK"
        Bildirim.BalloonTipText = "Welcome to Auto Clicker "
        Bildirim.ShowBalloonTip(1000)

    End Sub

    Public Sub soltus()
        mouse_event(&H2, 0, 0, 0, 0)
        mouse_event(&H4, 0, 0, 0, 0)
    End Sub


    Public Sub sagtus()
        mouse_event(&H6, 0, 0, 0, 0)
        mouse_event(&H8, 0, 0, 0, 0)
    End Sub

    '''

    '''

    Private Sub ibrahim_celik53_Tick(sender As Object, e As EventArgs) Handles ibrahim_celik53.Tick
        On Error Resume Next
        Me.kordinatxy.Text = Control.MousePosition.ToString()
    End Sub

    Private Sub keyikaydetme_Click(sender As Object, e As EventArgs) Handles keyikaydetme.Click
        On Error Resume Next
        Dim lines2() As String = {starttusu.Text, stoptusu.Text}
        Dim fileName As String = "softwaredevic.txt"
        Dim filePath As String = System.IO.Path.Combine(Application.StartupPath, fileName)
        System.IO.File.WriteAllLines(filePath, lines2)


        ibrahimcelik8696.SelectedTab = TabPage2
    End Sub

    Private Sub fonksiyonkaydetme_Click(sender As Object, e As EventArgs) Handles fonksiyonkaydetme.Click
        On Error Resume Next
        If RadioButton15.Checked = True Then
            Dim lines2() As String = {clickturu.Text, spamayari.Text, TextBox1.Text, xkordinat.Text, ykordinat.Text}
            Dim fileName As String = "Function1.txt"
            Dim filePath As String = System.IO.Path.Combine(Application.StartupPath, fileName)
            System.IO.File.WriteAllLines(filePath, lines2)
        End If

        If RadioButton16.Checked = True Then
            Dim lines2() As String = {clickturu.Text, spamayari.Text, TextBox1.Text, xkordinat.Text, ykordinat.Text}
            Dim fileName As String = "Function2.txt"
            Dim filePath As String = System.IO.Path.Combine(Application.StartupPath, fileName)
            System.IO.File.WriteAllLines(filePath, lines2)
        End If


        'sonradanekledim
        ibrahimcelik8696.SelectedTab = TabPage3


        '

        ' UnlockAchievement("SAVED_SPAM_SETTINGS")


    End Sub


    Private Sub ibrahimcelik8696_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ibrahimcelik8696.SelectedIndexChanged
        On Error Resume Next
        Dim dosya2 As String = "Function1.txt"
        Dim yolu2 As String = System.IO.Path.Combine(My.Application.Info.DirectoryPath, dosya2)

        If System.IO.File.Exists(yolu2) Then
            Dim lines() As String = System.IO.File.ReadAllLines(yolu2)
            Label10.Text = lines(0)
            Label11.Text = lines(1)
            Label12.Text = lines(2)
            Label13.Text = lines(3)
            Label14.Text = lines(4)
        Else
        End If
        '
        Dim dosya3 As String = "Function2.txt"
        Dim yolu3 As String = System.IO.Path.Combine(My.Application.Info.DirectoryPath, dosya3)

        If System.IO.File.Exists(yolu3) Then
            Dim lines2() As String = System.IO.File.ReadAllLines(yolu3)
            Label15.Text = lines2(0)
            Label16.Text = lines2(1)
            Label17.Text = lines2(2)
            Label18.Text = lines2(3)
            Label19.Text = lines2(4)
        Else
        End If
    End Sub

    Private Sub switch1_Click(sender As Object, e As EventArgs) Handles switch1.Click
        If switch1.Checked = True Then
            Label20.Text = "Enabled"
            Label20.ForeColor = Color.Lime
        End If

        If switch1.Checked = False Then
            Label20.Text = "Disabled"
            Label20.ForeColor = Color.Red
        End If

    End Sub


    Private Sub switch2_Click(sender As Object, e As EventArgs) Handles switch2.Click
        If switch2.Checked = True Then
            Label21.Text = "Enabled"
            Label21.ForeColor = Color.Lime
        End If

        If switch2.Checked = False Then
            Label21.Text = "Disabled"
            Label21.ForeColor = Color.Red
        End If
    End Sub

    Private Sub kontrol_Tick(sender As Object, e As EventArgs) Handles kontrol.Tick
        On Error Resume Next
        Dim anahtarStr As String = starttusu.Text
        Dim anahtarConverter As New KeysConverter()
        Dim anahtar As Keys
        anahtar = CType(anahtarConverter.ConvertFromString(anahtarStr), Keys)

        Dim anahtarStr2 As String = stoptusu.Text
        Dim anahtarConverter2 As New KeysConverter()
        Dim anahtar2 As Keys
        anahtar2 = CType(anahtarConverter2.ConvertFromString(anahtarStr2), Keys)




        If GetAsyncKeyState(anahtar) And switch1.Checked = True Then
            function1icin.Interval = Label12.Text
            function1icin.Start()
        End If

        If GetAsyncKeyState(anahtar2) And switch1.Checked = True Then
            function1icin.Interval = Label12.Text
            function1icin.Stop()
        End If



        If GetAsyncKeyState(anahtar) And switch2.Checked = True Then
            function2icin.Interval = Label17.Text
            function2icin.Start()
        End If

        If GetAsyncKeyState(anahtar2) And switch2.Checked = True Then
            function2icin.Interval = Label17.Text
            function2icin.Stop()
        End If


    End Sub

    Private Sub Function1icin_Tick(sender As Object, e As EventArgs) Handles function1icin.Tick
        If Label11.Text = "1 Time" Then

            Me.SendToBack()
            Windows.Forms.Cursor.Position = New Point(Label13.Text, Label14.Text)

            If clickturu.Text = "Left Click" Then
                soltus()
                function1icin.Stop()
            End If

            If clickturu.Text = "Right Click" Then
                sagtus()
                function1icin.Stop()
            End If
        End If


        If Label11.Text = "Spam Click" Then

            Me.SendToBack()
            Windows.Forms.Cursor.Position = New Point(Label13.Text, Label14.Text)

            If clickturu.Text = "Left Click" Then
                soltus()
            End If

            If clickturu.Text = "Right Click" Then
                sagtus()
            End If
        End If





    End Sub

    Private Sub Function2icin_Tick(sender As Object, e As EventArgs) Handles function2icin.Tick

        If Label16.Text = "1 Time" Then

            Me.SendToBack()
            Windows.Forms.Cursor.Position = New Point(Label18.Text, Label19.Text)

            If clickturu.Text = "Left Click" Then
                soltus()
                function2icin.Stop()
            End If

            If clickturu.Text = "Right Click" Then
                sagtus()
                function2icin.Stop()
            End If
        End If


        If Label16.Text = "Spam Click" Then

            Me.SendToBack()
            Windows.Forms.Cursor.Position = New Point(Label18.Text, Label19.Text)

            If clickturu.Text = "Left Click" Then
                soltus()
            End If

            If clickturu.Text = "Right Click" Then
                sagtus()
            End If
        End If

    End Sub

    Private Sub spamayari_SelectedIndexChanged(sender As Object, e As EventArgs) Handles spamayari.SelectedIndexChanged
        If spamayari.Text = "Spam Click" Then
            TextBox1.Text = 1
        End If
    End Sub




    Private Sub switch1_CheckedChanged(sender As Object, e As EventArgs) Handles switch1.CheckedChanged
        On Error Resume Next
    End Sub

    Private Sub ControlBox1_Click(sender As Object, e As EventArgs) Handles ControlBox1.Click
        Me.Close()
    End Sub

    Private Sub ControlBox4_Click(sender As Object, e As EventArgs) Handles ControlBox4.Click
        Me.Close()
    End Sub

    Private Sub ControlBox2_Click(sender As Object, e As EventArgs) Handles ControlBox2.Click
        Me.Close()
    End Sub

    Private Sub ControlBox3_Click(sender As Object, e As EventArgs) Handles ControlBox3.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("https://www.patreon.com/devibrahimcelik")
        MsgBox("Software Developer IBRAHIM CELIK" & vbCrLf & "Click OK button for go to YouTube Link")
        System.Diagnostics.Process.Start("https://www.youtube.com/@devibrahimcelik/")
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        System.Diagnostics.Process.Start("https://www.youtube.com/@devibrahimcelik/")
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        System.Diagnostics.Process.Start("https://www.patreon.com/devibrahimcelik")
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        System.Diagnostics.Process.Start("https://store.steampowered.com/app/2967830/")
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        System.Diagnostics.Process.Start("https://github.com/SoftwareDEVibrahimcelik")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Clipboard.SetDataObject("3H2iUqWmQ2RGTYDjJwceVeEFT8XMTafjrk")
        MsgBox("You copied bitcoin donation address" & vbCrLf & "                       IBRAHIM CELIK" & vbCrLf & "3H2iUqWmQ2RGTYDjJwceVeEFT8XMTafjrk")
    End Sub
End Class