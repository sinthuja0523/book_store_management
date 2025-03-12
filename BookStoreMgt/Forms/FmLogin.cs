using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookStoreMgt
{
    public partial class FmLogin : Form
    {
        public FmLogin()
        {
            InitializeComponent();
            // Test commit
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-DV35AK6;Initial Catalog=Bank_Customer;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            conn.Open();
            string query = "SELECT role FROM users WHERE user_name=@Username AND password=@Password";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);
            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                string role = result.ToString();
                MessageBox.Show($"Login Successful! Role: {role}", "Success");

                // Open the main dashboard
                //Dashboard mainForm = new Dashboard();
                this.Hide();
                //mainForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUsername.Text == "username")
            {
                txtUsername.Clear();
            }

        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text == "password")
            {
                txtPassword.Clear();
                txtPassword.PasswordChar = '*';
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.PasswordChar = '*';
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
