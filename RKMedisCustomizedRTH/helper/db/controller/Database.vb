Imports System.Environment
Imports System.IO
Imports System.Net
Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Module Database

    '' this Database module is actually WebRequest to the official API
    '' of FGroupIndonesia located at http://client.fgroupindonesia.com/rth/etc....

    Dim mainEndPoint As String = "http://client.fgroupindonesia.com/rth/"


    Sub ready()

        ' make a stable call

    End Sub

    Function constructURL(ByVal entityURL, ByVal actionURL) As String

        Return mainEndPoint & entityURL & "/" & actionURL
    End Function

    Function isValidStatus(ByVal dataIn As JObject) As Boolean
        Return Not dataIn.GetValue("status").ToString.Equals("invalid")
    End Function

    Async Function downloadUserPropic(ByVal aUsername As String, Optional editFormUsage As Boolean = True) As Task

        Dim client As HttpClient = New HttpClient

        Dim values As New Dictionary(Of String, String)
        values.Add("username", aUsername)

        Dim content As FormUrlEncodedContent = New FormUrlEncodedContent(values)

        Dim endResult As String
        Dim urlTarget As String = constructURL("user", "propic/download")
        Dim dataResponse As HttpResponseMessage = Await client.PostAsync(urlTarget, content)

        ' Check that response was successful or throw exception
        dataResponse.EnsureSuccessStatusCode()

        Dim tempFilename = "\\temp_user_propic.jpg"

        If (Directory.Exists(AppPath.getLokasiImageLocal) = False) Then
            Directory.CreateDirectory(AppPath.getLokasiImageLocal)
        End If

        Try


            ' Read response asynchronously and save asynchronously to file
            Using fileStream As FileStream = New FileStream((AppPath.getLokasiImageLocal + tempFilename), FileMode.Create, FileAccess.Write, FileShare.None)
                Await dataResponse.Content.CopyToAsync(fileStream)

            End Using


            'once done we render to the picture box
            Dim imageAsByteArray() As Byte = File.ReadAllBytes(AppPath.getLokasiImageLocal + tempFilename)


            If (editFormUsage) Then

                ' releasing any resource used earlier
                PanelRef.UserPropicPictureBox.Image.Dispose()
                PanelRef.UserPropicPictureBox.Image = ImageHelper.byteArrayToImage(imageAsByteArray)

            Else
                Dim fi As FileInfo = New FileInfo(AppPath.getLokasiImageLocal + tempFilename)
                Dim sizeFile As Long = fi.Length

                ' updating the detail
                PanelRef.FileSizePicturePreviewLabel.Text = "File Size : " & FormatSize(sizeFile)
                PanelRef.PreviewPicturebox.Image.Dispose()
                PanelRef.PreviewPicturebox.Image = ImageHelper.byteArrayToImage(imageAsByteArray)

            End If


            client.Dispose()

        Catch ex As Exception
            MessageBox.Show("Error on #89 " & ex.Message)
            ErrorLogger.write(ex.Message & "\n" & ex.StackTrace)
        End Try



    End Function

    Async Function downloadProductPicture(ByVal aFileName As String) As Task

        Dim client As HttpClient = New HttpClient

        Dim values As New Dictionary(Of String, String)
        values.Add("image_file", aFileName)

        Dim content As FormUrlEncodedContent = New FormUrlEncodedContent(values)

        Dim endResult As String
        Dim urlTarget As String = constructURL("product", "image/download")
        Dim dataResponse As HttpResponseMessage = Await client.PostAsync(urlTarget, content)

        ' Check that response was successful or throw exception
        dataResponse.EnsureSuccessStatusCode()

        Dim tempFilename = "\\temp_product_picture.jpg"

        If (Directory.Exists(AppPath.getLokasiImageLocal) = False) Then
            Directory.CreateDirectory(AppPath.getLokasiImageLocal)
        End If

        Try


            ' Read response asynchronously and save asynchronously to file
            Using fileStream As FileStream = New FileStream((AppPath.getLokasiImageLocal + tempFilename), FileMode.Create, FileAccess.Write, FileShare.None)
                Await dataResponse.Content.CopyToAsync(fileStream)

            End Using


            'once done we render to the picture box
            Dim imageAsByteArray() As Byte = File.ReadAllBytes(AppPath.getLokasiImageLocal + tempFilename)


            ' releasing any resource used earlier
            If (PanelRef.PreviewPicturebox.Image IsNot Nothing) Then
                PanelRef.PreviewPicturebox.Image.Dispose()
            End If

            PanelRef.PreviewPicturebox.Image = ImageHelper.byteArrayToImage(imageAsByteArray)



            client.Dispose()

        Catch ex As Exception
            MessageBox.Show("Error on #141 " & ex.Message)
            ErrorLogger.write(ex.Message & "\n" & ex.StackTrace)
        End Try



    End Function

    Async Function deleteUser(ByVal anId As Integer) As Task

        Dim client As HttpClient = New HttpClient
        Dim arrayList As New ArrayList

        Dim values As New Dictionary(Of String, String)
        values.Add("id", anId)

        Dim content As FormUrlEncodedContent = New FormUrlEncodedContent(values)

        Dim endResult As String
        Dim urlTarget As String = constructURL("user", "delete")
        Dim dataResponse As HttpResponseMessage = Await client.PostAsync(urlTarget, content)

        endResult = Await dataResponse.Content.ReadAsStringAsync()

        ' parse the string
        Try

            Dim dataIn As JObject = JsonConvert.DeserializeObject(endResult)

            If (dataIn IsNot Nothing) Then

                If (isValidStatus(dataIn) = True) Then

                    MyForm.showProgress(STATE_SUCCESS, "deleting data is success!")

                    ' refresh back the user table
                    getAllUser()

                End If

            End If


            client.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error on #136 " & ex.Message)
            ErrorLogger.write(ex.Message & "\n" & ex.StackTrace)
        End Try



    End Function

    Async Function deleteSchedule(ByVal anId As Integer) As Task

        Dim client As HttpClient = New HttpClient
        Dim arrayList As New ArrayList

        Dim values As New Dictionary(Of String, String)
        values.Add("id", anId)

        Dim content As FormUrlEncodedContent = New FormUrlEncodedContent(values)

        Dim endResult As String
        Dim urlTarget As String = constructURL("request", "schedule/delete")
        Dim dataResponse As HttpResponseMessage = Await client.PostAsync(urlTarget, content)

        endResult = Await dataResponse.Content.ReadAsStringAsync()

        ' parse the string
        Try

            Dim dataIn As JObject = JsonConvert.DeserializeObject(endResult)

            If (dataIn IsNot Nothing) Then

                If (isValidStatus(dataIn) = True) Then

                    MyForm.showProgress(STATE_SUCCESS, "deleting data is success!")

                    ' refresh back the schedule table
                    getAllSchedule()

                End If

            End If

            client.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error on #235 " & ex.Message)
            ErrorLogger.write(ex.Message & "\n" & ex.StackTrace)
        End Try



    End Function

    Async Function deleteOrderItem(ByVal anId As Integer) As Task

        Dim client As HttpClient = New HttpClient
        Dim arrayList As New ArrayList

        Dim values As New Dictionary(Of String, String)
        values.Add("id", anId)

        Dim content As FormUrlEncodedContent = New FormUrlEncodedContent(values)

        Dim endResult As String
        Dim urlTarget As String = constructURL("order", "item/delete")
        Dim dataResponse As HttpResponseMessage = Await client.PostAsync(urlTarget, content)

        endResult = Await dataResponse.Content.ReadAsStringAsync()

        ' parse the string
        Try

            Dim dataIn As JObject = JsonConvert.DeserializeObject(endResult)

            If (dataIn IsNot Nothing) Then

                If (isValidStatus(dataIn) = True) Then

                    MyForm.showProgress(STATE_SUCCESS, "deleting data is success!")

                    ' refresh back the user table
                    getAllOrder()

                End If

            End If


            client.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error on #240 " & ex.Message)
            ErrorLogger.write(ex.Message & "\n" & ex.StackTrace)
        End Try



    End Function

    Async Function deleteOrder(ByVal anId As Integer) As Task

        Dim client As HttpClient = New HttpClient
        Dim arrayList As New ArrayList

        Dim values As New Dictionary(Of String, String)
        values.Add("id", anId)

        Dim content As FormUrlEncodedContent = New FormUrlEncodedContent(values)

        Dim endResult As String
        Dim urlTarget As String = constructURL("order", "delete")
        Dim dataResponse As HttpResponseMessage = Await client.PostAsync(urlTarget, content)

        endResult = Await dataResponse.Content.ReadAsStringAsync()

        ' parse the string
        Try

            Dim dataIn As JObject = JsonConvert.DeserializeObject(endResult)

            If (dataIn IsNot Nothing) Then

                If (isValidStatus(dataIn) = True) Then

                    MyForm.showProgress(STATE_SUCCESS, "deleting data is success!")

                    ' refresh back the user table
                    getAllOrder()

                End If

            End If


            client.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error on #285 " & ex.Message)
            ErrorLogger.write(ex.Message & "\n" & ex.StackTrace)
        End Try



    End Function

    Async Function deletePatient(ByVal anId As Integer) As Task

        Dim client As HttpClient = New HttpClient
        Dim arrayList As New ArrayList

        Dim values As New Dictionary(Of String, String)
        values.Add("id", anId)

        Dim content As FormUrlEncodedContent = New FormUrlEncodedContent(values)

        Dim endResult As String
        Dim urlTarget As String = constructURL("patient", "delete")
        Dim dataResponse As HttpResponseMessage = Await client.PostAsync(urlTarget, content)

        endResult = Await dataResponse.Content.ReadAsStringAsync()

        ' parse the string
        Try

            Dim dataIn As JObject = JsonConvert.DeserializeObject(endResult)

            If (dataIn IsNot Nothing) Then

                If (isValidStatus(dataIn) = True) Then

                    If (PanelRef.ProgressFormLabel.Image IsNot Nothing) Then
                        PanelRef.ProgressFormLabel.Image.Dispose()
                    End If

                    PanelRef.ProgressFormLabel.Image = Global.RKMedisCustomizedRTH.My.Resources.Resources.ok
                    PanelRef.ProgressFormLabel.Text = "                   deleting data is success!"

                    ' refresh back the user table
                    getAllPatient()

                End If

            End If


            client.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error on #184 " & ex.Message)
            ErrorLogger.write(ex.Message & "\n" & ex.StackTrace)
        End Try



    End Function


    Async Function deleteProduct(ByVal anId As Integer) As Task

        Dim client As HttpClient = New HttpClient
        Dim arrayList As New ArrayList

        Dim values As New Dictionary(Of String, String)
        values.Add("id", anId)

        Dim content As FormUrlEncodedContent = New FormUrlEncodedContent(values)

        Dim endResult As String
        Dim urlTarget As String = constructURL("product", "delete")
        Dim dataResponse As HttpResponseMessage = Await client.PostAsync(urlTarget, content)

        endResult = Await dataResponse.Content.ReadAsStringAsync()

        ' parse the string
        Try

            Dim dataIn As JObject = JsonConvert.DeserializeObject(endResult)

            If (dataIn IsNot Nothing) Then

                If (isValidStatus(dataIn) = True) Then


                    MyForm.showProgress(STATE_SUCCESS, "deleting data is success!")

                    ' refresh back the product table
                    getAllProduct()

                End If

            End If


            client.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error on #240 " & ex.Message)
            ErrorLogger.write(ex.Message & "\n" & ex.StackTrace)
        End Try



    End Function

    Async Function savePatient(ByVal anEntry As PatientData, mainRecord As MainHistoryRecord, secondRecord As SecondHistoryRecord, Optional updateMode As Boolean = False, Optional patientFormRef As PatientForm = Nothing) As Task

        Dim client As HttpClient = New HttpClient

        Dim endResult As String
        Dim arrayList As New ArrayList

        ' parse the string
        Try

            ' Dim stringPayload As String = JsonConvert.SerializeObject(anEntry)
            ' Dim content As StringContent = New StringContent(stringPayload, Encoding.UTF8, "application/json")

            ' we're not using json here
            Dim values As New Dictionary(Of String, String)

            If (updateMode = True) Then
                values.Add("id", anEntry.id)
            End If

            values.Add("no_ktp", anEntry.no_ktp)
            values.Add("full_name", anEntry.full_name)
            values.Add("birth_place", anEntry.birth_place)
            values.Add("birth_date", anEntry.birth_date)
            values.Add("age", anEntry.age)
            values.Add("sex", anEntry.sex)
            values.Add("status_marriage", anEntry.status_marriage)
            values.Add("religion", anEntry.religion)
            values.Add("last_education", anEntry.last_education)
            values.Add("work", anEntry.work)
            values.Add("address", anEntry.address)
            values.Add("handphone", anEntry.handphone)
            values.Add("email", anEntry.email)
            values.Add("username", anEntry.username_privilege)

            'Main Record Health Entries
            values.Add("smoker", mainRecord.smoker)
            values.Add("smoker_desc", mainRecord.smoker_desc)
            values.Add("was_hospitalized", mainRecord.was_hospitalized)
            values.Add("was_hospitalized_desc", mainRecord.was_hospitalized_desc)
            values.Add("was_using_drugs", mainRecord.was_using_drugs)
            values.Add("was_using_drugs_desc", mainRecord.was_using_drugs_desc)
            values.Add("worst_disease", mainRecord.worst_disease)
            values.Add("worst_disease_desc", mainRecord.worst_disease_desc)
            values.Add("doctor_suggest", mainRecord.doctor_suggest)
            values.Add("doctor_suggest_desc", mainRecord.doctor_suggest_desc)

            'Second Record Health Entries
            values.Add("adat_syirik", secondRecord.adat_syirik)
            values.Add("adat_syirik_desc", secondRecord.adat_syirik_desc)
            values.Add("dzikir_td", secondRecord.dzikir_td)
            values.Add("dzikir_td_desc", secondRecord.dzikir_td_desc)
            values.Add("mimpi_buruk", secondRecord.mimpi_buruk)
            values.Add("mimpi_buruk_desc", secondRecord.mimpi_buruk_desc)
            values.Add("paranormal", secondRecord.paranormal)
            values.Add("paranormal_desc", secondRecord.paranormal_desc)
            values.Add("penampakan_ghaib", secondRecord.penampakan_ghaib)
            values.Add("penampakan_ghaib_desc", secondRecord.penampakan_ghaib_desc)

            Dim content As FormUrlEncodedContent = New FormUrlEncodedContent(values)

            Dim urlTarget As String

            If (updateMode = True) Then
                urlTarget = constructURL("patient", "update")
            Else
                urlTarget = constructURL("patient", "add")
            End If

            Dim dataResponse As HttpResponseMessage = Await client.PostAsync(urlTarget, content)

            endResult = Await dataResponse.Content.ReadAsStringAsync()

            Dim dataIn As JObject = JsonConvert.DeserializeObject(endResult)

            If (dataIn IsNot Nothing) Then

                If (isValidStatus(dataIn) = True) Then



                    If (updateMode) Then
                        MyForm.showProgress(STATE_SUCCESS, "data is successfully updated!")
                    Else
                        MyForm.showProgress(STATE_SUCCESS, "data is successfully saved!")
                    End If

                    ' refresh back the patient table
                    getAllPatient()

                    ' close the active form
                    If (patientFormRef IsNot Nothing) Then
                        patientFormRef.Dispose()
                    End If


                Else
                    ' when error
                    MyForm.showProgress(MyForm.STATE_ERROR, "Error Saving patient data!")

                End If

            End If

            client.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error on #250 " & ex.Message)
            ErrorLogger.write(ex.Message & "\n" & ex.StackTrace)
        End Try

    End Function

    Async Function saveProduct(ByVal anEntry As ProductData, Optional updateMode As Boolean = False, Optional productFormRef As ProductForm = Nothing) As Task

        Dim client As HttpClient = New HttpClient

        Dim endResult As String
        Dim arrayList As New ArrayList

        ' parse the string
        Try

            Dim stringPayload As String = JsonConvert.SerializeObject(anEntry)
            Dim content As StringContent = New StringContent(stringPayload, Encoding.UTF8, "application/json")

            ' we are escaping the limit exceed by converting into json object
            ' Dim values As New Dictionary(Of String, String)

            'If (updateMode = True) Then
            ' values.Add("id", anEntry.Id)
            ' values.Add("data", WebUtility.UrlEncode(stringPayload))
            'End If

            'Dim content As FormUrlEncodedContent = New FormUrlEncodedContent(values)

            Dim urlTarget As String

            If (updateMode = True) Then
                urlTarget = constructURL("product", "update")
            Else
                urlTarget = constructURL("product", "add")
            End If

            Dim dataResponse As HttpResponseMessage = Await client.PostAsync(urlTarget, content)

            endResult = Await dataResponse.Content.ReadAsStringAsync()

            Dim dataIn As JObject = JsonConvert.DeserializeObject(endResult)

            If (dataIn IsNot Nothing) Then

                If (isValidStatus(dataIn) = True) Then

                    If (updateMode) Then
                        MyForm.showProgress(STATE_SUCCESS, "data is successfully updated!")
                    Else
                        MyForm.showProgress(STATE_SUCCESS, "data is successfully saved!")
                    End If

                    ' refresh back the product table
                    ' and show the last row or 
                    ' show the updated row only
                    If (updateMode) Then
                        getAllProduct(False, anEntry.id)
                    Else
                        getAllProduct(True)
                    End If


                    ' close the active form
                    If (productFormRef IsNot Nothing) Then
                        productFormRef.Dispose()
                    End If


                Else
                    ' when error
                    MyForm.showProgress(MyForm.STATE_ERROR, "Error Saving product data!")

                End If

            End If

            client.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error on #462 " & ex.Message)
            ErrorLogger.write(ex.Message & "\n" & ex.StackTrace)
        End Try

    End Function

    Async Function saveSchedule(ByVal anEntry As ScheduleData, Optional updateMode As Boolean = False, Optional scheduleFormRef As ScheduleForm = Nothing) As Task

        Dim client As HttpClient = New HttpClient

        Dim endResult As String


        ' parse the string
        Try

            ' we are escaping the limit exceed by converting into json object
            ' Dim stringPayload As String = JsonConvert.SerializeObject(anEntry)
            ' Dim content As StringContent = New StringContent(stringPayload, Encoding.UTF8, "application/json")

            Dim values As New Dictionary(Of String, String)

            ' If (updateMode = True) Then
            values.Add("id", anEntry.id)
            values.Add("patient_id", anEntry.patient_id)
            values.Add("status", anEntry.status)
            values.Add("username", WebUtility.UrlEncode(anEntry.username))
            values.Add("date_choosen", WebUtility.UrlEncode(anEntry.date_choosen))
            values.Add("keluhan", WebUtility.UrlEncode(anEntry.keluhan))
            values.Add("treatment", WebUtility.UrlEncode(anEntry.treatment))
            'End If

            Dim content As FormUrlEncodedContent = New FormUrlEncodedContent(values)

            Dim urlTarget As String

            If (updateMode = True) Then
                urlTarget = constructURL("request", "schedule/update")
            Else
                urlTarget = constructURL("request", "schedule/add")
            End If

            Dim dataResponse As HttpResponseMessage = Await client.PostAsync(urlTarget, content)

            endResult = Await dataResponse.Content.ReadAsStringAsync()

            Dim dataIn As JObject = JsonConvert.DeserializeObject(endResult)

            If (dataIn IsNot Nothing) Then

                If (isValidStatus(dataIn) = True) Then

                    If (updateMode) Then
                        MyForm.showProgress(STATE_SUCCESS, "data is successfully updated!")
                    Else
                        MyForm.showProgress(STATE_SUCCESS, "data is successfully saved!")
                    End If

                    ' refresh back the schedule main table
                    getAllSchedule()

                    ' close the active form
                    If (scheduleFormRef IsNot Nothing) Then
                        scheduleFormRef.Dispose()
                    End If

                Else
                    ' when error
                    MyForm.showProgress(MyForm.STATE_ERROR, "Error Saving Request Schedule data!")

                End If

            End If

            client.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error on #654 " & ex.Message)
            ErrorLogger.write(ex.Message & "\n" & ex.StackTrace)
        End Try

    End Function

    Async Function saveOrder(ByVal aMainArray As ArrayList, invoiceCode As String, paymentMode As String, Optional updateMode As Boolean = False) As Task

        Dim client As HttpClient = New HttpClient

        Dim endResult As String
        Dim arrayList As New ArrayList

        ' parse the string
        Try

            Dim stringPayload As String = JsonConvert.SerializeObject(aMainArray)
            Dim content As StringContent = New StringContent(stringPayload, Encoding.UTF8, "application/json")

            ' we are escaping the limit exceed by converting into json object
            ' Dim values As New Dictionary(Of String, String)

            'If (updateMode = True) Then
            ' values.Add("id", anEntry.Id)
            ' values.Add("data", WebUtility.UrlEncode(stringPayload))
            'End If

            'Dim content As FormUrlEncodedContent = New FormUrlEncodedContent(values)

            Dim urlTarget As String

            If (updateMode = True) Then
                urlTarget = constructURL("product", "update")
            Else
                urlTarget = constructURL("product", "add")
            End If

            Dim dataResponse As HttpResponseMessage = Await client.PostAsync(urlTarget, content)

            endResult = Await dataResponse.Content.ReadAsStringAsync()

            Dim dataIn As JObject = JsonConvert.DeserializeObject(endResult)

            If (dataIn IsNot Nothing) Then

                If (isValidStatus(dataIn) = True) Then

                    If (updateMode) Then
                        MyForm.showProgress(STATE_SUCCESS, "data is successfully updated!")
                    Else
                        MyForm.showProgress(STATE_SUCCESS, "data is successfully saved!")
                    End If

                    ' refresh back the product table
                    ' and show the last row or 
                    ' show the updated row only



                Else
                    ' when error
                    MyForm.showProgress(MyForm.STATE_ERROR, "Error Saving Order data!")

                End If

            End If

            client.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error on #644 " & ex.Message)
            ErrorLogger.write(ex.Message & "\n" & ex.StackTrace)
        End Try

    End Function

    Async Function saveUser(ByVal anEntry As UserData, Optional updateMode As Boolean = False) As Task

        Dim client As HttpClient = New HttpClient

        Dim endResult As String
        Dim arrayList As New ArrayList
        ' parse the string
        Try

            Dim stringPayload As String = JsonConvert.SerializeObject(anEntry)
            Dim content As StringContent = New StringContent(stringPayload, Encoding.UTF8, "application/json")

            ' we are escaping the limit exceed by converting into json object
            ' Dim values As New Dictionary(Of String, String)

            'If (updateMode = True) Then
            ' values.Add("id", anEntry.Id)
            ' values.Add("data", WebUtility.UrlEncode(stringPayload))
            'End If



            'Dim content As FormUrlEncodedContent = New FormUrlEncodedContent(values)

            Dim urlTarget As String

            If (updateMode = True) Then
                urlTarget = constructURL("user", "update")
            Else
                urlTarget = constructURL("user", "register")
            End If

            Dim dataResponse As HttpResponseMessage = Await client.PostAsync(urlTarget, content)

            endResult = Await dataResponse.Content.ReadAsStringAsync()

            Dim dataIn As JObject = JsonConvert.DeserializeObject(endResult)

            If (dataIn IsNot Nothing) Then

                If (isValidStatus(dataIn) = True) Then

                    MyForm.showProgress(STATE_SUCCESS, "saving data is success!")

                    ' turned off code below
                    ' already replaced by MyForm.showProgress() function !

                    'PanelRef.ProgressFormLabel.Visible = True
                    'PanelRef.ProgressFormLabel.Image.Dispose()
                    'PanelRef.ProgressFormLabel.Image = Global.RKMedisCustomizedRTH.My.Resources.Resources.ok
                    'PanelRef.ProgressFormLabel.Text = "                   "


                    ' refresh back the user table
                    ' and show the last row
                    getAllUser(Nothing, True)

                End If

            End If

            client.Dispose()
        Catch ex As Exception
            'MessageBox.Show("Error on #89 " & ex.Message & "\n" & endResult)
            MessageBox.Show("Error on #200 " & ex.Message)
            ErrorLogger.write(ex.Message & "\n" & ex.StackTrace)
        End Try

    End Function

    Async Function getAllUser(ByVal Optional aCombobox As ComboBox = Nothing, Optional showLastRow As Boolean = False, Optional idRowSelected As Integer = -1) As Task

        Dim client As HttpClient = New HttpClient

        If (aCombobox IsNot Nothing) Then
            aCombobox.Items.Clear()
            ' empty default first item
            aCombobox.Items.Add("-")
        End If
        Dim arrayList As New ArrayList

        Dim values As New Dictionary(Of String, String)
        'values.Add("email",)

        Dim content As FormUrlEncodedContent = New FormUrlEncodedContent(values)

        Dim endResult As String
        Dim urlTarget As String = constructURL("user", "all")
        Dim dataResponse As HttpResponseMessage = Await client.PostAsync(urlTarget, content)

        endResult = Await dataResponse.Content.ReadAsStringAsync()

        ' parse the string
        Try

            Dim dataIn As JObject = JsonConvert.DeserializeObject(endResult)

            If (dataIn IsNot Nothing) Then

                If (isValidStatus(dataIn) = True) Then
                    ' parse the multi_data as array
                    Dim dataMulti As String = dataIn.GetValue("multi_data").ToString
                    Dim deretanData As UserData() = JsonConvert.DeserializeObject(Of UserData())(dataMulti)

                    If (deretanData IsNot Nothing) Then


                        For Each dataSatuan As UserData In deretanData
                            arrayList.Add(dataSatuan)

                            If (aCombobox IsNot Nothing) Then
                                aCombobox.Items.Add(dataSatuan.username)
                            End If

                        Next




                    End If

                End If

                'updating the datagridview table
                TableHelper.refreshTableUser(arrayList)
                If (showLastRow = True) Then
                    TableHelper.showLastRowTableUser()
                ElseIf (idRowSelected <> -1) Then
                    ' show selected row
                    TableHelper.showRowTableUser(idRowSelected)
                End If



            End If

            client.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error on #267 " & ex.Message)
            ErrorLogger.write(ex.Message & "\n" & ex.StackTrace)
        End Try



    End Function

    Async Function getAllPatient() As Task

        Dim client As HttpClient = New HttpClient

        Dim arrayList As New ArrayList

        Dim values As New Dictionary(Of String, String)
        'values.Add("email",)

        Dim content As FormUrlEncodedContent = New FormUrlEncodedContent(values)

        Dim endResult As String
        Dim urlTarget As String = constructURL("patient", "all")
        Dim dataResponse As HttpResponseMessage = Await client.PostAsync(urlTarget, content)

        endResult = Await dataResponse.Content.ReadAsStringAsync()

        ' parse the string
        Try

            Dim dataIn As JObject = JsonConvert.DeserializeObject(endResult)

            If (dataIn IsNot Nothing) Then

                If (isValidStatus(dataIn) = True) Then
                    ' parse the multi_data as array
                    Dim dataMulti As String = dataIn.GetValue("multi_data").ToString
                    Dim deretanData As PatientData() = JsonConvert.DeserializeObject(Of PatientData())(dataMulti)

                    If (deretanData IsNot Nothing) Then

                        For Each dataSatuan As PatientData In deretanData
                            arrayList.Add(dataSatuan)
                        Next



                    End If

                End If

                'updating the datagridview table
                TableHelper.refreshTablePatient(arrayList)

            End If

            client.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error on #324 " & ex.Message)
            ErrorLogger.write(ex.Message & "\n" & ex.StackTrace)
        End Try



    End Function


    Async Function getAllSchedule() As Task

        Dim client As HttpClient = New HttpClient

        Dim arrayList As New ArrayList

        Dim values As New Dictionary(Of String, String)
        'values.Add("email",)

        Dim content As FormUrlEncodedContent = New FormUrlEncodedContent(values)

        Dim endResult As String
        Dim urlTarget As String = constructURL("request", "schedule/all")
        Dim dataResponse As HttpResponseMessage = Await client.PostAsync(urlTarget, content)

        endResult = Await dataResponse.Content.ReadAsStringAsync()

        ' parse the string
        Try

            Dim dataIn As JObject = JsonConvert.DeserializeObject(endResult)

            If (dataIn IsNot Nothing) Then

                If (isValidStatus(dataIn) = True) Then
                    ' parse the multi_data as array
                    Dim dataMulti As String = dataIn.GetValue("multi_data").ToString
                    Dim deretanData As ScheduleData() = JsonConvert.DeserializeObject(Of ScheduleData())(dataMulti)

                    If (deretanData IsNot Nothing) Then

                        For Each dataSatuan As ScheduleData In deretanData
                            arrayList.Add(dataSatuan)
                        Next



                    End If

                End If

                'updating the datagridview table
                TableHelper.refreshTableSchedule(arrayList)

            End If

            client.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error on #976 " & ex.Message)
            ErrorLogger.write(ex.Message & "\n" & ex.StackTrace)
        End Try



    End Function

    Async Function getAllPatientByUsername(ByVal usernamePatokan As String, checkedList As CheckedListBox, Optional patientID As Integer = -1) As Task

        Dim client As HttpClient = New HttpClient

        Dim arrayList As New ArrayList

        Dim values As New Dictionary(Of String, String)
        values.Add("username", usernamePatokan)

        Dim content As FormUrlEncodedContent = New FormUrlEncodedContent(values)

        Dim endResult As String
        Dim urlTarget As String = constructURL("patient", "all")
        Dim dataResponse As HttpResponseMessage = Await client.PostAsync(urlTarget, content)

        endResult = Await dataResponse.Content.ReadAsStringAsync()

        ' parse the string
        Try

            Dim dataIn As JObject = JsonConvert.DeserializeObject(endResult)

            If (dataIn IsNot Nothing) Then

                If (isValidStatus(dataIn) = True) Then
                    ' parse the multi_data as array
                    Dim dataMulti As String = dataIn.GetValue("multi_data").ToString
                    Dim deretanData As PatientData() = JsonConvert.DeserializeObject(Of PatientData())(dataMulti)

                    If (deretanData IsNot Nothing) Then

                        ' clear data first before adding in some more values
                        checkedList.Items.Clear()

                        For Each dataSatuan As PatientData In deretanData
                            ' last output should be :
                            ' [id] - username
                            ' i.e for example :
                            ' [10] - general
                            Dim dataText As String = "[" & dataSatuan.id & "]" & " - " & dataSatuan.full_name

                            ' if the function call using a patientID written specifically
                            If (patientID <> -1 And dataSatuan.id = patientID) Then
                                checkedList.Items.Add(dataText, True)
                            Else
                                checkedList.Items.Add(dataText)
                            End If

                        Next

                    End If

                End If

            End If

            client.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error on #898 " & ex.Message)
            ErrorLogger.write(ex.Message & "\n" & ex.StackTrace)
        End Try



    End Function

    Async Function getAllProductCategory(ByVal aCombobox As ComboBox) As Task

        Dim client As HttpClient = New HttpClient

        Dim arrayList As New ArrayList

        Dim values As New Dictionary(Of String, String)
        'values.Add("email",)

        Dim content As FormUrlEncodedContent = New FormUrlEncodedContent(values)

        Dim endResult As String
        Dim urlTarget As String = constructURL("product", "category/all")
        Dim dataResponse As HttpResponseMessage = Await client.PostAsync(urlTarget, content)

        endResult = Await dataResponse.Content.ReadAsStringAsync()

        ' parse the string
        Try

            Dim dataIn As JObject = JsonConvert.DeserializeObject(endResult)

            If (dataIn IsNot Nothing) Then

                If (isValidStatus(dataIn) = True) Then
                    ' parse the multi_data as array
                    Dim dataMulti As String = dataIn.GetValue("multi_data").ToString
                    Dim deretanData As ProductCategoryData() = JsonConvert.DeserializeObject(Of ProductCategoryData())(dataMulti)

                    If (deretanData IsNot Nothing) Then

                        For Each dataSatuan As ProductCategoryData In deretanData
                            'arrayList.Add(dataSatuan)
                            aCombobox.Items.Add(dataSatuan.name)
                        Next



                    End If

                End If

                'updating the combobox


            End If

            client.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error on #725 " & ex.Message)
            ErrorLogger.write(ex.Message & "\n" & ex.StackTrace)
        End Try

    End Function

    Async Function getAllProductUnit(ByVal aCombobox As ComboBox) As Task

        Dim client As HttpClient = New HttpClient

        Dim arrayList As New ArrayList

        Dim values As New Dictionary(Of String, String)
        'values.Add("email",)

        Dim content As FormUrlEncodedContent = New FormUrlEncodedContent(values)

        Dim endResult As String
        Dim urlTarget As String = constructURL("product", "unit/all")
        Dim dataResponse As HttpResponseMessage = Await client.PostAsync(urlTarget, content)

        endResult = Await dataResponse.Content.ReadAsStringAsync()

        ' parse the string
        Try

            Dim dataIn As JObject = JsonConvert.DeserializeObject(endResult)

            If (dataIn IsNot Nothing) Then

                If (isValidStatus(dataIn) = True) Then
                    ' parse the multi_data as array
                    Dim dataMulti As String = dataIn.GetValue("multi_data").ToString
                    Dim deretanData As ProductUnitData() = JsonConvert.DeserializeObject(Of ProductUnitData())(dataMulti)

                    If (deretanData IsNot Nothing) Then

                        For Each dataSatuan As ProductUnitData In deretanData
                            'updating the combobox
                            'arrayList.Add(dataSatuan)
                            aCombobox.Items.Add(dataSatuan.name)
                        Next



                    End If

                End If




            End If

            client.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error on #781 " & ex.Message)
            ErrorLogger.write(ex.Message & "\n" & ex.StackTrace)
        End Try

    End Function

    Async Function getAllOrder(ByVal Optional showLastRow As Boolean = False, Optional idRowSelected As Integer = -1) As Task

        Dim client As HttpClient = New HttpClient

        Dim arrayList As New ArrayList

        Dim values As New Dictionary(Of String, String)
        ' values.Add("email",xxx)

        Dim content As FormUrlEncodedContent = New FormUrlEncodedContent(values)

        Dim endResult As String
        Dim urlTarget As String = constructURL("order", "all")
        Dim dataResponse As HttpResponseMessage = Await client.PostAsync(urlTarget, content)

        endResult = Await dataResponse.Content.ReadAsStringAsync()

        ' parse the string
        Try

            Dim dataIn As JObject = JsonConvert.DeserializeObject(endResult)

            If (dataIn IsNot Nothing) Then

                If (isValidStatus(dataIn) = True) Then
                    ' parse the multi_data as array
                    Dim dataMulti As String = dataIn.GetValue("multi_data").ToString
                    Dim deretanData As OrderData() = JsonConvert.DeserializeObject(Of OrderData())(dataMulti)

                    If (deretanData IsNot Nothing) Then

                        For Each dataSatuan As OrderData In deretanData
                            arrayList.Add(dataSatuan)
                        Next

                    End If

                End If

                ' updating the datagridview table
                TableHelper.refreshTableOrder(arrayList)
                If (showLastRow = True) Then
                    TableHelper.showLastRowTableOrder()
                ElseIf (idRowSelected <> -1) Then
                    ' show selected row
                    TableHelper.showRowTableOrder(idRowSelected)
                End If

            End If

            client.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error on #859 " & ex.Message)
            ErrorLogger.write(ex.Message & "\n" & ex.StackTrace)
        End Try

    End Function

    Async Function getAllOrderItems(ByVal noInvoice As String) As Task

        Dim client As HttpClient = New HttpClient

        Dim arrayList As New ArrayList

        Dim values As New Dictionary(Of String, String)
        values.Add("invoice_code", noInvoice)

        Dim content As FormUrlEncodedContent = New FormUrlEncodedContent(values)

        Dim endResult As String
        Dim urlTarget As String = constructURL("order", "all")
        Dim dataResponse As HttpResponseMessage = Await client.PostAsync(urlTarget, content)

        endResult = Await dataResponse.Content.ReadAsStringAsync()

        ' parse the string
        Try

            Dim dataIn As JObject = JsonConvert.DeserializeObject(endResult)

            If (dataIn IsNot Nothing) Then

                If (isValidStatus(dataIn) = True) Then
                    ' parse the multi_data as array
                    Dim dataMulti As String = dataIn.GetValue("multi_data").ToString
                    Dim deretanData As OrderData() = JsonConvert.DeserializeObject(Of OrderData())(dataMulti)

                    If (deretanData IsNot Nothing) Then

                        For Each dataSatuan As OrderData In deretanData
                            arrayList.Add(dataSatuan)
                        Next

                    End If

                End If

                ' updating the datagridview table
                TableHelper.refreshTableOrderItem(arrayList)


            End If

            client.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error on #999 " & ex.Message)
            ErrorLogger.write(ex.Message & "\n" & ex.StackTrace)
        End Try

    End Function

    Async Function getAllProduct(ByVal Optional showLastRow As Boolean = False, Optional idRowSelected As Integer = -1) As Task

        Dim client As HttpClient = New HttpClient

        Dim arrayList As New ArrayList

        Dim values As New Dictionary(Of String, String)
        'values.Add("email",)

        Dim content As FormUrlEncodedContent = New FormUrlEncodedContent(values)

        Dim endResult As String
        Dim urlTarget As String = constructURL("product", "all")
        Dim dataResponse As HttpResponseMessage = Await client.PostAsync(urlTarget, content)

        endResult = Await dataResponse.Content.ReadAsStringAsync()

        ' parse the string
        Try

            Dim dataIn As JObject = JsonConvert.DeserializeObject(endResult)

            If (dataIn IsNot Nothing) Then

                If (isValidStatus(dataIn) = True) Then
                    ' parse the multi_data as array
                    Dim dataMulti As String = dataIn.GetValue("multi_data").ToString
                    Dim deretanData As ProductData() = JsonConvert.DeserializeObject(Of ProductData())(dataMulti)

                    If (deretanData IsNot Nothing) Then

                        For Each dataSatuan As ProductData In deretanData
                            arrayList.Add(dataSatuan)
                        Next



                    End If

                End If

                'updating the datagridview table
                TableHelper.refreshTableProduct(arrayList)
                If (showLastRow = True) Then
                    TableHelper.showLastRowTableProduct()
                ElseIf (idRowSelected <> -1) Then
                    ' show selected row
                    TableHelper.showRowTableProduct(idRowSelected)
                End If


            End If

            client.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error on #546 " & ex.Message)
            ErrorLogger.write(ex.Message & "\n" & ex.StackTrace)
        End Try

    End Function

    ' getAllProducts with 's ending is for ProductCatalog Frame usage only
    Async Function getAllProducts() As Task

        Dim client As HttpClient = New HttpClient

        Dim arrayList As New ArrayList

        Dim values As New Dictionary(Of String, String)
        'values.Add("email",)

        Dim content As FormUrlEncodedContent = New FormUrlEncodedContent(values)

        Dim endResult As String
        Dim urlTarget As String = constructURL("product", "all")
        Dim dataResponse As HttpResponseMessage = Await client.PostAsync(urlTarget, content)

        endResult = Await dataResponse.Content.ReadAsStringAsync()

        ' parse the string
        Try

            Dim dataIn As JObject = JsonConvert.DeserializeObject(endResult)

            If (dataIn IsNot Nothing) Then

                If (isValidStatus(dataIn) = True) Then
                    ' parse the multi_data as array
                    Dim dataMulti As String = dataIn.GetValue("multi_data").ToString
                    Dim deretanData As ProductData() = JsonConvert.DeserializeObject(Of ProductData())(dataMulti)

                    If (deretanData IsNot Nothing) Then

                        For Each dataSatuan As ProductData In deretanData
                            arrayList.Add(dataSatuan)
                        Next


                    End If

                End If

                'updating the datagridview table
                TableHelper.refreshTableProductCatalog(arrayList)


            End If

            client.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error on #1114 " & ex.Message)
            ErrorLogger.write(ex.Message & "\n" & ex.StackTrace)
        End Try

    End Function

    Async Function getAllMedicalRecords(ByVal anID As Integer) As Task(Of ArrayList)

        Dim client As HttpClient = New HttpClient

        Dim arrayList As New ArrayList

        Dim values As New Dictionary(Of String, String)
        values.Add("patient_id", anID)

        Dim content As FormUrlEncodedContent = New FormUrlEncodedContent(values)

        Dim endResult As String
        Dim urlTarget As String = constructURL("patient", "record/all")
        Dim dataResponse As HttpResponseMessage = Await client.PostAsync(urlTarget, content)

        endResult = Await dataResponse.Content.ReadAsStringAsync()

        ' parse the string
        Try

            Dim dataIn As JObject = JsonConvert.DeserializeObject(endResult)

            If (dataIn IsNot Nothing) Then

                If (isValidStatus(dataIn) = True) Then
                    ' parse the multi_data as array
                    Dim dataMulti As String = dataIn.GetValue("multi_data").ToString

                    Dim dataMultiJSON As JArray = JsonConvert.DeserializeObject(dataMulti)

                    If (dataMultiJSON IsNot Nothing) Then

                        Dim dataMain As MainHistoryRecord = JsonConvert.DeserializeObject(Of MainHistoryRecord)(dataMultiJSON.Item(0).ToString)
                        Dim dataSecond As SecondHistoryRecord = JsonConvert.DeserializeObject(Of SecondHistoryRecord)(dataMultiJSON.Item(1).ToString)

                        'MessageBox.Show(dataMultiJSON.Item(1).ToString)
                        arrayList.Add(dataMain)
                        arrayList.Add(dataSecond)

                    End If

                End If

            End If

            client.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error on #414 " & ex.Message)
            ErrorLogger.write(ex.Message & "\n" & ex.StackTrace)
        End Try

        Return arrayList


    End Function

End Module
