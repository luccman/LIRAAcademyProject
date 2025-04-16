Public Class ListClass
    Private Sub ClassListBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ClassListBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClassListBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LIRADATABASEDataSet)

    End Sub

    Private Sub ListClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LIRADATABASEDataSet.ClassList' table. You can move, or remove it, as needed.
        Me.ClassListTableAdapter.Fill(Me.LIRADATABASEDataSet.ClassList)

    End Sub
End Class