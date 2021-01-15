Imports Foxtable

Public Class uc1
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
            If 页.Controls.Count = 0 Then
                Forms("m").StopRedraw()
                全局函数.添加表控件到页(Forms("m"), 页)
                Forms("m").ResumeRedraw()
            End If
            If cdt.Name = "cdt主" Then
                DataTables("m_" & 页.Name).LoadFilter = "1 = 1"
                DataTables("m_" & 页.Name).Load(False)
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
        Dim 主表 As Table
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
        Dim 子表 As Table
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
        Dim 子表 As Table
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
