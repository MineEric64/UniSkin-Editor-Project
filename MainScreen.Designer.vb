<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainScreen
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainScreen))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.VerText1 = New System.Windows.Forms.Label()
        Me.LoadBar1 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar_Value = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("HY산B", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 359)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(334, 14)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "ⓒ 2018 최에릭, Follow_JB All Rights Reserved."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 14.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(291, 267)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 24)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Loading..."
        '
        'VerText1
        '
        Me.VerText1.AutoSize = True
        Me.VerText1.BackColor = System.Drawing.Color.Black
        Me.VerText1.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 14.0!)
        Me.VerText1.ForeColor = System.Drawing.Color.White
        Me.VerText1.Location = New System.Drawing.Point(597, 349)
        Me.VerText1.Name = "VerText1"
        Me.VerText1.Size = New System.Drawing.Size(69, 24)
        Me.VerText1.TabIndex = 10
        Me.VerText1.Text = "0.0.0.0"
        '
        'LoadBar1
        '
        Me.LoadBar1.Location = New System.Drawing.Point(218, 300)
        Me.LoadBar1.MarqueeAnimationSpeed = 500
        Me.LoadBar1.Maximum = 360
        Me.LoadBar1.Name = "LoadBar1"
        Me.LoadBar1.Size = New System.Drawing.Size(230, 23)
        Me.LoadBar1.TabIndex = 9
        '
        'ProgressBar_Value
        '
        '
        'MainScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.UniSkin_Project.My.Resources.Resources.UniSkinEditorWallpaper
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(674, 381)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.VerText1)
        Me.Controls.Add(Me.LoadBar1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainScreen"
        Me.Text = "MainScreen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents VerText1 As Label
    Friend WithEvents LoadBar1 As ProgressBar
    Friend WithEvents ProgressBar_Value As Timer
End Class
