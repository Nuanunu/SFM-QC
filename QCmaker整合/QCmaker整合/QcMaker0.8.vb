Imports System.IO
Public Class Main
    Private Sub B_smdpath_s_Click(sender As Object, e As EventArgs) Handles B_smdpath_s.Click
        OpenFileDialog1.ShowDialog()
        T_smdpath_s.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub B_outpath_s_Click(sender As Object, e As EventArgs) Handles B_outpath_s.Click
        FolderBrowserDialog1.ShowDialog()
        T_outpath_s.Text = FolderBrowserDialog1.SelectedPath
        T_outpath_s.Text = T_outpath_s.Text & "\"
    End Sub

    Private Sub B_preview_s_Click(sender As Object, e As EventArgs) Handles B_preview_s.Click

        Dim smdpath As String
        Dim outpath As String
        Dim qcname As String
        Dim filenamenodrop As String
        smdpath = T_smdpath_s.Text
        outpath = T_outpath_s.Text
        filenamenodrop = Microsoft.VisualBasic.Right(smdpath, Len(smdpath) - InStrRev(smdpath, "\"))
        Try
            filenamenodrop = Microsoft.VisualBasic.Left(filenamenodrop, InStrRev(filenamenodrop, ".") - 1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return
        End Try
        qcname = filenamenodrop & ".qc"


        Dim cd As String
        cd = outpath
        'cd = Microsoft.VisualBasic.Left(cd, Len(cd) - 1)
        cd = Chr(34) & cd & Chr(34)

        Dim qcpath As String   'qcpath
        qcpath = outpath & qcname

        Dim username As String  'username
        username = "qcmaker"

        Dim mdl As String  'mdl
        mdl = username & "\" & filenamenodrop & "\" & filenamenodrop & ".mdl"
        mdl = Chr(34) & mdl & Chr(34)

        Dim body As String   'body
        body = filenamenodrop & ".smd"
        body = Chr(34) & body & Chr(34)

        Dim sequence As String
        sequence = body

        Dim cdm As String
        cdm = "models\" & username & "\" & filenamenodrop & "\"
        cdm = Chr(34) & cdm & Chr(34)

        Dim sw As StreamWriter     'write to file
        Dim sr As StreamReader
        Dim strRead() As String
        sw = New StreamWriter(qcpath, False, System.Text.Encoding.Default)

        'sw.WriteLine("//created by " & username)
        'sw.WriteLine()
        'sw.WriteLine("$cd " & cd)
        'sw.WriteLine()

        'sw.WriteLine("$modelname " & mdl)
        'sw.WriteLine()
        'sw.WriteLine("$model " & body)
        'sw.WriteLine()
        'sw.WriteLine("$surfaceprop " & Chr(34) & "flesh" & Chr(34))
        'sw.WriteLine()
        'sw.WriteLine("$contents " & Chr(34) & "solid" & Chr(34))
        'sw.WriteLine()
        'sw.WriteLine("$illumposition 0 0 0")
        'sw.WriteLine()
        'sw.WriteLine("$mostlyopaque")
        'sw.WriteLine()
        'sw.WriteLine("$cdmaterials " & cdm)
        'sw.WriteLine()
        'sw.WriteLine("$cbox 0 0 0 0 0 0")
        'sw.WriteLine("$bbox 0 0 0 0 0 0")
        'sw.WriteLine("$sequence " & Chr(34) & "idle" & Chr(34) & " {")
        'sw.WriteLine("    " & sequence)
        'sw.WriteLine("    activity " & """" & "ACT_IDLE" & """" & " 1")
        'sw.WriteLine("    fadein 0.2")
        'sw.WriteLine("    fadeout 0.2")
        'sw.WriteLine("    fps 30")
        'sw.WriteLine("    loop")
        'sw.WriteLine("}")
        'sw.WriteLine()

        Dim aa As String
        aa = T_preview_s.Text
        sw.WriteLine(aa)
        sw.Close()
        sw = Nothing
        MsgBox("写入成功，文件位于" & outpath)
    End Sub

    Private Sub T_smdpath_s_DragEnter(sender As Object, e As DragEventArgs) Handles T_smdpath_s.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Link
        End If
    End Sub
    Private Sub T_smdpath_s_DragDrop(sender As Object, e As DragEventArgs) Handles T_smdpath_s.DragDrop
        Dim files As String()
        Try
            files = CType(e.Data.GetData(DataFormats.FileDrop), String())
            Me.T_smdpath_s.Text = files(files.Length - 1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return
        End Try
        T_outpath_s.Text = Microsoft.VisualBasic.Left(T_smdpath_s.Text, InStrRev(T_smdpath_s.Text, "\"))

    End Sub
    Private Sub T_smdpath_s_TextChanged(sender As Object, e As EventArgs) Handles T_smdpath_s.TextChanged
        T_outpath_s.Text = Microsoft.VisualBasic.Left(T_smdpath_s.Text, InStrRev(T_smdpath_s.Text, "\"))
        Dim aa As String
        'aa = T_preview_s.Text

        Dim smdpath As String
        Dim outpath As String
        Dim qcname As String
        Dim filenamenodrop As String
        Dim filenamenodrop2 As String
        smdpath = T_smdpath_s.Text
        outpath = T_outpath_s.Text
        filenamenodrop = Microsoft.VisualBasic.Right(smdpath, Len(smdpath) - InStrRev(smdpath, "\"))
        filenamenodrop2 = Microsoft.VisualBasic.Left(filenamenodrop, InStrRev(filenamenodrop, ".") - 1)
        qcname = filenamenodrop2 & ".qc"


        Dim cd As String
        cd = outpath
        'cd = Microsoft.VisualBasic.Left(cd, Len(cd) - 1)
        cd = Chr(34) & cd & Chr(34)

        Dim qcpath As String   'qcpath
        qcpath = outpath & "\" & qcname

        Dim username As String  'username
        username = "qcmaker"

        Dim mdl As String  'mdl
        mdl = username & "\" & filenamenodrop2 & "\" & filenamenodrop2 & ".mdl"
        mdl = Chr(34) & mdl & Chr(34)

        Dim body As String   'body
        body = filenamenodrop '& ".smd"
        body = Chr(34) & body & Chr(34)

        Dim sequence As String
        sequence = body

        Dim cdm As String
        cdm = "models\" & username & "\" & filenamenodrop2 & "\"
        cdm = Chr(34) & cdm & Chr(34)

        aa = "//created by " & username & vbCrLf
        'aa = aa & "$cd " & cd & vbCrLf
        aa = aa & "$modelname " & mdl & vbCrLf
        aa = aa & "$model " & Chr(34) & "body" & Chr(34) & " " & body & vbCrLf
        'aa = aa & "$surfaceprop " & Chr(34) & "flesh" & Chr(34) & vbCrLf
        'aa = aa & "$contents " & Chr(34) & "solid" & Chr(34) & vbCrLf
        'aa = aa & "$illumposition 0 0 0" & vbCrLf
        aa = aa & "$mostlyopaque" & vbCrLf
        aa = aa & "$cdmaterials " & cdm & vbCrLf
        aa = aa & "$sequence " & Chr(34) & "idle" & Chr(34) & " {" & vbCrLf
        aa = aa & "    " & sequence & vbCrLf
        aa = aa & "    activity " & """" & "ACT_IDLE" & """" & " 1" & vbCrLf
        aa = aa & "    fadein 0.2" & vbCrLf
        aa = aa & "    fadeout 0.2" & vbCrLf
        aa = aa & "    fps 30" & vbCrLf
        aa = aa & "    loop" & vbCrLf
        aa = aa & "}" & vbCrLf

        T_preview_s.Text = aa

    End Sub



    Private Sub List_bdg_z_DragEnter_1(sender As Object, e As DragEventArgs) Handles List_bdg_z.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Link
        End If
    End Sub

    Private Sub List_bdg_z_DragDrop_1(sender As Object, e As DragEventArgs) Handles List_bdg_z.DragDrop
        List_bdg_z.Clear()
        Dim files As Array = e.Data.GetData(DataFormats.FileDrop)
        For Each file As String In files
            file = Microsoft.VisualBasic.Right(file, Len(file) - InStrRev(file, "\"))
            List_bdg_z.AppendText(Chr(34) & file & Chr(34) & vbCrLf)
        Next
    End Sub

    Private Sub B_bdg_z_Click(sender As Object, e As EventArgs) Handles B_bdg_z.Click
        C_bdg.Checked = True

        Dim ab As String
        Dim ac As String()
        Dim ad As String

        ab = List_bdg_z.Text
        ac = Split(ab, Chr(10))
        'T_bdg_z.Clear()
        ad = "$bodygroup " & Chr(34) & Name_bdg_z.Text & Chr(34) & vbCrLf
        ad = ad & "{" & vbCrLf
        For i = 0 To (ac.GetLength(0) - 1) '防止出错
            If ac(i) <> Nothing Then            '防止出现空行
                Dim acc As String
                'acc = Chr(34) & ac(i) & Chr(34)
                'T_bdg_z.AppendText(ac(i) & vbCrLf)   '        Environment.NewLine)
                ad = ad & "  studio " & ac(i) & vbCrLf
            End If
        Next
        ad = ad & "  blank" & vbCrLf
        ad = ad & "}" & vbCrLf
        T_bdg_z.AppendText(ad)
    End Sub

    Private Sub B_jb_z2_Click(sender As Object, e As EventArgs) Handles B_jb_z2.Click
        T_length.Text = "5"
        T_tip_mass.Text = "5"
        T_pitch_stiffness.Text = "100"
        T_pitch_damping.Text = "4"
        T_yaw_stiffness.Text = "100"
        T_yaw_damping.Text = "4"
        T_along_stiffness.Text = "100"
        T_along_damping.Text = "0"
        T_angle_constraint.Text = "1"

        T_base_mass.Text = "60"
        T_stiffness.Text = "200"
        T_damping.Text = "5"
        T_left_constraint.Text = "0 0"
        T_left_friction.Text = "0"
        T_up_constraint.Text = "-1 1"
        T_up_friction.Text = "0"
        T_forward_constraint.Text = "-0.2 0.2"
        T_forward_friction.Text = "0"
    End Sub

    Private Sub B1_jb_z_Click(sender As Object, e As EventArgs) Handles B1_jb_z.Click
        C_jb.Checked = True

        Dim ae As String
        Dim af As String

        ae = Chr(34) & T_jbn_z.Text & Chr(34)

        af = "$JiggleBone " & ae & vbCrLf
        af = af & "{" & vbCrLf


        If C2_jb_z.Checked = True Then


            af = af & "	is_flexible" & vbCrLf
            af = af & "	{" & vbCrLf
            If T_length.Text <> Nothing Then
                af = af & "		length " & T_length.Text & vbCrLf
            End If
            If T_tip_mass.Text <> Nothing Then
                af = af & "		tip_mass " & T_tip_mass.Text & vbCrLf
            End If
            If T_pitch_stiffness.Text <> Nothing Then
                af = af & "		pitch_stiffness " & T_pitch_stiffness.Text & vbCrLf
            End If
            If T_pitch_damping.Text <> Nothing Then
                af = af & "		pitch_damping " & T_pitch_damping.Text & vbCrLf
            End If
            If T_yaw_stiffness.Text <> Nothing Then
                af = af & "		yaw_stiffness " & T_yaw_stiffness.Text & vbCrLf
            End If
            If T_yaw_damping.Text <> Nothing Then
                af = af & "		yaw_damping " & T_yaw_damping.Text & vbCrLf
            End If
            If T_along_stiffness.Text <> Nothing Then
                af = af & "		along_stiffness " & T_along_stiffness.Text & vbCrLf
            End If
            If T_along_damping.Text <> Nothing Then
                af = af & "		along_damping " & T_along_damping.Text & vbCrLf
            End If
            If T_angle_constraint.Text <> Nothing Then
                af = af & "		angle_constraint " & T_angle_constraint.Text & vbCrLf
            End If

            af = af & "	}" & vbCrLf
        End If


        If C1_jb_z.Checked = True Then


            af = af & "	has_base_spring" & vbCrLf
            af = af & "	{" & vbCrLf

            If T_base_mass.Text <> Nothing Then
                af = af & "		base_mass " & T_base_mass.Text & vbCrLf
            End If
            If T_stiffness.Text <> Nothing Then
                af = af & "		stiffness " & T_stiffness.Text & vbCrLf
            End If
            If T_damping.Text <> Nothing Then
                af = af & "		damping " & T_damping.Text & vbCrLf
            End If
            If T_left_constraint.Text <> Nothing Then
                af = af & "		left_constraint " & T_left_constraint.Text & vbCrLf
            End If
            If T_left_friction.Text <> Nothing Then
                af = af & "		left_friction " & T_left_friction.Text & vbCrLf
            End If
            If T_up_constraint.Text <> Nothing Then
                af = af & "		up_constraint " & T_up_constraint.Text & vbCrLf
            End If
            If T_up_friction.Text <> Nothing Then
                af = af & "		up_friction " & T_up_friction.Text & vbCrLf
            End If
            If T_forward_constraint.Text <> Nothing Then
                af = af & "		forward_constraint " & T_forward_constraint.Text & vbCrLf
            End If
            If T_forward_friction.Text <> Nothing Then
                af = af & "		forward_friction " & T_forward_friction.Text & vbCrLf
            End If

            af = af & "	}" & vbCrLf
        End If

        af = af & "}" & vbCrLf
        af = af & vbCrLf

        T_jb_z.Text = T_jb_z.Text & af

    End Sub

    Private Sub B3_jb_z_Click(sender As Object, e As EventArgs) Handles B3_jb_z.Click

        T_jb_z.Clear（）
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        T_Mem.Text = "90"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        C_med.Checked = True

        Dim ag As String
        ag = "$MaxEyeDeflection " & T_Mem.Text & vbCrLf

        T_mem_z.Text = ag
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        T_mem_z.Clear()
    End Sub


    Private Sub B1_cdm_z_Click(sender As Object, e As EventArgs) Handles B1_cdm_z.Click
        T2_cdm_z.Clear()
    End Sub



    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        T1_item_z.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        T1_item_z.Text = "username"
    End Sub

    Private Sub B2_ttg_z_Click(sender As Object, e As EventArgs) Handles B2_ttg_z.Click
        T2_ttg_z.Clear()
    End Sub

    Private Sub B1_ttg_z_Click(sender As Object, e As EventArgs) Handles B1_ttg_z.Click
        C_ttg.Checked = True

        Dim ab As String
        Dim ac As String()
        Dim acc As String()
        Dim ad As String

        ab = T1_ttg_z.Text   'ab 数组

        ad = "$texturegroup " & Chr(34) & "GroupName" & Chr(34) & vbCrLf
        ad = ad & "{" & vbCrLf

        ac = Split(ab, Chr(10)) 'fenka huiche 
        For i = 0 To (ac.GetLength(0) - 1)
            If ac(i) <> Nothing Then
                acc = Split(ac(i), ",")

                ad = ad & "  { "

                For t = 0 To (acc.GetLength(0) - 1)
                    ad = ad & Chr(34) & acc(t) & Chr(34) & " "
                Next
                ad = ad & "}" & vbCrLf
            End If

        Next

        ad = ad & "}" & vbCrLf

        T2_ttg_z.Clear()       't2操作
        T2_ttg_z.AppendText(ad)
    End Sub

    Private Sub T_smdpath_z_DragEnter(sender As Object, e As DragEventArgs) Handles T_smdpath_z.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Link
        End If
    End Sub

    Private Sub T_smdpath_z_DragDrop(sender As Object, e As DragEventArgs) Handles T_smdpath_z.DragDrop
        Dim files As String()
        Try
            files = CType(e.Data.GetData(DataFormats.FileDrop), String())
            Me.T_smdpath_z.Text = files(files.Length - 1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return
        End Try



    End Sub

    Private Sub B_smdpath_z_Click(sender As Object, e As EventArgs) Handles B_smdpath_z.Click
        OpenFileDialog1.ShowDialog()
        T_smdpath_z.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub B_outpath_z_Click(sender As Object, e As EventArgs) Handles B_outpath_z.Click
        FolderBrowserDialog1.ShowDialog()
        T_outpath_z.Text = FolderBrowserDialog1.SelectedPath
        T_outpath_z.Text = T_outpath_z.Text & "\"
    End Sub

    Private Sub T_cd_z_TextChanged(sender As Object, e As EventArgs) Handles T_cd_z.TextChanged
        T2_cd_z.Text = "$cd " & Chr(34) & T_cd_z.Text & Chr(34)
    End Sub

    Private Sub T_smdpath_z_TextChanged(sender As Object, e As EventArgs) Handles T_smdpath_z.TextChanged
        Dim smdpath As String
        smdpath = T_smdpath_z.Text
        T_outpath_z.Text = Microsoft.VisualBasic.Left(smdpath, InStrRev(smdpath, "\"))
        T_cd_z.Text = Microsoft.VisualBasic.Left(smdpath, InStrRev(smdpath, "\") - 1)
        Dim filenamenodrop As String
        filenamenodrop = Microsoft.VisualBasic.Right(smdpath, Len(smdpath) - InStrRev(smdpath, "\"))
        filenamenodrop = Microsoft.VisualBasic.Left(filenamenodrop, InStrRev(filenamenodrop, ".") - 1)
        Dim username As String  'username
        username = "qcmaker"
        Dim mdl As String
        mdl = username & "\" & filenamenodrop & "\" & filenamenodrop & ".mdl"
        mdl = Chr(34) & mdl & Chr(34)
        T_mdn_z.Text = mdl
        T_seqf.Text = Microsoft.VisualBasic.Right(smdpath, Len(smdpath) - InStrRev(smdpath, "\"))
        T_mdl_z.Text = Microsoft.VisualBasic.Right(smdpath, Len(smdpath) - InStrRev(smdpath, "\"))
        Dim cdm As String
        cdm = "models\" & "qcmaker" & "\" & filenamenodrop & "\"
        cdm = Chr(34) & cdm & Chr(34)
        T1_cdm_z.Text = cdm
    End Sub

    Private Sub B2_mdn_z_Click(sender As Object, e As EventArgs) Handles B2_mdn_z.Click
        Dim smdpath As String
        smdpath = T_smdpath_z.Text
        Dim filenamenodrop As String
        filenamenodrop = Microsoft.VisualBasic.Right(smdpath, Len(smdpath) - InStrRev(smdpath, "\"))
        filenamenodrop = Microsoft.VisualBasic.Left(filenamenodrop, InStrRev(filenamenodrop, ".") - 1)
        Dim username As String  'username
        username = "qcmaker"
        Dim mdl As String
        mdl = username & "\" & filenamenodrop & "\" & filenamenodrop & ".mdl"
        mdl = Chr(34) & mdl & Chr(34)
        T_mdn_z.Text = mdl
    End Sub

    Private Sub B4_mdn_z_Click(sender As Object, e As EventArgs) Handles B4_mdn_z.Click
        Dim smdpath As String
        smdpath = T_smdpath_z.Text
        Dim filenamenodrop As String
        filenamenodrop = Microsoft.VisualBasic.Right(smdpath, Len(smdpath) - InStrRev(smdpath, "\"))
        filenamenodrop = Microsoft.VisualBasic.Left(filenamenodrop, InStrRev(filenamenodrop, ".") - 1)
        Dim username As String  'username
        username = T1_item_z.Text
        Dim mdl As String
        mdl = username & "\" & filenamenodrop & "\" & filenamenodrop & ".mdl"
        mdl = Chr(34) & mdl & Chr(34)
        T_mdn_z.Text = mdl

    End Sub

    Private Sub B3_mdn_z_Click(sender As Object, e As EventArgs) Handles B3_mdn_z.Click
        T2_mdn_z.Text = "$modelname " & T_mdn_z.Text
    End Sub

    Private Sub B1_mdn_z_Click(sender As Object, e As EventArgs) Handles B1_mdn_z.Click
        T2_mdn_z.Clear()
    End Sub

    Private Sub B4_seq_z_Click(sender As Object, e As EventArgs) Handles B4_seq_z.Click
        T_seqp.Clear()
    End Sub

    Private Sub T_seqf_DragEnter(sender As Object, e As DragEventArgs) Handles T_seqf.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Link
        End If
    End Sub

    Private Sub T_seqf_DragDrop(sender As Object, e As DragEventArgs) Handles T_seqf.DragDrop
        Dim files As String()
        Try
            files = CType(e.Data.GetData(DataFormats.FileDrop), String())
            Me.T_seqf.Text = files(files.Length - 1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return
        End Try
        Dim filenamenodrop As String
        filenamenodrop = Microsoft.VisualBasic.Right(T_seqf.Text, Len(T_seqf.Text) - InStrRev(T_seqf.Text, "\"))
        T_seqf.Text = filenamenodrop
    End Sub

    Private Sub B1_seq_z_Click(sender As Object, e As EventArgs) Handles B1_seq_z.Click
        Dim smdpath As String
        smdpath = T_smdpath_z.Text
        Dim filenamenodrop As String
        filenamenodrop = Microsoft.VisualBasic.Right(smdpath, Len(smdpath) - InStrRev(smdpath, "\"))
        T_seqf.Text = filenamenodrop
    End Sub

    Private Sub B2_seq_z_Click(sender As Object, e As EventArgs) Handles B2_seq_z.Click
        T_activity1.Text = Chr(34) & "ACT_IDLE" & Chr(34)
        T_activity2.Text = "1"
        T_fadein.Text = "0.2"
        T_fadeout.Text = "0.2"
        T_fps.Text = "30"
        C1_seq_z.Checked = True

    End Sub

    Private Sub B3_seq_z_Click(sender As Object, e As EventArgs) Handles B3_seq_z.Click
        Dim ak As String
        ak = "$Sequence " & T_seqn.Text & " {" & vbCrLf
        ak = ak & " " & Chr(34) & T_seqf.Text & Chr(34) & vbCrLf
        ak = ak & " activity " & T_activity1.Text & " " & T_activity2.Text & vbCrLf
        ak = ak & " fadein " & T_fadein.Text & vbCrLf
        ak = ak & " fadeout " & T_fadeout.Text & vbCrLf
        ak = ak & " fps " & T_fps.Text & vbCrLf
        If C1_seq_z.Checked = True Then
            ak = ak & " loop" & vbCrLf
        End If
        ak = ak & "}" & vbCrLf

        'T_seqp.Text = ak
        T_seqp.AppendText(ak)
    End Sub

    Private Sub T_mdl_z_TextChanged(sender As Object, e As EventArgs) Handles T_mdl_z.TextChanged
        T2_mdl_z.Text = "$model " & Chr(34) & "body" & Chr(34) & " " & Chr(34) & T_mdl_z.Text & Chr(34) & vbCrLf
    End Sub

    Private Sub B2_cdm_z_Click(sender As Object, e As EventArgs) Handles B2_cdm_z.Click
        Dim smdpath As String
        smdpath = T_smdpath_z.Text
        Dim filenamenodrop As String
        filenamenodrop = Microsoft.VisualBasic.Right(smdpath, Len(smdpath) - InStrRev(smdpath, "\"))
        filenamenodrop = Microsoft.VisualBasic.Left(filenamenodrop, InStrRev(filenamenodrop, ".") - 1)
        Dim username As String  'username
        username = "qcmaker"
        Dim cdm As String
        cdm = "models\" & "qcmaker" & "\" & filenamenodrop & "\"
        cdm = Chr(34) & cdm & Chr(34)
        T1_cdm_z.Text = cdm
    End Sub

    Private Sub B3_cdm_z_Click(sender As Object, e As EventArgs) Handles B3_cdm_z.Click
        Dim smdpath As String
        smdpath = T_smdpath_z.Text
        Dim filenamenodrop As String
        filenamenodrop = Microsoft.VisualBasic.Right(smdpath, Len(smdpath) - InStrRev(smdpath, "\"))
        filenamenodrop = Microsoft.VisualBasic.Left(filenamenodrop, InStrRev(filenamenodrop, ".") - 1)
        Dim username As String  'username
        username = T1_item_z.Text
        Dim cdm As String
        cdm = "models\" & username & "\" & filenamenodrop & "\"
        cdm = Chr(34) & cdm & Chr(34)
        T1_cdm_z.Text = cdm
    End Sub

    Private Sub B4_cdm_z_Click(sender As Object, e As EventArgs) Handles B4_cdm_z.Click
        Dim aj As String
        aj = "$cdmaterials " & T1_cdm_z.Text & vbCrLf
        T2_cdm_z.AppendText(aj)
        'T2_cdm_z.Text = "$cdmaterials " & T1_cdm_z.Text
    End Sub

    Private Sub B_pre_z_Click(sender As Object, e As EventArgs) Handles B_pre_z.Click
        Dim cd As String
        Dim mdn As String
        Dim mdl As String
        Dim bdg As String
        Dim jb As String
        Dim mem As String
        Dim cdm As String
        Dim ttg As String
        Dim seq As String

        Dim creater As String

        cd = T2_cd_z.Text & vbCrLf & vbCrLf
        mdn = T2_mdn_z.Text & vbCrLf & vbCrLf
        mdl = T2_mdl_z.Text & vbCrLf & vbCrLf
        bdg = T_bdg_z.Text & vbCrLf
        jb = T_jb_z.Text & vbCrLf
        mem = T_mem_z.Text & vbCrLf
        cdm = T2_cdm_z.Text & vbCrLf
        ttg = T2_ttg_z.Text & vbCrLf
        seq = T_seqp.Text & vbCrLf

        creater = "// created by " & T1_item_z.Text & vbCrLf

        preview_z.Clear()
        preview_z.AppendText(creater)

        If C_cd.Checked = True Then
            preview_z.AppendText(cd)
        End If

        If C_mdln.Checked = True Then
            preview_z.AppendText(mdn)
        End If

        If C_cdl.Checked = True Then
            preview_z.AppendText(mdl)
        End If

        If C_bdg.Checked = True Then
            preview_z.AppendText(bdg)
        End If

        If C_jb.Checked = True Then
            preview_z.AppendText(jb)
        End If

        If C_med.Checked = True Then
            preview_z.AppendText(mem)
        End If

        preview_z.AppendText(L_items_z.Text)

        If C_cdm.Checked = True Then
            preview_z.AppendText(cdm)
        End If

        If C_ttg.Checked = True Then
            preview_z.AppendText(ttg)
        End If

        If C_seq.Checked = True Then
            preview_z.AppendText(seq)
        End If




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim smdpath As String
        Dim outpath As String
        Dim qcname As String
        Dim filenamenodrop As String
        smdpath = T_smdpath_z.Text
        outpath = T_outpath_z.Text
        filenamenodrop = Microsoft.VisualBasic.Right(smdpath, Len(smdpath) - InStrRev(smdpath, "\"))
        Try
            filenamenodrop = Microsoft.VisualBasic.Left(filenamenodrop, InStrRev(filenamenodrop, ".") - 1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return
        End Try

        qcname = filenamenodrop & ".qc"

        Dim qcpath As String   'qcpath
        qcpath = outpath & qcname



        Dim sw As StreamWriter     'write to file
        Dim sr As StreamReader
        Dim strRead() As String
        sw = New StreamWriter(qcpath, False, System.Text.Encoding.Default)

        Dim aa As String
        aa = preview_z.Text
        aa = Replace(aa, Chr(34), Chr(34))
        sw.WriteLine(aa)
        sw.Close()
        sw = Nothing
        MsgBox("写入成功，文件位于" & outpath)
    End Sub

    Private Sub matflodercreate_Click(sender As Object, e As EventArgs) Handles matflodercreate_b.Click
        matflodercreate.Show()
    End Sub

    Private Sub samefloders_b_Click(sender As Object, e As EventArgs) Handles samefloders_b.Click
        samefloders.Show()
    End Sub

    Private Sub vmtcreated_b_Click(sender As Object, e As EventArgs) Handles vmtcreated_b.Click
        vmtcreated.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        vmtcreaterH.Show()
    End Sub

    Private Sub en_1_Click(sender As Object, e As EventArgs) Handles en_1.Click
        Me.Tag = "en"



        TabPage1.Text = "Simple qc"
        TabPage2.Text = "Custom qc"
        TabPage3.Text = "Help"
        TabPage4.Text = "Log & support"
        TabPage_other.Text = "Other Mini Software"
        L_smdpath_s.Text = "smd/dmx Path"
        L_outpath_s.Text = "OutPut Path"
        L_preview_s.Text = "Preview"
        B_smdpath_s.Text = "Find"
        B_outpath_s.Text = "Find"
        B_preview_s.Text = "Save"
        L_smdpath_z.Text = "smd/dmx Path"
        L_outpath_z.Text = "OutPut Path"
        B_smdpath_z.Text = "Find"
        B_outpath_z.Text = "Find"
        G_Func_z.Text = "Custom Function"
        G_Func2_z.Text = "Necessary Function"
        B2_mdn_z.Text = "Use default"
        B4_mdn_z.Text = "Use Username path"
        B3_mdn_z.Text = "Build code"
        B1_mdn_z.Text = "Clear"
        L_mdl_z.Text = "Mdl name"
        L_bdg_z.Text = "Group name"
        L2_bdg_z.Text = "Tip:Drag multiple files to textbox"
        B_bdg_z.Text = "Build/Add"
        B3_jb_z.Text = "Clear Preview"
        B_jb_z2.Text = "use default"
        B1_jb_z.Text = "Build/Add"
        L2_jb_z.Text = "JB preview"
        L_jb_z.Text = "JB name"
        Label9.Text = "This part " & vbCrLf & "will be " & vbCrLf & "improved"
        Button2.Text = "use default"
        Button5.Text = "Build"
        Button6.Text = "Clear Preview"
        L1_item_z.Text = "Username"
        Button4.Text = "use default"
        Button7.Text = "Clear Preview"
        L1_cdm.Text = "Materials (materials\)："
        B2_cdm_z.Text = "use default"
        B3_cdm_z.Text = "use Username"
        B4_cdm_z.Text = "Build/Add"
        B1_cdm_z.Text = "Clear Preview"
        L1_ttg_z.Text = "Material correspondence: Max. 8*32"
        Label7.Text = "Each mat split by comma symbol" & vbCrLf & "Each group is split by ENTER"
        B1_ttg_z.Text = "Build"
        Label8.Text = "Preview"
        B2_ttg_z.Text = "Clear Preview"
        C_items.Text = "Username"
        TabPage11.Text = "Username"
        L1_item_z.Text = "Username"
        Button4.Text = "Build"
        Button7.Text = "Clear Preview"
        L1_seq_z.Text = "Sequence tabel"
        GroupBox2.Text = "content"
        L3_seq_z.Text = "File"
        L4_seq_z.Text = "Tip:Drag File to this textbox"
        B1_seq_z.Text = "use default"
        B2_seq_z.Text = "use default"
        B3_seq_z.Text = "Build/Add"
        L2_seq_z.Text = "Preview"
        B4_seq_z.Text = "Clear Preview"
        TabPage15.Text = "Final Preview"
        Label6.Text = "*** REload smd REbuild code"
        Label10.Text = "*** Verify required function HAS BEEN built"
        B_pre_z.Text = "Final Build"
        Button1.Text = "Save"

        Label5.Text = "How To Use ?"
        TextBox5.Text = "1. The SMD path bar can be automatically matched with the output path bar and qc name by dragging SMD to the text box" & vbCrLf & "2. You can manually modify the name of qc and author, and the author name will be used for the path" & vbCrLf & "3, click synchronization to generate a custom area function" & vbCrLf & "4, model and bodygroup can drag the file to automatically identify" & vbCrLf & "5, simple creation does not go to the function area, will automatically create a simple qc" & vbCrLf & "6. Custom create a function that will use the function area to tick"
        Label1.Text = "Thanks to"
        Label2.Text = "Log"
        Label4.Text = "auther NuaNunu"
        Label11.Text = "Bug Report:nuatury@gmail.com"
        Label12.Text = "Welcome to advice"
        TextBox1.Text = "2020.4.23 0.8a-- add the consolidation tool page, add the materials folder builder, and now you need to modify jigglebone's function and add documentation" & vbCrLf & "2020.3.2 0.71c-- fix the bodygroup newline function to fix the bodygroup quote error" & vbCrLf & "2020.3.2 0.71b-- fix shadow function and material function on the same line. Fix simple build CD function. Fix simple build body name" & vbCrLf & "2020.2.26 0.71 -- fixed the problem of no middle name of model function, deleted the redundant functions of simple qc, and added the associated tick items of buttons. Thanks for helping starcold to find bugs and give Suggestions" & vbCrLf & "2020.2.26 0.70.1-- fixed custom shadowless function bug" & vbCrLf & "2020.2.26 0.70-- replan the interface, separate the simple creation and custom creation window, custom creation contains all the functions for SFM, each function contains its own preview, add the material group array recognition, model group multiple drag automatic recognition, etc" & vbCrLf & "2020.2.24 0.63-- added CD function added log and help window modified model function modified function unmodifiable item background. Update function name" & vbCrLf & "2020.2.24 0.61-- switch from vb6 to vb.net kernel" & vbCrLf & "2020.2.23 0.50-- fixed function bug" & vbCrLf & "2020.2.22 0.40-- add icon to fix drag bug" & vbCrLf & "2020.2.15 0.30-- add drag and drop to fix interface bugs add open file browser" & vbCrLf & "0.20-- determine current plate distribution" & vbCrLf & "0.10-- includes simple generation"
        TextBox2.Text = "StarCold" & vbCrLf & "Loudomian" & vbCrLf & "Tristan" & vbCrLf & "bot[bird]" & vbCrLf & "Mon1K4"
        matflodercreate_b.Text = "mat floder creator"
        samefloders_b.Text = "Same path folderS generator"
        vmtcreated_b.Text = "multi VMTs generator"
        Button3.Text = "Enhance VMT generator"


    End Sub
End Class
