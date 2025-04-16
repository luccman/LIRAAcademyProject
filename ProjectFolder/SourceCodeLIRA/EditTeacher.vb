Public Class EditTeacher
    Private Sub TeachersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TeachersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TeachersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LIRADATABASEDataSet1)

    End Sub

    Private Sub EditTeacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LIRADATABASEDataSet1.Teachers' table. You can move, or remove it, as needed.
        Me.TeachersTableAdapter.Fill(Me.LIRADATABASEDataSet1.Teachers)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.TeachersBindingSource.AddNew()
    End Sub

    Private Sub TeachersBindingNavigator_RefreshItems(sender As Object, e As EventArgs) Handles TeachersBindingNavigator.RefreshItems

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TeachersBindingSource.RemoveCurrent()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Try
            TeachersBindingSource.EndEdit()
            TeachersTableAdapter.Update(LIRADATABASEDataSet1.Teachers)
            MessageBox.Show("Data Saved")

        Catch ex As Exception
            MessageBox.Show("Error trying to save data")
        End Try

    End Sub
End Class