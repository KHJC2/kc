Imports Foxtable

Public Module 窗体事件
#Region "窗体m"
    Public Sub AfterLoad(e As Foxtable.FormEventArgs)

        'Windows 窗体设计器所必需的
        For Each tb As Table In Tables
            tb.Grid.AllowFiltering = True
        Next

        初始化窗体m(e)
        布局控件(e)
        打印已废弃的表设计()
        设置子表列表()
        For Each 主表 As String In 子表名列表.Keys '主表关联列字典排序
            子表名列表(主表).Sort()
            If 旧当前子表名.ContainsKey(主表) = False Then '设置旧当前子表
                旧当前子表名.Add(主表, 子表名列表(主表)(0))
            End If
        Next

    End Sub

    Private Sub 设置子表列表()
        For Each dt As DataTable In DataTables '将 关联列 添加到 主表关联列字典
            If dt.Name Like "m_*" AndAlso dt.Name.Remove(0, 2).Contains("_") = False Then
                For Each dc As DataCol In dt.DataCols
                    Dim dcc() As String = dc.Name.Split("_")
                    If dcc.Length = 3 Then
                        If DataTables.Contains("m_" & dcc(2)) Then
                            If 子表名列表.ContainsKey(dcc(2)) = False Then
                                子表名列表.Add(dcc(2), New List(Of String))
                            End If
                            Dim fkl As List(Of String) = 子表名列表(dcc(2))
                            If fkl.Contains(dc.Name) = False Then
                                fkl.Add(dc.Name)
                            End If
                        Else
                            Output.Show("关联列:" & dc.Name & "命名错误" & vbCrLf & "或者主表未完全加载")
                        End If
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub 打印已废弃的表设计()
        For Each 控件 As WinForm.Control In Forms("m").Controls
            If 控件.GetType.FullName = "Foxtable.WinForm.Table" AndAlso 控件.Name.Contains("_") = False Then
                If Connections("ft").GetTableNames.Contains(控件.Name) = False Then
                    Output.Show("表:" & 控件.Name & "已废弃")
                End If
            End If
        Next
    End Sub
    Private Sub 布局控件(e As FormEventArgs)
        For Each 表名 As String In Connections("ft").GetTableNames '将设计好的控件,移动到相应的位置
            If e.Form.Controls.Contains(表名) Then
                Dim 表控件 As WinForm.Control = e.Form.Controls(表名)
                If 表控件.GetType.FullName = "Foxtable.WinForm.Table" Then
                    Dim cdt主 As WinForm.TabControl = e.Form.Controls("cdt主")
                    Dim 页 As WinForm.TabPage = cdt主.TabPages(表控件.Name)
                    If 页 Is Nothing Then
                        'Dim tcp As WinForm.TabPage = tc.tabpages.add(ct.name,ct.name)
                        页 = cdt主.TabPages.Add(表控件.Name, 表控件.Name)
                    End If
                    页.AddControl(表控件)
                End If
            Else
                Output.Show("表:" & 表名 & "未设计")
            End If
        Next
    End Sub
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub 初始化窗体m(e As FormEventArgs)
        Dim components As System.ComponentModel.IContainer
        Dim C1CommandDock左 As C1.Win.C1Command.C1CommandDock
        Dim C1CommandDock右 As C1.Win.C1Command.C1CommandDock
        Dim C1CommandDock下 As C1.Win.C1Command.C1CommandDock
        Dim C1CommandDock主 As C1.Win.C1Command.C1CommandDock
        Dim C1DockingManager1 As C1.Win.C1Command.C1DockingManager
        Dim cdt左 As C1.Win.C1Command.C1DockingTab
        Dim cdt右 As C1.Win.C1Command.C1DockingTab
        Dim cdt下 As C1.Win.C1Command.C1DockingTab
        Dim cdt主 As C1.Win.C1Command.C1DockingTab


        '注意: 以下过程是 Windows 窗体设计器所必需的
        '可以使用 Windows 窗体设计器修改它.
        '不要使用代码编辑器修改它.
        components = New System.ComponentModel.Container()
        C1CommandDock左 = New C1.Win.C1Command.C1CommandDock()
        cdt左 = New C1.Win.C1Command.C1DockingTab()
        C1CommandDock右 = New C1.Win.C1Command.C1CommandDock()
        cdt右 = New C1.Win.C1Command.C1DockingTab()
        C1CommandDock下 = New C1.Win.C1Command.C1CommandDock()
        cdt下 = New C1.Win.C1Command.C1DockingTab()
        C1CommandDock主 = New C1.Win.C1Command.C1CommandDock()
        cdt主 = New C1.Win.C1Command.C1DockingTab()
        C1DockingManager1 = New C1.Win.C1Command.C1DockingManager(components)
        CType(C1CommandDock左, System.ComponentModel.ISupportInitialize).BeginInit()
        C1CommandDock左.SuspendLayout()
        CType(cdt左, System.ComponentModel.ISupportInitialize).BeginInit()
        cdt左.SuspendLayout()
        CType(C1CommandDock右, System.ComponentModel.ISupportInitialize).BeginInit()
        C1CommandDock右.SuspendLayout()
        CType(cdt右, System.ComponentModel.ISupportInitialize).BeginInit()
        cdt右.SuspendLayout()
        CType(C1CommandDock下, System.ComponentModel.ISupportInitialize).BeginInit()
        C1CommandDock下.SuspendLayout()
        CType(cdt下, System.ComponentModel.ISupportInitialize).BeginInit()
        cdt下.SuspendLayout()
        CType(C1CommandDock主, System.ComponentModel.ISupportInitialize).BeginInit()
        C1CommandDock主.SuspendLayout()
        CType(cdt主, System.ComponentModel.ISupportInitialize).BeginInit()
        cdt主.SuspendLayout()
        CType(C1DockingManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        'Me.SuspendLayout()
        '
        'C1CommandDock左
        '
        C1CommandDock左.AllowFloat = False
        C1CommandDock左.AutoDockBottom = False
        C1CommandDock左.AutoDockLeft = False
        C1CommandDock左.AutoDockRight = False
        C1CommandDock左.AutoDockTop = False
        C1CommandDock左.Controls.Add(cdt左)
        C1CommandDock左.Dock = System.Windows.Forms.DockStyle.Left
        C1CommandDock左.DockingStyle = C1.Win.C1Command.DockingStyle.VS2012
        C1CommandDock左.Id = 1
        C1CommandDock左.Location = New System.Drawing.Point(0, 0)
        C1CommandDock左.Name = "C1CommandDock左"
        C1CommandDock左.Size = New System.Drawing.Size(300, 450)
        '
        'cdt左
        '
        cdt左.Alignment = System.Windows.Forms.TabAlignment.Bottom
        cdt左.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        cdt左.CanAutoHide = True
        cdt左.CanCloseTabs = True
        cdt左.CanMoveTabs = True
        cdt左.HotTrack = True
        cdt左.Location = New System.Drawing.Point(0, 0)
        cdt左.Name = "cdt左"
        cdt左.SelectedIndex = 0
        cdt左.SelectedTabBold = True
        cdt左.ShowCaption = True
        cdt左.ShowTabList = True
        cdt左.ShowToolTips = True
        cdt左.Size = New System.Drawing.Size(300, 450)
        cdt左.TabAreaBorder = True
        cdt左.TabIndex = 0
        'cdt左.TabSizeMode = C1.Win.C1Command.TabSizeModeEnum.Fit
        cdt左.TabsSpacing = 5
        cdt左.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Black
        cdt左.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Black
        '
        'C1CommandDock右
        '
        C1CommandDock右.AllowFloat = False
        C1CommandDock右.AutoDockBottom = False
        C1CommandDock右.AutoDockLeft = False
        C1CommandDock右.AutoDockRight = False
        C1CommandDock右.AutoDockTop = False
        C1CommandDock右.Controls.Add(cdt右)
        C1CommandDock右.Dock = System.Windows.Forms.DockStyle.Right
        C1CommandDock右.DockingStyle = C1.Win.C1Command.DockingStyle.VS2012
        C1CommandDock右.Id = 6
        C1CommandDock右.Location = New System.Drawing.Point(500, 0)
        C1CommandDock右.Name = "C1CommandDock右"
        C1CommandDock右.Size = New System.Drawing.Size(300, 450)
        '
        'cdt右
        '
        cdt右.Alignment = System.Windows.Forms.TabAlignment.Bottom
        cdt右.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        cdt右.CanAutoHide = True
        cdt右.CanCloseTabs = True
        cdt右.CanMoveTabs = True
        cdt右.HotTrack = True
        cdt右.Location = New System.Drawing.Point(0, 0)
        cdt右.Name = "cdt右"
        cdt右.SelectedIndex = 0
        cdt右.SelectedTabBold = True
        cdt右.ShowCaption = True
        cdt右.ShowTabList = True
        cdt右.ShowToolTips = True
        cdt右.Size = New System.Drawing.Size(300, 450)
        cdt右.TabAreaBorder = True
        cdt右.TabIndex = 0
        'cdt右.TabSizeMode = C1.Win.C1Command.TabSizeModeEnum.Fit
        cdt右.TabsSpacing = 5
        cdt右.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Black
        cdt右.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Black
        '
        'C1CommandDock下
        '
        C1CommandDock下.AllowFloat = False
        C1CommandDock下.AutoDockBottom = False
        C1CommandDock下.AutoDockLeft = False
        C1CommandDock下.AutoDockRight = False
        C1CommandDock下.AutoDockTop = False
        C1CommandDock下.Controls.Add(cdt下)
        C1CommandDock下.Dock = System.Windows.Forms.DockStyle.Bottom
        C1CommandDock下.DockingStyle = C1.Win.C1Command.DockingStyle.VS2012
        C1CommandDock下.Id = 10
        C1CommandDock下.Location = New System.Drawing.Point(300, 250)
        C1CommandDock下.Name = "C1CommandDock下"
        C1CommandDock下.Size = New System.Drawing.Size(200, 200)
        '
        'cdt下
        '
        cdt下.Alignment = System.Windows.Forms.TabAlignment.Bottom
        cdt下.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        cdt下.CanAutoHide = False
        cdt下.CanCloseTabs = False
        cdt下.CanMoveTabs = False
        cdt下.HotTrack = True
        cdt下.Location = New System.Drawing.Point(0, 0)
        cdt下.Name = "cdt下"
        cdt下.SelectedIndex = 0
        'cdt下.SelectedTabBold = True
        cdt下.ShowCaption = True
        cdt下.ShowTabList = True
        cdt下.ShowToolTips = True
        cdt下.Size = New System.Drawing.Size(300, 300)
        cdt下.TabAreaBorder = True
        cdt下.TabIndex = 0
        'cdt下.TabSizeMode = C1.Win.C1Command.TabSizeModeEnum.Fit
        cdt下.TabsSpacing = 5
        cdt下.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Black
        cdt下.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Black
        AddHandler cdt下.SelectedTabChanged, AddressOf cdt主_SelectedTabChanged

        '
        'C1CommandDock主
        '
        C1CommandDock主.AllowFloat = False
        C1CommandDock主.AutoDockBottom = False
        C1CommandDock主.AutoDockLeft = False
        C1CommandDock主.AutoDockRight = False
        C1CommandDock主.AutoDockTop = False
        C1CommandDock主.Controls.Add(cdt主)
        C1CommandDock主.Dock = System.Windows.Forms.DockStyle.Fill
        C1CommandDock主.DockingStyle = C1.Win.C1Command.DockingStyle.VS2012
        C1CommandDock主.Id = 15
        C1CommandDock主.Location = New System.Drawing.Point(300, 0)
        C1CommandDock主.Name = "C1CommandDock主"
        C1CommandDock主.Size = New System.Drawing.Size(200, 250)
        '
        'cdt主
        '
        cdt主.Animate = True
        cdt主.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        cdt主.CanCloseTabs = False
        cdt主.CanMoveTabs = False
        'cdt主.CloseBox = C1.Win.C1Command.CloseBoxPositionEnum.ActivePage
        cdt主.HotTrack = True
        cdt主.Location = New System.Drawing.Point(0, 0)
        cdt主.Name = "cdt主"
        cdt主.SelectedIndex = 1
        cdt主.SelectedTabBold = True
        cdt主.ShowTabList = True
        cdt主.ShowTabs = False
        cdt主.ShowToolTips = True
        cdt主.ShowCaption = True
        cdt主.Size = New System.Drawing.Size(200, 250)
        cdt主.TabAreaBorder = True
        cdt主.TabIndex = 0
        'cdt主.TabSizeMode = C1.Win.C1Command.TabSizeModeEnum.Fit
        cdt主.TabsSpacing = 5
        cdt主.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2007
        cdt主.VisualStyle = C1.Win.C1Command.VisualStyle.Office2007Black
        cdt主.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2007Black
        AddHandler cdt主.SelectedTabChanged, AddressOf cdt主_SelectedTabChanged

        '
        'C1DockingManager1
        '
        C1DockingManager1.AllowFloat = False
        C1DockingManager1.ParentContainer = e.Form.Panel.FindForm
        AddHandler C1DockingManager1.QueryAllowDrop, AddressOf C1DockingManager1_QueryAllowDrop
        AddHandler C1DockingManager1.TabPageClosing, AddressOf C1DockingManager1_TabPageClosing


        '
        'Form1
        '
        'Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        'Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        'Me.ClientSize = New System.Drawing.Size(800, 450)
        e.Form.Panel.Controls.Add(C1CommandDock主)
        e.Form.Panel.Controls.Add(C1CommandDock下)
        e.Form.Panel.Controls.Add(C1CommandDock右)
        e.Form.Panel.Controls.Add(C1CommandDock左)
        'Me.Name = "Form1"
        'Me.Text = "Form1"
        CType(C1CommandDock左, System.ComponentModel.ISupportInitialize).EndInit()
        C1CommandDock左.ResumeLayout(False)
        CType(cdt左, System.ComponentModel.ISupportInitialize).EndInit()
        cdt左.ResumeLayout(False)
        CType(C1CommandDock右, System.ComponentModel.ISupportInitialize).EndInit()
        C1CommandDock右.ResumeLayout(False)
        CType(cdt右, System.ComponentModel.ISupportInitialize).EndInit()
        cdt右.ResumeLayout(False)
        CType(C1CommandDock下, System.ComponentModel.ISupportInitialize).EndInit()
        C1CommandDock下.ResumeLayout(False)
        CType(cdt下, System.ComponentModel.ISupportInitialize).EndInit()
        cdt下.ResumeLayout(False)
        CType(C1CommandDock主, System.ComponentModel.ISupportInitialize).EndInit()
        C1CommandDock主.ResumeLayout(False)
        CType(cdt主, System.ComponentModel.ISupportInitialize).EndInit()
        cdt主.ResumeLayout(False)
        CType(C1DockingManager1, System.ComponentModel.ISupportInitialize).EndInit()
        'Me.ResumeLayout(False)
    End Sub
#End Region



End Module

