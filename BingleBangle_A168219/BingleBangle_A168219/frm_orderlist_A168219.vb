Public Class frm_orderlist_A168219

    Dim t As Double

    Private Sub frm_orderlist_A168219_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim current_date As String = Date.Now.ToShortDateString
        lbl_date.Text = current_date

        Dim mysql As String = "SELECT FLD_ORDER_ID FROM TBL_ORDER_A168219"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        cmb_order.DataSource = mydatatable
        cmb_order.DisplayMember = "FLD_ORDER_ID"

        refresh_grid()
        refresh_price()
    End Sub

    Private Sub refresh_grid()

        Dim mysql As String = "SELECT FLD_PRODUCT_ID,FLD_PRODUCT_NAME,FLD_QUANTITY, FLD_PRICE FROM TBL_ORDERLIST_A168219 where FLD_ORDER_ID like""%" & cmb_order.Text & "%"""
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_order.DataSource = mydatatable

        grd_order.Columns(0).HeaderText = "Product ID"
        grd_order.Columns(1).HeaderText = "Product Name"
        grd_order.Columns(2).HeaderText = "Order Quantity"
        grd_order.Columns(3).HeaderText = "Total price (RM)"

    End Sub

    Private Sub cmb_order_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_order.SelectedIndexChanged
        refresh_grid()
        refresh_price()
    End Sub

    Private Sub refresh_price()

        If grd_order.RowCount > 1 Then
            t = 0
            For index As Integer = 0 To grd_order.RowCount - 1
                t += Convert.ToDouble(grd_order.Rows(index).Cells(3).Value)
            Next
            'lbl_total.Text = "RM " & t
        ElseIf grd_order.RowCount = 1 Then
            'lbl_total.Text = "RM 0"
        End If

    End Sub

    Private Sub lbl_title2_Click(sender As Object, e As EventArgs) Handles lbl_title2.Click

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_A168219.Show()
        Me.Hide()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub

    Private Sub lbl_total_Click(sender As Object, e As EventArgs)

    End Sub
End Class