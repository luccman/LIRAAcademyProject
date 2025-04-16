Public Class ListStaff
    Private Sub LoginStaffBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles LoginStaffBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.LoginStaffBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LiraDatabaseUser)

    End Sub

    Private Sub ListStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LiraDatabaseUser.LoginStaff' table. You can move, or remove it, as needed.
        Me.LoginStaffTableAdapter.Fill(Me.LiraDatabaseUser.LoginStaff)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            LoginStaffBindingSource.EndEdit()
            LoginStaffTableAdapter.Update(LiraDatabaseUser.LoginStaff)
            MessageBox.Show("Data Saved")

        Catch ex As Exception
            MessageBox.Show("Error trying to save data")
        End Try
    End Sub
End Class