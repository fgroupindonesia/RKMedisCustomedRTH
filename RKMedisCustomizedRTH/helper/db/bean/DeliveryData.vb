Public Class DeliveryData

    Private _dateCreated As String
    Public Property date_created() As String
        Get
            Return _dateCreated
        End Get
        Set(ByVal value As String)
            _dateCreated = value
        End Set
    End Property

    Private _message As String
    Public Property message() As String
        Get
            Return _message
        End Get
        Set(ByVal value As String)
            _message = value
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

    Private _invoiceCode As String
    Public Property invoice_code() As String
        Get
            Return _invoiceCode
        End Get
        Set(ByVal value As String)
            _invoiceCode = value
        End Set
    End Property

    Private _price As Integer
    Public Property price() As Integer
        Get
            Return _price
        End Get
        Set(ByVal value As Integer)
            _price = value
        End Set
    End Property

    Private _courier As String
    Public Property courier() As String
        Get
            Return _courier
        End Get
        Set(ByVal value As String)
            _courier = value
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
