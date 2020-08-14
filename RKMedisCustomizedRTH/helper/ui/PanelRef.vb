Module PanelRef

    Private _picturePreviewBox As PictureBox
    Public Property PreviewPicturebox() As PictureBox
        Get
            Return _picturePreviewBox
        End Get
        Set(ByVal value As PictureBox)
            _picturePreviewBox = value
        End Set
    End Property

    Private _filesizePicturePreviewLabel As Label
    Public Property FileSizePicturePreviewLabel() As Label
        Get
            Return _filesizePicturePreviewLabel
        End Get
        Set(ByVal value As Label)
            _filesizePicturePreviewLabel = value
        End Set
    End Property

    Private _filenamePicturePreviewLabel As Label
    Public Property FileNamePicturePreviewLabel() As Label
        Get
            Return _filenamePicturePreviewLabel
        End Get
        Set(ByVal value As Label)
            _filenamePicturePreviewLabel = value
        End Set
    End Property

    Private _progressFormLabel As Label
    Public Property ProgressFormLabel() As Label
        Get
            Return _progressFormLabel
        End Get
        Set(ByVal value As Label)
            _progressFormLabel = value
        End Set
    End Property

    Private _privilegeUsername As ComboBox
    Public Property PriviledgeUsernameCombobox() As ComboBox
        Get
            Return _privilegeUsername
        End Get
        Set(ByVal value As ComboBox)
            _privilegeUsername = value
        End Set
    End Property

    Private _patientAge As Label
    Public Property AgePatientLabel() As Label
        Get
            Return _patientAge
        End Get
        Set(ByVal value As Label)
            _patientAge = value
        End Set
    End Property

    Private _priviledgeUserPatient As Label
    Public Property PriviledgeUserPatientLabel() As Label
        Get
            Return _priviledgeUserPatient
        End Get
        Set(ByVal value As Label)
            _priviledgeUserPatient = value
        End Set
    End Property

    Private _lastRegPatient As Label
    Public Property LastRegisteredPatientLabel() As Label
        Get
            Return _lastRegPatient
        End Get
        Set(ByVal value As Label)
            _lastRegPatient = value
        End Set
    End Property

    Private _timeCreatedUser As Label
    Public Property TimeCreatedUserLabel() As Label
        Get
            Return _timeCreatedUser
        End Get
        Set(ByVal value As Label)
            _timeCreatedUser = value
        End Set
    End Property

    Private _lastRegUser As Label
    Public Property LastRegisteredUserLabel() As Label
        Get
            Return _lastRegUser
        End Get
        Set(ByVal value As Label)
            _lastRegUser = value
        End Set
    End Property

    Private _userProfilePictureBox As PictureBox
    Public Property UserPropicPictureBox() As PictureBox
        Get
            Return _userProfilePictureBox
        End Get
        Set(ByVal value As PictureBox)
            _userProfilePictureBox = value
        End Set
    End Property

End Module
