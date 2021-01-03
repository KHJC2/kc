<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class grid
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(grid))
        Me.C1FlexGrid1 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.仓库BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ft20200811DataSet = New 窗体.ft20200811DataSet()
        Me.仓库TableAdapter = New 窗体.ft20200811DataSetTableAdapters.仓库TableAdapter()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.仓库BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ft20200811DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1FlexGrid1
        '
        Me.C1FlexGrid1.AllowAddNew = True
        Me.C1FlexGrid1.AllowDelete = True
        Me.C1FlexGrid1.AllowFiltering = True
        Me.C1FlexGrid1.ColumnInfo = resources.GetString("C1FlexGrid1.ColumnInfo")
        Me.C1FlexGrid1.DataSource = Me.仓库BindingSource
        Me.C1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1FlexGrid1.Location = New System.Drawing.Point(0, 0)
        Me.C1FlexGrid1.Name = "C1FlexGrid1"
        Me.C1FlexGrid1.Rows.Count = 1
        Me.C1FlexGrid1.Size = New System.Drawing.Size(800, 450)
        Me.C1FlexGrid1.StyleInfo = resources.GetString("C1FlexGrid1.StyleInfo")
        Me.C1FlexGrid1.TabIndex = 0
        Me.C1FlexGrid1.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue
        '
        '仓库BindingSource
        '
        Me.仓库BindingSource.DataMember = "仓库"
        Me.仓库BindingSource.DataSource = Me.Ft20200811DataSet
        '
        'Ft20200811DataSet
        '
        Me.Ft20200811DataSet.DataSetName = "ft20200811DataSet"
        Me.Ft20200811DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '仓库TableAdapter
        '
        Me.仓库TableAdapter.ClearBeforeFill = True
        '
        'grid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.C1FlexGrid1)
        Me.Name = "grid"
        Me.Text = "grid"
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.仓库BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ft20200811DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents C1FlexGrid1 As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Ft20200811DataSet As ft20200811DataSet
    Friend WithEvents 仓库BindingSource As BindingSource
    Friend WithEvents 仓库TableAdapter As ft20200811DataSetTableAdapters.仓库TableAdapter
End Class
