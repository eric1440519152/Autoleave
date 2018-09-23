<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Me.leaveRulesData = New System.Windows.Forms.DataGridView()
        Me.endTimeBox = New System.Windows.Forms.DateTimePicker()
        Me.startTimeBox = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.choices = New System.Windows.Forms.ComboBox()
        Me.addButton = New System.Windows.Forms.Button()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.message = New System.Windows.Forms.CheckBox()
        Me.leaveType = New System.Windows.Forms.ComboBox()
        Me.题号DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.选项DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.开始时间DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.结束时间DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.是否短信通知DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.请假类型DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.LeaverulesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SettingDataSet = New Autoleave.settingDataSet()
        Me.LeaverulesTableAdapter = New Autoleave.settingDataSetTableAdapters.leaverulesTableAdapter()
        CType(Me.leaveRulesData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeaverulesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SettingDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'leaveRulesData
        '
        Me.leaveRulesData.AllowUserToAddRows = False
        Me.leaveRulesData.AutoGenerateColumns = False
        Me.leaveRulesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.leaveRulesData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.题号DataGridViewTextBoxColumn, Me.选项DataGridViewTextBoxColumn, Me.开始时间DataGridViewTextBoxColumn, Me.结束时间DataGridViewTextBoxColumn, Me.是否短信通知DataGridViewCheckBoxColumn, Me.请假类型DataGridViewTextBoxColumn})
        Me.leaveRulesData.DataSource = Me.LeaverulesBindingSource
        Me.leaveRulesData.Location = New System.Drawing.Point(12, 12)
        Me.leaveRulesData.Name = "leaveRulesData"
        Me.leaveRulesData.RowTemplate.Height = 23
        Me.leaveRulesData.Size = New System.Drawing.Size(644, 278)
        Me.leaveRulesData.TabIndex = 0
        '
        'endTimeBox
        '
        Me.endTimeBox.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.endTimeBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.endTimeBox.Location = New System.Drawing.Point(300, 329)
        Me.endTimeBox.Name = "endTimeBox"
        Me.endTimeBox.Size = New System.Drawing.Size(140, 21)
        Me.endTimeBox.TabIndex = 1
        '
        'startTimeBox
        '
        Me.startTimeBox.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.startTimeBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.startTimeBox.Location = New System.Drawing.Point(300, 302)
        Me.startTimeBox.Name = "startTimeBox"
        Me.startTimeBox.Size = New System.Drawing.Size(140, 21)
        Me.startTimeBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(229, 307)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "开始时间："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(229, 334)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "结束时间："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 308)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 12)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "题号："
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(81, 308)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 12)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "选项："
        '
        'choices
        '
        Me.choices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.choices.FormattingEnabled = True
        Me.choices.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.choices.Location = New System.Drawing.Point(121, 304)
        Me.choices.Name = "choices"
        Me.choices.Size = New System.Drawing.Size(102, 20)
        Me.choices.TabIndex = 8
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(12, 330)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(103, 23)
        Me.addButton.TabIndex = 9
        Me.addButton.Text = "添加"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(55, 303)
        Me.MaskedTextBox1.Mask = "99"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(19, 21)
        Me.MaskedTextBox1.TabIndex = 10
        Me.MaskedTextBox1.ValidatingType = GetType(Integer)
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(121, 330)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "保存"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'message
        '
        Me.message.AutoSize = True
        Me.message.Location = New System.Drawing.Point(452, 304)
        Me.message.Name = "message"
        Me.message.Size = New System.Drawing.Size(72, 16)
        Me.message.TabIndex = 13
        Me.message.Text = "发送短信"
        Me.message.UseVisualStyleBackColor = True
        '
        'leaveType
        '
        Me.leaveType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.leaveType.FormattingEnabled = True
        Me.leaveType.Items.AddRange(New Object() {"生病就医", "回家取物", "家中有事", "外出补习", "购物", "理发", "取款", "其它"})
        Me.leaveType.Location = New System.Drawing.Point(452, 330)
        Me.leaveType.Name = "leaveType"
        Me.leaveType.Size = New System.Drawing.Size(204, 20)
        Me.leaveType.TabIndex = 14
        '
        '题号DataGridViewTextBoxColumn
        '
        Me.题号DataGridViewTextBoxColumn.DataPropertyName = "题号"
        Me.题号DataGridViewTextBoxColumn.HeaderText = "题号"
        Me.题号DataGridViewTextBoxColumn.Name = "题号DataGridViewTextBoxColumn"
        '
        '选项DataGridViewTextBoxColumn
        '
        Me.选项DataGridViewTextBoxColumn.DataPropertyName = "选项"
        Me.选项DataGridViewTextBoxColumn.HeaderText = "选项"
        Me.选项DataGridViewTextBoxColumn.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.选项DataGridViewTextBoxColumn.Name = "选项DataGridViewTextBoxColumn"
        Me.选项DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.选项DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        '开始时间DataGridViewTextBoxColumn
        '
        Me.开始时间DataGridViewTextBoxColumn.DataPropertyName = "开始时间"
        Me.开始时间DataGridViewTextBoxColumn.HeaderText = "开始时间"
        Me.开始时间DataGridViewTextBoxColumn.Name = "开始时间DataGridViewTextBoxColumn"
        '
        '结束时间DataGridViewTextBoxColumn
        '
        Me.结束时间DataGridViewTextBoxColumn.DataPropertyName = "结束时间"
        Me.结束时间DataGridViewTextBoxColumn.HeaderText = "结束时间"
        Me.结束时间DataGridViewTextBoxColumn.Name = "结束时间DataGridViewTextBoxColumn"
        '
        '是否短信通知DataGridViewCheckBoxColumn
        '
        Me.是否短信通知DataGridViewCheckBoxColumn.DataPropertyName = "是否短信通知"
        Me.是否短信通知DataGridViewCheckBoxColumn.HeaderText = "是否短信通知"
        Me.是否短信通知DataGridViewCheckBoxColumn.Name = "是否短信通知DataGridViewCheckBoxColumn"
        '
        '请假类型DataGridViewTextBoxColumn
        '
        Me.请假类型DataGridViewTextBoxColumn.DataPropertyName = "请假类型"
        Me.请假类型DataGridViewTextBoxColumn.HeaderText = "请假类型"
        Me.请假类型DataGridViewTextBoxColumn.Items.AddRange(New Object() {"生病就医", "回家取物", "家中有事", "外出补习", "购物", "理发", "取款", "其它"})
        Me.请假类型DataGridViewTextBoxColumn.Name = "请假类型DataGridViewTextBoxColumn"
        Me.请假类型DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.请假类型DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'LeaverulesBindingSource
        '
        Me.LeaverulesBindingSource.DataMember = "leaverules"
        Me.LeaverulesBindingSource.DataSource = Me.SettingDataSet
        '
        'SettingDataSet
        '
        Me.SettingDataSet.DataSetName = "settingDataSet"
        Me.SettingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LeaverulesTableAdapter
        '
        Me.LeaverulesTableAdapter.ClearBeforeFill = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 367)
        Me.Controls.Add(Me.leaveType)
        Me.Controls.Add(Me.message)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.choices)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.startTimeBox)
        Me.Controls.Add(Me.endTimeBox)
        Me.Controls.Add(Me.leaveRulesData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Settings"
        Me.Text = "设置请假规则"
        CType(Me.leaveRulesData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeaverulesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SettingDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents leaveRulesData As DataGridView
    Friend WithEvents endTimeBox As DateTimePicker
    Friend WithEvents startTimeBox As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents choices As ComboBox
    Friend WithEvents addButton As Button
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents SettingDataSet As settingDataSet
    Friend WithEvents LeaverulesBindingSource As BindingSource
    Friend WithEvents LeaverulesTableAdapter As settingDataSetTableAdapters.leaverulesTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents message As CheckBox
    Friend WithEvents leaveType As ComboBox
    Friend WithEvents 题号DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 选项DataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents 开始时间DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 结束时间DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 是否短信通知DataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents 请假类型DataGridViewTextBoxColumn As DataGridViewComboBoxColumn
End Class
