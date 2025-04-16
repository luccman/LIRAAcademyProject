Imports System.Data.OleDb

Public Class FormClass
    Dim pro As String
    Dim connstring As String
    Dim command As String
    Dim myconnection As OleDbConnection = New OleDbConnection

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.Columns.Add("Class ID", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("Class Name", 250, HorizontalAlignment.Left)
        ListView1.Columns.Add("Class Level", 200, HorizontalAlignment.Left)
        ListView1.Columns.Add("Number of Students", 200, HorizontalAlignment.Left)
    End Sub

    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        If ListView1.SelectedItems.Count > 0 Then
            TextBox1.Text = ListView1.SelectedItems(0).SubItems(0).Text
            TextBox2.Text = ListView1.SelectedItems(0).SubItems(1).Text
            TextBox3.Text = ListView1.SelectedItems(0).SubItems(2).Text
            TextBox4.Text = ListView1.SelectedItems(0).SubItems(3).Text
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim newitem As New ListViewItem(TextBox1.Text)
        newitem.SubItems.Add(TextBox2.Text)
        newitem.SubItems.Add(TextBox3.Text)
        newitem.SubItems.Add(TextBox4.Text)

        ListView1.Items.Add(newitem)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ListView1.SelectedItems.Count > 0 Then
            ListView1.SelectedItems(0).SubItems(0).Text = TextBox1.Text
            ListView1.SelectedItems(0).SubItems(1).Text = TextBox2.Text
            ListView1.SelectedItems(0).SubItems(2).Text = TextBox3.Text
            ListView1.SelectedItems(0).SubItems(3).Text = TextBox4.Text
        End If
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ListView1.SelectedItems.Count > 0 Then
            ListView1.Items.Remove(ListView1.SelectedItems(0))
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ListView1.Items.Clear()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        pro = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\luqma\Documents\StudentInfo2\LIRADATABASE.accdb"
        connstring = pro
        myconnection.ConnectionString = connstring
        myconnection.Open()
        command = " insert into ClassList ([ClassID], [ClassName], [ClassLevel], [NumStudents]) values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "', '" & TextBox4.Text & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(command, myconnection)
        cmd.Parameters.Add(New OleDbParameter("ClassID", CType(TextBox1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("ClassName", CType(TextBox2.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("ClassLevel", CType(TextBox3.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("NumStudents", CType(TextBox4.Text, String)))
        MsgBox("Record has been saved.")
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ClassListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClassListToolStripMenuItem.Click
        ListClass.ShowDialog()

    End Sub


End Class

