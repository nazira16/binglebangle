Public Class frm_products_A168219
    Dim defaultpicture As String = Application.StartupPath & "\pictures\no-photo.jpg"


    Private Sub frm_products_A168219_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim current_date As String = Date.Now
        lbl_date.Text = current_date

        Dim mysql As String = "SELECT FLD_PRODUCT_ID FROM TBL_PRODUCTS_A168219"
        Dim product As New DataTable
        Dim reader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        reader.Fill(product)

        lst_product.DataSource = product
        lst_product.DisplayMember = "FLD_PRODUCT_ID"


        refresh_text(lst_product.Text)
        refresh_grid()


        'txt_path.Text = defaultpicture
        'pic_product.BackgroundImage = Image.FromFile(defaultpicture)

    End Sub


    Private Sub refresh_text(id As String)


        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A168219 WHERE FLD_PRODUCT_ID='" & id & "'"
        Dim product As New DataTable
        Dim reader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        reader.Fill(product)

        txt_price.Text = product.Rows(0).Item("FLD_PRICE")
        txt_prodBrand.Text = product.Rows(0).Item("FLD_BRAND")
        txt_prodClasp.Text = product.Rows(0).Item("FLD_CLASP")
        txt_prodColour.Text = product.Rows(0).Item("FLD_COLOUR")
        txt_prodID.Text = product.Rows(0).Item("FLD_PRODUCT_ID")
        txt_prodName.Text = product.Rows(0).Item("FLD_PRODUCT_NAME")
        txt_prodType.Text = product.Rows(0).Item("FLD_TYPE")

        Try
            pic_product.BackgroundImage = Image.FromFile("pictures/" & txt_prodID.Text & ".jpg")
        Catch ex As Exception
            pic_product.BackgroundImage = Image.FromFile("pictures/no-photo.jpg")
        End Try
    End Sub

    Private Sub lst_product_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lst_product.MouseClick

        refresh_text(lst_product.Text)

    End Sub

    Private Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A168219"
        Dim product As New DataTable
        Dim reader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        reader.Fill(product)

        lst_product.DataSource = product
        txt_path.Text = defaultpicture
        Try
            pic_product.BackgroundImage = Image.FromFile("pictures/" & txt_prodID.Text & ".jpg")
        Catch ex As Exception
            pic_product.BackgroundImage = Image.FromFile("pictures/no-photo.jpg")
        End Try

    End Sub

    Private Sub clear_fields()
        txt_price.Text = ""
        txt_prodBrand.Text = ""
        txt_prodClasp.Text = ""
        txt_prodColour.Text = ""
        txt_prodID.Text = ""
        txt_prodName.Text = ""
        txt_prodType.Text = ""
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click

        Dim mysql As String = "INSERT INTO TBL_PRODUCTS_A168219 VALUES ( '" & txt_prodID.Text & "',
	   '" & txt_prodName.Text & "', 
        " & txt_price.Text & ", 
	   '" & txt_prodBrand.Text & "', 
        '" & txt_prodClasp.Text & "', 
	   '" & txt_prodColour.Text & "', 
        '" & txt_prodType.Text & "')"

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try

            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            My.Computer.FileSystem.CopyFile(txt_path.Text, "pictures\" & txt_prodID.Text & ".jpg")

            refresh_grid()

        Catch ex As Exception

            Beep()
            MsgBox(“There is a mistake in the data you entered, as shown below” & vbCrLf & vbCrLf & ex.Message)

            mywriter.Connection.Close()
        End Try
    End Sub
    Private Function generate_matric() As String

        Dim lastid As String = run_sql_query("SELECT MAX(FLD_PRODUCT_ID) AS LASTID FROM TBL_PRODUCTS_A168219").Rows(0).Item("LASTID")
        Dim newmid As String = "P0" & Mid(lastid, 2) + 1
        Return newmid

    End Function
    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        clear_fields()
        txt_prodID.Text = generate_matric()
    End Sub

    Private Sub btn_picture_Click(sender As Object, e As EventArgs) Handles btn_picture.Click
        Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop

        OpenFileDialog1.InitialDirectory = mydesktop
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG files (*.jpg)|*.jpg"
        OpenFileDialog1.ShowDialog()

        pic_product.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
        txt_path.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        run_sql_command("UPDATE TBL_PRODUCTS_A168219 SET FLD_PRODUCT_NAME='" & txt_prodName.Text & "',FLD_PRICE ='" & txt_price.Text & "', FLD_BRAND='" & txt_prodBrand.Text & "', FLD_COLOUR = '" & txt_prodColour.Text & "', FLD_CLASP = '" & txt_prodClasp.Text & "', FLD_TYPE='" & txt_prodType.Text & "' WHERE FLD_PRODUCT_ID ='" & txt_prodID.Text & "'")

        Beep()
        MsgBox("You have succesfully updated the product """ & txt_prodID.Text & """.")
        clear_fields()
        refresh_grid()

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim delete_confirmation = MsgBox("are you sure you would Like to delete the product """ & txt_prodID.Text & """?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then

            run_sql_command("DELETE FROM TBL_PRODUCTS_A168219 WHERE FLD_PRODUCT_ID ='" & txt_prodID.Text & "'")

            Beep()
            MsgBox("The course """ & txt_prodID.Text & """ has been succesfully deleted.")
            clear_fields()
            refresh_grid()


        End If
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_A168219.Show()
        Me.Hide()
    End Sub
End Class