#Region "程序集 Foxtable, Version=2020.5.29.8, Culture=neutral, PublicKeyToken=null"

' C:\foxtable\Trial\foxtable.exe

#End Region

Imports System.Reflection

Imports Foxtable

<DefaultMember("Item")>
Public Class 数据行类

    Public Sub New(狐数据行参数 As Foxtable.DataRow)
        Me.狐数据行 = 狐数据行参数
    End Sub

    Public ReadOnly Property BaseRow As System.Data.DataRow
        Get
            Return 狐数据行.BaseRow
        End Get
    End Property

    Public ReadOnly Property DataTable As DataTable
        Get
            Return 狐数据行.DataTable
        End Get
    End Property

    Public Property Locked As Boolean
        Get
            Return 狐数据行.Locked
        End Get
        Set
            狐数据行.Locked = Value
        End Set
    End Property

    Public ReadOnly Property RowState As DataRowState
        Get
            Return 狐数据行.RowState
        End Get
    End Property

    Public ReadOnly Property 狐数据行 As Foxtable.DataRow

    Public ReadOnly Property IsNull(Column As DataCol) As Boolean
        Get
            Return 狐数据行.IsNull(Column)
        End Get
    End Property

    Public ReadOnly Property IsNull(ColumnName As String) As Boolean
        Get
            Return 狐数据行.IsNull(ColumnName)
        End Get
    End Property

    Default Public Property Item(Column As DataCol) As Object
        Get
            Return 狐数据行.Item(Column)
        End Get
        Set
            狐数据行.Item(Column) = Value
        End Set
    End Property

    Default Public Property Item(ColumnName As String) As Object
        Get
            Return 狐数据行.Item(ColumnName)
        End Get
        Set
            狐数据行.Item(ColumnName) = Value
        End Set
    End Property

    Public Property Lines(Column As DataCol) As List(Of String)
        Get
            Return 狐数据行.Lines(Column)
        End Get
        Set
            狐数据行.Lines(Column) = Value
        End Set
    End Property

    Public Property Lines(ColumnName As String) As List(Of String)
        Get
            Return 狐数据行.Lines(ColumnName)
        End Get
        Set
            狐数据行.Lines(ColumnName) = Value
        End Set
    End Property

    Public ReadOnly Property OriginalIsNull(ColumnName As String) As Boolean
        Get
            Return 狐数据行.OriginalIsNull(ColumnName)
        End Get
    End Property

    Public ReadOnly Property OriginalValue(ColumnName As String) As Object
        Get
            Return 狐数据行.OriginalValue(ColumnName)
        End Get
    End Property

    Public Sub a()
        狐数据行.a()
    End Sub

    Public Sub Accept()
        狐数据行.Accept()
    End Sub

    Public Sub ClearErrors()
        狐数据行.ClearErrors()
    End Sub

    Public Function Clone() As DataRow
        Return 狐数据行.Clone
    End Function

    Public Function Delete() As Boolean
        Return 狐数据行.Delete
    End Function

    Public Function Equals(dr1 As DataRow) As Boolean
        Return 狐数据行.Equals(dr1)
    End Function

    Public Function GetChildRows(ChildTableName As String) As List(Of DataRow)
        Return 狐数据行.GetChildRows(ChildTableName)
    End Function

    Public Function GetError(cn As DataCol, info As String) As String
        Return 狐数据行.GetError(cn, info)
    End Function

    Public Function GetError(cn As String) As String
        Return 狐数据行.GetError(cn)
    End Function

    Public Function GetParentRow(ParentTableName As String) As DataRow
        Return 狐数据行.GetParentRow(ParentTableName)
    End Function

    Public Function GetParentRows(ParentTableName As String) As List(Of DataRow)
        Return 狐数据行.GetParentRows(ParentTableName)
    End Function

    Public Sub Load(Optional blnSave As Boolean = True)
        狐数据行.Load(blnSave)
    End Sub

    Public Function LoadPhysicalValue() As Dictionary(Of String, Object)
        Return 狐数据行.LoadPhysicalValue
    End Function

    Public Sub Refresh()
        狐数据行.Refresh()
    End Sub

    Public Sub Reject()
        狐数据行.Reject()
    End Sub

    Public Sub RejectChanges()
        狐数据行.RejectChanges()
    End Sub

    Public Sub Remove()
        狐数据行.Remove()
    End Sub

    Public Sub Save()
        狐数据行.Save()
    End Sub

    Public Sub SetError(cn As String, info As String)
        狐数据行.SetError(cn, info)
    End Sub

    Public Sub SetError(cn As DataCol, info As String)
        狐数据行.SetError(cn, info)
    End Sub

    Public Function SQLGetValue(Field As String) As Object
        Return 狐数据行.SQLGetValue(Field)
    End Function

    Public Function SQLInsertFile(Field As String, FileName As String) As Boolean
        Return 狐数据行.SQLInsertFile(Field, FileName)
    End Function

    Public Function SQLInsertImage(Field As String, Img As System.Drawing.Image) As Boolean
        Return 狐数据行.SQLInsertImage(Field, Img)
    End Function

    Public Function SQLLoadFile(Filed As String, FileName As String) As Boolean
        Return 狐数据行.SQLLoadFile(Filed, FileName)
    End Function

    Public Function SQLLoadImage(Filed As String) As System.Drawing.Image
        Return 狐数据行.SQLLoadImage(Filed)
    End Function

    Public Function SQLSetValue(Field As String, Value As Object) As Boolean
        Return 狐数据行.SQLSetValue(Field, Value)
    End Function

End Class