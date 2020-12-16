#Region "程序集 Foxtable, Version=2020.5.29.8, Culture=neutral, PublicKeyToken=null"

' C:\foxtable\Trial\foxtable.exe

#End Region



Imports System.Collections

Imports System.Collections.Generic

Imports Foxtable.WinForm


Imports Foxtable

Public Class 列类型
    Public ReadOnly Property 狐列 As Foxtable.Col
    Public Sub New(狐列参数 As Foxtable.Col)
        Me.狐列 = 狐列参数
    End Sub

    Public ReadOnly Property Index As Integer
        Get
            Return 狐列.Index
        End Get
    End Property

    Public Property GrandTotal As Boolean
        Get
            Return 狐列.GrandTotal
        End Get
        Set
            狐列.GrandTotal = Value
        End Set
    End Property

    Public Property CodeDictonary As Dictionary(Of String, String)
        Get
            Return 狐列.CodeDictonary
        End Get
        Set
            狐列.CodeDictonary = Value
        End Set
    End Property

    Public Property CodeDictionary As Dictionary(Of String, String)
        Get
            Return 狐列.CodeDictionary
        End Get
        Set
            狐列.CodeDictionary = Value
        End Set
    End Property

    Public Property DataMap As IDictionary
        Get
            Return 狐列.DataMap
        End Get
        Set
            狐列.DataMap = Value
        End Set
    End Property

    Public Property ImageMap As IDictionary
        Get
            Return 狐列.ImageMap
        End Get
        Set
            狐列.ImageMap = Value
        End Set
    End Property

    Public Property ComboList As String
        Get
            Return 狐列.ComboList
        End Get
        Set
            狐列.ComboList = Value
        End Set
    End Property

    Public Property AllowDirectType As Boolean
        Get
            Return 狐列.AllowDirectType
        End Get
        Set
            狐列.AllowDirectType = Value
        End Set
    End Property

    Public Property AllowTypeAssistant As Boolean
        Get
            Return 狐列.AllowTypeAssistant
        End Get
        Set
            狐列.AllowTypeAssistant = Value
        End Set
    End Property

    Public Property UsetBuildInEditor As Boolean
        Get
            Return 狐列.UsetBuildInEditor
        End Get
        Set
            狐列.UsetBuildInEditor = Value
        End Set
    End Property

    Public Property ImageAndText As Boolean
        Get
            Return 狐列.ImageAndText
        End Get
        Set
            狐列.ImageAndText = Value
        End Set
    End Property

    Public WriteOnly Property DropTree As BuildInDropTree
        Set
            狐列.DropTree = Value
        End Set
    End Property

    Public Property TextAlign As TextAlignEnum
        Get
            Return 狐列.TextAlign
        End Get
        Set
            狐列.TextAlign = Value
        End Set
    End Property

    Public Property TextAlignFixed As TextAlignEnum
        Get
            Return 狐列.TextAlignFixed
        End Get
        Set
            狐列.TextAlignFixed = Value
        End Set
    End Property

    Public Property Width As Integer
        Get
            Return 狐列.Width
        End Get
        Set
            狐列.Width = Value
        End Set
    End Property

    Public Property PrintWidth As Double
        Get
            Return 狐列.PrintWidth
        End Get
        Set
            狐列.PrintWidth = Value
        End Set
    End Property

    Public Property DropForm As String
        Get
            Return 狐列.DropForm
        End Get
        Set
            狐列.DropForm = Value
        End Set
    End Property

    Public ReadOnly Property DroppedDown As Boolean
        Get
            Return 狐列.DroppedDown
        End Get
    End Property

    Public Property AllowEdit As Boolean
        Get
            Return 狐列.AllowEdit
        End Get
        Set
            狐列.AllowEdit = Value
        End Set
    End Property

    Public Property Visible As Boolean
        Get
            Return 狐列.Visible
        End Get
        Set
            狐列.Visible = Value
        End Set
    End Property

    Public ReadOnly Property PictureViewer As PictureViewer
        Get
            Return 狐列.PictureViewer
        End Get
    End Property

    Public ReadOnly Property Table As Foxtable.Table
        Get
            Return 狐列.Table
        End Get
    End Property

    Public ReadOnly Property DataTable As DataTable
        Get
            Return 狐列.DataTable
        End Get
    End Property

    Public ReadOnly Property DataCol As DataCol
        Get
            Return 狐列.DataCol
        End Get
    End Property

    Public Property ShowInRecordGrid As Boolean
        Get
            Return 狐列.ShowInRecordGrid
        End Get
        Set
            狐列.ShowInRecordGrid = Value
        End Set
    End Property

    Public Property RecordRowHeight As Integer
        Get
            Return 狐列.RecordRowHeight
        End Get
        Set
            狐列.RecordRowHeight = Value
        End Set
    End Property

    Public Property ShortCaption As String
        Get
            Return 狐列.ShortCaption
        End Get
        Set
            狐列.ShortCaption = Value
        End Set
    End Property

    Public Property Caption As String
        Get
            Return 狐列.Caption
        End Get
        Set
            狐列.Caption = Value
        End Set
    End Property

    Public ReadOnly Property Name As String
        Get
            Return 狐列.Name
        End Get
    End Property

    Public ReadOnly Property FileManager As FileManager
        Get
            Return 狐列.FileManager
        End Get
    End Property



    Public Sub ResetAutoCompleteSource()
        狐列.ResetAutoCompleteSource()
    End Sub

    Public Sub OpenWindow(Optional size As Integer = 0)
        狐列.OpenWindow(size)
    End Sub

    Public Sub CloseWindow()
        狐列.CloseWindow()
    End Sub

    Public Sub OpenDropDown()
        狐列.OpenDropDown()
    End Sub

    Public Sub SetDateTimeFormat(fmt As DateTimeFormatEnum)
        狐列.SetDateTimeFormat(fmt)
    End Sub

    Public Sub CloseDropDown()
        狐列.CloseDropDown()
    End Sub

    Public Sub Refresh()
        狐列.Refresh()
    End Sub

    Public Sub Move(IndexNew As Integer)
        狐列.Move(IndexNew)
    End Sub



    Public Function IsBoolean() As Boolean
        Return 狐列.IsBoolean
    End Function

    Public Function IsNumeric() As Boolean
        Return 狐列.IsNumeric
    End Function

    Public Function IsDate() As Boolean
        Return 狐列.IsDate
    End Function

    Public Function IsString() As Boolean
        Return 狐列.IsString
    End Function

End Class


