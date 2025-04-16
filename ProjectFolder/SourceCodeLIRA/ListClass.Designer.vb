<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListClass
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
        Dim ClassIDLabel As System.Windows.Forms.Label
        Dim ClassNameLabel As System.Windows.Forms.Label
        Dim ClassLevelLabel As System.Windows.Forms.Label
        Dim NumStudentsLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListClass))
        Me.LIRADATABASEDataSet = New LoginForUsers.LIRADATABASEDataSet()
        Me.ClassListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClassListTableAdapter = New LoginForUsers.LIRADATABASEDataSetTableAdapters.ClassListTableAdapter()
        Me.TableAdapterManager = New LoginForUsers.LIRADATABASEDataSetTableAdapters.TableAdapterManager()
        Me.ClassListBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ClassListBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ClassListDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClassIDTextBox = New System.Windows.Forms.TextBox()
        Me.ClassNameTextBox = New System.Windows.Forms.TextBox()
        Me.ClassLevelTextBox = New System.Windows.Forms.TextBox()
        Me.NumStudentsTextBox = New System.Windows.Forms.TextBox()
        ClassIDLabel = New System.Windows.Forms.Label()
        ClassNameLabel = New System.Windows.Forms.Label()
        ClassLevelLabel = New System.Windows.Forms.Label()
        NumStudentsLabel = New System.Windows.Forms.Label()
        CType(Me.LIRADATABASEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassListBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClassListBindingNavigator.SuspendLayout()
        CType(Me.ClassListDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ClassIDLabel
        '
        ClassIDLabel.AutoSize = True
        ClassIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ClassIDLabel.ForeColor = System.Drawing.Color.White
        ClassIDLabel.Location = New System.Drawing.Point(35, 404)
        ClassIDLabel.Name = "ClassIDLabel"
        ClassIDLabel.Size = New System.Drawing.Size(68, 18)
        ClassIDLabel.TabIndex = 2
        ClassIDLabel.Text = "Class ID:"
        '
        'ClassNameLabel
        '
        ClassNameLabel.AutoSize = True
        ClassNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ClassNameLabel.ForeColor = System.Drawing.Color.White
        ClassNameLabel.Location = New System.Drawing.Point(35, 245)
        ClassNameLabel.Name = "ClassNameLabel"
        ClassNameLabel.Size = New System.Drawing.Size(94, 18)
        ClassNameLabel.TabIndex = 4
        ClassNameLabel.Text = "Class Name:"
        '
        'ClassLevelLabel
        '
        ClassLevelLabel.AutoSize = True
        ClassLevelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ClassLevelLabel.ForeColor = System.Drawing.Color.White
        ClassLevelLabel.Location = New System.Drawing.Point(35, 325)
        ClassLevelLabel.Name = "ClassLevelLabel"
        ClassLevelLabel.Size = New System.Drawing.Size(88, 18)
        ClassLevelLabel.TabIndex = 6
        ClassLevelLabel.Text = "Class Level:"
        '
        'NumStudentsLabel
        '
        NumStudentsLabel.AutoSize = True
        NumStudentsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NumStudentsLabel.ForeColor = System.Drawing.Color.White
        NumStudentsLabel.Location = New System.Drawing.Point(35, 364)
        NumStudentsLabel.Name = "NumStudentsLabel"
        NumStudentsLabel.Size = New System.Drawing.Size(106, 18)
        NumStudentsLabel.TabIndex = 8
        NumStudentsLabel.Text = "Num Students:"
        '
        'LIRADATABASEDataSet
        '
        Me.LIRADATABASEDataSet.DataSetName = "LIRADATABASEDataSet"
        Me.LIRADATABASEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClassListBindingSource
        '
        Me.ClassListBindingSource.DataMember = "ClassList"
        Me.ClassListBindingSource.DataSource = Me.LIRADATABASEDataSet
        '
        'ClassListTableAdapter
        '
        Me.ClassListTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClassListTableAdapter = Me.ClassListTableAdapter
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.StudentsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = LoginForUsers.LIRADATABASEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ClassListBindingNavigator
        '
        Me.ClassListBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ClassListBindingNavigator.BindingSource = Me.ClassListBindingSource
        Me.ClassListBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ClassListBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ClassListBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ClassListBindingNavigatorSaveItem})
        Me.ClassListBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ClassListBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ClassListBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ClassListBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ClassListBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ClassListBindingNavigator.Name = "ClassListBindingNavigator"
        Me.ClassListBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ClassListBindingNavigator.Size = New System.Drawing.Size(1083, 25)
        Me.ClassListBindingNavigator.TabIndex = 0
        Me.ClassListBindingNavigator.Text = "BindingNavigator1"
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
        'ClassListBindingNavigatorSaveItem
        '
        Me.ClassListBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ClassListBindingNavigatorSaveItem.Image = CType(resources.GetObject("ClassListBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ClassListBindingNavigatorSaveItem.Name = "ClassListBindingNavigatorSaveItem"
        Me.ClassListBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ClassListBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ClassListDataGridView
        '
        Me.ClassListDataGridView.AllowUserToAddRows = False
        Me.ClassListDataGridView.AutoGenerateColumns = False
        Me.ClassListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClassListDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.ClassListDataGridView.DataSource = Me.ClassListBindingSource
        Me.ClassListDataGridView.Location = New System.Drawing.Point(357, 52)
        Me.ClassListDataGridView.Name = "ClassListDataGridView"
        Me.ClassListDataGridView.Size = New System.Drawing.Size(695, 479)
        Me.ClassListDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ClassID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ClassID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ClassName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ClassName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 375
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ClassLevel"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ClassLevel"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NumStudents"
        Me.DataGridViewTextBoxColumn4.HeaderText = "NumStudents"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'ClassIDTextBox
        '
        Me.ClassIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClassListBindingSource, "ClassID", True))
        Me.ClassIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClassIDTextBox.Location = New System.Drawing.Point(170, 401)
        Me.ClassIDTextBox.Name = "ClassIDTextBox"
        Me.ClassIDTextBox.Size = New System.Drawing.Size(121, 24)
        Me.ClassIDTextBox.TabIndex = 3
        '
        'ClassNameTextBox
        '
        Me.ClassNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClassListBindingSource, "ClassName", True))
        Me.ClassNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClassNameTextBox.Location = New System.Drawing.Point(38, 276)
        Me.ClassNameTextBox.Name = "ClassNameTextBox"
        Me.ClassNameTextBox.Size = New System.Drawing.Size(253, 24)
        Me.ClassNameTextBox.TabIndex = 5
        '
        'ClassLevelTextBox
        '
        Me.ClassLevelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClassListBindingSource, "ClassLevel", True))
        Me.ClassLevelTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClassLevelTextBox.Location = New System.Drawing.Point(170, 322)
        Me.ClassLevelTextBox.Name = "ClassLevelTextBox"
        Me.ClassLevelTextBox.Size = New System.Drawing.Size(121, 24)
        Me.ClassLevelTextBox.TabIndex = 7
        '
        'NumStudentsTextBox
        '
        Me.NumStudentsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClassListBindingSource, "NumStudents", True))
        Me.NumStudentsTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumStudentsTextBox.Location = New System.Drawing.Point(170, 361)
        Me.NumStudentsTextBox.Name = "NumStudentsTextBox"
        Me.NumStudentsTextBox.Size = New System.Drawing.Size(121, 24)
        Me.NumStudentsTextBox.TabIndex = 9
        '
        'ListClass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1083, 559)
        Me.Controls.Add(ClassIDLabel)
        Me.Controls.Add(Me.ClassIDTextBox)
        Me.Controls.Add(ClassNameLabel)
        Me.Controls.Add(Me.ClassNameTextBox)
        Me.Controls.Add(ClassLevelLabel)
        Me.Controls.Add(Me.ClassLevelTextBox)
        Me.Controls.Add(NumStudentsLabel)
        Me.Controls.Add(Me.NumStudentsTextBox)
        Me.Controls.Add(Me.ClassListDataGridView)
        Me.Controls.Add(Me.ClassListBindingNavigator)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "ListClass"
        Me.Text = "ListClass"
        CType(Me.LIRADATABASEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassListBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClassListBindingNavigator.ResumeLayout(False)
        Me.ClassListBindingNavigator.PerformLayout()
        CType(Me.ClassListDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LIRADATABASEDataSet As LIRADATABASEDataSet
    Friend WithEvents ClassListBindingSource As BindingSource
    Friend WithEvents ClassListTableAdapter As LIRADATABASEDataSetTableAdapters.ClassListTableAdapter
    Friend WithEvents TableAdapterManager As LIRADATABASEDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClassListBindingNavigator As BindingNavigator
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
    Friend WithEvents ClassListBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ClassListDataGridView As DataGridView
    Friend WithEvents ClassIDTextBox As TextBox
    Friend WithEvents ClassNameTextBox As TextBox
    Friend WithEvents ClassLevelTextBox As TextBox
    Friend WithEvents NumStudentsTextBox As TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
