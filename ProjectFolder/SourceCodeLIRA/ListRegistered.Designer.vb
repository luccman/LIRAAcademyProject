<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListRegistered
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim StudentNameLabel As System.Windows.Forms.Label
        Dim StudentICLabel As System.Windows.Forms.Label
        Dim Subject1Label As System.Windows.Forms.Label
        Dim Subject2Label As System.Windows.Forms.Label
        Dim Subject3Label As System.Windows.Forms.Label
        Dim Subject4Label As System.Windows.Forms.Label
        Dim Subject5Label As System.Windows.Forms.Label
        Dim Subject6Label As System.Windows.Forms.Label
        Dim Subject7Label As System.Windows.Forms.Label
        Dim Subject8Label As System.Windows.Forms.Label
        Dim Credit1Label As System.Windows.Forms.Label
        Dim Credit2Label As System.Windows.Forms.Label
        Dim Credit3Label As System.Windows.Forms.Label
        Dim Credit4Label As System.Windows.Forms.Label
        Dim Credit5Label As System.Windows.Forms.Label
        Dim Credit6Label As System.Windows.Forms.Label
        Dim Credit7Label As System.Windows.Forms.Label
        Dim Credit8Label As System.Windows.Forms.Label
        Dim FeeLabel As System.Windows.Forms.Label
        Dim Name1Label As System.Windows.Forms.Label
        Dim Name2Label As System.Windows.Forms.Label
        Dim Name3Label As System.Windows.Forms.Label
        Dim Name4Label As System.Windows.Forms.Label
        Dim Name5Label As System.Windows.Forms.Label
        Dim Name6Label As System.Windows.Forms.Label
        Dim Name7Label As System.Windows.Forms.Label
        Dim Name8Label As System.Windows.Forms.Label
        Dim StudentEmailLabel As System.Windows.Forms.Label
        Dim StudentClassLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListRegistered))
        Me.LiraDatabaseFinal = New LoginForUsers.LiraDatabaseFinal()
        Me.RegisteredStudentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegisteredStudentsTableAdapter = New LoginForUsers.LiraDatabaseFinalTableAdapters.RegisteredStudentsTableAdapter()
        Me.TableAdapterManager = New LoginForUsers.LiraDatabaseFinalTableAdapters.TableAdapterManager()
        Me.RegisteredStudentsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RegisteredStudentsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.RegisteredStudentsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.StudentNameTextBox = New System.Windows.Forms.TextBox()
        Me.StudentICTextBox = New System.Windows.Forms.TextBox()
        Me.Subject1TextBox = New System.Windows.Forms.TextBox()
        Me.Subject2TextBox = New System.Windows.Forms.TextBox()
        Me.Subject3TextBox = New System.Windows.Forms.TextBox()
        Me.Subject4TextBox = New System.Windows.Forms.TextBox()
        Me.Subject5TextBox = New System.Windows.Forms.TextBox()
        Me.Subject6TextBox = New System.Windows.Forms.TextBox()
        Me.Subject7TextBox = New System.Windows.Forms.TextBox()
        Me.Subject8TextBox = New System.Windows.Forms.TextBox()
        Me.Credit1TextBox = New System.Windows.Forms.TextBox()
        Me.Credit2TextBox = New System.Windows.Forms.TextBox()
        Me.Credit3TextBox = New System.Windows.Forms.TextBox()
        Me.Credit4TextBox = New System.Windows.Forms.TextBox()
        Me.Credit5TextBox = New System.Windows.Forms.TextBox()
        Me.Credit6TextBox = New System.Windows.Forms.TextBox()
        Me.Credit7TextBox = New System.Windows.Forms.TextBox()
        Me.Credit8TextBox = New System.Windows.Forms.TextBox()
        Me.FeeTextBox = New System.Windows.Forms.TextBox()
        Me.Name1TextBox = New System.Windows.Forms.TextBox()
        Me.Name2TextBox = New System.Windows.Forms.TextBox()
        Me.Name3TextBox = New System.Windows.Forms.TextBox()
        Me.Name4TextBox = New System.Windows.Forms.TextBox()
        Me.Name5TextBox = New System.Windows.Forms.TextBox()
        Me.Name6TextBox = New System.Windows.Forms.TextBox()
        Me.Name7TextBox = New System.Windows.Forms.TextBox()
        Me.Name8TextBox = New System.Windows.Forms.TextBox()
        Me.StudentEmailTextBox = New System.Windows.Forms.TextBox()
        Me.StudentClassTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        IDLabel = New System.Windows.Forms.Label()
        StudentNameLabel = New System.Windows.Forms.Label()
        StudentICLabel = New System.Windows.Forms.Label()
        Subject1Label = New System.Windows.Forms.Label()
        Subject2Label = New System.Windows.Forms.Label()
        Subject3Label = New System.Windows.Forms.Label()
        Subject4Label = New System.Windows.Forms.Label()
        Subject5Label = New System.Windows.Forms.Label()
        Subject6Label = New System.Windows.Forms.Label()
        Subject7Label = New System.Windows.Forms.Label()
        Subject8Label = New System.Windows.Forms.Label()
        Credit1Label = New System.Windows.Forms.Label()
        Credit2Label = New System.Windows.Forms.Label()
        Credit3Label = New System.Windows.Forms.Label()
        Credit4Label = New System.Windows.Forms.Label()
        Credit5Label = New System.Windows.Forms.Label()
        Credit6Label = New System.Windows.Forms.Label()
        Credit7Label = New System.Windows.Forms.Label()
        Credit8Label = New System.Windows.Forms.Label()
        FeeLabel = New System.Windows.Forms.Label()
        Name1Label = New System.Windows.Forms.Label()
        Name2Label = New System.Windows.Forms.Label()
        Name3Label = New System.Windows.Forms.Label()
        Name4Label = New System.Windows.Forms.Label()
        Name5Label = New System.Windows.Forms.Label()
        Name6Label = New System.Windows.Forms.Label()
        Name7Label = New System.Windows.Forms.Label()
        Name8Label = New System.Windows.Forms.Label()
        StudentEmailLabel = New System.Windows.Forms.Label()
        StudentClassLabel = New System.Windows.Forms.Label()
        CType(Me.LiraDatabaseFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegisteredStudentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegisteredStudentsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RegisteredStudentsBindingNavigator.SuspendLayout()
        CType(Me.RegisteredStudentsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.ForeColor = System.Drawing.Color.White
        IDLabel.Location = New System.Drawing.Point(1080, 129)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(29, 18)
        IDLabel.TabIndex = 2
        IDLabel.Text = "ID:"
        '
        'StudentNameLabel
        '
        StudentNameLabel.AutoSize = True
        StudentNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StudentNameLabel.ForeColor = System.Drawing.Color.White
        StudentNameLabel.Location = New System.Drawing.Point(576, 71)
        StudentNameLabel.Name = "StudentNameLabel"
        StudentNameLabel.Size = New System.Drawing.Size(119, 18)
        StudentNameLabel.TabIndex = 4
        StudentNameLabel.Text = "Student Name:"
        '
        'StudentICLabel
        '
        StudentICLabel.AutoSize = True
        StudentICLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StudentICLabel.ForeColor = System.Drawing.Color.White
        StudentICLabel.Location = New System.Drawing.Point(1018, 71)
        StudentICLabel.Name = "StudentICLabel"
        StudentICLabel.Size = New System.Drawing.Size(91, 18)
        StudentICLabel.TabIndex = 6
        StudentICLabel.Text = "Student IC:"
        '
        'Subject1Label
        '
        Subject1Label.AutoSize = True
        Subject1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Subject1Label.ForeColor = System.Drawing.Color.White
        Subject1Label.Location = New System.Drawing.Point(21, 193)
        Subject1Label.Name = "Subject1Label"
        Subject1Label.Size = New System.Drawing.Size(73, 16)
        Subject1Label.TabIndex = 8
        Subject1Label.Text = "1st Subject"
        '
        'Subject2Label
        '
        Subject2Label.AutoSize = True
        Subject2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Subject2Label.ForeColor = System.Drawing.Color.White
        Subject2Label.Location = New System.Drawing.Point(282, 190)
        Subject2Label.Name = "Subject2Label"
        Subject2Label.Size = New System.Drawing.Size(78, 16)
        Subject2Label.TabIndex = 10
        Subject2Label.Text = "2nd Subject"
        '
        'Subject3Label
        '
        Subject3Label.AutoSize = True
        Subject3Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Subject3Label.ForeColor = System.Drawing.Color.White
        Subject3Label.Location = New System.Drawing.Point(19, 299)
        Subject3Label.Name = "Subject3Label"
        Subject3Label.Size = New System.Drawing.Size(75, 16)
        Subject3Label.TabIndex = 12
        Subject3Label.Text = "3rd Subject"
        '
        'Subject4Label
        '
        Subject4Label.AutoSize = True
        Subject4Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Subject4Label.ForeColor = System.Drawing.Color.White
        Subject4Label.Location = New System.Drawing.Point(282, 296)
        Subject4Label.Name = "Subject4Label"
        Subject4Label.Size = New System.Drawing.Size(73, 16)
        Subject4Label.TabIndex = 14
        Subject4Label.Text = "4th Subject"
        '
        'Subject5Label
        '
        Subject5Label.AutoSize = True
        Subject5Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Subject5Label.ForeColor = System.Drawing.Color.White
        Subject5Label.Location = New System.Drawing.Point(19, 403)
        Subject5Label.Name = "Subject5Label"
        Subject5Label.Size = New System.Drawing.Size(73, 16)
        Subject5Label.TabIndex = 16
        Subject5Label.Text = "5th Subject"
        '
        'Subject6Label
        '
        Subject6Label.AutoSize = True
        Subject6Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Subject6Label.ForeColor = System.Drawing.Color.White
        Subject6Label.Location = New System.Drawing.Point(282, 403)
        Subject6Label.Name = "Subject6Label"
        Subject6Label.Size = New System.Drawing.Size(73, 16)
        Subject6Label.TabIndex = 18
        Subject6Label.Text = "6th Subject"
        '
        'Subject7Label
        '
        Subject7Label.AutoSize = True
        Subject7Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Subject7Label.ForeColor = System.Drawing.Color.White
        Subject7Label.Location = New System.Drawing.Point(19, 507)
        Subject7Label.Name = "Subject7Label"
        Subject7Label.Size = New System.Drawing.Size(73, 16)
        Subject7Label.TabIndex = 20
        Subject7Label.Text = "7th Subject"
        '
        'Subject8Label
        '
        Subject8Label.AutoSize = True
        Subject8Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Subject8Label.ForeColor = System.Drawing.Color.White
        Subject8Label.Location = New System.Drawing.Point(282, 504)
        Subject8Label.Name = "Subject8Label"
        Subject8Label.Size = New System.Drawing.Size(73, 16)
        Subject8Label.TabIndex = 22
        Subject8Label.Text = "8th Subject"
        '
        'Credit1Label
        '
        Credit1Label.AutoSize = True
        Credit1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Credit1Label.ForeColor = System.Drawing.Color.White
        Credit1Label.Location = New System.Drawing.Point(52, 247)
        Credit1Label.Name = "Credit1Label"
        Credit1Label.Size = New System.Drawing.Size(43, 16)
        Credit1Label.TabIndex = 24
        Credit1Label.Text = "Credit"
        '
        'Credit2Label
        '
        Credit2Label.AutoSize = True
        Credit2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Credit2Label.ForeColor = System.Drawing.Color.White
        Credit2Label.Location = New System.Drawing.Point(315, 247)
        Credit2Label.Name = "Credit2Label"
        Credit2Label.Size = New System.Drawing.Size(43, 16)
        Credit2Label.TabIndex = 26
        Credit2Label.Text = "Credit"
        '
        'Credit3Label
        '
        Credit3Label.AutoSize = True
        Credit3Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Credit3Label.ForeColor = System.Drawing.Color.White
        Credit3Label.Location = New System.Drawing.Point(52, 355)
        Credit3Label.Name = "Credit3Label"
        Credit3Label.Size = New System.Drawing.Size(43, 16)
        Credit3Label.TabIndex = 28
        Credit3Label.Text = "Credit"
        '
        'Credit4Label
        '
        Credit4Label.AutoSize = True
        Credit4Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Credit4Label.ForeColor = System.Drawing.Color.White
        Credit4Label.Location = New System.Drawing.Point(315, 352)
        Credit4Label.Name = "Credit4Label"
        Credit4Label.Size = New System.Drawing.Size(43, 16)
        Credit4Label.TabIndex = 30
        Credit4Label.Text = "Credit"
        '
        'Credit5Label
        '
        Credit5Label.AutoSize = True
        Credit5Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Credit5Label.ForeColor = System.Drawing.Color.White
        Credit5Label.Location = New System.Drawing.Point(52, 459)
        Credit5Label.Name = "Credit5Label"
        Credit5Label.Size = New System.Drawing.Size(43, 16)
        Credit5Label.TabIndex = 32
        Credit5Label.Text = "Credit"
        '
        'Credit6Label
        '
        Credit6Label.AutoSize = True
        Credit6Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Credit6Label.ForeColor = System.Drawing.Color.White
        Credit6Label.Location = New System.Drawing.Point(315, 459)
        Credit6Label.Name = "Credit6Label"
        Credit6Label.Size = New System.Drawing.Size(43, 16)
        Credit6Label.TabIndex = 34
        Credit6Label.Text = "Credit"
        '
        'Credit7Label
        '
        Credit7Label.AutoSize = True
        Credit7Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Credit7Label.ForeColor = System.Drawing.Color.White
        Credit7Label.Location = New System.Drawing.Point(52, 563)
        Credit7Label.Name = "Credit7Label"
        Credit7Label.Size = New System.Drawing.Size(43, 16)
        Credit7Label.TabIndex = 36
        Credit7Label.Text = "Credit"
        '
        'Credit8Label
        '
        Credit8Label.AutoSize = True
        Credit8Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Credit8Label.ForeColor = System.Drawing.Color.White
        Credit8Label.Location = New System.Drawing.Point(315, 563)
        Credit8Label.Name = "Credit8Label"
        Credit8Label.Size = New System.Drawing.Size(43, 16)
        Credit8Label.TabIndex = 38
        Credit8Label.Text = "Credit"
        '
        'FeeLabel
        '
        FeeLabel.AutoSize = True
        FeeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FeeLabel.Location = New System.Drawing.Point(20, 611)
        FeeLabel.Name = "FeeLabel"
        FeeLabel.Size = New System.Drawing.Size(125, 18)
        FeeLabel.TabIndex = 40
        FeeLabel.Text = "Fee to Pay RM:"
        FeeLabel.Visible = False
        '
        'Name1Label
        '
        Name1Label.AutoSize = True
        Name1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Name1Label.ForeColor = System.Drawing.Color.White
        Name1Label.Location = New System.Drawing.Point(52, 219)
        Name1Label.Name = "Name1Label"
        Name1Label.Size = New System.Drawing.Size(45, 16)
        Name1Label.TabIndex = 42
        Name1Label.Text = "Name"
        '
        'Name2Label
        '
        Name2Label.AutoSize = True
        Name2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Name2Label.ForeColor = System.Drawing.Color.White
        Name2Label.Location = New System.Drawing.Point(315, 219)
        Name2Label.Name = "Name2Label"
        Name2Label.Size = New System.Drawing.Size(45, 16)
        Name2Label.TabIndex = 44
        Name2Label.Text = "Name"
        '
        'Name3Label
        '
        Name3Label.AutoSize = True
        Name3Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Name3Label.ForeColor = System.Drawing.Color.White
        Name3Label.Location = New System.Drawing.Point(52, 327)
        Name3Label.Name = "Name3Label"
        Name3Label.Size = New System.Drawing.Size(45, 16)
        Name3Label.TabIndex = 46
        Name3Label.Text = "Name"
        '
        'Name4Label
        '
        Name4Label.AutoSize = True
        Name4Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Name4Label.ForeColor = System.Drawing.Color.White
        Name4Label.Location = New System.Drawing.Point(315, 324)
        Name4Label.Name = "Name4Label"
        Name4Label.Size = New System.Drawing.Size(45, 16)
        Name4Label.TabIndex = 48
        Name4Label.Text = "Name"
        '
        'Name5Label
        '
        Name5Label.AutoSize = True
        Name5Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Name5Label.ForeColor = System.Drawing.Color.White
        Name5Label.Location = New System.Drawing.Point(52, 431)
        Name5Label.Name = "Name5Label"
        Name5Label.Size = New System.Drawing.Size(45, 16)
        Name5Label.TabIndex = 50
        Name5Label.Text = "Name"
        '
        'Name6Label
        '
        Name6Label.AutoSize = True
        Name6Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Name6Label.ForeColor = System.Drawing.Color.White
        Name6Label.Location = New System.Drawing.Point(315, 431)
        Name6Label.Name = "Name6Label"
        Name6Label.Size = New System.Drawing.Size(45, 16)
        Name6Label.TabIndex = 52
        Name6Label.Text = "Name"
        '
        'Name7Label
        '
        Name7Label.AutoSize = True
        Name7Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Name7Label.ForeColor = System.Drawing.Color.White
        Name7Label.Location = New System.Drawing.Point(52, 535)
        Name7Label.Name = "Name7Label"
        Name7Label.Size = New System.Drawing.Size(45, 16)
        Name7Label.TabIndex = 54
        Name7Label.Text = "Name"
        '
        'Name8Label
        '
        Name8Label.AutoSize = True
        Name8Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Name8Label.ForeColor = System.Drawing.Color.White
        Name8Label.Location = New System.Drawing.Point(315, 535)
        Name8Label.Name = "Name8Label"
        Name8Label.Size = New System.Drawing.Size(45, 16)
        Name8Label.TabIndex = 56
        Name8Label.Text = "Name"
        '
        'StudentEmailLabel
        '
        StudentEmailLabel.AutoSize = True
        StudentEmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StudentEmailLabel.ForeColor = System.Drawing.Color.White
        StudentEmailLabel.Location = New System.Drawing.Point(576, 101)
        StudentEmailLabel.Name = "StudentEmailLabel"
        StudentEmailLabel.Size = New System.Drawing.Size(117, 18)
        StudentEmailLabel.TabIndex = 58
        StudentEmailLabel.Text = "Student Email:"
        '
        'StudentClassLabel
        '
        StudentClassLabel.AutoSize = True
        StudentClassLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StudentClassLabel.ForeColor = System.Drawing.Color.White
        StudentClassLabel.Location = New System.Drawing.Point(576, 132)
        StudentClassLabel.Name = "StudentClassLabel"
        StudentClassLabel.Size = New System.Drawing.Size(118, 18)
        StudentClassLabel.TabIndex = 60
        StudentClassLabel.Text = "Student Class:"
        '
        'LiraDatabaseFinal
        '
        Me.LiraDatabaseFinal.DataSetName = "LiraDatabaseFinal"
        Me.LiraDatabaseFinal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RegisteredStudentsBindingSource
        '
        Me.RegisteredStudentsBindingSource.DataMember = "RegisteredStudents"
        Me.RegisteredStudentsBindingSource.DataSource = Me.LiraDatabaseFinal
        '
        'RegisteredStudentsTableAdapter
        '
        Me.RegisteredStudentsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClassListTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.RegisteredStudentsTableAdapter = Me.RegisteredStudentsTableAdapter
        Me.TableAdapterManager.StudentsTableAdapter = Nothing
        Me.TableAdapterManager.SubjectsTableAdapter = Nothing
        Me.TableAdapterManager.TeachersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = LoginForUsers.LiraDatabaseFinalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RegisteredStudentsBindingNavigator
        '
        Me.RegisteredStudentsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.RegisteredStudentsBindingNavigator.BindingSource = Me.RegisteredStudentsBindingSource
        Me.RegisteredStudentsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.RegisteredStudentsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.RegisteredStudentsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.RegisteredStudentsBindingNavigatorSaveItem})
        Me.RegisteredStudentsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.RegisteredStudentsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RegisteredStudentsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RegisteredStudentsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RegisteredStudentsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RegisteredStudentsBindingNavigator.Name = "RegisteredStudentsBindingNavigator"
        Me.RegisteredStudentsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.RegisteredStudentsBindingNavigator.Size = New System.Drawing.Size(1295, 25)
        Me.RegisteredStudentsBindingNavigator.TabIndex = 0
        Me.RegisteredStudentsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'RegisteredStudentsBindingNavigatorSaveItem
        '
        Me.RegisteredStudentsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RegisteredStudentsBindingNavigatorSaveItem.Image = CType(resources.GetObject("RegisteredStudentsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RegisteredStudentsBindingNavigatorSaveItem.Name = "RegisteredStudentsBindingNavigatorSaveItem"
        Me.RegisteredStudentsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.RegisteredStudentsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'RegisteredStudentsDataGridView
        '
        Me.RegisteredStudentsDataGridView.AllowUserToAddRows = False
        Me.RegisteredStudentsDataGridView.AutoGenerateColumns = False
        Me.RegisteredStudentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RegisteredStudentsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn20})
        Me.RegisteredStudentsDataGridView.DataSource = Me.RegisteredStudentsBindingSource
        Me.RegisteredStudentsDataGridView.Location = New System.Drawing.Point(567, 170)
        Me.RegisteredStudentsDataGridView.Name = "RegisteredStudentsDataGridView"
        Me.RegisteredStudentsDataGridView.Size = New System.Drawing.Size(703, 450)
        Me.RegisteredStudentsDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "StudentName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "StudentName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 175
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "StudentIC"
        Me.DataGridViewTextBoxColumn3.HeaderText = "StudentIC"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Subject1"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Subject1"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Subject2"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Subject2"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Subject3"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Subject3"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Subject4"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Subject4"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Subject5"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Subject5"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Subject6"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Subject6"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Subject7"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Subject7"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Subject8"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Subject8"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Credit1"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Credit1"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Credit2"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Credit2"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Credit3"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Credit3"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Visible = False
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Credit4"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Credit4"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Visible = False
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Credit5"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Credit5"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Visible = False
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Credit6"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Credit6"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Visible = False
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Credit7"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Credit7"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Visible = False
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Credit8"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Credit8"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.Visible = False
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "Name1"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Name1"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.Visible = False
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Name2"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Name2"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.Visible = False
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Name3"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Name3"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.Visible = False
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Name4"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Name4"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.Visible = False
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "Name5"
        Me.DataGridViewTextBoxColumn25.HeaderText = "Name5"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.Visible = False
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "Name6"
        Me.DataGridViewTextBoxColumn26.HeaderText = "Name6"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.Visible = False
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "Name7"
        Me.DataGridViewTextBoxColumn27.HeaderText = "Name7"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.Visible = False
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "Name8"
        Me.DataGridViewTextBoxColumn28.HeaderText = "Name8"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.Visible = False
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "StudentEmail"
        Me.DataGridViewTextBoxColumn29.HeaderText = "StudentEmail"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.Width = 200
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "StudentClass"
        Me.DataGridViewTextBoxColumn30.HeaderText = "StudentClass"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.Width = 175
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Fee"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Fee"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.Visible = False
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "ID", True))
        Me.IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(1112, 129)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(43, 24)
        Me.IDTextBox.TabIndex = 3
        '
        'StudentNameTextBox
        '
        Me.StudentNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "StudentName", True))
        Me.StudentNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentNameTextBox.Location = New System.Drawing.Point(710, 68)
        Me.StudentNameTextBox.Name = "StudentNameTextBox"
        Me.StudentNameTextBox.Size = New System.Drawing.Size(291, 24)
        Me.StudentNameTextBox.TabIndex = 5
        '
        'StudentICTextBox
        '
        Me.StudentICTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "StudentIC", True))
        Me.StudentICTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentICTextBox.Location = New System.Drawing.Point(1112, 68)
        Me.StudentICTextBox.Name = "StudentICTextBox"
        Me.StudentICTextBox.Size = New System.Drawing.Size(158, 24)
        Me.StudentICTextBox.TabIndex = 7
        '
        'Subject1TextBox
        '
        Me.Subject1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "Subject1", True))
        Me.Subject1TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subject1TextBox.Location = New System.Drawing.Point(103, 190)
        Me.Subject1TextBox.Name = "Subject1TextBox"
        Me.Subject1TextBox.Size = New System.Drawing.Size(100, 22)
        Me.Subject1TextBox.TabIndex = 9
        '
        'Subject2TextBox
        '
        Me.Subject2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "Subject2", True))
        Me.Subject2TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subject2TextBox.Location = New System.Drawing.Point(366, 187)
        Me.Subject2TextBox.Name = "Subject2TextBox"
        Me.Subject2TextBox.Size = New System.Drawing.Size(100, 22)
        Me.Subject2TextBox.TabIndex = 11
        '
        'Subject3TextBox
        '
        Me.Subject3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "Subject3", True))
        Me.Subject3TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subject3TextBox.Location = New System.Drawing.Point(103, 296)
        Me.Subject3TextBox.Name = "Subject3TextBox"
        Me.Subject3TextBox.Size = New System.Drawing.Size(100, 22)
        Me.Subject3TextBox.TabIndex = 13
        '
        'Subject4TextBox
        '
        Me.Subject4TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "Subject4", True))
        Me.Subject4TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subject4TextBox.Location = New System.Drawing.Point(366, 293)
        Me.Subject4TextBox.Name = "Subject4TextBox"
        Me.Subject4TextBox.Size = New System.Drawing.Size(100, 22)
        Me.Subject4TextBox.TabIndex = 15
        '
        'Subject5TextBox
        '
        Me.Subject5TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "Subject5", True))
        Me.Subject5TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subject5TextBox.Location = New System.Drawing.Point(103, 400)
        Me.Subject5TextBox.Name = "Subject5TextBox"
        Me.Subject5TextBox.Size = New System.Drawing.Size(100, 22)
        Me.Subject5TextBox.TabIndex = 17
        '
        'Subject6TextBox
        '
        Me.Subject6TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "Subject6", True))
        Me.Subject6TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subject6TextBox.Location = New System.Drawing.Point(366, 400)
        Me.Subject6TextBox.Name = "Subject6TextBox"
        Me.Subject6TextBox.Size = New System.Drawing.Size(100, 22)
        Me.Subject6TextBox.TabIndex = 19
        '
        'Subject7TextBox
        '
        Me.Subject7TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "Subject7", True))
        Me.Subject7TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subject7TextBox.Location = New System.Drawing.Point(103, 504)
        Me.Subject7TextBox.Name = "Subject7TextBox"
        Me.Subject7TextBox.Size = New System.Drawing.Size(100, 22)
        Me.Subject7TextBox.TabIndex = 21
        '
        'Subject8TextBox
        '
        Me.Subject8TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "Subject8", True))
        Me.Subject8TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subject8TextBox.Location = New System.Drawing.Point(366, 501)
        Me.Subject8TextBox.Name = "Subject8TextBox"
        Me.Subject8TextBox.Size = New System.Drawing.Size(100, 22)
        Me.Subject8TextBox.TabIndex = 23
        '
        'Credit1TextBox
        '
        Me.Credit1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "Credit1", True))
        Me.Credit1TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Credit1TextBox.Location = New System.Drawing.Point(103, 244)
        Me.Credit1TextBox.Name = "Credit1TextBox"
        Me.Credit1TextBox.Size = New System.Drawing.Size(25, 22)
        Me.Credit1TextBox.TabIndex = 25
        '
        'Credit2TextBox
        '
        Me.Credit2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "Credit2", True))
        Me.Credit2TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Credit2TextBox.Location = New System.Drawing.Point(366, 244)
        Me.Credit2TextBox.Name = "Credit2TextBox"
        Me.Credit2TextBox.Size = New System.Drawing.Size(25, 22)
        Me.Credit2TextBox.TabIndex = 27
        '
        'Credit3TextBox
        '
        Me.Credit3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "Credit3", True))
        Me.Credit3TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Credit3TextBox.Location = New System.Drawing.Point(103, 352)
        Me.Credit3TextBox.Name = "Credit3TextBox"
        Me.Credit3TextBox.Size = New System.Drawing.Size(25, 22)
        Me.Credit3TextBox.TabIndex = 29
        '
        'Credit4TextBox
        '
        Me.Credit4TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "Credit4", True))
        Me.Credit4TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Credit4TextBox.Location = New System.Drawing.Point(366, 349)
        Me.Credit4TextBox.Name = "Credit4TextBox"
        Me.Credit4TextBox.Size = New System.Drawing.Size(25, 22)
        Me.Credit4TextBox.TabIndex = 31
        '
        'Credit5TextBox
        '
        Me.Credit5TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "Credit5", True))
        Me.Credit5TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Credit5TextBox.Location = New System.Drawing.Point(103, 456)
        Me.Credit5TextBox.Name = "Credit5TextBox"
        Me.Credit5TextBox.Size = New System.Drawing.Size(25, 22)
        Me.Credit5TextBox.TabIndex = 33
        '
        'Credit6TextBox
        '
        Me.Credit6TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "Credit6", True))
        Me.Credit6TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Credit6TextBox.Location = New System.Drawing.Point(366, 456)
        Me.Credit6TextBox.Name = "Credit6TextBox"
        Me.Credit6TextBox.Size = New System.Drawing.Size(25, 22)
        Me.Credit6TextBox.TabIndex = 35
        '
        'Credit7TextBox
        '
        Me.Credit7TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "Credit7", True))
        Me.Credit7TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Credit7TextBox.Location = New System.Drawing.Point(103, 560)
        Me.Credit7TextBox.Name = "Credit7TextBox"
        Me.Credit7TextBox.Size = New System.Drawing.Size(25, 22)
        Me.Credit7TextBox.TabIndex = 37
        '
        'Credit8TextBox
        '
        Me.Credit8TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "Credit8", True))
        Me.Credit8TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Credit8TextBox.Location = New System.Drawing.Point(366, 560)
        Me.Credit8TextBox.Name = "Credit8TextBox"
        Me.Credit8TextBox.Size = New System.Drawing.Size(25, 22)
        Me.Credit8TextBox.TabIndex = 39
        '
        'FeeTextBox
        '
        Me.FeeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "Fee", True))
        Me.FeeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FeeTextBox.Location = New System.Drawing.Point(151, 605)
        Me.FeeTextBox.Name = "FeeTextBox"
        Me.FeeTextBox.Size = New System.Drawing.Size(100, 24)
        Me.FeeTextBox.TabIndex = 41
        Me.FeeTextBox.Visible = False
        '
        'Name1TextBox
        '
        Me.Name1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "Name1", True))
        Me.Name1TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name1TextBox.Location = New System.Drawing.Point(103, 216)
        Me.Name1TextBox.Name = "Name1TextBox"
        Me.Name1TextBox.Size = New System.Drawing.Size(164, 22)
        Me.Name1TextBox.TabIndex = 43
        '
        'Name2TextBox
        '
        Me.Name2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "Name2", True))
        Me.Name2TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name2TextBox.Location = New System.Drawing.Point(366, 216)
        Me.Name2TextBox.Name = "Name2TextBox"
        Me.Name2TextBox.Size = New System.Drawing.Size(164, 22)
        Me.Name2TextBox.TabIndex = 45
        '
        'Name3TextBox
        '
        Me.Name3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "Name3", True))
        Me.Name3TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name3TextBox.Location = New System.Drawing.Point(103, 324)
        Me.Name3TextBox.Name = "Name3TextBox"
        Me.Name3TextBox.Size = New System.Drawing.Size(164, 22)
        Me.Name3TextBox.TabIndex = 47
        '
        'Name4TextBox
        '
        Me.Name4TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "Name4", True))
        Me.Name4TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name4TextBox.Location = New System.Drawing.Point(366, 321)
        Me.Name4TextBox.Name = "Name4TextBox"
        Me.Name4TextBox.Size = New System.Drawing.Size(164, 22)
        Me.Name4TextBox.TabIndex = 49
        '
        'Name5TextBox
        '
        Me.Name5TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "Name5", True))
        Me.Name5TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name5TextBox.Location = New System.Drawing.Point(103, 428)
        Me.Name5TextBox.Name = "Name5TextBox"
        Me.Name5TextBox.Size = New System.Drawing.Size(164, 22)
        Me.Name5TextBox.TabIndex = 51
        '
        'Name6TextBox
        '
        Me.Name6TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "Name6", True))
        Me.Name6TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name6TextBox.Location = New System.Drawing.Point(366, 428)
        Me.Name6TextBox.Name = "Name6TextBox"
        Me.Name6TextBox.Size = New System.Drawing.Size(164, 22)
        Me.Name6TextBox.TabIndex = 53
        '
        'Name7TextBox
        '
        Me.Name7TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "Name7", True))
        Me.Name7TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name7TextBox.Location = New System.Drawing.Point(103, 532)
        Me.Name7TextBox.Name = "Name7TextBox"
        Me.Name7TextBox.Size = New System.Drawing.Size(164, 22)
        Me.Name7TextBox.TabIndex = 55
        '
        'Name8TextBox
        '
        Me.Name8TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "Name8", True))
        Me.Name8TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name8TextBox.Location = New System.Drawing.Point(366, 532)
        Me.Name8TextBox.Name = "Name8TextBox"
        Me.Name8TextBox.Size = New System.Drawing.Size(164, 22)
        Me.Name8TextBox.TabIndex = 57
        '
        'StudentEmailTextBox
        '
        Me.StudentEmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "StudentEmail", True))
        Me.StudentEmailTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentEmailTextBox.Location = New System.Drawing.Point(710, 98)
        Me.StudentEmailTextBox.Name = "StudentEmailTextBox"
        Me.StudentEmailTextBox.Size = New System.Drawing.Size(291, 24)
        Me.StudentEmailTextBox.TabIndex = 59
        '
        'StudentClassTextBox
        '
        Me.StudentClassTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredStudentsBindingSource, "StudentClass", True))
        Me.StudentClassTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentClassTextBox.Location = New System.Drawing.Point(710, 129)
        Me.StudentClassTextBox.Name = "StudentClassTextBox"
        Me.StudentClassTextBox.Size = New System.Drawing.Size(291, 24)
        Me.StudentClassTextBox.TabIndex = 61
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Location = New System.Drawing.Point(34, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(474, 79)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Vew Subject Filter"
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.LoginForUsers.My.Resources.Resources.refres1
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(421, 25)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(36, 37)
        Me.Button3.TabIndex = 3
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(317, 25)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 37)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "By Name"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(209, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 37)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "By Code"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(20, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(170, 26)
        Me.TextBox1.TabIndex = 0
        '
        'ListRegistered
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1295, 650)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(StudentNameLabel)
        Me.Controls.Add(Me.StudentNameTextBox)
        Me.Controls.Add(StudentICLabel)
        Me.Controls.Add(Me.StudentICTextBox)
        Me.Controls.Add(Subject1Label)
        Me.Controls.Add(Me.Subject1TextBox)
        Me.Controls.Add(Subject2Label)
        Me.Controls.Add(Me.Subject2TextBox)
        Me.Controls.Add(Subject3Label)
        Me.Controls.Add(Me.Subject3TextBox)
        Me.Controls.Add(Subject4Label)
        Me.Controls.Add(Me.Subject4TextBox)
        Me.Controls.Add(Subject5Label)
        Me.Controls.Add(Me.Subject5TextBox)
        Me.Controls.Add(Subject6Label)
        Me.Controls.Add(Me.Subject6TextBox)
        Me.Controls.Add(Subject7Label)
        Me.Controls.Add(Me.Subject7TextBox)
        Me.Controls.Add(Subject8Label)
        Me.Controls.Add(Me.Subject8TextBox)
        Me.Controls.Add(Credit1Label)
        Me.Controls.Add(Me.Credit1TextBox)
        Me.Controls.Add(Credit2Label)
        Me.Controls.Add(Me.Credit2TextBox)
        Me.Controls.Add(Credit3Label)
        Me.Controls.Add(Me.Credit3TextBox)
        Me.Controls.Add(Credit4Label)
        Me.Controls.Add(Me.Credit4TextBox)
        Me.Controls.Add(Credit5Label)
        Me.Controls.Add(Me.Credit5TextBox)
        Me.Controls.Add(Credit6Label)
        Me.Controls.Add(Me.Credit6TextBox)
        Me.Controls.Add(Credit7Label)
        Me.Controls.Add(Me.Credit7TextBox)
        Me.Controls.Add(Credit8Label)
        Me.Controls.Add(Me.Credit8TextBox)
        Me.Controls.Add(FeeLabel)
        Me.Controls.Add(Me.FeeTextBox)
        Me.Controls.Add(Name1Label)
        Me.Controls.Add(Me.Name1TextBox)
        Me.Controls.Add(Name2Label)
        Me.Controls.Add(Me.Name2TextBox)
        Me.Controls.Add(Name3Label)
        Me.Controls.Add(Me.Name3TextBox)
        Me.Controls.Add(Name4Label)
        Me.Controls.Add(Me.Name4TextBox)
        Me.Controls.Add(Name5Label)
        Me.Controls.Add(Me.Name5TextBox)
        Me.Controls.Add(Name6Label)
        Me.Controls.Add(Me.Name6TextBox)
        Me.Controls.Add(Name7Label)
        Me.Controls.Add(Me.Name7TextBox)
        Me.Controls.Add(Name8Label)
        Me.Controls.Add(Me.Name8TextBox)
        Me.Controls.Add(StudentEmailLabel)
        Me.Controls.Add(Me.StudentEmailTextBox)
        Me.Controls.Add(StudentClassLabel)
        Me.Controls.Add(Me.StudentClassTextBox)
        Me.Controls.Add(Me.RegisteredStudentsDataGridView)
        Me.Controls.Add(Me.RegisteredStudentsBindingNavigator)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "ListRegistered"
        Me.Text = "ListRegistered"
        CType(Me.LiraDatabaseFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegisteredStudentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegisteredStudentsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RegisteredStudentsBindingNavigator.ResumeLayout(False)
        Me.RegisteredStudentsBindingNavigator.PerformLayout()
        CType(Me.RegisteredStudentsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LiraDatabaseFinal As LiraDatabaseFinal
    Friend WithEvents RegisteredStudentsBindingSource As BindingSource
    Friend WithEvents RegisteredStudentsTableAdapter As LiraDatabaseFinalTableAdapters.RegisteredStudentsTableAdapter
    Friend WithEvents TableAdapterManager As LiraDatabaseFinalTableAdapters.TableAdapterManager
    Friend WithEvents RegisteredStudentsBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents RegisteredStudentsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents RegisteredStudentsDataGridView As DataGridView
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents StudentNameTextBox As TextBox
    Friend WithEvents StudentICTextBox As TextBox
    Friend WithEvents Subject1TextBox As TextBox
    Friend WithEvents Subject2TextBox As TextBox
    Friend WithEvents Subject3TextBox As TextBox
    Friend WithEvents Subject4TextBox As TextBox
    Friend WithEvents Subject5TextBox As TextBox
    Friend WithEvents Subject6TextBox As TextBox
    Friend WithEvents Subject7TextBox As TextBox
    Friend WithEvents Subject8TextBox As TextBox
    Friend WithEvents Credit1TextBox As TextBox
    Friend WithEvents Credit2TextBox As TextBox
    Friend WithEvents Credit3TextBox As TextBox
    Friend WithEvents Credit4TextBox As TextBox
    Friend WithEvents Credit5TextBox As TextBox
    Friend WithEvents Credit6TextBox As TextBox
    Friend WithEvents Credit7TextBox As TextBox
    Friend WithEvents Credit8TextBox As TextBox
    Friend WithEvents FeeTextBox As TextBox
    Friend WithEvents Name1TextBox As TextBox
    Friend WithEvents Name2TextBox As TextBox
    Friend WithEvents Name3TextBox As TextBox
    Friend WithEvents Name4TextBox As TextBox
    Friend WithEvents Name5TextBox As TextBox
    Friend WithEvents Name6TextBox As TextBox
    Friend WithEvents Name7TextBox As TextBox
    Friend WithEvents Name8TextBox As TextBox
    Friend WithEvents StudentEmailTextBox As TextBox
    Friend WithEvents StudentClassTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
End Class
