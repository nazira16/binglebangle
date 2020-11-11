Public Class frm_customer_A168219
    Dim defaultpicture As String = Application.StartupPath & "\pictures\no-photo.jpg"

    Private Sub frm_customer_A168219_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim current_date As String = Date.Now
        lbl_date.Text = current_date

        Dim mysql As String = "SELECT FLD_CUST_ID FROM TBL_CUSTOMER_A168219"
        Dim customer As New DataTable
        Dim reader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        reader.Fill(customer)

        lst_customer.DataSource = customer
        lst_customer.DisplayMember = "FLD_CUST_ID"

        refresh_grid()
        refresh_text(lst_customer.Text)
    End Sub

    Private Sub refresh_text(ID As String)

        Dim mysql As String = "SELECT * FROM TBL_CUSTOMER_A168219 WHERE FLD_CUST_ID='" & ID & "'"
        Dim customer As New DataTable
        Dim reader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        reader.Fill(customer)
        txt_id.Text = customer.Rows(0).Item("FLD_CUST_ID")
        txt_name.Text = customer.Rows(0).Item("FLD_CUST_NAME")
        txt_address.Text = customer.Rows(0).Item("FLD_ADDRESS")
        txt_phone.Text = customer.Rows(0).Item("FLD_PHONE")
        lbl_id.Text = customer.Rows(0).Item("FLD_CUST_ID")
        Try
            pic_cust.BackgroundImage = Image.FromFile("pictures/" & txt_id.Text & ".jpg")
        Catch ex As Exception
            pic_cust.BackgroundImage = Image.FromFile("pictures/no-photo.jpg")

        End Try

    End Sub

    Private Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM TBL_CUSTOMER_A168219"
        Dim customer As New DataTable
        Dim reader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        reader.Fill(customer)
        lst_customer.DataSource = customer

        txt_path.Text = defaultpicture
        Try
            pic_cust.BackgroundImage = Image.FromFile("pictures/" & txt_id.Text & ".jpg")
        Catch ex As Exception
            pic_cust.BackgroundImage = Image.FromFile("pictures/no-photo.jpg")
        End Try

    End Sub
    Private Sub clear_fields()

        txt_id.Text = ""
        txt_name.Text = ""
        txt_address.Text = ""
        txt_phone.Text = ""
        lbl_id.Text = ""

    End Sub

    Private Sub lst_customer_MouseClick(sender As Object, e As EventArgs) Handles lst_customer.MouseClick
        refresh_text(lst_customer.Text)
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        clear_fields()
        txt_id.Text = generate_id()
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Dim mysql As String = "INSERT INTO TBL_CUSTOMER_A168219 VALUES ( '" & txt_id.Text & "',
	   '" & txt_name.Text & "', 
        " & txt_phone.Text & ", 
	   '" & txt_address.Text & "' 
       )"

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try

            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            My.Computer.FileSystem.CopyFile(txt_path.Text, "pictures\" & txt_id.Text & ".jpg")

            refresh_grid()

        Catch ex As Exception

            Beep()
            MsgBox(“There is a mistake in the data you entered, as shown below” & vbCrLf & vbCrLf & ex.Message)

            mywriter.Connection.Close()
        End Try
    End Sub
    Private Function generate_id() As String

        Dim lastid As String = run_sql_query("SELECT MAX(FLD_CUSTOMER_ID) AS LASTID FROM TBL_CUSTOMER_A168219").Rows(0).Item("LASTID")
        Dim newmid As String = "C0" & Mid(lastid, 2) + 1
        Return newmid

    End Function

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        run_sql_command("UPDATE TBL_CUSTOMER_A168219 SET FLD_CUST_NAME='" & txt_name.Text & "',FLD_PHONE =" & txt_phone.Text & ", FLD_ADDRESS='" & txt_address.Text & "' WHERE FLD_PRODUCT_ID ='" & txt_id.Text & "'")

        Beep()
        MsgBox("You have succesfully updated the customer """ & txt_id.Text & """.")
        clear_fields()
        refresh_grid()
    End Sub

    Private Sub btn_picture_Click(sender As Object, e As EventArgs) Handles btn_picture.Click
        Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop

        OpenFileDialog1.InitialDirectory = mydesktop
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG files (*.jpg)|*.jpg"
        OpenFileDialog1.ShowDialog()

        pic_cust.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
        txt_path.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim delete_confirmation = MsgBox("are you sure you would Like to delete the customer """ & txt_id.Text & """?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then

            run_sql_command("DELETE FROM TBL_CUSTOMER_A168219 WHERE FLD_CUST_ID ='" & txt_id.Text & "'")

            Beep()
            MsgBox("The course """ & txt_id.Text & """ has been succesfully deleted.")
            clear_fields()
            refresh_grid()

        End If
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_A168219.Show()
        Me.Hide()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub


End Class