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
    public partial class FmDashboardItems : Form
    {
        SaleControl sControl = new SaleControl();
        BookControl bControl = new BookControl();
        SupplierControl supControl = new SupplierControl();
        CustomerControl cControl = new CustomerControl();
        public FmDashboardItems()
        {
            InitializeComponent();
           
        }

        public void FmBooks_Load(object sender, EventArgs e)
        {
            lblSalesCount.Text = sControl.getTotalSalesCount().ToString();
            lblCustomersCount.Text = cControl.getCustomersCount().ToString();
            lblSuppliersCount.Text = supControl.getSuppliersCount().ToString();
            lblBooksCount.Text = bControl.getBooksCount().ToString();

        }

        
    }
}
