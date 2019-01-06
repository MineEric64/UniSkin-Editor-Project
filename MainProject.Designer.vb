<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainProject
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainProject))
        Me.Menu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MakeUniSkinAPKToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenAPKToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveUniSkinAPKToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstallFrameWorkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveFrameWorkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetImagesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TutorialsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateCheckToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ofdapk = New System.Windows.Forms.OpenFileDialog()
        Me.sfdapk = New System.Windows.Forms.SaveFileDialog()
        Me.EControl = New System.Windows.Forms.TabControl()
        Me.Images = New System.Windows.Forms.TabPage()
        Me.Tip1 = New System.Windows.Forms.Label()
        Me.ThemeIconSample1 = New System.Windows.Forms.PictureBox()
        Me.ImportThemeIcon1 = New System.Windows.Forms.Button()
        Me.TextFileName3 = New System.Windows.Forms.TextBox()
        Me.ImagesAdButton1 = New System.Windows.Forms.Button()
        Me.PopSkinSample1 = New System.Windows.Forms.PictureBox()
        Me.ImportPopSkin1 = New System.Windows.Forms.Button()
        Me.TextFileName2 = New System.Windows.Forms.TextBox()
        Me.AppIconSample1 = New System.Windows.Forms.PictureBox()
        Me.ImportAppIcon1 = New System.Windows.Forms.Button()
        Me.TextFileName1 = New System.Windows.Forms.TextBox()
        Me.Info = New System.Windows.Forms.TabPage()
        Me.Tip3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.infoTB3 = New System.Windows.Forms.TextBox()
        Me.XMLTextBox1 = New System.Windows.Forms.TextBox()
        Me.infoAV1 = New System.Windows.Forms.Label()
        Me.Tip2 = New System.Windows.Forms.Label()
        Me.infoTB2 = New System.Windows.Forms.TextBox()
        Me.infoAP1 = New System.Windows.Forms.Label()
        Me.infoTB4 = New System.Windows.Forms.TextBox()
        Me.infoTN1 = New System.Windows.Forms.Label()
        Me.infoTB6 = New System.Windows.Forms.TextBox()
        Me.infoTD1 = New System.Windows.Forms.Label()
        Me.infoTB5 = New System.Windows.Forms.TextBox()
        Me.infoTA1 = New System.Windows.Forms.Label()
        Me.infoTB1 = New System.Windows.Forms.TextBox()
        Me.infoSave = New System.Windows.Forms.Button()
        Me.infoAN1 = New System.Windows.Forms.Label()
        Me.ofdEdit = New System.Windows.Forms.OpenFileDialog()
        Me.colorPick = New System.Windows.Forms.ColorDialog()
        Me.infoCol1 = New UniSkin_Project.mkc_ColorCombobox()
        Me.CleanTheTempoaryFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu.SuspendLayout()
        Me.EControl.SuspendLayout()
        Me.Images.SuspendLayout()
        CType(Me.ThemeIconSample1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopSkinSample1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppIconSample1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Info.SuspendLayout()
        Me.SuspendLayout()
        '
        'Menu
        '
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.TutorialsToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.Menu.Location = New System.Drawing.Point(0, 0)
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(656, 24)
        Me.Menu.TabIndex = 0
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MakeUniSkinAPKToolStripMenuItem, Me.OpenAPKToolStripMenuItem, Me.SaveUniSkinAPKToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'MakeUniSkinAPKToolStripMenuItem
        '
        Me.MakeUniSkinAPKToolStripMenuItem.Name = "MakeUniSkinAPKToolStripMenuItem"
        Me.MakeUniSkinAPKToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.MakeUniSkinAPKToolStripMenuItem.Text = "Make a UniSkin"
        '
        'OpenAPKToolStripMenuItem
        '
        Me.OpenAPKToolStripMenuItem.Name = "OpenAPKToolStripMenuItem"
        Me.OpenAPKToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.OpenAPKToolStripMenuItem.Text = "Open Project"
        '
        'SaveUniSkinAPKToolStripMenuItem
        '
        Me.SaveUniSkinAPKToolStripMenuItem.Name = "SaveUniSkinAPKToolStripMenuItem"
        Me.SaveUniSkinAPKToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.SaveUniSkinAPKToolStripMenuItem.Text = "Save Project"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InstallFrameWorkToolStripMenuItem, Me.RemoveFrameWorkToolStripMenuItem, Me.ResetImagesToolStripMenuItem, Me.CleanTheTempoaryFilesToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'InstallFrameWorkToolStripMenuItem
        '
        Me.InstallFrameWorkToolStripMenuItem.Name = "InstallFrameWorkToolStripMenuItem"
        Me.InstallFrameWorkToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.InstallFrameWorkToolStripMenuItem.Text = "Install Framework"
        '
        'RemoveFrameWorkToolStripMenuItem
        '
        Me.RemoveFrameWorkToolStripMenuItem.Name = "RemoveFrameWorkToolStripMenuItem"
        Me.RemoveFrameWorkToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.RemoveFrameWorkToolStripMenuItem.Text = "Remove Framework"
        '
        'ResetImagesToolStripMenuItem
        '
        Me.ResetImagesToolStripMenuItem.Name = "ResetImagesToolStripMenuItem"
        Me.ResetImagesToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.ResetImagesToolStripMenuItem.Text = "Reset Images"
        '
        'TutorialsToolStripMenuItem
        '
        Me.TutorialsToolStripMenuItem.Name = "TutorialsToolStripMenuItem"
        Me.TutorialsToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.TutorialsToolStripMenuItem.Text = "Tutorials"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem, Me.InfoToolStripMenuItem, Me.UpdateCheckToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.InfoToolStripMenuItem.Text = "Info"
        '
        'UpdateCheckToolStripMenuItem
        '
        Me.UpdateCheckToolStripMenuItem.Name = "UpdateCheckToolStripMenuItem"
        Me.UpdateCheckToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.UpdateCheckToolStripMenuItem.Text = "Check Update"
        '
        'EControl
        '
        Me.EControl.Controls.Add(Me.Images)
        Me.EControl.Controls.Add(Me.Info)
        Me.EControl.Location = New System.Drawing.Point(13, 28)
        Me.EControl.Name = "EControl"
        Me.EControl.SelectedIndex = 0
        Me.EControl.Size = New System.Drawing.Size(631, 406)
        Me.EControl.TabIndex = 1
        '
        'Images
        '
        Me.Images.Controls.Add(Me.Tip1)
        Me.Images.Controls.Add(Me.ThemeIconSample1)
        Me.Images.Controls.Add(Me.ImportThemeIcon1)
        Me.Images.Controls.Add(Me.TextFileName3)
        Me.Images.Controls.Add(Me.ImagesAdButton1)
        Me.Images.Controls.Add(Me.PopSkinSample1)
        Me.Images.Controls.Add(Me.ImportPopSkin1)
        Me.Images.Controls.Add(Me.TextFileName2)
        Me.Images.Controls.Add(Me.AppIconSample1)
        Me.Images.Controls.Add(Me.ImportAppIcon1)
        Me.Images.Controls.Add(Me.TextFileName1)
        Me.Images.Location = New System.Drawing.Point(4, 22)
        Me.Images.Name = "Images"
        Me.Images.Padding = New System.Windows.Forms.Padding(3)
        Me.Images.Size = New System.Drawing.Size(623, 380)
        Me.Images.TabIndex = 0
        Me.Images.Text = "Images"
        Me.Images.UseVisualStyleBackColor = True
        '
        'Tip1
        '
        Me.Tip1.AutoSize = True
        Me.Tip1.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Tip1.ForeColor = System.Drawing.Color.Red
        Me.Tip1.Location = New System.Drawing.Point(6, 357)
        Me.Tip1.Name = "Tip1"
        Me.Tip1.Size = New System.Drawing.Size(359, 13)
        Me.Tip1.TabIndex = 5
        Me.Tip1.Text = "Tip: You have to use This Edit After Make a UniSkin or Open Project."
        '
        'ThemeIconSample1
        '
        Me.ThemeIconSample1.Image = CType(resources.GetObject("ThemeIconSample1.Image"), System.Drawing.Image)
        Me.ThemeIconSample1.Location = New System.Drawing.Point(58, 244)
        Me.ThemeIconSample1.Name = "ThemeIconSample1"
        Me.ThemeIconSample1.Size = New System.Drawing.Size(59, 62)
        Me.ThemeIconSample1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ThemeIconSample1.TabIndex = 18
        Me.ThemeIconSample1.TabStop = False
        '
        'ImportThemeIcon1
        '
        Me.ImportThemeIcon1.Location = New System.Drawing.Point(447, 264)
        Me.ImportThemeIcon1.Name = "ImportThemeIcon1"
        Me.ImportThemeIcon1.Size = New System.Drawing.Size(123, 23)
        Me.ImportThemeIcon1.TabIndex = 17
        Me.ImportThemeIcon1.Text = "Import Theme Icon"
        Me.ImportThemeIcon1.UseVisualStyleBackColor = True
        '
        'TextFileName3
        '
        Me.TextFileName3.Location = New System.Drawing.Point(123, 266)
        Me.TextFileName3.Name = "TextFileName3"
        Me.TextFileName3.ReadOnly = True
        Me.TextFileName3.Size = New System.Drawing.Size(318, 21)
        Me.TextFileName3.TabIndex = 16
        '
        'ImagesAdButton1
        '
        Me.ImagesAdButton1.Location = New System.Drawing.Point(532, 345)
        Me.ImagesAdButton1.Name = "ImagesAdButton1"
        Me.ImagesAdButton1.Size = New System.Drawing.Size(75, 23)
        Me.ImagesAdButton1.TabIndex = 15
        Me.ImagesAdButton1.Text = "Advanced"
        Me.ImagesAdButton1.UseVisualStyleBackColor = True
        '
        'PopSkinSample1
        '
        Me.PopSkinSample1.Image = CType(resources.GetObject("PopSkinSample1.Image"), System.Drawing.Image)
        Me.PopSkinSample1.Location = New System.Drawing.Point(58, 138)
        Me.PopSkinSample1.Name = "PopSkinSample1"
        Me.PopSkinSample1.Size = New System.Drawing.Size(59, 62)
        Me.PopSkinSample1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PopSkinSample1.TabIndex = 14
        Me.PopSkinSample1.TabStop = False
        '
        'ImportPopSkin1
        '
        Me.ImportPopSkin1.Location = New System.Drawing.Point(447, 158)
        Me.ImportPopSkin1.Name = "ImportPopSkin1"
        Me.ImportPopSkin1.Size = New System.Drawing.Size(103, 23)
        Me.ImportPopSkin1.TabIndex = 13
        Me.ImportPopSkin1.Text = "Import PopSkin"
        Me.ImportPopSkin1.UseVisualStyleBackColor = True
        '
        'TextFileName2
        '
        Me.TextFileName2.Location = New System.Drawing.Point(123, 160)
        Me.TextFileName2.Name = "TextFileName2"
        Me.TextFileName2.ReadOnly = True
        Me.TextFileName2.Size = New System.Drawing.Size(318, 21)
        Me.TextFileName2.TabIndex = 12
        '
        'AppIconSample1
        '
        Me.AppIconSample1.Image = CType(resources.GetObject("AppIconSample1.Image"), System.Drawing.Image)
        Me.AppIconSample1.ImageLocation = ""
        Me.AppIconSample1.Location = New System.Drawing.Point(58, 34)
        Me.AppIconSample1.Name = "AppIconSample1"
        Me.AppIconSample1.Size = New System.Drawing.Size(59, 62)
        Me.AppIconSample1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.AppIconSample1.TabIndex = 11
        Me.AppIconSample1.TabStop = False
        '
        'ImportAppIcon1
        '
        Me.ImportAppIcon1.Location = New System.Drawing.Point(447, 54)
        Me.ImportAppIcon1.Name = "ImportAppIcon1"
        Me.ImportAppIcon1.Size = New System.Drawing.Size(106, 23)
        Me.ImportAppIcon1.TabIndex = 10
        Me.ImportAppIcon1.Text = "Import App Icon"
        Me.ImportAppIcon1.UseVisualStyleBackColor = True
        '
        'TextFileName1
        '
        Me.TextFileName1.Location = New System.Drawing.Point(123, 56)
        Me.TextFileName1.Name = "TextFileName1"
        Me.TextFileName1.ReadOnly = True
        Me.TextFileName1.Size = New System.Drawing.Size(318, 21)
        Me.TextFileName1.TabIndex = 9
        '
        'Info
        '
        Me.Info.Controls.Add(Me.Tip3)
        Me.Info.Controls.Add(Me.Label1)
        Me.Info.Controls.Add(Me.infoTB3)
        Me.Info.Controls.Add(Me.XMLTextBox1)
        Me.Info.Controls.Add(Me.infoAV1)
        Me.Info.Controls.Add(Me.Tip2)
        Me.Info.Controls.Add(Me.infoTB2)
        Me.Info.Controls.Add(Me.infoAP1)
        Me.Info.Controls.Add(Me.infoTB4)
        Me.Info.Controls.Add(Me.infoTN1)
        Me.Info.Controls.Add(Me.infoTB6)
        Me.Info.Controls.Add(Me.infoTD1)
        Me.Info.Controls.Add(Me.infoTB5)
        Me.Info.Controls.Add(Me.infoTA1)
        Me.Info.Controls.Add(Me.infoTB1)
        Me.Info.Controls.Add(Me.infoSave)
        Me.Info.Controls.Add(Me.infoAN1)
        Me.Info.Controls.Add(Me.infoCol1)
        Me.Info.Location = New System.Drawing.Point(4, 22)
        Me.Info.Name = "Info"
        Me.Info.Padding = New System.Windows.Forms.Padding(3)
        Me.Info.Size = New System.Drawing.Size(623, 380)
        Me.Info.TabIndex = 1
        Me.Info.Text = "Info"
        Me.Info.UseVisualStyleBackColor = True
        '
        'Tip3
        '
        Me.Tip3.AutoSize = True
        Me.Tip3.Location = New System.Drawing.Point(160, 363)
        Me.Tip3.Name = "Tip3"
        Me.Tip3.Size = New System.Drawing.Size(158, 12)
        Me.Tip3.TabIndex = 34
        Me.Tip3.Text = "Tip: This feature is in beta."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(104, 336)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 15)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "UniSkin Text Color"
        '
        'infoTB3
        '
        Me.infoTB3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.infoTB3.Location = New System.Drawing.Point(223, 128)
        Me.infoTB3.Name = "infoTB3"
        Me.infoTB3.Size = New System.Drawing.Size(236, 21)
        Me.infoTB3.TabIndex = 25
        Me.infoTB3.Text = "1.0.0"
        '
        'XMLTextBox1
        '
        Me.XMLTextBox1.Location = New System.Drawing.Point(6, 355)
        Me.XMLTextBox1.Multiline = True
        Me.XMLTextBox1.Name = "XMLTextBox1"
        Me.XMLTextBox1.Size = New System.Drawing.Size(47, 22)
        Me.XMLTextBox1.TabIndex = 24
        Me.XMLTextBox1.Text = resources.GetString("XMLTextBox1.Text")
        Me.XMLTextBox1.Visible = False
        '
        'infoAV1
        '
        Me.infoAV1.AutoSize = True
        Me.infoAV1.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.infoAV1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.infoAV1.Location = New System.Drawing.Point(139, 129)
        Me.infoAV1.Name = "infoAV1"
        Me.infoAV1.Size = New System.Drawing.Size(78, 15)
        Me.infoAV1.TabIndex = 26
        Me.infoAV1.Text = "App Version"
        '
        'Tip2
        '
        Me.Tip2.AutoSize = True
        Me.Tip2.Location = New System.Drawing.Point(160, 96)
        Me.Tip2.Name = "Tip2"
        Me.Tip2.Size = New System.Drawing.Size(240, 12)
        Me.Tip2.TabIndex = 23
        Me.Tip2.Text = "Tip: Don't Delete This Text thoughtlessly!"
        '
        'infoTB2
        '
        Me.infoTB2.Location = New System.Drawing.Point(223, 70)
        Me.infoTB2.Name = "infoTB2"
        Me.infoTB2.Size = New System.Drawing.Size(236, 21)
        Me.infoTB2.TabIndex = 21
        Me.infoTB2.Text = "com.kimjisub.launchpad.theme.uniskin"
        '
        'infoAP1
        '
        Me.infoAP1.AutoSize = True
        Me.infoAP1.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.infoAP1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.infoAP1.Location = New System.Drawing.Point(133, 71)
        Me.infoAP1.Name = "infoAP1"
        Me.infoAP1.Size = New System.Drawing.Size(84, 15)
        Me.infoAP1.TabIndex = 22
        Me.infoAP1.Text = "App Package"
        '
        'infoTB4
        '
        Me.infoTB4.Location = New System.Drawing.Point(223, 179)
        Me.infoTB4.Name = "infoTB4"
        Me.infoTB4.Size = New System.Drawing.Size(236, 21)
        Me.infoTB4.TabIndex = 19
        Me.infoTB4.Text = "My UniSkin"
        '
        'infoTN1
        '
        Me.infoTN1.AutoSize = True
        Me.infoTN1.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.infoTN1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.infoTN1.Location = New System.Drawing.Point(132, 180)
        Me.infoTN1.Name = "infoTN1"
        Me.infoTN1.Size = New System.Drawing.Size(85, 15)
        Me.infoTN1.TabIndex = 20
        Me.infoTN1.Text = "Theme Name"
        '
        'infoTB6
        '
        Me.infoTB6.Location = New System.Drawing.Point(223, 286)
        Me.infoTB6.Name = "infoTB6"
        Me.infoTB6.Size = New System.Drawing.Size(236, 21)
        Me.infoTB6.TabIndex = 17
        Me.infoTB6.Text = "My UniSkin! :D"
        '
        'infoTD1
        '
        Me.infoTD1.AutoSize = True
        Me.infoTD1.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.infoTD1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.infoTD1.Location = New System.Drawing.Point(101, 287)
        Me.infoTD1.Name = "infoTD1"
        Me.infoTD1.Size = New System.Drawing.Size(116, 15)
        Me.infoTD1.TabIndex = 18
        Me.infoTD1.Text = "Theme Description"
        '
        'infoTB5
        '
        Me.infoTB5.Location = New System.Drawing.Point(223, 231)
        Me.infoTB5.Name = "infoTB5"
        Me.infoTB5.Size = New System.Drawing.Size(236, 21)
        Me.infoTB5.TabIndex = 15
        Me.infoTB5.Text = "MineEric, UniSkin Editor"
        '
        'infoTA1
        '
        Me.infoTA1.AutoSize = True
        Me.infoTA1.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.infoTA1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.infoTA1.Location = New System.Drawing.Point(128, 232)
        Me.infoTA1.Name = "infoTA1"
        Me.infoTA1.Size = New System.Drawing.Size(89, 15)
        Me.infoTA1.TabIndex = 16
        Me.infoTA1.Text = "Theme Author"
        '
        'infoTB1
        '
        Me.infoTB1.Location = New System.Drawing.Point(223, 21)
        Me.infoTB1.Name = "infoTB1"
        Me.infoTB1.Size = New System.Drawing.Size(236, 21)
        Me.infoTB1.TabIndex = 12
        Me.infoTB1.Text = "My UniSkin"
        '
        'infoSave
        '
        Me.infoSave.Location = New System.Drawing.Point(510, 319)
        Me.infoSave.Name = "infoSave"
        Me.infoSave.Size = New System.Drawing.Size(91, 46)
        Me.infoSave.TabIndex = 14
        Me.infoSave.Text = "Save"
        Me.infoSave.UseVisualStyleBackColor = True
        '
        'infoAN1
        '
        Me.infoAN1.AutoSize = True
        Me.infoAN1.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.infoAN1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.infoAN1.Location = New System.Drawing.Point(147, 22)
        Me.infoAN1.Name = "infoAN1"
        Me.infoAN1.Size = New System.Drawing.Size(70, 15)
        Me.infoAN1.TabIndex = 13
        Me.infoAN1.Text = "App Name"
        '
        'infoCol1
        '
        Me.infoCol1.ColorType = UniSkin_Project.mkc_ColorCombobox.ColorEnum.KnownColor
        Me.infoCol1.FocusStyle = UniSkin_Project.mkc_ColorCombobox.FocusStyleEnum.IDE
        Me.infoCol1.Location = New System.Drawing.Point(223, 336)
        Me.infoCol1.Name = "infoCol1"
        Me.infoCol1.SelectedColor = System.Drawing.Color.White
        Me.infoCol1.Size = New System.Drawing.Size(236, 24)
        Me.infoCol1.TabIndex = 33
        '
        'CleanTheTempoaryFilesToolStripMenuItem
        '
        Me.CleanTheTempoaryFilesToolStripMenuItem.Name = "CleanTheTempoaryFilesToolStripMenuItem"
        Me.CleanTheTempoaryFilesToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.CleanTheTempoaryFilesToolStripMenuItem.Text = "Clean the Tempoary Files"
        '
        'MainProject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 446)
        Me.Controls.Add(Me.EControl)
        Me.Controls.Add(Me.Menu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.Menu
        Me.Name = "MainProject"
        Me.Text = "UniSkin Editor"
        Me.Menu.ResumeLayout(False)
        Me.Menu.PerformLayout()
        Me.EControl.ResumeLayout(False)
        Me.Images.ResumeLayout(False)
        Me.Images.PerformLayout()
        CType(Me.ThemeIconSample1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopSkinSample1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppIconSample1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Info.ResumeLayout(False)
        Me.Info.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Menu As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MakeUniSkinAPKToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenAPKToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveUniSkinAPKToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TutorialsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ofdapk As OpenFileDialog
    Friend WithEvents sfdapk As SaveFileDialog
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EControl As TabControl
    Friend WithEvents Images As TabPage
    Friend WithEvents Info As TabPage
    Friend WithEvents ofdEdit As OpenFileDialog
    Friend WithEvents ImagesAdButton1 As Button
    Friend WithEvents PopSkinSample1 As PictureBox
    Friend WithEvents ImportPopSkin1 As Button
    Friend WithEvents TextFileName2 As TextBox
    Friend WithEvents AppIconSample1 As PictureBox
    Friend WithEvents ImportAppIcon1 As Button
    Friend WithEvents TextFileName1 As TextBox
    Friend WithEvents ThemeIconSample1 As PictureBox
    Friend WithEvents ImportThemeIcon1 As Button
    Friend WithEvents TextFileName3 As TextBox
    Friend WithEvents InfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents infoTB2 As TextBox
    Friend WithEvents infoAP1 As Label
    Friend WithEvents infoTB4 As TextBox
    Friend WithEvents infoTN1 As Label
    Friend WithEvents infoTB6 As TextBox
    Friend WithEvents infoTD1 As Label
    Friend WithEvents infoTB5 As TextBox
    Friend WithEvents infoTA1 As Label
    Friend WithEvents infoTB1 As TextBox
    Friend WithEvents infoSave As Button
    Friend WithEvents infoAN1 As Label
    Friend WithEvents Tip2 As Label
    Friend WithEvents InstallFrameWorkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveFrameWorkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents XMLTextBox1 As TextBox
    Friend WithEvents UpdateCheckToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Tip1 As Label
    Friend WithEvents infoTB3 As TextBox
    Friend WithEvents infoAV1 As Label
    Friend WithEvents ResetImagesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents colorPick As ColorDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents infoCol1 As mkc_ColorCombobox
    Friend WithEvents Tip3 As Label
    Friend WithEvents CleanTheTempoaryFilesToolStripMenuItem As ToolStripMenuItem
End Class
