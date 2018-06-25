using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UniversalComputer
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class pgOrder : Page
    {
        private clsOrder _Order;
        private clsAllComputers _Computers;
        public pgOrder()
        {
            this.InitializeComponent();
        }

        private void UpdatePage(clsOrder prOrder, clsAllComputers prComputers)
        {
            _Computers = prComputers;
            _Order = prOrder;

            txtCustomerName.Text = _Order.CustomerName;
            txtCustomerPhone.Text = _Order.CustomerPhone;
            txtCustomerAddress.Text = _Order.CustomerAddress;
            txtComputerName.Text = _Computers.ComputerID.ToString();
            txtQuantity.Text = _Order.OrderQuantity.ToString();
            txtPrice.Text = _Computers.Price.ToString();
            txtDate.Text = _Order.OrderDateTime.ToString();
        }

        private void PushData()
        {
            _Order.CustomerName = txtCustomerName.Text;
            _Order.CustomerPhone = txtCustomerPhone.Text;
            _Order.CustomerAddress = txtCustomerAddress.Text;
            _Order.ComputerID = int.Parse(txtComputerName.Text);
            _Order.OrderQuantity = int.Parse(txtQuantity.Text);
            _Order.OrderDateTime = DateTime.Parse(txtDate.Text);
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }

        private async void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            PushData();
            if (txtCustomerName.IsEnabled)
                await ServiceClient.InsertOrderAsync(_Order);
            else
                Frame.GoBack();
        }
    }
}
