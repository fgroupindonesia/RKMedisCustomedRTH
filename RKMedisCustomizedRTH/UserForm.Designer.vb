<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserForm))
        Me.PanelUserForm = New System.Windows.Forms.Panel()
        Me.LabelLoadingUserForm = New System.Windows.Forms.Label()
        Me.LinkLabelPictureUserForm = New System.Windows.Forms.LinkLabel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.PictureBoxPropicUserForm = New System.Windows.Forms.PictureBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBoxFullnameUserForm = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBoxAddressUserForm = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBoxHandphoneUserForm = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBoxEmailUserForm = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBoxPasswordUserForm = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LinkLabelSaveUserForm = New System.Windows.Forms.LinkLabel()
        Me.TextBoxUsernameUserForm = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PanelUserForm.SuspendLayout()
        CType(Me.PictureBoxPropicUserForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelUserForm
        '
        Me.PanelUserForm.Controls.Add(Me.LabelLoadingUserForm)
        Me.PanelUserForm.Controls.Add(Me.LinkLabelPictureUserForm)
        Me.PanelUserForm.Controls.Add(Me.Label18)
        Me.PanelUserForm.Controls.Add(Me.PictureBoxPropicUserForm)
        Me.PanelUserForm.Controls.Add(Me.Label17)
        Me.PanelUserForm.Controls.Add(Me.TextBoxFullnameUserForm)
        Me.PanelUserForm.Controls.Add(Me.Label16)
        Me.PanelUserForm.Controls.Add(Me.TextBoxAddressUserForm)
        Me.PanelUserForm.Controls.Add(Me.Label15)
        Me.PanelUserForm.Controls.Add(Me.TextBoxHandphoneUserForm)
        Me.PanelUserForm.Controls.Add(Me.Label14)
        Me.PanelUserForm.Controls.Add(Me.TextBoxEmailUserForm)
        Me.PanelUserForm.Controls.Add(Me.Label13)
        Me.PanelUserForm.Controls.Add(Me.TextBoxPasswordUserForm)
        Me.PanelUserForm.Controls.Add(Me.Label12)
        Me.PanelUserForm.Controls.Add(Me.LinkLabelSaveUserForm)
        Me.PanelUserForm.Controls.Add(Me.TextBoxUsernameUserForm)
        Me.PanelUserForm.Controls.Add(Me.Label6)
        Me.PanelUserForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelUserForm.Location = New System.Drawing.Point(0, 0)
        Me.PanelUserForm.Name = "PanelUserForm"
        Me.PanelUserForm.Size = New System.Drawing.Size(588, 455)
        Me.PanelUserForm.TabIndex = 12
        Me.PanelUserForm.Tag = "8"
        '
        'LabelLoadingUserForm
        '
        Me.LabelLoadingUserForm.Image = Global.RKMedisCustomizedRTH.My.Resources.Resources.loading
        Me.LabelLoadingUserForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelLoadingUserForm.Location = New System.Drawing.Point(21, 54)
        Me.LabelLoadingUserForm.Name = "LabelLoadingUserForm"
        Me.LabelLoadingUserForm.Size = New System.Drawing.Size(252, 42)
        Me.LabelLoadingUserForm.TabIndex = 32
        Me.LabelLoadingUserForm.Text = "Loading..."
        Me.LabelLoadingUserForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelLoadingUserForm.Visible = False
        '
        'LinkLabelPictureUserForm
        '
        Me.LinkLabelPictureUserForm.AutoSize = True
        Me.LinkLabelPictureUserForm.Location = New System.Drawing.Point(163, 326)
        Me.LinkLabelPictureUserForm.Name = "LinkLabelPictureUserForm"
        Me.LinkLabelPictureUserForm.Size = New System.Drawing.Size(51, 13)
        Me.LinkLabelPictureUserForm.TabIndex = 31
        Me.LinkLabelPictureUserForm.TabStop = True
        Me.LinkLabelPictureUserForm.Text = "Browse..."
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(21, 304)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 13)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "Profile Picture"
        '
        'PictureBoxPropicUserForm
        '
        Me.PictureBoxPropicUserForm.Image = Global.RKMedisCustomizedRTH.My.Resources.Resources.blankuser
        Me.PictureBoxPropicUserForm.Location = New System.Drawing.Point(24, 320)
        Me.PictureBoxPropicUserForm.Name = "PictureBoxPropicUserForm"
        Me.PictureBoxPropicUserForm.Size = New System.Drawing.Size(128, 128)
        Me.PictureBoxPropicUserForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBoxPropicUserForm.TabIndex = 29
        Me.PictureBoxPropicUserForm.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(323, 248)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(49, 13)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "Fullname"
        '
        'TextBoxFullnameUserForm
        '
        Me.TextBoxFullnameUserForm.Location = New System.Drawing.Point(320, 267)
        Me.TextBoxFullnameUserForm.Name = "TextBoxFullnameUserForm"
        Me.TextBoxFullnameUserForm.Size = New System.Drawing.Size(189, 20)
        Me.TextBoxFullnameUserForm.TabIndex = 27
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(323, 150)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 13)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Address"
        '
        'TextBoxAddressUserForm
        '
        Me.TextBoxAddressUserForm.Location = New System.Drawing.Point(320, 169)
        Me.TextBoxAddressUserForm.Multiline = True
        Me.TextBoxAddressUserForm.Name = "TextBoxAddressUserForm"
        Me.TextBoxAddressUserForm.Size = New System.Drawing.Size(245, 70)
        Me.TextBoxAddressUserForm.TabIndex = 25
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(21, 248)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 13)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Handphone"
        '
        'TextBoxHandphoneUserForm
        '
        Me.TextBoxHandphoneUserForm.Location = New System.Drawing.Point(18, 267)
        Me.TextBoxHandphoneUserForm.Name = "TextBoxHandphoneUserForm"
        Me.TextBoxHandphoneUserForm.Size = New System.Drawing.Size(189, 20)
        Me.TextBoxHandphoneUserForm.TabIndex = 23
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(21, 200)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(32, 13)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Email"
        '
        'TextBoxEmailUserForm
        '
        Me.TextBoxEmailUserForm.Location = New System.Drawing.Point(18, 219)
        Me.TextBoxEmailUserForm.Name = "TextBoxEmailUserForm"
        Me.TextBoxEmailUserForm.Size = New System.Drawing.Size(245, 20)
        Me.TextBoxEmailUserForm.TabIndex = 21
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(21, 150)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 13)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Password"
        '
        'TextBoxPasswordUserForm
        '
        Me.TextBoxPasswordUserForm.Location = New System.Drawing.Point(18, 169)
        Me.TextBoxPasswordUserForm.Name = "TextBoxPasswordUserForm"
        Me.TextBoxPasswordUserForm.Size = New System.Drawing.Size(245, 20)
        Me.TextBoxPasswordUserForm.TabIndex = 19
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(18, 100)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 13)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Username"
        '
        'LinkLabelSaveUserForm
        '
        Me.LinkLabelSaveUserForm.Image = Global.RKMedisCustomizedRTH.My.Resources.Resources.save
        Me.LinkLabelSaveUserForm.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LinkLabelSaveUserForm.Location = New System.Drawing.Point(509, 64)
        Me.LinkLabelSaveUserForm.Name = "LinkLabelSaveUserForm"
        Me.LinkLabelSaveUserForm.Size = New System.Drawing.Size(56, 53)
        Me.LinkLabelSaveUserForm.TabIndex = 17
        Me.LinkLabelSaveUserForm.TabStop = True
        Me.LinkLabelSaveUserForm.Text = "Save"
        Me.LinkLabelSaveUserForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'TextBoxUsernameUserForm
        '
        Me.TextBoxUsernameUserForm.Location = New System.Drawing.Point(18, 119)
        Me.TextBoxUsernameUserForm.Name = "TextBoxUsernameUserForm"
        Me.TextBoxUsernameUserForm.Size = New System.Drawing.Size(296, 20)
        Me.TextBoxUsernameUserForm.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(162, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(284, 23)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "User Form"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'UserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 455)
        Me.Controls.Add(Me.PanelUserForm)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UserForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UserForm"
        Me.PanelUserForm.ResumeLayout(False)
        Me.PanelUserForm.PerformLayout()
        CType(Me.PictureBoxPropicUserForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelUserForm As Panel
    Friend WithEvents LinkLabelPictureUserForm As LinkLabel
    Friend WithEvents Label18 As Label
    Friend WithEvents PictureBoxPropicUserForm As PictureBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBoxFullnameUserForm As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBoxAddressUserForm As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBoxHandphoneUserForm As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBoxEmailUserForm As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBoxPasswordUserForm As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents LinkLabelSaveUserForm As LinkLabel
    Friend WithEvents TextBoxUsernameUserForm As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents LabelLoadingUserForm As Label
End Class
