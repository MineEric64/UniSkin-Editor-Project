Imports System.IO
Public Class ImagesAdvanced
    Private Sub PhantomSample1_Click(sender As Object, e As EventArgs) Handles PhantomSample1.DoubleClick
        Dim curFile As String = "WorkSpace\drawable"
        Dim drawFile As String = "WorkSpace\drawable\"

        If Dir(curFile, vbDirectory) <> "" Then '만약 WorkSpace\drawable 폴더가 있으면
            File.Copy("Data\EditSamples\drawable\phantom.png", "WorkSpace\drawable\phantom.png", True) '파일 복사, 덮어쓰기 허용

            Dim phantom1 As New System.IO.FileStream(drawFile & "phantom.png", IO.FileMode.Open, IO.FileAccess.Read)
            Dim phantom_1 As New System.IO.FileStream(drawFile & "phantom_.png", IO.FileMode.Open, IO.FileAccess.Read)
            Dim chain1 As New System.IO.FileStream(drawFile & "chain.png", IO.FileMode.Open, IO.FileAccess.Read)
            Dim chain_1 As New System.IO.FileStream(drawFile & "chain_.png", IO.FileMode.Open, IO.FileAccess.Read)
            Dim chain__1 As New System.IO.FileStream(drawFile & "chain__.png", IO.FileMode.Open, IO.FileAccess.Read)

            Dim phantom2 As Image = Image.FromStream(phantom1) '다른 프로세스 사용 중 방지하기 위해 Image.FromStream 선언
            Dim phantom_2 As Image = Image.FromStream(phantom_1)
            Dim chain2 As Image = Image.FromStream(chain1)
            Dim chain_2 As Image = Image.FromStream(chain_1)
            Dim chain__2 As Image = Image.FromStream(chain__1)

            phantom1.Close()
            phantom_1.Close()
            chain1.Close()
            chain_1.Close()
            chain__1.Close()

            TextFileName1.Text = "Data\EditSamples\drawable\phantom.png"
            PhantomSample1.Image = phantom2
            MsgBox("Imported Sample Phantom Icon!", vbInformation)
        Else
            MsgBox("Import Failed! Error Code: 9" & vbNewLine & "Warning: Can't Find a Images Folder!", vbCritical)
        End If
    End Sub

    Private Sub ImportPhantom1_Click(sender As Object, e As EventArgs) Handles ImportPhantom1.Click
        Dim ofdEdit As New OpenFileDialog
        Dim curFile As String = "WorkSpace\drawable"
        Dim drawFile As String = "WorkSpace\drawable\"

        '팬텀 가져오기
        ofdEdit.Filter = "PNG Files|*.png"
        ofdEdit.Title = "Select Phantom File"

        If ofdEdit.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            If Dir(curFile, vbDirectory) <> "" Then
                File.Copy(ofdEdit.FileName, "WorkSpace\drawable\phantom.png", True)

                Dim phantom1 As New System.IO.FileStream(drawFile & "phantom.png", IO.FileMode.Open, IO.FileAccess.Read)
                Dim phantom_1 As New System.IO.FileStream(drawFile & "phantom_.png", IO.FileMode.Open, IO.FileAccess.Read)
                Dim chain1 As New System.IO.FileStream(drawFile & "chain.png", IO.FileMode.Open, IO.FileAccess.Read)
                Dim chain_1 As New System.IO.FileStream(drawFile & "chain_.png", IO.FileMode.Open, IO.FileAccess.Read)
                Dim chain__1 As New System.IO.FileStream(drawFile & "chain__.png", IO.FileMode.Open, IO.FileAccess.Read)

                Dim phantom2 As Image = Image.FromStream(phantom1) '다른 프로세스 사용 중 방지하기 위해 Image.FromStream 선언
                Dim phantom_2 As Image = Image.FromStream(phantom_1)
                Dim chain2 As Image = Image.FromStream(chain1)
                Dim chain_2 As Image = Image.FromStream(chain_1)
                Dim chain__2 As Image = Image.FromStream(chain__1)

                TextFileName1.Text = ofdEdit.FileName
                PhantomSample1.Image = phantom2

                phantom1.Close()
                phantom_1.Close()
                chain1.Close()
                chain_1.Close()
                chain__1.Close()

                MsgBox("Imported Phantom!", vbInformation)
            Else
                MsgBox("Import Failed! Error Code: 9" & vbNewLine & "Warning: Can't Find a Images Folder!", vbCritical)
            End If
        End If
    End Sub

    Private Sub ImportPhantomCorner_Click(sender As Object, e As EventArgs) Handles ImportPhantomCorner.Click
        Dim ofdEdit As New OpenFileDialog
        Dim curFile As String = "WorkSpace\drawable"
        Dim drawFile As String = "WorkSpace\drawable\"

        '팬텀 가장자리 가져오기
        ofdEdit.Filter = "PNG Files|*.png"
        ofdEdit.Title = "Select Phantom Corner File"

        If ofdEdit.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            If Dir(curFile, vbDirectory) <> "" Then
                File.Copy(ofdEdit.FileName, "WorkSpace\drawable\phantom_.png", True)

                Dim phantom1 As New System.IO.FileStream(drawFile & "phantom.png", IO.FileMode.Open, IO.FileAccess.Read)
                Dim phantom_1 As New System.IO.FileStream(drawFile & "phantom_.png", IO.FileMode.Open, IO.FileAccess.Read)
                Dim chain1 As New System.IO.FileStream(drawFile & "chain.png", IO.FileMode.Open, IO.FileAccess.Read)
                Dim chain_1 As New System.IO.FileStream(drawFile & "chain_.png", IO.FileMode.Open, IO.FileAccess.Read)
                Dim chain__1 As New System.IO.FileStream(drawFile & "chain__.png", IO.FileMode.Open, IO.FileAccess.Read)

                Dim phantom2 As Image = Image.FromStream(phantom1) '다른 프로세스 사용 중 방지하기 위해 Image.FromStream 선언
                Dim phantom_2 As Image = Image.FromStream(phantom_1)
                Dim chain2 As Image = Image.FromStream(chain1)
                Dim chain_2 As Image = Image.FromStream(chain_1)
                Dim chain__2 As Image = Image.FromStream(chain__1)

                TextFileName2.Text = ofdEdit.FileName
                PhantomCornerSample1.Image = phantom_2

                phantom1.Close()
                phantom_1.Close()
                chain1.Close()
                chain_1.Close()
                chain__1.Close()

                MsgBox("Imported Phantom Corner!", vbInformation)
            Else
                MsgBox("Import Failed! Error Code: 9" & vbNewLine & "Warning: Can't Find a Images Folder!", vbCritical)
            End If
        End If
    End Sub

    Private Sub PhantomCornerSample1_Click(sender As Object, e As EventArgs) Handles PhantomCornerSample1.DoubleClick
        Dim curFile As String = "WorkSpace\drawable"
        Dim drawFile As String = "WorkSpace\drawable\"

        If Dir(curFile, vbDirectory) <> "" Then '만약 WorkSpace\drawable 폴더가 있으면
            File.Copy("Data\EditSamples\drawable\phantom_.png", "WorkSpace\drawable\phantom_.png", True) '파일 복사, 덮어쓰기 허용

            Dim phantom1 As New System.IO.FileStream(drawFile & "phantom.png", IO.FileMode.Open, IO.FileAccess.Read)
            Dim phantom_1 As New System.IO.FileStream(drawFile & "phantom_.png", IO.FileMode.Open, IO.FileAccess.Read)
            Dim chain1 As New System.IO.FileStream(drawFile & "chain.png", IO.FileMode.Open, IO.FileAccess.Read)
            Dim chain_1 As New System.IO.FileStream(drawFile & "chain_.png", IO.FileMode.Open, IO.FileAccess.Read)
            Dim chain__1 As New System.IO.FileStream(drawFile & "chain__.png", IO.FileMode.Open, IO.FileAccess.Read)

            Dim phantom2 As Image = Image.FromStream(phantom1) '다른 프로세스 사용 중 방지하기 위해 Image.FromStream 선언
            Dim phantom_2 As Image = Image.FromStream(phantom_1)
            Dim chain2 As Image = Image.FromStream(chain1)
            Dim chain_2 As Image = Image.FromStream(chain_1)
            Dim chain__2 As Image = Image.FromStream(chain__1)

            TextFileName2.Text = "Data\EditSamples\drawable\phantom_.png"
            PhantomCornerSample1.Image = phantom_2

            phantom1.Close()
            phantom_1.Close()
            chain1.Close()
            chain_1.Close()
            chain__1.Close()

            MsgBox("Imported Sample Phantom Corner!", vbInformation)
        Else
            MsgBox("Import Failed! Error Code: 9" & vbNewLine & "Warning: Can't Find a Images Folder!", vbCritical)
        End If
    End Sub

    Private Sub ChainSample1_Click(sender As Object, e As EventArgs) Handles ChainSample1.DoubleClick
        Dim curFile As String = "WorkSpace\drawable"
        Dim drawFile As String = "WorkSpace\drawable\"

        If Dir(curFile, vbDirectory) <> "" Then '만약 WorkSpace\drawable 폴더가 있으면
            File.Copy("Data\EditSamples\drawable\chain.png", "WorkSpace\drawable\chain.png", True) '파일 복사, 덮어쓰기 허용

            Dim phantom1 As New System.IO.FileStream(drawFile & "phantom.png", IO.FileMode.Open, IO.FileAccess.Read)
            Dim phantom_1 As New System.IO.FileStream(drawFile & "phantom_.png", IO.FileMode.Open, IO.FileAccess.Read)
            Dim chain1 As New System.IO.FileStream(drawFile & "chain.png", IO.FileMode.Open, IO.FileAccess.Read)
            Dim chain_1 As New System.IO.FileStream(drawFile & "chain_.png", IO.FileMode.Open, IO.FileAccess.Read)
            Dim chain__1 As New System.IO.FileStream(drawFile & "chain__.png", IO.FileMode.Open, IO.FileAccess.Read)

            Dim phantom2 As Image = Image.FromStream(phantom1) '다른 프로세스 사용 중 방지하기 위해 Image.FromStream 선언
            Dim phantom_2 As Image = Image.FromStream(phantom_1)
            Dim chain2 As Image = Image.FromStream(chain1)
            Dim chain_2 As Image = Image.FromStream(chain_1)
            Dim chain__2 As Image = Image.FromStream(chain__1)

            TextFileName3.Text = "Data\EditSamples\drawable\chain.png"
            ChainSample1.Image = chain2

            phantom1.Close()
            phantom_1.Close()
            chain1.Close()
            chain_1.Close()
            chain__1.Close()

            MsgBox("Imported Sample Chain!", vbInformation)
        Else
            MsgBox("Import Failed! Error Code: 9" & vbNewLine & "Warning: Can't Find a Images Folder!", vbCritical)
        End If
    End Sub
    Private Sub ImportChain1_Click(sender As Object, e As EventArgs) Handles ImportChain1.Click
        Dim ofdEdit As New OpenFileDialog
        Dim curFile As String = "WorkSpace\drawable"
        Dim drawFile As String = "WorkSpace\drawable\"

        '체인 가져오기
        ofdEdit.Filter = "PNG Files|*.png"
        ofdEdit.Title = "Select Chain File"

        If ofdEdit.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            If Dir(curFile, vbDirectory) <> "" Then
                File.Copy(ofdEdit.FileName, "WorkSpace\drawable\chain.png", True)

                Dim phantom1 As New System.IO.FileStream(drawFile & "phantom.png", IO.FileMode.Open, IO.FileAccess.Read)
                Dim phantom_1 As New System.IO.FileStream(drawFile & "phantom_.png", IO.FileMode.Open, IO.FileAccess.Read)
                Dim chain1 As New System.IO.FileStream(drawFile & "chain.png", IO.FileMode.Open, IO.FileAccess.Read)
                Dim chain_1 As New System.IO.FileStream(drawFile & "chain_.png", IO.FileMode.Open, IO.FileAccess.Read)
                Dim chain__1 As New System.IO.FileStream(drawFile & "chain__.png", IO.FileMode.Open, IO.FileAccess.Read)

                Dim phantom2 As Image = Image.FromStream(phantom1) '다른 프로세스 사용 중 방지하기 위해 Image.FromStream 선언
                Dim phantom_2 As Image = Image.FromStream(phantom_1)
                Dim chain2 As Image = Image.FromStream(chain1)
                Dim chain_2 As Image = Image.FromStream(chain_1)
                Dim chain__2 As Image = Image.FromStream(chain__1)

                TextFileName3.Text = ofdEdit.FileName
                ChainSample1.Image = chain2

                phantom1.Close()
                phantom_1.Close()
                chain1.Close()
                chain_1.Close()
                chain__1.Close()

                MsgBox("Imported Chain!", vbInformation)
            Else
                MsgBox("Import Failed! Error Code: 9" & vbNewLine & "Warning: Can't Find a Images Folder!", vbCritical)
            End If
        End If
    End Sub

    Private Sub ImportSelChain_Click(sender As Object, e As EventArgs) Handles ImportSelChain1.Click
        Dim ofdEdit As New OpenFileDialog
        Dim curFile As String = "WorkSpace\drawable"
        Dim drawFile As String = "WorkSpace\drawable\"

        '선택 체인 가져오기
        ofdEdit.Filter = "PNG Files|*.png"
        ofdEdit.Title = "Select Selected Chain File"

        If ofdEdit.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            If Dir(curFile, vbDirectory) <> "" Then
                File.Copy(ofdEdit.FileName, "WorkSpace\drawable\chain_.png", True)

                Dim phantom1 As New System.IO.FileStream(drawFile & "phantom.png", IO.FileMode.Open, IO.FileAccess.Read)
                Dim phantom_1 As New System.IO.FileStream(drawFile & "phantom_.png", IO.FileMode.Open, IO.FileAccess.Read)
                Dim chain1 As New System.IO.FileStream(drawFile & "chain.png", IO.FileMode.Open, IO.FileAccess.Read)
                Dim chain_1 As New System.IO.FileStream(drawFile & "chain_.png", IO.FileMode.Open, IO.FileAccess.Read)
                Dim chain__1 As New System.IO.FileStream(drawFile & "chain__.png", IO.FileMode.Open, IO.FileAccess.Read)

                Dim phantom2 As Image = Image.FromStream(phantom1) '다른 프로세스 사용 중 방지하기 위해 Image.FromStream 선언
                Dim phantom_2 As Image = Image.FromStream(phantom_1)
                Dim chain2 As Image = Image.FromStream(chain1)
                Dim chain_2 As Image = Image.FromStream(chain_1)
                Dim chain__2 As Image = Image.FromStream(chain__1)

                TextFileName4.Text = ofdEdit.FileName
                SelChainSample1.Image = chain_2

                phantom1.Close()
                phantom_1.Close()
                chain1.Close()
                chain_1.Close()
                chain__1.Close()

                MsgBox("Imported Selected Chain!", vbInformation)
            Else
                MsgBox("Import Failed! Error Code: 9" & vbNewLine & "Warning: Can't Find a Images Folder!", vbCritical)
            End If
        End If
    End Sub

    Private Sub SelChainSample1_Click(sender As Object, e As EventArgs) Handles SelChainSample1.DoubleClick
        Dim curFile As String = "WorkSpace\drawable"
        Dim drawFile As String = "WorkSpace\drawable\"

        If Dir(curFile, vbDirectory) <> "" Then '만약 WorkSpace\drawable 폴더가 있으면
            File.Copy("Data\EditSamples\drawable\chain_.png", "WorkSpace\drawable\chain_.png", True) '파일 복사, 덮어쓰기 허용

            Dim phantom1 As New System.IO.FileStream(drawFile & "phantom.png", IO.FileMode.Open, IO.FileAccess.Read)
            Dim phantom_1 As New System.IO.FileStream(drawFile & "phantom_.png", IO.FileMode.Open, IO.FileAccess.Read)
            Dim chain1 As New System.IO.FileStream(drawFile & "chain.png", IO.FileMode.Open, IO.FileAccess.Read)
            Dim chain_1 As New System.IO.FileStream(drawFile & "chain_.png", IO.FileMode.Open, IO.FileAccess.Read)
            Dim chain__1 As New System.IO.FileStream(drawFile & "chain__.png", IO.FileMode.Open, IO.FileAccess.Read)

            Dim phantom2 As Image = Image.FromStream(phantom1) '다른 프로세스 사용 중 방지하기 위해 Image.FromStream 선언
            Dim phantom_2 As Image = Image.FromStream(phantom_1)
            Dim chain2 As Image = Image.FromStream(chain1)
            Dim chain_2 As Image = Image.FromStream(chain_1)
            Dim chain__2 As Image = Image.FromStream(chain__1)

            TextFileName4.Text = "Data\EditSamples\drawable\chain_.png"
            SelChainSample1.Image = chain_2

            phantom1.Close()
            phantom_1.Close()
            chain1.Close()
            chain_1.Close()
            chain__1.Close()

            MsgBox("Imported Sample Selected Chain!", vbInformation)
        Else
            MsgBox("Import Failed! Error Code: 9" & vbNewLine & "Warning: Can't Find a Images Folder!", vbCritical)
        End If
    End Sub

    Private Sub NextChainSample1_Click(sender As Object, e As EventArgs) Handles NextChainSample1.DoubleClick
        Dim curFile As String = "WorkSpace\drawable"
        Dim drawFile As String = "WorkSpace\drawable\"

        If Dir(curFile, vbDirectory) <> "" Then '만약 WorkSpace\drawable 폴더가 있으면
            File.Copy("Data\EditSamples\drawable\chain__.png", "WorkSpace\drawable\chain__.png", True) '파일 복사, 덮어쓰기 허용

            Dim chain__1 As New System.IO.FileStream(drawFile & "chain__.png", IO.FileMode.Open, IO.FileAccess.Read) '다른 프로세스 사용 중 방지하기 위해 Image.FromStream 선언
            Dim chain__2 As Image = Image.FromStream(chain__1)

            TextFileName5.Text = "Data\EditSamples\drawable\chain__.png"
            NextChainSample1.Image = chain__2

            chain__1.Close()

            MsgBox("Imported Sample Next Chain!", vbInformation)
        Else
            MsgBox("Import Failed! Error Code: 9" & vbNewLine & "Warning: Can't Find a Images Folder!", vbCritical)
        End If
    End Sub

    Private Sub ImportNextChain1_Click(sender As Object, e As EventArgs) Handles ImportNextChain1.Click
        Dim ofdEdit As New OpenFileDialog
        Dim curFile As String = "WorkSpace\drawable"
        Dim drawFile As String = "WorkSpace\drawable\"

        '연습모드 체인 가져오기
        ofdEdit.Filter = "PNG Files|*.png"
        ofdEdit.Title = "Select Next Chain File"

        If ofdEdit.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            If Dir(curFile, vbDirectory) <> "" Then
                File.Copy(ofdEdit.FileName, "WorkSpace\drawable\chain__.png", True)

                Dim chain__1 As New System.IO.FileStream(drawFile & "chain__.png", IO.FileMode.Open, IO.FileAccess.Read) '다른 프로세스 사용 중 방지하기 위해 Image.FromStream 선언
                Dim chain__2 As Image = Image.FromStream(chain__1)

                TextFileName5.Text = ofdEdit.FileName
                NextChainSample1.Image = chain__2

                chain__1.Close()

                MsgBox("Imported Next Chain!", vbInformation)
            Else
                MsgBox("Import Failed! Error Code: 9" & vbNewLine & "Warning: Can't Find a Images Folder!", vbCritical)
            End If
        End If
    End Sub

    Private Sub ChainLEDSample1_Click(sender As Object, e As EventArgs) Handles ChainLEDSample1.DoubleClick
        Dim curFile As String = "WorkSpace\drawable"
        Dim drawFile As String = "WorkSpace\drawable\"

        If Dir(curFile, vbDirectory) <> "" Then '만약 WorkSpace\drawable 폴더가 있으면
            File.Copy("Data\EditSamples\drawable\chainled.png", "WorkSpace\drawable\chainled.png", True) '파일 복사, 덮어쓰기 허용

            Dim chainled1 As New System.IO.FileStream(drawFile & "chainled.png", IO.FileMode.Open, IO.FileAccess.Read) '다른 프로세스 사용 중 방지하기 위해 Image.FromStream 선언
            Dim chainled2 As Image = Image.FromStream(chainled1)

            TextFileName6.Text = "Data\EditSamples\drawable\chainled.png"
            ChainLEDSample1.Image = chainled2

            chainled1.Close()

            MsgBox("Imported Sample LED Chain!", vbInformation)
        Else
            MsgBox("Import Failed! Error Code: 9" & vbNewLine & "Warning: Can't Find a Images Folder!", vbCritical)
        End If
    End Sub

    Private Sub ImportChainLED1_Click(sender As Object, e As EventArgs) Handles ImportChainLED1.Click
        Dim ofdEdit As New OpenFileDialog
        Dim curFile As String = "WorkSpace\drawable"
        Dim drawFile As String = "WorkSpace\drawable\"

        '연습모드 체인 가져오기
        ofdEdit.Filter = "PNG Files|*.png"
        ofdEdit.Title = "Select Next Chain File"

        If ofdEdit.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            If Dir(curFile, vbDirectory) <> "" Then
                File.Copy(ofdEdit.FileName, "WorkSpace\drawable\chainled.png", True)

                Dim chainled1 As New System.IO.FileStream(drawFile & "chainled.png", IO.FileMode.Open, IO.FileAccess.Read) '다른 프로세스 사용 중 방지하기 위해 Image.FromStream 선언
                Dim chainled2 As Image = Image.FromStream(chainled1)

                TextFileName6.Text = ofdEdit.FileName
                ChainLEDSample1.Image = chainled2

                chainled1.Close()

                MsgBox("Imported LED Chain!", vbInformation)
            Else
                MsgBox("Import Failed! Error Code: 9" & vbNewLine & "Warning: Can't Find a Images Folder!", vbCritical)
            End If
        End If
    End Sub

    Private Sub ImagesAdvanced_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim FFile = Application.StartupPath + "\settings.ini"
        Dim Section = "USKESettings"
        Dim drawFile As String = "WorkSpace\drawable\"
        Dim valFile As String = "Apktool\unism\res\values\"
        Dim ManiFile As String = "Apktool\unism\AndroidManifest.xml"

        If ReadIni(FFile, Section, "CHIMG", "") = "True" Then '만약 settings.ini 에서 CHIMG 값이 True 라면
            If Dir("WorkSpace\Images", vbDirectory) <> "" Then

                '새로운 기능이 추가되면 꼭 저장 선언을 해줘야 함.
                Dim phantom1 As New System.IO.FileStream(drawFile & "phantom.png", IO.FileMode.Open, IO.FileAccess.Read)
                Dim phantom_1 As New System.IO.FileStream(drawFile & "phantom_.png", IO.FileMode.Open, IO.FileAccess.Read)
                Dim chain1 As New System.IO.FileStream(drawFile & "chain.png", IO.FileMode.Open, IO.FileAccess.Read)
                Dim chain_1 As New System.IO.FileStream(drawFile & "chain_.png", IO.FileMode.Open, IO.FileAccess.Read)
                Dim chain__1 As New System.IO.FileStream(drawFile & "chain__.png", IO.FileMode.Open, IO.FileAccess.Read)

                If File.Exists(drawFile & "chainled.png") Then
                    Dim chainled1 As New System.IO.FileStream(drawFile & "chainled.png", IO.FileMode.Open, IO.FileAccess.Read)
                    Dim chainled2 As Image = Image.FromStream(chainled1)
                    ChainLEDSample1.Image = chainled2
                    chainled1.Close()
                End If

                Dim phantom2 As Image = Image.FromStream(phantom1) '다른 프로세스 사용 중 방지하기 위해 Image.FromStream 선언
                Dim phantom_2 As Image = Image.FromStream(phantom_1)
                Dim chain2 As Image = Image.FromStream(chain1)
                Dim chain_2 As Image = Image.FromStream(chain_1)
                Dim chain__2 As Image = Image.FromStream(chain__1)

                '프로세스 사용 중 에러 방지문
                PhantomSample1.Image = phantom2
                PhantomCornerSample1.Image = phantom_2
                ChainSample1.Image = chain2
                SelChainSample1.Image = chain_2
                NextChainSample1.Image = chain__2

                phantom1.Close() '꼭 선언 다한 후 .Close() 를 해줘야 함.
                phantom_1.Close() '안그러면 다른 프로세스에 사용 중이라고 오류가 펑펑!
                chain1.Close()
                chain_1.Close()
                chain__1.Close()

                'ImagesAdvanced 리소스 이미지 설정/리셋
            End If
        End If
    End Sub

    Private Sub ImagesAdvanced_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Dim File = Application.StartupPath + "\settings.ini"
        Dim Section = "USKESettings"
        Dim SdrawFile As String = "WorkSpace\Images\"
        Dim SvalFile As String = "Data\EditSamples\values\"
        Dim SManiFile As String = "Data\EditSamples\Manifest\AndroidManifest.xml"
        Dim DdrawFile As String = "Data\EditSamples\drawable\"

    End Sub
End Class