Imports System.IO

Public Class vmtcreated


    Private Sub TextBox1_DragEnter(sender As Object, e As DragEventArgs) Handles TextBox1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Link
        End If
    End Sub

    Private Sub TextBox1_DragDrop(sender As Object, e As DragEventArgs) Handles TextBox1.DragDrop

        Dim files As Array = e.Data.GetData(DataFormats.FileDrop)
        For Each file As String In files

            TextBox1.AppendText(file + Environment.NewLine)

        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ab As String
        Dim ac As String()
        Dim ad As String
        Dim ae As String
        Dim File As String
        Dim path As String

        If TextBox1.Text = Nothing Then
            MessageBox.Show("未指定vtf文件"， "报错")
            Exit Sub
        End If

        If TextBox2.Text = Nothing Then
            MessageBox.Show("路径栏无路径"， "报错")
            Exit Sub
        End If

        Dim sw As StreamWriter     'write to file
        Dim sr As StreamReader
        Dim strRead() As String

        Try
            ab = TextBox1.Text
            ac = Split(ab, Chr(10))
            ae = TextBox2.Text
            'T_bdg_z.Clear()
            'ad = "$bodygroup " & Chr(34) & Name_bdg_z.Text & Chr(34) & vbCrLf & "{" & vbCrLf
            For i = 0 To (ac.GetLength(0) - 1) '防止出错
                If ac(i) <> Nothing Then            '防止出现空行
                    'T_bdg_z.AppendText(ac(i) & vbCrLf)   '        Environment.NewLine)
                    'ad = ad & "  studio " & Chr(34) & ac(i) & Chr(34) & vbCrLf
                    File = ac(i)
                    path = Microsoft.VisualBasic.Left(File, InStrRev(File, ".")) & "vmt"
                    sw = New StreamWriter(path, False, System.Text.Encoding.Default)
                    File = Microsoft.VisualBasic.Right(File, Len(File) - InStrRev(File, "\"))
                    File = Microsoft.VisualBasic.Left(File, InStrRev(File, ".") - 1)
                    ad = Chr(34) & "VertexlitGeneric" & Chr(34) & vbCrLf & "{" & vbCrLf & Chr(34) & "$basetexture" & Chr(34) & " " & Chr(34) & ae & File & Chr(34) & " " & vbCrLf & "}"

                    sw.WriteLine(ad)
                    sw.Close()
                    sw = Nothing

                End If

            Next
            MsgBox("写入成功")
            'ad = ad & "  blank" & vbCrLf
            'ad = ad & "}" & vbCrLf
            'T_bdg_z.AppendText(ad)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub vmtcreated_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Main.Tag = "en" Then
            Me.Text = "multi VMTs generator (only base)"
            Label1.Text = "make sure VTFs set right place THEN DRAG them in textbox"
            Label2.Text = "cdmaterials path of QC"
            Button1.Text = "Generate VMTs to VTFs path"
        End If
    End Sub
End Class
