namespace BookStoreMgt.Forms
{
    partial class FmSale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmSale));
            panel1 = new Panel();
            cbApplyDiscount = new CheckBox();
            pnlCalcDiscount = new Panel();
            label8 = new Label();
            btnApplyDiscount = new Button();
            txtDiscountValue = new TextBox();
            panel2 = new Panel();
            btnCancelBuying = new Button();
            btnFinishShop = new Button();
            txtPriceTotalSale = new TextBox();
            label2 = new Label();
            dgvShoppingCart = new DataGridView();
            dgvShopping_idProd = new DataGridViewTextBoxColumn();
            dgvShopping_isbn = new DataGridViewTextBoxColumn();
            dgvShopping_nameProd = new DataGridViewTextBoxColumn();
            dgvShopping_amount = new DataGridViewTextBoxColumn();
            dgvShopping_Mountaint = new DataGridViewTextBoxColumn();
            label1 = new Label();
            pnlPartSeachProd = new Panel();
            btnCloseCustomerDetails = new Button();
            pnlCustomerDetails = new Panel();
            txtTPNo = new TextBox();
            label9 = new Label();
            txtAddress = new TextBox();
            label10 = new Label();
            txtAge = new TextBox();
            label11 = new Label();
            txtCustomerName = new TextBox();
            label12 = new Label();
            btnAddCustomerDetails = new Button();
            pnlQuantProd = new Panel();
            txtPriceProd = new TextBox();
            label7 = new Label();
            txtAmountProd = new TextBox();
            label6 = new Label();
            txtNameProd = new TextBox();
            label5 = new Label();
            txtIsbnProd = new TextBox();
            label4 = new Label();
            txtIdProd = new TextBox();
            label3 = new Label();
            btnCancelAddCart = new Button();
            btnAddToCart = new Button();
            dgvSearchProd = new DataGridView();
            panel4 = new Panel();
            groupBox1 = new GroupBox();
            btnSearchBookSale = new Button();
            mtxtSearchBookSale = new MaskedTextBox();
            pnlDgvSearchPro = new Panel();
            panel1.SuspendLayout();
            pnlCalcDiscount.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvShoppingCart).BeginInit();
            pnlPartSeachProd.SuspendLayout();
            pnlCustomerDetails.SuspendLayout();
            pnlQuantProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSearchProd).BeginInit();
            panel4.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(cbApplyDiscount);
            panel1.Controls.Add(pnlCalcDiscount);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dgvShoppingCart);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(557, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(668, 692);
            panel1.TabIndex = 0;
            // 
            // cbApplyDiscount
            // 
            cbApplyDiscount.AutoSize = true;
            cbApplyDiscount.Location = new Point(278, 344);
            cbApplyDiscount.Margin = new Padding(4, 3, 4, 3);
            cbApplyDiscount.Name = "cbApplyDiscount";
            cbApplyDiscount.Size = new Size(106, 19);
            cbApplyDiscount.TabIndex = 4;
            cbApplyDiscount.Text = "Apply discount";
            cbApplyDiscount.UseVisualStyleBackColor = true;
            cbApplyDiscount.CheckedChanged += cbApplyDiscount_CheckedChanged;
            cbApplyDiscount.Click += cbApplyDiscount_Click;
            // 
            // pnlCalcDiscount
            // 
            pnlCalcDiscount.Controls.Add(label8);
            pnlCalcDiscount.Controls.Add(btnApplyDiscount);
            pnlCalcDiscount.Controls.Add(txtDiscountValue);
            pnlCalcDiscount.Location = new Point(29, 370);
            pnlCalcDiscount.Margin = new Padding(4, 3, 4, 3);
            pnlCalcDiscount.Name = "pnlCalcDiscount";
            pnlCalcDiscount.Size = new Size(608, 115);
            pnlCalcDiscount.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(382, 13);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(25, 22);
            label8.TabIndex = 5;
            label8.Text = "%";
            // 
            // btnApplyDiscount
            // 
            btnApplyDiscount.BackColor = Color.FromArgb(9, 147, 55);
            btnApplyDiscount.Cursor = Cursors.Hand;
            btnApplyDiscount.FlatAppearance.BorderSize = 0;
            btnApplyDiscount.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnApplyDiscount.FlatStyle = FlatStyle.Flat;
            btnApplyDiscount.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApplyDiscount.ForeColor = Color.White;
            btnApplyDiscount.Image = (Image)resources.GetObject("btnApplyDiscount.Image");
            btnApplyDiscount.Location = new Point(231, 53);
            btnApplyDiscount.Margin = new Padding(4, 3, 4, 3);
            btnApplyDiscount.Name = "btnApplyDiscount";
            btnApplyDiscount.Size = new Size(145, 50);
            btnApplyDiscount.TabIndex = 14;
            btnApplyDiscount.Text = "Apply";
            btnApplyDiscount.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnApplyDiscount.UseVisualStyleBackColor = false;
            btnApplyDiscount.Click += btnApplyDiscount_Click;
            // 
            // txtDiscountValue
            // 
            txtDiscountValue.BackColor = SystemColors.ControlLightLight;
            txtDiscountValue.BorderStyle = BorderStyle.None;
            txtDiscountValue.Font = new Font("Century Gothic", 18F);
            txtDiscountValue.ForeColor = Color.DarkRed;
            txtDiscountValue.Location = new Point(233, 6);
            txtDiscountValue.Margin = new Padding(4, 3, 4, 3);
            txtDiscountValue.MaxLength = 2;
            txtDiscountValue.Name = "txtDiscountValue";
            txtDiscountValue.Size = new Size(141, 30);
            txtDiscountValue.TabIndex = 13;
            txtDiscountValue.TextAlign = HorizontalAlignment.Center;
            txtDiscountValue.TextChanged += txtDiscountValue_TextChanged;
            txtDiscountValue.KeyPress += txtDiscountValue_KeyPress;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCancelBuying);
            panel2.Controls.Add(btnFinishShop);
            panel2.Controls.Add(txtPriceTotalSale);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(29, 493);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(608, 186);
            panel2.TabIndex = 2;
            // 
            // btnCancelBuying
            // 
            btnCancelBuying.BackColor = Color.FromArgb(192, 0, 0);
            btnCancelBuying.Cursor = Cursors.Hand;
            btnCancelBuying.FlatAppearance.BorderSize = 0;
            btnCancelBuying.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnCancelBuying.FlatStyle = FlatStyle.Flat;
            btnCancelBuying.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelBuying.ForeColor = Color.White;
            btnCancelBuying.Image = (Image)resources.GetObject("btnCancelBuying.Image");
            btnCancelBuying.Location = new Point(387, 117);
            btnCancelBuying.Margin = new Padding(4, 3, 4, 3);
            btnCancelBuying.Name = "btnCancelBuying";
            btnCancelBuying.Size = new Size(145, 50);
            btnCancelBuying.TabIndex = 3;
            btnCancelBuying.Text = "Cancel";
            btnCancelBuying.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelBuying.UseVisualStyleBackColor = false;
            btnCancelBuying.Click += button1_Click;
            // 
            // btnFinishShop
            // 
            btnFinishShop.BackColor = Color.FromArgb(9, 147, 55);
            btnFinishShop.Cursor = Cursors.Hand;
            btnFinishShop.FlatAppearance.BorderSize = 0;
            btnFinishShop.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnFinishShop.FlatStyle = FlatStyle.Flat;
            btnFinishShop.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFinishShop.ForeColor = Color.White;
            btnFinishShop.Image = (Image)resources.GetObject("btnFinishShop.Image");
            btnFinishShop.Location = new Point(197, 117);
            btnFinishShop.Margin = new Padding(4, 3, 4, 3);
            btnFinishShop.Name = "btnFinishShop";
            btnFinishShop.Size = new Size(145, 50);
            btnFinishShop.TabIndex = 2;
            btnFinishShop.Text = "Finish";
            btnFinishShop.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFinishShop.UseVisualStyleBackColor = false;
            btnFinishShop.Click += btnFinishShop_Click;
            // 
            // txtPriceTotalSale
            // 
            txtPriceTotalSale.BackColor = SystemColors.ControlLightLight;
            txtPriceTotalSale.BorderStyle = BorderStyle.None;
            txtPriceTotalSale.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPriceTotalSale.ForeColor = Color.DarkRed;
            txtPriceTotalSale.Location = new Point(154, 51);
            txtPriceTotalSale.Margin = new Padding(4, 3, 4, 3);
            txtPriceTotalSale.Name = "txtPriceTotalSale";
            txtPriceTotalSale.ReadOnly = true;
            txtPriceTotalSale.Size = new Size(419, 30);
            txtPriceTotalSale.TabIndex = 1;
            txtPriceTotalSale.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 60);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(96, 21);
            label2.TabIndex = 0;
            label2.Text = "Total price:";
            // 
            // dgvShoppingCart
            // 
            dgvShoppingCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShoppingCart.Columns.AddRange(new DataGridViewColumn[] { dgvShopping_idProd, dgvShopping_isbn, dgvShopping_nameProd, dgvShopping_amount, dgvShopping_Mountaint });
            dgvShoppingCart.Location = new Point(29, 53);
            dgvShoppingCart.Margin = new Padding(4, 3, 4, 3);
            dgvShoppingCart.Name = "dgvShoppingCart";
            dgvShoppingCart.ReadOnly = true;
            dgvShoppingCart.RowHeadersVisible = false;
            dgvShoppingCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvShoppingCart.Size = new Size(608, 233);
            dgvShoppingCart.TabIndex = 1;
            // 
            // dgvShopping_idProd
            // 
            dgvShopping_idProd.HeaderText = "Id";
            dgvShopping_idProd.Name = "dgvShopping_idProd";
            dgvShopping_idProd.ReadOnly = true;
            // 
            // dgvShopping_isbn
            // 
            dgvShopping_isbn.HeaderText = "ISBN";
            dgvShopping_isbn.Name = "dgvShopping_isbn";
            dgvShopping_isbn.ReadOnly = true;
            // 
            // dgvShopping_nameProd
            // 
            dgvShopping_nameProd.HeaderText = "Product Name";
            dgvShopping_nameProd.Name = "dgvShopping_nameProd";
            dgvShopping_nameProd.ReadOnly = true;
            // 
            // dgvShopping_amount
            // 
            dgvShopping_amount.HeaderText = "Amount";
            dgvShopping_amount.Name = "dgvShopping_amount";
            dgvShopping_amount.ReadOnly = true;
            // 
            // dgvShopping_Mountaint
            // 
            dgvShopping_Mountaint.HeaderText = "Mountaint";
            dgvShopping_Mountaint.Name = "dgvShopping_Mountaint";
            dgvShopping_Mountaint.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(241, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(140, 22);
            label1.TabIndex = 0;
            label1.Text = "Shopping cart";
            // 
            // pnlPartSeachProd
            // 
            pnlPartSeachProd.BackColor = Color.WhiteSmoke;
            pnlPartSeachProd.Controls.Add(btnCloseCustomerDetails);
            pnlPartSeachProd.Controls.Add(pnlCustomerDetails);
            pnlPartSeachProd.Controls.Add(btnAddCustomerDetails);
            pnlPartSeachProd.Controls.Add(pnlQuantProd);
            pnlPartSeachProd.Controls.Add(dgvSearchProd);
            pnlPartSeachProd.Controls.Add(panel4);
            pnlPartSeachProd.Controls.Add(pnlDgvSearchPro);
            pnlPartSeachProd.Dock = DockStyle.Left;
            pnlPartSeachProd.Location = new Point(0, 0);
            pnlPartSeachProd.Margin = new Padding(4, 3, 4, 3);
            pnlPartSeachProd.Name = "pnlPartSeachProd";
            pnlPartSeachProd.Size = new Size(550, 692);
            pnlPartSeachProd.TabIndex = 1;
            // 
            // btnCloseCustomerDetails
            // 
            btnCloseCustomerDetails.BackColor = Color.FromArgb(192, 0, 0);
            btnCloseCustomerDetails.Cursor = Cursors.Hand;
            btnCloseCustomerDetails.FlatAppearance.BorderSize = 0;
            btnCloseCustomerDetails.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnCloseCustomerDetails.FlatStyle = FlatStyle.Flat;
            btnCloseCustomerDetails.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCloseCustomerDetails.ForeColor = Color.White;
            btnCloseCustomerDetails.Location = new Point(494, 462);
            btnCloseCustomerDetails.Margin = new Padding(4, 3, 4, 3);
            btnCloseCustomerDetails.Name = "btnCloseCustomerDetails";
            btnCloseCustomerDetails.Size = new Size(31, 25);
            btnCloseCustomerDetails.TabIndex = 16;
            btnCloseCustomerDetails.Text = "X";
            btnCloseCustomerDetails.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCloseCustomerDetails.UseVisualStyleBackColor = false;
            btnCloseCustomerDetails.Click += button1_Click_1;
            // 
            // pnlCustomerDetails
            // 
            pnlCustomerDetails.BackColor = Color.LightGray;
            pnlCustomerDetails.Controls.Add(txtTPNo);
            pnlCustomerDetails.Controls.Add(label9);
            pnlCustomerDetails.Controls.Add(txtAddress);
            pnlCustomerDetails.Controls.Add(label10);
            pnlCustomerDetails.Controls.Add(txtAge);
            pnlCustomerDetails.Controls.Add(label11);
            pnlCustomerDetails.Controls.Add(txtCustomerName);
            pnlCustomerDetails.Controls.Add(label12);
            pnlCustomerDetails.Location = new Point(26, 493);
            pnlCustomerDetails.Margin = new Padding(4, 3, 4, 3);
            pnlCustomerDetails.Name = "pnlCustomerDetails";
            pnlCustomerDetails.Size = new Size(499, 167);
            pnlCustomerDetails.TabIndex = 15;
            // 
            // txtTPNo
            // 
            txtTPNo.BackColor = SystemColors.ControlLightLight;
            txtTPNo.BorderStyle = BorderStyle.None;
            txtTPNo.Font = new Font("Century Gothic", 14F);
            txtTPNo.ForeColor = Color.DarkRed;
            txtTPNo.Location = new Point(143, 53);
            txtTPNo.Margin = new Padding(4, 3, 4, 3);
            txtTPNo.Name = "txtTPNo";
            txtTPNo.Size = new Size(315, 23);
            txtTPNo.TabIndex = 14;
            txtTPNo.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 10F);
            label9.Location = new Point(27, 55);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(49, 19);
            label9.TabIndex = 13;
            label9.Text = "TP No:";
            // 
            // txtAddress
            // 
            txtAddress.BackColor = SystemColors.ControlLightLight;
            txtAddress.BorderStyle = BorderStyle.None;
            txtAddress.Font = new Font("Century Gothic", 14F);
            txtAddress.ForeColor = Color.DarkRed;
            txtAddress.Location = new Point(143, 89);
            txtAddress.Margin = new Padding(4, 3, 4, 3);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(315, 23);
            txtAddress.TabIndex = 12;
            txtAddress.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 10F);
            label10.Location = new Point(27, 91);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(61, 19);
            label10.TabIndex = 11;
            label10.Text = "Address";
            // 
            // txtAge
            // 
            txtAge.BackColor = SystemColors.ControlLightLight;
            txtAge.BorderStyle = BorderStyle.None;
            txtAge.Font = new Font("Century Gothic", 14F);
            txtAge.ForeColor = Color.DarkRed;
            txtAge.Location = new Point(143, 126);
            txtAge.Margin = new Padding(4, 3, 4, 3);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(66, 23);
            txtAge.TabIndex = 10;
            txtAge.TextAlign = HorizontalAlignment.Center;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 10F);
            label11.Location = new Point(27, 127);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(40, 19);
            label11.TabIndex = 9;
            label11.Text = "Age:";
            // 
            // txtCustomerName
            // 
            txtCustomerName.BackColor = SystemColors.ControlLightLight;
            txtCustomerName.BorderStyle = BorderStyle.None;
            txtCustomerName.Font = new Font("Century Gothic", 14F);
            txtCustomerName.ForeColor = Color.DarkRed;
            txtCustomerName.Location = new Point(143, 17);
            txtCustomerName.Margin = new Padding(4, 3, 4, 3);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(315, 23);
            txtCustomerName.TabIndex = 8;
            txtCustomerName.TextAlign = HorizontalAlignment.Center;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 10F);
            label12.Location = new Point(27, 19);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(55, 19);
            label12.TabIndex = 7;
            label12.Text = "Name:";
            // 
            // btnAddCustomerDetails
            // 
            btnAddCustomerDetails.BackColor = Color.Teal;
            btnAddCustomerDetails.Cursor = Cursors.Hand;
            btnAddCustomerDetails.FlatAppearance.BorderSize = 0;
            btnAddCustomerDetails.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnAddCustomerDetails.FlatStyle = FlatStyle.Flat;
            btnAddCustomerDetails.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddCustomerDetails.ForeColor = Color.White;
            btnAddCustomerDetails.Location = new Point(26, 460);
            btnAddCustomerDetails.Margin = new Padding(4, 3, 4, 3);
            btnAddCustomerDetails.Name = "btnAddCustomerDetails";
            btnAddCustomerDetails.Size = new Size(162, 25);
            btnAddCustomerDetails.TabIndex = 15;
            btnAddCustomerDetails.Text = "Add Customer Details";
            btnAddCustomerDetails.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddCustomerDetails.UseVisualStyleBackColor = false;
            btnAddCustomerDetails.Click += btnAddCustomerDetails_Click;
            // 
            // pnlQuantProd
            // 
            pnlQuantProd.BackColor = Color.LightGray;
            pnlQuantProd.Controls.Add(txtPriceProd);
            pnlQuantProd.Controls.Add(label7);
            pnlQuantProd.Controls.Add(txtAmountProd);
            pnlQuantProd.Controls.Add(label6);
            pnlQuantProd.Controls.Add(txtNameProd);
            pnlQuantProd.Controls.Add(label5);
            pnlQuantProd.Controls.Add(txtIsbnProd);
            pnlQuantProd.Controls.Add(label4);
            pnlQuantProd.Controls.Add(txtIdProd);
            pnlQuantProd.Controls.Add(label3);
            pnlQuantProd.Controls.Add(btnCancelAddCart);
            pnlQuantProd.Controls.Add(btnAddToCart);
            pnlQuantProd.Location = new Point(26, 209);
            pnlQuantProd.Margin = new Padding(4, 3, 4, 3);
            pnlQuantProd.Name = "pnlQuantProd";
            pnlQuantProd.Size = new Size(499, 233);
            pnlQuantProd.TabIndex = 2;
            // 
            // txtPriceProd
            // 
            txtPriceProd.BackColor = SystemColors.ControlLightLight;
            txtPriceProd.BorderStyle = BorderStyle.None;
            txtPriceProd.Font = new Font("Century Gothic", 14F);
            txtPriceProd.ForeColor = Color.DarkRed;
            txtPriceProd.Location = new Point(344, 114);
            txtPriceProd.Margin = new Padding(4, 3, 4, 3);
            txtPriceProd.Name = "txtPriceProd";
            txtPriceProd.Size = new Size(140, 23);
            txtPriceProd.TabIndex = 14;
            txtPriceProd.TextAlign = HorizontalAlignment.Center;
            txtPriceProd.KeyPress += txtPriceProd_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10F);
            label7.Location = new Point(258, 116);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(78, 19);
            label7.TabIndex = 13;
            label7.Text = "Price (Rs.):";
            // 
            // txtAmountProd
            // 
            txtAmountProd.BackColor = SystemColors.ControlLightLight;
            txtAmountProd.BorderStyle = BorderStyle.None;
            txtAmountProd.Font = new Font("Century Gothic", 14F);
            txtAmountProd.ForeColor = Color.DarkRed;
            txtAmountProd.Location = new Point(102, 114);
            txtAmountProd.Margin = new Padding(4, 3, 4, 3);
            txtAmountProd.Name = "txtAmountProd";
            txtAmountProd.Size = new Size(143, 23);
            txtAmountProd.TabIndex = 12;
            txtAmountProd.TextAlign = HorizontalAlignment.Center;
            txtAmountProd.TextChanged += txtAmountProd_TextChanged;
            txtAmountProd.KeyPress += txtAmountProd_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10F);
            label6.Location = new Point(27, 116);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(70, 19);
            label6.TabIndex = 11;
            label6.Text = "Quantity";
            // 
            // txtNameProd
            // 
            txtNameProd.BackColor = SystemColors.ControlLightLight;
            txtNameProd.BorderStyle = BorderStyle.None;
            txtNameProd.Font = new Font("Century Gothic", 14F);
            txtNameProd.ForeColor = Color.DarkRed;
            txtNameProd.Location = new Point(161, 72);
            txtNameProd.Margin = new Padding(4, 3, 4, 3);
            txtNameProd.Name = "txtNameProd";
            txtNameProd.ReadOnly = true;
            txtNameProd.Size = new Size(322, 23);
            txtNameProd.TabIndex = 10;
            txtNameProd.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10F);
            label5.Location = new Point(27, 74);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(113, 19);
            label5.TabIndex = 9;
            label5.Text = "Product Name:";
            // 
            // txtIsbnProd
            // 
            txtIsbnProd.BackColor = SystemColors.ControlLightLight;
            txtIsbnProd.BorderStyle = BorderStyle.None;
            txtIsbnProd.Font = new Font("Century Gothic", 14F);
            txtIsbnProd.ForeColor = Color.DarkRed;
            txtIsbnProd.Location = new Point(217, 32);
            txtIsbnProd.Margin = new Padding(4, 3, 4, 3);
            txtIsbnProd.Name = "txtIsbnProd";
            txtIsbnProd.ReadOnly = true;
            txtIsbnProd.Size = new Size(266, 23);
            txtIsbnProd.TabIndex = 8;
            txtIsbnProd.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10F);
            label4.Location = new Point(168, 34);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(41, 19);
            label4.TabIndex = 7;
            label4.Text = "ISBN:";
            // 
            // txtIdProd
            // 
            txtIdProd.BackColor = SystemColors.ControlLightLight;
            txtIdProd.BorderStyle = BorderStyle.None;
            txtIdProd.Font = new Font("Century Gothic", 14F);
            txtIdProd.ForeColor = Color.DarkRed;
            txtIdProd.Location = new Point(61, 32);
            txtIdProd.Margin = new Padding(4, 3, 4, 3);
            txtIdProd.Name = "txtIdProd";
            txtIdProd.ReadOnly = true;
            txtIdProd.Size = new Size(79, 23);
            txtIdProd.TabIndex = 6;
            txtIdProd.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10F);
            label3.Location = new Point(27, 34);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(26, 19);
            label3.TabIndex = 5;
            label3.Text = "Id:";
            // 
            // btnCancelAddCart
            // 
            btnCancelAddCart.BackColor = Color.FromArgb(192, 0, 0);
            btnCancelAddCart.Cursor = Cursors.Hand;
            btnCancelAddCart.FlatAppearance.BorderSize = 0;
            btnCancelAddCart.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnCancelAddCart.FlatStyle = FlatStyle.Flat;
            btnCancelAddCart.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelAddCart.ForeColor = Color.White;
            btnCancelAddCart.Image = (Image)resources.GetObject("btnCancelAddCart.Image");
            btnCancelAddCart.Location = new Point(270, 167);
            btnCancelAddCart.Margin = new Padding(4, 3, 4, 3);
            btnCancelAddCart.Name = "btnCancelAddCart";
            btnCancelAddCart.Size = new Size(140, 43);
            btnCancelAddCart.TabIndex = 4;
            btnCancelAddCart.Text = "Cancel";
            btnCancelAddCart.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelAddCart.UseVisualStyleBackColor = false;
            btnCancelAddCart.Click += btnCancelAddCart_Click;
            // 
            // btnAddToCart
            // 
            btnAddToCart.BackColor = Color.FromArgb(9, 147, 55);
            btnAddToCart.Cursor = Cursors.Hand;
            btnAddToCart.FlatAppearance.BorderSize = 0;
            btnAddToCart.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnAddToCart.FlatStyle = FlatStyle.Flat;
            btnAddToCart.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddToCart.ForeColor = Color.White;
            btnAddToCart.Image = (Image)resources.GetObject("btnAddToCart.Image");
            btnAddToCart.Location = new Point(27, 167);
            btnAddToCart.Margin = new Padding(4, 3, 4, 3);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(218, 43);
            btnAddToCart.TabIndex = 3;
            btnAddToCart.Text = "Add to cart";
            btnAddToCart.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddToCart.UseVisualStyleBackColor = false;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // dgvSearchProd
            // 
            dgvSearchProd.BackgroundColor = Color.WhiteSmoke;
            dgvSearchProd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSearchProd.Location = new Point(26, 120);
            dgvSearchProd.Margin = new Padding(4, 3, 4, 3);
            dgvSearchProd.Name = "dgvSearchProd";
            dgvSearchProd.RowHeadersVisible = false;
            dgvSearchProd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSearchProd.Size = new Size(499, 83);
            dgvSearchProd.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gainsboro;
            panel4.Controls.Add(groupBox1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(550, 113);
            panel4.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(btnSearchBookSale);
            groupBox1.Controls.Add(mtxtSearchBookSale);
            groupBox1.Location = new Point(53, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(438, 72);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // btnSearchBookSale
            // 
            btnSearchBookSale.BackColor = Color.Black;
            btnSearchBookSale.Cursor = Cursors.Hand;
            btnSearchBookSale.FlatAppearance.BorderSize = 0;
            btnSearchBookSale.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnSearchBookSale.FlatStyle = FlatStyle.Flat;
            btnSearchBookSale.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchBookSale.ForeColor = Color.White;
            btnSearchBookSale.Image = (Image)resources.GetObject("btnSearchBookSale.Image");
            btnSearchBookSale.Location = new Point(339, 16);
            btnSearchBookSale.Margin = new Padding(4, 3, 4, 3);
            btnSearchBookSale.Name = "btnSearchBookSale";
            btnSearchBookSale.Size = new Size(60, 38);
            btnSearchBookSale.TabIndex = 3;
            btnSearchBookSale.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearchBookSale.UseVisualStyleBackColor = false;
            btnSearchBookSale.Click += btnSearchBookSale_Click;
            // 
            // mtxtSearchBookSale
            // 
            mtxtSearchBookSale.BorderStyle = BorderStyle.None;
            mtxtSearchBookSale.Font = new Font("Century Gothic", 16F);
            mtxtSearchBookSale.Location = new Point(34, 22);
            mtxtSearchBookSale.Margin = new Padding(4, 3, 4, 3);
            mtxtSearchBookSale.Mask = "ISBN 000-000000000-0";
            mtxtSearchBookSale.Name = "mtxtSearchBookSale";
            mtxtSearchBookSale.Size = new Size(276, 27);
            mtxtSearchBookSale.TabIndex = 4;
            // 
            // pnlDgvSearchPro
            // 
            pnlDgvSearchPro.Location = new Point(26, 120);
            pnlDgvSearchPro.Margin = new Padding(4, 3, 4, 3);
            pnlDgvSearchPro.Name = "pnlDgvSearchPro";
            pnlDgvSearchPro.Size = new Size(499, 83);
            pnlDgvSearchPro.TabIndex = 3;
            // 
            // FmSale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1225, 692);
            Controls.Add(pnlPartSeachProd);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "FmSale";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sale";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlCalcDiscount.ResumeLayout(false);
            pnlCalcDiscount.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvShoppingCart).EndInit();
            pnlPartSeachProd.ResumeLayout(false);
            pnlCustomerDetails.ResumeLayout(false);
            pnlCustomerDetails.PerformLayout();
            pnlQuantProd.ResumeLayout(false);
            pnlQuantProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSearchProd).EndInit();
            panel4.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancelBuying;
        private System.Windows.Forms.Button btnFinishShop;
        private System.Windows.Forms.TextBox txtPriceTotalSale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvShoppingCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvShopping_idProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvShopping_isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvShopping_nameProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvShopping_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvShopping_Mountaint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlPartSeachProd;
        private System.Windows.Forms.Panel pnlQuantProd;
        private System.Windows.Forms.TextBox txtPriceProd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAmountProd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNameProd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIsbnProd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdProd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelAddCart;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.DataGridView dgvSearchProd;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSearchBookSale;
        private System.Windows.Forms.Panel pnlDgvSearchPro;
        private System.Windows.Forms.MaskedTextBox mtxtSearchBookSale;
        private System.Windows.Forms.CheckBox cbApplyDiscount;
        private System.Windows.Forms.Panel pnlCalcDiscount;
        private System.Windows.Forms.Button btnApplyDiscount;
        private System.Windows.Forms.TextBox txtDiscountValue;
        private System.Windows.Forms.Label label8;
        private Button btnAddCustomerDetails;
        private Panel pnlCustomerDetails;
        private TextBox txtTPNo;
        private Label label9;
        private TextBox txtAddress;
        private Label label10;
        private TextBox txtAge;
        private Label label11;
        private TextBox txtCustomerName;
        private Label label12;
        private GroupBox groupBox1;
        private Button btnCloseCustomerDetails;
    }
}