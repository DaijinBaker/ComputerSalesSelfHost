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

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace UniversalComputer
{
    public sealed partial class UserControlDesktop : UserControl, IComputerControl
    {
        public UserControlDesktop()
        {
            this.InitializeComponent();
        }

        public void PushData(clsAllComputers _Computers)
        {
            _Computers.TowerType = txtTowerType.Text;
        }

        public void UpdateControl(clsAllComputers _Computers)
        {
            txtTowerType.Text = _Computers.TowerType;

            txtTowerType.IsEnabled = string.IsNullOrEmpty(_Computers.TowerType);
        }

        private void txtTowerType_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
