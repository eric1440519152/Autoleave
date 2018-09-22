Public Class Form1

    Dim gradeList As HtmlElement
    Dim gradeCount As Int16 = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim entryBtn As HtmlElement = WebBrowser1.Document.All.GetElementsByName("btnEntry").Item(0)
        Dim userIdBox As HtmlElement = WebBrowser1.Document.All.GetElementsByName("txtName").Item(0)
        Dim passWdBox As HtmlElement = WebBrowser1.Document.All.GetElementsByName("txtPwd").Item(0)

        'Dim form1 As HtmlElement = WebBrowser1.Document.Forms.GetElementsByName("form1").Item(0)

        userIdBox.SetAttribute("value", UserId.Text)
        passWdBox.SetAttribute("value", PassWd.Text)
        entryBtn.InvokeMember("click")


    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

        If WebBrowser1.Url.ToString = "http://www.gxufz.com:1234/QJInfoAdd.aspx" Then

            gradeListBox.Items.Clear()

            LoginGroup.Enabled = False

            gradeList = WebBrowser1.Document.GetElementById("ctl00_ContentPlaceHolder1_DropDownList1")

            gradeCount = gradeList.Children.Count

            For i = 0 To gradeCount - 2 Step 1
                gradeListBox.Items.Add(gradeList.Children.Item(i).GetAttribute("value"))
            Next

        End If



    End Sub

    Private Sub gradeListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gradeListBox.SelectedIndexChanged

        For i = 0 To gradeCount - 2 Step 1
            gradeList.Children.Item(i).SetAttribute("selected", Nothing)
        Next

        gradeList.Children.Item(gradeListBox.SelectedIndex).SetAttribute("selected", "selected")
        gradeList.InvokeMember("onchange")


        Dim classList As HtmlElement = WebBrowser1.Document.GetElementById("ctl00_ContentPlaceHolder1_DropDownList2")
        Dim classCount As Int16 = classList.Children.Count

        For i = 0 To classCount - 2 Step 1
            classListBox.Items.Add(classList.Children.Item(i).GetAttribute("value"))
        Next


        Dim nameList As HtmlElement = WebBrowser1.Document.GetElementById("ctl00_ContentPlaceHolder1_DropDownList3")
    End Sub
End Class
