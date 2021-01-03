Partial Public Class 订单类
    ''' <summary>
    ''' 添加订单明细
    ''' </summary>
    ''' <remarks>添加明细</remarks>
    ''' <returns>订单明细</returns>
    Public Function 添加订单明细() As 壳尘.订单明细类

    End Function

    ''' <summary>
    ''' 添加订单
    ''' </summary>
    ''' <remarks>共享方法</remarks>
    ''' <param name="订单表参数">ddddddee</param>
    ''' <returns>订单</returns>
    Public Shared Function 添加订单(订单表参数 As 订单表类) As 壳尘.订单类
        Return 订单表参数.添加订单()
    End Function
End Class
