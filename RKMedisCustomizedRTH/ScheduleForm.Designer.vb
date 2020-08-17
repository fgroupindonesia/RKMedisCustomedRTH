<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScheduleForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScheduleForm))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBoxTreatment = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxStatus = New System.Windows.Forms.ComboBox()
        Me.DateTimePickerDateChosen = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePickerTimeChosen = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBoxUsername = New System.Windows.Forms.ComboBox()
        Me.CheckedListBoxPatient = New System.Windows.Forms.CheckedListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxKeluhan = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LinkLabelClearScheduleForm = New System.Windows.Forms.LinkLabel()
        Me.LabelLoadingScheduleForm = New System.Windows.Forms.Label()
        Me.LinkLabelSaveScheduleForm = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(509, 23)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Schedule Form"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBoxTreatment
        '
        Me.ComboBoxTreatment.FormattingEnabled = True
        Me.ComboBoxTreatment.Items.AddRange(New Object() {"Konsultasi", "Ruqyah", "Listrik", "Totok Punggung", "Nebulizer", "Lintah", "Bekam Basah/Kering/Api", "Gurah Mata/Hidung-Tenggorokan"})
        Me.ComboBoxTreatment.Location = New System.Drawing.Point(16, 144)
        Me.ComboBoxTreatment.Name = "ComboBoxTreatment"
        Me.ComboBoxTreatment.Size = New System.Drawing.Size(167, 21)
        Me.ComboBoxTreatment.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Treatment : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(268, 320)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Status : "
        '
        'ComboBoxStatus
        '
        Me.ComboBoxStatus.FormattingEnabled = True
        Me.ComboBoxStatus.Items.AddRange(New Object() {"pending", "ok", "cancel"})
        Me.ComboBoxStatus.Location = New System.Drawing.Point(268, 339)
        Me.ComboBoxStatus.Name = "ComboBoxStatus"
        Me.ComboBoxStatus.Size = New System.Drawing.Size(119, 21)
        Me.ComboBoxStatus.TabIndex = 41
        '
        'DateTimePickerDateChosen
        '
        Me.DateTimePickerDateChosen.CustomFormat = "dd-MM-yyyy"
        Me.DateTimePickerDateChosen.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerDateChosen.Location = New System.Drawing.Point(19, 341)
        Me.DateTimePickerDateChosen.Name = "DateTimePickerDateChosen"
        Me.DateTimePickerDateChosen.Size = New System.Drawing.Size(98, 20)
        Me.DateTimePickerDateChosen.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 320)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Date Chosen : "
        '
        'DateTimePickerTimeChosen
        '
        Me.DateTimePickerTimeChosen.CustomFormat = "hh:mm:ss"
        Me.DateTimePickerTimeChosen.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerTimeChosen.Location = New System.Drawing.Point(137, 341)
        Me.DateTimePickerTimeChosen.Name = "DateTimePickerTimeChosen"
        Me.DateTimePickerTimeChosen.ShowUpDown = True
        Me.DateTimePickerTimeChosen.Size = New System.Drawing.Size(86, 20)
        Me.DateTimePickerTimeChosen.TabIndex = 45
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(268, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Username :"
        '
        'ComboBoxUsername
        '
        Me.ComboBoxUsername.FormattingEnabled = True
        Me.ComboBoxUsername.Location = New System.Drawing.Point(268, 144)
        Me.ComboBoxUsername.Name = "ComboBoxUsername"
        Me.ComboBoxUsername.Size = New System.Drawing.Size(167, 21)
        Me.ComboBoxUsername.TabIndex = 46
        '
        'CheckedListBoxPatient
        '
        Me.CheckedListBoxPatient.FormattingEnabled = True
        Me.CheckedListBoxPatient.Location = New System.Drawing.Point(268, 203)
        Me.CheckedListBoxPatient.Name = "CheckedListBoxPatient"
        Me.CheckedListBoxPatient.Size = New System.Drawing.Size(245, 109)
        Me.CheckedListBoxPatient.TabIndex = 48
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(268, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Patient :"
        '
        'TextBoxKeluhan
        '
        Me.TextBoxKeluhan.Location = New System.Drawing.Point(16, 203)
        Me.TextBoxKeluhan.Multiline = True
        Me.TextBoxKeluhan.Name = "TextBoxKeluhan"
        Me.TextBoxKeluhan.Size = New System.Drawing.Size(223, 104)
        Me.TextBoxKeluhan.TabIndex = 50
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Keluhan : "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(134, 322)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Time :"
        '
        'LinkLabelClearScheduleForm
        '
        Me.LinkLabelClearScheduleForm.Image = Global.RKMedisCustomizedRTH.My.Resources.Resources.clear2
        Me.LinkLabelClearScheduleForm.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LinkLabelClearScheduleForm.Location = New System.Drawing.Point(395, 59)
        Me.LinkLabelClearScheduleForm.Name = "LinkLabelClearScheduleForm"
        Me.LinkLabelClearScheduleForm.Size = New System.Drawing.Size(56, 53)
        Me.LinkLabelClearScheduleForm.TabIndex = 53
        Me.LinkLabelClearScheduleForm.TabStop = True
        Me.LinkLabelClearScheduleForm.Text = "Clear"
        Me.LinkLabelClearScheduleForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.LinkLabelClearScheduleForm.Visible = False
        '
        'LabelLoadingScheduleForm
        '
        Me.LabelLoadingScheduleForm.Image = Global.RKMedisCustomizedRTH.My.Resources.Resources.loading
        Me.LabelLoadingScheduleForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelLoadingScheduleForm.Location = New System.Drawing.Point(13, 69)
        Me.LabelLoadingScheduleForm.Name = "LabelLoadingScheduleForm"
        Me.LabelLoadingScheduleForm.Size = New System.Drawing.Size(258, 42)
        Me.LabelLoadingScheduleForm.TabIndex = 38
        Me.LabelLoadingScheduleForm.Text = "Loading..."
        Me.LabelLoadingScheduleForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelLoadingScheduleForm.Visible = False
        '
        'LinkLabelSaveScheduleForm
        '
        Me.LinkLabelSaveScheduleForm.Image = Global.RKMedisCustomizedRTH.My.Resources.Resources.save
        Me.LinkLabelSaveScheduleForm.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LinkLabelSaveScheduleForm.Location = New System.Drawing.Point(457, 58)
        Me.LinkLabelSaveScheduleForm.Name = "LinkLabelSaveScheduleForm"
        Me.LinkLabelSaveScheduleForm.Size = New System.Drawing.Size(56, 53)
        Me.LinkLabelSaveScheduleForm.TabIndex = 37
        Me.LinkLabelSaveScheduleForm.TabStop = True
        Me.LinkLabelSaveScheduleForm.Text = "Save"
        Me.LinkLabelSaveScheduleForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ScheduleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 380)
        Me.Controls.Add(Me.LinkLabelClearScheduleForm)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBoxKeluhan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CheckedListBoxPatient)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBoxUsername)
        Me.Controls.Add(Me.DateTimePickerTimeChosen)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateTimePickerDateChosen)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBoxStatus)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxTreatment)
        Me.Controls.Add(Me.LabelLoadingScheduleForm)
        Me.Controls.Add(Me.LinkLabelSaveScheduleForm)
        Me.Controls.Add(Me.Label6)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ScheduleForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Schedule Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelLoadingScheduleForm As Label
    Friend WithEvents LinkLabelSaveScheduleForm As LinkLabel
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBoxTreatment As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxStatus As ComboBox
    Friend WithEvents DateTimePickerDateChosen As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePickerTimeChosen As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBoxUsername As ComboBox
    Friend WithEvents CheckedListBoxPatient As CheckedListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxKeluhan As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LinkLabelClearScheduleForm As LinkLabel
End Class
