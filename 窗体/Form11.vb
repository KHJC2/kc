Public Class Form11
    Private Sub C1DockingManager1_Dragging(sender As Object, e As C1.Win.C1Command.FloatingEventArgs) Handles C1DockingManager1.Dragging
        If e.DockingTabPage.Parent.Controls.Count = 1 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub C1DockingManager1_QueryAllowDrop(sender As Object, e As C1.Win.C1Command.AllowDropEventArgs) Handles C1DockingManager1.QueryAllowDrop
        If e.TargetDockStyle <> DockStyle.Fill Then
            e.Cancel = True
        End If
    End Sub

    Private Sub C1DockingManager1_TabPageClosing(sender As Object, e As C1.Win.C1Command.TabPageCancelEventArgs) Handles C1DockingManager1.TabPageClosing
        If e.TabPage.Parent.Controls.Count = 1 Then
            e.Cancel = True
        End If
    End Sub
End Class