Public Class ScheduleForm
    Private Sub ComboBoxUsername_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxUsername.SelectedIndexChanged
        ' when changed then we must update the checkbox under ui

        Dim user As String = ComboBoxUsername.SelectedText
        If (Mode = MODE_NEW) Then


            Database.getAllPatientByUsername(user, CheckedListBoxPatient)

        Else

            Database.getAllPatientByUsername(user, CheckedListBoxPatient, Data.patient_id)
        End If


    End Sub

    Private Sub ScheduleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Database.getAllUser(ComboBoxUsername)

        If (Mode = MODE_NEW) Then
        Else
            TextBoxKeluhan.Text = Data.keluhan
            ComboBoxTreatment.SelectedItem = Data.treatment
            ComboBoxUsername.SelectedItem = Data.username
            ComboBoxStatus.SelectedItem = Data.status

            ' convert from yyyy-mm-dd hh:mm:ss format splitted to
            ' each separated different values
            Dim dateVal As String() = Data.date_choosen.Split(" ")

            DateTimePickerDateChosen.Value = MyForm.getUserDateFormat(dateVal(0))
            DateTimePickerTimeChosen.Value = DateVal(1)

        End If

    End Sub

    Private _data As New ScheduleData
    Public Property Data() As ScheduleData
        Get
            Return _data
        End Get
        Set(ByVal value As ScheduleData)
            _data = value
        End Set
    End Property

    Private Async Sub LinkLabelSaveScheduleForm_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelSaveScheduleForm.LinkClicked

        showNotificationPatient("Saving data...", MyForm.NOTIFICATION_LOADING)

        Data.username = Session.Username
        Data.treatment = ComboBoxTreatment.SelectedItem
        Data.status = ComboBoxStatus.SelectedItem
        Data.date_choosen = MyForm.getComputerBasedDate(DateTimePickerDateChosen.Text) & " " & DateTimePickerTimeChosen.Text
        Data.keluhan = TextBoxKeluhan.Text

        ' format pattern is [id] - username
        Dim patientChecked As String = CheckedListBoxPatient.CheckedItems.Item(0)
        Dim patientDataCheckedDirt As String() = patientChecked.Split("-")
        Dim patientId As Integer = patientDataCheckedDirt(0).Replace("[", "").Replace("]", "").Trim


        If (Mode = MyForm.MODE_EDIT) Then

            ' update the database
            Await Database.saveSchedule(Data, True)
        Else

            ' save a new data entry
            Await Database.saveSchedule(Data)
        End If

        Me.Dispose()

    End Sub

    Sub showNotificationPatient(ByVal message As String, mode As Integer)

        MyForm.applyNotification(message, mode, LabelLoadingScheduleForm)

        ' self referencing for future any DB callbacks
        PanelRef.ProgressFormLabel = LabelLoadingScheduleForm

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

End Class