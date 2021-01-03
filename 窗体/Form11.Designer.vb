<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form11
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
        Me.控件main1 = New 控件库.控件main()
        Me.C1DockingManager1 = New C1.Win.C1Command.C1DockingManager(Me.components)
        CType(Me.C1DockingManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '控件main1
        '
        Me.控件main1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.控件main1.Location = New System.Drawing.Point(0, 0)
        Me.控件main1.Name = "控件main1"
        Me.控件main1.Size = New System.Drawing.Size(800, 450)
        Me.控件main1.TabIndex = 0
        '
        'C1DockingManager1
        '
        Me.C1DockingManager1.AllowFloat = False
        Me.C1DockingManager1.ParentContainer = Me
        '
        'Form11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.控件main1)
        Me.Name = "Form11"
        Me.Text = "Form11"
        CType(Me.C1DockingManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents 控件main1 As 控件库.控件main
    Friend WithEvents C1DockingManager1 As C1.Win.C1Command.C1DockingManager
End Class
