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
    public partial class frmLaptop : frmComputer
    {
        private static readonly frmLaptop Instance = new frmLaptop();

        public frmLaptop()
        {
            InitializeComponent();
        }

        public static void Run(clsAllComputers prLaptops)
        {
            Instance.SetDetails(prLaptops);
        }

        protected override void updateForm()
        {
            base.updateForm();
            txtColor.Text = _Computers.Color;
        }

        protected override void pushData()
        {
            base.pushData();
            _Computers.Color = txtColor.Text;
        }

        private void txtType_TextChanged(object sender, EventArgs e)
        {

        }
    }
}