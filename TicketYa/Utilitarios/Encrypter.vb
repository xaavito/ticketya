﻿Imports System.Security.Cryptography

Public Class Encrypter


    Private Shared m_strPassPhrase As String = "MyPriv@Password!$$"    '---- any text string is good here
    Private Shared m_strHashAlgorithm As String = "MD5"                '--- we are doing MD5 encryption - can be "SHA1"
    Private Shared m_strPasswordIterations As Integer = 2              '--- can be any number
    Private Shared m_strInitVector As String = "@1B2c3D4e5F6g7H8"      '--- must be 16 bytes
    Private Shared m_intKeySize As Integer = 256                       '--- can be 192 or 128
    Private Shared strSaltValue As String = "00000000"



    'Encrypt Function: 

    Public Shared Function EncryptPasswordMD5(ByVal plainText As String) As String

        Dim strReturn As String = String.Empty

        ' Convert strings into byte arrays.
        ' Let us assume that strings only contain ASCII codes.
        ' If strings include Unicode characters, use Unicode, UTF7, or UTF8 
        ' encoding.

        Try
            Dim initVectorBytes As Byte()
            initVectorBytes = System.Text.Encoding.ASCII.GetBytes(m_strInitVector)

            Dim saltValueBytes As Byte()
            saltValueBytes = System.Text.Encoding.ASCII.GetBytes(strSaltValue)

            ' Convert our plaintext into a byte array.
            ' Let us assume that plaintext contains UTF8-encoded characters.
            Dim plainTextBytes As Byte()
            plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText)

            ' First, we must create a password, from which the key will be derived.
            ' This password will be generated from the specified passphrase and 
            ' salt value. The password will be created using the specified hash 
            ' algorithm. Password creation can be done in several iterations.

            Dim password As Rfc2898DeriveBytes

            password = New Rfc2898DeriveBytes(m_strPassPhrase, _
                                          saltValueBytes, _
                                          m_strPasswordIterations)

            ' Use the password to generate pseudo-random bytes for the encryption
            ' key. Specify the size of the key in bytes (instead of bits).
            Dim keyBytes As Byte()
            Dim intKeySize As Integer = 0

            intKeySize = CType((m_intKeySize / 8), Integer)

            keyBytes = password.GetBytes(intKeySize)

            ' Create uninitialized Rijndael encryption object.
            Dim symmetricKey As System.Security.Cryptography.RijndaelManaged
            symmetricKey = New System.Security.Cryptography.RijndaelManaged

            ' It is reasonable to set encryption mode to Cipher Block Chaining
            ' (CBC). Use default options for other symmetric key parameters.
            symmetricKey.Mode = System.Security.Cryptography.CipherMode.CBC

            'symmetricKey.Padding = PaddingMode.Zeros


            ' Generate encryptor from the existing key bytes and initialization 
            ' vector. Key size will be defined based on the number of the key 
            ' bytes.
            Dim encryptor As System.Security.Cryptography.ICryptoTransform
            encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes)

            ' Define memory stream which will be used to hold encrypted data.
            Dim memoryStream As System.IO.MemoryStream
            memoryStream = New System.IO.MemoryStream

            ' Define cryptographic stream (always use Write mode for encryption).
            Dim cryptoStream As System.Security.Cryptography.CryptoStream
            cryptoStream = New System.Security.Cryptography.CryptoStream(memoryStream, _
                                            encryptor, _
                                            System.Security.Cryptography.CryptoStreamMode.Write)
            ' Start encrypting.
            cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length)

            ' Finish encrypting.
            cryptoStream.FlushFinalBlock()

            ' Convert our encrypted data from a memory stream into a byte array.
            Dim cipherTextBytes As Byte()
            cipherTextBytes = memoryStream.ToArray()

            ' Close both streams.
            memoryStream.Close()
            cryptoStream.Close()

            ' Convert encrypted data into a base64-encoded string.
            Dim cipherText As String
            cipherText = Convert.ToBase64String(cipherTextBytes)

            ' Return encrypted string.
            strReturn = cipherText

        Catch ex As Exception
            strReturn = Nothing
        End Try

        Return strReturn

    End Function




    'Decrypt Function: 

    Public Shared Function DecryptPasswordMD5(ByVal cipherText As String, ByVal p_strSaltValue As String) As String

        Dim strReturn As String = String.Empty

        ' Convert strings defining encryption key characteristics into byte
        ' arrays. Let us assume that strings only contain ASCII codes.
        ' If strings include Unicode characters, use Unicode, UTF7, or UTF8
        ' encoding.

        Try

            Dim initVectorBytes As Byte()
            initVectorBytes = System.Text.Encoding.ASCII.GetBytes(m_strInitVector)

            Dim saltValueBytes As Byte()
            saltValueBytes = System.Text.Encoding.ASCII.GetBytes(p_strSaltValue)

            ' Convert our ciphertext into a byte array.
            Dim cipherTextBytes As Byte()
            cipherTextBytes = Convert.FromBase64String(cipherText)

            ' First, we must create a password, from which the key will be 
            ' derived. This password will be generated from the specified 
            ' passphrase and salt value. The password will be created using
            ' the specified hash algorithm. Password creation can be done in
            ' several iterations.

            Dim password As Rfc2898DeriveBytes

            password = New Rfc2898DeriveBytes(m_strPassPhrase, _
                                            saltValueBytes, _
                                            m_strPasswordIterations)

            ' Use the password to generate pseudo-random bytes for the encryption
            ' key. Specify the size of the key in bytes (instead of bits).
            Dim keyBytes As Byte()
            Dim intKeySize As Integer

            intKeySize = CType((m_intKeySize / 8), Integer)

            keyBytes = password.GetBytes(intKeySize)

            ' Create uninitialized Rijndael encryption object.
            Dim symmetricKey As System.Security.Cryptography.RijndaelManaged
            symmetricKey = New System.Security.Cryptography.RijndaelManaged

            ' It is reasonable to set encryption mode to Cipher Block Chaining
            ' (CBC). Use default options for other symmetric key parameters.
            symmetricKey.Mode = System.Security.Cryptography.CipherMode.CBC

            'symmetricKey.Padding = PaddingMode.Zeros

            ' Generate decryptor from the existing key bytes and initialization 
            ' vector. Key size will be defined based on the number of the key 
            ' bytes.
            Dim decryptor As System.Security.Cryptography.ICryptoTransform
            decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes)

            ' Define memory stream which will be used to hold encrypted data.
            Dim memoryStream As System.IO.MemoryStream
            memoryStream = New System.IO.MemoryStream(cipherTextBytes)

            ' Define memory stream which will be used to hold encrypted data.
            Dim cryptoStream As System.Security.Cryptography.CryptoStream
            cryptoStream = New System.Security.Cryptography.CryptoStream(memoryStream, _
                                            decryptor, _
                                            System.Security.Cryptography.CryptoStreamMode.Read)

            ' Since at this point we don't know what the size of decrypted data
            ' will be, allocate the buffer long enough to hold ciphertext;
            ' plaintext is never longer than ciphertext.
            Dim plainTextBytes As Byte()
            ReDim plainTextBytes(cipherTextBytes.Length)

            ' Start decrypting.
            Dim decryptedByteCount As Integer
            decryptedByteCount = cryptoStream.Read(plainTextBytes, _
                                                0, _
                                                plainTextBytes.Length)

            ' Close both streams.
            memoryStream.Close()
            cryptoStream.Close()

            ' Convert decrypted data into a string. 
            ' Let us assume that the original plaintext string was UTF8-encoded.
            Dim plainText As String
            plainText = System.Text.Encoding.UTF8.GetString(plainTextBytes, _
                                                0, _
                                                decryptedByteCount)

            ' Return decrypted string.
            strReturn = plainText

        Catch ex As Exception
            strReturn = Nothing
        End Try

        Return strReturn


    End Function

End Class