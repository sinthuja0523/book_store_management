namespace BookStoreMgt
{
    partial class Dashboard
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
            d = new Label();
            sidebar = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            sidebar.SuspendLayout();
            SuspendLayout();
            // 
            // d
            // 
            d.AutoSize = true;
            d.Location = new Point(454, 149);
            d.Name = "d";
            d.Size = new Size(64, 15);
            d.TabIndex = 0;
            d.Text = "Dashboard";
            // 
            // sidebar
            // 
            sidebar.Controls.Add(button3);
            sidebar.Controls.Add(button2);
            sidebar.Controls.Add(button1);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(173, 559);
            sidebar.TabIndex = 1;
            // 
            // button3
            // 
            button3.Location = new Point(39, 241);
            button3.Name = "button3";
            button3.Size = new Size(96, 40);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(39, 171);
            button2.Name = "button2";
            button2.Size = new Size(96, 40);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(39, 101);
            button1.Name = "button1";
            button1.Size = new Size(96, 40);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(173, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(703, 34);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(173, 34);
            panel2.Name = "panel2";
            panel2.Size = new Size(703, 525);
            panel2.TabIndex = 3;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 559);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(sidebar);
            Controls.Add(d);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            sidebar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label d;
        private Panel sidebar;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel1;
        private Panel panel2;
    }
}