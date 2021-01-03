Imports System.Windows.Forms
Imports Foxtable

Public Module defaultt
    Private _dataTablesU As New Dictionary(Of String, DataTable) '
    Private _子表名列表 As New Dictionary(Of String, List(Of String)) '主表子表列表
    Private _旧当前子表名 As New Dictionary(Of String, String) '主表当前子表
    Private _旧当前行 As New Dictionary(Of String, Row) '表当前行
    Private _旧当前主表名 As String = ""
    Private _旧当前表名 As String = "" '当前表

    Public Property DataTablesU As Dictionary(Of String, DataTable)
        Get
            Return _dataTablesU
        End Get
        Set(value As Dictionary(Of String, DataTable))
            _dataTablesU = value
        End Set
    End Property

    Public Property 子表名列表 As Dictionary(Of String, List(Of String))
        Get
            Return _子表名列表
        End Get
        Set(value As Dictionary(Of String, List(Of String)))
            _子表名列表 = value
        End Set
    End Property

    Public Property 旧当前子表名 As Dictionary(Of String, String)
        Get
            Return _旧当前子表名
        End Get
        Set(value As Dictionary(Of String, String))
            _旧当前子表名 = value
        End Set
    End Property

    Public Property 旧当前行 As Dictionary(Of String, Row)
        Get
            Return _旧当前行
        End Get
        Set(value As Dictionary(Of String, Row))
            _旧当前行 = value
        End Set
    End Property

    Public Property 旧当前主表名 As String
        Get
            Return _旧当前主表名
        End Get
        Set(value As String)
            _旧当前主表名 = value
        End Set
    End Property

    Public Property 旧当前表名 As String
        Get
            Return _旧当前表名
        End Get
        Set(value As String)
            _旧当前表名 = value
        End Set
    End Property
End Module

