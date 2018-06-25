using ComputerSalesWinform;
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
    public sealed partial class frmMain : Form
    {
        //Singleton pattern
        private static readonly frmMain _Instance = new frmMain();

        public delegate void Notify(string prComputerName);

        public event Notify ComputerNameChanged;

        private frmMain()
        {
            InitializeComponent();
        }

        //public declaration of the singleton instance
        public static frmMain Instance
        {
            get { return frmMain._Instance; }
        }

        public async void UpdateDisplay()
        {
            try //try the next piece of code
            {
                lstBrand.DataSource = null; //lstbrand datasource equals null
                lstBrand.DataSource = await ServiceClient.GetBrandNamesAsync(); //getting and setting the datasource of the listbox
                                                                                //using the service client to get the data from the controller
            }
            catch (Exception ex) //catch the error and display a message
            {
                MessageBox.Show(ex.Message, "Error Loading"); //display this message
            }
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            frmOrderList OpenForm = new frmOrderList(); //creating a instance of frmOrderList

            OpenForm.Show(); //Opening the frm when this button is clicked
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close(); //closing the application
        }

        //had to change the behaviour of the listbox and set it to double click in the designer code
        private void lstBrand_DoubleClick(object sender, EventArgs e)
        {
            string lcKey; //local string variable

            lcKey = Convert.ToString(lstBrand.SelectedItem);
            if (lcKey != null)
                try
                {
                    frmBrand.Run(lstBrand.SelectedItem as string); //run the form is the selected item has been double clicked
                    Show();//display the form
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "This should never occur");
                }
        }

        private void frmMain_Load_1(object sender, EventArgs e)
        {
            UpdateDisplay(); //calling local method
        }
    }
}
