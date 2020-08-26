Imports System.Net

Public Class ScheduleForm

    Private _mainFrameRef As MainFrame
    Public Property MainFrameRef() As MainFrame
        Get
            Return _mainFrameRef
        End Get
        Set(ByVal value As MainFrame)
            _mainFrameRef = value
        End Set
    End Property

    Private Sub ComboBoxUsername_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxUsername.SelectedIndexChanged
        ' when changed then we must update the checkbox under ui

        Dim user As String = ComboBoxUsername.SelectedItem

        CheckedListBoxPatient.Items.Clear()

        If (Mode = MODE_NEW) Then


            Database.getAllPatientByUsername(user, CheckedListBoxPatient)

        Else

            Database.getAllPatientByUsername(user, CheckedListBoxPatient, Data.patient_id)
        End If


    End Sub

    Private Async Sub ScheduleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MyForm.roundedCornerForm(Me)

        Await Database.getAllUser(ComboBoxUsername)

        If (Mode = MODE_NEW) Then
        Else
            ' this just an escape of unsimbolic pattern such as spaces etc...
            TextBoxKeluhan.Text = WebUtility.UrlDecode(Data.keluhan)
            ComboBoxTreatment.SelectedItem = WebUtility.UrlDecode(Data.treatment)
            ComboBoxUsername.SelectedItem = Data.username
            ComboBoxStatus.SelectedItem = Data.status

            ' convert from yyyy-mm-dd hh:mm:ss format splitted to
            ' each separated different values
            'Dim dateVal As String() = Data.date_choosen.Split(" ")
            'Dim dateOnly As String() = dateVal(0).Split("-")

            'Dim dateChoosen As New Date(dateOnly(0), dateOnly(1), dateOnly(2))
            Dim dateChoosen As Date = MyForm.getDate(Data.date_choosen)
            DateTimePickerDateChosen.Value = dateChoosen
            DateTimePickerTimeChosen.Text = MyForm.getTime(Data.date_choosen)

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

        Data.patient_id = patientId

        If (Mode = MyForm.MODE_EDIT) Then

            ' update the database
            Await Database.saveSchedule(Data, True)
        Else

            ' save a new data entry
            Await Database.saveSchedule(Data)
        End If

        'Me.Dispose()
        LinkLabelClearScheduleForm.Visible = True
        LinkLabelSaveScheduleForm.Visible = False

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

    Private Sub LinkLabelClearScheduleForm_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelClearScheduleForm.LinkClicked
        TextBoxKeluhan.Text = ""
        CheckedListBoxPatient.Items.Clear()
        DateTimePickerDateChosen.ResetText()
        DateTimePickerTimeChosen.ResetText()

        ComboBoxStatus.SelectedItem = "ok"
        ComboBoxUsername.SelectedIndex = 0
        ComboBoxTreatment.SelectedIndex = 0

        LinkLabelClearScheduleForm.Visible = False
        LinkLabelSaveScheduleForm.Visible = True

        LabelLoadingScheduleForm.Visible = False

    End Sub
End Class