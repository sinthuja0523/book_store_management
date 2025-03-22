namespace BookStoreMgt.Forms
{
    partial class FmDashboardItems
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
            panel7 = new Panel();
            customers_lbl = new Label();
            lblCustomersCount = new Label();
            panel6 = new Panel();
            suppliers_lbl = new Label();
            lblSuppliersCount = new Label();
            panel5 = new Panel();
            books_lbl = new Label();
            lblBooksCount = new Label();
            panel4 = new Panel();
            label1 = new Label();
            lblSalesCount = new Label();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(customers_lbl);
            panel7.Controls.Add(lblCustomersCount);
            panel7.Location = new Point(251, 476);
            panel7.Name = "panel7";
            panel7.Size = new Size(292, 246);
            panel7.TabIndex = 8;
            // 
            // customers_lbl
            // 
            customers_lbl.AutoSize = true;
            customers_lbl.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold);
            customers_lbl.Location = new Point(27, 127);
            customers_lbl.Name = "customers_lbl";
            customers_lbl.Size = new Size(238, 34);
            customers_lbl.TabIndex = 0;
            customers_lbl.Text = "No of Customers";
            // 
            // lblCustomersCount
            // 
            lblCustomersCount.AutoSize = true;
            lblCustomersCount.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold | FontStyle.Italic);
            lblCustomersCount.Location = new Point(129, 60);
            lblCustomersCount.Name = "lblCustomersCount";
            lblCustomersCount.Size = new Size(54, 62);
            lblCustomersCount.TabIndex = 1;
            lblCustomersCount.Text = "0";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(suppliers_lbl);
            panel6.Controls.Add(lblSuppliersCount);
            panel6.Location = new Point(903, 476);
            panel6.Name = "panel6";
            panel6.Size = new Size(292, 246);
            panel6.TabIndex = 6;
            // 
            // suppliers_lbl
            // 
            suppliers_lbl.AutoSize = true;
            suppliers_lbl.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold);
            suppliers_lbl.Location = new Point(41, 127);
            suppliers_lbl.Name = "suppliers_lbl";
            suppliers_lbl.Size = new Size(217, 34);
            suppliers_lbl.TabIndex = 0;
            suppliers_lbl.Text = "No of Suppliers";
            // 
            // lblSuppliersCount
            // 
            lblSuppliersCount.AutoSize = true;
            lblSuppliersCount.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold | FontStyle.Italic);
            lblSuppliersCount.Location = new Point(129, 60);
            lblSuppliersCount.Name = "lblSuppliersCount";
            lblSuppliersCount.Size = new Size(54, 62);
            lblSuppliersCount.TabIndex = 1;
            lblSuppliersCount.Text = "0";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(books_lbl);
            panel5.Controls.Add(lblBooksCount);
            panel5.Location = new Point(903, 84);
            panel5.Name = "panel5";
            panel5.Size = new Size(292, 246);
            panel5.TabIndex = 7;
            // 
            // books_lbl
            // 
            books_lbl.AutoSize = true;
            books_lbl.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold);
            books_lbl.Location = new Point(65, 127);
            books_lbl.Name = "books_lbl";
            books_lbl.Size = new Size(176, 34);
            books_lbl.TabIndex = 0;
            books_lbl.Text = "No of Books";
            // 
            // lblBooksCount
            // 
            lblBooksCount.AutoSize = true;
            lblBooksCount.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold | FontStyle.Italic);
            lblBooksCount.Location = new Point(129, 60);
            lblBooksCount.Name = "lblBooksCount";
            lblBooksCount.Size = new Size(54, 62);
            lblBooksCount.TabIndex = 1;
            lblBooksCount.Text = "0";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label1);
            panel4.Controls.Add(lblSalesCount);
            panel4.Location = new Point(251, 85);
            panel4.Name = "panel4";
            panel4.Size = new Size(292, 246);
            panel4.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold);
            label1.Location = new Point(104, 129);
            label1.Name = "label1";
            label1.Size = new Size(85, 34);
            label1.TabIndex = 0;
            label1.Text = "Sales";
            // 
            // lblSalesCount
            // 
            lblSalesCount.AutoSize = true;
            lblSalesCount.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold | FontStyle.Italic);
            lblSalesCount.Location = new Point(115, 59);
            lblSalesCount.Name = "lblSalesCount";
            lblSalesCount.Size = new Size(54, 62);
            lblSalesCount.TabIndex = 1;
            lblSalesCount.Text = "0";
            // 
            // FmDashboardItems
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1400, 923);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "FmDashboardItems";
            Text = "FmBooks";
            Load += FmBooks_Load;
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel7;
        private Label customers_lbl;
        private Label lblCustomersCount;
        private Panel panel6;
        private Label suppliers_lbl;
        private Label lblSuppliersCount;
        private Panel panel5;
        private Label books_lbl;
        private Label lblBooksCount;
        private Panel panel4;
        private Label label1;
        private Label lblSalesCount;
    }
}