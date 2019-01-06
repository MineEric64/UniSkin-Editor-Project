Public Class CleanFiles
    Private Sub CleanFiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim File = Application.StartupPath + "\settings.ini"
        Dim Section = "UniClean"

        If ReadIni(File, Section, "CWor", "") = "True" Then
            CWorkspace1.Checked = True
        Else
            CWorkspace1.Checked = False
        End If

        If ReadIni(File, Section, "CPrj", "") = "True" Then
            CProject1.Checked = True
        Else
            CProject1.Checked = False
        End If
    End Sub

    Private Sub StartButton1_Click(sender As Object, e As EventArgs) Handles StartButton1.Click
        Dim Skip As Integer = 0
        Dim File = Application.StartupPath + "\settings.ini"
        Dim Section = "UniClean"

        Try
            '세팅 파일 저장.
            If CWorkspace1.Checked = True Then 'CWorkSpace1 텍스트박스 = CWor ini
                writeIni(File, Section, "CWor", "True")
            Else
                writeIni(File, Section, "CWor", "False")
            End If

            If CProject1.Checked = True Then 'CProject1 텍스트박스 = CPrj ini
                writeIni(File, Section, "CPrj", "True")
            Else
                writeIni(File, Section, "CPrj", "False")
            End If

            'Workspace 폴더 정리.
            If CWorkspace1.Checked = True Then
                If Dir("WorkSpace", vbDirectory) <> "" Then
                    My.Computer.FileSystem.DeleteDirectory("WorkSpace", FileIO.DeleteDirectoryOption.DeleteAllContents)
                Else
                    MsgBox("Not Founded in Workspace Folder!", MsgBoxStyle.Information)
                End If
            End If

            '임시 유니스킨 파일 정리.
            If CProject1.Checked = True Then
                If IO.File.Exists("Apktool\unisample.apk") Then
                    IO.File.Delete("Apktool\unisample.apk") 'Open Project.
                Else
                    Skip = Skip + 10
                End If

                If IO.File.Exists("Apktool\null") Then
                    IO.File.Delete("Apktool\null")  'Tempoary File.
                Else
                    Skip = Skip + 10
                End If

                If IO.File.Exists("Apktool\Read me.txt") Then
                    IO.File.Delete("Apktool\Read me.txt") 'Tempoary File.
                Else
                    Skip = Skip + 10
                End If

                If IO.File.Exists("Apktool\SignApk\unisample.apk") Then
                    IO.File.Delete("Apktool\SignApk\unisample.apk") 'Tempoary File.
                Else
                    Skip = Skip + 10
                End If

                If IO.File.Exists("Apktool\SignApk\Signing.txt") Then
                    IO.File.Delete("Apktool\SignApk\Signing.txt") 'Tempoary File.
                Else
                    Skip = Skip + 10
                End If

                If IO.File.Exists("Apktool\SignApk\README.md") Then
                    IO.File.Delete("Apktool\SignApk\README.md") 'Tempoary File.
                Else
                    Skip = Skip + 10
                End If

                If Skip = 60 Then 'Skip이 60 인경우
                    MsgBox("Not Founded in Tempoary UniSkin Files!", MsgBoxStyle.Information)
                Else
                    MsgBox("Cleaned the Tempoary FIles!", MsgBoxStyle.Information)
                End If
                Skip = 0 '리소스 값 리셋.
            End If

            If CWorkspace1.Checked = False Then
                If CProject1.Checked = False Then '청소할게 없어요.
                    MsgBox("There is Nothing to Clean the Tempoary Files!" & vbNewLine & "Please Check in CheckBox!", MsgBoxStyle.Exclamation)
                End If
            End If
        Catch ex As Exception '예외 오류 잡기
            MessageBox.Show("Error Code: Unknown" & vbNewLine & "Warning: " & ex.Message, "UniSkin Editor: Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CancelButton1_Click(sender As Object, e As EventArgs) Handles CancelButton1.Click
        Me.Close()
    End Sub
End Class