Imports Foxtable

Public Module 项目事件




    Public Sub BeforeConnectOuterDataSource()

    End Sub

    Public Sub BeforeLoadInnerTable()

    End Sub

    Public Sub BeforeLoadOuterTable()

    End Sub

    Public Sub Initialize()

    End Sub

    Public Sub BeforeOpenProject()

    End Sub

    Public Sub MainTableChanging()

    End Sub

    Public Sub MainTableChanged()

    End Sub
    Public Sub CurrentTableChanged()
        Dim 当前表名 As String = CurrentTable.Name
        Dim 旧当前 As String = 旧当前表名
        Output.Show("<CurrentTableChanged_当前表-" & 当前表名 & ".旧表-" & 旧当前 & ">")
        Dim 窗体m As WinForm.Form = Forms("m")
        If 当前表名 <> 旧当前表名 Then
            旧当前表名 = 当前表名
            If 窗体m.Opened Then

                If 当前表名 Like "m_*" AndAlso 当前表名.Remove(0, 2).Contains("_") = False Then '切换主表 加载显示子表
                    If 当前表名 <> 旧当前主表名 Then
                        旧当前主表名 = 当前表名
                        切换主表(当前表名, 窗体m)
                    End If

                End If

                If 当前表名 Like "m_*" AndAlso 当前表名.Split("_").Length = 4 Then '切换子表
                    Dim 主表名 As String = "m_" & 当前表名.Split("_")(3)
                    If 当前表名 <> 旧当前子表名(主表名) Then
                        旧当前子表名(主表名) = 当前表名
                        切换子表(当前表名, 窗体m)
                    End If
                End If
            End If
        Else
        End If
        Output.Show("</CurrentTableChanged_当前表-" & 当前表名 & ".旧表-" & 旧当前 & ">")
    End Sub

    Public Sub AfterOpenProject()

    End Sub

    Public Sub LoadUserSetting()

    End Sub

    Public Sub BeforeCloseProject()

    End Sub

    Public Sub SystemIdle()

    End Sub

    Public Sub AfterSaveProject()

    End Sub

    Public Sub BeforeSaveProject()

    End Sub

    Public Sub GlobalVariableChanged()

    End Sub

    Public Sub BeforeShowErrorMessage()

    End Sub

    Public Sub NetworkAvailabilityChanged()

    End Sub

    Public Sub NetworkAddressChanged()

    End Sub

    Public Sub BeforeCloseTable()

    End Sub
    Private Sub 切换子表(当前表名 As String, 窗体m As WinForm.Form)
        Output.Show("<切换子表>")
        '旧当前子表名(当前表名.Split("_")(3)) = 当前表名.Remove(0, 2) ''记录主表当前子表
        Dim cdt主 As WinForm.TabControl = 窗体m.Controls("cdt主")
        Dim 主表 As Table = Tables("m_" & cdt主.SelectedPage.Name)
        Dim 加载条件 As String
        Dim 子表名 As String = 当前表名

        If 主表.Current IsNot Nothing Then
            加载条件 = 子表名.Remove(startIndex:=0, count:=2) & " = '" & 主表.Current(ColumnName:=主表.Cols(Index:=0).Name) & "'"
        Else
            加载条件 = "1 = 0"
        End If
        If DataTables(子表名).LoadFilter <> 加载条件 Then
            DataTables(子表名).LoadFilter = 加载条件
            DataTables(子表名).Load(SaveData:=False)
        Else
        End If
        Output.Show("</切换子表>")

    End Sub

    Private Sub 切换主表(当前表名 As String, 窗体m As WinForm.Form)
        Output.Show("<切换主表>")

        窗体m.StopRedraw()
        Dim cdt下 As WinForm.TabControl = 窗体m.Controls("cdt下")
        Dim 主表名 As String = 当前表名
        'Dim 页名 As String = 当前表名.Remove(0, 2)

        If 子表名列表.ContainsKey(主表名) Then
            For Each 子表名 As String In 子表名列表(主表名)
                Dim 列名 As String = 子表名.Remove(0, 2)

                If cdt下.TabPages.Contains(列名) Then
                    cdt下.TabPages(列名).Visible = True
                Else
                    cdt下.TabPages.Add(列名, 列名)
                    '添加表控件(窗体m, 列名, 页)
                    '页.Visible = True
                End If
            Next
            cdt下.Visible = True
            For Each 页 As WinForm.TabPage In cdt下.TabPages
                If 子表名列表(主表名).Contains("m_" & 页.Name) = False Then
                    页.Visible = False
                End If
            Next
            cdt下.SelectedPage = cdt下.TabPages(旧当前子表名(主表名).Remove(0, 2))

            'Forms("m").Controls(ctn.Remove(0,2)).Select
        Else
            cdt下.Visible = False
        End If
        窗体m.ResumeRedraw()
        Output.Show("</切换主表>")
    End Sub

    Public Sub 添加表控件(窗体m As WinForm.Form, 列名 As String, 页 As WinForm.TabPage)
        Dim 表控件 As WinForm.Table = 窗体m.CreateSQLTable(列名, "Select top 1000 * From {" & 列名.Split("_")(0) & "} where 1 = 0 order by sys_id", "ft")
        表控件.Dock = System.Windows.Forms.DockStyle.Fill
        页.AddControl(表控件)
        With 表控件
            .RowHeaderVisible = True
        End With
        Dim grid As C1.Win.C1FlexGrid.C1FlexGrid = 表控件.Table.Grid
        With grid
            '.AllowAddNew = True
            '.AutoSearch = True
            '.AutoSearchDelay = 1000
            .AutoResize = True
            .AllowFiltering = True
        End With
    End Sub
End Module