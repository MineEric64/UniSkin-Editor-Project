<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Info2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Info2))
        Me.infoPt = New System.Windows.Forms.PictureBox()
        Me.unitorLabel1 = New System.Windows.Forms.LinkLabel()
        Me.uniskeLabel1 = New System.Windows.Forms.LinkLabel()
        Me.OKButton1 = New System.Windows.Forms.Button()
        Me.ModeE = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Ver1 = New System.Windows.Forms.Label()
        Me.InfoP = New System.Windows.Forms.PictureBox()
        CType(Me.infoPt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InfoP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'infoPt
        '
        Me.infoPt.Image = Global.UniSkin_Project.My.Resources.Resources.UniSkinEditor1
        Me.infoPt.Location = New System.Drawing.Point(88, 162)
        Me.infoPt.Name = "infoPt"
        Me.infoPt.Size = New System.Drawing.Size(251, 34)
        Me.infoPt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.infoPt.TabIndex = 20
        Me.infoPt.TabStop = False
        '
        'unitorLabel1
        '
        Me.unitorLabel1.AutoSize = True
        Me.unitorLabel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.unitorLabel1.Location = New System.Drawing.Point(89, 306)
        Me.unitorLabel1.Name = "unitorLabel1"
        Me.unitorLabel1.Size = New System.Drawing.Size(54, 12)
        Me.unitorLabel1.TabIndex = 19
        Me.unitorLabel1.TabStop = True
        Me.unitorLabel1.Text = "unitor.ga"
        '
        'uniskeLabel1
        '
        Me.uniskeLabel1.AutoSize = True
        Me.uniskeLabel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.uniskeLabel1.Location = New System.Drawing.Point(6, 306)
        Me.uniskeLabel1.Name = "uniskeLabel1"
        Me.uniskeLabel1.Size = New System.Drawing.Size(77, 12)
        Me.uniskeLabel1.TabIndex = 18
        Me.uniskeLabel1.TabStop = True
        Me.uniskeLabel1.Text = "uniske.kro.kr"
        '
        'OKButton1
        '
        Me.OKButton1.Location = New System.Drawing.Point(264, 223)
        Me.OKButton1.Name = "OKButton1"
        Me.OKButton1.Size = New System.Drawing.Size(75, 23)
        Me.OKButton1.TabIndex = 17
        Me.OKButton1.Text = "OK"
        Me.OKButton1.UseVisualStyleBackColor = True
        '
        'ModeE
        '
        Me.ModeE.Location = New System.Drawing.Point(88, 225)
        Me.ModeE.Name = "ModeE"
        Me.ModeE.Size = New System.Drawing.Size(169, 21)
        Me.ModeE.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 204)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(332, 12)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "ⓒ 2018 MineEric (최에릭), Follow_JB All Rights Reserved."
        '
        'Ver1
        '
        Me.Ver1.AutoSize = True
        Me.Ver1.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Ver1.Location = New System.Drawing.Point(365, 305)
        Me.Ver1.Name = "Ver1"
        Me.Ver1.Size = New System.Drawing.Size(32, 12)
        Me.Ver1.TabIndex = 14
        Me.Ver1.Text = "Ver."
        '
        'InfoP
        '
        Me.InfoP.Image = Global.UniSkin_Project.My.Resources.Resources.UniSkinEditor
        Me.InfoP.Location = New System.Drawing.Point(148, 21)
        Me.InfoP.Name = "InfoP"
        Me.InfoP.Size = New System.Drawing.Size(136, 134)
        Me.InfoP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.InfoP.TabIndex = 13
        Me.InfoP.TabStop = False
        '
        'Info2
        '
        Me.AcceptButton = Me.OKButton1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 326)
        Me.Controls.Add(Me.infoPt)
        Me.Controls.Add(Me.unitorLabel1)
        Me.Controls.Add(Me.uniskeLabel1)
        Me.Controls.Add(Me.OKButton1)
        Me.Controls.Add(Me.ModeE)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Ver1)
        Me.Controls.Add(Me.InfoP)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Info2"
        Me.Text = "Info"
        CType(Me.infoPt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InfoP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents infoPt As PictureBox
    Friend WithEvents unitorLabel1 As LinkLabel
    Friend WithEvents uniskeLabel1 As LinkLabel
    Friend WithEvents OKButton1 As Button
    Friend WithEvents ModeE As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Ver1 As Label
    Friend WithEvents InfoP As PictureBox
End Class
