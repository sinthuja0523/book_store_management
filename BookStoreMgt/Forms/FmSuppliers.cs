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
    public partial class FmSuppliers : Form
    {
        private string titleLabel;
        private string id = null;

        SupplierControl supplierControl = new SupplierControl();
        public FmSuppliers()
        {
            InitializeComponent();
            panelAddVisible(true);
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
            dgvBooks.DataSource = supplierControl.showSuppliers();
        }

        public void disableButtonsBooks()
        {
            /*btnSearchBook.Enabled = false;*/
            btnUpdateData.Enabled = false;
        }
        public void enableButtonsBook()
        {
            /* btnSearchBook.Enabled = true;*/
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
            this.txtAddress.Clear();
            this.txtEmail.Clear();
            this.txtName.Clear();
            this.txtTPNo.Clear();
        }

        private void btnSaveBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Please enter a name !");
                    txtName.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtTPNo.Text))
                {
                    MessageBox.Show("Please enter a contact no !");
                    txtTPNo.Focus();
                    return;
                }

                bool isAddingNewBook = lblTitleAddSupplier.Text.Equals("Add new supplier");
                bool isUpdatingBook = lblTitleAddSupplier.Text.Equals("Update supplier");

                if (isAddingNewBook && supplierControl.checkTPNo(Convert.ToInt32(txtTPNo.Text)))
                {
                    MessageBox.Show("This supplier already exists in our database.");
                    txtTPNo.Clear();
                    txtTPNo.Focus();
                    return;
                }

                string operationResult = "";
                if (isAddingNewBook)
                {
                    operationResult = supplierControl.insertSupplierControl(txtName.Text, Convert.ToInt32(txtTPNo.Text), txtEmail.Text, txtAddress.Text);
                }
                else if (isUpdatingBook)
                {
                    operationResult = supplierControl.updateSupplierControl(id, txtName.Text, Convert.ToInt32(txtTPNo.Text), txtEmail.Text, txtAddress.Text);
                }

                if (operationResult.Equals("sucess"))
                {
                    MessageBox.Show(isAddingNewBook ? "Supplier added successfully!" : "Update finished successfully!");
                    clearAddNewTextBox();
                    lblTitleAddSupplier.Text = "Add new supplier";
                    btnSaveBook.Text = "Add supplier";
                    txtTPNo.ReadOnly = !isAddingNewBook;
                    showBooksInDataGrid();
                }
                else if (isAddingNewBook)
                {
                    MessageBox.Show("Error: Unable to add the book.");
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
                if (dgvBooks.SelectedRows.Count > 0)
                {
                    pnlContainerFmAddOrUpdateBook.BackColor = Color.DarkGray;
                    this.setTitleLabel("Update supplier");
                    btnSaveBook.Text = "Update supplier";
                    lblTitleAddSupplier.Text = getTitleLabel();
                    panelAddVisible(true);
                    enableButtonsBooks(false);

                    txtName.Text = dgvBooks.CurrentRow.Cells["name"].Value.ToString();
                    txtTPNo.Text = dgvBooks.CurrentRow.Cells["contact_number"].Value.ToString();
                    txtEmail.Text = dgvBooks.CurrentRow.Cells["email"].Value.ToString();
                    txtAddress.Text = dgvBooks.CurrentRow.Cells["address"].Value.ToString();
                    this.id = dgvBooks.CurrentRow.Cells["supplier_id"].Value.ToString();

                    txtTPNo.ReadOnly = true;

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
                string contact_number = dgvBooks.CurrentRow.Cells["contact_number"].Value.ToString();


                if (MessageBox.Show("Do you really want to delete these books?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string result = supplierControl.deleteSupplierControl(Convert.ToInt32(contact_number));
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
    }
}
