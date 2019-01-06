Public Class Info2
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.DoubleClick
        '이스터에그 1
        MsgBox("UI & Sources By 최에릭" & vbNewLine & "Codes By Follow_JB & 최에릭", vbInformation, "UniSkin Editor")
    End Sub

    Private Sub InfoP_Click(sender As Object, e As EventArgs) Handles InfoP.DoubleClick
        '이스터에그 2
        MsgBox("The Worst of UniPad IDE Editor.", MsgBoxStyle.Information, "UniSkin Editor")
    End Sub

    Private Sub uniseLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles uniskeLabel1.LinkClicked
        Shell("explorer.exe http://uniske.kro.kr")
    End Sub

    Private Sub unitorLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles unitorLabel1.LinkClicked
        Shell("explorer.exe http://unitor.ga")
    End Sub

    Private Sub OKButton1_Click(sender As Object, e As EventArgs) Handles OKButton1.Click

        If ModeE.Text = "Follow_JB" Then
            '이스터에그 1
            MsgBox("He's a God of Unitor." & vbNewLine & "He can do Everything. He's a Super Ultra Ultimate Fantastic God :D", vbInformation)
        Else
            If ModeE.Text = "Unitor" Then
                '이스터에그 2
                MsgBox("Godnitor Appeared!!!" & vbNewLine & "Godnitor = Unitor", vbInformation)
            Else
                '정보
                If ModeE.Text = "UniSkinEditor" Then
                    MsgBox("UniSkin Editor Ver. " & My.Application.Info.Version.ToString & " By 최에릭" & vbNewLine &
                           "Apktool Ver. 2.3.1 By Ryszard Wiśniewski, Connor Tumbleson" & vbNewLine & "SignAPK By TechExpertize", vbInformation)
                Else
                    MsgBox("Incorrect! :(", vbExclamation, "UniSkin Editor")
                End If
            End If
        End If
    End Sub

    Private Sub Info2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ver1.Text = "Ver " & My.Application.Info.Version.ToString 'UniSkin Editor 어셈블리 버전 갖고온 후 String 으로 버전 표시
    End Sub
End Class