Imports System.Drawing.Imaging

Public Class UserForm

    Private _mainFrame As MainFrame
    Public Property MainFrameRef() As MainFrame
        Get
            Return _mainFrame
        End Get
        Set(ByVal value As MainFrame)
            _mainFrame = value
        End Set
    End Property

    Private Sub UserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (Mode = MyForm.MODE_EDIT) Then
            TextBoxUsernameUserForm.Text = Data.username
            TextBoxPasswordUserForm.Text = Data.pass
            TextBoxEmailUserForm.Text = Data.email
            TextBoxAddressUserForm.Text = Data.address
            TextBoxHandphoneUserForm.Text = Data.handphone
            TextBoxFullnameUserForm.Text = Data.full_name

            LinkLabelPictureUserForm.Text = "Reset"

            ' for referencing DB call usage
            PanelRef.UserPropicPictureBox = PictureBoxPropicUserForm

            ' call the image render
            Database.downloadUserPropic(Data.username)

        Else
            Me.Data = New UserData
        End If

    End Sub

    Private _mode As Integer
    Public Property Mode() As Integer
        Get
            Return _mode
        End Get
        Set(ByVal value As Integer)
            _mode = value
        End Set
    End Property

    Private _userdata As UserData
    Public Property Data() As UserData
        Get
            Return _userdata
        End Get
        Set(ByVal value As UserData)
            _userdata = value
        End Set
    End Property

    Private Sub LinkLabelSaveUserForm_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelSaveUserForm.LinkClicked

        showNotification("saving user data...", MyForm.NOTIFICATION_LOADING)

        Data.address = TextBoxAddressUserForm.Text
        Data.email = TextBoxEmailUserForm.Text
        Data.full_name = TextBoxFullnameUserForm.Text
        Data.handphone = TextBoxHandphoneUserForm.Text
        Data.pass = TextBoxPasswordUserForm.Text
        Data.username = TextBoxUsernameUserForm.Text
        Data.propic = ImageHelper.ImageToBase64(PictureBoxPropicUserForm.Image, ImageFormat.Png)

        ' referencing for future db after call effect
        PanelRef.ProgressFormLabel = LabelLoadingUserForm
        showNotification("Saving the data...", MyForm.NOTIFICATION_LOADING)

        If (Me.Mode = MyForm.MODE_EDIT) Then

            Database.saveUser(Data, True)
            Me.Text = "User Form - EDIT"
        Else

            Me.Text = "User Form - NEW"
            Database.saveUser(Data)
        End If



    End Sub


    Sub showNotification(ByVal message As String, mode As Integer)

        MyForm.applyNotification(message, mode, LabelLoadingUserForm)

    End Sub

    Private Sub LinkLabelPictureUserForm_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelPictureUserForm.LinkClicked

        If (LinkLabelPictureUserForm.Text.Contains("Browse")) Then
            ' opening browse file dialog
            If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then
                PictureBoxPropicUserForm.Image.Dispose()

                Dim gbr As Image = Image.FromFile(OpenFileDialog1.FileName)

                PictureBoxPropicUserForm.Image = New Bitmap(ImageHelper.resizeImage(314, 235, gbr))

                gbr.Dispose()

                LinkLabelPictureUserForm.Text = "Reset"
            End If

        Else
            ' resetting picture
            PictureBoxPropicUserForm.Image.Dispose()
            PictureBoxPropicUserForm.Image = Global.RKMedisCustomizedRTH.My.Resources.blankuser

            LinkLabelPictureUserForm.Text = "Browse..."
        End If

    End Sub

    Private Sub UserForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub
End Class