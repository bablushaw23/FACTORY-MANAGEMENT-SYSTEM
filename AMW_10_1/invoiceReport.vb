Public Class invoiceReport

    Public Sub initData(ClienName As String, destin As String, invNo As String, isueDate As Date, duDate As Date, pyMode As String, pan As String, gstNo As String, address As String,
                        delnote As String, regard As String, stateCodde As String, plcOfSply As String, itemTable As DataTable, dclaration As String, whichType As String, aamt As Decimal)
        inVoiceNo.Value = invNo
        clientName.Value = ClienName
        destination.Value = destin
        issueDate.Value = isueDate
        dueDate.Value = duDate
        payMode.Value = pyMode
        clientPAN.Value = pan
        clientGST.Value = gstNo
        clientAddress.Value = address
        note.Value = delnote
        regards.Value = regard
        stateCode.Value = stateCodde
        placeOfSupply.Value = plcOfSply
        declaration.Value = dclaration

        whichCopy.Value = whichType
        If whichType = 3 Then
            whichCopy.Value = "TRIPLICATE FOR SUPPLIER"
            colourCode(3)
        ElseIf whichType = 1 Then
            whichCopy.Value = "ORIGINAL FOR RECIPIENT"
            colourCode(1)
        Else
            whichCopy.Value = "DUPLICATE FOR TRANSPORTER"
            colourCode(2)
        End If

        total.Value = "₹" + aamt.ToString()
        Dim tax As Decimal = (aamt * 9 / 100)
        cgst.Value = tax
        sgst.Value = tax
        Dim totalTaxx = tax * 2        
        grandtotal.Value = (Decimal.Parse(aamt + totalTaxx))
        Dim nw As New numberToWord
        totalTaxInWords.Value = nw.ConvertCurrencyToEnglish(totalTaxx) + " only"
        amtWord.Value = nw.ConvertCurrencyToEnglish(aamt + 2 * tax)
        set72(itemTable)
    End Sub

    Private Sub colourCode(i As Integer)
        If i = 3 Then
            setColor(System.Drawing.Color.FromArgb(221, 21, 68))
        ElseIf i = 2 Then
            setColor(System.Drawing.Color.FromArgb(0, 176, 80))
        ElseIf i = 1 Then
            setColor(System.Drawing.Color.FromArgb(0, 112, 192))
        End If
    End Sub

    Private Sub setColor(color As Color)

        xLblCAddrs.ForeColor = color
        xLblCAddrs1.ForeColor = color
        xLblCont.ForeColor = color
        xLblCPan.ForeColor = color
        xLblEMAL.ForeColor = color

        xLblGST.ForeColor = color
        xLblHeading.ForeColor = color
        xLblPOS.ForeColor = color
        xLblTaxInvs.ForeColor = color
        xLblWEB.ForeColor = color
        xLblWhichCopy.ForeColor = color
    End Sub

    Private Sub set72(data As DataTable)
        Dim rowNo As Integer = data.Rows.Count
        If (rowNo > 0) Then
            set1(data.Rows(0))
        End If
        If (rowNo > 1) Then
            set2(data.Rows(1))
        End If
        If (rowNo > 2) Then
            set3(data.Rows(2))
        End If
        If (rowNo > 3) Then
            set4(data.Rows(3))
        End If
        If (rowNo > 4) Then
            set5(data.Rows(4))
        End If
        If (rowNo > 5) Then
            set6(data.Rows(5))
        End If
        'If (rowNo > 6) Then
        '    set7(data.Rows(6))
        'End If
        'If (rowNo > 7) Then
        '    set8(data.Rows(7))
        'End If
        'If (rowNo > 8) Then
        '    set9(data.Rows(8))
        'End If
    End Sub

    Private Sub set1(dataRow As DataRow)
        pmsr1.Value = dataRow.Item(0)
        in1.Value = dataRow.Item(1) + " " + dataRow.Item(2)
        'it1.Value = dataRow.Item(2)
        hsn1.Value = dataRow.Item(5)
        qty1.Value = dataRow.Item(3)
        per1.Value = dataRow.Item(4)
        rate1.Value = dataRow.Item(6)
        amt1.Value = dataRow.Item(7)
    End Sub
    Private Sub set2(dataRow As DataRow)
        pmsr2.Value = dataRow.Item(0)
        in2.Value = dataRow.Item(1) + " " + dataRow.Item(2)
        'it2.Value = dataRow.Item(2)
        hsn2.Value = dataRow.Item(5)
        qty2.Value = dataRow.Item(3)
        per2.Value = dataRow.Item(4)
        rate2.Value = dataRow.Item(6)
        amt2.Value = dataRow.Item(7)
    End Sub
    Private Sub set3(dataRow As DataRow)
        pmsr3.Value = dataRow.Item(0)
        in3.Value = dataRow.Item(1) + " " + dataRow.Item(2)
        'it3.Value = dataRow.Item(2)
        hsn3.Value = dataRow.Item(5)
        qty3.Value = dataRow.Item(3)
        per3.Value = dataRow.Item(4)
        rate3.Value = dataRow.Item(6)
        amt3.Value = dataRow.Item(7)
    End Sub
    Private Sub set4(dataRow As DataRow)
        pmsr4.Value = dataRow.Item(0)
        in4.Value = dataRow.Item(1) + " " + dataRow.Item(2)
        'it4.Value = dataRow.Item(2)
        hsn4.Value = dataRow.Item(5)
        qty4.Value = dataRow.Item(3)
        per4.Value = dataRow.Item(4)
        rate4.Value = dataRow.Item(6)
        amt4.Value = dataRow.Item(7)
    End Sub
    Private Sub set5(dataRow As DataRow)
        pmsr5.Value = dataRow.Item(0)
        in5.Value = dataRow.Item(1) + " " + dataRow.Item(2)
        'it5.Value = dataRow.Item(2)
        hsn5.Value = dataRow.Item(5)
        qty5.Value = dataRow.Item(3)
        per5.Value = dataRow.Item(4)
        rate5.Value = dataRow.Item(6)
        amt5.Value = dataRow.Item(7)
    End Sub
    Private Sub set6(dataRow As DataRow)
        pmsr6.Value = dataRow.Item(0)
        in6.Value = dataRow.Item(1) + " " + dataRow.Item(2)
        'it6.Value = dataRow.Item(2)
        hsn6.Value = dataRow.Item(5)
        qty6.Value = dataRow.Item(3)
        per6.Value = dataRow.Item(4)
        rate6.Value = dataRow.Item(6)
        amt6.Value = dataRow.Item(7)
    End Sub
    Private Sub set7(dataRow As DataRow)
        pmsr7.Value = dataRow.Item(0)
        in7.Value = dataRow.Item(1)
        it7.Value = dataRow.Item(2)
        hsn7.Value = dataRow.Item(5)
        qty7.Value = dataRow.Item(3)
        per7.Value = dataRow.Item(4)
        rate7.Value = dataRow.Item(6)
        amt7.Value = dataRow.Item(7)
    End Sub
    Private Sub set8(dataRow As DataRow)
        pmsr8.Value = dataRow.Item(0)
        in8.Value = dataRow.Item(1)
        it8.Value = dataRow.Item(2)
        hsn8.Value = dataRow.Item(5)
        qty8.Value = dataRow.Item(3)
        per8.Value = dataRow.Item(4)
        rate8.Value = dataRow.Item(6)
        amt8.Value = dataRow.Item(7)
    End Sub
    Private Sub set9(dataRow As DataRow)
        pmsr9.Value = dataRow.Item(0)
        in9.Value = dataRow.Item(1)
        it9.Value = dataRow.Item(2)
        hsn9.Value = dataRow.Item(5)
        qty9.Value = dataRow.Item(3)
        per9.Value = dataRow.Item(4)
        rate9.Value = dataRow.Item(6)
        amt9.Value = dataRow.Item(7)
    End Sub





End Class