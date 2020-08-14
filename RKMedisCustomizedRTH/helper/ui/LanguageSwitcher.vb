Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Module LanguageSwitcher

    Dim dataJSON As JObject
    Dim langJSONFile As String = "\\en.json"

    Sub readFromFile()
        dataJSON = JsonConvert.DeserializeObject(File.ReadAllText(AppPath.getLokasiLanguage(langJSONFile)))
    End Sub

    Sub applyUI(ByVal labelVersion As Label)
        labelVersion.Text = dataJSON.GetValue("LabelVersionApp")
        'continue
    End Sub

End Module
