Imports System.Windows.Forms
Imports Foxtable
Imports 工作空间

Public Class uc1
    Private Sub 工作表目录树_AfterExpand(sender As Object, e As Windows.Forms.TreeViewEventArgs) Handles 工作表目录树.AfterExpand
        Dim 树 As TreeView = sender
        For Each 节点 As TreeNode In 树.Nodes
            If 节点 IsNot e.Node Then
                节点.Collapse()
            End If
        Next
        e.Node.TreeView.SelectedNode = e.Node.Nodes(旧当前子表名(e.Node.Name))
    End Sub

    Private Sub 工作表目录树_BeforeSelect(sender As Object, e As TreeViewCancelEventArgs) Handles 工作表目录树.BeforeSelect
        Dim 树 As TreeView = sender
        Dim 旧节点 As TreeNode = 树.SelectedNode
        If e.Node IsNot 旧节点 Then
            If e.Node.Name.Split("_").Length = 2 Then
                Dim cdt主 As WinForm.TabControl = Forms("m").Controls("cdt主")
                Dim tabPage1 As WinForm.TabPage = cdt主.TabPages(e.Node.Name.Remove(0, 2))

                If cdt主.SelectedPage.TabIndex <> tabPage1.TabIndex Then
                    cdt主.SelectedPage = tabPage1
                    If cdt主.SelectedPage.TabIndex <> tabPage1.TabIndex Then
                        e.Cancel = True
                    End If
                End If
            End If
            If e.Node.Name.Split("_").Length = 4 Then
                Dim cdt主 As WinForm.TabControl = Forms("m").Controls("cdt主")

                Dim 主表 As Table = Tables("m_" & cdt主.SelectedPage.Name)
                If Not 主表.Focused Then
                    主表.Focus()
                End If

                Dim cdt下 As WinForm.TabControl = Forms("m").Controls("cdt下")
                Dim tabPage As WinForm.TabPage = cdt下.TabPages(e.Node.Name.Remove(0, 2))
                If tabPage Is Nothing Then
                    e.Cancel = True

                Else
                    If cdt下.SelectedPage.TabIndex <> tabPage.TabIndex Then
                        cdt下.SelectedPage = tabPage
                        If cdt下.SelectedPage.TabIndex <> tabPage.TabIndex Then
                            e.Cancel = True
                        End If
                    End If
                End If


            End If
        End If
    End Sub

    Private Sub 工作表目录树_AfterSelect(sender As Object, e As Windows.Forms.TreeViewEventArgs) Handles 工作表目录树.AfterSelect
        If e.Node.Name.Split("_").Length = 2 Then
            e.Node.Expand()
        End If
    End Sub
    Private Sub cdm_QueryEnabledAnchors(sender As Object, e As C1.Win.C1Command.DockingAnchorsEventArgs) Handles cdm.QueryEnabledAnchors
        e.Anchors = C1.Win.C1Command.Anchors.DiamondCenter
    End Sub

    Private Sub cdm_TabPageClosing(sender As Object, e As C1.Win.C1Command.TabPageCancelEventArgs) Handles cdm.TabPageClosing
        If e.TabPage.Parent.Controls.Count = 1 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub cdt_SelectedTabChanged(sender As Object, e As EventArgs) Handles cdt主.SelectedTabChanged, cdt下.SelectedTabChanged
        Dim cdt As C1.Win.C1Command.C1DockingTab = CType(sender, C1.Win.C1Command.C1DockingTab)
        If cdt.Name = "cdt下" OrElse cdt.Name = "cdt主" Then
            Dim 页 = cdt.SelectedTab
            If 页 IsNot Nothing Then
                If 页.Controls.Count = 0 Then
                    Forms("m").StopRedraw()
                    '全局函数.添加表控件到页(Forms("m"), 页)
                    Forms("m").ResumeRedraw()
                End If
                If cdt.Name = "cdt主" Then
                    DataTables("m_" & 页.Name).LoadFilter = "1 = 1"
                    DataTables("m_" & 页.Name).Load(False)
                End If
            End If
        End If
        'Dim ss(25) As Object
        'ss(0) = (HardWareInfo)
        'ss(1) = SysInfo.AvailablePhysicalMemory
        'ss(2) = SysInfo.ChineseScript
        'ss(3) = SysInfo.ComputerName
        'ss(4) = SysInfo.ConnectName
        'ss(5) = SysInfo.ConnectType
        'ss(6) = SysInfo.ConvertScript
        'ss(7) = SysInfo.FileIdentify
        'ss(8) = SysInfo.FormatCode
        'ss(9) = SysInfo.ImportsStrings
        'ss(10) = SysInfo.OSFullName
        'ss(11) = SysInfo.OSVersion
        'ss(12) = SysInfo.PublishFiles
        'ss(13) = SysInfo.referFiles
        'ss(14) = SysInfo.ScreenDpiX
        'ss(15) = SysInfo.ScreenDpiY
        'ss(16) = SysInfo.ScreenHeight
        'ss(17) = SysInfo.ScreenWidth
        'ss(18) = SysInfo.SourceString10
        'ss(19) = SysInfo.SourceString4
        'ss(20) = SysInfo.spaceNames
        'ss(21) = SysInfo.TotalPhysicalMemory
        'ss(22) = SysInfo.UserName
        'ss(23) = SysInfo.WorkingAreaHeight
        'ss(24) = SysInfo.WorkingAreaWidth
        'ss(25) = My.Computer
    End Sub

    Private Sub cdt主_SelectedIndexChanging(sender As Object, e As C1.Win.C1Command.SelectedIndexChangingEventArgs) Handles cdt主.SelectedIndexChanging
        Dim cdt主 As C1.Win.C1Command.C1DockingTab = sender
        Dim 主表 As Table = Nothing
        Dim 主页 As C1.Win.C1Command.C1DockingTabPage = cdt主.SelectedTab
        If 主页 IsNot Nothing Then
            Dim 主表名 As String = "m_" & 主页.Name
            If Tables.Contains(主表名) Then
                主表 = Tables(主表名)
            End If
        End If
        If 主表 IsNot Nothing Then
            If 主表.DataTable.HasChanges Then
                e.Cancel = True
                PopMessage("主表未保存修改", "请保存修改", PopiconEnum.Infomation, 2)
                GoTo lage
            End If
        End If
        Dim cdt下 As C1.Win.C1Command.C1DockingTab = CType(Forms("m").Controls("cdt下"), WinForm.TabControl).BaseControl
        Dim 子表 As Table = Nothing
        Dim 子页 As C1.Win.C1Command.C1DockingTabPage = cdt下.SelectedTab
        If 子页 IsNot Nothing Then
            Dim 子表名 As String = "m_" & 子页.Name
            If Tables.Contains(子表名) Then
                子表 = Tables(子表名)
            End If
        End If
        If 子表 IsNot Nothing Then
            If 子表.DataTable.HasChanges Then
                e.Cancel = True
                PopMessage("子表未保存修改", "请保存修改", PopiconEnum.Infomation, 2)

            End If
        End If
lage:
    End Sub

    Private Sub cdt下_SelectedIndexChanging(sender As Object, e As C1.Win.C1Command.SelectedIndexChangingEventArgs) Handles cdt下.SelectedIndexChanging


        Dim cdt下 As C1.Win.C1Command.C1DockingTab = sender
        Dim 子表 As Table = Nothing
        Dim 子页 As C1.Win.C1Command.C1DockingTabPage = cdt下.SelectedTab
        If 子页 IsNot Nothing Then
            Dim 子表名 As String = "m_" & 子页.Name
            If Tables.Contains(子表名) Then
                子表 = Tables(子表名)
            End If
        End If
        If 子表 IsNot Nothing Then
            If 子表.DataTable.HasChanges Then
                e.Cancel = True
                PopMessage("子表未保存修改", "请保存修改", PopiconEnum.Infomation, 2)

            End If
        End If
    End Sub

    Private Sub cdt主_TabPageClosing(sender As Object, e As C1.Win.C1Command.TabPageCancelEventArgs) Handles cdt主.TabPageClosing
        e.TabPage.Hide()
        e.Cancel = True
    End Sub
End Class
