/*
 * Criado por SharpDevelop.
 * Usuário: Fabiano
 * Data: 10/05/2020
 * Hora: 20:23
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using Bookstore.Database;
/*using Bookstore.Utils;*/
using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace BookStoreMgt.Forms
{
    /// <summary>
    /// Description of FmLogin.
    /// </summary>
    public partial class FmLogin : Form
    {
        crudUsers usr = new crudUsers();
        Thread th;

        public string userLogged = "";
        public FmLogin()
        {
            InitializeComponent();
            txtEmail.Focus();
            txtEmail.Select(0, 0);
        }


        private void initFrame()
        {
            Application.Run(new FmDashboard());
        }
        void PbExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void PbCloseLoginClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void createFileToUser(string txt)
        {
            Stream outUser = null;
            StreamWriter writer = null;
            try
            {
                outUser = File.Open("userLogged.txt", FileMode.Create);
                writer = new StreamWriter(outUser);
                writer.WriteLine(txt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

                if (writer != null)
                    writer.Close();

                if (outUser != null)
                    outUser.Close();
            }


        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals("Enter your username"))
            {
                txtPassword.Clear();
            }

            //txtPassword.PasswordChar = '*';
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text.Equals("Enter your username"))
            {



                //txtEmail.Clear();
            }
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Equals("Enter your username"))
            {
                txtEmail.Clear();
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtEmail.Text.Equals("Enter your username"))
            {
                txtEmail.Clear();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtPassword.Text.Equals("Enter your password"))
            {
                txtPassword.Clear();
            }
            txtPassword.PasswordChar = '*';
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text.Equals(""))
            {
                txtEmail.Text = "Enter your username";
            }
        }



        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(""))
            {
                if (txtPassword.PasswordChar.Equals('*'))
                {
                    txtPassword.PasswordChar = '\0';
                    txtPassword.Text = "Enter your password";
                }
                else
                {
                    txtPassword.Text = "Enter your password";
                }

                //txtPassword.ResetText();

            }
        }

        private void pbEnterLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Equals("") || txtPassword.Text.Equals(""))
            {
                MessageBox.Show("All fields are required !!!");
                txtEmail.Focus();
            }
            else
            {
                usr.checkUsers(txtEmail.Text, txtPassword.Text);
                if (usr.getHas())
                {
                    //userLogged = txtEmail.Text;
                    createFileToUser(txtEmail.Text);
                    this.Close();
                    th = new Thread(initFrame);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                else
                {
                    MessageBox.Show("Username or password incorrect");
                }
            }
        }

        private void pbEnterLogin_MouseHover(object sender, EventArgs e)
        {
            pbEnterLogin.Width = 237;
            pbEnterLogin.Height = 63;
        }

        private void pbEnterLogin_MouseLeave(object sender, EventArgs e)
        {
            pbEnterLogin.Width = 234;
            pbEnterLogin.Height = 60;
        }

        private void pbEnterLogin_MouseDown(object sender, MouseEventArgs e)
        {
            pbEnterLogin.Width = 230;
            pbEnterLogin.Height = 57;
        }

        private void pbEnterLogin_MouseUp(object sender, MouseEventArgs e)
        {
            pbEnterLogin.Width = 234;
            pbEnterLogin.Height = 60;
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtEmail.Text.Equals("") || txtPassword.Text.Equals(""))
                {
                    MessageBox.Show("All fields are required !!!");
                    txtEmail.Focus();
                }
                else
                {
                    usr.checkUsers(txtEmail.Text, txtPassword.Text);
                    if (usr.getHas())
                    {
                        //userLogged = txtEmail.Text;
                        createFileToUser(txtEmail.Text);
                        this.Close();
                        th = new Thread(initFrame);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();
                    }
                    else
                    {
                        MessageBox.Show("Username or password incorrect");
                    }
                }
            }
        }

        private void chkbox_show_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbox_show_pass.Checked)
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
    }
}
