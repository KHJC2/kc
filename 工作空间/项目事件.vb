Imports Foxtable

Public Module 项目事件
    Public Sub CurrentTableChanged()
        Dim 当前表名 As String = CurrentTable.Name
        Output.Show(Date.Now & "CurrentTableChanged开始,当前表:" & 当前表名 & ",旧表:" & 旧当前表名)
        Dim 窗体m As WinForm.Form = Forms("m")
        If 当前表名 <> 旧当前表名 Then
            旧当前表名 = 当前表名
            If 窗体m.Opened Then

                If 当前表名 Like "m_*" AndAlso 当前表名.Remove(0, 2).Contains("_") = False Then '切换主表 加载显示子表
                    Output.Show("切换主表")
                    If 当前表名 <> 旧当前主表名 Then
                        Output.Show("真")
                        旧当前主表名 = 当前表名
                        切换主表(当前表名, 窗体m)
                    End If

                End If

                If 当前表名 Like "m_*" AndAlso 当前表名.Split("_").Length = 4 Then '切换子表
                    Output.Show("切换子表")
                    If 当前表名 <> 旧当前子表名(当前表名.Split("_")(3)) Then
                        Output.Show("真")
                        旧当前子表名(当前表名.Split("_")(3)) = 当前表名
                        切换子表(当前表名, 窗体m)
                    End If
                End If
            End If
        Else
        End If
        Output.Show(Date.Now & "CurrentTableChanged结束,当前表:" & 当前表名)
    End Sub

    Private Sub 切换子表(当前表名 As String, 窗体m As WinForm.Form)
        '旧当前子表名(当前表名.Split("_")(3)) = 当前表名.Remove(0, 2) ''记录主表当前子表
        Dim cdt主 As WinForm.TabControl = 窗体m.Controls("cdt主")
        Dim 主表 As Table = Tables("m_" & cdt主.SelectedPage.Name)
        Dim 加载条件 As String
        If 主表.Current IsNot Nothing Then
            加载条件 = 当前表名.Remove(0, 2) & " = '" & 主表.Current(主表.Cols(0).Name) & "'"
        Else
            加载条件 = "1 = 0"
        End If
        If DataTables(当前表名).LoadFilter <> 加载条件 Then
            DataTables(当前表名).LoadFilter = 加载条件
            DataTables(当前表名).Load(False)
        Else
        End If
    End Sub

    Private Sub 切换主表(当前表名 As String, 窗体m As WinForm.Form)
        窗体m.StopRedraw()
        Dim cdt下 As WinForm.TabControl = 窗体m.Controls("cdt下")
        Dim 表名 As String = 当前表名.Remove(0, 2)

        If 子表名列表.ContainsKey(表名) Then
            For Each 列名 As String In 子表名列表(表名)
                If cdt下.TabPages.Contains(列名) Then
                    cdt下.TabPages(列名).Visible = True
                Else
                    Dim 页 As WinForm.TabPage = cdt下.TabPages.Add(列名, 列名)
                    Dim 表控件 As WinForm.Table
                    表控件 = 窗体m.CreateSQLTable(列名, "Select top 200 * From {" & 列名.Split("_")(0) & "} where 1=0 order by sys_id", "ft")
                    表控件.Dock = System.Windows.Forms.DockStyle.Fill
                    页.AddControl(表控件)
                    页.Visible = True
                End If
            Next
            cdt下.Visible = True
            cdt下.SelectedPage = cdt下.TabPages(旧当前子表名(表名))
            For Each 页 As WinForm.TabPage In cdt下.TabPages
                If 子表名列表(表名).Contains(页.Name) = False Then
                    页.Visible = False
                End If
            Next
            'Forms("m").Controls(ctn.Remove(0,2)).Select
        Else
            cdt下.Visible = False
        End If
        窗体m.ResumeRedraw()
    End Sub
End Module

