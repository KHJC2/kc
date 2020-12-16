#Region "程序集 Foxtable, Version=2020.5.29.8, Culture=neutral, PublicKeyToken=null"

' C:\foxtable\Trial\foxtable.exe

#End Region




Imports Foxtable
Imports Foxtable.Syscmd

Namespace 狐空间

    Public Module 表模块

        Public Sub AddDataTable()
            Foxtable.Syscmd.Table.AddDataTable()
        End Sub

        Public Sub ChangeGridLineColor(c As System.Drawing.Color)
            Foxtable.Syscmd.Table.ChangeGridLineColor(c)
        End Sub

        Public Sub ChangeGridLineDirection(Direction As GridLineDirectionEnum)
            Foxtable.Syscmd.Table.ChangeGridLineDirection(Direction)
        End Sub

        Public Sub ToggleSortAndFilter()
            Foxtable.Syscmd.Table.ToggleSortAndFilter()
        End Sub

        Public Sub Lock()
            Foxtable.Syscmd.Table.Lock()
        End Sub

        Public Sub Unlock()
            Foxtable.Syscmd.Table.Unlock()
        End Sub

        Public Sub GetAllValue()
            Foxtable.Syscmd.Table.GetAllValue()
        End Sub

        Public Sub ExportToText()
            Foxtable.Syscmd.Table.ExportToText()
        End Sub

        Public Sub ExportToXML()
            Foxtable.Syscmd.Table.ExportToXML()
        End Sub

        Public Sub Merge()
            Foxtable.Syscmd.Table.Merge()
        End Sub

        Public Sub QuickMerge()
            Foxtable.Syscmd.Table.QuickMerge()
        End Sub

        Public Sub MergeFromXML()
            Foxtable.Syscmd.Table.MergeFromXML()
        End Sub

        Public Sub MergeFromText()
            Foxtable.Syscmd.Table.MergeFromText()
        End Sub

        Public Sub DockSetting()
            Foxtable.Syscmd.Table.DockSetting()
        End Sub

        Public Sub StatusViewer()
            Foxtable.Syscmd.Table.StatusViewer()
        End Sub

        Public Sub ChangeAlterBackColor(c As System.Drawing.Color)
            Foxtable.Syscmd.Table.ChangeAlterBackColor(c)
        End Sub

        Public Sub SaveTableView()
            Foxtable.Syscmd.Table.SaveTableView()
        End Sub

        Public Sub Refresh()
            Foxtable.Syscmd.Table.Refresh()
        End Sub

        Public Sub Load()
            Foxtable.Syscmd.Table.Load()
        End Sub

        Public Sub BuildGroupTable()
            Foxtable.Syscmd.Table.BuildGroupTable()
        End Sub

        Public Sub NewGroupTable()
            Foxtable.Syscmd.Table.NewGroupTable()
        End Sub

        Public Sub RebuildGroupTable()
            Foxtable.Syscmd.Table.RebuildGroupTable()
        End Sub

        Public Sub BuildCrossTable()
            Foxtable.Syscmd.Table.BuildCrossTable()
        End Sub

        Public Sub NewCrossTable()
            Foxtable.Syscmd.Table.NewCrossTable()
        End Sub

        Public Sub RebuildCrossTable()
            Foxtable.Syscmd.Table.RebuildCrossTable()
        End Sub

        Public Sub Move()
            Foxtable.Syscmd.Table.Move()
        End Sub

        Public Sub ExcelReportManager()
            Foxtable.Syscmd.Table.ExcelReportManager()
        End Sub

        Public Sub WordReportManager()
            Foxtable.Syscmd.Table.WordReportManager()
        End Sub

        Public Sub CodeReportManager()
            Foxtable.Syscmd.Table.CodeReportManager()
        End Sub

        Public Sub Recyle()
            Foxtable.Syscmd.Table.Recyle()
        End Sub

        Public Sub MoveLeft()
            Foxtable.Syscmd.Table.MoveLeft()
        End Sub

        Public Sub TableViewManager()
            Foxtable.Syscmd.Table.TableViewManager()
        End Sub

        Public Sub MoveRight()
            Foxtable.Syscmd.Table.MoveRight()
        End Sub

        Public Sub ChangeForeColor(c As System.Drawing.Color)
            Foxtable.Syscmd.Table.ChangeForeColor(c)
        End Sub

        Public Sub ToggleFontUnderLine()
            Foxtable.Syscmd.Table.ToggleFontUnderLine()
        End Sub

        Public Sub ModiStructure()
            Foxtable.Syscmd.Table.ModiStructure()
        End Sub

        Public Sub Copy()
            Foxtable.Syscmd.Table.Copy()
        End Sub

        Public Sub AddTemporaryTable()
            Foxtable.Syscmd.Table.AddTemporaryTable()
        End Sub

        Public Sub OuterTableManager()
            Foxtable.Syscmd.Table.OuterTableManager()
        End Sub

        Public Sub QueryManager()
            Foxtable.Syscmd.Table.QueryManager()
        End Sub

        Public Sub AddOuterTable()
            Foxtable.Syscmd.Table.AddOuterTable()
        End Sub

        Public Sub ModifyOuterTableSetting()
            Foxtable.Syscmd.Table.ModifyOuterTableSetting()
        End Sub

        Public Sub AddOuterQuery()
            Foxtable.Syscmd.Table.AddOuterQuery()
        End Sub

        Public Sub ModifyOuterQuerySetting()
            Foxtable.Syscmd.Table.ModifyOuterQuerySetting()
        End Sub

        Public Sub AddInnerQuery()
            Foxtable.Syscmd.Table.AddInnerQuery()
        End Sub

        Public Sub ModifyInnerQuery()
            Foxtable.Syscmd.Table.ModifyInnerQuery()
        End Sub

        Public Sub Delete()
            Foxtable.Syscmd.Table.Delete()
        End Sub

        Public Sub Rename()
            Foxtable.Syscmd.Table.Rename()
        End Sub

        Public Sub ModifyDataRelation()
            Foxtable.Syscmd.Table.ModifyDataRelation()
        End Sub

        Public Sub ChangeBackColor(c As System.Drawing.Color)
            Foxtable.Syscmd.Table.ChangeBackColor(c)
        End Sub

        Public Sub ModifyProperty()
            Foxtable.Syscmd.Table.ModifyProperty()
        End Sub

        Public Sub ModifyLookAndFeel()
            Foxtable.Syscmd.Table.ModifyLookAndFeel()
        End Sub

        Public Sub SetMergeMode()
            Foxtable.Syscmd.Table.SetMergeMode()
        End Sub

        Public Sub ToggleMergeMode()
            Foxtable.Syscmd.Table.ToggleMergeMode()
        End Sub

        Public Sub SetSubtotalMode()
            Foxtable.Syscmd.Table.SetSubtotalMode()
        End Sub

        Public Sub ReSubtotal()
            Foxtable.Syscmd.Table.ReSubtotal()
        End Sub

        Public Sub NewSubtotalMode()
            Foxtable.Syscmd.Table.NewSubtotalMode()
        End Sub

        Public Sub ToggleSubtotalMode()
            Foxtable.Syscmd.Table.ToggleSubtotalMode()
        End Sub

        Public Sub ToggleGrandTotal()
            Foxtable.Syscmd.Table.ToggleGrandTotal()
        End Sub

        Public Sub SetGrandTotal()
            Foxtable.Syscmd.Table.SetGrandTotal()
        End Sub

        Public Sub ChangeFont()
            Foxtable.Syscmd.Table.ChangeFont()
        End Sub

        Public Sub ChangeFontName(FontName As String)
            Foxtable.Syscmd.Table.ChangeFontName(FontName)
        End Sub

        Public Sub ChangeFontSize(FontSize As Integer)
            Foxtable.Syscmd.Table.ChangeFontSize(FontSize)
        End Sub

        Public Sub ToggleFontBold()
            Foxtable.Syscmd.Table.ToggleFontBold()
        End Sub

        Public Sub ToggleFontItalic()
            Foxtable.Syscmd.Table.ToggleFontItalic()
        End Sub

        Public Sub ModifyUserCellStyle()
            Foxtable.Syscmd.Table.ModifyUserCellStyle()
        End Sub

        Public Sub SetFunctionColumn()
            Foxtable.Syscmd.Table.SetFunctionColumn()
        End Sub

    End Module

End Namespace

