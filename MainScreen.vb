Public Class MainScreen
    Private Sub MainScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar_Value.Enabled = True 'ProgressBar_Value 타이버 활성화
        VerText1.Text = My.Application.Info.Version.ToString '버전 텍스트를 프로그램 버전으로 업데이트
    End Sub

    Private Sub ProgressBar_Value_Tick(sender As Object, e As EventArgs) Handles ProgressBar_Value.Tick
        If LoadBar1.Value = "360" Then
            ProgressBar_Value.Enabled = False
        Else
            LoadBar1.Value = LoadBar1.Value + 15
        End If
    End Sub
End Class