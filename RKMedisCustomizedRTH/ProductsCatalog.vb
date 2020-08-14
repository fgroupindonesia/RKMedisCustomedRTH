Public Class ProductsCatalog

    Dim orderedProducts As New ArrayList


    Private Sub ProductsCatalog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TableHelper.DataGridViewProductCatalog = DataGridViewCatalogProducts

        Database.getAllProducts()

    End Sub

    Private _orderFormRef As OrderForm
    Public Property OrderFormRef() As OrderForm
        Get
            Return _orderFormRef
        End Get
        Set(ByVal value As OrderForm)
            _orderFormRef = value
        End Set
    End Property

    Function confirmOrderedProduct() As Boolean

        DataGridViewCatalogProducts.EndEdit()

        Dim selected As Boolean = False

        ' confirm the product become ordered item
        For Each nBaris As DataGridViewRow In DataGridViewCatalogProducts.Rows

            ' when the item is checked
            ' and quantity ordered is valid above 0
            If (nBaris.Cells(0).Value = True And nBaris.Cells(6).Value > 0) Then

                Dim order As New OrderData

                ' get the details
                order.product_id = nBaris.Cells(1).Value
                order.product_name = nBaris.Cells(2).Value
                order.quantity = nBaris.Cells(6).Value
                order.sub_total = nBaris.Cells(4).Value * nBaris.Cells(6).Value

                If isExists(order) = False Then
                    orderedProducts.Add(order)
                Else
                    updateOrderedProducts(order)
                End If

                selected = True

            End If

        Next

        Return selected

    End Function

    Private Sub updateOrderedProducts(ByVal anOrder As OrderData)

        For Each nData As OrderData In orderedProducts

            If (nData.product_name = anOrder.product_name) Then
                ' update the existing
                nData.quantity = anOrder.quantity
                nData.sub_total = anOrder.sub_total
            End If

        Next

    End Sub


    Private Sub PictureBoxPickProduct_Click(sender As Object, e As EventArgs) Handles PictureBoxPickProduct.Click

        If (confirmOrderedProduct() = True) Then
            Me.OrderFormRef.addItems(orderedProducts)
            Me.Dispose()
        Else
            MessageBox.Show("Please pick the item first!")

        End If


    End Sub



    Function isExists(ByVal anOrder As OrderData) As Boolean

        For Each n As OrderData In orderedProducts

            If (n.product_name = anOrder.product_name) Then
                Return True
            End If

        Next

        Return False
    End Function

    Private Sub DataGridViewCatalogProducts_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewCatalogProducts.CellEndEdit
        If (confirmOrderedProduct() = True) Then
            ' if the items are available (ready)
            PictureBoxPickProduct.Enabled = True
            PictureBoxPickProduct.Image = Global.RKMedisCustomizedRTH.My.Resources.save
            PictureBoxPickProduct.Cursor = Cursors.Hand
        Else
            PictureBoxPickProduct.Enabled = False
            PictureBoxPickProduct.Image = Global.RKMedisCustomizedRTH.My.Resources.nosave
            PictureBoxPickProduct.Cursor = Cursors.Default
        End If
    End Sub
End Class