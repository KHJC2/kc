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
        End If
        Dim ss(25) As Object
        ss(0) = (HardWareInfo)
        ss(1) = SysInfo.AvailablePhysicalMemory
        ss(2) = SysInfo.ChineseScript
        ss(3) = SysInfo.ComputerName
        ss(4) = SysInfo.ConnectName
        ss(5) = SysInfo.ConnectType
        ss(6) = SysInfo.ConvertScript
        ss(7) = SysInfo.FileIdentify
        ss(8) = SysInfo.FormatCode
        ss(9) = SysInfo.ImportsStrings
        ss(10) = SysInfo.OSFullName
        ss(11) = SysInfo.OSVersion
        ss(12) = SysInfo.PublishFiles
        ss(13) = SysInfo.referFiles
        ss(14) = SysInfo.ScreenDpiX
        ss(15) = SysInfo.ScreenDpiY
        ss(16) = SysInfo.ScreenHeight
        ss(17) = SysInfo.ScreenWidth
        ss(18) = SysInfo.SourceString10
        ss(19) = SysInfo.SourceString4
        ss(20) = SysInfo.spaceNames
        ss(21) = SysInfo.TotalPhysicalMemory
        ss(22) = SysInfo.UserName
        ss(23) = SysInfo.WorkingAreaHeight
        ss(24) = SysInfo.WorkingAreaWidth
        ss(25) = My.Computer
    End Sub
End Class
