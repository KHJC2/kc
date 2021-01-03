Public Module 窗体m的三方事件 '三方控件事件代码
    Public Sub C1DockingManager1_Dragging(sender As Object, e As C1.Win.C1Command.FloatingEventArgs)
        If e.DockingTabPage.Parent.Controls.Count = 1 Then
            e.Cancel = True
        End If
    End Sub

    Public Sub C1DockingManager1_QueryAllowDrop(sender As Object, e As C1.Win.C1Command.AllowDropEventArgs)
        If e.TargetDockStyle <> System.Windows.Forms.DockStyle.Fill Then
            e.Cancel = True
        End If
        'Output.Show("QueryAllowDrop")
    End Sub

    Public Sub C1DockingManager1_TabPageClosing(sender As Object, e As C1.Win.C1Command.TabPageCancelEventArgs)
        'Output.Show(e.TabPage.Parent.Controls.Count )
        'If e.TabPage.Parent.Controls.Count = 1 Then
        e.Cancel = True
        'End If
        'Output.Show("TabPageClosing")

    End Sub
    Public Sub cdt主_SelectedTabChanged(sender As Object, e As EventArgs)
        Dim ss As C1.Win.C1Command.C1DockingTab = sender
        If ss.SelectedTab IsNot Nothing Then
            If ss.SelectedTab.Controls.Count <> 0 Then
                ss.SelectedTab.Controls(0).Select()
            End If
        End If
    End Sub
End Module

