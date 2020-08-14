<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductsCatalog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductsCatalog))
        Me.DataGridViewCatalogProducts = New System.Windows.Forms.DataGridView()
        Me.ColumnCheckbox = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ColumnIdProduct = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnNameProduct = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnCategoryProduct = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnPriceProduct = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnQuantityProduct = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnQuantityOrdered = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxProductSortKey = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBoxPickProduct = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridViewCatalogProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxPickProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewCatalogProducts
        '
        Me.DataGridViewCatalogProducts.AllowUserToAddRows = False
        Me.DataGridViewCatalogProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCatalogProducts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnCheckbox, Me.ColumnIdProduct, Me.ColumnNameProduct, Me.ColumnCategoryProduct, Me.ColumnPriceProduct, Me.ColumnQuantityProduct, Me.ColumnQuantityOrdered})
        Me.DataGridViewCatalogProducts.Location = New System.Drawing.Point(12, 85)
        Me.DataGridViewCatalogProducts.Name = "DataGridViewCatalogProducts"
        Me.DataGridViewCatalogProducts.Size = New System.Drawing.Size(622, 279)
        Me.DataGridViewCatalogProducts.TabIndex = 0
        '
        'ColumnCheckbox
        '
        Me.ColumnCheckbox.HeaderText = "[ x ]"
        Me.ColumnCheckbox.Name = "ColumnCheckbox"
        Me.ColumnCheckbox.Width = 35
        '
        'ColumnIdProduct
        '
        Me.ColumnIdProduct.HeaderText = "Id"
        Me.ColumnIdProduct.Name = "ColumnIdProduct"
        Me.ColumnIdProduct.Width = 35
        '
        'ColumnNameProduct
        '
        Me.ColumnNameProduct.HeaderText = "Name"
        Me.ColumnNameProduct.Name = "ColumnNameProduct"
        '
        'ColumnCategoryProduct
        '
        Me.ColumnCategoryProduct.HeaderText = "Category"
        Me.ColumnCategoryProduct.Name = "ColumnCategoryProduct"
        '
        'ColumnPriceProduct
        '
        Me.ColumnPriceProduct.HeaderText = "Price"
        Me.ColumnPriceProduct.Name = "ColumnPriceProduct"
        '
        'ColumnQuantityProduct
        '
        Me.ColumnQuantityProduct.HeaderText = "Quantity Available"
        Me.ColumnQuantityProduct.Name = "ColumnQuantityProduct"
        '
        'ColumnQuantityOrdered
        '
        Me.ColumnQuantityOrdered.HeaderText = "Quantity Ordered"
        Me.ColumnQuantityOrdered.Name = "ColumnQuantityOrdered"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sort By : "
        '
        'TextBoxProductSortKey
        '
        Me.TextBoxProductSortKey.Location = New System.Drawing.Point(70, 54)
        Me.TextBoxProductSortKey.Name = "TextBoxProductSortKey"
        Me.TextBoxProductSortKey.Size = New System.Drawing.Size(175, 20)
        Me.TextBoxProductSortKey.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(369, 38)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "You may tick/untick the items from the table data below. Once you're done, click " &
    "on the Save button."
        '
        'PictureBoxPickProduct
        '
        Me.PictureBoxPickProduct.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBoxPickProduct.Image = Global.RKMedisCustomizedRTH.My.Resources.Resources.nosave
        Me.PictureBoxPickProduct.Location = New System.Drawing.Point(598, 13)
        Me.PictureBoxPickProduct.Name = "PictureBoxPickProduct"
        Me.PictureBoxPickProduct.Size = New System.Drawing.Size(36, 39)
        Me.PictureBoxPickProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBoxPickProduct.TabIndex = 9
        Me.PictureBoxPickProduct.TabStop = False
        '
        'ProductsCatalog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 376)
        Me.Controls.Add(Me.PictureBoxPickProduct)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxProductSortKey)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridViewCatalogProducts)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ProductsCatalog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Products Catalog"
        CType(Me.DataGridViewCatalogProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxPickProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewCatalogProducts As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxProductSortKey As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBoxPickProduct As PictureBox
    Friend WithEvents ColumnCheckbox As DataGridViewCheckBoxColumn
    Friend WithEvents ColumnIdProduct As DataGridViewTextBoxColumn
    Friend WithEvents ColumnNameProduct As DataGridViewTextBoxColumn
    Friend WithEvents ColumnCategoryProduct As DataGridViewTextBoxColumn
    Friend WithEvents ColumnPriceProduct As DataGridViewTextBoxColumn
    Friend WithEvents ColumnQuantityProduct As DataGridViewTextBoxColumn
    Friend WithEvents ColumnQuantityOrdered As DataGridViewTextBoxColumn
End Class
