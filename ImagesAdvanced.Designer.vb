<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ImagesAdvanced
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImagesAdvanced))
        Me.ChainP1 = New System.Windows.Forms.TabPage()
        Me.ChainLEDSample1 = New System.Windows.Forms.PictureBox()
        Me.ImportChainLED1 = New System.Windows.Forms.Button()
        Me.TextFileName6 = New System.Windows.Forms.TextBox()
        Me.NextChainSample1 = New System.Windows.Forms.PictureBox()
        Me.ImportNextChain1 = New System.Windows.Forms.Button()
        Me.TextFileName5 = New System.Windows.Forms.TextBox()
        Me.SelChainSample1 = New System.Windows.Forms.PictureBox()
        Me.ImportSelChain1 = New System.Windows.Forms.Button()
        Me.TextFileName4 = New System.Windows.Forms.TextBox()
        Me.ChainSample1 = New System.Windows.Forms.PictureBox()
        Me.ImportChain1 = New System.Windows.Forms.Button()
        Me.TextFileName3 = New System.Windows.Forms.TextBox()
        Me.PhantomP1 = New System.Windows.Forms.TabPage()
        Me.PhantomCornerSample1 = New System.Windows.Forms.PictureBox()
        Me.ImportPhantomCorner = New System.Windows.Forms.Button()
        Me.TextFileName2 = New System.Windows.Forms.TextBox()
        Me.PhantomSample1 = New System.Windows.Forms.PictureBox()
        Me.ImportPhantom1 = New System.Windows.Forms.Button()
        Me.TextFileName1 = New System.Windows.Forms.TextBox()
        Me.EControl1 = New System.Windows.Forms.TabControl()
        Me.BarP1 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BarP2 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ofdEdit = New System.Windows.Forms.OpenFileDialog()
        Me.ChainP1.SuspendLayout()
        CType(Me.ChainLEDSample1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NextChainSample1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelChainSample1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChainSample1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PhantomP1.SuspendLayout()
        CType(Me.PhantomCornerSample1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PhantomSample1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EControl1.SuspendLayout()
        Me.BarP1.SuspendLayout()
        Me.BarP2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ChainP1
        '
        Me.ChainP1.Controls.Add(Me.ChainLEDSample1)
        Me.ChainP1.Controls.Add(Me.ImportChainLED1)
        Me.ChainP1.Controls.Add(Me.TextFileName6)
        Me.ChainP1.Controls.Add(Me.NextChainSample1)
        Me.ChainP1.Controls.Add(Me.ImportNextChain1)
        Me.ChainP1.Controls.Add(Me.TextFileName5)
        Me.ChainP1.Controls.Add(Me.SelChainSample1)
        Me.ChainP1.Controls.Add(Me.ImportSelChain1)
        Me.ChainP1.Controls.Add(Me.TextFileName4)
        Me.ChainP1.Controls.Add(Me.ChainSample1)
        Me.ChainP1.Controls.Add(Me.ImportChain1)
        Me.ChainP1.Controls.Add(Me.TextFileName3)
        Me.ChainP1.Location = New System.Drawing.Point(4, 22)
        Me.ChainP1.Name = "ChainP1"
        Me.ChainP1.Padding = New System.Windows.Forms.Padding(3)
        Me.ChainP1.Size = New System.Drawing.Size(572, 348)
        Me.ChainP1.TabIndex = 1
        Me.ChainP1.Text = "Chain"
        Me.ChainP1.UseVisualStyleBackColor = True
        '
        'ChainLEDSample1
        '
        Me.ChainLEDSample1.Image = CType(resources.GetObject("ChainLEDSample1.Image"), System.Drawing.Image)
        Me.ChainLEDSample1.Location = New System.Drawing.Point(21, 259)
        Me.ChainLEDSample1.Name = "ChainLEDSample1"
        Me.ChainLEDSample1.Size = New System.Drawing.Size(59, 62)
        Me.ChainLEDSample1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ChainLEDSample1.TabIndex = 26
        Me.ChainLEDSample1.TabStop = False
        '
        'ImportChainLED1
        '
        Me.ImportChainLED1.Location = New System.Drawing.Point(410, 279)
        Me.ImportChainLED1.Name = "ImportChainLED1"
        Me.ImportChainLED1.Size = New System.Drawing.Size(123, 23)
        Me.ImportChainLED1.TabIndex = 25
        Me.ImportChainLED1.Text = "Import Chain LED"
        Me.ImportChainLED1.UseVisualStyleBackColor = True
        '
        'TextFileName6
        '
        Me.TextFileName6.Location = New System.Drawing.Point(86, 281)
        Me.TextFileName6.Name = "TextFileName6"
        Me.TextFileName6.ReadOnly = True
        Me.TextFileName6.Size = New System.Drawing.Size(318, 21)
        Me.TextFileName6.TabIndex = 24
        '
        'NextChainSample1
        '
        Me.NextChainSample1.Image = CType(resources.GetObject("NextChainSample1.Image"), System.Drawing.Image)
        Me.NextChainSample1.Location = New System.Drawing.Point(21, 182)
        Me.NextChainSample1.Name = "NextChainSample1"
        Me.NextChainSample1.Size = New System.Drawing.Size(59, 62)
        Me.NextChainSample1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.NextChainSample1.TabIndex = 23
        Me.NextChainSample1.TabStop = False
        '
        'ImportNextChain1
        '
        Me.ImportNextChain1.Location = New System.Drawing.Point(410, 202)
        Me.ImportNextChain1.Name = "ImportNextChain1"
        Me.ImportNextChain1.Size = New System.Drawing.Size(123, 23)
        Me.ImportNextChain1.TabIndex = 22
        Me.ImportNextChain1.Text = "Import Next Chain"
        Me.ImportNextChain1.UseVisualStyleBackColor = True
        '
        'TextFileName5
        '
        Me.TextFileName5.Location = New System.Drawing.Point(86, 204)
        Me.TextFileName5.Name = "TextFileName5"
        Me.TextFileName5.ReadOnly = True
        Me.TextFileName5.Size = New System.Drawing.Size(318, 21)
        Me.TextFileName5.TabIndex = 21
        '
        'SelChainSample1
        '
        Me.SelChainSample1.Image = CType(resources.GetObject("SelChainSample1.Image"), System.Drawing.Image)
        Me.SelChainSample1.Location = New System.Drawing.Point(21, 104)
        Me.SelChainSample1.Name = "SelChainSample1"
        Me.SelChainSample1.Size = New System.Drawing.Size(59, 62)
        Me.SelChainSample1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SelChainSample1.TabIndex = 20
        Me.SelChainSample1.TabStop = False
        '
        'ImportSelChain1
        '
        Me.ImportSelChain1.Location = New System.Drawing.Point(410, 124)
        Me.ImportSelChain1.Name = "ImportSelChain1"
        Me.ImportSelChain1.Size = New System.Drawing.Size(144, 23)
        Me.ImportSelChain1.TabIndex = 19
        Me.ImportSelChain1.Text = "Import Selected Chain"
        Me.ImportSelChain1.UseVisualStyleBackColor = True
        '
        'TextFileName4
        '
        Me.TextFileName4.Location = New System.Drawing.Point(86, 126)
        Me.TextFileName4.Name = "TextFileName4"
        Me.TextFileName4.ReadOnly = True
        Me.TextFileName4.Size = New System.Drawing.Size(318, 21)
        Me.TextFileName4.TabIndex = 18
        '
        'ChainSample1
        '
        Me.ChainSample1.Image = CType(resources.GetObject("ChainSample1.Image"), System.Drawing.Image)
        Me.ChainSample1.Location = New System.Drawing.Point(21, 27)
        Me.ChainSample1.Name = "ChainSample1"
        Me.ChainSample1.Size = New System.Drawing.Size(59, 62)
        Me.ChainSample1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ChainSample1.TabIndex = 17
        Me.ChainSample1.TabStop = False
        '
        'ImportChain1
        '
        Me.ImportChain1.Location = New System.Drawing.Point(410, 47)
        Me.ImportChain1.Name = "ImportChain1"
        Me.ImportChain1.Size = New System.Drawing.Size(93, 23)
        Me.ImportChain1.TabIndex = 16
        Me.ImportChain1.Text = "Import Chain"
        Me.ImportChain1.UseVisualStyleBackColor = True
        '
        'TextFileName3
        '
        Me.TextFileName3.Location = New System.Drawing.Point(86, 49)
        Me.TextFileName3.Name = "TextFileName3"
        Me.TextFileName3.ReadOnly = True
        Me.TextFileName3.Size = New System.Drawing.Size(318, 21)
        Me.TextFileName3.TabIndex = 15
        '
        'PhantomP1
        '
        Me.PhantomP1.Controls.Add(Me.PhantomCornerSample1)
        Me.PhantomP1.Controls.Add(Me.ImportPhantomCorner)
        Me.PhantomP1.Controls.Add(Me.TextFileName2)
        Me.PhantomP1.Controls.Add(Me.PhantomSample1)
        Me.PhantomP1.Controls.Add(Me.ImportPhantom1)
        Me.PhantomP1.Controls.Add(Me.TextFileName1)
        Me.PhantomP1.Location = New System.Drawing.Point(4, 22)
        Me.PhantomP1.Name = "PhantomP1"
        Me.PhantomP1.Padding = New System.Windows.Forms.Padding(3)
        Me.PhantomP1.Size = New System.Drawing.Size(572, 348)
        Me.PhantomP1.TabIndex = 0
        Me.PhantomP1.Text = "Phantom"
        Me.PhantomP1.UseVisualStyleBackColor = True
        '
        'PhantomCornerSample1
        '
        Me.PhantomCornerSample1.Image = CType(resources.GetObject("PhantomCornerSample1.Image"), System.Drawing.Image)
        Me.PhantomCornerSample1.Location = New System.Drawing.Point(23, 183)
        Me.PhantomCornerSample1.Name = "PhantomCornerSample1"
        Me.PhantomCornerSample1.Size = New System.Drawing.Size(59, 62)
        Me.PhantomCornerSample1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PhantomCornerSample1.TabIndex = 17
        Me.PhantomCornerSample1.TabStop = False
        '
        'ImportPhantomCorner
        '
        Me.ImportPhantomCorner.Location = New System.Drawing.Point(412, 203)
        Me.ImportPhantomCorner.Name = "ImportPhantomCorner"
        Me.ImportPhantomCorner.Size = New System.Drawing.Size(147, 23)
        Me.ImportPhantomCorner.TabIndex = 16
        Me.ImportPhantomCorner.Text = "Import Phantom Corner"
        Me.ImportPhantomCorner.UseVisualStyleBackColor = True
        '
        'TextFileName2
        '
        Me.TextFileName2.Location = New System.Drawing.Point(88, 205)
        Me.TextFileName2.Name = "TextFileName2"
        Me.TextFileName2.ReadOnly = True
        Me.TextFileName2.Size = New System.Drawing.Size(318, 21)
        Me.TextFileName2.TabIndex = 15
        '
        'PhantomSample1
        '
        Me.PhantomSample1.Image = CType(resources.GetObject("PhantomSample1.Image"), System.Drawing.Image)
        Me.PhantomSample1.Location = New System.Drawing.Point(23, 72)
        Me.PhantomSample1.Name = "PhantomSample1"
        Me.PhantomSample1.Size = New System.Drawing.Size(59, 62)
        Me.PhantomSample1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PhantomSample1.TabIndex = 14
        Me.PhantomSample1.TabStop = False
        '
        'ImportPhantom1
        '
        Me.ImportPhantom1.Location = New System.Drawing.Point(412, 92)
        Me.ImportPhantom1.Name = "ImportPhantom1"
        Me.ImportPhantom1.Size = New System.Drawing.Size(106, 23)
        Me.ImportPhantom1.TabIndex = 13
        Me.ImportPhantom1.Text = "Import Phantom"
        Me.ImportPhantom1.UseVisualStyleBackColor = True
        '
        'TextFileName1
        '
        Me.TextFileName1.Location = New System.Drawing.Point(88, 94)
        Me.TextFileName1.Name = "TextFileName1"
        Me.TextFileName1.ReadOnly = True
        Me.TextFileName1.Size = New System.Drawing.Size(318, 21)
        Me.TextFileName1.TabIndex = 12
        '
        'EControl1
        '
        Me.EControl1.Controls.Add(Me.PhantomP1)
        Me.EControl1.Controls.Add(Me.ChainP1)
        Me.EControl1.Controls.Add(Me.BarP1)
        Me.EControl1.Controls.Add(Me.BarP2)
        Me.EControl1.Location = New System.Drawing.Point(12, 12)
        Me.EControl1.Name = "EControl1"
        Me.EControl1.SelectedIndex = 0
        Me.EControl1.Size = New System.Drawing.Size(580, 374)
        Me.EControl1.TabIndex = 0
        '
        'BarP1
        '
        Me.BarP1.Controls.Add(Me.Label1)
        Me.BarP1.Location = New System.Drawing.Point(4, 22)
        Me.BarP1.Name = "BarP1"
        Me.BarP1.Size = New System.Drawing.Size(572, 348)
        Me.BarP1.TabIndex = 2
        Me.BarP1.Text = "Bar 1"
        Me.BarP1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("맑은 고딕", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.Location = New System.Drawing.Point(181, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Coming Soon!"
        '
        'BarP2
        '
        Me.BarP2.Controls.Add(Me.Label2)
        Me.BarP2.Location = New System.Drawing.Point(4, 22)
        Me.BarP2.Name = "BarP2"
        Me.BarP2.Size = New System.Drawing.Size(572, 348)
        Me.BarP2.TabIndex = 3
        Me.BarP2.Text = "Bar 2"
        Me.BarP2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("맑은 고딕", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label2.Location = New System.Drawing.Point(181, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 37)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Coming Soon!"
        '
        'ofdEdit
        '
        Me.ofdEdit.FileName = "OpenFileDialog1"
        '
        'ImagesAdvanced
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 398)
        Me.Controls.Add(Me.EControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ImagesAdvanced"
        Me.Text = "Advanced Mode"
        Me.ChainP1.ResumeLayout(False)
        Me.ChainP1.PerformLayout()
        CType(Me.ChainLEDSample1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NextChainSample1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelChainSample1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChainSample1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PhantomP1.ResumeLayout(False)
        Me.PhantomP1.PerformLayout()
        CType(Me.PhantomCornerSample1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhantomSample1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EControl1.ResumeLayout(False)
        Me.BarP1.ResumeLayout(False)
        Me.BarP1.PerformLayout()
        Me.BarP2.ResumeLayout(False)
        Me.BarP2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ChainP1 As TabPage
    Friend WithEvents PhantomP1 As TabPage
    Friend WithEvents EControl1 As TabControl
    Friend WithEvents BarP1 As TabPage
    Friend WithEvents BarP2 As TabPage
    Friend WithEvents PhantomSample1 As PictureBox
    Friend WithEvents ImportPhantom1 As Button
    Friend WithEvents TextFileName1 As TextBox
    Friend WithEvents ofdEdit As OpenFileDialog
    Friend WithEvents PhantomCornerSample1 As PictureBox
    Friend WithEvents ImportPhantomCorner As Button
    Friend WithEvents TextFileName2 As TextBox
    Friend WithEvents ChainSample1 As PictureBox
    Friend WithEvents ImportChain1 As Button
    Friend WithEvents TextFileName3 As TextBox
    Friend WithEvents SelChainSample1 As PictureBox
    Friend WithEvents ImportSelChain1 As Button
    Friend WithEvents TextFileName4 As TextBox
    Friend WithEvents NextChainSample1 As PictureBox
    Friend WithEvents ImportNextChain1 As Button
    Friend WithEvents TextFileName5 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ChainLEDSample1 As PictureBox
    Friend WithEvents ImportChainLED1 As Button
    Friend WithEvents TextFileName6 As TextBox
End Class
