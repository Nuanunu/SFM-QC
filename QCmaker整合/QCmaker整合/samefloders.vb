Imports System.IO
Public Class samefloders
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim aa
        Dim ab
        Dim ac
        Dim ad
        Dim sw As StreamWriter     'write to file

        aa = TextBox2.Text 'aa是基础路径，要包含\
        ab = TextBox1.Text
        If ab = Nothing Then
            MessageBox.Show("未填写文件夹栏"， "报错")
            Exit Sub
        End If

        If aa = Nothing Then
            MessageBox.Show("路径栏无路径"， "报错")
            Exit Sub
        End If


        Try
            ab = Replace(ab, "，", ",") '替换中英逗号
            ac = Split(ab, ",") '分割每个逗号隔开的字符 ac是字符数组

            For i = 0 To (ac.GetLength(0) - 1) '防止出错
                If ac(i) <> Nothing Then            '防止出现空行
                    Dim path As String
                    path = aa & ac(i)

                    Directory.CreateDirectory(path)

                End If
            Next
            MessageBox.Show("生成完毕"， "完成")
        Catch ex As Exception

            MessageBox.Show(ex.Message， "报错")
            Exit Sub
        End Try

    End Sub

    Private Sub samefloders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Main.Tag = "en" Then
            Me.Text = "Same path folderS generator"
            Label1.Text = "Separate folder names with commas (example: nua,nunu,writer)"
            Label2.Text = "The path (example: F:\mydekstop\nuanunu\) is automatically created if the path does not exist"
            Button1.Text = "Generate file to the path you writed"
        End If

    End Sub
End Class
