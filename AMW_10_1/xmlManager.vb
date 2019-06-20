Imports System.Xml
Imports System.IO
Public Class xmlManager

    Public Sub createXML(CS As String)
        Dim data As New XmlDocument
        Dim dclr As XmlDeclaration
        Dim root As XmlElement
        Dim connectionString As XmlElement
        Dim vat As XmlElement
        Dim billingMSG As XmlElement
        Dim cmnt As XmlComment

        dclr = data.CreateXmlDeclaration("1.0", Nothing, String.Empty)
        data.InsertBefore(dclr, data.DocumentElement)

        root = data.CreateElement("GBEXTINFO")
        data.InsertAfter(root, dclr)

        cmnt = data.CreateComment("connection string starts")
        root.AppendChild(cmnt)

        connectionString = data.CreateElement("ConnectionString")
        connectionString.InnerText = CS
        root.AppendChild(connectionString)

        vat = data.CreateElement("VAT")
        vat.InnerText = "14.5"
        root.AppendChild(vat)

        billingMSG = data.CreateElement("billingMessage")
        billingMSG.InnerText = "Thank you.Visit Again"
        root.AppendChild(billingMSG)

        data.Save("GBINFO.xml")
    End Sub

    Public Function loadConnection() As String
        Dim dox As New XmlDocument
        Dim xmlNode As XmlNodeList
        Dim fs As FileStream
        Try
            fs = File.Open("GBINFO.xml", FileMode.Open, FileAccess.Read)
            dox.Load(fs)
        Catch ex As IOException
            MsgBox(ex.Message)
            Dim cm As New connectionManager
            cm.ShowDialog()
            Application.Restart()
        Finally
            If Not IsNothing(fs) Then
                fs.Close()
            End If
        End Try
        xmlNode = dox.GetElementsByTagName("GBEXTINFO")
        Return xmlNode(0).ChildNodes(1).InnerText
    End Function

    Public Function loadBillMSG() As String
        Dim dox As New XmlDocument
        Dim xmlNode As XmlNodeList
        Dim fs As FileStream
        Try
            fs = File.Open("GBINFO.xml", FileMode.Open, FileAccess.Read)
            dox.Load(fs)
        Catch ex As IOException
            MsgBox(ex.Message)
            Application.Exit()
        Finally
            If Not IsNothing(fs) Then
                fs.Close()
            End If
        End Try
        xmlNode = dox.GetElementsByTagName("GBEXTINFO")
        Return xmlNode(0).ChildNodes(3).InnerText
    End Function

    Public Function loadVAT() As Decimal
        Dim dox As New XmlDocument
        Dim xmlNode As XmlNodeList
        Dim fs As FileStream
        Try
            fs = File.Open("GBINFO.xml", FileMode.Open, FileAccess.Read)
            dox.Load(fs)
        Catch ex As IOException
            MsgBox(ex.Message)
            Application.Exit()
        Finally
            If Not IsNothing(fs) Then
                fs.Close()
            End If
        End Try
        xmlNode = dox.GetElementsByTagName("GBEXTINFO")
        Return Decimal.Parse(xmlNode(0).ChildNodes(2).InnerText.ToString())
    End Function

    Public Sub changeVat(newVat As Decimal)
        Dim dox As New XmlDocument
        Dim xmlNode As XmlNodeList
        Dim fs As FileStream
        Try
            fs = File.Open("GBINFO.xml", FileMode.Open, FileAccess.Read)
            dox.Load(fs)
        Catch ex As IOException
            MsgBox(ex.Message)
            Application.Exit()
        Finally
            If Not IsNothing(fs) Then
                fs.Close()
            End If
        End Try
        xmlNode = dox.GetElementsByTagName("GBEXTINFO")
        xmlNode(0).ChildNodes(2).InnerText = newVat
        dox.Save("GBINFO.xml")
    End Sub
    Public Sub changeBillingMsg(newmsg As String)
        Dim dox As New XmlDocument
        Dim xmlNode As XmlNodeList
        Dim fs As FileStream
        Try
            fs = File.Open("GBINFO.xml", FileMode.Open, FileAccess.Read)
            dox.Load(fs)
        Catch ex As IOException
            MsgBox(ex.Message)
            Application.Exit()
        Finally
            If Not IsNothing(fs) Then
                fs.Close()
            End If
        End Try
        xmlNode = dox.GetElementsByTagName("GBEXTINFO")
        xmlNode(0).ChildNodes(3).InnerText = newmsg
        dox.Save("GBINFO.xml")
    End Sub
End Class
