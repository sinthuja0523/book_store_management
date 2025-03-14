﻿namespace BookStoreMgt.Forms
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlButtosBooks = new Panel();
            pnlTopFmAddBook = new Panel();
            lblTitleAddBook = new Label();
            pnlContainerFmAddOrUpdateBook = new Panel();
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
            pnlButtosBooks.Location = new Point(24, 14);
            pnlButtosBooks.Margin = new Padding(4, 3, 4, 3);
            pnlButtosBooks.Name = "pnlButtosBooks";
            pnlButtosBooks.Size = new Size(476, 624);
            pnlButtosBooks.TabIndex = 2;
            // 
            // pnlTopFmAddBook
            // 
            pnlTopFmAddBook.BackColor = Color.Silver;
            pnlTopFmAddBook.Controls.Add(lblTitleAddBook);
            pnlTopFmAddBook.Dock = DockStyle.Top;
            pnlTopFmAddBook.Location = new Point(0, 0);
            pnlTopFmAddBook.Margin = new Padding(4, 3, 4, 3);
            pnlTopFmAddBook.Name = "pnlTopFmAddBook";
            pnlTopFmAddBook.Size = new Size(476, 38);
            pnlTopFmAddBook.TabIndex = 36;
//            pnlTopFmAddBook.Paint += pnlTopFmAddBook_Paint;
            // 
            // lblTitleAddBook
            // 
            lblTitleAddBook.AutoSize = true;
            lblTitleAddBook.FlatStyle = FlatStyle.Flat;
            lblTitleAddBook.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleAddBook.ForeColor = Color.Black;
            lblTitleAddBook.ImageAlign = ContentAlignment.MiddleLeft;
            lblTitleAddBook.Location = new Point(150, 10);
            lblTitleAddBook.Margin = new Padding(4, 0, 4, 0);
            lblTitleAddBook.Name = "lblTitleAddBook";
            lblTitleAddBook.Size = new Size(139, 19);
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
            pnlContainerFmAddOrUpdateBook.Dock = DockStyle.Fill;
            pnlContainerFmAddOrUpdateBook.Location = new Point(0, 0);
            pnlContainerFmAddOrUpdateBook.Margin = new Padding(4, 3, 4, 3);
            pnlContainerFmAddOrUpdateBook.Name = "pnlContainerFmAddOrUpdateBook";
            pnlContainerFmAddOrUpdateBook.Size = new Size(476, 624);
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
            btnCancelbook.Location = new Point(235, 544);
            btnCancelbook.Margin = new Padding(4, 3, 4, 3);
            btnCancelbook.Name = "btnCancelbook";
            btnCancelbook.Size = new Size(200, 52);
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
            btnSaveBook.Location = new Point(30, 544);
            btnSaveBook.Margin = new Padding(4, 3, 4, 3);
            btnSaveBook.Name = "btnSaveBook";
            btnSaveBook.Size = new Size(200, 52);
            btnSaveBook.TabIndex = 34;
            btnSaveBook.Text = "Add Book";
            btnSaveBook.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSaveBook.UseVisualStyleBackColor = false;
            btnSaveBook.Click += btnSaveBook_Click;
            // 
            // txtPriceBook
            // 
            txtPriceBook.BorderStyle = BorderStyle.None;
            txtPriceBook.Location = new Point(127, 460);
            txtPriceBook.Margin = new Padding(4, 3, 4, 3);
            txtPriceBook.MaxLength = 20;
            txtPriceBook.Multiline = true;
            txtPriceBook.Name = "txtPriceBook";
            txtPriceBook.Size = new Size(308, 23);
            txtPriceBook.TabIndex = 33;
            txtPriceBook.KeyPress += txtPriceBook_KeyPress;
            // 
            // mtxtISBN
            // 
            mtxtISBN.BorderStyle = BorderStyle.None;
            mtxtISBN.Location = new Point(127, 82);
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
            cbGenreBook.Location = new Point(127, 351);
            cbGenreBook.Margin = new Padding(4, 3, 4, 3);
            cbGenreBook.Name = "cbGenreBook";
            cbGenreBook.Size = new Size(235, 23);
            cbGenreBook.TabIndex = 31;
            cbGenreBook.Text = "Select the  book genre:";
            // 
            // txtAmountBook
            // 
            txtAmountBook.BorderStyle = BorderStyle.None;
            txtAmountBook.Location = new Point(127, 405);
            txtAmountBook.Margin = new Padding(4, 3, 4, 3);
            txtAmountBook.Multiline = true;
            txtAmountBook.Name = "txtAmountBook";
            txtAmountBook.Size = new Size(308, 23);
            txtAmountBook.TabIndex = 30;
            txtAmountBook.KeyPress += txtAmountBook_KeyPress;
            // 
            // txteditoraBook
            // 
            txteditoraBook.BorderStyle = BorderStyle.None;
            txteditoraBook.Location = new Point(127, 297);
            txteditoraBook.Margin = new Padding(4, 3, 4, 3);
            txteditoraBook.Multiline = true;
            txteditoraBook.Name = "txteditoraBook";
            txteditoraBook.Size = new Size(308, 23);
            txteditoraBook.TabIndex = 29;
            // 
            // txtAuthorBook
            // 
            txtAuthorBook.BorderStyle = BorderStyle.None;
            txtAuthorBook.Location = new Point(127, 186);
            txtAuthorBook.Margin = new Padding(4, 3, 4, 3);
            txtAuthorBook.Multiline = true;
            txtAuthorBook.Name = "txtAuthorBook";
            txtAuthorBook.Size = new Size(308, 23);
            txtAuthorBook.TabIndex = 28;
            // 
            // txtYearBook
            // 
            txtYearBook.BorderStyle = BorderStyle.None;
            txtYearBook.Location = new Point(127, 242);
            txtYearBook.Margin = new Padding(4, 3, 4, 3);
            txtYearBook.MaxLength = 4;
            txtYearBook.Multiline = true;
            txtYearBook.Name = "txtYearBook";
            txtYearBook.Size = new Size(308, 23);
            txtYearBook.TabIndex = 27;
            txtYearBook.KeyPress += txtYearBook_KeyPress;
            // 
            // txtTitleBook
            // 
            txtTitleBook.BorderStyle = BorderStyle.None;
            txtTitleBook.Location = new Point(127, 131);
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
            label7.ForeColor = Color.Black;
            label7.Location = new Point(30, 459);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(80, 19);
            label7.TabIndex = 25;
            label7.Text = "Price (RS)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(30, 405);
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
            label5.ForeColor = Color.Black;
            label5.Location = new Point(30, 351);
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
            label4.ForeColor = Color.Black;
            label4.Location = new Point(30, 297);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(51, 19);
            label4.TabIndex = 22;
            label4.Text = "Editor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(30, 243);
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
            label2.ForeColor = Color.Black;
            label2.Location = new Point(30, 189);
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
            lblTitleBook.ForeColor = Color.Black;
            lblTitleBook.Location = new Point(33, 135);
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
            lblISBN.ForeColor = Color.Black;
            lblISBN.Location = new Point(33, 81);
            lblISBN.Margin = new Padding(4, 0, 4, 0);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(42, 19);
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
            btnSearchBook.Location = new Point(622, 32);
            btnSearchBook.Margin = new Padding(4, 3, 4, 3);
            btnSearchBook.Name = "btnSearchBook";
            btnSearchBook.Size = new Size(55, 40);
            btnSearchBook.TabIndex = 1;
            btnSearchBook.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSearchBook.UseVisualStyleBackColor = false;
            //btnSearchBook.Click += btnSearchBook_Click;
            // 
            // pnlBooksGrid
            // 
            pnlBooksGrid.Controls.Add(btnDeleteBook);
            pnlBooksGrid.Controls.Add(btnUpdateData);
            pnlBooksGrid.Controls.Add(dgvBooks);
            pnlBooksGrid.Controls.Add(pnlSearchBook);
            pnlBooksGrid.Dock = DockStyle.Right;
            pnlBooksGrid.Location = new Point(499, 0);
            pnlBooksGrid.Margin = new Padding(4, 3, 4, 3);
            pnlBooksGrid.Name = "pnlBooksGrid";
            pnlBooksGrid.Size = new Size(726, 692);
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
            btnDeleteBook.Location = new Point(373, 558);
            btnDeleteBook.Margin = new Padding(4, 3, 4, 3);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(340, 80);
            btnDeleteBook.TabIndex = 6;
            btnDeleteBook.Text = "Delete";
            btnDeleteBook.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDeleteBook.UseVisualStyleBackColor = false;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // btnUpdateData
            // 
            btnUpdateData.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnUpdateData.BackColor = Color.Teal;
            btnUpdateData.Cursor = Cursors.Hand;
            btnUpdateData.FlatAppearance.BorderSize = 0;
            btnUpdateData.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnUpdateData.FlatStyle = FlatStyle.Flat;
            btnUpdateData.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdateData.ForeColor = Color.White;
            btnUpdateData.Image = (Image)resources.GetObject("btnUpdateData.Image");
            btnUpdateData.Location = new Point(16, 558);
            btnUpdateData.Margin = new Padding(4, 3, 4, 3);
            btnUpdateData.Name = "btnUpdateData";
            btnUpdateData.Size = new Size(340, 80);
            btnUpdateData.TabIndex = 5;
            btnUpdateData.Text = "Update data";
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
            dgvBooks.GridColor = Color.FromArgb(64, 64, 64);
            dgvBooks.Location = new Point(16, 140);
            dgvBooks.Margin = new Padding(4, 3, 4, 3);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.RowHeadersVisible = false;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.Size = new Size(697, 403);
            dgvBooks.TabIndex = 2;
            // 
            // pnlSearchBook
            // 
            pnlSearchBook.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlSearchBook.BackColor = Color.Silver;
            pnlSearchBook.Controls.Add(txtFilterData);
            pnlSearchBook.Controls.Add(btnSearchBook);
            pnlSearchBook.Controls.Add(label1);
            pnlSearchBook.Location = new Point(13, 14);
            pnlSearchBook.Margin = new Padding(4, 3, 4, 3);
            pnlSearchBook.Name = "pnlSearchBook";
            pnlSearchBook.Size = new Size(700, 100);
            pnlSearchBook.TabIndex = 7;
            // 
            // txtFilterData
            // 
            txtFilterData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtFilterData.BackColor = Color.White;
            txtFilterData.BorderStyle = BorderStyle.None;
            txtFilterData.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFilterData.Location = new Point(115, 40);
            txtFilterData.Margin = new Padding(4, 3, 4, 3);
            txtFilterData.MaxLength = 50;
            txtFilterData.Name = "txtFilterData";
            txtFilterData.Size = new Size(477, 24);
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
            label1.Location = new Point(22, 43);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 19);
            label1.TabIndex = 4;
            label1.Text = "Search";
            // 
            // btnCloseCustomerDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1225, 692);
            Controls.Add(pnlBooksGrid);
            Controls.Add(pnlButtosBooks);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "btnCloseCustomerDetails";
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