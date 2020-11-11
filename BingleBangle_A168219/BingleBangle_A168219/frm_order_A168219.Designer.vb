<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_order_A168219
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_order_A168219))
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.lst_product = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.numeric = New System.Windows.Forms.NumericUpDown()
        Me.btn_cart = New System.Windows.Forms.Button()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_type = New System.Windows.Forms.TextBox()
        Me.txt_colour = New System.Windows.Forms.TextBox()
        Me.txt_clasp = New System.Windows.Forms.TextBox()
        Me.txt_brand = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_order = New System.Windows.Forms.Button()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbl_order = New System.Windows.Forms.Label()
        Me.grd_order = New System.Windows.Forms.DataGridView()
        Me.ProductID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmb_staff = New System.Windows.Forms.ComboBox()
        Me.cmb_customer = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btn_remove = New System.Windows.Forms.Button()
        Me.btn_confirm = New System.Windows.Forms.Button()
        Me.btn_invoice = New System.Windows.Forms.Button()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_title2 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_date = New System.Windows.Forms.TextBox()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.numeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.BackColor = System.Drawing.Color.Transparent
        Me.lbl_date.Location = New System.Drawing.Point(12, 553)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(68, 20)
        Me.lbl_date.TabIndex = 11
        Me.lbl_date.Text = "lbl_date"
        '
        'pic_product
        '
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_product.Location = New System.Drawing.Point(32, 46)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(154, 184)
        Me.pic_product.TabIndex = 12
        Me.pic_product.TabStop = False
        '
        'lst_product
        '
        Me.lst_product.FormattingEnabled = True
        Me.lst_product.ItemHeight = 20
        Me.lst_product.Location = New System.Drawing.Point(32, 247)
        Me.lst_product.Name = "lst_product"
        Me.lst_product.Size = New System.Drawing.Size(154, 284)
        Me.lst_product.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.numeric)
        Me.GroupBox1.Controls.Add(Me.btn_cart)
        Me.GroupBox1.Controls.Add(Me.lbl_id)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_total)
        Me.GroupBox1.Controls.Add(Me.txt_price)
        Me.GroupBox1.Controls.Add(Me.txt_type)
        Me.GroupBox1.Controls.Add(Me.txt_colour)
        Me.GroupBox1.Controls.Add(Me.txt_clasp)
        Me.GroupBox1.Controls.Add(Me.txt_brand)
        Me.GroupBox1.Controls.Add(Me.txt_name)
        Me.GroupBox1.Location = New System.Drawing.Point(226, 107)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(408, 424)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'numeric
        '
        Me.numeric.Location = New System.Drawing.Point(98, 330)
        Me.numeric.Name = "numeric"
        Me.numeric.Size = New System.Drawing.Size(96, 26)
        Me.numeric.TabIndex = 19
        '
        'btn_cart
        '
        Me.btn_cart.Location = New System.Drawing.Point(118, 381)
        Me.btn_cart.Name = "btn_cart"
        Me.btn_cart.Size = New System.Drawing.Size(207, 37)
        Me.btn_cart.TabIndex = 18
        Me.btn_cart.Text = "ADD TO CART"
        Me.btn_cart.UseVisualStyleBackColor = True
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(114, 22)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(25, 20)
        Me.lbl_id.TabIndex = 17
        Me.lbl_id.Text = "ID"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(200, 330)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 20)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Total (RM):"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 330)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Quantity:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 288)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 20)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Price (RM):"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 243)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Type:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Colour:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Clasp:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Brand:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Product ID:"
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(290, 327)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(93, 26)
        Me.txt_total.TabIndex = 7
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(100, 282)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(283, 26)
        Me.txt_price.TabIndex = 5
        '
        'txt_type
        '
        Me.txt_type.Location = New System.Drawing.Point(100, 240)
        Me.txt_type.Name = "txt_type"
        Me.txt_type.Size = New System.Drawing.Size(283, 26)
        Me.txt_type.TabIndex = 4
        '
        'txt_colour
        '
        Me.txt_colour.Location = New System.Drawing.Point(100, 193)
        Me.txt_colour.Name = "txt_colour"
        Me.txt_colour.Size = New System.Drawing.Size(283, 26)
        Me.txt_colour.TabIndex = 3
        '
        'txt_clasp
        '
        Me.txt_clasp.Location = New System.Drawing.Point(100, 148)
        Me.txt_clasp.Name = "txt_clasp"
        Me.txt_clasp.Size = New System.Drawing.Size(283, 26)
        Me.txt_clasp.TabIndex = 2
        '
        'txt_brand
        '
        Me.txt_brand.Location = New System.Drawing.Point(100, 99)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.Size = New System.Drawing.Size(283, 26)
        Me.txt_brand.TabIndex = 1
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(100, 54)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(283, 26)
        Me.txt_name.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_order)
        Me.GroupBox2.Controls.Add(Me.lbl_total)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.lbl_order)
        Me.GroupBox2.Controls.Add(Me.grd_order)
        Me.GroupBox2.Location = New System.Drawing.Point(723, 206)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(455, 286)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Make Order"
        '
        'btn_order
        '
        Me.btn_order.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_order.Location = New System.Drawing.Point(348, 25)
        Me.btn_order.Name = "btn_order"
        Me.btn_order.Size = New System.Drawing.Size(96, 30)
        Me.btn_order.TabIndex = 29
        Me.btn_order.Text = "New Order"
        Me.btn_order.UseVisualStyleBackColor = True
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Location = New System.Drawing.Point(379, 254)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(65, 20)
        Me.lbl_total.TabIndex = 22
        Me.lbl_total.Text = "Label14"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(291, 254)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 20)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "TOTAL: RM"
        '
        'lbl_order
        '
        Me.lbl_order.AutoSize = True
        Me.lbl_order.Location = New System.Drawing.Point(7, 30)
        Me.lbl_order.Name = "lbl_order"
        Me.lbl_order.Size = New System.Drawing.Size(83, 20)
        Me.lbl_order.TabIndex = 20
        Me.lbl_order.Text = "ORDER ID:"
        '
        'grd_order
        '
        Me.grd_order.AllowUserToAddRows = False
        Me.grd_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_order.BackgroundColor = System.Drawing.Color.Thistle
        Me.grd_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_order.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductID, Me.ProductName, Me.Quantity, Me.Amount})
        Me.grd_order.Location = New System.Drawing.Point(11, 61)
        Me.grd_order.Name = "grd_order"
        Me.grd_order.RowTemplate.Height = 24
        Me.grd_order.Size = New System.Drawing.Size(438, 171)
        Me.grd_order.TabIndex = 0
        '
        'ProductID
        '
        Me.ProductID.FillWeight = 81.21828!
        Me.ProductID.HeaderText = "ID"
        Me.ProductID.Name = "ProductID"
        '
        'ProductName
        '
        Me.ProductName.FillWeight = 106.2606!
        Me.ProductName.HeaderText = "Product Name"
        Me.ProductName.Name = "ProductName"
        '
        'Quantity
        '
        Me.Quantity.FillWeight = 106.2606!
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        '
        'Amount
        '
        Me.Amount.FillWeight = 106.2606!
        Me.Amount.HeaderText = "Total (RM)"
        Me.Amount.Name = "Amount"
        '
        'cmb_staff
        '
        Me.cmb_staff.FormattingEnabled = True
        Me.cmb_staff.Location = New System.Drawing.Point(723, 107)
        Me.cmb_staff.Name = "cmb_staff"
        Me.cmb_staff.Size = New System.Drawing.Size(193, 28)
        Me.cmb_staff.TabIndex = 16
        '
        'cmb_customer
        '
        Me.cmb_customer.FormattingEnabled = True
        Me.cmb_customer.Location = New System.Drawing.Point(959, 107)
        Me.cmb_customer.Name = "cmb_customer"
        Me.cmb_customer.Size = New System.Drawing.Size(213, 28)
        Me.cmb_customer.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(721, 84)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 20)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Staff ID:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(955, 84)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 20)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Customer ID:"
        '
        'btn_remove
        '
        Me.btn_remove.Location = New System.Drawing.Point(797, 510)
        Me.btn_remove.Name = "btn_remove"
        Me.btn_remove.Size = New System.Drawing.Size(90, 30)
        Me.btn_remove.TabIndex = 21
        Me.btn_remove.Text = "REMOVE"
        Me.btn_remove.UseVisualStyleBackColor = True
        '
        'btn_confirm
        '
        Me.btn_confirm.Location = New System.Drawing.Point(910, 510)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(90, 30)
        Me.btn_confirm.TabIndex = 22
        Me.btn_confirm.Text = "CONFIRM"
        Me.btn_confirm.UseVisualStyleBackColor = True
        '
        'btn_invoice
        '
        Me.btn_invoice.Location = New System.Drawing.Point(1018, 510)
        Me.btn_invoice.Name = "btn_invoice"
        Me.btn_invoice.Size = New System.Drawing.Size(90, 30)
        Me.btn_invoice.TabIndex = 23
        Me.btn_invoice.Text = "INVOICE"
        Me.btn_invoice.UseVisualStyleBackColor = True
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Century Schoolbook", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(239, 34)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(417, 39)
        Me.lbl_title.TabIndex = 24
        Me.lbl_title.Text = "B I N G L E   B A N G L E"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_title2
        '
        Me.lbl_title2.AutoSize = True
        Me.lbl_title2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title2.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title2.Location = New System.Drawing.Point(317, 74)
        Me.lbl_title2.Name = "lbl_title2"
        Me.lbl_title2.Size = New System.Drawing.Size(254, 23)
        Me.lbl_title2.TabIndex = 25
        Me.lbl_title2.Text = "J   E   W   E   L   L   E   R   Y"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(719, 135)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 20)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Order Date:"
        '
        'txt_date
        '
        Me.txt_date.Location = New System.Drawing.Point(725, 161)
        Me.txt_date.Name = "txt_date"
        Me.txt_date.Size = New System.Drawing.Size(447, 26)
        Me.txt_date.TabIndex = 28
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.MistyRose
        Me.btn_back.BackgroundImage = CType(resources.GetObject("btn_back.BackgroundImage"), System.Drawing.Image)
        Me.btn_back.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(1025, 552)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(100, 33)
        Me.btn_back.TabIndex = 30
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.MistyRose
        Me.btn_exit.BackgroundImage = CType(resources.GetObject("btn_exit.BackgroundImage"), System.Drawing.Image)
        Me.btn_exit.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.Location = New System.Drawing.Point(1131, 553)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(100, 32)
        Me.btn_exit.TabIndex = 29
        Me.btn_exit.Text = "EXIT"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'frm_order_A168219
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1233, 588)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.txt_date)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lbl_title2)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.btn_invoice)
        Me.Controls.Add(Me.btn_confirm)
        Me.Controls.Add(Me.btn_remove)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmb_customer)
        Me.Controls.Add(Me.cmb_staff)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lst_product)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.lbl_date)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frm_order_A168219"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Make Order"
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.numeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_date As Label
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents lst_product As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_total As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_type As TextBox
    Friend WithEvents txt_colour As TextBox
    Friend WithEvents txt_clasp As TextBox
    Friend WithEvents txt_brand As TextBox
    Friend WithEvents lbl_id As Label
    Friend WithEvents btn_cart As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents grd_order As DataGridView
    Friend WithEvents cmb_staff As ComboBox
    Friend WithEvents cmb_customer As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btn_remove As Button
    Friend WithEvents btn_confirm As Button
    Friend WithEvents btn_invoice As Button
    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_title2 As Label
    Friend WithEvents numeric As NumericUpDown
    Friend WithEvents Label12 As Label
    Friend WithEvents lbl_order As Label
    Friend WithEvents lbl_total As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_date As TextBox
    Friend WithEvents ProductID As DataGridViewTextBoxColumn
    Friend WithEvents ProductName As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Amount As DataGridViewTextBoxColumn
    Friend WithEvents btn_order As Button
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_exit As Button
End Class
