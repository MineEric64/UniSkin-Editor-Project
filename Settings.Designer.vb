<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Settings
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.UpdateCheck1 = New System.Windows.Forms.CheckBox()
        Me.Save1 = New System.Windows.Forms.Button()
        Me.ChImgs1 = New System.Windows.Forms.CheckBox()
        Me.Tip1 = New System.Windows.Forms.Label()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.ChInfo1 = New System.Windows.Forms.CheckBox()
        Me.LatestVer1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'UpdateCheck1
        '
        Me.UpdateCheck1.AutoSize = True
        Me.UpdateCheck1.Checked = True
        Me.UpdateCheck1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.UpdateCheck1.Location = New System.Drawing.Point(12, 12)
        Me.UpdateCheck1.Name = "UpdateCheck1"
        Me.UpdateCheck1.Size = New System.Drawing.Size(132, 16)
        Me.UpdateCheck1.TabIndex = 0
        Me.UpdateCheck1.Text = "Auto Update Check"
        Me.UpdateCheck1.UseVisualStyleBackColor = True
        '
        'Save1
        '
        Me.Save1.Location = New System.Drawing.Point(312, 213)
        Me.Save1.Name = "Save1"
        Me.Save1.Size = New System.Drawing.Size(75, 34)
        Me.Save1.TabIndex = 2
        Me.Save1.Text = "Save"
        Me.Save1.UseVisualStyleBackColor = True
        '
        'ChImgs1
        '
        Me.ChImgs1.AutoSize = True
        Me.ChImgs1.Checked = True
        Me.ChImgs1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChImgs1.Location = New System.Drawing.Point(12, 43)
        Me.ChImgs1.Name = "ChImgs1"
        Me.ChImgs1.Size = New System.Drawing.Size(275, 16)
        Me.ChImgs1.TabIndex = 3
        Me.ChImgs1.Text = "Change UniSkin Images When Open UniSkin"
        Me.ChImgs1.UseVisualStyleBackColor = True
        '
        'Tip1
        '
        Me.Tip1.AutoSize = True
        Me.Tip1.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Tip1.ForeColor = System.Drawing.Color.Red
        Me.Tip1.Location = New System.Drawing.Point(19, 65)
        Me.Tip1.Name = "Tip1"
        Me.Tip1.Size = New System.Drawing.Size(72, 13)
        Me.Tip1.TabIndex = 4
        Me.Tip1.Text = "What is this?"
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(226, 213)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 34)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'ChInfo1
        '
        Me.ChInfo1.AutoSize = True
        Me.ChInfo1.Checked = True
        Me.ChInfo1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChInfo1.Location = New System.Drawing.Point(12, 81)
        Me.ChInfo1.Name = "ChInfo1"
        Me.ChInfo1.Size = New System.Drawing.Size(191, 16)
        Me.ChInfo1.TabIndex = 6
        Me.ChInfo1.Text = "Load Info When Open UniSkin"
        Me.ChInfo1.UseVisualStyleBackColor = True
        '
        'LatestVer1
        '
        Me.LatestVer1.AutoSize = True
        Me.LatestVer1.Checked = True
        Me.LatestVer1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.LatestVer1.Location = New System.Drawing.Point(12, 116)
        Me.LatestVer1.Name = "LatestVer1"
        Me.LatestVer1.Size = New System.Drawing.Size(291, 16)
        Me.LatestVer1.TabIndex = 7
        Me.LatestVer1.Text = "Run Latest Verison UniSkin Editor When Update"
        Me.LatestVer1.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 259)
        Me.Controls.Add(Me.LatestVer1)
        Me.Controls.Add(Me.ChInfo1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Tip1)
        Me.Controls.Add(Me.ChImgs1)
        Me.Controls.Add(Me.Save1)
        Me.Controls.Add(Me.UpdateCheck1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UpdateCheck1 As CheckBox
    Friend WithEvents Save1 As Button
    Friend WithEvents ChImgs1 As CheckBox
    Friend WithEvents Tip1 As Label
    Friend WithEvents Cancel As Button
    Friend WithEvents ChInfo1 As CheckBox
    Friend WithEvents LatestVer1 As CheckBox
End Class
