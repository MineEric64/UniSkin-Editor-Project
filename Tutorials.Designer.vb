<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tutorials
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tutorials))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TutorialsBox1 = New System.Windows.Forms.ComboBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(309, 54)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 20)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "I need Help."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TutorialsBox1
        '
        Me.TutorialsBox1.FormattingEnabled = True
        Me.TutorialsBox1.Items.AddRange(New Object() {"[What is Error Code: 9?]", "[How to Open UniSkin?]", "[Save Project is Not Working!]", "[How to Check for Updates?]", "[Error: Can't Find a UniSkin Resources.]"})
        Me.TutorialsBox1.Location = New System.Drawing.Point(59, 54)
        Me.TutorialsBox1.Name = "TutorialsBox1"
        Me.TutorialsBox1.Size = New System.Drawing.Size(244, 20)
        Me.TutorialsBox1.TabIndex = 4
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(47, 89)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(382, 214)
        Me.RichTextBox1.TabIndex = 3
        Me.RichTextBox1.Text = "" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "                               " & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "                            I'll Fix Up Your " &
    "Questions :)" & Global.Microsoft.VisualBasic.ChrW(10) & "                                       Good Game"
        '
        'Tutorials
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 368)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TutorialsBox1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Tutorials"
        Me.Text = "Tutorials"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TutorialsBox1 As ComboBox
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
