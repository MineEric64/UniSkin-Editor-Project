'=====================================================================================
'  mkc_ColorCombobox
'  combobox color picker control
'=====================================================================================
'  Created By: Marc Cramer
'  Published Date: 1/28/2003
'  Legal Copyright: Marc Cramer ?1/28/2003
'=====================================================================================
' Notes: GetIDEBackgroundColor is based on the function CalculateColor found in ColorUtil.cs written by Carlos H. Perez
'=====================================================================================
Imports System
Imports System.ComponentModel

Public Class mkc_ColorCombobox
	Inherits System.Windows.Forms.UserControl

#Region " Variable Declaration "
	'=====================================================================================
	' VARIABLE DECLARATION
	'=====================================================================================
	Dim Known_Color() As String = Split("Transparent,Black,DimGray,Gray,DarkGray,Silver,LightGray,Gainsboro,WhiteSmoke,White,RosyBrown,IndianRed,Brown,Firebrick,LightCoral,Maroon,DarkRed,Red,Snow,MistyRose,Salmon,Tomato,DarkSalmon,Coral,OrangeRed,LightSalmon,Sienna,SeaShell,Chocalate,SaddleBrown,SandyBrown,PeachPuff,Peru,Linen,Bisque,DarkOrange,BurlyWood,Tan,AntiqueWhite,NavajoWhite,BlanchedAlmond,PapayaWhip,Mocassin,Orange,Wheat,OldLace,FloralWhite,DarkGoldenrod,Cornsilk,Gold,Khaki,LemonChiffon,PaleGoldenrod,DarkKhaki,Beige,LightGoldenrod,Olive,Yellow,LightYellow,Ivory,OliveDrab,YellowGreen,DarkOliveGreen,GreenYellow,Chartreuse,LawnGreen,DarkSeaGreen,ForestGreen,LimeGreen,PaleGreen,DarkGreen,Green,Lime,Honeydew,SeaGreen,MediumSeaGreen,SpringGreen,MintCream,MediumSpringGreen,MediumAquaMarine,YellowAquaMarine,Turquoise,LightSeaGreen,MediumTurquoise,DarkSlateGray,PaleTurquoise,Teal,DarkCyan,Aqua,Cyan,LightCyan,Azure,DarkTurquoise,CadetBlue,PowderBlue,LightBlue,DeepSkyBlue,SkyBlue,LightSkyBlue,SteelBlue,AliceBlue,DodgerBlue,SlateGray,LightSlateGray,LightSteelBlue,CornflowerBlue,RoyalBlue,MidnightBlue,Lavender,Navy,DarkBlue,MediumBlue,Blue,GhostWhite,SlateBlue,DarkSlateBlue,MediumSlateBlue,MediumPurple,BlueViolet,Indigo,DarkOrchid,DarkViolet,MediumOrchid,Thistle,Plum,Violet,Purple,DarkMagenta,Magenta,Fuchsia,Orchid,MediumVioletRed,DeepPink,HotPink,LavenderBlush,PaleVioletRed,Crimson,Pink,LightPink", ",")
	Dim System_Color() As String = Split("ActiveBorder,ActiveCaption,ActiveCaptionText,AppWorkspace,Control,ControlDark,ControlDarkDark,ControlLight,ControlLightLight,ControlText,Desktop,GrayText,HighLight,HighLightText,HotTrack,InactiveBorder,InactiveCaption,InactiveCaptionText,Info,InfoText,Menu,MenuText,ScrollBar,Window,WindowFrame,WindowText", ",")
	Dim IDEBackgroundColor As System.Drawing.Color = CalculateIDEBackgroundColor()

	'=====================================================================================
	' PROPERTY VARIABLES
	'=====================================================================================
	Dim m_ColorEnum As ColorEnum = ColorEnum.KnownColor
	Dim m_SelectedColor As System.Drawing.Color
	Dim m_FocusStyle As FocusStyleEnum = FocusStyleEnum.IDE

	'=====================================================================================
	' ENUM DECLARATION
	'=====================================================================================
	Public Enum ColorEnum As Byte
		KnownColor = 0
		SystemColor = 1
	End Enum

	Public Enum FocusStyleEnum As Byte
		IDE = 0
		Normal = 1
	End Enum
	'=====================================================================================
#End Region

#Region " Windows Form Designer generated code "
	'=====================================================================================
	' WINDOWS FORM DESIGNER GENERATED CODE
	'=====================================================================================
	Public Sub New()
		MyBase.New()

		'This call is required by the Windows Form Designer.
		InitializeComponent()

		'Add any initialization after the InitializeComponent() call

	End Sub	  'New
	'=====================================================================================
	'UserControl overrides dispose to clean up the component list.
	Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If Not (components Is Nothing) Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub	  'Dispose(ByVal disposing As Boolean)
	'=====================================================================================
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	Friend WithEvents cboColor As System.Windows.Forms.ComboBox
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cboColor = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cboColor
        '
        Me.cboColor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboColor.Location = New System.Drawing.Point(0, 0)
        Me.cboColor.Name = "cboColor"
        Me.cboColor.Size = New System.Drawing.Size(150, 22)
        Me.cboColor.TabIndex = 0
        '
        'mkc_ColorCombobox
        '
        Me.Controls.Add(Me.cboColor)
        Me.Name = "mkc_ColorCombobox"
        Me.Size = New System.Drawing.Size(150, 24)
        Me.ResumeLayout(False)

    End Sub   'InitializeComponent()
    '=====================================================================================
#End Region

#Region " Events "
    '=====================================================================================
    'EVENTS
    '=====================================================================================
    Public Event SelectedColorChanged(ByVal SelectedColor As System.Drawing.Color)
	'=====================================================================================
	Private Sub cboColor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboColor.SelectedIndexChanged
		' a new value was picked so set variable and fire event
		m_SelectedColor = System.Drawing.Color.FromName(cboColor.Text)
		RaiseEvent SelectedColorChanged(System.Drawing.Color.FromName(cboColor.Text))
	End Sub	  'cboColor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboColor.SelectedIndexChanged
	'=====================================================================================
	Private Sub mkc_ColorPicker_FontChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FontChanged
		' update our font to selected values
		cboColor.Font = Me.Font
	End Sub	  'mkc_ColorPicker_FontChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FontChanged
	'=====================================================================================
#End Region

#Region " Properties "
	'=====================================================================================
	' PROPERTIES
	'=====================================================================================
	<Description("Gets and sets the type of color shown in list."), Category("Display")> _
	Public Property ColorType() As ColorEnum
		Get
			Return m_ColorEnum
		End Get
		Set(ByVal Value As ColorEnum)
			m_ColorEnum = Value
			LoadColors(Value)
		End Set
	End Property	  'ColorType() As ColorEnum
	'=====================================================================================
	<Description("Gets and sets the currently selected color."), Category("Display")> _
	Public Property SelectedColor() As System.Drawing.Color
		Get
			Return m_SelectedColor
		End Get
		Set(ByVal Value As System.Drawing.Color)
			m_SelectedColor = Value
			Dim ColorIndex As Integer
			ColorIndex = cboColor.FindStringExact(m_SelectedColor.Name)
			cboColor.SelectedIndex = ColorIndex
		End Set
	End Property	  'SelectedColor() As System.Drawing.Color
	'=====================================================================================
	<Description("Gets and sets the focus style."), Category("Display")> _
	Public Property FocusStyle() As FocusStyleEnum
		Get
			Return m_FocusStyle
		End Get
		Set(ByVal Value As FocusStyleEnum)
			m_FocusStyle = Value
			' we want IDE look so calculate the background color
			If m_FocusStyle = FocusStyleEnum.IDE Then IDEBackgroundColor = CalculateIDEBackgroundColor()
		End Set
	End Property	  'FocusStyle() As FocusStyleEnum
	'=====================================================================================
#End Region

#Region " Methods "
	'=====================================================================================
	' METHODS
	'=====================================================================================
	Private Sub cboColor_DrawItem(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles cboColor.DrawItem
		' if a vaild value then draw the color entry
		If e.Index <> -1 Then
			Dim HasFocusFlag As Boolean
			If e.State And DrawItemState.ComboBoxEdit Then
				DrawHighlight(False, e.Graphics, e.Bounds)
				HasFocusFlag = False
			ElseIf e.State And DrawItemState.Focus Then
				DrawHighlight(True, e.Graphics, e.Bounds)
				HasFocusFlag = True
			Else
				DrawHighlight(False, e.Graphics, e.Bounds)
				HasFocusFlag = False
			End If
			ColorItem(e.Graphics, e.Bounds, e.Index, m_ColorEnum, HasFocusFlag)
		End If
	End Sub	  'cboColor_DrawItem(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles cboColor.DrawItem
	'=====================================================================================
#End Region

#Region " Helper Routines "
	'=====================================================================================
	' HELPER ROUTINES
	'=====================================================================================
	Private Sub LoadColors(ByVal ColorEnum As ColorEnum)
		' load our color entry list into the combobox
		Dim Counter As Integer
		Dim ColorArray() As String

		If ColorEnum = ColorEnum.KnownColor Then
			ColorArray = Known_Color
		Else
			ColorArray = System_Color
		End If

		Dim ArrayCount As Integer = ColorArray.GetUpperBound(0)
		cboColor.Items.Clear()
		For Counter = 0 To ArrayCount
			cboColor.Items.Add(ColorArray(Counter))
		Next
	End Sub	  'LoadColors(ByVal ColorEnum As ColorEnum)
	'=====================================================================================
	Private Sub ColorItem(ByVal ItemGraphics As Graphics, ByVal ItemRectangle As Rectangle, ByVal ItemIndex As Integer, ByVal ColorEnum As ColorEnum, ByVal HasFocus As Boolean)
		' draw the color entries
		Dim ItemText As String
		Dim TextBrush As New SolidBrush(System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.MenuText))
		' if we are normal style focus and we our drawing our item with focus change text color to the right color
		If m_FocusStyle = FocusStyleEnum.Normal And HasFocus = True Then TextBrush.Color = System.Drawing.Color.FromKnownColor(KnownColor.HighlightText)
		Select Case ColorEnum
			Case ColorEnum.KnownColor
				ItemText = Known_Color(ItemIndex)
			Case ColorEnum.SystemColor
				ItemText = System_Color(ItemIndex)
		End Select
		Dim ColorBrush As New SolidBrush(System.Drawing.Color.FromName(ItemText))
		Dim Pen As New Pen(System.Drawing.Color.Black, 1)
		With ItemGraphics
			.FillRectangle(ColorBrush, ItemRectangle.Left + 2, ItemRectangle.Top + 2, 20, ItemRectangle.Height - 4)
			.DrawRectangle(Pen, New Rectangle(ItemRectangle.Left + 1, ItemRectangle.Top + 1, 21, ItemRectangle.Height - 3))
			.DrawString(ItemText, cboColor.Font, TextBrush, ItemRectangle.Left + 28, ItemRectangle.Top + (ItemRectangle.Height - cboColor.Font.GetHeight()) / 2)
		End With
		TextBrush.Dispose()
		ColorBrush.Dispose()
		Pen.Dispose()
	End Sub	  'ColorItem(ByVal ItemGraphics As Graphics, ByVal ItemRectangle As Rectangle, ByVal ItemIndex As Integer, ByVal ColorEnum As ColorEnum, ByVal HasFocus As Boolean)
	'=====================================================================================
	Private Sub DrawHighlight(ByVal IsSelected As Boolean, ByVal ItemGraphics As Graphics, ByVal ItemRectangle As Rectangle)
		If IsSelected = False Then
			' draw with out the highlight rectangle
			ItemGraphics.FillRectangle(New SolidBrush(SystemColors.Window), ItemRectangle.Left, ItemRectangle.Top, ItemRectangle.Width, ItemRectangle.Height)
		Else
			' draw with the highlight rectangle
			Dim BorderPen As New Pen(System.Drawing.Color.FromKnownColor(KnownColor.Highlight))
			Dim BackgroundBrush As New SolidBrush(System.Drawing.Color.FromKnownColor(KnownColor.Highlight))
			If m_FocusStyle = FocusStyleEnum.IDE Then BackgroundBrush.Color = IDEBackgroundColor
			ItemGraphics.FillRectangle(BackgroundBrush, ItemRectangle.Left, ItemRectangle.Top, ItemRectangle.Width, ItemRectangle.Height)
			ItemGraphics.DrawRectangle(BorderPen, ItemRectangle.Left, ItemRectangle.Top, ItemRectangle.Width - 1, ItemRectangle.Height - 1)
			BorderPen.Dispose()
			BackgroundBrush.Dispose()
		End If
	End Sub	  'DrawHighlight(ByVal IsSelected As Boolean, ByVal ItemGraphics As Graphics, ByVal ItemRectangle As Rectangle)
	'=====================================================================================
	Private Function CalculateIDEBackgroundColor() As System.Drawing.Color
		' create the background color
		Dim AlphaBlend As Integer = 70
		Dim BorderColor As System.Drawing.Color = System.Drawing.Color.FromArgb(255, System.Drawing.Color.FromKnownColor(KnownColor.Highlight))
		Dim WindowColor As System.Drawing.Color = System.Drawing.Color.FromArgb(255, System.Drawing.Color.FromKnownColor(KnownColor.Window))

		Dim RedValue As Byte = CByte(CSng(BorderColor.R * AlphaBlend / 255 + WindowColor.R * (CSng((255 - AlphaBlend) / 255))))
		Dim BlueValue As Byte = CByte(CSng(BorderColor.B * AlphaBlend / 255 + WindowColor.B * (CSng((255 - AlphaBlend) / 255))))
		Dim GreenValue As Byte = CByte(CSng(BorderColor.G * AlphaBlend / 255 + WindowColor.G * (CSng((255 - AlphaBlend) / 255))))

		CalculateIDEBackgroundColor = System.Drawing.Color.FromArgb(255, RedValue, GreenValue, BlueValue)
	End Function	  'CalculateIDEBackgroundColor() As System.Drawing.Color
	'=====================================================================================
#End Region

End Class
