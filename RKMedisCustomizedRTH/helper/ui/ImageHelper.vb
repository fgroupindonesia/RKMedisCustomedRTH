Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Net.Http

Module ImageHelper

    Public Function resizeImage(ByVal newWidth As Integer, ByVal newHeight As Integer, ByVal imgPhoto As Image) As Image
        Dim sourceWidth As Integer = imgPhoto.Width
        Dim sourceHeight As Integer = imgPhoto.Height
        Dim sourceX As Integer = 0
        Dim sourceY As Integer = 0
        Dim destX As Integer = 0
        Dim destY As Integer = 0
        Dim nPercent As Single = 0
        Dim nPercentW As Single = 0
        Dim nPercentH As Single = 0
        nPercentW = (CType(newWidth, Single) / CType(sourceWidth, Single))
        nPercentH = (CType(newHeight, Single) / CType(sourceHeight, Single))
        If (nPercentH < nPercentW) Then
            nPercent = nPercentH
            destX = System.Convert.ToInt16(((newWidth _
                    - (sourceWidth * nPercent)) _
                    / 2))
        Else
            nPercent = nPercentW
            destY = System.Convert.ToInt16(((newHeight _
                    - (sourceHeight * nPercent)) _
                    / 2))
        End If

        Dim destWidth As Integer = CType((sourceWidth * nPercent), Integer)
        Dim destHeight As Integer = CType((sourceHeight * nPercent), Integer)
        Dim bmPhoto As Bitmap = New Bitmap(newWidth, newHeight, PixelFormat.Format24bppRgb)
        bmPhoto.SetResolution(imgPhoto.HorizontalResolution, imgPhoto.VerticalResolution)
        Dim grPhoto As Graphics = Graphics.FromImage(bmPhoto)
        grPhoto.Clear(Color.Transparent)
        grPhoto.InterpolationMode = InterpolationMode.HighQualityBicubic
        grPhoto.DrawImage(imgPhoto, New Rectangle(destX, destY, destWidth, destHeight), New Rectangle(sourceX, sourceY, sourceWidth, sourceHeight), GraphicsUnit.Pixel)
        grPhoto.Dispose()

        imgPhoto.Dispose()
        Return bmPhoto
    End Function

    Public Function ImageToBase64(ByVal image As Image, ByVal format As System.Drawing.Imaging.ImageFormat) As String
        Using ms As New MemoryStream()
            ' Convert Image to byte[]
            image.Save(ms, format)

            Dim imageBytes As Byte() = ms.ToArray() ' Convert byte[] to Base64 String
            Dim base64String As String = Convert.ToBase64String(imageBytes)
            Return base64String
        End Using
    End Function

    Public Function Base64ToImage(ByVal base64String As String) As Image
        ' Convert Base64 String to byte[]
        Dim imageBytes As Byte() = Convert.FromBase64String(base64String)
        Dim ms As New MemoryStream(imageBytes, 0, imageBytes.Length)

        ' Convert byte[] to Image
        ms.Write(imageBytes, 0, imageBytes.Length)
        Dim ConvertedBase64Image As Image = Image.FromStream(ms, True)
        Return ConvertedBase64Image
    End Function

    Public Function FormatSize(ByVal bytes As Int64) As String

        Dim kilobytes As Double = (bytes / 1024)
        Dim megabytes As Double = (kilobytes / 1024)
        Dim gigabytes As Double = (megabytes / 1024)

        Return String.Format("{0:n1}{1}", kilobytes, "Kb")
    End Function


    Public Function byteArrayToImage(ByVal byteArrayIn() As Byte) As Image
        Dim ms As MemoryStream = New MemoryStream(byteArrayIn)
        Dim returnImage As Image = Image.FromStream(ms)
        Return returnImage
    End Function

    Public Async Function getDefaultAppLogo() As Task

        Dim client As HttpClient = New HttpClient

        Dim values As New Dictionary(Of String, String)
        'values.Add("username", aUsername)

        Dim content As FormUrlEncodedContent = New FormUrlEncodedContent(values)

        Dim endResult As String
        Dim urlTarget As String = constructURL("system", "logo/download")
        Dim dataResponse As HttpResponseMessage = Await client.PostAsync(urlTarget, content)

        ' Check that response was successful or throw exception
        dataResponse.EnsureSuccessStatusCode()

        Dim tempFilename = "\\default_logo.png"

        If (Directory.Exists(AppPath.getLokasiImageLocal) = False) Then
            Directory.CreateDirectory(AppPath.getLokasiImageLocal)
        End If

        Try

            ' Read response asynchronously and save asynchronously to file
            Using fileStream As FileStream = New FileStream((AppPath.getLokasiImageLocal + tempFilename), FileMode.Create, FileAccess.Write, FileShare.None)
                Await dataResponse.Content.CopyToAsync(fileStream)
            End Using

            'once done we render to the picture box
            Dim tempImage As Image = Image.FromFile(AppPath.getLokasiImageLocal + tempFilename)
            Dim bmp As New Bitmap(tempImage)

            Dim fi As FileInfo = New FileInfo(AppPath.getLokasiImageLocal + tempFilename)
            Dim sizeFile As Long = fi.Length

            ' updating the detail
            ' PanelRef.FileNamePicturePreviewLabel.Text = "File Name : " & tempFilename.Replace("\\", "")
            PanelRef.FileSizePicturePreviewLabel.Text = "File Size : " & FormatSize(sizeFile)

            PanelRef.PreviewPicturebox.Image.Dispose()
            PanelRef.PreviewPicturebox.Image = bmp

            client.Dispose()

        Catch ex As Exception
            MessageBox.Show("Error #126 " & ex.Message)
        End Try

    End Function

End Module
