<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_customer_A168219
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_customer_A168219))
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.lst_customer = New System.Windows.Forms.ListBox()
        Me.pic_cust = New System.Windows.Forms.PictureBox()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.txt_path = New System.Windows.Forms.RichTextBox()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.btn_picture = New System.Windows.Forms.Button()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.txt_phone = New System.Windows.Forms.TextBox()
        Me.lbl_id1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.pic_cust, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_title.Image = CType(resources.GetObject("lbl_title.Image"), System.Drawing.Image)
        Me.lbl_title.Location = New System.Drawing.Point(12, 34)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(264, 56)
        Me.lbl_title.TabIndex = 8
        Me.lbl_title.Text = "Customers"
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.BackColor = System.Drawing.Color.Transparent
        Me.lbl_date.Location = New System.Drawing.Point(17, 496)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(58, 18)
        Me.lbl_date.TabIndex = 7
        Me.lbl_date.Text = "lbl_date"
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.MistyRose
        Me.btn_back.BackgroundImage = CType(resources.GetObject("btn_back.BackgroundImage"), System.Drawing.Image)
        Me.btn_back.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(720, 491)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(100, 33)
        Me.btn_back.TabIndex = 6
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.MistyRose
        Me.btn_exit.BackgroundImage = CType(resources.GetObject("btn_exit.BackgroundImage"), System.Drawing.Image)
        Me.btn_exit.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.Location = New System.Drawing.Point(826, 492)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(100, 32)
        Me.btn_exit.TabIndex = 5
        Me.btn_exit.Text = "EXIT"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'lst_customer
        '
        Me.lst_customer.BackColor = System.Drawing.Color.Thistle
        Me.lst_customer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lst_customer.FormattingEnabled = True
        Me.lst_customer.ItemHeight = 18
        Me.lst_customer.Location = New System.Drawing.Point(68, 113)
        Me.lst_customer.Name = "lst_customer"
        Me.lst_customer.Size = New System.Drawing.Size(168, 360)
        Me.lst_customer.TabIndex = 9
        '
        'pic_cust
        '
        Me.pic_cust.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_cust.Location = New System.Drawing.Point(264, 151)
        Me.pic_cust.Name = "pic_cust"
        Me.pic_cust.Size = New System.Drawing.Size(193, 232)
        Me.pic_cust.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_cust.TabIndex = 10
        Me.pic_cust.TabStop = False
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.MistyRose
        Me.btn_clear.BackgroundImage = CType(resources.GetObject("btn_clear.BackgroundImage"), System.Drawing.Image)
        Me.btn_clear.Location = New System.Drawing.Point(499, 436)
        Me.btn_clear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(88, 35)
        Me.btn_clear.TabIndex = 52
        Me.btn_clear.Text = "CLEAR"
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'txt_path
        '
        Me.txt_path.BackColor = System.Drawing.Color.MistyRose
        Me.txt_path.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_path.Location = New System.Drawing.Point(264, 390)
        Me.txt_path.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_path.Name = "txt_path"
        Me.txt_path.Size = New System.Drawing.Size(193, 33)
        Me.txt_path.TabIndex = 51
        Me.txt_path.Text = ""
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.MistyRose
        Me.btn_delete.BackgroundImage = CType(resources.GetObject("btn_delete.BackgroundImage"), System.Drawing.Image)
        Me.btn_delete.Location = New System.Drawing.Point(782, 435)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(87, 36)
        Me.btn_delete.TabIndex = 50
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.MistyRose
        Me.btn_update.BackgroundImage = CType(resources.GetObject("btn_update.BackgroundImage"), System.Drawing.Image)
        Me.btn_update.Location = New System.Drawing.Point(687, 434)
        Me.btn_update.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(89, 36)
        Me.btn_update.TabIndex = 49
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_insert
        '
        Me.btn_insert.BackColor = System.Drawing.Color.MistyRose
        Me.btn_insert.BackgroundImage = CType(resources.GetObject("btn_insert.BackgroundImage"), System.Drawing.Image)
        Me.btn_insert.Location = New System.Drawing.Point(593, 435)
        Me.btn_insert.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(88, 35)
        Me.btn_insert.TabIndex = 48
        Me.btn_insert.Text = "INSERT"
        Me.btn_insert.UseVisualStyleBackColor = False
        '
        'btn_picture
        '
        Me.btn_picture.BackColor = System.Drawing.Color.MistyRose
        Me.btn_picture.BackgroundImage = CType(resources.GetObject("btn_picture.BackgroundImage"), System.Drawing.Image)
        Me.btn_picture.Location = New System.Drawing.Point(264, 431)
        Me.btn_picture.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_picture.Name = "btn_picture"
        Me.btn_picture.Size = New System.Drawing.Size(193, 45)
        Me.btn_picture.TabIndex = 47
        Me.btn_picture.Text = "SELECT PICTURE"
        Me.btn_picture.UseVisualStyleBackColor = False
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(343, 113)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(30, 25)
        Me.lbl_id.TabIndex = 53
        Me.lbl_id.Text = "Id"
        '
        'txt_id
        '
        Me.txt_id.BackColor = System.Drawing.Color.LavenderBlush
        Me.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_id.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(593, 164)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(290, 29)
        Me.txt_id.TabIndex = 54
        Me.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_name
        '
        Me.txt_name.BackColor = System.Drawing.Color.LavenderBlush
        Me.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_name.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(593, 223)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(290, 29)
        Me.txt_name.TabIndex = 55
        Me.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_address
        '
        Me.txt_address.BackColor = System.Drawing.Color.LavenderBlush
        Me.txt_address.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_address.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_address.Location = New System.Drawing.Point(593, 284)
        Me.txt_address.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(290, 29)
        Me.txt_address.TabIndex = 56
        Me.txt_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_phone
        '
        Me.txt_phone.BackColor = System.Drawing.Color.LavenderBlush
        Me.txt_phone.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_phone.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_phone.Location = New System.Drawing.Point(593, 344)
        Me.txt_phone.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_phone.Name = "txt_phone"
        Me.txt_phone.Size = New System.Drawing.Size(290, 29)
        Me.txt_phone.TabIndex = 57
        Me.txt_phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_id1
        '
        Me.lbl_id1.AutoSize = True
        Me.lbl_id1.BackColor = System.Drawing.Color.Transparent
        Me.lbl_id1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id1.ForeColor = System.Drawing.Color.Snow
        Me.lbl_id1.Location = New System.Drawing.Point(457, 168)
        Me.lbl_id1.Name = "lbl_id1"
        Me.lbl_id1.Size = New System.Drawing.Size(136, 23)
        Me.lbl_id1.TabIndex = 58
        Me.lbl_id1.Text = "Customer ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Snow
        Me.Label1.Location = New System.Drawing.Point(511, 227)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 23)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Snow
        Me.Label2.Location = New System.Drawing.Point(499, 288)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 23)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Address:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label3.Location = New System.Drawing.Point(510, 348)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 23)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Phone:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frm_customer_A168219
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(933, 536)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_id1)
        Me.Controls.Add(Me.txt_phone)
        Me.Controls.Add(Me.txt_address)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.txt_path)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.btn_picture)
        Me.Controls.Add(Me.pic_cust)
        Me.Controls.Add(Me.lst_customer)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_exit)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_customer_A168219"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_customer_A168219"
        CType(Me.pic_cust, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_date As Label
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents lst_customer As ListBox
    Friend WithEvents pic_cust As PictureBox
    Friend WithEvents btn_clear As Button
    Friend WithEvents txt_path As RichTextBox
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_insert As Button
    Friend WithEvents btn_picture As Button
    Friend WithEvents lbl_id As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_address As TextBox
    Friend WithEvents txt_phone As TextBox
    Friend WithEvents lbl_id1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
