Imports System.Data.OleDb

Public Class FormRegister
    Dim pro As String
    Dim connstring As String
    Dim command As String
    Dim myconnection As OleDbConnection = New OleDbConnection

    Private Sub FormRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LiraDatabaseLatest.Subjects' table. You can move, or remove it, as needed.
        Me.SubjectsTableAdapter1.Fill(Me.LiraDatabaseLatest.Subjects)
        'TODO: This line of code loads data into the 'LiraDatabaseLatest.Students' table. You can move, or remove it, as needed.
        Me.StudentsTableAdapter1.Fill(Me.LiraDatabaseLatest.Students)
        'TODO: This line of code loads data into the 'LIRADATABASEDataSet.Students' table. You can move, or remove it, as needed.
        Me.StudentsTableAdapter.Fill(Me.LIRADATABASEDataSet.Students)
        'TODO: This line of code loads data into the 'LIRADATABASEDataSet3.Subjects' table. You can move, or remove it, as needed.
        Me.SubjectsTableAdapter.Fill(Me.LIRADATABASEDataSet3.Subjects)






    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        StudentsBindingSource2.Filter = "(convert(studentname, 'System.String') LIKE '%" & TextBox1.Text & "%')"
        If StudentsBindingSource2.Count <> 0 Then
            With ComboBox1
                .DataSource = StudentsBindingSource2
            End With
        Else MsgBox("the search item was not found")
            StudentsBindingSource2.Filter = Nothing
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        StudentsBindingSource2.Filter = Nothing
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        pro = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\luqma\Documents\StudentInfo2\LIRADATABASE.accdb"
        connstring = pro
        myconnection.ConnectionString = connstring
        myconnection.Open()
        command = " insert into RegisteredStudents ([StudentName], [Subject1], [Credit1], [Credit2], [Subject2], [Credit3], [Subject3], [Credit4], [Subject4], [Credit5], [Subject5], [Credit6], [Subject6], [Credit7], [Subject7], [Credit8], [Subject8], [Name1], [Name2], [Name3], [Name4], [Name5], [Name6], [Name7],  [Name8],  [StudentIC], [StudentClass], [StudentEmail]) values 
        ('" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & Label11.Text & "', '" & Label14.Text & "', '" & ComboBox5.Text & "', '" & Label18.Text & "', '" & ComboBox7.Text & "', '" & Label21.Text & "', '" & ComboBox9.Text & "', '" & Label24.Text & "', '" & ComboBox11.Text & "', '" & Label27.Text & "', '" & ComboBox13.Text & "', '" & Label30.Text & "', '" & ComboBox15.Text & "', '" & Label33.Text & "', '" & ComboBox17.Text & "', '" & Label13.Text & "', '" & Label15.Text & "', '" & Label17.Text & "' , '" & Label20.Text & "' , '" & Label23.Text & "' , '" & Label26.Text & "' , '" & Label29.Text & "', '" & Label32.Text & "', '" & Label35.Text & "', '" & Label37.Text & "', '" & Label39.Text & "')"

        Dim cmd As OleDbCommand = New OleDbCommand(command, myconnection)
        cmd.Parameters.Add(New OleDbParameter("StudentName", CType(ComboBox1.Text, String)))



        cmd.Parameters.Add(New OleDbParameter("Subject1", CType(ComboBox2.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Credit1", CType(Label11.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Name1", CType(Label13.Text, String)))

        cmd.Parameters.Add(New OleDbParameter("Credit2", CType(Label14.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Subject2", CType(ComboBox5.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Name2", CType(Label15.Text, String)))

        cmd.Parameters.Add(New OleDbParameter("Credit3", CType(Label18.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Subject3", CType(ComboBox7.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Name3", CType(Label17.Text, String)))

        cmd.Parameters.Add(New OleDbParameter("Credit4", CType(Label21.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Subject4", CType(ComboBox9.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Name4", CType(Label20.Text, String)))

        cmd.Parameters.Add(New OleDbParameter("Credit5", CType(Label24.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Subject5", CType(ComboBox11.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Name5", CType(Label23.Text, String)))

        cmd.Parameters.Add(New OleDbParameter("Credit6", CType(Label27.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Subject6", CType(ComboBox13.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Name6", CType(Label26.Text, String)))

        cmd.Parameters.Add(New OleDbParameter("Credit7", CType(Label30.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Subject7", CType(ComboBox15.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Name7", CType(Label29.Text, String)))

        cmd.Parameters.Add(New OleDbParameter("Credit8", CType(Label33.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Subject8", CType(ComboBox17.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Name8", CType(Label32.Text, String)))

        cmd.Parameters.Add(New OleDbParameter("StudentIC", CType(Label35.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("StudentClass", CType(Label37.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("StudentEmail", CType(Label39.Text, String)))

        MsgBox("Record has been saved.")
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox5.Text = ""
        ComboBox7.Text = ""
        ComboBox9.Text = ""
        ComboBox11.Text = ""
        ComboBox13.Text = ""
        ComboBox15.Text = ""
        ComboBox17.Text = ""

        Label11.Text = ""
        Label13.Text = ""
        Label14.Text = ""
        Label15.Text = ""
        Label18.Text = ""
        Label17.Text = ""
        Label21.Text = ""
        Label20.Text = ""
        Label24.Text = ""
        Label27.Text = ""
        Label26.Text = ""
        Label30.Text = ""
        Label29.Text = ""
        Label33.Text = ""
        Label32.Text = "-"
        'Label35.Text = "-"
        'Label37.Text = "-"
        'Label39.Text = "-"
    End Sub

    Private Sub RegisteredStudentsListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisteredStudentsListToolStripMenuItem.Click
        ListRegistered.ShowDialog()
    End Sub

    Private Sub StudentsRegisteredSubjectsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentsRegisteredSubjectsToolStripMenuItem.Click
        DisplayRegister.ShowDialog()

    End Sub
End Class