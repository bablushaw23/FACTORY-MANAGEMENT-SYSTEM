Imports System.Data.SqlClient

Public Class cmdClass

    Dim cc As New ConstantClass

    Public Function addNewExpenses(ByRef form As formAddNewExpenses) As Boolean
        Dim con As New SqlConnection(ConstantClass.connectionString)
        Dim cmd As New SqlCommand
        cmd.CommandText = "addExpenses"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = con

        cmd.Parameters.Add("@date", SqlDbType.Date).Value = form.dtpDate.Value
        cmd.Parameters.Add("@desc", SqlDbType.NVarChar).Value = form.txtDesc.Text
        cmd.Parameters.Add("@amt", SqlDbType.Float).Value = form.txtAmt.Value
        cmd.Parameters.Add("@addedBy", SqlDbType.Int).Value = ConstantClass.UserID

        Try
            con.Open()
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            con.Close()
            con.Dispose()
            cmd.Dispose()
        End Try
    End Function

    Public Function returnSimpleScalerQuery(ByVal query As String) As String
        Dim cmd As New SqlCommand
        Dim con As New SqlConnection(ConstantClass.connectionString)
        cmd.CommandText = query
        cmd.Connection = con
        con.Open()
        Dim result As String = cmd.ExecuteScalar()
        con.Close()
        Return result
    End Function

    Public Function getItems(ByVal itemId As Integer) As DataTable
        Dim adapter As New SqlDataAdapter("select top 1 * from itemTable where ID=" + itemId.ToString, ConstantClass.connectionString)
        Dim dt As New DataTable
        adapter.Fill(dt)
        Return dt
    End Function

    Public Sub logout()
        Dim con As New SqlConnection(ConstantClass.connectionString)
        Dim cmd As New SqlCommand("ProclogOut", con)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@userID", SqlDbType.NVarChar).Value = ConstantClass.UserID
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        ConstantClass.Rank = 0
        ConstantClass.UserID = 0
    End Sub

    Public Function returnDataSet(ByVal cmd As SqlCommand) As DataSet
        Dim dset As New DataSet
        Dim con As New SqlConnection(ConstantClass.connectionString)
        cmd.Connection = con
        Try
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dset)
        Catch ex As Exception
            MsgBox("An error has occured from returnDataSet as " + ex.Message)
        End Try
        Return dset
    End Function
    Public Function returnDataSet(ByVal query As String, isproc As Boolean) As DataSet
        Dim dset As New DataSet
        Dim con As New SqlConnection(ConstantClass.connectionString)
        Try
            Dim cmd As New SqlCommand
            cmd.CommandText = query
            cmd.Connection = con
            If isproc Then
                cmd.CommandType = CommandType.StoredProcedure
            End If
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dset)
        Catch ex As Exception
            MsgBox("An error has occured from returnDataSet as " + ex.Message)
        End Try
        Return dset
    End Function

    Public Sub executeCMDNonQuery(ByVal cmd As SqlCommand)
        Dim connection As New SqlConnection(ConstantClass.connectionString)
        cmd.Connection = connection
        connection.Open()
        cmd.ExecuteNonQuery()
        connection.Close()
    End Sub

    Public Function returnAutocomplete(ByVal query As String, isproc As Boolean) As AutoCompleteStringCollection
        Dim coll As New AutoCompleteStringCollection
        Dim con As New SqlConnection(ConstantClass.connectionString)
        Try
            Dim cmd As New SqlCommand
            Dim rdr As SqlDataReader
            cmd.Connection = con
            cmd.CommandText = query
            If isproc Then
                cmd.CommandType = CommandType.StoredProcedure
            End If
            con.Open()
            rdr = cmd.ExecuteReader()
            If rdr.HasRows Then
                While rdr.Read
                    coll.Add(rdr(0))
                End While
            End If

        Catch ex As Exception
            MsgBox("Error occured from returnAutocomplete as " + ex.Message)
        Finally
            con.Close()
        End Try
        Return coll
    End Function

    Public Sub addNewCustomer(ByRef form As EditClients)
        Dim connection As New SqlClient.SqlConnection(ConstantClass.connectionString)

        Dim cmd As New SqlClient.SqlCommand
        cmd.CommandText = "addNewClient"
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@Name", form.txtName.Text)
        cmd.Parameters.AddWithValue("@MailingAddress", form.txtMail.Text)
        cmd.Parameters.AddWithValue("@ShippingAddress", form.txtShipping.Text)
        cmd.Parameters.AddWithValue("@EMail", form.txtEmail.Text)
        cmd.Parameters.AddWithValue("@Phone", form.txtPhone.Text)
        cmd.Parameters.AddWithValue("@Mobile", form.txtMob.Text)
        cmd.Parameters.AddWithValue("@Fax", form.txtFAX.Text)
        cmd.Parameters.AddWithValue("@UIN", form.txtUIN.Text)
        cmd.Parameters.AddWithValue("@PAN_IT", form.txtPAN.Text)
        cmd.Parameters.AddWithValue("@AddedBy", ConstantClass.UserID)
        cmd.Parameters.AddWithValue("@Description", form.txtDescription.Text)
        cmd.Connection = connection

        connection.Open()
        cmd.ExecuteNonQuery()
        connection.Close()

    End Sub

    Public Function addNewPurchaseCMD(ByRef form As AddPurchaseBill, ByRef transection As SqlClient.SqlTransaction, ByRef connection As SqlConnection) As Int16        
        Dim merchantId As Int16 = returnSimpleScalerQuery("select id from PurchaseClientlDtlsTable where name='" + form.txtCustName.Text + "' and GSTIN='" + form.comboGST.Text + "'")
        If merchantId < 1 Then
            Throw New Exception("Merchant not found")
        End If
            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "addNewPurchaseInvoice"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Transaction = transection

            cmd.Parameters.AddWithValue("@AdditionalCharges", form.nmOther.Value)
            cmd.Parameters.AddWithValue("@BillAmt", form.lblTotalPayable.Text)
            cmd.Parameters.AddWithValue("@ShippingCharges", form.nmShipping.Value)
            cmd.Parameters.AddWithValue("@MantainanceCharges", form.nmMantainance.Value)
            cmd.Parameters.AddWithValue("@IssueDate", form.dtpIssueDate.Value)
            cmd.Parameters.AddWithValue("@Inv_refNo", form.txtBillNO.Text)
            cmd.Parameters.AddWithValue("@Description", form.taDescription.Text)
            cmd.Parameters.AddWithValue("@DateOfReceive", form.dtpDeliveryDate.Value)
            cmd.Parameters.AddWithValue("@ClientID", merchantId)

            cmd.Connection = connection

            Dim toReturn As Int16 = cmd.ExecuteScalar()            

            Return toReturn
    End Function

    Public Sub addNewPurchaseItemCMD(invoiceID As Int16, itemTable As DataTable, ByRef transection As SqlClient.SqlTransaction, ByRef connection As SqlConnection)        
        Dim cmd As New SqlClient.SqlCommand("addPurchaseItems", connection)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Transaction = transection
        For Each row As DataRow In itemTable.Rows
            cmd.Parameters.Clear()            
            cmd.Parameters.AddWithValue("@InvoiceID", invoiceID)
            cmd.Parameters.AddWithValue("@ItemDescription", row.Item(2))
            cmd.Parameters.AddWithValue("@QTY", Decimal.Parse(row.Item(3)))
            cmd.Parameters.AddWithValue("@Rate", Decimal.Parse(row.Item(5).ToString))
            cmd.Parameters.AddWithValue("@HSN", row.Item(1).ToString)
            cmd.Parameters.AddWithValue("@Unit", row.Item(4).ToString)
            cmd.Parameters.AddWithValue("@CGST", Decimal.Parse(row.Item(8).ToString))
            cmd.Parameters.AddWithValue("@SGST", Decimal.Parse(row.Item(10).ToString))
            cmd.ExecuteNonQuery()
        Next        
    End Sub

    Public Function addNewitemCMD(ByRef form As addNewItem) As Boolean
        Dim cmd As New SqlCommand
        cmd.CommandText = "addNewItem"
        cmd.CommandType = CommandType.StoredProcedure
        If (form.txtName.Visible = True) Then
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = form.txtName.Text
        Else
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = form.comboItem.Text
        End If
        cmd.Parameters.Add("@Type", SqlDbType.NVarChar).Value = form.txtType.Text
        cmd.Parameters.Add("@Qty", SqlDbType.Decimal).Value = form.txtQty.Text
        cmd.Parameters.Add("@HSN", SqlDbType.NChar).Value = form.txtHSN.Text

        cmd.Parameters.AddWithValue("@wtPerPc", form.txtWtPerPc.Text.ToString)
        cmd.Parameters.Add("@cp", SqlDbType.Decimal).Value = form.txtCP.Value
        cmd.Parameters.Add("@sp", SqlDbType.Decimal).Value = form.txtSP.Value

        cmd.Parameters.Add("@description", SqlDbType.NVarChar).Value = form.txtDescription.Text.ToString
        
        cmd.Parameters.Add("@user", SqlDbType.Int).Value = ConstantClass.UserID
        Dim con As New SqlConnection(ConstantClass.connectionString)
        cmd.Connection = con
        Dim result As Integer
        Try
            con.Open()
            cmd.ExecuteScalar()
            result = 1
        Catch ex As Exception
            result = 0
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        Return result
    End Function

    Function editItemCMD(Form As SeeAndEditItems) As Boolean
        Dim cmd As New SqlCommand
        cmd.CommandText = "EditItem"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = Form.txtName.Text
        cmd.Parameters.Add("@Type", SqlDbType.NVarChar).Value = Form.txtType.Text
        cmd.Parameters.Add("@Qty", SqlDbType.Decimal).Value = Form.txtQty.Text
        cmd.Parameters.Add("@HSN", SqlDbType.NChar).Value = Form.txtHSN.Text
        cmd.Parameters.Add("@itemID", SqlDbType.Int).Value = Form.id

        cmd.Parameters.AddWithValue("@wtPerPcs", Form.txtWtPerPcs.Text)
        
        cmd.Parameters.Add("@cp", SqlDbType.Decimal).Value = Form.txtCP.Value
        cmd.Parameters.Add("@sp", SqlDbType.Decimal).Value = Form.txtSP.Value
        If Form.txtDescription.Text.Length > 0 Then
            cmd.Parameters.Add("@description", SqlDbType.NVarChar).Value = Form.txtDescription.Text
        Else
            cmd.Parameters.Add("@description", SqlDbType.NVarChar).Value = DBNull.Value
        End If
        cmd.Parameters.Add("@user", SqlDbType.Int).Value = ConstantClass.UserID
        Dim con As New SqlConnection(ConstantClass.connectionString)
        cmd.Connection = con
        Dim result As Integer
        Try
            con.Open()
            cmd.ExecuteScalar()
            result = 1
        Catch ex As Exception
            result = 0
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        Return result
    End Function

End Class
