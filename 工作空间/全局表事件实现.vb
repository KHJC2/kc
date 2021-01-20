Imports Foxtable

Friend Module 全局表事件实现
    Friend Sub CurrentChanged(e As TableEventArgs)
        Dim 当前行id As Integer '当前行id
        Dim 旧行id As Integer '旧行ID
        Dim 当前行 As Row = e.Table.Current '当前行
        If 当前行 IsNot Nothing Then
            当前行id = 当前行.DataRow("_Identify")
        Else
            当前行id = -1
        End If
        Dim 当前表名 As String = e.Table.Name
        If 旧当前行.ContainsKey(当前表名) = False Then
            旧当前行.Add(当前表名, Nothing)
        Else
        End If
        If 旧当前行(当前表名) IsNot Nothing Then
            If 旧当前行(当前表名).DataRow.RowState = 1 OrElse 旧当前行(当前表名).DataRow.RowState = 8 Then
                旧行id = -2
            Else
                旧行id = 旧当前行(当前表名).DataRow("_Identify")
            End If
        Else
            旧行id = -1
        End If
        Output.Show("<CurrentChanged_表-" & 当前表名 & ".行-" & 当前行id & ".旧行-" & 旧行id & ">")
        If 当前行id <> 旧行id Then
            If 当前表名 Like "m_*" AndAlso 当前表名.Remove(0, 2).Contains("_") = False Then '主表切换行
                主表切换行(e)
            Else
            End If
            旧当前行(当前表名) = 当前行 '设置旧当前行
        Else
        End If
        Output.Show("</CurrentChanged_表-" & 当前表名 & ".行-" & 当前行id & ".旧行-" & 旧行id & ">")
    End Sub

    Friend Sub BeforeDeleteDataRow()
        Throw New NotImplementedException()
    End Sub

    Friend Sub DataRowAdding(e As Foxtable.DataRowEventArgs)
        Output.Show("<DataRowAdding_表-" & e.DataTable.Name & ">")
        If e.DataTable.Name.StartsWith("m_") Then
            If e.DataTable.Name.Split("_").Length = 2 Then
                主表新增行(e)
            ElseIf e.DataTable.Name.Split("_").Length = 4 Then
                子表新增行(e)
            End If
            新增行(e)
        End If
        Output.Show("</DataRowAdding_表-" & e.DataTable.Name & ">")
    End Sub

    Private Sub 新增行(e As DataRowEventArgs)
        Output.Show("<新增行>")
        Dim guid As Guid = Guid.NewGuid
        Dim 时间 As Date = 全局变量.实际时间
        Dim 表名 As String = e.DataTable.Name.Split("_")(1)
        'If e.DataTable.DataCols.Contains("sys_id") Then
        Dim 编号列名 As String = 表名 & "_编号"

        e.DataRow("sys_id") = guid
        'End If
        'If e.DataTable.DataCols.Contains(e.DataTable.Name.Remove(0, 2) & "_编号") Then
        e.DataRow(编号列名) = PY.GetPY(表名, True, 3) & 时间.ToString("yyyyyMMddHHmmssfffffff") & guid.ToString.Replace("-", "")
        'End If
        e.DataRow("sys_addtime") = 时间
        Output.Show("</新增行>")
    End Sub

    Friend Sub AfterLoad(e As LoadEventArgs)
        For Each table As Table In Tables
            If table.DataTable Is e.DataTable Then
                For Each col As Col In table.Cols
                    If col.Name.Split("_").Length = 3 Then
                        col.DropForm = "dfm"
                        'Dim dmp As New TableDataMap
                        'dmp.DataTable = "客户" '指定数据来源表
                        'dmp.ValueCol = "ID" '指定取值列
                        'dmp.DisplayCol = "公司" '指定显示列
                        ''指定下拉列表时显示哪些列的数据
                        'dmp.ListCols = "ID,公司,姓氏,名字,职务,业务电话,传真号,地址,城市,邮政编码"
                        'dmp.Sort = "城市" '指定排序方式
                        'Tables("订单").Cols("客户 ID").DataMap = dmp.CreateDataMap() '生成并设置DataMap

                        '.DataMap = 
                    End If
                Next

            End If
        Next

    End Sub

    Private Sub 子表新增行(e As DataRowEventArgs)
        Output.Show("<主表新增行>")
        Dim cdt主 As WinForm.TabControl = Forms("m").Controls("cdt主")
        Dim 页 As WinForm.TabPage = cdt主.SelectedPage
        Dim 主表 As Table = Nothing
        If 页 IsNot Nothing Then
            If 页.Name = e.DataTable.Name.Split("_")(3) Then
                主表 = Tables("m_" & 页.Name)
            Else
            End If
        Else
        End If
        Dim 主表当前行 As Row = Nothing
        If 主表 IsNot Nothing Then
            主表当前行 = 主表.Current
        End If
        If 主表当前行 IsNot Nothing Then
            e.DataRow(e.DataTable.Name.Remove(0, 2)) = 主表当前行(主表.Name.Split("_")(1) & "_编号")
        Else
            e.Cancel = True
        End If

        Output.Show("</主表新增行>")
    End Sub

    Private Sub 主表新增行(e As DataRowEventArgs)
        Output.Show("<子表新增行>")
        Output.Show("</子表新增行>")
    End Sub

    Private Sub 主表切换行(e As TableEventArgs)
        Output.Show("<主表切换行>")
        Dim 主表 As Table = e.Table
        Dim 主表当前行 As Row = 主表.Current '当前行
        Dim 主表旧当前行 As Row = 旧当前行(主表.Name)
        Dim 子页 As Object = Forms("m").Controls("cdt下").SelectedPage
        Dim 子表 As Table
        If 子页 IsNot Nothing Then
            Dim 子表名 As String = CStr("m_" & 子页.Name)
            子表 = Tables(子表名)
            If 子表.DataTable.HasChanges Then
                'If 主表旧当前行(主表.Name.Remove(0, 2) & "_编号") = 子表.DataTable.DataRows(0)(子表.Name.Remove(0, 2)) Then

                If 有更改的主表行.ContainsKey(主表.Name) Then
                    If 有更改的主表行(主表.Name).StartsWith(子表.DataTable.DataRows(0)(子表.Name.Remove(0, 2)) & "|") = False Then
                        有更改的主表行(主表.Name) = 子表.DataTable.DataRows(0)(子表.Name.Remove(0, 2)) & "|" & Date.Now.ToString("yyyyy-MM-dd HH:mm:ss.fffffff")
                    End If
                Else
                    有更改的主表行.Add(主表.Name, 子表.DataTable.DataRows(0)(子表.Name.Remove(0, 2)) & "|" & Date.Now.ToString("yyyyy-MM-dd HH:mm:ss.fffffff"))
                End If

                'Dim 位置 As Integer = 主表.Find(子表.DataTable.DataRows(0)(子表.Name.Remove(0, 2)), 0, 主表.Name.Remove(0, 2) & "_编号", True, True, True)
                'If 位置 <> -1 Then
                '    If 主表.Position <> 位置 Then
                '        主表.Position = 位置
                '    End If
                'End If
                'PopMessage("当前行子表数据未保存", "请保存修改", PopiconEnum.Infomation, 2)
                GoTo lafy
                'End If
            End If

            Dim 条件字符串 As String
            If 主表当前行 IsNot Nothing Then
                条件字符串 = 子表名.Remove(0, 2) & " = '" & 主表当前行(主表.Cols(0).Name) & "'"
            Else
                条件字符串 = "1 = 0"
            End If
            If 子表.DataTable.LoadFilter <> 条件字符串 Then
                子表.DataTable.LoadFilter = 条件字符串
                子表.DataTable.Load(False)
            Else
            End If
lafy:
        End If

        Output.Show("</主表切换行>")
    End Sub
End Module
