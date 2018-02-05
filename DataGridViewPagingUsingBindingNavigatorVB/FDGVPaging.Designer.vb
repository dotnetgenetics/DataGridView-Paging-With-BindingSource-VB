<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FDGVPaging
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FDGVPaging))
        Me.dgvProductNames = New System.Windows.Forms.DataGridView()
        Me.ProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bindingNav = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.bindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.bindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.bindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.bindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.bindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.bindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.bindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.bindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.bindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.bindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.bindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.bindingProducts = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgvProductNames,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.bindingNav,System.ComponentModel.ISupportInitialize).BeginInit
        Me.bindingNav.SuspendLayout
        CType(Me.bindingProducts,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'dgvProductNames
        '
        Me.dgvProductNames.AllowUserToAddRows = false
        Me.dgvProductNames.AllowUserToDeleteRows = false
        Me.dgvProductNames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductNames.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductName})
        Me.dgvProductNames.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProductNames.Location = New System.Drawing.Point(0, 0)
        Me.dgvProductNames.Name = "dgvProductNames"
        Me.dgvProductNames.ReadOnly = true
        Me.dgvProductNames.Size = New System.Drawing.Size(431, 281)
        Me.dgvProductNames.TabIndex = 1
        '
        'ProductName
        '
        Me.ProductName.DataPropertyName = "ProductName"
        Me.ProductName.HeaderText = "Product Name"
        Me.ProductName.Name = "ProductName"
        Me.ProductName.ReadOnly = true
        Me.ProductName.Width = 380
        '
        'bindingNav
        '
        Me.bindingNav.AddNewItem = Me.bindingNavigatorAddNewItem
        Me.bindingNav.CountItem = Me.bindingNavigatorCountItem
        Me.bindingNav.DeleteItem = Me.bindingNavigatorDeleteItem
        Me.bindingNav.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bindingNav.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bindingNavigatorMoveFirstItem, Me.bindingNavigatorMovePreviousItem, Me.bindingNavigatorSeparator, Me.bindingNavigatorPositionItem, Me.bindingNavigatorCountItem, Me.bindingNavigatorSeparator1, Me.bindingNavigatorMoveNextItem, Me.bindingNavigatorMoveLastItem, Me.bindingNavigatorSeparator2, Me.bindingNavigatorAddNewItem, Me.bindingNavigatorDeleteItem})
        Me.bindingNav.Location = New System.Drawing.Point(0, 256)
        Me.bindingNav.MoveFirstItem = Me.bindingNavigatorMoveFirstItem
        Me.bindingNav.MoveLastItem = Me.bindingNavigatorMoveLastItem
        Me.bindingNav.MoveNextItem = Me.bindingNavigatorMoveNextItem
        Me.bindingNav.MovePreviousItem = Me.bindingNavigatorMovePreviousItem
        Me.bindingNav.Name = "bindingNav"
        Me.bindingNav.PositionItem = Me.bindingNavigatorPositionItem
        Me.bindingNav.Size = New System.Drawing.Size(431, 25)
        Me.bindingNav.TabIndex = 2
        Me.bindingNav.Text = "bindingNavigator1"
        '
        'bindingNavigatorAddNewItem
        '
        Me.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorAddNewItem.Enabled = false
        Me.bindingNavigatorAddNewItem.Image = CType(resources.GetObject("bindingNavigatorAddNewItem.Image"),System.Drawing.Image)
        Me.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem"
        Me.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true
        Me.bindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.bindingNavigatorAddNewItem.Text = "Add new"
        '
        'bindingNavigatorCountItem
        '
        Me.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem"
        Me.bindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.bindingNavigatorCountItem.Text = "of {0}"
        Me.bindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'bindingNavigatorDeleteItem
        '
        Me.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorDeleteItem.Enabled = false
        Me.bindingNavigatorDeleteItem.Image = CType(resources.GetObject("bindingNavigatorDeleteItem.Image"),System.Drawing.Image)
        Me.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem"
        Me.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true
        Me.bindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.bindingNavigatorDeleteItem.Text = "Delete"
        '
        'bindingNavigatorMoveFirstItem
        '
        Me.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("bindingNavigatorMoveFirstItem.Image"),System.Drawing.Image)
        Me.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem"
        Me.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true
        Me.bindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.bindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'bindingNavigatorMovePreviousItem
        '
        Me.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("bindingNavigatorMovePreviousItem.Image"),System.Drawing.Image)
        Me.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem"
        Me.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true
        Me.bindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.bindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'bindingNavigatorSeparator
        '
        Me.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator"
        Me.bindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'bindingNavigatorPositionItem
        '
        Me.bindingNavigatorPositionItem.AccessibleName = "Position"
        Me.bindingNavigatorPositionItem.AutoSize = false
        Me.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem"
        Me.bindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.bindingNavigatorPositionItem.Text = "0"
        Me.bindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'bindingNavigatorSeparator1
        '
        Me.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1"
        Me.bindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'bindingNavigatorMoveNextItem
        '
        Me.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorMoveNextItem.Image = CType(resources.GetObject("bindingNavigatorMoveNextItem.Image"),System.Drawing.Image)
        Me.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem"
        Me.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true
        Me.bindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.bindingNavigatorMoveNextItem.Text = "Move next"
        '
        'bindingNavigatorMoveLastItem
        '
        Me.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorMoveLastItem.Image = CType(resources.GetObject("bindingNavigatorMoveLastItem.Image"),System.Drawing.Image)
        Me.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem"
        Me.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true
        Me.bindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.bindingNavigatorMoveLastItem.Text = "Move last"
        '
        'bindingNavigatorSeparator2
        '
        Me.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2"
        Me.bindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'FDGVPaging
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 281)
        Me.Controls.Add(Me.bindingNav)
        Me.Controls.Add(Me.dgvProductNames)
        Me.Name = "FDGVPaging"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DataGridView Paging"
        CType(Me.dgvProductNames,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.bindingNav,System.ComponentModel.ISupportInitialize).EndInit
        Me.bindingNav.ResumeLayout(false)
        Me.bindingNav.PerformLayout
        CType(Me.bindingProducts,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Private WithEvents dgvProductNames As DataGridView
    Private WithEvents ProductName As DataGridViewTextBoxColumn
    Private WithEvents bindingNav As BindingNavigator
    Private WithEvents bindingNavigatorAddNewItem As ToolStripButton
    Private WithEvents bindingNavigatorCountItem As ToolStripLabel
    Private WithEvents bindingNavigatorDeleteItem As ToolStripButton
    Private WithEvents bindingNavigatorMoveFirstItem As ToolStripButton
    Private WithEvents bindingNavigatorMovePreviousItem As ToolStripButton
    Private WithEvents bindingNavigatorSeparator As ToolStripSeparator
    Private WithEvents bindingNavigatorPositionItem As ToolStripTextBox
    Private WithEvents bindingNavigatorSeparator1 As ToolStripSeparator
    Private WithEvents bindingNavigatorMoveNextItem As ToolStripButton
    Private WithEvents bindingNavigatorMoveLastItem As ToolStripButton
    Private WithEvents bindingNavigatorSeparator2 As ToolStripSeparator
    Private WithEvents bindingProducts As BindingSource
End Class
