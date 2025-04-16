Public Class ManageUser
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        switchpanel(ListRegistrar)
        ListStaff.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        switchpanel(ListStaff)
        ListRegistrar.Close()


    End Sub

    Private Sub MyForm_Closing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Sub switchpanel(ByVal panel As Form)

        Panel2.Controls.Clear()
        panel.TopLevel = False
        Panel2.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FormUser.Show()
        Me.Hide()
    End Sub
End Class