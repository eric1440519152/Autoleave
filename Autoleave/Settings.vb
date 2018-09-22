Imports System.ComponentModel

Public Class Settings

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles addButton.Click
        If MaskedTextBox1.Text <> Nothing And choices.SelectedItem <> Nothing And leaveType.SelectedItem <> Nothing Then
            Dim datas() As Object = {MaskedTextBox1.Text, choices.SelectedItem.ToString(), startTimeBox.Value.ToString(), endTimeBox.Value.ToString(), message.Checked, leaveType.SelectedItem.ToString()}
            SettingDataSet.leaverules.Rows.Add(datas)
            LeaverulesTableAdapter.Update(SettingDataSet.leaverules)
        End If


    End Sub

    Private Sub startTimeBox_ValueChanged(sender As Object, e As EventArgs) Handles startTimeBox.ValueChanged

        endTimeBox.MinDate = startTimeBox.Value.AddMinutes(10)

    End Sub

    Private Sub endTimeBox_ValueChanged(sender As Object, e As EventArgs) Handles endTimeBox.ValueChanged

        startTimeBox.MaxDate = endTimeBox.Value.AddMinutes(-10)

    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: 这行代码将数据加载到表“SettingDataSet.leaverules”中。您可以根据需要移动或删除它。
        Me.LeaverulesTableAdapter.Fill(Me.SettingDataSet.leaverules)
        endTimeBox.MinDate = startTimeBox.Value.AddMinutes(10)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        LeaverulesTableAdapter.Update(SettingDataSet.leaverules)

    End Sub

End Class