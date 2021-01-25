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
    Public Sub DataColChanged(e As Foxtable.DataColEventArgs)
        全局表事件实现.DataColChanged(e)
    End Sub
    Public Sub BeforeSaveDataRow()

    End Sub
    Public Sub BeforeAddDataRow()

    End Sub
    Public Sub DataRowAdding(e As Foxtable.DataRowEventArgs)
        全局表事件实现.DataRowAdding(e)
    End Sub
    Public Sub DataRowAdded()

    End Sub
    Public Sub BeforeDeleteDataRow()
        '紧急任务:
        全局表事件实现.BeforeDeleteDataRow()
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
        全局表事件实现.CurrentChanged(e)
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

    Public Sub AfterLoad(e As Foxtable.LoadEventArgs)
        全局表事件实现.AfterLoad(e)
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
End Module