Public Class VisitForm


    Private _mode As Integer
    Public Property Mode() As Integer
        Get
            Return _mode
        End Get
        Set(ByVal value As Integer)
            _mode = value
        End Set
    End Property

    Private _data As New VisitData
    Public Property Data() As VisitData
        Get
            Return _data
        End Get
        Set(ByVal value As VisitData)
            _data = value
        End Set
    End Property

    Private _mainFrameRef As MainFrame
    Public Property MainFrameRef() As MainFrame
        Get
            Return _mainFrameRef
        End Get
        Set(ByVal value As MainFrame)
            _mainFrameRef = value
        End Set
    End Property

    Private Sub LinkLabelClearVisitForm_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelClearVisitForm.LinkClicked
        ComboBoxPatientName.SelectedIndex = 0
        ComboBoxTreatment.SelectedIndex = 0

        DateTimePickerDateFuture.ResetText()
        DateTimePickerDateVisited.ResetText()
        NumericUpDownWeight.Value = 0
        TextBoxBloodPressure.Text = ""
        TextBoxDescription.Text = ""

        LinkLabelClearVisitForm.Visible = False
        LinkLabelSaveVisitForm.Visible = True

        LabelLoadingVisitForm.Visible = False
    End Sub

    Sub showNotificationVisit(ByVal message As String, mode As Integer)

        MyForm.applyNotification(message, mode, LabelLoadingVisitForm)

        ' self referencing for future any DB callbacks
        PanelRef.ProgressFormLabel = LabelLoadingVisitForm

    End Sub

    Private Async Sub LinkLabelSaveVisitForm_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelSaveVisitForm.LinkClicked

        showNotificationVisit("Saving data...", MyForm.NOTIFICATION_LOADING)

        Data.description = TextBoxDescription.Text
        Data.blood_pressure = TextBoxBloodPressure.Text
        Data.treatment = ComboBoxTreatment.SelectedItem
        Data.weight = NumericUpDownWeight.Value


        Data.date_visited = MyForm.getComputerBasedDate(DateTimePickerDateVisited.Text) & " " & DateTimePickerTimeVisited.Text
        Data.date_future_visit = MyForm.getComputerBasedDate(DateTimePickerDateFuture.Text)


        ' format pattern is [id] - username
        Dim dataPatientText As String = ComboBoxPatientName.SelectedItem.ToString.Split("-")(0)
        Dim nomerPatientId As Integer = dataPatientText.Replace("[", "").Replace("]", "").Trim
        Data.patient_id = nomerPatientId


        If (Mode = MyForm.MODE_EDIT) Then

            ' update the database
            Await Database.saveVisit(Data, True)
        Else

            ' save a new data entry
            Await Database.saveVisit(Data)
        End If

        'Me.Dispose()
        LinkLabelClearVisitForm.Visible = True
        LinkLabelSaveVisitForm.Visible = False
    End Sub

    Private Sub VisitForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (Mode = MODE_EDIT) Then
            ' extract every data
            TextBoxBloodPressure.Text = Data.blood_pressure
            TextBoxDescription.Text = Data.description
            NumericUpDownWeight.Value = Data.weight
            ComboBoxTreatment.SelectedItem = Data.treatment

            ComboBoxPatientName.SelectedItem = Data.patient_id

            DateTimePickerDateVisited.Value = MyForm.getDate(Data.date_visited)
            DateTimePickerTimeVisited.Text = MyForm.getTime(Data.date_visited)
            DateTimePickerDateFuture.Value = MyForm.getDate(Data.date_future_visit)



        End If

    End Sub
End Class