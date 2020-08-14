<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrderForm))
        Me.TextBoxInvoiceCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelSubTotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxPaymentMethod = New System.Windows.Forms.ComboBox()
        Me.DataGridViewOrderItem = New System.Windows.Forms.DataGridView()
        Me.ColumnCheckboxProductOrderDetail = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ColumnIdProductOrderDetail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnNameProductIdOrderDetail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnNameProductOrderDetail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnQuantityProductOrderDetail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnPriceEachOrderDetail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnSubTotalOrderDetail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LinkLabelDelivery = New System.Windows.Forms.LinkLabel()
        Me.LinkLabelAddMoreProduct = New System.Windows.Forms.LinkLabel()
        Me.LinkLabelDeleteSelectedProduct = New System.Windows.Forms.LinkLabel()
        Me.PictureBoxSaveOrder = New System.Windows.Forms.PictureBox()
        Me.PanelProductItem = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PanelDelivery = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LinkFIRST = New System.Windows.Forms.LinkLabel()
        Me.LinkREX = New System.Windows.Forms.LinkLabel()
        Me.LinkTIKI = New System.Windows.Forms.LinkLabel()
        Me.LinkSICEPAT = New System.Windows.Forms.LinkLabel()
        Me.LinkWAHANA = New System.Windows.Forms.LinkLabel()
        Me.LinkPOST = New System.Windows.Forms.LinkLabel()
        Me.LinkJNE = New System.Windows.Forms.LinkLabel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxMessage = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBoxCourier = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxAddress = New System.Windows.Forms.TextBox()
        Me.TextBoxPrice = New System.Windows.Forms.TextBox()
        Me.PictureBoxSaveDelivery = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridViewOrderItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxSaveOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelProductItem.SuspendLayout()
        Me.PanelDelivery.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxSaveDelivery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxInvoiceCode
        '
        Me.TextBoxInvoiceCode.Location = New System.Drawing.Point(18, 93)
        Me.TextBoxInvoiceCode.Name = "TextBoxInvoiceCode"
        Me.TextBoxInvoiceCode.Size = New System.Drawing.Size(239, 20)
        Me.TextBoxInvoiceCode.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Invoice Code :"
        '
        'LabelSubTotal
        '
        Me.LabelSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSubTotal.Location = New System.Drawing.Point(184, 411)
        Me.LabelSubTotal.Name = "LabelSubTotal"
        Me.LabelSubTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelSubTotal.Size = New System.Drawing.Size(336, 23)
        Me.LabelSubTotal.TabIndex = 2
        Me.LabelSubTotal.Text = "Overall Total : Rp.0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Payment Method:"
        '
        'ComboBoxPaymentMethod
        '
        Me.ComboBoxPaymentMethod.FormattingEnabled = True
        Me.ComboBoxPaymentMethod.Items.AddRange(New Object() {"Bank Transfer", "Cash"})
        Me.ComboBoxPaymentMethod.Location = New System.Drawing.Point(18, 142)
        Me.ComboBoxPaymentMethod.Name = "ComboBoxPaymentMethod"
        Me.ComboBoxPaymentMethod.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxPaymentMethod.TabIndex = 5
        '
        'DataGridViewOrderItem
        '
        Me.DataGridViewOrderItem.AllowUserToAddRows = False
        Me.DataGridViewOrderItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewOrderItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnCheckboxProductOrderDetail, Me.ColumnIdProductOrderDetail, Me.ColumnNameProductIdOrderDetail, Me.ColumnNameProductOrderDetail, Me.ColumnQuantityProductOrderDetail, Me.ColumnPriceEachOrderDetail, Me.ColumnSubTotalOrderDetail})
        Me.DataGridViewOrderItem.Location = New System.Drawing.Point(12, 205)
        Me.DataGridViewOrderItem.Name = "DataGridViewOrderItem"
        Me.DataGridViewOrderItem.Size = New System.Drawing.Size(522, 189)
        Me.DataGridViewOrderItem.TabIndex = 6
        '
        'ColumnCheckboxProductOrderDetail
        '
        Me.ColumnCheckboxProductOrderDetail.HeaderText = "[ x ]"
        Me.ColumnCheckboxProductOrderDetail.Name = "ColumnCheckboxProductOrderDetail"
        Me.ColumnCheckboxProductOrderDetail.Width = 35
        '
        'ColumnIdProductOrderDetail
        '
        Me.ColumnIdProductOrderDetail.HeaderText = "Id"
        Me.ColumnIdProductOrderDetail.Name = "ColumnIdProductOrderDetail"
        Me.ColumnIdProductOrderDetail.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnIdProductOrderDetail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColumnIdProductOrderDetail.Width = 35
        '
        'ColumnNameProductIdOrderDetail
        '
        Me.ColumnNameProductIdOrderDetail.HeaderText = "Product Id"
        Me.ColumnNameProductIdOrderDetail.Name = "ColumnNameProductIdOrderDetail"
        Me.ColumnNameProductIdOrderDetail.Visible = False
        '
        'ColumnNameProductOrderDetail
        '
        Me.ColumnNameProductOrderDetail.HeaderText = "Name"
        Me.ColumnNameProductOrderDetail.Name = "ColumnNameProductOrderDetail"
        '
        'ColumnQuantityProductOrderDetail
        '
        Me.ColumnQuantityProductOrderDetail.HeaderText = "Quantity"
        Me.ColumnQuantityProductOrderDetail.Name = "ColumnQuantityProductOrderDetail"
        '
        'ColumnPriceEachOrderDetail
        '
        Me.ColumnPriceEachOrderDetail.HeaderText = "Price Each"
        Me.ColumnPriceEachOrderDetail.Name = "ColumnPriceEachOrderDetail"
        '
        'ColumnSubTotalOrderDetail
        '
        Me.ColumnSubTotalOrderDetail.HeaderText = "Sub Total"
        Me.ColumnSubTotalOrderDetail.Name = "ColumnSubTotalOrderDetail"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Product Items:"
        '
        'LinkLabelDelivery
        '
        Me.LinkLabelDelivery.Image = Global.RKMedisCustomizedRTH.My.Resources.Resources.delivery
        Me.LinkLabelDelivery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkLabelDelivery.Location = New System.Drawing.Point(450, 157)
        Me.LinkLabelDelivery.Name = "LinkLabelDelivery"
        Me.LinkLabelDelivery.Size = New System.Drawing.Size(84, 45)
        Me.LinkLabelDelivery.TabIndex = 11
        Me.LinkLabelDelivery.TabStop = True
        Me.LinkLabelDelivery.Text = "Delivery"
        Me.LinkLabelDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LinkLabelAddMoreProduct
        '
        Me.LinkLabelAddMoreProduct.Cursor = System.Windows.Forms.Cursors.Default
        Me.LinkLabelAddMoreProduct.Image = Global.RKMedisCustomizedRTH.My.Resources.Resources.add2
        Me.LinkLabelAddMoreProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkLabelAddMoreProduct.Location = New System.Drawing.Point(100, 170)
        Me.LinkLabelAddMoreProduct.Name = "LinkLabelAddMoreProduct"
        Me.LinkLabelAddMoreProduct.Size = New System.Drawing.Size(90, 33)
        Me.LinkLabelAddMoreProduct.TabIndex = 10
        Me.LinkLabelAddMoreProduct.TabStop = True
        Me.LinkLabelAddMoreProduct.Text = "Add More"
        Me.LinkLabelAddMoreProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LinkLabelDeleteSelectedProduct
        '
        Me.LinkLabelDeleteSelectedProduct.Image = Global.RKMedisCustomizedRTH.My.Resources.Resources.delete
        Me.LinkLabelDeleteSelectedProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkLabelDeleteSelectedProduct.Location = New System.Drawing.Point(11, 403)
        Me.LinkLabelDeleteSelectedProduct.Name = "LinkLabelDeleteSelectedProduct"
        Me.LinkLabelDeleteSelectedProduct.Size = New System.Drawing.Size(124, 41)
        Me.LinkLabelDeleteSelectedProduct.TabIndex = 9
        Me.LinkLabelDeleteSelectedProduct.TabStop = True
        Me.LinkLabelDeleteSelectedProduct.Text = "Delete Selected"
        Me.LinkLabelDeleteSelectedProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBoxSaveOrder
        '
        Me.PictureBoxSaveOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxSaveOrder.Enabled = False
        Me.PictureBoxSaveOrder.Image = Global.RKMedisCustomizedRTH.My.Resources.Resources.nosave
        Me.PictureBoxSaveOrder.Location = New System.Drawing.Point(489, 22)
        Me.PictureBoxSaveOrder.Name = "PictureBoxSaveOrder"
        Me.PictureBoxSaveOrder.Size = New System.Drawing.Size(36, 39)
        Me.PictureBoxSaveOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBoxSaveOrder.TabIndex = 8
        Me.PictureBoxSaveOrder.TabStop = False
        '
        'PanelProductItem
        '
        Me.PanelProductItem.Controls.Add(Me.Label9)
        Me.PanelProductItem.Controls.Add(Me.TextBoxInvoiceCode)
        Me.PanelProductItem.Controls.Add(Me.LinkLabelDeleteSelectedProduct)
        Me.PanelProductItem.Controls.Add(Me.LabelSubTotal)
        Me.PanelProductItem.Controls.Add(Me.LinkLabelDelivery)
        Me.PanelProductItem.Controls.Add(Me.Label1)
        Me.PanelProductItem.Controls.Add(Me.LinkLabelAddMoreProduct)
        Me.PanelProductItem.Controls.Add(Me.Label3)
        Me.PanelProductItem.Controls.Add(Me.ComboBoxPaymentMethod)
        Me.PanelProductItem.Controls.Add(Me.PictureBoxSaveOrder)
        Me.PanelProductItem.Controls.Add(Me.DataGridViewOrderItem)
        Me.PanelProductItem.Controls.Add(Me.Label4)
        Me.PanelProductItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelProductItem.Location = New System.Drawing.Point(0, 0)
        Me.PanelProductItem.Name = "PanelProductItem"
        Me.PanelProductItem.Size = New System.Drawing.Size(547, 463)
        Me.PanelProductItem.TabIndex = 12
        Me.PanelProductItem.Tag = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(199, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(140, 24)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Product Detail"
        '
        'PanelDelivery
        '
        Me.PanelDelivery.Controls.Add(Me.GroupBox1)
        Me.PanelDelivery.Controls.Add(Me.Label8)
        Me.PanelDelivery.Controls.Add(Me.Label7)
        Me.PanelDelivery.Controls.Add(Me.Label2)
        Me.PanelDelivery.Controls.Add(Me.TextBoxMessage)
        Me.PanelDelivery.Controls.Add(Me.Label5)
        Me.PanelDelivery.Controls.Add(Me.ComboBoxCourier)
        Me.PanelDelivery.Controls.Add(Me.Label6)
        Me.PanelDelivery.Controls.Add(Me.TextBoxAddress)
        Me.PanelDelivery.Controls.Add(Me.TextBoxPrice)
        Me.PanelDelivery.Controls.Add(Me.PictureBoxSaveDelivery)
        Me.PanelDelivery.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDelivery.Location = New System.Drawing.Point(0, 0)
        Me.PanelDelivery.Name = "PanelDelivery"
        Me.PanelDelivery.Size = New System.Drawing.Size(547, 463)
        Me.PanelDelivery.TabIndex = 12
        Me.PanelDelivery.Tag = "2"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LinkFIRST)
        Me.GroupBox1.Controls.Add(Me.LinkREX)
        Me.GroupBox1.Controls.Add(Me.LinkTIKI)
        Me.GroupBox1.Controls.Add(Me.LinkSICEPAT)
        Me.GroupBox1.Controls.Add(Me.LinkWAHANA)
        Me.GroupBox1.Controls.Add(Me.LinkPOST)
        Me.GroupBox1.Controls.Add(Me.LinkJNE)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(21, 270)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(480, 198)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Check Courier Price"
        '
        'LinkFIRST
        '
        Me.LinkFIRST.AutoSize = True
        Me.LinkFIRST.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkFIRST.Location = New System.Drawing.Point(271, 66)
        Me.LinkFIRST.Name = "LinkFIRST"
        Me.LinkFIRST.Size = New System.Drawing.Size(80, 13)
        Me.LinkFIRST.TabIndex = 35
        Me.LinkFIRST.TabStop = True
        Me.LinkFIRST.Text = "FIRST Website"
        '
        'LinkREX
        '
        Me.LinkREX.AutoSize = True
        Me.LinkREX.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkREX.Location = New System.Drawing.Point(268, 110)
        Me.LinkREX.Name = "LinkREX"
        Me.LinkREX.Size = New System.Drawing.Size(71, 13)
        Me.LinkREX.TabIndex = 34
        Me.LinkREX.TabStop = True
        Me.LinkREX.Text = "REX Website"
        '
        'LinkTIKI
        '
        Me.LinkTIKI.AutoSize = True
        Me.LinkTIKI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkTIKI.Location = New System.Drawing.Point(249, 172)
        Me.LinkTIKI.Name = "LinkTIKI"
        Me.LinkTIKI.Size = New System.Drawing.Size(69, 13)
        Me.LinkTIKI.TabIndex = 33
        Me.LinkTIKI.TabStop = True
        Me.LinkTIKI.Text = "TIKI Website"
        '
        'LinkSICEPAT
        '
        Me.LinkSICEPAT.AutoSize = True
        Me.LinkSICEPAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkSICEPAT.Location = New System.Drawing.Point(95, 170)
        Me.LinkSICEPAT.Name = "LinkSICEPAT"
        Me.LinkSICEPAT.Size = New System.Drawing.Size(94, 13)
        Me.LinkSICEPAT.TabIndex = 32
        Me.LinkSICEPAT.TabStop = True
        Me.LinkSICEPAT.Text = "SICEPAT Website"
        '
        'LinkWAHANA
        '
        Me.LinkWAHANA.AutoSize = True
        Me.LinkWAHANA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkWAHANA.Location = New System.Drawing.Point(165, 132)
        Me.LinkWAHANA.Name = "LinkWAHANA"
        Me.LinkWAHANA.Size = New System.Drawing.Size(97, 13)
        Me.LinkWAHANA.TabIndex = 31
        Me.LinkWAHANA.TabStop = True
        Me.LinkWAHANA.Text = "WAHANA Website"
        '
        'LinkPOST
        '
        Me.LinkPOST.AutoSize = True
        Me.LinkPOST.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkPOST.Location = New System.Drawing.Point(185, 84)
        Me.LinkPOST.Name = "LinkPOST"
        Me.LinkPOST.Size = New System.Drawing.Size(78, 13)
        Me.LinkPOST.TabIndex = 30
        Me.LinkPOST.TabStop = True
        Me.LinkPOST.Text = "POST Website"
        '
        'LinkJNE
        '
        Me.LinkJNE.AutoSize = True
        Me.LinkJNE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkJNE.Location = New System.Drawing.Point(84, 90)
        Me.LinkJNE.Name = "LinkJNE"
        Me.LinkJNE.Size = New System.Drawing.Size(69, 13)
        Me.LinkJNE.TabIndex = 29
        Me.LinkJNE.TabStop = True
        Me.LinkJNE.Text = "JNE Website"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(9, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(171, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Click one of the links given below :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RKMedisCustomizedRTH.My.Resources.Resources.logo_kurir
        Me.PictureBox1.Location = New System.Drawing.Point(66, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(297, 149)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(199, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(143, 24)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Delivery Detail"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 214)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Price:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(243, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Message:"
        '
        'TextBoxMessage
        '
        Me.TextBoxMessage.Location = New System.Drawing.Point(243, 168)
        Me.TextBoxMessage.Multiline = True
        Me.TextBoxMessage.Name = "TextBoxMessage"
        Me.TextBoxMessage.Size = New System.Drawing.Size(282, 86)
        Me.TextBoxMessage.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(240, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Courier:"
        '
        'ComboBoxCourier
        '
        Me.ComboBoxCourier.FormattingEnabled = True
        Me.ComboBoxCourier.Location = New System.Drawing.Point(243, 112)
        Me.ComboBoxCourier.Name = "ComboBoxCourier"
        Me.ComboBoxCourier.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxCourier.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Address:"
        '
        'TextBoxAddress
        '
        Me.TextBoxAddress.Location = New System.Drawing.Point(16, 89)
        Me.TextBoxAddress.Multiline = True
        Me.TextBoxAddress.Name = "TextBoxAddress"
        Me.TextBoxAddress.Size = New System.Drawing.Size(197, 110)
        Me.TextBoxAddress.TabIndex = 20
        '
        'TextBoxPrice
        '
        Me.TextBoxPrice.Location = New System.Drawing.Point(16, 234)
        Me.TextBoxPrice.Name = "TextBoxPrice"
        Me.TextBoxPrice.Size = New System.Drawing.Size(197, 20)
        Me.TextBoxPrice.TabIndex = 19
        '
        'PictureBoxSaveDelivery
        '
        Me.PictureBoxSaveDelivery.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBoxSaveDelivery.Enabled = False
        Me.PictureBoxSaveDelivery.Image = Global.RKMedisCustomizedRTH.My.Resources.Resources.nosave
        Me.PictureBoxSaveDelivery.Location = New System.Drawing.Point(489, 22)
        Me.PictureBoxSaveDelivery.Name = "PictureBoxSaveDelivery"
        Me.PictureBoxSaveDelivery.Size = New System.Drawing.Size(36, 39)
        Me.PictureBoxSaveDelivery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBoxSaveDelivery.TabIndex = 18
        Me.PictureBoxSaveDelivery.TabStop = False
        '
        'OrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 463)
        Me.Controls.Add(Me.PanelProductItem)
        Me.Controls.Add(Me.PanelDelivery)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OrderForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order Form"
        CType(Me.DataGridViewOrderItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxSaveOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelProductItem.ResumeLayout(False)
        Me.PanelProductItem.PerformLayout()
        Me.PanelDelivery.ResumeLayout(False)
        Me.PanelDelivery.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxSaveDelivery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TextBoxInvoiceCode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelSubTotal As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBoxPaymentMethod As ComboBox
    Friend WithEvents DataGridViewOrderItem As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBoxSaveOrder As PictureBox
    Friend WithEvents LinkLabelDeleteSelectedProduct As LinkLabel
    Friend WithEvents LinkLabelAddMoreProduct As LinkLabel
    Friend WithEvents LinkLabelDelivery As LinkLabel
    Friend WithEvents PanelProductItem As Panel
    Friend WithEvents PanelDelivery As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxMessage As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBoxCourier As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxAddress As TextBox
    Friend WithEvents TextBoxPrice As TextBox
    Friend WithEvents PictureBoxSaveDelivery As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents LinkREX As LinkLabel
    Friend WithEvents LinkTIKI As LinkLabel
    Friend WithEvents LinkSICEPAT As LinkLabel
    Friend WithEvents LinkWAHANA As LinkLabel
    Friend WithEvents LinkPOST As LinkLabel
    Friend WithEvents LinkJNE As LinkLabel
    Friend WithEvents LinkFIRST As LinkLabel
    Friend WithEvents ColumnCheckboxProductOrderDetail As DataGridViewCheckBoxColumn
    Friend WithEvents ColumnIdProductOrderDetail As DataGridViewTextBoxColumn
    Friend WithEvents ColumnNameProductIdOrderDetail As DataGridViewTextBoxColumn
    Friend WithEvents ColumnNameProductOrderDetail As DataGridViewTextBoxColumn
    Friend WithEvents ColumnQuantityProductOrderDetail As DataGridViewTextBoxColumn
    Friend WithEvents ColumnPriceEachOrderDetail As DataGridViewTextBoxColumn
    Friend WithEvents ColumnSubTotalOrderDetail As DataGridViewTextBoxColumn
End Class
