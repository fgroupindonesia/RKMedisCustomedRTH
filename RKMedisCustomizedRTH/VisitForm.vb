Public Class VisitForm


    Private _mode As Integer
    Public Property Mode() As Integer
        Get
            Return _mode
        End Get
        Set(ByVal value As Integer)
            _mode = value
        End Set
    End Property

    Private _data As New VisitData
    Public Property Data() As VisitData
        Get
            Return _data
        End Get
        Set(ByVal value As VisitData)
            _data = value
        End Set
    End Property

    Private _mainFrameRef As MainFrame
    Public Property MainFrameRef() As MainFrame
        Get
            Return _mainFrameRef
        End Get
        Set(ByVal value As MainFrame)
            _mainFrameRef = value
        End Set
    End Property

    Private Sub VisitForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class