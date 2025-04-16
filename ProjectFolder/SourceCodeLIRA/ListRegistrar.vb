Public Class ListRegistrar
    Private Sub LoginBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles LoginBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.LoginBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LiraDatabaseUser)

    End Sub

    Private Sub ListRegistrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LiraDatabaseUser.Login' table. You can move, or remove it, as needed.
        Me.LoginTableAdapter.Fill(Me.LiraDatabaseUser.Login)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Try
            LoginBindingSource.EndEdit()
            LoginTableAdapter.Update(LiraDatabaseUser.Login)
            MessageBox.Show("Data Saved")

        Catch ex As Exception
            MessageBox.Show("Error trying to save data")
        End Try
    End Sub
End Class