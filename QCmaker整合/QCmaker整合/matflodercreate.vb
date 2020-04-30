Imports System.IO
Public Class matflodercreate

    Private Sub TextBox1_DragDrop(sender As Object, e As DragEventArgs) Handles TextBox1.DragDrop
        Dim files As String()
        Try
            files = CType(e.Data.GetData(DataFormats.FileDrop), String())
            TextBox1.Text = files(files.Length - 1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return
        End Try
        Dim drop = Microsoft.VisualBasic.Right(TextBox1.Text, Len(TextBox1.Text) - InStrRev(TextBox1.Text, ".") + 1)
        If drop <> ".qc" Then
            MessageBox.Show("不是qc文件无法识别", "报错")
            TextBox1.Text = Nothing
        End If
    End Sub
    Private Sub TextBox1_DragEnter(sender As Object, e As DragEventArgs) Handles TextBox1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Link
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Tb3 As String
        If TextBox1.Text = Nothing Then
            MessageBox.Show("无文件处理(no file)", "报错")
            Exit Sub
        End If
        Dim read1 = File.ReadAllLines(TextBox1.Text)
        For i = 0 To read1.Length - 1
            Try
                If read1(i) <> Nothing Then
                    Tb3 &= read1(i)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Next
        Dim str1 As String
        str1 = Tb3

        '替换大小写
        str1 = Replace(str1, "CDMaterials", "cdmaterials")
        str1 = Replace(str1, "CDmaterials", "cdmaterials")
        str1 = Replace(str1, "CdMaterials", "cdmaterials")
        str1 = Replace(str1, "cdMaterials", "cdmaterials")


        Dim str4 As String()
        Dim str2 As String
        str4 = Split(str1, "$")
        For i = 0 To str4.Length - 1
            Dim bo As Boolean
            bo = InStr(str4(i), "cdmaterials")
            If bo = True Then
                str2 &= str4(i)
            End If
        Next
        str2 = Replace(Replace(str2, vbCr, ""), vbLf, "")
        Dim str3 As String()
        Try
            str3 = Split(str2, "cdmaterials")
        Catch ex As Exception
            MessageBox.Show("无法找到(can't find): cdmaterials")
        End Try
        For i = 1 To str3.Length - 1
            str3(i) = Replace(str3(i), " ", "")
            str3(i) = Replace(str3(i), """", "")
            TextBox3.Text &= "获取材质文件夹路径(get mat path)：" & str3(i) & vbCrLf & vbCrLf
        Next
        For i = 1 To str3.Length - 1

            '引用
            Dim matpath = Microsoft.VisualBasic.Left(TextBox1.Text, InStrRev(TextBox1.Text, "\")) & "materials\"
            Dim floderpath As String = str3(i)
            Dim every As String
            Try
                Dim arr As Array = Split(floderpath, "\")
                For p = 0 To arr.GetLength(0) - 1
                    If arr(p) <> Nothing Then
                        If p = 0 Then
                            every = matpath & arr(p)
                        ElseIf p <> 0 Then
                            every = every & "\" & arr(p)
                        End If
                        Try
                            Directory.CreateDirectory(every)
                        Catch ex As Exception
                            Exit For
                        End Try
                    End If
                Next
            Catch ex As Exception
            End Try
            '引用结束
            TextBox3.Text &= "创建完成，材质文件夹(created, mat floder):" & every & vbCrLf & vbCrLf
        Next
        TextBox3.Text &= "运行结束(finish)" & vbCrLf & vbCrLf
















    End Sub

    Private Sub matflodercreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Main.Tag = "en" Then
            Me.Text = "mat floder creator"
            Label1.Text = "Drag QC file in"
            Button1.Text = "Do"
        End If
    End Sub
End Class
