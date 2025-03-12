/*
 * Criado por SharpDevelop.
 * Usuário: Fabiano
 * Data: 10/05/2020
 * Hora: 20:23
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace BookStoreMgt
{
	partial class FmLogin
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pbIconUser;
		private System.Windows.Forms.PictureBox pbEmail;
		private System.Windows.Forms.PictureBox pbPassword;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.CheckBox chkbox_show_pass;
		private System.Windows.Forms.PictureBox pbEnterLogin;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblRegister;
		private System.Windows.Forms.PictureBox pbIconEmail;
		private System.Windows.Forms.PictureBox pbIconPassword;
		private System.Windows.Forms.PictureBox pbCloseLogin;
		
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmLogin));
            pictureBox1 = new PictureBox();
            pbIconUser = new PictureBox();
            pbEmail = new PictureBox();
            pbPassword = new PictureBox();
            label1 = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            chkbox_show_pass = new CheckBox();
            pbEnterLogin = new PictureBox();
            label2 = new Label();
            lblRegister = new Label();
            pbIconEmail = new PictureBox();
            pbIconPassword = new PictureBox();
            pbCloseLogin = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbIconUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEnterLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbIconEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbIconPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCloseLogin).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(467, 458);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pbIconUser
            // 
            pbIconUser.Image = (Image)resources.GetObject("pbIconUser.Image");
            pbIconUser.Location = new Point(470, 14);
            pbIconUser.Margin = new Padding(4, 3, 4, 3);
            pbIconUser.Name = "pbIconUser";
            pbIconUser.Size = new Size(113, 98);
            pbIconUser.SizeMode = PictureBoxSizeMode.Zoom;
            pbIconUser.TabIndex = 1;
            pbIconUser.TabStop = false;
            // 
            // pbEmail
            // 
            pbEmail.Image = (Image)resources.GetObject("pbEmail.Image");
            pbEmail.Location = new Point(352, 155);
            pbEmail.Margin = new Padding(4, 3, 4, 3);
            pbEmail.Name = "pbEmail";
            pbEmail.Size = new Size(348, 52);
            pbEmail.SizeMode = PictureBoxSizeMode.Zoom;
            pbEmail.TabIndex = 2;
            pbEmail.TabStop = false;
            // 
            // pbPassword
            // 
            pbPassword.Image = (Image)resources.GetObject("pbPassword.Image");
            pbPassword.Location = new Point(352, 225);
            pbPassword.Margin = new Padding(4, 3, 4, 3);
            pbPassword.Name = "pbPassword";
            pbPassword.Size = new Size(348, 52);
            pbPassword.SizeMode = PictureBoxSizeMode.Zoom;
            pbPassword.TabIndex = 3;
            pbPassword.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("ArtBrush", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(427, 125);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(200, 27);
            label1.TabIndex = 4;
            label1.Text = "Enter you credentials";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.DarkGray;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.ForeColor = Color.WhiteSmoke;
            txtEmail.Location = new Point(430, 171);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(254, 23);
            txtEmail.TabIndex = 5;
            txtEmail.Text = "Enter your username";
            txtEmail.Click += txtEmail_Click;
            txtEmail.Enter += txtEmail_Enter;
            txtEmail.KeyPress += txtEmail_KeyPress;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.DarkGray;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.ForeColor = Color.WhiteSmoke;
            txtPassword.Location = new Point(430, 241);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.MaxLength = 16;
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(254, 23);
            txtPassword.TabIndex = 6;
            txtPassword.Text = "Enter your password";
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.KeyDown += txtPassword_KeyDown;
            txtPassword.KeyPress += txtPassword_KeyPress;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // chkbox_show_pass
            // 
            chkbox_show_pass.ForeColor = Color.Gray;
            chkbox_show_pass.Location = new Point(465, 284);
            chkbox_show_pass.Margin = new Padding(4, 3, 4, 3);
            chkbox_show_pass.Name = "chkbox_show_pass";
            chkbox_show_pass.Size = new Size(121, 28);
            chkbox_show_pass.TabIndex = 7;
            chkbox_show_pass.Text = "Show password";
            chkbox_show_pass.UseVisualStyleBackColor = true;
            chkbox_show_pass.CheckedChanged += chkbox_show_pass_CheckedChanged;
            // 
            // pbEnterLogin
            // 
            pbEnterLogin.Cursor = Cursors.Hand;
            pbEnterLogin.Image = (Image)resources.GetObject("pbEnterLogin.Image");
            pbEnterLogin.Location = new Point(390, 318);
            pbEnterLogin.Margin = new Padding(4, 3, 4, 3);
            pbEnterLogin.Name = "pbEnterLogin";
            pbEnterLogin.Size = new Size(273, 69);
            pbEnterLogin.SizeMode = PictureBoxSizeMode.Zoom;
            pbEnterLogin.TabIndex = 8;
            pbEnterLogin.TabStop = false;
            pbEnterLogin.Click += pbEnterLogin_Click;
            pbEnterLogin.MouseDown += pbEnterLogin_MouseDown;
            pbEnterLogin.MouseUp += pbEnterLogin_MouseUp;
            // 
            // label2
            // 
            label2.Font = new Font("ArtBrush", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(426, 402);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(94, 27);
            label2.TabIndex = 9;
            label2.Text = "New User?";
            label2.Visible = false;
            // 
            // lblRegister
            // 
            lblRegister.Cursor = Cursors.Hand;
            lblRegister.Font = new Font("ArtBrush", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblRegister.ForeColor = Color.FromArgb(255, 128, 0);
            lblRegister.Location = new Point(528, 402);
            lblRegister.Margin = new Padding(4, 0, 4, 0);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(103, 27);
            lblRegister.TabIndex = 10;
            lblRegister.Text = "Register now";
            lblRegister.Visible = false;
            // 
            // pbIconEmail
            // 
            pbIconEmail.BackColor = Color.DarkGray;
            pbIconEmail.Image = (Image)resources.GetObject("pbIconEmail.Image");
            pbIconEmail.Location = new Point(385, 165);
            pbIconEmail.Margin = new Padding(4, 3, 4, 3);
            pbIconEmail.Name = "pbIconEmail";
            pbIconEmail.Size = new Size(37, 31);
            pbIconEmail.SizeMode = PictureBoxSizeMode.Zoom;
            pbIconEmail.TabIndex = 11;
            pbIconEmail.TabStop = false;
            // 
            // pbIconPassword
            // 
            pbIconPassword.BackColor = Color.DarkGray;
            pbIconPassword.Image = (Image)resources.GetObject("pbIconPassword.Image");
            pbIconPassword.Location = new Point(385, 234);
            pbIconPassword.Margin = new Padding(4, 3, 4, 3);
            pbIconPassword.Name = "pbIconPassword";
            pbIconPassword.Size = new Size(37, 31);
            pbIconPassword.SizeMode = PictureBoxSizeMode.Zoom;
            pbIconPassword.TabIndex = 12;
            pbIconPassword.TabStop = false;
            // 
            // pbCloseLogin
            // 
            pbCloseLogin.Cursor = Cursors.Hand;
            pbCloseLogin.Image = (Image)resources.GetObject("pbCloseLogin.Image");
            pbCloseLogin.Location = new Point(706, 14);
            pbCloseLogin.Margin = new Padding(4, 3, 4, 3);
            pbCloseLogin.Name = "pbCloseLogin";
            pbCloseLogin.Size = new Size(33, 21);
            pbCloseLogin.SizeMode = PictureBoxSizeMode.Zoom;
            pbCloseLogin.TabIndex = 18;
            pbCloseLogin.TabStop = false;
            pbCloseLogin.Click += PbCloseLoginClick;
            // 
            // FmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(752, 455);
            Controls.Add(pbCloseLogin);
            Controls.Add(pbIconPassword);
            Controls.Add(pbIconEmail);
            Controls.Add(lblRegister);
            Controls.Add(label2);
            Controls.Add(pbEnterLogin);
            Controls.Add(chkbox_show_pass);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Controls.Add(pbPassword);
            Controls.Add(pbEmail);
            Controls.Add(pbIconUser);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "FmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbIconUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEnterLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbIconEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbIconPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCloseLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
