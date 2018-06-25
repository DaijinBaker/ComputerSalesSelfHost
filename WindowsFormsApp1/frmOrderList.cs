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
    public partial class frmOrderList : Form
    {
        public frmOrderList()
        {
            InitializeComponent();
        }

        private void lstOrder_DoubleClick(object sender, EventArgs e)
        {
           
            try
             {
                frmOrderDetails.Run(lstOrder.SelectedValue as clsOrder);
            }
            catch (Exception ex)
            {
                    MessageBox.Show(ex.Message, "Error Loading");
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
        }


        private void frmOrderList_Load(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        public async void UpdateDisplay()
        {
            try
            {
                lstOrder.DataSource = null;
                lstOrder.DataSource = await ServiceClient.GetOrderList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Loading");
            }
        }
    }
}
