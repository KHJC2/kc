#Region "程序集 Foxtable, Version=2020.5.29.8, Culture=neutral, PublicKeyToken=null"

' C:\foxtable\Trial\foxtable.exe

#End Region
Imports System.Reflection

Imports Foxtable.WinForm

Imports Foxtable.XLS

Imports Foxtable

<DefaultMember("Item")>
Public Class 表类

    Implements IEnumerable(Of Foxtable.Row)
    Public ReadOnly Property 狐表 As Foxtable.Table
    Public Sub New(狐表参数 As Foxtable.Table)
        Me.狐表 = 狐表参数
    End Sub



    Public Property ApplyFilter As Boolean
        Get
            Return 狐表.ApplyFilter
        End Get
        Set
            狐表.ApplyFilter = Value
        End Set
    End Property

    Public ReadOnly Property Count(Optional IncludeGroup As Boolean = False) As Integer
        Get
            Return 狐表.Count(IncludeGroup)
        End Get
    End Property

    Public ReadOnly Property Rows As Foxtable.RowCollection
        Get
            Return 狐表.Rows
        End Get
    End Property

    Public ReadOnly Property Cols As ColCollection
        Get
            Return 狐表.Cols
        End Get
    End Property

    Public Property StateFilter As StateFilterEnum
        Get
            Return 狐表.StateFilter
        End Get
        Set
            狐表.StateFilter = Value
        End Set
    End Property

    Public ReadOnly Property IsChild As Boolean
        Get
            Return 狐表.IsChild
        End Get
    End Property

    Public ReadOnly Property IsParent As Boolean
        Get
            Return 狐表.IsParent
        End Get
    End Property

    Public ReadOnly Property IsRelation As Boolean
        Get
            Return 狐表.IsRelation
        End Get
    End Property

    Public Property Position As Integer
        Get
            Return 狐表.Position
        End Get
        Set
            狐表.Position = Value
        End Set
    End Property

    Public ReadOnly Property Current As Foxtable.Row
        Get
            Return 狐表.Current
        End Get
    End Property

    Public ReadOnly Property RowSel As Integer
        Get
            Return 狐表.RowSel
        End Get
    End Property

    Public ReadOnly Property ColSel As Integer
        Get
            Return 狐表.ColSel
        End Get
    End Property

    Public ReadOnly Property TopRow As Integer
        Get
            Return 狐表.TopRow
        End Get
    End Property

    Public ReadOnly Property TopPosition As Integer
        Get
            Return 狐表.TopPosition
        End Get
    End Property

    Public ReadOnly Property BottomPosition As Integer
        Get
            Return 狐表.BottomPosition
        End Get
    End Property

    Public ReadOnly Property BottomRow As Integer
        Get
            Return 狐表.BottomRow
        End Get
    End Property

    Public ReadOnly Property LeftCol As Integer
        Get
            Return 狐表.LeftCol
        End Get
    End Property

    Public ReadOnly Property RightCol As Integer
        Get
            Return 狐表.RightCol
        End Get
    End Property

    Public Property Redraw As Boolean
        Get
            Return 狐表.Redraw
        End Get
        Set
            狐表.Redraw = Value
        End Set
    End Property

    Public Property Filter As String
        Get
            Return 狐表.Filter
        End Get
        Set
            狐表.Filter = Value
        End Set
    End Property

    Public ReadOnly Property Text(Row As Integer, Col As Integer) As String
        Get
            Return 狐表.Text(Row, Col)
        End Get
    End Property

    Public Property NeedSaveSetting As Boolean
        Get
            Return 狐表.NeedSaveSetting
        End Get
        Set
            狐表.NeedSaveSetting = Value
        End Set
    End Property

    Public ReadOnly Property Text As String
        Get
            Return 狐表.Text
        End Get
    End Property

    Default Public Property Item(Row As Integer, ColumnName As String, Optional IncludeGroup As Boolean = False) As Object
        Get
            Return 狐表.Item(Row, ColumnName, IncludeGroup)
        End Get
        Set
            狐表.Item(Row, ColumnName, IncludeGroup) = Value
        End Set
    End Property

    Public ReadOnly Property DataTable As DataTable
        Get
            Return 狐表.DataTable
        End Get
    End Property

    Public Property Font As System.Drawing.Font
        Get
            Return 狐表.Font
        End Get
        Set
            狐表.Font = Value
        End Set
    End Property

    Public Property ForeColor As System.Drawing.Color
        Get
            Return 狐表.ForeColor
        End Get
        Set
            狐表.ForeColor = Value
        End Set
    End Property

    Public ReadOnly Property CanUndo As Boolean
        Get
            Return 狐表.CanUndo
        End Get
    End Property

    Public ReadOnly Property CanRedo As Boolean
        Get
            Return 狐表.CanRedo
        End Get
    End Property

    Public Property MergeCols As List(Of String)
        Get
            Return 狐表.MergeCols
        End Get
        Set
            狐表.MergeCols = Value
        End Set
    End Property

    Public Property MergeSort As String
        Get
            Return 狐表.MergeSort
        End Get
        Set
            狐表.MergeSort = Value
        End Set
    End Property

    Public Property MergeMode As MergeModeEnum
        Get
            Return 狐表.MergeMode
        End Get
        Set
            狐表.MergeMode = Value
        End Set
    End Property

    Public Property AllowMerge As Boolean
        Get
            Return 狐表.AllowMerge
        End Get
        Set
            狐表.AllowMerge = Value
        End Set
    End Property

    Public ReadOnly Property SubtotalGroups As List(Of SubtotalGroup)
        Get
            Return 狐表.SubtotalGroups
        End Get
    End Property

    Public Property GroupAboveData As Boolean
        Get
            Return 狐表.GroupAboveData
        End Get
        Set
            狐表.GroupAboveData = Value
        End Set
    End Property

    Public Property TreeVisible As Boolean
        Get
            Return 狐表.TreeVisible
        End Get
        Set
            狐表.TreeVisible = Value
        End Set
    End Property

    Public Property ScrollPosition As System.Drawing.Point
        Get
            Return 狐表.ScrollPosition
        End Get
        Set
            狐表.ScrollPosition = Value
        End Set
    End Property

    Public ReadOnly Property IsSubtotal As Boolean
        Get
            Return 狐表.IsSubtotal
        End Get
    End Property

    Public Property GrandTotal As Boolean
        Get
            Return 狐表.GrandTotal
        End Get
        Set
            狐表.GrandTotal = Value
        End Set
    End Property

    Public Property Value As Object
        Get
            Return 狐表.Value
        End Get
        Set
            狐表.Value = Value
        End Set
    End Property

    Public Property Value(Row As Integer, Col As Integer, Optional IncludeGroup As Boolean = False) As Object
        Get
            Return 狐表.Value(Row, Col, IncludeGroup)
        End Get
        Set
            狐表.Value(Row, Col, IncludeGroup) = Value
        End Set
    End Property

    Public Property Value(Row As Integer, ColumnName As String, Optional IncludeGroup As Boolean = False) As Object
        Get
            Return 狐表.Value(Row, ColumnName, IncludeGroup)
        End Get
        Set
            狐表.Value(Row, ColumnName, IncludeGroup) = Value
        End Set
    End Property

    Default Public Property Item(Row As Integer, Col As Integer, Optional IncludeGroup As Boolean = False) As Object
        Get
            Return 狐表.Item(Row, Col, IncludeGroup)
        End Get
        Set
            狐表.Item(Row, Col, IncludeGroup) = Value
        End Set
    End Property

    Default Public ReadOnly Property Item(Index As Integer, Optional IncludeGroup As Boolean = False) As Foxtable.Row
        Get
            Return 狐表.Item(Index, IncludeGroup)
        End Get
    End Property

    Public Property Visible As Boolean
        Get
            Return 狐表.Visible
        End Get
        Set
            狐表.Visible = Value
        End Set
    End Property

    Public Property Sort As String
        Get
            Return 狐表.Sort
        End Get
        Set
            狐表.Sort = Value
        End Set
    End Property

    Public Property EnterKeyActionDown As Boolean
        Get
            Return 狐表.EnterKeyActionDown
        End Get
        Set
            狐表.EnterKeyActionDown = Value
        End Set
    End Property

    Public WriteOnly Property DataSource As Object
        Set
            狐表.DataSource = Value
        End Set
    End Property

    Public Property DefaultRowHeight As Integer
        Get
            Return 狐表.DefaultRowHeight
        End Get
        Set
            狐表.DefaultRowHeight = Value
        End Set
    End Property

    Public Property DefaultColWidth As Integer
        Get
            Return 狐表.DefaultColWidth
        End Get
        Set
            狐表.DefaultColWidth = Value
        End Set
    End Property

    Public Property FocusRect As Boolean
        Get
            Return 狐表.FocusRect
        End Get
        Set
            狐表.FocusRect = Value
        End Set
    End Property

    Public Property SpillNode As Boolean
        Get
            Return 狐表.SpillNode
        End Get
        Set
            狐表.SpillNode = Value
        End Set
    End Property

    Public ReadOnly Property RecordGridVisible As Boolean
        Get
            Return 狐表.RecordGridVisible
        End Get
    End Property

    Public Property AllowBackgroundStatistics As Boolean
        Get
            Return 狐表.AllowBackgroundStatistics
        End Get
        Set
            狐表.AllowBackgroundStatistics = Value
        End Set
    End Property

    Public Property LeftVisibleCol As Integer
        Get
            Return 狐表.LeftVisibleCol
        End Get
        Set
            狐表.LeftVisibleCol = Value
        End Set
    End Property

    Public ReadOnly Property RightVisibleCol As Integer
        Get
            Return 狐表.RightVisibleCol
        End Get
    End Property

    Public Property TopVisibleRow As Integer
        Get
            Return 狐表.TopVisibleRow
        End Get
        Set
            狐表.TopVisibleRow = Value
        End Set
    End Property

    Public ReadOnly Property BottomVisibleRow As Integer
        Get
            Return 狐表.BottomVisibleRow
        End Get
    End Property

    Public Property ExtendLastCol As Boolean
        Get
            Return 狐表.ExtendLastCol
        End Get
        Set
            狐表.ExtendLastCol = Value
        End Set
    End Property

    Public ReadOnly Property Appearance As LookAndFeelProperty
        Get
            Return 狐表.Appearance
        End Get
    End Property

    Public Property ShowErrors As Boolean
        Get
            Return 狐表.ShowErrors
        End Get
        Set
            狐表.ShowErrors = Value
        End Set
    End Property

    Public ReadOnly Property Form As Form
        Get
            Return 狐表.Form
        End Get
    End Property

    Public Property AllowBackEndFilter As Boolean
        Get
            Return 狐表.AllowBackEndFilter
        End Get
        Set
            狐表.AllowBackEndFilter = Value
        End Set
    End Property

    Public Property UseVisualStyle As Boolean
        Get
            Return 狐表.UseVisualStyle
        End Get
        Set
            狐表.UseVisualStyle = Value
        End Set
    End Property

    Public Property Theme As String
        Get
            Return 狐表.Theme
        End Get
        Set
            狐表.Theme = Value
        End Set
    End Property

    Public ReadOnly Property SysStyles As Global.C1.Win.C1FlexGrid.CellStyleCollection
        Get
            Return 狐表.SysStyles
        End Get
    End Property

    Public Property ShowCheckBox As Boolean
        Get
            Return 狐表.ShowCheckBox
        End Get
        Set
            狐表.ShowCheckBox = Value
        End Set
    End Property

    Public Property ApplySort As Boolean
        Get
            Return 狐表.ApplySort
        End Get
        Set
            狐表.ApplySort = Value
        End Set
    End Property

    Public Property RowHeaderVisible As Boolean
        Get
            Return 狐表.RowHeaderVisible
        End Get
        Set
            狐表.RowHeaderVisible = Value
        End Set
    End Property

    Public Property ListMode As Boolean
        Get
            Return 狐表.ListMode
        End Get
        Set
            狐表.ListMode = Value
        End Set
    End Property

    Public Property TabKeyActionDown As Boolean
        Get
            Return 狐表.TabKeyActionDown
        End Get
        Set
            狐表.TabKeyActionDown = Value
        End Set
    End Property

    Public Property AllowDragColumn As Boolean
        Get
            Return 狐表.AllowDragColumn
        End Get
        Set
            狐表.AllowDragColumn = Value
        End Set
    End Property

    Public Property AllowFreezeColumn As Boolean
        Get
            Return 狐表.AllowFreezeColumn
        End Get
        Set
            狐表.AllowFreezeColumn = Value
        End Set
    End Property

    Public Property AllowResizeColumn As Boolean
        Get
            Return 狐表.AllowResizeColumn
        End Get
        Set
            狐表.AllowResizeColumn = Value
        End Set
    End Property

    Public Property AllowResizeRow As Boolean
        Get
            Return 狐表.AllowResizeRow
        End Get
        Set
            狐表.AllowResizeRow = Value
        End Set
    End Property

    Public Property AllowEdit As Boolean
        Get
            Return 狐表.AllowEdit
        End Get
        Set
            狐表.AllowEdit = Value
        End Set
    End Property

    Public Property PreserveEditMode As Boolean
        Get
            Return 狐表.PreserveEditMode
        End Get
        Set
            狐表.PreserveEditMode = Value
        End Set
    End Property

    Public Property AllowAddNew As Boolean
        Get
            Return 狐表.AllowAddNew
        End Get
        Set
            狐表.AllowAddNew = Value
        End Set
    End Property

    Public Property AutoAddNew As Boolean
        Get
            Return 狐表.AutoAddNew
        End Get
        Set
            狐表.AutoAddNew = Value
        End Set
    End Property

    Public Property AllowDelete As Boolean
        Get
            Return 狐表.AllowDelete
        End Get
        Set
            狐表.AllowDelete = Value
        End Set
    End Property

    Public Property AllowLockRow As Boolean
        Get
            Return 狐表.AllowLockRow
        End Get
        Set
            狐表.AllowLockRow = Value
        End Set
    End Property

    Public Property AllowUnLockRow As Boolean
        Get
            Return 狐表.AllowUnLockRow
        End Get
        Set
            狐表.AllowUnLockRow = Value
        End Set
    End Property

    Public Property AllowResizeSingleRow As Boolean
        Get
            Return 狐表.AllowResizeSingleRow
        End Get
        Set
            狐表.AllowResizeSingleRow = Value
        End Set
    End Property

    Public ReadOnly Property Focused As Boolean
        Get
            Return 狐表.Focused
        End Get
    End Property

    Public ReadOnly Property PrintInfo As PrintInfo
        Get
            Return 狐表.PrintInfo
        End Get
    End Property

    Public ReadOnly Property HeaderRows As Integer
        Get
            Return 狐表.HeaderRows
        End Get
    End Property

    Public ReadOnly Property Grid As Global.C1.Win.C1FlexGrid.C1FlexGrid
        Get
            Return 狐表.Grid
        End Get
    End Property

    Public ReadOnly Property TableType As TableTypeEnum
        Get
            Return 狐表.TableType
        End Get
    End Property

    Public ReadOnly Property IsCopy As Boolean
        Get
            Return 狐表.IsCopy
        End Get
    End Property

    Public Property AllowClickSort As Boolean
        Get
            Return 狐表.AllowClickSort
        End Get
        Set
            狐表.AllowClickSort = Value
        End Set
    End Property

    Public ReadOnly Property Name As String
        Get
            Return 狐表.Name
        End Get
    End Property



    Public Event NameChanged As oo_0_O00



    Public Sub OpenCalculator()
        狐表.OpenCalculator()
    End Sub

    Public Sub Show()
        狐表.Show()
    End Sub

    Public Sub HideSelectedRows()
        狐表.HideSelectedRows()
    End Sub

    Public Sub Save()
        狐表.Save()
    End Sub

    Public Sub SaveHTM(FileName As String)
        狐表.SaveHTM(FileName)
    End Sub

    Public Sub SavePDF(FileName As String)
        狐表.SavePDF(FileName)
    End Sub

    Public Sub PrintSetting()
        狐表.PrintSetting()
    End Sub

    Public Sub StartEditing()
        狐表.StartEditing()
    End Sub

    Public Sub FinishEditing()
        狐表.FinishEditing()
    End Sub

    Public Sub ResetCurrentItem()
        狐表.ResetCurrentItem()
    End Sub

    Public Sub ResetBindings(Optional metadataChanged As Boolean = False)
        狐表.ResetBindings(metadataChanged)
    End Sub

    Public Sub ResetItem(Itemindex As Integer)
        狐表.ResetItem(Itemindex)
    End Sub

    Public Sub BuildHeader()
        狐表.BuildHeader()
    End Sub

    Public Sub HideUnSelectedRows()
        狐表.HideUnSelectedRows()
    End Sub

    Public Sub AutoSizeHeaderRow()
        狐表.AutoSizeHeaderRow()
    End Sub

    Public Sub AutoSizeRows(Optional ext As Integer = 2)
        狐表.AutoSizeRows(ext)
    End Sub

    Public Sub AutoSizeRow(Index As Integer)
        狐表.AutoSizeRow(Index)
    End Sub

    Public Sub AutoSizeCols(Optional ext As Integer = 2)
        狐表.AutoSizeCols(ext)
    End Sub

    Public Sub AutoSizeCol(ColName As String, Optional ext As Integer = 2)
        狐表.AutoSizeCol(ColName, ext)
    End Sub

    Public Sub SaveExcel(FileName As String, SheetName As String, Optional Flags As SaveExcelFlags = Nothing)
        狐表.SaveExcel(FileName, SheetName, Flags)
    End Sub

    Public Sub CreateReportHeader(tbl As Global.C1.C1Preview.RenderTable, Optional VisibleOnly As Boolean = True)
        狐表.CreateReportHeader(tbl, VisibleOnly)
    End Sub

    Public Sub CreateSheetHeader(XLSSheet As Sheet, Optional StartRow As Integer = 0, Optional StartCol As Integer = 0, Optional VisibleOnly As Boolean = True)
        狐表.CreateSheetHeader(XLSSheet, StartRow, StartCol, VisibleOnly)
    End Sub

    Public Sub SaveExcel(FileName As String, SheetName As String, SelectedRowsOnly As Boolean)
        狐表.SaveExcel(FileName, SheetName, SelectedRowsOnly)
    End Sub

    Public Sub Undo()
        狐表.Undo()
    End Sub

    Public Sub Redo()
        狐表.Redo()
    End Sub

    Public Sub ClearEditInfos()
        狐表.ClearEditInfos()
    End Sub

    Public Sub ClearSubtotal()
        狐表.ClearSubtotal()
    End Sub

    Public Sub Subtotal(Optional UseCurrentSort As Boolean = False)
        狐表.Subtotal(UseCurrentSort)
    End Sub

    Public Sub SetFirstVisibleRow(Index As Integer)
        狐表.SetFirstVisibleRow(Index)
    End Sub

    Public Sub SetFirstVisibleCol(Index As Integer)
        狐表.SetFirstVisibleCol(Index)
    End Sub

    Public Sub SetHeaderCellFont(ColName As String, fnt As System.Drawing.Font, Optional Level As Integer = 0)
        狐表.SetHeaderCellFont(ColName, fnt, Level)
    End Sub

    Public Sub [Select](r1 As Integer, c1 As Integer)
        狐表.[Select](r1, c1)
    End Sub

    Public Sub StopRedraw()
        狐表.StopRedraw()
    End Sub

    Public Sub ResumeRedraw()
        狐表.ResumeRedraw()
    End Sub

    Public Sub Print(Preview As Boolean, ShowDialog As Boolean)
        狐表.Print(Preview, ShowDialog)
    End Sub

    Public Sub DirectPrint(Preview As Boolean, ShowDialog As Boolean)
        狐表.DirectPrint(Preview, ShowDialog)
    End Sub

    Public Sub OpenView(TableViewName As String)
        狐表.OpenView(TableViewName)
    End Sub

    Public Sub Refresh()
        狐表.Refresh()
    End Sub

    Public Sub RefreshChildTables()
        狐表.RefreshChildTables()
    End Sub

    Public Sub [Select](r1 As Integer, c1 As Integer, r2 As Integer, c2 As Integer)
        狐表.[Select](r1, c1, r2, c2)
    End Sub

    Public Sub SetHeaderCellForeColor(ColName As String, clr As System.Drawing.Color, Optional Level As Integer = 0)
        狐表.SetHeaderCellForeColor(ColName, clr, Level)
    End Sub

    Public Sub SetHeaderRowHeight(ParamArray vals() As Integer)
        狐表.SetHeaderRowHeight(vals)
    End Sub

    Public Sub OpenLoadTree(ColNames As String, Optional size As Integer = 0, Optional PageRows As Integer = 0, Optional LoadFirstPage As Boolean = False, Optional Filter As String = "")
        狐表.OpenLoadTree(ColNames, size, PageRows, LoadFirstPage, Filter)
    End Sub

    Public Sub RelationFilter(ColName1 As String, DataTable As DataTable, ColName2 As String, Match As Boolean, Optional backFilter As Boolean = False)
        狐表.RelationFilter(ColName1, DataTable, ColName2, Match, backFilter)
    End Sub

    Public Sub HideToolTip()
        狐表.HideToolTip()
    End Sub

    Public Sub ShowToolTip(Text As String, r As Foxtable.Row, cn As String, Optional dutation As Integer = -1)
        狐表.ShowToolTip(Text, r, cn, dutation)
    End Sub

    Public Sub SetFilterTree()
        狐表.SetFilterTree()
    End Sub

    Public Sub OpenLoadTree()
        狐表.OpenLoadTree()
    End Sub

    Public Sub SetHeaderCellBackColor(ColName As String, clr As System.Drawing.Color, Optional Level As Integer = 0)
        狐表.SetHeaderCellBackColor(ColName, clr, Level)
    End Sub

    Public Sub SetLoadTree()
        狐表.SetLoadTree()
    End Sub

    Public Sub CloseLoadTree()
        狐表.CloseLoadTree()
    End Sub

    Public Sub BuildChart()
        狐表.BuildChart()
    End Sub

    Public Sub ShowCell(Row As Integer, col As Integer)
        狐表.ShowCell(Row, col)
    End Sub

    Public Sub EditCopy()
        狐表.EditCopy()
    End Sub

    Public Sub EditCut()
        狐表.EditCut()
    End Sub

    Public Sub EditPaste()
        狐表.EditPaste()
    End Sub

    Public Sub EditDelete()
        狐表.EditDelete()
    End Sub

    Public Sub ShowToolTip(Text As String, r As Foxtable.Row, c As Foxtable.Col, Optional dutation As Integer = -1)
        狐表.ShowToolTip(Text, r, c, dutation)
    End Sub

    Public Sub RelationFilter(ColName1 As String, DataTableName As String, ColName2 As String, Match As Boolean, Optional backFilter As Boolean = False)
        狐表.RelationFilter(ColName1, DataTableName, ColName2, Match, backFilter)
    End Sub

    Public Sub RepeatFilter(ColName As String, Mode As Integer, Optional backFilter As Boolean = False)
        狐表.RepeatFilter(ColName, Mode, backFilter)
    End Sub

    Public Sub AdvancedFilter()
        狐表.AdvancedFilter()
    End Sub

    Public Sub SetSubtotalMode(Optional last As Boolean = True)
        狐表.SetSubtotalMode(last)
    End Sub

    Public Sub SetColVisibleWidth(s As String)
        狐表.SetColVisibleWidth(s)
    End Sub

    Public Sub SetMergeMode()
        狐表.SetMergeMode()
    End Sub

    Public Sub RaiseCurrentChanged()
        狐表.RaiseCurrentChanged()
    End Sub

    Public Sub RaisePositionChanged()
        狐表.RaisePositionChanged()
    End Sub

    Public Sub SetRowHeight(Index As Integer, Height As Integer)
        狐表.SetRowHeight(Index, Height)
    End Sub

    Public Sub CloseRecordGrid()
        狐表.CloseRecordGrid()
    End Sub

    Public Sub Fill(SelectString As String, connName As String, IsQuery As Boolean)
        狐表.Fill(SelectString, connName, IsQuery)
    End Sub

    Public Sub CrossSubtotal(Optional last As Boolean = True)
        狐表.CrossSubtotal(last)
    End Sub

    Public Sub OpenFilterTree(ColNames As String, Optional size As Integer = 0)
        狐表.OpenFilterTree(ColNames, size)
    End Sub

    Public Sub CloseFilterTree()
        狐表.CloseFilterTree()
    End Sub

    Public Sub OpenRecordGrid(Optional size As Integer = 0)
        狐表.OpenRecordGrid(size)
    End Sub

    Public Sub ClearCheckedRows()
        狐表.ClearCheckedRows()
    End Sub

    Public Sub GroupSubtotal(Optional last As Boolean = True)
        狐表.GroupSubtotal(last)
    End Sub

    Public Sub AdvancedFilter(Dialog As Boolean)
        狐表.AdvancedFilter(Dialog)
    End Sub

    Public Sub OpenFilterTree()
        狐表.OpenFilterTree()
    End Sub

    Public Sub Fill(SelectString As String, IsQuery As Boolean)
        狐表.Fill(SelectString, IsQuery)
    End Sub



    Public Function Compute(Expression As String) As Object
        Return 狐表.Compute(Expression)
    End Function

    Public Function Aggregate(AggregateType As AggregateEnum, R1 As Integer, C1 As Integer, R2 As Integer, C2 As Integer) As Double
        Return 狐表.Aggregate(AggregateType, R1, C1, R2, C2)
    End Function

    Public Function Compute(Expression As String, Filter As String) As Object
        Return 狐表.Compute(Expression, Filter)
    End Function

    Public Function GetCheckedRows() As List(Of Foxtable.Row)
        Return 狐表.GetCheckedRows
    End Function

    Public Function [Select]() As Boolean
        Return 狐表.[Select]
    End Function

    Public Function Find(StrFind As String, RowStart As Integer, Col As Integer, caseSensitive As Boolean, fullMatch As Boolean, Wrap As Boolean) As Integer
        Return 狐表.Find(StrFind, RowStart, Col, caseSensitive, fullMatch, Wrap)
    End Function

    Public Function Find(StrFind As String, RowStart As Integer, Colname As String, caseSensitive As Boolean, fullMatch As Boolean, Wrap As Boolean) As Integer
        Return 狐表.Find(StrFind, RowStart, Colname, caseSensitive, fullMatch, Wrap)
    End Function

    Public Function FindRow(Expression As String) As Integer
        Return 狐表.FindRow(Expression)
    End Function

    Public Function FindRow(Expression As String, RowStart As Integer) As Integer
        Return 狐表.FindRow(Expression, RowStart)
    End Function

    Public Function FindRow(Expression As String, RowStart As Integer, Wrap As Boolean) As Integer
        Return 狐表.FindRow(Expression, RowStart, Wrap)
    End Function

    Public Function FindRow(dr As DataRow) As Integer
        Return 狐表.FindRow(dr)
    End Function

    Public Function AddNew(i As Integer) As Foxtable.Row
        Return 狐表.AddNew(i)
    End Function

    Public Function AddNew() As Foxtable.Row
        Return 狐表.AddNew
    End Function

    Public Function InsertNew() As Foxtable.Row
        Return 狐表.InsertNew
    End Function

    Public Function GetEnumerator() As IEnumerator(Of Foxtable.Row) Implements IEnumerable(Of Foxtable.Row).GetEnumerator
        Return 狐表.GetEnumerator
    End Function

    Public Function GetEnumerator1() As IEnumerator Implements IEnumerable.GetEnumerator
        Return 狐表.GetEnumerator1
    End Function

    Public Function GetColVisibleWidth() As String
        Return 狐表.GetColVisibleWidth
    End Function

    Public Function Focus() As Boolean
        Return 狐表.Focus
    End Function

    Public Delegate Sub oo_0_O00()

End Class

