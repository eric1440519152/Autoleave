Public Class ClassAction
    Public unFoundName() As String
    Public finishPost As Boolean
    Public finishSet As Boolean
    Public ifMessageForTimer As Boolean

    ''' <summary>
    ''' 用于执行单个请假操作,请注意，在下一次调用该函数前应先判断finishPost已经完成
    ''' </summary>
    ''' <param name="name">请假人姓名 不要传入其他任何字符</param>
    ''' <param name="startDate">开始的日期 包括时间Date格式</param>
    ''' <param name="endDate">结束的日期 包括时间Date格式</param>
    ''' <param name="ifMessage">是否需要发送短信</param>
    ''' <param name="leaveTypes">请假的理由 文本型</param>
    ''' <returns></returns>
    ''' 
    Public Function DoLeave(name As String, startDate As Date, endDate As Date, ifMessage As Boolean, leaveTypes As String) As Boolean


        '状态变量
        Dim checkStu As Boolean = False

        '预制HTML控件到实例化
        Dim nameList As HtmlElement = Main.WebBrowserBox.Document.GetElementById("ctl00_ContentPlaceHolder1_DropDownList3")
        Dim startDateHtml As HtmlElement = Main.WebBrowserBox.Document.GetElementById("ctl00_ContentPlaceHolder1_TextBox6")
        Dim endDateHtml As HtmlElement = Main.WebBrowserBox.Document.GetElementById("ctl00_ContentPlaceHolder1_TextBox7")
        Dim startHHtml As HtmlElement = Main.WebBrowserBox.Document.GetElementById("ctl00_ContentPlaceHolder1_TextBox8")
        Dim endHHtml As HtmlElement = Main.WebBrowserBox.Document.GetElementById("ctl00_ContentPlaceHolder1_TextBox10")
        Dim startMHtml As HtmlElement = Main.WebBrowserBox.Document.GetElementById("ctl00_ContentPlaceHolder1_TextBox9")
        Dim endMHtml As HtmlElement = Main.WebBrowserBox.Document.GetElementById("ctl00_ContentPlaceHolder1_TextBox11")
        Dim leaveTypeIllnessHtml As HtmlElement = Main.WebBrowserBox.Document.GetElementById("ctl00_ContentPlaceHolder1_RadioButton1")
        Dim leaveTypeGetsomthingHtml As HtmlElement = Main.WebBrowserBox.Document.GetElementById("ctl00_ContentPlaceHolder1_RadioButton3")
        Dim leaveTypeCasualHtml As HtmlElement = Main.WebBrowserBox.Document.GetElementById("ctl00_ContentPlaceHolder1_RadioButton5")
        Dim leaveTypeStudyHtml As HtmlElement = Main.WebBrowserBox.Document.GetElementById("ctl00_ContentPlaceHolder1_RadioButton7")
        Dim leaveTypeHairCutHtml As HtmlElement = Main.WebBrowserBox.Document.GetElementById("ctl00_ContentPlaceHolder1_RadioButton4")
        Dim leaveTypeShopingHtml As HtmlElement = Main.WebBrowserBox.Document.GetElementById("ctl00_ContentPlaceHolder1_RadioButton2")
        Dim leaveTypeBankHtml As HtmlElement = Main.WebBrowserBox.Document.GetElementById("ctl00_ContentPlaceHolder1_RadioButton6")
        Dim leaveTypeOthersHtml As HtmlElement = Main.WebBrowserBox.Document.GetElementById("ctl00_ContentPlaceHolder1_RadioButton8")


        For i = 0 To nameList.Children.Count - 2 Step 1
            nameList.Children.Item(i).SetAttribute("selected", Nothing)

            '如果在下拉列表检测到名字
            If InStr(nameList.Children.Item(i).GetAttribute("value"), name) Then

                Main.StatusLabel.Text = "正在请 " + name + " 的假"

                '选中选项
                nameList.Children.Item(i).SetAttribute("selected", "selected")
                nameList.InvokeMember("onchange")
                checkStu = True

                '执行请假操作

                '改变请假事由
                Select Case leaveTypes
                    Case "生病就医"

                        leaveTypeIllnessHtml.SetAttribute("checked", "checked")
                        leaveTypeGetsomthingHtml.SetAttribute("checked", Nothing)
                        leaveTypeBankHtml.SetAttribute("checked", Nothing)
                        leaveTypeCasualHtml.SetAttribute("checked", Nothing)
                        leaveTypeHairCutHtml.SetAttribute("checked", Nothing)
                        leaveTypeShopingHtml.SetAttribute("checked", Nothing)
                        leaveTypeStudyHtml.SetAttribute("checked", Nothing)
                        leaveTypeOthersHtml.SetAttribute("checked", Nothing)

                        leaveTypeIllnessHtml.InvokeMember("onclick")

                    Case "回家取物"

                        leaveTypeIllnessHtml.SetAttribute("checked", Nothing)
                        leaveTypeGetsomthingHtml.SetAttribute("checked", "checked")
                        leaveTypeBankHtml.SetAttribute("checked", Nothing)
                        leaveTypeCasualHtml.SetAttribute("checked", Nothing)
                        leaveTypeHairCutHtml.SetAttribute("checked", Nothing)
                        leaveTypeShopingHtml.SetAttribute("checked", Nothing)
                        leaveTypeStudyHtml.SetAttribute("checked", Nothing)
                        leaveTypeOthersHtml.SetAttribute("checked", Nothing)

                        leaveTypeGetsomthingHtml.InvokeMember("onclick")

                    Case "家中有事"

                        leaveTypeIllnessHtml.SetAttribute("checked", Nothing)
                        leaveTypeGetsomthingHtml.SetAttribute("checked", Nothing)
                        leaveTypeBankHtml.SetAttribute("checked", Nothing)
                        leaveTypeCasualHtml.SetAttribute("checked", "checked")
                        leaveTypeHairCutHtml.SetAttribute("checked", Nothing)
                        leaveTypeShopingHtml.SetAttribute("checked", Nothing)
                        leaveTypeStudyHtml.SetAttribute("checked", Nothing)
                        leaveTypeOthersHtml.SetAttribute("checked", Nothing)

                        leaveTypeCasualHtml.InvokeMember("onclick")

                    Case "外出补习"

                        leaveTypeIllnessHtml.SetAttribute("checked", Nothing)
                        leaveTypeGetsomthingHtml.SetAttribute("checked", Nothing)
                        leaveTypeBankHtml.SetAttribute("checked", Nothing)
                        leaveTypeCasualHtml.SetAttribute("checked", Nothing)
                        leaveTypeHairCutHtml.SetAttribute("checked", Nothing)
                        leaveTypeShopingHtml.SetAttribute("checked", Nothing)
                        leaveTypeStudyHtml.SetAttribute("checked", "checked")
                        leaveTypeOthersHtml.SetAttribute("checked", Nothing)

                        leaveTypeStudyHtml.InvokeMember("onclick")

                    Case "购物"

                        leaveTypeIllnessHtml.SetAttribute("checked", Nothing)
                        leaveTypeGetsomthingHtml.SetAttribute("checked", Nothing)
                        leaveTypeBankHtml.SetAttribute("checked", Nothing)
                        leaveTypeCasualHtml.SetAttribute("checked", Nothing)
                        leaveTypeHairCutHtml.SetAttribute("checked", Nothing)
                        leaveTypeShopingHtml.SetAttribute("checked", "checked")
                        leaveTypeStudyHtml.SetAttribute("checked", Nothing)
                        leaveTypeOthersHtml.SetAttribute("checked", Nothing)

                        leaveTypeShopingHtml.InvokeMember("onclick")

                    Case "理发"

                        leaveTypeIllnessHtml.SetAttribute("checked", Nothing)
                        leaveTypeGetsomthingHtml.SetAttribute("checked", Nothing)
                        leaveTypeBankHtml.SetAttribute("checked", Nothing)
                        leaveTypeCasualHtml.SetAttribute("checked", Nothing)
                        leaveTypeHairCutHtml.SetAttribute("checked", "checked")
                        leaveTypeShopingHtml.SetAttribute("checked", Nothing)
                        leaveTypeStudyHtml.SetAttribute("checked", Nothing)
                        leaveTypeOthersHtml.SetAttribute("checked", Nothing)

                        leaveTypeHairCutHtml.InvokeMember("onclick")

                    Case "取款"

                        leaveTypeIllnessHtml.SetAttribute("checked", Nothing)
                        leaveTypeGetsomthingHtml.SetAttribute("checked", Nothing)
                        leaveTypeBankHtml.SetAttribute("checked", "checked")
                        leaveTypeCasualHtml.SetAttribute("checked", Nothing)
                        leaveTypeHairCutHtml.SetAttribute("checked", Nothing)
                        leaveTypeShopingHtml.SetAttribute("checked", Nothing)
                        leaveTypeStudyHtml.SetAttribute("checked", Nothing)
                        leaveTypeOthersHtml.SetAttribute("checked", Nothing)

                        leaveTypeBankHtml.InvokeMember("onclick")

                    Case "其他"

                        leaveTypeIllnessHtml.SetAttribute("checked", Nothing)
                        leaveTypeGetsomthingHtml.SetAttribute("checked", Nothing)
                        leaveTypeBankHtml.SetAttribute("checked", Nothing)
                        leaveTypeCasualHtml.SetAttribute("checked", Nothing)
                        leaveTypeHairCutHtml.SetAttribute("checked", Nothing)
                        leaveTypeShopingHtml.SetAttribute("checked", Nothing)
                        leaveTypeStudyHtml.SetAttribute("checked", Nothing)
                        leaveTypeOthersHtml.SetAttribute("checked", "checked")

                        leaveTypeOthersHtml.InvokeMember("onclick")

                End Select

                MessageBox.Show("开始时间" + startDate.ToString("yyyy-MM-dd HH:mm") + "\n结束时间" + endDate.ToString("yyyy-MM-dd HH:mm"))

                '格式化并输出请假日期
                startDateHtml.SetAttribute("value", startDate.ToString("yyyy-MM-dd"))
                endDateHtml.SetAttribute("value", endDate.ToString("yyyy-MM-dd"))

                startHHtml.SetAttribute("value", startDate.ToString("HH"))
                endHHtml.SetAttribute("value", endDate.ToString("HH"))

                startMHtml.SetAttribute("value", startDate.ToString("mm"))
                endMHtml.SetAttribute("value", endDate.ToString("mm"))

                '将发送短信的参数传出 并交由PostTimer处理
                ifMessageForTimer = ifMessage

                '标记已经完成设置 将任务移交PostTimer
                finishSet = True

                '标记Post事件未完成 将任务移交PostTimer
                finishPost = False

                '跳出循环 记录未找到的名字
                Exit For

            End If

        Next

        '向数组中添加未被找到的名字
        If checkStu = False Then
            unFoundName(unFoundName.Count + 1) = name
        End If


        Return True

    End Function



End Class
