<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Me.LoginGroup = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PassWd = New System.Windows.Forms.TextBox()
        Me.UserId = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.WebBrowserBox = New System.Windows.Forms.WebBrowser()
        Me.Base = New System.Windows.Forms.GroupBox()
        Me.OpenExcel = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.renovate = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.classListBox = New System.Windows.Forms.ComboBox()
        Me.gradeListBox = New System.Windows.Forms.ComboBox()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.StatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PostTimerThread = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.DataSet = New System.Data.DataSet()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ExcelState = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.LoginGroup.SuspendLayout()
        Me.Base.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LoginGroup
        '
        Me.LoginGroup.Controls.Add(Me.Label2)
        Me.LoginGroup.Controls.Add(Me.Label1)
        Me.LoginGroup.Controls.Add(Me.PassWd)
        Me.LoginGroup.Controls.Add(Me.UserId)
        Me.LoginGroup.Controls.Add(Me.Button1)
        Me.LoginGroup.Enabled = False
        Me.LoginGroup.Location = New System.Drawing.Point(10, 12)
        Me.LoginGroup.Name = "LoginGroup"
        Me.LoginGroup.Size = New System.Drawing.Size(224, 106)
        Me.LoginGroup.TabIndex = 1
        Me.LoginGroup.TabStop = False
        Me.LoginGroup.Text = "登录窗口"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "用户名："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "密  码："
        '
        'PassWd
        '
        Me.PassWd.Location = New System.Drawing.Point(61, 48)
        Me.PassWd.Name = "PassWd"
        Me.PassWd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PassWd.Size = New System.Drawing.Size(155, 21)
        Me.PassWd.TabIndex = 2
        Me.PassWd.UseSystemPasswordChar = True
        '
        'UserId
        '
        Me.UserId.Location = New System.Drawing.Point(61, 20)
        Me.UserId.Name = "UserId"
        Me.UserId.Size = New System.Drawing.Size(155, 21)
        Me.UserId.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(141, 75)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "登录"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'WebBrowserBox
        '
        Me.WebBrowserBox.Location = New System.Drawing.Point(10, 207)
        Me.WebBrowserBox.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowserBox.Name = "WebBrowserBox"
        Me.WebBrowserBox.Size = New System.Drawing.Size(454, 77)
        Me.WebBrowserBox.TabIndex = 2
        Me.WebBrowserBox.Url = New System.Uri("http://www.gxufz.com:1234", System.UriKind.Absolute)
        Me.WebBrowserBox.Visible = False
        '
        'Base
        '
        Me.Base.Controls.Add(Me.Label4)
        Me.Base.Controls.Add(Me.renovate)
        Me.Base.Controls.Add(Me.Label3)
        Me.Base.Controls.Add(Me.classListBox)
        Me.Base.Controls.Add(Me.gradeListBox)
        Me.Base.Enabled = False
        Me.Base.Location = New System.Drawing.Point(10, 124)
        Me.Base.Name = "Base"
        Me.Base.Size = New System.Drawing.Size(224, 77)
        Me.Base.TabIndex = 3
        Me.Base.TabStop = False
        Me.Base.Text = "基本设置窗口"
        '
        'OpenExcel
        '
        Me.OpenExcel.Location = New System.Drawing.Point(9, 49)
        Me.OpenExcel.Name = "OpenExcel"
        Me.OpenExcel.Size = New System.Drawing.Size(126, 23)
        Me.OpenExcel.TabIndex = 10
        Me.OpenExcel.Text = "添加Excel文件"
        Me.OpenExcel.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(9, 20)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(209, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "设置请假规则"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 12)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "班  级："
        '
        'renovate
        '
        Me.renovate.Location = New System.Drawing.Point(170, 20)
        Me.renovate.Name = "renovate"
        Me.renovate.Size = New System.Drawing.Size(46, 20)
        Me.renovate.TabIndex = 6
        Me.renovate.Text = "刷新"
        Me.renovate.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "年  级："
        '
        'classListBox
        '
        Me.classListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.classListBox.Enabled = False
        Me.classListBox.FormattingEnabled = True
        Me.classListBox.Location = New System.Drawing.Point(61, 46)
        Me.classListBox.Name = "classListBox"
        Me.classListBox.Size = New System.Drawing.Size(155, 20)
        Me.classListBox.TabIndex = 1
        '
        'gradeListBox
        '
        Me.gradeListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.gradeListBox.FormattingEnabled = True
        Me.gradeListBox.Location = New System.Drawing.Point(61, 20)
        Me.gradeListBox.Name = "gradeListBox"
        Me.gradeListBox.Size = New System.Drawing.Size(103, 20)
        Me.gradeListBox.TabIndex = 0
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 298)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(476, 22)
        Me.StatusStrip.TabIndex = 4
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'StatusLabel
        '
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(125, 17)
        Me.StatusLabel.Text = "正在连接请假服务器..."
        '
        'PostTimerThread
        '
        Me.PostTimerThread.Interval = 1000
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.Filter = "Excel表格|*.xls;*.xlsx"
        Me.OpenFileDialog.Title = "请选择答题卡结果文件 Excel格式"
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "NewDataSet"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.ExcelState)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.OpenExcel)
        Me.GroupBox1.Location = New System.Drawing.Point(240, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(224, 106)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "学生列表设置"
        '
        'ExcelState
        '
        Me.ExcelState.AutoSize = True
        Me.ExcelState.Location = New System.Drawing.Point(10, 80)
        Me.ExcelState.Name = "ExcelState"
        Me.ExcelState.Size = New System.Drawing.Size(125, 12)
        Me.ExcelState.TabIndex = 11
        Me.ExcelState.Text = "请打开答题卡结果文件"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(141, 49)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "清空数据"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(240, 124)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(224, 77)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "执行请假任务"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 320)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.WebBrowserBox)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.Base)
        Me.Controls.Add(Me.LoginGroup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "广西大学附属中学 自动化请假系统 By:何泽恩"
        Me.LoginGroup.ResumeLayout(False)
        Me.LoginGroup.PerformLayout()
        Me.Base.ResumeLayout(False)
        Me.Base.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LoginGroup As GroupBox
    Friend WithEvents WebBrowserBox As WebBrowser
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PassWd As TextBox
    Friend WithEvents UserId As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Base As GroupBox
    Friend WithEvents classListBox As ComboBox
    Friend WithEvents gradeListBox As ComboBox
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents StatusLabel As ToolStripStatusLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents renovate As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents PostTimerThread As Timer
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents OpenExcel As Button
    Friend WithEvents DataSet As DataSet
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ExcelState As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
End Class
