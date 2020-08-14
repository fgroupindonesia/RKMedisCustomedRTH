Public Class ProductCategoryData

    Private _dateCreated As String
    Public Property date_created() As String
        Get
            Return _dateCreated
        End Get
        Set(ByVal value As String)
            _dateCreated = value
        End Set
    End Property

    Private _name As String
    Public Property name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
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
