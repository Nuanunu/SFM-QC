VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Begin VB.Form Form1 
   Caption         =   "qcmaker（qc简易制作For SFM）"
   ClientHeight    =   6015
   ClientLeft      =   120
   ClientTop       =   465
   ClientWidth     =   11190
   Icon            =   "qcmaker v0.3.frx":0000
   LinkTopic       =   "Form1"
   ScaleHeight     =   6015
   ScaleWidth      =   11190
   StartUpPosition =   3  '窗口缺省
   Begin VB.CheckBox Check8 
      Caption         =   "$sequence"
      Enabled         =   0   'False
      Height          =   255
      Left            =   480
      TabIndex        =   24
      TabStop         =   0   'False
      Top             =   5160
      Value           =   2  'Grayed
      Width           =   1455
   End
   Begin VB.Frame Frame1 
      Caption         =   "主控"
      Height          =   5535
      Left            =   120
      TabIndex        =   0
      Top             =   360
      Width           =   10935
      Begin VB.Frame Frame4 
         Caption         =   "作者名简写"
         Height          =   735
         Left            =   8880
         TabIndex        =   31
         Top             =   1560
         Width           =   1815
         Begin VB.TextBox username 
            Appearance      =   0  'Flat
            Height          =   375
            Left            =   120
            TabIndex        =   32
            Text            =   "username"
            ToolTipText     =   "字数最好少一点"
            Top             =   240
            Width           =   1575
         End
      End
      Begin VB.Frame Frame3 
         Caption         =   "Qc命名"
         Height          =   735
         Left            =   8880
         TabIndex        =   29
         Top             =   720
         Width           =   1815
         Begin VB.TextBox qcname 
            Appearance      =   0  'Flat
            Height          =   315
            Left            =   120
            TabIndex        =   30
            Text            =   "quest code.qc"
            ToolTipText     =   "自定义qc名称"
            Top             =   240
            Width           =   1575
         End
      End
      Begin VB.TextBox Text9 
         Appearance      =   0  'Flat
         BackColor       =   &H80000004&
         BorderStyle     =   0  'None
         BeginProperty Font 
            Name            =   "宋体"
            Size            =   10.5
            Charset         =   134
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Left            =   8880
         Locked          =   -1  'True
         MultiLine       =   -1  'True
         TabIndex        =   27
         Text            =   "qcmaker v0.3.frx":424A
         Top             =   4920
         Width           =   1935
      End
      Begin VB.PictureBox Picture1 
         Appearance      =   0  'Flat
         BackColor       =   &H80000005&
         ForeColor       =   &H80000008&
         Height          =   975
         Left            =   9360
         Picture         =   "qcmaker v0.3.frx":426F
         ScaleHeight     =   945
         ScaleWidth      =   945
         TabIndex        =   26
         Top             =   3840
         Width           =   975
      End
      Begin VB.CommandButton create2 
         Caption         =   "简易创建"
         BeginProperty Font 
            Name            =   "宋体"
            Size            =   12
            Charset         =   134
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   615
         Left            =   9000
         TabIndex        =   23
         Top             =   2400
         Width           =   1575
      End
      Begin VB.CommandButton create1 
         Caption         =   "自定义创建"
         BeginProperty Font 
            Name            =   "宋体"
            Size            =   12
            Charset         =   134
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   615
         Left            =   9000
         TabIndex        =   22
         Top             =   3120
         Width           =   1575
      End
      Begin VB.Frame Frame2 
         BackColor       =   &H80000004&
         Caption         =   "自定义区"
         ForeColor       =   &H00000000&
         Height          =   4335
         Left            =   120
         TabIndex        =   7
         Top             =   1080
         Width           =   8535
         Begin VB.TextBox Text8 
            Height          =   315
            Left            =   1920
            TabIndex        =   25
            Text            =   "default.smd"
            ToolTipText     =   "动画序列 可以用基础smd模型代替"
            Top             =   3720
            Width           =   6375
         End
         Begin VB.TextBox Text7 
            Height          =   315
            Left            =   1920
            TabIndex        =   21
            Text            =   "default"
            ToolTipText     =   "材质路径(materials文件夹下的路径)"
            Top             =   3240
            Width           =   6375
         End
         Begin VB.TextBox Text6 
            Height          =   315
            Left            =   1920
            TabIndex        =   20
            Text            =   "default.smd"
            ToolTipText     =   "额外smd模型名"
            Top             =   2760
            Width           =   6375
         End
         Begin VB.TextBox Text5 
            Height          =   315
            Left            =   1920
            TabIndex        =   19
            Text            =   "default.smd"
            ToolTipText     =   "额外smd模型名"
            Top             =   2280
            Width           =   6375
         End
         Begin VB.TextBox Text4 
            Height          =   315
            Left            =   1920
            TabIndex        =   18
            Text            =   "default.smd"
            ToolTipText     =   "额外smd模型名"
            Top             =   1800
            Width           =   6375
         End
         Begin VB.TextBox Text3 
            Height          =   315
            Left            =   1920
            TabIndex        =   17
            Text            =   "default.smd"
            ToolTipText     =   "额外smd模型名"
            Top             =   1320
            Width           =   6375
         End
         Begin VB.TextBox Text2 
            Height          =   315
            Left            =   1920
            TabIndex        =   16
            Text            =   "default.smd"
            ToolTipText     =   "主smd模型"
            Top             =   840
            Width           =   6375
         End
         Begin VB.TextBox Text1 
            Height          =   315
            Left            =   1920
            TabIndex        =   15
            Text            =   "default.mdl"
            ToolTipText     =   "mdl模型名字"
            Top             =   360
            Width           =   6375
         End
         Begin VB.CheckBox Check7 
            Caption         =   "$cdmaterials"
            Enabled         =   0   'False
            Height          =   255
            Left            =   240
            TabIndex        =   14
            TabStop         =   0   'False
            Top             =   3240
            Value           =   2  'Grayed
            Width           =   1455
         End
         Begin VB.CheckBox Check6 
            Caption         =   "$bodygroup4"
            Height          =   255
            Left            =   240
            TabIndex        =   13
            Top             =   2760
            Width           =   1455
         End
         Begin VB.CheckBox Check5 
            Caption         =   "$bodygroup3"
            Height          =   255
            Left            =   240
            TabIndex        =   12
            Top             =   2280
            Width           =   1455
         End
         Begin VB.CheckBox Check4 
            Caption         =   "$bodygroup2"
            Height          =   255
            Left            =   240
            TabIndex        =   11
            Top             =   1800
            Width           =   1455
         End
         Begin VB.CheckBox Check3 
            Caption         =   "$bodygroup"
            Height          =   255
            Left            =   240
            TabIndex        =   10
            Top             =   1320
            Width           =   1335
         End
         Begin VB.CheckBox Check2 
            Caption         =   "$body"
            Height          =   255
            Left            =   240
            TabIndex        =   9
            Top             =   840
            Value           =   1  'Checked
            Width           =   1335
         End
         Begin VB.CheckBox Check1 
            Caption         =   "$modelname"
            Enabled         =   0   'False
            Height          =   255
            Left            =   240
            TabIndex        =   8
            TabStop         =   0   'False
            Top             =   360
            Value           =   2  'Grayed
            Width           =   1335
         End
         Begin VB.Line Line1 
            BorderColor     =   &H008080FF&
            Visible         =   0   'False
            X1              =   1800
            X2              =   1800
            Y1              =   120
            Y2              =   4320
         End
      End
      Begin VB.TextBox Path2 
         Appearance      =   0  'Flat
         Height          =   315
         Left            =   1560
         TabIndex        =   6
         Text            =   "自动同步路径"
         ToolTipText     =   "自动同步路径"
         Top             =   705
         Width           =   7095
      End
      Begin VB.CommandButton Open1 
         Appearance      =   0  'Flat
         Caption         =   "查看"
         Height          =   375
         Left            =   9840
         TabIndex        =   3
         Top             =   240
         Width           =   975
      End
      Begin VB.CommandButton Browse1 
         Appearance      =   0  'Flat
         Caption         =   "设置路径"
         Height          =   375
         Left            =   8760
         TabIndex        =   2
         Top             =   240
         Width           =   975
      End
      Begin VB.TextBox Path1 
         Appearance      =   0  'Flat
         Height          =   315
         Left            =   1560
         TabIndex        =   1
         Text            =   "拖动smd文件到此处"
         ToolTipText     =   "拖动smd文件到此处"
         Top             =   240
         Width           =   7095
      End
      Begin VB.Label Label2 
         Caption         =   "OutPut Path"
         Height          =   255
         Left            =   120
         TabIndex        =   5
         Top             =   720
         Width           =   1335
      End
      Begin VB.Label Label1 
         Caption         =   "SMD File Path"
         Height          =   255
         Left            =   120
         TabIndex        =   4
         Top             =   360
         Width           =   1335
      End
   End
   Begin MSComDlg.CommonDialog CommonDialog1 
      Left            =   10680
      Top             =   0
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.Label Label4 
      Caption         =   "log：修复了函数错误的问题"
      Height          =   255
      Left            =   7920
      TabIndex        =   33
      Top             =   120
      Width           =   2775
   End
   Begin VB.Label Label3 
      Caption         =   "提示：拖动文件到smd目录识别 同步路径可以使自定义区部分自动替换 所有文本框均填英文"
      Height          =   255
      Left            =   120
      TabIndex        =   28
      Top             =   120
      Width           =   10935
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private SMD_Folder_Path As String '变量
Private B As String
Private C As String
Private creater As String
Private mdlname As String
Private smdname As String
Private outputpath As String
Private Long1 As String
Private Long2 As String
Private groupname1 As String
Private groupname2 As String
Private groupname3 As String
Private groupname4 As String




Private Function outfolder() '加杠函数
    Select Case Right(Path2, 1) '判断路径是否包含’\’
       Case "\":
            outputpath = Path2
       Case Else
            outputpath = Path2 & "\"
    End Select
End Function




Private Sub create1_Click() '定义创建
    creater = username
    mdlname = Left(Text1.Text, InStrRev(Text1.Text, ".") - 1)
    smdname = Left(Text2.Text, InStrRev(Text2.Text, ".") - 1)
    groupname1 = Left(Text3.Text, InStrRev(Text3.Text, ".") - 1)
    groupname2 = Left(Text4.Text, InStrRev(Text4.Text, ".") - 1)
    groupname3 = Left(Text5.Text, InStrRev(Text5.Text, ".") - 1)
    groupname4 = Left(Text6.Text, InStrRev(Text6.Text, ".") - 1)
    Call outfolder
    outputpath = Path2 & qcname
    Open outputpath For Output As #1
    Print #1, "// Created by " & creater
    Print #1,
    Print #1, "$modelname " & """" & username & "\" & mdlname & "\" & mdlname & ".mdl" & """"
    Print #1,
    If Check2.Value = 1 Then Print #1, "$body " & """" & smdname & ".smd" & """"
    If Check3.Value = 1 Then
        Print #1, "$bodygroup " & """" & groupname1 & """"
        Print #1, "{"
        Print #1, "studio " & """" & groupname1 & ".smd" & """"
        Print #1, "}"
        End If
    If Check4.Value = 1 Then
        Print #1, "$bodygroup " & """" & groupname2 & """"
        Print #1, "{"
        Print #1, "studio " & """" & groupname2 & ".smd" & """"
        Print #1, "}"
        End If
    If Check5.Value = 1 Then
        Print #1, "$bodygroup " & """" & groupname3 & """"
        Print #1, "{"
        Print #1, "studio " & """" & groupname3 & ".smd" & """"
        Print #1, "}"
        End If
    If Check6.Value = 1 Then
        Print #1, "$bodygroup " & """" & groupname4 & """"
        Print #1, "{"
        Print #1, "studio " & """" & groupname4 & ".smd" & """"
        Print #1, "}"
        End If
    Print #1,
    Print #1, "$surfaceprop " & """" & "flesh" & """"
    Print #1,
    Print #1, "$contents " & """" & "solid" & """"
    Print #1,
    Print #1, "$illumposition 0 0 0"
    Print #1,
    Print #1, "$mostlyopaque"
    Print #1,
    Print #1, "$cdmaterials " & """" & Text7.Text & """"
    Print #1,
    Print #1, "$cbox 0 0 0 0 0 0"
    Print #1, "$bbox 0 0 0 0 0 0"
    Print #1, "$sequence " & """" & "idle" & """" & " {"
    Print #1, "    " & """" & Text8.Text & """"
    Print #1, "    activity " & """" & "ACT_IDLE" & """" & " 1"
    Print #1, "    fadein 0.2"
    Print #1, "    fadeout 0.2"
    Print #1, "    fps 30"
    Print #1, "    loop"
    Print #1, "}"
    Print #1, ""
    Close
End Sub

Private Sub create2_Click() '简易创建
    creater = username
    mdlname = Text1.Text
    smdname = Text2.Text
    Call outfolder
    outputpath = Path2 & qcname
    Open outputpath For Output As #1
    Print #1, "// Created by " & creater
    Print #1,
    Print #1, "$modelname " & """" & username & "\" & C & "\" & C & ".mdl" & """"
    Print #1,
    Print #1, "$body " & """" & C & ".smd" & """"
    Print #1,
    Print #1, "$surfaceprop " & """" & "flesh" & """"
    Print #1,
    Print #1, "$contents " & """" & "solid" & """"
    Print #1,
    Print #1, "$illumposition 0 0 0"
    Print #1,
    Print #1, "$mostlyopaque"
    Print #1,
    Print #1, "$cdmaterials " & """" & "models\" & creater & "\" & C & "\" & """"
    Print #1,
    Print #1, "$cbox 0 0 0 0 0 0"
    Print #1, "$bbox 0 0 0 0 0 0"
    Print #1, "$sequence " & """" & "idle" & """" & " {"
    Print #1, "    " & """" & C & ".smd" & """ "
    Print #1, "    activity " & """" & "ACT_IDLE" & """" & " 1"
    Print #1, "    fadein 0.2"
    Print #1, "    fadeout 0.2"
    Print #1, "    fps 30"
    Print #1, "    loop"
    Print #1, "}"
    Print #1, ""
    Close
End Sub

Private Sub Form_Load() '初始化
Me.Path1.OLEDropMode = 1
Me.Path2.OLEDropMode = 1
Me.Text2.OLEDropMode = 1
Me.Text3.OLEDropMode = 1
Me.Text4.OLEDropMode = 1
Me.Text5.OLEDropMode = 1
Me.Text6.OLEDropMode = 1

End Sub




'拖条

Private Sub Path1_OLEDragDrop(Data As DataObject, Effect As Long, Button As Integer, Shift As Integer, X As Single, Y As Single)
    Dim nCount, nIndex As Integer
    With Data
        nCount = .Files.Count
        For nIndex = 1 To nCount
            strPath = strPath & .Files.Item(nIndex) & vbNewLine
        Next
    End With
    Path1.Text = Trim(strPath)
    Long1 = Len(Path1.Text)
    Long2 = Long1 - InStrRev(Path1.Text, "\")
    B = Right(Path1.Text, Long2)
    'Print B
    'B = Right(B, InStrRev(B, "\"))
    'Print B
    C = Left(B, InStrRev(B, ".") - 1)
    Path2.Text = Left(Path1.Text, InStrRev(Path1.Text, "\"))
    qcname = C & ".qc"
    Text1.Text = C & ".mdl"
    Text2.Text = B
    Text7.Text = "models\" & username & "\" & C & "\"
    Text8.Text = B
End Sub

'查看
Private Sub Open1_Click()
    'SMD_Folder_Path = Left(Path1.Text, InStrRev(Path1.Text, "\"))
    Shell "explorer " & Left(Path1.Text, InStrRev(Path1.Text, "\")), 1
End Sub



'框1浏览
Private Sub Browse1_Click()
    CommonDialog1.Filter = "smdfile(*.smd)|*.smd"
    CommonDialog1.Action = 1
    Path1.Text = CommonDialog1.FileName
End Sub
'输出目录
Private Sub Path2_OLEDragDrop(Data As DataObject, Effect As Long, Button As Integer, Shift As Integer, X As Single, Y As Single)
    Dim nCount, nIndex As Integer
    With Data
        nCount = .Files.Count
        For nIndex = 1 To nCount
            strPath = strPath & .Files.Item(nIndex) & vbNewLine
        Next
    End With
    Path2.Text = Trim(strPath)
    Path2.Text = Left(Path2.Text, InStrRev(Path2.Text, "\"))
End Sub
'group
Private Sub Text2_OLEDragDrop(Data As DataObject, Effect As Long, Button As Integer, Shift As Integer, X As Single, Y As Single)
    Dim nCount, nIndex As Integer
    With Data
        nCount = .Files.Count
        For nIndex = 1 To nCount
            strPath = strPath & .Files.Item(nIndex) & vbNewLine
        Next
    End With
    Text2.Text = Trim(strPath)
    Text2.Text = Right(Text2.Text, Len(Text2.Text) - InStrRev(Text2.Text, "\"))
End Sub

'group
Private Sub Text3_OLEDragDrop(Data As DataObject, Effect As Long, Button As Integer, Shift As Integer, X As Single, Y As Single)
    Dim nCount, nIndex As Integer
    With Data
        nCount = .Files.Count
        For nIndex = 1 To nCount
            strPath = strPath & .Files.Item(nIndex) & vbNewLine
        Next
    End With
    Text3.Text = Trim(strPath)
    Text3.Text = Right(Text3.Text, Len(Text3.Text) - InStrRev(Text3.Text, "\"))
End Sub

'group
Private Sub Text4_OLEDragDrop(Data As DataObject, Effect As Long, Button As Integer, Shift As Integer, X As Single, Y As Single)
    Dim nCount, nIndex As Integer
    With Data
        nCount = .Files.Count
        For nIndex = 1 To nCount
            strPath = strPath & .Files.Item(nIndex) & vbNewLine
        Next
    End With
    Text4.Text = Trim(strPath)
    Text4.Text = Right(Text4.Text, Len(Text4.Text) - InStrRev(Text4.Text, "\"))
End Sub

'group
Private Sub Text5_OLEDragDrop(Data As DataObject, Effect As Long, Button As Integer, Shift As Integer, X As Single, Y As Single)
    Dim nCount, nIndex As Integer
    With Data
        nCount = .Files.Count
        For nIndex = 1 To nCount
            strPath = strPath & .Files.Item(nIndex) & vbNewLine
        Next
    End With
    Text5.Text = Trim(strPath)
    Text5.Text = Right(Text5.Text, Len(Text5.Text) - InStrRev(Text5.Text, "\"))
End Sub

'group
Private Sub Text6_OLEDragDrop(Data As DataObject, Effect As Long, Button As Integer, Shift As Integer, X As Single, Y As Single)
    Dim nCount, nIndex As Integer
    With Data
        nCount = .Files.Count
        For nIndex = 1 To nCount
            strPath = strPath & .Files.Item(nIndex) & vbNewLine
        Next
    End With
    Text6.Text = Trim(strPath)
    Text6.Text = Right(Text6.Text, Len(Text6.Text) - InStrRev(Text6.Text, "\"))
End Sub




'同步用户名
Private Sub username_Change()
    Text7.Text = "models\" & username & "\" & C & "\"
End Sub
