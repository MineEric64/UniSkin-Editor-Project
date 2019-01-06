<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CleanFiles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CleanFiles))
        Me.CWorkspace1 = New System.Windows.Forms.CheckBox()
        Me.StartButton1 = New System.Windows.Forms.Button()
        Me.CancelButton1 = New System.Windows.Forms.Button()
        Me.CProject1 = New System.Windows.Forms.CheckBox()
        Me.ComingSoon1 = New System.Windows.Forms.CheckBox()
        Me.CPicture1 = New System.Windows.Forms.PictureBox()
        CType(Me.CPicture1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CWorkspace1
        '
        Me.CWorkspace1.AutoSize = True
        Me.CWorkspace1.Checked = True
        Me.CWorkspace1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CWorkspace1.Location = New System.Drawing.Point(32, 39)
        Me.CWorkspace1.Name = "CWorkspace1"
        Me.CWorkspace1.Size = New System.Drawing.Size(168, 16)
        Me.CWorkspace1.TabIndex = 0
        Me.CWorkspace1.Text = "Workspace (Cache FIles)"
        Me.CWorkspace1.UseVisualStyleBackColor = True
        '
        'StartButton1
        '
        Me.StartButton1.Location = New System.Drawing.Point(242, 214)
        Me.StartButton1.Name = "StartButton1"
        Me.StartButton1.Size = New System.Drawing.Size(98, 49)
        Me.StartButton1.TabIndex = 1
        Me.StartButton1.Text = "Start!"
        Me.StartButton1.UseVisualStyleBackColor = True
        '
        'CancelButton1
        '
        Me.CancelButton1.Location = New System.Drawing.Point(116, 214)
        Me.CancelButton1.Name = "CancelButton1"
        Me.CancelButton1.Size = New System.Drawing.Size(98, 49)
        Me.CancelButton1.TabIndex = 2
        Me.CancelButton1.Text = "Cancel"
        Me.CancelButton1.UseVisualStyleBackColor = True
        '
        'CProject1
        '
        Me.CProject1.AutoSize = True
        Me.CProject1.Checked = True
        Me.CProject1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CProject1.Location = New System.Drawing.Point(32, 91)
        Me.CProject1.Name = "CProject1"
        Me.CProject1.Size = New System.Drawing.Size(159, 16)
        Me.CProject1.TabIndex = 4
        Me.CProject1.Text = "Tempoary UniSkin Files"
        Me.CProject1.UseVisualStyleBackColor = True
        '
        'ComingSoon1
        '
        Me.ComingSoon1.AutoSize = True
        Me.ComingSoon1.Enabled = False
        Me.ComingSoon1.Location = New System.Drawing.Point(32, 144)
        Me.ComingSoon1.Name = "ComingSoon1"
        Me.ComingSoon1.Size = New System.Drawing.Size(113, 16)
        Me.ComingSoon1.TabIndex = 5
        Me.ComingSoon1.Text = "Coming Soon..."
        Me.ComingSoon1.UseVisualStyleBackColor = True
        '
        'CPicture1
        '
        Me.CPicture1.Image = CType(resources.GetObject("CPicture1.Image"), System.Drawing.Image)
        Me.CPicture1.Location = New System.Drawing.Point(32, 12)
        Me.CPicture1.Name = "CPicture1"
        Me.CPicture1.Size = New System.Drawing.Size(84, 21)
        Me.CPicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.CPicture1.TabIndex = 3
        Me.CPicture1.TabStop = False
        '
        'CleanFiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 290)
        Me.Controls.Add(Me.ComingSoon1)
        Me.Controls.Add(Me.CProject1)
        Me.Controls.Add(Me.CPicture1)
        Me.Controls.Add(Me.CancelButton1)
        Me.Controls.Add(Me.StartButton1)
        Me.Controls.Add(Me.CWorkspace1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CleanFiles"
        Me.Text = "UniSkin Editor"
        CType(Me.CPicture1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CWorkspace1 As CheckBox
    Friend WithEvents StartButton1 As Button
    Friend WithEvents CancelButton1 As Button
    Friend WithEvents CPicture1 As PictureBox
    Friend WithEvents CProject1 As CheckBox
    Friend WithEvents ComingSoon1 As CheckBox
End Class
