Public Class UserControl1
    Private Sub C1DockingManager1_TabPageClosed(sender As Object, e As C1.Win.C1Command.TabPageEventArgs) Handles C1DockingManager1.TabPageClosed
        Console.WriteLine("C1DockingManager1_TabPageClosed")
    End Sub
End Class
