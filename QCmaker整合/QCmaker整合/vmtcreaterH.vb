Imports System.IO
Public Class vmtcreaterH
    Dim FilePath As String = "C:\"
    Private Sub vtffiles_DragEnter(sender As Object, e As DragEventArgs) Handles t1.DragEnter, t2.DragEnter, t3.DragEnter, t4.DragEnter, t6.DragEnter, t7.DragEnter, t8.DragEnter, t9.DragEnter, t10.DragEnter, t11.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Link
        End If
    End Sub
    Private Sub vtffiles_DragDrop(sender As Object, e As DragEventArgs) Handles t1.DragDrop, t2.DragDrop, t3.DragDrop, t4.DragDrop, t6.DragDrop, t7.DragDrop, t8.DragDrop, t9.DragDrop, t10.DragDrop, t11.DragDrop
        Dim vtffiles As TextBox = sender
        Dim files As String()
        Try
            files = CType(e.Data.GetData(DataFormats.FileDrop), String())
            vtffiles.Text = files(files.Length - 1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return
        End Try
        FilePath = Mid(vtffiles.Text, 1, InStrRev(vtffiles.Text, "\") - 1)
        'filepath ceshi 
        'MessageBox.Show(FilePath)
        Dim drop = Microsoft.VisualBasic.Right(vtffiles.Text, Len(vtffiles.Text) - InStrRev(vtffiles.Text, ".") + 1)
        If drop <> ".vtf" Then
            MessageBox.Show("不是vtf文件无法识别", "报错")
            vtffiles.Text = Nothing
            Exit Sub
        End If
        Dim bo As Boolean
        bo = InStr(vtffiles.Text, "materials\")
        If bo = False Then
            MessageBox.Show("vtf文件需要放在materials目录下", "报错")
            vtffiles.Text = Nothing
            Exit Sub
        End If
        vtffiles.Text = Microsoft.VisualBasic.Mid(vtffiles.Text, InStrRev(vtffiles.Text, "materials\") + 10)
        Console.WriteLine(vtffiles.Text)
        vtffiles.Text = Microsoft.VisualBasic.Left(vtffiles.Text, Len(vtffiles.Text) - 4)


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        baseP.Height = 70
        detailP.Height = 35
        highP.Height = 35
        envirP.Height = 35
        illuP.Height = 35
        otherP.Height = 35


        '英文
        If Main.Tag = "en" Then
            '标题
            Me.Text = "Enhance VMT generator"
            'under
            Label1.Text = "base"
            Label8.Text = "base use alpha"
            Label6.Text = "bump"
            Label11.Text = "warp"
            Label12.Text = "nocull"
            's.Text =""
            Label48.Text = "detail"
            Label47.Text = "show percent"
            Label9.Text = "use uv"
            Label39.Text = "fake illu"
            Label46.Text = "percent 0-1"
            'h.Text =""
            Label2.Text = "highlight"
            Label13.Text = "brightness"
            Label14.Text = "hardness"
            Label15.Text = "fresnel"
            Label16.Text = "highlight"
            Label17.Text = "use base alpha as highlight"
            Label18.Text = "give highlight RGB to base"
            Label19.Text = "int 1-100 can 100+"
            Label20.Text = "percent 0-1 can 1+"
            Label21.Text = "[Φx Φy Φz] as [0.05 0.5 1]"
            's.Text =""
            Label3.Text = "envmap"
            Label22.Text = "envmap"
            Label24.Text = "mask"
            Label26.Text = "contrast"
            Label28.Text = "saturation"
            Label30.Text = "tint"
            Label23.Text = "default = env_map"
            Label25.Text = "percent 0-1 can 1+"
            Label27.Text = "percent 0-1 can 1+"
            Label29.Text = "RGB as [255 255 255]"
            's.Text =""
            Label10.Text = "selfillum"
            Label32.Text = "tint"
            Label33.Text = "mask"
            Label34.Text = "tinttexture"
            Label31.Text = "RGB as [255 255 255]"
            's.Text =""
            Label5.Text = "other"
            Label36.Text = "color"
            Label35.Text = "RGB as [255 255 255] OR float as 1.0"
            Label37.Text = "use ssao"
            Label38.Text = "ssao texture"
            Label4.Text = "default = use(on)"
            's.Text =""
            Label7.Text = "vmt name"


            'checkbxo.Text =""
            CheckBox1.Text = "on"
            CheckBox2.Text = "on"
            CheckBox3.Text = "on"
            CheckBox4.Text = "on"
            CheckBox5.Text = "on"
            CheckBox6.Text = "on"
            CheckBox7.Text = "on"
            CheckBox8.Text = "on"
            CheckBox9.Text = "on"
            CheckBox10.Text = "off"
            CheckBox11.Text = "on"

            'button
            baseB.Text = "+"
            detailB.Text = "+"
            highB.Text = "+"
            envirB.Text = "+"
            illuB.Text = "+"
            otherB.Text = "+"
            creat.Text = "Save as"





        End If
    End Sub

    Private Sub baseB_Click(sender As Object, e As EventArgs) Handles baseB.Click
        Select Case baseB.Tag
            Case 1
                baseP.Height = 70
                baseB.Tag = 0
            Case 0
                baseP.Height = 169
                baseB.Tag = 1
        End Select

    End Sub

    Private Sub detailB_Click(sender As Object, e As EventArgs) Handles detailB.Click
        Select Case detailB.Tag
            Case 1
                detailP.Height = 35
                detailB.Tag = 0
            Case 0
                detailP.Height = 143
                detailB.Tag = 1
        End Select
    End Sub

    Private Sub highB_Click(sender As Object, e As EventArgs) Handles highB.Click
        Select Case highB.Tag
            Case 1
                highP.Height = 35
                highB.Tag = 0
            Case 0
                highP.Height = 241
                highB.Tag = 1
        End Select
    End Sub

    Private Sub envirB_Click(sender As Object, e As EventArgs) Handles envirB.Click
        Select Case envirB.Tag
            Case 1
                envirP.Height = 35
                envirB.Tag = 0
            Case 0
                envirP.Height = 212
                envirB.Tag = 1
        End Select
    End Sub

    Private Sub illuB_Click(sender As Object, e As EventArgs) Handles illuB.Click
        Select Case illuB.Tag
            Case 1
                illuP.Height = 35
                illuB.Tag = 0
            Case 0
                illuP.Height = 144
                illuB.Tag = 1
        End Select
    End Sub

    Private Sub otherB_Click(sender As Object, e As EventArgs) Handles otherB.Click
        Select Case otherB.Tag
            Case 1
                otherP.Height = 35
                otherB.Tag = 0
            Case 0
                otherP.Height = 144
                otherB.Tag = 1
        End Select
    End Sub

    Private Sub t1_TextChanged(sender As Object, e As EventArgs) Handles t1.TextChanged
        Dim info = Microsoft.VisualBasic.Mid(t1.Text, InStrRev(t1.Text, "\") + 1)

        If InStr(info, " ") > 0 Then
            MessageBox.Show("贴图名不能包含空格，请使用_", "提示")
            t1.Text = Replace(t1.Text, " ", "")
        End If

        vmtnameTB.Text = Microsoft.VisualBasic.Mid(t1.Text, InStrRev(t1.Text, "\") + 1) & ".vmt"
    End Sub
    Private Sub ts_TextChanged(sender As Object, e As EventArgs) Handles t2.TextChanged, t3.TextChanged, t4.TextChanged, t6.TextChanged, t7.TextChanged, t8.TextChanged, t9.TextChanged, t10.TextChanged, t11.TextChanged
        Dim ts = sender
        Dim info = Microsoft.VisualBasic.Mid(ts.Text, InStrRev(ts.Text, "\") + 1)

        If InStr(info, " ") > 0 Then
            MessageBox.Show("贴图名不能包含空格，请使用_", "提示")
            ts.Text = Replace(ts.Text, " ", "")
        End If
    End Sub

    Private Sub creat_Click(sender As Object, e As EventArgs) Handles creat.Click
        'english
        If Main.Tag = "en" Then

            SaveFileDialog1.FileName = vmtnameTB.Text
            SaveFileDialog1.InitialDirectory = FilePath
            SaveFileDialog1.ShowDialog()
            'MessageBox.Show(SaveFileDialog1.FileName)
            If SaveFileDialog1.FileName = Nothing Then
                Return
            End If
            Dim sw = New StreamWriter(SaveFileDialog1.FileName, False, System.Text.Encoding.Default)
            sw.WriteLine("""" & "VertexlitGeneric" & """")
            sw.WriteLine("{")
            sw.WriteLine("//basetexture part")
            '基础贴图
            If t1.Text <> Nothing Then
                sw.WriteLine("  $basetexture " & """" & t1.Text & """" & "//basetexture")
            End If
            '法线贴图
            If t2.Text <> Nothing Then
                sw.WriteLine("  $bumpmap " & """" & t2.Text & """" & "//$bumpmap")
            End If
            '翘曲贴图
            If t3.Text <> Nothing Then
                sw.WriteLine("  $lightwarptexture " & """" & t3.Text & """" & "//$lightwarptexture")
            End If
            '基础贴图使用透明通道
            If CheckBox1.Checked <> False Then
                sw.WriteLine("  $alpha " & "1" & "//The base map uses a transparent channel")
            End If
            '无视正反面
            If CheckBox4.Checked <> False Then
                sw.WriteLine("  $nocull " & "1" & "//Ignore heads and tails")
            End If
            sw.WriteLine("")
            sw.WriteLine("//Detail map part")
            '细节贴图
            If t4.Text <> Nothing Then
                sw.WriteLine("  $detail " & """" & t4.Text & """" & "//$detail map")
                '可见程度
                If TextBox23.Text <> Nothing Then
                    sw.WriteLine("  $detailblendfactor " & """" & TextBox23.Text & """" & "//visibility")
                End If
                '对准UV
                If CheckBox8.Checked <> False Then
                    sw.WriteLine("  $detailscale " & "1" & "//Aimed at the UV")
                End If
                '开启伪自发光
                If CheckBox11.Checked <> False Then
                    sw.WriteLine("  $detailblendmode " & "5" & "//Turn on fake illumination")

                End If
            End If
            sw.WriteLine("")
            sw.WriteLine("//highlight map part")
            '高光
            If CheckBox2.Checked <> False Then
                sw.WriteLine("  $phong " & "1" & "//highlight")
                '亮度
                If TextBox5.Text <> Nothing Then
                    sw.WriteLine("  $phongexponent " & """" & TextBox5.Text & """" & "//brightness")
                End If
                '硬度
                If TextBox6.Text <> Nothing Then
                    sw.WriteLine("  $phongboost " & """" & TextBox6.Text & """" & "//hardness")
                End If
                '菲涅尔距离
                If TextBox7.Text <> Nothing Then
                    sw.WriteLine("  $phongfresnelranges " & """" & TextBox7.Text & """" & "//fresnelranges")
                End If
                '高光贴图
                If t6.Text <> Nothing Then
                    sw.WriteLine("  $phongexponenttexture " & """" & t6.Text & """" & "//highlight texture")
                End If
                '使用基础贴图alpha通道作为高光贴图
                If CheckBox6.Checked <> False Then
                    sw.WriteLine("  $basemapalphaphongmask " & "1" & "//Use the base map alpha channel as the specular map")
                End If
                '高光贴图的颜色附给基础贴图
                If CheckBox5.Checked <> False Then
                    sw.WriteLine("  $phongalbedotint " & "1" & "//The color of the specular map is attached to the base map")
                End If
            End If

            sw.WriteLine("")
            sw.WriteLine("//envmap part")
            '环境反射
            If CheckBox5.Checked <> False Then
                '环境贴图
                If t7.Text <> Nothing Then
                    sw.WriteLine("  $envmap " & """" & t7.Text & """" & "//Environment map")
                ElseIf t7.Text = Nothing Then
                    sw.WriteLine("  $envmap " & """" & "env_cubemap" & """" & "//Environment map")
                End If
                '遮罩贴图
                If t8.Text <> Nothing Then
                    sw.WriteLine("  $envmapmask " & """" & t8.Text & """" & "//Environment mask map")
                End If
                '对比度
                If TextBox10.Text <> Nothing Then
                    sw.WriteLine("  $envmapsaturation " & """" & TextBox11.Text & """" & "//saturation")
                End If
                '饱和度
                If TextBox11.Text <> Nothing Then
                    sw.WriteLine("  $envmapcontrast " & """" & TextBox10.Text & """" & "//contrast")
                End If
                '环境反射颜色
                If TextBox12.Text <> Nothing Then
                    sw.WriteLine("  $envmaptint " & """" & TextBox12.Text & """" & "//Ambient reflection color")
                End If
            End If

            sw.WriteLine("")
            sw.WriteLine("//selfillum part")
            '强制着色
            If CheckBox7.Checked <> False Then
                sw.WriteLine("  $selfillum " & "1" & "//Force shading")
            End If
            '强制着色颜色
            If TextBox13.Text <> Nothing Then
                sw.WriteLine("  $selfillumtint " & """" & TextBox13.Text & """" & "//Forced shading color")
            End If
            '着色遮罩贴图
            If t9.Text <> Nothing Then
                sw.WriteLine("  $selfillummask " & """" & t9.Text & """" & "//mask map")
            End If
            '着色颜色贴图
            If t10.Text <> Nothing Then
                sw.WriteLine("  $selfillumtexture " & """" & t10.Text & """" & "//Color map")
            End If
            sw.WriteLine("")
            sw.WriteLine("//other part")
            '漫反射颜色/亮度
            If CheckBox9.Checked <> False Then
                'RGB数组 例:[255 255 255] /浮点数 例:1.0
                If TextBox16.Text <> Nothing Then
                    sw.WriteLine("  $color " & """" & TextBox16.Text & """" & "//RGB array example :[255, 255, 255] / floating point number example :1.0")
                End If
            End If

            '不使用ssao
            If CheckBox10.Checked <> False Then
                sw.WriteLine("  $AmbientOcclusion " & "0" & "//The shadow problem can be solved without using ssao")
            End If
            '指定ssao贴图
            If t11.Text <> Nothing Then
                sw.WriteLine("  $AmbientOcclTexture " & """" & t11.Text & """" & "//Specifying ssao map but can not solve the shadow problem")
            End If
            sw.WriteLine("")
            sw.WriteLine("")
            sw.WriteLine("}")
            sw.Close()
            sw = Nothing


            'fanhui
            Return
        ElseIf Main.Tag <> "en" Then

            SaveFileDialog1.FileName = vmtnameTB.Text
            SaveFileDialog1.InitialDirectory = FilePath
            SaveFileDialog1.ShowDialog()
            'MessageBox.Show(SaveFileDialog1.FileName)
            If SaveFileDialog1.FileName = Nothing Then
                Return
            End If
            Dim sw = New StreamWriter(SaveFileDialog1.FileName, False, System.Text.Encoding.Default)
            sw.WriteLine("""" & "VertexlitGeneric" & """")
            sw.WriteLine("{")
            sw.WriteLine("//基础贴图部分")
            '基础贴图
            If t1.Text <> Nothing Then
                sw.WriteLine("  $basetexture " & """" & t1.Text & """" & "//基础贴图")
            End If
            '法线贴图
            If t2.Text <> Nothing Then
                sw.WriteLine("  $bumpmap " & """" & t2.Text & """" & "//法线贴图")
            End If
            '翘曲贴图
            If t3.Text <> Nothing Then
                sw.WriteLine("  $lightwarptexture " & """" & t3.Text & """" & "//翘曲贴图")
            End If
            '基础贴图使用透明通道
            If CheckBox1.Checked <> False Then
                sw.WriteLine("  $alpha " & "1" & "//基础贴图使用透明通道")
            End If
            '无视正反面
            If CheckBox4.Checked <> False Then
                sw.WriteLine("  $nocull " & "1" & "//无视正反面")
            End If
            sw.WriteLine("")
            sw.WriteLine("//细节贴图部分")
            '细节贴图
            If t4.Text <> Nothing Then
                sw.WriteLine("  $detail " & """" & t4.Text & """" & "//细节贴图")
                '可见程度
                If TextBox23.Text <> Nothing Then
                    sw.WriteLine("  $detailblendfactor " & """" & TextBox23.Text & """" & "//可见程度")
                End If
                '对准UV
                If CheckBox8.Checked <> False Then
                    sw.WriteLine("  $detailscale " & "1" & "//对准UV")
                End If
                '开启伪自发光
                If CheckBox11.Checked <> False Then
                    sw.WriteLine("  $detailblendmode " & "5" & "//开启伪自发光")

                End If
            End If
            sw.WriteLine("")
            sw.WriteLine("//高光贴图部分")
            '高光
            If CheckBox2.Checked <> False Then
                sw.WriteLine("  $phong " & "1" & "//高光")
                '亮度
                If TextBox5.Text <> Nothing Then
                    sw.WriteLine("  $phongexponent " & """" & TextBox5.Text & """" & "//亮度")
                End If
                '硬度
                If TextBox6.Text <> Nothing Then
                    sw.WriteLine("  $phongboost " & """" & TextBox6.Text & """" & "//硬度")
                End If
                '菲涅尔距离
                If TextBox7.Text <> Nothing Then
                    sw.WriteLine("  $phongfresnelranges " & """" & TextBox7.Text & """" & "//菲涅尔距离")
                End If
                '高光贴图
                If t6.Text <> Nothing Then
                    sw.WriteLine("  $phongexponenttexture " & """" & t6.Text & """" & "//高光贴图")
                End If
                '使用基础贴图alpha通道作为高光贴图
                If CheckBox6.Checked <> False Then
                    sw.WriteLine("  $basemapalphaphongmask " & "1" & "//使用基础贴图alpha通道作为高光贴图")
                End If
                '高光贴图的颜色附给基础贴图
                If CheckBox5.Checked <> False Then
                    sw.WriteLine("  $phongalbedotint " & "1" & "//高光贴图的颜色附给基础贴图")
                End If
            End If

            sw.WriteLine("")
            sw.WriteLine("//环境反射部分")
            '环境反射
            If CheckBox5.Checked <> False Then
                '环境贴图
                If t7.Text <> Nothing Then
                    sw.WriteLine("  $envmap " & """" & t7.Text & """" & "//环境贴图")
                ElseIf t7.Text = Nothing Then
                    sw.WriteLine("  $envmap " & """" & "env_cubemap" & """" & "//环境贴图")
                End If
                '遮罩贴图
                If t8.Text <> Nothing Then
                    sw.WriteLine("  $envmapmask " & """" & t8.Text & """" & "//环境遮罩贴图")
                End If
                '对比度
                If TextBox10.Text <> Nothing Then
                    sw.WriteLine("  $envmapsaturation " & """" & TextBox11.Text & """" & "//饱和度")
                End If
                '饱和度
                If TextBox11.Text <> Nothing Then
                    sw.WriteLine("  $envmapcontrast " & """" & TextBox10.Text & """" & "//对比度")
                End If
                '环境反射颜色
                If TextBox12.Text <> Nothing Then
                    sw.WriteLine("  $envmaptint " & """" & TextBox12.Text & """" & "//环境反射颜色")
                End If
            End If

            sw.WriteLine("")
            sw.WriteLine("//强制着色部分")
            '强制着色
            If CheckBox7.Checked <> False Then
                sw.WriteLine("  $selfillum " & "1" & "//强制着色")
            End If
            '强制着色颜色
            If TextBox13.Text <> Nothing Then
                sw.WriteLine("  $selfillumtint " & """" & TextBox13.Text & """" & "//强制着色颜色")
            End If
            '着色遮罩贴图
            If t9.Text <> Nothing Then
                sw.WriteLine("  $selfillummask " & """" & t9.Text & """" & "//着色遮罩贴图")
            End If
            '着色颜色贴图
            If t10.Text <> Nothing Then
                sw.WriteLine("  $selfillumtexture " & """" & t10.Text & """" & "//着色颜色贴图")
            End If
            sw.WriteLine("")
            sw.WriteLine("//其他单项")
            '漫反射颜色/亮度
            If CheckBox9.Checked <> False Then
                'RGB数组 例:[255 255 255] /浮点数 例:1.0
                If TextBox16.Text <> Nothing Then
                    sw.WriteLine("  $color " & """" & TextBox16.Text & """" & "//RGB数组 例:[255 255 255] /浮点数 例:1.0")
                End If
            End If

            '不使用ssao
            If CheckBox10.Checked <> False Then
                sw.WriteLine("  $AmbientOcclusion " & "0" & "//不使用ssao 能解决阴影问题")
            End If
            '指定ssao贴图
            If t11.Text <> Nothing Then
                sw.WriteLine("  $AmbientOcclTexture " & """" & t11.Text & """" & "//指定ssao贴图 不能解决阴影出错问题")
            End If
            sw.WriteLine("")
            sw.WriteLine("")
            sw.WriteLine("}")
            sw.Close()
            sw = Nothing


            'fanhui
            Return
        End If

    End Sub
End Class