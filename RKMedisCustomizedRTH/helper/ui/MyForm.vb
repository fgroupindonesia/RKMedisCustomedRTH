Module MyForm

    Public Const MODE_EDIT As Integer = 1
    Public Const MODE_NEW As Integer = 0

    Private _radioButtons As RadioButton()
    Public Property RadioButtons() As RadioButton()
        Get
            Return _radioButtons
        End Get
        Set(ByVal value As RadioButton())
            _radioButtons = value
        End Set
    End Property

    Private _combobox As ComboBox
    Public Property Combobox() As ComboBox
        Get
            Return _combobox
        End Get
        Set(ByVal value As ComboBox)
            _combobox = value
        End Set
    End Property

    Function getAgeYear(ByVal userBirthYear As Integer)
        Dim y2 = DateTime.Now.ToString("yyyy")

        ' this will return the remaining year number 
        ' subtracted with now (year)

        Return y2 - userBirthYear

    End Function

    Function getDate(ByVal DateIn As String) As Date
        ' convert from yyyy-mm-dd hh:mm:ss format splitted to
        ' each separated different values
        Dim dateVal As String() = DateIn.Split(" ")
        Dim dateOnly As String() = dateVal(0).Split("-")

        Dim dateChoosen As New Date(dateOnly(0), dateOnly(1), dateOnly(2))
        Return dateChoosen

    End Function

    Function getTime(ByVal DateIn As String) As String
        ' convert from yyyy-mm-dd hh:mm:ss format splitted to
        ' each separated different values
        Dim dateVal As String() = DateIn.Split(" ")

        Return dateVal(1)

    End Function

    Function getComputerBasedDate(ByVal humanDateFormat As String)

        Dim endVal As String = Nothing

        ' humanDateFormat is actually dd-mm-yyyy
        ' while computer based format is actually yyyy-mm-dd hh:mm:ss
        Dim dataArray As String() = humanDateFormat.Split("-")
        endVal = dataArray(2) & "-" & dataArray(1) & "-" & dataArray(0)

        Return endVal

    End Function

    Function getUserDateFormat(ByVal computerBasedDate As String) As String

        ' the computerBasedFormat is yyyy-mm-dd
        ' while userDateFormat is dd-mm-yyyy
        Dim data As String() = computerBasedDate.Split("-")

        ' if something is happened unexpectedly
        ' we return the empty value
        If (data.Length < 1) Then
            Return Nothing
        End If

        Dim userDate As String = data(2) & "-" & data(1) & "-" & data(0)

        Return userDate
    End Function

    Function getDescription(ByVal textboxElement As TextBox)

        If (textboxElement.Text = "description...") Then
            Return ""
        End If

        Return textboxElement.Text

    End Function

    Public Const STATE_ERROR As Integer = 1
    Public Const STATE_SUCCESS As Integer = 2

    Sub showProgress(ByVal state As Integer, message As String)
        If (PanelRef.ProgressFormLabel.Image IsNot Nothing) Then
            PanelRef.ProgressFormLabel.Image.Dispose()
        End If

        PanelRef.ProgressFormLabel.Text = "                   " & message

        If (state = STATE_ERROR) Then
            PanelRef.ProgressFormLabel.Image = Global.RKMedisCustomizedRTH.My.Resources.delete
        ElseIf (state = STATE_SUCCESS) Then
            PanelRef.ProgressFormLabel.Image = Global.RKMedisCustomizedRTH.My.Resources.ok
        End If

        PanelRef.ProgressFormLabel.Visible = True

    End Sub

    Function switchDateToDB(ByVal normalDate As String)

        ' normal is using this format
        ' dd-MM-yyyy
        Dim dataArray() As String = normalDate.Split("-")

        Dim newDate As String = dataArray(2) & "-" & dataArray(1) & "-" & dataArray(0)
        ' we switched to DB date
        ' yyyy-MM-dd
        Return newDate


    End Function

    Sub clearTextbox(ByVal defaultPlaceholder As String, aTextbox As TextBox)

        If (aTextbox.Text = defaultPlaceholder) Then
            aTextbox.Clear()
        End If

    End Sub

    Sub activateCombobox(ByVal selectedValue As String)

        selectedValue = selectedValue.ToLower

        ' this will be replaced by LanguageSwitcher later (future)
        If (selectedValue = "smp") Then
            selectedValue = "middle"
        ElseIf (selectedValue = "sd") Then
            selectedValue = "elementary"
        ElseIf (selectedValue = "sma") Then
            selectedValue = "senior"
        ElseIf (selectedValue = "kampus" Or selectedValue.ToLower = "s1") Then
            selectedValue = "university"
        End If

        For Each ops As String In Combobox.Items
            If (ops = selectedValue) Then
                Combobox.SelectedItem = ops
            End If
        Next

    End Sub

    Sub activateRadioButton(ByVal selectedValue As String)

        selectedValue = selectedValue.ToLower
        ' this will be replaced by LanguageSwitcher later (future)
        If (selectedValue = "wanita") Then
            selectedValue = "female"
        ElseIf (selectedValue = "pria") Then
            selectedValue = "male"
        End If

        For Each rd As RadioButton In RadioButtons
            If (rd.Text.ToLower = selectedValue) Then
                rd.Checked = True
            Else
                rd.Checked = False
            End If
        Next

    End Sub

    Function isPictureBoxFilled(ByVal picbox As PictureBox, fileFormat As String) As Boolean

        ' checking from the tag

        Dim extension As String() = fileFormat.Split("/")

        For Each ext As String In extension
            If (picbox.Tag.ToString.Contains("" & ext)) Then
                Return True
            End If
        Next

        Return False

    End Function

    Function isFilled(ByVal textboxElement As TextBox) As Boolean
        Return textboxElement.Text.Length > 3
    End Function

    Sub clearTextbox(ByVal textboxElement As TextBox)
        textboxElement.Text = ""
    End Sub

    Sub clearLabel(ByVal labelElement As Label)
        labelElement.Text = ""
    End Sub

    Sub clearPicturebox(ByVal picboxElement As PictureBox)
        picboxElement.Image.Dispose()
        picboxElement.Image = Nothing
    End Sub

    Sub setTextboxTextIfAny(ByVal aTextboxElement As TextBox, realData As String)
        If (realData.Trim.Length <> 0) Then
            aTextboxElement.Text = realData
        Else
            aTextboxElement.Text = "description..."
        End If
    End Sub


    Public Const NOTIFICATION_WARNING As Integer = 1
    Public Const NOTIFICATION_SUCCESS As Integer = 2
    Public Const NOTIFICATION_LOADING As Integer = 3

    Sub applyNotification(ByVal message As String, mode As Integer, labelElement As Label)
        labelElement.Text = "          " & message
        labelElement.Visible = True
        labelElement.Image.Dispose()

        If (mode = NOTIFICATION_LOADING) Then
            labelElement.Image = Global.RKMedisCustomizedRTH.My.Resources.loading
        ElseIf (mode = NOTIFICATION_WARNING) Then
            labelElement.Image = Global.RKMedisCustomizedRTH.My.Resources.warning
        ElseIf (mode = NOTIFICATION_SUCCESS) Then
            labelElement.Image = Global.RKMedisCustomizedRTH.My.Resources.ok
        End If
    End Sub

    Sub roundedCornerForm(ByVal obj As Form)

        'obj.FormBorderStyle = FormBorderStyle.None
        ' obj.BackColor = Color.Cyan


        Dim DGP As New Drawing2D.GraphicsPath
        DGP.StartFigure()
        'top left corner
        DGP.AddArc(New Rectangle(0, 0, 5, 5), 180, 90)
        DGP.AddLine(40, 0, obj.Width - 40, 0)

        'top right corner
        DGP.AddArc(New Rectangle(obj.Width - 40, 0, 65, 65), -90, 90)
        DGP.AddLine(obj.Width, 40, obj.Width, obj.Height - 40)

        'buttom right corner
        DGP.AddArc(New Rectangle(obj.Width - 40, obj.Height - 40, 40, 40), 0, 90)
        DGP.AddLine(obj.Width - 40, obj.Height, 40, obj.Height)

        'buttom left corner
        DGP.AddArc(New Rectangle(0, obj.Height - 40, 40, 40), 90, 90)
        DGP.CloseFigure()

        obj.Region = New Region(DGP)

    End Sub

End Module
