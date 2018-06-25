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
    public sealed partial class pgBrand : Page
    {
        private clsBrand _Brand;
        public pgBrand()
        {
            this.InitializeComponent();
        }

        private void UpdateDisplay()
        {
            updateForm();
            txtBrandName.IsEnabled = string.IsNullOrEmpty(_Brand.Name);
            txtType.IsEnabled = string.IsNullOrEmpty(_Brand.Type);

            lstComputers.ItemsSource = null;
            if (_Brand.ComputerList != null)
                lstComputers.ItemsSource = _Brand.ComputerList;
        }

        private void updateForm()
        {
            txtBrandName.Text = _Brand.Name;
            txtType.Text = _Brand.Type;
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (e.Parameter != null)
            {
                string lcBrandName = e.Parameter.ToString();
                _Brand = await ServiceClient.GetBrandAsync(lcBrandName);
                UpdateDisplay();
            }
            else
                _Brand = new clsBrand();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }

        private void OpenComputer(clsAllComputers prComputer)
        {
            if (prComputer != null)
                Frame.Navigate(typeof(pgComputer), prComputer);
        }

        private void btnSelect_Click(object sender, RoutedEventArgs e)
        {
            OpenComputer(lstComputers.SelectedItem as clsAllComputers);
        }

        private void lstComputers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
