Public Module 壳模块
    Public Function 获取对象(datarow As Foxtable.DataRow) As 数据行接口
        Dim 数据行 As 数据行接口 = New 人员类型(New 数据行类型(datarow))
        Return 数据行
    End Function
End Module



