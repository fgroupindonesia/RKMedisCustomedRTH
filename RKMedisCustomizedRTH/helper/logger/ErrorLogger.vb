Imports System.Environment
Imports System.IO

Module ErrorLogger

    Sub write(ByVal message As String)
        Dim folderAppName = GetFolderPath(SpecialFolder.ApplicationData) & "\\RK-Medis"
        Dim lokasiLog As String = folderAppName & "\\error.log"

        Using sw As New StreamWriter(File.Open(lokasiLog, FileMode.Append))
            sw.WriteLine(DateTime.Now)
            sw.WriteLine(message)
        End Using

    End Sub

End Module
