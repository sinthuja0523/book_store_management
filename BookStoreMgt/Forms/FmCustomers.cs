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
    public partial class FmCustomers : Form
    {
        private string titleLabel;
        private string id = null;

        BookControl BookControl = new BookControl();

        CustomerControl customerControl = new CustomerControl();
        public FmCustomers()
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
            //  this.mtxtISBN.Clear();
            //  this.txtAuthorBook.Clear();
            // this.txteditoraBook.Clear();
            this.txtCustomerPhone.Clear();
            // this.txtYearBook.Clear();
        }

        //private void btnSaveBook_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (cbGenreBook.SelectedIndex < 0)
        //        {
        //            MessageBox.Show("Please, select a book genre!");
        //            cbGenreBook.Focus();
        //            return;
        //        }

        //        bool isAddingNewBook = lblTitleAddBook.Text.Equals("Add a new book");
        //        bool isUpdatingBook = lblTitleAddBook.Text.Equals("Update book");

        //        if (isAddingNewBook && bookControl.checkISBNControl(mtxtISBN.Text))
        //        {
        //            MessageBox.Show("This ISBN already exists in our database.");
        //            mtxtISBN.Clear();
        //            mtxtISBN.Focus();
        //            return;
        //        }

        //        string operationResult = "";
        //        if (isAddingNewBook)
        //        {
        //            operationResult = bookControl.insertBooksControl(mtxtISBN.Text, txtTitleBook.Text, txtAuthorBook.Text, txtYearBook.Text, txteditoraBook.Text, cbGenreBook.SelectedItem.ToString(), txtAmountBook.Text, txtPriceBook.Text);
        //        }
        //        else if (isUpdatingBook)
        //        {
        //            operationResult = bookControl.updateDataControl(id, mtxtISBN.Text, txtTitleBook.Text, txtAuthorBook.Text, txtYearBook.Text, txteditoraBook.Text, cbGenreBook.SelectedItem.ToString(), txtAmountBook.Text, txtPriceBook.Text);
        //        }

        //        if (operationResult.Equals("sucess"))
        //        {
        //            MessageBox.Show(isAddingNewBook ? "Book added successfully!" : "Update finished successfully!");
        //            clearAddNewTextBox();
        //            lblTitleAddBook.Text = "Add a new book";
        //            //btnSaveBook.Text = "Add Book";
        //            mtxtISBN.ReadOnly = !isAddingNewBook;
        //            showBooksInDataGrid();
        //        }
        //        else if (isAddingNewBook)
        //        {
        //            MessageBox.Show("Error: Unable to add the book.");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        string errorMessage = $"Error: {ex.Message}\n\nStackTrace: {ex.StackTrace}";
        //        if (ex.InnerException != null)
        //        {
        //            errorMessage += $"\n\nInner Exception: {ex.InnerException.Message}";
        //        }
        //        MessageBox.Show(errorMessage, "Exception Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //}

        //private void btnUpdateData_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (dgvBooks.SelectedRows.Count > 0)
        //        {
        //            pnlContainerFmAddOrUpdateBook.BackColor = Color.DarkGray;
        //            this.setTitleLabel("Update book");
        //            //btnSaveBook.Text = "Update Book";
        //            lblTitleAddBook.Text = getTitleLabel();
        //            panelAddVisible(true);
        //            enableButtonsBooks(false);


        //            mtxtISBN.Text = dgvBooks.CurrentRow.Cells["isbn"].Value.ToString();
        //            txtTitleBook.Text = dgvBooks.CurrentRow.Cells["title"].Value.ToString();
        //            txtAuthorBook.Text = dgvBooks.CurrentRow.Cells["author"].Value.ToString();
        //            txtYearBook.Text = dgvBooks.CurrentRow.Cells["published_year"].Value.ToString();
        //            txteditoraBook.Text = dgvBooks.CurrentRow.Cells["editor"].Value.ToString();
        //            cbGenreBook.SelectedIndex = cbGenreBook.FindString(dgvBooks.CurrentRow.Cells["genre"].Value.ToString());

        //            txtAmountBook.Text = dgvBooks.CurrentRow.Cells["stock_quantity"].Value.ToString();
        //            txtPriceBook.Text = dgvBooks.CurrentRow.Cells["price"].Value.ToString();
        //            this.id = dgvBooks.CurrentRow.Cells["book_id"].Value.ToString();

        //            mtxtISBN.ReadOnly = true;

        //        }
        //        else
        //        {
        //            MessageBox.Show("Please, select a row!");
        //        }



        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {

            if (dgvBooks.SelectedRows.Count > 0)
            {
                string isbn = dgvBooks.CurrentRow.Cells["isbn"].Value.ToString();


                if (MessageBox.Show("Do you really want to delete these books?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    //string result = bookControl.deleteDataControl(isbn);
                    //if (result.Equals("sucess"))
                    //{
                    //    MessageBox.Show("Delete data has been sucessed!");
                    //    showBooksInDataGrid();
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Delete data it was possible!");
                    //}
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

        private void btnUpdateData_Click(object sender, EventArgs e)
        {

        }
    }
}
