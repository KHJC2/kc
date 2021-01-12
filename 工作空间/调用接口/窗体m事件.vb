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
        Output.Show("</AfterLoad_form-" & e.Form.Name & ">")
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
        Dim cdt主 As WinForm.TabControl = e.Form.Controls("cdt主")
        For Each 后台表名 As String In Connections("ft").GetTableNames '将设计好的控件,移动到相应的位置
            If 后台表名 <> "sysdiagrams" AndAlso Not cdt主.TabPages.Contains(后台表名) Then
                cdt主.TabPages.Add(后台表名, 后台表名)
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
                        Output.Show("关联列:" & 列.Name & "命名错误" & vbCrLf & "或者主表未完成加载")
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

