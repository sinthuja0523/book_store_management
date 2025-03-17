namespace BookStoreMgt.Forms
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmBooks));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnlButtosBooks = new Panel();
            pnlTopFmAddBook = new Panel();
            lblTitleAddBook = new Label();
            pnlContainerFmAddOrUpdateBook = new Panel();
            btnCancelbook = new Button();
            btnSaveBook = new Button();
            txtPriceBook = new TextBox();
            mtxtISBN = new MaskedTextBox();
            cbGenreBook = new ComboBox();
            txtQuantityBook = new TextBox();
            txtEditorBook = new TextBox();
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
            btnSearchBook = new Button();
            pnlBooksGrid = new Panel();
            btnDeleteBook = new Button();
            btnUpdateData = new Button();
            dgvBooks = new DataGridView();
            pnlSearchBook = new Panel();
            txtFilterData = new TextBox();
            label1 = new Label();
            pnlButtosBooks.SuspendLayout();
            pnlTopFmAddBook.SuspendLayout();
            pnlContainerFmAddOrUpdateBook.SuspendLayout();
            pnlBooksGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            pnlSearchBook.SuspendLayout();
            SuspendLayout();
            // 
            // pnlButtosBooks
            // 
            pnlButtosBooks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlButtosBooks.Controls.Add(pnlTopFmAddBook);
            pnlButtosBooks.Controls.Add(pnlContainerFmAddOrUpdateBook);
            pnlButtosBooks.Location = new Point(27, 19);
            pnlButtosBooks.Margin = new Padding(5, 4, 5, 4);
            pnlButtosBooks.Name = "pnlButtosBooks";
            pnlButtosBooks.Size = new Size(544, 832);
            pnlButtosBooks.TabIndex = 2;
            // 
            // pnlTopFmAddBook
            // 
            pnlTopFmAddBook.BackColor = Color.Silver;
            pnlTopFmAddBook.Controls.Add(lblTitleAddBook);
            pnlTopFmAddBook.Dock = DockStyle.Top;
            pnlTopFmAddBook.Location = new Point(0, 0);
            pnlTopFmAddBook.Margin = new Padding(5, 4, 5, 4);
            pnlTopFmAddBook.Name = "pnlTopFmAddBook";
            pnlTopFmAddBook.Size = new Size(544, 51);
            pnlTopFmAddBook.TabIndex = 36;
            // 
            // lblTitleAddBook
            // 
            lblTitleAddBook.AutoSize = true;
            lblTitleAddBook.FlatStyle = FlatStyle.Flat;
            lblTitleAddBook.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleAddBook.ForeColor = Color.Black;
            lblTitleAddBook.ImageAlign = ContentAlignment.MiddleLeft;
            lblTitleAddBook.Location = new Point(171, 13);
            lblTitleAddBook.Margin = new Padding(5, 0, 5, 0);
            lblTitleAddBook.Name = "lblTitleAddBook";
            lblTitleAddBook.Size = new Size(174, 23);
            lblTitleAddBook.TabIndex = 0;
            lblTitleAddBook.Text = "Add a new book";
            lblTitleAddBook.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlContainerFmAddOrUpdateBook
            // 
            pnlContainerFmAddOrUpdateBook.BackColor = SystemColors.Control;
            pnlContainerFmAddOrUpdateBook.Controls.Add(btnCancelbook);
            pnlContainerFmAddOrUpdateBook.Controls.Add(btnSaveBook);
            pnlContainerFmAddOrUpdateBook.Controls.Add(txtPriceBook);
            pnlContainerFmAddOrUpdateBook.Controls.Add(mtxtISBN);
            pnlContainerFmAddOrUpdateBook.Controls.Add(cbGenreBook);
            pnlContainerFmAddOrUpdateBook.Controls.Add(txtQuantityBook);
            pnlContainerFmAddOrUpdateBook.Controls.Add(txtEditorBook);
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
            pnlContainerFmAddOrUpdateBook.Dock = DockStyle.Fill;
            pnlContainerFmAddOrUpdateBook.Location = new Point(0, 0);
            pnlContainerFmAddOrUpdateBook.Margin = new Padding(5, 4, 5, 4);
            pnlContainerFmAddOrUpdateBook.Name = "pnlContainerFmAddOrUpdateBook";
            pnlContainerFmAddOrUpdateBook.Size = new Size(544, 832);
            pnlContainerFmAddOrUpdateBook.TabIndex = 3;
            // 
            // btnCancelbook
            // 
            btnCancelbook.BackColor = Color.FromArgb(192, 0, 0);
            btnCancelbook.Cursor = Cursors.Hand;
            btnCancelbook.FlatAppearance.BorderSize = 0;
            btnCancelbook.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnCancelbook.FlatStyle = FlatStyle.Flat;
            btnCancelbook.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelbook.ForeColor = Color.White;
            btnCancelbook.Image = (Image)resources.GetObject("btnCancelbook.Image");
            btnCancelbook.Location = new Point(269, 725);
            btnCancelbook.Margin = new Padding(5, 4, 5, 4);
            btnCancelbook.Name = "btnCancelbook";
            btnCancelbook.Size = new Size(229, 69);
            btnCancelbook.TabIndex = 35;
            btnCancelbook.Text = "Clear records";
            btnCancelbook.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelbook.UseVisualStyleBackColor = false;
            btnCancelbook.Click += btnCancelbook_Click;
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
            btnSaveBook.Location = new Point(34, 725);
            btnSaveBook.Margin = new Padding(5, 4, 5, 4);
            btnSaveBook.Name = "btnSaveBook";
            btnSaveBook.Size = new Size(229, 69);
            btnSaveBook.TabIndex = 34;
            btnSaveBook.Text = "Add Book";
            btnSaveBook.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSaveBook.UseVisualStyleBackColor = false;
            btnSaveBook.Click += btnSaveBook_Click;
            // 
            // txtPriceBook
            // 
            txtPriceBook.BorderStyle = BorderStyle.None;
            txtPriceBook.Location = new Point(145, 613);
            txtPriceBook.Margin = new Padding(5, 4, 5, 4);
            txtPriceBook.MaxLength = 20;
            txtPriceBook.Multiline = true;
            txtPriceBook.Name = "txtPriceBook";
            txtPriceBook.Size = new Size(268, 31);
            txtPriceBook.TabIndex = 39;
            txtPriceBook.KeyPress += txtPriceBook_KeyPress;
            // 
            // mtxtISBN
            // 
            mtxtISBN.BorderStyle = BorderStyle.None;
            mtxtISBN.Location = new Point(145, 109);
            mtxtISBN.Margin = new Padding(5, 4, 5, 4);
            mtxtISBN.Mask = "ISBN 000-&&&&&&&&&-0";
            mtxtISBN.Name = "mtxtISBN";
            mtxtISBN.Size = new Size(352, 20);
            mtxtISBN.TabIndex = 32;
            // 
            // cbGenreBook
            // 
            cbGenreBook.FlatStyle = FlatStyle.Flat;
            cbGenreBook.FormattingEnabled = true;
            cbGenreBook.Location = new Point(145, 468);
            cbGenreBook.Margin = new Padding(5, 4, 5, 4);
            cbGenreBook.Name = "cbGenreBook";
            cbGenreBook.Size = new Size(268, 28);
            cbGenreBook.TabIndex = 37;
            cbGenreBook.Text = "Select the  book genre:";
            // 
            // txtQuantityBook
            // 
            txtQuantityBook.BorderStyle = BorderStyle.None;
            txtQuantityBook.Location = new Point(145, 540);
            txtQuantityBook.Margin = new Padding(5, 4, 5, 4);
            txtQuantityBook.Multiline = true;
            txtQuantityBook.Name = "txtQuantityBook";
            txtQuantityBook.Size = new Size(268, 31);
            txtQuantityBook.TabIndex = 38;
            txtQuantityBook.KeyPress += txtAmountBook_KeyPress;
            // 
            // txtEditorBook
            // 
            txtEditorBook.BorderStyle = BorderStyle.None;
            txtEditorBook.Location = new Point(145, 396);
            txtEditorBook.Margin = new Padding(5, 4, 5, 4);
            txtEditorBook.Multiline = true;
            txtEditorBook.Name = "txtEditorBook";
            txtEditorBook.Size = new Size(352, 31);
            txtEditorBook.TabIndex = 36;
            // 
            // txtAuthorBook
            // 
            txtAuthorBook.BorderStyle = BorderStyle.None;
            txtAuthorBook.Location = new Point(145, 248);
            txtAuthorBook.Margin = new Padding(5, 4, 5, 4);
            txtAuthorBook.Multiline = true;
            txtAuthorBook.Name = "txtAuthorBook";
            txtAuthorBook.Size = new Size(352, 31);
            txtAuthorBook.TabIndex = 34;
            // 
            // txtYearBook
            // 
            txtYearBook.BorderStyle = BorderStyle.None;
            txtYearBook.Location = new Point(145, 323);
            txtYearBook.Margin = new Padding(5, 4, 5, 4);
            txtYearBook.MaxLength = 4;
            txtYearBook.Multiline = true;
            txtYearBook.Name = "txtYearBook";
            txtYearBook.Size = new Size(352, 31);
            txtYearBook.TabIndex = 35;
            txtYearBook.KeyPress += txtYearBook_KeyPress;
            // 
            // txtTitleBook
            // 
            txtTitleBook.BorderStyle = BorderStyle.None;
            txtTitleBook.Location = new Point(145, 175);
            txtTitleBook.Margin = new Padding(5, 4, 5, 4);
            txtTitleBook.Multiline = true;
            txtTitleBook.Name = "txtTitleBook";
            txtTitleBook.Size = new Size(352, 31);
            txtTitleBook.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(34, 612);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(102, 23);
            label7.TabIndex = 25;
            label7.Text = "Price (RS)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(34, 540);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(93, 23);
            label6.TabIndex = 24;
            label6.Text = "Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(34, 468);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(71, 23);
            label5.TabIndex = 23;
            label5.Text = "Genre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(34, 396);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(63, 23);
            label4.TabIndex = 22;
            label4.Text = "Editor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(34, 324);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(54, 23);
            label3.TabIndex = 21;
            label3.Text = "Year";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(34, 252);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 23);
            label2.TabIndex = 20;
            label2.Text = "Author";
            // 
            // lblTitleBook
            // 
            lblTitleBook.AutoSize = true;
            lblTitleBook.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleBook.ForeColor = Color.Black;
            lblTitleBook.Location = new Point(38, 180);
            lblTitleBook.Margin = new Padding(5, 0, 5, 0);
            lblTitleBook.Name = "lblTitleBook";
            lblTitleBook.Size = new Size(47, 23);
            lblTitleBook.TabIndex = 19;
            lblTitleBook.Text = "Title";
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblISBN.ForeColor = Color.Black;
            lblISBN.Location = new Point(38, 108);
            lblISBN.Margin = new Padding(5, 0, 5, 0);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(53, 23);
            lblISBN.TabIndex = 18;
            lblISBN.Text = "ISBN";
            // 
            // btnSearchBook
            // 
            btnSearchBook.BackColor = Color.Black;
            btnSearchBook.Cursor = Cursors.Hand;
            btnSearchBook.FlatAppearance.BorderSize = 0;
            btnSearchBook.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnSearchBook.FlatStyle = FlatStyle.Flat;
            btnSearchBook.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearchBook.ForeColor = Color.White;
            btnSearchBook.Image = (Image)resources.GetObject("btnSearchBook.Image");
            btnSearchBook.Location = new Point(711, 43);
            btnSearchBook.Margin = new Padding(5, 4, 5, 4);
            btnSearchBook.Name = "btnSearchBook";
            btnSearchBook.Size = new Size(63, 53);
            btnSearchBook.TabIndex = 1;
            btnSearchBook.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSearchBook.UseVisualStyleBackColor = false;
            // 
            // pnlBooksGrid
            // 
            pnlBooksGrid.Controls.Add(btnDeleteBook);
            pnlBooksGrid.Controls.Add(btnUpdateData);
            pnlBooksGrid.Controls.Add(dgvBooks);
            pnlBooksGrid.Controls.Add(pnlSearchBook);
            pnlBooksGrid.Dock = DockStyle.Right;
            pnlBooksGrid.Location = new Point(570, 0);
            pnlBooksGrid.Margin = new Padding(5, 4, 5, 4);
            pnlBooksGrid.Name = "pnlBooksGrid";
            pnlBooksGrid.Size = new Size(830, 923);
            pnlBooksGrid.TabIndex = 3;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDeleteBook.BackColor = Color.FromArgb(192, 0, 0);
            btnDeleteBook.Cursor = Cursors.Hand;
            btnDeleteBook.FlatAppearance.BorderSize = 0;
            btnDeleteBook.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnDeleteBook.FlatStyle = FlatStyle.Flat;
            btnDeleteBook.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeleteBook.ForeColor = Color.White;
            btnDeleteBook.Image = (Image)resources.GetObject("btnDeleteBook.Image");
            btnDeleteBook.Location = new Point(426, 744);
            btnDeleteBook.Margin = new Padding(5, 4, 5, 4);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(389, 107);
            btnDeleteBook.TabIndex = 6;
            btnDeleteBook.Text = "Delete book";
            btnDeleteBook.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDeleteBook.UseVisualStyleBackColor = false;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // btnUpdateData
            // 
            btnUpdateData.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnUpdateData.BackColor = Color.LightSeaGreen;
            btnUpdateData.Cursor = Cursors.Hand;
            btnUpdateData.FlatAppearance.BorderSize = 0;
            btnUpdateData.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnUpdateData.FlatStyle = FlatStyle.Flat;
            btnUpdateData.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdateData.ForeColor = Color.White;
            btnUpdateData.Image = (Image)resources.GetObject("btnUpdateData.Image");
            btnUpdateData.Location = new Point(18, 744);
            btnUpdateData.Margin = new Padding(5, 4, 5, 4);
            btnUpdateData.Name = "btnUpdateData";
            btnUpdateData.Size = new Size(389, 107);
            btnUpdateData.TabIndex = 5;
            btnUpdateData.Text = "Edit book";
            btnUpdateData.TextImageRelation = TextImageRelation.ImageAboveText;
            btnUpdateData.UseVisualStyleBackColor = false;
            btnUpdateData.Click += btnUpdateData_Click;
            // 
            // dgvBooks
            // 
            dgvBooks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvBooks.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvBooks.BackgroundColor = Color.Silver;
            dgvBooks.BorderStyle = BorderStyle.None;
            dgvBooks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(71, 3, 22);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = Color.Salmon;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvBooks.ColumnHeadersHeight = 30;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(144, 12, 63);
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(199, 0, 57);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvBooks.DefaultCellStyle = dataGridViewCellStyle4;
            dgvBooks.EnableHeadersVisualStyles = false;
            dgvBooks.GridColor = Color.FromArgb(64, 64, 64);
            dgvBooks.Location = new Point(18, 187);
            dgvBooks.Margin = new Padding(5, 4, 5, 4);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.RowHeadersVisible = false;
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.Size = new Size(797, 537);
            dgvBooks.TabIndex = 2;
            // 
            // pnlSearchBook
            // 
            pnlSearchBook.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlSearchBook.BackColor = Color.Silver;
            pnlSearchBook.Controls.Add(txtFilterData);
            pnlSearchBook.Controls.Add(btnSearchBook);
            pnlSearchBook.Controls.Add(label1);
            pnlSearchBook.Location = new Point(15, 19);
            pnlSearchBook.Margin = new Padding(5, 4, 5, 4);
            pnlSearchBook.Name = "pnlSearchBook";
            pnlSearchBook.Size = new Size(800, 133);
            pnlSearchBook.TabIndex = 7;
            // 
            // txtFilterData
            // 
            txtFilterData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtFilterData.BackColor = Color.White;
            txtFilterData.BorderStyle = BorderStyle.None;
            txtFilterData.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFilterData.Location = new Point(131, 53);
            txtFilterData.Margin = new Padding(5, 4, 5, 4);
            txtFilterData.MaxLength = 50;
            txtFilterData.Name = "txtFilterData";
            txtFilterData.Size = new Size(545, 30);
            txtFilterData.TabIndex = 5;
            txtFilterData.Text = "Type here the book title";
            txtFilterData.TextChanged += txtFilterData_TextChanged;
            txtFilterData.KeyPress += txtFilterData_KeyPress;
            txtFilterData.Leave += txtFilterData_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(25, 57);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(77, 23);
            label1.TabIndex = 4;
            label1.Text = "Search";
            // 
            // FmBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1400, 923);
            Controls.Add(pnlBooksGrid);
            Controls.Add(pnlButtosBooks);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "FmBooks";
            Text = "FmBooks";
            Load += FmBooks_Load;
            pnlButtosBooks.ResumeLayout(false);
            pnlTopFmAddBook.ResumeLayout(false);
            pnlTopFmAddBook.PerformLayout();
            pnlContainerFmAddOrUpdateBook.ResumeLayout(false);
            pnlContainerFmAddOrUpdateBook.PerformLayout();
            pnlBooksGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            pnlSearchBook.ResumeLayout(false);
            pnlSearchBook.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel pnlButtosBooks;
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
        private System.Windows.Forms.TextBox txtQuantityBook;
        private System.Windows.Forms.TextBox txtEditorBook;
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