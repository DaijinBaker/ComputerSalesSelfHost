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
    public partial class frmBrand : Form
    {
        private clsBrand _Brand; //private class variable

        private static Dictionary<string, frmBrand> _BrandFormList = new Dictionary<string, frmBrand>(); //private dictionary

        public frmBrand()
        {
            InitializeComponent();
        }

        public static void Run(string prBrandName)
        {
            frmBrand lcBrandForm; //local form variable
            //if the parameter is null or empty run the form as a new form and new class
            //otherwise get the values associated with the parameter and display the information in the form
            if (string.IsNullOrEmpty(prBrandName) || !_BrandFormList.TryGetValue(prBrandName, out lcBrandForm))
            {
                lcBrandForm = new frmBrand();
                if (string.IsNullOrEmpty(prBrandName)) lcBrandForm.SetDetails(new clsBrand());
                else
                {
                    _BrandFormList.Add(prBrandName, lcBrandForm);
                    lcBrandForm.refreshFormFromDB(prBrandName);
                }
            }
            else
            {
                lcBrandForm.Show();
                lcBrandForm.Activate();
            }
        }

        private async void refreshFormFromDB(string prBrandName)
        {
            //setting the details of the form 
            SetDetails(await ServiceClient.GetBrandAsync(prBrandName));
        }

        private void updateTitle(string prComputerName)
        {
            if (!string.IsNullOrEmpty(prComputerName))
                Text = ("Brand Details - " + prComputerName);
        }

        private void UpdateDisplay()
        {
            //Updating the listbox with the computers associated with the selected brand
            lstComputers.DataSource = null;
            if (_Brand.ComputerList != null)
                lstComputers.DataSource = _Brand.ComputerList;
        }

        public void UpdateForm()
        {
            //setting the text fields to the brand information
            txtName.Text = _Brand.Name;
            txtType.Text = _Brand.Type;
        }

        public void SetDetails(clsBrand prBrand)
        {
            _Brand = prBrand;
            txtName.Enabled = string.IsNullOrEmpty(_Brand.Name); //making the textfield un editable 
            UpdateForm(); //calling method
            UpdateDisplay(); //calling method
            frmMain.Instance.ComputerNameChanged += new frmMain.Notify(updateTitle);
            Show();
        }

        private void pushData()
        {
            //pushing any changes
            _Brand.Name = txtName.Text;
            _Brand.Type = txtType.Text;
        }

        private Boolean isValid()
        {
            return true;
        }
       
        //Buttons below//
        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmBrand_Load(object sender, EventArgs e)
        {

        }

        private void txtType_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstComputers_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                //calling frmcoputers method for selecting the correct form to show
                frmComputer.DispatchComputerForm(lstComputers.SelectedValue as clsAllComputers);
                UpdateDisplay(); //calling local method
                frmMain.Instance.UpdateDisplay(); //updating form Main
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string lcReply = new frmComputerDecision(clsAllComputers.FACTORY_PROMPT).Answer;
                if (!string.IsNullOrEmpty(lcReply))
                {
                    clsAllComputers lcComputer = clsAllComputers.NewComputer(lcReply[0]);
                    if (lcComputer != null)
                    {
                        if (txtName.Enabled)
                        {
                            pushData();
                            await ServiceClient.InsertBrandAsync(_Brand);
                            txtName.Enabled = false;
                        }
                        lcComputer.BrandName = _Brand.Name;
                        frmComputer.DispatchComputerForm(lcComputer);
                        if (!string.IsNullOrEmpty(lcComputer.Name))
                        {
                            refreshFormFromDB(_Brand.Name);
                            frmMain.Instance.UpdateDisplay();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                frmComputer.DispatchComputerForm(lstComputers.SelectedValue as clsAllComputers);
                UpdateDisplay();
                frmMain.Instance.UpdateDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            int lcIndex = lstComputers.SelectedIndex;

            if (lcIndex >= 0 && MessageBox.Show("Are you sure?", "Deleting computer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(await ServiceClient.DeleteComputerAsync(lstComputers.SelectedItem as clsAllComputers));
                refreshFormFromDB(_Brand.Name);
                frmMain.Instance.UpdateDisplay();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
