Imports System.Windows.Forms
Imports Foxtable

Public Module 全局变量
    Private _系统表列表 As New Dictionary(Of String, DataTable) '
    Private _子表名列表 As New Dictionary(Of String, List(Of String)) '主表子表列表
    Private _旧当前子表名 As New Dictionary(Of String, String) '主表当前子表
    Private _旧当前行 As New Dictionary(Of String, Row) '表当前行
    Private _旧当前主表名 As String = ""
    Private _旧当前表名 As String = "" '当前表
    Private _布局控件 As uc1
    Private _网络本地时间记录 As Dictionary(Of Date, Date)
    Friend _时差 As Double
    Private _时间监控最后执行时间 As Date
    Private _有更改的主表行 As New Dictionary(Of String, String)

    Private _登录用户编号 As String
    Private _登录人员编号 As String
    Private _登录客户端编号 As String
    Private _登录人员法律主体编号 As String
    Private _当前法律主体编号 As String
    Private _当前交易主体编号 As String
    Private _当前群体编号 As String
    Private _当前群体成员编号 As String
    Private _当前企业编号 As String
    'Private ReadOnly _实际时间计数 As New Dictionary(Of Date, Integer)



    'Private _时间监控开始时间 As Date
    'Private _时间监控执行次数 As Integer
    'Private _时间监控总误差 As Double

    Friend Property 网络本地时间记录 As Dictionary(Of Date, Date)
        Get
            If _网络本地时间记录 Is Nothing Then
                Dim 网络时间 As Date = 获取网络时间.DataStandardTime
                Dim 本地时间 As Date = Date.Now
                _网络本地时间记录 = New Dictionary(Of Date, Date)
                _网络本地时间记录.Add(网络时间, 本地时间)
                Dim 时间段 As TimeSpan = 网络时间 - 本地时间
                _时差 = 时间段.TotalMilliseconds
            End If
            Return _网络本地时间记录
        End Get
        Set(value As Dictionary(Of Date, Date))
            If value Is Nothing Then
                _网络本地时间记录 = value
            Else

            End If
        End Set
    End Property

    Public ReadOnly Property 实际时间 As Date
        Get
            'Dim 时间 As Date = Date.Now.AddMilliseconds(时差)
            'If 实际时间计数.ContainsKey(时间) Then
            '    实际时间计数(时间) += 1
            'Else
            '    实际时间计数.Clear()
            '    实际时间计数.Add(时间, 0)
            'End If
            'Return 时间
            Return Date.Now.AddMilliseconds(时差)
        End Get
    End Property

    Public Property 系统表列表 As Dictionary(Of String, DataTable)
        Get
            Return _系统表列表
        End Get
        Set(value As Dictionary(Of String, DataTable))
            _系统表列表 = value
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

    Public Property 布局控件 As uc1
        Get
            Return _布局控件
        End Get
        Set(value As uc1)
            _布局控件 = value
        End Set
    End Property

    Friend Property 时差 As Double
        Get
            Return _时差
        End Get
        Set(value As Double)
            _时差 = value
            Output.Show("Set时差")
        End Set
    End Property

    Public Property 时间监控最后执行时间 As Date
        Get
            Return _时间监控最后执行时间
        End Get
        Set(value As Date)
            _时间监控最后执行时间 = value
        End Set
    End Property

    Public Property 有更改的主表行 As Dictionary(Of String, String)
        Get
            Return _有更改的主表行
        End Get
        Set(value As Dictionary(Of String, String))
            _有更改的主表行 = value
        End Set
    End Property

    Public Property 登录用户编号 As String
        Get
            Return _登录用户编号
        End Get
        Set(value As String)
            _登录用户编号 = value
        End Set
    End Property

    Public Property 登录人员编号 As String
        Get
            Return _登录人员编号
        End Get
        Set(value As String)
            _登录人员编号 = value
        End Set
    End Property

    Public Property 登录客户端编号 As String
        Get
            Return _登录客户端编号
        End Get
        Set(value As String)
            _登录客户端编号 = value
        End Set
    End Property

    Public Property 登录人员法律主体编号 As String
        Get
            Return _登录人员法律主体编号
        End Get
        Set(value As String)
            _登录人员法律主体编号 = value
        End Set
    End Property

    Public Property 当前法律主体编号 As String
        Get
            Return _当前法律主体编号
        End Get
        Set(value As String)
            _当前法律主体编号 = value
        End Set
    End Property

    Public Property 当前交易主体编号 As String
        Get
            Return _当前交易主体编号
        End Get
        Set(value As String)
            _当前交易主体编号 = value
        End Set
    End Property

    Public Property 当前群体编号 As String
        Get
            Return _当前群体编号
        End Get
        Set(value As String)
            _当前群体编号 = value
        End Set
    End Property

    Public Property 当前群体成员编号 As String
        Get
            Return _当前群体成员编号
        End Get
        Set(value As String)
            _当前群体成员编号 = value
        End Set
    End Property

    Public Property 当前企业编号 As String
        Get
            Return _当前企业编号
        End Get
        Set(value As String)
            _当前企业编号 = value
        End Set
    End Property

    'Public ReadOnly Property 实际时间计数 As Dictionary(Of Date, Integer)
    '    Get
    '        Return _实际时间计数
    '    End Get
    'End Property



    'Public Property 时间监控开始时间 As Date
    '    Get
    '        Return _时间监控开始时间
    '    End Get
    '    Set(value As Date)
    '        _时间监控开始时间 = value
    '    End Set
    'End Property

    'Public Property 时间监控执行次数 As Integer
    '    Get
    '        Return _时间监控执行次数
    '    End Get
    '    Set(value As Integer)
    '        _时间监控执行次数 = value
    '    End Set
    'End Property

    'Public Property 时间监控总误差 As Double
    '    Get
    '        Return _时间监控总误差
    '    End Get
    '    Set(value As Double)
    '        _时间监控总误差 = value
    '    End Set
    'End Property
End Module
