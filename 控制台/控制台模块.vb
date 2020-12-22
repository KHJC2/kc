

Module 控制台模块
    Sub Main()
        Dim 人员 As String

        人员 = "当地人若"
        System.Console.WindowTop = 50
    End Sub

    Public Class Sdd
        Public Overrides Function Equals(obj As Object) As Boolean
            Return MyBase.Equals(obj)
        End Function
        Public Function Seer() As Sdd
            Dim b = Me.Equals(New Object)
            Return Nothing
        End Function
    End Class
End Module

