namespace BookStoreMgt
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
            panel2 = new Panel();
            button2 = new Button();
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
            pnlVerticalMenu.Controls.Add(panel2);
            pnlVerticalMenu.Controls.Add(button2);
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
            pnlVerticalMenu.Margin = new Padding(4, 3, 4, 3);
            pnlVerticalMenu.Name = "pnlVerticalMenu";
            pnlVerticalMenu.Size = new Size(247, 750);
            pnlVerticalMenu.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(0, 541);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(6, 85);
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
            button1.Location = new Point(7, 541);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(240, 85);
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
            btnNickUser.Location = new Point(4, 642);
            btnNickUser.Margin = new Padding(4, 3, 4, 3);
            btnNickUser.Name = "btnNickUser";
            btnNickUser.Size = new Size(286, 46);
            btnNickUser.TabIndex = 8;
            btnNickUser.UseVisualStyleBackColor = true;
            // 
            // pbShutDownDash
            // 
            pbShutDownDash.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pbShutDownDash.Cursor = Cursors.Hand;
            pbShutDownDash.Image = (Image)resources.GetObject("pbShutDownDash.Image");
            pbShutDownDash.Location = new Point(7, 707);
            pbShutDownDash.Margin = new Padding(4, 3, 4, 3);
            pbShutDownDash.Name = "pbShutDownDash";
            pbShutDownDash.Size = new Size(35, 35);
            pbShutDownDash.SizeMode = PictureBoxSizeMode.Zoom;
            pbShutDownDash.TabIndex = 7;
            pbShutDownDash.TabStop = false;
            pbShutDownDash.Click += pbShutDownDash_Click;
            // 
            // pnlBtnAbout
            // 
            pnlBtnAbout.BackColor = Color.White;
            pnlBtnAbout.Location = new Point(0, 340);
            pnlBtnAbout.Margin = new Padding(4, 3, 4, 3);
            pnlBtnAbout.Name = "pnlBtnAbout";
            pnlBtnAbout.Size = new Size(6, 85);
            pnlBtnAbout.TabIndex = 6;
            // 
            // pnlBtnProductos
            // 
            pnlBtnProductos.BackColor = Color.White;
            pnlBtnProductos.Location = new Point(0, 236);
            pnlBtnProductos.Margin = new Padding(4, 3, 4, 3);
            pnlBtnProductos.Name = "pnlBtnProductos";
            pnlBtnProductos.Size = new Size(6, 85);
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
            btnAbout.Location = new Point(7, 340);
            btnAbout.Margin = new Padding(4, 3, 4, 3);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(240, 85);
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
            btnProductos.Location = new Point(5, 236);
            btnProductos.Margin = new Padding(4, 3, 4, 3);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(240, 85);
            btnProductos.TabIndex = 2;
            btnProductos.Text = "Customers";
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
            btnSale.Location = new Point(7, 132);
            btnSale.Margin = new Padding(4, 3, 4, 3);
            btnSale.Name = "btnSale";
            btnSale.Size = new Size(240, 85);
            btnSale.TabIndex = 1;
            btnSale.Text = "Books";
            btnSale.UseVisualStyleBackColor = true;
            btnSale.Click += btnSale_Click;
            // 
            // pbLogoDash
            // 
            pbLogoDash.Cursor = Cursors.Hand;
            pbLogoDash.Image = (Image)resources.GetObject("pbLogoDash.Image");
            pbLogoDash.Location = new Point(25, 12);
            pbLogoDash.Margin = new Padding(4, 3, 4, 3);
            pbLogoDash.Name = "pbLogoDash";
            pbLogoDash.Size = new Size(181, 70);
            pbLogoDash.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogoDash.TabIndex = 0;
            pbLogoDash.TabStop = false;
            pbLogoDash.Click += pbLogoDash_Click;
            // 
            // pnlBtnSale
            // 
            pnlBtnSale.BackColor = Color.White;
            pnlBtnSale.Location = new Point(0, 132);
            pnlBtnSale.Margin = new Padding(4, 3, 4, 3);
            pnlBtnSale.Name = "pnlBtnSale";
            pnlBtnSale.Size = new Size(6, 85);
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
            pnlTop.Location = new Point(247, 0);
            pnlTop.Margin = new Padding(4, 3, 4, 3);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1033, 58);
            pnlTop.TabIndex = 1;
            pnlTop.MouseDown += pnlTop_MouseDown;
            // 
            // lblTitleDashboard
            // 
            lblTitleDashboard.AutoSize = true;
            lblTitleDashboard.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleDashboard.Location = new Point(580, 16);
            lblTitleDashboard.Margin = new Padding(4, 0, 4, 0);
            lblTitleDashboard.Name = "lblTitleDashboard";
            lblTitleDashboard.Size = new Size(56, 28);
            lblTitleDashboard.TabIndex = 5;
            lblTitleDashboard.Text = "Title";
            // 
            // pbMinimizeDash
            // 
            pbMinimizeDash.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbMinimizeDash.Cursor = Cursors.Hand;
            pbMinimizeDash.Image = (Image)resources.GetObject("pbMinimizeDash.Image");
            pbMinimizeDash.Location = new Point(926, 6);
            pbMinimizeDash.Margin = new Padding(4, 3, 4, 3);
            pbMinimizeDash.Name = "pbMinimizeDash";
            pbMinimizeDash.Size = new Size(29, 29);
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
            pbDropDownDash.Location = new Point(962, 6);
            pbDropDownDash.Margin = new Padding(4, 3, 4, 3);
            pbDropDownDash.Name = "pbDropDownDash";
            pbDropDownDash.Size = new Size(29, 29);
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
            pbMaximizeWindowDash.Location = new Point(962, 6);
            pbMaximizeWindowDash.Margin = new Padding(4, 3, 4, 3);
            pbMaximizeWindowDash.Name = "pbMaximizeWindowDash";
            pbMaximizeWindowDash.Size = new Size(29, 29);
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
            pbCloseWindowDash.Location = new Point(998, 6);
            pbCloseWindowDash.Margin = new Padding(4, 3, 4, 3);
            pbCloseWindowDash.Name = "pbCloseWindowDash";
            pbCloseWindowDash.Size = new Size(29, 29);
            pbCloseWindowDash.SizeMode = PictureBoxSizeMode.Zoom;
            pbCloseWindowDash.TabIndex = 1;
            pbCloseWindowDash.TabStop = false;
            pbCloseWindowDash.Click += pbCloseWindowDash_Click;
            // 
            // pbMenuDash
            // 
            pbMenuDash.Cursor = Cursors.Hand;
            pbMenuDash.Image = (Image)resources.GetObject("pbMenuDash.Image");
            pbMenuDash.Location = new Point(20, 8);
            pbMenuDash.Margin = new Padding(4, 3, 4, 3);
            pbMenuDash.Name = "pbMenuDash";
            pbMenuDash.Size = new Size(33, 36);
            pbMenuDash.SizeMode = PictureBoxSizeMode.Zoom;
            pbMenuDash.TabIndex = 0;
            pbMenuDash.TabStop = false;
            pbMenuDash.Click += pbMenuDash_Click;
            // 
            // pnlContainers
            // 
            pnlContainers.BackColor = Color.WhiteSmoke;
            pnlContainers.Dock = DockStyle.Fill;
            pnlContainers.Location = new Point(247, 58);
            pnlContainers.Margin = new Padding(4, 3, 4, 3);
            pnlContainers.Name = "pnlContainers";
            pnlContainers.Size = new Size(1033, 692);
            pnlContainers.TabIndex = 2;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(0, 441);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(6, 85);
            panel2.TabIndex = 11;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(7, 441);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(240, 85);
            button2.TabIndex = 10;
            button2.Text = "Orders";
            button2.UseVisualStyleBackColor = true;
            // 
            // FmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 750);
            Controls.Add(pnlContainers);
            Controls.Add(pnlTop);
            Controls.Add(pnlVerticalMenu);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
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
        private Button button2;
    }
}
