Public Class MainHistoryRecord

    Private _doctorSuggestDesc As String
    Public Property doctor_suggest_desc() As String
        Get
            Return _doctorSuggestDesc
        End Get
        Set(ByVal value As String)
            _doctorSuggestDesc = value
        End Set
    End Property

    Private _doctorSuggest As String
    Public Property doctor_suggest() As String
        Get
            Return _doctorSuggest
        End Get
        Set(ByVal value As String)
            _doctorSuggest = value
        End Set
    End Property

    Private _worstDiseaseDesc As String
    Public Property worst_disease_desc() As String
        Get
            Return _worstDiseaseDesc
        End Get
        Set(ByVal value As String)
            _worstDiseaseDesc = value
        End Set
    End Property

    Private _worstDisease As String
    Public Property worst_disease() As String
        Get
            Return _worstDisease
        End Get
        Set(ByVal value As String)
            _worstDisease = value
        End Set
    End Property

    Private _wasUsingDrugsDesc As String
    Public Property was_using_drugs_desc() As String
        Get
            Return _wasUsingDrugsDesc
        End Get
        Set(ByVal value As String)
            _wasUsingDrugsDesc = value
        End Set
    End Property

    Private _wasUsingDrugs As String
    Public Property was_using_drugs() As String
        Get
            Return _wasUsingDrugs
        End Get
        Set(ByVal value As String)
            _wasUsingDrugs = value
        End Set
    End Property

    Private _wasHospitalizedDesc As String
    Public Property was_hospitalized_desc() As String
        Get
            Return _wasHospitalizedDesc
        End Get
        Set(ByVal value As String)
            _wasHospitalizedDesc = value
        End Set
    End Property

    Private _wasHospitalized As String
    Public Property was_hospitalized() As String
        Get
            Return _wasHospitalized
        End Get
        Set(ByVal value As String)
            _wasHospitalized = value
        End Set
    End Property

    Private _smokerDesc As String
    Public Property smoker_desc() As String
        Get
            Return _smokerDesc
        End Get
        Set(ByVal value As String)
            _smokerDesc = value
        End Set
    End Property

    Private _smoker As String
    Public Property smoker() As String
        Get
            Return _smoker
        End Get
        Set(ByVal value As String)
            _smoker = value
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
