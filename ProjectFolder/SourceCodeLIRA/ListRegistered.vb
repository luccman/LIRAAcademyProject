Public Class ListRegistered
    Private Sub RegisteredStudentsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles RegisteredStudentsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RegisteredStudentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LiraDatabaseFinal)

    End Sub

    Private Sub ListRegistered_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LiraDatabaseFinal.RegisteredStudents' table. You can move, or remove it, as needed.
        Me.RegisteredStudentsTableAdapter.Fill(Me.LiraDatabaseFinal.RegisteredStudents)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RegisteredStudentsBindingSource.Filter = "(convert(subject1, 'System.String') LIKE '%" & TextBox1.Text & "%')"

        If RegisteredStudentsBindingSource.Count <> 0 Then
            With RegisteredStudentsDataGridView
                .DataSource = RegisteredStudentsBindingSource
            End With
        Else MsgBox("the search item was not found")
            RegisteredStudentsBindingSource.Filter = Nothing
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RegisteredStudentsBindingSource.Filter = "(convert(studentname, 'System.String') LIKE '%" & TextBox1.Text & "%')"
        If RegisteredStudentsBindingSource.Count <> 0 Then
            With RegisteredStudentsDataGridView
                .DataSource = RegisteredStudentsBindingSource
            End With
        Else MsgBox("the search item was not found")
            RegisteredStudentsBindingSource.Filter = Nothing
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RegisteredStudentsBindingSource.Filter = Nothing
        TextBox1.Clear()
    End Sub
End Class