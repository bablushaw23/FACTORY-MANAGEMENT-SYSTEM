Public Class ConstantClass
    Public Shared Property connectionString As String
    Public Shared Property userName As String
    Public Shared Property UserID As Integer = 1
    Public Shared Property Rank As Integer
    Public Shared Property VAT As Decimal = 18

    Public Shared Property themeColor As Color = Color.FromArgb(0, 102, 204)

    Public Shared Function getPDFLocation(pdfName As String) As String
        Dim location As String = "E:\\AMWReports"
        If (Not System.IO.Directory.Exists(location)) Then
            System.IO.Directory.CreateDirectory(location)
        End If
        location = location + "\" + pdfName + ".pdf"
        Return location
    End Function

    Public Shared Function SimpleCrypt(ByVal Text As String) As String
        ' Encrypts/decrypts the passed string using 
        ' a simple ASCII value-swapping algorithm
        Dim strTempChar As String, i As Integer
        For i = 1 To Len(Text)
            If Asc(Mid$(Text, i, 1)) < 128 Then
                strTempChar = _
          CType(Asc(Mid$(Text, i, 1)) + 128, String)
            Else
                strTempChar = _
          CType(Asc(Mid$(Text, i, 1)) - 128, String)
            End If
            Mid$(Text, i, 1) = _
                Chr(CType(strTempChar, Integer))
        Next i
        Return Text
    End Function

    Public Sub getCS()
        Dim dox As New xmlManager
        connectionString = dox.loadConnection()
    End Sub
    Public Function GetVat() As Decimal
        Return VAT
    End Function
    Public Function GetUserID() As Integer
        Return UserID
    End Function

    Public Sub SetUserID(ByVal id As Integer)
        UserID = id
    End Sub
    Public Sub SetRank(ByVal num As Integer)
        Rank = num
    End Sub


End Class
