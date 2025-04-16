Public Class DisplayRegister


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Label40.Text = "--"
        Label39.Text = "--"
    End Sub

    Private Sub DisplayRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LiraDatabaseFinal.RegisteredStudents' table. You can move, or remove it, as needed.
        Me.RegisteredStudentsTableAdapter.Fill(Me.LiraDatabaseFinal.RegisteredStudents)

        'ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim totalcredit, cre1, cre2, cre3, cre4, cre5, cre6, cre7, cre8 As Double
        If Label31.Text = "" Then
            cre1 = 0
        Else
            cre1 = Label31.Text
        End If

        If Label30.Text = "" Then
            cre2 = 0
        Else
            cre2 = Label30.Text
        End If

        If Label29.Text = "" Then
            cre3 = 0
        Else
            cre3 = Label29.Text
        End If

        If Label28.Text = "" Then
            cre4 = 0
        Else
            cre4 = Label28.Text
        End If

        If Label27.Text = "" Then
            cre5 = 0
        Else
            cre5 = Label27.Text
        End If

        If Label26.Text = "" Then
            cre6 = 0
        Else
            cre6 = Label26.Text
        End If

        If Label25.Text = "" Then
            cre7 = 0
        Else
            cre7 = Label25.Text
        End If

        If Label24.Text = "" Then
            cre8 = 0
        Else
            cre8 = Label24.Text
        End If

        totalcredit = cre1 + cre2 + cre3 + cre4 + cre5 + cre6 + cre7 + cre8

        Label40.Text = totalcredit.ToString

        Label39.Text = totalcredit * 50
    End Sub

    Private Sub SlipPreviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SlipPreviewToolStripMenuItem.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintSlipToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintSlipToolStripMenuItem.Click
        PrintDialog1.Document = PrintDocument1
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub SlipSetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SlipSetupToolStripMenuItem.Click
        PageSetupDialog1.Document = PrintDocument1
        PageSetupDialog1.Document.DefaultPageSettings.Color = False
        PageSetupDialog1.ShowDialog()


    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim fontt As New Font("Consolas", 16, FontStyle.Regular)
        Dim fontb As New Font("Consolas", 16, FontStyle.Bold)

        e.Graphics.DrawString(Label2.Text, fontb, Brushes.Black, 75, 100)
        e.Graphics.DrawString(Label32.Text, fontt, Brushes.Black, 300, 100)
        e.Graphics.DrawString(Label7.Text, fontb, Brushes.Black, 75, 125)
        e.Graphics.DrawString(Label33.Text, fontt, Brushes.Black, 300, 125)
        e.Graphics.DrawString(Label6.Text, fontb, Brushes.Black, 75, 150)
        e.Graphics.DrawString(Label34.Text, fontt, Brushes.Black, 300, 150)
        e.Graphics.DrawString(Label35.Text, fontb, Brushes.Black, 75, 175)
        e.Graphics.DrawString(Label36.Text, fontt, Brushes.Black, 300, 175)
        e.Graphics.DrawString(Label38.Text, fontb, Brushes.Black, 75, 250)
        e.Graphics.DrawString(Label40.Text, fontt, Brushes.Black, 300, 250)
        e.Graphics.DrawString(Label37.Text, fontb, Brushes.Black, 75, 275)
        e.Graphics.DrawString(Label39.Text, fontt, Brushes.Black, 300, 275)


        Dim fonte As New Font("Consolas", 14, FontStyle.Regular)
        Dim fonter As New Font("Consolas", 14, FontStyle.Bold)

        e.Graphics.DrawString(Label3.Text, fonter, Brushes.Black, 75, 375)
        e.Graphics.DrawString(Label4.Text, fonter, Brushes.Black, 250, 375)
        e.Graphics.DrawString(Label5.Text, fonter, Brushes.Black, 650, 375)

        e.Graphics.DrawString(Label8.Text, fonte, Brushes.Black, 75, 425)
        e.Graphics.DrawString(Label23.Text, fonte, Brushes.Black, 250, 425)
        e.Graphics.DrawString(Label31.Text, fonte, Brushes.Black, 650, 425)

        e.Graphics.DrawString(Label9.Text, fonte, Brushes.Black, 75, 450)
        e.Graphics.DrawString(Label22.Text, fonte, Brushes.Black, 250, 450)
        e.Graphics.DrawString(Label30.Text, fonte, Brushes.Black, 650, 450)

        e.Graphics.DrawString(Label10.Text, fonte, Brushes.Black, 75, 475)
        e.Graphics.DrawString(Label21.Text, fonte, Brushes.Black, 250, 475)
        e.Graphics.DrawString(Label29.Text, fonte, Brushes.Black, 650, 475)

        e.Graphics.DrawString(Label11.Text, fonte, Brushes.Black, 75, 500)
        e.Graphics.DrawString(Label20.Text, fonte, Brushes.Black, 250, 500)
        e.Graphics.DrawString(Label28.Text, fonte, Brushes.Black, 650, 500)

        e.Graphics.DrawString(Label12.Text, fonte, Brushes.Black, 75, 525)
        e.Graphics.DrawString(Label19.Text, fonte, Brushes.Black, 250, 525)
        e.Graphics.DrawString(Label27.Text, fonte, Brushes.Black, 650, 525)

        e.Graphics.DrawString(Label13.Text, fonte, Brushes.Black, 75, 550)
        e.Graphics.DrawString(Label18.Text, fonte, Brushes.Black, 250, 550)
        e.Graphics.DrawString(Label26.Text, fonte, Brushes.Black, 650, 550)

        e.Graphics.DrawString(Label15.Text, fonte, Brushes.Black, 75, 575)
        e.Graphics.DrawString(Label17.Text, fonte, Brushes.Black, 250, 575)
        e.Graphics.DrawString(Label25.Text, fonte, Brushes.Black, 650, 575)

        e.Graphics.DrawString(Label14.Text, fonte, Brushes.Black, 75, 600)
        e.Graphics.DrawString(Label16.Text, fonte, Brushes.Black, 250, 600)
        e.Graphics.DrawString(Label24.Text, fonte, Brushes.Black, 650, 600)

        Dim fontright As New Font("Courier New", 16, FontStyle.Italic)

        e.Graphics.DrawString("LIRA SYSTEMS 2021 © All Rights Reserved", fontright, Brushes.Black, 75, 700)
    End Sub

    Private Sub EmailSlipToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmailSlipToolStripMenuItem.Click
        Dim obj As New EmailSlip

        obj.stringpass = Label34.Text
        obj.ShowDialog()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class