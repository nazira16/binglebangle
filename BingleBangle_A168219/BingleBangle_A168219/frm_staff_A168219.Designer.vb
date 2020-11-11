<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_staff_A168219
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_staff_A168219))
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_id1 = New System.Windows.Forms.Label()
        Me.txt_gender = New System.Windows.Forms.TextBox()
        Me.txt_lname = New System.Windows.Forms.TextBox()
        Me.txt_fname = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.txt_path = New System.Windows.Forms.RichTextBox()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.btn_picture = New System.Windows.Forms.Button()
        Me.pic_staff = New System.Windows.Forms.PictureBox()
        Me.lst_staff = New System.Windows.Forms.ListBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.pic_staff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_title.Image = CType(resources.GetObject("lbl_title.Image"), System.Drawing.Image)
        Me.lbl_title.Location = New System.Drawing.Point(12, 32)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(171, 56)
        Me.lbl_title.TabIndex = 5
        Me.lbl_title.Text = "S t a f f"
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.BackColor = System.Drawing.Color.Transparent
        Me.lbl_date.Location = New System.Drawing.Point(15, 553)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(68, 20)
        Me.lbl_date.TabIndex = 8
        Me.lbl_date.Text = "lbl_date"
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.MistyRose
        Me.btn_back.BackgroundImage = CType(resources.GetObject("btn_back.BackgroundImage"), System.Drawing.Image)
        Me.btn_back.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(718, 546)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(100, 30)
        Me.btn_back.TabIndex = 7
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.MistyRose
        Me.btn_exit.BackgroundImage = CType(resources.GetObject("btn_exit.BackgroundImage"), System.Drawing.Image)
        Me.btn_exit.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.Location = New System.Drawing.Point(824, 546)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(100, 30)
        Me.btn_exit.TabIndex = 6
        Me.btn_exit.Text = "EXIT"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label3.Location = New System.Drawing.Point(486, 344)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 23)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Gender:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Snow
        Me.Label2.Location = New System.Drawing.Point(459, 284)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 23)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Last Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Snow
        Me.Label1.Location = New System.Drawing.Point(460, 223)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 23)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "First Name:"
        '
        'lbl_id1
        '
        Me.lbl_id1.AutoSize = True
        Me.lbl_id1.BackColor = System.Drawing.Color.Transparent
        Me.lbl_id1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id1.ForeColor = System.Drawing.Color.Snow
        Me.lbl_id1.Location = New System.Drawing.Point(495, 164)
        Me.lbl_id1.Name = "lbl_id1"
        Me.lbl_id1.Size = New System.Drawing.Size(83, 23)
        Me.lbl_id1.TabIndex = 75
        Me.lbl_id1.Text = "Staff ID:"
        '
        'txt_gender
        '
        Me.txt_gender.BackColor = System.Drawing.Color.LavenderBlush
        Me.txt_gender.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_gender.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_gender.Location = New System.Drawing.Point(584, 344)
        Me.txt_gender.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_gender.Name = "txt_gender"
        Me.txt_gender.Size = New System.Drawing.Size(290, 29)
        Me.txt_gender.TabIndex = 74
        Me.txt_gender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_lname
        '
        Me.txt_lname.BackColor = System.Drawing.Color.LavenderBlush
        Me.txt_lname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_lname.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lname.Location = New System.Drawing.Point(584, 284)
        Me.txt_lname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_lname.Name = "txt_lname"
        Me.txt_lname.Size = New System.Drawing.Size(290, 29)
        Me.txt_lname.TabIndex = 73
        Me.txt_lname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_fname
        '
        Me.txt_fname.BackColor = System.Drawing.Color.LavenderBlush
        Me.txt_fname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_fname.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fname.Location = New System.Drawing.Point(584, 223)
        Me.txt_fname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.Size = New System.Drawing.Size(290, 29)
        Me.txt_fname.TabIndex = 72
        Me.txt_fname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_id
        '
        Me.txt_id.BackColor = System.Drawing.Color.LavenderBlush
        Me.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_id.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(584, 164)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(290, 29)
        Me.txt_id.TabIndex = 71
        Me.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(334, 113)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(30, 25)
        Me.lbl_id.TabIndex = 70
        Me.lbl_id.Text = "Id"
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.MistyRose
        Me.btn_clear.BackgroundImage = CType(resources.GetObject("btn_clear.BackgroundImage"), System.Drawing.Image)
        Me.btn_clear.Location = New System.Drawing.Point(490, 436)
        Me.btn_clear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(88, 35)
        Me.btn_clear.TabIndex = 69
        Me.btn_clear.Text = "CLEAR"
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'txt_path
        '
        Me.txt_path.BackColor = System.Drawing.Color.MistyRose
        Me.txt_path.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_path.Location = New System.Drawing.Point(255, 390)
        Me.txt_path.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_path.Name = "txt_path"
        Me.txt_path.Size = New System.Drawing.Size(193, 33)
        Me.txt_path.TabIndex = 68
        Me.txt_path.Text = ""
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.MistyRose
        Me.btn_delete.BackgroundImage = CType(resources.GetObject("btn_delete.BackgroundImage"), System.Drawing.Image)
        Me.btn_delete.Location = New System.Drawing.Point(773, 435)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(87, 36)
        Me.btn_delete.TabIndex = 67
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.MistyRose
        Me.btn_update.BackgroundImage = CType(resources.GetObject("btn_update.BackgroundImage"), System.Drawing.Image)
        Me.btn_update.Location = New System.Drawing.Point(678, 434)
        Me.btn_update.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(89, 36)
        Me.btn_update.TabIndex = 66
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_insert
        '
        Me.btn_insert.BackColor = System.Drawing.Color.MistyRose
        Me.btn_insert.BackgroundImage = CType(resources.GetObject("btn_insert.BackgroundImage"), System.Drawing.Image)
        Me.btn_insert.Location = New System.Drawing.Point(584, 435)
        Me.btn_insert.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(88, 35)
        Me.btn_insert.TabIndex = 65
        Me.btn_insert.Text = "INSERT"
        Me.btn_insert.UseVisualStyleBackColor = False
        '
        'btn_picture
        '
        Me.btn_picture.BackColor = System.Drawing.Color.MistyRose
        Me.btn_picture.BackgroundImage = CType(resources.GetObject("btn_picture.BackgroundImage"), System.Drawing.Image)
        Me.btn_picture.Location = New System.Drawing.Point(255, 431)
        Me.btn_picture.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_picture.Name = "btn_picture"
        Me.btn_picture.Size = New System.Drawing.Size(193, 45)
        Me.btn_picture.TabIndex = 64
        Me.btn_picture.Text = "SELECT PICTURE"
        Me.btn_picture.UseVisualStyleBackColor = False
        '
        'pic_staff
        '
        Me.pic_staff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_staff.Location = New System.Drawing.Point(255, 151)
        Me.pic_staff.Name = "pic_staff"
        Me.pic_staff.Size = New System.Drawing.Size(193, 232)
        Me.pic_staff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_staff.TabIndex = 63
        Me.pic_staff.TabStop = False
        '
        'lst_staff
        '
        Me.lst_staff.BackColor = System.Drawing.Color.Thistle
        Me.lst_staff.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lst_staff.FormattingEnabled = True
        Me.lst_staff.ItemHeight = 20
        Me.lst_staff.Location = New System.Drawing.Point(59, 113)
        Me.lst_staff.Name = "lst_staff"
        Me.lst_staff.Size = New System.Drawing.Size(168, 360)
        Me.lst_staff.TabIndex = 62
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frm_staff_A168219
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(933, 588)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_id1)
        Me.Controls.Add(Me.txt_gender)
        Me.Controls.Add(Me.txt_lname)
        Me.Controls.Add(Me.txt_fname)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.txt_path)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.btn_picture)
        Me.Controls.Add(Me.pic_staff)
        Me.Controls.Add(Me.lst_staff)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.lbl_title)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frm_staff_A168219"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_staff_A168219"
        CType(Me.pic_staff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_date As Label
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_id1 As Label
    Friend WithEvents txt_gender As TextBox
    Friend WithEvents txt_lname As TextBox
    Friend WithEvents txt_fname As TextBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents lbl_id As Label
    Friend WithEvents btn_clear As Button
    Friend WithEvents txt_path As RichTextBox
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_insert As Button
    Friend WithEvents btn_picture As Button
    Friend WithEvents pic_staff As PictureBox
    Friend WithEvents lst_staff As ListBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
