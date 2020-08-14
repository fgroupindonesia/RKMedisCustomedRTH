Public Class OrderData

    Private _dateCreated As String
    Public Property date_created() As String
        Get
            Return _dateCreated
        End Get
        Set(ByVal value As String)
            _dateCreated = value
        End Set
    End Property

    Private _product_name As String
    Public Property product_name() As String
        Get
            Return _product_name
        End Get
        Set(ByVal value As String)
            _product_name = value
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

    Private _paymentMethod As String
    Public Property payment_method() As String
        Get
            Return _paymentMethod
        End Get
        Set(ByVal value As String)
            _paymentMethod = value
        End Set
    End Property

    Private _subTotal As Integer
    Public Property sub_total() As Integer
        Get
            Return _subTotal
        End Get
        Set(ByVal value As Integer)
            _subTotal = value
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

    Private _quantity As Integer
    Public Property quantity() As Integer
        Get
            Return _quantity
        End Get
        Set(ByVal value As Integer)
            _quantity = value
        End Set
    End Property

    Private _productId As Integer
    Public Property product_id() As Integer
        Get
            Return _productId
        End Get
        Set(ByVal value As Integer)
            _productId = value
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