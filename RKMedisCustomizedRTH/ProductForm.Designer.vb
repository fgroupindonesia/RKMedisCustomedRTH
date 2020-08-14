<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBoxStatusProduct = New System.Windows.Forms.ComboBox()
        Me.LinkLabelBrowsePhoto = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBoxPriceProduct = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBoxUnitProduct = New System.Windows.Forms.GroupBox()
        Me.ButtonAddUnitProduct = New System.Windows.Forms.Button()
        Me.LinkLabelCancelUnitProduct = New System.Windows.Forms.LinkLabel()
        Me.TextBoxNewUnitProduct = New System.Windows.Forms.TextBox()
        Me.LinkLabelAddNewUnitProduct = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBoxUnitProduct = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NumericUpDownQuantityProduct = New System.Windows.Forms.NumericUpDown()
        Me.GroupBoxNewCategoryProduct = New System.Windows.Forms.GroupBox()
        Me.ButtonAddCategoryProduct = New System.Windows.Forms.Button()
        Me.LinkLabelCancelCategoryProduct = New System.Windows.Forms.LinkLabel()
        Me.TextBoxNewCategoryProduct = New System.Windows.Forms.TextBox()
        Me.LinkLabelAddNewCategoryProduct = New System.Windows.Forms.LinkLabel()
        Me.ComboBoxCategoryProduct = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxNameProduct = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelLoadingProductForm = New System.Windows.Forms.Label()
        Me.LinkLabelSaveUserForm = New System.Windows.Forms.LinkLabel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxUnitProduct.SuspendLayout()
        CType(Me.NumericUpDownQuantityProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxNewCategoryProduct.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.ComboBoxStatusProduct)
        Me.Panel1.Controls.Add(Me.LinkLabelBrowsePhoto)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.TextBoxPriceProduct)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.GroupBoxUnitProduct)
        Me.Panel1.Controls.Add(Me.LinkLabelAddNewUnitProduct)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.ComboBoxUnitProduct)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.NumericUpDownQuantityProduct)
        Me.Panel1.Controls.Add(Me.GroupBoxNewCategoryProduct)
        Me.Panel1.Controls.Add(Me.LinkLabelAddNewCategoryProduct)
        Me.Panel1.Controls.Add(Me.ComboBoxCategoryProduct)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TextBoxNameProduct)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.LabelLoadingProductForm)
        Me.Panel1.Controls.Add(Me.LinkLabelSaveUserForm)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(619, 487)
        Me.Panel1.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(407, 337)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Status"
        '
        'ComboBoxStatusProduct
        '
        Me.ComboBoxStatusProduct.FormattingEnabled = True
        Me.ComboBoxStatusProduct.Items.AddRange(New Object() {"available", "out of stock"})
        Me.ComboBoxStatusProduct.Location = New System.Drawing.Point(410, 359)
        Me.ComboBoxStatusProduct.Name = "ComboBoxStatusProduct"
        Me.ComboBoxStatusProduct.Size = New System.Drawing.Size(139, 21)
        Me.ComboBoxStatusProduct.TabIndex = 57
        '
        'LinkLabelBrowsePhoto
        '
        Me.LinkLabelBrowsePhoto.AutoSize = True
        Me.LinkLabelBrowsePhoto.Location = New System.Drawing.Point(511, 295)
        Me.LinkLabelBrowsePhoto.Name = "LinkLabelBrowsePhoto"
        Me.LinkLabelBrowsePhoto.Size = New System.Drawing.Size(51, 13)
        Me.LinkLabelBrowsePhoto.TabIndex = 56
        Me.LinkLabelBrowsePhoto.TabStop = True
        Me.LinkLabelBrowsePhoto.Text = "Browse..."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(407, 140)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(166, 148)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Photo"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(160, 129)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 54
        Me.PictureBox1.TabStop = False
        '
        'TextBoxPriceProduct
        '
        Me.TextBoxPriceProduct.Location = New System.Drawing.Point(187, 268)
        Me.TextBoxPriceProduct.Name = "TextBoxPriceProduct"
        Me.TextBoxPriceProduct.Size = New System.Drawing.Size(167, 20)
        Me.TextBoxPriceProduct.TabIndex = 53
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(184, 250)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Price"
        '
        'GroupBoxUnitProduct
        '
        Me.GroupBoxUnitProduct.Controls.Add(Me.ButtonAddUnitProduct)
        Me.GroupBoxUnitProduct.Controls.Add(Me.LinkLabelCancelUnitProduct)
        Me.GroupBoxUnitProduct.Controls.Add(Me.TextBoxNewUnitProduct)
        Me.GroupBoxUnitProduct.Location = New System.Drawing.Point(182, 308)
        Me.GroupBoxUnitProduct.Name = "GroupBoxUnitProduct"
        Me.GroupBoxUnitProduct.Size = New System.Drawing.Size(200, 72)
        Me.GroupBoxUnitProduct.TabIndex = 51
        Me.GroupBoxUnitProduct.TabStop = False
        Me.GroupBoxUnitProduct.Text = "New Unit"
        Me.GroupBoxUnitProduct.Visible = False
        '
        'ButtonAddUnitProduct
        '
        Me.ButtonAddUnitProduct.Location = New System.Drawing.Point(142, 19)
        Me.ButtonAddUnitProduct.Name = "ButtonAddUnitProduct"
        Me.ButtonAddUnitProduct.Size = New System.Drawing.Size(47, 23)
        Me.ButtonAddUnitProduct.TabIndex = 43
        Me.ButtonAddUnitProduct.Text = "Add"
        Me.ButtonAddUnitProduct.UseVisualStyleBackColor = True
        '
        'LinkLabelCancelUnitProduct
        '
        Me.LinkLabelCancelUnitProduct.AutoSize = True
        Me.LinkLabelCancelUnitProduct.Location = New System.Drawing.Point(92, 48)
        Me.LinkLabelCancelUnitProduct.Name = "LinkLabelCancelUnitProduct"
        Me.LinkLabelCancelUnitProduct.Size = New System.Drawing.Size(40, 13)
        Me.LinkLabelCancelUnitProduct.TabIndex = 44
        Me.LinkLabelCancelUnitProduct.TabStop = True
        Me.LinkLabelCancelUnitProduct.Text = "Cancel"
        '
        'TextBoxNewUnitProduct
        '
        Me.TextBoxNewUnitProduct.Location = New System.Drawing.Point(11, 20)
        Me.TextBoxNewUnitProduct.Name = "TextBoxNewUnitProduct"
        Me.TextBoxNewUnitProduct.Size = New System.Drawing.Size(122, 20)
        Me.TextBoxNewUnitProduct.TabIndex = 39
        '
        'LinkLabelAddNewUnitProduct
        '
        Me.LinkLabelAddNewUnitProduct.AutoSize = True
        Me.LinkLabelAddNewUnitProduct.Location = New System.Drawing.Point(103, 354)
        Me.LinkLabelAddNewUnitProduct.Name = "LinkLabelAddNewUnitProduct"
        Me.LinkLabelAddNewUnitProduct.Size = New System.Drawing.Size(51, 13)
        Me.LinkLabelAddNewUnitProduct.TabIndex = 50
        Me.LinkLabelAddNewUnitProduct.TabStop = True
        Me.LinkLabelAddNewUnitProduct.Text = "Add New"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 308)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Unit"
        '
        'ComboBoxUnitProduct
        '
        Me.ComboBoxUnitProduct.FormattingEnabled = True
        Me.ComboBoxUnitProduct.Location = New System.Drawing.Point(27, 326)
        Me.ComboBoxUnitProduct.Name = "ComboBoxUnitProduct"
        Me.ComboBoxUnitProduct.Size = New System.Drawing.Size(136, 21)
        Me.ComboBoxUnitProduct.TabIndex = 48
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 253)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Quantity"
        '
        'NumericUpDownQuantityProduct
        '
        Me.NumericUpDownQuantityProduct.Location = New System.Drawing.Point(27, 270)
        Me.NumericUpDownQuantityProduct.Name = "NumericUpDownQuantityProduct"
        Me.NumericUpDownQuantityProduct.Size = New System.Drawing.Size(71, 20)
        Me.NumericUpDownQuantityProduct.TabIndex = 46
        Me.NumericUpDownQuantityProduct.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'GroupBoxNewCategoryProduct
        '
        Me.GroupBoxNewCategoryProduct.Controls.Add(Me.ButtonAddCategoryProduct)
        Me.GroupBoxNewCategoryProduct.Controls.Add(Me.LinkLabelCancelCategoryProduct)
        Me.GroupBoxNewCategoryProduct.Controls.Add(Me.TextBoxNewCategoryProduct)
        Me.GroupBoxNewCategoryProduct.Location = New System.Drawing.Point(182, 168)
        Me.GroupBoxNewCategoryProduct.Name = "GroupBoxNewCategoryProduct"
        Me.GroupBoxNewCategoryProduct.Size = New System.Drawing.Size(200, 72)
        Me.GroupBoxNewCategoryProduct.TabIndex = 45
        Me.GroupBoxNewCategoryProduct.TabStop = False
        Me.GroupBoxNewCategoryProduct.Text = "New Category"
        Me.GroupBoxNewCategoryProduct.Visible = False
        '
        'ButtonAddCategoryProduct
        '
        Me.ButtonAddCategoryProduct.Location = New System.Drawing.Point(142, 19)
        Me.ButtonAddCategoryProduct.Name = "ButtonAddCategoryProduct"
        Me.ButtonAddCategoryProduct.Size = New System.Drawing.Size(47, 23)
        Me.ButtonAddCategoryProduct.TabIndex = 43
        Me.ButtonAddCategoryProduct.Text = "Add"
        Me.ButtonAddCategoryProduct.UseVisualStyleBackColor = True
        '
        'LinkLabelCancelCategoryProduct
        '
        Me.LinkLabelCancelCategoryProduct.AutoSize = True
        Me.LinkLabelCancelCategoryProduct.Location = New System.Drawing.Point(92, 48)
        Me.LinkLabelCancelCategoryProduct.Name = "LinkLabelCancelCategoryProduct"
        Me.LinkLabelCancelCategoryProduct.Size = New System.Drawing.Size(40, 13)
        Me.LinkLabelCancelCategoryProduct.TabIndex = 44
        Me.LinkLabelCancelCategoryProduct.TabStop = True
        Me.LinkLabelCancelCategoryProduct.Text = "Cancel"
        '
        'TextBoxNewCategoryProduct
        '
        Me.TextBoxNewCategoryProduct.Location = New System.Drawing.Point(11, 20)
        Me.TextBoxNewCategoryProduct.Name = "TextBoxNewCategoryProduct"
        Me.TextBoxNewCategoryProduct.Size = New System.Drawing.Size(122, 20)
        Me.TextBoxNewCategoryProduct.TabIndex = 39
        '
        'LinkLabelAddNewCategoryProduct
        '
        Me.LinkLabelAddNewCategoryProduct.AutoSize = True
        Me.LinkLabelAddNewCategoryProduct.Location = New System.Drawing.Point(112, 217)
        Me.LinkLabelAddNewCategoryProduct.Name = "LinkLabelAddNewCategoryProduct"
        Me.LinkLabelAddNewCategoryProduct.Size = New System.Drawing.Size(51, 13)
        Me.LinkLabelAddNewCategoryProduct.TabIndex = 41
        Me.LinkLabelAddNewCategoryProduct.TabStop = True
        Me.LinkLabelAddNewCategoryProduct.Text = "Add New"
        '
        'ComboBoxCategoryProduct
        '
        Me.ComboBoxCategoryProduct.FormattingEnabled = True
        Me.ComboBoxCategoryProduct.Location = New System.Drawing.Point(27, 187)
        Me.ComboBoxCategoryProduct.Name = "ComboBoxCategoryProduct"
        Me.ComboBoxCategoryProduct.Size = New System.Drawing.Size(140, 21)
        Me.ComboBoxCategoryProduct.TabIndex = 40
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Category"
        '
        'TextBoxNameProduct
        '
        Me.TextBoxNameProduct.Location = New System.Drawing.Point(27, 140)
        Me.TextBoxNameProduct.Name = "TextBoxNameProduct"
        Me.TextBoxNameProduct.Size = New System.Drawing.Size(234, 20)
        Me.TextBoxNameProduct.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Name"
        '
        'LabelLoadingProductForm
        '
        Me.LabelLoadingProductForm.Image = Global.RKMedisCustomizedRTH.My.Resources.Resources.loading
        Me.LabelLoadingProductForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelLoadingProductForm.Location = New System.Drawing.Point(279, 65)
        Me.LabelLoadingProductForm.Name = "LabelLoadingProductForm"
        Me.LabelLoadingProductForm.Size = New System.Drawing.Size(188, 42)
        Me.LabelLoadingProductForm.TabIndex = 35
        Me.LabelLoadingProductForm.Text = "Loading..."
        Me.LabelLoadingProductForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelLoadingProductForm.Visible = False
        '
        'LinkLabelSaveUserForm
        '
        Me.LinkLabelSaveUserForm.Image = Global.RKMedisCustomizedRTH.My.Resources.Resources.save
        Me.LinkLabelSaveUserForm.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LinkLabelSaveUserForm.Location = New System.Drawing.Point(473, 65)
        Me.LinkLabelSaveUserForm.Name = "LinkLabelSaveUserForm"
        Me.LinkLabelSaveUserForm.Size = New System.Drawing.Size(56, 53)
        Me.LinkLabelSaveUserForm.TabIndex = 34
        Me.LinkLabelSaveUserForm.TabStop = True
        Me.LinkLabelSaveUserForm.Text = "Save"
        Me.LinkLabelSaveUserForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(126, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(284, 23)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Product Form"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ProductForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 487)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ProductForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProductForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxUnitProduct.ResumeLayout(False)
        Me.GroupBoxUnitProduct.PerformLayout()
        CType(Me.NumericUpDownQuantityProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxNewCategoryProduct.ResumeLayout(False)
        Me.GroupBoxNewCategoryProduct.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelLoadingProductForm As Label
    Friend WithEvents LinkLabelSaveUserForm As LinkLabel
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxNameProduct As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxNewCategoryProduct As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkLabelAddNewCategoryProduct As LinkLabel
    Friend WithEvents ComboBoxCategoryProduct As ComboBox
    Friend WithEvents ButtonAddCategoryProduct As Button
    Friend WithEvents LinkLabelCancelCategoryProduct As LinkLabel
    Friend WithEvents GroupBoxNewCategoryProduct As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents NumericUpDownQuantityProduct As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBoxUnitProduct As ComboBox
    Friend WithEvents LinkLabelAddNewUnitProduct As LinkLabel
    Friend WithEvents GroupBoxUnitProduct As GroupBox
    Friend WithEvents ButtonAddUnitProduct As Button
    Friend WithEvents LinkLabelCancelUnitProduct As LinkLabel
    Friend WithEvents TextBoxNewUnitProduct As TextBox
    Friend WithEvents TextBoxPriceProduct As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LinkLabelBrowsePhoto As LinkLabel
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBoxStatusProduct As ComboBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
