Imports System.Windows.Forms
Imports Foxtable

Public Class uc1
    Private Sub 工作表目录树_AfterExpand(sender As Object, e As Windows.Forms.TreeViewEventArgs) Handles 工作表目录树.AfterExpand
        If e.Node.TreeView.SelectedNode IsNot Nothing Then
            If e.Node.TreeView.SelectedNode.Index = e.Node.Nodes(旧当前子表名(e.Node.Name)).Index Then
                e.Node.TreeView.SelectedNode = e.Node.Nodes(旧当前子表名(e.Node.Name))
            End If
        End If
    End Sub

    Private Sub 工作表目录树_BeforeSelect(sender As Object, e As TreeViewCancelEventArgs) Handles 工作表目录树.BeforeSelect
        Dim 树 As TreeView = sender
        Dim 旧节点 As TreeNode = 树.SelectedNode
        If e.Node IsNot 旧节点 Then
            If e.Node.Name.Split("_").Length = 2 Then

                'Dim cdt主 As WinForm.TabControl = Forms("m").Controls("cdt主")
                'Dim cdt替 As WinForm.TabControl = Forms("m").Controls("cdt替")
                Dim 主页 As C1.Win.C1Command.C1DockingTabPage = cdt主.TabPages(e.Node.Name.Remove(0, 2))
                Dim 替页 As C1.Win.C1Command.C1DockingTabPage = cdt替.TabPages(e.Node.Name.Remove(0, 2))
                If 主页 Is Nothing Then
                    替页.Parent = cdt主
                    主页 = cdt主.TabPages(e.Node.Name.Remove(0, 2))
                End If
                If 主页 IsNot Nothing Then
                    If cdt主.SelectedTab IsNot 主页 Then
                        cdt主.SelectedTab = 主页
                        If cdt主.SelectedTab IsNot 主页 Then
                            e.Cancel = True
                        Else
                            Dim 主表 As Table = Tables("m_" & cdt主.SelectedTab.Name)
                            If Not 主表.Focused Then
                                主表.Focus()
                            End If
                        End If
                    End If
                Else
                    e.Cancel = True
                End If
            End If
            If e.Node.Name.Split("_").Length = 4 Then
                'Dim cdt主 As WinForm.TabControl = Forms("m").Controls("cdt主")
                If cdt主.SelectedTab IsNot Nothing Then
                    Dim 主表 As Table = Tables("m_" & cdt主.SelectedTab.Name)
                    If 主表 IsNot Nothing Then
                        If Not 主表.Focused Then
                            主表.Focus()
                        End If
                    End If
                Else
                    Dim 主页 As C1.Win.C1Command.C1DockingTabPage = cdt主.TabPages(e.Node.Name.Split("_")(3))
                    Dim 替页 As C1.Win.C1Command.C1DockingTabPage = cdt替.TabPages(e.Node.Name.Split("_")(3))
                    If 主页 Is Nothing AndAlso 替页 IsNot Nothing Then
                        替页.Parent = cdt主
                        主页 = cdt主.TabPages(e.Node.Name.Remove(0, 2))
                    End If
                    If 主页 IsNot Nothing Then
                        If cdt主.SelectedTab IsNot 主页 Then
                            cdt主.SelectedTab = 主页
                            If cdt主.SelectedTab IsNot 主页 Then
                                e.Cancel = True
                            Else
                                Dim 主表 As Table = Tables("m_" & cdt主.SelectedTab.Name)
                                If 主表 IsNot Nothing Then
                                    If Not 主表.Focused Then
                                        主表.Focus()
                                    End If
                                End If
                            End If
                        End If
                    Else
                        e.Cancel = True
                    End If
                    'e.Cancel = True
                End If

                    'Dim cdt下 As WinForm.TabControl = Forms("m").Controls("cdt下")
                    Dim 子页 As C1.Win.C1Command.C1DockingTabPage = cdt下.TabPages(e.Node.Name.Remove(0, 2))
                    If 子页 Is Nothing Then
                        e.Cancel = True
                    End If
                'If cdt下.SelectedTab Is Nothing Then
                '    e.Cancel = True
                'End If
                cdt下.Visible = True
                If e.Cancel <> True Then
                        If cdt下.SelectedTab IsNot 子页 Then
                            cdt下.SelectedTab = 子页
                        If cdt下.SelectedTab IsNot 子页 Then
                            e.Cancel = True
                        Else
                            'Dim 子表 As Table = Tables("m_" & cdt下.SelectedTab.Name)
                            'If 子表 IsNot Nothing Then
                            '    If Not 子表.Focused Then
                            '        子表.Focus()
                            '    End If
                            'End If
                        End If
                        End If
                    End If
                End If

            End If
    End Sub

    Private Sub 工作表目录树_AfterSelect(sender As Object, e As Windows.Forms.TreeViewEventArgs) Handles 工作表目录树.AfterSelect
        If e.Node.Name.Split("_").Length = 2 Then
            Dim 树 As TreeView = sender
            If Not e.Node.IsExpanded Then
                e.Node.Expand()
            End If
            For Each 节点 As TreeNode In 树.Nodes
                If 节点 IsNot Nothing Then
                    If 节点 IsNot e.Node Then
                        If 节点.IsExpanded Then
                            节点.Collapse()
                        End If
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub cdm_QueryEnabledAnchors(sender As Object, e As C1.Win.C1Command.DockingAnchorsEventArgs) Handles cdm.QueryEnabledAnchors
        e.Anchors = C1.Win.C1Command.Anchors.DiamondCenter
    End Sub

    Private Sub cdm_TabPageClosing(sender As Object, e As C1.Win.C1Command.TabPageCancelEventArgs) Handles cdm.TabPageClosing
        If e.TabPage.Parent.Controls.Count <= 1 Then
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
                    全局函数.添加表控件到页(Forms("m"), 页)
                    Forms("m").ResumeRedraw()
                End If
                If cdt.Name = "cdt主" Then
                    DataTables("m_" & 页.Name).LoadFilter = "1 = 1"
                    DataTables("m_" & 页.Name).LoadPage = DataTables("m_" & 页.Name).TotalPages - 1
                    DataTables("m_" & 页.Name).Load(False)
                End If
                If Tables.Contains("m_" & 页.Name) Then
                    If Not Tables("m_" & 页.Name).Focused Then
                        Tables("m_" & 页.Name).Focus()
                    End If
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
    Private Sub cdt主_TabPageClosing(sender As Object, e As C1.Win.C1Command.TabPageCancelEventArgs) Handles cdt主.TabPageClosing
        'Dim cdt主 As C1.Win.C1Command.C1DockingTab = sender
        Dim 主表 As Table = Nothing
        Dim 主页 As C1.Win.C1Command.C1DockingTabPage = cdt主.SelectedTab
        Dim he As Boolean = False
        If 主页 IsNot Nothing Then
            Dim 主表名 As String = "m_" & 主页.Name
            If Tables.Contains(主表名) Then
                主表 = Tables(主表名)
            End If
        End If
        If 主表 IsNot Nothing Then
            If 主表.DataTable.HasChanges Then
                he = True
                PopMessage("主表未保存修改", "请保存修改", PopiconEnum.Infomation, 2)
                GoTo lage
            End If
        End If
        'Dim cdt下 As C1.Win.C1Command.C1DockingTab = CType(Forms("m").Controls("cdt下"), WinForm.TabControl).BaseControl
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
                he = True
                PopMessage("子表未保存修改", "请保存修改", PopiconEnum.Infomation, 2)
            End If
        End If
lage:
        If Not he Then
            e.TabPage.Parent = cdt替
        End If
        If cdt主.TabPages.Count = 0 Then
            cdt下.Visible = False
        End If
        e.Cancel = True
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
End Class
