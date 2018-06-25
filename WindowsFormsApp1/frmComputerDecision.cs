using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerSalesWinForm
{
    public partial class frmComputerDecision : Form
    {
        private string _Answer;

        public frmComputerDecision(string message)
        {
            InitializeComponent();
            lblMessage.Text = message;
            txtDecision.Focus();
            ShowDialog();
        }

        private void btnL_Click(object sender, EventArgs e)
        {

        }

        private void txtDecision_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            _Answer = txtDecision.Text;
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public string Answer
        {
            get { return _Answer; }
            //set { _Answer = value; }
        }
    }
}
