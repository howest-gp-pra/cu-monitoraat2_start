using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pra.MonitoraatJH2.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        bool isNewAddress;


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }
        private void DefaultView()
        {
            grpAddresses.IsEnabled = false;
            grpPersons.IsEnabled = true;
            grpDetails.IsEnabled = true;
            btnSaveAddress.Visibility = Visibility.Hidden;
            btnCancelAddress.Visibility = Visibility.Hidden;
        }
        private void AddressView()
        {
            grpAddresses.IsEnabled = true;
            grpPersons.IsEnabled = false;
            grpDetails.IsEnabled = false;
            btnSaveAddress.Visibility = Visibility.Visible;
            btnCancelAddress.Visibility = Visibility.Visible;
        }
        private void PopulatePersons(Type type = null)
        {
            // VOORBEELD HOE JE EEN COMBO OF LISTBOX KUNT VULLEN MET OBJECTEN

        }
        private void PopulateTypes()
        {
            // VOORBEELD HOE JE EEN COMBO OF LISTBOX KAN VULLEN MET TYPES
        }
        private void PopulateAddressTypes()
        {
            // VOORBEELD HOE JE EEN COMBO OF LISTBOX KAN VULLEN MET ENUM WAARDEN

        }
        private void ClearControls()
        {
            tblInfo.Text = "";
            lblName.Content = "";
            lstAddresses.ItemsSource = null;
            ClearAddressControls();
        }
        private void ClearAddressControls()
        {
            cmbAddressTypes.SelectedIndex = -1;
            txtStreet.Text = "";
            txtHouseNumber.Text = "";
            txtPostalCode.Text = "";
            txtCity.Text = "";
            txtCountry.Text = "";
        }
        private void CmbFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbFilter.SelectedItem != null)
            {
            }
        }

        private void BtnClearFilter_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LstPersons_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }



        private void LstAddresses_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void BtnNewAddress_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnEditAddress_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDeleteAddress_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnSaveAddress_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnCancelAddress_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
