Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class uc1
    Inherits System.Windows.Forms.UserControl

    'UserControl 重写释放以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uc1))
        Me.ccd左 = New C1.Win.C1Command.C1CommandDock()
        Me.cdt左 = New C1.Win.C1Command.C1DockingTab()
        Me.工作表 = New C1.Win.C1Command.C1DockingTabPage()
        Me.工作表目录树 = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ccd右 = New C1.Win.C1Command.C1CommandDock()
        Me.cdt右 = New C1.Win.C1Command.C1DockingTab()
        Me.ccd下 = New C1.Win.C1Command.C1CommandDock()
        Me.cdt下 = New C1.Win.C1Command.C1DockingTab()
        Me.cdt主 = New C1.Win.C1Command.C1DockingTab()
        Me.ccd主 = New C1.Win.C1Command.C1CommandDock()
        Me.cdm = New C1.Win.C1Command.C1DockingManager(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cdt替 = New C1.Win.C1Command.C1DockingTab()
        CType(Me.ccd左, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ccd左.SuspendLayout()
        CType(Me.cdt左, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cdt左.SuspendLayout()
        Me.工作表.SuspendLayout()
        CType(Me.ccd右, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ccd右.SuspendLayout()
        CType(Me.cdt右, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ccd下, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ccd下.SuspendLayout()
        CType(Me.cdt下, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cdt主, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ccd主, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ccd主.SuspendLayout()
        CType(Me.cdm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.cdt替, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ccd左
        '
        Me.ccd左.AllowFloat = False
        Me.ccd左.AutoDockBottom = False
        Me.ccd左.AutoDockLeft = False
        Me.ccd左.AutoDockRight = False
        Me.ccd左.AutoDockTop = False
        Me.ccd左.Controls.Add(Me.cdt左)
        Me.ccd左.Dock = System.Windows.Forms.DockStyle.Left
        Me.ccd左.DockingStyle = C1.Win.C1Command.DockingStyle.VS2012
        Me.ccd左.Id = 1
        Me.ccd左.Location = New System.Drawing.Point(0, 0)
        Me.ccd左.Name = "ccd左"
        Me.ccd左.Size = New System.Drawing.Size(300, 593)
        '
        'cdt左
        '
        Me.cdt左.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.cdt左.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cdt左.CanAutoHide = True
        Me.cdt左.CanMoveTabs = True
        Me.cdt左.Controls.Add(Me.工作表)
        Me.cdt左.HotTrack = True
        Me.cdt左.Location = New System.Drawing.Point(0, 0)
        Me.cdt左.Name = "cdt左"
        Me.cdt左.SelectedIndex = 1
        Me.cdt左.ShowCaption = True
        Me.cdt左.ShowTabList = True
        Me.cdt左.ShowToolTips = True
        Me.cdt左.Size = New System.Drawing.Size(300, 593)
        Me.cdt左.TabAreaBorder = True
        Me.cdt左.TabIndex = 0
        Me.cdt左.TabsSpacing = 1
        Me.cdt左.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Black
        Me.cdt左.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Black
        '
        '工作表
        '
        Me.工作表.CaptionVisible = True
        Me.工作表.Controls.Add(Me.工作表目录树)
        Me.工作表.Location = New System.Drawing.Point(1, 1)
        Me.工作表.Name = "工作表"
        Me.工作表.Size = New System.Drawing.Size(295, 567)
        Me.工作表.TabIndex = 0
        Me.工作表.Text = "工作表"
        '
        '工作表目录树
        '
        Me.工作表目录树.Dock = System.Windows.Forms.DockStyle.Fill
        Me.工作表目录树.FullRowSelect = True
        Me.工作表目录树.HideSelection = False
        Me.工作表目录树.HotTracking = True
        Me.工作表目录树.ImageIndex = 1
        Me.工作表目录树.ImageList = Me.ImageList1
        Me.工作表目录树.Location = New System.Drawing.Point(0, 23)
        Me.工作表目录树.Name = "工作表目录树"
        Me.工作表目录树.SelectedImageIndex = 3
        Me.工作表目录树.ShowPlusMinus = False
        Me.工作表目录树.Size = New System.Drawing.Size(295, 544)
        Me.工作表目录树.StateImageList = Me.ImageList1
        Me.工作表目录树.TabIndex = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "00589.ico")
        Me.ImageList1.Images.SetKeyName(1, "Chart32.ico")
        Me.ImageList1.Images.SetKeyName(2, "Chart.ico")
        Me.ImageList1.Images.SetKeyName(3, "options.png")
        '
        'ccd右
        '
        Me.ccd右.AllowFloat = False
        Me.ccd右.AutoDockBottom = False
        Me.ccd右.AutoDockLeft = False
        Me.ccd右.AutoDockRight = False
        Me.ccd右.AutoDockTop = False
        Me.ccd右.Controls.Add(Me.cdt右)
        Me.ccd右.Dock = System.Windows.Forms.DockStyle.Right
        Me.ccd右.DockingStyle = C1.Win.C1Command.DockingStyle.VS2012
        Me.ccd右.Id = 6
        Me.ccd右.Location = New System.Drawing.Point(435, 0)
        Me.ccd右.Name = "ccd右"
        Me.ccd右.Size = New System.Drawing.Size(300, 593)
        '
        'cdt右
        '
        Me.cdt右.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.cdt右.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cdt右.CanAutoHide = True
        Me.cdt右.CanMoveTabs = True
        Me.cdt右.HotTrack = True
        Me.cdt右.Location = New System.Drawing.Point(0, 0)
        Me.cdt右.Name = "cdt右"
        Me.cdt右.ShowCaption = True
        Me.cdt右.ShowTabList = True
        Me.cdt右.ShowToolTips = True
        Me.cdt右.Size = New System.Drawing.Size(300, 593)
        Me.cdt右.TabAreaBorder = True
        Me.cdt右.TabIndex = 0
        Me.cdt右.TabsSpacing = 1
        Me.cdt右.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Black
        Me.cdt右.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Black
        '
        'ccd下
        '
        Me.ccd下.AllowFloat = False
        Me.ccd下.AutoDockBottom = False
        Me.ccd下.AutoDockLeft = False
        Me.ccd下.AutoDockRight = False
        Me.ccd下.AutoDockTop = False
        Me.ccd下.Controls.Add(Me.cdt下)
        Me.ccd下.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ccd下.DockingStyle = C1.Win.C1Command.DockingStyle.VS2012
        Me.ccd下.Id = 10
        Me.ccd下.Location = New System.Drawing.Point(300, 293)
        Me.ccd下.Name = "ccd下"
        Me.ccd下.Size = New System.Drawing.Size(135, 300)
        '
        'cdt下
        '
        Me.cdt下.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.cdt下.Animate = False
        Me.cdt下.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cdt下.HotTrack = True
        Me.cdt下.Location = New System.Drawing.Point(0, 0)
        Me.cdt下.Name = "cdt下"
        Me.cdt下.ShowCaption = True
        Me.cdt下.ShowTabList = True
        Me.cdt下.ShowToolTips = True
        Me.cdt下.Size = New System.Drawing.Size(135, 300)
        Me.cdt下.TabAreaBorder = True
        Me.cdt下.TabIndex = 0
        Me.cdt下.TabLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.cdt下.TabsSpacing = 1
        Me.cdt下.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Black
        Me.cdt下.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Black
        '
        'cdt主
        '
        Me.cdt主.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cdt主.CanCloseTabs = True
        Me.cdt主.CloseBox = C1.Win.C1Command.CloseBoxPositionEnum.ActivePage
        Me.cdt主.HotTrack = True
        Me.cdt主.Location = New System.Drawing.Point(0, 0)
        Me.cdt主.Name = "cdt主"
        Me.cdt主.ShowTabList = True
        Me.cdt主.Size = New System.Drawing.Size(135, 293)
        Me.cdt主.TabAreaBorder = True
        Me.cdt主.TabIndex = 0
        Me.cdt主.TabsSpacing = 1
        Me.cdt主.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2007
        Me.cdt主.VisualStyle = C1.Win.C1Command.VisualStyle.Office2007Black
        Me.cdt主.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2007Black
        '
        'ccd主
        '
        Me.ccd主.AllowFloat = False
        Me.ccd主.AutoDockBottom = False
        Me.ccd主.AutoDockLeft = False
        Me.ccd主.AutoDockRight = False
        Me.ccd主.AutoDockTop = False
        Me.ccd主.Controls.Add(Me.cdt主)
        Me.ccd主.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ccd主.DockingStyle = C1.Win.C1Command.DockingStyle.VS2012
        Me.ccd主.Id = 15
        Me.ccd主.Location = New System.Drawing.Point(300, 0)
        Me.ccd主.Name = "ccd主"
        Me.ccd主.Size = New System.Drawing.Size(135, 293)
        '
        'cdm
        '
        Me.cdm.AllowFloat = False
        Me.cdm.ParentContainer = Nothing
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cdt替)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1, 1)
        Me.Panel1.TabIndex = 1
        '
        'cdt替
        '
        Me.cdt替.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cdt替.Location = New System.Drawing.Point(0, 0)
        Me.cdt替.Name = "cdt替"
        Me.cdt替.Size = New System.Drawing.Size(1, 1)
        Me.cdt替.TabIndex = 0
        Me.cdt替.TabsSpacing = 5
        '
        'uc1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ccd主)
        Me.Controls.Add(Me.ccd下)
        Me.Controls.Add(Me.ccd右)
        Me.Controls.Add(Me.ccd左)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "uc1"
        Me.Size = New System.Drawing.Size(735, 593)
        CType(Me.ccd左, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ccd左.ResumeLayout(False)
        CType(Me.cdt左, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cdt左.ResumeLayout(False)
        Me.工作表.ResumeLayout(False)
        CType(Me.ccd右, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ccd右.ResumeLayout(False)
        CType(Me.cdt右, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ccd下, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ccd下.ResumeLayout(False)
        CType(Me.cdt下, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cdt主, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ccd主, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ccd主.ResumeLayout(False)
        CType(Me.cdm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.cdt替, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ccd主 As C1.Win.C1Command.C1CommandDock
    Friend WithEvents ccd左 As C1.Win.C1Command.C1CommandDock
    Friend WithEvents ccd右 As C1.Win.C1Command.C1CommandDock
    Friend WithEvents ccd下 As C1.Win.C1Command.C1CommandDock
    Friend WithEvents cdt主 As C1.Win.C1Command.C1DockingTab
    Friend WithEvents cdt左 As C1.Win.C1Command.C1DockingTab
    Friend WithEvents cdt右 As C1.Win.C1Command.C1DockingTab
    Friend WithEvents cdt下 As C1.Win.C1Command.C1DockingTab
    Public WithEvents cdm As C1.Win.C1Command.C1DockingManager
    Friend WithEvents Panel1 As Panel
    Friend WithEvents 工作表 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents 工作表目录树 As TreeView
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents cdt替 As C1.Win.C1Command.C1DockingTab
    'Friend WithEvents dd As new  Foxtable.WinForm.TabControl()
    'Friend WithEvents cb As C1.Win.C1Input.C1Button
    'Friend WithEvents t As Foxtable.WinForm.Table
End Class
