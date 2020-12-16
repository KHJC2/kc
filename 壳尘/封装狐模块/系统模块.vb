#Region "程序集 Foxtable, Version=2020.5.29.8, Culture=neutral, PublicKeyToken=null"

' C:\foxtable\Trial\foxtable.exe

#End Region



Imports System.Collections.Generic

Imports System.Data

Imports Foxtable.RibbonMenu

Imports Microsoft.VisualBasic.Devices

Imports Microsoft.VisualBasic.MyServices


Imports Foxtable

Namespace 狐空间

    Public Module 系统模块

        Public ReadOnly Property 当前表 As Table
            Get
                Return Foxtable.OO_00oOO.CurrentTable
            End Get
        End Property

        Public ReadOnly Property 音频 As Audio
            Get
                Return Foxtable.OO_00oOO.Audio
            End Get
        End Property

        Public ReadOnly Property BindTables(Name As String) As DataView
            Get
                Return Foxtable.OO_00oOO.BindTables(Name)
            End Get
        End Property

        Public ReadOnly Property Vars As VarsCollection
            Get
                Return Foxtable.OO_00oOO.Vars
            End Get
        End Property

        Public ReadOnly Property 计划集 As TimerCollection
            Get
                Return Foxtable.OO_00oOO.MyTimers
            End Get
        End Property

        Public ReadOnly Property 鼠标键 As System.Windows.Forms.MouseButtons
            Get
                Return Foxtable.OO_00oOO.MouseButton
            End Get
        End Property

        Public ReadOnly Property 辅助键 As System.Windows.Forms.Keys
            Get
                Return Foxtable.OO_00oOO.ModifierKey
            End Get
        End Property

        Public ReadOnly Property 当前用户 As UserInfo
            Get
                Return Foxtable.OO_00oOO.User
            End Get
        End Property

        Public ReadOnly Property 状态栏 As StatusBar
            Get
                Return Foxtable.OO_00oOO.StatusBar
            End Get
        End Property

        Public ReadOnly Property 下工具栏 As BottomToolBar
            Get
                Return Foxtable.OO_00oOO.BottomToolBar
            End Get
        End Property

        Public ReadOnly Property 上工具栏 As TopToolBar
            Get
                Return Foxtable.OO_00oOO.TopToolBar
            End Get
        End Property

        Public ReadOnly Property 配置栏 As ConfigBar
            Get
                Return Foxtable.OO_00oOO.ConfigBar
            End Get
        End Property

        Public ReadOnly Property 快速访问栏 As Qat
            Get
                Return Foxtable.OO_00oOO.QAT
            End Get
        End Property

        Public ReadOnly Property 数据表集 As Foxtable.DataTableCollection
            Get
                Return Foxtable.OO_00oOO.DataTables
            End Get
        End Property

        Public ReadOnly Property 项目启动参数集 As List(Of Object)
            Get
                Return Foxtable.OO_00oOO.OpenFileArgs
            End Get
        End Property

        Public ReadOnly Property 文件系统 As FileSystemProxy
            Get
                Return Foxtable.OO_00oOO.FileSys
            End Get
        End Property

        Public ReadOnly Property 表集 As TableCollection
            Get
                Return Foxtable.OO_00oOO.Tables
            End Get
        End Property

        Public ReadOnly Property Reports As ReportCollection
            Get
                Return Foxtable.OO_00oOO.Reports
            End Get
        End Property

        Public ReadOnly Property 函数集 As UserFunctions
            Get
                Return Foxtable.OO_00oOO.Functions
            End Get
        End Property

        Public ReadOnly Property 硬件信息 As HardWare
            Get
                Return Foxtable.OO_00oOO.HardWareInfo
            End Get
        End Property

        Public ReadOnly Property ProjectFile As String
            Get
                Return Foxtable.OO_00oOO.ProjectFile
            End Get
        End Property

        Public ReadOnly Property ApplicationPath As String
            Get
                Return Foxtable.OO_00oOO.ApplicationPath
            End Get
        End Property

        Public ReadOnly Property ProjectPath As String
            Get
                Return Foxtable.OO_00oOO.ProjectPath
            End Get
        End Property

        Public ReadOnly Property AttachPath As String
            Get
                Return Foxtable.OO_00oOO.AttachPath
            End Get
        End Property

        Public ReadOnly Property 程序菜单 As ApplicationMenu
            Get
                Return Foxtable.OO_00oOO.ApplicationMenu
            End Get
        End Property

        Public Property 主表 As Table
            Get
                Return Foxtable.OO_00oOO.MainTable
            End Get
            Set
                Foxtable.OO_00oOO.MainTable = Value
            End Set
        End Property

        Public ReadOnly Property 关联集 As Foxtable.DataRelationCollection
            Get
                Return Foxtable.OO_00oOO.Relations
            End Get
        End Property

        Public ReadOnly Property 连接集 As ConnectionCollection
            Get
                Return Foxtable.OO_00oOO.Connections
            End Get
        End Property

        Public ReadOnly Property FileWatcher As FileSystemWatcher
            Get
                Return Foxtable.OO_00oOO.FileWatcher
            End Get
        End Property

        Public ReadOnly Property Ports As MyPortCollections
            Get
                Return Foxtable.OO_00oOO.Ports
            End Get
        End Property

        Public ReadOnly Property 快捷菜单 As ContextMenuCollection
            Get
                Return Foxtable.OO_00oOO.ContextMenus
            End Get
        End Property

        Public ReadOnly Property 窗口集 As FormCollection
            Get
                Return Foxtable.OO_00oOO.Forms
            End Get
        End Property

        Public ReadOnly Property 功能区集 As RibbonMenu.RibbonTabCollection
            Get
                Return Foxtable.OO_00oOO.RibbonTabs
            End Get
        End Property

        Public Property VisualStyle As VisualStyleEnum
            Get
                Return Foxtable.OO_00oOO.VisualStyle
            End Get
            Set
                Foxtable.OO_00oOO.VisualStyle = Value
            End Set
        End Property

        Public Property UpdatePath As String
            Get
                Return Foxtable.OO_00oOO.UpdatePath
            End Get
            Set
                Foxtable.OO_00oOO.UpdatePath = Value
            End Set
        End Property

        Public ReadOnly Property Themes As List(Of String)
            Get
                Return Foxtable.OO_00oOO.Themes
            End Get
        End Property

        Public Property GridTheme As String
            Get
                Return Foxtable.OO_00oOO.GridTheme
            End Get
            Set
                Foxtable.OO_00oOO.GridTheme = Value
            End Set
        End Property

        Public Property RibbonTheme As String
            Get
                Return Foxtable.OO_00oOO.RibbonTheme
            End Get
            Set
                Foxtable.OO_00oOO.RibbonTheme = Value
            End Set
        End Property

        Public Property ControlTheme As String
            Get
                Return Foxtable.OO_00oOO.ControlTheme
            End Get
            Set
                Foxtable.OO_00oOO.ControlTheme = Value
            End Set
        End Property

        Public ReadOnly Property ProjectID As String
            Get
                Return Foxtable.OO_00oOO.ProjectID
            End Get
        End Property

        Public ReadOnly Property DongleID As String
            Get
                Return Foxtable.OO_00oOO.DongleID
            End Get
        End Property

        Public ReadOnly Property QQ客户端 As IMClient
            Get
                Return Foxtable.OO_00oOO.QQClient
            End Get
        End Property

        Public ReadOnly Property QQ服务器 As IMServer
            Get
                Return Foxtable.OO_00oOO.QQServer
            End Get
        End Property

        Public ReadOnly Property UDP客户端集 As o__OOo__
            Get
                Return Foxtable.OO_00oOO.UDPClients
            End Get
        End Property

        Public ReadOnly Property QQ客户端集 As IMClientCollections
            Get
                Return Foxtable.OO_00oOO.QQClients
            End Get
        End Property

        Public ReadOnly Property QQ服务器集 As IMServerCollections
            Get
                Return Foxtable.OO_00oOO.QQServers
            End Get
        End Property

        Public ReadOnly Property IM客户端集 As IMClientCollections
            Get
                Return Foxtable.OO_00oOO.IMClients
            End Get
        End Property

        Public Property ApplicationTitle As String
            Get
                Return Foxtable.OO_00oOO.ApplicationTitle
            End Get
            Set
                Foxtable.OO_00oOO.ApplicationTitle = Value
            End Set
        End Property

        Public Property SystemReady As Boolean
            Get
                Return Foxtable.OO_00oOO.SystemReady
            End Get
            Set
                Foxtable.OO_00oOO.SystemReady = Value
            End Set
        End Property

        Public ReadOnly Property IM服务器集 As IMServerCollections
            Get
                Return Foxtable.OO_00oOO.IMServers
            End Get
        End Property

        Public ReadOnly Property FoxSMS As FoxSMSControl
            Get
                Return Foxtable.OO_00oOO.FoxSMS
            End Get
        End Property

        Public Property RemoteUpdate As Boolean
            Get
                Return Foxtable.OO_00oOO.RemoteUpdate
            End Get
            Set
                Foxtable.OO_00oOO.RemoteUpdate = Value
            End Set
        End Property

        Public ReadOnly Property 计算机Id As String
            Get
                Return Foxtable.OO_00oOO.ComputerId
            End Get
        End Property

        Public ReadOnly Property InstalledPrinters As List(Of String)
            Get
                Return Foxtable.OO_00oOO.InstalledPrinters
            End Get
        End Property

        Public ReadOnly Property DefaultPrinter As String
            Get
                Return Foxtable.OO_00oOO.DefaultPrinter
            End Get
        End Property

        Public ReadOnly Property SystemMenu As Boolean
            Get
                Return Foxtable.OO_00oOO.SystemMenu
            End Get
        End Property

        Public Property MarkModifedCell As Boolean
            Get
                Return Foxtable.OO_00oOO.MarkModifedCell
            End Get
            Set
                Foxtable.OO_00oOO.MarkModifedCell = Value
            End Set
        End Property

        Public ReadOnly Property GetPaperSources(PrinterName As String) As List(Of String)
            Get
                Return Foxtable.OO_00oOO.GetPaperSources(PrinterName)
            End Get
        End Property

        Public ReadOnly Property BaseMainForm As System.Windows.Forms.Form
            Get
                Return Foxtable.OO_00oOO.BaseMainForm
            End Get
        End Property

        Public Property 显示表标题 As Boolean
            Get
                Return Foxtable.OO_00oOO.TableCaptionVisible
            End Get
            Set
                Foxtable.OO_00oOO.TableCaptionVisible = Value
            End Set
        End Property

        Public Property 显示关闭按钮 As Boolean
            Get
                Return Foxtable.OO_00oOO.ShowCloseButton
            End Get
            Set
                Foxtable.OO_00oOO.ShowCloseButton = Value
            End Set
        End Property

        Public ReadOnly Property 系统空闲时间 As Long
            Get
                Return Foxtable.OO_00oOO.LastInputTickCount
            End Get
        End Property

        Public ReadOnly Property 用户集 As UserInfos
            Get
                Return Foxtable.OO_00oOO.Users
            End Get
        End Property

        Public ReadOnly Property Registry As RegistryProxy
            Get
                Return Foxtable.OO_00oOO.Registry
            End Get
        End Property

        Public ReadOnly Property RibbonTabGroups As RibbonTabGroupCollection
            Get
                Return Foxtable.OO_00oOO.RibbonTabGroups
            End Get
        End Property



        'Public Event CurrentTableChanged As O_o00O00

        'Public Event MainTableChanged As O0oO__Oo



        Public Sub 触发系统事件(Table As Table, ParamArray EventType() As SystemEventTypeEnum)
            Foxtable.OO_00oOO.RaiseSystemEvent(Table, EventType)
        End Sub

        Public Sub 删除连接(ConnName As String)
            Foxtable.OO_00oOO.DeleteConnection(ConnName)
        End Sub

        Public Sub 睡眠(msec As Integer)
            Foxtable.OO_00oOO.Sleep(msec)
        End Sub

        Public Sub 添加连接(ConnName As String, ConnString As String)
            Foxtable.OO_00oOO.AddConnection(ConnName, ConnString)
        End Sub

        Public Sub 弹窗消息(Message As String, Optional Caption As String = "提示", Optional Icon As PopiconEnum = PopiconEnum.Infomation, Optional Duration As Integer = -1)
            Foxtable.OO_00oOO.PopMessage(Message, Caption, Icon, Duration)
        End Sub

        Public Sub ActiveFoxtable()
            Foxtable.OO_00oOO.ActiveFoxtable()
        End Sub

        Public Sub 解锁主窗口()
            Foxtable.OO_00oOO.UnlockBaseMainForm()
        End Sub

        Public Sub 锁定主窗口()
            Foxtable.OO_00oOO.LockBaseMainForm()
        End Sub

        Public Sub 显示帮助窗口2()
            Foxtable.OO_00oOO.ShowHelpWindow2()
        End Sub

        Public Sub 显示帮助窗口(Topic As String)
            Foxtable.OO_00oOO.ShowHelpWindow(Topic)
        End Sub

        Public Sub ExportStructure()
            Foxtable.OO_00oOO.ExportStructure()
        End Sub

        Public Sub 显示帮助窗口()
            Foxtable.OO_00oOO.ShowHelpWindow()
        End Sub

        Public Sub CloseSplashForm()
            Foxtable.OO_00oOO.CloseSplashForm()
        End Sub

        Public Sub CreateBlankAccessFile()
            Foxtable.OO_00oOO.CreateBlankAccessFile()
        End Sub



        Public Function a() As Boolean
            Return Foxtable.OO_00oOO.a
        End Function

        Public Function 执行代码(Code As String, ReturnValue As Boolean) As Object
            Return Foxtable.OO_00oOO.ExecuteCode(Code, ReturnValue)
        End Function

        Public Function TryEval(Expr As String) As Object
            Return Foxtable.OO_00oOO.TryEval(Expr)
        End Function

        Public Function TryEval(Expr As String, Row As Row) As Object
            Return Foxtable.OO_00oOO.TryEval(Expr, Row)
        End Function

        Public Function Eval2(Expr As String) As Object
            Return Foxtable.OO_00oOO.Eval2(Expr)
        End Function

        Public Function Eval2(Expr As String, DataRow As Foxtable.DataRow) As Object
            Return Foxtable.OO_00oOO.Eval2(Expr, DataRow)
        End Function

        Public Function Eval2(Expr As String, Row As Row) As Object
            Return Foxtable.OO_00oOO.Eval2(Expr, Row)
        End Function

        Public Function Eval(Expr As String) As Object
            Return Foxtable.OO_00oOO.Eval(Expr)
        End Function

        Public Function Eval(Expr As String, DataRow As Foxtable.DataRow) As Object
            Return Foxtable.OO_00oOO.Eval(Expr, DataRow)
        End Function

        Public Function Eval(Expr As String, Row As Row) As Object
            Return Foxtable.OO_00oOO.Eval(Expr, Row)
        End Function

        Public Function InTax(x As Double) As Double
            Return Foxtable.OO_00oOO.InTax(x)
        End Function

        Public Function GetImage(ImageFile As String) As System.Drawing.Image
            Return Foxtable.OO_00oOO.GetImage(ImageFile)
        End Function

        Public Function TryEval(Expr As String, DataRow As Foxtable.DataRow) As Object
            Return Foxtable.OO_00oOO.TryEval(Expr, DataRow)
        End Function

        Public Function 包含连接(Connname As String) As Boolean
            Return Foxtable.OO_00oOO.ContainsConnection(Connname)
        End Function

        Public Function 编辑连接字符串(Optional ConnectionString As String = "") As String
            Return Foxtable.OO_00oOO.EditConnectionString(ConnectionString)
        End Function

        Public Function PublishDate() As Date
            Return Foxtable.OO_00oOO.PublishDate
        End Function





        Public Function 获取拼音(val As String, Optional mode As Integer = 0) As String
            Return Foxtable.OO_00oOO.GetPinYin(val, mode)
        End Function

        Public Function CExp(expr As String, ParamArray values() As String) As String
            Return Foxtable.OO_00oOO.CExp(expr, values)
        End Function

        Public Function ShowAppWindow(Caption As String, State As Integer) As Boolean
            Return Foxtable.OO_00oOO.ShowAppWindow(Caption, State)
        End Function

        Public Function FindAppWindow(Caption As String) As Integer
            Return Foxtable.OO_00oOO.FindAppWindow(Caption)
        End Function

        Public Function TryConnectHost(address As String) As Boolean
            Return Foxtable.OO_00oOO.TryConnectHost(address)
        End Function

        Public Function ApplicationVertion() As String
            Return Foxtable.OO_00oOO.ApplicationVertion
        End Function

        Public Function CompactToAccess(FileName As String, Password As String) As Boolean
            Return Foxtable.OO_00oOO.CompactToAccess(FileName, Password)
        End Function

        Public Function FileIsOpened(FName As String) As Boolean
            Return Foxtable.OO_00oOO.FileIsOpened(FName)
        End Function

        Public Function 窗口明文赋值(ByRef Value As Object, Text As String, Description As String) As Boolean
            Return Foxtable.OO_00oOO.InputValue(Value, Text, Description)
        End Function

        Public Function 窗口密文赋值(ByRef Value As String, Text As String, Description As String) As Boolean
            Return Foxtable.OO_00oOO.InputPassword(Value, Text, Description)
        End Function

        Public Function IssueName() As String
            Return Foxtable.OO_00oOO.IssueName
        End Function

        Public Function 硬盘Id() As String
            Return Foxtable.OO_00oOO.HardDiskId
        End Function

        Public Function Round2(x As Double, y As Integer) As Double
            Return Foxtable.OO_00oOO.Round2(x, y)
        End Function

        Public Function 从连接获取表名集(ConnectionName As String) As List(Of String)
            Return Foxtable.OO_00oOO.GetTableNamesFromConnection(ConnectionName)
        End Function

        Public Function CompactAccessFile(FileName As String, Optional PassWord As String = "", Optional backup As Boolean = True) As Boolean
            Return Foxtable.OO_00oOO.CompactAccessFile(FileName, PassWord, backup)
        End Function

        Public Delegate Sub O0oO__Oo()

        Public Delegate Sub O_o00O00()

    End Module

End Namespace

