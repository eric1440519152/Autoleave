Imports System.Data.OleDb

Public Class Main

    Dim gradeList As HtmlElement
    Dim classList As HtmlElement

    Dim classCount As Int16 = 0
    Dim gradeCount As Int16 = 0

    Dim actionClass As New ClassAction

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Button1.Enabled = False

        My.Settings.username = UserId.Text
        My.Settings.Save()


        Dim entryBtn As HtmlElement = WebBrowserBox.Document.All.GetElementsByName("btnEntry").Item(0)
        Dim userIdBox As HtmlElement = WebBrowserBox.Document.All.GetElementsByName("txtName").Item(0)
        Dim passWdBox As HtmlElement = WebBrowserBox.Document.All.GetElementsByName("txtPwd").Item(0)

        'Dim form1 As HtmlElement = WebBrowser1.Document.Forms.GetElementsByName("form1").Item(0)

        userIdBox.SetAttribute("value", UserId.Text)
        passWdBox.SetAttribute("value", PassWd.Text)
        entryBtn.InvokeMember("click")

        StatusLabel.Text = "正在登陆"

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowserBox.DocumentCompleted

        '禁用提示框


        If WebBrowserBox.Url.ToString = "http://www.gxufz.com:1234/" Then

            'MessageBox.Show(WebBrowser1.ReadyState)
            LoginGroup.Enabled = True
            StatusLabel.Text = "完成"

        End If

        If WebBrowserBox.Url.ToString = "http://www.gxufz.com:1234/QJInfoAdd.aspx" Then

            gradeListBox.Items.Clear()

            LoginGroup.Enabled = False
            Base.Enabled = True
            StatusLabel.Text = "完成"

            gradeList = WebBrowserBox.Document.GetElementById("ctl00_ContentPlaceHolder1_DropDownList1")

            gradeCount = gradeList.Children.Count

            For i = 0 To gradeCount - 2 Step 1
                gradeListBox.Items.Add(gradeList.Children.Item(i).GetAttribute("value"))
            Next

        End If


    End Sub

    Private Sub gradeListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gradeListBox.SelectedIndexChanged

        classListBox.Enabled = False
        gradeList = WebBrowserBox.Document.GetElementById("ctl00_ContentPlaceHolder1_DropDownList1")

        'MessageBox.Show(gradeList.Children.Count)

        For i = 0 To gradeCount - 2 Step 1
            gradeList.Children.Item(i).SetAttribute("selected", Nothing)
        Next

        gradeList.Children.Item(gradeListBox.SelectedIndex).SetAttribute("selected", "selected")
        gradeList.InvokeMember("onchange")

    End Sub

    Public Sub Delay(ByVal a As Integer)
        Dim i As Integer
        For i = 0 To a
            Application.DoEvents()
        Next
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserId.Text = My.Settings.username
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles renovate.Click

        classListBox.Items.Clear()
        classList = WebBrowserBox.Document.GetElementById("ctl00_ContentPlaceHolder1_DropDownList2")

        classCount = classList.Children.Count

        For i = 0 To classCount - 2 Step 1
            classListBox.Items.Add(classList.Children.Item(i).GetAttribute("value"))
        Next
        classListBox.Enabled = True

    End Sub

    Private Sub classListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles classListBox.SelectedIndexChanged

        classList = WebBrowserBox.Document.GetElementById("ctl00_ContentPlaceHolder1_DropDownList2")

        'MessageBox.Show(classList.Children.Count)
        classCount = classList.Children.Count

        For i = 0 To classCount - 2 Step 1
            classList.Children.Item(i).SetAttribute("selected", Nothing)
        Next

        classList.Children.Item(classListBox.SelectedIndex).SetAttribute("selected", "selected")
        classList.InvokeMember("onchange")

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Settings.Show()

    End Sub

    Private Sub lock_Click(sender As Object, e As EventArgs)

        classListBox.Enabled = Not gradeListBox.Enabled
        gradeListBox.Enabled = Not gradeListBox.Enabled
        renovate.Enabled = Not renovate.Enabled

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)


        PostTimerThread.Enabled = True
        'actionClass.DoLeave(TextBox1.Text, Date.Now, Date.Now.AddMinutes(10), False, "其他")

    End Sub

    Private Sub messageCheckedTimer_Tick(sender As Object, e As EventArgs) Handles PostTimerThread.Tick

        '当Set事件完成且Post事件未完成时执行
        If actionClass.finishSet And Not actionClass.finishPost Then

            '执行去除短信操作
            If Not actionClass.ifMessageForTimer Then
                Dim ifMessageHtml As HtmlElement = WebBrowserBox.Document.GetElementById("ctl00_ContentPlaceHolder1_CheckBox1")
                ifMessageHtml.SetAttribute("checked", Nothing)
                ifMessageHtml.InvokeMember("onclick")
            End If

            '执行提交保存操作
            Dim PostHtml As HtmlElement = WebBrowserBox.Document.GetElementById("ctl00_ContentPlaceHolder1_Button1")
            PostHtml.InvokeMember("click")

            '完成后标记Post已经完成
            actionClass.finishPost = True

            '标记Set未完成并启动下一次任务
            actionClass.finishSet = False

            StatusLabel.Text = "完成"

            '标记不是第一次Post
            actionClass.finishPost = False

        End If

    End Sub

    Private Sub OpenExcel_Click_1(sender As Object, e As EventArgs) Handles OpenExcel.Click
        If OpenFileDialog.ShowDialog = DialogResult.OK Then

            Dim strConn As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + OpenFileDialog.FileName + ";Extended Properties='Excel 12.0;HDR=No'"
            Dim DataAdapter As New OleDbDataAdapter("select * from [Sheet1$]", strConn)
            DataAdapter.Fill(DataSet)
            ExcelState.Text = "该列表中包含" + Str(DataSet.Tables(0).Rows.Count - 1) + "个学生"

            'DataSet.Tables(0).Rows(2).Item(5).ToString()
        End If
    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles Button2.Click
        DataSet.Clear()
        ExcelState.Text = "请打开答题卡结果文件"
    End Sub

    Private Sub StartLeaveButton_Click(sender As Object, e As EventArgs) Handles StartLeaveButton.Click

        '读入请假配置数据
        Dim LeaverulesTableAdapter As New settingDataSetTableAdapters.leaverulesTableAdapter
        Dim SettingDataSet As New settingDataSet
        LeaverulesTableAdapter.Fill(SettingDataSet.leaverules)

        If classListBox.SelectedItem <> Nothing And gradeListBox.SelectedItem <> Nothing And DataSet.Tables.Count <> 0 And SettingDataSet.leaverules.Rows.Count <> 0 Then
            '设置完成，开始请假操作
            Dim RulesCount As Integer = SettingDataSet.leaverules.Rows.Count
            Dim stuCount As Integer = DataSet.Tables(0).Rows.Count

            For i = 0 To RulesCount - 1
                '逐个规则执行请假操作
                Dim ID As Integer = SettingDataSet.leaverules.Rows(i).Item(0).ToString
                Dim Choice = SettingDataSet.leaverules.Rows(i).Item(1).ToString
                Dim startTime As Date = SettingDataSet.leaverules.Rows(i).Item(2)
                Dim endTime As Date = SettingDataSet.leaverules.Rows(i).Item(3)
                Dim ifMessage As Boolean = SettingDataSet.leaverules.Rows(i).Item(4)
                Dim leaveType = SettingDataSet.leaverules.Rows(i).Item(5).ToString

                '对学生列表进行循环操作
                For a = 1 To stuCount - 1
                    If DataSet.Tables(0).Rows(a).Item(4 + ID) = Choice Then
                        '逐个提交请假
                        Dim name As String = DataSet.Tables(0).Rows(a).Item(1)

                        '一直循环 等待上一次Post完成
                        While True
                            '上一次Post完成后 执行本次请假


                            If actionClass.finishPost Or actionClass.firstPost Then
                                'MessageBox.Show("第一次" + actionClass.firstPost.ToString)
                                actionClass.DoLeave(name, startTime, endTime, ifMessage, leaveType)

                                '请假完成 跳出循环
                                Exit While
                            End If
                        End While

                    End If
                Next
            Next

            If actionClass.unFoundName <> Nothing Then
                MessageBox.Show("请假完成，未发现以下同学" + actionClass.unFoundName.ToString)
                actionClass.unFoundName = Nothing
            Else
                MessageBox.Show("全部请假完成")
            End If

        Else
            MessageBox.Show("设置未完成")
        End If
    End Sub
End Class
