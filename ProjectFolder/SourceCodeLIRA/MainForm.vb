Public Class MainForm
    Dim ExitYN As System.Windows.Forms.DialogResult
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' FormStudent.Show()
        switchpanel(FormStudent)
        FormTeacher.Close()
        FormClass.Close()
        FormRegister.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'FormClass.Show()
        switchpanel(FormClass)
        FormStudent.Close()
        FormTeacher.Close()


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Hide()
    End Sub


    Private Sub MyForm_Closing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        switchpanel(FormSubject)
    End Sub

    Private Sub Panel3_paint(sender As Object, e As PaintEventArgs)

    End Sub

    Sub switchpanel(ByVal panel As Form)

        Panel3.Controls.Clear()
        panel.TopLevel = False
        Panel3.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Panel3.Controls.Clear()
        FormRegister.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        switchpanel(FormTeacher)
        FormClass.Close()
        FormStudent.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        switchpanel(FormRegister)

    End Sub
End Class