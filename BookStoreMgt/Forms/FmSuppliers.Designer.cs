namespace BookStoreMgt.Forms
{
    partial class FmSuppliers
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnlButtosBooks = new Panel();
            pnlTopFmAddBook = new Panel();
            lblTitleAddSupplier = new Label();
            pnlContainerFmAddOrUpdateBook = new Panel();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            txtTPNo = new TextBox();
            btnCancelbook = new Button();
            btnSaveBook = new Button();
            txtName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lblTitleBook = new Label();
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
            pnlTopFmAddBook.Controls.Add(lblTitleAddSupplier);
            pnlTopFmAddBook.Dock = DockStyle.Top;
            pnlTopFmAddBook.Location = new Point(0, 0);
            pnlTopFmAddBook.Margin = new Padding(4, 3, 4, 3);
            pnlTopFmAddBook.Name = "pnlTopFmAddBook";
            pnlTopFmAddBook.Size = new Size(476, 38);
            pnlTopFmAddBook.TabIndex = 36;
            // 
            // lblTitleAddSupplier
            // 
            lblTitleAddSupplier.AutoSize = true;
            lblTitleAddSupplier.FlatStyle = FlatStyle.Flat;
            lblTitleAddSupplier.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleAddSupplier.ForeColor = Color.Black;
            lblTitleAddSupplier.ImageAlign = ContentAlignment.MiddleLeft;
            lblTitleAddSupplier.Location = new Point(150, 10);
            lblTitleAddSupplier.Margin = new Padding(4, 0, 4, 0);
            lblTitleAddSupplier.Name = "lblTitleAddSupplier";
            lblTitleAddSupplier.Size = new Size(145, 19);
            lblTitleAddSupplier.TabIndex = 0;
            lblTitleAddSupplier.Text = "Add new supplier";
            lblTitleAddSupplier.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlContainerFmAddOrUpdateBook
            // 
            pnlContainerFmAddOrUpdateBook.BackColor = SystemColors.Control;
            pnlContainerFmAddOrUpdateBook.Controls.Add(txtAddress);
            pnlContainerFmAddOrUpdateBook.Controls.Add(txtEmail);
            pnlContainerFmAddOrUpdateBook.Controls.Add(txtTPNo);
            pnlContainerFmAddOrUpdateBook.Controls.Add(btnCancelbook);
            pnlContainerFmAddOrUpdateBook.Controls.Add(btnSaveBook);
            pnlContainerFmAddOrUpdateBook.Controls.Add(txtName);
            pnlContainerFmAddOrUpdateBook.Controls.Add(label4);
            pnlContainerFmAddOrUpdateBook.Controls.Add(label3);
            pnlContainerFmAddOrUpdateBook.Controls.Add(label2);
            pnlContainerFmAddOrUpdateBook.Controls.Add(lblTitleBook);
            pnlContainerFmAddOrUpdateBook.Dock = DockStyle.Fill;
            pnlContainerFmAddOrUpdateBook.Location = new Point(0, 0);
            pnlContainerFmAddOrUpdateBook.Margin = new Padding(4, 3, 4, 3);
            pnlContainerFmAddOrUpdateBook.Name = "pnlContainerFmAddOrUpdateBook";
            pnlContainerFmAddOrUpdateBook.Size = new Size(476, 624);
            pnlContainerFmAddOrUpdateBook.TabIndex = 3;
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.None;
            txtAddress.Location = new Point(127, 295);
            txtAddress.Margin = new Padding(4, 3, 4, 3);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(308, 23);
            txtAddress.TabIndex = 38;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Location = new Point(127, 241);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(308, 23);
            txtEmail.TabIndex = 37;
            // 
            // txtTPNo
            // 
            txtTPNo.BorderStyle = BorderStyle.None;
            txtTPNo.Location = new Point(127, 187);
            txtTPNo.Margin = new Padding(4, 3, 4, 3);
            txtTPNo.Multiline = true;
            txtTPNo.Name = "txtTPNo";
            txtTPNo.Size = new Size(308, 23);
            txtTPNo.TabIndex = 36;
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
            btnCancelbook.Location = new Point(241, 397);
            btnCancelbook.Margin = new Padding(4, 3, 4, 3);
            btnCancelbook.Name = "btnCancelbook";
            btnCancelbook.Size = new Size(194, 52);
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
            btnSaveBook.Location = new Point(33, 397);
            btnSaveBook.Margin = new Padding(4, 3, 4, 3);
            btnSaveBook.Name = "btnSaveBook";
            btnSaveBook.Size = new Size(188, 52);
            btnSaveBook.TabIndex = 34;
            btnSaveBook.Text = "Add Supplier";
            btnSaveBook.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSaveBook.UseVisualStyleBackColor = false;
            btnSaveBook.Click += btnSaveBook_Click;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Location = new Point(127, 131);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(308, 23);
            txtName.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(30, 297);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 19);
            label4.TabIndex = 22;
            label4.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(30, 243);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(56, 19);
            label3.TabIndex = 21;
            label3.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(30, 189);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 19);
            label2.TabIndex = 20;
            label2.Text = "TP No:";
            // 
            // lblTitleBook
            // 
            lblTitleBook.AutoSize = true;
            lblTitleBook.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleBook.ForeColor = Color.Black;
            lblTitleBook.Location = new Point(33, 135);
            lblTitleBook.Margin = new Padding(4, 0, 4, 0);
            lblTitleBook.Name = "lblTitleBook";
            lblTitleBook.Size = new Size(62, 19);
            lblTitleBook.TabIndex = 19;
            lblTitleBook.Text = "Name:";
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
            btnDeleteBook.Location = new Point(373, 558);
            btnDeleteBook.Margin = new Padding(4, 3, 4, 3);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(340, 52);
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
            btnUpdateData.Location = new Point(16, 558);
            btnUpdateData.Margin = new Padding(4, 3, 4, 3);
            btnUpdateData.Name = "btnUpdateData";
            btnUpdateData.Size = new Size(340, 52);
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
            // FmSuppliers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1225, 692);
            Controls.Add(pnlBooksGrid);
            Controls.Add(pnlButtosBooks);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FmSuppliers";
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
        private System.Windows.Forms.Panel pnlBooksGrid;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Panel pnlContainerFmAddOrUpdateBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitleBook;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnCancelbook;
        private System.Windows.Forms.Button btnSaveBook;
        private System.Windows.Forms.Panel pnlTopFmAddBook;
        private System.Windows.Forms.Label lblTitleAddSupplier;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnUpdateData;
        private System.Windows.Forms.Panel pnlSearchBook;
        private System.Windows.Forms.TextBox txtFilterData;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private TextBox txtTPNo;
    }
}