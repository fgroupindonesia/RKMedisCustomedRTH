Public Class OrderForm

    Private Function getRandomText(ByVal manyDigit As Integer) As String

        Dim aText As String = ""

        Dim _random As Random = New Random()

        For n As Integer = 0 To manyDigit - 1

            Dim number As Integer = _random.Next(0, 26)
            Dim letter As Char = Chr((Asc("a"c) + number))
            aText &= letter.ToString.ToUpper
        Next

        Return aText

    End Function

    Private Function getRandomNumber() As Long
        'Dim aText As String = ""
        'Dim _random As Random = New Random()

        'For n As Integer = 0 To manyDigit - 1

        '    Dim number As Integer = _random.Next(0, 9)
        '    aText &= number
        'Next

        'Dim num As Long = aText
        'Return num

        ' the code below is to get 4 digit random using time format
        Dim aText As String = ""
        Dim time As DateTime = DateTime.Now
        Dim format As String = "HHmm"

        aText = time.ToString(format)

        Return aText

    End Function

    ' this is for OrderForm usage only
    Sub prepareNavigator()
        Navigator.Panels = New Panel() {PanelDelivery, PanelProductItem}
    End Sub

    Function generateNewInvoiceCode() As String

        Dim aNewCode As String = getRandomText(1) & "-" & getRandomNumber() & "-" & getRandomText(5)

        Return aNewCode
    End Function


    Private Sub OrderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' used for switching purposes
        prepareNavigator()

        ' used for ui reference usage
        TableHelper.DataGridViewOrderItem = DataGridViewOrderItem

        ' default combobox
        ComboBoxPaymentMethod.SelectedIndex = 0

        TextBoxInvoiceCode.ReadOnly = True

        If (Mode = MyForm.MODE_EDIT) Then

            TextBoxInvoiceCode.Text = NoInvoice

            ' call DB to obtain the details
            ' extraction directly to tablegridview
            Database.getAllOrderItems(NoInvoice)

        Else
            ' mode for New Doc
            TextBoxInvoiceCode.Text = generateNewInvoiceCode()

        End If

    End Sub

    Private _mainFrameRef As MainFrame
    Public Property MainFrameRef() As MainFrame
        Get
            Return _mainFrameRef
        End Get
        Set(ByVal value As MainFrame)
            _mainFrameRef = value
        End Set
    End Property

    Private _mode As Integer
    Public Property Mode() As Integer
        Get
            Return _mode
        End Get
        Set(ByVal value As Integer)
            _mode = value
        End Set
    End Property

    Private _paymentMethod As String
    Public Property PaymentMethod() As String
        Get
            Return _paymentMethod
        End Get
        Set(ByVal value As String)
            _paymentMethod = value
        End Set
    End Property

    Private _noInvoice As String
    Public Property NoInvoice() As String
        Get
            Return _noInvoice
        End Get
        Set(ByVal value As String)
            _noInvoice = value
        End Set
    End Property

    Private Sub DataGridViewProductItem_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridViewOrderItem.RowsAdded

        calculateCash()

    End Sub

    Sub calculateCash()
        ' calculate the cash
        Dim cash As Integer = 0

        For Each dataR As DataGridViewRow In DataGridViewOrderItem.Rows
            cash += dataR.Cells(5).Value
        Next

        LabelSubTotal.Text = "Overall Total : Rp." & cash

        If (cash <> 0) Then
            PictureBoxSaveOrder.Enabled = True
            PictureBoxSaveOrder.Image = Global.RKMedisCustomizedRTH.My.Resources.save
            PictureBoxSaveOrder.Cursor = Cursors.Hand
        Else
            PictureBoxSaveOrder.Enabled = False
            PictureBoxSaveOrder.Image = Global.RKMedisCustomizedRTH.My.Resources.nosave
            PictureBoxSaveOrder.Cursor = Cursors.Default
        End If

    End Sub

    Private Sub DataGridViewProductItem_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles DataGridViewOrderItem.RowsRemoved
        calculateCash()
    End Sub

    Public Sub addItems(ByVal anArray As ArrayList)

        If (DataGridViewOrderItem.Rows.Count > 0) Then

            Dim justFound As Boolean = False

            ' if the items already there
            Dim dataRow As New OrderData
            For Each nRow As DataGridViewRow In DataGridViewOrderItem.Rows

                ' when the name is equal
                ' thus, we add the existing quantity
                If (existIn(nRow.Cells(2).Value, anArray)) Then
                    updateQuantity(nRow.Cells(2).Value, nRow.Cells(3).Value, anArray)
                Else

                    Dim dataOrder As New OrderData
                    dataOrder.id = nRow.Cells(1).Value
                    dataOrder.product_name = nRow.Cells(2).Value
                    dataOrder.quantity = nRow.Cells(3).Value
                    dataOrder.sub_total = nRow.Cells(5).Value

                    anArray.Add(dataOrder)

                End If

            Next



        Else

        End If

        TableHelper.refreshTableOrderItem(anArray)

    End Sub

    Private Sub updateQuantity(ByVal name As String, quantity As Integer, anArrays As ArrayList)

        For Each n As OrderData In anArrays
            If (n.product_name = name) Then
                Dim firstPrice = n.sub_total / n.quantity
                n.quantity += quantity
                n.sub_total = n.quantity * firstPrice
            End If
        Next

    End Sub

    Private Function existIn(ByVal name As String, anArrays As ArrayList) As Boolean

        Dim found As Boolean = False

        For Each n As OrderData In anArrays

            If (n.product_name = name) Then
                found = True
            End If

        Next

        Return found
    End Function

    Private Sub LinkLabelAddMoreProduct_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelAddMoreProduct.LinkClicked
        Dim frame As New ProductsCatalog
        frame.OrderFormRef = Me
        frame.Show()
    End Sub

    Private Sub DataGridViewProductItem_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewOrderItem.CellEndEdit
        ' confirm the item chosen (picked)
        ' grab the chosen product

    End Sub

    Private Sub LinkLabelDeleteSelectedProduct_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelDeleteSelectedProduct.LinkClicked

        If (Mode = MODE_NEW) Then
            ' delete directly from datagridview
            TableHelper.deleteCheckedRows(DataGridViewOrderItem)
        Else

        End If

    End Sub

    Private _dataOrder As ArrayList
    Public Property DataOrder() As ArrayList
        Get
            Return _dataOrder
        End Get
        Set(ByVal value As ArrayList)
            _dataOrder = value
        End Set
    End Property

    Sub collectOrderData()

        DataOrder.Clear()

        For Each nrow As DataGridViewRow In DataGridViewOrderItem.Rows
            Dim aSingleData As New ProductData

            aSingleData.id = nrow.Cells(2).Value
            aSingleData.price = nrow.Cells(5).Value
            aSingleData.quantity = nrow.Cells(4).Value

            ' save the product as orderdata into the arraylist
            DataOrder.Add(aSingleData)

        Next

    End Sub

    Private Sub PictureBoxSaveOrder_Click(sender As Object, e As EventArgs) Handles PictureBoxSaveOrder.Click

        DataOrder = New ArrayList

        ' collecting data from datagridview
        collectOrderData()

        If (Mode = MODE_EDIT) Then
            'save for updating
            NoInvoice = TextBoxInvoiceCode.Text
            PaymentMethod = ComboBoxPaymentMethod.SelectedItem

            Database.saveOrder(DataOrder, NoInvoice, PaymentMethod, True)
        Else
            'save only
            Database.saveOrder(DataOrder, NoInvoice, PaymentMethod)
        End If

    End Sub

    Private Sub LinkLabelDelivery_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelDelivery.LinkClicked
        Navigator.gotoPage(PAGE_DELIVERY_FORM)
    End Sub

    Private _deliveryData As DeliveryData
    Public Property DeliveryEntry() As DeliveryData
        Get
            Return _deliveryData
        End Get
        Set(ByVal value As DeliveryData)
            _deliveryData = value
        End Set
    End Property

    Private Sub PictureBoxSaveDelivery_Click(sender As Object, e As EventArgs) Handles PictureBoxSaveDelivery.Click


        Navigator.gotoPage(PAGE_ORDER_FORM)
    End Sub

    Private Sub LinkJNE_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkJNE.LinkClicked
        openURL("https://www.jne.co.id/id/tracking/tarif")
    End Sub

    Sub openURL(ByVal anURL As String)
        Try
            '// use default browser
            Process.Start(anURL)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LinkPOST_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkPOST.LinkClicked
        openURL("https://www.posindonesia.co.id/id/check-tarif")
    End Sub

    Private Sub LinkFIRST_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkFIRST.LinkClicked
        openURL("https://www.firstlogistics.co.id")
    End Sub

    Private Sub LinkWAHANA_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkWAHANA.LinkClicked
        openURL("https://www.wahana.com")
    End Sub

    Private Sub LinkREX_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkREX.LinkClicked
        openURL("https://www.rex.co.id/id/calculator")
    End Sub

    Private Sub LinkSICEPAT_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkSICEPAT.LinkClicked
        openURL("https://www.sicepat.com/deliveryFee")
    End Sub

    Private Sub LinkTIKI_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkTIKI.LinkClicked
        openURL("https://tiki.id/id/tariff")
    End Sub

    Private Sub OrderForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' return the navigator back to home MainFrame
        MainFrameRef.prepareNavigator()
    End Sub
End Class