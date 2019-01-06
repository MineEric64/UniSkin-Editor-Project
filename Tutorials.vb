Public Class Tutorials
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("If you want to help, Please Send the Email." & vbNewLine & "Developer Email : besteric40@gmail.com", vbOKOnly, "UniSkin Editor")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TutorialsBox1.SelectedIndexChanged
        '에러 코드 9
        If TutorialsBox1.Text = "[What is Error Code: 9?]" Then
            RichTextBox1.Text = "Error Code: 9 is The File/ Folder already exists or does not exist. So, You should a Create, or Delete The Folder/ File Directly." & vbNewLine & vbNewLine &
                "에러 코드: 9는 그 파일이 이미 존재하거나 없는 오류입니다. 해결방법은, 직접 폴더를 만드시거나, 폴더를 삭제 해야 합니다."
        End If
        '유니스킨 여는 방법
        If TutorialsBox1.Text = "[How to Open UniSkin?]" Then
            RichTextBox1.Text = "First, Download a UniSkin. (When you haven't UniSkin, Then Press the Make a UniSkin.) Then, Open UniSkin APK. Then You can Edit!" & vbNewLine & vbNewLine &
                "먼저, 유니스킨을 다운로드 하세요. (유니스킨을 가지고 있지 않다면, Make a UniSkin 을 누르세요. 그 다음, 유니스킨 APK를 엽니다. 이제 편집할 수 있습니다!"
        End If
        '업데이트 체크 확인 방법
        If TutorialsBox1.Text = "[How to Check for Updates?]" Then
            RichTextBox1.Text = "First, Visit ( uniske.kro.kr ). Then, Press the Download Button. Then, You can Download UniSkin Editor for Latest Version. Or, You can check Update in Settings." & vbNewLine & vbNewLine &
                "먼저, ( uniske.kro.kr ) 에 들어가셔서 다운로드 버튼을 누르세요. 그러면, UniSkin Editor 최신 버전을 다운로드 하실 수 있습니다. 아니면, 설정에서 업데이트를 확인할 수 있습니다."
        End If
        'Save Project가 작동하지 않는 경우
        If TutorialsBox1.Text = "[Save Project is Not Working!]" Then
            RichTextBox1.Text = "Click Edit>Install FrameWork. If Save Project is still not Working, Click Edit>Remove FrameWork. If This Solution can't solve, Please Send the Error." & vbNewLine & "Developer Email : besteric40@gmail.com" & vbNewLine & vbNewLine &
                "Edit>Install FrameWork를 클릭하세요. 그래도 작동하지 않는다면, Edit>Remove FrameWork를 클릭하세요. 이 해결 방법으로 해결 되지 않는다면, 오류사항을 보내주세요." & vbNewLine & "개발자 이메일 : besteric40@gmail.com"
        End If
        '에러: 유니스킨 리소스 찾지 못할 때
        If TutorialsBox1.Text = "[Error: Can't Find a UniSkin Resources.]" Then
            RichTextBox1.Text = "This Error is You opened a UniSkin Doesn't have Resources or UniSkin Editor can't open Resources. Check You opened a UniSkin has Resources, Also Check UniSkin Editor is Latest Version. Oh, Did you Click Make a UniSkin?" & vbNewLine & vbNewLine &
            "당신이 열은 유니스킨이 리소스를 가지고 있지 않거나 유니스킨 에디터가 리소스를 불러오지 못할 때 나오는 오류입니다. 당신이 열은 유니스킨이 리소스를 가지고 있는지, 또한 유니스킨 에디터가 최신버전인지 확인해보세요. 오우, Make a UniSkin은 눌러보셨나요?"
        End If
    End Sub
End Class