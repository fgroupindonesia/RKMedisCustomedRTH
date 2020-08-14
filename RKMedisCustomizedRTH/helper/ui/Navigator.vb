Module Navigator

    Dim currentPanelIndex As Integer = 0

    Public Const PAGE_ORDER_FORM As Integer = 0
    Public Const PAGE_DELIVERY_FORM As Integer = 1

    Public Const PAGE_PATIENT_FORM As Integer = 0
    Public Const PAGE_MAIN_MEDICAL_HISTORY_FORM As Integer = 1
    Public Const PAGE_SECOND_MEDICAL_HISTORY_FORM As Integer = 2

    Public Const PAGE_VISIT_MANAGEMENT As Integer = 7
    Public Const PAGE_SCHEDULE_MANAGEMENT As Integer = 6
    Public Const PAGE_ORDER_MANAGEMENT As Integer = 5
    Public Const PAGE_PRODUCT_MANAGEMENT As Integer = 4
    Public Const PAGE_PATIENT_MANAGEMENT As Integer = 3
    Public Const PAGE_USER_MANAGEMENT As Integer = 2
    Public Const PAGE_HOME As Integer = 1
    Public Const PAGE_LOGIN As Integer = 0


    Private _panels As Panel()
        Public Property Panels() As Panel()
            Get
                Return _panels
            End Get
            Set(ByVal value As Panel())
                _panels = value
            End Set
        End Property


        Sub nextPage()

            currentPanelIndex += 1
            renderPage()

        End Sub

        Sub previousPage()

            currentPanelIndex -= 1
            renderPage()
        End Sub

        Sub gotoPage(ByVal num As Integer)
            currentPanelIndex = num
            renderPage()
        End Sub

        Sub renderPage()

        For Each satuanFrame As Panel In Panels
            If (Int32.Parse(satuanFrame.Tag) = currentPanelIndex) Then
                satuanFrame.Visible = True
            Else
                satuanFrame.Visible = False
            End If
        Next

    End Sub

    End Module
