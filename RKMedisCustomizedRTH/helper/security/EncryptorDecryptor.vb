Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Module EncryptorDecryptor

    Dim message As String = "wordMaychangedHere"
    ' this password will same as server (apiclient domain encryptor decryptor)
    Dim password As String = "fgroupindonesia.com"
    Dim mySHA256 As SHA256 = SHA256Managed.Create
    Dim key() As Byte = mySHA256.ComputeHash(Encoding.ASCII.GetBytes(password))
    Dim iv() As Byte = New Byte() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}

    Public Function EncryptString(ByVal plainText As String) As String

        ' Instantiate a new Aes object to perform string symmetric encryption
        Dim encryptor As Aes = Aes.Create
        encryptor.Mode = CipherMode.CBC
        ' Set key and IV
        Dim aesKey() As Byte = New Byte((32) - 1) {}
        Array.Copy(key, 0, aesKey, 0, 32)
        encryptor.Key = aesKey
        encryptor.IV = iv
        ' Instantiate a new MemoryStream object to contain the encrypted bytes
        Dim memoryStream As MemoryStream = New MemoryStream
        ' Instantiate a new encryptor from our Aes object
        Dim aesEncryptor As ICryptoTransform = encryptor.CreateEncryptor
        ' Instantiate a new CryptoStream object to process the data and write it to the 
        ' memory stream
        Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, aesEncryptor, CryptoStreamMode.Write)
        ' Convert the plainText string into a byte array
        Dim plainBytes() As Byte = Encoding.ASCII.GetBytes(plainText)
        ' Encrypt the input plaintext string
        cryptoStream.Write(plainBytes, 0, plainBytes.Length)
        ' Complete the encryption process
        cryptoStream.FlushFinalBlock()
        ' Convert the encrypted data from a MemoryStream to a byte array
        Dim cipherBytes() As Byte = memoryStream.ToArray
        ' Close both the MemoryStream and the CryptoStream
        memoryStream.Close()
        cryptoStream.Close()
        ' Convert the encrypted byte array to a base64 encoded string
        Dim cipherText As String = Convert.ToBase64String(cipherBytes, 0, cipherBytes.Length)
        ' Return the encrypted data as a string
        Return cipherText
    End Function

    Public Function DecryptString(ByVal cipherText As String) As String
        ' Instantiate a new Aes object to perform string symmetric encryption
        Dim encryptor As Aes = Aes.Create
        encryptor.Mode = CipherMode.CBC
        ' Set key and IV
        Dim aesKey() As Byte = New Byte((32) - 1) {}
        Array.Copy(key, 0, aesKey, 0, 32)
        encryptor.Key = aesKey
        encryptor.IV = iv
        ' Instantiate a new MemoryStream object to contain the encrypted bytes
        Dim memoryStream As MemoryStream = New MemoryStream
        ' Instantiate a new encryptor from our Aes object
        Dim aesDecryptor As ICryptoTransform = encryptor.CreateDecryptor
        ' Instantiate a new CryptoStream object to process the data and write it to the 
        ' memory stream
        Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, aesDecryptor, CryptoStreamMode.Write)
        ' Will contain decrypted plaintext
        Dim plainText As String = String.Empty
        Try
            ' Convert the ciphertext string into a byte array
            Dim cipherBytes() As Byte = Convert.FromBase64String(cipherText)
            ' Decrypt the input ciphertext string
            cryptoStream.Write(cipherBytes, 0, cipherBytes.Length)
            ' Complete the decryption process
            cryptoStream.FlushFinalBlock()
            ' Convert the decrypted data from a MemoryStream to a byte array
            Dim plainBytes() As Byte = memoryStream.ToArray
            ' Convert the decrypted byte array to string
            plainText = Encoding.ASCII.GetString(plainBytes, 0, plainBytes.Length)
        Finally
            ' Close both the MemoryStream and the CryptoStream
            memoryStream.Close()
            cryptoStream.Close()
        End Try

        ' Return the decrypted data as a string
        Return plainText
    End Function

End Module
