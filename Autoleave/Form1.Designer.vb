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
        Me.LoginGroup = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PassWd = New System.Windows.Forms.TextBox()
        Me.UserId = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Base = New System.Windows.Forms.GroupBox()
        Me.classListBox = New System.Windows.Forms.ComboBox()
        Me.gradeListBox = New System.Windows.Forms.ComboBox()
        Me.LoginGroup.SuspendLayout()
        Me.Base.SuspendLayout()
        Me.SuspendLayout()
        '
        'LoginGroup
        '
        Me.LoginGroup.Controls.Add(Me.Label2)
        Me.LoginGroup.Controls.Add(Me.Label1)
        Me.LoginGroup.Controls.Add(Me.PassWd)
        Me.LoginGroup.Controls.Add(Me.UserId)
        Me.LoginGroup.Controls.Add(Me.Button1)
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
        Me.PassWd.Size = New System.Drawing.Size(155, 21)
        Me.PassWd.TabIndex = 2
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
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(242, 12)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(714, 455)
        Me.WebBrowser1.TabIndex = 2
        Me.WebBrowser1.Url = New System.Uri("http://www.gxufz.com:1234", System.UriKind.Absolute)
        '
        'Base
        '
        Me.Base.Controls.Add(Me.classListBox)
        Me.Base.Controls.Add(Me.gradeListBox)
        Me.Base.Location = New System.Drawing.Point(10, 124)
        Me.Base.Name = "Base"
        Me.Base.Size = New System.Drawing.Size(224, 100)
        Me.Base.TabIndex = 3
        Me.Base.TabStop = False
        Me.Base.Text = "基本设置窗口"
        '
        'classListBox
        '
        Me.classListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.classListBox.FormattingEnabled = True
        Me.classListBox.Location = New System.Drawing.Point(61, 48)
        Me.classListBox.Name = "classListBox"
        Me.classListBox.Size = New System.Drawing.Size(155, 20)
        Me.classListBox.TabIndex = 1
        '
        'gradeListBox
        '
        Me.gradeListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.gradeListBox.FormattingEnabled = True
        Me.gradeListBox.Location = New System.Drawing.Point(61, 22)
        Me.gradeListBox.Name = "gradeListBox"
        Me.gradeListBox.Size = New System.Drawing.Size(155, 20)
        Me.gradeListBox.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 479)
        Me.Controls.Add(Me.Base)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.LoginGroup)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.LoginGroup.ResumeLayout(False)
        Me.LoginGroup.PerformLayout()
        Me.Base.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LoginGroup As GroupBox
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PassWd As TextBox
    Friend WithEvents UserId As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Base As GroupBox
    Friend WithEvents classListBox As ComboBox
    Friend WithEvents gradeListBox As ComboBox
End Class
