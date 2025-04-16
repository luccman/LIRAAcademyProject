' Login Code and Page 

Imports System.Data.OleDb
Imports System.Data


Public Class Form1
    Dim connection As New OleDbConnection(My.Settings.LIRADATABASEConnectionString)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = Nothing Or TextBox2.Text = Nothing Then
            MsgBox("Enter Credentials ", MsgBoxStyle.Exclamation)
        Else
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            Dim cmd As New OleDbCommand("select count(*) from login where username =? and Ipassword =?", connection)
            cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = TextBox1.Text
            cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = TextBox2.Text
            Dim count = Convert.ToInt32(cmd.ExecuteScalar())

            If (count > 0) Then
                MsgBox("Login Succeed", MsgBoxStyle.Information)
                MainForm.Show()
                Me.Hide()
            Else
                MsgBox("Account not found check credentials", MsgBoxStyle.Critical)
            End If
        End If

        TextBox1.Clear()
        TextBox2.Clear()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormUser.Show()
        Me.Hide()

    End Sub

End Class
