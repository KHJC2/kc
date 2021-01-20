Imports Foxtable

Friend Module 项目事件实现
    Friend Sub CurrentTableChanged()
        Dim 当前表名 As String = CurrentTable.Name
        Dim 旧当前 As String = 旧当前表名
        Output.Show("<CurrentTableChanged_当前表-" & 当前表名 & ".旧表-" & 旧当前 & ">")
        Dim 窗体m As WinForm.Form = Forms("m")
        If 当前表名 <> 旧当前表名 Then
            旧当前表名 = 当前表名
            If 窗体m.Opened Then
                Dim 树 As Foxtable.WinForm.TreeView = Forms("m").Controls("工作表目录树")
                If 当前表名 Like "m_*" AndAlso 当前表名.Remove(0, 2).Contains("_") = False Then '切换主表 加载显示子表
                    If 当前表名 <> 旧当前主表名 Then
                        旧当前主表名 = 当前表名
                        切换主表(当前表名, 窗体m)
                    End If
                    树.SelectedNode = 树.Nodes(当前表名)
                End If
                If 当前表名 Like "m_*" AndAlso 当前表名.Split("_").Length = 4 Then '切换子表
                    Dim 主表名 As String = "m_" & 当前表名.Split("_")(3)
                    If 当前表名 <> 旧当前子表名(主表名) Then
                        旧当前子表名(主表名) = 当前表名
                        切换子表(当前表名, 窗体m)
                    End If
                    树.SelectedNode = 树.Nodes(主表名).Nodes(当前表名)
                End If
            End If
            切换表(当前表名, 旧当前)
        Else
        End If
        Output.Show("</CurrentTableChanged_当前表-" & 当前表名 & ".旧表-" & 旧当前 & ">")
    End Sub

    Private Sub 切换表(当前表名 As String, 旧当前表 As String)
        刷新记录窗口()
    End Sub

    Private Sub 刷新记录窗口()
        If Forms("m").Opened Then
            Dim 记录窗口 As WinForm.RecordGrid = Forms("m").Controls("记录窗口")
            If 记录窗口 IsNot Nothing Then
                If CurrentTable.Focused AndAlso CurrentTable IsNot Nothing Then
                    记录窗口.Table = CurrentTable
                Else
                    记录窗口.Table = Nothing
                End If
                记录窗口.Table = CurrentTable
                记录窗口.Build()
                If 记录窗口.Table Is Nothing Then
                    记录窗口.Visible = False
                Else
                    记录窗口.Visible = True
                End If
            End If
        End If
    End Sub

    Friend Sub BeforeOpenProject(e As BeforeOpenProjectEventArgs)
        Output.Show("<BeforeOpenProject>")
        '普通任务:登录系统 用户,人员 
        登录用户编号 = ""

        登录人员编号 = ""
        登录人员法律主体编号 = ""

        登录客户端编号 = ""

        当前法律主体编号 = ""
        当前企业编号 = ""

        当前群体编号 = ""
        当前交易主体编号 = ""

        当前群体成员编号 = "" '登录人员的群体角色

        Output.Show("</BeforeOpenProject>")
    End Sub

    Private Sub 切换子表(当前表名 As String, 窗体m As WinForm.Form)
        Output.Show("<切换子表>")
        '旧当前子表名(当前表名.Split("_")(3)) = 当前表名.Remove(0, 2) ''记录主表当前子表
        Dim cdt主 As WinForm.TabControl = 窗体m.Controls("cdt主")
        Dim 主表 As Table = Tables("m_" & cdt主.SelectedPage.Name)
        Dim 加载条件 As String
        Dim 子表名 As String = 当前表名

        If 主表.Current IsNot Nothing Then
            加载条件 = 子表名.Remove(startIndex:=0, count:=2) & " = '" & 主表.Current(ColumnName:=主表.Cols(Index:=0).Name) & "'"
        Else
            加载条件 = "1 = 0"
        End If
        If DataTables(子表名).LoadFilter <> 加载条件 Then
            DataTables(子表名).LoadFilter = 加载条件
            DataTables(子表名).Load(SaveData:=False)
        Else
        End If
        Output.Show("</切换子表>")

    End Sub

    Private Sub 切换主表(当前表名 As String, 窗体m As WinForm.Form)
        Output.Show("<切换主表>")
        窗体m.StopRedraw()
        Dim cdt下 As WinForm.TabControl = 窗体m.Controls("cdt下")
        Dim 主表名 As String = 当前表名
        If 子表名列表.ContainsKey(主表名) Then
            For Each 子表名 As String In 子表名列表(主表名)
                Dim 列名 As String = 子表名.Remove(0, 2)
                If cdt下.TabPages.Contains(列名) Then
                    cdt下.TabPages(列名).Visible = True
                Else
                    cdt下.TabPages.Add(列名, 列名)
                End If
            Next
            cdt下.Visible = True
            cdt下.SelectedPage = cdt下.TabPages(旧当前子表名(主表名).Remove(0, 2))
            For Each 页 As WinForm.TabPage In cdt下.TabPages
                If 子表名列表(主表名).Contains("m_" & 页.Name) = False Then
                    页.Visible = False
                End If
            Next
        Else
            cdt下.Visible = False
        End If
        窗体m.ResumeRedraw()
        Output.Show("</切换主表>")
    End Sub


End Module
