Public Class grid
    Private Sub grid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“Ft20200811DataSet.仓库”中。您可以根据需要移动或删除它。
        Me.仓库TableAdapter.Fill(Me.Ft20200811DataSet.仓库)

    End Sub
End Class