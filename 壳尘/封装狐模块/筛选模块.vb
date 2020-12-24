#Region "程序集 Foxtable, Version=2020.5.29.8, Culture=neutral, PublicKeyToken=null"
' C:\foxtable\Trial\foxtable.exe
#End Region
Imports Foxtable
Namespace 狐空间
    Public Module 筛选模块
        Public Sub [Like]()
            Foxtable.Syscmd.Filter.[Like]()
        End Sub
        Public Sub Advanced()
            Foxtable.Syscmd.Filter.Advanced()
        End Sub
        Public Sub Between()
            Foxtable.Syscmd.Filter.Between()
        End Sub
        Public Sub Contains()
            Foxtable.Syscmd.Filter.Contains()
        End Sub
        Public Sub EndsWith()
            Foxtable.Syscmd.Filter.EndsWith()
        End Sub
        Public Sub Equal(Optional Current As Boolean = True)
            Foxtable.Syscmd.Filter.Equal(Current)
        End Sub
        Public Sub Expression()
            Foxtable.Syscmd.Filter.Expression()
        End Sub
        Public Sub FilterBoolean(Value As Boolean)
            Foxtable.Syscmd.Filter.FilterBoolean(Value)
        End Sub
        Public Sub FilterByMonth(M As Integer)
            Foxtable.Syscmd.Filter.FilterByMonth(M)
        End Sub
        Public Sub FilterByQuarter(Q As Integer)
            Foxtable.Syscmd.Filter.FilterByQuarter(Q)
        End Sub
        Public Sub HideSameValues()
            Foxtable.Syscmd.Filter.HideSameValues()
        End Sub
        Public Sub LessThan(Optional Current As Boolean = True)
            Foxtable.Syscmd.Filter.LessThan(Current)
        End Sub
        Public Sub LockStatusFilter(Value As Boolean)
            Foxtable.Syscmd.Filter.LockStatusFilter(Value)
        End Sub
        Public Sub MoreThan(Optional Current As Boolean = True)
            Foxtable.Syscmd.Filter.MoreThan(Current)
        End Sub
        Public Sub NotBetween()
            Foxtable.Syscmd.Filter.NotBetween()
        End Sub
        Public Sub NotContains()
            Foxtable.Syscmd.Filter.NotContains()
        End Sub
        Public Sub NotEndsWith()
            Foxtable.Syscmd.Filter.NotEndsWith()
        End Sub
        Public Sub NotLessThan(Optional Current As Boolean = True)
            Foxtable.Syscmd.Filter.NotLessThan(Current)
        End Sub
        Public Sub NotLike()
            Foxtable.Syscmd.Filter.NotLike()
        End Sub
        Public Sub NotMoreThan(Optional Current As Boolean = True)
            Foxtable.Syscmd.Filter.NotMoreThan(Current)
        End Sub
        Public Sub NotNull()
            Foxtable.Syscmd.Filter.NotNull()
        End Sub
        Public Sub NotStartsWith()
            Foxtable.Syscmd.Filter.NotStartsWith()
        End Sub
        Public Sub Null()
            Foxtable.Syscmd.Filter.Null()
        End Sub
        Public Sub RelationFilter()
            Foxtable.Syscmd.Filter.RelationFilter()
        End Sub
        Public Sub SameDay()
            Foxtable.Syscmd.Filter.SameDay()
        End Sub
        Public Sub SameHour()
            Foxtable.Syscmd.Filter.SameHour()
        End Sub
        Public Sub SameMinute()
            Foxtable.Syscmd.Filter.SameMinute()
        End Sub
        Public Sub SameMonth()
            Foxtable.Syscmd.Filter.SameMonth()
        End Sub
        Public Sub SameQuarter()
            Foxtable.Syscmd.Filter.SameQuarter()
        End Sub
        Public Sub SameSecond()
            Foxtable.Syscmd.Filter.SameSecond()
        End Sub
        Public Sub SameWeek()
            Foxtable.Syscmd.Filter.SameWeek()
        End Sub
        Public Sub SameYear()
            Foxtable.Syscmd.Filter.SameYear()
        End Sub
        Public Sub ShowRedundantValues()
            Foxtable.Syscmd.Filter.ShowRedundantValues()
        End Sub
        Public Sub ShowSameValues()
            Foxtable.Syscmd.Filter.ShowSameValues()
        End Sub
        Public Sub ShowUnqiueValues()
            Foxtable.Syscmd.Filter.ShowUnqiueValues()
        End Sub
        Public Sub StartsWith()
            Foxtable.Syscmd.Filter.StartsWith()
        End Sub
        Public Sub StateFilter(Value As StateFilterEnum)
            Foxtable.Syscmd.Filter.StateFilter(Value)
        End Sub
        Public Sub Unequal(Optional Current As Boolean = True)
            Foxtable.Syscmd.Filter.Unequal(Current)
        End Sub
        Public Sub UnFilter()
            Foxtable.Syscmd.Filter.UnFilter()
        End Sub
        Public Sub Values()
            Foxtable.Syscmd.Filter.Values()
        End Sub
    End Module
End Namespace