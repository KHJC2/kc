#Region "程序集 Foxtable, Version=2020.5.29.8, Culture=neutral, PublicKeyToken=null"

' C:\foxtable\Trial\foxtable.exe

#End Region

Imports Foxtable

Public Class 数据列类
    Public Sub New(狐数据列参数 As Foxtable.DataCol)
        Me.狐数据列 = 狐数据列参数
    End Sub
    Public Property AllowEdit As Boolean
        Get
            Return 狐数据列.AllowEdit
        End Get
        Set
            狐数据列.AllowEdit = Value
        End Set
    End Property
    Public Property AutoComplete As Boolean
        Get
            Return 狐数据列.AutoComplete
        End Get
        Set
            狐数据列.AutoComplete = Value
        End Set
    End Property
    Public Property AutoCopyAttachFile As BooleanEnum
        Get
            Return 狐数据列.AutoCopyAttachFile
        End Get
        Set
            狐数据列.AutoCopyAttachFile = Value
        End Set
    End Property
    Public Property AutoDeleteAttachFile As BooleanEnum
        Get
            Return 狐数据列.AutoDeleteAttachFile
        End Get
        Set
            狐数据列.AutoDeleteAttachFile = Value
        End Set
    End Property
    Public Property Caption As String
        Get
            Return 狐数据列.Caption
        End Get
        Set
            狐数据列.Caption = Value
        End Set
    End Property
    Public ReadOnly Property DataTable As DataTable
        Get
            Return 狐数据列.DataTable
        End Get
    End Property
    Public ReadOnly Property DataType As Type
        Get
            Return 狐数据列.DataType
        End Get
    End Property
    Public Property DateTimeFormat As DateTimeFormatEnum
        Get
            Return 狐数据列.DateTimeFormat
        End Get
        Set
            狐数据列.DateTimeFormat = Value
        End Set
    End Property
    Public Property Decimals As Integer
        Get
            Return 狐数据列.Decimals
        End Get
        Set
            狐数据列.Decimals = Value
        End Set
    End Property
    Public Property DefaultFolder As String
        Get
            Return 狐数据列.DefaultFolder
        End Get
        Set
            狐数据列.DefaultFolder = Value
        End Set
    End Property
    Public Property DefaultValue As String
        Get
            Return 狐数据列.DefaultValue
        End Get
        Set
            狐数据列.DefaultValue = Value
        End Set
    End Property
    Public Property Expression As String
        Get
            Return 狐数据列.Expression
        End Get
        Set
            狐数据列.Expression = Value
        End Set
    End Property
    Public Property ExtendType As ExtendTypeEnum
        Get
            Return 狐数据列.ExtendType
        End Get
        Set
            狐数据列.ExtendType = Value
        End Set
    End Property
    Public Property FileFilter As String
        Get
            Return 狐数据列.FileFilter
        End Get
        Set
            狐数据列.FileFilter = Value
        End Set
    End Property
    Public ReadOnly Property FTPClient As FTPClient
        Get
            Return 狐数据列.FTPClient
        End Get
    End Property
    Public Property ImeMode As BooleanEnum
        Get
            Return 狐数据列.ImeMode
        End Get
        Set
            狐数据列.ImeMode = Value
        End Set
    End Property
    Public ReadOnly Property IsBoolean As Boolean
        Get
            Return 狐数据列.IsBoolean
        End Get
    End Property
    Public ReadOnly Property IsDate As Boolean
        Get
            Return 狐数据列.IsDate
        End Get
    End Property
    Public ReadOnly Property IsNumeric As Boolean
        Get
            Return 狐数据列.IsNumeric
        End Get
    End Property
    Public ReadOnly Property IsString As Boolean
        Get
            Return 狐数据列.IsString
        End Get
    End Property
    Public ReadOnly Property MaxLength As Integer
        Get
            Return 狐数据列.MaxLength
        End Get
    End Property
    Public ReadOnly Property Name As String
        Get
            Return 狐数据列.Name
        End Get
    End Property
    Public ReadOnly Property NumericType As O__oO_O_
        Get
            Return 狐数据列.NumericType
        End Get
    End Property
    Public Property Port As Integer
        Get
            Return 狐数据列.Port
        End Get
        Set
            狐数据列.Port = Value
        End Set
    End Property
    Public Property RecordRowHeight As Integer
        Get
            Return 狐数据列.RecordRowHeight
        End Get
        Set
            狐数据列.RecordRowHeight = Value
        End Set
    End Property
    Public Property Remote As Boolean
        Get
            Return 狐数据列.Remote
        End Get
        Set
            狐数据列.Remote = Value
        End Set
    End Property
    Public Property ShortCaption As String
        Get
            Return 狐数据列.ShortCaption
        End Get
        Set
            狐数据列.ShortCaption = Value
        End Set
    End Property
    Public Property ShowInRecordGrid As BooleanEnum
        Get
            Return 狐数据列.ShowInRecordGrid
        End Get
        Set
            狐数据列.ShowInRecordGrid = Value
        End Set
    End Property
    Public Property SourceFolder As String
        Get
            Return 狐数据列.SourceFolder
        End Get
        Set
            狐数据列.SourceFolder = Value
        End Set
    End Property
    Public Property Unique As Boolean
        Get
            Return 狐数据列.Unique
        End Get
        Set
            狐数据列.Unique = Value
        End Set
    End Property
    Public ReadOnly Property 狐数据列 As Foxtable.DataCol
    Public Sub RaiseDataColChanged(Filter As String)
        狐数据列.RaiseDataColChanged(Filter)
    End Sub

    Public Sub RaiseDataColChanged(dr As DataRow)
        狐数据列.RaiseDataColChanged(dr)
    End Sub

    Public Sub RaiseDataColChanged()
        狐数据列.RaiseDataColChanged()
    End Sub

    Public Sub Recalc(dr As DataRow)
        狐数据列.Recalc(dr)
    End Sub

    Public Sub Recalc()
        狐数据列.Recalc()
    End Sub

    Public Sub SetDateTimeFormat(fmt As DateTimeFormatEnum)
        狐数据列.SetDateTimeFormat(fmt)
    End Sub
    Public Sub SetFormat(fmt As String)
        狐数据列.SetFormat(fmt)
    End Sub
End Class