<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_products_A168219
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_products_A168219))
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lst_product = New System.Windows.Forms.ListBox()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_prodID = New System.Windows.Forms.TextBox()
        Me.txt_prodBrand = New System.Windows.Forms.TextBox()
        Me.txt_prodClasp = New System.Windows.Forms.TextBox()
        Me.txt_prodType = New System.Windows.Forms.TextBox()
        Me.txt_prodName = New System.Windows.Forms.RichTextBox()
        Me.btn_picture = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_prodColour = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_path = New System.Windows.Forms.RichTextBox()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.MistyRose
        Me.btn_exit.BackgroundImage = CType(resources.GetObject("btn_exit.BackgroundImage"), System.Drawing.Image)
        Me.btn_exit.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.Location = New System.Drawing.Point(821, 534)
        Me.btn_exit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(100, 31)
        Me.btn_exit.TabIndex = 1
        Me.btn_exit.Text = "EXIT"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.MistyRose
        Me.btn_back.BackgroundImage = CType(resources.GetObject("btn_back.BackgroundImage"), System.Drawing.Image)
        Me.btn_back.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(706, 533)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(100, 31)
        Me.btn_back.TabIndex = 2
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.BackColor = System.Drawing.Color.Transparent
        Me.lbl_date.Location = New System.Drawing.Point(39, 544)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(68, 20)
        Me.lbl_date.TabIndex = 3
        Me.lbl_date.Text = "lbl_date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(24, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(475, 56)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Products Catalogue"
        '
        'lst_product
        '
        Me.lst_product.BackColor = System.Drawing.Color.Thistle
        Me.lst_product.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lst_product.FormattingEnabled = True
        Me.lst_product.ItemHeight = 20
        Me.lst_product.Location = New System.Drawing.Point(43, 102)
        Me.lst_product.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lst_product.Name = "lst_product"
        Me.lst_product.Size = New System.Drawing.Size(148, 400)
        Me.lst_product.TabIndex = 14
        '
        'pic_product
        '
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_product.Location = New System.Drawing.Point(209, 136)
        Me.pic_product.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(264, 325)
        Me.pic_product.TabIndex = 25
        Me.pic_product.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Location = New System.Drawing.Point(721, 271)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 37)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Type"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(508, 271)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 37)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Clasp"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label5.Location = New System.Drawing.Point(721, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 37)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Brand"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label6.Location = New System.Drawing.Point(508, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 37)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "ID"
        '
        'txt_prodID
        '
        Me.txt_prodID.BackColor = System.Drawing.Color.LavenderBlush
        Me.txt_prodID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_prodID.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_prodID.Location = New System.Drawing.Point(508, 233)
        Me.txt_prodID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_prodID.Name = "txt_prodID"
        Me.txt_prodID.Size = New System.Drawing.Size(168, 29)
        Me.txt_prodID.TabIndex = 31
        Me.txt_prodID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_prodBrand
        '
        Me.txt_prodBrand.BackColor = System.Drawing.Color.LavenderBlush
        Me.txt_prodBrand.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_prodBrand.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_prodBrand.Location = New System.Drawing.Point(724, 233)
        Me.txt_prodBrand.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_prodBrand.Name = "txt_prodBrand"
        Me.txt_prodBrand.Size = New System.Drawing.Size(168, 29)
        Me.txt_prodBrand.TabIndex = 32
        Me.txt_prodBrand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_prodClasp
        '
        Me.txt_prodClasp.BackColor = System.Drawing.Color.LavenderBlush
        Me.txt_prodClasp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_prodClasp.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_prodClasp.Location = New System.Drawing.Point(508, 311)
        Me.txt_prodClasp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_prodClasp.Name = "txt_prodClasp"
        Me.txt_prodClasp.Size = New System.Drawing.Size(168, 29)
        Me.txt_prodClasp.TabIndex = 33
        Me.txt_prodClasp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_prodType
        '
        Me.txt_prodType.BackColor = System.Drawing.Color.LavenderBlush
        Me.txt_prodType.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_prodType.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_prodType.Location = New System.Drawing.Point(728, 311)
        Me.txt_prodType.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_prodType.Name = "txt_prodType"
        Me.txt_prodType.Size = New System.Drawing.Size(168, 29)
        Me.txt_prodType.TabIndex = 34
        Me.txt_prodType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_prodName
        '
        Me.txt_prodName.BackColor = System.Drawing.Color.LavenderBlush
        Me.txt_prodName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_prodName.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_prodName.Location = New System.Drawing.Point(508, 134)
        Me.txt_prodName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_prodName.Name = "txt_prodName"
        Me.txt_prodName.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txt_prodName.Size = New System.Drawing.Size(384, 56)
        Me.txt_prodName.TabIndex = 35
        Me.txt_prodName.Text = ""
        '
        'btn_picture
        '
        Me.btn_picture.BackColor = System.Drawing.Color.MistyRose
        Me.btn_picture.BackgroundImage = CType(resources.GetObject("btn_picture.BackgroundImage"), System.Drawing.Image)
        Me.btn_picture.Location = New System.Drawing.Point(209, 508)
        Me.btn_picture.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_picture.Name = "btn_picture"
        Me.btn_picture.Size = New System.Drawing.Size(264, 45)
        Me.btn_picture.TabIndex = 37
        Me.btn_picture.Text = "SELECT PICTURE"
        Me.btn_picture.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.MistyRose
        Me.btn_delete.BackgroundImage = CType(resources.GetObject("btn_delete.BackgroundImage"), System.Drawing.Image)
        Me.btn_delete.Location = New System.Drawing.Point(813, 468)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(87, 36)
        Me.btn_delete.TabIndex = 40
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.MistyRose
        Me.btn_update.BackgroundImage = CType(resources.GetObject("btn_update.BackgroundImage"), System.Drawing.Image)
        Me.btn_update.Location = New System.Drawing.Point(718, 467)
        Me.btn_update.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(89, 36)
        Me.btn_update.TabIndex = 39
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_insert
        '
        Me.btn_insert.BackColor = System.Drawing.Color.MistyRose
        Me.btn_insert.BackgroundImage = CType(resources.GetObject("btn_insert.BackgroundImage"), System.Drawing.Image)
        Me.btn_insert.Location = New System.Drawing.Point(624, 468)
        Me.btn_insert.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(88, 35)
        Me.btn_insert.TabIndex = 38
        Me.btn_insert.Text = "INSERT"
        Me.btn_insert.UseVisualStyleBackColor = False
        '
        'txt_price
        '
        Me.txt_price.BackColor = System.Drawing.Color.LavenderBlush
        Me.txt_price.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_price.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_price.Location = New System.Drawing.Point(508, 382)
        Me.txt_price.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(168, 29)
        Me.txt_price.TabIndex = 42
        Me.txt_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label7.Location = New System.Drawing.Point(508, 342)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 37)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Price"
        '
        'txt_prodColour
        '
        Me.txt_prodColour.BackColor = System.Drawing.Color.LavenderBlush
        Me.txt_prodColour.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_prodColour.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_prodColour.Location = New System.Drawing.Point(731, 382)
        Me.txt_prodColour.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_prodColour.Name = "txt_prodColour"
        Me.txt_prodColour.Size = New System.Drawing.Size(168, 29)
        Me.txt_prodColour.TabIndex = 44
        Me.txt_prodColour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label8.Location = New System.Drawing.Point(730, 342)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 37)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Colour"
        '
        'txt_path
        '
        Me.txt_path.BackColor = System.Drawing.Color.MistyRose
        Me.txt_path.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_path.Location = New System.Drawing.Point(210, 467)
        Me.txt_path.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_path.Name = "txt_path"
        Me.txt_path.Size = New System.Drawing.Size(263, 33)
        Me.txt_path.TabIndex = 45
        Me.txt_path.Text = ""
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.MistyRose
        Me.btn_clear.BackgroundImage = CType(resources.GetObject("btn_clear.BackgroundImage"), System.Drawing.Image)
        Me.btn_clear.Location = New System.Drawing.Point(530, 469)
        Me.btn_clear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(88, 35)
        Me.btn_clear.TabIndex = 46
        Me.btn_clear.Text = "CLEAR"
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frm_products_A168219
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(933, 575)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.txt_path)
        Me.Controls.Add(Me.txt_prodColour)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.btn_picture)
        Me.Controls.Add(Me.txt_prodName)
        Me.Controls.Add(Me.txt_prodType)
        Me.Controls.Add(Me.txt_prodClasp)
        Me.Controls.Add(Me.txt_prodBrand)
        Me.Controls.Add(Me.txt_prodID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.lst_product)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_exit)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frm_products_A168219"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Products"
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_back As Button
    Friend WithEvents lbl_date As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lst_product As ListBox
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_prodID As TextBox
    Friend WithEvents txt_prodBrand As TextBox
    Friend WithEvents txt_prodClasp As TextBox
    Friend WithEvents txt_prodType As TextBox
    Friend WithEvents txt_prodName As RichTextBox
    Friend WithEvents btn_picture As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_insert As Button
    Friend WithEvents txt_price As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_prodColour As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_path As RichTextBox
    Friend WithEvents btn_clear As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
