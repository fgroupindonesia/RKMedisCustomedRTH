Imports System.Drawing.Imaging

Public Class ProductForm
    Private Sub LinkLabelAddNewCategoryProduct_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelAddNewCategoryProduct.LinkClicked
        GroupBoxNewCategoryProduct.Visible = True
        ComboBoxCategoryProduct.Enabled = False

        TextBoxNewCategoryProduct.Focus()
        TextBoxNewCategoryProduct.BackColor = Color.Yellow
    End Sub

    Private Sub LinkLabelCancelCategoryProduct_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelCancelCategoryProduct.LinkClicked
        ComboBoxCategoryProduct.Enabled = True
        GroupBoxNewCategoryProduct.Visible = False
    End Sub

    Private Sub TextBoxNewCategoryProduct_Leave(sender As Object, e As EventArgs) Handles TextBoxNewCategoryProduct.Leave
        TextBoxNewCategoryProduct.BackColor = Nothing
    End Sub

    Private Sub LinkLabelAddNewUnitProduct_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelAddNewUnitProduct.LinkClicked
        GroupBoxUnitProduct.Visible = True
        ComboBoxUnitProduct.Enabled = False

        TextBoxNewUnitProduct.Focus()
        TextBoxNewUnitProduct.BackColor = Color.Yellow
    End Sub

    Private Sub LinkLabelCancelUnitProduct_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelCancelUnitProduct.LinkClicked
        GroupBoxUnitProduct.Visible = False
        ComboBoxUnitProduct.Enabled = True
    End Sub

    Private Sub TextBoxNewUnitProduct_Leave(sender As Object, e As EventArgs) Handles TextBoxNewUnitProduct.Leave
        TextBoxNewUnitProduct.BackColor = Nothing
    End Sub

    Private Sub LinkLabelSaveUserForm_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelSaveUserForm.LinkClicked

        Data.name = TextBoxNameProduct.Text
        Data.category = ComboBoxCategoryProduct.Text
        Data.quantity = NumericUpDownQuantityProduct.Value
        Data.satuan = ComboBoxUnitProduct.Text
        Data.price = TextBoxPriceProduct.Text
        Data.status = ComboBoxStatusProduct.Text
        Data.image_file = ImageHelper.ImageToBase64(PictureBox1.Image, ImageFormat.Png)


        ' for DB update status later
        PanelRef.ProgressFormLabel = LabelLoadingProductForm

        If (Mode = MyForm.MODE_EDIT) Then

            Database.saveProduct(Data, True)
        Else
            ' mode New
            Database.saveProduct(Data, False)
        End If

    End Sub

    Private _mainFrame As MainFrame
    Public Property MainFrameRef() As MainFrame
        Get
            Return _mainFrame
        End Get
        Set(ByVal value As MainFrame)
            _mainFrame = value
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

    Private _data As ProductData
    Public Property Data() As ProductData
        Get
            Return _data
        End Get
        Set(ByVal value As ProductData)
            _data = value
        End Set
    End Property

    Private Async Sub ProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' these 2 calls are important to be waited
        ' before everythings started
        Await Database.getAllProductCategory(ComboBoxCategoryProduct)
        Await Database.getAllProductUnit(ComboBoxUnitProduct)

        ComboBoxStatusProduct.SelectedItem = "available"

        If (Me.Mode = MODE_NEW) Then
            Data = New ProductData

        Else
            ' this Edit Mode
            TextBoxNameProduct.Text = Data.name
            TextBoxPriceProduct.Text = Data.price
            NumericUpDownQuantityProduct.Value = Data.quantity
            ComboBoxCategoryProduct.SelectedItem = Data.category
            ComboBoxStatusProduct.SelectedItem = Data.status
            ComboBoxUnitProduct.SelectedItem = Data.satuan

            LinkLabelBrowsePhoto.Text = "Reset"

            If (Data.image_file IsNot Nothing) Then
                ' download the image first' for referencing DB call usage
                PanelRef.PreviewPicturebox = PictureBox1

                ' call the image render
                Database.downloadProductPicture(Data.image_file)

            End If

        End If

    End Sub

    Private Sub LinkLabelBrowsePhoto_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelBrowsePhoto.LinkClicked

        If (LinkLabelBrowsePhoto.Text.Contains("Browse")) Then
            ' opening browse file dialog
            If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then
                PictureBox1.Image.Dispose()

                Dim gbr As Image = Image.FromFile(OpenFileDialog1.FileName)

                PictureBox1.Image = New Bitmap(ImageHelper.resizeImage(314, 235, gbr))

                gbr.Dispose()

                LinkLabelBrowsePhoto.Text = "Reset"
            End If

        Else
            ' resetting picture
            PictureBox1.Image.Dispose()
            PictureBox1.Image = Global.RKMedisCustomizedRTH.My.Resources.product

            LinkLabelBrowsePhoto.Text = "Browse..."
        End If
    End Sub
End Class