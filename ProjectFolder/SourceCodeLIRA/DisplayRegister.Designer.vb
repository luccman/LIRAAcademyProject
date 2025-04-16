<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DisplayRegister
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DisplayRegister))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.RegisteredStudentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LiraDatabaseFinal = New LoginForUsers.LiraDatabaseFinal()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RegisteredStudentsTableAdapter = New LoginForUsers.LiraDatabaseFinalTableAdapters.RegisteredStudentsTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintSlipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SlipPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SlipSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmailSlipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        CType(Me.RegisteredStudentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LiraDatabaseFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.DataSource = Me.RegisteredStudentsBindingSource
        Me.ComboBox1.DisplayMember = "StudentName"
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(214, 68)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(314, 28)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "StudentName"
        '
        'RegisteredStudentsBindingSource
        '
        Me.RegisteredStudentsBindingSource.DataMember = "RegisteredStudents"
        Me.RegisteredStudentsBindingSource.DataSource = Me.LiraDatabaseFinal
        '
        'LiraDatabaseFinal
        '
        Me.LiraDatabaseFinal.DataSetName = "LiraDatabaseFinal"
        Me.LiraDatabaseFinal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(60, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select Student"
        '
        'RegisteredStudentsTableAdapter
        '
        Me.RegisteredStudentsTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(60, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Student Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 22)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Code"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(215, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 22)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Subject Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(581, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 22)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Credit"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.Label31)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(64, 204)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(704, 382)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Subject List"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "Credit8", True))
        Me.Label24.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(599, 313)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(27, 19)
        Me.Label24.TabIndex = 29
        Me.Label24.Text = "--"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "Credit7", True))
        Me.Label25.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(599, 279)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(27, 19)
        Me.Label25.TabIndex = 28
        Me.Label25.Text = "--"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "Credit6", True))
        Me.Label26.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(599, 249)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(27, 19)
        Me.Label26.TabIndex = 27
        Me.Label26.Text = "--"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "Credit5", True))
        Me.Label27.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(599, 215)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(27, 19)
        Me.Label27.TabIndex = 26
        Me.Label27.Text = "--"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "Credit4", True))
        Me.Label28.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(599, 181)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(27, 19)
        Me.Label28.TabIndex = 25
        Me.Label28.Text = "--"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "Credit3", True))
        Me.Label29.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(599, 153)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(27, 19)
        Me.Label29.TabIndex = 24
        Me.Label29.Text = "--"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "Credit2", True))
        Me.Label30.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(599, 122)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(27, 19)
        Me.Label30.TabIndex = 23
        Me.Label30.Text = "--"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.RegisteredStudentsBindingSource, "Credit1", True))
        Me.Label31.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "Credit1", True))
        Me.Label31.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(599, 88)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(27, 19)
        Me.Label31.TabIndex = 22
        Me.Label31.Text = "--"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "Name8", True))
        Me.Label16.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(215, 313)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(27, 19)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "--"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "Name7", True))
        Me.Label17.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(215, 279)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(27, 19)
        Me.Label17.TabIndex = 20
        Me.Label17.Text = "--"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "Name6", True))
        Me.Label18.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(215, 249)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(27, 19)
        Me.Label18.TabIndex = 19
        Me.Label18.Text = "--"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "Name5", True))
        Me.Label19.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(215, 215)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(27, 19)
        Me.Label19.TabIndex = 18
        Me.Label19.Text = "--"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "Name4", True))
        Me.Label20.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(215, 181)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(27, 19)
        Me.Label20.TabIndex = 17
        Me.Label20.Text = "--"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "Name3", True))
        Me.Label21.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(215, 153)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(27, 19)
        Me.Label21.TabIndex = 16
        Me.Label21.Text = "--"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "Name2", True))
        Me.Label22.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(215, 122)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(27, 19)
        Me.Label22.TabIndex = 15
        Me.Label22.Text = "--"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.RegisteredStudentsBindingSource, "Name1", True))
        Me.Label23.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "Name1", True))
        Me.Label23.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(215, 88)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(27, 19)
        Me.Label23.TabIndex = 14
        Me.Label23.Text = "--"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "Subject8", True))
        Me.Label14.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(21, 313)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(27, 19)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "--"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "Subject7", True))
        Me.Label15.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(21, 279)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(27, 19)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "--"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.RegisteredStudentsBindingSource, "Subject6", True))
        Me.Label13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "Subject6", True))
        Me.Label13.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(21, 249)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(27, 19)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "--"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "Subject5", True))
        Me.Label12.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(21, 215)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(27, 19)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "--"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "Subject4", True))
        Me.Label11.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(21, 181)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 19)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "--"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "Subject3", True))
        Me.Label10.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(21, 153)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 19)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "--"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "Subject2", True))
        Me.Label9.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(21, 122)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 19)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "--"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.RegisteredStudentsBindingSource, "Subject1", True))
        Me.Label8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "Subject1", True))
        Me.Label8.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 19)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "--"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(580, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(148, 18)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Student Email:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(60, 162)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 18)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Student IC:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.RegisteredStudentsBindingSource, "StudentName", True))
        Me.Label32.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "StudentName", True))
        Me.Label32.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.White
        Me.Label32.Location = New System.Drawing.Point(204, 130)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(28, 18)
        Me.Label32.TabIndex = 9
        Me.Label32.Text = "--"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "StudentIC", True))
        Me.Label33.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.White
        Me.Label33.Location = New System.Drawing.Point(204, 162)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(28, 18)
        Me.Label33.TabIndex = 10
        Me.Label33.Text = "--"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "StudentEmail", True))
        Me.Label34.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.White
        Me.Label34.Location = New System.Drawing.Point(734, 130)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(28, 18)
        Me.Label34.TabIndex = 11
        Me.Label34.Text = "--"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.White
        Me.Label35.Location = New System.Drawing.Point(580, 162)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(148, 18)
        Me.Label35.TabIndex = 12
        Me.Label35.Text = "Student Class:"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "StudentClass", True))
        Me.Label36.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.Location = New System.Drawing.Point(734, 162)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(28, 18)
        Me.Label36.TabIndex = 13
        Me.Label36.Text = "--"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.White
        Me.Label37.Location = New System.Drawing.Point(798, 292)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(138, 18)
        Me.Label37.TabIndex = 14
        Me.Label37.Text = "Total Fee RM:"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.BackColor = System.Drawing.Color.Transparent
        Me.Label38.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.White
        Me.Label38.Location = New System.Drawing.Point(798, 252)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(138, 18)
        Me.Label38.TabIndex = 15
        Me.Label38.Text = "Total Credit:"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.BackColor = System.Drawing.Color.Transparent
        Me.Label39.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.White
        Me.Label39.Location = New System.Drawing.Point(942, 292)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(28, 18)
        Me.Label39.TabIndex = 16
        Me.Label39.Text = "--"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.BackColor = System.Drawing.Color.Transparent
        Me.Label40.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.White
        Me.Label40.Location = New System.Drawing.Point(942, 252)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(28, 18)
        Me.Label40.TabIndex = 17
        Me.Label40.Text = "--"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(802, 71)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(186, 28)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Calculate Total Credit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Azure
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintToolStripMenuItem, Me.EmailSlipToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1065, 28)
        Me.MenuStrip1.TabIndex = 19
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintSlipToolStripMenuItem, Me.SlipPreviewToolStripMenuItem, Me.SlipSetupToolStripMenuItem})
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(80, 24)
        Me.PrintToolStripMenuItem.Text = " Printing"
        '
        'PrintSlipToolStripMenuItem
        '
        Me.PrintSlipToolStripMenuItem.Name = "PrintSlipToolStripMenuItem"
        Me.PrintSlipToolStripMenuItem.Size = New System.Drawing.Size(161, 24)
        Me.PrintSlipToolStripMenuItem.Text = "Print Slip"
        '
        'SlipPreviewToolStripMenuItem
        '
        Me.SlipPreviewToolStripMenuItem.Name = "SlipPreviewToolStripMenuItem"
        Me.SlipPreviewToolStripMenuItem.Size = New System.Drawing.Size(161, 24)
        Me.SlipPreviewToolStripMenuItem.Text = "Slip Preview"
        '
        'SlipSetupToolStripMenuItem
        '
        Me.SlipSetupToolStripMenuItem.Name = "SlipSetupToolStripMenuItem"
        Me.SlipSetupToolStripMenuItem.Size = New System.Drawing.Size(161, 24)
        Me.SlipSetupToolStripMenuItem.Text = "Slip Setup"
        '
        'EmailSlipToolStripMenuItem
        '
        Me.EmailSlipToolStripMenuItem.Name = "EmailSlipToolStripMenuItem"
        Me.EmailSlipToolStripMenuItem.Size = New System.Drawing.Size(88, 24)
        Me.EmailSlipToolStripMenuItem.Text = "Email Slip"
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'DisplayRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1065, 622)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "DisplayRegister"
        Me.Text = "Student's Subjects"
        CType(Me.RegisteredStudentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LiraDatabaseFinal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LiraDatabaseFinal As LiraDatabaseFinal
    Friend WithEvents RegisteredStudentsBindingSource As BindingSource
    Friend WithEvents RegisteredStudentsTableAdapter As LiraDatabaseFinalTableAdapters.RegisteredStudentsTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintSlipToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SlipPreviewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SlipSetupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents EmailSlipToolStripMenuItem As ToolStripMenuItem
End Class
