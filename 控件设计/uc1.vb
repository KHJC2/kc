Imports Foxtable
Imports 工作空间

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
        If cdt.Name = "cdt下" Then
            Dim 页 = cdt.SelectedTab
            If 页.Controls.Count = 0 Then
                Forms("m").StopRedraw()
                全局函数.添加表控件到页(Forms("m"), 页)
                Forms("m").ResumeRedraw()

            End If
        End If
    End Sub
End Class
