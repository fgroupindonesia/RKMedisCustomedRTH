Public Class PatientForm

    Sub showNotificationPatient(ByVal message As String, mode As Integer)

        MyForm.applyNotification(message, mode, LabelLoadingPatientForm)

        ' self referencing for future any DB callbacks
        PanelRef.ProgressFormLabel = LabelLoadingPatientForm

    End Sub

    Sub showNotificationMainMedicHistory(ByVal message As String, mode As Integer)

        MyForm.applyNotification(message, mode, LabelLoadingMainMedicHistory)

        ' self referencing for future any DB callbacks
        PanelRef.ProgressFormLabel = LabelLoadingMainMedicHistory

    End Sub

    Sub showNotificationSecondMedicHistory(ByVal message As String, mode As Integer)

        MyForm.applyNotification(message, mode, LabelLoadingSecondMedicHistory)

        ' self referencing for future any DB callbacks
        PanelRef.ProgressFormLabel = LabelLoadingSecondMedicHistory

    End Sub

    ' this is for PatientForm usage only
    Sub prepareNavigator()
        Navigator.Panels = New Panel() {PanelMainMedicHistory, PanelSecondaryMedicHistory, PanelPatientForm}
    End Sub

    Private Async Sub PatientForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        prepareNavigator()

        ' the call will be waited
        Await Database.getAllUser(ComboBoxUserPrivilledgePatientForm)

        Navigator.gotoPage(PAGE_PATIENT_FORM)

        If (Mode = MyForm.MODE_EDIT) Then

            Me.Text = "Patient Form - EDIT"

            TextBoxOccupationPatientForm.Text = Data.work
            TextBoxEmailPatientForm.Text = Data.email
            TextBoxAddressPatientForm.Text = Data.address
            TextBoxNoIDCardPatientForm.Text = Data.no_ktp
            TextBoxHandphonePatientForm.Text = Data.handphone
            TextBoxFullnamePatientForm.Text = Data.full_name
            TextBoxBirthPlacePatientForm.Text = Data.birth_place
            DateTimePickerBirthDatePatientForm.Text = Data.birth_date

            LabelYourAge.Text = "Your age is " & Data.age

            ComboBoxStatusPatientForm.Text = Data.status_file

            MyForm.RadioButtons = New RadioButton() {RadioButtonMalePatientForm,
                RadioButtonFemalePatientForm}
            MyForm.activateRadioButton(Data.sex)

            MyForm.RadioButtons = New RadioButton() {RadioButtonSinglePatientForm,
                RadioButtonDivorcedPatientForm,
                RadioButtonWidowPatientForm,
                RadioButtonMarriedPatientForm}
            MyForm.activateRadioButton(Data.status_marriage)

            MyForm.Combobox = ComboBoxReligionPatientForm
            MyForm.activateCombobox(Data.religion)

            MyForm.Combobox = ComboBoxGraduatedPatientForm
            MyForm.activateCombobox(Data.last_education)

            MyForm.Combobox = ComboBoxUserPrivilledgePatientForm
            MyForm.activateCombobox(Data.username_privilege)

            ' this is the medical historical records rendering
            renderMedicalHistoryRecords()

        Else

            Me.Text = "Patient Form - NEW"

            Me.Data = New PatientData
            Me.MainHistoryRecord = New MainHistoryRecord
            Me.SecondHistoryRecord = New SecondHistoryRecord

            'set default data for Main & Second Health Record
            ' set the values according the ui
            setSecondHistoryRecord()
            setMainHistoryRecord()

        End If
    End Sub

    Sub renderMedicalHistoryRecords()

        ' these are the Radiobuttons under MainMedicalHistory

        MyForm.RadioButtons = New RadioButton() {RadioButtonNoSmokingMainMedicHistory, RadioButtonYesSmokingMainMedicHistory}
        MyForm.activateRadioButton(MainHistoryRecord.smoker)
        MyForm.setTextboxTextIfAny(TextBoxDescriptionSmokingMainMedicHistory, MainHistoryRecord.smoker_desc)

        MyForm.RadioButtons = New RadioButton() {RadioButtonNoHospitalizedMainMedicHistory, RadioButtonYesHospitalizedMainMedicHistory}
        MyForm.activateRadioButton(MainHistoryRecord.was_hospitalized)
        MyForm.setTextboxTextIfAny(TextBoxDescriptionHospitalizedMainMedicHistory, MainHistoryRecord.was_hospitalized_desc)

        MyForm.RadioButtons = New RadioButton() {RadioButtonNoDrugsMainMedicHistory, RadioButtonYesDrugsMainMedicHistory}
        MyForm.activateRadioButton(MainHistoryRecord.was_using_drugs)
        MyForm.setTextboxTextIfAny(TextBoxDescriptionDrugsMainMedicHistory, MainHistoryRecord.was_using_drugs_desc)

        MyForm.RadioButtons = New RadioButton() {RadioButtonNoDrugsMainMedicHistory, RadioButtonYesDrugsMainMedicHistory}
        MyForm.activateRadioButton(MainHistoryRecord.was_using_drugs)
        MyForm.setTextboxTextIfAny(TextBoxDescriptionDrugsMainMedicHistory, MainHistoryRecord.was_using_drugs_desc)

        MyForm.RadioButtons = New RadioButton() {RadioButtonNoSentencedMainMedicHistory, RadioButtonYesSentencedMainMedicHistory}
        MyForm.activateRadioButton(MainHistoryRecord.worst_disease)
        MyForm.setTextboxTextIfAny(TextBoxDescriptionSentencedMainMedicHistory, MainHistoryRecord.worst_disease_desc)

        MyForm.RadioButtons = New RadioButton() {RadioButtonNoReferalsMainMedicHistory, RadioButtonYesReferalsMainMedicHistory}
        MyForm.activateRadioButton(MainHistoryRecord.doctor_suggest)
        MyForm.setTextboxTextIfAny(TextBoxDescriptionReferalsMainMedicHistory, MainHistoryRecord.doctor_suggest_desc)

        ' these are the Radiobuttons under SecondMedicalHistory

        MyForm.RadioButtons = New RadioButton() {RadioButtonNoSyirkSecondMedicalHistory, RadioButtonYesSyirkSecondMedicalHistory}
        MyForm.activateRadioButton(SecondHistoryRecord.adat_syirik)
        MyForm.setTextboxTextIfAny(TextBoxDescriptionSyirkSecondMedicalHistory, SecondHistoryRecord.adat_syirik_desc)

        MyForm.RadioButtons = New RadioButton() {RadioButtonNoSpiritualDzikirSecondMedicalHistory, RadioButtonYesSpiritualDzikirSecondMedicalHistory}
        MyForm.activateRadioButton(SecondHistoryRecord.dzikir_td)
        MyForm.setTextboxTextIfAny(TextBoxDescriptionSpiritualDzikirSecondMedicalHistory, SecondHistoryRecord.dzikir_td_desc)

        MyForm.RadioButtons = New RadioButton() {RadioButtonNoNightmareSecondMedicalHistory, RadioButtonYesNightmareSecondMedicalHistory}
        MyForm.activateRadioButton(SecondHistoryRecord.mimpi_buruk)
        MyForm.setTextboxTextIfAny(TextBoxDescriptionNightmareSecondMedicalHistory, SecondHistoryRecord.mimpi_buruk_desc)

        MyForm.RadioButtons = New RadioButton() {RadioButtonNoParanormalSecondMedicalHistory, RadioButtonYesParanormalSecondMedicalHistory}
        MyForm.activateRadioButton(SecondHistoryRecord.paranormal)
        MyForm.setTextboxTextIfAny(TextBoxDescriptionParanormalSecondMedicalHistory, SecondHistoryRecord.paranormal_desc)

        MyForm.RadioButtons = New RadioButton() {RadioButtonNoGhostSecondMedicalHistory, RadioButtonYesGhostSecondMedicalHistory}
        MyForm.activateRadioButton(SecondHistoryRecord.penampakan_ghaib)
        MyForm.setTextboxTextIfAny(TextBoxDescriptionGhostSecondMedicalHistory, SecondHistoryRecord.penampakan_ghaib_desc)
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

    Private _secondRecord As SecondHistoryRecord
    Public Property SecondHistoryRecord() As SecondHistoryRecord
        Get
            Return _secondRecord
        End Get
        Set(ByVal value As SecondHistoryRecord)
            _secondRecord = value
        End Set
    End Property

    Private _mainRecord As MainHistoryRecord
    Public Property MainHistoryRecord() As MainHistoryRecord
        Get
            Return _mainRecord
        End Get
        Set(ByVal value As MainHistoryRecord)
            _mainRecord = value
        End Set
    End Property

    Private _userdata As PatientData
    Public Property Data() As PatientData
        Get
            Return _userdata
        End Get
        Set(ByVal value As PatientData)
            _userdata = value
        End Set
    End Property

    Private Function setCheckedValues(ParamArray ByVal radButton() As RadioButton)

        Dim val As String = ""

        For Each rad In radButton

            If (rad.Checked) Then
                val = rad.Text.ToLower
                Exit For
            End If

        Next

        Return val
    End Function


    Private Sub setCheckedValues(ByVal radbutton As RadioButton, textboxDesc As TextBox, propKey As String, propDesc As String)
        If (radbutton.Checked) Then

            propDesc = textboxDesc.Text
            propKey = "yes"
        Else
            propKey = "no"
        End If
    End Sub

    Private Sub LinkLabelSaveSecondMedicalHistory_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelSaveSecondMedicalHistory.LinkClicked
        showNotificationSecondMedicHistory("Saving data...", NOTIFICATION_LOADING)

        ' save all data entered for secondary history
        SecondHistoryRecord.patient_id = Data.id

        ' set the values according the ui
        setSecondHistoryRecord()

        showNotificationSecondMedicHistory("updated...!", NOTIFICATION_SUCCESS)


    End Sub

    Sub setSecondHistoryRecord()

        SecondHistoryRecord.mimpi_buruk = setCheckedValues(RadioButtonYesNightmareSecondMedicalHistory, RadioButtonNoNightmareSecondMedicalHistory)
        SecondHistoryRecord.mimpi_buruk_desc = MyForm.getDescription(TextBoxDescriptionSmokingMainMedicHistory)

        SecondHistoryRecord.paranormal = setCheckedValues(RadioButtonYesParanormalSecondMedicalHistory, RadioButtonNoParanormalSecondMedicalHistory)
        SecondHistoryRecord.paranormal_desc = MyForm.getDescription(TextBoxDescriptionParanormalSecondMedicalHistory)

        SecondHistoryRecord.penampakan_ghaib = setCheckedValues(RadioButtonYesGhostSecondMedicalHistory, RadioButtonNoGhostSecondMedicalHistory)
        SecondHistoryRecord.penampakan_ghaib_desc = MyForm.getDescription(TextBoxDescriptionGhostSecondMedicalHistory)

        SecondHistoryRecord.dzikir_td = setCheckedValues(RadioButtonYesSpiritualDzikirSecondMedicalHistory, RadioButtonNoSpiritualDzikirSecondMedicalHistory)
        SecondHistoryRecord.dzikir_td_desc = MyForm.getDescription(TextBoxDescriptionSpiritualDzikirSecondMedicalHistory)

        SecondHistoryRecord.adat_syirik = setCheckedValues(RadioButtonYesSyirkSecondMedicalHistory, RadioButtonNoSyirkSecondMedicalHistory)
        SecondHistoryRecord.adat_syirik_desc = MyForm.getDescription(TextBoxDescriptionSyirkSecondMedicalHistory)

    End Sub

    Private Sub LinkLabelMainMedicHistoryPatientForm_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelMainMedicHistoryPatientForm.LinkClicked
        Navigator.gotoPage(PAGE_MAIN_MEDICAL_HISTORY_FORM)

    End Sub

    Private Sub LinkLabelSecondaryMedicHistoryPatientForm_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelSecondaryMedicHistoryPatientForm.LinkClicked
        Navigator.gotoPage(PAGE_SECOND_MEDICAL_HISTORY_FORM)
    End Sub

    Private Sub PictureBoxBackSecondMedicalHistory_Click(sender As Object, e As EventArgs) Handles PictureBoxBackSecondMedicalHistory.Click
        Navigator.gotoPage(PAGE_PATIENT_FORM)
    End Sub

    Private Sub PictureBoxBackMainMedicHistory_Click(sender As Object, e As EventArgs) Handles PictureBoxBackMainMedicHistory.Click
        Navigator.gotoPage(PAGE_PATIENT_FORM)
    End Sub

    Private Sub RadioButtonYesSyirkSecondMedicalHistory_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonYesSyirkSecondMedicalHistory.CheckedChanged
        TextBoxDescriptionSyirkSecondMedicalHistory.Enabled = RadioButtonYesSyirkSecondMedicalHistory.Checked
    End Sub

    Private Sub RadioButtonYesSpiritualDzikirSecondMedicalHistory_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonYesSpiritualDzikirSecondMedicalHistory.CheckedChanged
        TextBoxDescriptionSpiritualDzikirSecondMedicalHistory.Enabled = RadioButtonYesSpiritualDzikirSecondMedicalHistory.Checked
    End Sub

    Private Sub RadioButtonYesNightmareSecondMedicalHistory_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonYesNightmareSecondMedicalHistory.CheckedChanged
        TextBoxDescriptionNightmareSecondMedicalHistory.Enabled = RadioButtonYesNightmareSecondMedicalHistory.Checked
    End Sub

    Private Sub RadioButtonYesParanormalSecondMedicalHistory_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonYesParanormalSecondMedicalHistory.CheckedChanged
        TextBoxDescriptionParanormalSecondMedicalHistory.Enabled = RadioButtonYesParanormalSecondMedicalHistory.Checked
    End Sub

    Private Sub RadioButtonYesGhostSecondMedicalHistory_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonYesGhostSecondMedicalHistory.CheckedChanged
        TextBoxDescriptionGhostSecondMedicalHistory.Enabled = RadioButtonYesGhostSecondMedicalHistory.Checked
    End Sub

    Private Sub RadioButtonYesSmokingMainMedicHistory_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonYesSmokingMainMedicHistory.CheckedChanged
        TextBoxDescriptionSmokingMainMedicHistory.Enabled = RadioButtonYesSmokingMainMedicHistory.Checked

    End Sub

    Private Sub RadioButtonYesHospitalizedMainMedicHistory_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonYesHospitalizedMainMedicHistory.CheckedChanged
        TextBoxDescriptionHospitalizedMainMedicHistory.Enabled = RadioButtonYesHospitalizedMainMedicHistory.Checked
    End Sub

    Private Sub RadioButtonYesDrugsMainMedicHistory_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonYesDrugsMainMedicHistory.CheckedChanged
        TextBoxDescriptionDrugsMainMedicHistory.Enabled = RadioButtonYesDrugsMainMedicHistory.Checked
    End Sub

    Private Sub RadioButtonYesSentencedMainMedicHistory_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonYesSentencedMainMedicHistory.CheckedChanged
        TextBoxDescriptionSentencedMainMedicHistory.Enabled = RadioButtonYesSentencedMainMedicHistory.Checked
    End Sub

    Private Sub RadioButtonYesReferalsMainMedicHistory_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonYesReferalsMainMedicHistory.CheckedChanged
        TextBoxDescriptionReferalsMainMedicHistory.Enabled = RadioButtonYesReferalsMainMedicHistory.Checked
    End Sub

    Private Sub LinkLabelSavePatientForm_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelSavePatientForm.LinkClicked
        showNotificationPatient("Saving data...", MyForm.NOTIFICATION_LOADING)

        Data.full_name = TextBoxFullnamePatientForm.Text
        Data.birth_place = TextBoxBirthPlacePatientForm.Text
        Data.birth_date = MyForm.switchDateToDB(DateTimePickerBirthDatePatientForm.Text)
        Data.no_ktp = TextBoxNoIDCardPatientForm.Text
        Data.handphone = TextBoxHandphonePatientForm.Text
        Data.work = TextBoxOccupationPatientForm.Text

        Data.age = MyForm.getAgeYear(DateTimePickerBirthDatePatientForm.Value.Year)

        Data.sex = setCheckedValues(RadioButtonFemalePatientForm, RadioButtonMalePatientForm).ToString.ToLower
        Data.status_marriage = setCheckedValues(RadioButtonSinglePatientForm, RadioButtonMarriedPatientForm, RadioButtonDivorcedPatientForm, RadioButtonWidowPatientForm).ToString.ToLower

        Data.status_file = ComboBoxStatusPatientForm.Text
        Data.religion = ComboBoxReligionPatientForm.Text
        Data.last_education = ComboBoxGraduatedPatientForm.Text
        Data.username_privilege = ComboBoxUserPrivilledgePatientForm.Text

        Data.email = TextBoxEmailPatientForm.Text
        Data.address = TextBoxAddressPatientForm.Text

        If (Me.Mode = MODE_NEW) Then
            Database.savePatient(Data, MainHistoryRecord, SecondHistoryRecord, False, Me)
        Else
            Database.savePatient(Data, MainHistoryRecord, SecondHistoryRecord, True, Me)
        End If

        ' return back the Navigation part for HomeFrame
        MainFrameRef.prepareNavigator()

    End Sub

    Private Sub LinkLabelSaveMainMedicHistory_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelSaveMainMedicHistory.LinkClicked
        showNotificationMainMedicHistory("Saving data...", NOTIFICATION_LOADING)

        ' save all data entered for secondary history
        MainHistoryRecord.patient_id = Data.id

        ' set the values according to the ui
        setMainHistoryRecord()

        showNotificationMainMedicHistory("updated...!", NOTIFICATION_SUCCESS)

    End Sub

    Sub setMainHistoryRecord()

        MainHistoryRecord.smoker = setCheckedValues(RadioButtonYesSmokingMainMedicHistory, RadioButtonNoSmokingMainMedicHistory).ToString.ToLower
        MainHistoryRecord.smoker_desc = MyForm.getDescription(TextBoxDescriptionSmokingMainMedicHistory)

        MainHistoryRecord.was_hospitalized = setCheckedValues(RadioButtonYesHospitalizedMainMedicHistory, RadioButtonNoHospitalizedMainMedicHistory)
        MainHistoryRecord.was_hospitalized_desc = MyForm.getDescription(TextBoxDescriptionHospitalizedMainMedicHistory)

        MainHistoryRecord.was_using_drugs = setCheckedValues(RadioButtonYesDrugsMainMedicHistory, RadioButtonNoDrugsMainMedicHistory)
        MainHistoryRecord.was_using_drugs_desc = MyForm.getDescription(TextBoxDescriptionDrugsMainMedicHistory)

        MainHistoryRecord.worst_disease = setCheckedValues(RadioButtonYesSentencedMainMedicHistory, RadioButtonNoSentencedMainMedicHistory)
        MainHistoryRecord.worst_disease_desc = MyForm.getDescription(TextBoxDescriptionSentencedMainMedicHistory)

        MainHistoryRecord.doctor_suggest = setCheckedValues(RadioButtonYesReferalsMainMedicHistory, RadioButtonNoReferalsMainMedicHistory)
        MainHistoryRecord.doctor_suggest_desc = MyForm.getDescription(TextBoxDescriptionReferalsMainMedicHistory)

    End Sub

    Private Sub DateTimePickerBirthDatePatientForm_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerBirthDatePatientForm.ValueChanged
        ' pick the year and calculate with now
        Dim y As Integer = DateTimePickerBirthDatePatientForm.Value.Year

        Dim remains As Integer = MyForm.getAgeYear(y)

        LabelYourAge.Text = "Your age is " & remains & " years old."
    End Sub

    Private Sub TextBoxDescriptionSmokingMainMedicHistory_Enter(sender As Object, e As EventArgs) Handles TextBoxDescriptionSmokingMainMedicHistory.Enter
        clearTextbox("description...", TextBoxDescriptionSmokingMainMedicHistory)
    End Sub

    Private Sub TextBoxDescriptionHospitalizedMainMedicHistory_Enter(sender As Object, e As EventArgs) Handles TextBoxDescriptionHospitalizedMainMedicHistory.Enter
        clearTextbox("description...", TextBoxDescriptionHospitalizedMainMedicHistory)
    End Sub

    Private Sub TextBoxDescriptionDrugsMainMedicHistory_Enter(sender As Object, e As EventArgs) Handles TextBoxDescriptionDrugsMainMedicHistory.Enter
        clearTextbox("description...", TextBoxDescriptionDrugsMainMedicHistory)
    End Sub

    Private Sub TextBoxDescriptionSentencedMainMedicHistory_Enter(sender As Object, e As EventArgs) Handles TextBoxDescriptionSentencedMainMedicHistory.Enter
        clearTextbox("description...", TextBoxDescriptionSentencedMainMedicHistory)
    End Sub

    Private Sub TextBoxDescriptionReferalsMainMedicHistory_Enter(sender As Object, e As EventArgs) Handles TextBoxDescriptionReferalsMainMedicHistory.Enter
        clearTextbox("description...", TextBoxDescriptionReferalsMainMedicHistory)
    End Sub

    Private Sub TextBoxDescriptionSyirkSecondMedicalHistory_Enter(sender As Object, e As EventArgs) Handles TextBoxDescriptionSyirkSecondMedicalHistory.Enter
        clearTextbox("description...", TextBoxDescriptionSyirkSecondMedicalHistory)
    End Sub

    Private Sub TextBoxDescriptionSpiritualDzikirSecondMedicalHistory_Enter(sender As Object, e As EventArgs) Handles TextBoxDescriptionSpiritualDzikirSecondMedicalHistory.Enter
        clearTextbox("description...", TextBoxDescriptionSpiritualDzikirSecondMedicalHistory)
    End Sub

    Private Sub TextBoxDescriptionNightmareSecondMedicalHistory_Enter(sender As Object, e As EventArgs) Handles TextBoxDescriptionNightmareSecondMedicalHistory.Enter
        clearTextbox("description...", TextBoxDescriptionNightmareSecondMedicalHistory)
    End Sub

    Private Sub TextBoxDescriptionParanormalSecondMedicalHistory_Enter(sender As Object, e As EventArgs) Handles TextBoxDescriptionParanormalSecondMedicalHistory.Enter
        clearTextbox("description...", TextBoxDescriptionParanormalSecondMedicalHistory)
    End Sub

    Private Sub TextBoxDescriptionGhostSecondMedicalHistory_Enter(sender As Object, e As EventArgs) Handles TextBoxDescriptionGhostSecondMedicalHistory.Enter
        clearTextbox("description...", TextBoxDescriptionGhostSecondMedicalHistory)
    End Sub

End Class