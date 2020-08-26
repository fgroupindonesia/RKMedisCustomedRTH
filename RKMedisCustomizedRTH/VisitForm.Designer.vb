<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VisitForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VisitForm))
        Me.ComboBoxPatientName = New System.Windows.Forms.ComboBox()
        Me.LabelLoadingVisitForm = New System.Windows.Forms.Label()
        Me.LinkLabelSaveVisitForm = New System.Windows.Forms.LinkLabel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePickerDateVisited = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePickerDateFuture = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumericUpDownWeight = New System.Windows.Forms.NumericUpDown()
        Me.TextBoxBloodPressure = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBoxTreatment = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxDescription = New System.Windows.Forms.TextBox()
        Me.LinkLabelClearVisitForm = New System.Windows.Forms.LinkLabel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DateTimePickerTimeVisited = New System.Windows.Forms.DateTimePicker()
        CType(Me.NumericUpDownWeight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBoxPatientName
        '
        Me.ComboBoxPatientName.FormattingEnabled = True
        Me.ComboBoxPatientName.Location = New System.Drawing.Point(20, 116)
        Me.ComboBoxPatientName.Name = "ComboBoxPatientName"
        Me.ComboBoxPatientName.Size = New System.Drawing.Size(209, 21)
        Me.ComboBoxPatientName.TabIndex = 0
        '
        'LabelLoadingVisitForm
        '
        Me.LabelLoadingVisitForm.Image = Global.RKMedisCustomizedRTH.My.Resources.Resources.loading
        Me.LabelLoadingVisitForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelLoadingVisitForm.Location = New System.Drawing.Point(17, 45)
        Me.LabelLoadingVisitForm.Name = "LabelLoadingVisitForm"
        Me.LabelLoadingVisitForm.Size = New System.Drawing.Size(252, 42)
        Me.LabelLoadingVisitForm.TabIndex = 35
        Me.LabelLoadingVisitForm.Text = "Loading..."
        Me.LabelLoadingVisitForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelLoadingVisitForm.Visible = False
        '
        'LinkLabelSaveVisitForm
        '
        Me.LinkLabelSaveVisitForm.Image = Global.RKMedisCustomizedRTH.My.Resources.Resources.save
        Me.LinkLabelSaveVisitForm.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LinkLabelSaveVisitForm.Location = New System.Drawing.Point(399, 56)
        Me.LinkLabelSaveVisitForm.Name = "LinkLabelSaveVisitForm"
        Me.LinkLabelSaveVisitForm.Size = New System.Drawing.Size(56, 53)
        Me.LinkLabelSaveVisitForm.TabIndex = 34
        Me.LinkLabelSaveVisitForm.TabStop = True
        Me.LinkLabelSaveVisitForm.Text = "Save"
        Me.LinkLabelSaveVisitForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(440, 23)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Visit Form"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Date Visited :"
        '
        'DateTimePickerDateVisited
        '
        Me.DateTimePickerDateVisited.CustomFormat = "dd-MM-yyyy"
        Me.DateTimePickerDateVisited.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerDateVisited.Location = New System.Drawing.Point(21, 184)
        Me.DateTimePickerDateVisited.Name = "DateTimePickerDateVisited"
        Me.DateTimePickerDateVisited.Size = New System.Drawing.Size(98, 20)
        Me.DateTimePickerDateVisited.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Patient Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 289)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Date Future :"
        '
        'DateTimePickerDateFuture
        '
        Me.DateTimePickerDateFuture.CustomFormat = "dd-MM-yyyy"
        Me.DateTimePickerDateFuture.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerDateFuture.Location = New System.Drawing.Point(26, 310)
        Me.DateTimePickerDateFuture.Name = "DateTimePickerDateFuture"
        Me.DateTimePickerDateFuture.Size = New System.Drawing.Size(98, 20)
        Me.DateTimePickerDateFuture.TabIndex = 49
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(159, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Weight : (Kg)"
        '
        'NumericUpDownWeight
        '
        Me.NumericUpDownWeight.Location = New System.Drawing.Point(162, 183)
        Me.NumericUpDownWeight.Name = "NumericUpDownWeight"
        Me.NumericUpDownWeight.Size = New System.Drawing.Size(67, 20)
        Me.NumericUpDownWeight.TabIndex = 52
        '
        'TextBoxBloodPressure
        '
        Me.TextBoxBloodPressure.Location = New System.Drawing.Point(162, 252)
        Me.TextBoxBloodPressure.Name = "TextBoxBloodPressure"
        Me.TextBoxBloodPressure.Size = New System.Drawing.Size(128, 20)
        Me.TextBoxBloodPressure.TabIndex = 53
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(160, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Blood Pressure :"
        '
        'ComboBoxTreatment
        '
        Me.ComboBoxTreatment.FormattingEnabled = True
        Me.ComboBoxTreatment.Location = New System.Drawing.Point(334, 182)
        Me.ComboBoxTreatment.Name = "ComboBoxTreatment"
        Me.ComboBoxTreatment.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxTreatment.TabIndex = 55
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(331, 163)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Treatment : "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(331, 231)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Description :"
        '
        'TextBoxDescription
        '
        Me.TextBoxDescription.Location = New System.Drawing.Point(333, 252)
        Me.TextBoxDescription.Multiline = True
        Me.TextBoxDescription.Name = "TextBoxDescription"
        Me.TextBoxDescription.Size = New System.Drawing.Size(122, 83)
        Me.TextBoxDescription.TabIndex = 57
        '
        'LinkLabelClearVisitForm
        '
        Me.LinkLabelClearVisitForm.Image = Global.RKMedisCustomizedRTH.My.Resources.Resources.clear2
        Me.LinkLabelClearVisitForm.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LinkLabelClearVisitForm.Location = New System.Drawing.Point(338, 56)
        Me.LinkLabelClearVisitForm.Name = "LinkLabelClearVisitForm"
        Me.LinkLabelClearVisitForm.Size = New System.Drawing.Size(56, 53)
        Me.LinkLabelClearVisitForm.TabIndex = 59
        Me.LinkLabelClearVisitForm.TabStop = True
        Me.LinkLabelClearVisitForm.Text = "Clear"
        Me.LinkLabelClearVisitForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.LinkLabelClearVisitForm.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 230)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "Time :"
        '
        'DateTimePickerTimeVisited
        '
        Me.DateTimePickerTimeVisited.CustomFormat = "hh:mm:ss"
        Me.DateTimePickerTimeVisited.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerTimeVisited.Location = New System.Drawing.Point(25, 249)
        Me.DateTimePickerTimeVisited.Name = "DateTimePickerTimeVisited"
        Me.DateTimePickerTimeVisited.ShowUpDown = True
        Me.DateTimePickerTimeVisited.Size = New System.Drawing.Size(86, 20)
        Me.DateTimePickerTimeVisited.TabIndex = 60
        '
        'VisitForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 361)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DateTimePickerTimeVisited)
        Me.Controls.Add(Me.LinkLabelClearVisitForm)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBoxDescription)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ComboBoxTreatment)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxBloodPressure)
        Me.Controls.Add(Me.NumericUpDownWeight)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePickerDateFuture)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateTimePickerDateVisited)
        Me.Controls.Add(Me.LabelLoadingVisitForm)
        Me.Controls.Add(Me.LinkLabelSaveVisitForm)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComboBoxPatientName)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VisitForm"
        Me.Text = "Visit Form"
        CType(Me.NumericUpDownWeight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxPatientName As ComboBox
    Friend WithEvents LabelLoadingVisitForm As Label
    Friend WithEvents LinkLabelSaveVisitForm As LinkLabel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePickerDateVisited As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePickerDateFuture As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents NumericUpDownWeight As NumericUpDown
    Friend WithEvents TextBoxBloodPressure As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBoxTreatment As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxDescription As TextBox
    Friend WithEvents LinkLabelClearVisitForm As LinkLabel
    Friend WithEvents Label9 As Label
    Friend WithEvents DateTimePickerTimeVisited As DateTimePicker
End Class
