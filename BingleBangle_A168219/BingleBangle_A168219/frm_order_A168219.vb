Public Class frm_order_A168219
    Dim defaultpicture As String = Application.StartupPath & "\pictures\no-photo.jpg"
    Dim num As Integer
    Dim Total As Double
    Dim duit As Double

    Private Sub frm_order_A168219_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim current_date As String = Date.Now.ToShortDateString

        lbl_date.Text = current_date

        Dim mysql As String = "SELECT FLD_PRODUCT_ID FROM TBL_PRODUCTS_A168219"
        Dim product As New DataTable
        Dim reader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        reader.Fill(product)

        lst_product.DataSource = product
        lst_product.DisplayMember = "FLD_PRODUCT_ID"


        refresh_text(lst_product.Text)

        cmb_staff.DataSource = run_sql_query("SELECT * FROM TBL_STAFF_A168219")
        cmb_staff.DisplayMember = "FLD_STAFF_ID"

        cmb_customer.DataSource = run_sql_query("SELECT * FROM TBL_CUSTOMER_A168219")
        cmb_customer.DisplayMember = "FLD_CUST_ID"

        txt_date.Text = current_date
        refresh_count()

    End Sub

    Private Sub refresh_count()

        Dim count As Integer = 1
        Dim mysql As String = "SELECT COUNT (FLD_ORDER_ID) As count_id FROM TBL_ORDER_A168219"
        Dim order As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(order)
        count += order.Rows(0).Item("count_id")
        lbl_order.Text = "H" + count.ToString("000")
    End Sub
    Private Sub refresh_text(id As String)


        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A168219 WHERE FLD_PRODUCT_ID='" & id & "'"
        Dim product As New DataTable
        Dim reader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        reader.Fill(product)

        txt_price.Text = product.Rows(0).Item("FLD_PRICE")
        txt_brand.Text = product.Rows(0).Item("FLD_BRAND")
        txt_clasp.Text = product.Rows(0).Item("FLD_CLASP")
        txt_colour.Text = product.Rows(0).Item("FLD_COLOUR")
        lbl_id.Text = product.Rows(0).Item("FLD_PRODUCT_ID")
        txt_name.Text = product.Rows(0).Item("FLD_PRODUCT_NAME")
        txt_type.Text = product.Rows(0).Item("FLD_TYPE")
        txt_total.Text = num * txt_price.Text()

        Try
            pic_product.BackgroundImage = Image.FromFile("pictures/" & lbl_id.Text & ".jpg")
        Catch ex As Exception
            pic_product.BackgroundImage = Image.FromFile("pictures/no-photo.jpg")
        End Try
    End Sub

    Private Sub lst_product_MouseClick(sender As Object, e As EventArgs) Handles lst_product.MouseClick
        refresh_text(lst_product.Text)
    End Sub

    Private Sub numeric_ValueChanged(sender As Object, e As EventArgs) Handles numeric.ValueChanged
        num = numeric.Value
        Total = txt_price.Text()
        txt_total.Text = num * Total
    End Sub

    Private Sub btn_cart_Click(sender As Object, e As EventArgs) Handles btn_cart.Click
        grd_order.Rows.Add(New String() {lbl_id.Text, txt_name.Text, numeric.Value, txt_total.Text})
        txt_total.Text = ""
        numeric.Value = 0
        lbl_total.Text = " "
        refresh_price()
    End Sub

    Private Sub refresh_price()

        If grd_order.RowCount > 0 Then
            duit = 0

            For index As Integer = 0 To grd_order.RowCount - 1
                duit += Convert.ToDouble(grd_order.Rows(index).Cells(3).Value)
            Next

            lbl_total.Text = "RM " & duit
        ElseIf grd_order.RowCount = 1 Then

            lbl_total.Text = "RM 0"

        End If
    End Sub


    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btn_remove.Click
        Dim delete_order = MsgBox("Confirm to delete this item from list?", MsgBoxStyle.YesNo)

        If delete_order = MsgBoxResult.Yes Then
            grd_order.Rows.Remove(grd_order.CurrentRow)
            refresh_price()
        Else
            refresh_price()
        End If
    End Sub

    Private Sub btn_invoice_Click(sender As Object, e As EventArgs) Handles btn_invoice.Click
        frm_orderlist_A168219.Show()
        Me.Hide()
    End Sub

    Private Sub btn_confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click
        Dim mytransaction As OleDb.OleDbTransaction
        myconnection2.Open()

        mytransaction = myconnection2.BeginTransaction
        Try
            Dim order As String = "INSERT INTO TBL_ORDER_A168219 (FLD_ORDER_ID,FLD_CUSTOMER_ID,FLD_ORDER_DATE,FLD_STAFF_ID) values (""" &
            lbl_order.Text & """,""" & cmb_customer.Text & """,""" & txt_date.Text & """,""" & cmb_staff.Text & """)"

            Dim myorder As New OleDb.OleDbCommand(order, myconnection2, mytransaction)

            myorder.ExecuteNonQuery()
            For i As Integer = 0 To grd_order.RowCount - 1
                Dim productid As String = grd_order(0, i).Value
                Dim productname As String = grd_order(1, i).Value
                Dim quantity As String = grd_order(2, i).Value

                Dim price As String = grd_order(3, i).Value

                Dim mysql As String = "insert into TBL_ORDERLIST_A168219 (FLD_ORDER_ID, FLD_PRODUCT_ID, FLD_PRODUCT_NAME, FLD_QUANTITY, FLD_PRICE) values (""" & lbl_order.Text & """,""" & productid & """, """ & productname & """, """ & quantity & """, """ & price & """)"
                Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2, mytransaction)


                mywriter.ExecuteNonQuery()

            Next
            mytransaction.Commit()
            myconnection2.Close()
            Beep()
            MsgBox("Transaction successful!")
            grd_order.Rows.Clear()

        Catch ex As Exception
            Beep()
            MsgBox("Problem with transaction:" & vbCrLf & vbCrLf & ex.Message)
            mytransaction.Rollback()
            myconnection2.Close()

        End Try

        btn_cart.Enabled = False
        btn_confirm.Enabled = False
        btn_remove.Enabled = False
        btn_order.Enabled = True
        numeric.Value = 0
        lbl_total.Text = "0"
        refresh_count()
    End Sub

    Private Sub btn_order_Click_1(sender As Object, e As EventArgs) Handles btn_order.Click

        Dim mytransaction As OleDb.OleDbTransaction
        myconnection2.Open()
        mytransaction = myconnection2.BeginTransaction
        Try

            Dim mysql As String = "INSERT INTO TBL_ORDER_A168219 (FLD_ORDER_ID,FLD_CUSTOMER_ID,FLD_ORDER_DATE,FLD_STAFF_ID) values (""" &
            lbl_order.Text & """,""" & cmb_customer.Text & """,""" & txt_date.Text & """,""" & cmb_staff.Text & """)"

            Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2,
            mytransaction)

            mywriter.ExecuteNonQuery()
            mytransaction.Commit()
            myconnection2.Close()
            Beep()
            MsgBox("You can make new order now!")
            grd_order.Rows.Clear()

        Catch ex As Exception

            Beep()
            MsgBox("Problem with transaction:" & vbCrLf & vbCrLf & ex.Message)
            mytransaction.Rollback()
            myconnection2.Close()

        End Try

        btn_cart.Enabled = True
        btn_confirm.Enabled = True
        btn_remove.Enabled = True
        btn_order.Enabled = False
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_A168219.Show()
        Me.Hide()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub
End Class