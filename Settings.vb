Imports System.IO
Imports System.Text
Imports System.Windows
Module modINI
    'ini 파일 구조
    Private Declare Unicode Function WritePrivateProfileString Lib "kernel32" _
    Alias "WritePrivateProfileStringW" (ByVal lpApplicationName As String,
    ByVal lpKeyName As String, ByVal lpString As String,
    ByVal lpFileName As String) As Int32

    Private Declare Unicode Function GetPrivateProfileString Lib "kernel32" _
    Alias "GetPrivateProfileStringW" (ByVal lpApplicationName As String,
    ByVal lpKeyName As String, ByVal lpDefault As String,
    ByVal lpReturnedString As String, ByVal nSize As Int32,
    ByVal lpFileName As String) As Int32

    Public Sub writeIni(ByVal iniFileName As String, ByVal Section As String, ByVal ParamName As String, ByVal ParamVal As String)
        Dim Result As Integer = WritePrivateProfileString(Section, ParamName, ParamVal, iniFileName)
    End Sub

    Public Function ReadIni(ByVal IniFileName As String, ByVal Section As String, ByVal ParamName As String, ByVal ParamDefault As String) As String
        Dim ParamVal As String = Space$(1024)
        Dim LenParamVal As Long = GetPrivateProfileString(Section, ParamName, ParamDefault, ParamVal, Len(ParamVal), IniFileName)
        ReadIni = Left$(ParamVal, LenParamVal)
    End Function
End Module
Public Class Settings
    Public strdata As New System.Text.StringBuilder(255)
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim File = Application.StartupPath + "\settings.ini"
        Dim Section = "USKESettings"
        Dim CheckUpdate = "CheckUpdate"

        'ini 파일 CheckUpdate 사항 읽기
        If ReadIni(File, Section, CheckUpdate, "") = "True" Then '만약 UpdateCheck2 의 텍스트가 True 면
            UpdateCheck1.Checked = True 'UpdateCheck1 을 체크
        Else
            UpdateCheck1.Checked = False 'UpdateCheck1 을 체크 해제
        End If

        If ReadIni(File, Section, "CHIMG", "") = "True" Then '만약 CHIMG 의 텍스트가 True 면
            ChImgs1.Checked = True 'ChImg1 을 체크
        Else
            ChImgs1.Checked = False 'ChImg1 을 체크 해제
        End If

        If ReadIni(File, Section, "LatestVer", "") = "True" Then '만약 CHIMG 의 텍스트가 True 면
            LatestVer1.Checked = True  'LatestVer1 을 체크
        Else
            LatestVer1.Checked = False 'LatestVer1 을 체크 해제
        End If
    End Sub

    Private Sub Save1_Click(sender As Object, e As EventArgs) Handles Save1.Click
        Dim File = Application.StartupPath + "\settings.ini"
        Dim Section = "USKESettings"

        If UpdateCheck1.Checked = True Then 'CheckUpdate 체크
            writeIni(File, Section, "CheckUpdate", "True")
        Else
            writeIni(File, Section, "CheckUpdate", "False")
        End If
        If ChImgs1.Checked = True Then 'CHIMG 체크
            writeIni(File, Section, "CHIMG", "True")
        Else
            writeIni(File, Section, "CHIMG", "False")
        End If
        MsgBox("Settings Saved!", vbInformation)

        If ChInfo1.Checked = True Then 'CHINFO 체크
            writeIni(File, Section, "CHINFO", "True")
        Else
            writeIni(File, Section, "CHINFO", "False")
        End If

        If LatestVer1.Checked = True Then 'LatestVer 체크
            writeIni(File, Section, "LatestVer", "True")
        Else
            writeIni(File, Section, "LatestVer", "False")
        End If
    End Sub

    Private Sub Tip1_Click(sender As Object, e As EventArgs) Handles Tip1.Click
        MsgBox("When you Open Project, Change Menu Sample Resources to you opened UniSkin Resources.", vbInformation)
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
End Class