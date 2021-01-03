Imports Foxtable

Public Module 全局表事件
    Public Sub CurrentChanged(e As Foxtable.TableEventArgs)
        Dim 当前行id As Integer '当前行id
        Dim 旧行ID As Integer '旧行ID
        Dim 当前行 As Row = e.Table.Current '当前行
        If 当前行 IsNot Nothing Then
            当前行id = 当前行.DataRow("_Identify")
        Else
            当前行id = -1
        End If
        If 旧当前行.ContainsKey(e.Table.Name) = False Then
            旧当前行.Add(e.Table.Name, Nothing)
        Else
        End If
        If 旧当前行(e.Table.Name) IsNot Nothing Then
            If 旧当前行(e.Table.Name).DataRow.RowState = 1 OrElse 旧当前行(e.Table.Name).DataRow.RowState = 8 Then
                旧行ID = -2
            Else
                旧行ID = 旧当前行(e.Table.Name).DataRow("_Identify")
            End If
        Else
            旧行ID = -1
        End If
        Output.Show("CurrentChanged开始,表:" & e.Table.Name & ",行:" & 当前行id & "旧行:" & 旧行ID)


        If 当前行id <> 旧行ID Then
            旧当前行(e.Table.Name) = 当前行 '设置旧当前行
            If e.Table.Name Like "m_*" AndAlso e.Table.Name.Remove(0, 2).Contains("_") = False Then '主表切换行
                Output.Show("主表切换行")
                主表切换行(e)
            Else
            End If
        Else
        End If

        Output.Show("CurrentChanged结束,表:" & e.Table.Name & ",行:" & 当前行id)
    End Sub

    Private Sub 主表切换行(e As TableEventArgs)

        Dim 当前行 As Row = e.Table.Current '当前行
        Dim 子表名 As String = CStr("m_" & Forms("m").Controls("cdt下").SelectedPage.Name)
        Dim 子表 As Table = Tables(子表名)
        '<子表加载对应数据>
        If 当前行 IsNot Nothing Then
            子表.DataTable.LoadFilter = 子表名.Remove(0, 2) & " = '" & 当前行(e.Table.Cols(0).Name) & "'"
        Else
            子表.DataTable.LoadFilter = "1 = 0"
        End If
        子表.DataTable.Load(False)
        '</子表加载对应数据>
    End Sub
End Module

