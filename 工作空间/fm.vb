Public Class fm
    Public Sub New(name As String)

        ' 此调用是设计器所必需的。
        InitializeComponent()
        Me.Name = name
        Me.SetTopLevel(False)
        ' 在 InitializeComponent() 调用之后添加任何初始化。

    End Sub
End Class