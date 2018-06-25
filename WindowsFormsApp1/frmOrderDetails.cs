using ComputerSalesWinForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerSalesWinform
{
    public partial class frmOrderDetails : Form
    {
        private static readonly frmOrderDetails Instance = new frmOrderDetails();

        private clsOrder _Order;

        public frmOrderDetails()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public static void Run(clsOrder prOrder)
        {
            Instance.SetDetails(prOrder);
        }

        private void SetDetails(clsOrder prOrder)
        {
            _Order = prOrder;
            UpdateForm();
        }

        private void UpdateForm()
        {
            txtCustomerName.Text = _Order.CustomerName;
            txtCustomerPhone.Text = _Order.CustomerPhone;
            txtCustomerAddress.Text = _Order.CustomerAddress;
            txtOrderNumber.Text = _Order.OrderID.ToString();
            txtPriceAtOrder.Text = _Order.PriceAtOrder.ToString();
            txtOrderDateTime.Text = _Order.OrderDateTime.ToString();
            txtQuantity.Text = _Order.OrderQuantity.ToString();
            txtComputerID.Text = _Order.ComputerID.ToString();
        }
    }
}
