#Region "程序集 Foxtable, Version=2020.5.29.8, Culture=neutral, PublicKeyToken=null"

' C:\foxtable\Trial\foxtable.exe

#End Region


Imports Foxtable.Syscmd

Namespace 狐空间

    Public Module 项目模块

        Public Sub 新建项目()
            Foxtable.Syscmd.Project.Create()
        End Sub

        Public Sub 隐藏表标题()
            Foxtable.Syscmd.Project.HideTableCaption()
        End Sub

        Public Sub ToAccess()
            Foxtable.Syscmd.Project.ToAccess()
        End Sub

        Public Sub 重定向()
            Foxtable.Syscmd.Project.Redirect()
        End Sub

        Public Sub 停止绘制()
            Foxtable.Syscmd.Project.StopRedraw()
        End Sub

        Public Sub 恢复绘制()
            Foxtable.Syscmd.Project.ResumeRedraw()
        End Sub

        Public Sub PublishProject()
            Foxtable.Syscmd.Project.PublishProject()
        End Sub

        Public Sub Variable()
            Foxtable.Syscmd.Project.Variable()
        End Sub

        Public Sub VBCode()
            Foxtable.Syscmd.Project.VBCode()
        End Sub

        Public Sub Refrence()
            Foxtable.Syscmd.Project.Refrence()
        End Sub

        Public Sub ExcelVBCode()
            Foxtable.Syscmd.Project.ExcelVBCode()
        End Sub

        Public Sub SetFileWatcher()
            Foxtable.Syscmd.Project.SetFileWatcher()
        End Sub

        Public Sub SetDeviceWatcher()
            Foxtable.Syscmd.Project.SetDeviceWatcher()
        End Sub

        Public Sub SetPortWatcher()
            Foxtable.Syscmd.Project.SetPortWatcher()
        End Sub

        Public Sub SetSMSWatcher()
            Foxtable.Syscmd.Project.SetSMSWatcher()
        End Sub

        Public Sub SetIMWatcher()
            Foxtable.Syscmd.Project.SetIMWatcher()
        End Sub

        Public Sub ViewCode()
            Foxtable.Syscmd.Project.ViewCode()
        End Sub

        Public Sub ViewStructure()
            Foxtable.Syscmd.Project.ViewStructure()
        End Sub

        Public Sub EditTree()
            Foxtable.Syscmd.Project.EditTree()
        End Sub

        Public Sub QRCode()
            Foxtable.Syscmd.Project.QRCode()
        End Sub

        Public Sub BarCode()
            Foxtable.Syscmd.Project.BarCode()
        End Sub

        Public Sub 更新版本()
            Foxtable.Syscmd.Project.Update()
        End Sub

        Public Sub 打开用户菜单()
            Foxtable.Syscmd.Project.OpenUserMenu()
        End Sub

        Public Sub 打开系统菜单()
            Foxtable.Syscmd.Project.OpenSystemMenu()
        End Sub

        Public Sub Version()
            Foxtable.Syscmd.Project.Version()
        End Sub

        Public Sub UpdateFoxTable()
            Foxtable.Syscmd.Project.UpdateFoxTable()
        End Sub

        Public Sub SetUKey()
            Foxtable.Syscmd.Project.SetUKey()
        End Sub

        Public Sub NewExcelTemplate()
            Foxtable.Syscmd.Project.NewExcelTemplate()
        End Sub

        Public Sub OpenExcelTemplate()
            Foxtable.Syscmd.Project.OpenExcelTemplate()
        End Sub

        Public Sub NewWordTemplate()
            Foxtable.Syscmd.Project.NewWordTemplate()
        End Sub

        Public Sub 显示表标题()
            Foxtable.Syscmd.Project.ShowTableCaption()
        End Sub

        Public Sub OpenWordTemplate()
            Foxtable.Syscmd.Project.OpenWordTemplate()
        End Sub

        Public Sub ModiProjectInfo()
            Foxtable.Syscmd.Project.ModiProjectInfo()
        End Sub

        Public Sub 窗口设计()
            Foxtable.Syscmd.Project.FormDesigner()
        End Sub

        Public Sub 打开项目()
            Foxtable.Syscmd.Project.Open()
        End Sub

        Public Sub OpenCaseStudy()
            Foxtable.Syscmd.Project.OpenCaseStudy()
        End Sub

        Public Sub ModifyProperty()
            Foxtable.Syscmd.Project.ModifyProperty()
        End Sub

        Public Sub Compact(Optional ShowMessage As Boolean = True)
            Foxtable.Syscmd.Project.Compact(ShowMessage)
        End Sub

        Public Sub 备份项目(Optional Path As String = "", Optional Auto As Boolean = False)
            Foxtable.Syscmd.Project.Backup(Path, Auto)
        End Sub

        Public Sub 保存项目()
            Foxtable.Syscmd.Project.Save()
        End Sub

        Public Sub 另存项目()
            Foxtable.Syscmd.Project.SaveAs()
        End Sub

        Public Sub 退出项目()
            Foxtable.Syscmd.Project.[Exit]()
        End Sub

        Public Sub 退出项目(blnSave As Boolean)
            Foxtable.Syscmd.Project.[Exit](blnSave)
        End Sub

        Public Sub DesignRibbonMenu()
            Foxtable.Syscmd.Project.DesignRibbonMenu()
        End Sub

        Public Sub ModifyOuterDataSource()
            Foxtable.Syscmd.Project.ModifyOuterDataSource()
        End Sub

        Public Sub Import()
            Foxtable.Syscmd.Project.Import()
        End Sub

        Public Sub MainFormDesigner()
            Foxtable.Syscmd.Project.MainFormDesigner()
        End Sub

        Public Sub ImportFromText()
            Foxtable.Syscmd.Project.ImportFromText()
        End Sub

        Public Sub ImportFromXML()
            Foxtable.Syscmd.Project.ImportFromXML()
        End Sub

        Public Sub Export()
            Foxtable.Syscmd.Project.Export()
        End Sub

        Public Sub Initialize()
            Foxtable.Syscmd.Project.Initialize()
        End Sub

        Public Sub EditMyTimers()
            Foxtable.Syscmd.Project.EditMyTimers()
        End Sub

        Public Sub 重载项目()
            Foxtable.Syscmd.Project.Load()
        End Sub

        Public Sub 刷新()
            Foxtable.Syscmd.Project.Refresh()
        End Sub

        Public Sub FunctionManager()
            Foxtable.Syscmd.Project.FunctionManager()
        End Sub

        Public Sub QuickImport()
            Foxtable.Syscmd.Project.QuickImport()
        End Sub

        Public Sub ExecuteSQL()
            Foxtable.Syscmd.Project.ExecuteSQL()
        End Sub

        Public Sub SwitchUser()
            Foxtable.Syscmd.Project.SwitchUser()
        End Sub

        Public Sub Users()
            Foxtable.Syscmd.Project.Users()
        End Sub

        Public Sub QuickExport()
            Foxtable.Syscmd.Project.QuickExport()
        End Sub

        Public Sub ExportToExcel()
            Foxtable.Syscmd.Project.ExportToExcel()
        End Sub

        Public Sub ExportToAccess()
            Foxtable.Syscmd.Project.ExportToAccess()
        End Sub

        Public Sub 命令窗口()
            Foxtable.Syscmd.Project.CommandWindow()
        End Sub

        Public Sub Options()
            Foxtable.Syscmd.Project.Options()
        End Sub



        Public Function 更新版本(Prom1 As Boolean, Prom2 As Boolean) As Boolean
            Return Foxtable.Syscmd.Project.Update(Prom1, Prom2)
        End Function

        Public Function 打开项目(FileName As String, ParamArray args() As String) As Boolean
            Return Foxtable.Syscmd.Project.Open(FileName, args)
        End Function

    End Module

End Namespace

