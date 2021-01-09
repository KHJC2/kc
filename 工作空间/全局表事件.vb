Imports Foxtable

Public Module 全局表事件
    Public Sub PrepareEdit()

    End Sub
    Public Sub StartEdit()

    End Sub

    Public Sub ValidateEdit()

    End Sub

    Public Sub AfterEdit()

    End Sub

    Public Sub CellButtonClick()

    End Sub

    Public Sub ChangeEdit()

    End Sub

    Public Sub KeyPressEdit()

    End Sub

    Public Sub KeyDownEdit()

    End Sub

    Public Sub KeyUpEdit()

    End Sub

    Public Sub DataColChanging()

    End Sub

    Public Sub DataColChanged()

    End Sub

    Public Sub BeforeSaveDataRow()

    End Sub

    Public Sub BeforeAddDataRow()

    End Sub

    Public Sub DataRowAdding()

    End Sub

    Public Sub DataRowAdded()

    End Sub

    Public Sub BeforeDeleteDataRow()

    End Sub

    Public Sub DataRowDeleting()

    End Sub

    Public Sub DataRowDeleted()

    End Sub

    Public Sub DataRowLockedChanging()

    End Sub

    Public Sub DataRowLockedChanged()

    End Sub

    Public Sub PositionChanged()

    End Sub
    Public Sub CurrentChanged(e As Foxtable.TableEventArgs)
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
    Public Sub BeforeSelChange()

    End Sub

    Public Sub AfterSelChange()

    End Sub

    Public Sub BeforeSelRangeChange()

    End Sub

    Public Sub AfterSelRangeChange()

    End Sub

    Public Sub BeforeMoveRow()

    End Sub

    Public Sub AfterMoveRow()

    End Sub

    Public Sub BeforeDragColumn()

    End Sub

    Public Sub AfterDragColumn()

    End Sub

    Public Sub BeforeFreezeColumn()

    End Sub

    Public Sub AfterFreezeColumn()

    End Sub

    Public Sub BeforeResizeColumn()

    End Sub

    Public Sub AfterResizeColumn()

    End Sub

    Public Sub BeforeResizeRow()

    End Sub

    Public Sub AfterResizeRow()

    End Sub
    Public Sub AfterCheckRow()

    End Sub
    Public Sub BeforeCheckRow()

    End Sub

    Public Sub BeforeLoad()

    End Sub

    Public Sub AfterLoad()

    End Sub

    Public Sub BeforeFilter()

    End Sub

    Public Sub AfterFilter()

    End Sub

    Public Sub BeforeSort()

    End Sub

    Public Sub AfterSort()

    End Sub

    Public Sub BeforeAddFile()

    End Sub

    Public Sub BeforeAttachFile()

    End Sub

    Public Sub BeforeOpenFile()

    End Sub

    Public Sub BeforeDeleteFile()

    End Sub

    Public Sub DrawCell()

    End Sub

    Public Sub BeforeDrawRow()

    End Sub

    Public Sub KeyDown()

    End Sub

    Public Sub KeyUp()

    End Sub

    Public Sub DoubleClick()

    End Sub

    Public Sub DoubleClickRowHeader()

    End Sub

    Public Sub Click()

    End Sub

    Public Sub MouseEnterCell()

    End Sub

    Public Sub MouseLeaveCell()

    End Sub

    Public Sub AfterScroll()

    End Sub

    Public Sub AfterLoadTableSetting()

    End Sub

    Public Sub BeforeShowContextMenu()

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

