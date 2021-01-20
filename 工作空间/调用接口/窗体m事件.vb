Imports Foxtable

Public Module 窗体m事件
    Public Sub AfterClose(e As Foxtable.FormEventArgs)
        Output.Show("<AfterClose_form-" & e.Form.Name & ">")
        卸载控件(e)
        全局变量.网络本地时间记录 = Nothing
        全局变量.时间监控最后执行时间 = Nothing
        Output.Show("</AfterClose_form-" & e.Form.Name & ">")
    End Sub
    Public Sub AfterLoad(e As Foxtable.FormEventArgs)
        Output.Show("<AfterLoad_form-" & e.Form.Name & ">")
        Dim 网络时间 As Date = 全局变量.网络本地时间记录.Keys(0)
        全局函数.设置系统表列表()
        '设置所有表()
        加载控件(e)
        添加cdt主页(e)
        '打印已废弃的表设计()
        设置子表名列表()
        子表名列表排序()
        添加记录窗口(e)
        添加工作目录树节点(e)
        加载系统设置()

        Output.Show("</AfterLoad_form-" & e.Form.Name & ">")
    End Sub

    Private Sub 加载系统设置()
        Dim sqcmd As New SQLCommand With {.ConnectionName = "ft", .CommandText = "select * from 系统表"}
        Dim 系统表表 As DataTable = sqcmd.ExecuteReader(True)
        For Each 表名 As String In 系统表列表.Keys
            Dim 系统表行 As DataRow = 系统表表.Find("系统表_名称 = '" & 表名 & "'", "", 0)
            If 系统表行 Is Nothing Then
                系统表行 = 系统表表.AddNew()
                系统表行("系统表_名称") = 表名
                Dim guid As Guid = Guid.NewGuid
                Dim 时间 As Date = 全局变量.实际时间
                Dim 编号列名 As String = "系统表_编号"
                系统表行("sys_id") = guid
                系统表行(编号列名) = PY.GetPY("系统表", True, 3) & 时间.ToString("yyyyyMMddHHmmssfffffff") & guid.ToString.Replace("-", "")
                系统表行("sys_addtime") = 时间
            End If
            Dim sc As New SQLCommand With {.ConnectionName = "ft", .CommandText = "select * from 系统列 where 系统列_系统表_系统表 = '" & 系统表行("系统表_编号") & "'"}
            Dim 系统列表 As DataTable = sc.ExecuteReader(True)
            For Each 表列 As DataCol In 系统表列表(表名).DataCols
                Dim 系统列行 As DataRow = 系统列表.Find("系统列_列名 = '" & 表列.Name & "'", "", 0)
                If 系统列行 Is Nothing Then
                    系统列行 = 系统列表.AddNew()
                    系统列行("系统列_列名") = 表列.Name
                    Dim guid As Guid = Guid.NewGuid
                    Dim 时间 As Date = 全局变量.实际时间
                    Dim 编号列名 As String = "系统列_编号"
                    系统列行("sys_id") = guid
                    系统列行(编号列名) = PY.GetPY("系统列", True, 3) & 时间.ToString("yyyyyMMddHHmmssfffffff") & guid.ToString.Replace("-", "")

                    系统列行("sys_addtime") = 时间
                    系统列行("系统列_系统表_系统表") = 系统表行("系统表_编号")
                End If
            Next
            For Each 系统列行 As DataRow In 系统列表.DataRows
                If 系统表列表(表名).DataCols.Contains(系统列行("系统列_列名")) = False Then
                    'If 系统表列表.ContainsKey(系统列列("系统列_列名")) = False Then
                    系统列行("sys_deleted") = True
                Else
                    系统列行("sys_deleted") = False
                End If
            Next
            系统列表.Save()
        Next
        For Each 系统表行 As DataRow In 系统表表.DataRows
            If 系统表列表.ContainsKey(系统表行("系统表_名称")) = False Then
                系统表行("sys_deleted") = True
            Else
                系统表行("sys_deleted") = False
            End If
        Next
        系统表表.Save()
    End Sub

    Private Sub 添加工作目录树节点(e As FormEventArgs)
        Dim 工作目录树 As Foxtable.WinForm.TreeView = e.Form.Controls("工作表目录树")
        For Each 主表名 As String In 子表名列表.Keys
            Dim 主节点 As Foxtable.WinForm.TreeNode = 工作目录树.Nodes.Add(主表名, 主表名.Remove(0, 2))
            For Each 子表名 As String In 子表名列表(主表名)
                主节点.Nodes.Add(子表名, 子表名.Remove(0, 2))
            Next
        Next
        For Each 表名 As String In 系统表列表.Keys
            If Not 子表名列表.Keys.Contains("m_" & 表名) Then
                Dim 节点 As Foxtable.WinForm.TreeNode = 工作目录树.Nodes.Add("m_" & 表名, 表名)
                节点.ImageFile = "Chart.ico"
                节点.NodeSelectedImageFile = "options.png"
                节点.SelectedIconFile = "options.png"
            End If
        Next
    End Sub

    Private Sub 添加记录窗口(e As FormEventArgs)
        Dim cdt右 As WinForm.TabControl = e.Form.Controls("cdt右")
        Dim 页 As WinForm.TabPage = cdt右.TabPages.Add("记录窗口", "记录窗口")
        Dim 记录窗口 As WinForm.RecordGrid = e.Form.CreateControl("记录窗口", ControlTypeEnum.RecordGrid)
        记录窗口.Dock = Windows.Forms.DockStyle.Fill
        记录窗口.Table = CurrentTable
        记录窗口.Build()
        记录窗口.Visible = False
        页.AddControl(记录窗口)
    End Sub

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub 加载控件(e As FormEventArgs)
        Output.Show("<加载控件>")
        全局变量.布局控件 = New 工作空间.uc1()
        全局变量.布局控件.Dock = System.Windows.Forms.DockStyle.Fill
        全局变量.布局控件.Location = New System.Drawing.Point(0, 0)
        全局变量.布局控件.Name = "Uc1"
        全局变量.布局控件.Size = New System.Drawing.Size(800, 450)
        全局变量.布局控件.TabIndex = 0
        全局变量.布局控件.cdm.ParentContainer = e.Form.Panel
        e.Form.Panel.Controls.Add(全局变量.布局控件)
        Output.Show("</加载控件>")
    End Sub
    Private Sub 添加cdt主页(e As FormEventArgs)
        Output.Show("<添加cdt主页>")
        Dim cdt替 As WinForm.TabControl = e.Form.Controls("cdt替")
        For Each 后台表名 As String In Connections("ft").GetTableNames
            If 后台表名 <> "sysdiagrams" AndAlso Not cdt替.TabPages.Contains(后台表名) Then
                cdt替.TabPages.Add(后台表名, 后台表名)
            End If
        Next
        Output.Show("</添加cdt主页>")
    End Sub
    Private Sub 设置子表名列表()
        Output.Show("<设置子表名列表>")
        For Each 表 As DataTable In 系统表列表.Values '将 关联列 添加到 主表关联列字典
            For Each 列 As DataCol In 表.DataCols
                Dim 列字符组() As String = 列.Name.Split("_")
                If 列字符组.Length = 3 Then
                    Dim 主表名 As String = "m_" & 列字符组(2)
                    If 系统表列表.ContainsKey(列字符组(2)) Then
                        If 子表名列表.ContainsKey(主表名) = False Then
                            子表名列表.Add(主表名, New List(Of String))
                        End If
                        Dim 列表 As List(Of String) = 子表名列表(主表名)
                        Dim 子表名 As String = "m_" & 列.Name

                        If 列表.Contains(子表名) = False Then
                            列表.Add(子表名)
                        End If
                    Else
                        PopMessage("关联列:" & 列.Name & "命名错误" & vbCrLf & "或者主表未完成加载", "提示", PopiconEnum.Infomation, 3)
                    End If
                End If
            Next
        Next
        Output.Show("</设置子表名列表>")
    End Sub
    Private Sub 子表名列表排序()
        Output.Show("<子表名列表排序>")
        For Each 主表名 As String In 子表名列表.Keys '子表名列表排序
            子表名列表(主表名).Sort()
            If 旧当前子表名.ContainsKey(主表名) = False Then '设置旧当前子表名
                Output.Show("<设置旧当前子表名>")
                旧当前子表名.Add(主表名, 子表名列表(主表名)(0))
                Output.Show("</设置旧当前子表名>")
            End If
        Next
        Output.Show("</子表名列表排序>")
    End Sub
    Private Sub 卸载控件(e As FormEventArgs)
        Output.Show("<卸载控件>")
        If e.Form.Name = "m" Then
            全局变量.布局控件.Dispose()
            全局变量.布局控件 = Nothing
            For Each 主表名 As String In 子表名列表.Keys
                If DataTables.Contains(主表名) Then
                    DataTables.Unload(主表名)
                End If
                For Each 子表名 As String In 子表名列表(主表名)
                    If DataTables.Contains(子表名) Then
                        DataTables.Unload(子表名)
                    End If
                Next
            Next
        End If
        Output.Show("</卸载控件>")
    End Sub
End Module

Public Module 窗体dfm事件
    Public Sub sssd(e As Object)
        Dim txt As String = e.Form.DropDownBox.Text
        Dim tbl As Table = Tables("dfm_dt")
        Dim filter As String
        If txt = "" Then
            filter = ""
        Else
            txt = "'" & txt & "%'"
            For Each cl As Col In tbl.Cols
                If cl.IsString Then
                    If cl.Name.Split("_").Length = 2 Then
                        filter += cl.Name & " like " & txt & " "
                    Else

                    End If
                End If
            Next
        End If
        e.Form.DropDownBox.Select()
    End Sub

End Module


