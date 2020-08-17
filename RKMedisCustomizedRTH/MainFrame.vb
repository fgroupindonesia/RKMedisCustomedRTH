Public Class MainFrame


    Private Sub MainFrame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundedCornerForm(Me)
        doubleBufferingUI()
        applyLanguagesUI()
        prepareReferencing()
        prepareNavigator()
        Navigator.gotoPage(PAGE_LOGIN)
    End Sub

    Sub prepareReferencing()

        ' this is for the UI reference where the DB Calls started
        TableHelper.DataGridViewUser = DataGridViewUserManagement
        TableHelper.DataGridViewPatient = DataGridViewPatientManagement
        TableHelper.DataGridViewProduct = DataGridViewProductManagement
        TableHelper.DataGridViewOrder = DataGridViewOrderManagement
        TableHelper.DataGridViewSchedule = DataGridViewScheduleManagement

        PanelRef.ProgressFormLabel = LabelLoadingUserManagement

    End Sub

    Public Sub prepareNavigator()
        Navigator.Panels = New Panel() {PanelLogin,
            PanelHome,
            PanelUserManagement,
            PanelPatientManagement,
            PanelOrderManagement,
            PanelScheduleManagement,
            PanelProductManagement,
            PanelVisitManagement}
    End Sub

    Sub doubleBufferingUI()
        ' manually double buffering ui started
        Me.SetStyle((ControlStyles.DoubleBuffer _
                Or (ControlStyles.UserPaint Or ControlStyles.AllPaintingInWmPaint)), True)
        Me.UpdateStyles()
        ' manually double buffering ui done
    End Sub

    Sub applyLanguagesUI()
        LanguageSwitcher.readFromFile()
        LanguageSwitcher.applyUI(LabelVersionApp)
    End Sub

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Navigator.gotoPage(Navigator.PAGE_HOME)

        'saved for other ui usage later
        Session.Username = TextBoxUsernameLogin.Text
    End Sub

    Private Sub ButtonUserManagementMain_Click(sender As Object, e As EventArgs) Handles ButtonUserManagementMain.Click
        Navigator.gotoPage(Navigator.PAGE_USER_MANAGEMENT)
        ' call the DB for refreshing the table
        Database.getAllUser()
    End Sub

    Private Sub ButtonPatientManagementMain_Click(sender As Object, e As EventArgs) Handles ButtonPatientManagementMain.Click
        Navigator.gotoPage(Navigator.PAGE_PATIENT_MANAGEMENT)
        ' call the DB for refreshing the table
        Database.getAllPatient()
    End Sub

    Private Sub ButtonProductManagementMain_Click(sender As Object, e As EventArgs) Handles ButtonProductManagementMain.Click
        Navigator.gotoPage(Navigator.PAGE_PRODUCT_MANAGEMENT)
        ' call the DB for refreshing the table
        Database.getAllProduct()
    End Sub

    Private Sub ButtonOrderManagementMain_Click(sender As Object, e As EventArgs) Handles ButtonOrderManagementMain.Click
        Navigator.gotoPage(Navigator.PAGE_ORDER_MANAGEMENT)
        ' call the DB for refreshing the table
        Database.getAllOrder()
    End Sub

    Private Sub ButtonScheduleManagementMain_Click(sender As Object, e As EventArgs) Handles ButtonScheduleManagementMain.Click
        Navigator.gotoPage(Navigator.PAGE_SCHEDULE_MANAGEMENT)
        ' call the DB for refreshing the table
        Database.getAllSchedule()
    End Sub

    Private Sub ButtonVisitManagementMain_Click(sender As Object, e As EventArgs) Handles ButtonVisitManagementMain.Click
        Navigator.gotoPage(Navigator.PAGE_VISIT_MANAGEMENT)
    End Sub

    Private Sub PictureBoxBackVisitManagement_Click(sender As Object, e As EventArgs) Handles PictureBoxBackVisitManagement.Click
        Navigator.gotoPage(PAGE_HOME)
    End Sub

    Private Sub PictureBoxBackScheduleManagement_Click(sender As Object, e As EventArgs) Handles PictureBoxBackScheduleManagement.Click
        Navigator.gotoPage(PAGE_HOME)
    End Sub

    Private Sub PictureBoxBackOrderManagement_Click(sender As Object, e As EventArgs) Handles PictureBoxBackOrderManagement.Click
        Navigator.gotoPage(PAGE_HOME)
    End Sub

    Private Sub PictureBoxBackProductManagement_Click(sender As Object, e As EventArgs) Handles PictureBoxBackProductManagement.Click
        Navigator.gotoPage(PAGE_HOME)
    End Sub

    Private Sub PictureBoxBackPatientManagement_Click(sender As Object, e As EventArgs) Handles PictureBoxBackPatientManagement.Click
        Navigator.gotoPage(PAGE_HOME)
    End Sub

    Private Sub PictureBoxBackUserManagement_Click(sender As Object, e As EventArgs) Handles PictureBoxBackUserManagement.Click
        Navigator.gotoPage(PAGE_HOME)
    End Sub

    Private Sub LinkLabelDeleteUserManagement_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelDeleteUserManagement.LinkClicked
        Dim idTerpilih As ArrayList = TableHelper.getCheckedRows(DataGridViewUserManagement)
        For Each idNa As Integer In idTerpilih
            Database.deleteUser(idNa)
        Next
    End Sub

    Private Sub LinkLabelEditUserManagement_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelEditUserManagement.LinkClicked
        Dim data As UserData = TableHelper.getUserManagementCheckedRow()
        If (data IsNot Nothing) Then

            Dim frame As New UserForm
            frame.MainFrameRef = Me
            frame.Mode = MyForm.MODE_EDIT
            frame.Data = data
            frame.Visible = True

            LabelLoadingUserManagement.Visible = False
        Else
            showUserNotification("Select data from the table first!", NOTIFICATION_WARNING)
        End If
    End Sub

    Sub showUserNotification(ByVal message As String, mode As Integer)

        MyForm.applyNotification(message, mode, LabelLoadingUserManagement)

    End Sub

    Sub showScheduleNotification(ByVal message As String, mode As Integer)

        MyForm.applyNotification(message, mode, LabelLoadingScheduleManagement)

    End Sub

    Sub showPatientNotification(ByVal message As String, mode As Integer)

        MyForm.applyNotification(message, mode, LabelLoadingPatientManagement)

    End Sub

    Sub showProductNotification(ByVal message As String, mode As Integer)

        MyForm.applyNotification(message, mode, LabelLoadingProductManagement)

    End Sub


    Sub showOrderNotification(ByVal message As String, mode As Integer)

        MyForm.applyNotification(message, mode, LabelLoadingOrderManagement)

    End Sub
    Private Sub LinkLabelAddUserManagement_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelAddUserManagement.LinkClicked
        Dim frame As New UserForm
        frame.MainFrameRef = Me
        frame.Mode = MyForm.MODE_NEW
        frame.Visible = True
    End Sub

    Private Sub LinkLabelDeletePatientManagement_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelDeletePatientManagement.LinkClicked
        Dim idTerpilih As ArrayList = TableHelper.getCheckedRows(DataGridViewPatientManagement)
        For Each idNa As Integer In idTerpilih
            Database.deletePatient(idNa)
        Next
    End Sub

    Async Sub LinkLabelEditPatientManagement_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelEditPatientManagement.LinkClicked
        Dim data As PatientData = TableHelper.getPatientManagementCheckedRow()


        If (data IsNot Nothing) Then

            ' calling Database for supporting the Medical History Data
            Dim dataMedicHistory As ArrayList = Await Database.getAllMedicalRecords(data.id)

            Dim frame As New PatientForm
            frame.MainFrameRef = Me
            frame.Mode = MyForm.MODE_EDIT
            frame.Data = data
            frame.MainHistoryRecord = dataMedicHistory.Item(0)
            frame.SecondHistoryRecord = dataMedicHistory.Item(1)
            frame.Visible = True

            LabelLoadingPatientManagement.Visible = False
        Else
            showPatientNotification("Select data from the table first!", NOTIFICATION_WARNING)
        End If
    End Sub

    Private Sub LinkLabelAddPatientManagement_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelAddPatientManagement.LinkClicked
        Dim frame As New PatientForm
        frame.MainFrameRef = Me
        frame.Mode = MyForm.MODE_NEW
        frame.Visible = True
    End Sub

    Private Sub LinkLabelDeleteProductManagement_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelDeleteProductManagement.LinkClicked
        Dim idTerpilih As ArrayList = TableHelper.getCheckedRows(DataGridViewProductManagement)
        For Each idNa As Integer In idTerpilih
            Database.deleteProduct(idNa)
        Next
    End Sub

    Private Sub LinkLabelEditProductManagement_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelEditProductManagement.LinkClicked
        Dim data As ProductData = TableHelper.getProductManagementCheckedRow()

        If (data IsNot Nothing) Then

            Dim frame As New ProductForm
            frame.MainFrameRef = Me
            frame.Mode = MyForm.MODE_EDIT
            frame.Data = data

            frame.Visible = True

            LabelLoadingProductManagement.Visible = False
        Else
            showProductNotification("Select data from the table first!", NOTIFICATION_WARNING)
        End If
    End Sub

    Private Sub LinkLabelAddProductManagement_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelAddProductManagement.LinkClicked
        Dim frame As New ProductForm
        frame.MainFrameRef = Me
        frame.Mode = MyForm.MODE_NEW
        frame.Visible = True
    End Sub

    Private Sub LinkLabelDeleteOrderManagement_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelDeleteOrderManagement.LinkClicked
        Dim idTerpilih As ArrayList = TableHelper.getCheckedRows(DataGridViewOrderManagement)
        For Each idNa As Integer In idTerpilih
            ' deleteOrderItem' and 'deleteOrder' are totally different
            ' deleteOrderItem means specific 1
            ' deleteOrder only means whole all items
            Database.deleteOrderItem(idNa)
        Next
    End Sub

    Private Sub LinkLabelEditOrderManagement_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelEditOrderManagement.LinkClicked
        Dim dataNoInvoice As String = TableHelper.getOrderManagementCheckedRow()

        If (dataNoInvoice IsNot Nothing) Then

            Dim frame As New OrderForm
            frame.MainFrameRef = Me
            frame.Mode = MyForm.MODE_EDIT
            frame.NoInvoice = dataNoInvoice

            frame.Visible = True

            LabelLoadingOrderManagement.Visible = False
        Else
            showOrderNotification("Select data from the table first!", NOTIFICATION_WARNING)
        End If
    End Sub

    Private Sub LinkLabelAddOrderManagement_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelAddOrderManagement.LinkClicked
        Dim frame As New OrderForm
        frame.MainFrameRef = Me
        frame.Show()
    End Sub

    Private Sub LinkLabelAddScheduleManagement_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelAddScheduleManagement.LinkClicked
        Dim frame As New ScheduleForm

        frame.Show()
    End Sub

    Private Sub LinkLabelDeleteScheduleManagement_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelDeleteScheduleManagement.LinkClicked
        Dim idTerpilih As ArrayList = TableHelper.getCheckedRows(DataGridViewScheduleManagement)
        For Each idNa As Integer In idTerpilih
            Database.deleteSchedule(idNa)
        Next
    End Sub

    Private Sub LinkLabelEditScheduleManagement_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelEditScheduleManagement.LinkClicked
        Dim data As ScheduleData = TableHelper.getScheduleManagementCheckedRow()
        If (data IsNot Nothing) Then

            Dim frame As New ScheduleForm
            frame.MainFrameRef = Me
            frame.Mode = MyForm.MODE_EDIT
            frame.Data = data
            frame.Visible = True

            LabelLoadingScheduleManagement.Visible = False
        Else
            showScheduleNotification("Select data from the table first!", MyForm.NOTIFICATION_WARNING)
        End If
    End Sub

    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
        ToolStripTextBoxSearch.Visible = Not ToolStripTextBoxSearch.Visible
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class