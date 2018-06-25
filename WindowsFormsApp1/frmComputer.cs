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
    public partial class frmComputer : Form
    {
        protected clsAllComputers _Computers;
        public frmComputer()
        {
            InitializeComponent();
        }

        public void SetDetails(clsAllComputers prComputers)
        {
            _Computers = prComputers;
            updateForm();
            ShowDialog();
        }

        private async void btnConfirm_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                pushData();
                if (txtName.Enabled)
                    MessageBox.Show(await ServiceClient.InsertComputersAsync(_Computers));
                else
                    MessageBox.Show(await ServiceClient.UpdateComputersAsync(_Computers));
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected virtual bool isValid()
        {
            return true;
        }

        protected virtual void updateForm()
        {
            txtName.Text = _Computers.Name;
            txtPrice.Text = _Computers.Price.ToString();
            txtLModified.Text = _Computers.LastModified.ToShortTimeString();
            //txtType.Text = _Computers.Type.ToString();
            txtQuantity.Text = _Computers.Quantity.ToString();
            txtRam.Text = _Computers.Ram;
            txtHDD.Text = _Computers.HDD;
            txtGraphics.Text = _Computers.Graphics;
            txtName.Enabled = string.IsNullOrEmpty(_Computers.Name);
        }

        protected virtual void pushData()
        {
            _Computers.Name = txtName.Text;
            _Computers.Price = decimal.Parse(txtPrice.Text);
            _Computers.LastModified = DateTime.Parse(txtLModified.Text);
            //_Computers.Type = char.Parse(txtType.Text);
            _Computers.Quantity = int.Parse(txtQuantity.Text);
            _Computers.Ram = txtRam.Text;
            _Computers.HDD = txtHDD.Text;
            _Computers.Graphics = txtGraphics.Text;


        }

        public delegate void LoadComputerFormDelegate(clsAllComputers prComputers);

        public static Dictionary<char, Delegate> _ComputersForm = new Dictionary<char, Delegate>
        {
            {'D', new LoadComputerFormDelegate(frmDesktop.Run) },
            {'L', new LoadComputerFormDelegate(frmLaptop.Run) }
        };

        public static void DispatchComputerForm(clsAllComputers prComputers)
        {
            _ComputersForm[prComputers.Type].DynamicInvoke(prComputers);
        }
    }
}
