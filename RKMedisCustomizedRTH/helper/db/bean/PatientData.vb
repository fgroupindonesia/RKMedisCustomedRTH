Public Class PatientData

    Private _dateCreated As String
    Public Property date_created() As String
        Get
            Return _dateCreated
        End Get
        Set(ByVal value As String)
            _dateCreated = value
        End Set
    End Property

    Private _statusFile As String
    Public Property status_file() As String
        Get
            Return _statusFile
        End Get
        Set(ByVal value As String)
            _statusFile = value
        End Set
    End Property

    Private _email As String
    Public Property email() As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property

    Private _address As String
    Public Property address() As String
        Get
            Return _address
        End Get
        Set(ByVal value As String)
            _address = value
        End Set
    End Property

    Private _work As String
    Public Property work() As String
        Get
            Return _work
        End Get
        Set(ByVal value As String)
            _work = value
        End Set
    End Property

    Private _lastedu As String
    Public Property last_education() As String
        Get
            Return _lastedu
        End Get
        Set(ByVal value As String)
            _lastedu = value
        End Set
    End Property

    Private _religion As String
    Public Property religion() As String
        Get
            Return _religion
        End Get
        Set(ByVal value As String)
            _religion = value
        End Set
    End Property

    Private _sex As String
    Public Property sex() As String
        Get
            Return _sex
        End Get
        Set(ByVal value As String)
            _sex = value
        End Set
    End Property

    Private _statusMarriage As String
    Public Property status_marriage() As String
        Get
            Return _statusMarriage
        End Get
        Set(ByVal value As String)
            _statusMarriage = value
        End Set
    End Property

    Private _handphone As String
    Public Property handphone() As String
        Get
            Return _handphone
        End Get
        Set(ByVal value As String)
            _handphone = value
        End Set
    End Property

    Private _usernamePrivilege As String
    Public Property username_privilege() As String
        Get
            Return _usernamePrivilege
        End Get
        Set(ByVal value As String)
            _usernamePrivilege = value
        End Set
    End Property

    Private _age As String
    Public Property age() As String
        Get
            Return _age
        End Get
        Set(ByVal value As String)
            _age = value
        End Set
    End Property
    Private _fullname As String
    Public Property full_name() As String
        Get
            Return _fullname
        End Get
        Set(ByVal value As String)
            _fullname = value
        End Set
    End Property

    Private _noktp As String
    Public Property no_ktp() As String
        Get
            Return _noktp
        End Get
        Set(ByVal value As String)
            _noktp = value
        End Set
    End Property



    Private _birthdate As String
    Public Property birth_date() As String
        Get
            Return _birthdate
        End Get
        Set(ByVal value As String)
            _birthdate = value
        End Set
    End Property

    Private _birthplace As String
    Public Property birth_place() As String
        Get
            Return _birthplace
        End Get
        Set(ByVal value As String)
            _birthplace = value
        End Set
    End Property

    Private _id As Integer
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

End Class
