#Region "程序集 Foxtable, Version=2020.5.29.8, Culture=neutral, PublicKeyToken=null"

' C:\foxtable\Trial\foxtable.exe

#End Region




Imports Foxtable
Imports Foxtable.Syscmd

Namespace 狐空间

    Public Module 列模块

        Public Sub InsertDataColumn()
            Foxtable.Syscmd.Column.InsertDataColumn()
        End Sub

        Public Sub GetAllValue()
            Foxtable.Syscmd.Column.GetAllValue()
        End Sub

        Public Sub ChangeTextAlign(Align As TextAlignEnum)
            Foxtable.Syscmd.Column.ChangeTextAlign(Align)
        End Sub

        Public Sub Width()
            Foxtable.Syscmd.Column.Width()
        End Sub

        Public Sub ModifyProperty()
            Foxtable.Syscmd.Column.ModifyProperty()
        End Sub

        Public Sub UnFreeze()
            Foxtable.Syscmd.Column.UnFreeze()
        End Sub

        Public Sub Freeze()
            Foxtable.Syscmd.Column.Freeze()
        End Sub

        Public Sub UnHide()
            Foxtable.Syscmd.Column.UnHide()
        End Sub

        Public Sub Hide()
            Foxtable.Syscmd.Column.Hide()
        End Sub

        Public Sub MoveRight()
            Foxtable.Syscmd.Column.MoveRight()
        End Sub

        Public Sub MoveLeft()
            Foxtable.Syscmd.Column.MoveLeft()
        End Sub

        Public Sub UnLock()
            Foxtable.Syscmd.Column.UnLock()
        End Sub

        Public Sub Lock()
            Foxtable.Syscmd.Column.Lock()
        End Sub

        Public Sub Rename()
            Foxtable.Syscmd.Column.Rename()
        End Sub

        Public Sub Modify()
            Foxtable.Syscmd.Column.Modify()
        End Sub

        Public Sub ChangeType()
            Foxtable.Syscmd.Column.ChangeType()
        End Sub

        Public Sub Delete()
            Foxtable.Syscmd.Column.Delete()
        End Sub

        Public Sub EditExpression()
            Foxtable.Syscmd.Column.EditExpression()
        End Sub

        Public Sub EditGetValueCode()
            Foxtable.Syscmd.Column.EditGetValueCode()
        End Sub

        Public Sub AddExpressionColumn()
            Foxtable.Syscmd.Column.AddExpressionColumn()
        End Sub

        Public Sub InsertExpressionColumn()
            Foxtable.Syscmd.Column.InsertExpressionColumn()
        End Sub

        Public Sub AddDataColumn()
            Foxtable.Syscmd.Column.AddDataColumn()
        End Sub

        Public Sub DataToExp()
            Foxtable.Syscmd.Column.DataToExp()
        End Sub

        Public Sub ExpToData()
            Foxtable.Syscmd.Column.ExpToData()
        End Sub

    End Module

End Namespace

