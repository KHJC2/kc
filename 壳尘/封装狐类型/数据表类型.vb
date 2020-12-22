#Region "程序集 Foxtable, Version=2020.5.29.8, Culture=neutral, PublicKeyToken=null"

' C:\foxtable\Trial\foxtable.exe

#End Region

Imports System.Data.OleDb
Imports Foxtable

Public Class 数据表类型
    Public Sub New(狐数据表参数 As Foxtable.DataTable)
        Me.狐数据表 = 狐数据表参数
    End Sub
    Public ReadOnly Property AddByCode As Boolean
        Get
            Return 狐数据表.AddByCode
        End Get
    End Property
    Public Property AllowClipBoard As Boolean
        Get
            Return 狐数据表.AllowClipBoard
        End Get
        Set
            狐数据表.AllowClipBoard = Value
        End Set
    End Property
    Public Property BatchUpdateSize As Integer
        Get
            Return 狐数据表.BatchUpdateSize
        End Get
        Set
            狐数据表.BatchUpdateSize = Value
        End Set
    End Property
    Public Property DeleteRowPrompt As Boolean
        Get
            Return 狐数据表.DeleteRowPrompt
        End Get
        Set
            狐数据表.DeleteRowPrompt = Value
        End Set
    End Property
    Public Property Developer As String
        Get
            Return 狐数据表.Developer
        End Get
        Set
            狐数据表.Developer = Value
        End Set
    End Property
    Public Property FillLoadTimeOut As Integer
        Get
            Return 狐数据表.FillLoadTimeOut
        End Get
        Set
            狐数据表.FillLoadTimeOut = Value
        End Set
    End Property
    Public ReadOnly Property InBackEndFilterMode As Boolean
        Get
            Return 狐数据表.InBackEndFilterMode
        End Get
    End Property
    Public Property LoadOrder As String
        Get
            Return 狐数据表.LoadOrder
        End Get
        Set
            狐数据表.LoadOrder = Value
        End Set
    End Property
    Public Property LoadOver As String
        Get
            Return 狐数据表.LoadOver
        End Get
        Set
            狐数据表.LoadOver = Value
        End Set
    End Property
    Public Property LoadReverse As Boolean
        Get
            Return 狐数据表.LoadReverse
        End Get
        Set
            狐数据表.LoadReverse = Value
        End Set
    End Property
    Public ReadOnly Property LoadTop2 As String
        Get
            Return 狐数据表.LoadTop2
        End Get
    End Property
    Public Property MultiRowHeader As Boolean
        Get
            Return 狐数据表.MultiRowHeader
        End Get
        Set
            狐数据表.MultiRowHeader = Value
        End Set
    End Property
    Public Property PreserveEditMode As Boolean
        Get
            Return 狐数据表.PreserveEditMode
        End Get
        Set
            狐数据表.PreserveEditMode = Value
        End Set
    End Property
    Public Property PreserveEditMode2 As BooleanEnum
        Get
            Return 狐数据表.PreserveEditMode2
        End Get
        Set
            狐数据表.PreserveEditMode2 = Value
        End Set
    End Property
    Public Property SEQUENCE As String
        Get
            Return 狐数据表.SEQUENCE
        End Get
        Set
            狐数据表.SEQUENCE = Value
        End Set
    End Property
    Public Property SystemVisualStyle As Boolean
        Get
            Return 狐数据表.SystemVisualStyle
        End Get
        Set
            狐数据表.SystemVisualStyle = Value
        End Set
    End Property
    Public Property Tab键向下 As Boolean
        Get
            Return 狐数据表.TabKeyActionDown
        End Get
        Set
            狐数据表.TabKeyActionDown = Value
        End Set
    End Property
    Public Property Theme As String
        Get
            Return 狐数据表.Theme
        End Get
        Set
            狐数据表.Theme = Value
        End Set
    End Property
    Public ReadOnly Property 标题 As String
        Get
            Return 狐数据表.Caption
        End Get
    End Property
    Public ReadOnly Property 狐数据表 As Foxtable.DataTable
    Public Property 回车键向下 As Boolean
        Get
            Return 狐数据表.EnterKeyActionDown
        End Get
        Set
            狐数据表.EnterKeyActionDown = Value
        End Set
    End Property
    Public Property 基表 As System.Data.DataTable
        Get
            Return 狐数据表.BaseTable
        End Get
        Set
            狐数据表.BaseTable = Value
        End Set
    End Property
    Public Property 加载筛选 As String
        Get
            Return 狐数据表.LoadFilter
        End Get
        Set
            狐数据表.LoadFilter = Value
        End Set
    End Property
    Public Property 加载行数 As String
        Get
            Return 狐数据表.LoadTop
        End Get
        Set
            狐数据表.LoadTop = Value
        End Set
    End Property
    Public Property 加载页 As Integer
        Get
            Return 狐数据表.LoadPage
        End Get
        Set
            狐数据表.LoadPage = Value
        End Set
    End Property
    Public ReadOnly Property 类型 As Integer
        Get
            Return 狐数据表.Type
        End Get
    End Property
    Public ReadOnly Property 连接名 As String
        Get
            Return 狐数据表.ConnectionName
        End Get
    End Property
    Public ReadOnly Property 名称 As String
        Get
            Return 狐数据表.Name
        End Get
    End Property
    Public ReadOnly Property 全局事件集 As GlobalEvents
        Get
            Return 狐数据表.GlobalHandler
        End Get
    End Property
    Public ReadOnly Property 数据列集 As DataColCollection
        Get
            Return 狐数据表.DataCols
        End Get
    End Property
    Public ReadOnly Property 数据行集 As Foxtable.DataRowCollection
        Get
            Return 狐数据表.DataRows
        End Get
    End Property
    Public ReadOnly Property 数据源类型 As DataServerTypeEnum
        Get
            Return 狐数据表.DataServerType
        End Get
    End Property
    Public ReadOnly Property 有更改 As Boolean
        Get
            Return 狐数据表.HasChanges
        End Get
    End Property
    Public ReadOnly Property 源类型 As Integer
        Get
            Return 狐数据表.SourceType
        End Get
    End Property
    Public Property 允许编辑 As Boolean
        Get
            Return 狐数据表.AllowEdit
        End Get
        Set
            狐数据表.AllowEdit = Value
        End Set
    End Property
    Public Property 允许初始化 As Boolean
        Get
            Return 狐数据表.AllowInitialize
        End Get
        Set
            狐数据表.AllowInitialize = Value
        End Set
    End Property
    Public Property 允许调整单独行高 As Boolean
        Get
            Return 狐数据表.AllowResizeSingleRow
        End Get
        Set
            狐数据表.AllowResizeSingleRow = Value
        End Set
    End Property
    Public Property 允许调整列宽 As Boolean
        Get
            Return 狐数据表.AllowResizeColumn
        End Get
        Set
            狐数据表.AllowResizeColumn = Value
        End Set
    End Property
    Public Property 允许调整行高 As Boolean
        Get
            Return 狐数据表.AllowResizeRow
        End Get
        Set
            狐数据表.AllowResizeRow = Value
        End Set
    End Property
    Public Property 允许冻结列 As Boolean
        Get
            Return 狐数据表.AllowFreezeColumn
        End Get
        Set
            狐数据表.AllowFreezeColumn = Value
        End Set
    End Property
    Public Property 允许复制表头 As Boolean
        Get
            Return 狐数据表.AllowCopyHeader
        End Get
        Set
            狐数据表.AllowCopyHeader = Value
        End Set
    End Property
    Public Property 允许后台筛选 As Boolean
        Get
            Return 狐数据表.AllowBackEndFilter
        End Get
        Set
            狐数据表.AllowBackEndFilter = Value
        End Set
    End Property
    Public Property 允许解锁行 As Boolean
        Get
            Return 狐数据表.AllowUnlockRow
        End Get
        Set
            狐数据表.AllowUnlockRow = Value
        End Set
    End Property
    Public Property 允许删除行 As Boolean
        Get
            Return 狐数据表.AllowDelete
        End Get
        Set
            狐数据表.AllowDelete = Value
        End Set
    End Property
    Public Property 允许锁定行 As Boolean
        Get
            Return 狐数据表.AllowLockRow
        End Get
        Set
            狐数据表.AllowLockRow = Value
        End Set
    End Property
    Public Property 允许拖动列 As Boolean
        Get
            Return 狐数据表.AllowDragColumn
        End Get
        Set
            狐数据表.AllowDragColumn = Value
        End Set
    End Property
    Public Property 允许新增行 As Boolean
        Get
            Return 狐数据表.AllowAddNew
        End Get
        Set
            狐数据表.AllowAddNew = Value
        End Set
    End Property
    Public Property 允许重定向表 As Boolean
        Get
            Return 狐数据表.AllowRedirect
        End Get
        Set
            狐数据表.AllowRedirect = Value
        End Set
    End Property
    Public Property 自动新增行 As Boolean
        Get
            Return 狐数据表.AutoAddNew
        End Get
        Set
            狐数据表.AutoAddNew = Value
        End Set
    End Property
    Public ReadOnly Property 总行数 As Integer
        Get
            Return 狐数据表.TotalRows
        End Get
    End Property

    Public ReadOnly Property 总页数 As Double
        Get
            Return 狐数据表.TotalPages
        End Get
    End Property
    Public ReadOnly Property Styles(StyleName As String) As CellStyle
        Get
            Return 狐数据表.Styles(StyleName)
        End Get
    End Property
    Public ReadOnly Property SysStyles(StyleName As String) As CellStyle
        Get
            Return 狐数据表.SysStyles(StyleName)
        End Get
    End Property
    Public Sub AddUserStyle(Name As String, BackColor As System.Drawing.Color, Forecolor As System.Drawing.Color)
        狐数据表.AddUserStyle(Name, BackColor, Forecolor)
    End Sub
    Public Sub Dispose()
        狐数据表.Dispose()
    End Sub
    Public Sub FillSortKeyValue()
        狐数据表.FillSortKeyValue()
    End Sub
    Public Function GetComboListString(ColumnName As String, Optional Filter As String = "", Optional sort As String = "") As String
        Return 狐数据表.GetComboListString(ColumnName, Filter, sort)
    End Function
    Public Function GetUniqueValues(Filter As String, ColumnName As String) As List(Of String)
        Return 狐数据表.GetUniqueValues(Filter, ColumnName)
    End Function
    Public Function GetUniqueValues(Filter As String, ParamArray ColumnNames() As String) As List(Of String())
        Return 狐数据表.GetUniqueValues(Filter, ColumnNames)
    End Function
    Public Sub LoadChildren(ChildName As String)
        狐数据表.LoadChildren(ChildName)
    End Sub
    Public Sub LoadChildren(ChildName As String, ParentCol As String, ChildCol As String)
        狐数据表.LoadChildren(ChildName, ParentCol, ChildCol)
    End Sub
    Public Sub RejectChanges()
        狐数据表.RejectChanges()
    End Sub
    Public Function SQLGetComboListString(ColumnName As String, Optional Filter As String = "", Optional Sort As String = "") As String
        Return 狐数据表.SQLGetComboListString(ColumnName, Filter, Sort)
    End Function
    Public Function SQL查找行(Filter As String, Optional Sort As String = "", Optional Index As Integer = 0) As Foxtable.DataRow
        Return 狐数据表.SQLFind(Filter, Sort, Index)
    End Function
    Public Sub SQL更新行(lst As List(Of Foxtable.DataRow))
        狐数据表.SQLUpdate(lst)
    End Sub
    Public Function SQL获取列不重复值(ColumnName As String, Optional Filter As String = "", Optional Sort As String = "") As Object
        Return 狐数据表.SQLGetValues(ColumnName, Filter, Sort)
    End Function
    Public Function SQL计算(Expression As String, Filter As String) As Object
        Return 狐数据表.SQLCompute(Expression, Filter)
    End Function
    Public Function SQL计算(Expression As String) As Object
        Return 狐数据表.SQLCompute(Expression)
    End Function
    Public Function SQL删除行(Filter As String) As Integer
        Return 狐数据表.SQLDeleteFor(Filter)
    End Function
    Public Function SQL替换行(ColName As String, Value As Object, Optional Filter As String = "", Optional IsExpression As Boolean = False) As Integer
        Return 狐数据表.SQLReplaceFor(ColName, Value, Filter, IsExpression)
    End Function
    Public Function SQL新增行() As Foxtable.DataRow
        Return 狐数据表.SQLAddNew
    End Function
    Public Function SQL选择行(Filter As String, Optional Top As String = "", Optional Sort As String = "") As List(Of Foxtable.DataRow)
        Return 狐数据表.SQLSelect(Filter, Top, Sort)
    End Function
    Public Sub SQL重载表(SelectString As String, Optional SaveData As Boolean = True)
        狐数据表.SQLLoad(SelectString, SaveData)
    End Sub
    Public Sub 保存表(blnSaveSetting As Boolean)
        狐数据表.Save(blnSaveSetting)
    End Sub
    Public Sub 保存表()
        狐数据表.Save()
    End Sub
    Public Function 查找行(filterExpression As String, Optional Sort As String = "", Optional Index As Integer = 0) As Foxtable.DataRow
        Return 狐数据表.Find(filterExpression, Sort, Index)
    End Function
    Public Sub 更改连接(ConnName As String)
        狐数据表.ChangeConnection(ConnName)
    End Sub
    Public Sub 忽略更改()
        狐数据表.AcceptChanges()
    End Sub
    Public Sub 恢复绘制()
        狐数据表.ResumeRedraw()
    End Sub
    Public Function 获取列不重复值(ColumnNames As String, Optional Filter As String = "", Optional Sort As String = "") As Object
        Return 狐数据表.GetValues(ColumnNames, Filter, Sort)
    End Function
    Public Function 获取列字符串(ColumnName As String, Optional Filter As String = "", Optional sort As String = "") As String
        Return 狐数据表.GetStrings(ColumnName, Filter, sort)
    End Function
    Public Function 计算(Expression As String) As Object
        Return 狐数据表.Compute(Expression)
    End Function
    Public Function 计算(Expression As String, Filter As String) As Object
        Return 狐数据表.Compute(Expression, Filter)
    End Function
    Public Sub 删除行(Filter As String)
        狐数据表.DeleteFor(Filter)
    End Sub
    Public Sub 生成表头()
        狐数据表.BuildHeader()
    End Sub
    Public Sub 刷新表()
        狐数据表.Refresh()
    End Sub
    Public Sub 替换行(ColName As String, Value As Object, Optional Filter As String = "")
        狐数据表.ReplaceFor(ColName, Value, Filter)
    End Sub
    Public Sub 添加行(Row As Foxtable.DataRow)
        狐数据表.AddRow(Row)
    End Sub
    Public Sub 填充表(SelectString As String, isquery As Boolean)
        狐数据表.Fill(SelectString, isquery)
    End Sub
    Public Sub 填充表(SelectString As String, connName As String, isquery As Boolean)
        狐数据表.Fill(SelectString, connName, isquery)
    End Sub
    Public Sub 停止绘制()
        狐数据表.StopRedraw()
    End Sub
    Public Function 新增行() As Foxtable.DataRow
        Return 狐数据表.NewRow
    End Function
    Public Function 新增行(Optional Count As Integer = 1) As Foxtable.DataRow
        Return 狐数据表.AddNew(Count)
    End Function
    Public Function 选择行(filterExpression As String, Sort As String) As List(Of Foxtable.DataRow)
        Return 狐数据表.[Select](filterExpression, Sort)
    End Function
    Public Function 选择行(filterExpression As String) As List(Of Foxtable.DataRow)
        Return 狐数据表.[Select](filterExpression)
    End Function
    Public Function 选择行(filterExpression As String, Sort As String, RowState As DataViewRowState) As List(Of Foxtable.DataRow)
        Return 狐数据表.[Select](filterExpression, Sort, RowState)
    End Function
    Public Sub 移除行(Filter As String)
        狐数据表.RemoveFor(Filter)
    End Sub
    Public Sub 异步重载表(Optional SaveData As Boolean = True)
        狐数据表.LoadAsync(SaveData)
    End Sub
    Public Sub 异步追加行(Filter As String, Optional SaveBefore As Boolean = True)
        狐数据表.AppendLoadAsync(Filter, SaveBefore)
    End Sub
    Public Sub 重载表(Optional SaveData As Boolean = True, Optional ada As OleDbDataAdapter = Nothing)
        狐数据表.Load(SaveData, ada)
    End Sub
    Public Function 追加行(Filter As String, Optional SaveBefore As Boolean = True, Optional ada As OleDbDataAdapter = Nothing) As List(Of Foxtable.DataRow)
        Return 狐数据表.AppendLoad(Filter, SaveBefore, ada)
    End Function
End Class