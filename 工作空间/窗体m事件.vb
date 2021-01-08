Imports Foxtable

Public Module 窗体m事件
    Public Sub AfterClose(e As Foxtable.FormEventArgs)
        Output.Show("<AfterClose_form-" & e.Form.Name & ">")
        卸载控件(e)
        Output.Show("</AfterClose_form-" & e.Form.Name & ">")
    End Sub
    Public Sub AfterLoad(e As Foxtable.FormEventArgs)
        Output.Show("<AfterLoad_form-" & e.Form.Name & ">")
        允许列头筛选()
        加载控件(e)
        布局控件(e)
        打印已废弃的表设计()
        设置子表名列表()
        子表名列表排序()
        Output.Show("</AfterLoad_form-" & e.Form.Name & ">")
    End Sub
    Private Sub 允许列头筛选()
        Output.Show("<允许列头筛选>")
        For Each tb As Table In Tables
            Dim grid As C1.Win.C1FlexGrid.C1FlexGrid = tb.Grid
            grid.AllowFiltering = True
            grid.AutoResize = True

        Next
        Output.Show("</允许列头筛选>")
    End Sub

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub 加载控件(e As FormEventArgs)
        Output.Show("<加载控件>")
        Uc11 = New 工作空间.uc1()
        Uc11.Dock = System.Windows.Forms.DockStyle.Fill
        Uc11.Location = New System.Drawing.Point(0, 0)
        Uc11.Name = "Uc1"
        Uc11.Size = New System.Drawing.Size(800, 450)
        Uc11.TabIndex = 0
        Uc11.cdm.ParentContainer = e.Form.Panel
        e.Form.Panel.Controls.Add(Uc11)
        Output.Show("</加载控件>")
    End Sub
    Private Sub 布局控件(e As FormEventArgs)
        Output.Show("<布局控件>")
        For Each 后台表名 As String In Connections("ft").GetTableNames '将设计好的控件,移动到相应的位置
            If e.Form.Controls.Contains(后台表名) Then
                Dim 表控件 As WinForm.Control = e.Form.Controls(后台表名)
                If 表控件.GetType.FullName = "Foxtable.WinForm.Table" Then
                    Dim cdt主 As WinForm.TabControl = e.Form.Controls("cdt主")
                    Dim 页 As WinForm.TabPage = cdt主.TabPages(表控件.Name)
                    If 页 Is Nothing Then
                        'Dim tcp As WinForm.TabPage = tc.tabpages.add(ct.name,ct.name)
                        页 = cdt主.TabPages.Add(表控件.Name, 表控件.Name)
                    End If
                    页.AddControl(表控件)
                End If
            Else
                Output.Show("表:" & 后台表名 & "未设计")
            End If
        Next
        Output.Show("</布局控件>")
    End Sub
    Private Sub 打印已废弃的表设计()
        Output.Show("<打印已废弃的表设计>")
        For Each 控件 As WinForm.Control In Forms("m").Controls
            If 控件.GetType.FullName = "Foxtable.WinForm.Table" AndAlso 控件.Name.Contains("_") = False Then
                If Connections("ft").GetTableNames.Contains(控件.Name) = False Then
                    Output.Show("表:" & 控件.Name & "已废弃")
                End If
            End If
        Next
        Output.Show("</打印已废弃的表设计>")
    End Sub
    Private Sub 设置子表名列表()
        Output.Show("<设置子表名列表>")
        For Each 表 As DataTable In DataTables '将 关联列 添加到 主表关联列字典
            If 表.Name Like "m_*" AndAlso 表.Name.Remove(0, 2).Contains("_") = False Then
                For Each 列 As DataCol In 表.DataCols
                    Dim 列字符组() As String = 列.Name.Split("_")
                    If 列字符组.Length = 3 Then
                        Dim 主表名 As String = "m_" & 列字符组(2)

                        If DataTables.Contains(主表名) Then
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
            End If
        Next
        Output.Show("</设置子表名列表>")
    End Sub
    Private Sub 子表名列表排序()
        Output.Show("<子表名列表排序>")
        For Each 主表名 As String In 子表名列表.Keys '子表名列表排序
            子表名列表(主表名).Sort()
            If 旧当前子表名.ContainsKey(主表名) = False Then '设置旧当前子表
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
            Uc11.Dispose()
        End If
        Output.Show("</卸载控件>")
    End Sub
End Module

