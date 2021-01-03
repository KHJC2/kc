Partial Public Class 订单表类
    Implements 表接口
    Public Sub New(表参数 As 表类)
        Me._表 = 表参数
    End Sub
    Public ReadOnly Property 表 As 表类 Implements 表接口.表
        Get
            Return _表
        End Get
    End Property
    Private ReadOnly _表 As 表类
End Class
