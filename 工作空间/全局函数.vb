Imports C1.Win.C1FlexGrid
Imports Foxtable

Public Module 全局函数
    Public Sub 设置系统表列表()
        Dim 连接 As Connection = Connections("ft")
        Dim 查询字符串 As String = "Select top 1000 * From {表名} Where 1 = 0 order by sys_id"
        For Each 表名 As String In 连接.GetTableNames
            If 表名 <> "sysdiagrams" AndAlso Not 全局变量.系统表列表.ContainsKey(表名) Then
                全局变量.系统表列表.Add(表名, New SQLCommand() With {.ConnectionName = "ft", .CommandText = 查询字符串.Replace("表名", 表名)}.ExecuteReader(True))
            End If
        Next
    End Sub

    Public Sub 添加表控件到页(窗体m As WinForm.Form, 页 As WinForm.TabPage)
        Dim 表控件 As WinForm.Table = 窗体m.CreateSQLTable(页.Name, "Select top 1000 * From {" & 页.Name.Split("_")(0) & "} where 1 = 0 order by sys_id", "ft")
        表控件.Dock = System.Windows.Forms.DockStyle.Fill
        页.AddControl(表控件)
        设置表控件(表控件)
        If 表控件.Focused = False Then
            表控件.Select()
        End If
    End Sub
    Public Sub 设置数据表(数据表 As DataTable)
        With 数据表
            For Each 数据列 As DataCol In .DataCols
                设置数据列(数据列)
            Next
            .AllowDragColumn = False
            .AllowInitialize = False
            .AllowResizeColumn = True
            .AllowResizeRow = False
            .AllowResizeSingleRow = False
            .DeleteRowPrompt = False
            .PreserveEditMode = True
            .BuildHeader()

        End With
    End Sub

    Public Sub 设置数据列(数据列 As DataCol)
        With 数据列
            If .Name.Split("_").Length > 1 Then
                .Caption = .Name.Split("_")(1)
            End If
            .AutoComplete = True
            If .IsDate Then
                .SetDateTimeFormat(DateTimeFormatEnum.DateLongTime)
            End If
            If .IsString Then

            End If
            If .IsBoolean Then

            End If
            If .IsNumeric Then

            End If
        End With
    End Sub

    Public Sub 设置grid(grid As C1.Win.C1FlexGrid.C1FlexGrid)
        With grid
            '.AllowAddNew = True '未知情况
            .AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.Rows
            .ShowCellLabels = True
            .AutoResize = True
            .AllowFiltering = True
            For Each col As Column In .Cols
                设置gridcol(col)
            Next
        End With
    End Sub

    Public Sub 设置gridcol(col As Column)
        With col
            '.AllowFiltering = True '冲突
            '.AllowResizing = True
            '.AllowExpressionEditing = True ,无程序集dll
        End With
    End Sub

    Public Sub 设置表(表 As Table)
        With 表
            .AutoSizeCols()
            .AutoSizeRows()
            '.AllowBackEndFilter = True '允许通过菜单筛选后台数据
            '.AllowBackgroundStatistics = True '直接统计后台数据
            .AllowDragColumn = False
            '.AllowMerge = False '切换合并模式
            '.AllowResizeRow = False
            '.AllowResizeSingleRow = False
            '.Sort = .Cols(0).Name
            '.Filter = ""
            For Each 列 As Col In .Cols
                设置列(列)
            Next
        End With
    End Sub

    Public Sub 设置列(列 As Col)
        With 列
            .AllowDirectType = True '是否允许用户直接输入不在列表项目中的内容
            .AllowTypeAssistant = True '是否启用输入助手
            ' .CodeDictionary = New Dictionary(Of String, String)
            '.ComboList = ""
            '.DataMap = Nothing
            '.DropForm = Nothing
            '.DropTree = Nothing
            '.ShortCaption = .Caption
            '.DropTree = Nothing
            '.ShowInRecordGrid = True
            If .Name.StartsWith("sys_") Then
                .Visible = False
                '.ShowInRecordGrid = False
            Else
                .Visible = True
            End If
            If .Width > 150 Then
                .Width = 150
            End If
            .UsetBuildInEditor = False '是否使用内置输入器
            .CloseWindow()
            '.RecordRowHeight = 1
            '.ResetAutoCompleteSource() '未知情况
        End With
    End Sub

    Public Sub 设置表控件(表控件 As WinForm.Table)
        设置数据表(表控件.Table.DataTable)
        设置grid(表控件.Table.Grid)
        设置表(表控件.Table)
        With 表控件

        End With
    End Sub
End Module

