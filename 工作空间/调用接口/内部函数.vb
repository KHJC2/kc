Imports System.Windows.Forms
Imports Foxtable

Public Module 内部函数

    Public Sub 设置系统表列表()
        全局函数.设置系统表列表()
    End Sub
    Public Sub 本地时间监控(间隔 As Integer)
        全局函数.本地时间监控(间隔)
    End Sub
    Public Sub 有更改行监控()
        全局函数.有更改行监控()
    End Sub
    Public Sub 修改表名(原表名 As String, 新表名 As String)
        If 系统表列表.ContainsKey(原表名) Then
            Dim sql As String = "EXEC ft20200811.sys.sp_rename N'ft20200811.dbo.(原表名)' , N'(新表名)', 'OBJECT'"
            Dim sql1 As String = "EXEC ft20200811.sys.sp_rename N'ft20200811.dbo.(表名).(原列名)' , N'(新列名)', 'COLUMN'"
            Dim sc As New SQLCommand With {.ConnectionName = "ft"}
            Dim kb As Boolean = True
            Try
                sc.BeginTransaction()
                If 子表名列表.ContainsKey("m_" & 原表名) Then
                    For Each 子表名 As String In 子表名列表("m_" & 原表名)
                        Dim 引用原列名 As String = 子表名.Remove(0, 2)
                        Dim 引用表名 As String = 引用原列名.Split("_")(0)
                        Dim 新列名 As String = 引用原列名.Remove(引用原列名.Length - 原表名.Length, 原表名.Length) & 新表名
                        sc.CommandText = sql1.Replace("(表名)", 引用表名).Replace("(原列名)", 引用原列名).Replace("(新列名)", 新列名)
                        'Output.Show(sc.CommandText)
                        sc.ExecuteNonQuery()
                    Next
                End If

                For Each 列 As DataCol In 系统表列表(原表名).DataCols
                    If 列.Name.StartsWith(原表名) Then
                        Dim 原列名 As String = 列.Name
                        Dim 新列名 As String = 新表名 & 原列名.Remove(0, 原表名.Length)
                        sc.CommandText = sql1.Replace("(表名)", 原表名).Replace("(原列名)", 原列名).Replace("(新列名)", 新列名)
                        'Output.Show(sc.CommandText)
                        sc.ExecuteNonQuery()
                    End If
                Next
                sc.CommandText = sql.Replace("(原表名)", 原表名).Replace("(新表名)", 新表名)
                'Output.Show(sc.CommandText)
                sc.ExecuteNonQuery()

                sc.Commit()
            Catch ex As Exception
                sc.Rollback()
                kb = False
                Windows.Forms.MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            If kb Then
                Windows.Forms.MessageBox.Show("操作成功,即将重启项目", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                System.Diagnostics.Process.Start(ProjectFile)
                Syscmd.Project.Exit(False)
            End If

        End If

    End Sub
End Module

