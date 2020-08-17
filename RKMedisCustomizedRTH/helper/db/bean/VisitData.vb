Public Class VisitData

    Private _description As String
    Public Property description() As String
        Get
            Return _description
        End Get
        Set(ByVal value As String)
            _description = value
        End Set
    End Property

    Private _bloodPressure As String
    Public Property blood_pressure() As String
        Get
            Return _bloodPressure
        End Get
        Set(ByVal value As String)
            _bloodPressure = value
        End Set
    End Property

    Private _weight As Integer
    Public Property weight() As Integer
        Get
            Return _weight
        End Get
        Set(ByVal value As Integer)
            _weight = value
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

    Private _dateFutureVisit As String
    Public Property date_future_visit() As String
        Get
            Return _dateFutureVisit
        End Get
        Set(ByVal value As String)
            _dateFutureVisit = value
        End Set
    End Property

    Private _dateVisited As String
    Public Property date_visited() As String
        Get
            Return _dateVisited
        End Get
        Set(ByVal value As String)
            _dateVisited = value
        End Set
    End Property

    Private _patientID As Integer
    Public Property patient_id() As Integer
        Get
            Return _patientID
        End Get
        Set(ByVal value As Integer)
            _patientID = value
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
