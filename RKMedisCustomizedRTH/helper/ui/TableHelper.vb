Module TableHelper

    Private _dataGridSchedule As DataGridView
    Public Property DataGridViewSchedule() As DataGridView
        Get
            Return _dataGridSchedule
        End Get
        Set(ByVal value As DataGridView)
            _dataGridSchedule = value
        End Set
    End Property

    Private _dataGridOrder As DataGridView
    Public Property DataGridViewOrder() As DataGridView
        Get
            Return _dataGridOrder
        End Get
        Set(ByVal value As DataGridView)
            _dataGridOrder = value
        End Set
    End Property

    Private _dataGridProductCatalog As DataGridView
    Public Property DataGridViewProductCatalog() As DataGridView
        Get
            Return _dataGridProductCatalog
        End Get
        Set(ByVal value As DataGridView)
            _dataGridProductCatalog = value
        End Set
    End Property

    Private _dataGridProduct As DataGridView
    Public Property DataGridViewProduct() As DataGridView
        Get
            Return _dataGridProduct
        End Get
        Set(ByVal value As DataGridView)
            _dataGridProduct = value
        End Set
    End Property

    Private _dataGridPatient As DataGridView
    Public Property DataGridViewPatient() As DataGridView
        Get
            Return _dataGridPatient
        End Get
        Set(ByVal value As DataGridView)
            _dataGridPatient = value
        End Set
    End Property

    Private _dataGridUser As DataGridView
    Public Property DataGridViewUser() As DataGridView
        Get
            Return _dataGridUser
        End Get
        Set(ByVal value As DataGridView)
            _dataGridUser = value
        End Set
    End Property

    Private _dataGridOrderItem As DataGridView
    Public Property DataGridViewOrderItem() As DataGridView
        Get
            Return _dataGridOrderItem
        End Get
        Set(ByVal value As DataGridView)
            _dataGridOrderItem = value
        End Set
    End Property

    Public Sub refreshTableOrderItem(ByVal entries As ArrayList)

        If (DataGridViewOrderItem IsNot Nothing) Then
            DataGridViewOrderItem.Rows.Clear()
        End If

        For Each satuan As OrderData In entries
            Dim priceEach As Integer = satuan.sub_total / satuan.quantity
            Dim row As Object() = New Object() {False,
                satuan.id,
                satuan.product_name,
                satuan.quantity,
                priceEach,
                satuan.sub_total
            }

            If (DataGridViewOrderItem IsNot Nothing) Then
                DataGridViewOrderItem.Rows.Add(row)
            End If

        Next

    End Sub

    Public Sub refreshTableOrder(ByVal entries As ArrayList)

        If (DataGridViewOrder IsNot Nothing) Then
            DataGridViewOrder.Rows.Clear()
        End If

        For Each satuan As OrderData In entries
            Dim row As Object() = New Object() {False,
                satuan.id,
                satuan.invoice_code,
                satuan.product_id,
                satuan.quantity,
                satuan.username,
                satuan.sub_total,
                satuan.payment_method,
                satuan.status,
                satuan.date_created
            }

            If (DataGridViewOrder IsNot Nothing) Then
                DataGridViewOrder.Rows.Add(row)
            End If

        Next

    End Sub

    Public Sub refreshTablePatient(ByVal entries As ArrayList)

        If (DataGridViewPatient IsNot Nothing) Then
            DataGridViewPatient.Rows.Clear()
        End If

        For Each satuan As PatientData In entries
            Dim row As Object() = New Object() {False,
                satuan.id,
                satuan.full_name,
                satuan.sex,
                satuan.status_marriage,
                satuan.birth_place,
                satuan.birth_date,
                satuan.age,
                satuan.religion,
                satuan.last_education,
                satuan.work,
                satuan.address,
                satuan.email,
                satuan.status_file,
                satuan.handphone,
                satuan.username_privilege,
                satuan.date_created,
                satuan.no_ktp
            }

            If (DataGridViewPatient IsNot Nothing) Then
                DataGridViewPatient.Rows.Add(row)
            End If

        Next


    End Sub


    Public Sub refreshTableSchedule(ByVal entries As ArrayList)

        If (DataGridViewSchedule IsNot Nothing) Then
            DataGridViewSchedule.Rows.Clear()
        End If

        For Each satuan As ScheduleData In entries
            Dim row As Object() = New Object() {False,
                satuan.id,
                satuan.patient_id,
                satuan.username,
                satuan.keluhan,
                satuan.treatment,
                satuan.status,
                satuan.date_choosen,
                satuan.date_created
            }

            If (DataGridViewSchedule IsNot Nothing) Then
                DataGridViewSchedule.Rows.Add(row)
            End If

        Next


    End Sub

    Public Sub refreshTableProduct(ByVal entries As ArrayList)

        If (DataGridViewProduct IsNot Nothing) Then
            DataGridViewProduct.Rows.Clear()
        End If

        Dim textShown As String = ""
        For Each satuan As ProductData In entries

            If (satuan.image_file IsNot Nothing) Then
                ' for ui purposes only
                textShown = "View Image"
            End If

            Dim row As Object() = New Object() {False,
                satuan.id,
                satuan.name,
                satuan.category,
                satuan.quantity,
                satuan.satuan,
                satuan.price,
                textShown,
                satuan.image_file, ' this image is hidden non-visible in ui table
                satuan.status
            }

            If (DataGridViewProduct IsNot Nothing) Then
                DataGridViewProduct.Rows.Add(row)
            End If

        Next


    End Sub

    Public Sub refreshTableProductCatalog(ByVal entries As ArrayList)

        If (DataGridViewProductCatalog IsNot Nothing) Then
            DataGridViewProductCatalog.Rows.Clear()
        End If

        Dim textShown As String = ""
        For Each satuan As ProductData In entries

            Dim row As Object() = New Object() {False,
                satuan.id,
                satuan.name,
                satuan.category,
                satuan.price,
                satuan.quantity,
                "0"
            }

            If (DataGridViewProductCatalog IsNot Nothing) Then
                DataGridViewProductCatalog.Rows.Add(row)
            End If

        Next


    End Sub

    Public Sub refreshTableUser(ByVal entries As ArrayList)

        If (DataGridViewUser IsNot Nothing) Then
            DataGridViewUser.Rows.Clear()
        End If

        For Each satuan As UserData In entries
            Dim row As Object() = New Object() {False, satuan.id, satuan.username, satuan.pass, satuan.email, satuan.handphone, satuan.full_name, satuan.address, "click"}

            If (DataGridViewUser IsNot Nothing) Then
                DataGridViewUser.Rows.Add(row)
            End If

        Next


    End Sub

    Sub deleteCheckedRows(ByVal tableGrid As DataGridView)
        Dim dataId As New ArrayList

        For Each r As DataGridViewRow In tableGrid.Rows
            Dim checked As Boolean = r.Cells(0).Value
            If (checked) Then
                dataId.Add(r.Index)
            End If
        Next

        For n As Integer = dataId.Count - 1 To 0
            tableGrid.Rows.RemoveAt(n)
        Next

    End Sub

    Function getCheckedRows(ByVal tableGrid As DataGridView) As ArrayList
        Dim dataId As New ArrayList

        For Each r As DataGridViewRow In tableGrid.Rows
            Dim checked As Boolean = r.Cells(0).Value
            If (checked) Then
                Dim idNa As Integer = r.Cells(1).Value.ToString()
                dataId.Add(idNa)
            End If
        Next

        Return dataId
    End Function

    Function getUserManagementCheckedRow() As UserData

        Dim dataUser As UserData = Nothing

        For Each r As DataGridViewRow In DataGridViewUser.Rows
            Dim checked As Boolean = r.Cells(0).Value
            If (checked) Then

                dataUser = New UserData
                dataUser.id = r.Cells(1).Value
                dataUser.username = r.Cells(2).Value
                dataUser.pass = r.Cells(3).Value
                dataUser.email = r.Cells(4).Value
                dataUser.handphone = r.Cells(5).Value
                dataUser.full_name = r.Cells(6).Value
                dataUser.address = r.Cells(7).Value
                ' dataUser.Id = r.Cells("id").Value

                Exit For
            End If
        Next

        Return dataUser

    End Function


    Function getScheduleManagementCheckedRow() As ScheduleData

        Dim dataSchedule As ScheduleData = Nothing

        For Each r As DataGridViewRow In DataGridViewUser.Rows
            Dim checked As Boolean = r.Cells(0).Value
            If (checked) Then

                dataSchedule = New ScheduleData
                dataSchedule.id = r.Cells(1).Value
                dataSchedule.patient_id = r.Cells(2).Value
                dataSchedule.username = r.Cells(3).Value
                dataSchedule.keluhan = r.Cells(4).Value
                dataSchedule.treatment = r.Cells(5).Value
                dataSchedule.status = r.Cells(6).Value
                dataSchedule.date_choosen = r.Cells(7).Value
                dataSchedule.date_created = r.Cells(8).Value

                Exit For
            End If
        Next

        Return dataSchedule

    End Function

    Function getProductManagementCheckedRow() As ProductData

        Dim dataProduct As ProductData = Nothing

        For Each r As DataGridViewRow In DataGridViewProduct.Rows
            Dim checked As Boolean = r.Cells(0).Value
            If (checked) Then

                dataProduct = New ProductData
                dataProduct.id = r.Cells(1).Value
                dataProduct.name = r.Cells(2).Value
                dataProduct.category = r.Cells(3).Value
                dataProduct.quantity = r.Cells(4).Value
                dataProduct.satuan = r.Cells(5).Value
                dataProduct.price = r.Cells(6).Value
                ' the 7th position is used for link ui only
                dataProduct.image_file = r.Cells(8).Value
                dataProduct.status = r.Cells(9).Value
                ' dataUser.Id = r.Cells("id").Value

                Exit For
            End If
        Next

        Return dataProduct

    End Function

    Sub showLastRowTableOrder()
        selectRowDataGrid(DataGridViewOrder)
    End Sub

    Sub showLastRowTablePatient()
        selectRowDataGrid(DataGridViewPatient)
    End Sub

    Sub showLastRowTableProduct()
        selectRowDataGrid(DataGridViewProduct)
    End Sub

    Sub showLastRowTableUser()
        selectRowDataGrid(DataGridViewUser)
    End Sub

    Sub showRowTableOrder(ByVal idRow As Integer)
        selectRowDataGrid(DataGridViewOrder, idRow)
    End Sub

    Sub showRowTableUser(ByVal idRow As Integer)
        selectRowDataGrid(DataGridViewUser, idRow)
    End Sub

    Sub showRowTableProduct(ByVal idRow As Integer)
        selectRowDataGrid(DataGridViewProduct, idRow)
    End Sub

    Sub showRowTablePatient(ByVal idRow As Integer)
        selectRowDataGrid(DataGridViewPatient, idRow)
    End Sub

    Sub selectRowDataGrid(ByVal aDataGridView As DataGridView, Optional rowId As Integer = -1)
        aDataGridView.ClearSelection()
        Dim lastRow As Integer

        If (rowId = -1) Then
            ' default row index for the last item
            lastRow = aDataGridView.Rows.Count - 1
        Else

            ' find the id of the n-th item from the table
            For Each r As DataGridViewRow In aDataGridView.Rows
                If (r.Cells(1).Value = rowId) Then
                    lastRow = r.Index
                End If
            Next

        End If

        aDataGridView.Rows(lastRow).Selected = True
        aDataGridView.FirstDisplayedScrollingRowIndex = lastRow
    End Sub

    Function getOrderManagementCheckedRow() As String
        Dim dataNoInvoice As String = Nothing

        For Each r As DataGridViewRow In DataGridViewOrder.Rows
            Dim checked As Boolean = r.Cells(0).Value
            If (checked) Then

                dataNoInvoice = r.Cells(2).Value

                Exit For
            End If
        Next

        Return dataNoInvoice
    End Function

    Function getPatientManagementCheckedRow() As PatientData

        Dim dataUser As PatientData = Nothing

        For Each r As DataGridViewRow In DataGridViewPatient.Rows
            Dim checked As Boolean = r.Cells(0).Value
            If (checked) Then

                dataUser = New PatientData
                dataUser.id = r.Cells(1).Value
                dataUser.full_name = r.Cells(2).Value
                dataUser.sex = r.Cells(3).Value
                dataUser.status_marriage = r.Cells(4).Value
                dataUser.birth_place = r.Cells(5).Value
                dataUser.birth_date = r.Cells(6).Value
                dataUser.age = r.Cells(7).Value
                dataUser.religion = r.Cells(8).Value
                dataUser.last_education = r.Cells(9).Value
                dataUser.work = r.Cells(10).Value
                dataUser.address = r.Cells(11).Value
                dataUser.email = r.Cells(12).Value
                dataUser.status_file = r.Cells(13).Value
                dataUser.handphone = r.Cells(14).Value
                dataUser.username_privilege = r.Cells(15).Value
                dataUser.date_created = r.Cells(16).Value
                dataUser.no_ktp = r.Cells(17).Value
                ' dataUser.Id = r.Cells("id").Value

                Exit For
            End If
        Next

        Return dataUser

    End Function

End Module
