Public Class ScheduleData

    Private _date_choosen As String
    Public Property date_choosen() As String
        Get
            Return _date_choosen
        End Get
        Set(ByVal value As String)
            _date_choosen = value
        End Set
    End Property

    Private _status As String
    Public Property status() As String
        Get
            Return _status
        End Get
        Set(ByVal value As String)
            _status = value
        End Set
    End Property

    Private _treatment As String
    Public Property treatment() As String
        Get
            Return _treatment
        End Get
        Set(ByVal value As String)
            _treatment = value
        End Set
    End Property

    Private _keluhan As String
    Public Property keluhan() As String
        Get
            Return _keluhan
        End Get
        Set(ByVal value As String)
            _keluhan = value
        End Set
    End Property

    Private _date_created As String
    Public Property date_created() As String
        Get
            Return _date_created
        End Get
        Set(ByVal value As String)
            _date_created = value
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

    Private _patientId As Integer
    Public Property patient_id() As Integer
        Get
            Return _patientId
        End Get
        Set(ByVal value As Integer)
            _patientId = value
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
