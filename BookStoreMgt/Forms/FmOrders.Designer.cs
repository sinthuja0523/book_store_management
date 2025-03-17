namespace BookStoreMgt.Forms
{
    partial class FmOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmOrders));
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
            pnlButtosBooks.Margin = new Padding(4, 3, 4, 3);
            pnlButtosBooks.Name = "pnlButtosBooks";
            pnlButtosBooks.Size = new Size(1225, 692);
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
            pnlContainerFmAddOrUpdateBook.Location = new Point(55, 398);
            pnlContainerFmAddOrUpdateBook.Margin = new Padding(4, 3, 4, 3);
            pnlContainerFmAddOrUpdateBook.Name = "pnlContainerFmAddOrUpdateBook";
            pnlContainerFmAddOrUpdateBook.Size = new Size(1111, 230);
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
            btnSaveData.Location = new Point(278, 173);
            btnSaveData.Margin = new Padding(4, 3, 4, 3);
            btnSaveData.Name = "btnSaveData";
            btnSaveData.Size = new Size(130, 46);
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
            btnCancelbook.Location = new Point(532, 29);
            btnCancelbook.Margin = new Padding(4, 3, 4, 3);
            btnCancelbook.Name = "btnCancelbook";
            btnCancelbook.Size = new Size(282, 46);
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
            btnDeleteBook.Location = new Point(532, 133);
            btnDeleteBook.Margin = new Padding(4, 3, 4, 3);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(282, 46);
            btnDeleteBook.TabIndex = 6;
            btnDeleteBook.Text = "Delete customer";
            btnDeleteBook.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDeleteBook.UseVisualStyleBackColor = false;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // txtCustomerPhone
            // 
            txtCustomerPhone.BorderStyle = BorderStyle.None;
            txtCustomerPhone.Location = new Point(100, 136);
            txtCustomerPhone.Margin = new Padding(4, 3, 4, 3);
            txtCustomerPhone.Multiline = true;
            txtCustomerPhone.Name = "txtCustomerPhone";
            txtCustomerPhone.Size = new Size(308, 23);
            txtCustomerPhone.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(31, 136);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(54, 18);
            label3.TabIndex = 36;
            label3.Text = "Phone";
            // 
            // txtCustomerEmail
            // 
            txtCustomerEmail.BorderStyle = BorderStyle.None;
            txtCustomerEmail.Location = new Point(100, 82);
            txtCustomerEmail.Margin = new Padding(4, 3, 4, 3);
            txtCustomerEmail.Multiline = true;
            txtCustomerEmail.Name = "txtCustomerEmail";
            txtCustomerEmail.Size = new Size(308, 23);
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
            btnUpdateData.Location = new Point(532, 81);
            btnUpdateData.Margin = new Padding(4, 3, 4, 3);
            btnUpdateData.Name = "btnUpdateData";
            btnUpdateData.Size = new Size(282, 46);
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
            label2.Location = new Point(31, 82);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(48, 18);
            label2.TabIndex = 34;
            label2.Text = "Email";
            // 
            // txtPriceBook
            // 
            txtPriceBook.BorderStyle = BorderStyle.None;
            txtPriceBook.Location = new Point(566, 236);
            txtPriceBook.Margin = new Padding(4, 3, 4, 3);
            txtPriceBook.MaxLength = 20;
            txtPriceBook.Multiline = true;
            txtPriceBook.Name = "txtPriceBook";
            txtPriceBook.Size = new Size(308, 23);
            txtPriceBook.TabIndex = 33;
            txtPriceBook.KeyPress += txtPriceBook_KeyPress;
            // 
            // txtAmountBook
            // 
            txtAmountBook.BorderStyle = BorderStyle.None;
            txtAmountBook.Location = new Point(128, 236);
            txtAmountBook.Margin = new Padding(4, 3, 4, 3);
            txtAmountBook.Multiline = true;
            txtAmountBook.Name = "txtAmountBook";
            txtAmountBook.Size = new Size(308, 23);
            txtAmountBook.TabIndex = 30;
            txtAmountBook.KeyPress += txtAmountBook_KeyPress;
            // 
            // txtCustomerName
            // 
            txtCustomerName.BorderStyle = BorderStyle.None;
            txtCustomerName.Location = new Point(100, 29);
            txtCustomerName.Margin = new Padding(4, 3, 4, 3);
            txtCustomerName.Multiline = true;
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(308, 23);
            txtCustomerName.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(469, 236);
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
            label6.Location = new Point(31, 236);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(71, 19);
            label6.TabIndex = 24;
            label6.Text = "Amount";
            // 
            // lblTitleBook
            // 
            lblTitleBook.AutoSize = true;
            lblTitleBook.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold);
            lblTitleBook.ForeColor = Color.Black;
            lblTitleBook.Location = new Point(31, 29);
            lblTitleBook.Margin = new Padding(4, 0, 4, 0);
            lblTitleBook.Name = "lblTitleBook";
            lblTitleBook.Size = new Size(53, 18);
            lblTitleBook.TabIndex = 19;
            lblTitleBook.Text = "Name";
            // 
            // pnlTopFmAddBook
            // 
            pnlTopFmAddBook.BackColor = Color.Silver;
            pnlTopFmAddBook.Controls.Add(lblTitleAddBook);
            pnlTopFmAddBook.Dock = DockStyle.Top;
            pnlTopFmAddBook.Location = new Point(0, 0);
            pnlTopFmAddBook.Margin = new Padding(4, 3, 4, 3);
            pnlTopFmAddBook.Name = "pnlTopFmAddBook";
            pnlTopFmAddBook.Size = new Size(1225, 38);
            pnlTopFmAddBook.TabIndex = 36;
            // 
            // lblTitleAddBook
            // 
            lblTitleAddBook.AutoSize = true;
            lblTitleAddBook.FlatStyle = FlatStyle.Flat;
            lblTitleAddBook.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleAddBook.ForeColor = Color.Black;
            lblTitleAddBook.ImageAlign = ContentAlignment.MiddleLeft;
            lblTitleAddBook.Location = new Point(507, 10);
            lblTitleAddBook.Margin = new Padding(4, 0, 4, 0);
            lblTitleAddBook.Name = "lblTitleAddBook";
            lblTitleAddBook.Size = new Size(159, 19);
            lblTitleAddBook.TabIndex = 0;
            lblTitleAddBook.Text = "Sales Management";
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
            dgvBooks.Location = new Point(55, 130);
            dgvBooks.Margin = new Padding(4, 3, 4, 3);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.RowHeadersVisible = false;
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.Size = new Size(1116, 220);
            dgvBooks.TabIndex = 2;
            // 
            // pnlSearchBook
            // 
            pnlSearchBook.BackColor = Color.Silver;
            pnlSearchBook.Controls.Add(txtFilterData);
            pnlSearchBook.Controls.Add(btnSearchBook);
            pnlSearchBook.Controls.Add(label1);
            pnlSearchBook.Location = new Point(185, 44);
            pnlSearchBook.Margin = new Padding(4, 3, 4, 3);
            pnlSearchBook.Name = "pnlSearchBook";
            pnlSearchBook.Size = new Size(843, 62);
            pnlSearchBook.TabIndex = 7;
            // 
            // txtFilterData
            // 
            txtFilterData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtFilterData.BackColor = Color.White;
            txtFilterData.BorderStyle = BorderStyle.None;
            txtFilterData.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFilterData.Location = new Point(142, 21);
            txtFilterData.Margin = new Padding(4, 3, 4, 3);
            txtFilterData.MaxLength = 50;
            txtFilterData.Name = "txtFilterData";
            txtFilterData.Size = new Size(620, 24);
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
            btnSearchBook.Location = new Point(783, 14);
            btnSearchBook.Margin = new Padding(4, 3, 4, 3);
            btnSearchBook.Name = "btnSearchBook";
            btnSearchBook.Size = new Size(55, 40);
            btnSearchBook.TabIndex = 1;
            btnSearchBook.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSearchBook.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(46, 21);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 19);
            label1.TabIndex = 4;
            label1.Text = "Search";
            // 
            // FmOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1225, 692);
            Controls.Add(pnlButtosBooks);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FmOrders";
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