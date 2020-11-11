Public Class frm_staff_A168219
    Dim defaultpicture As String = Application.StartupPath & "\pictures\no-photo.jpg"

    Private Sub frm_staff_A168219_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT FLD_STAFF_ID FROM TBL_STAFF_A168219"
        Dim staff As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(staff)

        lst_staff.DataSource = staff
        lst_staff.DisplayMember = "FLD_STAFF_ID"

        refresh_text(lst_staff.Text)
        refresh_grid()
    End Sub

    Private Sub refresh_text(id As String)

        Dim mysql As String = "SELECT * FROM TBL_STAFF_A168219 WHERE FLD_STAFF_ID='" & id & "'"
        Dim staff As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(staff)

        txt_id.Text = staff.Rows(0).Item("FLD_STAFF_ID")
        txt_fname.Text = staff.Rows(0).Item("FLD_FIRST_NAME")
        txt_lname.Text = staff.Rows(0).Item("FLD_LAST_NAME")
        txt_gender.Text = staff.Rows(0).Item("FLD_GENDER")
        lbl_id.Text = staff.Rows(0).Item("FLD_STAFF_ID")
        Try
            pic_staff.BackgroundImage = Image.FromFile("pictures/" & txt_id.Text & ".jpg")
        Catch ex As Exception
            pic_staff.BackgroundImage = Image.FromFile("pictures/no-photo.jpg")

        End Try

    End Sub
    Private Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM TBL_STAFF_A168219"
        Dim staff As New DataTable
        Dim reader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        reader.Fill(staff)
        lst_staff.DataSource = staff

        txt_path.Text = defaultpicture
        Try
            pic_staff.BackgroundImage = Image.FromFile("pictures/" & txt_id.Text & ".jpg")
        Catch ex As Exception
            pic_staff.BackgroundImage = Image.FromFile("pictures/no-photo.jpg")
        End Try

    End Sub
    Private Sub clear_fields()

        txt_id.Text = ""
        txt_fname.Text = ""
        txt_lname.Text = ""
        txt_gender.Text = ""
        lbl_id.Text = ""

    End Sub

    Private Sub lst_staff_MouseClick(sender As Object, e As EventArgs) Handles lst_staff.MouseClick
        refresh_text(lst_staff.Text)
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        clear_fields()
        txt_id.Text = generate_id()
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Dim mysql As String = "INSERT INTO TBL_STAFF_A168219 VALUES ( '" & txt_id.Text & "', '" & txt_fname.Text & "',  '" & txt_lname.Text & "', '" & txt_gender.Text & "' )"

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

        Dim lastid As String = run_sql_query("SELECT MAX(FLD_STAFF_ID) AS LASTID FROM TBL_STAFF_A168219").Rows(0).Item("LASTID")
        Dim newmid As String = "S00" & Mid(lastid, 2) + 1
        Return newmid

    End Function

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        run_sql_command("UPDATE TBL_STAFF_A168219 SET FLD_FIRST_NAME='" & txt_fname.Text & "',FLD_LAST_NAME ='" & txt_lname.Text & "', FLD_GENDER='" & txt_gender.Text & "' WHERE FLD_STAFF_ID ='" & txt_id.Text & "'")

        Beep()
        MsgBox("You have succesfully updated the staff """ & txt_id.Text & """.")
        clear_fields()
        refresh_grid()
    End Sub

    Private Sub btn_picture_Click(sender As Object, e As EventArgs) Handles btn_picture.Click
        Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop

        OpenFileDialog1.InitialDirectory = mydesktop
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG files (*.jpg)|*.jpg"
        OpenFileDialog1.ShowDialog()

        pic_staff.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
        txt_path.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim delete_confirmation = MsgBox("are you sure you would Like to delete the staff """ & txt_id.Text & """?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then

            run_sql_command("DELETE FROM TBL_STAFF_A168219 WHERE FLD_STAFF_ID ='" & txt_id.Text & "'")

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