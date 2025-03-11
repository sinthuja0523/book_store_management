namespace BookStoreMgt
{
    partial class FmBooks
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

        //#region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmBooks));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pbCloseFmBooks = new PictureBox();
            pnlButtosBooks = new Panel();
            pnlContainerFmAddOrUpdateBook = new Panel();
            pnlTopFmAddBook = new Panel();
            lblTitleAddBook = new Label();
            btnCancelbook = new Button();
            btnSaveBook = new Button();
            txtPriceBook = new TextBox();
            mtxtISBN = new MaskedTextBox();
            cbGenreBook = new ComboBox();
            txtAmountBook = new TextBox();
            txteditoraBook = new TextBox();
            txtAuthorBook = new TextBox();
            txtYearBook = new TextBox();
            txtTitleBook = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lblTitleBook = new Label();
            lblISBN = new Label();
            btnAddNewBook = new Button();
            btnSearchBook = new Button();
            pnlBooksGrid = new Panel();
            btnDeleteBook = new Button();
            btnUpdateData = new Button();
            dgvBooks = new DataGridView();
            pnlSearchBook = new Panel();
            txtFilterData = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbCloseFmBooks).BeginInit();
            pnlButtosBooks.SuspendLayout();
            pnlContainerFmAddOrUpdateBook.SuspendLayout();
            pnlTopFmAddBook.SuspendLayout();
            pnlBooksGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            pnlSearchBook.SuspendLayout();
      /*      SuspendLayout();*/
            // 
            // pbCloseFmBooks
            // 
            pbCloseFmBooks.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbCloseFmBooks.Image = (Image)resources.GetObject("pbCloseFmBooks.Image");
            pbCloseFmBooks.Location = new Point(566, 14);
            pbCloseFmBooks.Margin = new Padding(4, 3, 4, 3);
            pbCloseFmBooks.Name = "pbCloseFmBooks";
            pbCloseFmBooks.Size = new Size(29, 29);
            pbCloseFmBooks.SizeMode = PictureBoxSizeMode.Zoom;
            pbCloseFmBooks.TabIndex = 1;
            pbCloseFmBooks.TabStop = false;
         /*   pbCloseFmBooks.Click += pbCloseFmBooks_Click;*/
            // 
            // pnlButtosBooks
            // 
            pnlButtosBooks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlButtosBooks.Controls.Add(pnlContainerFmAddOrUpdateBook);
            pnlButtosBooks.Controls.Add(btnAddNewBook);
            pnlButtosBooks.Location = new Point(0, 0);
            pnlButtosBooks.Margin = new Padding(4, 3, 4, 3);
            pnlButtosBooks.Name = "pnlButtosBooks";
            pnlButtosBooks.Size = new Size(609, 692);
            pnlButtosBooks.TabIndex = 2;
            // 
            // pnlContainerFmAddOrUpdateBook
            // 
            pnlContainerFmAddOrUpdateBook.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlContainerFmAddOrUpdateBook.BackColor = SystemColors.Control;
            pnlContainerFmAddOrUpdateBook.Controls.Add(pnlTopFmAddBook);
            pnlContainerFmAddOrUpdateBook.Controls.Add(btnCancelbook);
            pnlContainerFmAddOrUpdateBook.Controls.Add(btnSaveBook);
            pnlContainerFmAddOrUpdateBook.Controls.Add(txtPriceBook);
            pnlContainerFmAddOrUpdateBook.Controls.Add(mtxtISBN);
            pnlContainerFmAddOrUpdateBook.Controls.Add(cbGenreBook);
            pnlContainerFmAddOrUpdateBook.Controls.Add(txtAmountBook);
            pnlContainerFmAddOrUpdateBook.Controls.Add(txteditoraBook);
            pnlContainerFmAddOrUpdateBook.Controls.Add(txtAuthorBook);
            pnlContainerFmAddOrUpdateBook.Controls.Add(txtYearBook);
            pnlContainerFmAddOrUpdateBook.Controls.Add(txtTitleBook);
            pnlContainerFmAddOrUpdateBook.Controls.Add(label7);
            pnlContainerFmAddOrUpdateBook.Controls.Add(label6);
            pnlContainerFmAddOrUpdateBook.Controls.Add(label5);
            pnlContainerFmAddOrUpdateBook.Controls.Add(label4);
            pnlContainerFmAddOrUpdateBook.Controls.Add(label3);
            pnlContainerFmAddOrUpdateBook.Controls.Add(label2);
            pnlContainerFmAddOrUpdateBook.Controls.Add(lblTitleBook);
            pnlContainerFmAddOrUpdateBook.Controls.Add(lblISBN);
            pnlContainerFmAddOrUpdateBook.Location = new Point(0, 145);
            pnlContainerFmAddOrUpdateBook.Margin = new Padding(4, 3, 4, 3);
            pnlContainerFmAddOrUpdateBook.Name = "pnlContainerFmAddOrUpdateBook";
            pnlContainerFmAddOrUpdateBook.Size = new Size(609, 547);
            pnlContainerFmAddOrUpdateBook.TabIndex = 3;
            // 
            // pnlTopFmAddBook
            // 
            pnlTopFmAddBook.BackColor = Color.FromArgb(255, 87, 51);
            pnlTopFmAddBook.Controls.Add(lblTitleAddBook);
            pnlTopFmAddBook.Dock = DockStyle.Top;
            pnlTopFmAddBook.Location = new Point(0, 0);
            pnlTopFmAddBook.Margin = new Padding(4, 3, 4, 3);
            pnlTopFmAddBook.Name = "pnlTopFmAddBook";
            pnlTopFmAddBook.Size = new Size(609, 38);
            pnlTopFmAddBook.TabIndex = 36;
       /*     pnlTopFmAddBook.Paint += pnlTopFmAddBook_Paint;*/
            // 
            // lblTitleAddBook
            // 
            lblTitleAddBook.AutoSize = true;
            lblTitleAddBook.FlatStyle = FlatStyle.Flat;
            lblTitleAddBook.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleAddBook.ForeColor = Color.White;
            lblTitleAddBook.ImageAlign = ContentAlignment.MiddleLeft;
            lblTitleAddBook.Location = new Point(210, 8);
            lblTitleAddBook.Margin = new Padding(4, 0, 4, 0);
            lblTitleAddBook.Name = "lblTitleAddBook";
            lblTitleAddBook.Size = new Size(139, 19);
            lblTitleAddBook.TabIndex = 0;
            lblTitleAddBook.Text = "Add a new book";
            lblTitleAddBook.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCancelbook
            // 
            btnCancelbook.BackColor = Color.FromArgb(199, 0, 57);
            btnCancelbook.Cursor = Cursors.Hand;
            btnCancelbook.FlatAppearance.BorderSize = 0;
            btnCancelbook.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnCancelbook.FlatStyle = FlatStyle.Flat;
            btnCancelbook.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelbook.ForeColor = Color.White;
            btnCancelbook.Image = (Image)resources.GetObject("btnCancelbook.Image");
            btnCancelbook.Location = new Point(363, 361);
            btnCancelbook.Margin = new Padding(4, 3, 4, 3);
            btnCancelbook.Name = "btnCancelbook";
            btnCancelbook.Size = new Size(136, 52);
            btnCancelbook.TabIndex = 35;
            btnCancelbook.Text = "Cancel";
            btnCancelbook.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelbook.UseVisualStyleBackColor = false;
        /*    btnCancelbook.Click += btnCancelbook_Click;*/
            // 
            // btnSaveBook
            // 
            btnSaveBook.BackColor = Color.FromArgb(9, 147, 55);
            btnSaveBook.Cursor = Cursors.Hand;
            btnSaveBook.FlatAppearance.BorderSize = 0;
            btnSaveBook.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnSaveBook.FlatStyle = FlatStyle.Flat;
            btnSaveBook.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveBook.ForeColor = Color.White;
            btnSaveBook.Image = (Image)resources.GetObject("btnSaveBook.Image");
            btnSaveBook.Location = new Point(191, 361);
            btnSaveBook.Margin = new Padding(4, 3, 4, 3);
            btnSaveBook.Name = "btnSaveBook";
            btnSaveBook.Size = new Size(136, 52);
            btnSaveBook.TabIndex = 34;
            btnSaveBook.Text = "Save";
            btnSaveBook.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSaveBook.UseVisualStyleBackColor = false;
        /*    btnSaveBook.Click += btnSaveBook_Click;*/
            // 
            // txtPriceBook
            // 
            txtPriceBook.BorderStyle = BorderStyle.None;
            txtPriceBook.Location = new Point(191, 315);
            txtPriceBook.Margin = new Padding(4, 3, 4, 3);
            txtPriceBook.MaxLength = 20;
            txtPriceBook.Multiline = true;
            txtPriceBook.Name = "txtPriceBook";
            txtPriceBook.Size = new Size(308, 23);
            txtPriceBook.TabIndex = 33;
       /*     txtPriceBook.KeyPress += txtPriceBook_KeyPress;*/
            // 
            // mtxtISBN
            // 
            mtxtISBN.BorderStyle = BorderStyle.None;
            mtxtISBN.Location = new Point(191, 105);
            mtxtISBN.Margin = new Padding(4, 3, 4, 3);
            mtxtISBN.Mask = "ISBN 000-&&&&&&&&&-0";
            mtxtISBN.Name = "mtxtISBN";
            mtxtISBN.Size = new Size(308, 16);
            mtxtISBN.TabIndex = 32;
            // 
            // cbGenreBook
            // 
            cbGenreBook.FlatStyle = FlatStyle.Flat;
            cbGenreBook.FormattingEnabled = true;
            cbGenreBook.Location = new Point(227, 252);
            cbGenreBook.Margin = new Padding(4, 3, 4, 3);
            cbGenreBook.Name = "cbGenreBook";
            cbGenreBook.Size = new Size(235, 23);
            cbGenreBook.TabIndex = 31;
            cbGenreBook.Text = "Select the  book genre:";
            // 
            // txtAmountBook
            // 
            txtAmountBook.BorderStyle = BorderStyle.None;
            txtAmountBook.Location = new Point(191, 285);
            txtAmountBook.Margin = new Padding(4, 3, 4, 3);
            txtAmountBook.Multiline = true;
            txtAmountBook.Name = "txtAmountBook";
            txtAmountBook.Size = new Size(308, 23);
            txtAmountBook.TabIndex = 30;
        /*    txtAmountBook.TextChanged += txtAmountBook_TextChanged;
            txtAmountBook.KeyPress += txtAmountBook_KeyPress;
            // */
            // txteditoraBook
            // 
            txteditoraBook.BorderStyle = BorderStyle.None;
            txteditoraBook.Location = new Point(191, 225);
            txteditoraBook.Margin = new Padding(4, 3, 4, 3);
            txteditoraBook.Multiline = true;
            txteditoraBook.Name = "txteditoraBook";
            txteditoraBook.Size = new Size(308, 23);
            txteditoraBook.TabIndex = 29;
            // 
            // txtAuthorBook
            // 
            txtAuthorBook.BorderStyle = BorderStyle.None;
            txtAuthorBook.Location = new Point(191, 165);
            txtAuthorBook.Margin = new Padding(4, 3, 4, 3);
            txtAuthorBook.Multiline = true;
            txtAuthorBook.Name = "txtAuthorBook";
            txtAuthorBook.Size = new Size(308, 23);
            txtAuthorBook.TabIndex = 28;
            // 
            // txtYearBook
            // 
            txtYearBook.BorderStyle = BorderStyle.None;
            txtYearBook.Location = new Point(191, 195);
            txtYearBook.Margin = new Padding(4, 3, 4, 3);
            txtYearBook.MaxLength = 4;
            txtYearBook.Multiline = true;
            txtYearBook.Name = "txtYearBook";
            txtYearBook.Size = new Size(308, 23);
            txtYearBook.TabIndex = 27;
       /*     txtYearBook.KeyPress += txtYearBook_KeyPress;*/
            // 
            // txtTitleBook
            // 
            txtTitleBook.BorderStyle = BorderStyle.None;
            txtTitleBook.Location = new Point(191, 135);
            txtTitleBook.Margin = new Padding(4, 3, 4, 3);
            txtTitleBook.Multiline = true;
            txtTitleBook.Name = "txtTitleBook";
            txtTitleBook.Size = new Size(308, 23);
            txtTitleBook.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(76, 309);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(69, 19);
            label7.TabIndex = 25;
            label7.Text = "Price R$";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(75, 279);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(71, 19);
            label6.TabIndex = 24;
            label6.Text = "Amount";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(83, 249);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(57, 19);
            label5.TabIndex = 23;
            label5.Text = "Genre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(79, 219);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(62, 19);
            label4.TabIndex = 22;
            label4.Text = "Editora";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(90, 189);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(45, 19);
            label3.TabIndex = 21;
            label3.Text = "Year";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(80, 159);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 19);
            label2.TabIndex = 20;
            label2.Text = "Author";
            // 
            // lblTitleBook
            // 
            lblTitleBook.AutoSize = true;
            lblTitleBook.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleBook.ForeColor = Color.White;
            lblTitleBook.Location = new Point(93, 129);
            lblTitleBook.Margin = new Padding(4, 0, 4, 0);
            lblTitleBook.Name = "lblTitleBook";
            lblTitleBook.Size = new Size(38, 19);
            lblTitleBook.TabIndex = 19;
            lblTitleBook.Text = "Title";
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblISBN.ForeColor = Color.White;
            lblISBN.Location = new Point(91, 99);
            lblISBN.Margin = new Padding(4, 0, 4, 0);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(42, 19);
            lblISBN.TabIndex = 18;
            lblISBN.Text = "ISBN";
            // 
            // btnAddNewBook
            // 
            btnAddNewBook.BackColor = Color.FromArgb(9, 147, 55);
            btnAddNewBook.Cursor = Cursors.Hand;
            btnAddNewBook.FlatAppearance.BorderSize = 0;
            btnAddNewBook.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnAddNewBook.FlatStyle = FlatStyle.Flat;
            btnAddNewBook.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddNewBook.ForeColor = Color.White;
            btnAddNewBook.Image = (Image)resources.GetObject("btnAddNewBook.Image");
            btnAddNewBook.Location = new Point(191, 68);
            btnAddNewBook.Margin = new Padding(4, 3, 4, 3);
            btnAddNewBook.Name = "btnAddNewBook";
            btnAddNewBook.Size = new Size(217, 54);
            btnAddNewBook.TabIndex = 0;
            btnAddNewBook.Text = "Add a new book";
            btnAddNewBook.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddNewBook.UseVisualStyleBackColor = false;
       /*     btnAddNewBook.Click += btnAddNewBook_Click;*/
            // 
            // btnSearchBook
            // 
            btnSearchBook.BackColor = Color.FromArgb(255, 87, 51);
            btnSearchBook.Cursor = Cursors.Hand;
            btnSearchBook.FlatAppearance.BorderSize = 0;
            btnSearchBook.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnSearchBook.FlatStyle = FlatStyle.Flat;
            btnSearchBook.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearchBook.ForeColor = Color.White;
            btnSearchBook.Image = (Image)resources.GetObject("btnSearchBook.Image");
            btnSearchBook.Location = new Point(510, 42);
            btnSearchBook.Margin = new Padding(4, 3, 4, 3);
            btnSearchBook.Name = "btnSearchBook";
            btnSearchBook.Size = new Size(55, 40);
            btnSearchBook.TabIndex = 1;
            btnSearchBook.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSearchBook.UseVisualStyleBackColor = false;
       /*     btnSearchBook.Click += btnSearchBook_Click;*/
            // 
            // pnlBooksGrid
            // 
            pnlBooksGrid.Controls.Add(btnDeleteBook);
            pnlBooksGrid.Controls.Add(btnUpdateData);
            pnlBooksGrid.Controls.Add(dgvBooks);
            pnlBooksGrid.Controls.Add(pbCloseFmBooks);
            pnlBooksGrid.Controls.Add(pnlSearchBook);
            pnlBooksGrid.Dock = DockStyle.Right;
            pnlBooksGrid.Location = new Point(616, 0);
            pnlBooksGrid.Margin = new Padding(4, 3, 4, 3);
            pnlBooksGrid.Name = "pnlBooksGrid";
            pnlBooksGrid.Size = new Size(609, 692);
            pnlBooksGrid.TabIndex = 3;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDeleteBook.BackColor = Color.FromArgb(125, 60, 152);
            btnDeleteBook.Cursor = Cursors.Hand;
            btnDeleteBook.FlatAppearance.BorderSize = 0;
            btnDeleteBook.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnDeleteBook.FlatStyle = FlatStyle.Flat;
            btnDeleteBook.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeleteBook.ForeColor = Color.White;
            btnDeleteBook.Image = (Image)resources.GetObject("btnDeleteBook.Image");
            btnDeleteBook.Location = new Point(327, 585);
            btnDeleteBook.Margin = new Padding(4, 3, 4, 3);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(180, 80);
            btnDeleteBook.TabIndex = 6;
            btnDeleteBook.Text = "Delete";
            btnDeleteBook.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDeleteBook.UseVisualStyleBackColor = false;
      /*      btnDeleteBook.Click += btnDeleteBook_Click;*/
            // 
            // btnUpdateData
            // 
            btnUpdateData.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnUpdateData.BackColor = Color.FromArgb(14, 102, 85);
            btnUpdateData.Cursor = Cursors.Hand;
            btnUpdateData.FlatAppearance.BorderSize = 0;
            btnUpdateData.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnUpdateData.FlatStyle = FlatStyle.Flat;
            btnUpdateData.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdateData.ForeColor = Color.White;
            btnUpdateData.Image = (Image)resources.GetObject("btnUpdateData.Image");
            btnUpdateData.Location = new Point(74, 585);
            btnUpdateData.Margin = new Padding(4, 3, 4, 3);
            btnUpdateData.Name = "btnUpdateData";
            btnUpdateData.Size = new Size(180, 80);
            btnUpdateData.TabIndex = 5;
            btnUpdateData.Text = "Update data";
            btnUpdateData.TextImageRelation = TextImageRelation.ImageAboveText;
            btnUpdateData.UseVisualStyleBackColor = false;
         /*   btnUpdateData.Click += btnUpdateData_Click;*/
            // 
            // dgvBooks
            // 
            dgvBooks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvBooks.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvBooks.BackgroundColor = Color.FromArgb(144, 12, 63);
            dgvBooks.BorderStyle = BorderStyle.None;
            dgvBooks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(71, 3, 22);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = Color.Salmon;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBooks.ColumnHeadersHeight = 30;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(144, 12, 63);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(199, 0, 57);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvBooks.DefaultCellStyle = dataGridViewCellStyle2;
            dgvBooks.EnableHeadersVisualStyles = false;
            dgvBooks.GridColor = Color.FromArgb(199, 0, 57);
            dgvBooks.Location = new Point(15, 156);
            dgvBooks.Margin = new Padding(4, 3, 4, 3);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.RowHeadersVisible = false;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.Size = new Size(580, 403);
            dgvBooks.TabIndex = 2;
            // 
            // pnlSearchBook
            // 
            pnlSearchBook.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlSearchBook.BackColor = Color.FromArgb(255, 87, 51);
            pnlSearchBook.Controls.Add(txtFilterData);
            pnlSearchBook.Controls.Add(btnSearchBook);
            pnlSearchBook.Controls.Add(label1);
            pnlSearchBook.Location = new Point(15, 57);
            pnlSearchBook.Margin = new Padding(4, 3, 4, 3);
            pnlSearchBook.Name = "pnlSearchBook";
            pnlSearchBook.Size = new Size(580, 92);
            pnlSearchBook.TabIndex = 7;
            // 
            // txtFilterData
            // 
            txtFilterData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtFilterData.BackColor = Color.Beige;
            txtFilterData.BorderStyle = BorderStyle.None;
            txtFilterData.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFilterData.Location = new Point(58, 50);
            txtFilterData.Margin = new Padding(4, 3, 4, 3);
            txtFilterData.MaxLength = 50;
            txtFilterData.Name = "txtFilterData";
            txtFilterData.Size = new Size(433, 20);
            txtFilterData.TabIndex = 5;
            txtFilterData.Text = "Type here the book title";
         /*   txtFilterData.TextChanged += txtFilterData_TextChanged;
            txtFilterData.KeyPress += txtFilterData_KeyPress;
            txtFilterData.Leave += txtFilterData_Leave;*/
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(204, 12);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(145, 21);
            label1.TabIndex = 4;
            label1.Text = "Search book now";
            // 
            // FmBooks
            // 
            /*
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1225, 692);
            Controls.Add(pnlBooksGrid);
            Controls.Add(pnlButtosBooks);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FmBooks";
            Text = "FmBooks";
            Load += FmBooks_Load;*/
            ((System.ComponentModel.ISupportInitialize)pbCloseFmBooks).EndInit();
            pnlButtosBooks.ResumeLayout(false);
            pnlContainerFmAddOrUpdateBook.ResumeLayout(false);
            pnlContainerFmAddOrUpdateBook.PerformLayout();
            pnlTopFmAddBook.ResumeLayout(false);
            pnlTopFmAddBook.PerformLayout();
            pnlBooksGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            pnlSearchBook.ResumeLayout(false);
            pnlSearchBook.PerformLayout();
           /* ResumeLayout(false);*/
        }

        //#endregion
        private System.Windows.Forms.PictureBox pbCloseFmBooks;
        private System.Windows.Forms.Panel pnlButtosBooks;
        private System.Windows.Forms.Button btnAddNewBook;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.Panel pnlBooksGrid;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Panel pnlContainerFmAddOrUpdateBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitleBook;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtPriceBook;
        private System.Windows.Forms.MaskedTextBox mtxtISBN;
        private System.Windows.Forms.ComboBox cbGenreBook;
        private System.Windows.Forms.TextBox txtAmountBook;
        private System.Windows.Forms.TextBox txteditoraBook;
        private System.Windows.Forms.TextBox txtAuthorBook;
        private System.Windows.Forms.TextBox txtYearBook;
        private System.Windows.Forms.TextBox txtTitleBook;
        private System.Windows.Forms.Button btnCancelbook;
        private System.Windows.Forms.Button btnSaveBook;
        private System.Windows.Forms.Panel pnlTopFmAddBook;
        private System.Windows.Forms.Label lblTitleAddBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnUpdateData;
        private System.Windows.Forms.Panel pnlSearchBook;
        private System.Windows.Forms.TextBox txtFilterData;
    }
}