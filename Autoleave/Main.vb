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

    Private Sub lock_Click(sender As Object, e As EventArgs) Handles lock.Click

        classListBox.Enabled = Not gradeListBox.Enabled
        gradeListBox.Enabled = Not gradeListBox.Enabled
        renovate.Enabled = Not renovate.Enabled

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click


        PostTimerThread.Enabled = True
        actionClass.DoLeave(TextBox1.Text, Date.Now, Date.Now.AddHours(10), False, "其他")

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

        End If

    End Sub
End Class
