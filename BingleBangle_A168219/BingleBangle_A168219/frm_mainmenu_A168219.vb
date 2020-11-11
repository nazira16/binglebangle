Public Class frm_mainmenu_A168219
    Private Sub frm_mainmenu_A168219_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim current_date As String = Date.Now
        lbl_date.Text = current_date

        'My.Computer.Audio.Play("C:\Users\ena\Desktop\NCT 127 - TOUCH(Piano cover) 엔시티 127 터치 피아노커버 (online-audio-converter.com).wav")'

    End Sub

    Private Sub btn_product_Click(sender As Object, e As EventArgs) Handles btn_product.Click
        frm_products_A168219.Show()
        Me.Hide()
    End Sub

    Private Sub btn_customer_Click(sender As Object, e As EventArgs) Handles btn_customer.Click
        frm_customer_A168219.Show()
        Me.Hide()
    End Sub
    Private Sub btn_staff_Click(sender As Object, e As EventArgs) Handles btn_staff.Click
        frm_staff_A168219.Show()
        Me.Hide()
    End Sub

    Private Sub btn_order_Click(sender As Object, e As EventArgs) Handles btn_order.Click
        frm_order_A168219.Show()
        Me.Hide()

    End Sub

    Private Sub btn_orderlist_Click(sender As Object, e As EventArgs) Handles btn_orderlist.Click
        frm_orderlist_A168219.Show()
        Me.Hide()
    End Sub



End Class
