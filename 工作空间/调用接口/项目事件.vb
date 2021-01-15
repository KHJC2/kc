Imports Foxtable
Public Module 项目事件
    Public Sub BeforeConnectOuterDataSource()

    End Sub

    Public Sub BeforeLoadInnerTable()

    End Sub

    Public Sub BeforeLoadOuterTable()
    End Sub

    Public Sub Initialize()

    End Sub

    Public Sub BeforeOpenProject(e As Foxtable.BeforeOpenProjectEventArgs)
        项目事件实现.BeforeOpenProject(e)
    End Sub

    Public Sub MainTableChanging()

    End Sub

    Public Sub MainTableChanged()

    End Sub
    Public Sub CurrentTableChanged()
        项目事件实现.CurrentTableChanged()
    End Sub



    Public Sub AfterOpenProject()
        'Output.Show("<AfterOpenProject>")
        '全局函数.设置系统表列表()
        'Output.Show("</AfterOpenProject>")
    End Sub

    Public Sub LoadUserSetting()

    End Sub

    Public Sub BeforeCloseProject()

    End Sub

    Public Sub SystemIdle()

    End Sub

    Public Sub AfterSaveProject()

    End Sub

    Public Sub BeforeSaveProject()

    End Sub

    Public Sub GlobalVariableChanged()

    End Sub

    Public Sub BeforeShowErrorMessage()

    End Sub

    Public Sub NetworkAvailabilityChanged()

    End Sub

    Public Sub NetworkAddressChanged()

    End Sub

    Public Sub BeforeCloseTable()

    End Sub



End Module
