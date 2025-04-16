Public Class FormSubject
    Private Sub SubjectsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SubjectsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SubjectsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LIRADATABASEDataSet3)

    End Sub

    Private Sub FormSubject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LIRADATABASEDataSet3.Subjects' table. You can move, or remove it, as needed.
        Me.SubjectsTableAdapter.Fill(Me.LIRADATABASEDataSet3.Subjects)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SubjectsBindingSource.Filter = "(convert(Subjectname, 'System.String') LIKE '%" & TextBox1.Text & "%')"
        If SubjectsBindingSource.Count <> 0 Then
            With SubjectsDataGridView
                .DataSource = SubjectsBindingSource
            End With
        Else MsgBox("the search item was not found")
            SubjectsBindingSource.Filter = Nothing
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SubjectsBindingSource.Filter = "(convert(Code, 'System.String') LIKE '%" & TextBox1.Text & "%')"
        If SubjectsBindingSource.Count <> 0 Then
            With SubjectsDataGridView
                .DataSource = SubjectsBindingSource
            End With
        Else MsgBox("the search item was not found")
            SubjectsBindingSource.Filter = Nothing
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SubjectsBindingSource.Filter = Nothing
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim imagebmp As New Bitmap(Me.SubjectsDataGridView.Width, Me.SubjectsDataGridView.Height)
        SubjectsDataGridView.DrawToBitmap(imagebmp, New Rectangle(0, 0, Me.SubjectsDataGridView.Width, Me.SubjectsDataGridView.Height))

        e.Graphics.DrawImage(imagebmp, 100, 125)

        Dim fontright As New Font("Courier New", 14, FontStyle.Italic)
        Dim fonte As New Font("Consolas", 16, FontStyle.Bold)

        e.Graphics.DrawString("LIRA Academy Subject List", fonte, Brushes.Black, 250, 75)
        e.Graphics.DrawString("LIRA SYSTEMS 2021 © All Rights Reserved", fontright, Brushes.Black, 75, 600)


    End Sub
End Class