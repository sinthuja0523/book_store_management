namespace BookStoreMgt.Forms
{
    partial class FmCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmCustomers));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlButtosBooks = new Panel();
            pnlContainerFmAddOrUpdateBook = new Panel();
            btnSaveData = new Button();
            btnCancelbook = new Button();
            btnDeleteBook = new Button();
            txtCustomerPhone = new TextBox();
            label3 = new Label();
            txtCustomerEmail = new TextBox();
            btnUpdateData = new Button();
            label2 = new Label();
            txtPriceBook = new TextBox();
            txtAmountBook = new TextBox();
            txtCustomerName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            lblTitleBook = new Label();
            pnlTopFmAddBook = new Panel();
            lblTitleAddBook = new Label();
            dgvBooks = new DataGridView();
            pnlSearchBook = new Panel();
            txtFilterData = new TextBox();
            btnSearchBook = new Button();
            label1 = new Label();
            pnlButtosBooks.SuspendLayout();
            pnlContainerFmAddOrUpdateBook.SuspendLayout();
            pnlTopFmAddBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            pnlSearchBook.SuspendLayout();
            SuspendLayout();
            // 
            // pnlButtosBooks
            // 
            pnlButtosBooks.Controls.Add(pnlContainerFmAddOrUpdateBook);
            pnlButtosBooks.Controls.Add(pnlTopFmAddBook);
            pnlButtosBooks.Controls.Add(dgvBooks);
            pnlButtosBooks.Controls.Add(pnlSearchBook);
            pnlButtosBooks.Dock = DockStyle.Fill;
            pnlButtosBooks.Location = new Point(0, 0);
            pnlButtosBooks.Margin = new Padding(5, 4, 5, 4);
            pnlButtosBooks.Name = "pnlButtosBooks";
            pnlButtosBooks.Size = new Size(1400, 923);
            pnlButtosBooks.TabIndex = 2;
            // 
            // pnlContainerFmAddOrUpdateBook
            // 
            pnlContainerFmAddOrUpdateBook.BackColor = SystemColors.Control;
            pnlContainerFmAddOrUpdateBook.Controls.Add(btnSaveData);
            pnlContainerFmAddOrUpdateBook.Controls.Add(btnCancelbook);
            pnlContainerFmAddOrUpdateBook.Controls.Add(btnDeleteBook);
            pnlContainerFmAddOrUpdateBook.Controls.Add(txtCustomerPhone);
            pnlContainerFmAddOrUpdateBook.Controls.Add(label3);
            pnlContainerFmAddOrUpdateBook.Controls.Add(txtCustomerEmail);
            pnlContainerFmAddOrUpdateBook.Controls.Add(btnUpdateData);
            pnlContainerFmAddOrUpdateBook.Controls.Add(label2);
            pnlContainerFmAddOrUpdateBook.Controls.Add(txtPriceBook);
            pnlContainerFmAddOrUpdateBook.Controls.Add(txtAmountBook);
            pnlContainerFmAddOrUpdateBook.Controls.Add(txtCustomerName);
            pnlContainerFmAddOrUpdateBook.Controls.Add(label7);
            pnlContainerFmAddOrUpdateBook.Controls.Add(label6);
            pnlContainerFmAddOrUpdateBook.Controls.Add(lblTitleBook);
            pnlContainerFmAddOrUpdateBook.Location = new Point(63, 531);
            pnlContainerFmAddOrUpdateBook.Margin = new Padding(5, 4, 5, 4);
            pnlContainerFmAddOrUpdateBook.Name = "pnlContainerFmAddOrUpdateBook";
            pnlContainerFmAddOrUpdateBook.Size = new Size(1270, 306);
            pnlContainerFmAddOrUpdateBook.TabIndex = 3;
            // 
            // btnSaveData
            // 
            btnSaveData.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSaveData.BackColor = Color.ForestGreen;
            btnSaveData.Cursor = Cursors.Hand;
            btnSaveData.FlatAppearance.BorderSize = 0;
            btnSaveData.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnSaveData.FlatStyle = FlatStyle.Flat;
            btnSaveData.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btnSaveData.ForeColor = Color.White;
            btnSaveData.Location = new Point(318, 231);
            btnSaveData.Margin = new Padding(5, 4, 5, 4);
            btnSaveData.Name = "btnSaveData";
            btnSaveData.Size = new Size(148, 61);
            btnSaveData.TabIndex = 38;
            btnSaveData.Text = "Update";
            btnSaveData.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSaveData.UseVisualStyleBackColor = false;
            btnSaveData.Click += btnSaveBook_Click;
            // 
            // btnCancelbook
            // 
            btnCancelbook.BackColor = Color.DarkOrange;
            btnCancelbook.Cursor = Cursors.Hand;
            btnCancelbook.FlatAppearance.BorderSize = 0;
            btnCancelbook.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnCancelbook.FlatStyle = FlatStyle.Flat;
            btnCancelbook.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btnCancelbook.ForeColor = Color.White;
            btnCancelbook.Image = (Image)resources.GetObject("btnCancelbook.Image");
            btnCancelbook.Location = new Point(608, 39);
            btnCancelbook.Margin = new Padding(5, 4, 5, 4);
            btnCancelbook.Name = "btnCancelbook";
            btnCancelbook.Size = new Size(322, 61);
            btnCancelbook.TabIndex = 35;
            btnCancelbook.Text = "Clear records";
            btnCancelbook.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelbook.UseVisualStyleBackColor = false;
            btnCancelbook.Click += btnCancelbook_Click;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDeleteBook.BackColor = Color.FromArgb(192, 0, 0);
            btnDeleteBook.Cursor = Cursors.Hand;
            btnDeleteBook.FlatAppearance.BorderSize = 0;
            btnDeleteBook.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnDeleteBook.FlatStyle = FlatStyle.Flat;
            btnDeleteBook.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btnDeleteBook.ForeColor = Color.White;
            btnDeleteBook.Image = (Image)resources.GetObject("btnDeleteBook.Image");
            btnDeleteBook.Location = new Point(608, 177);
            btnDeleteBook.Margin = new Padding(5, 4, 5, 4);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(322, 61);
            btnDeleteBook.TabIndex = 6;
            btnDeleteBook.Text = "Delete customer";
            btnDeleteBook.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDeleteBook.UseVisualStyleBackColor = false;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // txtCustomerPhone
            // 
            txtCustomerPhone.BorderStyle = BorderStyle.None;
            txtCustomerPhone.Location = new Point(114, 182);
            txtCustomerPhone.Margin = new Padding(5, 4, 5, 4);
            txtCustomerPhone.Multiline = true;
            txtCustomerPhone.Name = "txtCustomerPhone";
            txtCustomerPhone.Size = new Size(352, 31);
            txtCustomerPhone.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(35, 182);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(66, 22);
            label3.TabIndex = 36;
            label3.Text = "Phone";
            // 
            // txtCustomerEmail
            // 
            txtCustomerEmail.BorderStyle = BorderStyle.None;
            txtCustomerEmail.Location = new Point(114, 109);
            txtCustomerEmail.Margin = new Padding(5, 4, 5, 4);
            txtCustomerEmail.Multiline = true;
            txtCustomerEmail.Name = "txtCustomerEmail";
            txtCustomerEmail.Size = new Size(352, 31);
            txtCustomerEmail.TabIndex = 35;
            // 
            // btnUpdateData
            // 
            btnUpdateData.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnUpdateData.BackColor = Color.Teal;
            btnUpdateData.Cursor = Cursors.Hand;
            btnUpdateData.FlatAppearance.BorderSize = 0;
            btnUpdateData.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnUpdateData.FlatStyle = FlatStyle.Flat;
            btnUpdateData.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btnUpdateData.ForeColor = Color.White;
            btnUpdateData.Image = (Image)resources.GetObject("btnUpdateData.Image");
            btnUpdateData.Location = new Point(608, 108);
            btnUpdateData.Margin = new Padding(5, 4, 5, 4);
            btnUpdateData.Name = "btnUpdateData";
            btnUpdateData.Size = new Size(322, 61);
            btnUpdateData.TabIndex = 5;
            btnUpdateData.Text = "Edit customer";
            btnUpdateData.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdateData.UseVisualStyleBackColor = false;
            btnUpdateData.Click += btnUpdateData_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(35, 109);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(56, 22);
            label2.TabIndex = 34;
            label2.Text = "Email";
            // 
            // txtPriceBook
            // 
            txtPriceBook.BorderStyle = BorderStyle.None;
            txtPriceBook.Location = new Point(647, 315);
            txtPriceBook.Margin = new Padding(5, 4, 5, 4);
            txtPriceBook.MaxLength = 20;
            txtPriceBook.Multiline = true;
            txtPriceBook.Name = "txtPriceBook";
            txtPriceBook.Size = new Size(352, 31);
            txtPriceBook.TabIndex = 33;
            txtPriceBook.KeyPress += txtPriceBook_KeyPress;
            // 
            // txtAmountBook
            // 
            txtAmountBook.BorderStyle = BorderStyle.None;
            txtAmountBook.Location = new Point(146, 315);
            txtAmountBook.Margin = new Padding(5, 4, 5, 4);
            txtAmountBook.Multiline = true;
            txtAmountBook.Name = "txtAmountBook";
            txtAmountBook.Size = new Size(352, 31);
            txtAmountBook.TabIndex = 30;
            txtAmountBook.KeyPress += txtAmountBook_KeyPress;
            // 
            // txtCustomerName
            // 
            txtCustomerName.BorderStyle = BorderStyle.None;
            txtCustomerName.Location = new Point(114, 39);
            txtCustomerName.Margin = new Padding(5, 4, 5, 4);
            txtCustomerName.Multiline = true;
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(352, 31);
            txtCustomerName.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(536, 314);
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
            label6.Location = new Point(35, 315);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(87, 23);
            label6.TabIndex = 24;
            label6.Text = "Amount";
            // 
            // lblTitleBook
            // 
            lblTitleBook.AutoSize = true;
            lblTitleBook.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold);
            lblTitleBook.ForeColor = Color.Black;
            lblTitleBook.Location = new Point(35, 39);
            lblTitleBook.Margin = new Padding(5, 0, 5, 0);
            lblTitleBook.Name = "lblTitleBook";
            lblTitleBook.Size = new Size(64, 22);
            lblTitleBook.TabIndex = 19;
            lblTitleBook.Text = "Name";
            // 
            // pnlTopFmAddBook
            // 
            pnlTopFmAddBook.BackColor = Color.Silver;
            pnlTopFmAddBook.Controls.Add(lblTitleAddBook);
            pnlTopFmAddBook.Dock = DockStyle.Top;
            pnlTopFmAddBook.Location = new Point(0, 0);
            pnlTopFmAddBook.Margin = new Padding(5, 4, 5, 4);
            pnlTopFmAddBook.Name = "pnlTopFmAddBook";
            pnlTopFmAddBook.Size = new Size(1400, 51);
            pnlTopFmAddBook.TabIndex = 36;
            // 
            // lblTitleAddBook
            // 
            lblTitleAddBook.AutoSize = true;
            lblTitleAddBook.FlatStyle = FlatStyle.Flat;
            lblTitleAddBook.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleAddBook.ForeColor = Color.Black;
            lblTitleAddBook.ImageAlign = ContentAlignment.MiddleLeft;
            lblTitleAddBook.Location = new Point(579, 13);
            lblTitleAddBook.Margin = new Padding(5, 0, 5, 0);
            lblTitleAddBook.Name = "lblTitleAddBook";
            lblTitleAddBook.Size = new Size(242, 23);
            lblTitleAddBook.TabIndex = 0;
            lblTitleAddBook.Text = "Customer Management";
            lblTitleAddBook.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvBooks
            // 
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
            dgvBooks.Location = new Point(63, 174);
            dgvBooks.Margin = new Padding(5, 4, 5, 4);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.RowHeadersVisible = false;
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.Size = new Size(1275, 293);
            dgvBooks.TabIndex = 2;
            // 
            // pnlSearchBook
            // 
            pnlSearchBook.BackColor = Color.Silver;
            pnlSearchBook.Controls.Add(txtFilterData);
            pnlSearchBook.Controls.Add(btnSearchBook);
            pnlSearchBook.Controls.Add(label1);
            pnlSearchBook.Location = new Point(211, 59);
            pnlSearchBook.Margin = new Padding(5, 4, 5, 4);
            pnlSearchBook.Name = "pnlSearchBook";
            pnlSearchBook.Size = new Size(963, 83);
            pnlSearchBook.TabIndex = 7;
            // 
            // txtFilterData
            // 
            txtFilterData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtFilterData.BackColor = Color.White;
            txtFilterData.BorderStyle = BorderStyle.None;
            txtFilterData.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFilterData.Location = new Point(162, 28);
            txtFilterData.Margin = new Padding(5, 4, 5, 4);
            txtFilterData.MaxLength = 50;
            txtFilterData.Name = "txtFilterData";
            txtFilterData.Size = new Size(708, 30);
            txtFilterData.TabIndex = 5;
            txtFilterData.Text = "Type here the customer name";
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
            btnSearchBook.Location = new Point(895, 19);
            btnSearchBook.Margin = new Padding(5, 4, 5, 4);
            btnSearchBook.Name = "btnSearchBook";
            btnSearchBook.Size = new Size(63, 53);
            btnSearchBook.TabIndex = 1;
            btnSearchBook.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSearchBook.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(52, 28);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(77, 23);
            label1.TabIndex = 4;
            label1.Text = "Search";
            // 
            // FmCustomers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1400, 923);
            Controls.Add(pnlButtosBooks);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "FmCustomers";
            Text = "FmBooks";
            Load += FmBooks_Load;
            pnlButtosBooks.ResumeLayout(false);
            pnlContainerFmAddOrUpdateBook.ResumeLayout(false);
            pnlContainerFmAddOrUpdateBook.PerformLayout();
            pnlTopFmAddBook.ResumeLayout(false);
            pnlTopFmAddBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            pnlSearchBook.ResumeLayout(false);
            pnlSearchBook.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel pnlButtosBooks;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Panel pnlContainerFmAddOrUpdateBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTitleBook;
        private System.Windows.Forms.TextBox txtPriceBook;
        private System.Windows.Forms.TextBox txtAmountBook;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Button btnCancelbook;
        private System.Windows.Forms.Panel pnlTopFmAddBook;
        private System.Windows.Forms.Label lblTitleAddBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnUpdateData;
        private System.Windows.Forms.Panel pnlSearchBook;
        private System.Windows.Forms.TextBox txtFilterData;
        private TextBox txtCustomerPhone;
        private Label label3;
        private TextBox txtCustomerEmail;
        private Label label2;
        private Button btnSaveData;
    }
}