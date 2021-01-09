Imports Foxtable

Public Module 内部函数

    Public Sub 设置系统表列表()
        Dim 连接 As Connection = Connections("ft")
        Dim 查询字符串 As String = "Select top 200 * From {表名} Where 1 = 0 order by sys_id"
        For Each 表名 As String In 连接.GetTableNames
            If 表名 <> "sysdiagrams" AndAlso Not 全局变量.系统表列表.ContainsKey(表名) Then
                全局变量.系统表列表.Add(表名, New SQLCommand() With {.ConnectionName = "ft", .CommandText = 查询字符串.Replace("表名", 表名)}.ExecuteReader(True))
            End If
        Next
    End Sub


End Module

