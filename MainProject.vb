Imports System.IO
Imports System.IO.Compression
Imports System.Net
Imports System.Text
Imports Delimon.Win32.IO

Public Class MainProject

    Private Sub TutorialsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TutorialsToolStripMenuItem.Click
        Tutorials.Show()
    End Sub
    Private Sub InfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfoToolStripMenuItem.Click
        Info2.Show()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Settings.Show()
    End Sub

    Private Sub MainProject_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        Dim userRoot As String = Environment.GetEnvironmentVariable("USERPROFILE")
        Dim Client As New WebClient
        Dim vFile = Application.StartupPath + "\Data\version.ini"
        Dim sFile = Application.StartupPath + "\settings.ini"
        Dim ChkUpdate As String = ReadIni(sFile, "USKESettings", "CheckUpdate", "")
        Dim FileInfo As String = ReadIni(vFile, "Version", "version", "")

        Try
            '중복 실행 방지
            If UBound(Process.GetProcessesByName(Process.GetCurrentProcess.ProcessName)) > 0 Then '만약 중복실행이 되고 있다면
                MsgBox("UniSkin Editor is Already Running :(" & vbNewLine & "Try Restart UniSkin Editor!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, Me.Text) '중복실행 메시지박스 표시
                End
            End If

            'Data 파일 존재, 확인 하지 않을경우 엄청난 문제 발생.
            If Not Dir("Data", vbDirectory) <> "" Then
                MsgBox("UniSkin Editor Load Failed! Error Code: 9" & vbNewLine & "Warning: Data Folder Doesn't Exist!", vbCritical)
                End
            End If

            'Java 설치 확인 -업그레이드 버전 (베타)
            Try
                Dim Pr As New ProcessStartInfo("Data\JExists.exe")

                Pr.WindowStyle = ProcessWindowStyle.Hidden
                Pr.CreateNoWindow = True
                Process.Start(Pr).WaitForExit()
                If IO.File.Exists("JExists.config") Then
                    IO.File.Delete("JExists.config") '아무렇지도 않은듯이 Next
                Else
                    MessageBox.Show("First, You should Install Java." & vbNewLine &
                                    "Otherwise, You can't use some Features.", "UniSkin Editor: Java Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    '따끔하게 Java 설치하라고 혼내주기!
                End If

            Catch ex As Exception '예외 오류 잡기
                MessageBox.Show("Error Code: Unknown" & vbNewLine & "Warning: " & ex.Message, "UniSkin Editor: Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            CheckUpdate()

            If (My.Computer.Network.IsAvailable = True) Then '만약 네트워크가 연결 되있다면
                Client.DownloadFile("http://downini.uniske.kro.kr", "Data\version.ini") 'Data\version.ini 파일로 다운로드
            End If

        Catch ex As Exception '예외 오류 잡기
            MessageBox.Show("Error Code: Unknown" & vbNewLine & "Warning: " & ex.Message, "UniSkin Editor: Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Me.Text = "UniSkin Editor " & My.Application.Info.Version.ToString
        Info2.Ver1.Text = "Ver " & My.Application.Info.Version.ToString 'UniSkin Editor 어셈블리 버전 갖고온 후 String 으로 버전 표시
    End Sub

    Private Sub MakeUniSkinAPKToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MakeUniSkinAPKToolStripMenuItem.Click
        Dim ffile = Application.StartupPath + "\settings.ini"
        Dim Section = "USKESettings"
        Dim curFile As String = "Apktool\unism"
        Dim durFile As String = "WorkSpace"
        Dim drawFile As String = "Apktool\unism\res\drawable\"
        Dim SdrawFile As String = "WorkSpace\drawable\"
        Dim SSdrawFile As String = "WorkSpace\Images\"

        Try
            If Dir(durFile, vbDirectory) <> "" Then '만약 WorkSpace 폴더가 있으면
                My.Computer.FileSystem.DeleteDirectory(durFile, FileIO.DeleteDirectoryOption.DeleteAllContents) 'WorkSpace 모든 폴더와 파일 삭제
            End If

            If Dir(curFile, vbDirectory) <> "" Then
                My.Computer.FileSystem.DeleteDirectory("Apktool\unism", FileIO.DeleteDirectoryOption.DeleteAllContents)
                'bat 파일 실행 코드
                Dim proc As Process = Nothing
                Try
                    Dim batDir As String = String.Format("Apktool\") 'bat 파일을 실행할 폴더
                    proc = New Process()
                    proc.StartInfo.WorkingDirectory = batDir 'bat 파일로 지정
                    proc.StartInfo.FileName = "DecompileUni.bat" '파일 이름 지정
                    proc.StartInfo.CreateNoWindow = False
                    proc.Start()
                    proc.WaitForExit()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace.ToString())
                End Try
            Else
                'bat 파일 실행 코드
                Dim proc As Process = Nothing
                Try
                    Dim batDir As String = String.Format("Apktool\") 'bat 파일을 실행할 폴더
                    proc = New Process()
                    proc.StartInfo.WorkingDirectory = batDir 'bat 파일로 지정
                    proc.StartInfo.FileName = "DecompileUni.bat" '파일 이름 지정
                    proc.StartInfo.CreateNoWindow = False
                    proc.Start()
                    proc.WaitForExit()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace.ToString())
                End Try
            End If

            If Dir("WorkSpace\Images", vbDirectory) <> "" Then
CopyLine:
                IO.File.Copy(drawFile & "appicon.png", SSdrawFile & "appicon.png", True) '원본 이미지를 불러오기 위한 값 복사
                IO.File.Copy(drawFile & "playbg.png", SSdrawFile & "playbg.png", True)
                IO.File.Copy(drawFile & "theme_ic.png", SSdrawFile & "theme_ic.png", True)
                IO.File.Copy(drawFile & "phantom.png", SSdrawFile & "phantom.png", True)
                IO.File.Copy(drawFile & "phantom_.png", SSdrawFile & "phantom_.png", True)
                IO.File.Copy(drawFile & "chain.png", SSdrawFile & "chain.png", True)
                IO.File.Copy(drawFile & "chain_.png", SSdrawFile & "chain_.png", True)
                IO.File.Copy(drawFile & "chain__.png", SSdrawFile & "chain__.png", True)

                If IO.File.Exists(drawFile & "chainled.png") Then  '구유니스킨 chainled가 없는 오류 대비문
                    IO.File.Copy(drawFile & "chainled.png", SSdrawFile & "chainled.png", True)
                End If
            Else
                My.Computer.FileSystem.CreateDirectory("WorkSpace\Images")
                GoTo CopyLine
            End If

            If Dir("WorkSpace\drawable", vbDirectory) <> "" Then
OrCopyLine:
                IO.File.Copy(drawFile & "appicon.png", SdrawFile & "appicon.png", True) '원본 이미지를 불러오기 위한 값 복사
                IO.File.Copy(drawFile & "playbg.png", SdrawFile & "playbg.png", True)
                IO.File.Copy(drawFile & "theme_ic.png", SdrawFile & "theme_ic.png", True)
                IO.File.Copy(drawFile & "phantom.png", SdrawFile & "phantom.png", True)
                IO.File.Copy(drawFile & "phantom_.png", SdrawFile & "phantom_.png", True)
                IO.File.Copy(drawFile & "chain.png", SdrawFile & "chain.png", True)
                IO.File.Copy(drawFile & "chain_.png", SdrawFile & "chain_.png", True)
                IO.File.Copy(drawFile & "chain__.png", SdrawFile & "chain__.png", True)

                If IO.File.Exists(drawFile & "chainled.png") Then  '구유니스킨 chainled가 없는 오류 대비문
                    IO.File.Copy(drawFile & "chainled.png", SdrawFile & "chainled.png", True)
                End If
            Else
                My.Computer.FileSystem.CreateDirectory("WorkSpace\drawable")
                GoTo OrCopyLine
            End If

            If ReadIni(ffile, Section, "CHIMG", "") = "True" Then '만약 settings.ini 에서 CHIMG 값이 True 라면
                If Dir(durFile & "\Images", vbDirectory) <> "" Then '만약 WorkSpace\Images 라는 폴더가 존재하면

                    Dim appicon1 As New System.IO.FileStream(SdrawFile & "appicon.png", IO.FileMode.Open, IO.FileAccess.Read)
                    Dim popskin1 As New System.IO.FileStream(SdrawFile & "playbg.png", IO.FileMode.Open, IO.FileAccess.Read)
                    Dim themeicon1 As New System.IO.FileStream(SdrawFile & "theme_ic.png", IO.FileMode.Open, IO.FileAccess.Read)

                    Dim appicon2 As Image = Image.FromStream(appicon1) '다른 프로세스 사용 중 방지하기 위해 Image.FromStream 선언
                    Dim popskin2 As Image = Image.FromStream(popskin1)
                    Dim themeicon2 As Image = Image.FromStream(themeicon1)

                    AppIconSample1.Image = appicon2 '샘플 이미지를 리소스 이미지로 변경
                    PopSkinSample1.Image = popskin2
                    ThemeIconSample1.Image = themeicon2

                    appicon1.Close() '꼭 선언 다한 후 .Close() 를 해줘야 함.
                    popskin1.Close()
                    themeicon1.Close()
                End If
            End If
            If Dir(curFile, vbDirectory) <> "" Then
                MsgBox("Made a UniSkin!", vbInformation)
            Else
                MsgBox("Make a UniSkin Failed! Error Code: 9" & vbNewLine & "Warning: Can't Find a UniSkin Resources. Check it out in Tutorials.", vbCritical)
            End If
        Catch ex As Exception '예외 오류 잡기
            MessageBox.Show("Error Code: Unknown" & vbNewLine & "Warning: " & ex.Message, "UniSkin Editor: Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub OpenAPKToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenAPKToolStripMenuItem.Click
        Dim ofdapk As New OpenFileDialog()
        Dim Astro As String = """" '특수문자 (")
        Dim Space As String = " " '띄어쓰기 ( )
        Dim curFile As String = "Apktool\unism"
        Dim durFile As String = "WorkSpace"
        Dim File = Application.StartupPath + "\settings.ini"
        Dim Section = "USKESettings"
        Dim drawFile As String = "Apktool\unism\res\drawable\"
        Dim valFile As String = "Apktool\unism\res\values\"
        Dim ManiFile As String = "Apktool\unism\AndroidManifest.xml"
        Dim DdrawFile As String = "Data\EditSamples\drawable\"
        Dim SdrawFile As String = "WorkSpace\drawable\"
        Dim SSdrawFile As String = "WorkSpace\Images\"

        ' 프로젝트 열기
        ofdapk.Filter = "APK Files|*.apk"
        ofdapk.Title = "Select UniSkin Files"

        If ofdapk.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                If Dir(durFile, vbDirectory) <> "" Then '만약 WorkSpace 폴더가 있으면

                    '프로세스 사용 중 에러 방지문
                    Dim appicon1 As New System.IO.FileStream(DdrawFile & "appicon.png", IO.FileMode.Open, IO.FileAccess.Read)
                    Dim popskin1 As New System.IO.FileStream(DdrawFile & "playbg.png", IO.FileMode.Open, IO.FileAccess.Read)
                    Dim themeicon1 As New System.IO.FileStream(DdrawFile & "theme_ic.png", IO.FileMode.Open, IO.FileAccess.Read)

                    Dim appicon2 As Image = Image.FromStream(appicon1) '다른 프로세스 사용 중 방지하기 위해 Image.FromStream 선언
                    Dim popskin2 As Image = Image.FromStream(popskin1)
                    Dim themeicon2 As Image = Image.FromStream(themeicon1)

                    If ReadIni(File, Section, "CHIMG", "") = "True" Then '만약 settings.ini 에서 CHIMG 값이 True 라면
                        If Dir(durFile & "\Images", vbDirectory) <> "" Then '만약 WorkSpace\Images 라는 폴더가 존재하면
                            AppIconSample1.Image = appicon2 '샘플 이미지를 리소스 이미지로 변경
                            PopSkinSample1.Image = popskin2
                            ThemeIconSample1.Image = themeicon2

                            appicon1.Close() '꼭 선언 다한 후 .Close() 를 해줘야 함.
                            popskin1.Close()
                            themeicon1.Close()
                        End If

                        If Dir(durFile, vbDirectory) <> "" Then
                            My.Computer.FileSystem.DeleteDirectory(durFile, FileIO.DeleteDirectoryOption.DeleteAllContents) '깨끗한 WorkSpace 청소
                        End If
                    End If
                    IO.File.Copy(ofdapk.FileName, "Apktool\unisample.apk", True) '파일 ofdApk의 파일 경로, 이름을 복사 후 Apktool\unisample.apk 로 붙여넣기, 덮어쓰기 허용
                    If Dir(curFile, vbDirectory) <> "" Then 'Apktool\unism 의 폴더가 있으면
                        My.Computer.FileSystem.DeleteDirectory("Apktool\unism", FileIO.DeleteDirectoryOption.DeleteAllContents) '모든 unism 폴더 안에 있는 파일과 unism 폴더 삭제
                    End If

                    'bat 파일 실행 코드
                    Dim proc As Process = Nothing
                    Try
                        Dim batDir As String = String.Format("Apktool\") 'bat 파일을 실행할 폴더
                        proc = New Process()
                        proc.StartInfo.WorkingDirectory = batDir 'bat 파일로 지정
                        proc.StartInfo.FileName = "DecompileSam.bat" '파일 이름 지정
                        proc.StartInfo.CreateNoWindow = False
                        proc.Start()
                        proc.WaitForExit()
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace.ToString())
                    End Try
                Else
                    If Dir(curFile, vbDirectory) <> "" Then 'Apktool\unism 의 폴더가 있으면
                        My.Computer.FileSystem.DeleteDirectory("Apktool\unism", FileIO.DeleteDirectoryOption.DeleteAllContents) '모든 unism 폴더 안에 있는 파일과 unism 폴더 삭제
                    End If

                    'bat 파일 실행 코드
                    Dim proc As Process = Nothing
                    Try
                        Dim batDir As String = String.Format("Apktool\") 'bat 파일을 실행할 폴더
                        proc = New Process()
                        proc.StartInfo.WorkingDirectory = batDir 'bat 파일로 지정
                        proc.StartInfo.FileName = "DecompileSam.bat" '파일 이름 지정
                        proc.StartInfo.CreateNoWindow = False
                        proc.Start()
                        proc.WaitForExit()
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace.ToString())
                    End Try
                End If
                If Dir(curFile, vbDirectory) <> "" Then '디컴파일의 오류로 인한 If문으로 방지
                    MsgBox("Opened Project!", vbInformation)

                    Dim Dappicon1 As New System.IO.FileStream(DdrawFile & "appicon.png", IO.FileMode.Open, IO.FileAccess.Read) '원본으로 복원.
                    Dim Dpopskin1 As New System.IO.FileStream(DdrawFile & "playbg.png", IO.FileMode.Open, IO.FileAccess.Read)
                    Dim Dthemeicon1 As New System.IO.FileStream(DdrawFile & "theme_ic.png", IO.FileMode.Open, IO.FileAccess.Read)

                    Dim Dappicon2 As Image = Image.FromStream(Dappicon1) '다른 프로세스 사용 중 방지하기 위해 Image.FromStream 선언
                    Dim Dpopskin2 As Image = Image.FromStream(Dpopskin1)
                    Dim Dthemeicon2 As Image = Image.FromStream(Dthemeicon1)

                    AppIconSample1.Image = Dappicon2 '샘플 이미지로 값 리셋
                    PopSkinSample1.Image = Dpopskin2
                    ThemeIconSample1.Image = Dthemeicon2

                    If ReadIni(File, Section, "CHIMG", "") = "True" Then '만약 settings.ini 에서 CHIMG 값이 True 라면
                        If Dir("WorkSpace\drawable", vbDirectory) <> "" Then
ImageSetLine:
                            IO.File.Copy(drawFile & "appicon.png", SdrawFile & "appicon.png", True) '리소스 이미지를 불러오기 위한 값 복사
                            IO.File.Copy(drawFile & "playbg.png", SdrawFile & "playbg.png", True)
                            IO.File.Copy(drawFile & "theme_ic.png", SdrawFile & "theme_ic.png", True)
                            IO.File.Copy(drawFile & "phantom.png", SdrawFile & "phantom.png", True)
                            IO.File.Copy(drawFile & "phantom_.png", SdrawFile & "phantom_.png", True)
                            IO.File.Copy(drawFile & "chain.png", SdrawFile & "chain.png", True)
                            IO.File.Copy(drawFile & "chain_.png", SdrawFile & "chain_.png", True)
                            IO.File.Copy(drawFile & "chain__.png", SdrawFile & "chain__.png", True)

                            If IO.File.Exists(drawFile & "chainled.png") Then  '구유니스킨 chainled가 없는 오류 대비문
                                IO.File.Copy(drawFile & "chainled.png", SdrawFile & "chainled.png", True)
                            Else
                                MsgBox("This UniSkin don't have Chain LED!", MsgBoxStyle.Exclamation)
                            End If

                            '프로세스 사용 중 에러 방지문
                            Dim Sappicon1 As New System.IO.FileStream(SdrawFile & "appicon.png", IO.FileMode.Open, IO.FileAccess.ReadWrite)
                            Dim Spopskin1 As New System.IO.FileStream(SdrawFile & "playbg.png", IO.FileMode.Open, IO.FileAccess.ReadWrite)
                            Dim Sthemeicon1 As New System.IO.FileStream(SdrawFile & "theme_ic.png", IO.FileMode.Open, IO.FileAccess.ReadWrite)

                            Dim Sappicon2 As Image = Image.FromStream(Sappicon1) '다른 프로세스 사용 중 방지하기 위해 Image.FromStream 선언
                            Dim Spopskin2 As Image = Image.FromStream(Spopskin1)
                            Dim Sthemeicon2 As Image = Image.FromStream(Sthemeicon1)

                            AppIconSample1.Image = Sappicon2 '샘플 이미지를 리소스 이미지로 변경
                            PopSkinSample1.Image = Spopskin2
                            ThemeIconSample1.Image = Sthemeicon2

                            Sappicon1.Close() '꼭 선언 다한 후 .Close() 를 해줘야 함.
                            Spopskin1.Close() '안그러면 다른 프로세스에 사용 중이라고 오류가 펑펑!
                            Sthemeicon1.Close()
                            'MainProject 리소스 이미지 설정/리셋
                        Else
                            My.Computer.FileSystem.CreateDirectory("WorkSpace\drawable")
                            GoTo ImageSetLine
                        End If
                    End If

                    If Dir("WorkSpace\Images", vbDirectory) <> "" Then
OrCopyLine:
                        IO.File.Copy(drawFile & "appicon.png", SSdrawFile & "appicon.png", True) '원본 이미지를 불러오기 위한 값 복사
                        IO.File.Copy(drawFile & "playbg.png", SSdrawFile & "playbg.png", True)
                        IO.File.Copy(drawFile & "theme_ic.png", SSdrawFile & "theme_ic.png", True)
                        IO.File.Copy(drawFile & "phantom.png", SSdrawFile & "phantom.png", True)
                        IO.File.Copy(drawFile & "phantom_.png", SSdrawFile & "phantom_.png", True)
                        IO.File.Copy(drawFile & "chain.png", SSdrawFile & "chain.png", True)
                        IO.File.Copy(drawFile & "chain_.png", SSdrawFile & "chain_.png", True)
                        IO.File.Copy(drawFile & "chain__.png", SSdrawFile & "chain__.png", True)

                        If IO.File.Exists(drawFile & "chainled.png") Then  '구유니스킨 chainled가 없는 오류 대비문
                            IO.File.Copy(drawFile & "chainled.png", SSdrawFile & "chainled.png", True)
                        End If
                    Else
                        My.Computer.FileSystem.CreateDirectory("WorkSpace\Images")
                        GoTo OrCopyLine
                    End If

                    'Info 정보 불러오기 (베타)
#Region "Info_Load"

                    'Replace 방법을 이용하여 정보를 불러오는데, 이 기능 및 코드가 베타라서 오류가 많을 수 있습니다.
                    If ReadIni(File, Section, "CHINFO", "") = "True" Then '만약 settings.ini 에서 CHINFO 값이 True 라면
                        If IO.File.Exists("Apktool\unism\res\values\strings.xml") Then 'values의 strings 파일 존재 확인
                            Dim L1File As String = System.IO.File.ReadAllLines(Application.StartupPath & "\Apktool\unism\res\values\strings.xml")(35) '36줄 페이지 불러오기!
                            Dim L4File As String = System.IO.File.ReadAllLines(Application.StartupPath & "\Apktool\unism\res\values\strings.xml")(38) '(라인 줄-1) 을 해야 정상적 처리. 
                            Dim L5File As String = System.IO.File.ReadAllLines(Application.StartupPath & "\Apktool\unism\res\values\strings.xml")(36) '이유는 저도 몰라유.
                            Dim L6File As String = System.IO.File.ReadAllLines(Application.StartupPath & "\Apktool\unism\res\values\strings.xml")(37)

                            infoTB1.Text = L1File '불러온 String 을 infoTB1 텍스트 박스에 저장.
                            infoTB1.Text = infoTB1.Text.Replace("<string name=" & Astro & "app_name" & Astro & ">", "").Trim() 'Replace: App Name
                            infoTB1.Text = infoTB1.Text.Replace("</string>", "").Trim()

                            infoTB4.Text = L4File
                            infoTB4.Text = infoTB4.Text.Replace("<string name=" & Astro & "theme_name" & Astro & ">", "").Trim() 'Replace: Theme Name
                            infoTB4.Text = infoTB4.Text.Replace("</string>", "").Trim()

                            infoTB5.Text = L5File
                            infoTB5.Text = infoTB5.Text.Replace("<string name=" & Astro & "theme_author" & Astro & ">", "").Trim() 'Replace: Theme Author
                            infoTB5.Text = infoTB5.Text.Replace("</string>", "").Trim()

                            infoTB6.Text = L6File
                            infoTB6.Text = infoTB6.Text.Replace("<string name=" & Astro & "theme_description" & Astro & ">", "").Trim() 'Replace: Theme Description
                            infoTB6.Text = infoTB6.Text.Replace("</string>", "").Trim()
                        End If

                        'Loop.
                        If IO.File.Exists("Apktool\unism\AndroidManifest.xml") Then
                            Dim L2File As String = System.IO.File.ReadAllLines(Application.StartupPath & "\Apktool\unism\AndroidManifest.xml")(0)

                            infoTB2.Text = L2File  '꼭 텍스트박스 번호는 바꿔주기.                                                                 
                            infoTB2.Text = infoTB2.Text.Replace("<?xml version=" & Astro & "1.0" & Astro & Space & "encoding=" & Astro & "utf-8" & Astro & Space & "standalone=" & Astro &
                                                           "no" & Astro & "?><manifest xmlns:android=" & Astro & "http://schemas.android.com/apk/res/android" & Astro & Space &
                                                           "package=" & Astro, "").Trim() 'Replace: App Package

                            infoTB2.Text = infoTB2.Text.Replace(Astro & Space & "platformBuildVersionCode=" & Astro & "23" & Astro & Space &
                                                           "platformBuildVersionName=" & Astro & "6.0-2438415" & Astro & ">", "").Trim()
                        End If

                        If IO.File.Exists("Apktool\unism\apktool.yml") Then
                            Dim L3File As String = System.IO.File.ReadAllLines(Application.StartupPath & "\Apktool\unism\apktool.yml")(21)

                            infoTB3.Text = L3File
                            infoTB3.Text = infoTB3.Text.Replace("versionName:", "").Trim() 'Replace: App Version

                            'Color Load 기능 추가 중...
                        End If
                    End If
#End Region
                Else
                    MsgBox("Open UniSkin Failed! Error Code: 9" & vbNewLine & "Warning: Can't Find a UniSkin Resources. Check it out in Tutorials.", vbCritical)
                End If
            Catch ex As Exception '예외 오류 잡기
                MessageBox.Show("Error Code: Unknown" & vbNewLine & "Warning: " & ex.Message, "UniSkin Editor: Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub SaveUniSkinAPKToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveUniSkinAPKToolStripMenuItem.Click
        Dim sfdapk As New SaveFileDialog()
        Dim fileInfo As IO.FileInfo
        Dim dirdrawInfo As IO.DirectoryInfo = New IO.DirectoryInfo("WorkSpace\drawable\")
        Dim dirvalInfo As IO.DirectoryInfo = New IO.DirectoryInfo("WorkSpace\values\")
        Dim dirmaniInfo As IO.DirectoryInfo = New IO.DirectoryInfo("WorkSpace\Manifest\")
        Dim dirverInfo As IO.DirectoryInfo = New IO.DirectoryInfo("WorkSpace\Version\")
        Dim uniFile As String = "Apktool\unism"
        Dim drawFile As String = "WorkSpace\drawable"
        Dim valFile As String = "WorkSpace\values"
        Dim maniFile As String = "WorkSpace\Manifest"
        Dim verFile As String = "WorkSpace\Version"

        '프로젝트 저장
        sfdapk.Filter = "APK Files|*.apk"
        sfdapk.Title = "Save a UniSkin File"

        If sfdapk.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                If Dir(uniFile, vbDirectory) <> "" Then 'Make a UniSkin 을 안한경우의 오류 대비
                    If Dir(drawFile, vbDirectory) <> "" Then '만약 drawable 폴더가 있으면
                        For Each fileInfo In dirdrawInfo.GetFiles() 'Drawable 파일 갯수 가져오기
                            IO.File.Copy(fileInfo.FullName, "Apktool\unism\res\drawable\" & fileInfo.Name, True) '파일 갯수 만큼 복사
                        Next
                    End If
                    If Dir(valFile, vbDirectory) <> "" Then
                        For Each fileInfo In dirvalInfo.GetFiles() ' Values 파일 갯수 가져오기
                            IO.File.Copy(fileInfo.FullName, "Apktool\unism\res\values\" & fileInfo.Name, True) '파일 갯수 만큼 복사
                        Next
                    End If
                    If Dir(maniFile, vbDirectory) <> "" Then
                        For Each fileInfo In dirmaniInfo.GetFiles() ' Manifest 파일 갯수 가져오기
                            IO.File.Copy(fileInfo.FullName, "Apktool\unism\" & fileInfo.Name, True) '파일 갯수 만큼 복사
                        Next
                    End If
                    If Dir(verFile, vbDirectory) <> "" Then
                        For Each fileInfo In dirverInfo.GetFiles() ' 버전 파일 갯수 가져오기
                            IO.File.Copy(fileInfo.FullName, "Apktool\unism\" & fileInfo.Name, True) '파일 갯수 만큼 복사
                        Next
                    End If
                    'bat 파일 실행 코드
                    Dim proc As Process = Nothing
                    Try
                        Dim batDir As String = String.Format("Apktool\") 'bat 파일을 실행할 폴더
                        proc = New Process()
                        proc.StartInfo.WorkingDirectory = batDir 'bat 파일로 지정
                        proc.StartInfo.FileName = "CompileSam.bat" '파일 이름 지정
                        proc.StartInfo.CreateNoWindow = False
                        proc.Start()
                        proc.WaitForExit()
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace.ToString())
                    End Try
                    If IO.File.Exists("Apktool\unism\dist\uniskinsample.apk") Then
                        If IO.File.Exists("Apktool\SignApk\unisample.apk") Then '만약 unisample.apk 가 이미 있으면
                            IO.File.Delete("Apktool\SignApk\unisample.apk")  '파일 삭제
                            IO.File.Move("Apktool\unism\dist\uniskinsample.apk", "Apktool\SignApk\unisample.apk") '파일 이동
                        Else
                            IO.File.Move("Apktool\unism\dist\uniskinsample.apk", "Apktool\SignApk\unisample.apk") '파일 이동
                        End If
                        Try
                            Dim batDir As String = String.Format("Apktool\SignApk\") 'bat 파일을 실행할 폴더
                            proc = New Process()
                            proc.StartInfo.WorkingDirectory = batDir 'bat 파일로 지정
                            proc.StartInfo.FileName = "SignSam.bat" '파일 이름 지정
                            proc.StartInfo.CreateNoWindow = False
                            proc.Start()
                            proc.WaitForExit()
                        Catch ex As Exception
                            Console.WriteLine(ex.StackTrace.ToString())
                        End Try
                        If IO.File.Exists(sfdapk.FileName) Then '만약 덮어쓰기 발견 되면
                            IO.File.Delete(sfdapk.FileName) '파일 삭제
                            IO.File.Move("Apktool\SignApk\UniSkin.apk", sfdapk.FileName) '파일 이동
                            MsgBox("Saved UniSkin!", vbInformation) '파일 이동
                        Else
                            IO.File.Move("Apktool\SignApk\UniSkin.apk", sfdapk.FileName) '파일 이동
                            MsgBox("Saved UniSkin!", vbInformation) '파일 이동
                        End If
                        RmDir("Apktool\unism\dist") 'dist 폴더 삭제
                    Else
                        If IO.File.Exists("Apktool\unism\dist\unisample.apk") Then
                            If IO.File.Exists("Apktool\SignApk\unisample.apk") Then
                                IO.File.Delete("Apktool\SignApk\unisample.apk")
                                IO.File.Move("Apktool\unism\dist\unisample.apk", "Apktool\SignApk\unisample.apk")
                            Else
                                IO.File.Move("Apktool\unism\dist\unisample.apk", "Apktool\SignApk\unisample.apk")
                            End If
                            Try
                                Dim batDir As String = String.Format("Apktool\SignApk\") 'bat 파일을 실행할 폴더
                                proc = New Process()
                                proc.StartInfo.WorkingDirectory = batDir 'bat 파일로 지정
                                proc.StartInfo.FileName = "SignSam.bat" '파일 이름 지정
                                proc.StartInfo.CreateNoWindow = False
                                proc.Start()
                                proc.WaitForExit()
                            Catch ex As Exception
                                Console.WriteLine(ex.StackTrace.ToString())
                            End Try
                            If IO.File.Exists(sfdapk.FileName) Then '만약 덮어쓰기 발견 되면
                                IO.File.Delete(sfdapk.FileName) '파일 삭제
                                IO.File.Move("Apktool\SignApk\UniSkin.apk", sfdapk.FileName) '파일 이동
                                MsgBox("Saved UniSkin!", vbInformation) '파일 이동
                            Else
                                IO.File.Move("Apktool\SignApk\UniSkin.apk", sfdapk.FileName) '파일 이동
                                MsgBox("Saved UniSkin!", vbInformation) '파일 이동
                            End If
                            RmDir("Apktool\unism\dist") 'dist 폴더 삭제
                        Else
                            MsgBox("Save UniSkin Failed! Error Code: 9" & vbNewLine & "Warning: Can't Find Recompile APK. Check it out in Tutorials.", vbCritical)
                        End If
                    End If
                Else
                    MsgBox("Save UniSkin Failed! Error Code: 9" & vbNewLine & "Warning: Can't Find a UniSkin Resources. Check it out in Tutorials.", vbCritical)
                End If
            Catch ex As Exception '예외 오류 잡기
                MessageBox.Show("Error Code: Unknown" & vbNewLine & "Warning: " & ex.Message, "UniSkin Editor: Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub IconSample1_Click(sender As Object, e As EventArgs) Handles AppIconSample1.DoubleClick
        Dim curFile As String = "WorkSpace\drawable"
        Dim drawFile As String = "WorkSpace\drawable\"

        If Dir(curFile, vbDirectory) <> "" Then '만약 WorkSpace\drawable 폴더가 있으면
StartLine:
            IO.File.Copy("Data\EditSamples\drawable\appicon.png", "WorkSpace\drawable\appicon.png", True) '파일 복사, 덮어쓰기 허용

            Dim appicon1 As New System.IO.FileStream(drawFile & "appicon.png", IO.FileMode.Open, IO.FileAccess.Read)
            Dim appicon2 As Image = Image.FromStream(appicon1) '다른 프로세스 사용 중 방지하기 위해 Image.FromStream 선언
            appicon1.Close()

            TextFileName1.Text = "Data\EditSamples\drawable\appicon.png"
            AppIconSample1.Image = appicon2
            MsgBox("Imported Sample Icon!", vbInformation)
        Else
            My.Computer.FileSystem.CreateDirectory(curFile)
            GoTo StartLine
        End If
    End Sub

    Private Sub ImportIcon1_Click(sender As Object, e As EventArgs) Handles ImportAppIcon1.Click
        Dim ofdEdit As New OpenFileDialog
        Dim curFile As String = "WorkSpace\drawable"
        Dim drawFile As String = "WorkSpace\drawable\"

        '아이콘 가져오기
        ofdEdit.Filter = "PNG Files|*.png"
        ofdEdit.Title = "Select App Icon File"

        If ofdEdit.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            If Dir(curFile, vbDirectory) <> "" Then
StartLine:
                IO.File.Copy(ofdEdit.FileName, "WorkSpace\drawable\appicon.png", True)

                Dim appicon1 As New System.IO.FileStream(drawFile & "appicon.png", IO.FileMode.Open, IO.FileAccess.Read)
                Dim appicon2 As Image = Image.FromStream(appicon1) '다른 프로세스 사용 중 방지하기 위해 Image.FromStream 선언
                appicon1.Close()

                TextFileName1.Text = ofdEdit.FileName
                AppIconSample1.Image = appicon2
                MsgBox("Imported App Icon!", vbInformation)
            Else
                My.Computer.FileSystem.CreateDirectory(curFile)
                GoTo StartLine
            End If
        End If
    End Sub

    Private Sub ImportPopSkin1_Click(sender As Object, e As EventArgs) Handles ImportPopSkin1.Click
        Dim ofdEdit As New OpenFileDialog
        Dim curFile As String = "WorkSpace\drawable"
        Dim drawFile As String = "WorkSpace\drawable\"

        '팝스킨 가져오기
        ofdEdit.Filter = "PNG Files|*.png"
        ofdEdit.Title = "Select PopSkin File"

        If ofdEdit.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            If Dir(curFile, vbDirectory) <> "" Then
StartLine:
                IO.File.Copy(ofdEdit.FileName, "WorkSpace\drawable\playbg.png", True)

                Dim playbg1 As New System.IO.FileStream(drawFile & "playbg.png", IO.FileMode.Open, IO.FileAccess.Read)
                Dim playbg2 As Image = Image.FromStream(playbg1)
                playbg1.Close()

                TextFileName2.Text = ofdEdit.FileName
                PopSkinSample1.Image = playbg2
                MsgBox("Imported App Icon!", vbInformation)
            Else
                My.Computer.FileSystem.CreateDirectory(curFile)
                GoTo StartLine
            End If
        End If
    End Sub

    Private Sub PopSkinSample2_Click(sender As Object, e As EventArgs) Handles PopSkinSample1.DoubleClick
        Dim curFile As String = "WorkSpace\drawable"
        Dim drawFile As String = "WorkSpace\drawable\"

        '팝스킨 가져오기
        If Dir(curFile, vbDirectory) <> "" Then '만약 WorkSpace\drawable 폴더가 있으면
StartLine:
            IO.File.Copy("Data\EditSamples\drawable\playbg.png", "WorkSpace\drawable\playbg.png", True) '파일 복사, 덮어쓰기 허용

            Dim playbg1 As New System.IO.FileStream(drawFile & "playbg.png", IO.FileMode.Open, IO.FileAccess.Read)
            Dim playbg2 As Image = Image.FromStream(playbg1)
            playbg1.Close()

            TextFileName2.Text = "Data\EditSamples\drawable\playbg.png"
            PopSkinSample1.Image = playbg2
            MsgBox("Imported Sample PopSkin!", vbInformation)
        Else
            My.Computer.FileSystem.CreateDirectory(curFile)
            GoTo StartLine
        End If
    End Sub

    Private Sub ImagesAdButton1_Click(sender As Object, e As EventArgs) Handles ImagesAdButton1.Click
        ImagesAdvanced.Show()
    End Sub

    Private Sub ThemeIconSample1_Click(sender As Object, e As EventArgs) Handles ThemeIconSample1.DoubleClick
        Dim curFile As String = "WorkSpace\drawable"
        Dim drawFile As String = "WorkSpace\drawable\"

        '테마 아이콘 가져오기
        If Dir(curFile, vbDirectory) <> "" Then '만약 WorkSpace\drawable 폴더가 있으면
StartLine:
            IO.File.Copy("Data\EditSamples\drawable\theme_ic.png", "WorkSpace\drawable\theme_ic.png", True) '파일 복사, 덮어쓰기 허용

            Dim themeicon1 As New System.IO.FileStream(drawFile & "theme_ic.png", IO.FileMode.Open, IO.FileAccess.Read)
            Dim themeicon2 As Image = Image.FromStream(themeicon1)
            themeicon1.Close()

            TextFileName3.Text = "Data\EditSamples\drawable\theme_ic.png"
            ThemeIconSample1.Image = themeicon2
            MsgBox("Imported Sample Theme Icon!", vbInformation)
        Else
            My.Computer.FileSystem.CreateDirectory(curFile)
            GoTo StartLine
        End If
    End Sub

    Private Sub ImportThemeIcon1_Click(sender As Object, e As EventArgs) Handles ImportThemeIcon1.Click
        Dim ofdEdit As New OpenFileDialog
        Dim curFile As String = "WorkSpace\drawable"
        Dim drawFile As String = "WorkSpace\drawable\"

        '테마 아이콘 가져오기
        ofdEdit.Filter = "PNG Files|*.png"
        ofdEdit.Title = "Select Theme Icon File"

        If ofdEdit.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            If Dir(curFile, vbDirectory) <> "" Then
StartLine:
                IO.File.Copy(ofdEdit.FileName, "WorkSpace\drawable\theme_ic.png", True)

                Dim themeicon1 As New System.IO.FileStream(drawFile & "theme_ic.png", IO.FileMode.Open, IO.FileAccess.Read)
                Dim themeicon2 As Image = Image.FromStream(themeicon1)
                themeicon1.Close()

                TextFileName3.Text = ofdEdit.FileName
                ThemeIconSample1.Image = themeicon2
                MsgBox("Imported Theme Icon!", vbInformation)
            Else
                My.Computer.FileSystem.CreateDirectory(curFile)
                GoTo StartLine
            End If
        End If
    End Sub

    Private Sub infoSave_Click(sender As Object, e As EventArgs) Handles infoSave.Click
        Dim Astro As String = """" '특수문자 (")
        Dim Space As String = " " '띄어쓰기 ( )
        Dim fs As FileStream
        Dim info As Byte()

        '모든 drawable 파일, values 파일과 AndroidManifest 파일, Version 파일 저장
        '제작자가 비주얼 베이직 닷넷을 독학해서 소스가 아주 더러울꺼에유.
        '방법은 여러가지가 있습니다. 대놓고 아예 String 에다가 넣고, XMLTextBox1 으로 XML의 일부를 담고 또 String 에다가 넣은 뒤,
        '아예 Replace로 이용한 방법도 있죠.

        'Manifest 저장 (Strings 저장, 베타여서 오류가 많음)
        If Dir("WorkSpace", vbDirectory) <> "" Then '만약 WorkSpace 폴더가 있으면
            If Dir("WorkSpace\Manifest", vbDirectory) <> "" Then '만약 Mainifest 폴더가 있으면
                If IO.File.Exists("WorkSpace\Manifest\AndroidManifest.xml") Then '만약 AndroidMainifest.xml 이 존재하면
                    IO.File.Delete("WorkSpace\Manifest\AndroidManifest.xml") '파일 삭제
ManifestLine:
                    fs = IO.File.Create("WorkSpace\Manifest\AndroidManifest.xml") '파일 생성
                    '파일 내용을 UTF 8로 인코딩 & AndroidManifest.xml 파일 저장
                    info = New UTF8Encoding(True).GetBytes("<?xml version=" & Astro & "1.0" & Astro & Space & "encoding=" & Astro & "utf-8" & Astro & Space & "standalone=" & Astro &
                                                           "no" & Astro & "?><manifest xmlns:android=" & Astro & "http://schemas.android.com/apk/res/android" & Astro & Space &
                                                           "package=" & Astro & infoTB2.Text & Astro & Space & "platformBuildVersionCode=" & Astro & "23" & Astro & Space &
                                                           "platformBuildVersionName=" & Astro & "6.0-2438415" & Astro & ">" & vbNewLine & "    <application android:allowBackup=" & Astro &
                                                           "true" & Astro & Space & "android:icon=" & Astro & "@drawable/appicon" & Astro & Space & "android:label=" & Astro &
                                                           "@string/app_name" & Astro & Space & "android:supportsRtl=" & Astro & "true" & Astro & Space & "android:theme=" & Astro &
                                                           "@style/AppTheme" & Astro & ">" & vbNewLine & "        <activity android:name=" & Astro &
                                                           "com.kimjisub.launchpad.theme.template.MainActivity" & Astro & ">" & vbNewLine & "            <intent-filter>" & vbNewLine &
                                                           "                <action android:name=" & Astro & "android.intent.action.MAIN" & Astro & "/>" & vbNewLine &
                                                           "                <category android:name=" & Astro & "android.intent.category.LAUNCHER" & Astro & "/>" & vbNewLine &
                                                           "            </intent-filter>" & vbNewLine & "        </activity>" & vbNewLine & "    </application>" & vbNewLine & "</manifest>")
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Else
                    GoTo ManifestLine
                End If
            Else
                My.Computer.FileSystem.CreateDirectory("WorkSpace\Manifest")
                GoTo ManifestLine
            End If
        Else
            My.Computer.FileSystem.CreateDirectory("WorkSpace")
            My.Computer.FileSystem.CreateDirectory("WorkSpace\Manifest")
            GoTo ManifestLine
        End If

        'Values 저장 (XMLTextBox1 & Strings 저장, 이것도 베타여서 오류가 많음)
        If Dir("WorkSpace", vbDirectory) <> "" Then '만약 WorkSpace 폴더가 있으면
            If Dir("WorkSpace\values", vbDirectory) <> "" Then '만약 values 폴더가 있으면
                If IO.File.Exists("WorkSpace\values\strings.xml") Then '만약 strings.xml 이 존재하면
ValuesLine:
                    fs = IO.File.Create("WorkSpace\values\strings.xml") '파일 생성
                    '파일 내용을 UTF 8로 인코딩 & strings.xml 파일 저장
                    info = New UTF8Encoding(True).GetBytes(XMLTextBox1.Text & vbNewLine & "    <string name=" & Astro & "app_name" & Astro & ">" & infoTB1.Text & "</string>" & vbNewLine &
                                                           "    <string name=" & Astro & "theme_author" & Astro & ">" & infoTB5.Text & "</string>" & vbNewLine &
                                                           "    <string name=" & Astro & "theme_description" & Astro & ">" & infoTB6.Text & "</string>" & vbNewLine &
                                                           "    <string name=" & Astro & "theme_name" & Astro & ">" & infoTB4.Text & "</string>" & vbNewLine &
                                                           "</resources>")
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Else
                    GoTo ValuesLine
                End If
            Else
                My.Computer.FileSystem.CreateDirectory("WorkSpace\values")
                GoTo ValuesLine
            End If
        Else
            My.Computer.FileSystem.CreateDirectory("WorkSpace")
            My.Computer.FileSystem.CreateDirectory("WorkSpace\values")
            GoTo ValuesLine
        End If

        'App Version 저장 (Find & Replace 저장)
        If Dir("WorkSpace\Version", vbDirectory) <> "" Then
VersionLine:
            IO.File.Copy("Apktool\unism\apktool.yml", "WorkSpace\Version\apktool.yml", True)
            Dim FilePath As String = "WorkSpace\Version\apktool.yml"
            IO.File.WriteAllText(FilePath, IO.File.ReadAllText(FilePath).Replace("1.0.0", infoTB3.Text))
        Else
            My.Computer.FileSystem.CreateDirectory("WorkSpace\Version")
            GoTo VersionLine
        End If

        'UniSkin Text Color 저장 (Converting Color To HTML)
#Region "Colors_Setting"
        Dim curFile As String = "WorkSpace\values\colors.xml" 'File 경로
        Dim WhCol As String = "#ffffffff" '하얀 색깔

        If Dir("WorkSpace\values", vbDirectory) <> "" Then
ColorsLine:
            Try
                IO.File.Copy("Data\EditSamples\values\colors.xml", curFile, True) '덮어쓰기 허용이라 이젠 File.Exists 문 안해도 된다.

                Dim SCol As Color = infoCol1.SelectedColor
                Dim ColARGB As String = "#" + SCol.A.ToString("X2") + SCol.R.ToString("X2") + SCol.G.ToString("X2") + SCol.B.ToString("X2")

                IO.File.WriteAllText(curFile, IO.File.ReadAllText(curFile).Replace(WhCol, ColARGB))

            Catch ex As Exception '예외 오류 잡기
                MessageBox.Show("Error Code: Unknown" & vbNewLine & "Warning: " & ex.Message, "UniSkin Editor: Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                GoTo NullLine
            End Try
        Else
            My.Computer.FileSystem.CreateDirectory("WorkSpace\values")
            GoTo ColorsLine
        End If
#End Region

        If Dir("Apktool\unism", vbDirectory) <> "" Then '일단 unism 폴더가 있는지 확인 (이 폴더가 존재하지 않으면 심각한 문제가 일어난다)
            If IO.File.Exists("Apktool\unism\res\drawable\appicon.png") Then 'drawable 파일이 있는지 확인 (추후 문제가 생긴다)
                If IO.File.Exists("Apktool\unism\res\values\strings.xml") Then 'drawable 파일이 있는지 확인 (또한 추후 문제가 생긴다)
                    '모든 명령어가 끝나면 메시지박스 출력.
                    MsgBox("Saved Info!", vbInformation, "UniSkin Editor")
                Else
                    'values 오류
                    MsgBox("Saved Info, But Can't Find UniSkin values Resources! Error Code: 8" & vbNewLine & "Warning: Can't Find values UniSkin Resources. Check it out in Tutorials.", vbCritical)
                End If
            Else
                'drawable 오류
                MsgBox("Saved Info, But Can't Find UniSkin drawable Resources! Error Code: 8" & vbNewLine & "Warning: Can't Find drawable UniSkin Resources. Check it out in Tutorials.", vbCritical)
            End If
        Else
            'Project 만들기 및 열기 오류
            MsgBox("Saved Info, But Can't Find UniSkin Resources! Error Code: 8" & vbNewLine & "Warning: Can't Find UniSkin Resources. Check it out in Tutorials.", vbCritical)
        End If

NullLine: 'Catch ex As Execption 중 방지하기 위해 Line 생성
    End Sub

    Private Sub InstallFrameWorkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstallFrameWorkToolStripMenuItem.Click
        'bat 파일 실행 코드
        Dim proc As Process = Nothing
        Try
            Dim batDir As String = String.Format("Apktool\") 'bat 파일을 실행할 폴더
            proc = New Process()
            proc.StartInfo.WorkingDirectory = batDir 'bat 파일로 지정
            proc.StartInfo.FileName = "FrameWork.bat" '파일 이름 지정
            proc.StartInfo.CreateNoWindow = False
            proc.Start()
            proc.WaitForExit()
        Catch ex As Exception
            Console.WriteLine(ex.StackTrace.ToString())
        End Try
        MsgBox("Installed FrameWork!", vbInformation, "UniSkin Editor")
    End Sub

    Private Sub RemoveFrameWorkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveFrameWorkToolStripMenuItem.Click
        'bat 파일 실행 코드
        Dim proc As Process = Nothing
        Try
            Dim batDir As String = String.Format("Apktool\") 'bat 파일을 실행할 폴더
            proc = New Process()
            proc.StartInfo.WorkingDirectory = batDir 'bat 파일로 지정
            proc.StartInfo.FileName = "ReMoveFr.bat" '파일 이름 지정
            proc.StartInfo.CreateNoWindow = False
            proc.Start()
            proc.WaitForExit()
        Catch ex As Exception
            Console.WriteLine(ex.StackTrace.ToString())
        End Try
        MsgBox("Removed FrameWork!", vbInformation, "UniSkin Editor")
    End Sub

    Private Sub UpdateCheckToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateCheckToolStripMenuItem.Click
        Dim Client As New WebClient
        Dim vFile = Application.StartupPath + "\Data\version.ini"
        Dim sFile = Application.StartupPath + "\settings.ini"
        Dim ChkUpdate As String = ReadIni(sFile, "USKESettings", "CheckUpdate", "")
        Dim FileInfo As String = ReadIni(vFile, "Version", "version", "")

        CheckUpdate()

        '최신버전 사용 코드
        If (My.Computer.Network.IsAvailable = True) Then '만약 네트워크가 연결 되있다면
            If My.Application.Info.Version.ToString = FileInfo Then '만약 어셈블리 버전이랑 FileInfo 가 값이 같으면
                MsgBox("You are using a Latest Version." & vbNewLine & vbNewLine &
                       "Current Version : " & My.Application.Info.Version.ToString & vbNewLine & "Latest Version : " & FileInfo, vbInformation)
            End If
        Else
            MsgBox("Network Connect Failed! Can't Check For Updates.", vbCritical)
        End If

        '? 테스트 버전 사용 코드
        'S/S01M8Zv+NjMThxTjmj3gjoTL41D9dh7Z/SDufVMuk= (UniSkinEditor, AES-256)
        If (My.Computer.Network.IsAvailable = True) Then '만약 네트워크가 연결 되있다면
            If My.Application.Info.Version.ToString > FileInfo Then '만약 어셈블리 버전이 FileInfo 보다 값이 크면
                MsgBox("You are using a Test Version!" & vbNewLine & vbNewLine & "Current Version : " & FileInfo & vbNewLine &
                       "Your Test Version : " & My.Application.Info.Version.ToString, vbInformation)
            End If
        Else
            MsgBox("Network Connect Failed! Can't Check For Updates.", vbCritical)
        End If
    End Sub

    Private Sub Tip2_Click(sender As Object, e As EventArgs) Handles Tip1.Click
        MsgBox("Otherwise, UniSkin Editor will show Error.", vbInformation)
    End Sub

    Private Sub ResetImagesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetImagesToolStripMenuItem.Click
        Dim drawFile As String = "WorkSpace\drawable\"
        Dim SdrawFile As String = "WorkSpace\Images\"

        If MessageBox.Show("Do you want to reset the Images?", "UniSkin Editor", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            If Dir("WorkSpace\drawable", vbDirectory) <> "" Then
                If Dir("WorkSpace\Images", vbDirectory) <> "" Then
ImageSetLine:
                    '새로운 기능이 추가되면 꼭 저장 선언을 해줘야 함.
                    IO.File.Copy(SdrawFile & "appicon.png", drawFile & "appicon.png", True) '리셋할 이미지 리소스 복사
                    IO.File.Copy(SdrawFile & "playbg.png", drawFile & "playbg.png", True)
                    IO.File.Copy(SdrawFile & "theme_ic.png", drawFile & "theme_ic.png", True)
                    IO.File.Copy(SdrawFile & "phantom.png", drawFile & "phantom.png", True)
                    IO.File.Copy(SdrawFile & "phantom_.png", drawFile & "phantom_.png", True)
                    IO.File.Copy(SdrawFile & "chain.png", drawFile & "chain.png", True)
                    IO.File.Copy(SdrawFile & "chain_.png", drawFile & "chain_.png", True)
                    IO.File.Copy(SdrawFile & "chain__.png", drawFile & "chain__.png", True)

                    Dim appicon1 As New System.IO.FileStream(SdrawFile & "appicon.png", IO.FileMode.Open, IO.FileAccess.Read)
                    Dim playbg1 As New System.IO.FileStream(SdrawFile & "playbg.png", IO.FileMode.Open, IO.FileAccess.Read)
                    Dim themeicon1 As New System.IO.FileStream(SdrawFile & "theme_ic.png", IO.FileMode.Open, IO.FileAccess.Read)
                    Dim phantom1 As New System.IO.FileStream(SdrawFile & "phantom.png", IO.FileMode.Open, IO.FileAccess.Read)
                    Dim phantom_1 As New System.IO.FileStream(SdrawFile & "phantom_.png", IO.FileMode.Open, IO.FileAccess.Read)
                    Dim chain1 As New System.IO.FileStream(SdrawFile & "chain.png", IO.FileMode.Open, IO.FileAccess.Read)
                    Dim chain_1 As New System.IO.FileStream(SdrawFile & "chain_.png", IO.FileMode.Open, IO.FileAccess.Read)
                    Dim chain__1 As New System.IO.FileStream(SdrawFile & "chain__.png", IO.FileMode.Open, IO.FileAccess.Read)

                    Dim appicon2 As Image = Image.FromStream(appicon1) '다른 프로세스 사용 중 방지하기 위해 Image.FromStream 선언
                    Dim playbg2 As Image = Image.FromStream(playbg1)
                    Dim themeicon2 As Image = Image.FromStream(themeicon1)
                    Dim phantom2 As Image = Image.FromStream(phantom1)
                    Dim phantom_2 As Image = Image.FromStream(phantom_1)
                    Dim chain2 As Image = Image.FromStream(chain1)
                    Dim chain_2 As Image = Image.FromStream(chain_1)
                    Dim chain__2 As Image = Image.FromStream(chain__1)

                    '프로세스 사용 중 에러 방지
                    appicon1.Close() '꼭 선언 다한 후 .Close() 를 해줘야 함.
                    playbg1.Close() '안그러면 다른 프로세스에 사용 중이라고 오류가 펑펑!
                    themeicon1.Close()
                    phantom1.Close()
                    phantom_1.Close()
                    chain1.Close()
                    chain_1.Close()
                    chain__1.Close()

                    If IO.File.Exists(SdrawFile & "chainled.png") Then  '구유니스킨 chainled가 없는 오류 대비문
                        IO.File.Copy(SdrawFile & "chainled.png", drawFile & "chainled.png", True)
                        Dim chainled1 As New System.IO.FileStream(SdrawFile & "chainled.png", IO.FileMode.Open, IO.FileAccess.Read)
                        Dim chainled2 As Image = Image.FromStream(chainled1)
                        ImagesAdvanced.ChainLEDSample1.Image = chainled2
                        chainled1.Close()
                    End If

                    AppIconSample1.Image = appicon2
                    PopSkinSample1.Image = playbg2
                    ThemeIconSample1.Image = themeicon2
                    ImagesAdvanced.PhantomSample1.Image = phantom2
                    ImagesAdvanced.PhantomCornerSample1.Image = phantom_2
                    ImagesAdvanced.ChainSample1.Image = chain2
                    ImagesAdvanced.SelChainSample1.Image = chain_2
                    ImagesAdvanced.NextChainSample1.Image = chain__2

                    MessageBox.Show("Reset Images!", "UniSkin Editor", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MsgBox("Reset Failed! Error Code: 9" & vbNewLine & "Warning: Can't Find a Images Folder!", vbCritical) '예외 throw: 이미지 로드 실패
                End If
            Else
                MsgBox("Reset Failed! Error Code: 9" & vbNewLine & "Warning: Can't Find a Images Folder!", vbCritical) '예외 throw: 이미지 로드 실패
            End If
        End If
    End Sub

    Private Sub CleanTheTempoaryFilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CleanTheTempoaryFilesToolStripMenuItem.Click
        If MessageBox.Show("Do you want to clean the Tempoary Files?", "UniSkin Editor", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            CleanFiles.Show()
        End If
    End Sub

    Private Sub CheckUpdate()
        Dim Client As New WebClient
        Dim vFile = Application.StartupPath + "\Data\version.ini"
        Dim sFile = Application.StartupPath + "\settings.ini"
        Dim ChkUpdate As String = ReadIni(sFile, "USKESettings", "CheckUpdate", "")
        Dim FileInfo As String = ReadIni(vFile, "Version", "version", "")

        If (My.Computer.Network.IsAvailable = True) Then '만약 네트워크가 연결 되있다면
            If ChkUpdate = "True" Then '만약 CheckUpdate 의 값이 "True" 라면
                If My.Application.Info.Version.ToString < FileInfo Then '만약 어셈블리 버전보다 FileInfo 가 더 크면
                    If MessageBox.Show("New Version " & FileInfo & " is Available! You can Update later for (About> Check Update)." & vbNewLine & vbNewLine & "Current Version : " & My.Application.Info.Version.ToString & vbNewLine & "Latest Version : " & FileInfo, "UniSkin Editor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        ProgramUpdate.DLabel1.Left = 101
                        ProgramUpdate.DLabel1.Top = 108
                        ProgramUpdate.DLabel1.Text = "Downloading UniSkin Editor " & FileInfo & " ..."
                        ProgramUpdate.DProgress1.Value = 800
                        ProgramUpdate.Show()
                        ProgramUpdate.DProgress1.MarqueeAnimationSpeed = 100
                        Client.DownloadFile("http://download.uniske.kro.kr", "Update.zip") 'Update.zip 으로 다운로드
                        If Dir("UniSkin Editor_v" & FileInfo, vbDirectory) <> "" Then
                            If IO.File.Exists("UniSkin Editor_v" & FileInfo & "\UniSkin Editor.exe") Then
                                My.Computer.FileSystem.DeleteDirectory("UniSkin Editor_v" & FileInfo, FileIO.DeleteDirectoryOption.DeleteAllContents)
                                My.Computer.FileSystem.CreateDirectory("UniSkin Editor_v" & FileInfo)
                                ZipFile.ExtractToDirectory("Update.zip", "UniSkin Editor_v" & FileInfo)  'Zip 파일을 압축 풀기
                            Else
                                ZipFile.ExtractToDirectory("Update.zip", "UniSkin Editor_v" & FileInfo)
                            End If
                        Else
                            My.Computer.FileSystem.CreateDirectory("UniSkin Editor_v" & FileInfo)
                            ZipFile.ExtractToDirectory("Update.zip", "UniSkin Editor_v" & FileInfo)
                        End If
                        Threading.Thread.Sleep(3000)  '3초 대기
                        ProgramUpdate.DProgress1.Value = 1000
                        If ProgramUpdate.DProgress1.Value = 1000 Then
                            ProgramUpdate.DLabel1.Left = 151
                            ProgramUpdate.DLabel1.Top = 108
                            ProgramUpdate.DLabel1.Text = "Update Complete!"
                            If MsgBox("Update Complete! UniSkin Editor " & FileInfo & " is in [UniSkin Editor_v" & FileInfo & "] Folder.", vbInformation) = vbOK Then
                                IO.File.Delete("Update.zip") 'Update.zip 파일 삭제
                                ProgramUpdate.Close() 'Update 끝!
                            End If
                        End If
                        If ReadIni(sFile, "USKESettings", "LatestVer", "") = "True" Then
                            If IO.File.Exists("UniSkin Editor_v" & FileInfo & "\UniSkin Editor.exe") Then
                                Process.Start("UniSkin Editor_v" & FileInfo & "\UniSkin Editor.exe") '업데이트 한 유니스킨 에디터 실행.
                                End '프로세스 종료.
                            Else
                                'UniSkin Editor.exe 가 없을 때 발생하는 오류.
                                MessageBox.Show("Error Code: 9" & vbNewLine & "Warning: UniSkin Editor Can't Run Latest Version UniSkin Editor. UniSkin Editor don't exist!", "UniSkin Editor: Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End If
                    End If
                End If
            End If
        Else
            MsgBox("Network Connect Failed! Can't Check For Updates.", vbCritical)
        End If
    End Sub
End Class
