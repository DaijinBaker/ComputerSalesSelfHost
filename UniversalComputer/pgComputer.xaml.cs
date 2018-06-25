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
    public sealed partial class pgComputer : Page
    {
        private clsAllComputers _Computers;

        public pgComputer()
        {
            this.InitializeComponent();
            _ComputerContent = new Dictionary<char, Delegate>
            {
                {'D', new LoadComputerControlDelegate(RunDesktop) },
                {'L', new LoadComputerControlDelegate(RunLaptop) }
            };
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }

        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OrderComputer()
        {

        }
        private void UpdatePage(clsAllComputers prComputers)
        {
            _Computers = prComputers;
            txtComputerName.Text = _Computers.Name;
            txtPrice.Text = _Computers.Price.ToString();
            txtLastModified.Text = _Computers.LastModified.ToString("d");
            txtQuantity.Text = _Computers.Quantity.ToString();
            txtRam.Text = _Computers.Ram;
            txtHDD.Text = _Computers.HDD;
            txtGraphics.Text = _Computers.Graphics;

            txtComputerName.IsEnabled = string.IsNullOrEmpty(_Computers.Name);
            txtPrice.IsEnabled = string.IsNullOrEmpty(_Computers.Price.ToString());
            txtLastModified.IsEnabled = string.IsNullOrEmpty(_Computers.LastModified.ToString());
            txtQuantity.IsEnabled = string.IsNullOrEmpty(_Computers.Quantity.ToString());
            txtRam.IsEnabled = string.IsNullOrEmpty(_Computers.Ram);
            txtHDD.IsEnabled = string.IsNullOrEmpty(_Computers.HDD);
            txtGraphics.IsEnabled = string.IsNullOrEmpty(_Computers.Graphics);

            (ComputerSpecs.Content as IComputerControl).UpdateControl(prComputers);
        }

        private void RunDesktop(clsAllComputers prComputers)
        {
            ComputerSpecs.Content = new UserControlDesktop();
        }

        private void RunLaptop(clsAllComputers prComputers)
        {
            ComputerSpecs.Content = new UserControlLaptop();
        }

        private delegate void LoadComputerControlDelegate(clsAllComputers prComputers);
        private Dictionary<char, Delegate> _ComputerContent;
        private void DispatchComputerContent(clsAllComputers prComputer)
        {
            _ComputerContent[prComputer.Type].DynamicInvoke(prComputer);
            UpdatePage(prComputer);
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            DispatchComputerContent(e.Parameter as clsAllComputers);
        }
    }
}
