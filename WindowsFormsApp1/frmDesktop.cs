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
    public partial class frmDesktop : frmComputer
    {
        private static readonly frmDesktop Instance = new frmDesktop();

        public frmDesktop()
        {
            InitializeComponent();
        }

        public static void Run (clsAllComputers prDesktops)
        {
            Instance.SetDetails(prDesktops);
        }

        protected override void updateForm()
        {
            base.updateForm();
            txtTowerType.Text = _Computers.TowerType;
        }

        protected override void pushData()
        {
            base.pushData();
            _Computers.TowerType = txtTowerType.Text;
        }

        private void txtType_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
