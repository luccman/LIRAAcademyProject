Public Class FormTeacher
    Private Sub TeachersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TeachersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LIRADATABASEDataSet1)

    End Sub

    Private Sub FormTeacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LIRADATABASEDataSet1.Teachers' table. You can move, or remove it, as needed.
        Me.TeachersTableAdapter.Fill(Me.LIRADATABASEDataSet1.Teachers)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TeachersBindingSource.Filter = "(convert(name, 'System.String') LIKE '%" & TextBox1.Text & "%')"
        If TeachersBindingSource.Count <> 0 Then
            With TeachersDataGridView
                .DataSource = TeachersBindingSource
            End With
        Else MsgBox("the search item was not found")
            TeachersBindingSource.Filter = Nothing
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TeachersBindingSource.Filter = "(convert(IC, 'System.String') LIKE '%" & TextBox1.Text & "%')"
        If TeachersBindingSource.Count <> 0 Then
            With TeachersDataGridView
                .DataSource = TeachersBindingSource
            End With
        Else MsgBox("the search item was not found")
            TeachersBindingSource.Filter = Nothing
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        EditTeacher.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TeachersBindingSource.Filter = Nothing
    End Sub
End Class