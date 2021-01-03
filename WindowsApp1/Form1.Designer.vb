<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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
        Me.C1DockingManager1 = New C1.Win.C1Command.C1DockingManager(Me.components)
        Me.C1CommandDock1 = New C1.Win.C1Command.C1CommandDock()
        Me.C1DockingTab1 = New C1.Win.C1Command.C1DockingTab()
        Me.C1DockingTabPage1 = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1DockingTabPage5 = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1CommandDock2 = New C1.Win.C1Command.C1CommandDock()
        Me.C1DockingTab2 = New C1.Win.C1Command.C1DockingTab()
        Me.C1DockingTabPage2 = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1DockingTabPage6 = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1CommandDock3 = New C1.Win.C1Command.C1CommandDock()
        Me.C1DockingTab3 = New C1.Win.C1Command.C1DockingTab()
        Me.C1DockingTabPage3 = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1DockingTabPage4 = New C1.Win.C1Command.C1DockingTabPage()
        CType(Me.C1DockingManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CommandDock1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1CommandDock1.SuspendLayout()
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTab1.SuspendLayout()
        CType(Me.C1CommandDock2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1CommandDock2.SuspendLayout()
        CType(Me.C1DockingTab2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTab2.SuspendLayout()
        CType(Me.C1CommandDock3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1CommandDock3.SuspendLayout()
        CType(Me.C1DockingTab3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTab3.SuspendLayout()
        Me.SuspendLayout()
        '
        'C1DockingManager1
        '
        Me.C1DockingManager1.ParentContainer = Me
        '
        'C1CommandDock1
        '
        Me.C1CommandDock1.Controls.Add(Me.C1DockingTab1)
        Me.C1CommandDock1.Dock = System.Windows.Forms.DockStyle.Left
        Me.C1CommandDock1.Id = 1
        Me.C1CommandDock1.Location = New System.Drawing.Point(0, 0)
        Me.C1CommandDock1.Name = "C1CommandDock1"
        Me.C1CommandDock1.Size = New System.Drawing.Size(300, 450)
        '
        'C1DockingTab1
        '
        Me.C1DockingTab1.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.C1DockingTab1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.C1DockingTab1.CanAutoHide = True
        Me.C1DockingTab1.CanCloseTabs = True
        Me.C1DockingTab1.CanMoveTabs = True
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage1)
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage5)
        Me.C1DockingTab1.Location = New System.Drawing.Point(0, 0)
        Me.C1DockingTab1.Name = "C1DockingTab1"
        Me.C1DockingTab1.SelectedIndex = 1
        Me.C1DockingTab1.ShowCaption = True
        Me.C1DockingTab1.Size = New System.Drawing.Size(300, 450)
        Me.C1DockingTab1.TabIndex = 0
        Me.C1DockingTab1.TabSizeMode = C1.Win.C1Command.TabSizeModeEnum.Fit
        Me.C1DockingTab1.TabsSpacing = 5
        '
        'C1DockingTabPage1
        '
        Me.C1DockingTabPage1.CaptionVisible = True
        Me.C1DockingTabPage1.Location = New System.Drawing.Point(0, 0)
        Me.C1DockingTabPage1.Name = "C1DockingTabPage1"
        Me.C1DockingTabPage1.Size = New System.Drawing.Size(297, 425)
        Me.C1DockingTabPage1.TabIndex = 0
        Me.C1DockingTabPage1.Text = "第1页"
        '
        'C1DockingTabPage5
        '
        Me.C1DockingTabPage5.CaptionVisible = True
        Me.C1DockingTabPage5.Location = New System.Drawing.Point(0, 0)
        Me.C1DockingTabPage5.Name = "C1DockingTabPage5"
        Me.C1DockingTabPage5.Size = New System.Drawing.Size(297, 425)
        Me.C1DockingTabPage5.TabIndex = 1
        Me.C1DockingTabPage5.Text = "第5页"
        '
        'C1CommandDock2
        '
        Me.C1CommandDock2.Controls.Add(Me.C1DockingTab2)
        Me.C1CommandDock2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.C1CommandDock2.Id = 3
        Me.C1CommandDock2.Location = New System.Drawing.Point(300, 250)
        Me.C1CommandDock2.Name = "C1CommandDock2"
        Me.C1CommandDock2.Size = New System.Drawing.Size(500, 200)
        '
        'C1DockingTab2
        '
        Me.C1DockingTab2.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.C1DockingTab2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.C1DockingTab2.CanAutoHide = True
        Me.C1DockingTab2.CanCloseTabs = True
        Me.C1DockingTab2.CanMoveTabs = True
        Me.C1DockingTab2.Controls.Add(Me.C1DockingTabPage2)
        Me.C1DockingTab2.Controls.Add(Me.C1DockingTabPage6)
        Me.C1DockingTab2.Location = New System.Drawing.Point(0, 0)
        Me.C1DockingTab2.Name = "C1DockingTab2"
        Me.C1DockingTab2.SelectedIndex = 1
        Me.C1DockingTab2.ShowCaption = True
        Me.C1DockingTab2.Size = New System.Drawing.Size(500, 200)
        Me.C1DockingTab2.TabIndex = 0
        Me.C1DockingTab2.TabSizeMode = C1.Win.C1Command.TabSizeModeEnum.Fit
        Me.C1DockingTab2.TabsSpacing = 5
        '
        'C1DockingTabPage2
        '
        Me.C1DockingTabPage2.CaptionVisible = True
        Me.C1DockingTabPage2.Location = New System.Drawing.Point(0, 3)
        Me.C1DockingTabPage2.Name = "C1DockingTabPage2"
        Me.C1DockingTabPage2.Size = New System.Drawing.Size(500, 172)
        Me.C1DockingTabPage2.TabIndex = 0
        Me.C1DockingTabPage2.Text = "第2页"
        '
        'C1DockingTabPage6
        '
        Me.C1DockingTabPage6.CaptionVisible = True
        Me.C1DockingTabPage6.Location = New System.Drawing.Point(0, 3)
        Me.C1DockingTabPage6.Name = "C1DockingTabPage6"
        Me.C1DockingTabPage6.Size = New System.Drawing.Size(500, 172)
        Me.C1DockingTabPage6.TabIndex = 1
        Me.C1DockingTabPage6.Text = "第6页"
        '
        'C1CommandDock3
        '
        Me.C1CommandDock3.Controls.Add(Me.C1DockingTab3)
        Me.C1CommandDock3.Dock = System.Windows.Forms.DockStyle.Right
        Me.C1CommandDock3.Id = 6
        Me.C1CommandDock3.Location = New System.Drawing.Point(596, 0)
        Me.C1CommandDock3.Name = "C1CommandDock3"
        Me.C1CommandDock3.Size = New System.Drawing.Size(204, 250)
        '
        'C1DockingTab3
        '
        Me.C1DockingTab3.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.C1DockingTab3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.C1DockingTab3.CanAutoHide = True
        Me.C1DockingTab3.CanCloseTabs = True
        Me.C1DockingTab3.CanMoveTabs = True
        Me.C1DockingTab3.Controls.Add(Me.C1DockingTabPage3)
        Me.C1DockingTab3.Controls.Add(Me.C1DockingTabPage4)
        Me.C1DockingTab3.Location = New System.Drawing.Point(0, 0)
        Me.C1DockingTab3.Name = "C1DockingTab3"
        Me.C1DockingTab3.SelectedIndex = 1
        Me.C1DockingTab3.ShowCaption = True
        Me.C1DockingTab3.Size = New System.Drawing.Size(204, 250)
        Me.C1DockingTab3.TabIndex = 3
        Me.C1DockingTab3.TabSizeMode = C1.Win.C1Command.TabSizeModeEnum.Fit
        Me.C1DockingTab3.TabsSpacing = 5
        '
        'C1DockingTabPage3
        '
        Me.C1DockingTabPage3.CaptionVisible = True
        Me.C1DockingTabPage3.Location = New System.Drawing.Point(3, 0)
        Me.C1DockingTabPage3.Name = "C1DockingTabPage3"
        Me.C1DockingTabPage3.Size = New System.Drawing.Size(201, 225)
        Me.C1DockingTabPage3.TabIndex = 0
        Me.C1DockingTabPage3.Text = "第3页"
        '
        'C1DockingTabPage4
        '
        Me.C1DockingTabPage4.CaptionVisible = True
        Me.C1DockingTabPage4.Location = New System.Drawing.Point(3, 0)
        Me.C1DockingTabPage4.Name = "C1DockingTabPage4"
        Me.C1DockingTabPage4.Size = New System.Drawing.Size(201, 225)
        Me.C1DockingTabPage4.TabIndex = 1
        Me.C1DockingTabPage4.Text = "第4页"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.C1CommandDock3)
        Me.Controls.Add(Me.C1CommandDock2)
        Me.Controls.Add(Me.C1CommandDock1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.C1DockingManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CommandDock1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1CommandDock1.ResumeLayout(False)
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTab1.ResumeLayout(False)
        CType(Me.C1CommandDock2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1CommandDock2.ResumeLayout(False)
        CType(Me.C1DockingTab2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTab2.ResumeLayout(False)
        CType(Me.C1CommandDock3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1CommandDock3.ResumeLayout(False)
        CType(Me.C1DockingTab3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTab3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents C1DockingManager1 As C1.Win.C1Command.C1DockingManager
    Friend WithEvents C1CommandDock1 As C1.Win.C1Command.C1CommandDock
    Friend WithEvents C1CommandDock3 As C1.Win.C1Command.C1CommandDock
    Friend WithEvents C1DockingTab3 As C1.Win.C1Command.C1DockingTab
    Friend WithEvents C1DockingTabPage3 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1DockingTabPage4 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1CommandDock2 As C1.Win.C1Command.C1CommandDock
    Friend WithEvents C1DockingTab2 As C1.Win.C1Command.C1DockingTab
    Friend WithEvents C1DockingTabPage2 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1DockingTabPage6 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1DockingTab1 As C1.Win.C1Command.C1DockingTab
    Friend WithEvents C1DockingTabPage1 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1DockingTabPage5 As C1.Win.C1Command.C1DockingTabPage
End Class
