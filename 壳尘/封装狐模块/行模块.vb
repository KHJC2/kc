#Region "程序集 Foxtable, Version=2020.5.29.8, Culture=neutral, PublicKeyToken=null"

' C:\foxtable\Trial\foxtable.exe

#End Region


Imports Foxtable.Syscmd

Namespace 狐空间

    Public Module 行模块

        Public Sub 新增一行()
            Foxtable.Syscmd.Row.AddNew()
        End Sub

        Public Sub 新增多行(Optional Rows As Integer = -1)
            Foxtable.Syscmd.Row.AddNews(Rows)
        End Sub

        Public Sub 克隆行()
            Foxtable.Syscmd.Row.Clone()
        End Sub

        Public Sub 插入行()
            Foxtable.Syscmd.Row.Insert()
        End Sub

        Public Sub 删除行()
            Foxtable.Syscmd.Row.Delete()
        End Sub

        Public Sub 锁定行()
            Foxtable.Syscmd.Row.Lock()
        End Sub

        Public Sub 解锁行()
            Foxtable.Syscmd.Row.UnLock()
        End Sub

        Public Sub 行高()
            Foxtable.Syscmd.Row.Height()
        End Sub

        Public Sub 刷新行()
            Foxtable.Syscmd.Row.Refresh()
        End Sub

        Public Sub 重载行()
            Foxtable.Syscmd.Row.Load()
        End Sub

        Public Sub 隐藏未选定行()
            Foxtable.Syscmd.Row.HideUnSelectedRows()
        End Sub

        Public Sub 隐藏选定行()
            Foxtable.Syscmd.Row.HideSelectedRows()
        End Sub

        Public Sub 显示隐藏行()
            Foxtable.Syscmd.Row.ShowHideRows()
        End Sub

        Public Sub 上移行()
            Foxtable.Syscmd.Row.MoveUp()
        End Sub

        Public Sub 下移行()
            Foxtable.Syscmd.Row.MoveDown()
        End Sub

    End Module

End Namespace

