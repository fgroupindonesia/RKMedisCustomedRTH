Imports System.Environment

Module AppPath
    Dim folderAppName = GetFolderPath(SpecialFolder.ApplicationData) & "\\RK-Medis"
    Dim lokasiImageLocal As String = folderAppName & "\\images"
    Dim lokasiLanguage As String = folderAppName & "\\language"

    Function getLokasiAppLocal() As String
        Return folderAppName
    End Function

    Function getLokasiImageLocal() As String
        Return lokasiImageLocal
    End Function

    Function getLokasiLanguage() As String
        Return lokasiLanguage
    End Function

    Function getLokasiLanguage(ByVal filename As String) As String
        Return lokasiLanguage & filename
    End Function

End Module
