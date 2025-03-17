using BookStoreMgt.Database_Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BookStoreMgt.Forms
{
    public partial class FmOrders : Form
    {
        private string titleLabel;
        private string id = null;

        BookControl BookControl = new BookControl();

        CustomerControl customerControl = new CustomerControl();
        public FmOrders()
        {
            InitializeComponent();
            panelAddVisible(true);
            btnSaveData.Visible = false;
        }

        public void setTitleLabel(string s)
        {
            this.titleLabel = s;
        }
        public string getTitleLabel()
        {
            return this.titleLabel;
        }

        public void FmBooks_Load(object sender, EventArgs e)
        {
            showBooksInDataGrid();

        }

        public void showBooksInDataGrid()
        {
            dgvBooks.DataSource = customerControl.showBooks();
        }

        public void disableButtonsBooks()
        {
            btnSearchBook.Enabled = false;
            btnUpdateData.Enabled = false;
        }
        public void enableButtonsBook()
        {
            btnSearchBook.Enabled = true;
            btnUpdateData.Enabled = true;
        }

        public void ValidaEnableButtons()
        {
            this.enableButtonsBook();
        }

        private void openInPanelContainerBook(object form)
        {
            if (this.pnlContainerFmAddOrUpdateBook.Controls.Count > 0)
            {
                this.pnlContainerFmAddOrUpdateBook.Controls.RemoveAt(0);
            }
            Form fh = form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlContainerFmAddOrUpdateBook.Controls.Add(fh);
            this.pnlContainerFmAddOrUpdateBook.Tag = fh;
            fh.Show();
        }

        public void refreshForm()
        {
            this.Refresh();
        }

        private void enableButtonsBooks(bool v)
        {
            if (v)
            {
                btnUpdateData.Enabled = true;
                btnDeleteBook.Enabled = true;
            }
            else
            {
                btnUpdateData.Enabled = false;
                btnDeleteBook.Enabled = false;
            }
        }

        private void txtYearBook_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 09)
            {
                e.Handled = true;
            }
        }

        private void txtAmountBook_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 09)
            {
                e.Handled = true;
            }
        }

        private void txtPriceBook_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txt.Text.Contains(','));
                }
                else
                    e.Handled = true;
            }
        }

        private void btnCancelbook_Click(object sender, EventArgs e)
        {
            clearAddNewTextBox();
            enableButtonsBooks(true);
        }

        private void panelAddVisible(bool v)
        {
            pnlContainerFmAddOrUpdateBook.Visible = v;
        }

        private void clearAddNewTextBox()
        {
            this.txtCustomerName.Clear();
            this.txtCustomerEmail.Clear();
            this.txtCustomerPhone.Clear();
        }

        private void btnSaveBook_Click(object sender, EventArgs e)
        {
            try
            {  
                bool isUpdatingBook = lblTitleAddBook.Text.Equals("Update customer");

                string operationResult = "";
                if (isUpdatingBook)
                {
                    operationResult = customerControl.updateDataControl(id, txtCustomerName.Text, txtCustomerEmail.Text, txtCustomerPhone.Text);
                    MessageBox.Show(operationResult);
                }

                if (operationResult.Equals("sucess"))
                {
                    MessageBox.Show("Update finished successfully!");
                    clearAddNewTextBox();
                    lblTitleAddBook.Text = "Customer Management";
                    showBooksInDataGrid();
                }
                else 
                {
                    MessageBox.Show("Error: Unable to update the book.");
                }
            }
            catch (Exception ex)
            {
                string errorMessage = $"Error: {ex.Message}\n\nStackTrace: {ex.StackTrace}";
                if (ex.InnerException != null)
                {
                    errorMessage += $"\n\nInner Exception: {ex.InnerException.Message}";
                }
                MessageBox.Show(errorMessage, "Exception Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnUpdateData_Click(object sender, EventArgs e)
        {
            try
            {
                btnSaveData.Visible = true;
                if (dgvBooks.SelectedRows.Count > 0)
                {
                    pnlContainerFmAddOrUpdateBook.BackColor = Color.DarkGray;
                    this.setTitleLabel("Update customer");
                    //btnSaveBook.Text = "Update Book";
                    lblTitleAddBook.Text = getTitleLabel();
                    panelAddVisible(true);
                    enableButtonsBooks(false);


                    txtCustomerEmail.Text = dgvBooks.CurrentRow.Cells["email"].Value.ToString();
                    txtCustomerName.Text = dgvBooks.CurrentRow.Cells["name"].Value.ToString();
                    txtCustomerPhone.Text = dgvBooks.CurrentRow.Cells["phone"].Value.ToString();
                    this.id = dgvBooks.CurrentRow.Cells["customer_id"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Please, select a row!");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {

            if (dgvBooks.SelectedRows.Count > 0)
            {
                string isbn = dgvBooks.CurrentRow.Cells["customer_id"].Value.ToString();


                if (MessageBox.Show("Do you really want to delete these books?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string result = customerControl.deleteDataControl(isbn);
                    if (result.Equals("sucess"))
                    {
                        MessageBox.Show("Delete data has been sucessed!");
                        showBooksInDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Delete data it was possible!");
                    }
                }

            }
        }

        private void txtFilterData_TextChanged(object sender, EventArgs e)
        {
            if (!txtFilterData.Text.Equals("Type here the book title"))
            {
                (dgvBooks.DataSource as DataTable).DefaultView.RowFilter =
                string.Format("title LIKE '{0}%' OR title LIKE '% {0}%'", txtFilterData.Text);
            }

        }

        private void txtFilterData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtFilterData.Text.Equals("Type here the book title"))
            {
                txtFilterData.Clear();
            }
        }

        private void txtFilterData_Leave(object sender, EventArgs e)
        {
            if (txtFilterData.Text.Equals(""))
            {
                txtFilterData.Text = "Type here the book title";
            }
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbGenreBook_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {

        }
    }
}
