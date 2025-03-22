using BookStoreMgt.Database_Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;

namespace BookStoreMgt.Forms
{
    public partial class FmSale : Form
    {
        SaleControl sControl = new SaleControl();
        private string priceDefalt;
        SaleProd sp = new SaleProd();
        public FmSale()
        {
            InitializeComponent();
            pnlCalcDiscount.Visible = false;
            toggleCustomerDetailsPanel(false, true, false);
        }

        private void btnSearchBookSale_Click(object sender, EventArgs e)
        {
            if (sControl.showSearchSale(mtxtSearchBookSale.Text).Rows.Count <= 0)
            {
                MessageBox.Show("There are no book with this ISBN!");
            }
            else
            {
                pnlDgvSearchPro.Visible = true;
                dgvSearchProd.DataSource = sControl.showSearchSale(mtxtSearchBookSale.Text);

                if (dgvSearchProd.SelectedRows.Count > 0)
                {
                    txtIdProd.Text = dgvSearchProd.CurrentRow.Cells["book_id"].Value.ToString();
                    txtIsbnProd.Text = dgvSearchProd.CurrentRow.Cells["isbn"].Value.ToString();
                    txtNameProd.Text = dgvSearchProd.CurrentRow.Cells["title"].Value.ToString();
                    txtAmountProd.Text = "1";
                    priceDefalt = dgvSearchProd.CurrentRow.Cells["price"].Value.ToString();
                    txtPriceProd.Text = priceDefalt;
                }
            }
        }

        private void txtAmountProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 09)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtPriceProd_KeyPress(object sender, KeyPressEventArgs e)
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

        private string calculo(string amount, string preco)
        {
            string rpl;
            if (preco.Contains(","))
            {
                preco.Replace(",", ".");
            }
            rpl = preco;
            decimal a = Convert.ToDecimal(amount);
            decimal b = Convert.ToDecimal(rpl);
            decimal result = a * b;
            string answer = result.ToString();
            if (answer.Contains("."))
            {
                answer.Replace(".", ",");
            }

            return answer;
        }

        private void txtAmountProd_TextChanged(object sender, EventArgs e)
        {


            if ((!txtAmountProd.Text.Equals("1")) && txtAmountProd.Text.Length > 0)
            {
                txtPriceProd.Text = calculo(txtAmountProd.Text, txtPriceProd.Text);
            }
            if (txtAmountProd.Text.Equals("1") || txtAmountProd.Text.Equals(""))
            {
                txtPriceProd.Text = priceDefalt;
            }

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            dgvShoppingCart.Rows.Add(txtIdProd.Text, txtIsbnProd.Text, txtNameProd.Text, txtAmountProd.Text, txtPriceProd.Text);
            sp.calcPriceTotal(Convert.ToDecimal(txtPriceProd.Text));
            txtPriceTotalSale.Text = Convert.ToString(sp.priceTotal_prod);
            dgvSearchProd.DataSource = null;
            mtxtSearchBookSale.Clear();
            txtIdProd.Clear();
            txtIsbnProd.Clear();
            txtNameProd.Clear();
            txtAmountProd.Clear();
            txtPriceProd.Clear();

        }

        private void btnCancelAddCart_Click(object sender, EventArgs e)
        {
            dgvSearchProd.DataSource = null;
            mtxtSearchBookSale.Clear();
            txtIdProd.Clear();
            txtIsbnProd.Clear();
            txtNameProd.Clear();
            txtAmountProd.Clear();
            txtPriceProd.Clear();
        }

        private void cbApplyDiscount_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void txtDiscountValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 09)
            {
                e.Handled = true;
            }
        }

        private void txtDiscountValue_TextChanged(object sender, EventArgs e)
        {
            if (txtDiscountValue.Text.Equals(""))
            {
                btnApplyDiscount.Enabled = false;
            }
            else
                btnApplyDiscount.Enabled = true;
        }



        private void btnApplyDiscount_Click(object sender, EventArgs e)
        {
            sp.priceFinal_prod = (sp.priceTotal_prod - sp.calcDiscountValue(Convert.ToDecimal(txtDiscountValue.Text), sp.priceTotal_prod));
            txtPriceTotalSale.Text = sp.priceFinal_prod.ToString();
            pnlPartSeachProd.Enabled = false;
        }

        private void cbApplyDiscount_Click(object sender, EventArgs e)
        {
            if (dgvShoppingCart.Rows.Count != 0)
            {
                if (cbApplyDiscount.Checked)
                {
                    pnlCalcDiscount.Visible = true;
                }
                else
                {
                    pnlCalcDiscount.Visible = false;
                }
            }

        }

        // Finish Button
        private void btnFinishShop_Click(object sender, EventArgs e)
        {
            try
            {
                List<(int bookId, int quantity, decimal price)> books = new List<(int, int, decimal)>();

                foreach (DataGridViewRow row in dgvShoppingCart.Rows)
                {
                    if (row.Cells[0].Value != null) 
                    {
                        int bookId = Convert.ToInt32(row.Cells[0].Value); 
                        int quantity = Convert.ToInt32(row.Cells[3].Value); 
                        decimal price = Convert.ToDecimal(row.Cells[4].Value); 

                        books.Add((bookId, quantity, price));
                    }
                }
                List<(string? name, string? email, string? phone)> customer_details = new List<(string? name, string? email, string? phone)>();

                if (pnlCustomerDetails.Visible == true)
                {
                    if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
                    {
                        MessageBox.Show("Customer name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCustomerName.Focus();
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(txtAddress.Text))
                    {
                        MessageBox.Show("Address is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtAddress.Focus();
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(txtTPNo.Text) || !txtTPNo.Text.All(char.IsDigit) || txtTPNo.Text.Length < 10)
                    {
                        MessageBox.Show("Please enter a valid phone number with at least 10 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtTPNo.Focus();
                        return;
                    }

                    if (!int.TryParse(txtAge.Text, out int age) || age <= 0)
                    {
                        MessageBox.Show("Please enter a valid age greater than 0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtAge.Focus();
                        return;
                    }

                    customer_details.Add((txtCustomerName.Text, txtTPNo.Text, txtAddress.Text));
                    proceedSale(books, customer_details);
                }
                else
                {
                    proceedSale(books, customer_details);
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

        private void proceedSale(List<(int bookId, int quantity, decimal price)> books, List<(string? name, string? email, string? phone)>? customer_details) {
            string result = sControl.insertNewSale(books, customer_details);
            if (result.Equals("sucess"))
            {
                if (pnlPartSeachProd.Enabled != true)
                    pnlPartSeachProd.Enabled = true;
                dgvShoppingCart.DataSource = null;
                dgvShoppingCart.Rows.Clear();
                cbApplyDiscount.Checked = false;
                pnlCalcDiscount.Visible = false;
                txtPriceTotalSale.Text = "";
                sp.priceTotal_prod = 0;
                sp.priceFinal_prod = sp.priceTotal_prod;
                MessageBox.Show("Book sold successfully!");
                clearCustomerDetailsInputs();
            }
            else
            {
                MessageBox.Show("Error: its not possible add a book!");
            }
        }

        private void clearCustomerDetailsInputs() {
            txtCustomerName.Clear();
            txtTPNo.Clear();
            txtAddress.Clear();
            txtAge.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pnlPartSeachProd.Enabled != true)
                pnlPartSeachProd.Enabled = true;
            dgvShoppingCart.DataSource = null;
            cbApplyDiscount.Checked = false;
            pnlCalcDiscount.Visible = false;
            txtPriceTotalSale.Text = "";
            sp.priceTotal_prod = 0;
            sp.priceFinal_prod = sp.priceTotal_prod;
        }

        private void btnAddCustomerDetails_Click(object sender, EventArgs e)
        {
            btnAddCustomerDetails.Visible = false;
            toggleCustomerDetailsPanel(true, false, true);
        }

        private void toggleCustomerDetailsPanel(bool value, bool value2, bool value3)
        {
            pnlCustomerDetails.Visible = value;
            btnAddCustomerDetails.Visible = value2;
            btnCloseCustomerDetails.Visible = value3;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            toggleCustomerDetailsPanel(false, true, false);
        }
    }
}
