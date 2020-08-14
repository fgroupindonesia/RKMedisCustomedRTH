Public Class UserData

    Private _id As Integer
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _datecreated As String
    Public Property date_created() As String
        Get
            Return _datecreated
        End Get
        Set(ByVal value As String)
            _datecreated = value
        End Set
    End Property

    Private _propic As String
    Public Property propic() As String
        Get
            Return _propic
        End Get
        Set(ByVal value As String)
            _propic = value
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

    Private _fullname As String
    Public Property full_name() As String
        Get
            Return _fullname
        End Get
        Set(ByVal value As String)
            _fullname = value
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

    Private _email As String
    Public Property email() As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property

    Private _pass As String
    Public Property pass() As String
        Get
            Return _pass
        End Get
        Set(ByVal value As String)
            _pass = value
        End Set
    End Property

    Private _username As String
    Public Property username() As String
        Get
            Return _username
        End Get
        Set(ByVal value As String)
            _username = value
        End Set
    End Property

End Class
