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
        Dim 表名 As String = e.Table.Name
        If 旧当前行.ContainsKey(表名) = False Then
            旧当前行.Add(表名, Nothing)
        Else
        End If
        If 旧当前行(表名) IsNot Nothing Then
            If 旧当前行(表名).DataRow.RowState = 1 OrElse 旧当前行(表名).DataRow.RowState = 8 Then
                旧行id = -2
            Else
                旧行id = 旧当前行(表名).DataRow("_Identify")
            End If
        Else
            旧行id = -1
        End If
        Output.Show("<CurrentChanged_表-" & 表名 & ".行-" & 当前行id & ".旧行-" & 旧行id & ">")
        If 当前行id <> 旧行id Then
            旧当前行(表名) = 当前行 '设置旧当前行
            If 表名 Like "m_*" AndAlso 表名.Remove(0, 2).Contains("_") = False Then '主表切换行
                主表切换行(e)
            Else
            End If
        Else
        End If
        Output.Show("</CurrentChanged_表-" & 表名 & ".行-" & 当前行id & ".旧行-" & 旧行id & ">")
    End Sub

    Friend Sub DataRowAdding(e As Foxtable.DataRowEventArgs)
        Output.Show("<DataRowAdding_表-" & e.DataTable.Name & ">")
        If e.DataTable.Name.StartsWith("m_") Then
            新增行(e)
            If e.DataTable.Name.Split("_").Length = 2 Then
                主表新增行(e)
            Else
                子表新增行(e)
            End If
        End If
        Output.Show("</DataRowAdding_表-" & e.DataTable.Name & ">")
    End Sub

    Private Sub 新增行(e As DataRowEventArgs)
        Output.Show("<新增行>")

        Output.Show("</新增行>")
    End Sub

    Private Sub 子表新增行(e As DataRowEventArgs)
        Output.Show("<主表新增行>")

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
        Dim 子表名 As String = CStr("m_" & Forms("m").Controls("cdt下").SelectedPage.Name)
        Dim 子表 As Table = Tables(子表名)
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
        Output.Show("</主表切换行>")

    End Sub
End Module
