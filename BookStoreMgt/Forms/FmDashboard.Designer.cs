namespace BookStoreMgt.Forms
{
	partial class FmDashboard
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmDashboard));
            pnlVerticalMenu = new Panel();
            btnOrder = new Button();
            panel3 = new Panel();
            btnCustomers = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            button1 = new Button();
            btnNickUser = new Button();
            pbShutDownDash = new PictureBox();
            pnlBtnAbout = new Panel();
            pnlBtnProductos = new Panel();
            btnAbout = new Button();
            btnProductos = new Button();
            btnSale = new Button();
            pbLogoDash = new PictureBox();
            pnlBtnSale = new Panel();
            pnlTop = new Panel();
            lblTitleDashboard = new Label();
            pbMinimizeDash = new PictureBox();
            pbDropDownDash = new PictureBox();
            pbMaximizeWindowDash = new PictureBox();
            pbCloseWindowDash = new PictureBox();
            pbMenuDash = new PictureBox();
            pnlContainers = new Panel();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            btn_dashboard = new Button();
            panel4 = new Panel();
            pnlVerticalMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbShutDownDash).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogoDash).BeginInit();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMinimizeDash).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDropDownDash).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMaximizeWindowDash).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCloseWindowDash).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMenuDash).BeginInit();
            SuspendLayout();
            // 
            // pnlVerticalMenu
            // 
            pnlVerticalMenu.BackColor = Color.MidnightBlue;
            pnlVerticalMenu.Controls.Add(btn_dashboard);
            pnlVerticalMenu.Controls.Add(panel4);
            pnlVerticalMenu.Controls.Add(btnOrder);
            pnlVerticalMenu.Controls.Add(panel3);
            pnlVerticalMenu.Controls.Add(btnCustomers);
            pnlVerticalMenu.Controls.Add(panel2);
            pnlVerticalMenu.Controls.Add(panel1);
            pnlVerticalMenu.Controls.Add(button1);
            pnlVerticalMenu.Controls.Add(btnNickUser);
            pnlVerticalMenu.Controls.Add(pbShutDownDash);
            pnlVerticalMenu.Controls.Add(pnlBtnAbout);
            pnlVerticalMenu.Controls.Add(pnlBtnProductos);
            pnlVerticalMenu.Controls.Add(btnAbout);
            pnlVerticalMenu.Controls.Add(btnProductos);
            pnlVerticalMenu.Controls.Add(btnSale);
            pnlVerticalMenu.Controls.Add(pbLogoDash);
            pnlVerticalMenu.Controls.Add(pnlBtnSale);
            pnlVerticalMenu.Dock = DockStyle.Left;
            pnlVerticalMenu.Location = new Point(0, 0);
            pnlVerticalMenu.Margin = new Padding(5, 4, 5, 4);
            pnlVerticalMenu.Name = "pnlVerticalMenu";
            pnlVerticalMenu.Size = new Size(282, 1000);
            pnlVerticalMenu.TabIndex = 0;
            // 
            // btnOrder
            // 
            btnOrder.Cursor = Cursors.Hand;
            btnOrder.FlatAppearance.BorderSize = 0;
            btnOrder.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnOrder.FlatStyle = FlatStyle.Flat;
            btnOrder.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOrder.ForeColor = Color.White;
            btnOrder.Image = (Image)resources.GetObject("btnOrder.Image");
            btnOrder.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrder.Location = new Point(5, 637);
            btnOrder.Margin = new Padding(5, 4, 5, 4);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(274, 65);
            btnOrder.TabIndex = 13;
            btnOrder.Text = "Orders";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(0, 349);
            panel3.Margin = new Padding(5, 4, 5, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(7, 65);
            panel3.TabIndex = 6;
            // 
            // btnCustomers
            // 
            btnCustomers.Cursor = Cursors.Hand;
            btnCustomers.FlatAppearance.BorderSize = 0;
            btnCustomers.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnCustomers.FlatStyle = FlatStyle.Flat;
            btnCustomers.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCustomers.ForeColor = Color.White;
            btnCustomers.Image = (Image)resources.GetObject("btnCustomers.Image");
            btnCustomers.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomers.Location = new Point(5, 541);
            btnCustomers.Margin = new Padding(5, 4, 5, 4);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(274, 65);
            btnCustomers.TabIndex = 12;
            btnCustomers.Text = "Customers";
            btnCustomers.UseVisualStyleBackColor = true;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(0, 637);
            panel2.Margin = new Padding(5, 4, 5, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(7, 65);
            panel2.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(0, 733);
            panel1.Margin = new Padding(5, 4, 5, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(7, 65);
            panel1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(8, 733);
            button1.Margin = new Padding(5, 4, 5, 4);
            button1.Name = "button1";
            button1.Size = new Size(274, 65);
            button1.TabIndex = 9;
            button1.Text = "Reports";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnNickUser
            // 
            btnNickUser.FlatAppearance.BorderSize = 0;
            btnNickUser.FlatStyle = FlatStyle.Flat;
            btnNickUser.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNickUser.ForeColor = Color.White;
            btnNickUser.Image = (Image)resources.GetObject("btnNickUser.Image");
            btnNickUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnNickUser.Location = new Point(5, 856);
            btnNickUser.Margin = new Padding(5, 4, 5, 4);
            btnNickUser.Name = "btnNickUser";
            btnNickUser.Size = new Size(327, 61);
            btnNickUser.TabIndex = 8;
            btnNickUser.UseVisualStyleBackColor = true;
            // 
            // pbShutDownDash
            // 
            pbShutDownDash.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pbShutDownDash.Cursor = Cursors.Hand;
            pbShutDownDash.Image = (Image)resources.GetObject("pbShutDownDash.Image");
            pbShutDownDash.Location = new Point(8, 943);
            pbShutDownDash.Margin = new Padding(5, 4, 5, 4);
            pbShutDownDash.Name = "pbShutDownDash";
            pbShutDownDash.Size = new Size(40, 47);
            pbShutDownDash.SizeMode = PictureBoxSizeMode.Zoom;
            pbShutDownDash.TabIndex = 7;
            pbShutDownDash.TabStop = false;
            pbShutDownDash.Click += pbShutDownDash_Click;
            // 
            // pnlBtnAbout
            // 
            pnlBtnAbout.BackColor = Color.White;
            pnlBtnAbout.Location = new Point(0, 541);
            pnlBtnAbout.Margin = new Padding(5, 4, 5, 4);
            pnlBtnAbout.Name = "pnlBtnAbout";
            pnlBtnAbout.Size = new Size(7, 65);
            pnlBtnAbout.TabIndex = 6;
            // 
            // pnlBtnProductos
            // 
            pnlBtnProductos.BackColor = Color.White;
            pnlBtnProductos.Location = new Point(0, 445);
            pnlBtnProductos.Margin = new Padding(5, 4, 5, 4);
            pnlBtnProductos.Name = "pnlBtnProductos";
            pnlBtnProductos.Size = new Size(7, 65);
            pnlBtnProductos.TabIndex = 5;
            // 
            // btnAbout
            // 
            btnAbout.Cursor = Cursors.Hand;
            btnAbout.FlatAppearance.BorderSize = 0;
            btnAbout.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnAbout.FlatStyle = FlatStyle.Flat;
            btnAbout.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAbout.ForeColor = Color.White;
            btnAbout.Image = (Image)resources.GetObject("btnAbout.Image");
            btnAbout.ImageAlign = ContentAlignment.MiddleLeft;
            btnAbout.Location = new Point(8, 445);
            btnAbout.Margin = new Padding(5, 4, 5, 4);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(274, 65);
            btnAbout.TabIndex = 3;
            btnAbout.Text = "Suppliers";
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += btnAbout_Click;
            // 
            // btnProductos
            // 
            btnProductos.Cursor = Cursors.Hand;
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProductos.ForeColor = Color.White;
            btnProductos.Image = (Image)resources.GetObject("btnProductos.Image");
            btnProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductos.Location = new Point(8, 349);
            btnProductos.Margin = new Padding(5, 4, 5, 4);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(274, 65);
            btnProductos.TabIndex = 2;
            btnProductos.Text = "Sales";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnSale
            // 
            btnSale.Cursor = Cursors.Hand;
            btnSale.FlatAppearance.BorderSize = 0;
            btnSale.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnSale.FlatStyle = FlatStyle.Flat;
            btnSale.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSale.ForeColor = Color.White;
            btnSale.Image = (Image)resources.GetObject("btnSale.Image");
            btnSale.ImageAlign = ContentAlignment.MiddleLeft;
            btnSale.Location = new Point(8, 253);
            btnSale.Margin = new Padding(5, 4, 5, 4);
            btnSale.Name = "btnSale";
            btnSale.Size = new Size(274, 65);
            btnSale.TabIndex = 1;
            btnSale.Text = "Books";
            btnSale.UseVisualStyleBackColor = true;
            btnSale.Click += btnSale_Click;
            // 
            // pbLogoDash
            // 
            pbLogoDash.Cursor = Cursors.Hand;
            pbLogoDash.Image = (Image)resources.GetObject("pbLogoDash.Image");
            pbLogoDash.Location = new Point(29, 16);
            pbLogoDash.Margin = new Padding(5, 4, 5, 4);
            pbLogoDash.Name = "pbLogoDash";
            pbLogoDash.Size = new Size(207, 93);
            pbLogoDash.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogoDash.TabIndex = 0;
            pbLogoDash.TabStop = false;
            pbLogoDash.Click += pbLogoDash_Click;
            // 
            // pnlBtnSale
            // 
            pnlBtnSale.BackColor = Color.White;
            pnlBtnSale.Location = new Point(0, 253);
            pnlBtnSale.Margin = new Padding(5, 4, 5, 4);
            pnlBtnSale.Name = "pnlBtnSale";
            pnlBtnSale.Size = new Size(7, 65);
            pnlBtnSale.TabIndex = 4;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.WhiteSmoke;
            pnlTop.Controls.Add(lblTitleDashboard);
            pnlTop.Controls.Add(pbMinimizeDash);
            pnlTop.Controls.Add(pbDropDownDash);
            pnlTop.Controls.Add(pbMaximizeWindowDash);
            pnlTop.Controls.Add(pbCloseWindowDash);
            pnlTop.Controls.Add(pbMenuDash);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(282, 0);
            pnlTop.Margin = new Padding(5, 4, 5, 4);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1512, 77);
            pnlTop.TabIndex = 1;
            pnlTop.MouseDown += pnlTop_MouseDown;
            // 
            // lblTitleDashboard
            // 
            lblTitleDashboard.AutoSize = true;
            lblTitleDashboard.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleDashboard.Location = new Point(663, 21);
            lblTitleDashboard.Margin = new Padding(5, 0, 5, 0);
            lblTitleDashboard.Name = "lblTitleDashboard";
            lblTitleDashboard.Size = new Size(72, 37);
            lblTitleDashboard.TabIndex = 5;
            lblTitleDashboard.Text = "Title";
            // 
            // pbMinimizeDash
            // 
            pbMinimizeDash.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbMinimizeDash.Cursor = Cursors.Hand;
            pbMinimizeDash.Image = (Image)resources.GetObject("pbMinimizeDash.Image");
            pbMinimizeDash.Location = new Point(1390, 8);
            pbMinimizeDash.Margin = new Padding(5, 4, 5, 4);
            pbMinimizeDash.Name = "pbMinimizeDash";
            pbMinimizeDash.Size = new Size(33, 39);
            pbMinimizeDash.SizeMode = PictureBoxSizeMode.Zoom;
            pbMinimizeDash.TabIndex = 4;
            pbMinimizeDash.TabStop = false;
            pbMinimizeDash.Click += pbMinimizeDash_Click;
            // 
            // pbDropDownDash
            // 
            pbDropDownDash.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbDropDownDash.Cursor = Cursors.Hand;
            pbDropDownDash.Image = (Image)resources.GetObject("pbDropDownDash.Image");
            pbDropDownDash.Location = new Point(1431, 8);
            pbDropDownDash.Margin = new Padding(5, 4, 5, 4);
            pbDropDownDash.Name = "pbDropDownDash";
            pbDropDownDash.Size = new Size(33, 39);
            pbDropDownDash.SizeMode = PictureBoxSizeMode.Zoom;
            pbDropDownDash.TabIndex = 3;
            pbDropDownDash.TabStop = false;
            pbDropDownDash.Visible = false;
            pbDropDownDash.Click += pbDropDownDash_Click;
            // 
            // pbMaximizeWindowDash
            // 
            pbMaximizeWindowDash.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbMaximizeWindowDash.Cursor = Cursors.Hand;
            pbMaximizeWindowDash.Image = (Image)resources.GetObject("pbMaximizeWindowDash.Image");
            pbMaximizeWindowDash.Location = new Point(1431, 8);
            pbMaximizeWindowDash.Margin = new Padding(5, 4, 5, 4);
            pbMaximizeWindowDash.Name = "pbMaximizeWindowDash";
            pbMaximizeWindowDash.Size = new Size(33, 39);
            pbMaximizeWindowDash.SizeMode = PictureBoxSizeMode.Zoom;
            pbMaximizeWindowDash.TabIndex = 2;
            pbMaximizeWindowDash.TabStop = false;
            pbMaximizeWindowDash.Click += pbMaximizeWindowDash_Click;
            // 
            // pbCloseWindowDash
            // 
            pbCloseWindowDash.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbCloseWindowDash.Cursor = Cursors.Hand;
            pbCloseWindowDash.Image = (Image)resources.GetObject("pbCloseWindowDash.Image");
            pbCloseWindowDash.Location = new Point(1472, 8);
            pbCloseWindowDash.Margin = new Padding(5, 4, 5, 4);
            pbCloseWindowDash.Name = "pbCloseWindowDash";
            pbCloseWindowDash.Size = new Size(33, 39);
            pbCloseWindowDash.SizeMode = PictureBoxSizeMode.Zoom;
            pbCloseWindowDash.TabIndex = 1;
            pbCloseWindowDash.TabStop = false;
            pbCloseWindowDash.Click += pbCloseWindowDash_Click;
            // 
            // pbMenuDash
            // 
            pbMenuDash.Cursor = Cursors.Hand;
            pbMenuDash.Image = (Image)resources.GetObject("pbMenuDash.Image");
            pbMenuDash.Location = new Point(23, 11);
            pbMenuDash.Margin = new Padding(5, 4, 5, 4);
            pbMenuDash.Name = "pbMenuDash";
            pbMenuDash.Size = new Size(38, 48);
            pbMenuDash.SizeMode = PictureBoxSizeMode.Zoom;
            pbMenuDash.TabIndex = 0;
            pbMenuDash.TabStop = false;
            pbMenuDash.Click += pbMenuDash_Click;
            // 
            // pnlContainers
            // 
            pnlContainers.BackColor = Color.Gainsboro;
            pnlContainers.Dock = DockStyle.Fill;
            pnlContainers.Location = new Point(282, 77);
            pnlContainers.Margin = new Padding(5, 4, 5, 4);
            pnlContainers.Name = "pnlContainers";
            pnlContainers.Size = new Size(1512, 923);
            pnlContainers.TabIndex = 2;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // btn_dashboard
            // 
            btn_dashboard.Cursor = Cursors.Hand;
            btn_dashboard.FlatAppearance.BorderSize = 0;
            btn_dashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btn_dashboard.FlatStyle = FlatStyle.Flat;
            btn_dashboard.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_dashboard.ForeColor = Color.White;
            btn_dashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btn_dashboard.Location = new Point(8, 157);
            btn_dashboard.Margin = new Padding(5, 4, 5, 4);
            btn_dashboard.Name = "btn_dashboard";
            btn_dashboard.Size = new Size(274, 65);
            btn_dashboard.TabIndex = 14;
            btn_dashboard.Text = "Dashboard";
            btn_dashboard.UseVisualStyleBackColor = true;
            btn_dashboard.Click += button2_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(0, 157);
            panel4.Margin = new Padding(5, 4, 5, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(7, 65);
            panel4.TabIndex = 15;
            // 
            // FmDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1794, 1000);
            Controls.Add(pnlContainers);
            Controls.Add(pnlTop);
            Controls.Add(pnlVerticalMenu);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "FmDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FmDashboard";
            Load += FmDashboard_Load;
            pnlVerticalMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbShutDownDash).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogoDash).EndInit();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbMinimizeDash).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDropDownDash).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMaximizeWindowDash).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCloseWindowDash).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMenuDash).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlVerticalMenu;
		private System.Windows.Forms.Panel pnlTop;
		private System.Windows.Forms.PictureBox pbMenuDash;
		private System.Windows.Forms.Panel pnlContainers;
        private System.Windows.Forms.PictureBox pbLogoDash;
        private System.Windows.Forms.PictureBox pbMinimizeDash;
        private System.Windows.Forms.PictureBox pbDropDownDash;
        private System.Windows.Forms.PictureBox pbMaximizeWindowDash;
        private System.Windows.Forms.PictureBox pbCloseWindowDash;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.PictureBox pbShutDownDash;
        private System.Windows.Forms.Panel pnlBtnAbout;
        private System.Windows.Forms.Panel pnlBtnProductos;
        private System.Windows.Forms.Button btnNickUser;
        private System.Windows.Forms.Label lblTitleDashboard;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Button button1;
        private Panel panel1;
        private Panel pnlBtnSale;
        private Panel panel2;
        private Button btnOrders;
        private Button btnCustomers;
        // private Button btnOrders;
        private Panel panel3;
        private Button btnOrder;
        private Button btn_dashboard;
        private Panel panel4;
    }
}
