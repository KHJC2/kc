#Region "程序集 Foxtable, Version=2020.5.29.8, Culture=neutral, PublicKeyToken=null"

' C:\foxtable\Trial\foxtable.exe

#End Region

Imports System.Reflection

Imports Foxtable

<DefaultMember("Item")>
Public Class 行类型
    Public Sub New(狐行参数 As Foxtable.Row)
        Me.狐行 = 狐行参数
    End Sub
    Public Property Checked As Boolean
        Get
            Return 狐行.Checked
        End Get
        Set
            狐行.Checked = Value
        End Set
    End Property
    Public ReadOnly Property DataRow As DataRow
        Get
            Return 狐行.DataRow
        End Get
    End Property

    Public ReadOnly Property Index As Integer
        Get
            Return 狐行.Index
        End Get
    End Property

    Public ReadOnly Property IsGroup As Boolean
        Get
            Return 狐行.IsGroup
        End Get
    End Property

    Public ReadOnly Property Level As Integer
        Get
            Return 狐行.Level
        End Get
    End Property

    Public Property Locked As Boolean
        Get
            Return 狐行.Locked
        End Get
        Set
            狐行.Locked = Value
        End Set
    End Property

    Public ReadOnly Property Table As Table
        Get
            Return 狐行.Table
        End Get
    End Property

    Public ReadOnly Property 狐行 As Foxtable.Row

    Public ReadOnly Property IsNull(Col As Col) As Boolean
        Get
            Return 狐行.IsNull(Col)
        End Get
    End Property

    Public ReadOnly Property IsNull(Col As Integer) As Boolean
        Get
            Return 狐行.IsNull(Col)
        End Get
    End Property

    Public ReadOnly Property IsNull(ColumnName As String) As Boolean
        Get
            Return 狐行.IsNull(ColumnName)
        End Get
    End Property

    Default Public Property Item(Col As Integer) As Object
        Get
            Return 狐行.Item(Col)
        End Get
        Set
            狐行.Item(Col) = Value
        End Set
    End Property

    Default Public Property Item(Column As Col) As Object
        Get
            Return 狐行.Item(Column)
        End Get
        Set
            狐行.Item(Column) = Value
        End Set
    End Property

    Default Public Property Item(ColumnName As String) As Object
        Get
            Return 狐行.Item(ColumnName)
        End Get
        Set
            狐行.Item(ColumnName) = Value
        End Set
    End Property

    Public Sub a()
        狐行.a()
    End Sub

    Public Function Clone() As Row
        Return 狐行.Clone
    End Function

    Public Function Delete() As Boolean
        Return 狐行.Delete
    End Function

    Public Function Equals(r1 As Row) As Boolean
        Return 狐行.Equals(r1)
    End Function

    Public Sub Load(Optional blnsave As Boolean = True)
        狐行.Load(blnsave)
    End Sub

    Public Function Move(IndexNew As Integer) As Boolean
        Return 狐行.Move(IndexNew)
    End Function

    Public Sub Refresh(ColName As String)
        狐行.Refresh(ColName)
    End Sub

    Public Sub Refresh()
        狐行.Refresh()
    End Sub

    Public Sub Reject()
        狐行.Reject()
    End Sub

    Public Sub Remove()
        狐行.Remove()
    End Sub

    Public Sub Save()
        狐行.Save()
    End Sub

End Class