Public Class ListStudent
    Private Sub StudentsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles StudentsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StudentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LIRADATABASEDataSet)

    End Sub

    Private Sub ListStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LIRADATABASEDataSet.Students' table. You can move, or remove it, as needed.
        Me.StudentsTableAdapter.Fill(Me.LIRADATABASEDataSet.Students)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        StudentsBindingSource.Filter = "(convert(studentname, 'System.String') LIKE '%" & TextBox1.Text & "%')"
        If StudentsBindingSource.Count <> 0 Then
            With StudentsDataGridView
                .DataSource = StudentsBindingSource
            End With
        Else MsgBox("the search item was not found")
            StudentsBindingSource.Filter = Nothing
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        StudentsBindingSource.Filter = "(convert(studentic, 'System.String') LIKE '%" & TextBox1.Text & "%')"
        If StudentsBindingSource.Count <> 0 Then
            With StudentsDataGridView
                .DataSource = StudentsBindingSource
            End With
        Else MsgBox("the search item was not found")
            StudentsBindingSource.Filter = Nothing
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        StudentsBindingSource.Filter = Nothing
    End Sub
End Class